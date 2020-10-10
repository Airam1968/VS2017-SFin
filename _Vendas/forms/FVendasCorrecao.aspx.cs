using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FVendasCorrecao : System.Web.UI.Page
{
    DataSet dsunidades;
    DataSet dsvendas;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "VENDAS";

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = SreDblib.TemPermissao("001.004.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.004.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.004.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.004.004.000", (String)Session["CodUsuario"]);
        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        edselecionados.Text = "(0) Contratos Selecionados";
        //
        btprocessa.Enabled = lAltera;
        if (!lAltera)
        {
            btprocessa.Image.ToolTip = Msg_acesso;
            edfeedback.Text = Msg_acesso;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //Limpa Cache
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetExpires(DateTime.Now);
        Response.Cache.SetNoServerCaching();
        Response.Cache.SetNoStore();
        //Fim Limpa Cache

        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Response.Redirect("~\\LoginTimeOut.aspx");
        }

        if (!Page.IsPostBack)
        {
            //Combo Produto
            cbproduto.Items.Clear();
            uProduto.MontaComboProduto(cbproduto, true);
            //
            dtcorrecao.Value = DateTime.Now;
            //
            edfeedback.Text = "Selecionados abaixo para efetuar a Correção!";
            //
        }

    }


    protected void cbproduto_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        if (cbproduto.Text != string.Empty)
        {
            //Combo Grupo
            cbgrupo.Items.Clear();
            uProduto.MontaComboGrupo(cbgrupo, Convert.ToString(cbproduto.Value).Trim(), true);
            Label2.Visible = true;
            cbgrupo.Visible = true;
        }
        else
        {
            Label2.Visible = false;
            cbgrupo.Visible = false;
        }

    }

    protected void cbgrupo_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        if (cbproduto.Text != string.Empty)
        {
            if (cbgrupo.Text != string.Empty)
            {
                //Combo Unidades
                cbgrupounidades.Items.Clear();
                uProduto.MontaComboUnidades(cbgrupounidades, Convert.ToString(cbproduto.Value).Trim(), Convert.ToString(cbgrupo.Value).Trim(), true);
                if (cbgrupounidades.Items.Count == 0)
                {
                    btprocessa.Enabled = false;
                    //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não Há Unidades Disponíveis!');", true);
                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                    "toastr.info('Não Há Unidades Disponíveis!', 'Atenção!')", true);
                }
                Label7.Visible = true;
                cbgrupounidades.Visible = true;
            }
            else
            {
                Label2.Visible = true;
                cbgrupo.Visible = true;
                Label7.Visible = false;
                cbgrupounidades.Visible = false;
            }
        }

    }

    protected void cbgrupounidades_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        if (cbproduto.Text != string.Empty)
        {
            if (cbgrupo.Text != string.Empty)
            {
                if (cbgrupounidades.Text != string.Empty)
                {
                    //Cliente
                    Label8.Visible = true;
                    edcliente.Visible = true;
                    Label4.Visible = true;
                    edfeedback.Visible = true;
                    string grupounidades = cbgrupounidades.Text;
                    string parte = grupounidades.Substring(grupounidades.IndexOf("-") + 1).Trim();
                    if (parte != "0")
                    {
                        rbmeiolote.Enabled = true;
                        rbmeiolote.Visible = true;
                    }
                    else
                    {
                        rbmeiolote.Enabled = false;
                        rbmeiolote.Visible = false;
                    }
                    string IDCliente = uUnidade.PegaIDCliente(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte, "1");
                    edcliente.Text = Srelib.QStr0(IDCliente.Trim(), 5) + " - " + uContato.PegaNomeID(IDCliente);
                    edclienteperiodicidade.Text = uVendas.PegaIndexador(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte) + " - " +
                                                  uVendas.PegaPeriodicidade(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte, "1");
                    //Feedback
                    if (uVendas.PegaIndexador(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), "0") != "NENHUM")
                    {
                        edfeedback.Text = "Clique no Botão Processa para efetuar a Correção!";
                        btprocessa.Enabled = true;
                    }
                    else
                    {
                        edfeedback.Text = "Financiamento com indexador NENHUM, não é possível efetuar a Correção!";
                        btprocessa.Enabled = false;
                    }

                }
                else
                {
                    //Cliente
                    Label8.Visible = false;
                    edcliente.Visible = false;
                    //Feedback
                    Label4.Visible = false;
                    edfeedback.Visible = false;
                }
            }
        }
    }


    protected void bthelp_Click(object sender, EventArgs e)
    {
        //
        //if (Popuphelp.IsCallback)
        {
            // Intentionally pauses server-side processing, 
            // to demonstrate the Loading Panel functionality.
            Thread.Sleep(1000);
        }
    }

    protected void btprocessa_Click(object sender, EventArgs e)
    {
        Boolean lOk = true;
        string produto = "";
        string grupo = "";
        string grupounidade = "";
        string grupounidadeparte = "";
        string grupounidademeiolote = "";
        //
        string periodicidade_correcao = rbperiodicidade.SelectedIndex.ToString();
        string periodicidade = "";
        if (periodicidade_correcao == "0")
        {
            periodicidade = "";
        }
        else
        {
            if (periodicidade_correcao == "1")
            {
                periodicidade = "Mensal";
            }
            else
            {
                periodicidade = "Anual";
            }
        }
        //
        string produto_corrente = "";
        string grupo_corrente = "";
        string grupounidade_corrente = "";
        string grupounidadeparte_corrente = "";
        string meiolote_corrente = "";
        string indexador_corrente = "";
        string periodicidade_corrente = "";
        DateTime dtbase_corrente = Convert.ToDateTime("01/01/1900");
        DateTime dtperiodo_fim = Convert.ToDateTime(dtcorrecao.Date.ToString().Substring(0, 10));
        //
        Boolean tabela_price = false;
        Double juros_price = 0;
        Int16 total_parcelas_price = 0;
        Boolean indexadorejuros = false;
        string indexador_juros = "NENHUM";
        //
        //Criticas
        if (lOk)
        {
            //Check da Unidade
            //Produto
            if (cbproduto.Text != string.Empty)
            {
                if (cbgrupo.Text != string.Empty)
                {
                    if (cbgrupounidades.Text != string.Empty)
                    {
                        produto = cbproduto.Value.ToString();
                        grupo = cbgrupo.Value.ToString();
                        grupounidade = cbgrupounidades.Value.ToString();
                        grupounidadeparte = cbgrupounidades.Text.ToString();
                        grupounidadeparte = grupounidadeparte.Substring(grupounidadeparte.IndexOf("-") + 1).Trim();
                        if (grupounidadeparte != "0")
                        {
                            //ou 1 ou 2
                            grupounidademeiolote = (rbmeiolote.SelectedIndex + 1).ToString();
                        }

                    }
                    else
                    {
                        produto = cbproduto.Value.ToString();
                        grupo = cbgrupo.Value.ToString();
                    }
                }
                else
                {
                    produto = cbproduto.Value.ToString();
                }
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione um Produto!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Selecione um Produto!', 'Atenção!')", true);
            }
            //Fim Check da Unidade
        }
        //
        //Processa Correção Monetária
        if (lOk)
        {
            //Unidades Selecionadas
            if (cbgrupounidades.Text.Trim() == "")
            {
                //dsunidades = uVendas.PegaDadosVendaFinanciamentos(produto, grupo, grupounidade, grupounidadeparte);
                periodicidade_corrente = uVendas.PegaPeriodicidade(produto,
                                                                   grupo,
                                                                   grupounidade,
                                                                   grupounidadeparte,
                                                                   grupounidademeiolote);
                //
                dsunidades = uVendas.PegaDadosVendas(produto,
                                                     grupo,
                                                     grupounidade,
                                                     grupounidadeparte,
                                                     periodicidade,
                                                     "0");
            }
            else
            {
                if (cbgrupounidades.Text.Trim() == "0")
                {
                    //dsunidades = uVendas.PegaDadosVendaFinanciamentos(produto, grupo, grupounidade, grupounidadeparte);
                    periodicidade_corrente = uVendas.PegaPeriodicidade(produto,
                                                                       grupo,
                                                                       grupounidade,
                                                                       grupounidadeparte,
                                                                       grupounidademeiolote);
                    //
                    dsunidades = uVendas.PegaDadosVendas(produto,
                                                         grupo,
                                                         grupounidade,
                                                         grupounidadeparte,
                                                         periodicidade,
                                                         "0");
                }
                else
                {
                    //dsunidades = uVendas.PegaDadosVendaFinanciamentos(produto, grupo, grupounidade, grupounidademeiolote);
                    periodicidade_corrente = uVendas.PegaPeriodicidade(produto,
                                                                       grupo,
                                                                       grupounidade,
                                                                       grupounidadeparte,
                                                                       grupounidademeiolote);
                    //
                    dsunidades = uVendas.PegaDadosVendas(produto,
                                                         grupo,
                                                         grupounidade,
                                                         grupounidademeiolote,
                                                         periodicidade,
                                                         "0");
                }
            }
            //
            if (dsunidades.Tables[0].Rows.Count != 0)
            {
                produto_corrente = "";
                grupo_corrente = "";
                grupounidade_corrente = "";
                grupounidadeparte_corrente = "";
                meiolote_corrente = "";
                indexador_corrente = "";
                periodicidade_corrente = "";
                dtbase_corrente = Convert.ToDateTime("01/01/1900");
                dtperiodo_fim = Convert.ToDateTime(dtcorrecao.Date.ToString().Substring(0, 10));
                //
                tabela_price = false;
                juros_price = 0;
                total_parcelas_price = 0;
                indexadorejuros = false;
                indexador_juros = "NENHUM";
                //
                //Loop de Unidades
                for (int i = 0; i < dsunidades.Tables[0].Rows.Count; i++)
                {
                    produto_corrente = dsunidades.Tables[0].Rows[i]["produto"].ToString();
                    grupo_corrente = dsunidades.Tables[0].Rows[i]["grupo"].ToString();
                    grupounidade_corrente = dsunidades.Tables[0].Rows[i]["unidade"].ToString();
                    grupounidadeparte_corrente = dsunidades.Tables[0].Rows[i]["parte"].ToString();
                    meiolote_corrente = dsunidades.Tables[0].Rows[i]["parte"].ToString();
                    indexador_corrente = dsunidades.Tables[0].Rows[i]["indexador"].ToString();
                    periodicidade_corrente = dsunidades.Tables[0].Rows[i]["periodicidade_correcao"].ToString();
                    dtbase_corrente = Convert.ToDateTime(dsunidades.Tables[0].Rows[i]["ultima_correcao"].ToString().Substring(0, 10));
                    // Dados Correção Juros + Indexador (Castor 2018)
                    tabela_price = Convert.ToBoolean(dsunidades.Tables[0].Rows[i]["tabela_price"]);
                    juros_price = Convert.ToDouble(dsunidades.Tables[0].Rows[i]["juros_price"]);
                    total_parcelas_price = Convert.ToInt16(dsunidades.Tables[0].Rows[i]["total_parcelas_price"]);
                    indexadorejuros = Convert.ToBoolean(dsunidades.Tables[0].Rows[i]["indexadorejuros"]);
                    indexador_juros = dsunidades.Tables[0].Rows[i]["indexador_juros"].ToString();
                    //
                    //Correção
                    if (tabela_price)
                    {
                        //Tabela Price
                        if (periodicidade_corrente == "MENSAL")
                        {
                            uParcelas.CorrecaoMensalTP(produto_corrente,
                                                       grupo_corrente,
                                                       grupounidade_corrente,
                                                       grupounidadeparte_corrente,
                                                       meiolote_corrente,
                                                       indexador_corrente,
                                                       indexador_juros,
                                                       dtbase_corrente,
                                                       dtperiodo_fim);
                            //
                        }
                        if (periodicidade_corrente == "ANUAL")
                        {
                            //Data Base
                            if (dtbase_corrente < dtperiodo_fim.AddYears(-1))
                            {
                                //Correção Anual com tabela price
                                uParcelas.CorrecaoAnualTP(produto_corrente,
                                                          grupo_corrente,
                                                          grupounidade_corrente,
                                                          grupounidadeparte_corrente,
                                                          indexador_corrente,
                                                          indexador_juros,
                                                          dtbase_corrente,
                                                          dtperiodo_fim);
                                //
                            }
                            else
                            {
                                //Correção Mensal com tabela price usando Indexador Juros
                                uParcelas.CorrecaoMensalTP(produto_corrente,
                                                           grupo_corrente,
                                                           grupounidade_corrente,
                                                           grupounidadeparte_corrente,
                                                           meiolote_corrente,
                                                           indexador_juros,
                                                           "NENHUM",
                                                           dtbase_corrente,
                                                           dtperiodo_fim);
                                //
                            }
                        }
                    }
                    else
                    {
                        //Sem Tabela Price
                        if (periodicidade_corrente == "MENSAL")
                        {
                            uParcelas.CorrecaoMensal(produto_corrente,
                                                     grupo_corrente,
                                                     grupounidade_corrente,
                                                     grupounidadeparte_corrente,
                                                     meiolote_corrente,
                                                     indexador_corrente,
                                                     dtbase_corrente,
                                                     dtperiodo_fim);
                            //
                        }
                        if (periodicidade_corrente == "ANUAL")
                        {
                            //Data Base Menor que Data Final menos 1 ano
                            if (dtbase_corrente < dtperiodo_fim.AddYears(-1))
                            {
                                //
                                uParcelas.CorrecaoAnual(produto_corrente,
                                                        grupo_corrente,
                                                        grupounidade_corrente,
                                                        grupounidadeparte_corrente,
                                                        meiolote_corrente,
                                                        indexador_corrente,
                                                        dtbase_corrente,
                                                        dtperiodo_fim);
                                //
                            }
                        }
                    }
                }
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não Há Financiamentos á Corrigir!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Não Há Financiamentos á Corrigir!', 'Atenção!')", true);
            }
        }
        //Fim Processa Correção Monetária
        if (lOk)
        {
            //
            // CRIA LOG ===================================================================================================================================================

            fwObs_Log = "CORREÇÃO MONETÁRIA : " + produto;
            if (cbgrupo.Text != null)
            {
                fwObs_Log = fwObs_Log + "/" + cbgrupo.Text;
            }
            if (cbgrupounidades.Text != null)
            {
                fwObs_Log = fwObs_Log + "/" + cbgrupounidades.Text;
            }
            if (cbgrupounidades.Text != null)
            {
                fwObs_Log = fwObs_Log + "/" + cbgrupounidades.Text;
            }
            if (rbmeiolote.Visible == true)
            {
                fwObs_Log = fwObs_Log + "/" + (rbmeiolote.SelectedIndex + 1).ToString();
            }
            fwObs_Log = fwObs_Log + " Até " + dtcorrecao.Text;
            //
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ),
                                         new SqlParameter("@tabela"   , fWtabela                              ),
                                         new SqlParameter("@operacao" , "VENDAS"                              ),
                                         new SqlParameter("@obs"      , "CORREÇÃO MONETÁRIA UNIDADE"          ),
                                         new SqlParameter("@acao"     , fwObs_Log                             ) };
            uLog.MakeLog(param_log);
            // FIM CRIA LOG ===============================================================================================================================================

        }
        //Fim Processa Correção Monetária
        //
        btprocessa.Enabled = false;
        AtualizaGrid();
        //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Processamento Concluído!');", true);
        ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
        "toastr.success('Processamento Concluído!', 'Atenção!')", true);
    }

    protected void btcarrega_Click(object sender, EventArgs e)
    {
        //
        AtualizaGrid();
    }

    private void AtualizaGrid()
    {
        // 
        string grupounidades = cbgrupounidades.Text.Trim();
        string periodicidade_correcao = rbperiodicidade.SelectedIndex.ToString();
        string periodicidade = "";
        if (periodicidade_correcao == "0")
        {
            periodicidade = "";
        }
        else
        {
            if (periodicidade_correcao == "1")
            {
                periodicidade = "Mensal";
            }
            else
            {
                periodicidade = "Anual";
            }
        }
        //
        if (cbgrupo.Text.Trim() != "")
        {
            if (grupounidades != "")
            {
                string parte = grupounidades.Substring(grupounidades.IndexOf("-") + 1).Trim();
                if (parte == "0")
                {
                    dsvendas = uVendas.PegaDadosVendas(cbproduto.Value.ToString().Trim(),
                                                       cbgrupo.Value.ToString().Trim(),
                                                       cbgrupounidades.Value.ToString().Trim(),
                                                       parte,
                                                       periodicidade,
                                                       "0");
                }
                else
                {
                    dsvendas = uVendas.PegaDadosVendas(cbproduto.Value.ToString().Trim(),
                                                       cbgrupo.Value.ToString().Trim(),
                                                       cbgrupounidades.Value.ToString().Trim(),
                                                       (rbmeiolote.SelectedIndex + 1).ToString(),
                                                       periodicidade,
                                                       "0");
                }
            }
            else
            {
                dsvendas = uVendas.PegaDadosVendas(cbproduto.Value.ToString().Trim(),
                                                   cbgrupo.Value.ToString().Trim(),
                                                   "",
                                                   "",
                                                   periodicidade,
                                                   "0");
            }
        }
        else
        {
            dsvendas = uVendas.PegaDadosVendas(cbproduto.Value.ToString().Trim(),
                                               "",
                                               "",
                                               "",
                                               periodicidade,
                                               "0");
        }
        edselecionados.Text = "(" + dsvendas.Tables[0].Rows.Count.ToString() + ") Contratos Selecionados";
        //
        GridListagem.DataSource = dsvendas;
        GridListagem.KeyFieldName = "ID";
        GridListagem.DataBind();
        btprocessa.Enabled = true;
        //

    }
    protected void rbmeiolote_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        //Cliente
        string grupounidades = cbgrupounidades.Text;
        string parte = grupounidades.Substring(grupounidades.IndexOf("-") + 1).Trim();
        string meiolote = "1";
        if (parte != "0")
        {
            if (rbmeiolote.SelectedIndex == 0)
            {
                meiolote = "1";
            }
            else
            {
                meiolote = "2";
            }
        }
        else
        {
            rbmeiolote.Enabled = false;
            rbmeiolote.Visible = false;
        }
        //
        string IDCliente = uUnidade.PegaIDCliente(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte, meiolote);
        edcliente.Text = Srelib.QStr0(IDCliente.Trim(), 5) + " - " + uContato.PegaNomeID(IDCliente);
        Label8.Visible = true;
        edcliente.Visible = true;
        edclienteperiodicidade.Visible = true;
        //
    }

}

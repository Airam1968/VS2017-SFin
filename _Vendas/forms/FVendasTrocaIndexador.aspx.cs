using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FVendasTrocaIndexador : System.Web.UI.Page
{
    DataSet dsunidade;
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
        //
        btprocessa.Enabled = lAltera;
        if (!lAltera)
            btprocessa.Image.ToolTip = Msg_acesso;
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
        }

    }


    protected void cbproduto_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        if (cbproduto.Text != string.Empty)
        {
            //Combo Grupo
            //string tipo = "";
            cbgrupo.Items.Clear();
            //tipo = uProduto.PegaTipo(Convert.ToInt32(cbproduto.Value));
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
                    Label5.Visible = true;
                    edindexador.Visible = true;
                    Label9.Visible = true;
                    edperiodicidade.Visible = true;
                    Label6.Visible = true;
                    cbindexador.Visible = true;
                    Label4.Visible = true;
                    edfeedback.Visible = true;
                    //
                    string IndexadorCliente = "";
                    string PeriodicidadeCliente = "";
                    IndexadorCliente = uVendas.PegaIndexador(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), "0");
                    PeriodicidadeCliente = uVendas.PegaPeriodicidade(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), "0", "1");
                    edindexador.Text = IndexadorCliente;
                    edperiodicidade.Text = PeriodicidadeCliente;
                    //
                    //Combo Unidades
                    cbindexador.Items.Clear();
                    uIndexadores.MontaComboIndexadores(cbindexador, true);
                    //
                    cbindexador.Text = IndexadorCliente;
                    //
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
                    //
                    Label12.Visible = true;
                    eddatabaseatual.Visible = true;
                    eddatabaseatual.Text = uVendas.PegaDataBase(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), "0").ToString().Substring(0, 10);
                    //
                    cbindexador_SelectedIndexChanged(sender, e);
                    //
                }
                else
                {
                    //Cliente
                    Label8.Visible = false;
                    edcliente.Visible = false;
                    Label5.Visible = false;
                    edindexador.Visible = false;
                    Label9.Visible = false;
                    edperiodicidade.Visible = false;
                    Label6.Visible = false;
                    cbindexador.Visible = false;
                    Label12.Visible = false;
                    eddatabaseatual.Visible = false;

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
        string indexador = "";
        string data_base = "";
        string periodicidade = "";
        Boolean congela = false;

        if (lOk)
        {
            //Check da Unidade para Quitação
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
                        //
                        grupounidademeiolote = "1";
                        if (grupounidadeparte != "0")
                        {
                            if (rbmeiolote.SelectedIndex == 0)
                            {
                                grupounidademeiolote = "1";
                            }
                            else
                            {
                                grupounidademeiolote = "2";
                            }
                        }

                    }
                    else
                    {
                        lOk = false;
                        //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione uma Unidade!');", true);
                        ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                        "toastr.info('Selecione uma Unidade!', 'Atenção!')", true);
                    }

                }
                else
                {
                    lOk = false;
                    //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione um Grupo!');", true);
                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                    "toastr.info('Selecione um Grupo!', 'Atenção!')", true);
                }
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione um Produto!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Selecione um Produto!', 'Atenção!')", true);
            }
            //Fim Check da Unidade para Quitação
        }


        if (lOk)
        {
            if (rbperiodicidade.SelectedIndex == 0)
            {
                periodicidade = "DIARIA";
            }
            else
            {
                if (rbperiodicidade.SelectedIndex == 1)
                {
                    periodicidade = "MENSAL";
                }
                else
                {
                    periodicidade = "ANUAL";
                }
            }
        }
        //
        if (lOk)
        {
            if (dtbase.Value != null)
            {
                if (rbaplicacao.SelectedIndex == 0)
                {
                    data_base = dtbase.Value.ToString().Substring(0, 10);
                    congela = false;
                }
                else
                {
                    data_base = dtbase.Value.ToString().Substring(0, 10);
                    congela = true;
                }
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione nova Data Base!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Selecione nova Data Base!', 'Atenção!')", true);
            }
        }
        //
        if (lOk)
        {
            //Check do Indexador
            //Indexador
            if (cbindexador.Text != string.Empty)
            {
                indexador = cbindexador.Value.ToString();
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione um Indexador!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Selecione um Indexador!', 'Atenção!')", true);
            }
            //Fim Check do Indexador
        }
        if (lOk)
        {
            //
            //Processa Troca Indexador
            if (grupounidadeparte == "0")
            {
                uVendas.GravaTrocaIndexador(produto,
                                            grupo,
                                            grupounidade,
                                            grupounidadeparte,
                                            indexador,
                                            periodicidade,
                                            data_base,
                                            congela);
            }
            else
            {
                uVendas.GravaTrocaIndexador(produto,
                                            grupo,
                                            grupounidade,
                                            grupounidademeiolote,
                                            indexador,
                                            periodicidade,
                                            data_base,
                                            congela);
            }
            //Fim Processa Troca Indexador
            //
            // CRIA LOG ===================================================================================================================================================
            if (grupounidadeparte == "0")
            {
                fwObs_Log = "TROCA INDEXADOR: " + produto + "/" + grupo + "/" + grupounidade + "/" + grupounidadeparte +
                            " DE: " + edindexador.Text.Trim() + " PARA: " + indexador;
            }
            else
            {
                fwObs_Log = "TROCA INDEXADOR: " + produto + "/" + grupo + "/" + grupounidade + "/" + grupounidademeiolote +
                            " DE: " + edindexador.Text.Trim() + " PARA: " + indexador;
            }
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ), 
                                         new SqlParameter("@tabela"   , fWtabela                              ),
                                         new SqlParameter("@operacao" , "VENDAS"                              ),
                                         new SqlParameter("@obs"      , "TROCA INDEXADOR"                     ),
                                         new SqlParameter("@acao"     , fwObs_Log                             ) };
            uLog.MakeLog(param_log);
            // FIM CRIA LOG ===============================================================================================================================================
            //
            btprocessa.Enabled = false;
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Processamento Concluído!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.success('Processamento Concluído!', 'Atenção!')", true);
        }

    }

    protected void rbperiodicidade_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rbperiodicidade.SelectedIndex == 2)
        {
            rbaplicacao.Enabled = true;
        }
        else
        {
            rbaplicacao.SelectedIndex = 0;
            rbaplicacao.Enabled = false;
        }
    }


    protected void cbindexador_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        string grupounidades = cbgrupounidades.Text;
        string parte = grupounidades.Substring(grupounidades.IndexOf("-") + 1).Trim();
        dtbase.Value = uVendas.PegaDataBase(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte);
        string meiolote = "1";
        string partecorrente = "0";
        if (parte != "0")
        {
            if (rbmeiolote.SelectedIndex == 0)
            {
                meiolote = "1";
                partecorrente = "1";
                dtbase.Value = uVendas.PegaDataBase(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), meiolote);
            }
            else
            {
                meiolote = "2";
                partecorrente = "2";
                dtbase.Value = uVendas.PegaDataBase(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), meiolote);
            }
        }
        else
        {
            partecorrente = "0";
        }
        //
        if (uParametros.PegaParametro("TROCA INDEXADOR") == "SIM")
        {
            if (uParcelas.TemParcelaPaga(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), partecorrente))
            {
                edfeedback.Text = "Clique no Botão Processa para efetuar a Troca do Indexador!";
                Label13.Visible = true;
                rbperiodicidade.Visible = true;
                //Periodicidade Correção do Contrato Original
                string periodicidade = uVendas.PegaPeriodicidade(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte, "0");
                periodicidade = periodicidade.ToUpper();
                //
                if (periodicidade == "DIARIA")
                {
                    rbperiodicidade.SelectedIndex = 0;
                }
                else
                {
                    if (periodicidade == "MENSAL")
                    {
                        rbperiodicidade.SelectedIndex = 1;
                    }
                    else
                    {
                        rbperiodicidade.SelectedIndex = 2;
                    }
                }
                //
                Label10.Visible = true;
                rbaplicacao.Visible = true;
                if ((rbaplicacao.SelectedIndex == 0) || (rbaplicacao.SelectedIndex == 1))
                {
                    rbaplicacao.Enabled = false;
                }
                //
                Label11.Visible = true;
                dtbase.Visible = true;
                btprocessa.Enabled = true;
            }
            else
            {
                edfeedback.Text = "Financiamento não possui parcelas Pagas, não iniciado, não é possível efetuar a Troca do Indexador!";
                Label13.Visible = false;
                rbperiodicidade.Visible = false;
                Label10.Visible = false;
                rbaplicacao.Visible = false;
                Label11.Visible = false;
                dtbase.Visible = false;
                btprocessa.Enabled = false;
            }
        }
        else
        {
            edfeedback.Text = "Clique no Botão Processa para efetuar a Troca do Indexador!";
            Label13.Visible = true;
            rbperiodicidade.Visible = true;
            //Periodicidade Correção do Contrato Original
            string periodicidade = uVendas.PegaPeriodicidade(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte, "0");
            periodicidade = periodicidade.ToUpper();
            //
            if (periodicidade == "DIARIA")
            {
                rbperiodicidade.SelectedIndex = 0;
            }
            else
            {
                if (periodicidade == "MENSAL")
                {
                    rbperiodicidade.SelectedIndex = 1;
                }
                else
                {
                    rbperiodicidade.SelectedIndex = 2;
                }
            }
            //
            Label10.Visible = true;
            rbaplicacao.Visible = true;
            if ((rbaplicacao.SelectedIndex == 0) || (rbaplicacao.SelectedIndex == 1))
            {
                rbaplicacao.Enabled = false;
            }
            //
            Label11.Visible = true;
            dtbase.Visible = true;
            btprocessa.Enabled = true;
        }
    }
    protected void rbaplicacao_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        if ((rbperiodicidade.SelectedIndex == 0) || (rbperiodicidade.SelectedIndex == 1))
        {
            //Diaria ou Mensal
            //
            string grupounidades = cbgrupounidades.Text;
            string parte = grupounidades.Substring(grupounidades.IndexOf("-") + 1).Trim();
            dtbase.Value = uVendas.PegaDataBase(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte);
            string meiolote = "1";
            if (parte != "0")
            {
                if (rbmeiolote.SelectedIndex == 0)
                {
                    meiolote = "1";
                    dtbase.Value = uVendas.PegaDataBase(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), meiolote);
                }
                else
                {
                    meiolote = "2";
                    dtbase.Value = uVendas.PegaDataBase(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), meiolote);
                }
            }
            //
            Label11.Visible = true;
            dtbase.Visible = true;

        }
        else
        {
            //Anual
            //
            string grupounidades = cbgrupounidades.Text;
            string parte = grupounidades.Substring(grupounidades.IndexOf("-") + 1).Trim();
            dtbase.Value = uVendas.PegaDataBase(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte);
            string meiolote = "1";
            if (parte != "0")
            {
                if (rbmeiolote.SelectedIndex == 0)
                {
                    meiolote = "1";
                    dtbase.Value = uVendas.PegaDataBase(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), meiolote);
                }
                else
                {
                    meiolote = "2";
                    dtbase.Value = uVendas.PegaDataBase(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), meiolote);
                }
            }
            //
            Label11.Visible = true;
            dtbase.Visible = true;
        }
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
                    Label5.Visible = true;
                    edindexador.Visible = true;
                    Label9.Visible = true;
                    edperiodicidade.Visible = true;
                    Label6.Visible = true;
                    cbindexador.Visible = true;
                    Label4.Visible = true;
                    edfeedback.Visible = true;
                    //
                    string IndexadorCliente = "";
                    string PeriodicidadeCliente = "";
                    if (parte != "0")
                    {
                        if (rbmeiolote.SelectedIndex == 0)
                        {
                            meiolote = "1";
                            IndexadorCliente = uVendas.PegaIndexador(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), meiolote);
                            PeriodicidadeCliente = uVendas.PegaPeriodicidade(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte, meiolote);
                        }
                        else
                        {
                            meiolote = "2";
                            IndexadorCliente = uVendas.PegaIndexador(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), meiolote);
                            PeriodicidadeCliente = uVendas.PegaPeriodicidade(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte, meiolote);

                        }
                    }
                    else
                    {
                        IndexadorCliente = uVendas.PegaIndexador(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), "0");
                        PeriodicidadeCliente = uVendas.PegaPeriodicidade(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), "0", "1");
                    }
                    edindexador.Text = IndexadorCliente;
                    edperiodicidade.Text = PeriodicidadeCliente;
                    //
                    //Combo Unidades
                    cbindexador.Items.Clear();
                    uIndexadores.MontaComboIndexadores(cbindexador, true);
                    //
                    cbindexador.Text = IndexadorCliente;
                    //
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
                    string IDCliente = uUnidade.PegaIDCliente(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte, meiolote);
                    edcliente.Text = Srelib.QStr0(IDCliente.Trim(), 5) + " - " + uContato.PegaNomeID(IDCliente);
                    //
                    Label12.Visible = true;
                    eddatabaseatual.Visible = true;
                    eddatabaseatual.Text = uVendas.PegaDataBase(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte).ToString().Substring(0, 10);
                    //
                    cbindexador_SelectedIndexChanged(sender, e);
                }
                else
                {
                    //Cliente
                    Label8.Visible = false;
                    edcliente.Visible = false;
                    Label5.Visible = false;
                    edindexador.Visible = false;
                    Label9.Visible = false;
                    edperiodicidade.Visible = false;
                    Label6.Visible = false;
                    cbindexador.Visible = false;
                    Label12.Visible = false;
                    eddatabaseatual.Visible = false;

                    //Feedback
                    Label4.Visible = false;
                    edfeedback.Visible = false;
                }
            }
        }
    }

}

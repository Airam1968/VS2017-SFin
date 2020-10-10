using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FVendasRenegociacao : System.Web.UI.Page
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
        lInsere = SreDblib.TemPermissao("001.003.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.003.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.003.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.003.004.000", (String)Session["CodUsuario"]);
        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        //
        btprocessa.Enabled = lInsere;
        if (!lInsere)
            btprocessa.Image.ToolTip = Msg_acesso;
        //
        lInsere = false;
        lAltera = false;
        lExclui = false;
        lConsulta = false;
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
            //Combo Empresas
            cbproduto.Items.Clear();
            uProduto.MontaComboProduto(cbproduto, true);
            //
            Session.Add("Contador_Sinal", "0");
            Session.Add("Contador_Intermediaria", "0");
            Session.Add("Contador_Fluxo", "0");
            Session.Add("Primeiro_vencimento", "31/12/2999");
            Session.Add("Ultimo_vencimento", "01/01/1900");
        }

        if (edqtdsinal.IsVisible() && ((edqtdsinal.Text != "0") && (edqtdsinal.Text != "")))
        {
            Divsinalparcelado.Style[HtmlTextWriterStyle.Visibility] = "visible";
        }
        else
        {
            Divsinalparcelado.Style[HtmlTextWriterStyle.Visibility] = "hidden";
        }

        if (edqtdintermediarias.IsVisible() && ((edqtdintermediarias.Text != "0") && (edqtdintermediarias.Text != "")))
        {
            Divintermediaria.Style[HtmlTextWriterStyle.Visibility] = "visible";
        }
        else
        {
            Divintermediaria.Style[HtmlTextWriterStyle.Visibility] = "hidden";
        }

        if (edqtdfluxoparcelas.IsVisible() && ((edqtdfluxoparcelas.Text != "0") && (edqtdfluxoparcelas.Text != "")))
        {
            Divfluxos.Style[HtmlTextWriterStyle.Visibility] = "visible";
        }
        else
        {
            Divfluxos.Style[HtmlTextWriterStyle.Visibility] = "hidden";
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
            GridListagem.Visible = false;
        }
        else
        {
            Label2.Visible = false;
            cbgrupo.Visible = false;
            GridListagem.Visible = false;
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
                //tipo = uProduto.PegaTipo(Convert.ToInt32(cbproduto.Value));
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
                    string grupounidades = cbgrupounidades.Text;
                    string parte = grupounidades.Substring(grupounidades.IndexOf("-") + 1).Trim();
                    string meiolote = "1";
                    if (parte != "0")
                    {
                        rbmeiolote.Enabled = true;
                        rbmeiolote.Visible = true;
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
                    if (parte == "0")
                    {
                        string IDCliente = uUnidade.PegaIDCliente(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte, meiolote);
                        edcliente.Text = Srelib.QStr0(IDCliente.Trim(), 5) + " - " + uContato.PegaNomeID(IDCliente);
                        Label8.Visible = true;
                        edcliente.Visible = true;
                        //
                        //
                        if (uVendas.TemQuitacao(cbproduto.Value.ToString(),
                                                         cbgrupo.Value.ToString(),
                                                         cbgrupounidades.Value.ToString(),
                                                         parte))
                        {
                            Label42.Visible = true;
                            btprocessa.Enabled = false;
                        }
                        else
                        {
                            Label42.Visible = false;
                            btprocessa.Enabled = true;
                        }
                        //
                        //Valores da Venda
                        string indexador = uVendas.PegaIndexador(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte);
                        edindexador.Text = indexador.Trim();
                        edindexador.ReadOnly = true;
                        //
                        string corretor = uVendas.PegaCorretor(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte);
                        edcorretor.Text = corretor.Trim();
                        if (corretor != string.Empty)
                        {
                            edcorretor.Text = Srelib.QStr0(edcorretor.Text.Trim(), 5) + " - " + uCorretor.PegaApelidoCorretor(Convert.ToInt16(edcorretor.Text));
                        }
                        else
                        {
                            edcorretor.Text = "PRÓPRIO";
                        }
                        //
                        //Periodicidade Correção do Contrato Original
                        string periodicidade = uVendas.PegaPeriodicidade(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte, "0" );
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
                    }
                    else
                    {
                        string IDCliente = uUnidade.PegaIDCliente(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte, meiolote);
                        edcliente.Text = Srelib.QStr0(IDCliente.Trim(), 5) + " - " + uContato.PegaNomeID(IDCliente);
                        Label8.Visible = true;
                        edcliente.Visible = true;
                        //

                        //Valores da Venda
                        string indexador = uVendas.PegaIndexador(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), meiolote);
                        edindexador.Text = indexador.Trim();
                        edindexador.ReadOnly = true;
                        //
                        string corretor = uVendas.PegaCorretor(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), meiolote);
                        edcorretor.Text = corretor.Trim();
                        if (corretor != string.Empty)
                        {
                            edcorretor.Text = Srelib.QStr0(edcorretor.Text.Trim(), 5) + " - " + uCorretor.PegaApelidoCorretor(Convert.ToInt16(edcorretor.Text));
                        }
                        else
                        {
                            edcorretor.Text = "PRÓPRIO";
                        }
                        //
                        //
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
                    }
                    Label4.Visible = true;
                    dtvenda.Visible = true;
                    Label5.Visible = true;
                    edvlrvenda.Visible = true;
                    Label9.Visible = true;
                    edvlrsinal.Visible = true;
                    //cksinalparcelado.Visible = true;
                    Label10.Visible = true;
                    edvlrsaldo1.Visible = true;
                    Label11.Visible = true;
                    edvlrintermediarias.Visible = true;
                    //Label19.Visible = true;
                    //edqtdintermediarias.Visible = true;
                    Label18.Visible = true;
                    edvlrfluxoparcelas.Visible = true;
                    //Label17.Visible = true;
                    //edqtdfluxoparcelas.Visible = true;
                    Label12.Visible = true;
                    edindexador.Visible = true;
                    edindexador.ReadOnly = true;
                    Label13.Visible = true;
                    rbperiodicidade.Visible = true;
                    rbperiodicidade.Enabled = false;
                    Label14.Visible = true;
                    edcorretor.Visible = true;
                    Label15.Visible = true;
                    edmulta.Visible = true;
                    Label16.Visible = true;
                    edcomissao.Visible = true;
                    rbperiodicidadecomissao.Visible = true;
                    Label6.Visible = true;
                    edobservacao.Visible = true;
                    Label41.Visible = true;
                    dtbase.Visible = true;
                    //
                    dtvenda.Value = DateTime.Now;
                    dtbase.Value = DateTime.Now;
                    edvlrvenda.Text = "0.00";
                    edvlrsinal.Text = "0.00";
                    edvlrsaldo1.Text = "0.00";
                    edvlrintermediarias.Text = "0.00";
                    //
                    edmulta.Text = uParametros.PegaParametro("MULTA");
                    edcomissao.Text = uParametros.PegaParametro("COMISSAO TAXA");
                    //
                    dtvenda.Focus();
                    edvlrsaldo1.ReadOnly = true;
                    //

                }
                else
                {
                    Label8.Visible = false;
                    edcliente.Visible = false;
                }
            }
        }
    }

    private void AtualizaGrid()
    {
        //dsusuario.Clear();
        string grupounidades = cbgrupounidades.Text;
        string parte = grupounidades.Substring(grupounidades.IndexOf("-") + 1).Trim();
        //
        dsunidade = uParcelas.PegaDadosParcelas2(cbproduto.Value.ToString().Trim(),
                                                cbgrupo.Value.ToString().Trim(),
                                                cbgrupounidades.Value.ToString().Trim(),
                                                parte,
                                                (rbmeiolote.SelectedIndex + 1).ToString(),
                                                "01/01/1900",
                                                "31/12/2999",
                                                "T",
                                                "0",
                                                "V",
                                                false,
                                                "0");
        GridListagem.DataSource = dsunidade;
        GridListagem.KeyFieldName = "data_vencimento";
        GridListagem.DataBind();
        btprocessa.Enabled = false;
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
        string cliente = "";
        string indexador = "";
        string corretor = "";
        //
        Double vlr_venda = 0.00;
        Double vlr_sinal = 0.00;
        Double vlr_intermediaria = 0.00;
        Double vlr_fluxo = 0.00;
        //
        Int32 qtd_sinal = 0;
        Int32 qtd_intermediaria = 0;
        Int32 qtd_fluxo = 0;
        //
        Double multa = 0.00;
        Double comissao = 0.00;
        //

        if (lOk)
        {
            //Check da Unidade para Renegociação
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
                            grupounidademeiolote = (rbmeiolote.SelectedIndex + 1).ToString();
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
            //Fim Check da Unidade para Venda
        }
        //
        if (lOk)
        {
            //Check do Cliente
            //Cliente
            //
            if (edcliente.Text != string.Empty)
            {
                cliente = edcliente.Text.Substring(0, 5);
            }
            //
            //Fim Check do Cliente
        }
        //

        //
        if (lOk)
        {
            //Check de Valores
            //Valor da Venda
            if ((edvlrvenda.Text != string.Empty) && (edvlrvenda.Text != "0,00"))
            {
                vlr_venda = Convert.ToDouble(edvlrvenda.Text);
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Valor de Venda igual a Zero!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Valor de Venda igual a Zero!', 'Atenção!')", true);
            }
            //Fim Valor da Venda
        }
        //
        if (lOk)
        {
            //Check de Valores
            //Valor do Sinal
            if ((edvlrsinal.Text != string.Empty) && (edvlrsinal.Text != "0,00"))
            {
                vlr_sinal = Convert.ToDouble(edvlrsinal.Text);
                //Sinal Parcelado
                if (cksinalparcelado.Checked)
                {
                    if ((edqtdsinal.Text != string.Empty) && (edqtdsinal.Text != "0"))
                    {
                        qtd_sinal = Convert.ToInt32(edqtdsinal.Text);
                        //Parcelas de Sinal


                        //Fim Parcelas de Sinal
                    }
                    else
                    {
                        lOk = false;
                        //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Quantidade de Parcelas de Sinal igual a Zero!');", true);
                        ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                        "toastr.info('Quantidade de Parcelas de Sinal igual a Zero!', 'Atenção!')", true);
                    }
                }
            }
            else
            {
                if (cksinalparcelado.Visible == true)
                {
                    lOk = false;
                    ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Valor de Sinal igual a Zero!');", true);
                }
            }
            //Fim Sinal Parcelado
        }
        //
        if (lOk)
        {
            //Check de Valores
            //Valor do Intermediarias
            if ((edvlrintermediarias.Text != string.Empty) && (edvlrintermediarias.Text != "0,00"))
            {
                vlr_intermediaria = Convert.ToDouble(edvlrintermediarias.Text);
                //Intermediarias Parcelado
                if ((edqtdintermediarias.Text != string.Empty) && (edqtdintermediarias.Text != "0"))
                {
                    qtd_intermediaria = Convert.ToInt32(edqtdintermediarias.Text);
                    //Parcelas de Intermediarias


                    //Fim Parcelas de Intermediarias
                }
                else
                {
                    lOk = false;
                    //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Quantidade de Parcelas de Intermediarias igual a Zero!');", true);
                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                    "toastr.info('Quantidade de Parcelas de Intermediarias igual a Zero!', 'Atenção!')", true);
                }
            }
            else
            {
                //Permitido Intermediárias zeradas
                //lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Valor de Intermediarias igual a Zero!');", true);
            }
            //Fim Intermediarias
        }
        //
        if (lOk)
        {
            //Check de Valores
            //Valor do Fluxo
            if ((edvlrfluxoparcelas.Text != string.Empty) && (edvlrfluxoparcelas.Text != "0,00"))
            {
                vlr_fluxo = Convert.ToDouble(edvlrfluxoparcelas.Text);
                //Fluxo
                if ((edqtdfluxoparcelas.Text != string.Empty) && (edqtdfluxoparcelas.Text != "0"))
                {
                    qtd_fluxo = Convert.ToInt32(edqtdfluxoparcelas.Text);
                    //Parcelas de Fluxo


                    //Fim Parcelas de Fluxo
                }
                else
                {
                    lOk = false;
                    //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Quantidade de Fluxos igual a Zero!');", true);
                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                    "toastr.info('Quantidade de Fluxos igual a Zero!', 'Atenção!')", true);
                }
            }
            else
            {
                //Permitido Fluxo zerado
                //lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Valor de Fluxo igual a Zero!');", true);
            }
            //Fim Fluxo
        }
        //
        if (lOk)
        {
            //Check do Indexador
            //Indexador
            if (edindexador.Text != string.Empty)
            {
                indexador = edindexador.Value.ToString();
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
        //
        if (lOk)
        {
            //Check do Corretor
            //Corretor
            if (edcorretor.Text != string.Empty)
            {
                corretor = edcorretor.Value.ToString().Substring(0, 5);
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione um Corretor!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Selecione um Corretor!', 'Atenção!')", true);
            }
            //Fim Check do cbcorretor
        }
        //
        if (lOk)
        {
            //Check de Multa
            //Valor da Multa
            if ((edmulta.Text != string.Empty) && (edmulta.Text != "0,00"))
            {
                multa = Convert.ToDouble(edmulta.Text);
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Valor de Multa igual a Zero!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Valor de Multa igual a Zero!', 'Atenção!')", true);
            }
            //Fim Valor da Multa
        }
        //
        if (lOk)
        {
            //Check de Comissão de Permanência
            //Valor da Comissão
            if ((edcomissao.Text != string.Empty) && (edcomissao.Text != "0,00"))
            {
                comissao = Convert.ToDouble(edcomissao.Text);
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Valor de Comissão de Permanência igual a Zero!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Valor de Comissão de Permanência igual a Zero!', 'Atenção!')", true);
            }
            //Fim Valor da Comissão
        }
        //
        if (lOk)
        {
            //Check de Valores da Venda
            Double Resultado = 0.00;
            Double Diferenca = 0.00;
            Resultado = vlr_sinal + vlr_intermediaria + vlr_fluxo;
            vlr_venda = Math.Round(vlr_venda, 2);
            Resultado = Math.Round(Resultado, 2);
            Diferenca = vlr_venda - Resultado;
            if (vlr_venda != Resultado)
            {
                if (vlr_venda > Resultado)
                {
                    //Resultado menor que valor da venda
                    lOk = false;
                    //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Soma dos componentes da venda MENOR que o valor de venda! (" + Diferenca.ToString() + ")');", true);
                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                    "toastr.info('Soma dos componentes da venda MENOR que o valor de venda!', 'Atenção!')", true);
                }
                else
                {
                    //Resultado Maior que valor da venda
                    lOk = false;
                    //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Soma dos componentes da venda MAIOR que o valor de venda! (" + Diferenca.ToString() + ")');", true);
                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                    "toastr.info('Soma dos componentes da venda MAIOR que o valor de venda!', 'Atenção!')", true);
                }
            }
        }
        //
        if (lOk)
        {
            string periodicidade = "";
            string periodicidadecomissao = "";
            string primeiro_vencimento = (string)Session["Primeiro_vencimento"];
            string ultimo_vencimento = (string)Session["Ultimo_vencimento"];
            //Processa Venda
            //
            //Gravar Venda
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
            //
            if (rbperiodicidadecomissao.SelectedIndex == 0)
            {
                periodicidadecomissao = "a.d.";
            }
            else
            {
                if (rbperiodicidadecomissao.SelectedIndex == 1)
                {
                    periodicidadecomissao = "a.m.";
                }
                else
                {
                    periodicidadecomissao = "a.a.";
                }
            }
            //Fim Gravar Renegociação
            if (grupounidadeparte == "0")
            {
                uVendas.GravaRenegociacao(produto,
                                          grupo,
                                          grupounidade,
                                          grupounidadeparte,
                                          cliente,
                                          Convert.ToString(dtvenda.Value).Substring(0, 10),
                                          Convert.ToDecimal(vlr_venda),
                                          Convert.ToDecimal(vlr_sinal),
                                          Convert.ToDecimal(vlr_fluxo),
                                          Convert.ToDecimal(vlr_intermediaria),
                                          qtd_sinal.ToString(),
                                          qtd_fluxo.ToString(),
                                          qtd_intermediaria.ToString(),
                                          Convert.ToDecimal(edvlrparcelafluxo.Text),
                                          primeiro_vencimento,
                                          ultimo_vencimento,
                                          0,
                                          indexador,
                                          indexador,
                                          periodicidade,
                                          "01/01/1900",
                                          Convert.ToInt16(cksinalparcelado.Checked),
                                          corretor,
                                          edobservacao.Text,
                                          Convert.ToDecimal(multa),
                                          Convert.ToDecimal(comissao),
                                          periodicidadecomissao
                                          , "R"
                                          , "1"
                                          , 0
                                          , 0
                                          , 0
                                          , 0
                                          , "NENHUM"
                                          );
                //
                uVendas.GravaNovaDataBase(produto,
                                          grupo,
                                          grupounidade,
                                          grupounidadeparte,
                                          Convert.ToString(dtbase.Value).Substring(0, 10));
                //
                //Fim Gravar Renegociação
                //
                //Gravar Parcelas
                //
                //Preparar parcelas anteriores a Renegociação
                uVendas.ApagaRenegociacaoParcelas(produto,
                                                  grupo,
                                                  grupounidade,
                                                  grupounidadeparte,
                                                  Convert.ToString(dtvenda.Value).Substring(0, 10));
                //
                //
                //Parcelas de Sinal
                if (cksinalparcelado.Checked)
                {
                    Int64 parcelas = Convert.ToInt64(edqtdsinal.Text.Trim());
                    double Vlr_parcela = 0.00;
                    DateTime Dt_parcela = Convert.ToDateTime("01/01/1900");

                    for (int i = 1; i <= parcelas; i++)
                    {
                        Vlr_parcela = Convert.ToDouble((string)Session["SinalValor" + i.ToString()]);
                        Dt_parcela = Convert.ToDateTime((string)Session["SinalData" + i.ToString()]);

                        uParcelas.Grava(produto,
                                        grupo,
                                        grupounidade,
                                        grupounidadeparte,
                                        i.ToString().Trim(),
                                        "S",
                                        Convert.ToString(Dt_parcela).Substring(0, 10),
                                        Convert.ToDecimal(Vlr_parcela),
                                        Convert.ToString("01/01/1900").Substring(0, 10),
                                        0,
                                        Convert.ToString(Dt_parcela).Substring(0, 10),
                                        Convert.ToDecimal(Vlr_parcela),
                                        Convert.ToString(Dt_parcela).Substring(0, 10),
                                        Convert.ToDecimal(Vlr_parcela),
                                        "",
                                        "",
                                        1,
                                        0,
                                        0,
                                        0,
                                        1,
                                        Convert.ToDecimal(multa),
                                        Convert.ToDecimal(comissao),
                                        0,
                                        0,
                                        0,
                                        periodicidadecomissao,
                                        Convert.ToString("01/01/1900").Substring(0, 10),
                                        "0",
                                        indexador,
                                        0,
                                        0,
                                        0,
                                        0,
                                        0,
                                        ""
                                      );

                    }

                }
                //Fim Parcelas de Sinal
                //
                //Parcelas de Intermediárias
                if (Convert.ToInt32((string)Session["Contador_Intermediaria"]) > 0)
                {
                    Int64 parcelas = Convert.ToInt64(edqtdintermediarias.Text.Trim());
                    double Vlr_parcela = 0.00;
                    DateTime Dt_parcela = Convert.ToDateTime("01/01/1900");
                    string Obs_parcela = "";

                    for (int i = 1; i <= parcelas; i++)
                    {
                        Vlr_parcela = Convert.ToDouble((string)Session["IntermediariaValor" + i.ToString()]);
                        Dt_parcela = Convert.ToDateTime((string)Session["IntermediariaData" + i.ToString()]);
                        Obs_parcela = (string)Session["IntermediariaObs" + i.ToString()];

                        uParcelas.Grava(produto,
                                        grupo,
                                        grupounidade,
                                        grupounidadeparte,
                                        i.ToString().Trim(),
                                        "I",
                                        Convert.ToString(Dt_parcela).Substring(0, 10),
                                        Convert.ToDecimal(Vlr_parcela),
                                        Convert.ToString("01/01/1900").Substring(0, 10),
                                        0,
                                        Convert.ToString(Dt_parcela).Substring(0, 10),
                                        Convert.ToDecimal(Vlr_parcela),
                                        Convert.ToString(Dt_parcela).Substring(0, 10),
                                        Convert.ToDecimal(Vlr_parcela),
                                        "",
                                        "",
                                        1,
                                        0,
                                        0,
                                        0,
                                        1,
                                        Convert.ToDecimal(multa),
                                        Convert.ToDecimal(comissao),
                                        0,
                                        0,
                                        0,
                                        periodicidadecomissao,
                                        Convert.ToString("01/01/1900").Substring(0, 10),
                                        "0",
                                        indexador,
                                        0,
                                        0,
                                        0,
                                        0,
                                        0,
                                        Obs_parcela
                                      );

                    }

                }
                //Fim Parcelas de Intermediárias
                //
                //Parcelas de Fluxos
                if (Convert.ToInt32((string)Session["Contador_Fluxo"]) > 0)
                {
                    Int64 fluxos = Convert.ToInt64(edqtdfluxoparcelas.Text.Trim());
                    //
                    double Vlr_parcela = 0.00;
                    DateTime Dt_parcela = Convert.ToDateTime("01/01/1900");
                    Int64 parcelas = 0;
                    Int64 numerorenegociacoes = 0;
                    string renegociacaotipo = "R0";
                    if (uVendas.TemRenegociacao(produto,
                                                grupo,
                                                grupounidade,
                                                grupounidadeparte))
                    {
                        numerorenegociacoes = uVendas.NumeroRenegociacao(produto,
                                                                         grupo,
                                                                         grupounidade,
                                                                         grupounidadeparte) - 1;
                        renegociacaotipo = "R" + numerorenegociacoes.ToString().Trim();
                    }
                    //
                    for (int i = 1; i <= fluxos; i++)
                    {

                        Vlr_parcela = Convert.ToDouble((string)Session["FluxoValor" + i.ToString()]);
                        Dt_parcela = Convert.ToDateTime((string)Session["FluxoData" + i.ToString()]);
                        parcelas = Convert.ToInt64((string)Session["FluxoParcelas" + i.ToString()]);
                        //
                        for (int j = 1; j <= parcelas; j++)
                        {
                            //
                            uParcelas.Grava(produto,
                                            grupo,
                                            grupounidade,
                                            grupounidadeparte,
                                            j.ToString().Trim(),
                                            renegociacaotipo,
                                            Convert.ToString(Dt_parcela).Substring(0, 10),
                                            Convert.ToDecimal(Vlr_parcela),
                                            Convert.ToString("01/01/1900").Substring(0, 10),
                                            0,
                                            Convert.ToString(Dt_parcela).Substring(0, 10),
                                            Convert.ToDecimal(Vlr_parcela),
                                            Convert.ToString(Dt_parcela).Substring(0, 10),
                                            Convert.ToDecimal(Vlr_parcela),
                                            "",
                                            "",
                                            1,
                                            0,
                                            0,
                                            0,
                                            1,
                                            Convert.ToDecimal(multa),
                                            Convert.ToDecimal(comissao),
                                            0,
                                            0,
                                            0,
                                            periodicidadecomissao,
                                            Convert.ToString("01/01/1900").Substring(0, 10),
                                            "0",
                                            indexador,
                                            0,
                                            0,
                                            0,
                                            0,
                                            0,
                                            ""
                                          );

                            Dt_parcela = Dt_parcela.AddMonths(1);
                        }
                    }

                }
            }
            else
            {
                uVendas.GravaRenegociacao(produto,
                                          grupo,
                                          grupounidade,
                                          grupounidademeiolote,
                                          cliente,
                                          Convert.ToString(dtvenda.Value).Substring(0, 10),
                                          Convert.ToDecimal(vlr_venda),
                                          Convert.ToDecimal(vlr_sinal),
                                          Convert.ToDecimal(vlr_fluxo),
                                          Convert.ToDecimal(vlr_intermediaria),
                                          qtd_sinal.ToString(),
                                          qtd_fluxo.ToString(),
                                          qtd_intermediaria.ToString(),
                                          Convert.ToDecimal(edvlrparcelafluxo.Text),
                                          primeiro_vencimento,
                                          ultimo_vencimento,
                                          0,
                                          indexador,
                                          indexador,
                                          periodicidade,
                                          "01/01/1900",
                                          Convert.ToInt16(cksinalparcelado.Checked),
                                          corretor,
                                          edobservacao.Text,
                                          Convert.ToDecimal(multa),
                                          Convert.ToDecimal(comissao),
                                          periodicidadecomissao
                                          , "R"
                                          , "1"
                                          , 0
                                          , 0
                                          , 0
                                          , 0
                                          , ""
                                          );
                //
                uVendas.GravaNovaDataBase(produto,
                                          grupo,
                                          grupounidade,
                                          grupounidadeparte,
                                          Convert.ToString(dtbase.Value).Substring(0, 10));
                //
                //Fim Gravar Renegociação
                //
                //Gravar Parcelas
                //
                //Preparar parcelas anteriores a Renegociação
                uVendas.ApagaRenegociacaoParcelas(produto,
                                                  grupo,
                                                  grupounidade,
                                                  grupounidademeiolote,
                                                  Convert.ToString(dtvenda.Value).Substring(0, 10));
                //
                //
                //Parcelas de Sinal
                if (cksinalparcelado.Checked)
                {
                    Int64 parcelas = Convert.ToInt64(edqtdsinal.Text.Trim());
                    double Vlr_parcela = 0.00;
                    DateTime Dt_parcela = Convert.ToDateTime("01/01/1900");

                    for (int i = 1; i <= parcelas; i++)
                    {
                        Vlr_parcela = Convert.ToDouble((string)Session["SinalValor" + i.ToString()]);
                        Dt_parcela = Convert.ToDateTime((string)Session["SinalData" + i.ToString()]);

                        uParcelas.Grava(produto,
                                        grupo,
                                        grupounidade,
                                        grupounidademeiolote,
                                        i.ToString().Trim(),
                                        "S",
                                        Convert.ToString(Dt_parcela).Substring(0, 10),
                                        Convert.ToDecimal(Vlr_parcela),
                                        Convert.ToString("01/01/1900").Substring(0, 10),
                                        0,
                                        Convert.ToString(Dt_parcela).Substring(0, 10),
                                        Convert.ToDecimal(Vlr_parcela),
                                        Convert.ToString(Dt_parcela).Substring(0, 10),
                                        Convert.ToDecimal(Vlr_parcela),
                                        "",
                                        "",
                                        1,
                                        0,
                                        0,
                                        0,
                                        1,
                                        Convert.ToDecimal(multa),
                                        Convert.ToDecimal(comissao),
                                        0,
                                        0,
                                        0,
                                        periodicidadecomissao,
                                        Convert.ToString("01/01/1900").Substring(0, 10),
                                        "0",
                                        indexador,
                                        0,
                                        0,
                                        0,
                                        0,
                                        0,
                                        ""
                                      );

                    }

                }
                //Fim Parcelas de Sinal
                //
                //Parcelas de Intermediárias
                if (Convert.ToInt32((string)Session["Contador_Intermediaria"]) > 0)
                {
                    Int64 parcelas = Convert.ToInt64(edqtdintermediarias.Text.Trim());
                    double Vlr_parcela = 0.00;
                    DateTime Dt_parcela = Convert.ToDateTime("01/01/1900");
                    string Obs_parcela = "";

                    for (int i = 1; i <= parcelas; i++)
                    {
                        Vlr_parcela = Convert.ToDouble((string)Session["IntermediariaValor" + i.ToString()]);
                        Dt_parcela = Convert.ToDateTime((string)Session["IntermediariaData" + i.ToString()]);
                        Obs_parcela = (string)Session["IntermediariaObs" + i.ToString()];

                        uParcelas.Grava(produto,
                                        grupo,
                                        grupounidade,
                                        grupounidademeiolote,
                                        i.ToString().Trim(),
                                        "I",
                                        Convert.ToString(Dt_parcela).Substring(0, 10),
                                        Convert.ToDecimal(Vlr_parcela),
                                        Convert.ToString("01/01/1900").Substring(0, 10),
                                        0,
                                        Convert.ToString(Dt_parcela).Substring(0, 10),
                                        Convert.ToDecimal(Vlr_parcela),
                                        Convert.ToString(Dt_parcela).Substring(0, 10),
                                        Convert.ToDecimal(Vlr_parcela),
                                        "",
                                        "",
                                        1,
                                        0,
                                        0,
                                        0,
                                        1,
                                        Convert.ToDecimal(multa),
                                        Convert.ToDecimal(comissao),
                                        0,
                                        0,
                                        0,
                                        periodicidadecomissao,
                                        Convert.ToString("01/01/1900").Substring(0, 10),
                                        "0",
                                        indexador,
                                        0,
                                        0,
                                        0,
                                        0,
                                        0,
                                        Obs_parcela
                                      );

                    }

                }
                //Fim Parcelas de Intermediárias
                //
                //Parcelas de Fluxos
                if (Convert.ToInt32((string)Session["Contador_Fluxo"]) > 0)
                {
                    Int64 fluxos = Convert.ToInt64(edqtdfluxoparcelas.Text.Trim());
                    //
                    double Vlr_parcela = 0.00;
                    DateTime Dt_parcela = Convert.ToDateTime("01/01/1900");
                    Int64 parcelas = 0;
                    Int64 numerorenegociacoes = 0;
                    string renegociacaotipo = "R0";
                    if (uVendas.TemRenegociacao(produto,
                                                grupo,
                                                grupounidade,
                                                grupounidadeparte))
                    {
                        numerorenegociacoes = uVendas.NumeroRenegociacao(produto,
                                                                         grupo,
                                                                         grupounidade,
                                                                         grupounidadeparte) - 1;
                        renegociacaotipo = "R" + numerorenegociacoes.ToString().Trim();
                    }
                    //
                    //
                    for (int i = 1; i <= fluxos; i++)
                    {

                        Vlr_parcela = Convert.ToDouble((string)Session["FluxoValor" + i.ToString()]);
                        Dt_parcela = Convert.ToDateTime((string)Session["FluxoData" + i.ToString()]);
                        parcelas = Convert.ToInt64((string)Session["FluxoParcelas" + i.ToString()]);
                        //
                        for (int j = 1; j <= parcelas; j++)
                        {
                            //
                            uParcelas.Grava(produto,
                                            grupo,
                                            grupounidade,
                                            grupounidademeiolote,
                                            j.ToString().Trim(),
                                            renegociacaotipo,
                                            Convert.ToString(Dt_parcela).Substring(0, 10),
                                            Convert.ToDecimal(Vlr_parcela),
                                            Convert.ToString("01/01/1900").Substring(0, 10),
                                            0,
                                            Convert.ToString(Dt_parcela).Substring(0, 10),
                                            Convert.ToDecimal(Vlr_parcela),
                                            Convert.ToString(Dt_parcela).Substring(0, 10),
                                            Convert.ToDecimal(Vlr_parcela),
                                            "",
                                            "",
                                            1,
                                            0,
                                            0,
                                            0,
                                            1,
                                            Convert.ToDecimal(multa),
                                            Convert.ToDecimal(comissao),
                                            0,
                                            0,
                                            0,
                                            periodicidadecomissao,
                                            Convert.ToString("01/01/1900").Substring(0, 10),
                                            "0",
                                            indexador,
                                            0,
                                            0,
                                            0,
                                            0,
                                            0,
                                            ""
                                          );

                            Dt_parcela = Dt_parcela.AddMonths(1);
                        }
                    }

                }
            }
            //Fim Parcelas de Fluxos
            //
            //Fim Gravar Parcelas
            //
            //Fim Processa Venda
            // CRIA LOG ===================================================================================================================================================
            if (grupounidadeparte == "0")
            {
                fwObs_Log = "RENEGOCIAÇÃO UNIDADE: " + produto + "/" + grupo + "/" + grupounidade + "/" + grupounidadeparte;
            }
            else
            {
                fwObs_Log = "RENEGOCIAÇÃO UNIDADE: " + produto + "/" + grupo + "/" + grupounidade + "/" + grupounidademeiolote;
            }
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ), 
                                         new SqlParameter("@tabela"   , fWtabela                              ),
                                         new SqlParameter("@operacao" , "VENDAS"                              ),
                                         new SqlParameter("@obs"      , "RENEGOCIAÇÃO UNIDADE"                ),
                                         new SqlParameter("@acao"     , fwObs_Log                             ) };
            uLog.MakeLog(param_log);
            // FIM CRIA LOG ===============================================================================================================================================

            //Grid
            AtualizaGrid();
            GridListagem.Visible = true;
            //Fim Grid
            btprocessa.Enabled = false;
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Processamento Concluído!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.success('Processamento Concluído!', 'Atenção!')", true);
        }

    }

    protected void GridListagem_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
    {
        //Código Original
        //ASPxGridView gridView = (ASPxGridView)sender;

        ////
        //string apelido = "";
        //string nome = "";
        //string cnpj = "";
        //string inscmunicipal = "";
        //string inscestadual = "";
        //string regjuntacom = "";
        //string nire = "";
        //string enderecocom = "";
        //string enderecocomnumero = "";
        //string enderecocomcomplem = "";
        //string bairrocom = "";
        //string cidadecom = "";
        //string ufcom = "";
        //string cepcom = "";
        //string fone1com = "";
        //string fone2com = "";
        //string fone3com = "";
        //string email1 = "";
        //string email2 = "";
        //string email3 = "";
        //string email4 = "";
        //string email5 = "";
        //string gerente = "";
        //string contato = "";
        //DateTime dtnascimento = Convert.ToDateTime("01/01/1900");
        //DateTime dtingresso = Convert.ToDateTime("01/01/1900");
        //string ncontrato = "";
        //DateTime dtcontrato = Convert.ToDateTime("01/01/1900");
        //Boolean ativo = true;
        //Boolean acessointernet = true;
        //string obs1 = "";
        //string obs2 = "";
        //string obs3 = "";
        //string obs4 = "";
        //string obs5 = "";
        //string instrcob1 = "";
        //string instrcob2 = "";
        //string diasprotesto = "";
        //string conta1 = "";
        //string conta2 = "";
        //string conta3 = "";
        //string conta4 = "";
        //string conta5 = "";
        ////
        //// Empresa
        //apelido = e.NewValues["apelido"].ToString().ToUpper();
        //nome = e.NewValues["nome"].ToString().ToUpper();
        //cnpj = e.NewValues["cnpj"].ToString();
        //if (e.NewValues["inscmunicipal"] != null)
        //    inscmunicipal = e.NewValues["inscmunicipal"].ToString();
        //if (e.NewValues["inscestadual"] != null)
        //    inscestadual = e.NewValues["inscestadual"].ToString();
        //if (e.NewValues["regjuntacom"] != null)
        //    regjuntacom = e.NewValues["regjuntacom"].ToString();
        //if (e.NewValues["nire"] != null)
        //    nire = e.NewValues["nire"].ToString();
        //if (e.NewValues["enderecocom"] != null)
        //    enderecocom = e.NewValues["enderecocom"].ToString();
        //if (e.NewValues["enderecocomnumero"] != null)
        //    enderecocomnumero = e.NewValues["enderecocomnumero"].ToString();
        //if (e.NewValues["enderecocomcomplem"] != null)
        //    enderecocomcomplem = e.NewValues["enderecocomcomplem"].ToString();
        //if (e.NewValues["bairrocom"] != null)
        //    bairrocom = e.NewValues["bairrocom"].ToString();
        //if (e.NewValues["cidadecom"] != null)
        //    cidadecom = e.NewValues["cidadecom"].ToString();
        //if (e.NewValues["ufcom"] != null)
        //    ufcom = e.NewValues["ufcom"].ToString();
        //if (e.NewValues["cepcom"] != null)
        //    cepcom = e.NewValues["cepcom"].ToString();
        //if (e.NewValues["fone1com"] != null)
        //    fone1com = e.NewValues["fone1com"].ToString();
        //if (e.NewValues["fone2com"] != null)
        //    fone2com = e.NewValues["fone2com"].ToString();
        //if (e.NewValues["fone3com"] != null)
        //    fone3com = e.NewValues["fone3com"].ToString();
        //if (e.NewValues["email1"] != null)
        //    email1 = e.NewValues["email1"].ToString();
        //if (e.NewValues["email2"] != null)
        //    email2 = e.NewValues["email2"].ToString();
        //if (e.NewValues["email3"] != null)
        //    email3 = e.NewValues["email3"].ToString();
        //if (e.NewValues["email4"] != null)
        //    email4 = e.NewValues["email4"].ToString();
        //if (e.NewValues["email5"] != null)
        //    email5 = e.NewValues["email5"].ToString();
        //if (e.NewValues["gerente"] != null)
        //    gerente = e.NewValues["gerente"].ToString();
        //if (e.NewValues["contato"] != null)
        //    contato = e.NewValues["contato"].ToString();
        //if (e.NewValues["dtnascimento"] != null)
        //    dtnascimento = Convert.ToDateTime(e.NewValues["dtnascimento"].ToString());
        //if (e.NewValues["dtingresso"] != null)
        //    dtingresso = Convert.ToDateTime(e.NewValues["dtingresso"].ToString());
        //if (e.NewValues["ncontrato"] != null)
        //    ncontrato = e.NewValues["ncontrato"].ToString();
        //if (e.NewValues["dtcontrato"] != null)
        //    dtcontrato = Convert.ToDateTime(e.NewValues["dtcontrato"].ToString());
        //if (e.NewValues["ativo"] != null)
        //    ativo = Convert.ToBoolean(e.NewValues["ativo"].ToString());
        //if (e.NewValues["acessointernet"] != null)
        //    acessointernet = Convert.ToBoolean(e.NewValues["acessointernet"].ToString());
        //if (e.NewValues["obs1"] != null)
        //    obs1 = e.NewValues["obs1"].ToString();
        //if (e.NewValues["obs2"] != null)
        //    obs2 = e.NewValues["obs2"].ToString();
        //if (e.NewValues["obs3"] != null)
        //    obs3 = e.NewValues["obs3"].ToString();
        //if (e.NewValues["obs4"] != null)
        //    obs4 = e.NewValues["obs4"].ToString();
        //if (e.NewValues["obs5"] != null)
        //    obs5 = e.NewValues["obs5"].ToString();
        //if (e.NewValues["instrcob1"] != null)
        //    instrcob1 = e.NewValues["instrcob1"].ToString();
        //if (e.NewValues["instrcob2"] != null)
        //    instrcob2 = e.NewValues["instrcob2"].ToString();
        //if (e.NewValues["diasprotesto"] != null)
        //    diasprotesto = e.NewValues["diasprotesto"].ToString();
        //if (e.NewValues["conta1"] != null)
        //    conta1 = e.NewValues["conta1"].ToString();
        //if (e.NewValues["conta2"] != null)
        //    conta2 = e.NewValues["conta2"].ToString();
        //if (e.NewValues["conta3"] != null)
        //    conta3 = e.NewValues["conta3"].ToString();
        //if (e.NewValues["conta4"] != null)
        //    conta4 = e.NewValues["conta4"].ToString();
        //if (e.NewValues["conta5"] != null)
        //    conta5 = e.NewValues["conta5"].ToString();

        //uEmpresa.Grava(apelido,
        //               nome,
        //               cnpj,
        //               inscmunicipal,
        //               inscestadual,
        //               regjuntacom,
        //               nire,
        //               enderecocom,
        //               enderecocomnumero,
        //               enderecocomcomplem,
        //               bairrocom,
        //               cidadecom,
        //               ufcom,
        //               cepcom,
        //               fone1com,
        //               fone2com,
        //               fone3com,
        //               email1,
        //               email2,
        //               email3,
        //               email4,
        //               email5,
        //               gerente,
        //               contato,
        //               dtnascimento,
        //               dtingresso,
        //               ncontrato,
        //               dtcontrato,
        //               ativo,
        //               acessointernet,
        //               obs1,
        //               obs2,
        //               obs3,
        //               obs4,
        //               obs5,
        //               instrcob1,
        //               instrcob2,
        //               diasprotesto,
        //               conta1,
        //               conta2,
        //               conta3,
        //               conta4,
        //               conta5);

        ////Código Original
        //gridView.CancelEdit();
        //e.Cancel = true;

        ////Usando Classe uLog.MakeLog - Gravando Log
        //fwObs_Log = "INCLUI EMPRESA: " + "NOVO" + "/" + e.NewValues["apelido"].ToString().ToUpper();
        //SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
        //                             new SqlParameter("@tabela"   , fWtabela                     ),
        //                             new SqlParameter("@operacao" , "EMPRESA"                    ),
        //                             new SqlParameter("@obs"      , "INCLUI"                     ),
        //                             new SqlParameter("@acao"     , fwObs_Log                    ) };
        //uLog.MakeLog(param_log);
        //
        AtualizaGrid();

    }
    protected void GridListagem_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        //
        string produto = "";
        string grupo = "";
        string unidade = "";
        string parte = "";
        decimal metragem_total = 0;
        decimal vlr_total = 0;
        decimal vlr_1 = 0;
        decimal metragem_1 = 0;
        string inscricao_1 = "";
        string proprietario_1 = "";
        Boolean quitado_1 = false;
        Boolean escritura_1 = false;
        DateTime dtescritura_1 = Convert.ToDateTime("01/01/1900");
        string cartorio_1 = "";
        string livro_1 = "";
        string folha_1 = "";
        Boolean processo_1 = false;
        string obs_1 = "";
        decimal vlr_2 = 0;
        decimal metragem_2 = 0;
        string inscricao_2 = "";
        string proprietario_2 = "";
        Boolean quitado_2 = false;
        Boolean escritura_2 = false;
        DateTime dtescritura_2 = Convert.ToDateTime("01/01/1900");
        string cartorio_2 = "";
        string livro_2 = "";
        string folha_2 = "";
        Boolean processo_2 = false;
        string obs_2 = "";
        //
        //
        decimal area_privativa_coletiva_m2 = 0;
        decimal area_privativa_terraco_coberto_m2 = 0;
        decimal area_privativa_terraco_descoberto_m2 = 0;
        decimal area_comum_m2 = 0;
        decimal area_garagem_m2 = 0;
        decimal area_hobby_box_m2 = 0;
        decimal area_total_m2 = 0;
        decimal fracao_ideal_m2 = 0;
        decimal fracao_ideal_percentual = 0;
        string hobby_box_numero = "";
        string hobby_box_localizacao = "";
        string numero_garagem_01 = "";
        string numero_garagem_02 = "";
        string numero_garagem_03 = "";
        string numero_garagem_04 = "";
        string numero_garagem_05 = "";
        string vagas_localizacao = "";
        Int16 vagas_quantidade = 0;
        //
        // Empresa
        ID = e.NewValues["ID"].ToString();
        produto = e.NewValues["produto"].ToString();
        grupo = e.NewValues["grupo"].ToString();
        unidade = e.NewValues["unidade"].ToString();
        parte = e.NewValues["parte"].ToString();
        if (e.NewValues["metragem_total"] != null)
            metragem_total = Convert.ToDecimal(e.NewValues["metragem_total"].ToString());
        if (e.NewValues["vlr_total"] != null)
            vlr_total = Convert.ToDecimal(e.NewValues["vlr_total"].ToString());
        if (e.NewValues["vlr_1"] != null)
            vlr_1 = Convert.ToDecimal(e.NewValues["vlr_1"].ToString());
        if (e.NewValues["metragem_1"] != null)
            metragem_1 = Convert.ToDecimal(e.NewValues["metragem_1"].ToString());
        if (e.NewValues["inscricao_1"] != null)
            inscricao_1 = e.NewValues["inscricao_1"].ToString();
        if (e.NewValues["proprietario_1"] != null)
            proprietario_1 = e.NewValues["proprietario_1"].ToString();
        if (e.NewValues["quitado_1"] != null)
            quitado_1 = Convert.ToBoolean(e.NewValues["quitado_1"].ToString());
        if (e.NewValues["escritura_1"] != null)
            escritura_1 = Convert.ToBoolean(e.NewValues["escritura_1"].ToString());
        if (e.NewValues["dtescritura_1"] != null)
            dtescritura_1 = Convert.ToDateTime(e.NewValues["dtescritura_1"].ToString());
        if (e.NewValues["cartorio_1"] != null)
            cartorio_1 = e.NewValues["cartorio_1"].ToString();
        if (e.NewValues["livro_1"] != null)
            livro_1 = e.NewValues["livro_1"].ToString();
        if (e.NewValues["folha_1"] != null)
            folha_1 = e.NewValues["folha_1"].ToString();
        if (e.NewValues["processo_1"] != null)
            processo_1 = Convert.ToBoolean(e.NewValues["processo_1"].ToString());
        if (e.NewValues["obs_1"] != null)
            obs_1 = e.NewValues["obs_1"].ToString();
        if (e.NewValues["vlr_2"] != null)
            vlr_2 = Convert.ToDecimal(e.NewValues["vlr_2"].ToString());
        if (e.NewValues["metragem_2"] != null)
            metragem_2 = Convert.ToDecimal(e.NewValues["metragem_2"].ToString());
        if (e.NewValues["inscricao_2"] != null)
            inscricao_2 = e.NewValues["inscricao_2"].ToString();
        if (e.NewValues["proprietario_2"] != null)
            proprietario_2 = e.NewValues["proprietario_2"].ToString();
        if (e.NewValues["quitado_2"] != null)
            quitado_2 = Convert.ToBoolean(e.NewValues["quitado_2"].ToString());
        if (e.NewValues["escritura_2"] != null)
            escritura_2 = Convert.ToBoolean(e.NewValues["escritura_2"].ToString());
        if (e.NewValues["dtescritura_2"] != null)
            dtescritura_2 = Convert.ToDateTime(e.NewValues["dtescritura_2"].ToString());
        if (e.NewValues["cartorio_2"] != null)
            cartorio_2 = e.NewValues["cartorio_2"].ToString();
        if (e.NewValues["livro_2"] != null)
            livro_2 = e.NewValues["livro_2"].ToString();
        if (e.NewValues["folha_2"] != null)
            folha_2 = e.NewValues["folha_2"].ToString();
        if (e.NewValues["processo_2"] != null)
            processo_2 = Convert.ToBoolean(e.NewValues["processo_2"].ToString());
        if (e.NewValues["obs_2"] != null)
            obs_2 = e.NewValues["obs_2"].ToString();
        //
        if (e.NewValues["area_privativa_coletiva_m2"] != null)
            area_privativa_coletiva_m2 = Convert.ToDecimal(e.NewValues["area_privativa_coletiva_m2"]);
        if (e.NewValues["area_privativa_terraco_coberto_m2"] != null)
            area_privativa_terraco_coberto_m2 = Convert.ToDecimal(e.NewValues["area_privativa_terraco_coberto_m2"]);
        if (e.NewValues["area_privativa_terraco_descoberto_m2"] != null)
            area_privativa_terraco_descoberto_m2 = Convert.ToDecimal(e.NewValues["area_privativa_terraco_descoberto_m2"]);
        //
        if (e.NewValues["area_comum_m2"] != null)
            area_comum_m2 = Convert.ToDecimal(e.NewValues["area_comum_m2"]);
        if (e.NewValues["area_garagem_m2"] != null)
            area_garagem_m2 = Convert.ToDecimal(e.NewValues["area_garagem_m2"]);
        if (e.NewValues["area_hobby_box_m2"] != null)
            area_hobby_box_m2 = Convert.ToDecimal(e.NewValues["area_hobby_box_m2"]);
        if (e.NewValues["area_total_m2"] != null)
            area_total_m2 = Convert.ToDecimal(e.NewValues["area_total_m2"]);
        if (e.NewValues["fracao_ideal_m2"] != null)
            fracao_ideal_m2 = Convert.ToDecimal(e.NewValues["fracao_ideal_m2"]);
        if (e.NewValues["fracao_ideal_percentual"] != null)
            fracao_ideal_percentual = Convert.ToDecimal(e.NewValues["fracao_ideal_percentual"]);
        //
        if (e.NewValues["hobby_box_numero"] != null)
            hobby_box_numero = e.NewValues["hobby_box_numero"].ToString();
        if (e.NewValues["hobby_box_localizacao"] != null)
            hobby_box_localizacao = e.NewValues["hobby_box_localizacao"].ToString();
        if (e.NewValues["numero_garagem_01"] != null)
            numero_garagem_01 = e.NewValues["numero_garagem_01"].ToString();
        if (e.NewValues["numero_garagem_02"] != null)
            numero_garagem_02 = e.NewValues["numero_garagem_02"].ToString();
        if (e.NewValues["numero_garagem_03"] != null)
            numero_garagem_03 = e.NewValues["numero_garagem_03"].ToString();
        if (e.NewValues["numero_garagem_04"] != null)
            numero_garagem_04 = e.NewValues["numero_garagem_04"].ToString();
        if (e.NewValues["numero_garagem_05"] != null)
            numero_garagem_05 = e.NewValues["numero_garagem_05"].ToString();
        //
        if (e.NewValues["vagas_localizacao"] != null)
            vagas_localizacao = e.NewValues["vagas_localizacao"].ToString();
        if (e.NewValues["vagas_quantidade"] != null)
            vagas_quantidade = Convert.ToInt16(e.NewValues["vagas_quantidade"]);
        //        

        uUnidade.Altera(ID,
                        produto,
                        grupo,
                        unidade,
                        parte,
                        metragem_total,
                        vlr_total,
                        vlr_1,
                        metragem_1,
                        inscricao_1,
                        proprietario_1,
                        Convert.ToInt16(quitado_1),
                        Convert.ToInt16(escritura_1),
                        Convert.ToString(dtescritura_1).Substring(0, 10),
                        cartorio_1,
                        livro_1,
                        folha_1,
                        Convert.ToInt16(processo_1),
                        obs_1,
                        vlr_2,
                        metragem_2,
                        inscricao_2,
                        proprietario_2,
                        Convert.ToInt16(quitado_2),
                        Convert.ToInt16(escritura_2),
                        Convert.ToString(dtescritura_2).Substring(0, 10),
                        cartorio_2,
                        livro_2,
                        folha_2,
                        Convert.ToInt16(processo_2),
                        obs_2,
                        area_privativa_coletiva_m2,
                        area_privativa_terraco_coberto_m2,
                        area_privativa_terraco_descoberto_m2,
                        area_comum_m2,
                        area_garagem_m2,
                        area_hobby_box_m2,
                        area_total_m2,
                        fracao_ideal_m2,
                        fracao_ideal_percentual,
                        hobby_box_numero,
                        hobby_box_localizacao,
                        numero_garagem_01,
                        numero_garagem_02,
                        numero_garagem_03,
                        numero_garagem_04,
                        numero_garagem_05,
                        vagas_localizacao,
                        vagas_quantidade);


        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "ALTERA PRODUTO UNIDADE: " + produto + "/" + grupo + "/" + unidade + "/" + parte;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "PRODUTO UNIDADE"            ),
                                     new SqlParameter("@obs"      , "ALTERA"                     ),
                                     new SqlParameter("@acao"     , fwObs_Log                    ) };
        uLog.MakeLog(param_log);

        //
        AtualizaGrid();
    }

    protected void GridListagem_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
    {
        //ASPxGridView gridView = (ASPxGridView)sender;

        //uEmpresa.Exclui(e.Values["ID"].ToString());
        ////

        //gridView.CancelEdit();
        //e.Cancel = true;

        ////Usando Classe uLog.MakeLog - Gravando Log
        //fwObs_Log = "EXCLUI EMPRESA: " + e.Values["ID"].ToString() + "/" + e.Values["apelido"].ToString().ToUpper();
        //SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
        //                             new SqlParameter("@tabela"   , fWtabela                     ),
        //                             new SqlParameter("@operacao" , "EMPRESA"                    ),
        //                             new SqlParameter("@obs"      , "EXCLUI"                     ),
        //                             new SqlParameter("@acao"     , fwObs_Log                    ) };
        //uLog.MakeLog(param_log);
        //
        AtualizaGrid();

    }

    protected void GridListagem_CommandButtonInitialize(object sender, ASPxGridViewCommandButtonEventArgs e)
    {
        //Botão Edit
        if (e.ButtonType == DevExpress.Web.ASPxGridView.ColumnCommandButtonType.Edit)
            e.Visible = lAltera;

        //Botão Novo
        if (e.ButtonType == DevExpress.Web.ASPxGridView.ColumnCommandButtonType.New)
            e.Visible = lInsere;

        //Botão Altera
        if (e.ButtonType == DevExpress.Web.ASPxGridView.ColumnCommandButtonType.Update)
            e.Visible = lAltera;

        //Botão Exclui
        if (e.ButtonType == DevExpress.Web.ASPxGridView.ColumnCommandButtonType.Delete)
            e.Visible = lExclui;

    }
    protected void GridListagem_InitNewRow(object sender, DevExpress.Web.Data.ASPxDataInitNewRowEventArgs e)
    {
        //e.NewValues["dtnascimento"] = Convert.ToDateTime("01/01/1900");
        //e.NewValues["dtingresso"] = DateTime.Now;
        //e.NewValues["dtcontrato"] = Convert.ToDateTime("01/01/1900");
        //e.NewValues["ativo"] = true;
        //e.NewValues["acessointernet"] = true;
        //e.NewValues["gerente"] = "GERAL";
    }

    private void GetSelectedValues()
    {
        if (selectedValues != null)
            selectedValues.Clear();

        List<string> fieldNames = new List<string>();
        foreach (GridViewColumn column in GridListagem.Columns)
            if (column is GridViewDataColumn)
                fieldNames.Add(((GridViewDataColumn)column).FieldName);
        selectedValues = GridListagem.GetSelectedFieldValues(fieldNames.ToArray());
    }

    protected void edvlrvenda_TextChanged(object sender, EventArgs e)
    {
        edvlrsaldo1.Text = Convert.ToString(Convert.ToDecimal(edvlrvenda.Text) - Convert.ToDecimal(edvlrsinal.Text));
        edvlrfluxoparcelas.Text = Convert.ToString(Convert.ToDecimal(edvlrvenda.Text) -
                                                   Convert.ToDecimal(edvlrsinal.Text) -
                                                   Convert.ToDecimal(edvlrintermediarias.Text));
        //
        edvlrfluxoparcelas_TextChanged(sender, e);
        //
    }

    protected void edvlrsinal_TextChanged(object sender, EventArgs e)
    {
        edvlrsaldo1.Text = Convert.ToString(Convert.ToDecimal(edvlrvenda.Text) - Convert.ToDecimal(edvlrsinal.Text));
        edvlrfluxoparcelas.Text = Convert.ToString(Convert.ToDecimal(edvlrvenda.Text) -
                                                   Convert.ToDecimal(edvlrsinal.Text) -
                                                   Convert.ToDecimal(edvlrintermediarias.Text));
        if ((edvlrsinal.Text != "0,00") && (edvlrsinal.Text != ""))
        {
            cksinalparcelado.Visible = true;
            cksinalparcelado.Focus();
        }
        else
        {
            cksinalparcelado.Visible = false;
            edvlrsinal.Focus();
        }
    }

    protected void edvlrintermediarias_TextChanged(object sender, EventArgs e)
    {
        edvlrsaldo1.Text = Convert.ToString(Convert.ToDecimal(edvlrvenda.Text) - Convert.ToDecimal(edvlrsinal.Text));
        edvlrfluxoparcelas.Text = Convert.ToString(Convert.ToDecimal(edvlrvenda.Text) -
                                                   Convert.ToDecimal(edvlrsinal.Text) -
                                                   Convert.ToDecimal(edvlrintermediarias.Text));
        if ((edvlrintermediarias.Text != "0,00") && (edvlrintermediarias.Text != ""))
        {
            Label19.Visible = true;
            edqtdintermediarias.Visible = true;
            edqtdintermediarias.Focus();
        }
        else
        {
            Label19.Visible = false;
            edqtdintermediarias.Visible = false;
            edvlrintermediarias.Focus();
        }
    }

    protected void edvlrfluxoparcelas_TextChanged(object sender, EventArgs e)
    {
        if ((edvlrfluxoparcelas.Text != "0,00") && (edvlrfluxoparcelas.Text != ""))
        {
            Label17.Visible = true;
            edqtdfluxoparcelas.Visible = true;
            edqtdfluxoparcelas.Focus();
        }
        else
        {
            Label17.Visible = false;
            edqtdfluxoparcelas.Visible = false;
            edvlrfluxoparcelas.Focus();
        }
    }

    protected void edqtdfluxoparcelas_TextChanged(object sender, EventArgs e)
    {
        if ((edqtdfluxoparcelas.Text != "0") && (edqtdfluxoparcelas.Text != ""))
        {
            Divfluxos.Style[HtmlTextWriterStyle.Visibility] = "visible";
            //
            Int32 Contador_Fluxo = Convert.ToInt32((string)Session["Contador_Fluxo"]);
            Contador_Fluxo++;
            Session.Remove("Contador_Fluxo");
            Session.Add("Contador_Fluxo", Contador_Fluxo.ToString());
            Label35.Text = Contador_Fluxo.ToString() + "/" + edqtdfluxoparcelas.Text.Trim();
            edqtdfluxoparcelas.ReadOnly = true;
            eddtparcelaintermediaria.Focus();
            //
            Label34.Visible = true;
            Label35.Visible = true;
            Label36.Visible = true;
            eddtinicialfluxo.Visible = true;
            Label37.Visible = true;
            edvlrparcelafluxo.Visible = true;
            Label40.Visible = true;
            edqtdparcelafluxo.Visible = true;
            Label38.Visible = true;
            edvlrparcelafluxototal.Visible = true;
            btgravafluxo.Visible = true;
            //
            eddtinicialfluxo.Value = DateTime.Now;
            edvlrparcelafluxo.Text = "0,00";
            edvlrparcelafluxototal.Text = "0,00";
            //
            eddtinicialfluxo.Focus();
        }
        else
        {
            Divfluxos.Style[HtmlTextWriterStyle.Visibility] = "hidden";
            Label35.Text = "9999/9999";
            //
            Label34.Visible = false;
            Label35.Visible = false;
            Label36.Visible = false;
            eddtinicialfluxo.Visible = false;
            Label37.Visible = false;
            edvlrparcelafluxo.Visible = false;
            Label40.Visible = false;
            edqtdparcelafluxo.Visible = false;
            Label38.Visible = false;
            edvlrparcelafluxototal.Visible = false;
            btgravafluxo.Visible = false;
            //
            edqtdfluxoparcelas.ReadOnly = false;
            edqtdfluxoparcelas.Focus();
        }
    }

    protected void cbindexador_SelectedIndexChanged(object sender, EventArgs e)
    {
        //rbperiodicidade.Focus();
    }

    protected void rbperiodicidade_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        if (rbperiodicidade.SelectedIndex == 2)
        {

        }
        else
        {
            
        }
    }

    protected void cbcorretor_SelectedIndexChanged(object sender, EventArgs e)
    {
        //edmulta.Focus();
    }


    protected void edmulta_TextChanged(object sender, EventArgs e)
    {
        //edcomissao.Focus();
    }


    protected void edcomissao_TextChanged(object sender, EventArgs e)
    {
        //rbperiodicidadecomissao.Focus();
    }

    protected void edqtdintermediarias_TextChanged(object sender, EventArgs e)
    {
        if ((edqtdintermediarias.Text != "0") && (edqtdintermediarias.Text != ""))
        {
            Divintermediaria.Style[HtmlTextWriterStyle.Visibility] = "visible";

            Int32 Contador_Intermediaria = Convert.ToInt32((string)Session["Contador_Intermediaria"]);
            Contador_Intermediaria++;
            Session.Remove("Contador_Intermediaria");
            Session.Add("Contador_Intermediaria", Contador_Intermediaria.ToString());
            Label28.Text = Contador_Intermediaria.ToString() + "/" + edqtdintermediarias.Text.Trim();
            edqtdintermediarias.ReadOnly = true;
            eddtparcelaintermediaria.Focus();
            //
            Label27.Visible = true;
            Label28.Visible = true;
            Label29.Visible = true;
            eddtparcelaintermediaria.Visible = true;
            Label30.Visible = true;
            edvlrparcelaintermediaria.Visible = true;
            Label39.Visible = true;
            edobsintermediaria.Visible = true;
            Label31.Visible = true;
            edvlrparcelaintermediariatotal.Visible = true;
            btgravaintermediaria.Visible = true;
            //
            edobservacao.Text = "";
            eddtparcelaintermediaria.Value = DateTime.Now;
            edvlrparcelaintermediaria.Text = "0,00";
            edvlrparcelaintermediariatotal.Text = "0,00";
            edobsintermediaria.Text = "";
            //
            eddtparcelaintermediaria.Focus();
            //
        }
        else
        {
            Divintermediaria.Style[HtmlTextWriterStyle.Visibility] = "hidden";
            //
            Label27.Visible = false;
            Label28.Visible = false;
            Label29.Visible = false;
            eddtparcelaintermediaria.Visible = false;
            Label30.Visible = false;
            edvlrparcelaintermediaria.Visible = false;
            Label39.Visible = false;
            edobsintermediaria.Visible = false;
            Label31.Visible = false;
            edvlrparcelaintermediariatotal.Visible = false;
            btgravaintermediaria.Visible = false;
            //
            Label28.Text = "9999/9999";
            edqtdintermediarias.ReadOnly = false;
            edqtdintermediarias.Focus();
        }
    }
    protected void rbperiodicidadecomissao_SelectedIndexChanged(object sender, EventArgs e)
    {
        //edobservacao.Focus();
    }
    protected void edobservacao_TextChanged(object sender, EventArgs e)
    {
        //btprocessa.Focus();
    }
    protected void cksinalparcelado_CheckedChanged(object sender, EventArgs e)
    {
        //
        if (cksinalparcelado.Checked)
        {
            Divsinalparcelado.Style[HtmlTextWriterStyle.Visibility] = "visible";
            Label32.Visible = true;
            edqtdsinal.Visible = true;
            Label22.Visible = true;
            eddtparcelasinal.Visible = true;
            Label23.Visible = true;
            edvlrparcelasinal.Visible = true;
            Label24.Visible = true;
            edvlrparcelasinaltotal.Visible = true;
            Label25.Visible = true;
            btgravasinal.Visible = true;
            //
            edqtdsinal.Text = "0";
            eddtparcelasinal.Value = DateTime.Now;
            edvlrparcelasinal.Text = "0,00";
            edvlrparcelasinaltotal.Text = "0,00";
            //
            edqtdsinal.Focus();
        }
        else
        {
            Divsinalparcelado.Style[HtmlTextWriterStyle.Visibility] = "hidden";
            Label32.Visible = false;
            edqtdsinal.Visible = false;
            Label22.Visible = false;
            eddtparcelasinal.Visible = false;
            Label23.Visible = false;
            edvlrparcelasinal.Visible = false;
            Label24.Visible = false;
            edvlrparcelasinaltotal.Visible = false;
            Label25.Visible = false;
            btgravasinal.Visible = false;
            //
            edvlrsinal.Focus();
        }
    }

    protected void edqtdsinal_TextChanged(object sender, EventArgs e)
    {
        if ((edqtdsinal.Text != "0") && (edqtdsinal.Text != ""))
        {
            Int32 Contador_Sinal = Convert.ToInt32((string)Session["Contador_Sinal"]);
            Contador_Sinal++;
            Session.Remove("Contador_Sinal");
            Session.Add("Contador_Sinal", Contador_Sinal.ToString());
            Label25.Text = Contador_Sinal.ToString() + "/" + edqtdsinal.Text.Trim();
            edqtdsinal.ReadOnly = true;
            eddtparcelasinal.Focus();
        }
        else
        {
            Label25.Text = "9999/9999";
            edqtdsinal.ReadOnly = false;
            edqtdsinal.Focus();
        }
    }

    protected void btgravasinal_Click(object sender, EventArgs e)
    {
        Boolean lOk = true;
        Double Total = 0.00;
        Int32 Contador_Sinal = Convert.ToInt32((string)Session["Contador_Sinal"]);
        if (Contador_Sinal <= Convert.ToInt32(edqtdsinal.Text))
        {
            Label25.Text = Contador_Sinal.ToString() + "/" + edqtdsinal.Text.Trim();
            //armazena valores
            Session.Remove("SinalData" + Contador_Sinal.ToString());
            Session.Remove("SinalValor" + Contador_Sinal.ToString());
            Session.Add("SinalData" + Contador_Sinal.ToString(), eddtparcelasinal.Text);
            Session.Add("SinalValor" + Contador_Sinal.ToString(), edvlrparcelasinal.Text);
            //
            edvlrparcelasinaltotal.Text = edvlrparcelasinal.Text;
            //
            if (Convert.ToDateTime(eddtparcelasinal.Text.Substring(0, 10)) <= Convert.ToDateTime((string)Session["Primeiro_vencimento"]))
            {
                Session.Remove("Primeiro_vencimento");
                Session.Add("Primeiro_vencimento", eddtparcelasinal.Text.Substring(0, 10));
            }
            if (Convert.ToDateTime(eddtparcelasinal.Text.Substring(0, 10)) >= Convert.ToDateTime((string)Session["Ultimo_vencimento"]))
            {
                Session.Remove("Ultimo_vencimento");
                Session.Add("Ultimo_vencimento", eddtparcelasinal.Text.Substring(0, 10));
            }
            //
            //Totaliza
            for (int i = 1; i < Contador_Sinal + 1; i++)
            {
                Total = Total + Convert.ToDouble((string)Session["SinalValor" + i.ToString()]);
            }
            Total = Math.Round(Total, 2);
            //
            edvlrparcelasinaltotal.Text = Total.ToString();
            //
            Contador_Sinal++;
            if (Contador_Sinal <= Convert.ToInt64(edqtdsinal.Text))
            {
                Label25.Text = Contador_Sinal.ToString() + "/" + edqtdsinal.Text.Trim();
                edvlrparcelasinal.Text = "0,00";
                Session.Remove("Contador_Sinal");
                Session.Add("Contador_Sinal", Contador_Sinal.ToString());
                eddtparcelasinal.Focus();
            }
            else
            {
                Double diferenca = (Total - Convert.ToDouble(edvlrsinal.Text));
                //
                //Check de Valores do Sinal
                if (diferenca != 0)
                {
                    if (Total > Convert.ToDouble(edvlrsinal.Text))
                    {
                        //Resultado menor que valor da venda
                        lOk = false;
                        //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Soma dos componentes do Sinal MAIOR que o Total de Sinal!');", true);
                        btprocessa.Focus();
                        ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                        "toastr.info('Soma dos componentes do Sinal é MAIOR que o Total de Sinal!', 'Atenção!')", true);
                    }
                    else
                    {
                        //Resultado Maior que valor da venda
                        lOk = false;
                        //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Soma dos componentes do Sinal MENOR que o Total de Sinal!');", true);
                        btprocessa.Focus();
                        ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                        "toastr.info('Soma dos componentes do Sinal é MENOR que o Total de Sinal!', 'Atenção!')", true);
                    }
                }
                if (lOk)
                {
                    edvlrintermediarias.Focus();
                }
                else
                {
                    //Reset
                    for (int i = 1; i < Contador_Sinal + 1; i++)
                    {
                        Session.Remove("SinalData" + Contador_Sinal.ToString());
                        Session.Remove("SinalValor" + Contador_Sinal.ToString());
                    }
                    Session.Remove("Contador_Sinal");
                    Session.Add("Contador_Sinal", "0");
                    //
                    Divsinalparcelado.Style[HtmlTextWriterStyle.Visibility] = "hidden";
                    Label32.Visible = false;
                    edqtdsinal.Visible = false;
                    Label22.Visible = false;
                    eddtparcelasinal.Visible = false;
                    Label23.Visible = false;
                    edvlrparcelasinal.Visible = false;
                    Label24.Visible = false;
                    edvlrparcelasinaltotal.Visible = false;
                    Label25.Visible = false;
                    btgravasinal.Visible = false;
                    cksinalparcelado.Checked = false;
                    //
                    edqtdsinal.Text = "0";
                    edqtdsinal.ReadOnly = false;
                    //
                    //edqtdsinal.Focus();
                }
            }
        }

    }
    protected void btgravaintermediaria_Click(object sender, EventArgs e)
    {
        Boolean lOk = true;
        Double Total = 0.00;
        Int32 Contador_Intermediaria = Convert.ToInt32((string)Session["Contador_Intermediaria"]);
        if (Contador_Intermediaria <= Convert.ToInt32(edqtdintermediarias.Text))
        {
            Label28.Text = Contador_Intermediaria.ToString() + "/" + edqtdintermediarias.Text.Trim();
            //armazena valores
            Session.Remove("IntermediariaData" + Contador_Intermediaria.ToString());
            Session.Remove("IntermediariaValor" + Contador_Intermediaria.ToString());
            Session.Remove("IntermediariaObs" + Contador_Intermediaria.ToString());
            //
            Session.Add("IntermediariaData" + Contador_Intermediaria.ToString(), eddtparcelaintermediaria.Text);
            Session.Add("IntermediariaValor" + Contador_Intermediaria.ToString(), edvlrparcelaintermediaria.Text);
            Session.Add("IntermediariaObs" + Contador_Intermediaria.ToString(), edobsintermediaria.Text);
            //
            edvlrparcelaintermediariatotal.Text = edvlrparcelaintermediaria.Text;
            //
            if (Convert.ToDateTime(eddtparcelaintermediaria.Text.Substring(0, 10)) <= Convert.ToDateTime((string)Session["Primeiro_vencimento"]))
            {
                Session.Remove("Primeiro_vencimento");
                Session.Add("Primeiro_vencimento", eddtparcelaintermediaria.Text.Substring(0, 10));
            }
            if (Convert.ToDateTime(eddtparcelaintermediaria.Text.Substring(0, 10)) >= Convert.ToDateTime((string)Session["Ultimo_vencimento"]))
            {
                Session.Remove("Ultimo_vencimento");
                Session.Add("Ultimo_vencimento", eddtparcelaintermediaria.Text.Substring(0, 10));
            }
            //
            //Totaliza
            for (int i = 1; i < Contador_Intermediaria + 1; i++)
            {
                Total = Total + Convert.ToDouble((string)Session["IntermediariaValor" + i.ToString()]);
            }
            Total = Math.Round(Total, 2);
            //
            edvlrparcelaintermediariatotal.Text = Total.ToString();
            //
            Contador_Intermediaria++;
            if (Contador_Intermediaria <= Convert.ToInt64(edqtdintermediarias.Text))
            {
                Label28.Text = Contador_Intermediaria.ToString() + "/" + edqtdintermediarias.Text.Trim();
                edvlrparcelaintermediaria.Text = "0,00";
                Session.Remove("Contador_Intermediaria");
                Session.Add("Contador_Intermediaria", Contador_Intermediaria.ToString());
                eddtparcelaintermediaria.Focus();
            }
            else
            {
                //Check de Valores de Intermediarias
                Double diferenca = (Total - Convert.ToDouble(edvlrintermediarias.Text));
                //
                //Check de Valores de Fluxo 
                if (diferenca != 0)
                {
                    if (Total > Convert.ToDouble(edvlrintermediarias.Text))
                    {
                        //Resultado menor que valor de Intermediarias
                        lOk = false;
                        //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Soma dos componentes de Intermediarias MAIOR que o Total de Intermediarias!');", true);
                        btprocessa.Focus();
                        ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                        "toastr.info('Soma dos componentes de Intermediarias é MAIOR que o Total de Intermediarias!', 'Atenção!')", true);
                    }
                    else
                    {
                        //Resultado Maior que valor de Intermediarias
                        lOk = false;
                        //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Soma dos componentes de Intermediarias MENOR que o Total de Intermediarias!');", true);
                        btprocessa.Focus();
                        ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                        "toastr.info('Soma dos componentes de Intermediarias é MENOR que o Total de Intermediarias!', 'Atenção!')", true);
                    }
                }
                if (lOk)
                {
                    edvlrfluxoparcelas.Focus();
                }
                else
                {
                    //Reset
                    for (int i = 1; i < Contador_Intermediaria + 1; i++)
                    {
                        Session.Remove("IntermediariaData" + Contador_Intermediaria.ToString());
                        Session.Remove("IntermediariaValor" + Contador_Intermediaria.ToString());
                        Session.Remove("IntermediariaObs" + Contador_Intermediaria.ToString());
                    }
                    Session.Remove("Contador_Intermediaria");
                    Session.Add("Contador_Intermediaria", "0");
                    //
                    Divintermediaria.Style[HtmlTextWriterStyle.Visibility] = "hidden";
                    //
                    Label27.Visible = false;
                    Label28.Visible = false;
                    Label29.Visible = false;
                    eddtparcelaintermediaria.Visible = false;
                    Label30.Visible = false;
                    edvlrparcelaintermediaria.Visible = false;
                    Label39.Visible = false;
                    edobsintermediaria.Visible = false;
                    Label31.Visible = false;
                    edvlrparcelaintermediariatotal.Visible = false;
                    btgravaintermediaria.Visible = false;
                    //
                    Label28.Text = "9999/9999";
                    edqtdintermediarias.Text = "0";
                    edqtdintermediarias.ReadOnly = false;
                    //edqtdintermediarias.Focus();
                }
            }

        }


    }
    protected void btgravafluxo_Click(object sender, EventArgs e)
    {
        Boolean lOk = true;
        Double Total = 0.00;
        Int32 Contador_Fluxo = Convert.ToInt32((string)Session["Contador_Fluxo"]);
        if (Contador_Fluxo <= Convert.ToInt32(edqtdfluxoparcelas.Text))
        {
            Label35.Text = Contador_Fluxo.ToString() + "/" + edqtdfluxoparcelas.Text.Trim();
            //armazena valores
            Session.Remove("FluxoData" + Contador_Fluxo.ToString());
            Session.Remove("FluxoValor" + Contador_Fluxo.ToString());
            Session.Remove("FluxoParcelas" + Contador_Fluxo.ToString());
            Session.Add("FluxoData" + Contador_Fluxo.ToString(), eddtinicialfluxo.Text);
            Session.Add("FluxoValor" + Contador_Fluxo.ToString(), edvlrparcelafluxo.Text);
            Session.Add("FluxoParcelas" + Contador_Fluxo.ToString(), edqtdparcelafluxo.Text);
            //
            edvlrparcelafluxototal.Text = edvlrparcelafluxo.Text;
            //
            //Totaliza
            for (int i = 1; i < Contador_Fluxo + 1; i++)
            {
                Total = Total + (Convert.ToDouble((string)Session["FluxoValor" + i.ToString()]))
                                *
                                (Convert.ToInt64((string)Session["FluxoParcelas" + i.ToString()]));
            }
            Total = Math.Round(Total, 2);
            //
            edvlrparcelafluxototal.Text = Total.ToString();
            //
            Contador_Fluxo++;
            if (Contador_Fluxo <= Convert.ToInt64(edqtdfluxoparcelas.Text))
            {
                Label35.Text = Contador_Fluxo.ToString() + "/" + edqtdfluxoparcelas.Text.Trim();
                edvlrparcelafluxo.Text = "0,00";
                edqtdparcelafluxo.Text = "0";
                Session.Remove("Contador_Fluxo");
                Session.Add("Contador_Fluxo", Contador_Fluxo.ToString());
                eddtinicialfluxo.Focus();
            }
            else
            {
                Double diferenca = (Total - Convert.ToDouble(edvlrfluxoparcelas.Text));
                //
                //Check de Valores de Fluxo 
                if (diferenca != 0)
                {
                    if (Total > Convert.ToDouble(edvlrfluxoparcelas.Text))
                    {
                        //Resultado menor que valor da Fluxo
                        lOk = false;
                        edobservacao.Text = "Diferença: " + String.Format("{0:N}", Convert.ToDouble(diferenca));
                        btprocessa.Focus();
                        //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Soma dos componentes do Fluxo MAIOR que o Total de Fluxo de Parcelas!');", true);
                        ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                        "toastr.info('Soma dos componentes do Fluxo é MAIOR que o Total de Fluxo de Parcelas!', 'Atenção!')", true);
                    }
                    else
                    {
                        //Resultado Maior que valor da Fluxo
                        lOk = false;
                        edobservacao.Text = "Diferença: " + String.Format("{0:N}", Convert.ToDouble(diferenca));
                        //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Soma dos componentes do Fluxo MENOR que o Total de Fluxo de Parcelas!');", true);
                        btprocessa.Focus();
                        ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                        "toastr.info('Soma dos componentes do Fluxo é MENOR que o Total de Fluxo de Parcelas!', 'Atenção!')", true);
                    }
                }
                if (lOk)
                {
                    edindexador.Focus();
                }
                else
                {
                    //Reset
                    for (int i = 1; i < Contador_Fluxo + 1; i++)
                    {
                        Session.Remove("FluxoData" + Contador_Fluxo.ToString());
                        Session.Remove("FluxoValor" + Contador_Fluxo.ToString());
                        Session.Remove("FluxoParcelas" + Contador_Fluxo.ToString());
                    }
                    Session.Remove("Contador_Fluxo");
                    Session.Add("Contador_Fluxo", "0");
                    //
                    Divfluxos.Style[HtmlTextWriterStyle.Visibility] = "hidden";
                    Label35.Text = "9999/9999";
                    //
                    Label34.Visible = false;
                    Label35.Visible = false;
                    Label36.Visible = false;
                    eddtinicialfluxo.Visible = false;
                    Label37.Visible = false;
                    edvlrparcelafluxo.Visible = false;
                    Label40.Visible = false;
                    edqtdparcelafluxo.Visible = false;
                    Label38.Visible = false;
                    edvlrparcelafluxototal.Visible = false;
                    btgravafluxo.Visible = false;
                    //
                    edqtdfluxoparcelas.Text = "0";
                    edqtdfluxoparcelas.ReadOnly = false;
                    //edqtdfluxoparcelas.Focus();
                }
            }

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
        string IDCliente = uUnidade.PegaIDCliente(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte, meiolote);
        edcliente.Text = Srelib.QStr0(IDCliente.Trim(), 5) + " - " + uContato.PegaNomeID(IDCliente);
        Label8.Visible = true;
        edcliente.Visible = true;
        //
        //
        if (uVendas.TemQuitacao(cbproduto.Value.ToString(),
                                         cbgrupo.Value.ToString(),
                                         cbgrupounidades.Value.ToString(),
                                         parte))
        {
            Label42.Visible = true;
            btprocessa.Enabled = false;
        }
        else
        {
            Label42.Visible = false;
            btprocessa.Enabled = true;
        }
        //
    }


    protected void dtvenda_DateChanged(object sender, EventArgs e)
    {
        if (rbperiodicidade.SelectedIndex == 2)
        {
            dtbase.Value = dtvenda.Value;
            edvlrvenda.Focus();
        }
    }
}

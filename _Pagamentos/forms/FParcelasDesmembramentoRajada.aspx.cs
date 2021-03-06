﻿using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FParcelasDesmembramentoRajada : System.Web.UI.Page
{
    DataSet dsparcelas;
    DataSet parcela;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "";

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = SreDblib.TemPermissao("001.005.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.005.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.005.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.005.004.000", (String)Session["CodUsuario"]);
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
                    Label8.Visible = true;
                    edcliente.Visible = true;
                    //
                    Label4.Visible = true;
                    dtvenda.Visible = true;
                    dtvenda.Value = uVendas.PegaDataVenda(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), "0");
                    //
                    Label13.Visible = true;
                    rbparcelasituacao.Visible = true;
                    //
                    rbparcelasituacao_SelectedIndexChanged(sender, e);
                    //
                }
                else
                {
                    rbmeiolote.Visible = false;
                    Label8.Visible = false;
                    edcliente.Visible = false;
                    //
                }
            }
        }
    }

    private void AtualizaGrid(String situacaopgto)
    {
        // 
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

        //dsparcelas.Clear();
        dsparcelas = uParcelas.PegaDadosParcelas2(cbproduto.Value.ToString().Trim(),
                                                 cbgrupo.Value.ToString().Trim(),
                                                 cbgrupounidades.Value.ToString().Trim(),
                                                 parte,
                                                 meiolote,
                                                 "01/01/1900",
                                                 "31/12/2999",
                                                 situacaopgto,
                                                 "0",
                                                 "N",
                                                 false,
                                                 "1");

        GridListagem.DataSource = dsparcelas;
        GridListagem.KeyFieldName = "ID";
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
        Boolean ativa = false;
        string tst = "";
        DataSet parcela;
        Double vlr_original1 = 0;
        Double vlr_original2 = 0;
        string grupounidades = cbgrupounidades.Text;
        string parte = grupounidades.Substring(grupounidades.IndexOf("-") + 1).Trim();
        string meiolote = "1";
        //
        //
        Double vlr_parcelaunitario = 0;
        Double qtd_parcelas = 0;
        Double parcela_total = 0;
        //
        Double vlr_original = 0;
        Double vlr_originalunitario = 0;
        //
        Double diferenca = 0;
        Double diferenca_apurada = 0;
        //
        DateTime proximovencimento = Convert.ToDateTime("01/01/1900");
        //

        //Criticas
        if (lOk)
        {
            tst = "";
            List<object> Listagem = GridListagem.GetSelectedFieldValues(new string[] { "ID" });
            if (Listagem.Count == 1)
            {
                foreach (Int32 xval in Listagem)
                {
                    if (tst != "")
                    {
                        tst = tst + ",";
                    }
                    tst = tst + Convert.ToString(xval);
                }
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Parcela Não Selecionada!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Parcela Não Selecionada!', 'Atenção!')", true);
            }
        }
        //
        parcela = uParcelas.PegaDadosParcelaID(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), "0", tst);
        //
        if (lOk)
        {
            //Parcela Ativa
            //Carregar Dados
            ativa = Convert.ToBoolean(parcela.Tables[0].Rows[0]["ativa"]);

            if (!ativa)
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Não é possivel Desmembrar Parcela Inativa!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Não é possivel Desmembrar Parcela Inativa!', 'Atenção!')", true);
                //Limpar Campos
            }
        }

        //
        if (lOk)
        {
            if (rbvalorparcela.SelectedIndex == 0)
            {
                //Calculo Desmembramento parcelas iguais
                //
                vlr_parcelaunitario = (Math.Round(Convert.ToDouble(edvlr_parcela1.Text), 2));
                qtd_parcelas = (Math.Round(Convert.ToDouble(edqtd_parcelas.Text), 2));
                parcela_total = Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2);
                //
                vlr_original = Math.Round(Convert.ToDouble(edvlr_original.Text), 2);
                vlr_originalunitario = (vlr_original / qtd_parcelas);
                //
                diferenca = ((vlr_parcelaunitario * qtd_parcelas) - parcela_total);
                //
                if (Math.Abs(diferenca) < .50)
                {
                    //Diferença aceitável
                    diferenca_apurada = Math.Abs(diferenca);
                    diferenca = 0;
                }
                //
                if (Math.Abs(diferenca) == 0)
                {
                    //Calcula
                    //
                    Double perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela1.Text), 2));
                    //
                    vlr_original1 = Math.Round((vlr_original / perc1));
                    //
                    edvlr_original1.Text = edvlr_original1.Text + " - " + Convert.ToString(vlr_original1);
                    //
                }
                else
                {
                    //Erro
                    lOk = false;
                    edfeedback.Text = "As parcelas * quantidade de parcelas são diferentes do Valor Total da Parcela! Diferença: " + String.Format("{0:N}", Convert.ToDouble(diferenca));
                    //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('As parcelas * quantidade de parcelas são diferentes do Valor Total da Parcela!');", true);
                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                    "toastr.info('As parcelas * quantidade de parcelas são diferentes do Valor Total da Parcela!', 'Atenção!')", true);
                }
            }
            else
            {
                //Calculo Desmembramento parcelas diferentes
                //
                //
                Double vlr_temporario = (Convert.ToDouble(edvlr_parcela_01.Text) +
                                        Convert.ToDouble(edvlr_parcela_02.Text) +
                                        Convert.ToDouble(edvlr_parcela_03.Text) +
                                        Convert.ToDouble(edvlr_parcela_04.Text) +
                                        Convert.ToDouble(edvlr_parcela_05.Text) +
                                        Convert.ToDouble(edvlr_parcela_06.Text) +
                                        Convert.ToDouble(edvlr_parcela_07.Text) +
                                        Convert.ToDouble(edvlr_parcela_08.Text) +
                                        Convert.ToDouble(edvlr_parcela_09.Text) +
                                        Convert.ToDouble(edvlr_parcela_10.Text) +
                                        Convert.ToDouble(edvlr_parcela_11.Text) +
                                        Convert.ToDouble(edvlr_parcela_12.Text));
                Double vlr_diferenca = Convert.ToDouble(edvlr_parcela.Text) - vlr_temporario;
                edvlr_original1.Text = Convert.ToString(vlr_temporario);
                edvlr_original2.Text = Convert.ToString(vlr_diferenca);
                //
                if (Math.Abs(vlr_diferenca) < .50)
                {
                    //Diferença aceitável
                    vlr_diferenca = 0;
                }
                //
                if (Math.Abs(vlr_diferenca) != 0)
                {
                    if (Math.Abs(vlr_diferenca) <= 0.50)
                    {
                        edfeedback.Text = "A Soma dos Valores são diferentes do Valor Total da Parcela! Diferença: " + String.Format("{0:N}", Convert.ToDouble(vlr_diferenca) + ", será acrescentada na 1a. parcela.");
                        edvlr_original2.Text = String.Format("{0:N}", Convert.ToDouble(vlr_diferenca));
                        btprocessa.Enabled = true;
                    }
                    else
                    {
                        //Erro
                        lOk = false;
                        edvlr_original2.Text = String.Format("{0:N}", Convert.ToDouble(vlr_diferenca));
                        edfeedback.Text = "As parcelas * quantidade de parcelas são diferentes do Valor Total da Parcela! Diferença: " + String.Format("{0:N}", Convert.ToDouble(diferenca));
                        //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('As parcelas * quantidade de parcelas são diferentes do Valor Total da Parcela!');", true);
                        ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                        "toastr.info('As parcelas * quantidade de parcelas são diferentes do Valor Total da Parcela!', 'Atenção!')", true);

                    }
                }
                else
                {
                    edfeedback.Text = "A Soma dos Valores são Iguais ao Valor Total da Parcela! Diferença: 0,00 ";
                    edvlr_original2.Text = String.Format("{0:N}", Convert.ToDouble(vlr_diferenca));
                }
                //
            }
        }

        if (lOk)
        {
            //Cliente
            grupounidades = cbgrupounidades.Text;
            parte = grupounidades.Substring(grupounidades.IndexOf("-") + 1).Trim();
            meiolote = "1";
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
            //
        }
        //
        if (lOk)
        {
            //Processa Desmembramento da Parcela
            if (rbvalorparcela.SelectedIndex == 0)
            {
                //Parcelas de valor Igual
                //
                //Parcela 1
                if (parte == "0")
                {
                    uParcelas.GravaDesmembramento(cbproduto.Value.ToString(),
                                                  cbgrupo.Value.ToString(),
                                                  cbgrupounidades.Value.ToString(),
                                                  parte,
                                                  tst,
                                                  Math.Round(Convert.ToDecimal(vlr_parcelaunitario), 2),
                                                  Math.Round(Convert.ToDecimal(vlr_originalunitario), 2));
                    //
                    //Parcela N
                    proximovencimento = Convert.ToDateTime(eddtvencimento2.Text.Substring(0, 10));
                    for (int i = 0; i < qtd_parcelas - 1; i++)
                    {
                        if (diferenca_apurada != 0)
                        {
                            //
                            Double perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(diferenca_apurada), 2));
                            //
                            Double vlr_originalunitario_apurado = Math.Round((vlr_originalunitario / perc1));
                            //
                            uParcelas.Grava(cbproduto.Value.ToString(),
                                            cbgrupo.Value.ToString(),
                                            cbgrupounidades.Value.ToString(),
                                            parte,
                                            parcela.Tables[0].Rows[0]["parcela"].ToString(),
                                            parcela.Tables[0].Rows[0]["tipo"].ToString(),
                                            proximovencimento.ToString().Substring(0, 10),
                                            Math.Round(Convert.ToDecimal(vlr_parcelaunitario + diferenca_apurada), 2),
                                            "01/01/1900",
                                            0,
                                            "01/01/1900",
                                            Convert.ToDecimal(vlr_originalunitario + vlr_originalunitario_apurado),
                                            "01/01/1900",
                                            Convert.ToDecimal(vlr_originalunitario + vlr_originalunitario_apurado),
                                            "",
                                            "",
                                            1,
                                            0,
                                            0,
                                            0,
                                            1,
                                            Convert.ToDecimal(uParametros.PegaParametro("MULTA")),
                                            Convert.ToDecimal(uParametros.PegaParametro("COMISSAO TAXA")),
                                            0,
                                            0,
                                            0,
                                            Convert.ToString(uParametros.PegaParametro("COMISSAO PERIODO")),
                                            "01/01/1900",
                                            "0",
                                            "",
                                            0,
                                            0,
                                            0,
                                            0,
                                            0,
                                            "DESMEMBRAMENTO");
                            //
                            diferenca_apurada = 0;
                        }
                        else
                        {
                            uParcelas.Grava(cbproduto.Value.ToString(),
                                            cbgrupo.Value.ToString(),
                                            cbgrupounidades.Value.ToString(),
                                            parte,
                                            parcela.Tables[0].Rows[0]["parcela"].ToString(),
                                            parcela.Tables[0].Rows[0]["tipo"].ToString(),
                                            proximovencimento.ToString().Substring(0, 10),
                                            Math.Round(Convert.ToDecimal(vlr_parcelaunitario), 2),
                                            "01/01/1900",
                                            0,
                                            "01/01/1900",
                                            Convert.ToDecimal(vlr_originalunitario),
                                            "01/01/1900",
                                            Convert.ToDecimal(vlr_originalunitario),
                                            "",
                                            "",
                                            1,
                                            0,
                                            0,
                                            0,
                                            1,
                                            Convert.ToDecimal(uParametros.PegaParametro("MULTA")),
                                            Convert.ToDecimal(uParametros.PegaParametro("COMISSAO TAXA")),
                                            0,
                                            0,
                                            0,
                                            Convert.ToString(uParametros.PegaParametro("COMISSAO PERIODO")),
                                            "01/01/1900",
                                            "0",
                                            "",
                                            0,
                                            0,
                                            0,
                                            0,
                                            0,
                                            "DESMEMBRAMENTO");
                        }
                        //
                        if (ckdatafixa.Checked == false)
                        {
                            proximovencimento = proximovencimento.AddMonths(1);
                        }
                        //
                    }



                }
                else
                {
                    uParcelas.GravaDesmembramento(cbproduto.Value.ToString(),
                                                  cbgrupo.Value.ToString(),
                                                  cbgrupounidades.Value.ToString(),
                                                  meiolote,
                                                  tst,
                                                  Math.Round(Convert.ToDecimal(vlr_parcelaunitario), 2),
                                                  Math.Round(Convert.ToDecimal(vlr_originalunitario), 2));
                    //
                    //Parcela N
                    proximovencimento = Convert.ToDateTime(eddtvencimento2.Text.Substring(0, 10));
                    for (int i = 0; i < qtd_parcelas - 1; i++)
                    {
                        uParcelas.Grava(cbproduto.Value.ToString(),
                                        cbgrupo.Value.ToString(),
                                        cbgrupounidades.Value.ToString(),
                                        meiolote,
                                        parcela.Tables[0].Rows[0]["parcela"].ToString(),
                                        parcela.Tables[0].Rows[0]["tipo"].ToString(),
                                        eddtvencimento2.Text.Substring(0, 10),
                                        Math.Round(Convert.ToDecimal(vlr_parcelaunitario), 2),
                                        "01/01/1900",
                                        0,
                                        "01/01/1900",
                                        Convert.ToDecimal(vlr_originalunitario),
                                        "01/01/1900",
                                        Convert.ToDecimal(vlr_originalunitario),
                                        "",
                                        "",
                                        1,
                                        0,
                                        0,
                                        0,
                                        1,
                                        Convert.ToDecimal(uParametros.PegaParametro("MULTA")),
                                        Convert.ToDecimal(uParametros.PegaParametro("COMISSAO TAXA")),
                                        0,
                                        0,
                                        0,
                                        Convert.ToString(uParametros.PegaParametro("COMISSAO PERIODO")),
                                        "01/01/1900",
                                        "0",
                                        "",
                                        0,
                                        0,
                                        0,
                                        0,
                                        0,
                                        "DESMEMBRAMENTO");

                        //
                        if (ckdatafixa.Checked == false)
                        {
                            proximovencimento = proximovencimento.AddMonths(1);
                        }
                        //
                    }
                }
            }
            else
            {
                //Parcelas de valor Diferente
                //
                //Parcela 1
                if (parte == "0")
                {
                    //
                    Double perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela_01.Text), 2));
                    //
                    qtd_parcelas = (Math.Round(Convert.ToDouble(edqtd_parcelas.Text), 2));
                    vlr_original = Math.Round(Convert.ToDouble(edvlr_original.Text), 2);
                    vlr_originalunitario = Math.Round((vlr_original / perc1));
                    //
                    uParcelas.GravaDesmembramento(cbproduto.Value.ToString(),
                                                  cbgrupo.Value.ToString(),
                                                  cbgrupounidades.Value.ToString(),
                                                  parte,
                                                  tst,
                                                  Math.Round(Convert.ToDecimal(edvlr_parcela_01.Text), 2),
                                                  Math.Round(Convert.ToDecimal(vlr_originalunitario), 2));
                    //
                    //Parcela N
                    proximovencimento = Convert.ToDateTime(eddtvencimento2.Text.Substring(0, 10));
                    for (int i = 0; i < qtd_parcelas - 1; i++)
                    {
                        //
                        if (i == 0)
                        {
                            perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela_02.Text), 2));
                            vlr_parcelaunitario = Math.Round(Convert.ToDouble(edvlr_parcela_02.Text));
                            vlr_originalunitario = Math.Round((vlr_original / perc1));
                        }
                        if (i == 1)
                        {
                            perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela_03.Text), 2));
                            vlr_parcelaunitario = Math.Round(Convert.ToDouble(edvlr_parcela_03.Text));
                            vlr_originalunitario = Math.Round((vlr_original / perc1));
                        }
                        if (i == 2)
                        {
                            perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela_04.Text), 2));
                            vlr_parcelaunitario = Math.Round(Convert.ToDouble(edvlr_parcela_04.Text));
                            vlr_originalunitario = Math.Round((vlr_original / perc1));
                        }
                        if (i == 3)
                        {
                            perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela_05.Text), 2));
                            vlr_parcelaunitario = Math.Round(Convert.ToDouble(edvlr_parcela_05.Text));
                            vlr_originalunitario = Math.Round((vlr_original / perc1));
                        }
                        if (i == 4)
                        {
                            perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela_06.Text), 2));
                            vlr_parcelaunitario = Math.Round(Convert.ToDouble(edvlr_parcela_06.Text));
                            vlr_originalunitario = Math.Round((vlr_original / perc1));
                        }
                        if (i == 5)
                        {
                            perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela_07.Text), 2));
                            vlr_parcelaunitario = Math.Round(Convert.ToDouble(edvlr_parcela_07.Text));
                            vlr_originalunitario = Math.Round((vlr_original / perc1));
                        }
                        if (i == 6)
                        {
                            perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela_08.Text), 2));
                            vlr_parcelaunitario = Math.Round(Convert.ToDouble(edvlr_parcela_08.Text));
                            vlr_originalunitario = Math.Round((vlr_original / perc1));
                        }
                        if (i == 7)
                        {
                            perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela_09.Text), 2));
                            vlr_parcelaunitario = Math.Round(Convert.ToDouble(edvlr_parcela_09.Text));
                            vlr_originalunitario = Math.Round((vlr_original / perc1));
                        }
                        if (i == 8)
                        {
                            perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela_10.Text), 2));
                            vlr_parcelaunitario = Math.Round(Convert.ToDouble(edvlr_parcela_10.Text));
                            vlr_originalunitario = Math.Round((vlr_original / perc1));
                        }
                        if (i == 9)
                        {
                            perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela_11.Text), 2));
                            vlr_parcelaunitario = Math.Round(Convert.ToDouble(edvlr_parcela_11.Text));
                            vlr_originalunitario = Math.Round((vlr_original / perc1));
                        }
                        if (i == 10)
                        {
                            perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela_12.Text), 2));
                            vlr_parcelaunitario = Math.Round(Convert.ToDouble(edvlr_parcela_12.Text));
                            vlr_originalunitario = Math.Round((vlr_original / perc1));
                        }
                        //
                        //
                        uParcelas.Grava(cbproduto.Value.ToString(),
                                        cbgrupo.Value.ToString(),
                                        cbgrupounidades.Value.ToString(),
                                        parte,
                                        parcela.Tables[0].Rows[0]["parcela"].ToString(),
                                        parcela.Tables[0].Rows[0]["tipo"].ToString(),
                                        proximovencimento.ToString().Substring(0, 10),
                                        Math.Round(Convert.ToDecimal(vlr_parcelaunitario), 2),
                                        "01/01/1900",
                                        0,
                                        "01/01/1900",
                                        Convert.ToDecimal(vlr_originalunitario),
                                        "01/01/1900",
                                        Convert.ToDecimal(vlr_originalunitario),
                                        "",
                                        "",
                                        1,
                                        0,
                                        0,
                                        0,
                                        1,
                                        Convert.ToDecimal(uParametros.PegaParametro("MULTA")),
                                        Convert.ToDecimal(uParametros.PegaParametro("COMISSAO TAXA")),
                                        0,
                                        0,
                                        0,
                                        Convert.ToString(uParametros.PegaParametro("COMISSAO PERIODO")),
                                        "01/01/1900",
                                        "0",
                                        "",
                                        0,
                                        0,
                                        0,
                                        0,
                                        0,
                                        "DESMEMBRAMENTO");
                        //
                        if (ckdatafixa.Checked == false)
                        {
                            proximovencimento = proximovencimento.AddMonths(1);
                        }
                        //
                    }
                }
                else
                {
                    uParcelas.GravaDesmembramento(cbproduto.Value.ToString(),
                                                  cbgrupo.Value.ToString(),
                                                  cbgrupounidades.Value.ToString(),
                                                  meiolote,
                                                  tst,
                                                  Math.Round(Convert.ToDecimal(vlr_parcelaunitario), 2),
                                                  Math.Round(Convert.ToDecimal(vlr_originalunitario), 2));
                    //
                    //Parcela N
                    proximovencimento = Convert.ToDateTime(eddtvencimento2.Text.Substring(0, 10));
                    qtd_parcelas = (Math.Round(Convert.ToDouble(edqtd_parcelas.Text), 2));
                    //
                    for (int i = 0; i < qtd_parcelas - 1; i++)
                    {
                        //
                        Double perc1 = 0;
                        vlr_original = Math.Round(Convert.ToDouble(edvlr_original.Text), 2);
                        if (i == 0)
                        {
                            perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela_02.Text), 2));
                            vlr_parcelaunitario = Math.Round(Convert.ToDouble(edvlr_parcela_02.Text));
                            vlr_originalunitario = Math.Round((vlr_original / perc1));
                        }
                        if (i == 1)
                        {
                            perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela_03.Text), 2));
                            vlr_parcelaunitario = Math.Round(Convert.ToDouble(edvlr_parcela_03.Text));
                            vlr_originalunitario = Math.Round((vlr_original / perc1));
                        }
                        if (i == 2)
                        {
                            perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela_04.Text), 2));
                            vlr_parcelaunitario = Math.Round(Convert.ToDouble(edvlr_parcela_04.Text));
                            vlr_originalunitario = Math.Round((vlr_original / perc1));
                        }
                        if (i == 3)
                        {
                            perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela_05.Text), 2));
                            vlr_parcelaunitario = Math.Round(Convert.ToDouble(edvlr_parcela_05.Text));
                            vlr_originalunitario = Math.Round((vlr_original / perc1));
                        }
                        if (i == 4)
                        {
                            perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela_06.Text), 2));
                            vlr_parcelaunitario = Math.Round(Convert.ToDouble(edvlr_parcela_06.Text));
                            vlr_originalunitario = Math.Round((vlr_original / perc1));
                        }
                        if (i == 5)
                        {
                            perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela_07.Text), 2));
                            vlr_parcelaunitario = Math.Round(Convert.ToDouble(edvlr_parcela_07.Text));
                            vlr_originalunitario = Math.Round((vlr_original / perc1));
                        }
                        if (i == 6)
                        {
                            perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela_08.Text), 2));
                            vlr_parcelaunitario = Math.Round(Convert.ToDouble(edvlr_parcela_08.Text));
                            vlr_originalunitario = Math.Round((vlr_original / perc1));
                        }
                        if (i == 7)
                        {
                            perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela_09.Text), 2));
                            vlr_parcelaunitario = Math.Round(Convert.ToDouble(edvlr_parcela_09.Text));
                            vlr_originalunitario = Math.Round((vlr_original / perc1));
                        }
                        if (i == 8)
                        {
                            perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela_10.Text), 2));
                            vlr_parcelaunitario = Math.Round(Convert.ToDouble(edvlr_parcela_10.Text));
                            vlr_originalunitario = Math.Round((vlr_original / perc1));
                        }
                        if (i == 9)
                        {
                            perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela_11.Text), 2));
                            vlr_parcelaunitario = Math.Round(Convert.ToDouble(edvlr_parcela_11.Text));
                            vlr_originalunitario = Math.Round((vlr_original / perc1));
                        }
                        if (i == 10)
                        {
                            perc1 = (Math.Round(Convert.ToDouble(edvlr_parcela.Text), 2) / Math.Round(Convert.ToDouble(edvlr_parcela_12.Text), 2));
                            vlr_parcelaunitario = Math.Round(Convert.ToDouble(edvlr_parcela_12.Text));
                            vlr_originalunitario = Math.Round((vlr_original / perc1));
                        }
                        //
                        //
                        uParcelas.Grava(cbproduto.Value.ToString(),
                                        cbgrupo.Value.ToString(),
                                        cbgrupounidades.Value.ToString(),
                                        meiolote,
                                        parcela.Tables[0].Rows[0]["parcela"].ToString(),
                                        parcela.Tables[0].Rows[0]["tipo"].ToString(),
                                        eddtvencimento2.Text.Substring(0, 10),
                                        Math.Round(Convert.ToDecimal(vlr_parcelaunitario), 2),
                                        "01/01/1900",
                                        0,
                                        "01/01/1900",
                                        Convert.ToDecimal(vlr_originalunitario),
                                        "01/01/1900",
                                        Convert.ToDecimal(vlr_originalunitario),
                                        "",
                                        "",
                                        1,
                                        0,
                                        0,
                                        0,
                                        1,
                                        Convert.ToDecimal(uParametros.PegaParametro("MULTA")),
                                        Convert.ToDecimal(uParametros.PegaParametro("COMISSAO TAXA")),
                                        0,
                                        0,
                                        0,
                                        Convert.ToString(uParametros.PegaParametro("COMISSAO PERIODO")),
                                        "01/01/1900",
                                        "0",
                                        "",
                                        0,
                                        0,
                                        0,
                                        0,
                                        0,
                                        "DESMEMBRAMENTO");

                        //
                        if (ckdatafixa.Checked == false)
                        {
                            proximovencimento = proximovencimento.AddMonths(1);
                        }
                        //
                    }
                }
            }
            //
            // CRIA LOG ===============================================================================================================================================
            if (parte == "0")
            {
                fwObs_Log = "DESMEMBRAMENTO PARCELA RAJADA: " + cbproduto.Value.ToString() + "/" + cbgrupo.Value.ToString() + "/" + cbgrupounidades.Value.ToString() + "/" + parte +
                            " QTD PARCELAS: " + qtd_parcelas.ToString();
            }
            else
            {
                fwObs_Log = "DESMEMBRAMENTO PARCELA RAJADA: " + cbproduto.Value.ToString() + "/" + cbgrupo.Value.ToString() + "/" + cbgrupounidades.Value.ToString() + "/" + meiolote +
                            " QTD PARCELAS: " + qtd_parcelas.ToString();
            }
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ), 
                                         new SqlParameter("@tabela"   , fWtabela                              ),
                                         new SqlParameter("@operacao" , "PARCELAS"                            ),
                                         new SqlParameter("@obs"      , "DESMEMBRAMENTO PARCELA RAJADA"       ),
                                         new SqlParameter("@acao"     , fwObs_Log                             ) };
            uLog.MakeLog(param_log);
            // FIM CRIA LOG ===============================================================================================================================================
            //
            //Todas
            if (rbparcelasituacao.SelectedIndex == 0)
            {
                AtualizaGrid("T");
            }
            //Pagas
            if (rbparcelasituacao.SelectedIndex == 1)
            {
                AtualizaGrid("P");
            }
            //Em Aberto
            if (rbparcelasituacao.SelectedIndex == 2)
            {
                AtualizaGrid("A");
            }
            //
            btprocessa.Enabled = false;
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Desmembramento em Rajada Registrado!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.success('Desmembramento em Rajada Registrado!', 'Atenção!')", true);

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
        //AtualizaGrid("T");

    }
    protected void GridListagem_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
    {
        //ASPxGridView gridView = (ASPxGridView)sender;

        ////
        //string produto = "";
        //string grupo = "";
        //string unidade = "";
        //string parte = "";
        //decimal metragem_total = 0;
        //decimal vlr_total = 0;
        //decimal vlr_1 = 0;
        //decimal metragem_1 = 0;
        //string inscricao_1 = "";
        //string proprietario_1 = "";
        //Boolean quitado_1 = false;
        //Boolean escritura_1 = false;
        //DateTime dtescritura_1 = Convert.ToDateTime("01/01/1900");
        //string cartorio_1 = "";
        //string livro_1 = "";
        //string folha_1 = "";
        //Boolean processo_1 = false;
        //string obs_1 = "";
        //decimal vlr_2 = 0;
        //decimal metragem_2 = 0;
        //string inscricao_2 = "";
        //string proprietario_2 = "";
        //Boolean quitado_2 = false;
        //Boolean escritura_2 = false;
        //DateTime dtescritura_2 = Convert.ToDateTime("01/01/1900");
        //string cartorio_2 = "";
        //string livro_2 = "";
        //string folha_2 = "";
        //Boolean processo_2 = false;
        //string obs_2 = "";
        ////
        //// Empresa
        //ID = e.NewValues["ID"].ToString();
        //produto = e.NewValues["produto"].ToString();
        //grupo = e.NewValues["grupo"].ToString();
        //unidade = e.NewValues["unidade"].ToString();
        //parte = e.NewValues["parte"].ToString();
        //if (e.NewValues["metragem_total"] != null)
        //    metragem_total = Convert.ToDecimal(e.NewValues["metragem_total"].ToString());
        //if (e.NewValues["vlr_total"] != null)
        //    vlr_total = Convert.ToDecimal(e.NewValues["vlr_total"].ToString());
        //if (e.NewValues["vlr_1"] != null)
        //    vlr_1 = Convert.ToDecimal(e.NewValues["vlr_1"].ToString());
        //if (e.NewValues["metragem_1"] != null)
        //    metragem_1 = Convert.ToDecimal(e.NewValues["metragem_1"].ToString());
        //if (e.NewValues["inscricao_1"] != null)
        //    inscricao_1 = e.NewValues["inscricao_1"].ToString();
        //if (e.NewValues["proprietario_1"] != null)
        //    proprietario_1 = e.NewValues["proprietario_1"].ToString();
        //if (e.NewValues["quitado_1"] != null)
        //    quitado_1 = Convert.ToBoolean(e.NewValues["quitado_1"].ToString());
        //if (e.NewValues["escritura_1"] != null)
        //    escritura_1 = Convert.ToBoolean(e.NewValues["escritura_1"].ToString());
        //if (e.NewValues["dtescritura_1"] != null)
        //    dtescritura_1 = Convert.ToDateTime(e.NewValues["dtescritura_1"].ToString());
        //if (e.NewValues["cartorio_1"] != null)
        //    cartorio_1 = e.NewValues["cartorio_1"].ToString();
        //if (e.NewValues["livro_1"] != null)
        //    livro_1 = e.NewValues["livro_1"].ToString();
        //if (e.NewValues["folha_1"] != null)
        //    folha_1 = e.NewValues["folha_1"].ToString();
        //if (e.NewValues["processo_1"] != null)
        //    processo_1 = Convert.ToBoolean(e.NewValues["processo_1"].ToString());
        //if (e.NewValues["obs_1"] != null)
        //    obs_1 = e.NewValues["obs_1"].ToString();
        //if (e.NewValues["vlr_2"] != null)
        //    vlr_2 = Convert.ToDecimal(e.NewValues["vlr_2"].ToString());
        //if (e.NewValues["metragem_2"] != null)
        //    metragem_2 = Convert.ToDecimal(e.NewValues["metragem_2"].ToString());
        //if (e.NewValues["inscricao_2"] != null)
        //    inscricao_2 = e.NewValues["inscricao_2"].ToString();
        //if (e.NewValues["proprietario_2"] != null)
        //    proprietario_2 = e.NewValues["proprietario_2"].ToString();
        //if (e.NewValues["quitado_2"] != null)
        //    quitado_2 = Convert.ToBoolean(e.NewValues["quitado_2"].ToString());
        //if (e.NewValues["escritura_2"] != null)
        //    escritura_2 = Convert.ToBoolean(e.NewValues["escritura_2"].ToString());
        //if (e.NewValues["dtescritura_2"] != null)
        //    dtescritura_2 = Convert.ToDateTime(e.NewValues["dtescritura_2"].ToString());
        //if (e.NewValues["cartorio_2"] != null)
        //    cartorio_2 = e.NewValues["cartorio_2"].ToString();
        //if (e.NewValues["livro_2"] != null)
        //    livro_2 = e.NewValues["livro_2"].ToString();
        //if (e.NewValues["folha_2"] != null)
        //    folha_2 = e.NewValues["folha_2"].ToString();
        //if (e.NewValues["processo_2"] != null)
        //    processo_2 = Convert.ToBoolean(e.NewValues["processo_2"].ToString());
        //if (e.NewValues["obs_2"] != null)
        //    obs_2 = e.NewValues["obs_2"].ToString();

        //uUnidade.Altera(ID,
        //                produto,
        //                grupo,
        //                unidade,
        //                parte,
        //                metragem_total,
        //                vlr_total,
        //                vlr_1,
        //                metragem_1,
        //                inscricao_1,
        //                proprietario_1,
        //                Convert.ToInt16(quitado_1),
        //                Convert.ToInt16(escritura_1),
        //                Convert.ToString(dtescritura_1).Substring(0, 10),
        //                cartorio_1,
        //                livro_1,
        //                folha_1,
        //                Convert.ToInt16(processo_1),
        //                obs_1,
        //                vlr_2,
        //                metragem_2,
        //                inscricao_2,
        //                proprietario_2,
        //                Convert.ToInt16(quitado_2),
        //                Convert.ToInt16(escritura_2),
        //                Convert.ToString(dtescritura_2).Substring(0, 10),
        //                cartorio_2,
        //                livro_2,
        //                folha_2,
        //                Convert.ToInt16(processo_2),
        //                obs_2);


        //gridView.CancelEdit();
        //e.Cancel = true;

        ////Usando Classe uLog.MakeLog - Gravando Log
        //fwObs_Log = "ALTERA PRODUTO UNIDADE: " + produto + "/" + grupo + "/" + unidade + "/" + parte;
        //SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
        //                             new SqlParameter("@tabela"   , fWtabela                     ),
        //                             new SqlParameter("@operacao" , "PRODUTO UNIDADE"            ),
        //                             new SqlParameter("@obs"      , "ALTERA"                     ),
        //                             new SqlParameter("@acao"     , fwObs_Log                    ) };
        //uLog.MakeLog(param_log);

        ////
        //AtualizaGrid("T");
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
        //AtualizaGrid("T");

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


    protected void rbparcelasituacao_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Todas
        if (rbparcelasituacao.SelectedIndex == 0)
        {
            GridListagem.Visible = true;
            //AtualizaGrid("T");
            AtualizaGrid("A");
        }
        //Pagas
        if (rbparcelasituacao.SelectedIndex == 1)
        {
            GridListagem.Visible = true;
            //AtualizaGrid("P");
            AtualizaGrid("A");
        }
        //Em Aberto
        if (rbparcelasituacao.SelectedIndex == 2)
        {
            GridListagem.Visible = true;
            AtualizaGrid("A");
        }
    }

    protected void btcarrega_Click(object sender, EventArgs e)
    {
        Boolean lOk = true;
        string tst = "";

        if (lOk)
        {
            //CRIAÇÃO DA VARIÁVEL DE SESSÃO COM OS ELEMENTOS SELECIONADOS NO LOOKUP  ===============================================================================================================================================
            //Empresa
            tst = "";
            List<object> Listagem = GridListagem.GetSelectedFieldValues(new string[] { "ID" });
            if (Listagem.Count == 1)
            {
                foreach (Int32 xval in Listagem)
                {
                    if (tst != "")
                    {
                        tst = tst + ",";
                    }
                    tst = tst + Convert.ToString(xval);
                }
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Parcela Não Selecionada!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Parcela Não Selecionada!', 'Atenção!')", true);

            }
            //
            //FIM CRIAÇÃO DA VARIÁVEL DE SESSÃO COM OS ELEMENTOS SELECIONADOS NO LOOKUP  ===============================================================================================================================================
        }
        if (lOk)
        {
            //Carregar Dados
            edparcela.Text = "";
            edvlr_parcela.Text = "0,00";
            eddtvencimento.Text = "";
            eddtbase.Text = "";
            edindexador.Text = "";
            edperiodicidade.Text = "";
            edvlr_parcela1.Text = "0,00";
            edqtd_parcelas.Text = "0,00";
            eddtvencimento2.Text = "";
            edfeedback.Text = "";
            edvlr_original.Text = "0,00";
            edvlr_original1.Text = "0,00";
            edvlr_original2.Text = "0,00";
            //
            edparcela.Enabled = false;
            edvlr_parcela.Enabled = false;
            eddtvencimento.Enabled = false;
            eddtbase.Enabled = false;
            edindexador.Enabled = false;
            edperiodicidade.Enabled = false;
            edvlr_parcela1.Enabled = true;
            edqtd_parcelas.Enabled = true;
            eddtvencimento2.Enabled = true;
            edfeedback.Enabled = true;
            edvlr_original.Enabled = false;
            edvlr_original1.Enabled = false;
            edvlr_original2.Enabled = false;
            //
            Label23.Visible = true;
            edparcela.Visible = true;
            Label5.Visible = true;
            edvlr_parcela.Visible = true;
            Label6.Visible = true;
            eddtvencimento.Visible = true;
            Label9.Visible = true;
            eddtbase.Visible = true;
            Label10.Visible = true;
            edindexador.Visible = true;
            Label11.Visible = true;
            edperiodicidade.Visible = true;
            Label12.Visible = true;
            edvlr_parcela1.Visible = true;
            Label14.Visible = true;
            edqtd_parcelas.Visible = true;
            Label15.Visible = true;
            eddtvencimento2.Visible = true;
            Label16.Visible = true;
            edfeedback.Visible = true;
            Label24.Visible = true;
            rbvalorparcela.Visible = true;
            edvlr_original.Visible = true;
            edvlr_original1.Visible = true;
            edvlr_original2.Visible = true;
            //
            parcela = uParcelas.PegaDadosParcelaID(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), "0", tst);
            //Carregar Dados
            edparcela.Text = parcela.Tables[0].Rows[0]["parcela"].ToString() + " / " + parcela.Tables[0].Rows[0]["tipo"].ToString();
            edvlr_parcela.Text = parcela.Tables[0].Rows[0]["vlr_parcela"].ToString();
            //
            //edvlr_original.Text = parcela.Tables[0].Rows[0]["vlr_base"].ToString(); acertar na migração
            edvlr_original.Text = parcela.Tables[0].Rows[0]["vlr_original"].ToString();
            //
            eddtvencimento.Text = parcela.Tables[0].Rows[0]["data_vencimento"].ToString().Substring(0, 10);
            eddtbase.Text = uVendas.PegaDataBase(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), "0").ToString().Substring(0, 10);
            edindexador.Text = uVendas.PegaIndexador(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), "0");
            edperiodicidade.Text = uVendas.PegaPeriodicidade(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), "0", "1");
            eddtvencimento2.Text = parcela.Tables[0].Rows[0]["data_vencimento"].ToString().Substring(0, 10);
            //
            btprocessa.Enabled = false;
            //
            edfeedback.Text = "Parcela Selecionada, preencha dos campos e clique no Botão Calcular.";
            //
            edvlr_parcela1.Focus();
            //
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
        Label4.Visible = true;
        dtvenda.Visible = true;
        dtvenda.Value = uVendas.PegaDataVenda(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), meiolote);
        //
        Label13.Visible = true;
        rbparcelasituacao.Visible = true;
        //
        rbparcelasituacao_SelectedIndexChanged(sender, e);
        //
    }
    protected void edqtd_parcelas_TextChanged(object sender, EventArgs e)
    {
        if (rbvalorparcela.SelectedIndex == 0)
        {
            //
            Double vlr_temporario = Convert.ToDouble(edvlr_parcela1.Text) * Convert.ToDouble(edqtd_parcelas.Text);
            Double vlr_diferenca = Convert.ToDouble(edvlr_parcela.Text) - vlr_temporario;
            edvlr_original1.Text = Convert.ToString(vlr_temporario);
            edvlr_original2.Text = Convert.ToString(vlr_diferenca);
            //
            //rbvalorparcela_SelectedIndexChanged(sender, e);
            //
            if (Math.Abs(vlr_diferenca) < .50)
            {
                //Diferença aceitável
                vlr_diferenca = 0;
            }
            //
            if (Math.Abs(vlr_diferenca) != 0)
            {
                if (Math.Abs(vlr_diferenca) <= 0.50)
                {
                    edfeedback.Text = "A Soma dos Valores são diferentes do Valor Total da Parcela! Diferença: " + String.Format("{0:N}", Convert.ToDouble(vlr_diferenca) + ", será acrescentada na 1a. parcela.");
                    edvlr_original2.Text = String.Format("{0:N}", Convert.ToDouble(vlr_diferenca));
                    btprocessa.Enabled = true;
                }
                else
                {
                    edfeedback.Text = "A Soma dos Valores são diferentes do Valor Total da Parcela! Diferença: " + String.Format("{0:N}", Convert.ToDouble(vlr_diferenca));
                    edvlr_original2.Text = String.Format("{0:N}", Convert.ToDouble(vlr_diferenca));
                    btprocessa.Enabled = false;
                }
            }
            else
            {
                edfeedback.Text = "A Soma dos Valores são Iguais ao Valor Total da Parcela! Diferença: 0,00 ";
                edvlr_original2.Text = String.Format("{0:N}", Convert.ToDouble(vlr_diferenca));
                btprocessa.Enabled = true;
            }
        }
        else
        {
            //
            Double vlr_temporario = (Convert.ToDouble(edvlr_parcela_01.Text) +
                                    Convert.ToDouble(edvlr_parcela_02.Text) +
                                    Convert.ToDouble(edvlr_parcela_03.Text) +
                                    Convert.ToDouble(edvlr_parcela_04.Text) +
                                    Convert.ToDouble(edvlr_parcela_05.Text) +
                                    Convert.ToDouble(edvlr_parcela_06.Text) +
                                    Convert.ToDouble(edvlr_parcela_07.Text) +
                                    Convert.ToDouble(edvlr_parcela_08.Text) +
                                    Convert.ToDouble(edvlr_parcela_09.Text) +
                                    Convert.ToDouble(edvlr_parcela_10.Text) +
                                    Convert.ToDouble(edvlr_parcela_11.Text) +
                                    Convert.ToDouble(edvlr_parcela_12.Text));
            Double vlr_diferenca = Convert.ToDouble(edvlr_parcela.Text) - vlr_temporario;
            edvlr_original1.Text = Convert.ToString(vlr_temporario);
            edvlr_original2.Text = Convert.ToString(vlr_diferenca);
            //
            //rbvalorparcela_SelectedIndexChanged(sender, e);
            //
            if (Math.Abs(vlr_diferenca) < .50)
            {
                //Diferença aceitável
                vlr_diferenca = 0;
            }
            //
            if (Math.Abs(vlr_diferenca) != 0)
            {
                if (Math.Abs(vlr_diferenca) <= 0.50)
                {
                    edfeedback.Text = "A Soma dos Valores são diferentes do Valor Total da Parcela! Diferença: " + String.Format("{0:N}", Convert.ToDouble(vlr_diferenca) + ", será acrescentada na 1a. parcela.");
                    edvlr_original2.Text = String.Format("{0:N}", Convert.ToDouble(vlr_diferenca));
                    btprocessa.Enabled = true;
                }
                else
                {
                    edfeedback.Text = "A Soma dos Valores são diferentes do Valor Total da Parcela! Diferença: " + String.Format("{0:N}", Convert.ToDouble(vlr_diferenca));
                    edvlr_original2.Text = String.Format("{0:N}", Convert.ToDouble(vlr_diferenca));
                    btprocessa.Enabled = false;
                }
            }
            else
            {
                edfeedback.Text = "A Soma dos Valores são Iguais ao Valor Total da Parcela! Diferença: 0,00 ";
                edvlr_original2.Text = String.Format("{0:N}", Convert.ToDouble(vlr_diferenca));
                btprocessa.Enabled = true;
            }
            //
            edvlr_parcela_01.Enabled = false;
            edvlr_parcela_02.Enabled = false;
            edvlr_parcela_03.Enabled = false;
            edvlr_parcela_04.Enabled = false;
            edvlr_parcela_05.Enabled = false;
            edvlr_parcela_06.Enabled = false;
            edvlr_parcela_07.Enabled = false;
            edvlr_parcela_08.Enabled = false;
            edvlr_parcela_09.Enabled = false;
            edvlr_parcela_10.Enabled = false;
            edvlr_parcela_11.Enabled = false;
            edvlr_parcela_12.Enabled = false;
            //
            if ((Convert.ToInt16(edqtd_parcelas.Text) > 0) && (Convert.ToInt16(edqtd_parcelas.Text) < 13))
            {
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 1)
                {
                    //edvlr_parcela_01.Text = "0";
                    edvlr_parcela_01.Enabled = true;
                }
                //
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 2)
                {
                    //edvlr_parcela_02.Text = "0";
                    edvlr_parcela_02.Enabled = true;
                }
                //
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 3)
                {
                    //edvlr_parcela_03.Text = "0";
                    edvlr_parcela_03.Enabled = true;
                }
                //
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 4)
                {
                    //edvlr_parcela_04.Text = "0";
                    edvlr_parcela_04.Enabled = true;
                }
                //
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 5)
                {
                    //edvlr_parcela_05.Text = "0";
                    edvlr_parcela_05.Enabled = true;
                }
                //
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 6)
                {
                    //edvlr_parcela_06.Text = "0";
                    edvlr_parcela_06.Enabled = true;
                }
                //
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 7)
                {
                    //edvlr_parcela_07.Text = "0";
                    edvlr_parcela_07.Enabled = true;
                }
                //
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 8)
                {
                    //edvlr_parcela_08.Text = "0";
                    edvlr_parcela_08.Enabled = true;
                }
                //
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 9)
                {
                    //edvlr_parcela_09.Text = "0";
                    edvlr_parcela_09.Enabled = true;
                }
                //
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 10)
                {
                    //edvlr_parcela_10.Text = "0";
                    edvlr_parcela_10.Enabled = true;
                }
                //
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 11)
                {
                    //edvlr_parcela_11.Text = "0";
                    edvlr_parcela_11.Enabled = true;
                }
                //
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 12)
                {
                    //edvlr_parcela_12.Text = "0";
                    edvlr_parcela_12.Enabled = true;
                }
            }
            //

        }
    }

    protected void rbvalorparcela_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rbvalorparcela.SelectedIndex == 0)
        {
            //
            Label12.Visible = true;
            edvlr_parcela1.Visible = true;
            edvlr_original1.Visible = true;
            Label14.Visible = true;
            edqtd_parcelas.Visible = true;
            edvlr_original2.Visible = true;
            Label15.Visible = true;
            eddtvencimento2.Visible = true;
            Label16.Visible = true;
            edfeedback.Visible = true;
            Label17.Visible = false;
            edvlr_parcela_01.Visible = false;
            edvlr_parcela_02.Visible = false;
            edvlr_parcela_03.Visible = false;
            edvlr_parcela_04.Visible = false;
            edvlr_parcela_05.Visible = false;
            edvlr_parcela_06.Visible = false;
            edvlr_parcela_07.Visible = false;
            edvlr_parcela_08.Visible = false;
            edvlr_parcela_09.Visible = false;
            edvlr_parcela_10.Visible = false;
            edvlr_parcela_11.Visible = false;
            edvlr_parcela_12.Visible = false;
            //
            //Valores iguais
            Decimal vlr_temporario = 0;
            Decimal vlr_diferenca = 0;
            //
            if ((Convert.ToDecimal(edvlr_parcela.Text) != 0) && (Convert.ToDecimal(edqtd_parcelas.Text) != 0))
            {
                vlr_temporario = Convert.ToDecimal(edvlr_parcela.Text) / Convert.ToDecimal(edqtd_parcelas.Text);
                vlr_diferenca = Convert.ToDecimal(edvlr_parcela.Text) - (vlr_temporario * Convert.ToDecimal(edqtd_parcelas.Text));
                //
                if (rbvalorparcela.SelectedIndex == 0)
                {
                    edvlr_original1.Text = Convert.ToString(vlr_temporario);
                    edvlr_original2.Text = Convert.ToString(vlr_diferenca);
                }
                else
                {

                }
            }
            edqtd_parcelas_TextChanged(sender, e);
        }
        else
        {
            //
            Label12.Visible = false;
            edvlr_parcela1.Visible = false;
            edvlr_original1.Visible = false;
            Label14.Visible = true;
            edqtd_parcelas.Visible = true;
            edvlr_original2.Visible = true;
            Label15.Visible = true;
            eddtvencimento2.Visible = true;
            Label16.Visible = true;
            edfeedback.Visible = true;
            Label17.Visible = true;
            edvlr_parcela_01.Visible = true;
            edvlr_parcela_02.Visible = true;
            edvlr_parcela_03.Visible = true;
            edvlr_parcela_04.Visible = true;
            edvlr_parcela_05.Visible = true;
            edvlr_parcela_06.Visible = true;
            edvlr_parcela_07.Visible = true;
            edvlr_parcela_08.Visible = true;
            edvlr_parcela_09.Visible = true;
            edvlr_parcela_10.Visible = true;
            edvlr_parcela_11.Visible = true;
            edvlr_parcela_12.Visible = true;
            //
            edvlr_parcela_01.Enabled = false;
            edvlr_parcela_02.Enabled = false;
            edvlr_parcela_03.Enabled = false;
            edvlr_parcela_04.Enabled = false;
            edvlr_parcela_05.Enabled = false;
            edvlr_parcela_06.Enabled = false;
            edvlr_parcela_07.Enabled = false;
            edvlr_parcela_08.Enabled = false;
            edvlr_parcela_09.Enabled = false;
            edvlr_parcela_10.Enabled = false;
            edvlr_parcela_11.Enabled = false;
            edvlr_parcela_12.Enabled = false;
            //
            edvlr_parcela_01.Text = "0";
            edvlr_parcela_02.Text = "0";
            edvlr_parcela_03.Text = "0";
            edvlr_parcela_04.Text = "0";
            edvlr_parcela_05.Text = "0";
            edvlr_parcela_06.Text = "0";
            edvlr_parcela_07.Text = "0";
            edvlr_parcela_08.Text = "0";
            edvlr_parcela_09.Text = "0";
            edvlr_parcela_10.Text = "0";
            edvlr_parcela_11.Text = "0";
            edvlr_parcela_12.Text = "0";
            //
            //Valores Diferentes
            //
            edvlr_parcela_01.Enabled = false;
            edvlr_parcela_02.Enabled = false;
            edvlr_parcela_03.Enabled = false;
            edvlr_parcela_04.Enabled = false;
            edvlr_parcela_05.Enabled = false;
            edvlr_parcela_06.Enabled = false;
            edvlr_parcela_07.Enabled = false;
            edvlr_parcela_08.Enabled = false;
            edvlr_parcela_09.Enabled = false;
            edvlr_parcela_10.Enabled = false;
            edvlr_parcela_11.Enabled = false;
            edvlr_parcela_12.Enabled = false;
            //
            if ((Convert.ToInt16(edqtd_parcelas.Text) > 0) && (Convert.ToInt16(edqtd_parcelas.Text) < 13))
            {
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 1)
                {
                    edvlr_parcela_01.Text = "0";
                    edvlr_parcela_01.Enabled = true;
                }
                //
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 2)
                {
                    edvlr_parcela_02.Text = "0";
                    edvlr_parcela_02.Enabled = true;
                }
                //
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 3)
                {
                    edvlr_parcela_03.Text = "0";
                    edvlr_parcela_03.Enabled = true;
                }
                //
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 4)
                {
                    edvlr_parcela_04.Text = "0";
                    edvlr_parcela_04.Enabled = true;
                }
                //
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 5)
                {
                    edvlr_parcela_05.Text = "0";
                    edvlr_parcela_05.Enabled = true;
                }
                //
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 6)
                {
                    edvlr_parcela_06.Text = "0";
                    edvlr_parcela_06.Enabled = true;
                }
                //
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 7)
                {
                    edvlr_parcela_07.Text = "0";
                    edvlr_parcela_07.Enabled = true;
                }
                //
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 8)
                {
                    edvlr_parcela_08.Text = "0";
                    edvlr_parcela_08.Enabled = true;
                }
                //
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 9)
                {
                    edvlr_parcela_09.Text = "0";
                    edvlr_parcela_09.Enabled = true;
                }
                //
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 10)
                {
                    edvlr_parcela_10.Text = "0";
                    edvlr_parcela_10.Enabled = true;
                }
                //
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 11)
                {
                    edvlr_parcela_11.Text = "0";
                    edvlr_parcela_11.Enabled = true;
                }
                //
                if (Convert.ToInt16(edqtd_parcelas.Text) >= 12)
                {
                    edvlr_parcela_12.Text = "0";
                    edvlr_parcela_12.Enabled = true;
                }
            }
            //


        }
    }
    protected void edvlr_parcela1_TextChanged(object sender, EventArgs e)
    {
        edqtd_parcelas_TextChanged(sender, e);
    }
    protected void edvlr_parcela_01_TextChanged(object sender, EventArgs e)
    {
        edqtd_parcelas_TextChanged(sender, e);
    }
    protected void edvlr_parcela_02_TextChanged(object sender, EventArgs e)
    {
        edqtd_parcelas_TextChanged(sender, e);
    }
    protected void edvlr_parcela_03_TextChanged(object sender, EventArgs e)
    {
        edqtd_parcelas_TextChanged(sender, e);
    }
    protected void edvlr_parcela_04_TextChanged(object sender, EventArgs e)
    {
        edqtd_parcelas_TextChanged(sender, e);
    }
    protected void edvlr_parcela_05_TextChanged(object sender, EventArgs e)
    {
        edqtd_parcelas_TextChanged(sender, e);
    }
    protected void edvlr_parcela_06_TextChanged(object sender, EventArgs e)
    {
        edqtd_parcelas_TextChanged(sender, e);
    }
    protected void edvlr_parcela_07_TextChanged(object sender, EventArgs e)
    {
        edqtd_parcelas_TextChanged(sender, e);
    }
    protected void edvlr_parcela_08_TextChanged(object sender, EventArgs e)
    {
        edqtd_parcelas_TextChanged(sender, e);
    }
    protected void edvlr_parcela_09_TextChanged(object sender, EventArgs e)
    {
        edqtd_parcelas_TextChanged(sender, e);
    }
    protected void edvlr_parcela_10_TextChanged(object sender, EventArgs e)
    {
        edqtd_parcelas_TextChanged(sender, e);
    }
    protected void edvlr_parcela_11_TextChanged(object sender, EventArgs e)
    {
        edqtd_parcelas_TextChanged(sender, e);
    }
    protected void edvlr_parcela_12_TextChanged(object sender, EventArgs e)
    {
        edqtd_parcelas_TextChanged(sender, e);
    }
    protected void ckdatafixa_CheckedChanged(object sender, EventArgs e)
    {
        if (ckdatafixa.Checked == false)
        {
            eddtvencimento2.Date = DateTime.Now;
            eddtvencimento2.Enabled = true;
        }
        else
        {
            eddtvencimento2.Date = Convert.ToDateTime(eddtvencimento.Text);
            eddtvencimento2.Enabled = false;
        }
    }
}

﻿using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FParcelasRajada : System.Web.UI.Page
{
    DataSet dsparcelas;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "PARCELAS";

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
                    rbparcelasituacao.Enabled = false;
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
                                                 "0");
        GridListagem.DataSource = dsparcelas;
        GridListagem.KeyFieldName = "ID";
        GridListagem.DataBind();
        btcarrega.Enabled = true;
        btprocessa.Enabled = false;
        //
        //Limpa Dados
        edvlr_parcela.Text = "0,00";
        eddtpagamento.Value = DateTime.Now;
        edfeedback.Text = "";
        //
        edvlr_parcela.Enabled = false;
        eddtpagamento.Enabled = true;
        edfeedback.Enabled = true;
        //
        Label5.Visible = true;
        edvlr_parcela.Visible = true;
        Label11.Visible = true;
        edqtdparcelas.Visible = true;
        Label6.Visible = true;
        edvlr_pagamento.Visible = true;
        edvlr_diferenca.Visible = true;
        edperc_diferenca.Visible = true;
        Label10.Visible = true;
        Label9.Visible = true;
        eddtpagamento.Visible = true;
        Label21.Visible = true;
        cbformapagamento.Visible = true;
        Label22.Visible = true;
        cbcontascorrentes.Visible = true;
        Label24.Visible = true;
        edfeedback.Visible = true;
        //
        uParcelas.MontaComboFormaPagamento(cbformapagamento, false);
        uContas.MontaComboContas(cbcontascorrentes, "0");
        //
        cbformapagamento.Text = "";
        cbcontascorrentes.Text = "";
        //
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
        string tst = "";
        string contacorrente = "";
        string formapagamento = "";
        //
        DataSet parcela;
        string ID_parcela = "";
        decimal multa = 0;
        decimal juros = 0;
        decimal desconto = 0;
        decimal correcao = 0;
        decimal vlr_parcela = 0;
        decimal vlr_pago = 0;
        //Cliente
        string grupounidades = cbgrupounidades.Text;
        string parte = grupounidades.Substring(grupounidades.IndexOf("-") + 1).Trim();
        string meiolote = "1";
        //
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

        if (lOk)
        {
            tst = "";
            List<object> Listagem = GridListagem.GetSelectedFieldValues(new string[] { "ID" });
            if (Listagem.Count > 0)
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
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Parcelas Não Selecionadas!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Parcelas Não Selecionadas!', 'Atenção!')", true);

            }
        }
        //Criticas
        if (lOk)
        {
            //Check de Conta Corrente
            if (cbcontascorrentes.Text != string.Empty)
            {
                contacorrente = cbcontascorrentes.Value.ToString();
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione uma Conta!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Selecione uma Conta!', 'Atenção!')", true);
            }
            //Fim Check de Conta Corrente
        }
        if (lOk)
        {
            //Check de Forma de Pagamento
            if (cbformapagamento.Text != string.Empty)
            {
                formapagamento = cbformapagamento.Value.ToString();
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione uma Forma de Pagamento!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Selecione uma Forma de Pagamento!', 'Atenção!')", true);
            }
            //Fim Check de Forma de Pagamento
        }
        //
        if (lOk)
        {
            //Processa Pagamento das Parcelas
            //
            if (parte == "0")
            {
                parcela = uParcelas.PegaDadosParcelaID(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte, tst);
            }
            else
            {
                parcela = uParcelas.PegaDadosParcelaID(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), meiolote, tst);
            }
            //
            //
            for (int i = 0; i < parcela.Tables[0].Rows.Count; i++)
            {
                //
                ID_parcela = parcela.Tables[0].Rows[i]["ID"].ToString();
                multa = 0;
                juros = 0;
                desconto = 0;
                correcao = 0;
                vlr_parcela = 0;
                vlr_pago = 0;
                vlr_parcela = Convert.ToDecimal(parcela.Tables[0].Rows[i]["vlr_parcela"]);
                //
                if (Convert.ToDouble(edvlr_parcela.Text) > Convert.ToDouble(edvlr_pagamento.Text))
                {
                    //Valores Parcela maior que o Pagamento
                    //
                    vlr_pago = (vlr_parcela * ((Convert.ToDecimal(edperc_diferenca.Text) / 100) - 1));
                    if (vlr_pago < 0)
                    {
                        vlr_pago = vlr_pago * -1;
                    }
                    //
                    if (vlr_pago > vlr_parcela)
                    {
                        correcao = vlr_pago - vlr_parcela;
                    }
                    else
                    {
                        desconto = vlr_parcela - vlr_pago;
                    }
                }
                else
                {
                    //Valores Parcela Menor que o Pagamento
                    //
                    vlr_pago = (vlr_parcela * ((Convert.ToDecimal(edperc_diferenca.Text) / 100) + 1));
                    if (vlr_pago < 0)
                    {
                        vlr_pago = vlr_pago * -1;
                    }
                    //
                    if (vlr_pago < vlr_parcela)
                    {
                        desconto = vlr_parcela - vlr_pago;
                    }
                    else
                    {
                        correcao = vlr_pago - vlr_parcela;
                    }
                    //
                }
                //
                if (parte == "0")
                {
                    uParcelas.GravaPagamento(cbproduto.Value.ToString(),
                                             cbgrupo.Value.ToString(),
                                             cbgrupounidades.Value.ToString(),
                                             parte,
                                             ID_parcela,
                                             eddtpagamento.Value.ToString(),
                                             vlr_pago,
                                             cbformapagamento.Value.ToString(),
                                             multa,
                                             juros,
                                             desconto,
                                             DateTime.Now.ToString().Substring(0, 10),
                                             cbcontascorrentes.Value.ToString(),
                                             correcao);
                }
                else
                {
                    uParcelas.GravaPagamento(cbproduto.Value.ToString(),
                                             cbgrupo.Value.ToString(),
                                             cbgrupounidades.Value.ToString(),
                                             meiolote,
                                             ID_parcela,
                                             eddtpagamento.Value.ToString(),
                                             vlr_pago,
                                             cbformapagamento.Value.ToString(),
                                             multa,
                                             juros,
                                             desconto,
                                             DateTime.Now.ToString().Substring(0, 10),
                                             cbcontascorrentes.Value.ToString(),
                                             correcao);
                }
                //
                // CRIA LOG ===============================================================================================================================================
                fwObs_Log = "PAGAMENTO PARCELA: " + cbproduto.Value.ToString() +
                                                "/" + cbgrupo.Value.ToString() +
                                                "/" + cbgrupounidades.Value.ToString() +
                                                "/" + parte + "/" + meiolote +
                                                " PARCELA ID: " + tst;
                //
                SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ), 
                                             new SqlParameter("@tabela"   , fWtabela                              ),
                                             new SqlParameter("@operacao" , "PARCELAS"                            ),
                                             new SqlParameter("@obs"      , "PAGAMENTO PARCELA"                   ),
                                             new SqlParameter("@acao"     , fwObs_Log                             ) };
                uLog.MakeLog(param_log);
                // FIM CRIA LOG ===============================================================================================================================================
                //
            }
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
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Pagamento Registrado!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.success('Pagamento Registrado!', 'Atenção!')", true);
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
            //Todas
            GridListagem.Visible = true;
            AtualizaGrid("T");
        }
        //Pagas
        if (rbparcelasituacao.SelectedIndex == 1)
        {
            //Pagas
            GridListagem.Visible = true;
            AtualizaGrid("P");
        }
        //Em Aberto
        if (rbparcelasituacao.SelectedIndex == 2)
        {
            //Em Aberto
            GridListagem.Visible = true;
            AtualizaGrid("A");
        }
    }

    protected void btcarrega_Click(object sender, EventArgs e)
    {
        Boolean lOk = true;
        string tst = "";
        DataSet parcela;
        string contaproduto = uProduto.PegaProdutoConta(Convert.ToInt16(cbproduto.Value));
        string descricaoconta = "";
        Double totalparcelas = 0;
        Int32 qtdparcelas = 0;
        //
        if (lOk)
        {
            //Parcelas
            tst = "";
            List<object> Listagem = GridListagem.GetSelectedFieldValues(new string[] { "ID" });
            if (Listagem.Count > 0)
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
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Parcelas Não Selecionadas!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Parcelas Não Selecionadas!', 'Atenção!')", true);

            }
            //
        }

        if (lOk)
        {
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
            //Carregar Dados
            edvlr_parcela.Text = "0,00";
            eddtpagamento.Value = DateTime.Now;
            edfeedback.Text = "";
            //
            edvlr_parcela.Enabled = false;
            eddtpagamento.Enabled = true;
            edfeedback.Enabled = true;
            //
            Label5.Visible = true;
            edvlr_parcela.Visible = true;
            Label11.Visible = true;
            edqtdparcelas.Visible = true;
            Label6.Visible = true;
            edvlr_pagamento.Visible = true;
            edvlr_diferenca.Visible = true;
            edperc_diferenca.Visible = true;
            Label10.Visible = true;
            Label9.Visible = true;
            eddtpagamento.Visible = true;
            Label21.Visible = true;
            cbformapagamento.Visible = true;
            Label22.Visible = true;
            cbcontascorrentes.Visible = true;
            Label24.Visible = true;
            edfeedback.Visible = true;
            //
            uParcelas.MontaComboFormaPagamento(cbformapagamento, false);
            uContas.MontaComboContas(cbcontascorrentes, "0");
            //
            descricaoconta = uContas.PegaContaDescricaoSimples(contaproduto);
            cbcontascorrentes.Text = Srelib.QStr0(contaproduto.ToString().Trim(), 5) + " - " + descricaoconta;
            //
            if (parte == "0")
            {
                parcela = uParcelas.PegaDadosParcelaID(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte, tst);
            }
            else
            {
                parcela = uParcelas.PegaDadosParcelaID(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), meiolote, tst);
            }
            //
            totalparcelas = 0;
            qtdparcelas = 0;
            for (int i = 0; i < parcela.Tables[0].Rows.Count; i++)
            {
                totalparcelas = totalparcelas + Convert.ToDouble(parcela.Tables[0].Rows[0]["vlr_parcela"]);
                qtdparcelas++;
            }
            edvlr_parcela.Text = totalparcelas.ToString();
            edvlr_pagamento.Text = totalparcelas.ToString();
            edqtdparcelas.Text = qtdparcelas.ToString();
            edvlr_diferenca.Text = "0";
            edperc_diferenca.Text = "0";
            //
            btprocessa.Enabled = true;
            //
            edfeedback.Text = "Parcelas Totalizadas, preencha dos campos e clique no Botão Processar.";
            //
            edvlr_pagamento.Focus();
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
        rbparcelasituacao.Enabled = false;
        //
        rbparcelasituacao_SelectedIndexChanged(sender, e);
        //

    }
    protected void edvlr_pagamento_TextChanged(object sender, EventArgs e)
    {
        //
        if (Convert.ToDouble(edvlr_parcela.Text) == Convert.ToDouble(edvlr_pagamento.Text))
        {
            //Valores Iguais
            //
            edvlr_diferenca.Text = "0";
            edperc_diferenca.Text = "0";
        }
        else
        {
            if (Convert.ToDouble(edvlr_parcela.Text) > Convert.ToDouble(edvlr_pagamento.Text))
            {
                //Valores Parcela maior que o Pagamento
                //
                edvlr_diferenca.Text = ((Convert.ToDouble(edvlr_parcela.Text) - Convert.ToDouble(edvlr_pagamento.Text)) * -1).ToString();
                edperc_diferenca.Text = ((((Convert.ToDouble(edvlr_parcela.Text) -
                                          Convert.ToDouble(edvlr_pagamento.Text)) /
                                         (Convert.ToDouble(edvlr_parcela.Text))) * 100) * -1).ToString();

            }
            else
            {
                //Valores Parcela Menor que o Pagamento
                //
                edvlr_diferenca.Text = (Convert.ToDouble(edvlr_parcela.Text) - Convert.ToDouble(edvlr_pagamento.Text)).ToString();
                edperc_diferenca.Text = (((Convert.ToDouble(edvlr_parcela.Text) -
                                          Convert.ToDouble(edvlr_pagamento.Text)) /
                                         (Convert.ToDouble(edvlr_parcela.Text))) * 100).ToString();

            }
        }
    }

}


using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FParcelasProprietario : System.Web.UI.Page
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
                    Label28.Visible = true;
                    edcorrecao.Visible = true;
                    edcorrecao.Text = "";
                    edcorrecao.Text = edcorrecao.Text + uVendas.PegaPeriodicidade(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte, "1");
                    edcorrecao.Text = edcorrecao.Text + " - " + uVendas.PegaIndexador(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte);
                    edcorrecao.Text = edcorrecao.Text + " - BASE: " + uVendas.PegaDataBase(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte).ToString().Substring(0, 10);
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
                                                 "0");
        GridListagem.DataSource = dsparcelas;
        GridListagem.KeyFieldName = "ID";
        GridListagem.DataBind();
        btcarrega.Enabled = true;
        btcalcula.Enabled = false;
        btprocessa.Enabled = false;
        //
        //Limpa Dados
        edparcela.Text = "";
        edvlr_parcela.Text = "0,00";
        eddtvencimento.Text = "";
        eddtpagamento.Text = DateTime.Now.ToString().Substring(0, 10);
        edvlr_correcao.Text = "0,00";
        edindexador_acum.Text = "";
        edindexador_acum2.Text = "";
        edvlr_juros.Text = "0,00";
        edjuros_acum.Text = "0,00";
        edjuros_acum2.Text = "";
        edvlr_multa.Text = "0,00";
        edtaxa_multa.Text = "0,00";
        edvlr_pagamento.Text = "0,00";
        eddiferenca.Text = "0,00";
        edvlr_desconto.Text = "0,00";
        edvlr_pagofinal.Text = "0,00";
        edfeedback.Text = "";
        //
        edparcela.Enabled = false;
        edvlr_parcela.Enabled = false;
        eddtvencimento.Enabled = false;
        eddtpagamento.Enabled = true;
        edvlr_correcao.Enabled = false;
        edindexador_acum.Enabled = false;
        edindexador_acum2.Enabled = false;
        edvlr_juros.Enabled = false;
        edjuros_acum.Enabled = false;
        edjuros_acum2.Enabled = false;
        edvlr_multa.Enabled = false;
        edtaxa_multa.Enabled = false;
        edvlr_pagamento.Enabled = true;
        eddiferenca.Enabled = false;
        edvlr_desconto.Enabled = true;
        edvlr_pagofinal.Enabled = false;
        edfeedback.Enabled = true;
        //
        Label23.Visible = true;
        edparcela.Visible = true;
        Label5.Visible = true;
        edvlr_parcela.Visible = true;
        Label6.Visible = true;
        eddtvencimento.Visible = true;
        Label9.Visible = true;
        eddtpagamento.Visible = true;
        Label10.Visible = true;
        edvlr_correcao.Visible = true;
        Label25.Visible = true;
        rbrecibo.Visible = true;
        Label11.Visible = true;
        edindexador_acum.Visible = true;
        edindexador_acum2.Visible = true;
        Label12.Visible = true;
        edvlr_juros.Visible = true;
        Label14.Visible = true;
        edjuros_acum.Visible = true;
        edjuros_acum2.Visible = true;
        Label15.Visible = true;
        edvlr_multa.Visible = true;
        Label16.Visible = true;
        edtaxa_multa.Visible = true;
        Label17.Visible = true;
        edvlr_pagamento.Visible = true;
        Label18.Visible = true;
        eddiferenca.Visible = true;
        Label19.Visible = true;
        edvlr_desconto.Visible = true;
        Label20.Visible = true;
        edvlr_pagofinal.Visible = true;
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
            //Processa Pagamento da Parcela
            if (parte == "0")
            {
                uParcelas.GravaPagamento(cbproduto.Value.ToString(),
                                         cbgrupo.Value.ToString(),
                                         cbgrupounidades.Value.ToString(),
                                         parte,
                                         tst,
                                         eddtpagamento.Value.ToString(),
                                         Convert.ToDecimal(edvlr_pagofinal.Text),
                                         cbformapagamento.Value.ToString(),
                                         Convert.ToDecimal(edvlr_multa.Text),
                                         Convert.ToDecimal(edvlr_juros.Text),
                                         Convert.ToDecimal(edvlr_desconto.Text),
                                         DateTime.Now.ToString().Substring(0, 10),
                                         cbcontascorrentes.Value.ToString(),
                                         Convert.ToDecimal(edvlr_correcao.Text));
            }
            else
            {
                uParcelas.GravaPagamento(cbproduto.Value.ToString(),
                                         cbgrupo.Value.ToString(),
                                         cbgrupounidades.Value.ToString(),
                                         meiolote,
                                         tst,
                                         eddtpagamento.Value.ToString(),
                                         Convert.ToDecimal(edvlr_pagofinal.Text),
                                         cbformapagamento.Value.ToString(),
                                         Convert.ToDecimal(edvlr_multa.Text),
                                         Convert.ToDecimal(edvlr_juros.Text),
                                         Convert.ToDecimal(edvlr_desconto.Text),
                                         DateTime.Now.ToString().Substring(0, 10),
                                         cbcontascorrentes.Value.ToString(),
                                         Convert.ToDecimal(edvlr_correcao.Text));
            }
            //
            // CRIA LOG ===============================================================================================================================================
            fwObs_Log = "PAGAMENTO PARCELA: " + cbproduto.Value.ToString() + "/" + cbgrupo.Value.ToString() + "/" + cbgrupounidades.Value.ToString() + "/" + parte + "/" + meiolote +
                        " PARCELA ID: " + tst;
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ),
                                         new SqlParameter("@tabela"   , fWtabela                              ),
                                         new SqlParameter("@operacao" , "PARCELAS"                            ),
                                         new SqlParameter("@obs"      , "PAGAMENTO PARCELA"                   ),
                                         new SqlParameter("@acao"     , fwObs_Log                             ) };
            uLog.MakeLog(param_log);
            // FIM CRIA LOG ===============================================================================================================================================
            //
            //Variáveis de Sessão para Recibo
            Session.Remove("cbproduto");
            Session.Add("cbproduto", cbproduto.Value.ToString().Trim());
            Session.Remove("cbgrupo");
            Session.Add("cbgrupo", cbgrupo.Value.ToString().Trim());
            Session.Remove("cbgrupounidades");
            Session.Add("cbgrupounidades", cbgrupounidades.Value.ToString().Trim());
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
            Session.Remove("id");
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
                Session.Add("id", tst);
            }
            Session.Remove("cbcontascorrentes");
            contacorrente = cbcontascorrentes.Value.ToString();
            Session.Add("cbcontascorrentes", cbcontascorrentes.Value.ToString());
            Session.Remove("cbformapagamento");
            formapagamento = cbformapagamento.Value.ToString();
            Session.Add("cbformapagamento", cbformapagamento.Value.ToString());
            //Variáveis de Sessão para Recibo
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
            btimprime.Enabled = true;
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

    protected void btcalcula_Click(object sender, EventArgs e)
    {
        //
        Boolean lOk = true;
        Boolean ativa = false;
        string tst = "";
        DataSet parcela;
        //
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
        if (lOk)
        {
            //Parcela Ativa
            //Carregar Dados
            ativa = Convert.ToBoolean(parcela.Tables[0].Rows[0]["ativa"]);

            if (!ativa)
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Não é possivel Pagar Parcela Inativa!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Não é possivel Pagar Parcela Inativa!', 'Atenção!')", true);
                //Limpar Campos
            }
        }
        //
        if (lOk)
        {
            //
            string vlrcorrecao = "0";
            string vlrjuros = "0";
            string vlrmulta = "0";
            string vlrdesconto = "0";
            string vlrpagamento = "0";
            string vlrpagamentofinal = "0";
            Boolean btprocessa = false;
            string edfeedback = "";
            string edindexadoracum = "";
            string periodicidade_comissao = "";
            string juros = "0";
            string taxamulta = "0";
            string diferencadias = "0";
            //
            uCorrecoes.CorrecaoParcela(cbproduto.Value.ToString(),
                                       cbgrupo.Value.ToString(),
                                       cbgrupounidades.Value.ToString(),
                                       parte,
                                       meiolote,
                                       Convert.ToDateTime(eddtvencimento.Text),
                                       Convert.ToDateTime(eddtpagamento.Text),
                                       edvlr_parcela.Text,
                                       ref vlrcorrecao,
                                       ref vlrjuros,
                                       ref vlrmulta,
                                       ref vlrdesconto,
                                       ref vlrpagamento,
                                       ref vlrpagamentofinal,
                                       ref btprocessa,
                                       ref edfeedback,
                                       ref edindexadoracum,
                                       edjuros_acum2.Text,
                                       edjuros_acum.Text,
                                       edtaxa_multa.Text,
                                       diferencadias);
            //
            //Preenchimento da Tela
            vlrcorrecao = "0";
            vlrjuros = "0";
            vlrmulta = "0";
            vlrdesconto = "0";
            vlrpagamento = "0";
            vlrpagamentofinal = "0";
            btprocessa = false;
            edfeedback = "";
            edindexadoracum = "";
            periodicidade_comissao = "";
            juros = "0";
            taxamulta = "0";
            diferencadias = "0";
            //
        }
        //
        if (lOk)
        {
            edvlr_correcao.Text = "0,00";
            edvlr_juros.Text = "0,00";
            edvlr_multa.Text = "0,00";
            edvlr_desconto.Text = "0,00";
            //
            //Calculo Pagamento
            if ((Convert.ToDateTime(eddtpagamento.Text) <= (Convert.ToDateTime(eddtvencimento.Text))))
            {
                //Mesmo Dia ou antecipado
                edfeedback.Text = "Calculo de pagamento na Data de Vencimento. Clique no Botão Gravar.";
                edvlr_pagamento.Text = Convert.ToString(
                                       Convert.ToDouble(edvlr_parcela.Text) +
                                       Convert.ToDouble(edvlr_correcao.Text) +
                                       Convert.ToDouble(edvlr_juros.Text) +
                                       Convert.ToDouble(edvlr_multa.Text)
                                       );
                edvlr_pagofinal.Text = Convert.ToString(
                                       Convert.ToDouble(edvlr_pagamento.Text) -
                                       Convert.ToDouble(edvlr_desconto.Text)
                                       );
                //
                btprocessa.Enabled = true;
                //
            }
            else
            {
                string metodo = uParametros.PegaParametro("PAGAMENTO METODO");
                if (metodo == "1")
                {
                    //Calculo pelo Método 1, padrão do sistema
                    //Atrasado
                    edfeedback.Text = "Calculo de pagamento Atrasado (MÉTODO 1). Clique no Botão Gravar.";
                    //Indexador
                    string tx_indexador_acum = "0,00";
                    string indexador = "";
                    if (parte == "0")
                    {
                        indexador = uVendas.PegaIndexador(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte);
                    }
                    else
                    {
                        indexador = uVendas.PegaIndexador(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), meiolote);
                    }
                    Decimal vlr_correcao = 0;
                    if ((indexador != "NENHUM") || (indexador != ""))
                    {
                        tx_indexador_acum = uTaxasMensais.PegaDadosTaxasMensaisAcumuladaNomePagamento(
                                                          indexador,
                                                          Convert.ToDateTime(eddtvencimento.Text),
                                                          Convert.ToDateTime(eddtpagamento.Value)).ToString();
                        tx_indexador_acum = Math.Round(Convert.ToDecimal(tx_indexador_acum), 4).ToString();
                        //
                        //Correção
                        if (tx_indexador_acum != "0")
                        {
                            vlr_correcao = (Math.Round(Convert.ToDecimal(edvlr_parcela.Text), 2) *
                                           ((Math.Round(Convert.ToDecimal(tx_indexador_acum), 4) / 100))
                                           );
                            vlr_correcao = Math.Round(Convert.ToDecimal(vlr_correcao), 2);
                        }
                        else
                        {
                            vlr_correcao = 0;
                        }
                    }
                    else
                    {
                        edfeedback.Text = "Calculo de pagamento Atrasado (MÉTODO 1). Indexador NENHUM não gera calculo. Clique no Botão Gravar.";
                    }
                    edindexador_acum.Text = indexador + " - " + tx_indexador_acum;
                    edvlr_correcao.Text = vlr_correcao.ToString();
                    //
                    //Juros (Parcela + Correção) * (((( Juros/100 ) + 1) ^ Meses ou dias) - 1)
                    Double diasatraso = Convert.ToInt64((Convert.ToDateTime(eddtpagamento.Text) - Convert.ToDateTime(eddtvencimento.Text)).TotalDays);
                    Double mesesatraso = diasatraso / 30;
                    //
                    string periodicidade_comissao = edjuros_acum2.Text;
                    //
                    Decimal vlr_juros = 0;
                    if (periodicidade_comissao == "a.d.")
                    {
                        vlr_juros = (Math.Round(Convert.ToDecimal(edvlr_parcela.Text), 2) +
                                    Math.Round(Convert.ToDecimal(edvlr_correcao.Text), 2));
                        vlr_juros = vlr_juros *
                                    (Convert.ToDecimal(Math.Pow((Convert.ToDouble(edjuros_acum.Text) / 100) + 1, diasatraso)) - 1);
                    }
                    if (periodicidade_comissao == "a.m.")
                    {
                        vlr_juros = (Math.Round(Convert.ToDecimal(edvlr_parcela.Text), 2) +
                                    Math.Round(Convert.ToDecimal(edvlr_correcao.Text), 2));
                        vlr_juros = vlr_juros *
                                    (Convert.ToDecimal(Math.Pow((Convert.ToDouble(edjuros_acum.Text) / 100) + 1, mesesatraso)) - 1);

                    }
                    vlr_juros = Math.Round(Convert.ToDecimal(vlr_juros), 2);
                    edvlr_juros.Text = vlr_juros.ToString();
                    //
                    //Multa
                    Decimal vlr_multa = (Math.Round(Convert.ToDecimal(edvlr_parcela.Text), 2) +
                                         Math.Round(Convert.ToDecimal(edvlr_correcao.Text), 2) +
                                         Math.Round(Convert.ToDecimal(edvlr_juros.Text), 2)) *
                                         (Math.Round(Convert.ToDecimal(edtaxa_multa.Text), 2) / 100)
                                         ;
                    vlr_multa = Math.Round(Convert.ToDecimal(vlr_multa), 2);
                    edvlr_multa.Text = vlr_multa.ToString();
                    //
                    Decimal vlr_pagamento = (Math.Round(Convert.ToDecimal(edvlr_parcela.Text), 2) +
                                           Math.Round(Convert.ToDecimal(edvlr_correcao.Text), 2) +
                                           Math.Round(Convert.ToDecimal(edvlr_juros.Text), 2) +
                                           Math.Round(Convert.ToDecimal(edvlr_multa.Text), 2))
                                           ;
                    vlr_pagamento = Math.Round(Convert.ToDecimal(vlr_pagamento), 2);
                    edvlr_pagamento.Text = vlr_pagamento.ToString();
                    //
                    Decimal vlr_pagofinal = Math.Round(Convert.ToDecimal(edvlr_pagamento.Text), 2) -
                                           Math.Round(Convert.ToDecimal(edvlr_desconto.Text), 2)
                                           ;
                    vlr_pagofinal = Math.Round(Convert.ToDecimal(vlr_pagofinal), 2);
                    edvlr_pagofinal.Text = vlr_pagofinal.ToString();
                    //
                    eddiferenca.Text = mesesatraso.ToString() + " - " + diasatraso.ToString();
                    //
                    btprocessa.Enabled = true;
                }
                if (metodo == "2")
                {
                    //Calculo pelo Método 2, modificado Terra Simão
                    //Atrasado
                    edfeedback.Text = "Calculo de pagamento Atrasado (MÉTODO 2). Clique no Botão Gravar.";
                    Double diasatraso = Convert.ToInt64((Convert.ToDateTime(eddtpagamento.Text) - Convert.ToDateTime(eddtvencimento.Text)).TotalDays);
                    Double mesesatraso = diasatraso / 30;
                    //
                    //Indexador
                    string tx_indexador_acum = "0,00";
                    string indexador = "";
                    if (parte == "0")
                    {
                        indexador = uVendas.PegaIndexador(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte);
                    }
                    else
                    {
                        indexador = uVendas.PegaIndexador(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), meiolote);
                    }
                    //
                    Decimal vlr_correcao = 0;
                    if ((indexador != "NENHUM") || (indexador != ""))
                    {
                        tx_indexador_acum = uTaxasMensais.PegaDadosTaxasMensaisAcumuladaNomePagamento(
                                                          indexador,
                                                          Convert.ToDateTime(eddtvencimento.Text),
                                                          Convert.ToDateTime(eddtpagamento.Value)).ToString();
                        tx_indexador_acum = Math.Round(Convert.ToDecimal(tx_indexador_acum), 4).ToString();
                        //
                        //Correção
                        if (tx_indexador_acum != "0")
                        {
                            //Taxa Acumulada
                            vlr_correcao = (Math.Round(Convert.ToDecimal(edvlr_parcela.Text), 2) *
                                           ((Math.Round(Convert.ToDecimal(tx_indexador_acum), 4) / 100) *
                                           Convert.ToDecimal(diasatraso))
                                           );
                            vlr_correcao = Math.Round(Convert.ToDecimal(vlr_correcao), 2);
                        }
                        else
                        {
                            //Taxa Mês Corrente
                            if (diasatraso > 0)
                            {
                                tx_indexador_acum = uTaxasMensais.PegaDadosTaxasMensaisNomeString(
                                                                  indexador,
                                                                  Convert.ToDateTime(eddtvencimento.Text),
                                                                  Convert.ToDateTime(eddtpagamento.Value)).ToString();
                                if (tx_indexador_acum != "0")
                                {
                                    //Taxa Mês
                                    vlr_correcao = (Math.Round(Convert.ToDecimal(edvlr_parcela.Text), 2) *
                                                   ((Math.Round(Convert.ToDecimal(tx_indexador_acum), 4) / 100) *
                                                   Convert.ToDecimal(diasatraso))
                                                   );
                                    vlr_correcao = Math.Round(Convert.ToDecimal(vlr_correcao), 2);
                                }
                                else
                                {
                                    vlr_correcao = 0;
                                }
                            }
                            else
                            {
                                vlr_correcao = 0;
                            }
                        }
                    }
                    else
                    {
                        edfeedback.Text = "Calculo de pagamento Atrasado (MÉTODO 2). Indexador NENHUM não gera calculo. Clique no Botão Gravar.";
                    }
                    edindexador_acum.Text = indexador + " - " + tx_indexador_acum;
                    edvlr_correcao.Text = vlr_correcao.ToString();
                    //
                    //Juros (Parcela + Correção) * (((( Juros/100 ) + 1) ^ Meses ou dias) - 1)
                    string periodicidade_comissao = edjuros_acum2.Text;
                    //
                    Decimal vlr_juros = 0;
                    if (periodicidade_comissao == "a.d.")
                    {
                        vlr_juros = (Math.Round(Convert.ToDecimal(edvlr_parcela.Text), 2) +
                                    Math.Round(Convert.ToDecimal(edvlr_correcao.Text), 2));
                        //Multiplicar não Elevar
                        vlr_juros = vlr_juros *
                                    (Convert.ToDecimal(Math.Pow((Convert.ToDouble(edjuros_acum.Text) / 100) + 1, diasatraso)) - 1);
                    }
                    if (periodicidade_comissao == "a.m.")
                    {
                        vlr_juros = (Math.Round(Convert.ToDecimal(edvlr_parcela.Text), 2) +
                                    Math.Round(Convert.ToDecimal(edvlr_correcao.Text), 2));

                        vlr_juros = vlr_juros *
                                    (Convert.ToDecimal(Math.Pow((Convert.ToDouble(edjuros_acum.Text) / 100) + 1, mesesatraso)) - 1);

                    }
                    vlr_juros = Math.Round(Convert.ToDecimal(vlr_juros), 2);
                    edvlr_juros.Text = vlr_juros.ToString();
                    //
                    //Multa
                    Decimal vlr_multa = (Math.Round(Convert.ToDecimal(edvlr_parcela.Text), 2) +
                                         Math.Round(Convert.ToDecimal(edvlr_correcao.Text), 2) +
                                         Math.Round(Convert.ToDecimal(edvlr_juros.Text), 2)) *
                                         (Math.Round(Convert.ToDecimal(edtaxa_multa.Text), 2) / 100)
                                         ;
                    vlr_multa = Math.Round(Convert.ToDecimal(vlr_multa), 2);
                    edvlr_multa.Text = vlr_multa.ToString();
                    //
                    Decimal vlr_pagamento = (Math.Round(Convert.ToDecimal(edvlr_parcela.Text), 2) +
                                           Math.Round(Convert.ToDecimal(edvlr_correcao.Text), 2) +
                                           Math.Round(Convert.ToDecimal(edvlr_juros.Text), 2) +
                                           Math.Round(Convert.ToDecimal(edvlr_multa.Text), 2))
                                           ;
                    vlr_pagamento = Math.Round(Convert.ToDecimal(vlr_pagamento), 2);
                    edvlr_pagamento.Text = vlr_pagamento.ToString();
                    //
                    Decimal vlr_pagofinal = Math.Round(Convert.ToDecimal(edvlr_pagamento.Text), 2) -
                                           Math.Round(Convert.ToDecimal(edvlr_desconto.Text), 2)
                                           ;
                    vlr_pagofinal = Math.Round(Convert.ToDecimal(vlr_pagofinal), 2);
                    edvlr_pagofinal.Text = vlr_pagofinal.ToString();
                    //
                    eddiferenca.Text = mesesatraso.ToString() + " - " + diasatraso.ToString();
                    //
                    btprocessa.Enabled = true;
                }
                if ((metodo != "1") && (metodo != "2"))
                {
                    edfeedback.Text = "Atenção!!! Parâmetro PAGAMENTO MÉTODO não definido corretamente.";
                }

            }

        }
    }
    protected void btcarrega_Click(object sender, EventArgs e)
    {
        Boolean lOk = true;
        string tst = "";
        DataSet parcela;
        string contaproduto = uProduto.PegaProdutoConta(Convert.ToInt16(cbproduto.Value));
        string descricaoconta = "";

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
            edparcela.Text = "";
            edvlr_parcela.Text = "0,00";
            eddtvencimento.Text = "";
            eddtpagamento.Text = DateTime.Now.ToString().Substring(0, 10);
            edvlr_correcao.Text = "0,00";
            edindexador_acum.Text = "";
            edindexador_acum2.Text = "";
            edvlr_juros.Text = "0,00";
            edjuros_acum.Text = "0,00";
            edjuros_acum2.Text = "";
            edvlr_multa.Text = "0,00";
            edtaxa_multa.Text = "0,00";
            edvlr_pagamento.Text = "0,00";
            eddiferenca.Text = "0,00";
            edvlr_desconto.Text = "0,00";
            edvlr_pagofinal.Text = "0,00";
            edfeedback.Text = "";
            //
            edparcela.Enabled = false;
            edvlr_parcela.Enabled = false;
            eddtvencimento.Enabled = false;
            eddtpagamento.Enabled = true;
            edvlr_correcao.Enabled = false;
            edindexador_acum.Enabled = false;
            edindexador_acum2.Enabled = false;
            edvlr_juros.Enabled = false;
            edjuros_acum.Enabled = false;
            edjuros_acum2.Enabled = false;
            edvlr_multa.Enabled = false;
            edtaxa_multa.Enabled = false;
            edvlr_pagamento.Enabled = true;
            eddiferenca.Enabled = false;
            edvlr_desconto.Enabled = true;
            edvlr_pagofinal.Enabled = false;
            edfeedback.Enabled = true;
            //
            Label23.Visible = true;
            edparcela.Visible = true;
            Label5.Visible = true;
            edvlr_parcela.Visible = true;
            Label6.Visible = true;
            eddtvencimento.Visible = true;
            Label9.Visible = true;
            eddtpagamento.Visible = true;
            Label10.Visible = true;
            edvlr_correcao.Visible = true;
            Label25.Visible = true;
            rbrecibo.Visible = true;
            Label11.Visible = true;
            edindexador_acum.Visible = true;
            edindexador_acum2.Visible = true;
            Label12.Visible = true;
            edvlr_juros.Visible = true;
            Label14.Visible = true;
            edjuros_acum.Visible = true;
            edjuros_acum2.Visible = true;
            Label15.Visible = true;
            edvlr_multa.Visible = true;
            Label16.Visible = true;
            edtaxa_multa.Visible = true;
            Label17.Visible = true;
            edvlr_pagamento.Visible = true;
            Label18.Visible = true;
            eddiferenca.Visible = true;
            Label19.Visible = true;
            edvlr_desconto.Visible = true;
            Label20.Visible = true;
            edvlr_pagofinal.Visible = true;
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
            parcela = uParcelas.PegaDadosParcelaID(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), "0", tst);
            //Carregar Dados
            edparcela.Text = parcela.Tables[0].Rows[0]["parcela"].ToString() + " / " + parcela.Tables[0].Rows[0]["tipo"].ToString();
            edvlr_parcela.Text = parcela.Tables[0].Rows[0]["vlr_parcela"].ToString();
            eddtvencimento.Text = parcela.Tables[0].Rows[0]["data_vencimento"].ToString().Substring(0, 10);
            eddtpagamento.Text = DateTime.Now.ToString().Substring(0, 10);
            edvlr_correcao.Text = "0,00";
            if (parte != "0")
            {
                edindexador_acum.Text = uVendas.PegaIndexador(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), meiolote) + " - 0,00";
            }
            else
            {
                edindexador_acum.Text = uVendas.PegaIndexador(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte) + " - 0,00";
            }
            edindexador_acum2.Text = "a.m.";
            edvlr_juros.Text = "0,00";
            edjuros_acum.Text = parcela.Tables[0].Rows[0]["tx_comissao"].ToString(); // +" " + parcela.Tables[0].Rows[0]["periodicidade_comissao"].ToString();
            edjuros_acum2.Text = parcela.Tables[0].Rows[0]["periodicidade_comissao"].ToString();
            edvlr_multa.Text = "0,00";
            edtaxa_multa.Text = parcela.Tables[0].Rows[0]["tx_multa"].ToString(); // +" a.m.";
            edvlr_pagamento.Text = parcela.Tables[0].Rows[0]["vlr_parcela"].ToString();
            Int64 diasatraso = Convert.ToInt64((Convert.ToDateTime(eddtpagamento.Text) - Convert.ToDateTime(eddtvencimento.Text)).TotalDays);
            Int64 mesesatraso = diasatraso / 30;
            eddiferenca.Text = mesesatraso.ToString() + " - " + diasatraso.ToString();
            edvlr_desconto.Text = "0,00";
            edvlr_pagofinal.Text = parcela.Tables[0].Rows[0]["vlr_parcela"].ToString();
            //
            btcalcula.Enabled = true;
            btprocessa.Enabled = false;
            btimprime.Enabled = false;
            //
            edfeedback.Text = "Parcela Selecionada, preencha dos campos e clique no Botão Calcular.";
            //
            eddtpagamento.Focus();
            //
            btcalcula_Click(sender, e);
            //
        }
    }

    protected void btimprime_Click(object sender, EventArgs e)
    {
        //
        Boolean lOk = true;
        string tst = "";
        ////CRITICAS
        string contacorrente = "";
        string formapagamento = "";
        string parte = "";
        string meiolote = "1";
        //
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
        }
        //
        if (lOk)
        {
            // CRIA LOG ===============================================================================================================================================
            fwObs_Log = "RELATÓRIO RECIBO PAGAMENTO PARCELA: " + cbproduto.Value.ToString() + "/" + cbgrupo.Value.ToString() + "/" + cbgrupounidades.Value.ToString() + "/" + parte +
                        " PARCELA ID: " + tst;
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ),
                                         new SqlParameter("@tabela"   , fWtabela                              ),
                                         new SqlParameter("@operacao" , "PARCELAS"                            ),
                                         new SqlParameter("@obs"      , "RELATÓRIO RECIBO PAGAMENTO PARCELA"  ),
                                         new SqlParameter("@acao"     , fwObs_Log                             ) };
            uLog.MakeLog(param_log);
            //
            //TITULO RECIBO
            string recibo = uParametros.PegaParametro("PROXIMO RECIBO");
            Session.Remove("PROXIMO RECIBO");
            Session.Add("PROXIMO RECIBO", recibo.ToString().Trim());
            //
            uParcelas.GravaRecibo(cbproduto.Value.ToString(),
                                  cbgrupo.Value.ToString(),
                                  cbgrupounidades.Value.ToString(),
                                  parte.ToString(),
                                  tst.ToString(),
                                  recibo.ToString());
            uParametros.AlteraMigracao("PROXIMO RECIBO", Convert.ToString(Convert.ToInt64(recibo) + 1));
            //
            // FIM CRIA LOG ===============================================================================================================================================
            //
            if (rbrecibo.SelectedIndex == 0)
            {
                //Retrato
                ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( '" + HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpRuntime.AppDomainAppVirtualPath + "/_Pagamentos/relatorios/RelParcelasRetrato.aspx', null, 'height=755,width=900,status=yes,resizable=yes,menubar=yes,location=yes' );", true);
            }
            else
            {
                //Paisagem
                ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( '" + HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpRuntime.AppDomainAppVirtualPath + "/_Pagamentos/relatorios/RelParcelas.aspx', null, 'height=755,width=900,status=yes,resizable=yes,menubar=yes,location=yes' );", true);
            }
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
        Label28.Visible = true;
        edcorrecao.Visible = true;
        edcorrecao.Text = "";
        edcorrecao.Text = edcorrecao.Text + uVendas.PegaPeriodicidade(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte, meiolote);
        edcorrecao.Text = edcorrecao.Text + " - " + uVendas.PegaIndexador(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte);
        edcorrecao.Text = edcorrecao.Text + " - BASE: " + uVendas.PegaDataBase(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte).ToString().Substring(0, 10);
        //
        Label13.Visible = true;
        rbparcelasituacao.Visible = true;
        //
        rbparcelasituacao_SelectedIndexChanged(sender, e);
        //

    }
    protected void edvlr_pagamento_TextChanged(object sender, EventArgs e)
    {
        //Igual
        if (edvlr_parcela.Text == edvlr_pagamento.Text)
        {
            edvlr_correcao.Text = "0,00";
            edvlr_multa.Text = "0,00";
            edvlr_juros.Text = "0,00";
            edvlr_desconto.Text = "0,00";
            edvlr_pagofinal.Text = edvlr_pagamento.Text;
        }
        //Parcela Maior
        if (Convert.ToDouble(edvlr_parcela.Text) > Convert.ToDouble(edvlr_pagamento.Text))
        {
            edvlr_correcao.Text = "0,00";
            edvlr_multa.Text = "0,00";
            edvlr_juros.Text = "0,00";
            edvlr_desconto.Text = String.Format("{0:N}", (Convert.ToDouble(edvlr_parcela.Text) - Convert.ToDouble(edvlr_pagamento.Text)));
            edvlr_pagofinal.Text = edvlr_pagamento.Text;
        }
        //Parcela Menor
        if (Convert.ToDouble(edvlr_parcela.Text) < Convert.ToDouble(edvlr_pagamento.Text))
        {
            edvlr_correcao.Text = String.Format("{0:N}", (Convert.ToDouble(edvlr_pagamento.Text) - Convert.ToDouble(edvlr_parcela.Text)));
            edvlr_multa.Text = "0,00";
            edvlr_juros.Text = "0,00";
            edvlr_desconto.Text = "0,00";
            edvlr_pagofinal.Text = edvlr_pagamento.Text;
        }

    }

    protected void eddtpagamento_ValueChanged(object sender, EventArgs e)
    {
        btcalcula_Click(sender, e);
    }

    protected void cbcliente_filtro_SelectedIndexChanged(object sender, EventArgs e)
    {
        string cliente = "";
        if (cbcliente_filtro.Text == string.Empty)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Informe um Cliente!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Informe um Cliente!', 'Atenção!')", true);
        }
        else
        {
            cliente = cbcliente_filtro.Text.Substring(cbcliente_filtro.Text.IndexOf("(", 1) + 1,
                      cbcliente_filtro.Text.IndexOf(")", 1) - 1 - cbcliente_filtro.Text.IndexOf("(", 1));
            uVendas.MontaComboVendasCliente(cbvendas, " WHERE CLIENTE = " + Srelib.QStr(cliente));
            cbvendas.Text = "";
            //
            if (cbvendas.Items.Count > 0)
            {
                Label27.Visible = true;
                cbvendas.Visible = true;
            }
            else
            {
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Não há vendas para este cliente!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Não há vendas para este cliente!', 'Atenção!')", true);
            }
        }
    }


    protected void cbvendas_SelectedIndexChanged(object sender, EventArgs e)
    {
        string ID_Venda = "";
        DataSet dsvendas;
        string produto = "";
        string grupo = "";
        string grupounidade = "";
        string parte = "";
        string meiolote = "";
        //
        if (cbvendas.Text != String.Empty)
        {
            ID_Venda = cbvendas.Text.Substring(4, cbvendas.Text.IndexOf("V") - 4).Trim();
            dsvendas = uVendas.PegaDadosVendaID(ID_Venda);
            //
            produto = dsvendas.Tables[0].Rows[0]["produto"].ToString();
            grupo = dsvendas.Tables[0].Rows[0]["grupo"].ToString();
            grupounidade = dsvendas.Tables[0].Rows[0]["unidade"].ToString();
            parte = dsvendas.Tables[0].Rows[0]["parte"].ToString();
            //
            cbproduto.Items.Clear();
            uProduto.MontaComboProduto(cbproduto, true);
            cbproduto.SelectedItem = cbproduto.Items.FindByValue(produto);
            //
            cbgrupo.Items.Clear();
            uProduto.MontaComboGrupo(cbgrupo, produto, true);
            cbgrupo.SelectedItem = cbgrupo.Items.FindByValue(grupo);
            //
            cbgrupounidades.Items.Clear();
            uProduto.MontaComboUnidades(cbgrupounidades, produto, grupo, true);
            cbgrupounidades.SelectedItem = cbgrupounidades.Items.FindByValue(grupounidade);
            //
            rbmeiolote.Enabled = false;
            rbmeiolote.Visible = false;
            meiolote = "1";
            if (parte != "0")
            {
                rbmeiolote.Enabled = true;
                rbmeiolote.Visible = true;
                //
                if (parte == "1")
                {
                    rbmeiolote.SelectedIndex = 0;
                    meiolote = "1";
                }
                else
                {
                    rbmeiolote.SelectedIndex = 1;
                    meiolote = "2";
                }
            }
            //
            string IDCliente = uUnidade.PegaIDCliente(produto, grupo, grupounidade, parte, meiolote);
            edcliente.Text = Srelib.QStr0(IDCliente.Trim(), 5) + " - " + uContato.PegaNomeID(IDCliente);
            Label8.Visible = true;
            edcliente.Visible = true;
            //
            Label4.Visible = true;
            dtvenda.Visible = true;
            dtvenda.Value = uVendas.PegaDataVenda(produto, grupo, grupounidade, parte);
            //
            Label28.Visible = true;
            edcorrecao.Visible = true;
            edcorrecao.Text = "";
            edcorrecao.Text = edcorrecao.Text + uVendas.PegaPeriodicidade(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte, meiolote);
            edcorrecao.Text = edcorrecao.Text + " - " + uVendas.PegaIndexador(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte);
            edcorrecao.Text = edcorrecao.Text + " - BASE: " + uVendas.PegaDataBase(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte).ToString().Substring(0, 10);
            //
            Label13.Visible = true;
            rbparcelasituacao.Visible = true;
            //
            rbparcelasituacao_SelectedIndexChanged(sender, e);
            //
            Label3.Visible = true;
            cbproduto.Visible = true;
            Label2.Visible = true;
            cbgrupo.Visible = true;
            Label7.Visible = true;
            cbgrupounidades.Visible = true;
            Label8.Visible = true;
            edcliente.Visible = true;
            Label4.Visible = true;
            dtvenda.Visible = true;
            Label13.Visible = true;
            rbparcelasituacao.Visible = true;
            //

            //
        }
        else
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Informe uma Venda!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Informe uma Venda!', 'Atenção!')", true);
        }
    }

    protected void edvlr_desconto_TextChanged(object sender, EventArgs e)
    {
        if (Convert.ToDouble(edvlr_desconto.Text) != 0)
        {
            edvlr_correcao.Text = "0,00";
            edvlr_multa.Text = "0,00";
            edvlr_juros.Text = "0,00";
            edvlr_pagofinal.Text = String.Format("{0:N}", (Convert.ToDouble(edvlr_parcela.Text) - Convert.ToDouble(edvlr_desconto.Text)));
        }
        else
        {
            //Igual
            if (edvlr_parcela.Text == edvlr_pagamento.Text)
            {
                edvlr_correcao.Text = "0,00";
                edvlr_multa.Text = "0,00";
                edvlr_juros.Text = "0,00";
                edvlr_desconto.Text = "0,00";
                edvlr_pagofinal.Text = edvlr_pagamento.Text;
            }
            //Parcela Maior
            if (Convert.ToDouble(edvlr_parcela.Text) > Convert.ToDouble(edvlr_pagamento.Text))
            {
                edvlr_correcao.Text = "0,00";
                edvlr_multa.Text = "0,00";
                edvlr_juros.Text = "0,00";
                edvlr_desconto.Text = String.Format("{0:N}", (Convert.ToDouble(edvlr_parcela.Text) - Convert.ToDouble(edvlr_pagamento.Text)));
                edvlr_pagofinal.Text = edvlr_pagamento.Text;
            }
            //Parcela Menor
            if (Convert.ToDouble(edvlr_parcela.Text) < Convert.ToDouble(edvlr_pagamento.Text))
            {
                edvlr_correcao.Text = String.Format("{0:N}", (Convert.ToDouble(edvlr_pagamento.Text) - Convert.ToDouble(edvlr_parcela.Text)));
                edvlr_multa.Text = "0,00";
                edvlr_juros.Text = "0,00";
                edvlr_desconto.Text = "0,00";
                edvlr_pagofinal.Text = edvlr_pagamento.Text;
            }
        }

    }
}


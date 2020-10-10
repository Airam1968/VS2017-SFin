using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FAReceberDepositosCompensados : System.Web.UI.Page
{
    DataSet dscpagar;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "CONTAS_PAGAR";

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = false; // SreDblib.TemPermissao("001.007.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.007.002.000", (String)Session["CodUsuario"]);
        lExclui = false; // SreDblib.TemPermissao("001.007.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.007.004.000", (String)Session["CodUsuario"]);
        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        //
        btprocessa.Enabled = lAltera;
        if (!lAltera)
            btprocessa.Image.ToolTip = Msg_acesso;
        lAltera = false;
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
            //Combo Receitas
            cbreceita.Items.Clear();
            uReceitas.MontaComboReceitas(cbreceita, "0", true);
            Label2.Visible = true;
            cbreceita.Visible = true;
            GridListagem.Visible = false;
            //
            //Combo Cliente
            cbcliente.Items.Clear();
            uCliente.MontaComboClientes(cbcliente, "0", true);
            Label7.Visible = true;
            cbcliente.Visible = true;
            //
            //Combo Contas Correntes
            cbcontascorrentes.Items.Clear();
            uContas.MontaComboContas(cbcontascorrentes, "0");
            Label16.Visible = true;
            cbcontascorrentes.Visible = true;
            //
            Label4.Visible = true;
            dtprevisao1.Visible = true;
            Label5.Visible = true;
            dtprevisao2.Visible = true;
            //
            Label6.Visible = true;
            dtrealizado1.Visible = true;
            Label9.Visible = true;
            dtrealizado2.Visible = true;
            //
            Label10.Visible = true;
            dtnotafiscal1.Visible = true;
            Label11.Visible = true;
            dtnotafiscal2.Visible = true;
            //
            dtprevisao1.Date = Convert.ToDateTime("01/01/1900");
            dtprevisao2.Date = Convert.ToDateTime("31/12/2999");
            dtrealizado1.Date = Convert.ToDateTime("01/01/1900");
            dtrealizado2.Date = Convert.ToDateTime("31/12/2999");
            dtnotafiscal1.Date = Convert.ToDateTime("01/01/1900");
            dtnotafiscal2.Date = Convert.ToDateTime("31/12/2999");
        }

    }


    protected void cbproduto_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        //if (cbproduto.Text != string.Empty)
        //{
        //    //Combo Grupo
        //    cbdespesa.Items.Clear();
        //    uDespesas.MontaComboDespesas(cbdespesa, "0", true);
        //    Label2.Visible = true;
        //    cbdespesa.Visible = true;
        //    GridListagem.Visible = false;
        //}
        //else
        //{
        //    Label2.Visible = false;
        //    cbdespesa.Visible = false;
        //    GridListagem.Visible = false;
        //}

    }

    private void AtualizaGrid(String situacaopgto, String ordenacao)
    {
        string cbproduto2 = "";
        string cbdespesa2 = "";
        string cbfornecedor2 = "";
        string cbcontascorrentes2 = "";
        Boolean compensado = false;
        //
        if (cbproduto.Value != null)
        {
            cbproduto2 = cbproduto.Value.ToString().Trim();
        }
        if (cbreceita.Value != null)
        {
            cbdespesa2 = cbreceita.Value.ToString().Trim();
        }
        if (cbcliente.Value != null)
        {
            cbfornecedor2 = cbcliente.Value.ToString().Trim();
        }
        if (cbcontascorrentes.Value != null)
        {
            cbcontascorrentes2 = cbcontascorrentes.Value.ToString().Trim();
        }
        // 
        if (rbdeposito.SelectedIndex == 0)
        {
            compensado = true;
        }
        else
        {
            compensado = false;
        }
        // 
        dscpagar = uContasReceber.PegaDadosCReceber(cbproduto2,
                                                     cbdespesa2,
                                                     cbfornecedor2,
                                                     cbcontascorrentes2,
                                                     dtprevisao1.Text,
                                                     dtprevisao2.Text,
                                                     dtrealizado1.Text,
                                                     dtrealizado2.Text,
                                                     dtnotafiscal1.Text,
                                                     dtnotafiscal2.Text,
                                                     eddocumento.Text,
                                                     situacaopgto,
                                                     ordenacao,
                                                     true,
                                                     compensado);
        decimal totvlrprevisto = 0;
        decimal totqtdprevisto = 0;
        decimal totvlrrealizado = 0;
        decimal totqtdrealizado = 0;
        for (int i = 0; i < dscpagar.Tables[0].Rows.Count; i++)
        {
            totvlrprevisto = totvlrprevisto + Convert.ToDecimal(dscpagar.Tables[0].Rows[i]["vlr_previsto"]);
            totqtdprevisto = totqtdprevisto + 1;
            totvlrrealizado = totvlrrealizado +Convert.ToDecimal(dscpagar.Tables[0].Rows[i]["vlr_realizado"]);
            totqtdrealizado = totqtdrealizado + 1;            
        }

        edvlrtotalprevisto.Text =  Convert.ToString(totvlrprevisto);
        edqtdtotalprevisto.Text =  Convert.ToString(totqtdprevisto);
        edvlrtotalrealizado.Text = Convert.ToString(totvlrrealizado);
        edqtdtotalrealizado.Text = Convert.ToString(totqtdrealizado);

        GridListagem.DataSource = dscpagar;
        GridListagem.KeyFieldName = "ID";
        GridListagem.DataBind();
        GridListagem.Focus();
        //btprocessa.Enabled = false;


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
        //

        if (lOk)
        {
            //Todas
            if (rbparcelasituacao.SelectedIndex == 0)
            {
                //Todas/Lançamento
                if (rbordenacao.SelectedIndex == 0)
                {
                    GridListagem.Visible = true;
                    AtualizaGrid("T", "L");
                }
                //Todas/Classe Despesa
                if (rbordenacao.SelectedIndex == 1)
                {
                    GridListagem.Visible = true;
                    AtualizaGrid("T", "D");
                }
                //Todas/Fornecedores
                if (rbordenacao.SelectedIndex == 2)
                {
                    GridListagem.Visible = true;
                    AtualizaGrid("T", "F");
                }
                //Todas/Data Prevista
                if (rbordenacao.SelectedIndex == 3)
                {
                    GridListagem.Visible = true;
                    AtualizaGrid("T", "DP");
                }
                //Todas/Data Realizado
                if (rbordenacao.SelectedIndex == 4)
                {
                    GridListagem.Visible = true;
                    AtualizaGrid("T", "DR");
                }
                //Todas/Data Nota Fiscal
                if (rbordenacao.SelectedIndex == 5)
                {
                    GridListagem.Visible = true;
                    AtualizaGrid("T", "DN");
                }
            }
            //Previsto
            if (rbparcelasituacao.SelectedIndex == 1)
            {
                //Previsto/Lançamento
                if (rbordenacao.SelectedIndex == 0)
                {
                    GridListagem.Visible = true;
                    AtualizaGrid("P", "L");
                }
                //Previsto/Classe Despesa
                if (rbordenacao.SelectedIndex == 1)
                {
                    GridListagem.Visible = true;
                    AtualizaGrid("P", "D");
                }
                //Previsto/Fornecedores
                if (rbordenacao.SelectedIndex == 2)
                {
                    GridListagem.Visible = true;
                    AtualizaGrid("P", "F");
                }
                //Previsto/Data Prevista
                if (rbordenacao.SelectedIndex == 3)
                {
                    GridListagem.Visible = true;
                    AtualizaGrid("P", "DP");
                }
                //Previsto/Data Realizado
                if (rbordenacao.SelectedIndex == 4)
                {
                    GridListagem.Visible = true;
                    AtualizaGrid("P", "DR");
                }
                //Previsto/Data Nota Fiscal
                if (rbordenacao.SelectedIndex == 5)
                {
                    GridListagem.Visible = true;
                    AtualizaGrid("P", "DN");
                }
            }
            //Realizado
            if (rbparcelasituacao.SelectedIndex == 2)
            {
                //Realizado/Lançamento
                if (rbordenacao.SelectedIndex == 0)
                {
                    GridListagem.Visible = true;
                    AtualizaGrid("R", "L");
                }
                //Realizado/Classe Despesa
                if (rbordenacao.SelectedIndex == 1)
                {
                    GridListagem.Visible = true;
                    AtualizaGrid("R", "D");
                }
                //Realizado/Fornecedores
                if (rbordenacao.SelectedIndex == 2)
                {
                    GridListagem.Visible = true;
                    AtualizaGrid("R", "F");
                }
                //Realizado/Data Prevista
                if (rbordenacao.SelectedIndex == 3)
                {
                    GridListagem.Visible = true;
                    AtualizaGrid("R", "DP");
                }
                //Realizado/Data Realizado
                if (rbordenacao.SelectedIndex == 4)
                {
                    GridListagem.Visible = true;
                    AtualizaGrid("R", "DR");
                }
                //Realizado/Data Nota Fiscal
                if (rbordenacao.SelectedIndex == 5)
                {
                    GridListagem.Visible = true;
                    AtualizaGrid("R", "DN");
                }
            }


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
        ASPxGridView gridView = (ASPxGridView)sender;

        DateTime dtcompensacao = Convert.ToDateTime(e.NewValues["dtcompensacao"]);
        //
        uContasReceber.AlteraCompensacao(e.NewValues["ID"].ToString(), dtcompensacao.ToString().Substring(0, 10));
        //

        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "ALTERAÇÃO CONTAS A RECEBER - COMPENSAÇÃO ID/Lançamento/Data: " +
                    e.NewValues["ID"].ToString() + "/" +
                    e.NewValues["lancamento"].ToString().ToUpper() + "/" +
                    dtcompensacao.ToString().Substring(0, 10);
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "CONTAS A RECEBER"           ),
                                     new SqlParameter("@obs"      , "ALTERAÇÃO"                  ),
                                     new SqlParameter("@acao"     , fwObs_Log                    ) };
        uLog.MakeLog(param_log);

        //Todas
        if (rbparcelasituacao.SelectedIndex == 0)
        {
            //Todas/Lançamento
            if (rbordenacao.SelectedIndex == 0)
            {
                GridListagem.Visible = true;
                AtualizaGrid("T", "L");
            }
            //Todas/Classe Despesa
            if (rbordenacao.SelectedIndex == 1)
            {
                GridListagem.Visible = true;
                AtualizaGrid("T", "D");
            }
            //Todas/Fornecedores
            if (rbordenacao.SelectedIndex == 2)
            {
                GridListagem.Visible = true;
                AtualizaGrid("T", "F");
            }
            //Todas/Data Prevista
            if (rbordenacao.SelectedIndex == 3)
            {
                GridListagem.Visible = true;
                AtualizaGrid("T", "DP");
            }
            //Todas/Data Realizado
            if (rbordenacao.SelectedIndex == 4)
            {
                GridListagem.Visible = true;
                AtualizaGrid("T", "DR");
            }
            //Todas/Data Nota Fiscal
            if (rbordenacao.SelectedIndex == 5)
            {
                GridListagem.Visible = true;
                AtualizaGrid("T", "DN");
            }
        }
        //Previsto
        if (rbparcelasituacao.SelectedIndex == 1)
        {
            //Previsto/Lançamento
            if (rbordenacao.SelectedIndex == 0)
            {
                GridListagem.Visible = true;
                AtualizaGrid("P", "L");
            }
            //Previsto/Classe Despesa
            if (rbordenacao.SelectedIndex == 1)
            {
                GridListagem.Visible = true;
                AtualizaGrid("P", "D");
            }
            //Previsto/Fornecedores
            if (rbordenacao.SelectedIndex == 2)
            {
                GridListagem.Visible = true;
                AtualizaGrid("P", "F");
            }
            //Previsto/Data Prevista
            if (rbordenacao.SelectedIndex == 3)
            {
                GridListagem.Visible = true;
                AtualizaGrid("P", "DP");
            }
            //Previsto/Data Realizado
            if (rbordenacao.SelectedIndex == 4)
            {
                GridListagem.Visible = true;
                AtualizaGrid("P", "DR");
            }
            //Previsto/Data Nota Fiscal
            if (rbordenacao.SelectedIndex == 5)
            {
                GridListagem.Visible = true;
                AtualizaGrid("P", "DN");
            }
        }
        //Realizado
        if (rbparcelasituacao.SelectedIndex == 2)
        {
            //Realizado/Lançamento
            if (rbordenacao.SelectedIndex == 0)
            {
                GridListagem.Visible = true;
                AtualizaGrid("R", "L");
            }
            //Realizado/Classe Despesa
            if (rbordenacao.SelectedIndex == 1)
            {
                GridListagem.Visible = true;
                AtualizaGrid("R", "D");
            }
            //Realizado/Fornecedores
            if (rbordenacao.SelectedIndex == 2)
            {
                GridListagem.Visible = true;
                AtualizaGrid("R", "F");
            }
            //Realizado/Data Prevista
            if (rbordenacao.SelectedIndex == 3)
            {
                GridListagem.Visible = true;
                AtualizaGrid("R", "DP");
            }
            //Realizado/Data Realizado
            if (rbordenacao.SelectedIndex == 4)
            {
                GridListagem.Visible = true;
                AtualizaGrid("R", "DR");
            }
            //Realizado/Data Nota Fiscal
            if (rbordenacao.SelectedIndex == 5)
            {
                GridListagem.Visible = true;
                AtualizaGrid("R", "DN");
            }
        }

    }
    protected void GridListagem_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        uContasReceber.Exclui(e.Values["ID"].ToString());
        //

        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "EXCLUI CONTAS A RECEBER: " + e.Values["ID"].ToString() + "/" + e.Values["lancamento"].ToString().ToUpper();
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "CONTAS A RECEBER"           ),
                                     new SqlParameter("@obs"      , "EXCLUI"                     ),
                                     new SqlParameter("@acao"     , fwObs_Log                    ) };
        uLog.MakeLog(param_log);

        //Todas
        if (rbparcelasituacao.SelectedIndex == 0)
        {
            //Todas/Lançamento
            if (rbordenacao.SelectedIndex == 0)
            {
                GridListagem.Visible = true;
                AtualizaGrid("T", "L");
            }
            //Todas/Classe Despesa
            if (rbordenacao.SelectedIndex == 1)
            {
                GridListagem.Visible = true;
                AtualizaGrid("T", "D");
            }
            //Todas/Fornecedores
            if (rbordenacao.SelectedIndex == 2)
            {
                GridListagem.Visible = true;
                AtualizaGrid("T", "F");
            }
            //Todas/Data Prevista
            if (rbordenacao.SelectedIndex == 3)
            {
                GridListagem.Visible = true;
                AtualizaGrid("T", "DP");
            }
            //Todas/Data Realizado
            if (rbordenacao.SelectedIndex == 4)
            {
                GridListagem.Visible = true;
                AtualizaGrid("T", "DR");
            }
            //Todas/Data Nota Fiscal
            if (rbordenacao.SelectedIndex == 5)
            {
                GridListagem.Visible = true;
                AtualizaGrid("T", "DN");
            }
        }
        //Previsto
        if (rbparcelasituacao.SelectedIndex == 1)
        {
            //Previsto/Lançamento
            if (rbordenacao.SelectedIndex == 0)
            {
                GridListagem.Visible = true;
                AtualizaGrid("P", "L");
            }
            //Previsto/Classe Despesa
            if (rbordenacao.SelectedIndex == 1)
            {
                GridListagem.Visible = true;
                AtualizaGrid("P", "D");
            }
            //Previsto/Fornecedores
            if (rbordenacao.SelectedIndex == 2)
            {
                GridListagem.Visible = true;
                AtualizaGrid("P", "F");
            }
            //Previsto/Data Prevista
            if (rbordenacao.SelectedIndex == 3)
            {
                GridListagem.Visible = true;
                AtualizaGrid("P", "DP");
            }
            //Previsto/Data Realizado
            if (rbordenacao.SelectedIndex == 4)
            {
                GridListagem.Visible = true;
                AtualizaGrid("P", "DR");
            }
            //Previsto/Data Nota Fiscal
            if (rbordenacao.SelectedIndex == 5)
            {
                GridListagem.Visible = true;
                AtualizaGrid("P", "DN");
            }
        }
        //Realizado
        if (rbparcelasituacao.SelectedIndex == 2)
        {
            //Realizado/Lançamento
            if (rbordenacao.SelectedIndex == 0)
            {
                GridListagem.Visible = true;
                AtualizaGrid("R", "L");
            }
            //Realizado/Classe Despesa
            if (rbordenacao.SelectedIndex == 1)
            {
                GridListagem.Visible = true;
                AtualizaGrid("R", "D");
            }
            //Realizado/Fornecedores
            if (rbordenacao.SelectedIndex == 2)
            {
                GridListagem.Visible = true;
                AtualizaGrid("R", "F");
            }
            //Realizado/Data Prevista
            if (rbordenacao.SelectedIndex == 3)
            {
                GridListagem.Visible = true;
                AtualizaGrid("R", "DP");
            }
            //Realizado/Data Realizado
            if (rbordenacao.SelectedIndex == 4)
            {
                GridListagem.Visible = true;
                AtualizaGrid("R", "DR");
            }
            //Realizado/Data Nota Fiscal
            if (rbordenacao.SelectedIndex == 5)
            {
                GridListagem.Visible = true;
                AtualizaGrid("R", "DN");
            }
        }

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

}

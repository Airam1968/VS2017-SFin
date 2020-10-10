using System;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;

public partial class FRelAPagarCheques : System.Web.UI.Page
{
    //DataSet dsproduto;                                    // DATASETS DOS LOOKUPS TEM QUE SER CRIADOS AQUI  ====================================================================================
    String login_usuario;
    Boolean lImprime = false;
    String fwObs_Log = "";
    String fWtabela = "CONTAS_PAGAR";


    protected void Page_Init(object sender, EventArgs e)  // CARGA DOS LOOKUPS TEM QUE SER FEITA NESTE EVENTO  ====================================================================================
    {
        login_usuario = Convert.ToString(Session["usuario"]);
        lImprime = true; //SreDbLib.TemPermissao("001.070.080.001", (String)Session["CodUsuario"]);

        // CARGA DE UM LOOKUP  ===============================================================================================================================================
        //Combo Empresas
        cbproduto.Items.Clear();
        uProduto.MontaComboProduto(cbproduto, true);
        //
        //Combo Grupo
        cbdespesa.Items.Clear();
        uDespesas.MontaComboDespesas(cbdespesa, "0", true);
        Label1.Visible = true;
        cbdespesa.Visible = true;
        //
        //Combo Fornecedor
        cbfornecedor.Items.Clear();
        uFornecedores.MontaComboFornecedores(cbfornecedor, "0", true);
        Label7.Visible = true;
        cbfornecedor.Visible = true;
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

    protected void Page_Load(object sender, EventArgs e)
    {
        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Server.Transfer("~\\LoginTimeOut.aspx");
        }

        if (!Page.IsPostBack)
        {
            login_usuario = Convert.ToString(Session["usuario"]);
            lImprime = true; //SreDbLib.TemPermissao("001.070.080.001", (String)Session["CodUsuario"]);
            //
            //Combo Empresas
            cbproduto.Items.Clear();
            uProduto.MontaComboProduto(cbproduto, true);
            //
            //Combo Grupo
            cbdespesa.Items.Clear();
            uDespesas.MontaComboDespesas(cbdespesa, "0", true);
            Label2.Visible = true;
            cbdespesa.Visible = true;
            //
            //Combo Fornecedor
            cbfornecedor.Items.Clear();
            uFornecedores.MontaComboFornecedores(cbfornecedor, "0", true);
            Label7.Visible = true;
            cbfornecedor.Visible = true;
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

    protected void btImpressao_Click(object sender, EventArgs e)
    {
        Boolean lOk = true;
        string tst = "";
        ////CRITICAS

        if (lOk)
        {
            //CRIAÇÃO DA VARIÁVEL DE SESSÃO COM OS ELEMENTOS SELECIONADOS NO LOOKUP  ===============================================================================================================================================
            //Produto
            Session.Remove("cbproduto");
            if (cbproduto.Text != string.Empty)
            {
                Session.Add("cbproduto", cbproduto.Value.ToString().Trim());
                tst = cbproduto.Value.ToString().Trim();
            }
            else
            {
                Session.Add("cbproduto", "");
                tst = "Todos";
                //lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Nenhum Produto Selecionado!');", true);
            }
        }
        if (lOk)
        {
            //Despesa
            Session.Remove("cbdespesa");
            if (cbdespesa.Text != string.Empty)
            {
                Session.Add("cbdespesa", cbdespesa.Value.ToString().Trim());
            }
            else
            {
                Session.Add("cbdespesa", "");
                //lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Nenhuma Despesa Selecionada!');", true);
            }
        }
        if (lOk)
        {
            //Fornecedor
            Session.Remove("cbfornecedor");
            if (cbfornecedor.Text != string.Empty)
            {
                Session.Add("cbfornecedor", cbfornecedor.Value.ToString().Trim());
            }
            else
            {
                Session.Add("cbfornecedor", "");
                //lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Nenhum Fornecedor Selecionado!');", true);
            }
        }
        if (lOk)
        {
            //
            //cbcontacorrente
            Session.Remove("cbcontacorrente");
            if (cbcontascorrentes.Text != string.Empty)
            {
                Session.Add("cbcontacorrente", cbcontascorrentes.Value.ToString().Trim());
            }
            else
            {
                Session.Add("cbcontacorrente", "");
                lOk = false;
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.info('Conta corrente não informada!', 'Atenção!')", true);
            }
        }
        if (lOk)
        {
            //Documento
            Session.Remove("eddocumento");
            if (eddocumento.Text != string.Empty)
            {
                Session.Add("eddocumento", eddocumento.Text);
            }
            else
            {
                Session.Add("eddocumento", "");
            }
        }
        //
        if (lOk)
        {
            //Previsão
            Session.Remove("dtprevisao1");
            Session.Remove("dtprevisao2");
            if (dtprevisao1.Text != string.Empty)
            {
                Session.Add("dtprevisao1", dtprevisao1.Value.ToString().Trim());
            }
            else
            {
                Session.Add("dtprevisao1", "01/01/1900");
            }
            //
            if (dtprevisao2.Text != string.Empty)
            {
                Session.Add("dtprevisao2", dtprevisao2.Value.ToString().Trim());
            }
            else
            {
                Session.Add("dtprevisao2", "31/12/2999");
            }
        }
        if (lOk)
        {
            //Realizado
            Session.Remove("dtrealizado1");
            Session.Remove("dtrealizado2");
            if (dtrealizado1.Text != string.Empty)
            {
                Session.Add("dtrealizado1", dtrealizado1.Value.ToString().Trim());
            }
            else
            {
                Session.Add("dtrealizado1", "01/01/1900");
            }
            //
            if (dtrealizado2.Text != string.Empty)
            {
                Session.Add("dtrealizado2", dtrealizado2.Value.ToString().Trim());
            }
            else
            {
                Session.Add("dtrealizado2", "31/12/2999");
            }
        }
        if (lOk)
        {
            //Data Nota Fiscal
            Session.Remove("dtnotafiscal1");
            Session.Remove("dtnotafiscal2");
            if (dtnotafiscal1.Text != string.Empty)
            {
                Session.Add("dtnotafiscal1", dtnotafiscal1.Value.ToString().Trim());
            }
            else
            {
                Session.Add("dtnotafiscal1", "01/01/1900");
            }
            //
            if (dtnotafiscal2.Text != string.Empty)
            {
                Session.Add("dtnotafiscal2", dtnotafiscal2.Value.ToString().Trim());
            }
            else
            {
                Session.Add("dtnotafiscal2", "31/12/2999");
            }
        }
        if (lOk)
        {
            //Número Cheque
            Session.Remove("ednumerocheque");
            if (ednumerocheque.Text != string.Empty)
            {
                Session.Add("ednumerocheque", ednumerocheque.Text);
            }
            else
            {
                Session.Add("ednumerocheque", "");
                lOk = false;
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.info('Numero do cheque não informado!', 'Atenção!')", true);
            }
        }
        //
        if (lOk)
        {
            //rblancamentossituacao
            Session.Remove("rblancamentossituacao");
            Session.Add("rblancamentossituacao", rblancamentossituacao.SelectedIndex.ToString());
            //
            //rbordenacao
            Session.Remove("rbordenacao");
            Session.Add("rbordenacao", rbordenacao.SelectedIndex.ToString());
            //
            //rbvalores
            Session.Remove("rbvalores");
            Session.Add("rbvalores", rbvalores.SelectedIndex.ToString());
            //
            //rbcompensacao
            Session.Remove("rbcompensacao");
            Session.Add("rbcompensacao", rbcompensacao.SelectedIndex.ToString());
            //
            //FIM CRIAÇÃO DA VARIÁVEL DE SESSÃO COM OS ELEMENTOS SELECIONADOS NO LOOKUP  ===============================================================================================================================================

            //Usando Classe uLog.MakeLog - Gravando Log
            fwObs_Log = "RELATÓRIO CONTAS A PAGAR - CHEQUES: " + tst;
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]           ), 
                                         new SqlParameter("@tabela"   , fWtabela                                ),
                                         new SqlParameter("@operacao" , "RELATÓRIO"                             ),
                                         new SqlParameter("@obs"      , "RELATÓRIO CONTAS A PAGAR - CHEQUES"    ),
                                         new SqlParameter("@acao"     , fwObs_Log                               ) };
            uLog.MakeLog(param_log);

            // FIM CRIA LOG RELATÓRIO  ===============================================================================================================================================

            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( '" + HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpRuntime.AppDomainAppVirtualPath + "/_APagar/relatorios/RelAPagarCheques.aspx', null, 'height=755,width=900,status=yes,resizable=yes,menubar=yes,location=yes' );", true);

        }
    }

    protected void cbproduto_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        if (cbproduto.Text != string.Empty)
        {
            Label2.Visible = true;
            cbdespesa.Visible = true;
            //
            //Combo Fornecedor
            Label7.Visible = true;
            cbfornecedor.Visible = true;
            //
            //Combo Contas Correntes
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
        }
        else
        {
            Label2.Visible = false;
            cbdespesa.Visible = false;
            //
            //Combo Fornecedor
            Label7.Visible = false;
            cbfornecedor.Visible = false;
            //
            //Combo Contas Correntes
            Label16.Visible = false;
            cbcontascorrentes.Visible = false;
            //
            Label4.Visible = false;
            dtprevisao1.Visible = false;
            Label5.Visible = false;
            dtprevisao2.Visible = false;
            //
            Label6.Visible = false;
            dtrealizado1.Visible = false;
            Label9.Visible = false;
            dtrealizado2.Visible = false;
            //
            Label10.Visible = false;
            dtnotafiscal1.Visible = false;
            Label11.Visible = false;
            dtnotafiscal2.Visible = false;
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

    protected void cbcontacorrente_SelectedIndexChanged(object sender, EventArgs e)
    {
        //edmulta.Focus();
    }
}

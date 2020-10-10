using System;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;

public partial class FRelAReceberLancamentos : System.Web.UI.Page
{
    //DataSet dsproduto;                                    // DATASETS DOS LOOKUPS TEM QUE SER CRIADOS AQUI  ====================================================================================
    String login_usuario;
    Boolean lImprime = false;
    String fwObs_Log = "";
    String fWtabela = "CONTAS_RECEBER";


    protected void Page_Init(object sender, EventArgs e)  // CARGA DOS LOOKUPS TEM QUE SER FEITA NESTE EVENTO  ====================================================================================
    {
        login_usuario = Convert.ToString(Session["usuario"]);
        lImprime = true; //SreDbLib.TemPermissao("001.070.080.001", (String)Session["CodUsuario"]);

        // CARGA DE UM LOOKUP  ===============================================================================================================================================
        //Combo Empresas
        cbproduto.Items.Clear();
        uProduto.MontaComboProduto(cbproduto, true);
        //
        //Combo Receita
        cbreceita.Items.Clear();
        uReceitas.MontaComboReceitas(cbreceita, "0", true);
        Label1.Visible = true;
        cbreceita.Visible = true;
        //
        //
        //Combo Cliente
        if ((SreDblib.GetParametro("ORDEM CLIENTE") == "CODIGO") && (SreDblib.GetParametro("ORDEM CLIENTE") == "CÓDIGO"))
        {
            cbcliente.Items.Clear();
            uCliente.MontaComboClientes(cbcliente, "0", true);
            Label7.Visible = true;
            cbcliente.Visible = true;
        }
        else
        {
            if (SreDblib.GetParametro("FILTRO CLIENTE") == "SIM")
            {
                Label7.Visible = true;
                cbcliente_filtro.Visible = true;
            }
            else
            {
                cbcliente.Items.Clear();
                uCliente.MontaComboClientes(cbcliente, "0", true);
                Label7.Visible = true;
                cbcliente.Visible = true;
            }
        }
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
        //
        edsaldoinicial.Text = "0,00";
        Label4.Visible = true;
        edsaldoinicial.Visible = true;
        //

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
            //Combo Receita
            cbreceita.Items.Clear();
            uReceitas.MontaComboReceitas(cbreceita, "0", true);
            Label1.Visible = true;
            cbreceita.Visible = true;
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
            //
            edsaldoinicial.Text = "0,00";
            Label4.Visible = true;
            edsaldoinicial.Visible = true;
            //

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
            //Receita
            Session.Remove("cbreceita");
            if (cbreceita.Text != string.Empty)
            {
                Session.Add("cbreceita", cbreceita.Value.ToString().Trim());
            }
            else
            {
                Session.Add("cbdespesa", "");
                //lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Nenhuma Despesa Selecionada!');", true);
            }
        }
        //
        if (lOk)
        {
            //Check Cliente
            Session.Remove("cbcliente");
            if ((SreDblib.GetParametro("ORDEM CLIENTE") == "CODIGO") && (SreDblib.GetParametro("ORDEM CLIENTE") == "CÓDIGO"))
            {
                if (cbcliente.Text != null)
                {
                    Session.Add("cbcliente", cbcliente.Value.ToString().Trim());
                }
                else
                {
                    Session.Add("cbcliente", "");
                }
            }
            else
            {
                if (SreDblib.GetParametro("FILTRO CLIENTE") == "SIM")
                {
                    if (cbcliente_filtro.Text != String.Empty)
                    {
                        string cliente = cbcliente_filtro.Text.Substring(cbcliente_filtro.Text.IndexOf("(", 1) + 1,
                                            cbcliente_filtro.Text.IndexOf(")", 1) - 1 - cbcliente_filtro.Text.IndexOf("(", 1));
                        Session.Add("cbcliente", cliente);
                    }
                    else
                    {
                        Session.Add("cbcliente", "");
                    }
                }
                else
                {
                    if (cbcliente.Text != null)
                    {
                        Session.Add("cbcliente", cbcliente.Value.ToString().Trim());
                    }
                    else
                    {
                        Session.Add("cbcliente", "");
                    }
                }
            }
            //Fim Check Cliente
        }
        //
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
            }
        }
        if (lOk)
        {
            //Documento
            Session.Remove("eddocumento");
            if (eddocumento.Text != string.Empty)
            {
                Session.Add("eddocumento", eddocumento);
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
                Session.Add("dtprevisao1", dtprevisao1.Text.Substring(0, 10));
            }
            else
            {
                Session.Add("dtprevisao1", "01/01/1900");
            }
            //
            if (dtprevisao2.Text != string.Empty)
            {
                Session.Add("dtprevisao2", dtprevisao2.Text.Substring(0, 10));
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
                Session.Add("dtrealizado1", dtrealizado1.Text.Substring(0, 10));
            }
            else
            {
                Session.Add("dtrealizado1", "01/01/1900");
            }
            //
            if (dtrealizado2.Text != string.Empty)
            {
                Session.Add("dtrealizado2", dtrealizado2.Text.Substring(0, 10));
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
                Session.Add("dtnotafiscal1", dtnotafiscal1.Text.Substring(0, 10));
            }
            else
            {
                Session.Add("dtnotafiscal1", "01/01/1900");
            }
            //
            if (dtnotafiscal2.Text != string.Empty)
            {
                Session.Add("dtnotafiscal2", dtnotafiscal2.Text.Substring(0, 10));
            }
            else
            {
                Session.Add("dtnotafiscal2", "31/12/2999");
            }
        }
        //
        if (lOk)
        {
            //Saldo Inicial
            Session.Remove("edsaldoinicial");
            if (edsaldoinicial.Text != string.Empty)
            {
                Session.Add("edsaldoinicial", edsaldoinicial.Text);
            }
            else
            {
                Session.Add("edsaldoinicial", "0");
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

            //FIM CRIAÇÃO DA VARIÁVEL DE SESSÃO COM OS ELEMENTOS SELECIONADOS NO LOOKUP  ===============================================================================================================================================

            //Usando Classe uLog.MakeLog - Gravando Log
            fwObs_Log = "RELATÓRIO CONTAS A RECEBER - LANÇAMENTOS: " + tst;
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]           ), 
                                         new SqlParameter("@tabela"   , fWtabela                                ),
                                         new SqlParameter("@operacao" , "RELATÓRIO"                             ),
                                         new SqlParameter("@obs"      , "RELATÓRIO CONTAS A RECEBER - LANÇAMENTOS"),
                                         new SqlParameter("@acao"     , fwObs_Log                               ) };
            uLog.MakeLog(param_log);

            // FIM CRIA LOG RELATÓRIO  ===============================================================================================================================================

            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( '" + HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpRuntime.AppDomainAppVirtualPath + "/_AReceber/relatorios/RelAReceberLancamentos.aspx', null, 'height=755,width=900,status=yes,resizable=yes,menubar=yes,location=yes' );", true);

        }
    }

    protected void cbproduto_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        if (cbproduto.Text != string.Empty)
        {
            Label1.Visible = true;
            cbreceita.Visible = true;
            //
            //Combo Fornecedor
            Label7.Visible = true;
            cbcliente.Visible = true;
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
            Label1.Visible = false;
            cbreceita.Visible = false;
            //
            //Combo Fornecedor
            Label7.Visible = false;
            cbcliente.Visible = false;
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

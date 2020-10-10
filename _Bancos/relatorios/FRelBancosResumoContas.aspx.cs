using System;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;

public partial class FRelBancosResumoContas : System.Web.UI.Page
{
    //DataSet dsproduto;                                    // DATASETS DOS LOOKUPS TEM QUE SER CRIADOS AQUI  ====================================================================================
    String login_usuario;
    Boolean lImprime = false;
    String fwObs_Log = "";
    String fWtabela = "CONTA";


    protected void Page_Init(object sender, EventArgs e)  // CARGA DOS LOOKUPS TEM QUE SER FEITA NESTE EVENTO  ====================================================================================
    {
        login_usuario = Convert.ToString(Session["usuario"]);
        lImprime = true; //SreDbLib.TemPermissao("001.070.080.001", (String)Session["CodUsuario"]);

        // CARGA DE UM LOOKUP  ===============================================================================================================================================
        //Combo Contas Correntes
        cbcontascorrentes.Items.Clear();
        uContas.MontaComboContas(cbcontascorrentes, "0");
        //Label16.Visible = true;
        //cbcontascorrentes.Visible = true;
        //
        //Label4.Visible = true;
        //dtprevisao1.Visible = true;
        //Label5.Visible = true;
        //dtprevisao2.Visible = true;
        //
        dtprevisao1.Date = Convert.ToDateTime("01/01/1900");
        dtprevisao2.Date = Convert.ToDateTime("31/12/2999");

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
            //
            //Combo Contas Correntes
            cbcontascorrentes.Items.Clear();
            uContas.MontaComboContas(cbcontascorrentes, "0");
            //Label16.Visible = true;
            //cbcontascorrentes.Visible = true;
            //
            //Label4.Visible = true;
            //dtprevisao1.Visible = true;
            //Label5.Visible = true;
            //dtprevisao2.Visible = true;
            //
            dtprevisao1.Date = Convert.ToDateTime("01/01/1900");
            dtprevisao2.Date = Convert.ToDateTime("31/12/2999");
        }
    }

    protected void btImpressao_Click(object sender, EventArgs e)
    {
        Boolean lOk = true;
        string tst = "";
        ////CRITICAS

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
                //lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Nenhuma Conta Selecionada!');", true);
                Session.Add("cbcontacorrente", "");
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
            //FIM CRIAÇÃO DA VARIÁVEL DE SESSÃO COM OS ELEMENTOS SELECIONADOS NO LOOKUP  ===============================================================================================================================================

            //Usando Classe uLog.MakeLog - Gravando Log
            fwObs_Log = "RELATÓRIO BANCOS - RESUMO DE CONTAS: " + tst;
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]           ), 
                                         new SqlParameter("@tabela"   , fWtabela                                ),
                                         new SqlParameter("@operacao" , "RELATÓRIO"                             ),
                                         new SqlParameter("@obs"      , "RELATÓRIO BANCOS - RESUMO DE CONTAS"   ),
                                         new SqlParameter("@acao"     , fwObs_Log                               ) };
            uLog.MakeLog(param_log);

            // FIM CRIA LOG RELATÓRIO  ===============================================================================================================================================

            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( '" + HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpRuntime.AppDomainAppVirtualPath + "/_Bancos/relatorios/RelBancosResumoContas.aspx', null, 'height=755,width=900,status=yes,resizable=yes,menubar=yes,location=yes' );", true);

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

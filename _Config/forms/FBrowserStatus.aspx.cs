using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;

public partial class FBrowserStatus : System.Web.UI.Page
{
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "TODAS";
    DataSet ds0 = new DataSet();
    //

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = SreDblib.TemPermissao("001.011.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.011.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.011.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.011.004.000", (String)Session["CodUsuario"]);
        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        //
        btprocessa.Enabled = lConsulta;
        if (!lConsulta)
            btprocessa.Image.ToolTip = Msg_acesso;
        //
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
            //
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
        //
        HttpBrowserCapabilities bc = Request.Browser;


        if (lOk)
        {
            //
            lbbasegitano2.Text = bc.Type;
            //
            lbbasecep2.Text = bc.Browser;
            //
            lbusuariosativos2.Text = bc.Version;
            //
            lbclientesfinanciamentos2.Text = bc.MajorVersion.ToString();
            //
            lbunidadescadastradas2.Text = bc.MinorVersion.ToString();
            //
            lbvendas2.Text = bc.Platform;
            //
            lbcontasapagar2.Text = bc.Beta.ToString();
            //
            lbcontasareceber2.Text = bc.Crawler.ToString();
            //
            lbclientescreceber2.Text = bc.AOL.ToString();
            //
            lbfornecedorescpagar2.Text = bc.Win16.ToString();
            //
            lbcontascorrentes2.Text = bc.Win32.ToString();
            //
            lbcorretores2.Text = bc.Frames.ToString();
            //
            lblog2.Text = bc.Tables.ToString();
            //
            lbfornecedores.Text = bc.Cookies.ToString();
            //
            lbreceitas.Text = bc.VBScript.ToString();
            //
            lbclientescontaareceber.Text = bc.JavaScript.ToString();
            //
            lbbancos.Text = bc.JavaApplets.ToString();
            //
            lbcontascorrentes3.Text = bc.ActiveXControls.ToString();
            //
            lbsaldoinicial.Text = bc.CDF.ToString();
            //

        }

        //
        //Processamento
        ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Processamento Concluído!');", true);


        if (lOk)
        {
            // CRIA LOG  ===============================================================================================================================================
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
                                         new SqlParameter("@tabela"   , "TODAS"                      ),
                                         new SqlParameter("@operacao" , "CONFIG"                     ),
                                         new SqlParameter("@obs"      , "STATUS"                     ),
                                         new SqlParameter("@acao"     , "STATUS DO BROWSER"          ) };
            uLog.MakeLog(param_log);
            // FIM CRIA LOG ============================================================================================================================================
        }
    }
}

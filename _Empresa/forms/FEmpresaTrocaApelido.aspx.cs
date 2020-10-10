using System;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;

public partial class FEmpresaTrocaApelido : System.Web.UI.Page
{
    Boolean lInsere;
    Boolean lAltera;
    Boolean lExclui;
    String fwObs_Log = "";
    String fWtabela = "EMPRESA";
    //

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = SreDblib.TemPermissao("001.013.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.013.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.013.003.000", (String)Session["CodUsuario"]);
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
            //Combo Empresas
            cbempresa.Items.Clear();
            uEmpresa.MontaComboEmpresa(cbempresa);
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

        edempresa.Text = Srelib.tiraacento(edempresa.Text.Trim().ToUpper());

        if (lOk)
        {
            if (edempresa.Text.Trim() == String.Empty)
            {
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Apelido Original Não Preenchido!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Apelido Original Não Preenchido!', 'Atenção!')", true);
                lOk = false;
            }

        }
        if (lOk)
        {
            if (cbempresa.Text.Trim() == String.Empty)
            {
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Apelido Original Não Preenchido!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Apelido Original Não Preenchido!', 'Atenção!')", true);
                lOk = false;
            }
        }
        if (lOk)
        {
            if (cbempresa.Text.Trim() == edempresa.Text.Trim())
            {
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Apelidos Iguais, Processamento Abortado!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Apelidos Iguais, Processamento Abortado!', 'Atenção!')", true);
                lOk = false;
            }
        }

        if (lOk)
        {
            if (edempresa.Text.Trim().Length > 20)
            {
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Apelido Novo com mais de 20 caracteres, Processamento Abortado!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Apelido Novo com mais de 20 caracteres, Processamento Abortado!', 'Atenção!')", true);
                lOk = false;
            }
        }

        if (lOk)
        {
            //Processamento
            //Troca Apelido
            uEmpresa.TrocaApelido(cbempresa.Text.Trim(),edempresa.Text.Trim().ToUpper());
            //
            // CRIA LOG  ===============================================================================================================================================
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
                                         new SqlParameter("@tabela"   , fWtabela                     ),
                                         new SqlParameter("@operacao" , "UTILITÁRIOS"                ),
                                         new SqlParameter("@obs"      , "TROCA APELIDO"              ),
                                         new SqlParameter("@acao"     , "TROCA APELIDO EMPRESA - DE/PARA: "+cbempresa.Text+"/"+edempresa.Text      ) };
            uLog.MakeLog(param_log);
            // FIM CRIA LOG ============================================================================================================================================

            //Limpa
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Processamento Concluído!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.success('Processamento Concluído!', 'Atenção!')", true);
            btprocessa.Enabled = false;
            //Combo Empresas
            cbempresa.Items.Clear();
            cbempresa.Text = "";
            uEmpresa.MontaComboEmpresa(cbempresa);
            edempresa.Text = "";
            //
        }
    }
}

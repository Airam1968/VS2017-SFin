using System;
using System.Data.SqlClient;
using System.IO;
using System.Web;
using System.Web.UI;

public partial class SiteMaster : System.Web.UI.MasterPage
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetExpires(DateTime.Now);
        Response.Cache.SetNoServerCaching();
        Response.Cache.SetNoStore();

        if ((String)Session["CodUsuario"] != null)
        {
            //Atualizar labels do header master page
            String BaseSql = (String)Session["CodBaseSql"];
            //
            //BaseSql = BaseSql.Substring(3, BaseSql.Length - 3);
            lbbase.Text = "Base: " + BaseSql + " ";
            lbusuario.Text = "Usuário: " + (String)Session["CodUsuario"] + " ";
            //
            //
            FileInfo file_info = new FileInfo("C:\\inetpub\\wwwroot\\Gitano\\Principal.aspx");
            string Criado = file_info.CreationTime.ToString("dd/MM/yyyy"); //("dd/MM/yyyy HH:mm:ss");
            string Modificado = file_info.LastWriteTime.ToString("dd/MM/yyyy"); //("dd/MM/yyyy HH:mm:ss");
            string Acessado = file_info.LastAccessTime.ToString("dd/MM/yyyy"); //("dd/MM/yyyy HH:mm:ss");
            //
            lbfechamento.Text = "Correção: " + Convert.ToDateTime("01/01/1900").ToString("dd/MM/yyyy").Substring(0, 10);
            //
            lbdataatual.Text = "Data Atual: " + Convert.ToString(DateTime.Now).Substring(0, 10);
            //
            if (Convert.ToInt16(Modificado.Substring(6,4)) < 1900)
            {
                lbatualizacao.Text = "Atualizado: " + "01/01/1900";
            }
            else
            {
                lbatualizacao.Text = "Atualizado: " + Modificado;
            }
            //
            //Bloco de Status Header
            lblogoff.Visible = true;
            lbbase.Visible = true;
            lbusuario.Visible = true;
            lbatualizacao.Visible = true;
            lbfechamento.Visible = true;
            lbdataatual.Visible = true;
            Image1.Visible = true;

            //Parâmetros

            //
        }
        else
        {
            //Bloco de Status Header
            lblogoff.Visible = false;
            lbdataatual.Visible = false;
            lbusuario.Visible = false;
            lbatualizacao.Visible = false;
            lbdataatual.Visible = false;
            lbdataatual.Visible = false;
            Image1.Visible = false;

        }

    }
    protected void lblogoff_Click(object sender, EventArgs e)
    {
        //
        // CRIA LOG  ===============================================================================================================================================
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
                                     new SqlParameter("@tabela"   , "USUARIO"                    ),
                                     new SqlParameter("@operacao" , "LOGIN"                      ),
                                     new SqlParameter("@obs"      , "SAÍDA DO SISTEMA"           ),
                                     new SqlParameter("@acao"     , "SAÍDA DO SISTEMA USUÁRIO: "+(String)Session["CodUsuario"]        ) };
        uLog.MakeLog(param_log);
        // FIM CRIA LOG ============================================================================================================================================
        //
        Session.Clear();
        Session.Abandon();
        //
        lblogoff.Visible = false;
        //
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetExpires(DateTime.Now);
        Response.Cache.SetNoServerCaching();
        Response.Cache.SetNoStore();
        //
        Response.Redirect("~\\Login.aspx");
    }
    protected void ASPxButton12_Click(object sender, EventArgs e)
    {
        //Sobre Nós
        ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( 'http://www.gitanosoftware.com.br/#team', null, 'height=900,width=1055,status=yes,resizable=yes,menubar=yes,location=yes' );", true);
    }
    protected void ASPxButton11_Click(object sender, EventArgs e)
    {
        //Hot Site
        ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( 'http://www.gitanosoftware.com.br/', null, 'height=900,width=1155,status=yes,resizable=yes,menubar=yes,location=yes' );", true);
    }
    protected void ASPxButton6_Click(object sender, EventArgs e)
    {
        //Chat
        ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( 'http://online.chatlive.com.br/rgbsys/atendimento.php?login=rgbsys&yid=1&deptid=0&page=http%3A//rgbsys.no-ip.org/Suporte/%23%23%23', null, 'height=500,width=500,status=yes,resizable=yes,menubar=yes,location=yes' );", true);
    }
    protected void ASPxButton4_Click(object sender, EventArgs e)
    {
        //Twitter
        ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( 'https://twitter.com/intent/user?screen_name=airam1968', null, 'height=900,width=1055,status=yes,resizable=yes,menubar=yes,location=yes' );", true);
    }
    protected void ASPxButton5_Click(object sender, EventArgs e)
    {
        //Blog
        ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( 'https://gitanosoftware.wordpress.com/', null, 'height=900,width=1055,status=yes,resizable=yes,menubar=yes,location=yes' );", true);
    }
    protected void ASPxButton9_Click(object sender, EventArgs e)
    {
        //Videos
        ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( 'http://gitanosoftware.blogspot.com.br/', null, 'height=900,width=1155,status=yes,resizable=yes,menubar=yes,location=yes' );", true);
    }
    protected void ASPxButton10_Click(object sender, EventArgs e)
    {
        //Novidades
        ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( 'http://www.gitanosoftware.com.br/#portfolios', null, 'height=900,width=1055,status=yes,resizable=yes,menubar=yes,location=yes' );", true);
    }
    protected void ASPxButton8_Click(object sender, EventArgs e)
    {
        //E-Mails
        ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( 'mailto:airam1968@terra.com.br', null, 'status=yes,resizable=no,menubar=yes,location=yes' );", true);
        //SABER COMO LINKAR AO E-MAIL
    }
    protected void ASPxButton3_Click(object sender, EventArgs e)
    {
        //Facebook
        ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( 'https://www.facebook.com/GitanoSoftware', null, 'status=yes,resizable=no,menubar=yes,location=yes' );", true);
    }
}

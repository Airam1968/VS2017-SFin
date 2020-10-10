using System;
using System.Data.SqlClient;
using System.Web;
using System.Text;


public partial class FFavoritos : System.Web.UI.Page
{
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

        //Carregamento
        StringBuilder texto = new StringBuilder();

        texto.Append("Favoritos, Links Úteis:").AppendLine();
        texto.AppendLine();
        texto.AppendLine();
        //
        texto.Append("Taxas IGP-M. ").AppendLine();
        texto.Append("https://www.portalbrasil.net/igpm.htm").AppendLine();
        texto.AppendLine();

        MemoNovidades.Text = texto.ToString();
        //
    }


}

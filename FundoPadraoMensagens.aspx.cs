using System;

public partial class FundoPadraoMensagens : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Response.Redirect("~\\LoginTimeOut.aspx");
        }
    }

    protected void Page_Init(object sender, EventArgs e)
    {
        MemoJuridico.Text = "Não há Alertas no momento...";
        MemoAdministrativo.Text = "Não há Alertas no momento...";
    }
}
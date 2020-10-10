using System;
using System.Data;
using System.Web.UI;

public partial class RelProposta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Server.Transfer("~\\LoginTimeOut.aspx");
        }

        ScriptManager.RegisterStartupScript(this, typeof(string), "MAXIMIZE", "top.window.moveTo(0,0); top.window.resizeTo(screen.availWidth,screen.availHeight);", true);

        RepPropostas report = new RepPropostas();
        // Use SqlDataAdapter to define and populate a DataSet using the information extracted from a Session vairable

        // EMPRESA MATRIZ
        report.ltempresa.Text = uEmpresa.PegaNome(uEmpresa.PegaMatriz());
        //
        // ID PROPOSTA
        string id = Convert.ToString(Session["proposta"]);
        report.proposta = Convert.ToInt64(id);
        //
        // RODAPÉ
        report.lcaminho.Text = "Gitano ->SGFin ->Propostas ->Proposta de Venda de Imóvel";
        //
        //
        DataSet ds;

        ds = uProposta.PegaDadosPropostaID(id);
        //
        report.DataSource = ds;
        report.DataMember = ds.Tables[0].TableName;
        //

        if (ds.Tables[0].Rows.Count > 0)
        {
            ReportViewer1.Report = report;
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Nada a Imprimir!');", true);
            Page.ClientScript.RegisterStartupScript(GetType(), "close", "self.close()", true);
        }
    }

}
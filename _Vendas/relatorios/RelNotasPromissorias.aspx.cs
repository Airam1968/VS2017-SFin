using System;
using System.Data;
using System.Web.UI;

public partial class RelNotasPromissorias : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Server.Transfer("~\\LoginTimeOut.aspx");
        }

        ScriptManager.RegisterStartupScript(this, typeof(string), "MAXIMIZE", "top.window.moveTo(0,0); top.window.resizeTo(screen.availWidth,screen.availHeight);", true);

        RepNotasPromissorias report = new RepNotasPromissorias();
        // Use SqlDataAdapter to define and populate a DataSet using the information extracted from a Session vairable

        // PRODUTO
        string produto = Convert.ToString(Session["cbproduto"]);
        // GRUPO
        string grupo = Convert.ToString(Session["cbgrupo"]);
        // UNIDADE
        string unidade = Convert.ToString(Session["cbgrupounidades"]);
        // PARTE
        string parte = Convert.ToString(Session["parte"]);
        // CONTA CORRENTE
        string contacorrente = Convert.ToString(Session["cbcontacorrente"]);
        // PROPRIETARIO
        string cliente = Convert.ToString(Session["cbcliente"]);
        // PERIODO
        DateTime dtprevisao1 = Convert.ToDateTime(Session["dtprevisao1"]);
        DateTime dtprevisao2 = Convert.ToDateTime(Session["dtprevisao2"]);
        //report.lfperiodo.Text = dtprevisao1.Date.ToString().Substring(0, 10) + " até " + dtprevisao2.Date.ToString().Substring(0, 10);

        //rbparcelasituacao
        string rbparcelasituacao = Convert.ToString(Session["rbparcelasituacao"]);
        string rbparcelasituacao2 = "";
        if (rbparcelasituacao == "0")
            rbparcelasituacao2 = "T";
        if (rbparcelasituacao == "1")
            rbparcelasituacao2 = "P";
        if (rbparcelasituacao == "2")
            rbparcelasituacao2 = "A";
        //
        //rbdatabase
        string rbdatabase = Convert.ToString(Session["rbdatabase"]);
        report.rbdatabase = rbdatabase;
        //
        //ckconjuge
        Boolean ckconjuge = Convert.ToBoolean(Session["ckconjuge"]);
        report.ckconjuge = ckconjuge;

        // USUÁRIO
        string usuario = Convert.ToString(Session["CodUsuario"]);
        //report.ltusuario.Text = "Usuário: " + usuario;

        DataSet ds;

        ds = uParcelas.PegaDadosParcelas2(produto,
                                         grupo,
                                         unidade,
                                         parte,
                                         "1",
                                         dtprevisao1.ToString().Substring(0, 10),
                                         dtprevisao2.ToString().Substring(0, 10),
                                         rbparcelasituacao2,
                                         contacorrente,
                                         "N",
                                         false,
                                         "1");
        //
        report.quantidade = ds.Tables[0].Rows.Count;
        //
        report.DataSource = ds;
        report.DataMember = ds.Tables[0].TableName;

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
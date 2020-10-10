using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

public partial class RelAPagarDespesas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Server.Transfer("~\\LoginTimeOut.aspx");
        }

        ScriptManager.RegisterStartupScript(this, typeof(string), "MAXIMIZE", "top.window.moveTo(0,0); top.window.resizeTo(screen.availWidth,screen.availHeight);", true);

        RepAPagarDespesas report = new RepAPagarDespesas();
        // Use SqlDataAdapter to define and populate a DataSet using the information extracted from a Session vairable

        // EMPRESA MATRIZ
        report.ltempresa.Text = uEmpresa.PegaNome(uEmpresa.PegaMatriz());

        // DESPESAS
        string despesas = Convert.ToString(Session["cbdespesas"]);
        if (despesas == "")
        {
            report.lfdespesa.Text = "Todas";
            despesas = "0";
        }
        else
        {
            if (despesas.Substring(0, 1) == "'")
            {
                report.lfdespesa.Text = "Algumas";
            }
            else
            {
                report.lfdespesa.Text = "Selecionado";
            }
        }
        // USUÁRIO
        string usuario = Convert.ToString(Session["CodUsuario"]);
        report.ltusuario.Text = "Usuário: " + usuario;

        // RODAPÉ
        report.lcaminho.Text = "Gitano ->SGFin ->Contas a Pagar ->Relatório Despesas Cadastro";

        DataSet ds;

        ds = uDespesas.PegaDadosDespesas(despesas);

        report.DataSource = ds;
        report.DataMember = ds.Tables[0].TableName;
        report.lcodigo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "codigo")});
        report.ldescricao.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "descricao")});
        report.lcontacontabil.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "conta_contabil")});
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
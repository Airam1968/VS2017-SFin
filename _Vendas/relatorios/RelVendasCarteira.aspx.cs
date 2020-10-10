using System;
using System.Data;
using System.Web.UI;

public partial class RelVendasCarteira : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Server.Transfer("~\\LoginTimeOut.aspx");
        }

        ScriptManager.RegisterStartupScript(this, typeof(string), "MAXIMIZE", "top.window.moveTo(0,0); top.window.resizeTo(screen.availWidth,screen.availHeight);", true);

        RepVendasCarteira report = new RepVendasCarteira();
        // Use SqlDataAdapter to define and populate a DataSet using the information extracted from a Session vairable

        // EMPRESA MATRIZ
        report.ltempresa.Text = uEmpresa.PegaNome(uEmpresa.PegaMatriz());

        // PRODUTO
        string produto = Convert.ToString(Session["cbproduto"]);
        if (produto == "")
        {
            report.lfproduto.Text = "Todos";
        }
        else
        {
            if (produto.Substring(0, 1) == "'")
            {
                report.lfproduto.Text = "Alguns";
            }
            else
            {
                report.lfproduto.Text = produto + " - " + uProduto.PegaProdutoDescricao(Convert.ToInt32(produto));
            }
        }
        // GRUPO
        string grupo = Convert.ToString(Session["cbgrupo"]);
        if (grupo == "")
        {
            report.lfgrupo.Text = "Todos";
        }
        else
        {
            if (produto.Substring(0, 1) == "'")
            {
                report.lfgrupo.Text = "Alguns";
            }
            else
            {
                report.lfgrupo.Text = grupo + " - " + uProduto.PegaProdutoGrupoDescricao(Convert.ToInt32(produto), Convert.ToInt32(grupo));
            }
        }
        // PERIODO
        DateTime dtprevisao1 = Convert.ToDateTime(Session["dtprevisao1"]);
        DateTime dtprevisao2 = Convert.ToDateTime(Session["dtprevisao2"]);
        report.lfperiodo.Text = dtprevisao1.Date.ToString().Substring(0, 10) + " até " + dtprevisao2.Date.ToString().Substring(0, 10);

        // USUÁRIO
        string usuario = Convert.ToString(Session["CodUsuario"]);
        report.ltusuario.Text = "Usuário: " + usuario;

        // RODAPÉ
        report.lcaminho.Text = "Gitano ->SGFin ->Vendas ->Relatório Vendas Carteira";
        //
        DataSet ds;
        ds = uParcelas.PegaDadosParcelasCarteira(produto, grupo, dtprevisao1.ToString().Substring(0, 10), dtprevisao2.ToString().Substring(0, 10));
        //

        report.DataSource = ds;
        report.DataMember = ds.Tables[0].TableName;
        report.ltitulosqtd.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "titulosqtd")});
        report.ltitulospagosqtd.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "titulospagosqtd")});
        report.ltitulosdevidosqtd.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "titulosdevidosqtd")});
        report.ltituloscarteirapagosqtd.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tituloscarteirapagosqtd")});
        report.ltituloscarteiradevidosqtd.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tituloscarteiradevidosqtd")});
        report.ltitulosbancariapagosqtd.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "titulosbancariapagosqtd")});
        report.ltitulosbancariadevidosqtd.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "titulosbancariadevidosqtd")});
        report.ltitulosprotestoqtd.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "titulosprotestoqtd")});
        //
        report.ltitulosvlr.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "titulosvlr", "{0:N}")});
        report.ltitulospagosvlr.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "titulospagosvlr", "{0:N}")});
        report.ltitulosdevidosvlr.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "titulosdevidosvlr", "{0:N}")});
        report.ltituloscarteirapagosvlr.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tituloscarteirapagosvlr", "{0:N}")});
        report.ltituloscarteiradevidosvlr.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tituloscarteiradevidosvlr", "{0:N}")});
        report.ltitulosbancariapagosvlr.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "titulosbancariapagosvlr", "{0:N}")});
        report.ltitulosbancariadevidosvlr.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "titulosbancariadevidosvlr", "{0:N}")});
        report.ltitulosprotestovlr.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "titulosprotestovlr", "{0:N}")});
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
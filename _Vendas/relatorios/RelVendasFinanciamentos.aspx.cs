using System;
using System.Data;
using System.Web.UI;

public partial class RelVendasFinanciamentos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Server.Transfer("~\\LoginTimeOut.aspx");
        }

        ScriptManager.RegisterStartupScript(this, typeof(string), "MAXIMIZE", "top.window.moveTo(0,0); top.window.resizeTo(screen.availWidth,screen.availHeight);", true);

        RepVendasFinanciamentos report = new RepVendasFinanciamentos();
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
        // UNIDADE
        string unidade = Convert.ToString(Session["cbgrupounidades"]);
        if (unidade == "")
        {
            //report.lfgrupounidade.Text = "Todas";
        }
        else
        {
            if (unidade.Substring(0, 1) == "'")
            {
                //report.lfgrupounidade.Text = "Algumas";
            }
            else
            {
                //report.lfgrupounidade.Text = unidade;
            }
        }
        // PARTE
        string parte = Convert.ToString(Session["cbparte"]);
        if (parte != "0")
        {
            //report.lfgrupounidade.Text = report.lfgrupounidade.Text + " - Parte: " + parte;
        }
        // MEIOLOTE
        string meiolote = Convert.ToString(Session["cbmeiolote"]);
        if (parte != "0")
        {
            //report.lfgrupounidade.Text = report.lfgrupounidade.Text + " - Meio Lote: " + meiolote + "o.";
        }

        // PERIODO
        DateTime dtprevisao1 = Convert.ToDateTime(Session["dtprevisao1"]);
        DateTime dtprevisao2 = Convert.ToDateTime(Session["dtprevisao2"]);
        report.lfperiodo.Text = dtprevisao1.Date.ToString().Substring(0, 10) + " até " + dtprevisao2.Date.ToString().Substring(0, 10);

        // USUÁRIO
        string usuario = Convert.ToString(Session["CodUsuario"]);
        report.ltusuario.Text = "Usuário: " + usuario;

        // RODAPÉ
        report.lcaminho.Text = "Gitano ->SGFin ->Vendas ->Relatório Saldos Financiamentos";

        DataSet ds;
        ds = uVendas.PegaDadosVendaFinanciamentos(produto, grupo, unidade, parte);
        //
        report.DataSource = ds;
        report.DataMember = ds.Tables[0].TableName;
        report.lid.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "produto")});
        //report.lgrupo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
        //    new DevExpress.XtraReports.UI.XRBinding("Text", null, "grupo")});
        report.lunidade.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "unidade")});
        report.lparte.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "parte")});
        report.lproprietario.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "proprietario")});
        report.ldatavenda.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "data_venda", "{0:dd/MM/yyyy}")});
        report.lvlrvenda.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "vlr_venda", "{0:N}")});
        report.lsaldocredor.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "saldocredor", "{0:N}")});
        report.lsaldodevedor.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "saldodevedor", "{0:N}")});
        //report.lsaldocredorativo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
        //    new DevExpress.XtraReports.UI.XRBinding("Text", null, "saldocredorativo", "{0:N}")});
        //report.lsaldodevedorativo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
        //    new DevExpress.XtraReports.UI.XRBinding("Text", null, "saldodevedorativo", "{0:N}")});
        //report.lquitado.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
        //    new DevExpress.XtraReports.UI.XRBinding("Text", null, "quitado")});
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
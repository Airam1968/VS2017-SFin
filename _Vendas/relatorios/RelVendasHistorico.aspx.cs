using System;
using System.Data;
using System.Web.UI;

public partial class RelVendasHistorico : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Server.Transfer("~\\LoginTimeOut.aspx");
        }

        ScriptManager.RegisterStartupScript(this, typeof(string), "MAXIMIZE", "top.window.moveTo(0,0); top.window.resizeTo(screen.availWidth,screen.availHeight);", true);

        RepVendasHistorico report = new RepVendasHistorico();
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
            report.lfgrupounidade.Text = "Todos";
        }
        else
        {
            if (produto.Substring(0, 1) == "'")
            {
                report.lfgrupounidade.Text = "Alguns";
            }
            else
            {
                report.lfgrupounidade.Text = unidade;
            }
        }
        // PARTE
        string parte = Convert.ToString(Session["parte"]);
        // PERIODO
        DateTime dtprevisao1 = Convert.ToDateTime(Session["dtprevisao1"]);
        DateTime dtprevisao2 = Convert.ToDateTime(Session["dtprevisao2"]);
        report.lfperiodo.Text = dtprevisao1.Date.ToString().Substring(0, 10) + " até " + dtprevisao2.Date.ToString().Substring(0, 10);

        // USUÁRIO
        string usuario = Convert.ToString(Session["CodUsuario"]);
        report.ltusuario.Text = "Usuário: " + usuario;

        // RODAPÉ
        report.lcaminho.Text = "Gitano ->SGFin ->Vendas ->Relatório Vendas Histórico";
        //String de Busca
        string busca = "";
        if (produto.Trim() != "")
        {
            busca = produto.Trim();
        }
        if (grupo.Trim() != "")
        {
            busca = busca + "/" + grupo.Trim();
        }
        if (unidade.Trim() != "")
        {
            busca = busca + "/" + unidade.Trim();
        }
        //
        DataSet ds;
        try
        {
            ds = uLog.PegaDadosLog("", dtprevisao1.ToString().Substring(0, 10), dtprevisao2.ToString().Substring(0, 10), "", "", busca);
        }
        catch (Exception)
        {
            ds = uLog.PegaDadosLog("", dtprevisao1.ToString().Substring(0, 10), dtprevisao2.ToString().Substring(0, 10), "", "", busca);
        }


        report.DataSource = ds;
        report.DataMember = ds.Tables[0].TableName;
        report.lusuario.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Login")});
        report.ldatahora.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "DataHora")});
        report.ltabela.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Tabela")});
        report.loperacao.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Operacao")});
        report.loperacao2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Obs")});
        report.lacao.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acao")});


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
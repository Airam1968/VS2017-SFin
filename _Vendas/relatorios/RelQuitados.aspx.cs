using System;
using System.Data;
using System.Web.UI;

public partial class RelQuitados : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Server.Transfer("~\\LoginTimeOut.aspx");
        }

        ScriptManager.RegisterStartupScript(this, typeof(string), "MAXIMIZE", "top.window.moveTo(0,0); top.window.resizeTo(screen.availWidth,screen.availHeight);", true);

        RepQuitados report = new RepQuitados();
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
        //
        //rbquitados
        string rbquitados = Convert.ToString(Session["rbquitados"]);
        if (rbquitados == "0")
        {
            // TÍTULO
            report.ltitulorelatorio.Text = "RELATÓRIO VENDAS QUITADOS";
            // RODAPÉ
            report.lcaminho.Text = "Gitano ->SGFin ->Vendas ->Relatório Vendas Quitadas";
        }
        else
        {
            // TÍTULO
            report.ltitulorelatorio.Text = "RELATÓRIO VENDAS NÃO QUITADAS";
            // RODAPÉ
            report.lcaminho.Text = "Gitano ->SGFin ->Vendas ->Relatório Vendas Não Quitadas";
        }
        //
        //rbquitados
        string rbvendidos = Convert.ToString(Session["rbvendidos"]);
        //
        // USUÁRIO
        string usuario = Convert.ToString(Session["CodUsuario"]);
        report.ltusuario.Text = "Usuário: " + usuario;
        //
        DataSet ds;
        if (grupo == "")
        {
            if (rbquitados == "0")
            {
                if (rbvendidos == "0")
                {
                    ds = uProduto.PegaDadosProdutoUnidades(produto, "", "0", "1", "0");
                }
                else
                {
                    ds = uProduto.PegaDadosProdutoUnidades(produto, "", "1", "1", "0");
                }
            }
            else
            {
                if (rbvendidos == "0")
                {
                    ds = uProduto.PegaDadosProdutoUnidades(produto, "", "0", "2", "0");
                }
                else
                {
                    ds = uProduto.PegaDadosProdutoUnidades(produto, "", "1", "2", "0");
                }
            }
        }
        else
        {
            if (rbquitados == "0")
            {
                if (rbvendidos == "0")
                {
                    ds = uProduto.PegaDadosProdutoUnidades(produto, grupo, "0", "1", "0");
                }
                else
                {
                    ds = uProduto.PegaDadosProdutoUnidades(produto, grupo, "1", "1", "0");
                }
            }
            else
            {
                if (rbvendidos == "0")
                {
                    ds = uProduto.PegaDadosProdutoUnidades(produto, grupo, "0", "2", "0");
                }
                else
                {
                    ds = uProduto.PegaDadosProdutoUnidades(produto, grupo, "1", "2", "0");
                }
            }
        }
        //
        report.DataSource = ds;
        report.DataMember = ds.Tables[0].TableName;
        //
        report.lid.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "produto")});
        //report.lgrupo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
        //    new DevExpress.XtraReports.UI.XRBinding("Text", null, "grupo")});
        report.lunidade.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "unidade")});
        report.lparte.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "parte")});
        report.linscricao.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "inscricao_1")});
        //report.ldatavenda.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
        //    new DevExpress.XtraReports.UI.XRBinding("Text", null, "data_venda", "{0:dd/MM/yyyy}")});
        report.lproprietario.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "nome_proprietario_1")});
        //report.lcnpj.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
        //    new DevExpress.XtraReports.UI.XRBinding("Text", null, "cnpj_proprietario_1")});
        report.lrg.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "rg_proprietario_1")});
        report.lsituacao.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "situacao")});

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
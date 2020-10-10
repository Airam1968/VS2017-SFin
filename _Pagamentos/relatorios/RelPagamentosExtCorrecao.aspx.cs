using System;
using System.Data;
using System.Web.UI;

public partial class RelPagamentosExtCorrecao : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Server.Transfer("~\\LoginTimeOut.aspx");
        }

        ScriptManager.RegisterStartupScript(this, typeof(string), "MAXIMIZE", "top.window.moveTo(0,0); top.window.resizeTo(screen.availWidth,screen.availHeight);", true);

        RepPagamentosExtCorrecao report = new RepPagamentosExtCorrecao();
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
            if (grupo.Substring(0, 1) == "'")
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
            report.lfgrupounidade.Text = "Todas";
        }
        else
        {
            if (unidade.Substring(0, 1) == "'")
            {
                report.lfgrupounidade.Text = "Algumas";
            }
            else
            {
                report.lfgrupounidade.Text = unidade;
            }
        }
        // PARTE
        string parte = Convert.ToString(Session["cbparte"]);
        if (parte != "0")
        {
            report.lfgrupounidade.Text = report.lfgrupounidade.Text + " - Parte: " + parte;
        }
        // MEIOLOTE
        string meiolote = Convert.ToString(Session["cbmeiolote"]);
        if (parte != "0")
        {
            report.lfgrupounidade.Text = report.lfgrupounidade.Text + " - Meio Lote: " + meiolote + "o.";
        }
        // PERIODICIDADE
        string periodicidade = uVendas.PegaPeriodicidade(produto, grupo, unidade, parte, meiolote);
        report.lfperiodicidade.Text = periodicidade;
        // PROPRIETARIO
        string cliente = Convert.ToString(Session["cbcliente"]);
        if (cliente == "")
        {
            report.lfproprietario.Text = "Todas";
        }
        else
        {
            if (cliente.Substring(0, 1) == "'")
            {
                report.lfproprietario.Text = "Alguns";
            }
            else
            {
                report.lfproprietario.Text = uContato.PegaNomeID(cliente) + "-" + Srelib.FormataCPFCNPJ(uContato.PegaCpfCnpjID(cliente));
            }
        }
        // PERIODO FILTRO
        DateTime dtprevisao1 = Convert.ToDateTime(Session["dtprevisao1"]);
        DateTime dtprevisao2 = Convert.ToDateTime(Session["dtprevisao2"]);
        report.lfperiodo.Text = dtprevisao1.Date.ToString().Substring(0, 10) + " até " + dtprevisao2.Date.ToString().Substring(0, 10);
        if (unidade != string.Empty)
        {
            DateTime dtprevisaovenda1 = uVendas.PegaDataVenda(produto, grupo, unidade, parte);
            DateTime dtprevisaovenda2 = uParcelas.PegaUltimoVencimento(produto, grupo, unidade, parte, meiolote);
            // VENDA
            report.lfdatavenda.Text = dtprevisaovenda1.Date.ToString().Substring(0, 10);
            // PERIODO VENDA
            report.lfperiodovenda.Text = dtprevisaovenda1.Date.ToString().Substring(0, 10) + " até " + dtprevisaovenda2.Date.ToString().Substring(0, 10);
            //
            report.lfcorrecao.Text = "";
            report.lfcorrecao.Text = report.lfcorrecao.Text + uVendas.PegaPeriodicidade(produto, grupo, unidade, parte, meiolote);
            report.lfcorrecao.Text = report.lfcorrecao.Text + " - " + uVendas.PegaIndexador(produto, grupo, unidade, parte);
            report.lfcorrecao.Text = report.lfcorrecao.Text + " - BASE: ";
            report.lfcorrecao.Text = report.lfcorrecao.Text + uVendas.PegaDataBase(produto, grupo, unidade, parte).ToString().Substring(0, 10);
        }
        else
        {
            report.xrLabel25.Visible = false;
            report.lfdatavenda.Visible = false;
            //
            report.xrLabel28.Visible = false;
            report.lfperiodovenda.Visible = false;
            //
            report.xrLabel30.Visible = false;
            report.lfcorrecao.Visible = false;
        }
        // USUÁRIO
        string usuario = Convert.ToString(Session["CodUsuario"]);
        report.ltusuario.Text = "Usuário: " + usuario;

        // RODAPÉ
        report.lcaminho.Text = "Gitano ->SGFin ->Pagamentos ->Relatório Extrato de Correção Monetária";
        // LEGENDA
        if (uVendas.TemRenegociacao(produto, grupo, unidade, parte))
        {
            report.llegenda.Text = "Legenda:" + " | Financiamento possui renegociação.";
        }
        else
        {
            report.llegenda.Text = "Legenda:" + " | Financiamento não possui renegociação.";
        }
        //
        DataSet ds;

        ds = uParcelas.PegaDadosParcelas2(produto,
                                         grupo,
                                         unidade,
                                         parte,
                                         meiolote,
                                         dtprevisao1.ToString().Substring(0,10),
                                         dtprevisao2.ToString().Substring(0, 10),
                                         "T",
                                         "0",
                                         "N",
                                         false,
                                         "0");
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
        report.lparcela.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "parcela")});
        report.ltipo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tipo")});
        report.lconta.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "conta")});
        report.ldatavencimento.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "data_vencimento", "{0:dd/MM/yyyy}")});
        report.lvlroriginal.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "vlr_original", "{0:N}")});
        report.ltaxames.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "indexador_mes")});
        report.ltaxaacum.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "indexador_acumulado")});
        report.lindexador.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "indexador")});
        report.lvlrparcela.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "vlr_parcela", "{0:N}")});
        report.lvlrresiduomes.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "residuo_mes")});
        report.lvlrresiduoacum.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "residuo_acumulado")});
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
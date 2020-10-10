using System;
using System.Data;
using System.Web.UI;

public partial class RelFCaixaDiario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Server.Transfer("~\\LoginTimeOut.aspx");
        }

        ScriptManager.RegisterStartupScript(this, typeof(string), "MAXIMIZE", "top.window.moveTo(0,0); top.window.resizeTo(screen.availWidth,screen.availHeight);", true);

        RepFCaixaDiario report = new RepFCaixaDiario();
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
        // CONTA CORRENTE
        string contacorrente = Convert.ToString(Session["cbcontacorrente"]);
        if (contacorrente == "")
        {
            report.lfcontacorrente.Text = "Todas";
            contacorrente = "0";
        }
        else
        {
            if ((contacorrente.Substring(0, 1) == "'") || (contacorrente.Contains(",")))
            {
                report.lfcontacorrente.Text = "Algumas: " +"(" + contacorrente + ")"; 
            }
            else
            {
                report.lfcontacorrente.Text = uContas.PegaContaDescricao(contacorrente);
            }
        }
        // PERIODO PREVISÃO
        DateTime dtprevisao1 = Convert.ToDateTime(Session["dtprevisao1"]);
        DateTime dtprevisao2 = Convert.ToDateTime(Session["dtprevisao2"]);
        report.lfperiodoprevisao.Text = dtprevisao1.Date.ToString().Substring(0, 10) + " até " + dtprevisao2.Date.ToString().Substring(0, 10);
        //
        string rblancamentossituacao = Convert.ToString(Session["rblancamentossituacao"]);
        if (rblancamentossituacao == "0")
        {
            rblancamentossituacao = "P";
            report.lflancamentos.Text = "Previstos";
            report.rblancamentossituacao = "P";
        }
        else
        {
            rblancamentossituacao = "R";
            report.lflancamentos.Text = "Realizados";
            report.rblancamentossituacao = "R";
        }
        //
        // INCLUIR APLICAÇÕES
        Boolean aplicacoes = Convert.ToBoolean(Session["ckaplicacao"]);
        //
        // USUÁRIO
        string usuario = Convert.ToString(Session["CodUsuario"]);
        report.ltusuario.Text = "Usuário: " + usuario;
        // RODAPÉ
        report.lcaminho.Text = "Gitano ->SGFin ->Fluxo de Caixa ->Relatório Fluxo de Caixa - Diário";
        // LEGENDA
        //report.llegenda.Text = "Coluna Origem dos Pagamentos [B = Pagamento Carteira][C = Cobrança Bancária]";
        //
        DataSet ds;

        ds = uFluxoCaixa.PegaDadosFCaixa(produto,
                                         contacorrente,
                                         dtprevisao1,
                                         dtprevisao2,
                                         rblancamentossituacao,
                                         false,
                                         false,
                                         aplicacoes);
        //
        report.DataSource = ds;
        report.DataMember = ds.Tables[0].TableName;
        report.llancamento.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "lancamento")});
        report.lproduto.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "produto")});
        report.ltipo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "tipo")});
        report.lconta.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "conta")});
        //report.lfornecedor.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
        //    new DevExpress.XtraReports.UI.XRBinding("Text", null, "fornecedor")});
        //report.lclassedespesa.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
        //    new DevExpress.XtraReports.UI.XRBinding("Text", null, "classe")});
        report.lnf.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "documento")});
        report.ldatadocumento.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "data_documento", "{0:dd/MM/yyyy}")});
        report.ldescricao.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "descricao")});
        report.ldatavencimento.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "data_prevista", "{0:dd/MM/yyyy}")});
        report.lvlrprevisto.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "vlr_previsto", "{0:N}")});
        report.ldatapagamento.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "data_realizado", "{0:dd/MM/yyyy}")});
        report.lvlrpagamento.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "vlr_realizado", "{0:N}")});
        //
        report.eimprimedata = false;
        if (rblancamentossituacao == "0")
        {
            // Carrega quebra por DATA PREVISTO
            report.headerdata.GroupFields.Clear();                    // DESABILITA O CAMPO DE QUEBRA DO GROUPHEADER  =====================================================================================
            report.headerdata.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {                                       // CRIA CAMPO DE QUEBRA ==========================================================================================
            new DevExpress.XtraReports.UI.GroupField("data_prevista" , DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),});// NO GROUPHEADER       ==========================================================================================
            report.eimprimedata = true;
        }
        else
        {
            // Carrega quebra por DATA REALIZADO
            report.headerdata.GroupFields.Clear();                    // DESABILITA O CAMPO DE QUEBRA DO GROUPHEADER  =====================================================================================
            report.headerdata.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {                                       // CRIA CAMPO DE QUEBRA ==========================================================================================
            new DevExpress.XtraReports.UI.GroupField("data_realizado" , DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),});// NO GROUPHEADER       ==========================================================================================
            report.eimprimedata = true;
        }
        //
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
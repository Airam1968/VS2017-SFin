using System;
using System.Data;
using System.Web.UI;

public partial class RelPagamentosCobrancaNBancaria : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Server.Transfer("~\\LoginTimeOut.aspx");
        }

        ScriptManager.RegisterStartupScript(this, typeof(string), "MAXIMIZE", "top.window.moveTo(0,0); top.window.resizeTo(screen.availWidth,screen.availHeight);", true);

        RepPagamentosCobrancaNBancaria report = new RepPagamentosCobrancaNBancaria();
        // Use SqlDataAdapter to define and populate a DataSet using the information extracted from a Session vairable

        // EMPRESA MATRIZ
        report.ltempresa.Text = uEmpresa.PegaNome(uEmpresa.PegaMatriz());

        // DATASET
        DataSet dsparcelas = (DataSet)Session["dsparcelas"];
        //

        // PRODUTO
        string produto = dsparcelas.Tables[0].Rows[0]["venda_ID"].ToString().Trim();
        string resta = produto.Substring(produto.IndexOf("/"), produto.Length - produto.IndexOf("/"));
        produto = produto.Substring(0, produto.IndexOf("/"));
        report.lfproduto.Text = uProduto.PegaProdutoDescricao(Convert.ToInt32(produto));

        // GRUPO
        report.lfgrupo.Text = "Alguns";

        // UNIDADE
        report.lfgrupounidade.Text = "Algumas";

        // PARTE
        report.lfgrupounidade.Text = "Alguns";

        // CONTA CORRENTE
        string contacorrente = "22";
        report.lfcontacorrente.Text = uContas.PegaContaDescricao(contacorrente);

        // PERIODO
        DateTime dtprevisao1 = Convert.ToDateTime(dsparcelas.Tables[0].Rows[0]["data_pagamento"]);
        DateTime dtprevisao2 = Convert.ToDateTime(dsparcelas.Tables[0].Rows[0]["data_pagamento"]);
        report.lfperiodo.Text = dtprevisao1.Date.ToString().Substring(0, 10) + " até " + dtprevisao2.Date.ToString().Substring(0, 10);

        // DIFERENÇA
        report.lfdiferenca.Text = uParametros.PegaParametro("DIFERENÇA BAIXA");

        // USUÁRIO
        string usuario = Convert.ToString(Session["CodUsuario"]);
        report.ltusuario.Text = "Usuário: " + usuario;

        // RODAPÉ
        report.lcaminho.Text = "Gitano ->SGFin ->Pagamentos ->Relatório Cobrança Não Bancária";
        //
        report.DataSource = dsparcelas;
        report.DataMember = dsparcelas.Tables[0].TableName;
        report.lid_venda.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "venda_ID")});
        report.lidentificador.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "identificador")});
        report.lplano.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "plano")});
        report.lconta_cedente.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "conta_cedente")});
        report.lapelido_cedente.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "apelido_cedente")});
        report.ldatavencimento.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "data_vencimento", "{0:dd/MM/yyyy}")});
        report.lvlrparcela.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "vlr_pgto_base", "{0:N}")});
        report.lvlrjuros.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "vlr_pgto_juros", "{0:N}")});
        report.lvlrpagamento.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "vlr_pgto_total", "{0:N}")});
        report.lvenda_localizada.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "venda_localizada")});
        report.lparcela_sistema.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "parcela_sistema", "{0:N}")});
        report.lparcela_corrigida.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "parcela_corrigida", "{0:N}")});
        report.lparcela_diferenca.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "diferenca", "{0:N}")});
        report.lparcela_ID.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "parcela_ID")});
        //
        // Carrega quebra por DATA DE PAGAMENTOS
        report.headerdata.GroupFields.Clear();                    // DESABILITA O CAMPO DE QUEBRA DO GROUPHEADER  =====================================================================================
        report.headerdata.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {                                       // CRIA CAMPO DE QUEBRA ==========================================================================================
            new DevExpress.XtraReports.UI.GroupField("data_pagamento" , DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),});// NO GROUPHEADER       ==========================================================================================
        //
        if (dsparcelas.Tables[0].Rows.Count > 0)
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
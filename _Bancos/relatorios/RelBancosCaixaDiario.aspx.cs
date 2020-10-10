using System;
using System.Data;
using System.Web.UI;

public partial class RelBancosCaixaDiario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Server.Transfer("~\\LoginTimeOut.aspx");
        }

        ScriptManager.RegisterStartupScript(this, typeof(string), "MAXIMIZE", "top.window.moveTo(0,0); top.window.resizeTo(screen.availWidth,screen.availHeight);", true);

        RepBancosCaixaDiario report = new RepBancosCaixaDiario();
        // Use SqlDataAdapter to define and populate a DataSet using the information extracted from a Session vairable

        // EMPRESA MATRIZ
        report.ltempresa.Text = uEmpresa.PegaNome(uEmpresa.PegaMatriz());
        // CONTA CORRENTE
        string contacorrente = Convert.ToString(Session["cbcontacorrente"]);
        if (contacorrente == "")
        {
            report.lfcontacorrente.Text = "Todas";
            contacorrente = "0";
        }
        else
        {
            if (contacorrente.Substring(0, 1) == "'")
            {
                report.lfcontacorrente.Text = "Alguns";
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
        // LIMITE DE CRÉDITO
        //report.lflimitecredito.Text = uContas.PegaLimite(contacorrente);
        //
        // CHEQUES A COMPENSAR
        report.cheques = Convert.ToDouble(uContasPagar.PegaChequesCompensados(contacorrente, dtprevisao1.Date.ToString().Substring(0, 10), dtprevisao2.Date.ToString().Substring(0, 10), false));
        //
        // DEPOSITOS A COMPENSAR
        report.depositos = Convert.ToDouble(uContasReceber.PegaDepositosCompensados(contacorrente, dtprevisao1.Date.ToString().Substring(0, 10), dtprevisao2.Date.ToString().Substring(0, 10), false));
        //
        // USUÁRIO
        string usuario = Convert.ToString(Session["CodUsuario"]);
        report.ltusuario.Text = "Usuário: " + usuario;
        // RODAPÉ
        report.lcaminho.Text = "Gitano ->SGFin ->Bancos ->Relatório Caixa Diário";
        // LEGENDA
        //report.llegenda.Text = "Coluna Origem dos Pagamentos [B = Pagamento Carteira][C = Cobrança Bancária]";
        //
        DataSet ds;

        ds = uContas.PegaDadosConta(contacorrente,
                                    Convert.ToString(dtprevisao1).Substring(0, 10),
                                    Convert.ToString(dtprevisao2).Substring(0, 10));
        //
        report.DataSource = ds;
        report.DataMember = ds.Tables[0].TableName;
        report.llancamento.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "lancamento")});
        report.lproduto.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "produto")});
        report.ldescricao.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "descricao")});
        report.lcomplemento.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "complemento")});
        report.ldata.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "data", "{0:dd/MM/yyyy}")});
        report.lvlrentradas.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "credito")});
        report.lvlrsaidas.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "debito")});
        report.lvlrfinal.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "saldo_f")});
        report.lordemcompra.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "pedido_compra")});
        report.lcheque.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "cheque")});
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
using System;
using System.Data;
using System.Web.UI;

public partial class RelBancosResumoContas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Server.Transfer("~\\LoginTimeOut.aspx");
        }

        ScriptManager.RegisterStartupScript(this, typeof(string), "MAXIMIZE", "top.window.moveTo(0,0); top.window.resizeTo(screen.availWidth,screen.availHeight);", true);

        RepBancosResumoContas report = new RepBancosResumoContas();
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
        //report.lfperiodoprevisao.Text = dtprevisao1.Date.ToString().Substring(0, 10) + " até " + dtprevisao2.Date.ToString().Substring(0, 10);
        report.lfperiodoprevisao.Text = "Último Saldo das Contas";
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
        report.lcaminho.Text = "Gitano ->SGFin ->Bancos ->Relatório Resumo de Contas";
        //
        DataSet ds;
        //
        ds = uContas.PegaUltimoSaldoContas();
        //
        report.DataSource = ds;
        report.DataMember = ds.Tables[0].TableName;
        report.lconta.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "cod_conta")});
        report.ldata.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "data", "{0:dd/MM/yyyy}")});
        report.lvlrinicial.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "saldo_i", "{0:N}")});
        report.lvlrentradas.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "credito", "{0:N}")});
        report.lvlrsaidas.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "debito", "{0:N}")});
        report.lvlrfinal.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "saldo_f", "{0:N}")});
        report.lvlraplicacaobloq.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "saldo_aplicacaoB", "{0:N}")});
        report.lvlraplicacaodesbloq.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "saldo_aplicacaoD", "{0:N}")});
        report.lvlrsaldomaisaplicacao.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "saldo_finalaplicacao", "{0:N}")});
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
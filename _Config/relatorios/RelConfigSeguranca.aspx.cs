using System;
using System.Data;
using System.Web.UI;

public partial class RelConfigSeguranca : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Server.Transfer("~\\LoginTimeOut.aspx");
        }

        ScriptManager.RegisterStartupScript(this, typeof(string), "MAXIMIZE", "top.window.moveTo(0,0); top.window.resizeTo(screen.availWidth,screen.availHeight);", true);

        RepConfigSeguranca report = new RepConfigSeguranca();
        // Use SqlDataAdapter to define and populate a DataSet using the information extracted from a Session vairable

        // EMPRESA MATRIZ
        report.ltempresa.Text = uEmpresa.PegaNome(uEmpresa.PegaMatriz());

        // USUARIOS SELECIONADOS
        string usuarios = Convert.ToString(Session["cbusuarios"]);
        if (usuarios == "")
        {
            report.lfusuarios.Text = "Todos";
            usuarios = "";
        }
        else
        {
            if (usuarios.Substring(0, 1) == "'")
            {
                report.lfusuarios.Text = "Alguns";
            }
            else
            {
                report.lfusuarios.Text = usuarios;
            }
        }
        // USUÁRIO
        string usuario = Convert.ToString(Session["CodUsuario"]);
        report.ltusuario.Text = "Usuário: " + usuario;
        // PERÍODO
        string periodo = Convert.ToString(Session["dtinicio"]) + " até " + Convert.ToString(Session["dtfim"]);
        report.lfperiodo.Text = periodo;
        // MÓDULO
        string modulo = Convert.ToString(Session["Modulo"]);
        if (modulo != string.Empty)
            report.lfmodulo.Text = modulo;
        else
            report.lfmodulo.Text = "Todos";
        // AÇÃO
        string acao = Convert.ToString(Session["Acao"]);
        if (acao != string.Empty)
            report.lfacao.Text = acao;
        else
            report.lfacao.Text = "Todas";
        // COMPLEMENTO
        string complemento = Convert.ToString(Session["Complemento"]);
        if (complemento != string.Empty)
            report.lfcomplemento.Text = complemento;
        else
            report.lfcomplemento.Text = "Todas";
        //
        DataSet ds;
        //
        string RelatorioTipo = Convert.ToString(Session["RelatorioTipo"]);
        if (RelatorioTipo == "1")
        {
            report.ltitulorelatorio.Text = "RELATÓRIO SEGURANÇA ACESSO";
            // RODAPÉ
            report.lcaminho.Text = "Gitano ->SGFin ->Config ->Relatório Segurança Ações";
            ds = uLog.PegaDadosLog(usuarios,
                                   Convert.ToString(Session["dtinicio"]).Substring(0, 10),
                                   Convert.ToString(Session["dtfim"]).Substring(0, 10),
                                   modulo,
                                   acao,
                                   complemento);
        }
        else
        {
            report.ltitulorelatorio.Text = "RELATÓRIO SEGURANÇA AÇÕES";
            // RODAPÉ
            report.lcaminho.Text = "Gitano ->SGFin ->Config ->Relatório Segurança Ações";
            ds = uLog.PegaDadosLog(usuarios,
                                   Convert.ToString(Session["dtinicio"]).Substring(0, 10),
                                   Convert.ToString(Session["dtfim"]).Substring(0, 10),
                                   modulo,
                                   acao,
                                   complemento);       
        }




        report.DataSource = ds;
        report.DataMember = ds.Tables[0].TableName;
        report.llogin.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Login")});
        report.ldatahora.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "DataHora")});
        report.ltabela.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Tabela")});
        report.lacao.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Obs")});
        report.loperacao.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Operacao")});
        report.lcomplemento.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acao")});


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
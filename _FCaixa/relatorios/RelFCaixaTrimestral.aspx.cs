using System;
using System.Data;
using System.Web.UI;

public partial class RelFCaixaTrimestral : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Server.Transfer("~\\LoginTimeOut.aspx");
        }
        //
        ScriptManager.RegisterStartupScript(this, typeof(string), "MAXIMIZE", "top.window.moveTo(0,0); top.window.resizeTo(screen.availWidth,screen.availHeight);", true);

        RepFCaixaTrimestral report = new RepFCaixaTrimestral();
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
                report.lfcontacorrente.Text = "Algumas: " + "(" + contacorrente + ")";
            }
            else
            {
                report.lfcontacorrente.Text = uContas.PegaContaDescricao(contacorrente);
            }
        }
        //rblancamentossituacao
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
        // ANO
        string cbano = Convert.ToString(Session["cbano"]);
        if (cbano != "")
        {
            report.lfano.Text = cbano;
        }
        //
        // rbtrimestre
        string rbtrimestre = Convert.ToString(Session["rbtrimestre"]);
        if (rbtrimestre == "1")
        {
            report.lftrimestre.Text = "1o. Trimestre - 01/01 á 31/03";
            report.xrLabel5.Text = "Janeiro/" + cbano;
            report.xrLabel7.Text = "Fevereiro/" + cbano;
            report.xrLabel6.Text = "Março/" + cbano;
        }
        if (rbtrimestre == "2")
        {
            report.lftrimestre.Text = "2o. Trimestre - 01/04 á 30/06";
            report.xrLabel5.Text = "Abril/" + cbano;
            report.xrLabel7.Text = "Maio/" + cbano;
            report.xrLabel6.Text = "Junho/" + cbano;
        }
        if (rbtrimestre == "3")
        {
            report.lftrimestre.Text = "3o. Trimestre - 01/07 á 30/09";
            report.xrLabel5.Text = "Julho/" + cbano;
            report.xrLabel7.Text = "Agosto/" + cbano;
            report.xrLabel6.Text = "Setembro/" + cbano;
        }
        if (rbtrimestre == "4")
        {
            report.lftrimestre.Text = "4o. Trimestre - 01/10 á 31/12";
            report.xrLabel5.Text = "Outubro/" + cbano;
            report.xrLabel7.Text = "Novembro/" + cbano;
            report.xrLabel6.Text = "Dezembro/" + cbano;
        }
        //
        //SALDO INICIAL
        string edsaldoinicial = Convert.ToString(Session["edsaldoinicial"]);
        if (edsaldoinicial != "")
        {
            report.saldoinicial = Convert.ToDouble(edsaldoinicial);
        }
        //
        // INCLUIR APLICAÇÕES
        Boolean aplicacoes = Convert.ToBoolean(Session["ckaplicacao"]);
        //
        //
        // USUÁRIO
        string usuario = Convert.ToString(Session["CodUsuario"]);
        report.ltusuario.Text = "Usuário: " + usuario;
        // RODAPÉ
        report.lcaminho.Text = "Gitano ->SGFin ->Fluxo de Caixa ->Relatório Fluxo de Caixa - Trimestre";
        //
        DataSet ds;

        ds = uFluxoCaixa.PegaDadosFCaixaTrimestral(produto,
                                                   contacorrente,
                                                   rbtrimestre,
                                                   cbano,
                                                   rblancamentossituacao,
                                                   false,
                                                   false,
                                                   aplicacoes);
        //
        report.DataSource = ds;
        report.DataMember = ds.Tables[0].TableName;
        report.lclasse.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "classe")});
        report.ldescricao.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "descricao")});
        //report.lmes1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
        //    new DevExpress.XtraReports.UI.XRBinding("Text", null, "mes1", "{0:N}")});
        //report.lmes2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
        //    new DevExpress.XtraReports.UI.XRBinding("Text", null, "mes2", "{0:N}")});
        //report.lmes3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
        //    new DevExpress.XtraReports.UI.XRBinding("Text", null, "mes3", "{0:N}")});
        //report.ltotais.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
        //    new DevExpress.XtraReports.UI.XRBinding("Text", null, "totaltrimestre", "{0:N}")});

        report.eimprimetipo = false;
        // Carrega quebra por DATA PREVISTO
        report.headertipo.GroupFields.Clear();                    // DESABILITA O CAMPO DE QUEBRA DO GROUPHEADER  =====================================================================================
        report.headertipo.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {                                       // CRIA CAMPO DE QUEBRA ==========================================================================================
            new DevExpress.XtraReports.UI.GroupField("tipo" , DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),});// NO GROUPHEADER       ==========================================================================================
        report.eimprimetipo = true;


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
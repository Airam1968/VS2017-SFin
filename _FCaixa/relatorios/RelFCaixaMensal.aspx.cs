using System;
using System.Data;
using System.Web.UI;

public partial class RelFCaixaMensal : System.Web.UI.Page
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

        RepFCaixaMensal report = new RepFCaixaMensal();
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
        //
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
        // MES
        string cbmes = Convert.ToString(Session["cbmes"]);
        if (cbmes != "")
        {
            report.lfmes.Text = cbmes;
            report.xrLabel5.Text = cbmes.Substring(5, (cbmes.Length - 5)) + "/" + cbano;
            cbmes = cbmes.Substring(0, 2);
        }
        else
        {
            report.lfano.Text = "mês indefinido";
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
        report.lcaminho.Text = "Gitano ->SGFin ->Fluxo de Caixa ->Relatório Fluxo de Caixa - Mensal";
        //
        DataSet ds;

        ds = uFluxoCaixa.PegaDadosFCaixaMensal(produto,
                                               contacorrente,
                                               cbmes,
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
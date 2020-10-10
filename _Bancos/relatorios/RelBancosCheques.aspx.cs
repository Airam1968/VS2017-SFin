using System;
using System.Data;
using System.Web.UI;

public partial class RelBancosCheques : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Server.Transfer("~\\LoginTimeOut.aspx");
        }

        ScriptManager.RegisterStartupScript(this, typeof(string), "MAXIMIZE", "top.window.moveTo(0,0); top.window.resizeTo(screen.availWidth,screen.availHeight);", true);

        RepBancosCheques report = new RepBancosCheques();
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
        // DESPESA
        string cbdespesa = Convert.ToString(Session["cbdespesa"]);
        if (cbdespesa == "")
        {
            report.lfclassedespesa.Text = "Todos";
        }
        else
        {
            if (cbdespesa.Substring(0, 1) == "'")
            {
                report.lfclassedespesa.Text = "Alguns";
            }
            else
            {
                report.lfclassedespesa.Text = uDespesas.PegaDespesaDescricao(Convert.ToInt32(cbdespesa));
            }
        }
        // FORNECEDOR
        string cbfornecedor = Convert.ToString(Session["cbfornecedor"]);
        if (cbfornecedor == "")
        {
            report.lffornecedor.Text = "Todos";
        }
        else
        {
            if (cbfornecedor.Substring(0, 1) == "'")
            {
                report.lffornecedor.Text = "Alguns";
            }
            else
            {
                report.lffornecedor.Text = uFornecedores.PegaNomeFornecedor(Convert.ToInt32(cbfornecedor));
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
            if (contacorrente.Substring(0, 1) == "'")
            {
                report.lfcontacorrente.Text = "Alguns";
            }
            else
            {
                report.lfcontacorrente.Text = uContas.PegaContaDescricao(contacorrente);
            }
        }
        // DOCUMENTO
        string eddocumento = Convert.ToString(Session["eddocumento"]);
        // PERIODO PREVISÃO
        DateTime dtprevisao1 = Convert.ToDateTime(Session["dtprevisao1"]);
        DateTime dtprevisao2 = Convert.ToDateTime(Session["dtprevisao2"]);
        report.lfperiodoprevisao.Text = dtprevisao1.Date.ToString().Substring(0, 10) + " até " + dtprevisao2.Date.ToString().Substring(0, 10);
        //
        // PERIODO REALIZADO
        DateTime dtrealizado1 = Convert.ToDateTime(Session["dtrealizado1"]);
        DateTime dtrealizado2 = Convert.ToDateTime(Session["dtrealizado2"]);
        report.lfperiodorealizado.Text = dtrealizado1.Date.ToString().Substring(0, 10) + " até " + dtrealizado2.Date.ToString().Substring(0, 10);
        //
        // PERIODO NOTA FISCAL
        DateTime dtnotafiscal1 = Convert.ToDateTime(Session["dtnotafiscal1"]);
        DateTime dtnotafiscal2 = Convert.ToDateTime(Session["dtnotafiscal2"]);
        report.lfperiodonotafiscal.Text = dtnotafiscal1.Date.ToString().Substring(0, 10) + " até " + dtnotafiscal2.Date.ToString().Substring(0, 10);
        //
        string rbcompensadossituacao = Convert.ToString(Session["rbcompensadossituacao"]);
        Boolean ckcompensado = false;
        Boolean compensado = false;
        if (rbcompensadossituacao == "0")
        {
            ckcompensado = false;
            compensado = false;
            report.lfcompensacao.Text = "Todos";
        }
        else
        {
            if (rbcompensadossituacao == "1")
            {
                ckcompensado = true;
                compensado = false;
                report.lfcompensacao.Text = "Não Compensados";
            }
            else
            {
                ckcompensado = true;
                compensado = true;
                report.lfcompensacao.Text = "Compensados";
            }
        }
        //
        string rbordenacao = Convert.ToString(Session["rbordenacao"]);
        if (rbordenacao == "0")
        {
            report.lfordenacao.Text = "Lançamentos";
            rbordenacao = "L";
        }
        if (rbordenacao == "1")
        {
            report.lfordenacao.Text = "Classe Despesa";
            rbordenacao = "D";
        }
        if (rbordenacao == "2")
        {
            report.lfordenacao.Text = "Fornecedor";
            rbordenacao = "F";
        }
        if (rbordenacao == "3")
        {
            report.lfordenacao.Text = "Data Prevista";
            rbordenacao = "DP";
        }
        if (rbordenacao == "4")
        {
            report.lfordenacao.Text = "Data Realizada";
            rbordenacao = "DR";
        }
        if (rbordenacao == "5")
        {
            report.lfordenacao.Text = "Data Nota Fiscal";
            rbordenacao = "DN";
        }
        //
        //
        // USUÁRIO
        string usuario = Convert.ToString(Session["CodUsuario"]);
        report.ltusuario.Text = "Usuário: " + usuario;
        // RODAPÉ
        report.lcaminho.Text = "Gitano ->SGFin ->Bancos ->Relatório Cheques";
        // LEGENDA
        //report.llegenda.Text = "Coluna Origem dos Pagamentos [B = Pagamento Carteira][C = Cobrança Bancária]";
        //
        DataSet ds;

        ds = uContasPagar.PegaDadosCPagar(produto,
                                          cbdespesa,
                                          cbfornecedor,
                                          contacorrente,
                                          dtprevisao1.ToString().Substring(0, 10),
                                          dtprevisao2.ToString().Substring(0, 10),
                                          dtrealizado1.ToString().Substring(0, 10),
                                          dtrealizado2.ToString().Substring(0, 10),
                                          dtnotafiscal1.ToString().Substring(0, 10),
                                          dtnotafiscal2.ToString().Substring(0, 10),
                                          eddocumento,
                                          "R",
                                          rbordenacao,
                                          ckcompensado,
                                          compensado);
        //
        report.DataSource = ds;
        report.DataMember = ds.Tables[0].TableName;
        report.llancamento.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "lancamento")});
        report.lproduto.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "produto")});
        report.lconta.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "conta")});
        //report.lfornecedor.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
        //    new DevExpress.XtraReports.UI.XRBinding("Text", null, "fornecedor")});
        //report.lclassedespesa.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
        //    new DevExpress.XtraReports.UI.XRBinding("Text", null, "classe")});
        report.lnf.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "documento")});
        report.ldatadocumento.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "documento")});
        report.ldatavencimento.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "data_prevista", "{0:dd/MM/yyyy}")});
        report.lvlrprevisto.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "vlr_previsto", "{0:N}")});
        report.ldatapagamento.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "data_realizado", "{0:dd/MM/yyyy}")});
        report.lvlrpagamento.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "vlr_realizado", "{0:N}")});
        report.lcheque.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "cheque")});
        report.lcompensado.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "dtcompensacao", "{0:dd/MM/yyyy}")});
        report.lpedidocompra.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "pedido_compra")});
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
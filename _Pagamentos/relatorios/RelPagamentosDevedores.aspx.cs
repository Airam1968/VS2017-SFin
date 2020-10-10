using System;
using System.Data;
using System.Web.UI;

public partial class RelPagamentosDevedores : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Server.Transfer("~\\LoginTimeOut.aspx");
        }

        ScriptManager.RegisterStartupScript(this, typeof(string), "MAXIMIZE", "top.window.moveTo(0,0); top.window.resizeTo(screen.availWidth,screen.availHeight);", true);

        RepPagamentosDevedores report = new RepPagamentosDevedores();
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
                report.lfproprietario.Text = cliente + " - " + uContato.PegaNomeID(cliente);
            }
        }
        // PERIODO
        DateTime dtprevisao1 = Convert.ToDateTime(Session["dtprevisao1"]);
        DateTime dtprevisao2 = Convert.ToDateTime(Session["dtprevisao2"]);
        report.lfperiodo.Text = dtprevisao1.Date.ToString().Substring(0, 10) + " até " + dtprevisao2.Date.ToString().Substring(0, 10);
        //
        //Protesto
        string rbprotesto = Convert.ToString(Session["rbprotesto"]);
        if (rbprotesto == "0")
        {
            report.lfprotesto.Text = "Todas";
        }
        else
        {
            if (rbprotesto == "1")
            {
                report.lfprotesto.Text = "Protestados";
            }
            if (rbprotesto == "2")
            {
                report.lfprotesto.Text = "Não Protestados";
            }
        }
        //
        //Tipo Parcela
        string rbtipoparcela = Convert.ToString(Session["rbtipoparcela"]);
        if (rbtipoparcela == "0")
        {
            report.lftipoparcela.Text = "Todas";
        }
        else
        {
            if (rbtipoparcela == "1")
            {
                report.lftipoparcela.Text = "Sinal";
            }
            if (rbtipoparcela == "2")
            {
                report.lftipoparcela.Text = "Normal ou Renegociação";
            }
            if (rbtipoparcela == "3")
            {
                report.lftipoparcela.Text = "Intermediárias";
            }
        }
        //
        //Carteira\Bancária
        string rbcarteira = Convert.ToString(Session["rbcarteira"]);
        if (rbcarteira == "0")
        {
            report.lftipocobranca.Text = "Todas";
        }
        else
        {
            if (rbcarteira == "1")
            {
                report.lftipocobranca.Text = "Bancárias";
            }
            if (rbcarteira == "2")
            {
                report.lftipocobranca.Text = "Carteira";
            }
        }
        //
        //Ordem
        string rbordem = Convert.ToString(Session["rbordem"]);
        if (rbordem == "0")
        {
            report.lfordem.Text = "Data de Vencimento";
        }
        else
        {
            if (rbordem == "1")
            {
                report.lfordem.Text = "Unidade";
            }
        }
        //
        //Desistentes
        string ckdesistentes = Convert.ToString(Session["ckdesistentes"]);
        if (ckdesistentes == "False")
        {
            report.lfdesistentes.Text = "Não";
        }
        else
        {
            report.lfdesistentes.Text = "Sim";
        }
        //
        // USUÁRIO
        string usuario = Convert.ToString(Session["CodUsuario"]);
        report.ltusuario.Text = "Usuário: " + usuario;

        // RODAPÉ
        report.lcaminho.Text = "Gitano ->SGFin ->Pagamentos ->Relatório Devedores de Parcelas";
        // LEGENDA
        report.llegenda.Text = "Coluna Origem dos Pagamentos [B = Pagamento Carteira][C = Cobrança Bancária]";
        report.llegenda.Text = report.llegenda.Text +
                               " - Coluna Vlr. Parcela Corrigida [Apresenta a correção por atraso até a data de emissão do Relatório]";
        //
        DataSet ds;

        ds = uParcelas.PegaDadosParcelasDevedores(produto,
                                                   grupo,
                                                   unidade,
                                                   parte,
                                                   meiolote,
                                                   dtprevisao1.ToString().Substring(0, 10),
                                                   dtprevisao2.ToString().Substring(0, 10),
                                                   contacorrente,
                                                   rbprotesto,
                                                   rbtipoparcela,
                                                   rbordem,
                                                   ckdesistentes,
                                                   rbcarteira);
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
        report.lvlrparcela.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "vlr_parcela", "{0:N}")});
        report.ldatapagamento.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "data_pagamento", "{0:dd/MM/yyyy}")});
        report.lvlrpagamento.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "vlr_pagamento", "{0:N}")});
        //report.lprotesto.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
        //    new DevExpress.XtraReports.UI.XRBinding("Text", null, "protesto")});
        //report.lativa.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
        //    new DevExpress.XtraReports.UI.XRBinding("Text", null, "ativa")});
        report.lorigem.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "origem_pagamento")});
        report.lnossonumero.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "nossonumero")});
        //
        report.eimprimedatavencimento = false;
        report.eimprimeunidade = false;
        if (rbordem == "0")
        {
            // Carrega quebra por DATA DE PAGAMENTOS
            report.headerdata.GroupFields.Clear();                    // DESABILITA O CAMPO DE QUEBRA DO GROUPHEADER  =====================================================================================
            report.headerdata.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {                                       // CRIA CAMPO DE QUEBRA ==========================================================================================
            new DevExpress.XtraReports.UI.GroupField("data_vencimento" , DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),});// NO GROUPHEADER       ==========================================================================================
            report.eimprimedatavencimento = true;
        }
        else
        {
            if (rbordem == "1")
            {
                // Carrega quebra por UNIDADE
                report.headerunidade.GroupFields.Clear();                    // DESABILITA O CAMPO DE QUEBRA DO GROUPHEADER  =====================================================================================
                report.headerunidade.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {                                       // CRIA CAMPO DE QUEBRA ==========================================================================================
            new DevExpress.XtraReports.UI.GroupField("identificador" , DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),});// NO GROUPHEADER       ==========================================================================================
                report.eimprimeunidade = true;
            }
        }
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
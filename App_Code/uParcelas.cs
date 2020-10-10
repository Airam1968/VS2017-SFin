using DevExpress.Web.ASPxEditors;
using System;
using System.Data;

/// <summary>
/// Summary description for uParcelas
/// </summary>
public class uParcelas
{

    public static DataSet LookUpParcelas()
    {
        return SreDblib.GetDsScript("select apelido from vendas");
    }

    public static ASPxComboBox MontaComboParcelas(ASPxComboBox pCombo)
    {
        //Documentação - Chamada da Função
        //
        //uBanco.MontaComboBanco(ASPxComboBox1);
        //
        //Fim Documentação - Chamada da Função


        return SreDblib.MontaCombo(pCombo, "Vendas", "apelido", "apelido", false, "");

    }

    public static String Exclui(string xproduto,
                                string xgrupo,
                                string xunidade,
                                string xparte,
                                string xID)
    {

        string script = "DELETE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                        " where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String Grava(string xproduto,
                                string xgrupo,
                                string xunidade,
                                string xparte,
                                string parcela,
                                string xtipo,
                                string xdata_vencimento,
                                decimal xvlr_parcela,
                                string xdata_pagamento,
                                decimal xvlr_pagamento,
                                string xdata_original,
                                decimal xvlr_original,
                                string xdata_base,
                                decimal xvlr_base,
                                string xnossonumero,
                                string xorigem_pagamento,
                                Int16 xativa,
                                decimal xpercentual_correcao,
                                Int16 xcarteira,
                                Int16 xprotesto,
                                Int16 xcontabil,
                                decimal xtx_multa,
                                decimal xtx_comissao,
                                decimal xvlr_multa,
                                decimal xvlr_comissao,
                                decimal xvlr_desconto,
                                string xperiodicidade_comissao,
                                string xdata_conta,
                                string xconta,
                                string xindexador,
                                decimal xindexador_mes,
                                decimal xindexador_acumulado,
                                decimal xresiduo_mes,
                                decimal xresiduo_acumulado,
                                decimal xvlr_correcao,
                                string xobservacao)
    {

        if (xproduto != String.Empty)
        {
            string script = "INSERT INTO parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) + " VALUES ( " +
                            Srelib.QStr(xproduto) +
                            ", " + Srelib.QStr(xgrupo) +
                            ", " + Srelib.QStr(xunidade) +
                            ", " + Srelib.QStr(xparte) +
                            ", " + Srelib.QStr(parcela) +
                            ", " + Srelib.QStr(xtipo) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_vencimento)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_parcela)) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_pagamento)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_pagamento)) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_original)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_original)) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_base)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_base)) +
                            ", " + Srelib.QStr(xnossonumero) +
                            ", " + Srelib.QStr(xorigem_pagamento) +
                            ", " + xativa +
                            ", " + Srelib.forcaponto(Convert.ToString(xpercentual_correcao)) +
                            ", " + xcarteira +
                            ", " + xprotesto +
                            ", " + xcontabil +
                            ", " + Srelib.forcaponto(Convert.ToString(xtx_multa)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xtx_comissao)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_multa)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_comissao)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_desconto)) +
                            ", " + Srelib.QStr(xperiodicidade_comissao) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_conta)) +
                            ", " + Srelib.QStr(xconta) +
                            ", " + Srelib.QStr(xindexador) +
                            ", " + Srelib.forcaponto(Convert.ToString(xindexador_mes)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xindexador_acumulado)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xresiduo_mes)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xresiduo_acumulado)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_correcao)) +
                            ", " + Srelib.QStr(xobservacao) +
                            ", " + Srelib.forcaponto(Convert.ToString(0.00)) +
                            ", " + Srelib.forcaponto(Convert.ToString(0.00)) +
                            ", " + Srelib.forcaponto(Convert.ToString(0)) +
                            ", " + Srelib.forcaponto(Convert.ToString(0.00)) +
                            ", " + Srelib.forcaponto(Convert.ToString(0.00)) +
                            " ) ";

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String GravaCalculoTP(string xproduto,
                                        string xgrupo,
                                        string xunidade,
                                        string xparte,
                                        string xmeiolote,
                                        Int16 xparcela_ID,
                                        decimal xjurosprice,
                                        decimal xparcela_jurosprice,
                                        decimal xvlr_parcelas_descapitalizada,
                                        Int16 xi)
    {
        //Grava Calculo da Tabela Price na Venda, Parcela a parcela
        string script = "";
        if (xproduto != String.Empty)
        {
            //
            script = "";
            script = " UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                     " SET juros_price = " + Srelib.forcaponto(Convert.ToString(xjurosprice)) +
                     " , vlr_parcelas_jurosprice = " + Srelib.forcaponto(Convert.ToString(xparcela_jurosprice)) +
                     " , amortizacao = " + xi +
                     " , vlr_parcelas_descapitalizada = " + Srelib.forcaponto(Convert.ToString(xvlr_parcelas_descapitalizada)) +
                     " WHERE  " +
                     " ID = " + xparcela_ID;

            SreDblib.ExecScript(script);
        }
        return " ";
    }


    public static String GravaPagamento(string xproduto,
                                        string xgrupo,
                                        string xunidade,
                                        string xparte,
                                        string xID,
                                        string xdata_pagamento,
                                        decimal xvlr_pagamento,
                                        string xorigem_pagamento,
                                        decimal xvlr_multa,
                                        decimal xvlr_comissao,
                                        decimal xvlr_desconto,
                                        string xdata_conta,
                                        string xconta,
                                        decimal xvlr_correcao)
    {

        if (xproduto != String.Empty)
        {
            string script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                            " SET " +
                            " data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_pagamento)) +
                            ", vlr_pagamento = " + Srelib.forcaponto(Convert.ToString(xvlr_pagamento)) +
                            ", origem_pagamento = " + Srelib.QStr(xorigem_pagamento) +
                            ", vlr_multa = " + Srelib.forcaponto(Convert.ToString(xvlr_multa)) +
                            ", vlr_comissao = " + Srelib.forcaponto(Convert.ToString(xvlr_comissao)) +
                            ", vlr_desconto = " + Srelib.forcaponto(Convert.ToString(xvlr_desconto)) +
                            ", data_conta = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_conta)) +
                            ", conta = " + Srelib.QStr(xconta) +
                            ", vlr_correcao = " + Srelib.forcaponto(Convert.ToString(xvlr_correcao)) +
                            " WHERE ID = " + xID;

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String GravaRenegociacao(string xproduto,
                                            string xgrupo,
                                            string xunidade,
                                            string xparte,
                                            string parcela,
                                            string xtipo,
                                            string xdata_vencimento,
                                            decimal xvlr_parcela,
                                            string xdata_pagamento,
                                            decimal xvlr_pagamento,
                                            string xdata_original,
                                            decimal xvlr_original,
                                            string xdata_base,
                                            decimal xvlr_base,
                                            string xnossonumero,
                                            string xorigem_pagamento,
                                            Int16 xativa,
                                            decimal xpercentual_correcao,
                                            Int16 xcarteira,
                                            Int16 xprotesto,
                                            Int16 xcontabil,
                                            decimal xtx_multa,
                                            decimal xtx_comissao,
                                            decimal xvlr_multa,
                                            decimal xvlr_comissao,
                                            decimal xvlr_desconto,
                                            string xperiodicidade_comissao,
                                            string xdata_conta,
                                            string xconta,
                                            string xindexador,
                                            decimal xindexador_mes,
                                            decimal xindexador_acumulado,
                                            decimal xresiduo_mes,
                                            decimal xresiduo_acumulado,
                                            decimal xvlr_correcao,
                                            string xobservacao,
                                            decimal xjuros_price,
                                            decimal xvlr_parcelas_jurosprice,
                                            Int16 xamortizacao,
                                            decimal xvlr_parcelas_descapitalizada,
                                            decimal xtaxa_anual_price
                    )
    {

        if (xproduto != String.Empty)
        {
            string script = "INSERT INTO parcelas_renegociacao" + " VALUES ( " +
                            Srelib.QStr(xproduto) +
                            " , " + Srelib.QStr(xgrupo) +
                            ", " + Srelib.QStr(xunidade) +
                            ", " + Srelib.QStr(xparte) +
                            ", " + Srelib.QStr(parcela) +
                            ", " + Srelib.QStr(xtipo) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_vencimento)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_parcela)) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_pagamento)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_pagamento)) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_original)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_original)) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_base)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_base)) +
                            ", " + Srelib.QStr(xnossonumero) +
                            ", " + Srelib.QStr(xorigem_pagamento) +
                            ", " + xativa +
                            ", " + Srelib.forcaponto(Convert.ToString(xpercentual_correcao)) +
                            ", " + xcarteira +
                            ", " + xprotesto +
                            ", " + xcontabil +
                            ", " + Srelib.forcaponto(Convert.ToString(xtx_multa)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xtx_comissao)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_multa)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_comissao)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_desconto)) +
                            ", " + Srelib.QStr(xperiodicidade_comissao) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_conta)) +
                            ", " + Srelib.QStr(xconta) +
                            ", " + Srelib.QStr(xindexador) +
                            ", " + Srelib.forcaponto(Convert.ToString(xindexador_mes)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xindexador_acumulado)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xresiduo_mes)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xresiduo_acumulado)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_correcao)) +
                            ", " + Srelib.QStr(xobservacao) +
                            ", " + Srelib.forcaponto(Convert.ToString(xjuros_price)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_parcelas_jurosprice)) +
                            ", " + xamortizacao +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_parcelas_descapitalizada)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xtaxa_anual_price)) +
                            " ) ";

            //" where nome=" + Rgblib.QStr(pParametro);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String Altera(string xID,
                                string xproduto,
                                string xgrupo,
                                string xunidade,
                                string xparte,
                                string parcela,
                                string xtipo,
                                string xdata_vencimento,
                                decimal xvlr_parcela,
                                string xdata_pagamento,
                                decimal xvlr_pagamento,
                                string xdata_original,
                                decimal xvlr_original,
                                string xdata_base,
                                decimal xvlr_base,
                                string xnossonumero,
                                string xorigem_pagamento,
                                Int16 xativa,
                                decimal xpercentual_correcao,
                                Int16 xcarteira,
                                Int16 xprotesto,
                                Int16 xcontabil,
                                decimal xtx_multa,
                                decimal xtx_comissao,
                                decimal xvlr_multa,
                                decimal xvlr_comissao,
                                decimal xvlr_desconto,
                                string xperiodicidade_comissao,
                                string xdata_conta,
                                string xconta,
                                string xindexador,
                                decimal xindexador_mes,
                                decimal xindexador_acumulado,
                                decimal xresiduo_mes,
                                decimal xresiduo_acumulado,
                                decimal xvlr_correcao,
                                string xobservacao)
    {

        if (xID != String.Empty)
        {
            string script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) + " SET " +
                            "  produto = " + Srelib.QStr(xproduto) +
                            ", grupo = " + Srelib.QStr(xgrupo) +
                            ", unidade = " + Srelib.QStr(xunidade) +
                            ", parte = " + Srelib.QStr(xparte) +
                            ", Parcela = " + Srelib.QStr(parcela) +
                            ", tipo = " + Srelib.QStr(xtipo) +
                            ", data_vencimento = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_vencimento)) +
                            ", vlr_parcela = " + Srelib.forcaponto(Convert.ToString(xvlr_parcela)) +
                            ", data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_pagamento)) +
                            ", vlr_pagamento = " + Srelib.forcaponto(Convert.ToString(xvlr_pagamento)) +
                            ", data_original = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_original)) +
                            ", vlr_original = " + Srelib.forcaponto(Convert.ToString(xvlr_original)) +
                            ", data_base = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_base)) +
                            ", vlr_base = " + Srelib.forcaponto(Convert.ToString(xvlr_base)) +
                            ", nossonumero = " + Srelib.QStr(xnossonumero) +
                            ", origem_pagamento = " + Srelib.QStr(xorigem_pagamento) +
                            ", ativa = " + xativa +
                            ", percentual_correcao = " + Srelib.forcaponto(Convert.ToString(xpercentual_correcao)) +
                            ", carteira = " + xcarteira +
                            ", protesto = " + xprotesto +
                            ", contabil = " + xcontabil +
                            ", tx_multa = " + Srelib.forcaponto(Convert.ToString(xtx_multa)) +
                            ", tx_comissao = " + Srelib.forcaponto(Convert.ToString(xtx_comissao)) +
                            ", vlr_multa = " + Srelib.forcaponto(Convert.ToString(xvlr_multa)) +
                            ", vlr_comissao = " + Srelib.forcaponto(Convert.ToString(xvlr_comissao)) +
                            ", vlr_desconto = " + Srelib.forcaponto(Convert.ToString(xvlr_desconto)) +
                            ", periodicidade_comissao = " + Srelib.QStr(xperiodicidade_comissao) +
                            ", data_conta = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_conta)) +
                            ", conta = " + Srelib.QStr(xconta) +
                            ", indexador = " + Srelib.QStr(xindexador) +
                            ", indexador_mes = " + Srelib.forcaponto(Convert.ToString(xindexador_mes)) +
                            ", indexador_acumulado = " + Srelib.forcaponto(Convert.ToString(xindexador_acumulado)) +
                            ", residuo_mes = " + Srelib.forcaponto(Convert.ToString(xresiduo_mes)) +
                            ", residuo_acumulado  = " + Srelib.forcaponto(Convert.ToString(xresiduo_acumulado)) +
                            ", vlr_correcao = " + Srelib.forcaponto(Convert.ToString(xvlr_correcao)) +
                            ", observacao = " + Srelib.QStr(xobservacao) +
                            " where ID =" + xID;

            //" where nome=" + Rgblib.QStr(pParametro);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String AlteraCobranca(string xID,
                                        string xproduto,
                                        string xgrupo,
                                        string xunidade,
                                        string xparte,
                                        Int16 xcarteira)
    {

        if (xID != String.Empty)
        {
            string script = " UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) + " SET " +
                            " carteira = " + xcarteira +
                            " where ID =" + xID;

            //" where nome=" + Rgblib.QStr(pParametro);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String AlteraParcela(string xID,
                                       string xproduto,
                                       string xgrupo,
                                       string xunidade,
                                       string xparte,
                                       string xvlr_parcela,
                                       string xdata_vencimento)
    {

        if (xID != String.Empty)
        {
            string script = " UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) + " SET " +
                            " vlr_parcela = " + Srelib.forcaponto(Convert.ToString(xvlr_parcela)) + ", " +
                            " data_vencimento = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_vencimento)) +
                            " where ID =" + xID;

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static Boolean TemParcelaPaga(string xproduto,
                                         string xgrupo,
                                         string xunidade,
                                         string xparte)
    {
        string nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);
        string script = "";
        script = "SELECT ID FROM " + nomearquivo + " WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte +
                //" and " +
                //" ativa = 1" +
                " and " +
                " vlr_pagamento <> 0";

        try
        {
            return SreDblib.TemNaTabela(script);
        }
        catch
        {
            return false;
        }
    }

    public static Boolean ParcelaPaga(string xproduto,
                                      string xgrupo,
                                      string xunidade,
                                      string xparte,
                                      string xparcela_id)
    {
        string nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);
        string script = "";
        //
        script = " SELECT ID FROM " + nomearquivo +
                 " WITH(NOLOCK) WHERE " +
                 " ID = " + xparcela_id +
                 " and " +
                 " data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                 " and " +
                 " vlr_pagamento <> 0";

        try
        {
            return SreDblib.TemNaTabela(script);
        }
        catch
        {
            return false;
        }
    }

    public static Boolean TemParcelaAberto(string xproduto,
                                           string xgrupo,
                                           string xunidade,
                                           string xparte)
    {
        string nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);
        string script = "";

        script = "SELECT ID FROM " + nomearquivo + " WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte +
                " and " +
                " ativa = 1" +
                " and " +
                " vlr_pagamento = 0";

        try
        {
            return SreDblib.TemNaTabela(script);
        }
        catch
        {
            return false;
        }
    }

    public static DataSet PegaDadosParcelas(string xproduto,
                                            string xgrupo,
                                            string xunidade,
                                            string xparte,
                                            string xmeiolote,
                                            string xData1,
                                            string xData2,
                                            string xsituacaopgto,
                                            string xcontacorrente,
                                            string xordenacao,
                                            Boolean xcorrecao,
                                            string xativa)
    {
        //xsituacaopgto = Todas, Pagas e em Aberto
        //caso todas configura ativas ou não via parametro
        string script = "";

        string nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);
        //Todos os Produtos
        if (xproduto == string.Empty)
        {
            //Todas
            if (xsituacaopgto == "T")
            {
                if (xcontacorrente != "0")
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                             " where conta = " + xcontacorrente + " " +
                             " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                             " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                    if (xativa != "1")
                    {
                        script = script + " and ativa = 1  ";
                    }
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
                else
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                             " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                             " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                    if (xativa != "1")
                    {
                        script = script + " and ativa = 1  ";
                    }
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
            }
            //
            //Em Aberto
            if (xsituacaopgto == "A")
            {
                if (xcontacorrente != "0")
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                            " where data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                            " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                            " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                            " and vlr_pagamento = 0 " +
                            " and ativa = 1 " +
                            " and conta = " + xcontacorrente + " ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
                else
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                            " where data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                            " and vlr_pagamento = 0 " +
                            " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                            " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                            " and ativa = 1 ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
            }
            //Em Aberto Atrazadas
            if (xsituacaopgto == "A2")
            {
                if (xcontacorrente != "0")
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                            " where data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                            " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                            " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                            " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                            " and vlr_pagamento = 0 " +
                            " and ativa = 1 " +
                            " and conta = " + xcontacorrente + " ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
                else
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                            " where data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                            " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                            " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                            " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                            " and vlr_pagamento = 0 " +
                            " and ativa = 1 ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
            }
            //
            //Em Aberto Antecipadas
            if (xsituacaopgto == "A3")
            {
                if (xcontacorrente != "0")
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                            " where data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                            " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                            " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                            " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                            " and vlr_pagamento = 0 " +
                            " and ativa = 1 " +
                            " and conta = " + xcontacorrente + " ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
                else
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                            " where data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                            " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                            " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                            " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                            " and vlr_pagamento = 0 " +
                            " and ativa = 1 ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
            }
            //
            //Pagas
            if (xsituacaopgto == "P")
            {
                if (xcontacorrente != "0")
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                             " where (data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                             " and vlr_pagamento <> 0) " +
                             " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                             " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                             " and ativa = 1 " +
                             " and conta = " + xcontacorrente + " ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
                else
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                            " where data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                            " or vlr_pagamento <> 0 " +
                            " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                            " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                            " and ativa = 1 ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
            }

        }
        else
        {
            //Produtos Específico
            if (xgrupo == string.Empty)
            {
                //Todos
                if (xsituacaopgto == "T")
                {
                    if (xcontacorrente != "0")
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                 " and conta = " + xcontacorrente + " " +
                                 " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                 " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                 " and ativa = 1 ";
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                    else
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto;
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                }
                //Em Aberto
                if (xsituacaopgto == "A")
                {
                    if (xcontacorrente != "0")
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                 " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                 " and vlr_pagamento = 0 " +
                                 " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                 " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                 " and ativa = 1 " +
                                 " and conta = " + xcontacorrente + " ";
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                    else
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                 " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                 " and vlr_pagamento = 0 " +
                                 " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                 " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                 " and ativa = 1 ";
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                }
                //Em Aberto Atrazadas
                if (xsituacaopgto == "A2")
                {
                    if (xcontacorrente != "0")
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                " and vlr_pagamento = 0 " +
                                " and ativa = 1 " +
                                " and conta = " + xcontacorrente + " ";
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                    else
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                " and vlr_pagamento = 0 " +
                                " and ativa = 1 ";
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                }
                //
                //Em Aberto Antecipadas
                if (xsituacaopgto == "A3")
                {
                    if (xcontacorrente != "0")
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                " and vlr_pagamento = 0 " +
                                " and ativa = 1 " +
                                " and conta = " + xcontacorrente + " ";
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                    else
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                " and vlr_pagamento = 0 " +
                                " and ativa = 1 ";
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                }
                //
                //Pagos
                if (xsituacaopgto == "P")
                {
                    if (xcontacorrente != "0")
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                 " and (data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                 " and vlr_pagamento <> 0) " +
                                 " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                 " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                 " and ativa = 1 " +
                                 " and conta = " + xcontacorrente + " ";
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                    else
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                 " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                 " or vlr_pagamento <> 0 " +
                                 " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                 " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                 " and ativa = 1 ";
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                }
            }
            else
            {
                //Todos as Unidades
                if (xunidade == string.Empty)
                {
                    //Todas
                    if (xsituacaopgto == "T")
                    {
                        if (xcontacorrente != "0")
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                    " and Grupo = " + xgrupo +
                                    " and conta = " + xcontacorrente + " " +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                            if (xativa != "1")
                            {
                                script = script + " and ativa = 1  ";
                            }
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                        else
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                    " and Grupo = " + xgrupo +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                            if (xativa != "1")
                            {
                                script = script + " and ativa = 1  ";
                            }
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                    }
                    //Em Aberto
                    if (xsituacaopgto == "A")
                    {
                        if (xcontacorrente != "0")
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " and vlr_pagamento = 0 " +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and ativa = 1 " +
                                     " and conta = " + xcontacorrente + " ";
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                        else
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " and vlr_pagamento = 0 " +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and ativa = 1 ";
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                    }
                    //Em Aberto Atrazadas
                    if (xsituacaopgto == "A2")
                    {
                        if (xcontacorrente != "0")
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                     " and vlr_pagamento = 0 " +
                                     " and ativa = 1 " +
                                     " and conta = " + xcontacorrente + " ";
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                        else
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                     " and vlr_pagamento = 0 " +
                                     " and ativa = 1 ";
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                    }
                    //
                    //Em Aberto Antecipadas
                    if (xsituacaopgto == "A3")
                    {
                        if (xcontacorrente != "0")
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                     " and vlr_pagamento = 0 " +
                                     " and ativa = 1 " +
                                     " and conta = " + xcontacorrente + " ";
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                        else
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                     " and vlr_pagamento = 0 " +
                                     " and ativa = 1 ";
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                    }
                    //
                    //Pagos
                    if (xsituacaopgto == "P")
                    {
                        if (xcontacorrente != "0")
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and (data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " and vlr_pagamento <> 0) " +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and ativa = 1 " +
                                     " and conta = " + xcontacorrente + " ";
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                        else
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " or vlr_pagamento <> 0 " +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and ativa = 1 ";
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                    }
                }
                else
                {
                    //Unidade específica
                    //Todas as Partes
                    if (xparte == string.Empty)
                    {
                        //Todas
                        if (xsituacaopgto == "T")
                        {
                            if (xcontacorrente != "0")
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                    " and Grupo = " + xgrupo +
                                    " and Unidade = " + xunidade +
                                    " and conta = " + xcontacorrente + " " +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                if (xativa != "1")
                                {
                                    script = script + " and ativa = 1  ";
                                }
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                            else
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                    " and Grupo = " + xgrupo +
                                    " and Unidade = " + xunidade +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                if (xativa != "1")
                                {
                                    script = script + " and ativa = 1  ";
                                }
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                        }
                        //Em Aberto
                        if (xsituacaopgto == "A")
                        {
                            if (xcontacorrente != "0")
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " and vlr_pagamento = 0 " +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and ativa = 1 " +
                                         " and conta = " + xcontacorrente + " ";
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                            else
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " and vlr_pagamento = 0 " +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and ativa = 1 ";
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                        }
                        //Em Aberto Atrazadas
                        if (xsituacaopgto == "A2")
                        {
                            if (xcontacorrente != "0")
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                         " and vlr_pagamento = 0 " +
                                         " and ativa = 1 " +
                                         " and conta = " + xcontacorrente + " ";
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                            else
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                         " and vlr_pagamento = 0 " +
                                         " and ativa = 1 ";
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                        }
                        //
                        //Em Aberto Antecipadas
                        if (xsituacaopgto == "A3")
                        {
                            if (xcontacorrente != "0")
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                         " and vlr_pagamento = 0 " +
                                         " and ativa = 1 " +
                                         " and conta = " + xcontacorrente + " ";
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                            else
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                         " and vlr_pagamento = 0 " +
                                         " and ativa = 1 ";
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                        }
                        //
                        //Pagas
                        if (xsituacaopgto == "P")
                        {
                            if (xcontacorrente != "0")
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and (data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " and vlr_pagamento <> 0) " +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and ativa = 1 " +
                                         " and conta = " + xcontacorrente + " ";
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                            else
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " or vlr_pagamento <> 0 " +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and ativa = 1 ";
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        //Parte Específica
                        //Todas
                        if (xsituacaopgto == "T")
                        {
                            if (xcontacorrente != "0")
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                    " and Grupo = " + xgrupo +
                                    " and Unidade = " + xunidade +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                if (xativa != "1")
                                {
                                    script = script + " and ativa = 1  ";
                                }
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                //Unidade Total
                                if (xparte == "0")
                                {
                                    script = script +
                                        " and Parte = " + xparte;
                                }
                                else
                                {
                                    if (xparte == "1")
                                    {
                                        if (xmeiolote == "1")
                                        {
                                            //Meio Lote 1
                                            script = script +
                                                " and Parte = " + xparte;
                                        }
                                        else
                                        {
                                            //Meio Lote 2
                                            script = script +
                                                " and Parte = 2 ";
                                        }
                                    }
                                }
                                //
                                script = script +
                                    " and conta = " + xcontacorrente + " ";
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                            else
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade;
                                //Unidade Total
                                if (xparte == "0")
                                {
                                    script = script +
                                        " and Parte = " + xparte;
                                }
                                else
                                {
                                    if (xparte == "1")
                                    {
                                        if (xmeiolote == "1")
                                        {
                                            //Meio Lote 1
                                            script = script +
                                                " and Parte = " + xparte;
                                        }
                                        else
                                        {
                                            //Meio Lote 2
                                            script = script +
                                                " and Parte = 2 ";
                                        }
                                    }
                                }
                                script = script +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                if (xativa != "1")
                                {
                                    script = script + " and ativa = 1  ";
                                }
                                //
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                        }
                        //Parte 0 ou 1
                        if ((xparte == "0") || (xparte == "1"))
                        {
                            //Todas
                            if (xsituacaopgto == "T")
                            {
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade;
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    script = script +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xativa != "1")
                                    {
                                        script = script + " and ativa = 1  ";
                                    }
                                    //
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //
                                    script = script +
                                        " and conta = " + xcontacorrente + " ";
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade;
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    script = script +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xativa != "1")
                                    {
                                        script = script + " and ativa = 1  ";
                                    }
                                    //
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //Em Aberto
                            if (xsituacaopgto == "A")
                            {
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade;
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    script = script +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xativa != "1")
                                    {
                                        script = script + " and ativa = 1  ";
                                    }
                                    //
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and conta = " + xcontacorrente + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade;
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    script = script +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xativa != "1")
                                    {
                                        script = script + " and ativa = 1  ";
                                    }
                                    //
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //
                                    script = script +
                                    " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                    " and vlr_pagamento = 0 " +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                    " and ativa = 1 ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //Em Aberto Atrasadas
                            if (xsituacaopgto == "A2")
                            {
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade;
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and conta = " + xcontacorrente + " " +
                                        " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                    " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                    " and vlr_pagamento = 0 " +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                    " and ativa = 1 " +
                                    " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //Em Aberto A Vencer
                            if (xsituacaopgto == "A3")
                            {
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and conta = " + xcontacorrente + " " +
                                        " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                    " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                    " and vlr_pagamento = 0 " +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                    " and ativa = 1 " +
                                    " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //
                            //Pagas
                            if (xsituacaopgto == "P")
                            {
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xativa != "1")
                                    {
                                        script = script + " and ativa = 1  ";
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        //" or vlr_pagamento <> 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and conta = " + xcontacorrente + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xativa != "1")
                                    {
                                        script = script + " and ativa = 1  ";
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xativa != "1")
                                    {
                                        script = script + " and ativa = 1  ";
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //" or vlr_pagamento <> 0 ";
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            //Parte = 2
                            if (xsituacaopgto == "T")
                            {
                                //Todas
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xativa != "1")
                                    {
                                        script = script + " and ativa = 1  ";
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and conta = " + xcontacorrente + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xativa != "1")
                                    {
                                        script = script + " and ativa = 1  ";
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xativa != "1")
                                    {
                                        script = script + " and ativa = 1  ";
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //
                            //Em Aberto
                            if (xsituacaopgto == "A")
                            {
                                //Em Aberto
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xativa != "1")
                                    {
                                        script = script + " and ativa = 1  ";
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and conta = " + xcontacorrente + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xativa != "1")
                                    {
                                        script = script + " and ativa = 1  ";
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //Em Aberto atrasado
                            if (xsituacaopgto == "A2")
                            {
                                //Em Aberto
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and conta = " + xcontacorrente + " " +
                                        " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //Em Aberto a vencer
                            if (xsituacaopgto == "A3")
                            {
                                //Em Aberto
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and conta = " + xcontacorrente + " " +
                                        " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //
                            //
                            //Pago
                            if (xsituacaopgto == "P")
                            {
                                //Pagas
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xativa != "1")
                                    {
                                        script = script + " and ativa = 1  ";
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        //" or vlr_pagamento <> 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and conta = " + xcontacorrente + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xativa != "1")
                                    {
                                        script = script + " and ativa = 1  ";
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        //" or vlr_pagamento <> 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        return SreDblib.GetDsScript(script);

    }

    public static DataSet PegaDadosParcelas2(string xproduto,
                                             string xgrupo,
                                             string xunidade,
                                             string xparte,
                                             string xmeiolote,
                                             string xData1,
                                             string xData2,
                                             string xsituacaopgto,
                                             string xcontacorrente,
                                             string xordenacao,
                                             Boolean xcorrecao,
                                             string xativa)
    {
        //PegaDadosParcelas refatorado em teste na correção de contratos
        //12/04/2019
        //Ações a tomar:
        //trocar PegaDadosParcelas por PegaDadosParcelas2
        //Mudar a chamada para pegar parcelas ativas ou não com novo parametro criado
        //
        //
        //xsituacaopgto = Todas, Pagas e em Aberto
        //xativa = 1
        Boolean lOk = true;
        string script = "";
        if ((xproduto == string.Empty) && (xgrupo == string.Empty))
        {
            lOk = false;
        }
        //
        if (lOk)
        {
            //
            string nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);
            //
            //Script Base
            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) where 1 = 1 ";
            //Conta Corrente
            if (xcontacorrente != "0")
            {
                script = script + " and conta = " + xcontacorrente + " ";
            }
            //
            //Produto Específico
            if (xproduto != string.Empty)
            {
                script = script + " and produto = " + xproduto + " ";
            }
            //Grupo Específico
            if (xgrupo != string.Empty)
            {
                script = script + " and grupo = " + xgrupo + " ";
            }
            //Unidade Específica
            if (xunidade != string.Empty)
            {
                script = script + " and Unidade = " + xunidade + " ";
            }
            //Unidade Parte
            if (xparte == "0")
            {
                script = script + " and Parte = " + xparte + " ";
            }
            else
            {
                if (xparte == "1")
                {
                    if (xmeiolote == "1")
                    {
                        //Meio Lote 1
                        script = script + " and Parte = 1  ";
                    }
                    else
                    {
                        //Meio Lote 2
                        script = script + " and Parte = 2  ";
                    }
                }
            }
            //
            //Situação de Pagamento
            //Todos
            if (xsituacaopgto == "T")
            {
                script = script + " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                  " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
            }
            //Aberto
            if (xsituacaopgto == "A")
            {
                script = script + " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                  " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                  " and vlr_pagamento = 0 ";
            }
            //
            //Em Aberto Atrazadas
            if (xsituacaopgto == "A2")
            {
                script = script + " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                  " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                  " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                  " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                  " and vlr_pagamento = 0 ";
            }
            //Em Aberto Antecipadas
            if (xsituacaopgto == "A3")
            {
                script = script + " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                  " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                  " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                  " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                  " and vlr_pagamento = 0 ";
            }
            //Pagas
            if (xsituacaopgto == "P")
            {
                script = script + " and (data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                  " and vlr_pagamento <> 0) " +
                                  " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                  " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
            }
            //
            //Ativa
            if (xativa == "1")
            {
                script = script + " and ativa = 1  ";
            }
            //CORRIGE PARCELA IPTU
            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
            {
                script = script + " and " +
                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
            }
            //Ordenação
            if (xordenacao == "N")
            {
                script = script + " order by produto, grupo, unidade, data_vencimento";
            }
            if (xordenacao == "V")
            {
                script = script + " order by data_vencimento";
            }
            if (xordenacao == "P")
            {
                script = script + " order by data_pagamento";
            }
        }

        return SreDblib.GetDsScript(script);

    }


    public static DataSet PegaDadosParcelasRenegociacao(string xproduto,
                                                        string xgrupo,
                                                        string xunidade,
                                                        string xparte,
                                                        string xmeiolote,
                                                        string xData1,
                                                        string xData2,
                                                        string xsituacaopgto,
                                                        string xcontacorrente,
                                                        string xordenacao,
                                                        Boolean xcorrecao)
    {
        //xsituacaopgto = Todas, Pagas e em Aberto
        string script = "";

        string nomearquivo = "parcelas_renegociacao";
        //Todos os Produtos
        if (xproduto == string.Empty)
        {
            //Todas
            if (xsituacaopgto == "T")
            {
                if (xcontacorrente != "0")
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                             " where conta = " + xcontacorrente + " " +
                             " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                             " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
                else
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                             " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                             " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
            }
            //
            //Em Aberto
            if (xsituacaopgto == "A")
            {
                if (xcontacorrente != "0")
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                            " where data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                            " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                            " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                            " and vlr_pagamento = 0 " +
                            " and ativa = 1 " +
                            " and conta = " + xcontacorrente + " ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
                else
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                            " where data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                            " and vlr_pagamento = 0 " +
                            " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                            " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                            " and ativa = 1 ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
            }
            //Em Aberto Atrazadas
            if (xsituacaopgto == "A2")
            {
                if (xcontacorrente != "0")
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                            " where data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                            " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                            " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                            " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                            " and vlr_pagamento = 0 " +
                            " and ativa = 1 " +
                            " and conta = " + xcontacorrente + " ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
                else
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                            " where data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                            " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                            " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                            " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                            " and vlr_pagamento = 0 " +
                            " and ativa = 1 ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
            }
            //
            //Em Aberto Antecipadas
            if (xsituacaopgto == "A3")
            {
                if (xcontacorrente != "0")
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                            " where data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                            " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                            " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                            " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                            " and vlr_pagamento = 0 " +
                            " and ativa = 1 " +
                            " and conta = " + xcontacorrente + " ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
                else
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                            " where data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                            " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                            " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                            " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                            " and vlr_pagamento = 0 " +
                            " and ativa = 1 ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
            }
            //
            //Pagas
            if (xsituacaopgto == "P")
            {
                if (xcontacorrente != "0")
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                             " where (data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                             " and vlr_pagamento <> 0) " +
                             " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                             " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                             " and ativa = 1 " +
                             " and conta = " + xcontacorrente + " ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
                else
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                            " where data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                            " or vlr_pagamento <> 0 " +
                            " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                            " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                            " and ativa = 1 ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
            }

        }
        else
        {
            //Produtos Específico
            if (xgrupo == string.Empty)
            {
                //Todos
                if (xsituacaopgto == "T")
                {
                    if (xcontacorrente != "0")
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                 " and conta = " + xcontacorrente + " " +
                                 " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                 " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                 " and ativa = 1 ";
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                    else
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto;
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                }
                //Em Aberto
                if (xsituacaopgto == "A")
                {
                    if (xcontacorrente != "0")
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                 " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                 " and vlr_pagamento = 0 " +
                                 " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                 " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                 " and ativa = 1 " +
                                 " and conta = " + xcontacorrente + " ";
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                    else
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                 " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                 " and vlr_pagamento = 0 " +
                                 " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                 " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                 " and ativa = 1 ";
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                }
                //Em Aberto Atrazadas
                if (xsituacaopgto == "A2")
                {
                    if (xcontacorrente != "0")
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                " and vlr_pagamento = 0 " +
                                " and ativa = 1 " +
                                " and conta = " + xcontacorrente + " ";
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                    else
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                " and vlr_pagamento = 0 " +
                                " and ativa = 1 ";
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                }
                //
                //Em Aberto Antecipadas
                if (xsituacaopgto == "A3")
                {
                    if (xcontacorrente != "0")
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                " and vlr_pagamento = 0 " +
                                " and ativa = 1 " +
                                " and conta = " + xcontacorrente + " ";
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                    else
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                " and vlr_pagamento = 0 " +
                                " and ativa = 1 ";
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                }
                //
                //Pagos
                if (xsituacaopgto == "P")
                {
                    if (xcontacorrente != "0")
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                 " and (data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                 " and vlr_pagamento <> 0) " +
                                 " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                 " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                 " and ativa = 1 " +
                                 " and conta = " + xcontacorrente + " ";
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                    else
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                 " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                 " or vlr_pagamento <> 0 " +
                                 " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                 " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                 " and ativa = 1 ";
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                }
            }
            else
            {
                //Todos as Unidades
                if (xunidade == string.Empty)
                {
                    //Todas
                    if (xsituacaopgto == "T")
                    {
                        if (xcontacorrente != "0")
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                    " and Grupo = " + xgrupo +
                                    " and conta = " + xcontacorrente + " " +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                        else
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                    " and Grupo = " + xgrupo +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                    }
                    //Em Aberto
                    if (xsituacaopgto == "A")
                    {
                        if (xcontacorrente != "0")
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " and vlr_pagamento = 0 " +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and ativa = 1 " +
                                     " and conta = " + xcontacorrente + " ";
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                        else
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " and vlr_pagamento = 0 " +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and ativa = 1 ";
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                    }
                    //Em Aberto Atrazadas
                    if (xsituacaopgto == "A2")
                    {
                        if (xcontacorrente != "0")
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                     " and vlr_pagamento = 0 " +
                                     " and ativa = 1 " +
                                     " and conta = " + xcontacorrente + " ";
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                        else
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                     " and vlr_pagamento = 0 " +
                                     " and ativa = 1 ";
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                    }
                    //
                    //Em Aberto Antecipadas
                    if (xsituacaopgto == "A3")
                    {
                        if (xcontacorrente != "0")
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                     " and vlr_pagamento = 0 " +
                                     " and ativa = 1 " +
                                     " and conta = " + xcontacorrente + " ";
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                        else
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                     " and vlr_pagamento = 0 " +
                                     " and ativa = 1 ";
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                    }
                    //
                    //Pagos
                    if (xsituacaopgto == "P")
                    {
                        if (xcontacorrente != "0")
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and (data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " and vlr_pagamento <> 0) " +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and ativa = 1 " +
                                     " and conta = " + xcontacorrente + " ";
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                        else
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " or vlr_pagamento <> 0 " +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and ativa = 1 ";
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                    }
                }
                else
                {
                    //Unidade específica
                    //Todas as Partes
                    if (xparte == string.Empty)
                    {
                        //Todas
                        if (xsituacaopgto == "T")
                        {
                            if (xcontacorrente != "0")
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                    " and Grupo = " + xgrupo +
                                    " and Unidade = " + xunidade +
                                    " and conta = " + xcontacorrente + " " +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                            else
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                    " and Grupo = " + xgrupo +
                                    " and Unidade = " + xunidade +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                        }
                        //Em Aberto
                        if (xsituacaopgto == "A")
                        {
                            if (xcontacorrente != "0")
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " and vlr_pagamento = 0 " +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and ativa = 1 " +
                                         " and conta = " + xcontacorrente + " ";
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                            else
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " and vlr_pagamento = 0 " +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and ativa = 1 ";
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                        }
                        //Em Aberto Atrazadas
                        if (xsituacaopgto == "A2")
                        {
                            if (xcontacorrente != "0")
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                         " and vlr_pagamento = 0 " +
                                         " and ativa = 1 " +
                                         " and conta = " + xcontacorrente + " ";
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                            else
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                         " and vlr_pagamento = 0 " +
                                         " and ativa = 1 ";
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                        }
                        //
                        //Em Aberto Antecipadas
                        if (xsituacaopgto == "A3")
                        {
                            if (xcontacorrente != "0")
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                         " and vlr_pagamento = 0 " +
                                         " and ativa = 1 " +
                                         " and conta = " + xcontacorrente + " ";
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                            else
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                         " and vlr_pagamento = 0 " +
                                         " and ativa = 1 ";
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                        }
                        //
                        //Pagas
                        if (xsituacaopgto == "P")
                        {
                            if (xcontacorrente != "0")
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and (data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " and vlr_pagamento <> 0) " +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and ativa = 1 " +
                                         " and conta = " + xcontacorrente + " ";
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                            else
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " or vlr_pagamento <> 0 " +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and ativa = 1 ";
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        //Parte Específica
                        //Todas
                        if (xsituacaopgto == "T")
                        {
                            if (xcontacorrente != "0")
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                    " and Grupo = " + xgrupo +
                                    " and Unidade = " + xunidade +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                //Unidade Total
                                if (xparte == "0")
                                {
                                    script = script +
                                        " and Parte = " + xparte;
                                }
                                else
                                {
                                    if (xparte == "1")
                                    {
                                        if (xmeiolote == "1")
                                        {
                                            //Meio Lote 1
                                            script = script +
                                                " and Parte = " + xparte;
                                        }
                                        else
                                        {
                                            //Meio Lote 2
                                            script = script +
                                                " and Parte = 2 ";
                                        }
                                    }
                                }
                                //
                                script = script +
                                    " and conta = " + xcontacorrente + " ";
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                            else
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade;
                                //Unidade Total
                                if (xparte == "0")
                                {
                                    script = script +
                                        " and Parte = " + xparte;
                                }
                                else
                                {
                                    if (xparte == "1")
                                    {
                                        if (xmeiolote == "1")
                                        {
                                            //Meio Lote 1
                                            script = script +
                                                " and Parte = " + xparte;
                                        }
                                        else
                                        {
                                            //Meio Lote 2
                                            script = script +
                                                " and Parte = 2 ";
                                        }
                                    }
                                }
                                script = script +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                //
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                        }
                        //Parte 0 ou 1
                        if ((xparte == "0") || (xparte == "1"))
                        {
                            //Todas
                            if (xsituacaopgto == "T")
                            {
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade;
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    script = script +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    //
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //
                                    script = script +
                                        " and conta = " + xcontacorrente + " ";
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade;
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    script = script +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    //
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //Em Aberto
                            if (xsituacaopgto == "A")
                            {
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade;
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    script = script +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    //
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and conta = " + xcontacorrente + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade;
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    script = script +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    //
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //
                                    script = script +
                                    " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                    " and vlr_pagamento = 0 " +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                    " and ativa = 1 ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //Em Aberto Atrasadas
                            if (xsituacaopgto == "A2")
                            {
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade;
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and conta = " + xcontacorrente + " " +
                                        " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                    " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                    " and vlr_pagamento = 0 " +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                    " and ativa = 1 " +
                                    " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //Em Aberto A Vencer
                            if (xsituacaopgto == "A3")
                            {
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and conta = " + xcontacorrente + " " +
                                        " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                    " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                    " and vlr_pagamento = 0 " +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                    " and ativa = 1 " +
                                    " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //
                            //Pagas
                            if (xsituacaopgto == "P")
                            {
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        //" or vlr_pagamento <> 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and conta = " + xcontacorrente + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //" or vlr_pagamento <> 0 ";
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            //Parte = 2
                            if (xsituacaopgto == "T")
                            {
                                //Todas
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and conta = " + xcontacorrente + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //
                            //Em Aberto
                            if (xsituacaopgto == "A")
                            {
                                //Em Aberto
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and conta = " + xcontacorrente + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //Em Aberto atrasado
                            if (xsituacaopgto == "A2")
                            {
                                //Em Aberto
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and conta = " + xcontacorrente + " " +
                                        " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //Em Aberto a vencer
                            if (xsituacaopgto == "A3")
                            {
                                //Em Aberto
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and conta = " + xcontacorrente + " " +
                                        " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //
                            //
                            //Pago
                            if (xsituacaopgto == "P")
                            {
                                //Pagas
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        //" or vlr_pagamento <> 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and conta = " + xcontacorrente + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        //" or vlr_pagamento <> 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        return SreDblib.GetDsScript(script);

    }


    public static DataSet PegaDadosParcelasContabil(string xproduto,
                                                    string xgrupo,
                                                    string xunidade,
                                                    string xparte,
                                                    string xmeiolote,
                                                    string xData1,
                                                    string xData2,
                                                    string xsituacaopgto,
                                                    string xcontacorrente,
                                                    string xordenacao,
                                                    string xcontabil,
                                                    string xcarteira,
                                                    Boolean xcorrecao)
    {
        //xsituacaopgto = Todas, Pagas e em Aberto
        string script = "";

        string nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);
        //Todos os Produtos
        if (xproduto == string.Empty)
        {
            //Todas
            if (xsituacaopgto == "T")
            {
                if (xcontacorrente != "0")
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                             " where conta = " + xcontacorrente + " " +
                             " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                             " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
                else
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                             " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                             " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
            }
            //
            //Em Aberto
            if (xsituacaopgto == "A")
            {
                if (xcontacorrente != "0")
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                            " where data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                            " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                            " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                            " and vlr_pagamento = 0 " +
                            " and ativa = 1 " +
                            " and contabil = " + xcontabil +
                            " and conta = " + xcontacorrente + " ";
                    if (xcarteira != String.Empty)
                    {
                        if (xcarteira == "True")
                        {
                            script = script + " and " +
                                              " carteira = 1 ";
                        }
                        else
                        {
                            script = script + " and " +
                                              " carteira = 0 ";
                        }
                    }
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
                else
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                            " where data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                            " and vlr_pagamento = 0 " +
                            " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                            " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                            " and ativa = 1 ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
            }
            //Em Aberto Atrazadas
            if (xsituacaopgto == "A2")
            {
                if (xcontacorrente != "0")
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                            " where data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                            " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                            " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                            " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                            " and vlr_pagamento = 0 " +
                            " and ativa = 1 " +
                            " and contabil = " + xcontabil +
                            " and conta = " + xcontacorrente + " ";
                    if (xcarteira != String.Empty)
                    {
                        if (xcarteira == "True")
                        {
                            script = script + " and " +
                                              " carteira = 1 ";
                        }
                        else
                        {
                            script = script + " and " +
                                              " carteira = 0 ";
                        }
                    }
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
                else
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                            " where data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                            " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                            " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                            " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                            " and vlr_pagamento = 0 " +
                            " and ativa = 1 ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
            }
            //
            //Em Aberto Antecipadas
            if (xsituacaopgto == "A3")
            {
                if (xcontacorrente != "0")
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                            " where data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                            " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                            " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                            " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                            " and vlr_pagamento = 0 " +
                            " and ativa = 1 " +
                            " and contabil = " + xcontabil +
                            " and conta = " + xcontacorrente + " ";
                    if (xcarteira != String.Empty)
                    {
                        if (xcarteira == "True")
                        {
                            script = script + " and " +
                                              " carteira = 1 ";
                        }
                        else
                        {
                            script = script + " and " +
                                              " carteira = 0 ";
                        }
                    }
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
                else
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                            " where data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                            " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                            " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                            " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                            " and vlr_pagamento = 0 " +
                            " and ativa = 1 ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
            }
            //
            //Pagas
            if (xsituacaopgto == "P")
            {
                if (xcontacorrente != "0")
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                             " where (data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                             " and vlr_pagamento <> 0) " +
                             " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                             " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                             " and ativa = 1 " +
                             " and contabil = " + xcontabil +
                             " and conta = " + xcontacorrente + " ";
                    if (xcarteira != String.Empty)
                    {
                        if (xcarteira == "True")
                        {
                            script = script + " and " +
                                              " carteira = 1 ";
                        }
                        else
                        {
                            script = script + " and " +
                                              " carteira = 0 ";
                        }
                    }
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
                else
                {
                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                            " where data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                            " or vlr_pagamento <> 0 " +
                            " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                            " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                            " and ativa = 1 ";
                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                    {
                        script = script + " and " +
                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                    }
                    if (xordenacao == "N")
                    {
                        script = script + " order by produto, grupo, unidade, data_vencimento";
                    }
                    else
                    {
                        if (xordenacao == "V")
                        {
                            script = script + " order by data_vencimento";
                        }
                        else
                        {
                            script = script + " order by data_pagamento";
                        }
                    }
                }
            }

        }
        else
        {
            //Produtos Específico
            if (xgrupo == string.Empty)
            {
                //Todos
                if (xsituacaopgto == "T")
                {
                    if (xcontacorrente != "0")
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                 " and conta = " + xcontacorrente + " " +
                                 " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                 " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                 " and ativa = 1 ";
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                    else
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto;
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                }
                //Em Aberto
                if (xsituacaopgto == "A")
                {
                    if (xcontacorrente != "0")
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                 " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                 " and vlr_pagamento = 0 " +
                                 " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                 " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                 " and ativa = 1 " +
                                 " and contabil = " + xcontabil +
                                 " and conta = " + xcontacorrente + " ";
                        if (xcarteira != String.Empty)
                        {
                            if (xcarteira == "True")
                            {
                                script = script + " and " +
                                                  " carteira = 1 ";
                            }
                            else
                            {
                                script = script + " and " +
                                                  " carteira = 0 ";
                            }
                        }
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                    else
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                 " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                 " and vlr_pagamento = 0 " +
                                 " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                 " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                 " and ativa = 1 ";
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                }
                //Em Aberto Atrazadas
                if (xsituacaopgto == "A2")
                {
                    if (xcontacorrente != "0")
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                " and vlr_pagamento = 0 " +
                                " and ativa = 1 " +
                                " and contabil = " + xcontabil +
                                " and conta = " + xcontacorrente + " ";
                        if (xcarteira != String.Empty)
                        {
                            if (xcarteira == "True")
                            {
                                script = script + " and " +
                                                  " carteira = 1 ";
                            }
                            else
                            {
                                script = script + " and " +
                                                  " carteira = 0 ";
                            }
                        }
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                    else
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                " and vlr_pagamento = 0 " +
                                " and ativa = 1 ";
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                }
                //
                //Em Aberto Antecipadas
                if (xsituacaopgto == "A3")
                {
                    if (xcontacorrente != "0")
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                " and vlr_pagamento = 0 " +
                                " and ativa = 1 " +
                                " and contabil = " + xcontabil +
                                " and conta = " + xcontacorrente + " ";
                        if (xcarteira != String.Empty)
                        {
                            if (xcarteira == "True")
                            {
                                script = script + " and " +
                                                  " carteira = 1 ";
                            }
                            else
                            {
                                script = script + " and " +
                                                  " carteira = 0 ";
                            }
                        }
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                    else
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                " and vlr_pagamento = 0 " +
                                " and ativa = 1 ";
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                }
                //
                //Pagos
                if (xsituacaopgto == "P")
                {
                    if (xcontacorrente != "0")
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                 " and (data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                 " and vlr_pagamento <> 0) " +
                                 " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                 " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                 " and ativa = 1 " +
                                 " and contabil = " + xcontabil +
                                 " and conta = " + xcontacorrente + " ";
                        if (xcarteira != String.Empty)
                        {
                            if (xcarteira == "True")
                            {
                                script = script + " and " +
                                                  " carteira = 1 ";
                            }
                            else
                            {
                                script = script + " and " +
                                                  " carteira = 0 ";
                            }
                        }
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                    else
                    {
                        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                 " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                 " or vlr_pagamento <> 0 " +
                                 " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                 " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                 " and ativa = 1 ";
                        if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                        {
                            script = script + " and " +
                                              " tipo <> " + Srelib.QStr("IPTU") + "  ";
                        }
                        if (xordenacao == "N")
                        {
                            script = script + " order by produto, grupo, unidade, data_vencimento";
                        }
                        else
                        {
                            if (xordenacao == "V")
                            {
                                script = script + " order by data_vencimento";
                            }
                            else
                            {
                                script = script + " order by data_pagamento";
                            }
                        }
                    }
                }
            }
            else
            {
                //Todos as Unidades
                if (xunidade == string.Empty)
                {
                    //Todas
                    if (xsituacaopgto == "T")
                    {
                        if (xcontacorrente != "0")
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                    " and Grupo = " + xgrupo +
                                    " and conta = " + xcontacorrente + " " +
                                    " and ativa = 1 " +
                                    " and contabil = " + xcontabil +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                            if (xcarteira != String.Empty)
                            {
                                if (xcarteira == "True")
                                {
                                    script = script + " and " +
                                                      " carteira = 1 ";
                                }
                                else
                                {
                                    script = script + " and " +
                                                      " carteira = 0 ";
                                }
                            }
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                        else
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                    " and Grupo = " + xgrupo +
                                    " and ativa = 1 " +
                                    " and contabil = " + xcontabil +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) ";
                            if (xcarteira != String.Empty)
                            {
                                if (xcarteira == "True")
                                {
                                    script = script + " and " +
                                                      " carteira = 1 ";
                                }
                                else
                                {
                                    script = script + " and " +
                                                      " carteira = 0 ";
                                }
                            }
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                    }
                    //Em Aberto
                    if (xsituacaopgto == "A")
                    {
                        if (xcontacorrente != "0")
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " and vlr_pagamento = 0 " +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and ativa = 1 " +
                                     " and contabil = " + xcontabil +
                                     " and conta = " + xcontacorrente + " ";
                            if (xcarteira != String.Empty)
                            {
                                if (xcarteira == "True")
                                {
                                    script = script + " and " +
                                                      " carteira = 1 ";
                                }
                                else
                                {
                                    script = script + " and " +
                                                      " carteira = 0 ";
                                }
                            }
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                        else
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " and vlr_pagamento = 0 " +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and ativa = 1 " +
                                     " and contabil = " + xcontabil;
                            if (xcarteira != String.Empty)
                            {
                                if (xcarteira == "True")
                                {
                                    script = script + " and " +
                                                      " carteira = 1 ";
                                }
                                else
                                {
                                    script = script + " and " +
                                                      " carteira = 0 ";
                                }
                            }
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                    }
                    //Em Aberto Atrazadas
                    if (xsituacaopgto == "A2")
                    {
                        if (xcontacorrente != "0")
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                     " and vlr_pagamento = 0 " +
                                     " and ativa = 1 " +
                                     " and contabil = " + xcontabil +
                                     " and conta = " + xcontacorrente + " ";
                            if (xcarteira != String.Empty)
                            {
                                if (xcarteira == "True")
                                {
                                    script = script + " and " +
                                                      " carteira = 1 ";
                                }
                                else
                                {
                                    script = script + " and " +
                                                      " carteira = 0 ";
                                }
                            }
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                        else
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                     " and vlr_pagamento = 0 " +
                                     " and ativa = 1 " +
                                     " and contabil = " + xcontabil;
                            if (xcarteira != String.Empty)
                            {
                                if (xcarteira == "True")
                                {
                                    script = script + " and " +
                                                      " carteira = 1 ";
                                }
                                else
                                {
                                    script = script + " and " +
                                                      " carteira = 0 ";
                                }
                            }
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                    }
                    //
                    //Em Aberto Antecipadas
                    if (xsituacaopgto == "A3")
                    {
                        if (xcontacorrente != "0")
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                     " and vlr_pagamento = 0 " +
                                     " and ativa = 1 " +
                                     " and contabil = " + xcontabil +
                                     " and conta = " + xcontacorrente + " ";
                            if (xcarteira != String.Empty)
                            {
                                if (xcarteira == "True")
                                {
                                    script = script + " and " +
                                                      " carteira = 1 ";
                                }
                                else
                                {
                                    script = script + " and " +
                                                      " carteira = 0 ";
                                }
                            }
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                        else
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                     " and vlr_pagamento = 0 " +
                                     " and ativa = 1 " +
                                     " and contabil = " + xcontabil;
                            if (xcarteira != String.Empty)
                            {
                                if (xcarteira == "True")
                                {
                                    script = script + " and " +
                                                      " carteira = 1 ";
                                }
                                else
                                {
                                    script = script + " and " +
                                                      " carteira = 0 ";
                                }
                            }
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                    }
                    //
                    //Pagos
                    if (xsituacaopgto == "P")
                    {
                        if (xcontacorrente != "0")
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and (data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " and vlr_pagamento <> 0) " +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and ativa = 1 " +
                                     " and contabil = " + xcontabil +
                                     " and conta = " + xcontacorrente + " ";
                            if (xcarteira != String.Empty)
                            {
                                if (xcarteira == "True")
                                {
                                    script = script + " and " +
                                                      " carteira = 1 ";
                                }
                                else
                                {
                                    script = script + " and " +
                                                      " carteira = 0 ";
                                }
                            }
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                        else
                        {
                            script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                     " and Grupo = " + xgrupo +
                                     " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                     " or vlr_pagamento <> 0 " +
                                     " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                     " and ativa = 1 " +
                                     " and contabil = " + xcontabil;
                            if (xcarteira != String.Empty)
                            {
                                if (xcarteira == "True")
                                {
                                    script = script + " and " +
                                                      " carteira = 1 ";
                                }
                                else
                                {
                                    script = script + " and " +
                                                      " carteira = 0 ";
                                }
                            }
                            if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                            {
                                script = script + " and " +
                                                  " tipo <> " + Srelib.QStr("IPTU") + "  ";
                            }
                            if (xordenacao == "N")
                            {
                                script = script + " order by produto, grupo, unidade, data_vencimento";
                            }
                            else
                            {
                                if (xordenacao == "V")
                                {
                                    script = script + " order by data_vencimento";
                                }
                                else
                                {
                                    script = script + " order by data_pagamento";
                                }
                            }
                        }
                    }
                }
                else
                {
                    //Unidade específica
                    //Todas as Partes
                    if (xparte == string.Empty)
                    {
                        //Todas
                        if (xsituacaopgto == "T")
                        {
                            if (xcontacorrente != "0")
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                    " and Grupo = " + xgrupo +
                                    " and Unidade = " + xunidade +
                                    " and conta = " + xcontacorrente + " " +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                    " and ativa = 1 " +
                                    " and contabil = " + xcontabil;
                                if (xcarteira != String.Empty)
                                {
                                    if (xcarteira == "True")
                                    {
                                        script = script + " and " +
                                                          " carteira = 1 ";
                                    }
                                    else
                                    {
                                        script = script + " and " +
                                                          " carteira = 0 ";
                                    }
                                }
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                            else
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                    " and Grupo = " + xgrupo +
                                    " and Unidade = " + xunidade +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                    " and ativa = 1 " +
                                    " and contabil = " + xcontabil;
                                if (xcarteira != String.Empty)
                                {
                                    if (xcarteira == "True")
                                    {
                                        script = script + " and " +
                                                          " carteira = 1 ";
                                    }
                                    else
                                    {
                                        script = script + " and " +
                                                          " carteira = 0 ";
                                    }
                                }
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                        }
                        //Em Aberto
                        if (xsituacaopgto == "A")
                        {
                            if (xcontacorrente != "0")
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " and vlr_pagamento = 0 " +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and ativa = 1 " +
                                         " and contabil = " + xcontabil +
                                         " and conta = " + xcontacorrente + " ";
                                if (xcarteira != String.Empty)
                                {
                                    if (xcarteira == "True")
                                    {
                                        script = script + " and " +
                                                          " carteira = 1 ";
                                    }
                                    else
                                    {
                                        script = script + " and " +
                                                          " carteira = 0 ";
                                    }
                                }
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                            else
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " and vlr_pagamento = 0 " +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and ativa = 1 " +
                                         " and contabil = " + xcontabil;
                                if (xcarteira != String.Empty)
                                {
                                    if (xcarteira == "True")
                                    {
                                        script = script + " and " +
                                                          " carteira = 1 ";
                                    }
                                    else
                                    {
                                        script = script + " and " +
                                                          " carteira = 0 ";
                                    }
                                }
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                        }
                        //Em Aberto Atrazadas
                        if (xsituacaopgto == "A2")
                        {
                            if (xcontacorrente != "0")
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                         " and vlr_pagamento = 0 " +
                                         " and ativa = 1 " +
                                         " and contabil = " + xcontabil +
                                         " and conta = " + xcontacorrente + " ";
                                if (xcarteira != String.Empty)
                                {
                                    if (xcarteira == "True")
                                    {
                                        script = script + " and " +
                                                          " carteira = 1 ";
                                    }
                                    else
                                    {
                                        script = script + " and " +
                                                          " carteira = 0 ";
                                    }
                                }
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                            else
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                         " and vlr_pagamento = 0 " +
                                         " and ativa = 1 " +
                                         " and contabil = " + xcontabil;
                                if (xcarteira != String.Empty)
                                {
                                    if (xcarteira == "True")
                                    {
                                        script = script + " and " +
                                                          " carteira = 1 ";
                                    }
                                    else
                                    {
                                        script = script + " and " +
                                                          " carteira = 0 ";
                                    }
                                }
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                        }
                        //
                        //Em Aberto Antecipadas
                        if (xsituacaopgto == "A3")
                        {
                            if (xcontacorrente != "0")
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                         " and vlr_pagamento = 0 " +
                                         " and ativa = 1 " +
                                         " and contabil = " + xcontabil +
                                         " and conta = " + xcontacorrente + " ";
                                if (xcarteira != String.Empty)
                                {
                                    if (xcarteira == "True")
                                    {
                                        script = script + " and " +
                                                          " carteira = 1 ";
                                    }
                                    else
                                    {
                                        script = script + " and " +
                                                          " carteira = 0 ";
                                    }
                                }
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                            else
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) +
                                         " and vlr_pagamento = 0 " +
                                         " and ativa = 1 " +
                                         " and contabil = " + xcontabil;
                                if (xcarteira != String.Empty)
                                {
                                    if (xcarteira == "True")
                                    {
                                        script = script + " and " +
                                                          " carteira = 1 ";
                                    }
                                    else
                                    {
                                        script = script + " and " +
                                                          " carteira = 0 ";
                                    }
                                }
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                        }
                        //
                        //Pagas
                        if (xsituacaopgto == "P")
                        {
                            if (xcontacorrente != "0")
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and (data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " and vlr_pagamento <> 0) " +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and ativa = 1 " +
                                         " and contabil = " + xcontabil +
                                         " and conta = " + xcontacorrente + " ";
                                if (xcarteira != String.Empty)
                                {
                                    if (xcarteira == "True")
                                    {
                                        script = script + " and " +
                                                          " carteira = 1 ";
                                    }
                                    else
                                    {
                                        script = script + " and " +
                                                          " carteira = 0 ";
                                    }
                                }
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                            else
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                         " and Grupo = " + xgrupo +
                                         " and Unidade = " + xunidade +
                                         " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                         " or vlr_pagamento <> 0 " +
                                         " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                         " and ativa = 1 " +
                                         " and contabil = " + xcontabil;
                                if (xcarteira != String.Empty)
                                {
                                    if (xcarteira == "True")
                                    {
                                        script = script + " and " +
                                                          " carteira = 1 ";
                                    }
                                    else
                                    {
                                        script = script + " and " +
                                                          " carteira = 0 ";
                                    }
                                }
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        //Parte Específica
                        //Todas
                        if (xsituacaopgto == "T")
                        {
                            if (xcontacorrente != "0")
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                    " and Grupo = " + xgrupo +
                                    " and Unidade = " + xunidade +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                    " and ativa = 1 " +
                                    " and contabil = " + xcontabil;
                                if (xcarteira != String.Empty)
                                {
                                    if (xcarteira == "True")
                                    {
                                        script = script + " and " +
                                                          " carteira = 1 ";
                                    }
                                    else
                                    {
                                        script = script + " and " +
                                                          " carteira = 0 ";
                                    }
                                }
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                //Unidade Total
                                if (xparte == "0")
                                {
                                    script = script +
                                        " and Parte = " + xparte;
                                }
                                else
                                {
                                    if (xparte == "1")
                                    {
                                        if (xmeiolote == "1")
                                        {
                                            //Meio Lote 1
                                            script = script +
                                                " and Parte = " + xparte;
                                        }
                                        else
                                        {
                                            //Meio Lote 2
                                            script = script +
                                                " and Parte = 2 ";
                                        }
                                    }
                                }
                                //
                                script = script +
                                    " and conta = " + xcontacorrente + " ";
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                            else
                            {
                                script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                    " and Grupo = " + xgrupo +
                                    " and Unidade = " + xunidade +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                    " and ativa = 1 " +
                                    " and contabil = " + xcontabil;
                                if (xcarteira != String.Empty)
                                {
                                    if (xcarteira == "True")
                                    {
                                        script = script + " and " +
                                                          " carteira = 1 ";
                                    }
                                    else
                                    {
                                        script = script + " and " +
                                                          " carteira = 0 ";
                                    }
                                }
                                if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                {
                                    script = script + " and " +
                                                      " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                }
                                //Unidade Total
                                if (xparte == "0")
                                {
                                    script = script +
                                        " and Parte = " + xparte;
                                }
                                else
                                {
                                    if (xparte == "1")
                                    {
                                        if (xmeiolote == "1")
                                        {
                                            //Meio Lote 1
                                            script = script +
                                                " and Parte = " + xparte;
                                        }
                                        else
                                        {
                                            //Meio Lote 2
                                            script = script +
                                                " and Parte = 2 ";
                                        }
                                    }
                                }
                                if (xordenacao == "N")
                                {
                                    script = script + " order by produto, grupo, unidade, data_vencimento";
                                }
                                else
                                {
                                    if (xordenacao == "V")
                                    {
                                        script = script + " order by data_vencimento";
                                    }
                                    else
                                    {
                                        script = script + " order by data_pagamento";
                                    }
                                }
                            }
                        }
                        //Parte 0 ou 1
                        if ((xparte == "0") || (xparte == "1"))
                        {
                            //Todas
                            if (xsituacaopgto == "T")
                            {
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and conta = " + xcontacorrente + " ";
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //Em Aberto
                            if (xsituacaopgto == "A")
                            {
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil +
                                        " and conta = " + xcontacorrente + " ";
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                    " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                    " and vlr_pagamento = 0 " +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                    " and ativa = 1 " +
                                    " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //Em Aberto Atrasadas
                            if (xsituacaopgto == "A2")
                            {
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil +
                                        " and conta = " + xcontacorrente + " " +
                                        " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                    " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                    " and vlr_pagamento = 0 " +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                    " and ativa = 1 " +
                                    " and contabil = " + xcontabil +
                                    " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //Em Aberto A Vencer
                            if (xsituacaopgto == "A3")
                            {
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil +
                                        " and conta = " + xcontacorrente + " " +
                                        " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                    " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                    " and vlr_pagamento = 0 " +
                                    " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                    " and ativa = 1 " +
                                    " and contabil = " + xcontabil +
                                    " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //
                            //Pagas
                            if (xsituacaopgto == "P")
                            {
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        //" or vlr_pagamento <> 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil +
                                        " and conta = " + xcontacorrente + " ";
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //" or vlr_pagamento <> 0 ";
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            //Parte = 2
                            if (xsituacaopgto == "T")
                            {
                                //Todas
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and conta = " + xcontacorrente + " " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //
                            //Em Aberto
                            if (xsituacaopgto == "A")
                            {
                                //Em Aberto
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil +
                                        " and conta = " + xcontacorrente + " ";
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //Em Aberto atrasado
                            if (xsituacaopgto == "A2")
                            {
                                //Em Aberto
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil +
                                        " and conta = " + xcontacorrente + " " +
                                        " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil +
                                        " and data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //Em Aberto a vencer
                            if (xsituacaopgto == "A3")
                            {
                                //Em Aberto
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and conta = " + xcontacorrente + " " +
                                        " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        " and vlr_pagamento = 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil +
                                        " and data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(DateTime.Today.ToString().Substring(0, 10))) + " ";
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                            //
                            //
                            //Pago
                            if (xsituacaopgto == "P")
                            {
                                //Pagas
                                if (xcontacorrente != "0")
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        //" or vlr_pagamento <> 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil +
                                        " and conta = " + xcontacorrente + " ";
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                                else
                                {
                                    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) WHERE Produto = " + xproduto +
                                        " and Grupo = " + xgrupo +
                                        " and Unidade = " + xunidade +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    //Unidade Total
                                    if (xparte == "0")
                                    {
                                        script = script +
                                            " and Parte = " + xparte;
                                    }
                                    else
                                    {
                                        if (xparte == "1")
                                        {
                                            if (xmeiolote == "1")
                                            {
                                                //Meio Lote 1
                                                script = script +
                                                    " and Parte = " + xparte;
                                            }
                                            else
                                            {
                                                //Meio Lote 2
                                                script = script +
                                                    " and Parte = 2 ";
                                            }
                                        }
                                    }
                                    //
                                    script = script +
                                        " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                                        //" or vlr_pagamento <> 0 " +
                                        " and (data_vencimento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + " ) " +
                                        " and ativa = 1 " +
                                        " and contabil = " + xcontabil;
                                    if (xcarteira != String.Empty)
                                    {
                                        if (xcarteira == "True")
                                        {
                                            script = script + " and " +
                                                              " carteira = 1 ";
                                        }
                                        else
                                        {
                                            script = script + " and " +
                                                              " carteira = 0 ";
                                        }
                                    }
                                    if (xcorrecao && ((SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NAO") || (SreDblib.GetParametro("CORRIGE PARCELA IPTU") == "NÃO")))
                                    {
                                        script = script + " and " +
                                                          " tipo <> " + Srelib.QStr("IPTU") + "  ";
                                    }
                                    if (xordenacao == "N")
                                    {
                                        script = script + " order by produto, grupo, unidade, data_vencimento";
                                    }
                                    else
                                    {
                                        if (xordenacao == "V")
                                        {
                                            script = script + " order by data_vencimento";
                                        }
                                        else
                                        {
                                            script = script + " order by data_pagamento";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        return SreDblib.GetDsScript(script);

    }

    public static DataSet PegaDadosParcelasCarteira(string xproduto,
                                                    string xgrupo,
                                                    string xData1,
                                                    string xData2)
    {
        //Produto não pode ser vazio
        //Grupo Vazio = todos
        String script = "";
        string nomearquivo = "";
        //
        string titqtd = "0";
        string titpgqtd = "0";
        string titdevqtd = "0";
        string titcarteirapgqtd = "0";
        string titcarteiradevqtd = "0";
        string titbanpgqtd = "0";
        string titbandevqtd = "0";
        string titprotestoqtd = "0";
        string titvlr = "0";
        string titpgvlr = "0";
        string titdevvlr = "0";
        string titcarteirapgvlr = "0";
        string titcarteiradevvlr = "0";
        string titbanpgvlr = "0";
        string titbandevvlr = "0";
        string titprotestovlr = "0";
        //
        string aux = "0";
        //

        if (xgrupo != string.Empty)
        {
            nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);

            script = " " +
            " (SELECT COUNT(ID) AS titqtd " +
            " 	   FROM " + nomearquivo + " WITH(NOLOCK)  " +
            " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " AND ativa = 1 )  ";
            //
            titqtd = SreDblib.GetCampoScript(script);
            //
            script = " " +
            " (SELECT COUNT(ID) AS titpgqtd " +
            " 	   FROM " + nomearquivo + " WITH(NOLOCK)  " +
            " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " and (vlr_pagamento <> 0 and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
            " AND ativa = 1 )  ";
            //
            titpgqtd = SreDblib.GetCampoScript(script);
            //
            script = " " +
            " (SELECT COUNT(ID) AS titdevqtd " +
            " 	   FROM " + nomearquivo + " WITH(NOLOCK)  " +
            " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " and (vlr_pagamento = 0 and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
            " AND ativa = 1 )  ";
            //
            titdevqtd = SreDblib.GetCampoScript(script);
            //
            script = " " +
            " (SELECT COUNT(ID) AS titcarteirapgqtd " +
            " 	   FROM " + nomearquivo + " WITH(NOLOCK)  " +
            " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " and (vlr_pagamento <> 0 and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
            " AND (origem_pagamento = 'B') " +
            " AND ativa = 1 )  ";
            //
            titcarteirapgqtd = SreDblib.GetCampoScript(script);
            //
            script = " " +
            " (SELECT COUNT(ID) AS titcarteiradevqtd " +
            " 	   FROM " + nomearquivo + " WITH(NOLOCK)  " +
            " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " and (vlr_pagamento = 0 and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
            " AND (origem_pagamento = 'B') " +
            " AND ativa = 1 )  ";
            //
            titcarteiradevqtd = SreDblib.GetCampoScript(script);
            //
            script = " " +
            " (SELECT COUNT(ID) AS titbanpgqtd " +
            " 	   FROM " + nomearquivo + " WITH(NOLOCK)  " +
            " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " and (vlr_pagamento <> 0 and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
            " AND (origem_pagamento <> 'B') " +
            " AND ativa = 1 )  ";
            //
            titbanpgqtd = SreDblib.GetCampoScript(script);
            //
            script = " " +
            " (SELECT COUNT(ID) AS titbandevqtd " +
            " 	   FROM " + nomearquivo + " WITH(NOLOCK)  " +
            " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " and (vlr_pagamento = 0 and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
            " AND (origem_pagamento <> 'B') " +
            " AND ativa = 1 )  ";
            //
            titbandevqtd = SreDblib.GetCampoScript(script);
            //
            script = " " +
            " (SELECT COUNT(ID) AS titprotestoqtd " +
            " 	   FROM " + nomearquivo + " WITH(NOLOCK)  " +
            " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " and (vlr_pagamento <> 0 and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
            " AND (protesto = 1) " +
            " AND ativa = 1 )  ";
            //
            titprotestoqtd = SreDblib.GetCampoScript(script);
            //
            script = " " +
            " (SELECT SUM(vlr_parcela) AS titvlr " +
            " 	   FROM " + nomearquivo + " WITH(NOLOCK)  " +
            " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " AND ativa = 1 )  ";
            //
            titvlr = SreDblib.GetCampoScript(script);
            //
            script = " " +
            " (SELECT ISNULL(SUM(vlr_parcela),0) AS titpgvlr " +
            " 	   FROM " + nomearquivo + " WITH(NOLOCK)  " +
            " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " and (vlr_pagamento <> 0 and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
            " AND ativa = 1 )  ";
            //
            titpgvlr = SreDblib.GetCampoScript(script);
            //
            script = " " +
            " (SELECT ISNULL(SUM(vlr_parcela),0) AS titdevvlr " +
            " 	   FROM " + nomearquivo + " WITH(NOLOCK)  " +
            " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " and (vlr_pagamento = 0 and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
            " AND ativa = 1 )  ";
            //
            titdevvlr = SreDblib.GetCampoScript(script);
            //
            script = " " +
            " (SELECT ISNULL(SUM(vlr_parcela),0) AS titcarteirapgvlr " +
            " 	   FROM " + nomearquivo + " WITH(NOLOCK)  " +
            " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " and (vlr_pagamento <> 0 and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
            " AND (origem_pagamento = 'B') " +
            " AND ativa = 1 )  ";
            //
            titcarteirapgvlr = SreDblib.GetCampoScript(script);
            //
            script = " " +
            " (SELECT ISNULL(SUM(vlr_parcela),0) AS titcarteiradevvlr " +
            " 	   FROM " + nomearquivo + " WITH(NOLOCK)  " +
            " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " and (vlr_pagamento = 0 and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
            " AND (origem_pagamento = 'B') " +
            " AND ativa = 1 ) ";
            //
            titcarteiradevvlr = SreDblib.GetCampoScript(script);
            //
            script = " " +
            " (SELECT ISNULL(SUM(vlr_parcela),0) AS titbanpgvlr " +
            " 	   FROM " + nomearquivo + " WITH(NOLOCK)  " +
            " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " and (vlr_pagamento <> 0 and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
            " AND (origem_pagamento <> 'B') " +
            " AND ativa = 1 ) ";
            //
            titbanpgvlr = SreDblib.GetCampoScript(script);
            //
            script = " " +
            " (SELECT ISNULL(SUM(vlr_parcela),0) AS titbandevvlr " +
            " 	   FROM " + nomearquivo + " WITH(NOLOCK)  " +
            " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " and (vlr_pagamento = 0 and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
            " AND (origem_pagamento <> 'B') " +
            " AND ativa = 1 )  ";
            //
            titbandevvlr = SreDblib.GetCampoScript(script);
            //
            script = " " +
            " (SELECT ISNULL(SUM(vlr_parcela),0) AS titprotestovlr " +
            " 	   FROM " + nomearquivo + " WITH(NOLOCK)  " +
            " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " and (vlr_pagamento <> 0 and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
            " AND (protesto = 1) " +
            " AND ativa = 1 )  ";
            //
            titprotestovlr = SreDblib.GetCampoScript(script);
            //
        }
        else
        {
            DataSet ds0 = uProduto.PegaDadosProdutoGrupo(Convert.ToInt32(xproduto), "1");
            string yproduto = "";
            string ygrupo = "";

            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["produto"].ToString() != String.Empty)
                {
                    // Produtos
                    yproduto = ds0.Tables[0].Rows[row]["produto"].ToString().Trim();
                    ygrupo = ds0.Tables[0].Rows[row]["grupo"].ToString().Trim();


                    if (xproduto != String.Empty)
                    {
                        //Totalização dos Grupos
                        nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(ygrupo.Trim(), 5);

                        script = " " +
                        " (SELECT COUNT(ID) AS titqtd " +
                        " 	   FROM " + nomearquivo + " WITH(NOLOCK)  " +
                        " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " AND ativa = 1 )  ";
                        //
                        aux = "";
                        aux = SreDblib.GetCampoScript(script).Trim();
                        titqtd = Convert.ToString(Convert.ToInt32(titqtd) + Convert.ToInt32(aux));
                        //
                        script = " " +
                        " (SELECT COUNT(ID) AS titpgqtd " +
                        " 	   FROM " + nomearquivo + " WITH(NOLOCK)  " +
                        " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " and (vlr_pagamento <> 0 and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
                        " AND ativa = 1 )  ";
                        //

                        titpgqtd = Convert.ToString(Convert.ToInt32(titpgqtd) + Convert.ToInt32(SreDblib.GetCampoScript(script))).Trim();
                        //
                        script = " " +
                        " (SELECT COUNT(ID) AS titdevqtd " +
                        " 	   FROM " + nomearquivo + " WITH(NOLOCK)  " +
                        " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " and (vlr_pagamento = 0 and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
                        " AND ativa = 1 )  ";
                        //
                        titdevqtd = Convert.ToString(Convert.ToInt32(titdevqtd) + Convert.ToInt32(SreDblib.GetCampoScript(script))).Trim();
                        //
                        script = " " +
                        " (SELECT COUNT(ID) AS titcarteirapgqtd " +
                        " 	   FROM " + nomearquivo + " WITH(NOLOCK)  " +
                        " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " and (vlr_pagamento <> 0 and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
                        " AND (origem_pagamento = 'B') " +
                        " AND ativa = 1 )  ";
                        //
                        titcarteirapgqtd = Convert.ToString(Convert.ToInt32(titcarteirapgqtd) + Convert.ToInt32(SreDblib.GetCampoScript(script))).Trim();
                        //
                        script = " " +
                        " (SELECT COUNT(ID) AS titcarteiradevqtd " +
                        " FROM " + nomearquivo + " WITH(NOLOCK)  " +
                        " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " and (vlr_pagamento = 0 and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
                        " AND (origem_pagamento = 'B') " +
                        " AND ativa = 1 )  ";
                        //
                        titcarteiradevqtd = Convert.ToString(Convert.ToInt32(titcarteiradevqtd) + Convert.ToInt32(SreDblib.GetCampoScript(script))).Trim();
                        //
                        script = " " +
                        " (SELECT COUNT(ID) AS titbanpgqtd " +
                        " FROM " + nomearquivo + " WITH(NOLOCK)  " +
                        " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " and (vlr_pagamento <> 0 and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
                        " AND (origem_pagamento <> 'B') " +
                        " AND ativa = 1 )  ";
                        //
                        titbanpgqtd = Convert.ToString(Convert.ToInt32(titbanpgqtd) + Convert.ToInt32(SreDblib.GetCampoScript(script))).Trim();
                        //
                        script = " " +
                        " (SELECT COUNT(ID) AS titbandevqtd " +
                        " FROM " + nomearquivo + " WITH(NOLOCK)  " +
                        " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " and (vlr_pagamento = 0 and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
                        " AND (origem_pagamento <> 'B') " +
                        " AND ativa = 1 )  ";
                        //
                        titbandevqtd = Convert.ToString(Convert.ToInt32(titbandevqtd) + Convert.ToInt32(SreDblib.GetCampoScript(script))).Trim();
                        //
                        script = " " +
                        " (SELECT COUNT(ID) AS titprotestoqtd " +
                        " FROM " + nomearquivo + " WITH(NOLOCK)  " +
                        " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " and (vlr_pagamento <> 0 and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
                        " AND (protesto = 1) " +
                        " AND ativa = 1 )  ";
                        //
                        titprotestoqtd = Convert.ToString(Convert.ToInt32(titprotestoqtd) + Convert.ToInt32(SreDblib.GetCampoScript(script))).Trim();
                        //
                        script = " " +
                        " (SELECT SUM(vlr_parcela) AS titvlr " +
                        " FROM " + nomearquivo + " WITH(NOLOCK)  " +
                        " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " AND ativa = 1 )  ";
                        //
                        try
                        {
                            titvlr = Convert.ToString(Convert.ToDecimal(titvlr) + Convert.ToDecimal(SreDblib.GetCampoScript(script))).Trim();
                        }
                        catch (Exception)
                        {

                        }
                        //
                        script = " " +
                        " (SELECT ISNULL(SUM(vlr_parcela),0) AS titpgvlr " +
                        " FROM " + nomearquivo + " WITH(NOLOCK)  " +
                        " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " and (vlr_pagamento <> 0 and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
                        " AND ativa = 1 )  ";
                        //
                        titpgvlr = Convert.ToString(Convert.ToDecimal(titpgvlr) + Convert.ToDecimal(SreDblib.GetCampoScript(script))).Trim();
                        //
                        script = " " +
                        " (SELECT ISNULL(SUM(vlr_parcela),0) AS titdevvlr " +
                        " FROM " + nomearquivo + " WITH(NOLOCK)  " +
                        " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " and (vlr_pagamento = 0 and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
                        " AND ativa = 1 )  ";
                        //
                        titdevvlr = Convert.ToString(Convert.ToDecimal(titdevvlr) + Convert.ToDecimal(SreDblib.GetCampoScript(script))).Trim();
                        //
                        script = " " +
                        " (SELECT ISNULL(SUM(vlr_parcela),0) AS titcarteirapgvlr " +
                        " FROM " + nomearquivo + " WITH(NOLOCK)  " +
                        " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " and (vlr_pagamento <> 0 and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
                        " AND (origem_pagamento = 'B') " +
                        " AND ativa = 1 )  ";
                        //
                        titcarteirapgvlr = Convert.ToString(Convert.ToDecimal(titcarteirapgvlr) + Convert.ToDecimal(SreDblib.GetCampoScript(script))).Trim();
                        //
                        script = " " +
                        " (SELECT ISNULL(SUM(vlr_parcela),0) AS titcarteiradevvlr " +
                        " FROM " + nomearquivo + " WITH(NOLOCK)  " +
                        " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " and (vlr_pagamento = 0 and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
                        " AND (origem_pagamento = 'B') " +
                        " AND ativa = 1 ) ";
                        //
                        titcarteiradevvlr = Convert.ToString(Convert.ToDecimal(titcarteiradevvlr) + Convert.ToDecimal(SreDblib.GetCampoScript(script))).Trim();
                        //
                        script = " " +
                        " (SELECT ISNULL(SUM(vlr_parcela),0) AS titbanpgvlr " +
                        " FROM " + nomearquivo + " WITH(NOLOCK)  " +
                        " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " and (vlr_pagamento <> 0 and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
                        " AND (origem_pagamento <> 'B') " +
                        " AND ativa = 1 ) ";
                        //
                        titbanpgvlr = Convert.ToString(Convert.ToDecimal(titbanpgvlr) + Convert.ToDecimal(SreDblib.GetCampoScript(script))).Trim();
                        //
                        script = " " +
                        " (SELECT ISNULL(SUM(vlr_parcela),0) AS titbandevvlr " +
                        " FROM " + nomearquivo + " WITH(NOLOCK)  " +
                        " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " and (vlr_pagamento = 0 and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
                        " AND (origem_pagamento <> 'B') " +
                        " AND ativa = 1 )  ";
                        //
                        titbandevvlr = Convert.ToString(Convert.ToDecimal(titbandevvlr) + Convert.ToDecimal(SreDblib.GetCampoScript(script))).Trim();
                        //
                        script = " " +
                        " (SELECT ISNULL(SUM(vlr_parcela),0) AS titprotestovlr " +
                        " FROM " + nomearquivo + " WITH(NOLOCK)  " +
                        " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                        " and (vlr_pagamento <> 0 and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
                        " AND (protesto = 1) " +
                        " AND ativa = 1 )  ";
                        //
                        titprotestovlr = Convert.ToString(Convert.ToDecimal(titprotestovlr) + Convert.ToDecimal(SreDblib.GetCampoScript(script))).Trim();
                        //


                        //Fim da Totalização dos Grupos
                    }

                    yproduto = "";
                    ygrupo = "";

                }

            }

        }

        //
        DataTable table1 = new DataTable("table1");
        table1.Columns.Add("titulosqtd");
        table1.Columns.Add("titulospagosqtd");
        table1.Columns.Add("titulosdevidosqtd");
        table1.Columns.Add("tituloscarteirapagosqtd");
        table1.Columns.Add("tituloscarteiradevidosqtd");
        table1.Columns.Add("titulosbancariapagosqtd");
        table1.Columns.Add("titulosbancariadevidosqtd");
        table1.Columns.Add("titulosprotestoqtd");
        table1.Columns.Add("titulosvlr");
        table1.Columns.Add("titulospagosvlr");
        table1.Columns.Add("titulosdevidosvlr");
        table1.Columns.Add("tituloscarteirapagosvlr");
        table1.Columns.Add("tituloscarteiradevidosvlr");
        table1.Columns.Add("titulosbancariapagosvlr");
        table1.Columns.Add("titulosbancariadevidosvlr");
        table1.Columns.Add("titulosprotestovlr");
        //
        table1.Rows.Add(titqtd,
        titpgqtd,
        titdevqtd,
        titcarteirapgqtd,
        titcarteiradevqtd,
        titbanpgqtd,
        titbandevqtd,
        titprotestoqtd,
        titvlr,
        titpgvlr,
        titdevvlr,
        titcarteirapgvlr,
        titcarteiradevvlr,
        titbanpgvlr,
        titbandevvlr,
        titprotestovlr);
        //
        DataSet ds = new DataSet("table");
        ds.Tables.Add(table1);

        return ds;

    }

    public static DataSet PegaDadosParcelasContabil(string xproduto,
                                                    string xgrupo,
                                                    string xunidade,
                                                    string xparte,
                                                    string xproprietario,
                                                    string xData1,
                                                    string xData2,
                                                    string xcontacorrente)
    {
        //Produto não pode ser vazio
        //Grupo Vazio = todos
        //Unidade Vazio = todos
        String script = "";
        string nomearquivo = "";
        //
        string produto = "0";
        string grupo = "0";
        string unidade = "0";
        string parte = "0";
        string conta = "0";
        string parcela = "0";
        string tipo = "0";
        string data_vencimento = "0";
        string vlr_parcela = "0";
        string data_pagamento = "0";
        string vlr_pagamento = "0";
        string vlr_multa = "0";
        string vlr_comissao = "0";
        string vlr_desconto = "0";
        string origem_pagamento = "0";
        string observacao = "0";
        string nossonumero = "0";
        //
        DataSet dsgrupo;
        //
        DataTable table1 = new DataTable("table1");
        table1.Columns.Add("produto");
        table1.Columns.Add("grupo");
        table1.Columns.Add("unidade");
        table1.Columns.Add("parte");
        table1.Columns.Add("conta");
        table1.Columns.Add("parcela");
        table1.Columns.Add("tipo");
        table1.Columns.Add("data_vencimento", typeof(DateTime));
        table1.Columns.Add("vlr_parcela");
        table1.Columns.Add("data_pagamento", typeof(DateTime));
        table1.Columns.Add("vlr_pagamento");
        table1.Columns.Add("vlr_multa");
        table1.Columns.Add("vlr_comissao");
        table1.Columns.Add("vlr_desconto");
        table1.Columns.Add("origem_pagamento");
        table1.Columns.Add("observacao");
        table1.Columns.Add("nossonumero");
        table1.Columns.Add("identificador");
        //

        if (xgrupo != string.Empty)
        {
            nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);
            //
            script = " " +
            " SELECT *   FROM " + nomearquivo + " WITH(NOLOCK)  " +
            " WHERE (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
            " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " and (vlr_pagamento <> 0 and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
            " and Grupo = " + xgrupo;
            //
            if (xunidade != string.Empty)
            {
                script = script +
                " and Unidade = " + xunidade;
                //
                if (xparte == "0")
                {
                    script = script +
                    " and Parte = " + xparte;
                }
                else
                    if (xproprietario == "1")
                {
                    script = script +
                    " and Parte = 1 ";
                }
                else
                {
                    script = script +
                    " and Parte = 2 ";
                }
            }
            if (xcontacorrente != "0")
            {
                script = script +
                " and conta = " + xcontacorrente + " ";
            }
            script = script +
            " order by produto, grupo, unidade, parte, data_pagamento ";
            //
            dsgrupo = SreDblib.GetDsScript(script);
            //
            for (int i = 0; i <= dsgrupo.Tables[0].Rows.Count - 1; i++)
            {
                //
                produto = dsgrupo.Tables[0].Rows[i]["produto"].ToString().Trim();
                grupo = dsgrupo.Tables[0].Rows[i]["grupo"].ToString().Trim();
                unidade = dsgrupo.Tables[0].Rows[i]["unidade"].ToString().Trim();
                parte = dsgrupo.Tables[0].Rows[i]["parte"].ToString().Trim();
                conta = dsgrupo.Tables[0].Rows[i]["conta"].ToString().Trim();
                if (conta == string.Empty)
                {
                    conta = "0";
                }
                parcela = dsgrupo.Tables[0].Rows[i]["parcela"].ToString().Trim();
                tipo = dsgrupo.Tables[0].Rows[i]["tipo"].ToString().Trim();
                data_vencimento = dsgrupo.Tables[0].Rows[i]["data_vencimento"].ToString().Trim();
                vlr_parcela = dsgrupo.Tables[0].Rows[i]["vlr_parcela"].ToString().Trim();
                data_pagamento = dsgrupo.Tables[0].Rows[i]["data_pagamento"].ToString().Trim();
                vlr_pagamento = dsgrupo.Tables[0].Rows[i]["vlr_pagamento"].ToString().Trim();
                vlr_multa = dsgrupo.Tables[0].Rows[i]["vlr_multa"].ToString().Trim();
                vlr_comissao = dsgrupo.Tables[0].Rows[i]["vlr_comissao"].ToString().Trim();
                vlr_desconto = dsgrupo.Tables[0].Rows[i]["vlr_desconto"].ToString().Trim();
                origem_pagamento = dsgrupo.Tables[0].Rows[i]["origem_pagamento"].ToString().Trim();
                observacao = dsgrupo.Tables[0].Rows[i]["observacao"].ToString().Trim();
                nossonumero = dsgrupo.Tables[0].Rows[i]["nossonumero"].ToString().Trim();
                //
                table1.Rows.Add(produto,
                                grupo,
                                unidade,
                                parte,
                                conta,
                                parcela,
                                tipo,
                                data_vencimento,
                                vlr_parcela,
                                data_pagamento,
                                vlr_pagamento,
                                vlr_multa,
                                vlr_comissao,
                                vlr_desconto,
                                origem_pagamento,
                                observacao,
                                nossonumero);
            }
            //
            //
        }
        else
        {
            DataSet ds0 = uProduto.PegaDadosProdutoGrupo(Convert.ToInt32(xproduto), "1");
            string yproduto = "";
            string ygrupo = "";

            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                // Produtos
                yproduto = ds0.Tables[0].Rows[row]["produto"].ToString().Trim();
                ygrupo = ds0.Tables[0].Rows[row]["grupo"].ToString().Trim();
                //
                nomearquivo = "parcelas_" + Srelib.QStr0(yproduto.Trim(), 5) + "_" + Srelib.QStr0(ygrupo.Trim(), 5);

                script = " " +
                " SELECT *   FROM " + nomearquivo + " WITH(NOLOCK)  " +
                " WHERE (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                " and (vlr_pagamento <> 0 and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
                if (xcontacorrente != "0")
                {
                    script = script +
                    " and conta = " + xcontacorrente + " ";
                }
                script = script +
                " order by produto, grupo, unidade, parte, data_pagamento ";
                //
                dsgrupo = SreDblib.GetDsScript(script);
                //
                for (int i = 0; i <= dsgrupo.Tables[0].Rows.Count - 1; i++)
                {
                    //
                    produto = dsgrupo.Tables[0].Rows[i]["produto"].ToString().Trim();
                    grupo = dsgrupo.Tables[0].Rows[i]["grupo"].ToString().Trim();
                    unidade = dsgrupo.Tables[0].Rows[i]["unidade"].ToString().Trim();
                    parte = dsgrupo.Tables[0].Rows[i]["parte"].ToString().Trim();
                    conta = dsgrupo.Tables[0].Rows[i]["conta"].ToString().Trim();
                    if (conta == string.Empty)
                    {
                        conta = "0";
                    }
                    parcela = dsgrupo.Tables[0].Rows[i]["parcela"].ToString().Trim();
                    tipo = dsgrupo.Tables[0].Rows[i]["tipo"].ToString().Trim();
                    data_vencimento = dsgrupo.Tables[0].Rows[i]["data_vencimento"].ToString().Trim();
                    vlr_parcela = dsgrupo.Tables[0].Rows[i]["vlr_parcela"].ToString().Trim();
                    data_pagamento = dsgrupo.Tables[0].Rows[i]["data_pagamento"].ToString().Trim();
                    vlr_pagamento = dsgrupo.Tables[0].Rows[i]["vlr_pagamento"].ToString().Trim();
                    vlr_multa = dsgrupo.Tables[0].Rows[i]["vlr_multa"].ToString().Trim();
                    vlr_comissao = dsgrupo.Tables[0].Rows[i]["vlr_comissao"].ToString().Trim();
                    vlr_desconto = dsgrupo.Tables[0].Rows[i]["vlr_desconto"].ToString().Trim();
                    origem_pagamento = dsgrupo.Tables[0].Rows[i]["origem_pagamento"].ToString().Trim();
                    observacao = dsgrupo.Tables[0].Rows[i]["observacao"].ToString().Trim();
                    nossonumero = dsgrupo.Tables[0].Rows[i]["nossonumero"].ToString().Trim();
                    //
                    table1.Rows.Add(produto,
                                    grupo,
                                    unidade,
                                    parte,
                                    conta,
                                    parcela,
                                    tipo,
                                    data_vencimento,
                                    vlr_parcela,
                                    data_pagamento,
                                    vlr_pagamento,
                                    vlr_multa,
                                    vlr_comissao,
                                    vlr_desconto,
                                    origem_pagamento,
                                    observacao,
                                    nossonumero);
                }
                //
                //                        
                //Fim da Totalização dos Grupos
                dsgrupo.Clear();
                yproduto = "";
                ygrupo = "";
            }

        }


        //
        //table1.AcceptChanges();
        //table1.DefaultView.Sort = "data_pagamento DESC";
        //
        //DataView dataview = table1.DefaultView;
        //dataview.Sort = "data_pagamento";
        //
        DataView dataview = new DataView(table1);
        dataview.Sort = "data_pagamento ASC";
        DataTable table2 = dataview.ToTable();
        //
        DataSet dsresult = new DataSet("table");
        dsresult.Tables.Add(table2);
        //dsresult.Tables[0].DefaultView.Sort = "data_pagamento, DESC";

        return dsresult;

    }

    public static DataSet PegaDadosParcelasPagamentos(string xproduto,
                                                     string xgrupo,
                                                     string xunidade,
                                                     string xparte,
                                                     string xproprietario,
                                                     string xData1,
                                                     string xData2,
                                                     string xcontacorrente,
                                                     string xrborigempagamento,
                                                     string xrbtipoparcela,
                                                     string xrbpagamentos,
                                                     string xrbordem,
                                                     string xckdesistentes,
                                                     string xcbcorretor)
    {
        //Produto não pode ser vazio
        //Grupo Vazio = todos
        //Unidade Vazio = todos
        String script = "";
        string nomearquivo = "";
        //
        string produto = "0";
        string grupo = "0";
        string unidade = "0";
        string parte = "0";
        string conta = "0";
        string parcela = "0";
        string tipo = "0";
        string data_vencimento = "0";
        string vlr_parcela = "0";
        string data_pagamento = "0";
        string vlr_pagamento = "0";
        string vlr_multa = "0";
        string vlr_desconto = "0";
        string origem_pagamento = "0";
        string observacao = "0";
        string nossonumero = "0";
        string identificador = "";
        string corretor = "";
        //
        DataSet dsgrupo;
        //
        DataTable table1 = new DataTable("table1");
        table1.Columns.Add("produto");
        table1.Columns.Add("grupo");
        table1.Columns.Add("unidade");
        table1.Columns.Add("parte");
        table1.Columns.Add("conta");
        table1.Columns.Add("parcela");
        table1.Columns.Add("tipo");
        table1.Columns.Add("data_vencimento", typeof(DateTime));
        table1.Columns.Add("vlr_parcela");
        table1.Columns.Add("data_pagamento", typeof(DateTime));
        table1.Columns.Add("vlr_pagamento");
        table1.Columns.Add("vlr_multa");
        table1.Columns.Add("vlr_desconto");
        table1.Columns.Add("origem_pagamento");
        table1.Columns.Add("observacao");
        table1.Columns.Add("nossonumero");
        table1.Columns.Add("identificador");
        table1.Columns.Add("corretor");
        //


        if (xgrupo != string.Empty)
        {
            nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);

            script = " " +
            " SELECT P.* " +
            ",(REPLICATE('0', 3 - LEN(P.produto)) + CAST(P.produto AS varchar) + " +
            "REPLICATE('0', 3 - LEN(P.grupo)) + CAST(P.grupo AS varchar) + " +
            "REPLICATE('0', 5 - LEN(P.unidade)) + CAST(P.unidade AS varchar) + " +
            "REPLICATE('0', 3 - LEN(P.parte)) + CAST(P.parte AS varchar)) identificador " +
            ",  V.corretor " +
            " FROM " + nomearquivo + " P , VENDAS V WITH(NOLOCK)  " +
            " WHERE " +
                " (P.produto = V.produto" +
                " and " +
                " P.grupo = V.grupo" +
                " and " +
                " P.unidade = V.unidade" +
                " and " +
                " P.parte = V.parte) " +
            " and (P.data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
            " and P.data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " and (P.vlr_pagamento <> 0 and P.data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
            " and P.Grupo = " + xgrupo;
            //
            if (xunidade != string.Empty)
            {
                script = script +
                " and P.Unidade = " + xunidade;
                //
                if (xparte == "0")
                {
                    script = script +
                    " and P.Parte = " + xparte;
                }
                else
                    if (xproprietario == "1")
                {
                    script = script +
                    " and P.Parte = 1 ";
                }
                else
                {
                    script = script +
                    " and P.Parte = 2 ";
                }
            }
            if (xcontacorrente != "0")
            {
                script = script +
                " and P.conta = " + xcontacorrente + " ";
            }
            //
            if (xrborigempagamento != "0")
            {
                if (xrborigempagamento == "1")
                {
                    script = script +
                    " and P.origem_pagamento <> " + Srelib.QStr("B") + " ";
                }
                else
                {
                    script = script +
                    " and P.origem_pagamento = " + Srelib.QStr("B") + " ";
                }
            }
            //
            if (xrbtipoparcela != "0")
            {
                if (xrbtipoparcela == "1")
                {
                    script = script +
                    " and Substring(P.tipo,1,1) = " + Srelib.QStr("S") + " ";
                }
                if (xrbtipoparcela == "2")
                {
                    script = script +
                    " and (Substring(P.tipo,1,1) = " + Srelib.QStr("N") + " " +
                    " OR Substring(P.tipo,1,1) = " + Srelib.QStr("R") + ") ";
                }
                if (xrbtipoparcela == "3")
                {
                    script = script +
                    " and Substring(P.tipo,1,1) = " + Srelib.QStr("I") + " ";
                }
            }
            //
            if (xrbpagamentos != "0")
            {
                if (xrbpagamentos == "1")
                {
                    //atrasados
                    script = script +
                    " and (P.data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + ") ";
                    //" and (P.data_pagamento > P.data_vencimento) ";
                }
                if (xrbpagamentos == "2")
                {
                    //antecipados
                    script = script +
                    " and (P.data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") ";
                    //" and (P.data_pagamento < P.data_vencimento) ";
                }
                if (xrbpagamentos == "3")
                {
                    //no mes
                    script = script +
                    " and (MONTH(P.data_pagamento) = MONTH(P.data_vencimento) " +
                    " and YEAR(P.data_pagamento) = YEAR(P.data_vencimento))";
                }
            }
            //
            if (xcbcorretor != string.Empty)
            {
                script = script +
                " and V.corretor = " + xcbcorretor + " ";
            }
            //

            //
            dsgrupo = SreDblib.GetDsScript(script);
            //
            for (int i = 0; i <= dsgrupo.Tables[0].Rows.Count - 1; i++)
            {
                //
                produto = dsgrupo.Tables[0].Rows[i]["produto"].ToString().Trim();
                grupo = dsgrupo.Tables[0].Rows[i]["grupo"].ToString().Trim();
                unidade = dsgrupo.Tables[0].Rows[i]["unidade"].ToString().Trim();
                parte = dsgrupo.Tables[0].Rows[i]["parte"].ToString().Trim();
                conta = dsgrupo.Tables[0].Rows[i]["conta"].ToString().Trim();
                if (conta == string.Empty)
                {
                    conta = "0";
                }
                parcela = dsgrupo.Tables[0].Rows[i]["parcela"].ToString().Trim();
                tipo = dsgrupo.Tables[0].Rows[i]["tipo"].ToString().Trim();
                data_vencimento = dsgrupo.Tables[0].Rows[i]["data_vencimento"].ToString().Trim();
                vlr_parcela = dsgrupo.Tables[0].Rows[i]["vlr_parcela"].ToString().Trim();
                data_pagamento = dsgrupo.Tables[0].Rows[i]["data_pagamento"].ToString().Trim();
                vlr_pagamento = dsgrupo.Tables[0].Rows[i]["vlr_pagamento"].ToString().Trim();
                vlr_multa = dsgrupo.Tables[0].Rows[i]["vlr_multa"].ToString().Trim();
                vlr_desconto = dsgrupo.Tables[0].Rows[i]["vlr_desconto"].ToString().Trim();
                origem_pagamento = dsgrupo.Tables[0].Rows[i]["origem_pagamento"].ToString().Trim();
                observacao = dsgrupo.Tables[0].Rows[i]["observacao"].ToString().Trim();
                nossonumero = dsgrupo.Tables[0].Rows[i]["nossonumero"].ToString().Trim();
                identificador = dsgrupo.Tables[0].Rows[i]["identificador"].ToString().Trim();
                corretor = dsgrupo.Tables[0].Rows[i]["corretor"].ToString().Trim();
                //
                table1.Rows.Add(produto,
                                grupo,
                                unidade,
                                parte,
                                conta,
                                parcela,
                                tipo,
                                data_vencimento,
                                vlr_parcela,
                                data_pagamento,
                                vlr_pagamento,
                                vlr_multa,
                                vlr_desconto,
                                origem_pagamento,
                                observacao,
                                nossonumero,
                                identificador,
                                corretor);
            }
            //
            //
        }
        else
        {
            DataSet ds0 = uProduto.PegaDadosProdutoGrupo(Convert.ToInt32(xproduto), "1");
            string yproduto = "";
            string ygrupo = "";

            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                // Produtos
                yproduto = ds0.Tables[0].Rows[row]["produto"].ToString().Trim();
                ygrupo = ds0.Tables[0].Rows[row]["grupo"].ToString().Trim();
                //
                nomearquivo = "parcelas_" + Srelib.QStr0(yproduto.Trim(), 5) + "_" + Srelib.QStr0(ygrupo.Trim(), 5);

                script = " " +
                " SELECT P.* " +
                ",(REPLICATE('0', 3 - LEN(P.produto)) + CAST(P.produto AS varchar) + " +
                "REPLICATE('0', 3 - LEN(P.grupo)) + CAST(P.grupo AS varchar) + " +
                "REPLICATE('0', 5 - LEN(P.unidade)) + CAST(P.unidade AS varchar) + " +
                "REPLICATE('0', 3 - LEN(P.parte)) + CAST(P.parte AS varchar)) identificador " +
                ",  V.corretor " +
                " FROM " + nomearquivo + " P , VENDAS V WITH(NOLOCK)  " +
                " WHERE " +
                " (P.produto = V.produto" +
                " and " +
                " P.grupo = V.grupo" +
                " and " +
                " P.unidade = V.unidade" +
                " and " +
                " P.parte = V.parte) " +
                " and (P.data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                " and P.data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                " and (P.vlr_pagamento <> 0 and P.data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
                if (xcontacorrente != "0")
                {
                    script = script +
                    " and P.conta = " + xcontacorrente + " ";
                }
                //
                if (xrborigempagamento != "0")
                {
                    if (xrborigempagamento == "1")
                    {
                        script = script +
                        " and P.origem_pagamento <> " + Srelib.QStr("B") + " ";
                    }
                    else
                    {
                        script = script +
                        " and P.origem_pagamento = " + Srelib.QStr("B") + " ";
                    }
                }
                //
                if (xrbtipoparcela != "0")
                {
                    if (xrbtipoparcela == "1")
                    {
                        script = script +
                        " and Substring(P.tipo,1,1) = " + Srelib.QStr("S") + " ";
                    }
                    if (xrbtipoparcela == "2")
                    {
                        script = script +
                        " and (Substring(P.tipo,1,1) = " + Srelib.QStr("N") + " " +
                        " OR Substring(P.tipo,1,1) = " + Srelib.QStr("R") + ") ";
                    }
                    if (xrbtipoparcela == "3")
                    {
                        script = script +
                        " and Substring(P.tipo,1,1) = " + Srelib.QStr("I") + " ";
                    }
                }
                //
                if (xrbpagamentos != "0")
                {
                    if (xrbpagamentos == "1")
                    {
                        //atrasados
                        script = script +
                        " and (P.data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + ") ";
                        //" and (P.data_pagamento > P.data_vencimento) ";
                    }
                    if (xrbpagamentos == "2")
                    {
                        //antecipados
                        script = script +
                        " and (P.data_vencimento > " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") ";
                        //" and (P.data_pagamento < P.data_vencimento) ";
                    }
                    if (xrbpagamentos == "3")
                    {
                        //no mes
                        script = script +
                        " and (MONTH(P.data_pagamento) = MONTH(P.data_vencimento) " +
                        " and YEAR(P.data_pagamento) = YEAR(P.data_vencimento))";
                    }
                }
                if (xcbcorretor != string.Empty)
                {
                    script = script +
                    " and V.corretor = " + xcbcorretor + " ";
                }
                //
                dsgrupo = SreDblib.GetDsScript(script);
                //
                for (int i = 0; i <= dsgrupo.Tables[0].Rows.Count - 1; i++)
                {
                    //
                    produto = dsgrupo.Tables[0].Rows[i]["produto"].ToString().Trim();
                    grupo = dsgrupo.Tables[0].Rows[i]["grupo"].ToString().Trim();
                    unidade = dsgrupo.Tables[0].Rows[i]["unidade"].ToString().Trim();
                    parte = dsgrupo.Tables[0].Rows[i]["parte"].ToString().Trim();
                    conta = dsgrupo.Tables[0].Rows[i]["conta"].ToString().Trim();
                    if (conta == string.Empty)
                    {
                        conta = "0";
                    }
                    parcela = dsgrupo.Tables[0].Rows[i]["parcela"].ToString().Trim();
                    tipo = dsgrupo.Tables[0].Rows[i]["tipo"].ToString().Trim();
                    data_vencimento = dsgrupo.Tables[0].Rows[i]["data_vencimento"].ToString().Trim();
                    vlr_parcela = dsgrupo.Tables[0].Rows[i]["vlr_parcela"].ToString().Trim();
                    data_pagamento = dsgrupo.Tables[0].Rows[i]["data_pagamento"].ToString().Trim();
                    vlr_pagamento = dsgrupo.Tables[0].Rows[i]["vlr_pagamento"].ToString().Trim();
                    vlr_multa = dsgrupo.Tables[0].Rows[i]["vlr_multa"].ToString().Trim();
                    vlr_desconto = dsgrupo.Tables[0].Rows[i]["vlr_desconto"].ToString().Trim();
                    origem_pagamento = dsgrupo.Tables[0].Rows[i]["origem_pagamento"].ToString().Trim();
                    observacao = dsgrupo.Tables[0].Rows[i]["observacao"].ToString().Trim();
                    nossonumero = dsgrupo.Tables[0].Rows[i]["nossonumero"].ToString().Trim();
                    identificador = dsgrupo.Tables[0].Rows[i]["identificador"].ToString().Trim();
                    corretor = dsgrupo.Tables[0].Rows[i]["corretor"].ToString().Trim();
                    //
                    table1.Rows.Add(produto,
                                    grupo,
                                    unidade,
                                    parte,
                                    parcela,
                                    conta,
                                    tipo,
                                    data_vencimento,
                                    vlr_parcela,
                                    data_pagamento,
                                    vlr_pagamento,
                                    vlr_multa,
                                    vlr_desconto,
                                    origem_pagamento,
                                    observacao,
                                    nossonumero,
                                    identificador,
                                    corretor);
                }
                //
                //                        
                //Fim da Totalização dos Grupos
                dsgrupo.Clear();
                yproduto = "";
                ygrupo = "";
            }

        }
        //
        //Desistentes
        if (Convert.ToBoolean(xckdesistentes))
        {
            // Produtos
            nomearquivo = "parcelas_renegociacao";

            script = " " +
            " SELECT P.* " +
            ",(REPLICATE('0', 3 - LEN(P.produto)) + CAST(P.produto AS varchar) + " +
            "REPLICATE('0', 3 - LEN(P.grupo)) + CAST(P.grupo AS varchar) + " +
            "REPLICATE('0', 5 - LEN(P.unidade)) + CAST(P.unidade AS varchar) + " +
            "REPLICATE('0', 3 - LEN(P.parte)) + CAST(P.parte AS varchar)) identificador " +
            ", " + Srelib.QStr("") + " corretor " +
            " FROM " + nomearquivo + " P  " +
            //
            //" FROM " + nomearquivo + " P , VENDAS V WITH(NOLOCK)  " +
            //
            " WHERE (P.data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
            " and P.data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " and (P.vlr_pagamento <> 0 and P.data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
            //
            if (xproduto != string.Empty)
            {
                script = script +
                " and P.Produto = " + xproduto;
            }
            if (xgrupo != string.Empty)
            {
                script = script +
                " and P.Grupo = " + xgrupo;
            }
            if (xunidade != string.Empty)
            {
                script = script +
                " and P.Unidade = " + xunidade +
                " and P.Parte = " + xparte;
            }
            //
            if (xcontacorrente != "0")
            {
                script = script +
                " and P.conta = " + xcontacorrente + " ";
            }
            //
            if (xrborigempagamento != "0")
            {
                if (xrborigempagamento == "1")
                {
                    script = script +
                    " and P.origem_pagamento <> " + Srelib.QStr("B") + " ";
                }
                else
                {
                    script = script +
                    " and P.origem_pagamento = " + Srelib.QStr("B") + " ";
                }
            }
            //
            if (xrbtipoparcela != "0")
            {
                if (xrbtipoparcela == "1")
                {
                    script = script +
                    " and Substring(P.tipo,1,1) = " + Srelib.QStr("S") + " ";
                }
                if (xrbtipoparcela == "2")
                {
                    script = script +
                    " and (Substring(P.tipo,1,1) = " + Srelib.QStr("N") + " " +
                    " OR Substring(P.tipo,1,1) = " + Srelib.QStr("R") + ") ";
                }
                if (xrbtipoparcela == "3")
                {
                    script = script +
                    " and Substring(P.tipo,1,1) = " + Srelib.QStr("I") + " ";
                }
            }
            //
            if (xrbpagamentos != "0")
            {
                if (xrbpagamentos == "1")
                {
                    //atrasados
                    script = script +
                    " and (P.data_pagamento > P.data_vencimento) ";
                }
                if (xrbpagamentos == "2")
                {
                    //antecipados
                    script = script +
                    " and (P.data_pagamento < P.data_vencimento) ";
                }
                if (xrbpagamentos == "3")
                {
                    //no mes
                    script = script +
                    " and (MONTH(P.data_pagamento) = MONTH(P.data_vencimento) " +
                    " and YEAR(P.data_pagamento) = YEAR(P.data_vencimento))";
                }
            }
            //if (corretor != string.Empty)
            //{
            //    script = script +
            //    " and corretor = " + corretor + " ";
            //}
            //
            dsgrupo = SreDblib.GetDsScript(script);
            //
            for (int i = 0; i <= dsgrupo.Tables[0].Rows.Count - 1; i++)
            {
                //
                produto = dsgrupo.Tables[0].Rows[i]["produto"].ToString().Trim();
                grupo = dsgrupo.Tables[0].Rows[i]["grupo"].ToString().Trim();
                unidade = dsgrupo.Tables[0].Rows[i]["unidade"].ToString().Trim();
                parte = dsgrupo.Tables[0].Rows[i]["parte"].ToString().Trim();
                conta = dsgrupo.Tables[0].Rows[i]["conta"].ToString().Trim();
                if (conta == string.Empty)
                {
                    conta = "0";
                }
                parcela = dsgrupo.Tables[0].Rows[i]["parcela"].ToString().Trim();
                tipo = dsgrupo.Tables[0].Rows[i]["tipo"].ToString().Trim();
                data_vencimento = dsgrupo.Tables[0].Rows[i]["data_vencimento"].ToString().Trim();
                vlr_parcela = dsgrupo.Tables[0].Rows[i]["vlr_parcela"].ToString().Trim();
                data_pagamento = dsgrupo.Tables[0].Rows[i]["data_pagamento"].ToString().Trim();
                vlr_pagamento = dsgrupo.Tables[0].Rows[i]["vlr_pagamento"].ToString().Trim();
                vlr_multa = dsgrupo.Tables[0].Rows[i]["vlr_multa"].ToString().Trim();
                vlr_desconto = dsgrupo.Tables[0].Rows[i]["vlr_desconto"].ToString().Trim();
                origem_pagamento = dsgrupo.Tables[0].Rows[i]["origem_pagamento"].ToString().Trim();
                observacao = dsgrupo.Tables[0].Rows[i]["observacao"].ToString().Trim();
                nossonumero = dsgrupo.Tables[0].Rows[i]["nossonumero"].ToString().Trim();
                identificador = dsgrupo.Tables[0].Rows[i]["identificador"].ToString().Trim();
                corretor = dsgrupo.Tables[0].Rows[i]["corretor"].ToString().Trim();
                //
                table1.Rows.Add(produto,
                                grupo,
                                unidade,
                                parte,
                                conta,
                                parcela,
                                tipo,
                                data_vencimento,
                                vlr_parcela,
                                data_pagamento,
                                vlr_pagamento,
                                vlr_multa,
                                vlr_desconto,
                                origem_pagamento,
                                observacao,
                                nossonumero,
                                identificador,
                                corretor);
            }

        }
        //
        DataView dataview = new DataView(table1);
        //
        if (xrbordem == "0")
        {
            dataview.Sort = "data_pagamento ASC";
        }
        if (xrbordem == "1")
        {
            dataview.Sort = "identificador ASC";
        }
        //
        DataTable table2 = dataview.ToTable();
        //
        DataSet dsresult = new DataSet("table");
        dsresult.Tables.Add(table2);
        //
        return dsresult;

    }

    public static DataSet PegaDadosParcelasDevedores(string xproduto,
                                                     string xgrupo,
                                                     string xunidade,
                                                     string xparte,
                                                     string xproprietario,
                                                     string xData1,
                                                     string xData2,
                                                     string xcontacorrente,
                                                     string xrbprotesto,
                                                     string xrbtipoparcela,
                                                     string xrbordem,
                                                     string xckdesistentes,
                                                     string xrbtipocobranca)
    {
        //Produto não pode ser vazio
        //Grupo Vazio = todos
        //Unidade Vazio = todos
        String script = "";
        string nomearquivo = "";
        //
        string produto = "0";
        string grupo = "0";
        string unidade = "0";
        string parte = "0";
        string conta = "0";
        string parcela = "0";
        string tipo = "0";
        string data_vencimento = "0";
        string vlr_parcela = "0";
        string data_pagamento = "0";
        string vlr_pagamento = "0";
        string protesto = "0";
        string ativa = "0";
        string origem_pagamento = "0";
        string observacao = "0";
        string nossonumero = "0";
        string identificador = "";
        string tx_comissao = "0";
        string tx_multa = "0";
        string periodicidade_comissao = "a.m.";
        string carteira = "0";
        //
        DataSet dsparcelas;
        //
        DataTable table1 = new DataTable("table1");
        table1.Columns.Add("produto");
        table1.Columns.Add("grupo");
        table1.Columns.Add("unidade");
        table1.Columns.Add("parte");
        table1.Columns.Add("conta");
        table1.Columns.Add("parcela");
        table1.Columns.Add("tipo");
        table1.Columns.Add("data_vencimento", typeof(DateTime));
        table1.Columns.Add("vlr_parcela");
        table1.Columns.Add("data_pagamento", typeof(DateTime));
        table1.Columns.Add("vlr_pagamento");
        table1.Columns.Add("protesto");
        table1.Columns.Add("ativa");
        table1.Columns.Add("origem_pagamento");
        table1.Columns.Add("observacao");
        table1.Columns.Add("nossonumero");
        table1.Columns.Add("identificador");
        table1.Columns.Add("tx_comissao");
        table1.Columns.Add("tx_multa");
        table1.Columns.Add("periodicidade_comissao");
        table1.Columns.Add("carteira");
        //


        if (xgrupo != string.Empty)
        {
            nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);

            script = " " +
            " SELECT * " +
            ",(REPLICATE('0', 3 - LEN(produto)) + CAST(produto AS varchar) + " +
            "REPLICATE('0', 3 - LEN(grupo)) + CAST(grupo AS varchar) + " +
            "REPLICATE('0', 5 - LEN(unidade)) + CAST(unidade AS varchar) + " +
            "REPLICATE('0', 3 - LEN(parte)) + CAST(parte AS varchar)) identificador " +
            " FROM " + nomearquivo + " WITH(NOLOCK)  " +
            " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
            " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " and (vlr_pagamento = 0 and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
            " and ativa = 1 " +
            " and Grupo = " + xgrupo;
            //
            if (xunidade != string.Empty)
            {
                script = script +
                " and Unidade = " + xunidade;
                //
                if (xparte == "0")
                {
                    script = script +
                    " and Parte = " + xparte;
                }
                else
                    if (xproprietario == "1")
                {
                    script = script +
                    " and Parte = 1 ";
                }
                else
                {
                    script = script +
                    " and Parte = 2 ";
                }
            }
            if (xcontacorrente != "0")
            {
                script = script +
                " and conta = " + xcontacorrente + " ";
            }
            //
            if (xrbprotesto != "0")
            {
                if (xrbprotesto == "1")
                {
                    script = script +
                    " and protesto = 1 ";
                }
                else
                {
                    script = script +
                    " and protesto = 0 ";
                }
            }
            //
            if (xrbtipoparcela != "0")
            {
                if (xrbtipoparcela == "1")
                {
                    script = script +
                    " and tipo like " + Srelib.QStr("%S%") + " ";
                }
                if (xrbtipoparcela == "2")
                {
                    script = script +
                    " and (tipo = " + Srelib.QStr("N") + " " +
                    " OR tipo like " + Srelib.QStr("%R%") + ") ";
                }
                if (xrbtipoparcela == "3")
                {
                    script = script +
                    " and (tipo like " + Srelib.QStr("%I%") + " " +
                    " OR tipo = " + Srelib.QStr("IPTU") + ") ";
                }
            }
            //
            if (xrbtipocobranca != "0")
            {
                if (xrbtipocobranca == "1")
                {
                    script = script +
                    " and carteira = 0 ";
                }
                if (xrbtipocobranca == "2")
                {
                    script = script +
                    " and carteira = 1 ";
                }
            }
            //
            dsparcelas = SreDblib.GetDsScript(script);
            //
            for (int i = 0; i <= dsparcelas.Tables[0].Rows.Count - 1; i++)
            {
                //
                produto = dsparcelas.Tables[0].Rows[i]["produto"].ToString().Trim();
                grupo = dsparcelas.Tables[0].Rows[i]["grupo"].ToString().Trim();
                unidade = dsparcelas.Tables[0].Rows[i]["unidade"].ToString().Trim();
                parte = dsparcelas.Tables[0].Rows[i]["parte"].ToString().Trim();
                conta = dsparcelas.Tables[0].Rows[i]["conta"].ToString().Trim();
                if (conta == string.Empty)
                {
                    conta = "0";
                }
                parcela = dsparcelas.Tables[0].Rows[i]["parcela"].ToString().Trim();
                tipo = dsparcelas.Tables[0].Rows[i]["tipo"].ToString().Trim();
                data_vencimento = dsparcelas.Tables[0].Rows[i]["data_vencimento"].ToString().Trim();
                vlr_parcela = dsparcelas.Tables[0].Rows[i]["vlr_parcela"].ToString().Trim();
                data_pagamento = dsparcelas.Tables[0].Rows[i]["data_pagamento"].ToString().Trim();
                vlr_pagamento = dsparcelas.Tables[0].Rows[i]["vlr_pagamento"].ToString().Trim();
                protesto = dsparcelas.Tables[0].Rows[i]["protesto"].ToString().Trim();
                ativa = dsparcelas.Tables[0].Rows[i]["ativa"].ToString().Trim();
                origem_pagamento = dsparcelas.Tables[0].Rows[i]["origem_pagamento"].ToString().Trim();
                observacao = dsparcelas.Tables[0].Rows[i]["observacao"].ToString().Trim();
                nossonumero = dsparcelas.Tables[0].Rows[i]["nossonumero"].ToString().Trim();
                identificador = dsparcelas.Tables[0].Rows[i]["identificador"].ToString().Trim();
                tx_comissao = dsparcelas.Tables[0].Rows[i]["tx_comissao"].ToString().Trim();
                tx_multa = dsparcelas.Tables[0].Rows[i]["tx_multa"].ToString().Trim();
                periodicidade_comissao = dsparcelas.Tables[0].Rows[i]["periodicidade_comissao"].ToString().Trim();
                carteira = dsparcelas.Tables[0].Rows[i]["carteira"].ToString().Trim();
                //
                table1.Rows.Add(produto,
                                grupo,
                                unidade,
                                parte,
                                conta,
                                parcela,
                                tipo,
                                data_vencimento,
                                vlr_parcela,
                                data_pagamento,
                                vlr_pagamento,
                                protesto,
                                ativa,
                                origem_pagamento,
                                observacao,
                                nossonumero,
                                identificador,
                                tx_comissao,
                                tx_multa,
                                periodicidade_comissao,
                                carteira);
            }
            //
            //
        }
        else
        {
            //Todos os Grupos
            DataSet dsgrupos = uProduto.PegaDadosProdutoGrupo(Convert.ToInt32(xproduto), "1");
            string yproduto = "";
            string ygrupo = "";

            for (int row = 0; row < dsgrupos.Tables[0].Rows.Count; row++)
            {
                // Produtos
                yproduto = dsgrupos.Tables[0].Rows[row]["produto"].ToString().Trim();
                ygrupo = dsgrupos.Tables[0].Rows[row]["grupo"].ToString().Trim();
                //
                nomearquivo = "parcelas_" + Srelib.QStr0(yproduto.Trim(), 5) + "_" + Srelib.QStr0(ygrupo.Trim(), 5);

                script = " " +
                " SELECT * " +
                ",(REPLICATE('0', 3 - LEN(produto)) + CAST(produto AS varchar) + " +
                "REPLICATE('0', 3 - LEN(grupo)) + CAST(grupo AS varchar) + " +
                "REPLICATE('0', 5 - LEN(unidade)) + CAST(unidade AS varchar) + " +
                "REPLICATE('0', 3 - LEN(parte)) + CAST(parte AS varchar)) identificador " +
                " FROM " + nomearquivo + " WITH(NOLOCK)  " +
                " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                " and (vlr_pagamento = 0 and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
                " and ativa = 1 ";
                if (xcontacorrente != "0")
                {
                    script = script +
                    " and conta = " + xcontacorrente + " ";
                }
                //
                if (xrbprotesto != "0")
                {
                    if (xrbprotesto == "1")
                    {
                        script = script +
                        " and protesto = 1 ";
                    }
                    else
                    {
                        script = script +
                        " and protesto = 0 ";
                    }
                }
                //
                if (xrbtipoparcela != "0")
                {
                    if (xrbtipoparcela == "1")
                    {
                        script = script +
                        " and tipo like " + Srelib.QStr("%S%") + " ";
                    }
                    if (xrbtipoparcela == "2")
                    {
                        script = script +
                        " and (tipo = " + Srelib.QStr("N") + " " +
                        " OR tipo like " + Srelib.QStr("%R%") + ") ";
                    }
                    if (xrbtipoparcela == "3")
                    {
                        script = script +
                        " and (tipo like " + Srelib.QStr("%I%") + " " +
                        " OR tipo = " + Srelib.QStr("IPTU") + ") ";
                    }
                }
                //
                if (xrbtipocobranca != "0")
                {
                    if (xrbtipocobranca == "1")
                    {
                        script = script +
                        " and carteira = 0 ";
                    }
                    if (xrbtipocobranca == "2")
                    {
                        script = script +
                        " and carteira = 1 ";
                    }
                }
                //
                //Todas as Parcelas do Grupo
                dsparcelas = SreDblib.GetDsScript(script);
                //
                for (int i = 0; i <= dsparcelas.Tables[0].Rows.Count - 1; i++)
                {
                    //
                    produto = dsparcelas.Tables[0].Rows[i]["produto"].ToString().Trim();
                    grupo = dsparcelas.Tables[0].Rows[i]["grupo"].ToString().Trim();
                    unidade = dsparcelas.Tables[0].Rows[i]["unidade"].ToString().Trim();
                    parte = dsparcelas.Tables[0].Rows[i]["parte"].ToString().Trim();
                    conta = dsparcelas.Tables[0].Rows[i]["conta"].ToString().Trim();
                    if (conta == string.Empty)
                    {
                        conta = "0";
                    }
                    parcela = dsparcelas.Tables[0].Rows[i]["parcela"].ToString().Trim();
                    tipo = dsparcelas.Tables[0].Rows[i]["tipo"].ToString().Trim();
                    data_vencimento = dsparcelas.Tables[0].Rows[i]["data_vencimento"].ToString().Trim();
                    vlr_parcela = dsparcelas.Tables[0].Rows[i]["vlr_parcela"].ToString().Trim();
                    data_pagamento = dsparcelas.Tables[0].Rows[i]["data_pagamento"].ToString().Trim();
                    vlr_pagamento = dsparcelas.Tables[0].Rows[i]["vlr_pagamento"].ToString().Trim();
                    protesto = dsparcelas.Tables[0].Rows[i]["protesto"].ToString().Trim();
                    ativa = dsparcelas.Tables[0].Rows[i]["ativa"].ToString().Trim();
                    origem_pagamento = dsparcelas.Tables[0].Rows[i]["origem_pagamento"].ToString().Trim();
                    observacao = dsparcelas.Tables[0].Rows[i]["observacao"].ToString().Trim();
                    nossonumero = dsparcelas.Tables[0].Rows[i]["nossonumero"].ToString().Trim();
                    identificador = dsparcelas.Tables[0].Rows[i]["identificador"].ToString().Trim();
                    tx_comissao = dsparcelas.Tables[0].Rows[i]["tx_comissao"].ToString().Trim();
                    tx_multa = dsparcelas.Tables[0].Rows[i]["tx_multa"].ToString().Trim();
                    periodicidade_comissao = dsparcelas.Tables[0].Rows[i]["periodicidade_comissao"].ToString().Trim();
                    carteira = dsparcelas.Tables[0].Rows[i]["carteira"].ToString().Trim();
                    //
                    table1.Rows.Add(produto,
                                    grupo,
                                    unidade,
                                    parte,
                                    conta,
                                    parcela,
                                    tipo,
                                    data_vencimento,
                                    vlr_parcela,
                                    data_pagamento,
                                    vlr_pagamento,
                                    protesto,
                                    ativa,
                                    origem_pagamento,
                                    observacao,
                                    nossonumero,
                                    identificador,
                                    tx_comissao,
                                    tx_multa,
                                    periodicidade_comissao,
                                    carteira);
                }
                //
                //                        
                //Fim da Totalização dos Grupos
                dsparcelas.Clear();
                yproduto = "";
                ygrupo = "";
            }

        }
        //
        //Desistentes
        if (Convert.ToBoolean(xckdesistentes))
        {
            // Produtos
            nomearquivo = "parcelas_renegociacao";

            script = " " +
            " SELECT * " +
            ",(REPLICATE('0', 3 - LEN(produto)) + CAST(produto AS varchar) + " +
            "REPLICATE('0', 3 - LEN(grupo)) + CAST(grupo AS varchar) + " +
            "REPLICATE('0', 5 - LEN(unidade)) + CAST(unidade AS varchar) + " +
            "REPLICATE('0', 3 - LEN(parte)) + CAST(parte AS varchar)) identificador " +
            " FROM " + nomearquivo + " WITH(NOLOCK)  " +
            " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
            " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " and (vlr_pagamento = 0 and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
            " and ativa = 1 ";
            //
            if (xcontacorrente != "0")
            {
                script = script +
                " and conta = " + xcontacorrente + " ";
            }
            //
            if (xrbprotesto != "0")
            {
                if (xrbprotesto == "1")
                {
                    script = script +
                    " and protesto = 1 ";
                }
                else
                {
                    script = script +
                    " and protesto = 0 ";
                }
            }
            //
            if (xrbtipoparcela != "0")
            {
                if (xrbtipoparcela == "1")
                {
                    script = script +
                    " and tipo like " + Srelib.QStr("%S%") + " ";
                }
                if (xrbtipoparcela == "2")
                {
                    script = script +
                    " and (tipo = " + Srelib.QStr("N") + " " +
                    " OR tipo like " + Srelib.QStr("%R%") + ") ";
                }
                if (xrbtipoparcela == "3")
                {
                    script = script +
                    " and (tipo like " + Srelib.QStr("%I%") + " " +
                    " OR tipo = " + Srelib.QStr("IPTU") + ") ";
                }
            }
            //
            if (xrbtipocobranca != "0")
            {
                if (xrbtipocobranca == "1")
                {
                    script = script +
                    " and carteira = 0 ";
                }
                if (xrbtipocobranca == "2")
                {
                    script = script +
                    " and carteira = 1 ";
                }
            }
            //
            dsparcelas = SreDblib.GetDsScript(script);
            //
            for (int i = 0; i <= dsparcelas.Tables[0].Rows.Count - 1; i++)
            {
                //
                produto = dsparcelas.Tables[0].Rows[i]["produto"].ToString().Trim();
                grupo = dsparcelas.Tables[0].Rows[i]["grupo"].ToString().Trim();
                unidade = dsparcelas.Tables[0].Rows[i]["unidade"].ToString().Trim();
                parte = dsparcelas.Tables[0].Rows[i]["parte"].ToString().Trim();
                conta = dsparcelas.Tables[0].Rows[i]["conta"].ToString().Trim();
                if (conta == string.Empty)
                {
                    conta = "0";
                }
                parcela = dsparcelas.Tables[0].Rows[i]["parcela"].ToString().Trim();
                tipo = dsparcelas.Tables[0].Rows[i]["tipo"].ToString().Trim();
                data_vencimento = dsparcelas.Tables[0].Rows[i]["data_vencimento"].ToString().Trim();
                vlr_parcela = dsparcelas.Tables[0].Rows[i]["vlr_parcela"].ToString().Trim();
                data_pagamento = dsparcelas.Tables[0].Rows[i]["data_pagamento"].ToString().Trim();
                vlr_pagamento = dsparcelas.Tables[0].Rows[i]["vlr_pagamento"].ToString().Trim();
                protesto = dsparcelas.Tables[0].Rows[i]["protesto"].ToString().Trim();
                ativa = dsparcelas.Tables[0].Rows[i]["ativa"].ToString().Trim();
                origem_pagamento = dsparcelas.Tables[0].Rows[i]["origem_pagamento"].ToString().Trim();
                observacao = dsparcelas.Tables[0].Rows[i]["observacao"].ToString().Trim();
                nossonumero = dsparcelas.Tables[0].Rows[i]["nossonumero"].ToString().Trim();
                identificador = dsparcelas.Tables[0].Rows[i]["identificador"].ToString().Trim();
                tx_comissao = dsparcelas.Tables[0].Rows[i]["tx_comissao"].ToString().Trim();
                tx_multa = dsparcelas.Tables[0].Rows[i]["tx_multa"].ToString().Trim();
                periodicidade_comissao = dsparcelas.Tables[0].Rows[i]["periodicidade_comissao"].ToString().Trim();
                carteira = dsparcelas.Tables[0].Rows[i]["carteira"].ToString().Trim();
                //
                table1.Rows.Add(produto,
                                grupo,
                                unidade,
                                parte,
                                conta,
                                parcela,
                                tipo,
                                data_vencimento,
                                vlr_parcela,
                                data_pagamento,
                                vlr_pagamento,
                                protesto,
                                ativa,
                                origem_pagamento,
                                observacao,
                                nossonumero,
                                identificador,
                                tx_comissao,
                                tx_multa,
                                periodicidade_comissao,
                                carteira);
            }
        }

        //
        DataView dataview = new DataView(table1);
        //
        if (xrbordem == "0")
        {
            dataview.Sort = "data_vencimento ASC";
        }
        if (xrbordem == "1")
        {
            dataview.Sort = "identificador ASC";
        }
        //
        DataTable table2 = dataview.ToTable();
        //
        DataSet dsresult = new DataSet("table");
        dsresult.Tables.Add(table2);
        //
        return dsresult;

    }

    public static DataSet PegaDadosParcelasInadimplentes(string xproduto,
                                                         string xgrupo,
                                                         string xunidade,
                                                         string xparte,
                                                         string xproprietario,
                                                         string xData1,
                                                         string xData2,
                                                         string xcontacorrente,
                                                         string xrbprotesto,
                                                         string xrbtipoparcela,
                                                         string xrbordem,
                                                         string xckdesistentes,
                                                         string xnumeroparcelas,
                                                         string xcknumeroparcelas)
    {
        //Produto não pode ser vazio
        //Grupo Vazio = todos
        //Unidade Vazio = todos
        String script = "";
        String script2 = "";
        string nomearquivo = "";
        //
        string produto = "0";
        string grupo = "0";
        string unidade = "0";
        string parte = "0";
        string conta = "0";
        string parcela = "0";
        string tipo = "0";
        string data_vencimento = "0";
        string vlr_parcela = "0";
        string data_pagamento = "0";
        string vlr_pagamento = "0";
        string protesto = "0";
        string ativa = "0";
        string origem_pagamento = "0";
        string observacao = "0";
        string nossonumero = "0";
        string identificador = "";
        string tx_comissao = "0";
        string tx_multa = "0";
        string periodicidade_comissao = "a.m.";
        //
        DataSet dsgrupo;
        DataSet dstodasparcelas;
        DataSet dsparcelas;
        //
        DataTable table1 = new DataTable("table1");
        table1.Columns.Add("produto");
        table1.Columns.Add("grupo");
        table1.Columns.Add("unidade");
        table1.Columns.Add("parte");
        table1.Columns.Add("conta");
        table1.Columns.Add("parcela");
        table1.Columns.Add("tipo");
        table1.Columns.Add("data_vencimento", typeof(DateTime));
        table1.Columns.Add("vlr_parcela");
        table1.Columns.Add("data_pagamento", typeof(DateTime));
        table1.Columns.Add("vlr_pagamento");
        table1.Columns.Add("protesto");
        table1.Columns.Add("ativa");
        table1.Columns.Add("origem_pagamento");
        table1.Columns.Add("observacao");
        table1.Columns.Add("nossonumero");
        table1.Columns.Add("identificador");
        table1.Columns.Add("tx_comissao");
        table1.Columns.Add("tx_multa");
        table1.Columns.Add("periodicidade_comissao");

        //


        if (xgrupo != string.Empty)
        {
            //Grupo Expecífico
            nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);

            script = " " +
            " SELECT * " +
            ",(REPLICATE('0', 3 - LEN(produto)) + CAST(produto AS varchar) + " +
            "REPLICATE('0', 3 - LEN(grupo)) + CAST(grupo AS varchar) + " +
            "REPLICATE('0', 5 - LEN(unidade)) + CAST(unidade AS varchar) + " +
            "REPLICATE('0', 3 - LEN(parte)) + CAST(parte AS varchar)) identificador " +
            " FROM " + nomearquivo + " WITH(NOLOCK)  " +
            " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
            " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " and (vlr_pagamento = 0 and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
            " and ativa = 1 " +
            " and Grupo = " + xgrupo;
            //
            if (xunidade != string.Empty)
            {
                script = script +
                " and Unidade = " + xunidade;
                //
                if (xparte == "0")
                {
                    script = script +
                    " and Parte = " + xparte;
                }
                else
                    if (xproprietario == "1")
                {
                    script = script +
                    " and Parte = 1 ";
                }
                else
                {
                    script = script +
                    " and Parte = 2 ";
                }
            }
            if (xcontacorrente != "0")
            {
                script = script +
                " and conta = " + xcontacorrente + " ";
            }
            //
            if (xrbprotesto != "0")
            {
                if (xrbprotesto == "1")
                {
                    script = script +
                    " and protesto = 1 ";
                }
                else
                {
                    script = script +
                    " and protesto = 0 ";
                }
            }
            //
            if (xrbtipoparcela != "0")
            {
                if (xrbtipoparcela == "1")
                {
                    script = script +
                    " and tipo like " + Srelib.QStr("%S%") + " ";
                }
                if (xrbtipoparcela == "2")
                {
                    script = script +
                    " and (tipo = " + Srelib.QStr("N") + " " +
                    " OR tipo like " + Srelib.QStr("%R%") + ") ";
                }
                if (xrbtipoparcela == "3")
                {
                    script = script +
                    " and (tipo like " + Srelib.QStr("%I%") + " " +
                    " OR tipo = " + Srelib.QStr("IPTU") + ") ";
                }
            }
            //
            dstodasparcelas = SreDblib.GetDsScript(script);
            //
            for (int i = 0; i <= dstodasparcelas.Tables[0].Rows.Count - 1; i++)
            {
                //
                produto = dstodasparcelas.Tables[0].Rows[i]["produto"].ToString().Trim();
                grupo = dstodasparcelas.Tables[0].Rows[i]["grupo"].ToString().Trim();
                unidade = dstodasparcelas.Tables[0].Rows[i]["unidade"].ToString().Trim();
                parte = dstodasparcelas.Tables[0].Rows[i]["parte"].ToString().Trim();
                conta = dstodasparcelas.Tables[0].Rows[i]["conta"].ToString().Trim();
                if (conta == string.Empty)
                {
                    conta = "0";
                }
                parcela = dstodasparcelas.Tables[0].Rows[i]["parcela"].ToString().Trim();
                //
                //Unidade Específica
                script2 = " ";
                script2 = script + " and Unidade = " + unidade + " and Parte = " + parte;
                dsparcelas = SreDblib.GetDsScript(script2);
                //
                if (Convert.ToBoolean(xcknumeroparcelas) == true)
                {
                    if (dsparcelas.Tables[0].Rows.Count >= Convert.ToInt32(xnumeroparcelas))
                    {
                        //
                        for (int j = 0; j < dsparcelas.Tables[0].Rows.Count; j++)
                        {
                            //
                            tipo = dsparcelas.Tables[0].Rows[j]["tipo"].ToString().Trim();
                            data_vencimento = dsparcelas.Tables[0].Rows[j]["data_vencimento"].ToString().Trim();
                            vlr_parcela = dsparcelas.Tables[0].Rows[j]["vlr_parcela"].ToString().Trim();
                            data_pagamento = dsparcelas.Tables[0].Rows[j]["data_pagamento"].ToString().Trim();
                            vlr_pagamento = dsparcelas.Tables[0].Rows[j]["vlr_pagamento"].ToString().Trim();
                            protesto = dsparcelas.Tables[0].Rows[j]["protesto"].ToString().Trim();
                            ativa = dsparcelas.Tables[0].Rows[j]["ativa"].ToString().Trim();
                            origem_pagamento = dsparcelas.Tables[0].Rows[j]["origem_pagamento"].ToString().Trim();
                            observacao = dsparcelas.Tables[0].Rows[j]["observacao"].ToString().Trim();
                            nossonumero = dsparcelas.Tables[0].Rows[j]["nossonumero"].ToString().Trim();
                            identificador = dsparcelas.Tables[0].Rows[j]["identificador"].ToString().Trim();
                            tx_comissao = dsparcelas.Tables[0].Rows[j]["tx_comissao"].ToString().Trim();
                            tx_multa = dsparcelas.Tables[0].Rows[j]["tx_multa"].ToString().Trim();
                            periodicidade_comissao = dsparcelas.Tables[0].Rows[j]["periodicidade_comissao"].ToString().Trim();
                            //
                            table1.Rows.Add(produto,
                                            grupo,
                                            unidade,
                                            parte,
                                            conta,
                                            parcela,
                                            tipo,
                                            data_vencimento,
                                            vlr_parcela,
                                            data_pagamento,
                                            vlr_pagamento,
                                            protesto,
                                            ativa,
                                            origem_pagamento,
                                            observacao,
                                            nossonumero,
                                            identificador,
                                            tx_comissao,
                                            tx_multa,
                                            periodicidade_comissao);
                            //
                            i++;
                        }
                    }
                }
                else
                {
                    if (dsparcelas.Tables[0].Rows.Count == Convert.ToInt32(xnumeroparcelas))
                    {
                        //
                        for (int j = 0; j < Convert.ToInt32(xnumeroparcelas); j++)
                        {
                            //
                            tipo = dsparcelas.Tables[0].Rows[j]["tipo"].ToString().Trim();
                            data_vencimento = dsparcelas.Tables[0].Rows[j]["data_vencimento"].ToString().Trim();
                            vlr_parcela = dsparcelas.Tables[0].Rows[j]["vlr_parcela"].ToString().Trim();
                            data_pagamento = dsparcelas.Tables[0].Rows[j]["data_pagamento"].ToString().Trim();
                            vlr_pagamento = dsparcelas.Tables[0].Rows[j]["vlr_pagamento"].ToString().Trim();
                            protesto = dsparcelas.Tables[0].Rows[j]["protesto"].ToString().Trim();
                            ativa = dsparcelas.Tables[0].Rows[j]["ativa"].ToString().Trim();
                            origem_pagamento = dsparcelas.Tables[0].Rows[j]["origem_pagamento"].ToString().Trim();
                            observacao = dsparcelas.Tables[0].Rows[j]["observacao"].ToString().Trim();
                            nossonumero = dsparcelas.Tables[0].Rows[j]["nossonumero"].ToString().Trim();
                            identificador = dsparcelas.Tables[0].Rows[j]["identificador"].ToString().Trim();
                            tx_comissao = dsparcelas.Tables[0].Rows[j]["tx_comissao"].ToString().Trim();
                            tx_multa = dsparcelas.Tables[0].Rows[j]["tx_multa"].ToString().Trim();
                            periodicidade_comissao = dsparcelas.Tables[0].Rows[j]["periodicidade_comissao"].ToString().Trim();
                            //
                            table1.Rows.Add(produto,
                                            grupo,
                                            unidade,
                                            parte,
                                            conta,
                                            parcela,
                                            tipo,
                                            data_vencimento,
                                            vlr_parcela,
                                            data_pagamento,
                                            vlr_pagamento,
                                            protesto,
                                            ativa,
                                            origem_pagamento,
                                            observacao,
                                            nossonumero,
                                            identificador,
                                            tx_comissao,
                                            tx_multa,
                                            periodicidade_comissao);
                            //
                            i++;
                        }

                    }
                }
            }
        }
        else
        {
            //Todos os Grupos
            DataSet ds0 = uProduto.PegaDadosProdutoGrupo(Convert.ToInt32(xproduto), "1");
            string yproduto = "";
            string ygrupo = "";

            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            {
                // Produtos
                yproduto = ds0.Tables[0].Rows[row]["produto"].ToString().Trim();
                ygrupo = ds0.Tables[0].Rows[row]["grupo"].ToString().Trim();
                //
                nomearquivo = "parcelas_" + Srelib.QStr0(yproduto.Trim(), 5) + "_" + Srelib.QStr0(ygrupo.Trim(), 5);

                script = " " +
                " SELECT * " +
                ",(REPLICATE('0', 3 - LEN(produto)) + CAST(produto AS varchar) + " +
                "REPLICATE('0', 3 - LEN(grupo)) + CAST(grupo AS varchar) + " +
                "REPLICATE('0', 5 - LEN(unidade)) + CAST(unidade AS varchar) + " +
                "REPLICATE('0', 3 - LEN(parte)) + CAST(parte AS varchar)) identificador " +
                " FROM " + nomearquivo + " WITH(NOLOCK)  " +
                " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                " and (vlr_pagamento = 0 and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
                " and ativa = 1 ";
                if (xcontacorrente != "0")
                {
                    script = script +
                    " and conta = " + xcontacorrente + " ";
                }
                //
                if (xrbprotesto != "0")
                {
                    if (xrbprotesto == "1")
                    {
                        script = script +
                        " and protesto = 1 ";
                    }
                    else
                    {
                        script = script +
                        " and protesto = 0 ";
                    }
                }
                //
                if (xrbtipoparcela != "0")
                {
                    if (xrbtipoparcela == "1")
                    {
                        script = script +
                        " and tipo like " + Srelib.QStr("%S%") + " ";
                    }
                    if (xrbtipoparcela == "2")
                    {
                        script = script +
                        " and (tipo = " + Srelib.QStr("N") + " " +
                        " OR tipo like " + Srelib.QStr("%R%") + ") ";
                    }
                    if (xrbtipoparcela == "3")
                    {
                        script = script +
                        " and (tipo " + Srelib.QStr("%I%") + " " +
                        " OR tipo = " + Srelib.QStr("IPTU") + ") ";
                    }
                }
                //
                dstodasparcelas = SreDblib.GetDsScript(script);
                //
                for (int i = 0; i <= dstodasparcelas.Tables[0].Rows.Count - 1; i++)
                {
                    //
                    produto = dstodasparcelas.Tables[0].Rows[i]["produto"].ToString().Trim();
                    grupo = dstodasparcelas.Tables[0].Rows[i]["grupo"].ToString().Trim();
                    unidade = dstodasparcelas.Tables[0].Rows[i]["unidade"].ToString().Trim();
                    parte = dstodasparcelas.Tables[0].Rows[i]["parte"].ToString().Trim();
                    conta = dstodasparcelas.Tables[0].Rows[i]["conta"].ToString().Trim();
                    if (conta == string.Empty)
                    {
                        conta = "0";
                    }
                    parcela = dstodasparcelas.Tables[0].Rows[i]["parcela"].ToString().Trim();
                    //
                    script2 = " ";
                    script2 = script + " and Unidade = " + unidade + " and Parte = " + parte;
                    dsparcelas = SreDblib.GetDsScript(script2);
                    //
                    if (Convert.ToBoolean(xcknumeroparcelas) == true)
                    {
                        if (dsparcelas.Tables[0].Rows.Count >= Convert.ToInt32(xnumeroparcelas))
                        {
                            //
                            for (int j = 0; j < dsparcelas.Tables[0].Rows.Count; j++)
                            {
                                //
                                tipo = dsparcelas.Tables[0].Rows[j]["tipo"].ToString().Trim();
                                data_vencimento = dsparcelas.Tables[0].Rows[j]["data_vencimento"].ToString().Trim();
                                vlr_parcela = dsparcelas.Tables[0].Rows[j]["vlr_parcela"].ToString().Trim();
                                data_pagamento = dsparcelas.Tables[0].Rows[j]["data_pagamento"].ToString().Trim();
                                vlr_pagamento = dsparcelas.Tables[0].Rows[j]["vlr_pagamento"].ToString().Trim();
                                protesto = dsparcelas.Tables[0].Rows[j]["protesto"].ToString().Trim();
                                ativa = dsparcelas.Tables[0].Rows[j]["ativa"].ToString().Trim();
                                origem_pagamento = dsparcelas.Tables[0].Rows[j]["origem_pagamento"].ToString().Trim();
                                observacao = dsparcelas.Tables[0].Rows[j]["observacao"].ToString().Trim();
                                nossonumero = dsparcelas.Tables[0].Rows[j]["nossonumero"].ToString().Trim();
                                identificador = dsparcelas.Tables[0].Rows[j]["identificador"].ToString().Trim();
                                tx_comissao = dsparcelas.Tables[0].Rows[j]["tx_comissao"].ToString().Trim();
                                tx_multa = dsparcelas.Tables[0].Rows[j]["tx_multa"].ToString().Trim();
                                periodicidade_comissao = dsparcelas.Tables[0].Rows[j]["periodicidade_comissao"].ToString().Trim();
                                //
                                table1.Rows.Add(produto,
                                                grupo,
                                                unidade,
                                                parte,
                                                conta,
                                                parcela,
                                                tipo,
                                                data_vencimento,
                                                vlr_parcela,
                                                data_pagamento,
                                                vlr_pagamento,
                                                protesto,
                                                ativa,
                                                origem_pagamento,
                                                observacao,
                                                nossonumero,
                                                identificador,
                                                tx_comissao,
                                                tx_multa,
                                                periodicidade_comissao);
                                //
                                i++;
                            }

                        }
                    }
                    else
                    {
                        if (dsparcelas.Tables[0].Rows.Count == Convert.ToInt32(xnumeroparcelas))
                        {
                            //
                            for (int j = 0; j < Convert.ToInt32(xnumeroparcelas); j++)
                            {
                                //
                                tipo = dsparcelas.Tables[0].Rows[j]["tipo"].ToString().Trim();
                                data_vencimento = dsparcelas.Tables[0].Rows[j]["data_vencimento"].ToString().Trim();
                                vlr_parcela = dsparcelas.Tables[0].Rows[j]["vlr_parcela"].ToString().Trim();
                                data_pagamento = dsparcelas.Tables[0].Rows[j]["data_pagamento"].ToString().Trim();
                                vlr_pagamento = dsparcelas.Tables[0].Rows[j]["vlr_pagamento"].ToString().Trim();
                                protesto = dsparcelas.Tables[0].Rows[j]["protesto"].ToString().Trim();
                                ativa = dsparcelas.Tables[0].Rows[j]["ativa"].ToString().Trim();
                                origem_pagamento = dsparcelas.Tables[0].Rows[j]["origem_pagamento"].ToString().Trim();
                                observacao = dsparcelas.Tables[0].Rows[j]["observacao"].ToString().Trim();
                                nossonumero = dsparcelas.Tables[0].Rows[j]["nossonumero"].ToString().Trim();
                                identificador = dsparcelas.Tables[0].Rows[j]["identificador"].ToString().Trim();
                                tx_comissao = dsparcelas.Tables[0].Rows[j]["tx_comissao"].ToString().Trim();
                                tx_multa = dsparcelas.Tables[0].Rows[j]["tx_multa"].ToString().Trim();
                                periodicidade_comissao = dsparcelas.Tables[0].Rows[j]["periodicidade_comissao"].ToString().Trim();
                                //
                                table1.Rows.Add(produto,
                                                grupo,
                                                unidade,
                                                parte,
                                                conta,
                                                parcela,
                                                tipo,
                                                data_vencimento,
                                                vlr_parcela,
                                                data_pagamento,
                                                vlr_pagamento,
                                                protesto,
                                                ativa,
                                                origem_pagamento,
                                                observacao,
                                                nossonumero,
                                                identificador,
                                                tx_comissao,
                                                tx_multa,
                                                periodicidade_comissao);
                                //
                                i++;
                            }
                        }
                    }
                    //
                    //                        
                    //Fim da Totalização dos Grupos
                    dsparcelas.Clear();
                    yproduto = "";
                    ygrupo = "";
                }

            }
        }
        //
        //Desistentes
        if (Convert.ToBoolean(xckdesistentes))
        {
            // Produtos
            nomearquivo = "parcelas_renegociacao";

            script = " " +
            " SELECT * " +
            ",(REPLICATE('0', 3 - LEN(produto)) + CAST(produto AS varchar) + " +
            "REPLICATE('0', 3 - LEN(grupo)) + CAST(grupo AS varchar) + " +
            "REPLICATE('0', 5 - LEN(unidade)) + CAST(unidade AS varchar) + " +
            "REPLICATE('0', 3 - LEN(parte)) + CAST(parte AS varchar)) identificador " +
            " FROM " + nomearquivo + " WITH(NOLOCK)  " +
            " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
            " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " and (vlr_pagamento = 0 and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
            " and ativa = 1 ";
            //
            if (xcontacorrente != "0")
            {
                script = script +
                " and conta = " + xcontacorrente + " ";
            }
            //
            if (xrbprotesto != "0")
            {
                if (xrbprotesto == "1")
                {
                    script = script +
                    " and protesto = 1 ";
                }
                else
                {
                    script = script +
                    " and protesto = 0 ";
                }
            }
            //
            if (xrbtipoparcela != "0")
            {
                if (xrbtipoparcela == "1")
                {
                    script = script +
                    " and tipo like " + Srelib.QStr("%S%") + " ";
                }
                if (xrbtipoparcela == "2")
                {
                    script = script +
                    " and (tipo = " + Srelib.QStr("N") + " " +
                    " OR tipo like " + Srelib.QStr("%R%") + ") ";
                }
                if (xrbtipoparcela == "3")
                {
                    script = script +
                    " and (tipo like " + Srelib.QStr("%I%") + " " +
                    " OR tipo = " + Srelib.QStr("IPTU") + ") ";
                }
            }
            //
            dstodasparcelas = SreDblib.GetDsScript(script);
            //
            for (int i = 0; i <= dstodasparcelas.Tables[0].Rows.Count - 1; i++)
            {
                //
                produto = dstodasparcelas.Tables[0].Rows[i]["produto"].ToString().Trim();
                grupo = dstodasparcelas.Tables[0].Rows[i]["grupo"].ToString().Trim();
                unidade = dstodasparcelas.Tables[0].Rows[i]["unidade"].ToString().Trim();
                parte = dstodasparcelas.Tables[0].Rows[i]["parte"].ToString().Trim();
                conta = dstodasparcelas.Tables[0].Rows[i]["conta"].ToString().Trim();
                if (conta == string.Empty)
                {
                    conta = "0";
                }
                parcela = dstodasparcelas.Tables[0].Rows[i]["parcela"].ToString().Trim();
                //
                script2 = " ";
                script2 = script + " and Unidade = " + unidade + " and Parte = " + parte;
                dsparcelas = SreDblib.GetDsScript(script2);
                //
                if (Convert.ToBoolean(xcknumeroparcelas) == true)
                {
                    if (dsparcelas.Tables[0].Rows.Count >= Convert.ToInt32(xnumeroparcelas))
                    {
                        //
                        for (int j = 0; j < dsparcelas.Tables[0].Rows.Count; j++)
                        {
                            //
                            tipo = dsparcelas.Tables[0].Rows[j]["tipo"].ToString().Trim();
                            data_vencimento = dsparcelas.Tables[0].Rows[j]["data_vencimento"].ToString().Trim();
                            vlr_parcela = dsparcelas.Tables[0].Rows[j]["vlr_parcela"].ToString().Trim();
                            data_pagamento = dsparcelas.Tables[0].Rows[j]["data_pagamento"].ToString().Trim();
                            vlr_pagamento = dsparcelas.Tables[0].Rows[j]["vlr_pagamento"].ToString().Trim();
                            protesto = dsparcelas.Tables[0].Rows[j]["protesto"].ToString().Trim();
                            ativa = dsparcelas.Tables[0].Rows[j]["ativa"].ToString().Trim();
                            origem_pagamento = dsparcelas.Tables[0].Rows[j]["origem_pagamento"].ToString().Trim();
                            observacao = dsparcelas.Tables[0].Rows[j]["observacao"].ToString().Trim();
                            nossonumero = dsparcelas.Tables[0].Rows[j]["nossonumero"].ToString().Trim();
                            identificador = dsparcelas.Tables[0].Rows[j]["identificador"].ToString().Trim();
                            tx_comissao = dsparcelas.Tables[0].Rows[j]["tx_comissao"].ToString().Trim();
                            tx_multa = dsparcelas.Tables[0].Rows[j]["tx_multa"].ToString().Trim();
                            periodicidade_comissao = dsparcelas.Tables[0].Rows[j]["periodicidade_comissao"].ToString().Trim();
                            //
                            table1.Rows.Add(produto,
                                            grupo,
                                            unidade,
                                            parte,
                                            conta,
                                            parcela,
                                            tipo,
                                            data_vencimento,
                                            vlr_parcela,
                                            data_pagamento,
                                            vlr_pagamento,
                                            protesto,
                                            ativa,
                                            origem_pagamento,
                                            observacao,
                                            nossonumero,
                                            identificador,
                                            tx_comissao,
                                            tx_multa,
                                            periodicidade_comissao);
                            //
                            i++;
                        }

                    }
                }
                else
                {
                    if (dsparcelas.Tables[0].Rows.Count == Convert.ToInt32(xnumeroparcelas))
                    {
                        //
                        for (int j = 0; j < Convert.ToInt32(xnumeroparcelas); j++)
                        {
                            //
                            tipo = dsparcelas.Tables[0].Rows[j]["tipo"].ToString().Trim();
                            data_vencimento = dsparcelas.Tables[0].Rows[j]["data_vencimento"].ToString().Trim();
                            vlr_parcela = dsparcelas.Tables[0].Rows[j]["vlr_parcela"].ToString().Trim();
                            data_pagamento = dsparcelas.Tables[0].Rows[j]["data_pagamento"].ToString().Trim();
                            vlr_pagamento = dsparcelas.Tables[0].Rows[j]["vlr_pagamento"].ToString().Trim();
                            protesto = dsparcelas.Tables[0].Rows[j]["protesto"].ToString().Trim();
                            ativa = dsparcelas.Tables[0].Rows[j]["ativa"].ToString().Trim();
                            origem_pagamento = dsparcelas.Tables[0].Rows[j]["origem_pagamento"].ToString().Trim();
                            observacao = dsparcelas.Tables[0].Rows[j]["observacao"].ToString().Trim();
                            nossonumero = dsparcelas.Tables[0].Rows[j]["nossonumero"].ToString().Trim();
                            identificador = dsparcelas.Tables[0].Rows[j]["identificador"].ToString().Trim();
                            tx_comissao = dsparcelas.Tables[0].Rows[j]["tx_comissao"].ToString().Trim();
                            tx_multa = dsparcelas.Tables[0].Rows[j]["tx_multa"].ToString().Trim();
                            periodicidade_comissao = dsparcelas.Tables[0].Rows[j]["periodicidade_comissao"].ToString().Trim();
                            //
                            table1.Rows.Add(produto,
                                            grupo,
                                            unidade,
                                            parte,
                                            conta,
                                            parcela,
                                            tipo,
                                            data_vencimento,
                                            vlr_parcela,
                                            data_pagamento,
                                            vlr_pagamento,
                                            protesto,
                                            ativa,
                                            origem_pagamento,
                                            observacao,
                                            nossonumero,
                                            identificador,
                                            tx_comissao,
                                            tx_multa,
                                            periodicidade_comissao);
                            //
                            i++;
                        }

                    }
                }
            }
        }
        //
        DataView dataview = new DataView(table1);
        //
        if (xrbordem == "0")
        {
            dataview.Sort = "data_vencimento ASC";
        }
        if (xrbordem == "1")
        {
            dataview.Sort = "identificador ASC";
        }
        //
        DataTable table2 = dataview.ToTable();
        //
        DataSet dsresult = new DataSet("table");
        dsresult.Tables.Add(table2);
        //
        return dsresult;

    }


    public static DataSet PegaDadosSaldoDevedor(string xproduto,
                                                string xgrupo,
                                                string xData1,
                                                string xData2)
    {
        //Produto não pode ser vazio
        //Grupo Vazio = todos
        //Unidade Vazio = todos
        String script = "";
        string nomearquivo = "";
        //
        string produto = "0";
        string grupo = "0";
        string unidade = "0";
        string parte = "0";
        string saldodevedor = "0";
        string parcelas = "0";
        //
        DataSet dsgrupo;
        //
        DataTable table1 = new DataTable("table1");
        table1.Columns.Add("produto");
        table1.Columns.Add("grupo");
        table1.Columns.Add("unidade");
        table1.Columns.Add("parte");
        table1.Columns.Add("saldodevedor");
        table1.Columns.Add("parcelas");
        //


        if (xgrupo != string.Empty)
        {
            nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);

            script = " " +
            " SELECT produto, grupo, unidade, parte, " +
            " SUM(vlr_parcela) AS saldodevedor, COUNT(parcela) AS saldodevedorqtd " +
            " FROM " + nomearquivo + " WITH(NOLOCK)  " +
            " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            //" AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " AND ativa = 1   " +
            " and (vlr_pagamento = 0 and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
            " group by produto, grupo, unidade, parte ";
            //
            dsgrupo = SreDblib.GetDsScript(script);
            //
            for (int i = 0; i <= dsgrupo.Tables[0].Rows.Count - 1; i++)
            {
                //
                produto = dsgrupo.Tables[0].Rows[i]["produto"].ToString().Trim();
                grupo = dsgrupo.Tables[0].Rows[i]["grupo"].ToString().Trim();
                unidade = dsgrupo.Tables[0].Rows[i]["unidade"].ToString().Trim();
                parte = dsgrupo.Tables[0].Rows[i]["parte"].ToString().Trim();
                saldodevedor = dsgrupo.Tables[0].Rows[i]["saldodevedor"].ToString().Trim();
                parcelas = dsgrupo.Tables[0].Rows[i]["saldodevedorqtd"].ToString().Trim();
                //
                table1.Rows.Add(produto,
                                grupo,
                                unidade,
                                parte,
                                saldodevedor,
                                parcelas);
            }
            //
            //
        }
        else
        {
            DataSet ds0 = uProduto.PegaDadosProdutoGrupo(Convert.ToInt32(xproduto), "1");
            string yproduto = "";
            string ygrupo = "";

            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                // Produtos
                yproduto = ds0.Tables[0].Rows[row]["produto"].ToString().Trim();
                ygrupo = ds0.Tables[0].Rows[row]["grupo"].ToString().Trim();
                //
                nomearquivo = "parcelas_" + Srelib.QStr0(yproduto.Trim(), 5) + "_" + Srelib.QStr0(ygrupo.Trim(), 5);

                script = " " +
                " SELECT produto, grupo, unidade, parte, " +
                " SUM(vlr_parcela) AS saldodevedor, COUNT(parcela) AS saldodevedorqtd " +
                " FROM " + nomearquivo + " WITH(NOLOCK)  " +
                " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                //" AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                " AND ativa = 1   " +
                " and (vlr_pagamento = 0 and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
                " group by produto, grupo, unidade, parte ";
                //
                dsgrupo = SreDblib.GetDsScript(script);
                //
                for (int i = 0; i <= dsgrupo.Tables[0].Rows.Count - 1; i++)
                {
                    //
                    produto = dsgrupo.Tables[0].Rows[i]["produto"].ToString().Trim();
                    grupo = dsgrupo.Tables[0].Rows[i]["grupo"].ToString().Trim();
                    unidade = dsgrupo.Tables[0].Rows[i]["unidade"].ToString().Trim();
                    parte = dsgrupo.Tables[0].Rows[i]["parte"].ToString().Trim();
                    saldodevedor = dsgrupo.Tables[0].Rows[i]["saldodevedor"].ToString().Trim();
                    parcelas = dsgrupo.Tables[0].Rows[i]["saldodevedorqtd"].ToString().Trim();
                    //
                    table1.Rows.Add(produto,
                                    grupo,
                                    unidade,
                                    parte,
                                    saldodevedor,
                                    parcelas);
                }
                //
                //                        
                //Fim da Totalização dos Grupos
                dsgrupo.Clear();
                yproduto = "";
                ygrupo = "";
            }

        }
        //
        //
        //DataView dataview = new DataView(table1)
        //{
        //    Sort = "grupo, unidade ASC"
        //};
        //
        //DataTable table2 = dataview.ToTable();
        //
        DataSet dsresult = new DataSet("table");
        //
        dsresult.Tables.Add(table1);
        //
        return dsresult;

    }

    public static DataSet PegaDadosSaldoCredor(string xproduto,
                                               string xgrupo,
                                               string xData1,
                                               string xData2)
    {
        //Produto não pode ser vazio
        //Grupo Vazio = todos
        //Unidade Vazio = todos
        String script = "";
        string nomearquivo = "";
        //
        string produto = "0";
        string grupo = "0";
        string unidade = "0";
        string parte = "0";
        string saldocredor = "0";
        string parcelas = "0";
        //
        DataSet dsgrupo;
        //
        DataTable table1 = new DataTable("table1");
        table1.Columns.Add("produto");
        table1.Columns.Add("grupo");
        table1.Columns.Add("unidade");
        table1.Columns.Add("parte");
        table1.Columns.Add("saldocredor");
        table1.Columns.Add("parcelas");
        //


        if (xgrupo != string.Empty)
        {
            nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);

            script = " " +
            " SELECT produto, grupo, unidade, parte, " +
            " SUM(vlr_pagamento) AS saldocredor, COUNT(parcela) AS saldocredorqtd " +
            " FROM " + nomearquivo + " WITH(NOLOCK)  " +
            " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
            " AND ativa = 1   " +
            " and (vlr_pagamento <> 0 and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
            " group by produto, grupo, unidade, parte ";
            //
            dsgrupo = SreDblib.GetDsScript(script);
            //
            for (int i = 0; i <= dsgrupo.Tables[0].Rows.Count - 1; i++)
            {
                //
                produto = dsgrupo.Tables[0].Rows[i]["produto"].ToString().Trim();
                grupo = dsgrupo.Tables[0].Rows[i]["grupo"].ToString().Trim();
                unidade = dsgrupo.Tables[0].Rows[i]["unidade"].ToString().Trim();
                parte = dsgrupo.Tables[0].Rows[i]["parte"].ToString().Trim();
                saldocredor = dsgrupo.Tables[0].Rows[i]["saldocredor"].ToString().Trim();
                parcelas = dsgrupo.Tables[0].Rows[i]["saldocredorqtd"].ToString().Trim();
                //
                table1.Rows.Add(produto,
                                grupo,
                                unidade,
                                parte,
                                saldocredor,
                                parcelas);
            }
            //
            //
        }
        else
        {
            DataSet ds0 = uProduto.PegaDadosProdutoGrupo(Convert.ToInt32(xproduto), "1");
            string yproduto = "";
            string ygrupo = "";

            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                // Produtos
                yproduto = ds0.Tables[0].Rows[row]["produto"].ToString().Trim();
                ygrupo = ds0.Tables[0].Rows[row]["grupo"].ToString().Trim();
                //
                nomearquivo = "parcelas_" + Srelib.QStr0(yproduto.Trim(), 5) + "_" + Srelib.QStr0(ygrupo.Trim(), 5);

                script = " " +
                " SELECT produto, grupo, unidade, parte, " +
                " SUM(vlr_parcela) AS saldocredor, COUNT(parcela) AS saldocredorqtd " +
                " FROM " + nomearquivo + " WITH(NOLOCK)  " +
                " WHERE (data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                " AND (data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") " +
                " AND ativa = 1   " +
                " and (vlr_pagamento <> 0 and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") " +
                " group by produto, grupo, unidade, parte ";
                //
                dsgrupo = SreDblib.GetDsScript(script);
                //
                for (int i = 0; i <= dsgrupo.Tables[0].Rows.Count - 1; i++)
                {
                    //
                    produto = dsgrupo.Tables[0].Rows[i]["produto"].ToString().Trim();
                    grupo = dsgrupo.Tables[0].Rows[i]["grupo"].ToString().Trim();
                    unidade = dsgrupo.Tables[0].Rows[i]["unidade"].ToString().Trim();
                    parte = dsgrupo.Tables[0].Rows[i]["parte"].ToString().Trim();
                    saldocredor = dsgrupo.Tables[0].Rows[i]["saldocredor"].ToString().Trim();
                    parcelas = dsgrupo.Tables[0].Rows[i]["saldocredorqtd"].ToString().Trim();
                    //
                    table1.Rows.Add(produto,
                                    grupo,
                                    unidade,
                                    parte,
                                    saldocredor,
                                    parcelas);
                }
                //
                //                        
                //Fim da Totalização dos Grupos
                dsgrupo.Clear();
                yproduto = "";
                ygrupo = "";
            }

        }

        //
        //DataView dataview = new DataView(table1)
        //{
        //    Sort = "grupo, unidade ASC"
        //};
        //DataTable table2 = dataview.ToTable();
        //
        DataSet dsresult = new DataSet("table");
        dsresult.Tables.Add(table1);
        //
        return dsresult;

    }

    public static ASPxComboBox MontaComboFormaPagamento(ASPxComboBox pCombo, Boolean pExibeValor)
    {
        //Documentação - Chamada da Função
        //
        //SreLib.MontaComboMes(ASPxComboBox1, True);
        //
        //Fim Documentação - Chamada da Função

        pCombo.Items.Clear();
        pCombo.Items.Add("Dinheiro");
        pCombo.Items.Add("Cheque");
        pCombo.Items.Add("Boleto");
        pCombo.Items.Add("Outros");

        return pCombo;
    }


    public static DataSet PegaDadosParcelaID(string xproduto,
                                             string xgrupo,
                                             string xunidade,
                                             string xparte,
                                             string xID)
    {
        string script = "";

        string nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);

        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) " +
                 " where ID  IN (" + xID + ") ";

        return SreDblib.GetDsScript(script);

    }

    public static String GravaRecibo(string xproduto,
                                     string xgrupo,
                                     string xunidade,
                                     string xparte,
                                     string xID,
                                     string xrecibo)
    {
        //
        if (xproduto != String.Empty)
        {
            string script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                            " SET " +
                            " nossonumero = " + Srelib.QStr(xrecibo) +
                            " WHERE ID = " + xID;
            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String GravaNovoDiaVencimento(string xproduto,
                                                string xgrupo,
                                                string xunidade,
                                                string xparte,
                                                string xdtperiodo1,
                                                string xdtperiodo2,
                                                string xnovodia)
    {
        //
        //A quantidade de dias dos meses do ano varia entre 28 e 31, conforme o Calendário Gregoriano:

        //Janeiro	tem 31 dias
        //Fevereiro	tem 28 (ou 29 dias nos anos bissextos)
        //Março	tem 31 dias
        //Abril	tem 30 dias
        //Maio	tem 31 dias
        //Junho	tem 30 dias
        //Julho	tem 31 dias
        //Agosto	tem 31 dias
        //Setembro	tem 30 dias
        //Outubro	tem 31 dias
        //Novembro	tem 30 dias
        //Dezembro	tem 31 dias
        //
        string script = "";
        if (xproduto != String.Empty)
        {
            if (Convert.ToInt16(xnovodia) <= 28)
            {
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         " + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         " + " + Srelib.QStr(xnovodia) + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
            }
            //
            //
            if (Convert.ToInt16(xnovodia) == 29)
            {
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         " + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         " + " + Srelib.QStr(xnovodia) + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND month(data_vencimento) <> 2 " +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
                //
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         " + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         " + " + Srelib.QStr("28") + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND month(data_vencimento) = 2 " +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
            }
            //
            if (Convert.ToInt16(xnovodia) == 30)
            {
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         " + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         " + " + Srelib.QStr(xnovodia) + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND month(data_vencimento) <> 2 " +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
                //
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         " + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         " + " + Srelib.QStr("28") + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND month(data_vencimento) = 2 " +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
            }
            //
            if (Convert.ToInt16(xnovodia) == 31)
            {
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         " + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         " + " + Srelib.QStr(xnovodia) + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND (month(data_vencimento) <> 2 " +
                         " AND month(data_vencimento) <> 4 " +
                         " AND month(data_vencimento) <> 6 " +
                         " AND month(data_vencimento) <> 9 " +
                         " AND month(data_vencimento) <> 11) " +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
                //
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         " + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         " + " + Srelib.QStr("28") + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND month(data_vencimento) = 2 " +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
                //
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         " + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         " + " + Srelib.QStr("30") + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND (month(data_vencimento) <> 1 " +
                         " AND month(data_vencimento) <> 2 " +
                         " AND month(data_vencimento) <> 3 " +
                         " AND month(data_vencimento) <> 5 " +
                         " AND month(data_vencimento) <> 7 " +
                         " AND month(data_vencimento) <> 8 " +
                         " AND month(data_vencimento) <> 10 " +
                         " AND month(data_vencimento) <> 12) " +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
                //
            }

        }
        return " ";
    }

    public static String GravaNovoDiaVencimentoForaMes(string xproduto,
                                                       string xgrupo,
                                                       string xunidade,
                                                       string xparte,
                                                       string xdtperiodo1,
                                                       string xdtperiodo2,
                                                       string xnovadatainicial)
    {
        //
        //A quantidade de dias dos meses do ano varia entre 28 e 31, conforme o Calendário Gregoriano:

        //Janeiro	tem 31 dias
        //Fevereiro	tem 28 (ou 29 dias nos anos bissextos)
        //Março	tem 31 dias
        //Abril	tem 30 dias
        //Maio	tem 31 dias
        //Junho	tem 30 dias
        //Julho	tem 31 dias
        //Agosto	tem 31 dias
        //Setembro	tem 30 dias
        //Outubro	tem 31 dias
        //Novembro	tem 30 dias
        //Dezembro	tem 31 dias
        //
        Int32 meses = 0;
        string script = "Select top 1 data_vencimento from " +
                        " parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                        " WHERE " +
                        " produto = " + xproduto +
                        " and " +
                        " grupo = " + xgrupo +
                        " and " +
                        " unidade = " + xunidade +
                        " and " +
                        " parte = " + xparte +
                        " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                        " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                        " order by data_vencimento ";
        //
        string primeiradata = SreDblib.GetCampoScript(script);
        //
        meses = 12 * (Convert.ToDateTime(primeiradata.Substring(0, 10)).Year - Convert.ToDateTime(xnovadatainicial.Substring(0, 10)).Year)
            + Convert.ToDateTime(primeiradata.Substring(0, 10)).Month - Convert.ToDateTime(xnovadatainicial.Substring(0, 10)).Month;
        meses = Math.Abs(meses);
        //
        //Mêses Negativo
        if (Convert.ToDateTime(xnovadatainicial.Substring(0, 10)) < Convert.ToDateTime(primeiradata.Substring(0, 10)))
        {
            meses = (meses * -1);
        }
        //Novo Dia
        string novodiainicial = xnovadatainicial.Substring(0, 2);
        //
        script = "";
        if (xproduto != String.Empty)
        {
            if (Convert.ToInt16(novodiainicial) <= 28)
            {
                //Muda o Mês
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " DATEADD(month," + meses + ",data_vencimento) " +
                         //" cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         //" + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         //" + " + Srelib.QStr(novodiainicial) + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
                //
                //Muda o Dia
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         " + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         " + " + Srelib.QStr(novodiainicial) + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
            }
            //
            //
            if (Convert.ToInt16(novodiainicial) == 29)
            {
                //Muda o Mês
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " DATEADD(month," + meses + ",data_vencimento) " +
                         //" cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         //" + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         //" + " + Srelib.QStr(novodiainicial) + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND month(data_vencimento) <> 2 " +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
                //
                //Muda o Dia
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         " + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         " + " + Srelib.QStr(novodiainicial) + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND month(data_vencimento) <> 2 " +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
                //
                //Muda o Mês
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " DATEADD(month," + meses + ",data_vencimento) " +
                         //" cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         //" + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         //" + " + Srelib.QStr(novodiainicial) + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND month(data_vencimento) = 2 " +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
                //
                //Muda o Dia
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         " + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         " + " + Srelib.QStr(novodiainicial) + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND month(data_vencimento) = 2 " +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
            }
            //
            if (Convert.ToInt16(novodiainicial) == 30)
            {
                //Muda o Mês
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " DATEADD(month," + meses + ",data_vencimento) " +
                         //" cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         //" + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         //" + " + Srelib.QStr(novodiainicial) + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND month(data_vencimento) <> 2 " +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
                //
                //Muda o Dia
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         " + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         " + " + Srelib.QStr(novodiainicial) + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND month(data_vencimento) <> 2 " +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
                //
                //Muda o Mês
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " DATEADD(month," + meses + ",data_vencimento) " +
                         //" cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         //" + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         //" + " + Srelib.QStr("28") + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND month(data_vencimento) = 2 " +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
                //
                //Muda o Dia
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         " + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         " + " + Srelib.QStr("28") + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND month(data_vencimento) = 2 " +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
            }
            //
            if (Convert.ToInt16(novodiainicial) == 31)
            {
                //Muda o Mês
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " DATEADD(month," + meses + ",data_vencimento) " +
                         //" cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         //" + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         //" + " + Srelib.QStr(novodiainicial) + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND (month(data_vencimento) <> 2 " +
                         " AND month(data_vencimento) <> 4 " +
                         " AND month(data_vencimento) <> 6 " +
                         " AND month(data_vencimento) <> 9 " +
                         " AND month(data_vencimento) <> 11) " +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
                //
                //Muda o Dia
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         " + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         " + " + Srelib.QStr(novodiainicial) + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND (month(data_vencimento) <> 2 " +
                         " AND month(data_vencimento) <> 4 " +
                         " AND month(data_vencimento) <> 6 " +
                         " AND month(data_vencimento) <> 9 " +
                         " AND month(data_vencimento) <> 11) " +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
                //
                //Muda o Mês
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " DATEADD(month," + meses + ",data_vencimento) " +
                         //" cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         //" + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         //" + " + Srelib.QStr("28") + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND month(data_vencimento) = 2 " +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
                //
                //Muda o Dia
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         " + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         " + " + Srelib.QStr("28") + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND month(data_vencimento) = 2 " +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
                //
                //Muda o Mês
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " DATEADD(month," + meses + ",data_vencimento) " +
                         //" cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         //" + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         //" + " + Srelib.QStr("30") + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND (month(data_vencimento) <> 1 " +
                         " AND month(data_vencimento) <> 2 " +
                         " AND month(data_vencimento) <> 3 " +
                         " AND month(data_vencimento) <> 5 " +
                         " AND month(data_vencimento) <> 7 " +
                         " AND month(data_vencimento) <> 8 " +
                         " AND month(data_vencimento) <> 10 " +
                         " AND month(data_vencimento) <> 12) " +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
                //
                //Muda o Dia
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " data_vencimento = " +
                         " cast(cast(YEAR(data_vencimento) as varchar(4)) " +
                         " + right('00'+cast(MONTH(data_vencimento) as varchar(2)),2) " +
                         " + " + Srelib.QStr("30") + " as DATE) " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_vencimento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) +
                         " AND (month(data_vencimento) <> 1 " +
                         " AND month(data_vencimento) <> 2 " +
                         " AND month(data_vencimento) <> 3 " +
                         " AND month(data_vencimento) <> 5 " +
                         " AND month(data_vencimento) <> 7 " +
                         " AND month(data_vencimento) <> 8 " +
                         " AND month(data_vencimento) <> 10 " +
                         " AND month(data_vencimento) <> 12) " +
                         " AND ativa = 1";
                SreDblib.ExecScript(script);
                //
            }
        }
        return " ";
    }


    public static String GravaProtesto(string xproduto,
                                       string xgrupo,
                                       string xunidade,
                                       string xparte,
                                       string xdtperiodo1,
                                       string xdtperiodo2,
                                       string xprotesto)
    {
        //
        string script = "";
        if (xproduto != String.Empty)
        {
            if (xprotesto == "0")
            {
                //Protestar
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " protesto = 1 " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2));
            }
            else
            {
                //Não Protestar
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " protesto = 0 " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2));
            }
            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String GravaContabil(string xproduto,
                                       string xgrupo,
                                       string xunidade,
                                       string xparte,
                                       string xdtperiodo1,
                                       string xdtperiodo2,
                                       string xcontabil)
    {
        //
        string script = "";
        if (xproduto != String.Empty)
        {
            if (xcontabil == "0")
            {
                //Protestar
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " contabil = 1 " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2));
            }
            else
            {
                //Não Protestar
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " contabil = 0 " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2));
            }
            SreDblib.ExecScript(script);
        }
        return " ";
    }


    public static String GravaCobranca(string xproduto,
                                       string xgrupo,
                                       string xunidade,
                                       string xparte,
                                       string xdtperiodo1,
                                       string xdtperiodo2,
                                       string xcarteira)
    {
        //
        string script = "";
        if (xproduto != String.Empty)
        {
            if (xcarteira == "0")
            {
                //Protestar
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " carteira = 1 " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2));
            }
            else
            {
                //Não Protestar
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " carteira = 0 " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2));
            }
            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String GravaPeriodicidade(string xproduto,
                                            string xgrupo,
                                            string xunidade,
                                            string xparte,
                                            string xdtperiodo1,
                                            string xdtperiodo2,
                                            string xperiodicidade)
    {
        //
        string script = "";
        if (xproduto != String.Empty)
        {
            if (xperiodicidade == "0")
            {
                //Protestar
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " periodicidade_comissao = " + Srelib.QStr("a.d.") + " " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2));
            }
            if (xperiodicidade == "1")
            {
                //Não Protestar
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " periodicidade_comissao = " + Srelib.QStr("a.m.") + " " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2));
            }
            if (xperiodicidade == "2")
            {
                //Não Protestar
                script = "";
                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " periodicidade_comissao = " + Srelib.QStr("a.a.") + " " +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " AND data_pagamento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                         " AND data_pagamento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2));
            }
            //
            SreDblib.ExecScript(script);
        }
        return " ";
    }



    public static String GravaBaixaCobranca(string xproduto,
                                            string xgrupo,
                                            string xunidade,
                                            string xparte,
                                            string xdtvencimento,
                                            string xdtpagamento,
                                            string xnossonumero,
                                            string xcontacorrente,
                                            string xvlr_pagamento)
    {
        //
        string script = "";
        if (xproduto != String.Empty)
        {
            if (xnossonumero != String.Empty)
            {
                //
                script = "";
                script = " UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " vlr_pagamento = " + Srelib.forcaponto(Convert.ToString(xvlr_pagamento)) +
                         " ,data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtpagamento)) +
                         " ,conta = " + xcontacorrente +
                         " ,nossonumero = " + xnossonumero +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " and " +
                         " data_vencimento = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtvencimento));
            }
            else
            {
                //
                script = "";
                script = " UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " vlr_pagamento = " + Srelib.forcaponto(Convert.ToString(xvlr_pagamento)) +
                         " ,data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtpagamento)) +
                         " ,conta = " + xcontacorrente +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " and " +
                         " data_vencimento = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtvencimento));
            }

            if (SreDblib.GetParametro("BAIXA INATIVO") == "NAO")
            {
                script = script + " and " +
                                  " ativo =  1 ";
            }
            //
            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String GravaNossoNumero(string xproduto,
                                          string xgrupo,
                                          string xunidade,
                                          string xparte,
                                          string xdtvencimento,
                                          string xnossonumero)
    {
        //
        string script = "";
        if (xproduto != String.Empty)
        {
            if (xnossonumero != String.Empty)
            {
                //
                script = "";
                script = " UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " nossonumero = " + xnossonumero +
                         " WHERE " +
                         " produto = " + xproduto +
                         " and " +
                         " grupo = " + xgrupo +
                         " and " +
                         " unidade = " + xunidade +
                         " and " +
                         " parte = " + xparte +
                         " and " +
                         " data_vencimento = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtvencimento));

                SreDblib.ExecScript(script);
            }
        }
        return " ";
    }

    public static String GravaNossoNumeroID(string xproduto,
                                            string xgrupo,
                                            string xunidade,
                                            string xparte,
                                            string xdtvencimento,
                                            string xnossonumero,
                                            string xparcela_ID)
    {
        //
        string script = "";
        if (xproduto != String.Empty)
        {
            if (xnossonumero != String.Empty)
            {
                //
                script = "";
                script = " UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                         " SET " +
                         " nossonumero = " + xnossonumero +
                         " WHERE " +
                         " ID = " + xparcela_ID;

                SreDblib.ExecScript(script);
            }
        }
        return " ";
    }

    public static String GravaDesmembramento(string xproduto,
                                             string xgrupo,
                                             string xunidade,
                                             string xparte,
                                             string xID,
                                             decimal xvlr_parcela,
                                             decimal xvlr_base)
    {
        //
        if (xproduto != String.Empty)
        {
            string script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                            " SET " +
                            " vlr_parcela = " + Srelib.forcaponto(Convert.ToString(xvlr_parcela)) + ", " +
                            " vlr_base = " + Srelib.forcaponto(Convert.ToString(xvlr_base)) + " " +
                            " WHERE ID = " + xID;
            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String CorrecaoMensal(string xproduto_corrente,
                                        string xgrupo_corrente,
                                        string xgrupounidade_corrente,
                                        string xgrupounidadeparte_corrente,
                                        string xmeiolote_corrente,
                                        string xindexador_corrente,
                                        DateTime xdtbase_corrente,
                                        DateTime xdtperiodo_fim)
    {
        DataSet dsparcelas;
        //
        string MesLimite = xdtperiodo_fim.Month.ToString();
        string AnoLimite = xdtperiodo_fim.Year.ToString();
        string MesParcela = "";
        string AnoParcela = "";
        string MesBase = xdtbase_corrente.Month.ToString();
        string AnoBase = xdtbase_corrente.Year.ToString();
        DateTime dtpagamento = Convert.ToDateTime("01/01/1900");
        DateTime dtvencimento = Convert.ToDateTime("01/01/1900");
        DateTime dtvencimentomesanterior = Convert.ToDateTime("01/01/1900");
        //
        string IDparcela = "";
        //
        Double TaxaAcumulada = 0;
        Double TaxaMes = 0;
        Double vlr_pagamento = 0;
        Double vlr_parcela = 0;
        Double vlr_parcela_corrigida = 0;
        string script = "";

        //
        //Parcelas Selecionadas
        dsparcelas = uParcelas.PegaDadosParcelas2(xproduto_corrente,
                                                 xgrupo_corrente,
                                                 xgrupounidade_corrente,
                                                 xgrupounidadeparte_corrente,
                                                 xmeiolote_corrente,
                                                 "01/01/1900",
                                                 "31/12/2999",
                                                 "T",
                                                 "0",
                                                 "V",
                                                 true,
                                                 "1");
        //
        if (dsparcelas.Tables[0].Rows.Count != 0)
        {
            for (int i = 0; i < dsparcelas.Tables[0].Rows.Count; i++)
            {
                //
                IDparcela = dsparcelas.Tables[0].Rows[i]["ID"].ToString();
                MesParcela = Convert.ToDateTime(dsparcelas.Tables[0].Rows[i]["data_vencimento"].ToString().Substring(0, 10)).Month.ToString();
                AnoParcela = Convert.ToDateTime(dsparcelas.Tables[0].Rows[i]["data_vencimento"].ToString().Substring(0, 10)).Year.ToString(); ;
                dtpagamento = Convert.ToDateTime(dsparcelas.Tables[0].Rows[i]["data_pagamento"].ToString().Substring(0, 10));
                dtvencimento = Convert.ToDateTime(dsparcelas.Tables[0].Rows[i]["data_vencimento"].ToString().Substring(0, 10));
                dtvencimentomesanterior = dtvencimento.AddMonths(-1);
                vlr_pagamento = Convert.ToDouble(dsparcelas.Tables[0].Rows[i]["vlr_pagamento"]);
                vlr_parcela = Convert.ToDouble(dsparcelas.Tables[0].Rows[i]["vlr_original"]);
                //
                if (dtvencimento > xdtperiodo_fim)
                {
                    TaxaAcumulada = uTaxasMensais.PegaDadosTaxasMensaisAcumuladaNome(xindexador_corrente, xdtbase_corrente, xdtperiodo_fim);
                    TaxaMes = uTaxasMensais.PegaDadosTaxasMensaisNomeString(xindexador_corrente, xdtbase_corrente, dtvencimento);
                }
                else
                {
                    if ((xdtbase_corrente.Month == dtvencimento.Month) && (xdtbase_corrente.Year == dtvencimento.Year))
                    {
                        //1o. mes
                        TaxaAcumulada = 0;
                    }
                    else
                    {
                        TaxaAcumulada = uTaxasMensais.PegaDadosTaxasMensaisAcumuladaNome(xindexador_corrente, xdtbase_corrente, dtvencimentomesanterior);
                    }
                    TaxaMes = uTaxasMensais.PegaDadosTaxasMensaisNomeString(xindexador_corrente, xdtbase_corrente, dtvencimento);
                }
                //
                TaxaAcumulada = Math.Round(TaxaAcumulada, 4);
                TaxaMes = Math.Round(TaxaMes, 4);
                //               
                //
                vlr_parcela_corrigida = (vlr_parcela * ((TaxaAcumulada / 100) + 1));
                vlr_parcela_corrigida = Math.Round(vlr_parcela_corrigida, 4);
                //Ativa
                if (Convert.ToBoolean(dsparcelas.Tables[0].Rows[i]["ativa"]) == true)
                {
                    //Boleto Emitido
                    if (uParametros.PegaParametro("CORRIGE BOLETO") == "SIM")
                    {
                        //Parcela Paga
                        if (uParametros.PegaParametro("CORRIGE PAGA") == "SIM")
                        {
                            //
                            script = "";
                            script = "UPDATE parcelas_" + Srelib.QStr0(xproduto_corrente.Trim(), 5) + "_" + Srelib.QStr0(xgrupo_corrente.Trim(), 5) +
                                     " SET " +
                                     " vlr_parcela = " + Srelib.forcaponto(Convert.ToString(vlr_parcela_corrigida)) +
                                     " , indexador = " + Srelib.QStr(xindexador_corrente) +
                                     " , indexador_mes = " + String.Format("{0:0.########}", Srelib.forcaponto(TaxaMes.ToString())) +
                                     " , indexador_acumulado = " + String.Format("{0:0.########}", Srelib.forcaponto(TaxaAcumulada.ToString())) +
                                     " WHERE " +
                                     " ID = " + IDparcela;
                            SreDblib.ExecScript(script);
                        }
                        else
                        {
                            //Parcela em Aberto
                            if ((dtpagamento == Convert.ToDateTime("01/01/1900")) &&
                                (vlr_pagamento == 0))
                                //if ((dsparcelas.Tables[0].Rows[i]["data_pagamento"].ToString().Trim() == "01/01/1900") &&
                                //(dsparcelas.Tables[0].Rows[i]["vlr_pagamento"].ToString().Trim() == "0.00"))
                            {
                                //
                                script = "";
                                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto_corrente.Trim(), 5) + "_" + Srelib.QStr0(xgrupo_corrente.Trim(), 5) +
                                         " SET " +
                                         " vlr_parcela = " + Srelib.forcaponto(Convert.ToString(vlr_parcela_corrigida)) +
                                         " , indexador = " + Srelib.QStr(xindexador_corrente) +
                                         " , indexador_mes = " + String.Format("{0:0.########}", Srelib.forcaponto(TaxaMes.ToString())) +
                                         " , indexador_acumulado = " + String.Format("{0:0.########}", Srelib.forcaponto(TaxaAcumulada.ToString())) +
                                         " WHERE " +
                                         " ID = " + IDparcela;

                                SreDblib.ExecScript(script);
                            }
                        }
                    }

                }
            }
        }
        //
        return " ";
    }


    public static String CorrecaoAnual(string xproduto_corrente,
                                       string xgrupo_corrente,
                                       string xgrupounidade_corrente,
                                       string xgrupounidadeparte_corrente,
                                       string xmeiolote_corrente,
                                       string xindexador_corrente,
                                       DateTime xdtbase_corrente,
                                       DateTime xdtperiodo_fim)
    {
        DataSet dsparcelas;
        //
        string MesLimite = xdtperiodo_fim.Month.ToString();
        string AnoLimite = xdtperiodo_fim.Year.ToString();
        string MesParcela = "";
        string AnoParcela = "";
        string MesBase = xdtbase_corrente.Month.ToString();
        string AnoBase = xdtbase_corrente.Year.ToString();
        DateTime dtvencimento = Convert.ToDateTime("01/01/1900");
        DateTime dtvencimentomesanterior = Convert.ToDateTime("01/01/1900");
        DateTime ydtbase_corrente_final = xdtbase_corrente.AddMonths(12);
        if (ydtbase_corrente_final.Day != 1)
        {
            ydtbase_corrente_final = ydtbase_corrente_final.AddDays((ydtbase_corrente_final.Day - 1) * -1);
        }
        //
        string IDparcela = "";
        //
        Double TaxaAcumulada = 0;
        Double TaxaMes = 0;
        Double vlr_parcela = 0;
        Double vlr_parcela_corrigida = 0;
        Double vlr_residuo = 0;
        Double vlr_residuo_acumulado = 0;
        Int16 qtdparcelas = 0;
        string script = "";
        //
        Boolean Residuo = true;
        Double Residuo_diluido = 0;
        //
        //Parcelas Selecionadas
        dsparcelas = uParcelas.PegaDadosParcelas2(xproduto_corrente,
                                                 xgrupo_corrente,
                                                 xgrupounidade_corrente,
                                                 xgrupounidadeparte_corrente,
                                                 xmeiolote_corrente,
                                                 "01/01/1900",
                                                 "31/12/2999",
                                                 "T",
                                                 "0",
                                                 "V",
                                                 true,
                                                 "1");

        //
        //
        if (dsparcelas.Tables[0].Rows.Count != 0)
        {
            //Total de parcelas para resíduo diluido
            for (int i = 0; i < dsparcelas.Tables[0].Rows.Count; i++)
            {
                if (Convert.ToDateTime(dsparcelas.Tables[0].Rows[i]["data_vencimento"].ToString().Substring(0, 10)) >=
                    Convert.ToDateTime("01/" + Srelib.QStr0(xdtperiodo_fim.Month.ToString().Trim(), 2) + "/" + xdtperiodo_fim.Year))
                {
                    qtdparcelas++;
                }
            }
            //
            //Correção
            //Apuração do Resíduo do Período
            for (int i = 0; i < dsparcelas.Tables[0].Rows.Count; i++)
            {
                //
                IDparcela = dsparcelas.Tables[0].Rows[i]["ID"].ToString();
                MesParcela = Convert.ToDateTime(dsparcelas.Tables[0].Rows[i]["data_vencimento"].ToString().Substring(0, 10)).Month.ToString();
                AnoParcela = Convert.ToDateTime(dsparcelas.Tables[0].Rows[i]["data_vencimento"].ToString().Substring(0, 10)).Year.ToString(); ;
                dtvencimento = Convert.ToDateTime(dsparcelas.Tables[0].Rows[i]["data_vencimento"].ToString().Substring(0, 10));
                dtvencimentomesanterior = dtvencimento.AddMonths(-1);
                vlr_parcela = Convert.ToDouble(dsparcelas.Tables[0].Rows[i]["vlr_original"]);
                //
                //Vencimento dentro do Período a Partir da Ultima Correção até 12 meses Depois
                //
                if ((dtvencimento >= xdtbase_corrente) && (dtvencimento <= ydtbase_corrente_final))
                {
                    //
                    TaxaAcumulada = uTaxasMensais.PegaDadosTaxasMensaisAcumuladaNome(xindexador_corrente, xdtbase_corrente, dtvencimento);
                    TaxaMes = uTaxasMensais.PegaDadosTaxasMensaisNomeString(xindexador_corrente, dtvencimento, dtvencimento);
                    //
                }
                //
                TaxaAcumulada = Math.Round(TaxaAcumulada, 4);
                TaxaMes = Math.Round(TaxaMes, 4);
                //
                //Calculo do Resíduo do Mês
                vlr_residuo = vlr_parcela * ((TaxaAcumulada / 100));
                vlr_residuo = Math.Round(vlr_residuo, 4);
                vlr_residuo_acumulado = vlr_residuo_acumulado + vlr_residuo;
                //
                //Parcelas dentro do período do ano
                if ((dtvencimento <= ydtbase_corrente_final))
                {
                    //Ativa
                    if (Convert.ToBoolean(dsparcelas.Tables[0].Rows[i]["ativa"]) == true)
                    {
                        //Boleto Emitido
                        if (uParametros.PegaParametro("CORRIGE BOLETO") == "SIM")
                        {
                            //Parcela Paga
                            if (uParametros.PegaParametro("CORRIGE PAGA") == "SIM")
                            {
                                //
                                script = "";
                                if ((TaxaMes != 0) && (TaxaAcumulada != 0))
                                {
                                    script = "UPDATE parcelas_" + Srelib.QStr0(xproduto_corrente.Trim(), 5) + "_" + Srelib.QStr0(xgrupo_corrente.Trim(), 5) +
                                             " SET " +
                                             " residuo_mes = " + Srelib.forcaponto(Convert.ToString(vlr_residuo)) +
                                             " , residuo_acumulado = " + Srelib.forcaponto(Convert.ToString(vlr_residuo_acumulado)) +
                                             " , indexador = " + Srelib.QStr(xindexador_corrente) +
                                             " , indexador_mes = " + String.Format("{0:0.########}", Srelib.forcaponto(TaxaMes.ToString())) +
                                             " , indexador_acumulado = " + String.Format("{0:0.########}", Srelib.forcaponto(TaxaAcumulada.ToString())) +
                                             " WHERE " +
                                             " ID = " + IDparcela;
                                    SreDblib.ExecScript(script);
                                }
                            }
                            else
                            {
                                //Parcela em Aberto
                                if ((dsparcelas.Tables[0].Rows[i]["data_pagamento"].ToString().Trim() == "01/01/1900") &&
                                    (dsparcelas.Tables[0].Rows[i]["vlr_pagamento"].ToString().Trim() == "0.00"))
                                {
                                    //
                                    script = "";
                                    script = "UPDATE parcelas_" + Srelib.QStr0(xproduto_corrente.Trim(), 5) + "_" + Srelib.QStr0(xgrupo_corrente.Trim(), 5) +
                                             " SET " +
                                             " vlr_parcela = " + Srelib.forcaponto(Convert.ToString(vlr_residuo)) +
                                             " , vlr_original = " + Srelib.forcaponto(Convert.ToString(vlr_residuo)) +
                                             " , indexador = " + Srelib.QStr(xindexador_corrente) +
                                             " , indexador_mes = " + String.Format("{0:0.########}", Srelib.forcaponto(TaxaMes.ToString())) +
                                             " , indexador_acumulado = " + String.Format("{0:0.########}", Srelib.forcaponto(TaxaAcumulada.ToString())) +
                                             " WHERE " +
                                             " ID = " + IDparcela;

                                    SreDblib.ExecScript(script);
                                }
                            }
                        }
                    }
                }
                else
                {
                    //Criar parcela Resíduo Separado ou Diluir resíduo nas parcelas restantes
                    //
                    if (Residuo)
                    {
                        if (uParametros.PegaParametro("RESIDUO 13 PARCELA") == "SIM")
                        {
                            if (uParametros.PegaParametro("RESIDUO 13 SEPARADO") == "SIM")
                            {
                                //Cria Parcela de Resíduo em Separado
                                //
                                uParcelas.Grava(xproduto_corrente,
                                                xgrupo_corrente,
                                                xgrupounidade_corrente,
                                                xgrupounidadeparte_corrente,
                                                "99",
                                                "R",
                                                dtvencimento.ToString().Substring(0, 10),
                                                Math.Round(Convert.ToDecimal(vlr_residuo_acumulado - vlr_residuo), 2),
                                                "01/01/1900",
                                                0,
                                                "01/01/1900",
                                                Math.Round(Convert.ToDecimal(vlr_residuo_acumulado - vlr_residuo), 2),
                                                "01/01/1900",
                                                Math.Round(Convert.ToDecimal(vlr_residuo_acumulado - vlr_residuo), 2),
                                                "",
                                                "",
                                                1,
                                                0,
                                                0,
                                                0,
                                                1,
                                                Convert.ToDecimal(uParametros.PegaParametro("MULTA")),
                                                Convert.ToDecimal(uParametros.PegaParametro("COMISSAO TAXA")),
                                                0,
                                                0,
                                                0,
                                                "a.m.",
                                                "01/01/1900",
                                                "0",
                                                xindexador_corrente,
                                                0,
                                                0,
                                                0,
                                                0,
                                                0,
                                                "RESÍDUO CORREÇÃO ANUAL");
                                Residuo = false;
                                //
                                uVendas.GravaNovaDataBase(xproduto_corrente,
                                                          xgrupo_corrente,
                                                          xgrupounidade_corrente,
                                                          xgrupounidadeparte_corrente,
                                                          xdtbase_corrente.AddYears(1).ToString().Substring(0, 10));
                                //
                            }
                            else
                            {
                                //Resíduo Diluido nas Parcelas
                                if (qtdparcelas > 0)
                                {
                                    Residuo_diluido = (vlr_residuo_acumulado - vlr_residuo) / qtdparcelas;
                                }
                                else
                                {
                                    //Não existem mais parcelas, cria parcela nova com o Resíduo
                                    //
                                    uParcelas.Grava(xproduto_corrente,
                                                    xgrupo_corrente,
                                                    xgrupounidade_corrente,
                                                    xgrupounidadeparte_corrente,
                                                    "99",
                                                    "R",
                                                    xdtbase_corrente.AddYears(1).ToString().Substring(0, 10),
                                                    Math.Round(Convert.ToDecimal(vlr_residuo_acumulado - vlr_residuo), 2),
                                                    "01/01/1900",
                                                    0,
                                                    "01/01/1900",
                                                    Math.Round(Convert.ToDecimal(vlr_residuo_acumulado - vlr_residuo), 2),
                                                    "01/01/1900",
                                                    Math.Round(Convert.ToDecimal(vlr_residuo_acumulado - vlr_residuo), 2),
                                                    "",
                                                    "",
                                                    1,
                                                    0,
                                                    0,
                                                    0,
                                                    1,
                                                    Convert.ToDecimal(uParametros.PegaParametro("MULTA")),
                                                    Convert.ToDecimal(uParametros.PegaParametro("COMISSAO TAXA")),
                                                    0,
                                                    0,
                                                    0,
                                                    "a.m.",
                                                    "01/01/1900",
                                                    "0",
                                                    xindexador_corrente,
                                                    0,
                                                    0,
                                                    0,
                                                    0,
                                                    0,
                                                    "RESÍDUO CORREÇÃO ANUAL FINAL");
                                }
                                //
                                uVendas.GravaNovaDataBase(xproduto_corrente,
                                                          xgrupo_corrente,
                                                          xgrupounidade_corrente,
                                                          xgrupounidadeparte_corrente,
                                                          xdtbase_corrente.AddYears(1).ToString().Substring(0, 10));
                                //
                            }
                        }
                    }
                    else
                    {
                        //
                        uVendas.GravaNovaDataBase(xproduto_corrente,
                                                  xgrupo_corrente,
                                                  xgrupounidade_corrente,
                                                  xgrupounidadeparte_corrente,
                                                  xdtbase_corrente.AddYears(1).ToString().Substring(0, 10));
                        //
                    }
                    //
                    //Parcelas após o período do ano
                    vlr_parcela_corrigida = Residuo_diluido + (vlr_parcela * ((TaxaAcumulada / 100) + 1));
                    //Ativa
                    if (Convert.ToBoolean(dsparcelas.Tables[0].Rows[i]["ativa"]) == true)
                    {
                        //Boleto Emitido
                        if (uParametros.PegaParametro("CORRIGE BOLETO") == "SIM")
                        {
                            //Parcela Paga
                            if (uParametros.PegaParametro("CORRIGE PAGA") == "SIM")
                            {
                                //
                                script = "";
                                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto_corrente.Trim(), 5) + "_" + Srelib.QStr0(xgrupo_corrente.Trim(), 5) +
                                         " SET " +
                                         " vlr_parcela = " + Srelib.forcaponto(Convert.ToString(vlr_parcela_corrigida)) +
                                         " , vlr_original = " + Srelib.forcaponto(Convert.ToString(vlr_parcela_corrigida)) +
                                         " , indexador_mes = " + String.Format("{0:0.########}", Srelib.forcaponto(TaxaMes.ToString())) +
                                         " , indexador_acumulado = " + String.Format("{0:0.########}", Srelib.forcaponto(TaxaAcumulada.ToString())) +
                                         " , residuo_mes = 0 " +
                                         " , residuo_acumulado = 0 " +
                                         " WHERE " +
                                         " ID = " + IDparcela;

                                SreDblib.ExecScript(script);
                            }
                            else
                            {
                                //Parcela em Aberto
                                if ((dsparcelas.Tables[0].Rows[i]["data_pagamento"].ToString().Trim() == "01/01/1900") &&
                                    (dsparcelas.Tables[0].Rows[i]["vlr_pagamento"].ToString().Trim() == "0.00"))
                                {
                                    //
                                    script = "";
                                    script = "UPDATE parcelas_" + Srelib.QStr0(xproduto_corrente.Trim(), 5) + "_" + Srelib.QStr0(xgrupo_corrente.Trim(), 5) +
                                             " SET " +
                                             " vlr_parcela = " + Srelib.forcaponto(Convert.ToString(vlr_parcela_corrigida)) +
                                             " , vlr_original = " + Srelib.forcaponto(Convert.ToString(vlr_parcela_corrigida)) +
                                             " , indexador = " + Srelib.QStr(xindexador_corrente) +
                                             " , indexador_mes = " + String.Format("{0:0.########}", Srelib.forcaponto(TaxaMes.ToString())) +
                                             " , indexador_acumulado = " + String.Format("{0:0.########}", Srelib.forcaponto(TaxaAcumulada.ToString())) +
                                             " , residuo_mes = 0 " +
                                             " , residuo_acumulado = 0 " +
                                             " WHERE " +
                                             " ID = " + IDparcela;

                                    SreDblib.ExecScript(script);
                                }
                            }
                        }

                    }
                }
            }
        }
        //
        return " ";
    }

    public static string GravaNovaParcelaBase(string xproduto,
                                              string xgrupo,
                                              string xunidade,
                                              string xparte,
                                              string xdata_base)
    {
        // Grava nova parcela base = correção anual
        //
        string script = "";
        script = "UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                " SET " +
        " vlr_original = vlr_parcela " +
        " WHERE (produto = " + xproduto + " " +
        " AND grupo = " + xgrupo + " " +
        " AND unidade = " + xunidade + " " +
        " AND parte = " + xparte +
        " AND data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_base)) + " " + ") ";
        //
        SreDblib.ExecScript(script);
        //
        return " ";
    }

    public static String CorrecaoMensalTP(string xproduto_corrente,
                                          string xgrupo_corrente,
                                          string xgrupounidade_corrente,
                                          string xgrupounidadeparte_corrente,
                                          string xmeiolote_corrente,
                                          string xindexador_corrente,
                                          string xjuros_corrente,
                                          DateTime xdtbase_corrente,
                                          DateTime xdtperiodo_fim)
    {
        DataSet dsparcelas;
        //
        string MesLimite = xdtperiodo_fim.Month.ToString();
        string AnoLimite = xdtperiodo_fim.Year.ToString();
        string MesParcela = "";
        string AnoParcela = "";
        string MesBase = xdtbase_corrente.Month.ToString();
        string AnoBase = xdtbase_corrente.Year.ToString();
        DateTime dtvencimento = Convert.ToDateTime("01/01/1900");
        DateTime dtvencimentomesanterior = Convert.ToDateTime("01/01/1900");
        //
        string IDparcela = "";
        //
        Double JurosAcumulado = 0;
        //
        Double TaxaResultante = 0;
        Double TaxaAcumulada = 0;
        Double TaxaMes = 0;
        Double JurosMes = 0;
        Double vlr_parcela = 0;
        Double vlr_parcela_corrigida = 0;
        string script = "";

        //
        //Parcelas Selecionadas
        dsparcelas = uParcelas.PegaDadosParcelas2(xproduto_corrente,
                                                 xgrupo_corrente,
                                                 xgrupounidade_corrente,
                                                 xgrupounidadeparte_corrente,
                                                 xmeiolote_corrente,
                                                 "01/01/1900",
                                                 "31/12/2999",
                                                 "T",
                                                 "0",
                                                 "V",
                                                 true,
                                                 "1");
        //
        if (dsparcelas.Tables[0].Rows.Count != 0)
        {
            for (int i = 0; i < dsparcelas.Tables[0].Rows.Count; i++)
            {
                //
                IDparcela = dsparcelas.Tables[0].Rows[i]["ID"].ToString();
                MesParcela = Convert.ToDateTime(dsparcelas.Tables[0].Rows[i]["data_vencimento"].ToString().Substring(0, 10)).Month.ToString();
                AnoParcela = Convert.ToDateTime(dsparcelas.Tables[0].Rows[i]["data_vencimento"].ToString().Substring(0, 10)).Year.ToString(); ;
                dtvencimento = Convert.ToDateTime(dsparcelas.Tables[0].Rows[i]["data_vencimento"].ToString().Substring(0, 10));
                dtvencimentomesanterior = dtvencimento.AddMonths(-1);
                //
                vlr_parcela = Convert.ToDouble(dsparcelas.Tables[0].Rows[i]["vlr_parcelas_jurosprice"]);
                //vlr_parcela = Convert.ToDouble(dsparcelas.Tables[0].Rows[i]["vlr_original"]);
                //
                if (dtvencimento > xdtperiodo_fim)
                {
                    JurosAcumulado = uTaxasMensais.PegaDadosTaxasMensaisAcumuladaNome(xjuros_corrente, xdtbase_corrente, xdtperiodo_fim);
                    TaxaAcumulada = uTaxasMensais.PegaDadosTaxasMensaisAcumuladaNome(xindexador_corrente, xdtbase_corrente, xdtperiodo_fim);
                    JurosMes = uTaxasMensais.PegaDadosTaxasMensaisNomeString(xjuros_corrente, xdtbase_corrente, dtvencimento);
                    TaxaMes = uTaxasMensais.PegaDadosTaxasMensaisNomeString(xindexador_corrente, xdtbase_corrente, dtvencimento);
                }
                else
                {
                    if ((xdtbase_corrente.Month == dtvencimento.Month) && (xdtbase_corrente.Year == dtvencimento.Year))
                    {
                        //1o. mes
                        TaxaAcumulada = 0;
                        JurosAcumulado = 0;
                    }
                    else
                    {
                        JurosAcumulado = uTaxasMensais.PegaDadosTaxasMensaisAcumuladaNome(xjuros_corrente, xdtbase_corrente, dtvencimentomesanterior);
                        TaxaAcumulada = uTaxasMensais.PegaDadosTaxasMensaisAcumuladaNome(xindexador_corrente, xdtbase_corrente, dtvencimentomesanterior);
                    }
                    TaxaMes = uTaxasMensais.PegaDadosTaxasMensaisNomeString(xindexador_corrente, xdtbase_corrente, dtvencimento);
                    JurosMes = uTaxasMensais.PegaDadosTaxasMensaisNomeString(xjuros_corrente, xdtbase_corrente, dtvencimento);
                }
                //
                //Juntar Taxa Acumulada e Juros 
                TaxaResultante = (((TaxaAcumulada / 100) + 1) * ((JurosAcumulado / 100) + 1));
                TaxaResultante = ((TaxaResultante - 1) * 100);
                TaxaResultante = Math.Round(TaxaResultante, 4);
                //
                TaxaAcumulada = Math.Round(TaxaAcumulada, 4);
                JurosAcumulado = Math.Round(JurosAcumulado, 4);
                TaxaMes = Math.Round(TaxaMes, 4);
                JurosMes = Math.Round(JurosMes, 4);
                //               
                //
                vlr_parcela_corrigida = (vlr_parcela * ((TaxaResultante / 100) + 1));
                vlr_parcela_corrigida = Math.Round(vlr_parcela_corrigida, 4);
                //Ativa
                if (Convert.ToBoolean(dsparcelas.Tables[0].Rows[i]["ativa"]) == true)
                {
                    //Boleto Emitido
                    if (uParametros.PegaParametro("CORRIGE BOLETO") == "SIM")
                    {
                        //Parcela Paga
                        if (uParametros.PegaParametro("CORRIGE PAGA") == "SIM")
                        {
                            //
                            script = "";
                            script = "UPDATE parcelas_" + Srelib.QStr0(xproduto_corrente.Trim(), 5) + "_" + Srelib.QStr0(xgrupo_corrente.Trim(), 5) +
                                     " SET " +
                                     " vlr_parcela = " + Srelib.forcaponto(Convert.ToString(vlr_parcela_corrigida)) +
                                     " , indexador = " + Srelib.QStr(xindexador_corrente) +
                                     " , indexador_mes = " + String.Format("{0:0.########}", Srelib.forcaponto(TaxaMes.ToString())) +
                                     " , indexador_acumulado = " + String.Format("{0:0.########}", Srelib.forcaponto(TaxaAcumulada.ToString())) +
                                     " WHERE " +
                                     " ID = " + IDparcela;
                            SreDblib.ExecScript(script);
                        }
                        else
                        {
                            //Parcela em Aberto
                            if ((dsparcelas.Tables[0].Rows[i]["data_pagamento"].ToString().Trim() == "01/01/1900") &&
                                (dsparcelas.Tables[0].Rows[i]["vlr_pagamento"].ToString().Trim() == "0.00"))
                            {
                                //
                                script = "";
                                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto_corrente.Trim(), 5) + "_" + Srelib.QStr0(xgrupo_corrente.Trim(), 5) +
                                         " SET " +
                                         " vlr_parcela = " + Srelib.forcaponto(Convert.ToString(vlr_parcela_corrigida)) +
                                         " , indexador = " + Srelib.QStr(xindexador_corrente) +
                                         " , indexador_mes = " + String.Format("{0:0.########}", Srelib.forcaponto(TaxaMes.ToString())) +
                                         " , indexador_acumulado = " + String.Format("{0:0.########}", Srelib.forcaponto(TaxaAcumulada.ToString())) +
                                         " WHERE " +
                                         " ID = " + IDparcela;

                                SreDblib.ExecScript(script);
                            }
                        }
                    }

                }
            }
        }
        //
        return " ";
    }


    public static String CorrecaoAnualTP(string xproduto_corrente,
                                       string xgrupo_corrente,
                                       string xgrupounidade_corrente,
                                       string xgrupounidadeparte_corrente,
                                       string xindexador_corrente,
                                       string xjuros_corrente,
                                       DateTime xdtbase_corrente,
                                       DateTime xdtperiodo_fim)
    {
        DataSet dsparcelas;
        //
        string MesLimite = xdtperiodo_fim.Month.ToString();
        string AnoLimite = xdtperiodo_fim.Year.ToString();
        string MesParcela = "";
        string AnoParcela = "";
        string MesBase = xdtbase_corrente.Month.ToString();
        string AnoBase = xdtbase_corrente.Year.ToString();
        DateTime dtvencimento = Convert.ToDateTime("01/01/1900");
        DateTime dtvencimentomesanterior = Convert.ToDateTime("01/01/1900");
        DateTime ydtbase_corrente_final = xdtbase_corrente.AddMonths(12);
        if (ydtbase_corrente_final.Day != 1)
        {
            ydtbase_corrente_final = ydtbase_corrente_final.AddDays((ydtbase_corrente_final.Day - 1) * -1);
        }
        //
        string IDparcela = "";
        //
        Double TaxaResultante = 0;
        Double TaxaAcumulada = 0;
        Double JurosAcumulado = 0;
        Double TaxaMes = 0;
        Double JurosMes = 0;
        Double vlr_parcela = 0;
        Double vlr_parcela_corrigida = 0;
        Double vlr_residuo = 0;
        Double vlr_residuo_acumulado = 0;
        Int16 qtdparcelas = 0;
        string script = "";
        //
        //Parcelas Selecionadas
        dsparcelas = uParcelas.PegaDadosParcelas2(xproduto_corrente,
                                                 xgrupo_corrente,
                                                 xgrupounidade_corrente,
                                                 xgrupounidadeparte_corrente,
                                                 "01/01/1900",
                                                 "31/12/2999",
                                                 "1",
                                                 "T",
                                                 "0",
                                                 "V",
                                                 true,
                                                 "1");
        //
        if (dsparcelas.Tables[0].Rows.Count != 0)
        {
            //Total de parcelas para resíduo diluido
            for (int i = 0; i < dsparcelas.Tables[0].Rows.Count; i++)
            {
                if (Convert.ToDateTime(dsparcelas.Tables[0].Rows[i]["data_vencimento"].ToString().Substring(0, 10)) >=
                    Convert.ToDateTime("01/" + Srelib.QStr0(xdtperiodo_fim.Month.ToString().Trim(), 2) + "/" + xdtperiodo_fim.Year))
                {
                    qtdparcelas++;
                }
            }
            //
            //Correção
            //Apuração do Resíduo do Período
            for (int i = 0; i < dsparcelas.Tables[0].Rows.Count; i++)
            {
                //
                IDparcela = dsparcelas.Tables[0].Rows[i]["ID"].ToString();
                MesParcela = Convert.ToDateTime(dsparcelas.Tables[0].Rows[i]["data_vencimento"].ToString().Substring(0, 10)).Month.ToString();
                AnoParcela = Convert.ToDateTime(dsparcelas.Tables[0].Rows[i]["data_vencimento"].ToString().Substring(0, 10)).Year.ToString(); ;
                dtvencimento = Convert.ToDateTime(dsparcelas.Tables[0].Rows[i]["data_vencimento"].ToString().Substring(0, 10));
                dtvencimentomesanterior = dtvencimento.AddMonths(-1);
                vlr_parcela = Convert.ToDouble(dsparcelas.Tables[0].Rows[i]["vlr_original"]);
                //
                //Vencimento dentro do Período a Partir da Ultima Correção até 12 meses Depois
                //
                if ((dtvencimento >= xdtbase_corrente) && (dtvencimento < ydtbase_corrente_final))
                {
                    //
                    JurosAcumulado = uTaxasMensais.PegaDadosTaxasMensaisAcumuladaNome(xjuros_corrente, xdtbase_corrente, dtvencimento);
                    JurosMes = uTaxasMensais.PegaDadosTaxasMensaisNomeString(xjuros_corrente, xdtbase_corrente, dtvencimento);
                    //
                    TaxaAcumulada = uTaxasMensais.PegaDadosTaxasMensaisAcumuladaNome(xindexador_corrente, xdtbase_corrente, dtvencimento);
                    TaxaMes = uTaxasMensais.PegaDadosTaxasMensaisNomeString(xindexador_corrente, xdtbase_corrente, dtvencimento);
                    //
                }
                //Juntar Taxa Acumulada e Juros 
                TaxaResultante = (((TaxaAcumulada / 100) + 1) * ((JurosAcumulado / 100) + 1));
                TaxaResultante = ((TaxaResultante - 1) * 100);
                TaxaResultante = Math.Round(TaxaResultante, 4);
                //
                TaxaAcumulada = Math.Round(TaxaAcumulada, 4);
                JurosAcumulado = Math.Round(JurosAcumulado, 4);
                TaxaMes = Math.Round(TaxaMes, 4);
                JurosMes = Math.Round(JurosMes, 4);
                //
                //Calculo do Resíduo do Mês
                vlr_residuo = vlr_parcela * ((TaxaAcumulada / 100));
                vlr_residuo = Math.Round(vlr_residuo, 4);
                vlr_residuo_acumulado = vlr_residuo_acumulado + vlr_residuo;
                //Parcelas dentro do período do ano
                if ((dtvencimento < ydtbase_corrente_final))
                {
                    //Ativa
                    if (Convert.ToBoolean(dsparcelas.Tables[0].Rows[i]["ativa"]) == true)
                    {
                        //Boleto Emitido
                        if (uParametros.PegaParametro("CORRIGE BOLETO") == "SIM")
                        {
                            //Parcela Paga
                            if (uParametros.PegaParametro("CORRIGE PAGA") == "SIM")
                            {
                                //
                                script = "";
                                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto_corrente.Trim(), 5) + "_" + Srelib.QStr0(xgrupo_corrente.Trim(), 5) +
                                         " SET " +
                                         " residuo_mes = " + Srelib.forcaponto(Convert.ToString(vlr_residuo)) +
                                         " , residuo_acumulado = " + Srelib.forcaponto(Convert.ToString(vlr_residuo_acumulado)) +
                                         " , indexador = " + Srelib.QStr(xindexador_corrente) +
                                         " , indexador_mes = " + String.Format("{0:0.########}", Srelib.forcaponto(TaxaMes.ToString())) +
                                         " , indexador_acumulado = " + String.Format("{0:0.########}", Srelib.forcaponto(TaxaAcumulada.ToString())) +
                                         " WHERE " +
                                         " ID = " + IDparcela;
                                SreDblib.ExecScript(script);
                            }
                            else
                            {
                                //Parcela em Aberto
                                if ((dsparcelas.Tables[0].Rows[i]["data_pagamento"].ToString().Trim() == "01/01/1900") &&
                                    (dsparcelas.Tables[0].Rows[i]["vlr_pagamento"].ToString().Trim() == "0.00"))
                                {
                                    //
                                    script = "";
                                    script = "UPDATE parcelas_" + Srelib.QStr0(xproduto_corrente.Trim(), 5) + "_" + Srelib.QStr0(xgrupo_corrente.Trim(), 5) +
                                             " SET " +
                                             " vlr_parcela = " + Srelib.forcaponto(Convert.ToString(vlr_residuo)) +
                                             " , indexador = " + Srelib.QStr(xindexador_corrente) +
                                             " , indexador_mes = " + String.Format("{0:0.########}", Srelib.forcaponto(TaxaMes.ToString())) +
                                             " , indexador_acumulado = " + String.Format("{0:0.########}", Srelib.forcaponto(TaxaAcumulada.ToString())) +
                                             " WHERE " +
                                             " ID = " + IDparcela;

                                    SreDblib.ExecScript(script);
                                }
                            }
                        }

                    }
                }
                else
                {
                    //Criar parcela Resíduo Separado ou Diluir resíduo nas parcelas restantes
                    //
                    //
                    //Parcelas após o período do ano
                    vlr_parcela_corrigida = (vlr_parcela * ((TaxaAcumulada / 100) - 1));
                    //Ativa
                    if (Convert.ToBoolean(dsparcelas.Tables[0].Rows[i]["ativa"]) == true)
                    {
                        //Boleto Emitido
                        if (uParametros.PegaParametro("CORRIGE BOLETO") == "SIM")
                        {
                            //Parcela Paga
                            if (uParametros.PegaParametro("CORRIGE PAGA") == "SIM")
                            {
                                //
                                script = "";
                                script = "UPDATE parcelas_" + Srelib.QStr0(xproduto_corrente.Trim(), 5) + "_" + Srelib.QStr0(xgrupo_corrente.Trim(), 5) +
                                         " SET " +
                                         " vlr_parcela = " + Srelib.forcaponto(Convert.ToString(vlr_parcela_corrigida)) +
                                         " , indexador = " + Srelib.QStr(xindexador_corrente) +
                                         " , indexador_mes = 0 " +
                                         " , indexador_acumulado = " + String.Format("{0:0.########}", Srelib.forcaponto(TaxaAcumulada.ToString())) +
                                         " , residuo_mes = 0 " +
                                         " , residuo_acumulado = 0 " +
                                         " WHERE " +
                                         " ID = " + IDparcela;

                                SreDblib.ExecScript(script);
                            }
                            else
                            {
                                //Parcela em Aberto
                                if ((dsparcelas.Tables[0].Rows[i]["data_pagamento"].ToString().Trim() == "01/01/1900") &&
                                    (dsparcelas.Tables[0].Rows[i]["vlr_pagamento"].ToString().Trim() == "0.00"))
                                {
                                    //
                                    script = "";
                                    script = "UPDATE parcelas_" + Srelib.QStr0(xproduto_corrente.Trim(), 5) + "_" + Srelib.QStr0(xgrupo_corrente.Trim(), 5) +
                                             " SET " +
                                             " vlr_parcela = " + Srelib.forcaponto(Convert.ToString(vlr_parcela_corrigida)) +
                                             " , indexador = " + Srelib.QStr(xindexador_corrente) +
                                             " , indexador_mes = 0 " +
                                             " , indexador_acumulado = " + String.Format("{0:0.########}", Srelib.forcaponto(TaxaAcumulada.ToString())) +
                                             " , residuo_mes = 0 " +
                                             " , residuo_acumulado = 0 " +
                                             " WHERE " +
                                             " ID = " + IDparcela;

                                    SreDblib.ExecScript(script);
                                }
                            }
                        }

                    }
                }
            }
        }
        //
        return " ";
    }


    public static String PegaValorParcela(string xproduto,
                                          string xgrupo,
                                          string xunidade,
                                          string xparte,
                                          string xproprietario,
                                          string xvencimento)
    {
        string nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);
        string script = "";
        if (xparte == "0")
        {
            script = "SELECT vlr_parcela FROM " + nomearquivo + " WITH(NOLOCK) WHERE " +
                                                " ativa = 1 " +
                                                " and " +
                                                " produto = " + xproduto +
                                                " and " +
                                                " grupo = " + xgrupo +
                                                " and " +
                                                " unidade = " + xunidade +
                                                " and " +
                                                " parte = " + xparte +
                                                " and " +
                                                " data_vencimento = " + Srelib.QStr(Srelib.DataAmericanasembarra(xvencimento));
        }
        else
        {
            //Parte = 1
            if (xproprietario == "1")
            {
                script = "SELECT vlr_parcela FROM " + nomearquivo + " WITH(NOLOCK) WHERE " +
                                                    " ativa = 1 " +
                                                    " and " +
                                                    " produto = " + xproduto +
                                                    " and " +
                                                    " grupo = " + xgrupo +
                                                    " and " +
                                                    " unidade = " + xunidade +
                                                    " and " +
                                                    " parte = " + xproprietario +
                                                    " and " +
                                                    " data_vencimento = " + Srelib.QStr(Srelib.DataAmericanasembarra(xvencimento));
            }
            else
            {
                //Parte = 2
                script = "SELECT vlr_parcela FROM " + nomearquivo + " WITH(NOLOCK) WHERE " +
                                                    " ativa = 1 " +
                                                    " and " +
                                                    " produto = " + xproduto +
                                                    " and " +
                                                    " grupo = " + xgrupo +
                                                    " and " +
                                                    " unidade = " + xunidade +
                                                    " and " +
                                                    " parte = " + xproprietario +
                                                    " and " +
                                                    " data_vencimento = " + Srelib.QStr(Srelib.DataAmericanasembarra(xvencimento));
            }
        }

        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }


    public static String PegaValorParcelaNumeroParcela(string xproduto,
                                                       string xgrupo,
                                                       string xunidade,
                                                       string xparte,
                                                       string xproprietario,
                                                       string xvencimento,
                                                       string xnumeroparcela)
    {
        string nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);
        string script = "";
        if (xparte == "0")
        {
            script = "SELECT vlr_parcela FROM " + nomearquivo + " WITH(NOLOCK) WHERE " +
                                                " ativa = 1 " +
                                                " and " +
                                                " produto = " + xproduto +
                                                " and " +
                                                " grupo = " + xgrupo +
                                                " and " +
                                                " unidade = " + xunidade +
                                                " and " +
                                                " parte = " + xparte +
                                                " and " +
                                                " parcela = " + Srelib.QStr(xnumeroparcela);
        }
        else
        {
            //Parte = 1
            if (xproprietario == "1")
            {
                script = "SELECT vlr_parcela FROM " + nomearquivo + " WITH(NOLOCK) WHERE " +
                                                    " ativa = 1 " +
                                                    " and " +
                                                    " produto = " + xproduto +
                                                    " and " +
                                                    " grupo = " + xgrupo +
                                                    " and " +
                                                    " unidade = " + xunidade +
                                                    " and " +
                                                    " parte = " + xproprietario +
                                                    " and " +
                                                    " parcela = " + Srelib.QStr(xnumeroparcela);
            }
            else
            {
                //Parte = 2
                script = "SELECT vlr_parcela FROM " + nomearquivo + " WITH(NOLOCK) WHERE " +
                                                    " ativa = 1 " +
                                                    " and " +
                                                    " produto = " + xproduto +
                                                    " and " +
                                                    " grupo = " + xgrupo +
                                                    " and " +
                                                    " unidade = " + xunidade +
                                                    " and " +
                                                    " parte = " + xproprietario +
                                                    " and " +
                                                    " parcela = " + Srelib.QStr(xnumeroparcela);
            }
        }

        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }


    public static String PegaIDParcela(string xproduto,
                                       string xgrupo,
                                       string xunidade,
                                       string xparte,
                                       string xproprietario,
                                       string xvencimento)
    {
        string nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);
        string script = "";
        if (xparte == "0")
        {
            script = "SELECT ID FROM " + nomearquivo + " WITH(NOLOCK) WHERE " +
                                         " ativa = 1 " +
                                         " and " +
                                         " produto = " + xproduto +
                                         " and " +
                                         " grupo = " + xgrupo +
                                         " and " +
                                         " unidade = " + xunidade +
                                         " and " +
                                         " parte = " + xparte +
                                         " and " +
                                         " data_vencimento = " + Srelib.QStr(Srelib.DataAmericanasembarra(xvencimento));
        }
        else
        {
            //Parte = 1
            if (xproprietario == "1")
            {
                script = "SELECT ID FROM " + nomearquivo + " WITH(NOLOCK) WHERE " +
                                             " ativa = 1 " +
                                             " and " +
                                             " produto = " + xproduto +
                                             " and " +
                                             " grupo = " + xgrupo +
                                             " and " +
                                             " unidade = " + xunidade +
                                             " and " +
                                             " parte = " + xproprietario +
                                             " and " +
                                             " data_vencimento = " + Srelib.QStr(Srelib.DataAmericanasembarra(xvencimento));
            }
            else
            {
                //Parte = 2
                script = "SELECT ID FROM " + nomearquivo + " WITH(NOLOCK) WHERE " +
                                             " ativa = 1 " +
                                             " and " +
                                             " produto = " + xproduto +
                                             " and " +
                                             " grupo = " + xgrupo +
                                             " and " +
                                             " unidade = " + xunidade +
                                             " and " +
                                             " parte = " + xproprietario +
                                             " and " +
                                             " data_vencimento = " + Srelib.QStr(Srelib.DataAmericanasembarra(xvencimento));
            }
        }

        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static DateTime PegaUltimoVencimento(string xproduto,
                                              string xgrupo,
                                              string xunidade,
                                              string xparte,
                                              string xproprietario)
    {
        string nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);
        string script = "";
        if (xparte == "0")
        {
            script = "SELECT TOP 1 data_vencimento FROM " + nomearquivo + " WITH(NOLOCK) WHERE " +
                                         " produto = " + xproduto +
                                         " and " +
                                         " grupo = " + xgrupo +
                                         " and " +
                                         " unidade = " + xunidade +
                                         " and " +
                                         " parte = " + xparte +
                                         " order by data_vencimento DESC ";
        }
        else
        {
            //Parte = 1
            if (xproprietario == "1")
            {
                script = "SELECT TOP 1 data_vencimento FROM " + nomearquivo + " WITH(NOLOCK) WHERE " +
                                             " produto = " + xproduto +
                                             " and " +
                                             " grupo = " + xgrupo +
                                             " and " +
                                             " unidade = " + xunidade +
                                             " and " +
                                             " parte = " + xproprietario +
                                             " order by data_vencimento DESC ";
            }
            else
            {
                //Parte = 2
                script = "SELECT TOP 1 data_vencimento FROM " + nomearquivo + " WITH(NOLOCK) WHERE " +
                                             " produto = " + xproduto +
                                             " and " +
                                             " grupo = " + xgrupo +
                                             " and " +
                                             " unidade = " + xunidade +
                                             " and " +
                                             " parte = " + xproprietario +
                                             " order by data_vencimento DESC ";
            }
        }

        try
        {
            return Convert.ToDateTime(SreDblib.GetCampoScript(script));
        }
        catch
        {
            return Convert.ToDateTime("01/01/1900");
        }
    }
    public static String PegaIDParcelaNumeroParcela(string xproduto,
                                                    string xgrupo,
                                                    string xunidade,
                                                    string xparte,
                                                    string xproprietario,
                                                    string xvencimento,
                                                    string xnumeroparcela)
    {
        string nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);
        string script = "";
        if (xparte == "0")
        {
            script = "SELECT ID FROM " + nomearquivo + " WITH(NOLOCK) WHERE " +
                                         " ativa = 1 " +
                                         " and " +
                                         " produto = " + xproduto +
                                         " and " +
                                         " grupo = " + xgrupo +
                                         " and " +
                                         " unidade = " + xunidade +
                                         " and " +
                                         " parte = " + xparte +
                                         " and " +
                                         " parcela = " + Srelib.QStr(xnumeroparcela);
        }
        else
        {
            //Parte = 1
            if (xproprietario == "1")
            {
                script = "SELECT ID FROM " + nomearquivo + " WITH(NOLOCK) WHERE " +
                                             " ativa = 1 " +
                                             " and " +
                                             " produto = " + xproduto +
                                             " and " +
                                             " grupo = " + xgrupo +
                                             " and " +
                                             " unidade = " + xunidade +
                                             " and " +
                                             " parte = " + xproprietario +
                                             " and " +
                                             " parcela = " + Srelib.QStr(xnumeroparcela);
            }
            else
            {
                //Parte = 2
                script = "SELECT ID FROM " + nomearquivo + " WITH(NOLOCK) WHERE " +
                                             " ativa = 1 " +
                                             " and " +
                                             " produto = " + xproduto +
                                             " and " +
                                             " grupo = " + xgrupo +
                                             " and " +
                                             " unidade = " + xunidade +
                                             " and " +
                                             " parte = " + xproprietario +
                                             " and " +
                                             " parcela = " + Srelib.QStr(xnumeroparcela);
            }
        }

        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static String CriarTabelaParcelas(string xproduto,
                                             string xgrupo)
    {
        //Criar Arquivo Parcelas
        string nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);
        string script = "";

        if (xproduto != string.Empty)
        {
            //Cria nova tabela no SQL
            string script1 = "";
            string script2 = "";
            string script3 = "";
            string scriptconta = "";

            script1 = "CREATE TABLE [dbo].[";
            script2 = "](" +
                      "[ID] [int] IDENTITY(1,1) NOT NULL , " +
                      "[produto] [int] NOT NULL , " +
                      "[grupo] [int] NOT NULL , " +
                      "[unidade] [int] NOT NULL , " +
                      "[parte] [int] NOT NULL , " +
                      "[parcela] [int] NOT NULL , " +
                      "[tipo] [varchar](5) NOT NULL , " +
                      "[data_vencimento] [datetime] NOT NULL , " +
                      "[vlr_parcela] [decimal](18, 2) NOT NULL , " +
                      "[data_pagamento] [datetime] NULL , " +
                      "[vlr_pagamento] [decimal](18, 2) NULL , " +
                      "[data_original] [datetime] NOT NULL , " +
                      "[vlr_original] [decimal](18, 2) NOT NULL , " +
                      "[data_base] [datetime] NOT NULL , " +
                      "[vlr_base] [decimal](18,  2) NOT NULL , " +
                      "[nossonumero] [varchar](30) NULL , " +
                      "[origem_pagamento] [varchar](30) NULL , " +
                      "[ativa] [bit] NULL , " +
                      "[percentual_correcao] [decimal](18, 8) NULL , " +
                      "[carteira] [bit] NULL , " +
                      "[protesto] [bit] NULL , " +
                      "[contabil] [bit] NULL , " +
                      "[tx_multa] [decimal](18,  2) NULL , " +
                      "[tx_comissao] [decimal](18, 2) NULL , " +
                      "[vlr_multa] [decimal](18, 2) NULL , " +
                      "[vlr_comissao] [decimal](18, 2) NULL , " +
                      "[vlr_desconto] [decimal](18, 2) NULL , " +
                      "[periodicidade_comissao] [varchar](10) NULL , " +
                      "[data_conta] [datetime] NULL , " +
                      "[conta] [varchar](10) NULL , " +
                      "[indexador] [varchar](20) NULL , " +
                      "[indexador_mes] [decimal](18,  8) NULL , " +
                      "[indexador_acumulado] [decimal](18, 8) NULL , " +
                      "[residuo_mes] [decimal](18,  8) NULL , " +
                      "[residuo_acumulado] [decimal](18,  8) NULL , " +
                      "[vlr_correcao] [decimal](18,  2) NULL , " +
                      "[observacao] [varchar](60) NULL , " +
                      "[juros_price] [decimal](18, 8) NULL, " +
                      "[vlr_parcelas_jurosprice] [decimal](18, 2) NULL, " +
                      "[amortizacao] [int] NULL, " +
                      "[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	 " +
                      "[taxa_anual_price] [decimal](18, 2) NULL " +
                      "CONSTRAINT [PK_";

            script3 = "] PRIMARY KEY NONCLUSTERED " +
                        "(" +
                        "	[ID] ASC" +
                        ")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]" +
                        ") ON [PRIMARY]"; // +

            //"GO";
            //
            scriptconta = scriptconta + nomearquivo;

            //Criação da Tabela
            script = script1 + scriptconta + script2 + scriptconta + script3;
            //drop
            try
            {
                SreDblib.ExecScript("drop table dbo." + nomearquivo);
            }
            catch (Exception)
            {
                //
            }
            //create
            try
            {
                SreDblib.ExecScript(script);
            }
            catch (Exception)
            {
                //
            }

        }
        //fim Cria nova tabela no SQL

        return " ";
    }



    public uParcelas()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}


using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;

/// <summary>
/// Summary description for uVendas
/// </summary>
public class uVendas
{


    public static DataSet LookUpVendas()
    {
        return SreDblib.GetDsScript("select apelido from vendas");
    }

    public static ASPxComboBox MontaComboVendas(ASPxComboBox pCombo)
    {
        //Documentação - Chamada da Função
        //
        //uBanco.MontaComboBanco(ASPxComboBox1);
        //
        //Fim Documentação - Chamada da Função


        return SreDblib.MontaCombo(pCombo, "Vendas", "ID", "ID", false, "");

    }

    public static ASPxComboBox MontaComboVendasCliente(ASPxComboBox pCombo, string pScript)
    {
        //Documentação - Chamada da Função
        //
        //uBanco.MontaComboVendasCliente(ASPxComboBox1, p Where);
        //
        //Fim Documentação - Chamada da Função

        String script = "SELECT " + "ID" + "," + "produto, grupo, unidade, parte" + " FROM " + "Vendas" + " WITH(NOLOCK)" + pScript;
        DataSet ds = SreDblib.GetDsScript(script);
        ListEditItem le;
        //
        le = new ListEditItem();
        le.Text = "";
        le.Value = "0";
        pCombo.Items.Add(le);
        //
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            le = new ListEditItem();

            le.Text = "ID: " +
                      Srelib.QStr0(dr["ID"].ToString().Trim(), 5) +
                      " Venda: " +
                      Srelib.QStr0(dr["produto"].ToString().Trim(), 5) + "/" +
                      Srelib.QStr0(dr["grupo"].ToString().Trim(), 5) + "/" +
                      Srelib.QStr0(dr["unidade"].ToString().Trim(), 5) + "/" +
                      Srelib.QStr0(dr["parte"].ToString().Trim(), 5);
            le.Value = dr["ID"].ToString();
            pCombo.Items.Add(le);
        }
        return pCombo;

    }

    public static ASPxComboBox MontaComboRenegociacoes(ASPxComboBox pCombo, string pScript)
    {
        //Documentação - Chamada da Função
        //
        //uVendas.MontaComboRenegociacoes(ASPxComboBox1, p Where);
        //
        //Fim Documentação - Chamada da Função

        String script = "SELECT " + "ID" + "," + "produto, grupo, unidade, parte, data_venda " + 
                        " FROM " + "vendas_renegociacao" + " WITH(NOLOCK) " + pScript +
                        " AND tipo_renegociacao = " + Srelib.QStr("R") + " " +
                        " order by data_venda ";
        DataSet ds = SreDblib.GetDsScript(script);
        ListEditItem le;
        //
        le = new ListEditItem();
        le.Text = "";
        le.Value = "0";
        pCombo.Items.Add(le);
        //
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            le = new ListEditItem();

            le.Text = "ID: " +
                      Srelib.QStr0(dr["ID"].ToString().Trim(), 6) +
                      " RNG: " +
                      Srelib.QStr0(dr["produto"].ToString().Trim(), 5) + "/" +
                      Srelib.QStr0(dr["grupo"].ToString().Trim(), 5) + "/" +
                      Srelib.QStr0(dr["unidade"].ToString().Trim(), 5) + "/" +
                      Srelib.QStr0(dr["parte"].ToString().Trim(), 5) + " - " +
                      dr["data_venda"].ToString().Substring(0,10).Trim();
            le.Value = dr["ID"].ToString();
            if (le.Value.ToString().Trim() != String.Empty)
            {
                pCombo.Items.Add(le);
            }
        }
        return pCombo;

    }

    public static ASPxComboBox MontaComboDesistencias(ASPxComboBox pCombo, string pScript)
    {
        //Documentação - Chamada da Função
        //
        //uVendas.MontaComboRenegociacoes(ASPxComboBox1, p Where);
        //
        //Fim Documentação - Chamada da Função

        String script = "SELECT " + "ID" + "," + "produto, grupo, unidade, parte, data_venda " +
                        " FROM " + "vendas_renegociacao" + " WITH(NOLOCK) " + pScript +
                        " AND tipo_renegociacao = " + Srelib.QStr("D") + " " +
                        " order by data_venda ";
        DataSet ds = SreDblib.GetDsScript(script);
        ListEditItem le;
        //
        le = new ListEditItem();
        le.Text = "";
        le.Value = "0";
        pCombo.Items.Add(le);
        //
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            le = new ListEditItem();

            le.Text = "ID: " +
                      Srelib.QStr0(dr["ID"].ToString().Trim(), 6) +
                      " DES: " +
                      Srelib.QStr0(dr["produto"].ToString().Trim(), 5) + "/" +
                      Srelib.QStr0(dr["grupo"].ToString().Trim(), 5) + "/" +
                      Srelib.QStr0(dr["unidade"].ToString().Trim(), 5) + "/" +
                      Srelib.QStr0(dr["parte"].ToString().Trim(), 5) + " - " +
                      dr["data_venda"].ToString().Substring(0, 10).Trim();
            le.Value = dr["ID"].ToString();
            if (le.Value.ToString().Trim() != String.Empty)
            {
                pCombo.Items.Add(le);
            }
        }
        return pCombo;

    }

    public static String Grava(string xproduto,
                                string xgrupo,
                                string xunidade,
                                string xparte,
                                string xcliente,
                                string xdata_venda,
                                decimal xvlr_venda,
                                decimal xvlr_sinal,
                                decimal xvlr_fluxo,
                                decimal xvlr_intermediaria,
                                string xnum_parcelas_sinal,
                                string xnum_parcelas_fluxo,
                                string xnum_parcelas_intermediarias,
                                decimal xvlr_parcela_fluxo,
                                string xprimeiro_vencimento,
                                string xultimo_vencimento,
                                Int16 xquitado,
                                string xindexador,
                                string xindexador_original,
                                string xperiodicidade_correcao,
                                string xultima_correcao,
                                Int16 xsinal_parcelado,
                                string xcorretor,
                                string xobservacao,
                                decimal xmulta,
                                decimal xcomissao,
                                string xperiodicidade_comissao
        )
    {

        if (xproduto != String.Empty)
        {
            string script = "INSERT INTO VENDAS VALUES ( " +
                            Srelib.QStr(xproduto) +
                            ", " + Srelib.QStr(xgrupo) +
                            ", " + Srelib.QStr(xunidade) +
                            ", " + Srelib.QStr(xparte) +
                            ", " + Srelib.QStr(xcliente) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_venda)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_venda)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_sinal)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_fluxo)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_intermediaria)) +
                            ", " + xnum_parcelas_sinal +
                            ", " + xnum_parcelas_fluxo +
                            ", " + xnum_parcelas_intermediarias +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_parcela_fluxo)) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xprimeiro_vencimento)) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xultimo_vencimento)) +
                            ", " + xquitado +
                            ", " + Srelib.QStr(xindexador) +
                            ", " + Srelib.QStr(xindexador_original) +
                            ", " + Srelib.QStr(xperiodicidade_correcao) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xultima_correcao)) +
                            ", " + xsinal_parcelado +
                            ", " + Srelib.QStr(xcorretor) +
                            ", " + Srelib.QStr(xobservacao) +
                            ", " + Srelib.forcaponto(Convert.ToString(xmulta)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xcomissao)) +
                            ", " + Srelib.QStr(xperiodicidade_comissao) +
                            ", " + "0" +
                            ", " + "0.00" +
                            ", " + "0" +
                            ", " + "0" +
                            ", " + Srelib.QStr("NENHUM") +
                            " ) ";

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String GravaTP(string xproduto,
                                string xgrupo,
                                string xunidade,
                                string xparte,
                                string xcliente,
                                string xdata_venda,
                                decimal xvlr_venda,
                                decimal xvlr_sinal,
                                decimal xvlr_fluxo,
                                decimal xvlr_intermediaria,
                                string xnum_parcelas_sinal,
                                string xnum_parcelas_fluxo,
                                string xnum_parcelas_intermediarias,
                                decimal xvlr_parcela_fluxo,
                                string xprimeiro_vencimento,
                                string xultimo_vencimento,
                                Int16 xquitado,
                                string xindexador,
                                string xindexador_original,
                                string xperiodicidade_correcao,
                                string xultima_correcao,
                                Int16 xsinal_parcelado,
                                string xcorretor,
                                string xobservacao,
                                decimal xmulta,
                                decimal xcomissao,
                                string xperiodicidade_comissao,
                                Int16 xtabelaprice,
                                decimal xedjurostabelaprice,
                                Int16 xtotal_parcelas_price,
                                Int16 xckindexadorejuros,
                                string xindexadorejuros
        )
    {
        //Venda Tabela Price
        if (xproduto != String.Empty)
        {
            string script = "INSERT INTO VENDAS VALUES ( " +
                            Srelib.QStr(xproduto) +
                            ", " + Srelib.QStr(xgrupo) +
                            ", " + Srelib.QStr(xunidade) +
                            ", " + Srelib.QStr(xparte) +
                            ", " + Srelib.QStr(xcliente) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_venda)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_venda)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_sinal)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_fluxo)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_intermediaria)) +
                            ", " + xnum_parcelas_sinal +
                            ", " + xnum_parcelas_fluxo +
                            ", " + xnum_parcelas_intermediarias +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_parcela_fluxo)) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xprimeiro_vencimento)) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xultimo_vencimento)) +
                            ", " + xquitado +
                            ", " + Srelib.QStr(xindexador) +
                            ", " + Srelib.QStr(xindexador_original) +
                            ", " + Srelib.QStr(xperiodicidade_correcao) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xultima_correcao)) +
                            ", " + xsinal_parcelado +
                            ", " + Srelib.QStr(xcorretor) +
                            ", " + Srelib.QStr(xobservacao) +
                            ", " + Srelib.forcaponto(Convert.ToString(xmulta)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xcomissao)) +
                            ", " + Srelib.QStr(xperiodicidade_comissao) +
                            ", " + xtabelaprice +
                            ", " + Srelib.forcaponto(Convert.ToString(xedjurostabelaprice)) +
                            ", " + xtotal_parcelas_price +
                            ", " + xckindexadorejuros +
                            ", " + Srelib.QStr(xindexadorejuros) +
                            " ) ";

            //" where nome=" + Rgblib.QStr(pParametro);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String GravaRenegociacao(string xproduto,
                                string xgrupo,
                                string xunidade,
                                string xparte,
                                string xcliente,
                                string xdata_venda,
                                decimal xvlr_venda,
                                decimal xvlr_sinal,
                                decimal xvlr_fluxo,
                                decimal xvlr_intermediaria,
                                string xnum_parcelas_sinal,
                                string xnum_parcelas_fluxo,
                                string xnum_parcelas_intermediarias,
                                decimal xvlr_parcela_fluxo,
                                string xprimeiro_vencimento,
                                string xultimo_vencimento,
                                Int16 xquitado,
                                string xindexador,
                                string xindexador_original,
                                string xperiodicidade_correcao,
                                string xultima_correcao,
                                Int16 xsinal_parcelado,
                                string xcorretor,
                                string xobservacao,
                                decimal xmulta,
                                decimal xcomissao,
                                string xperiodicidade_comissao,
                                string xtipo_renegociacao,
                                string xnum_renegociacao,
                                Int16 xtabela_price,
                                decimal xjuros_price,
                                Int16 xtotal_parcelas_price,
                                Int16 xindexadorejuros,
                                string xindexador_juros
        )
    {

        if (xproduto != String.Empty)
        {
            string script = "INSERT INTO VENDAS_RENEGOCIACAO VALUES ( " +
                            Srelib.QStr(xproduto) +
                            ", " + Srelib.QStr(xgrupo) +
                            ", " + Srelib.QStr(xunidade) +
                            ", " + Srelib.QStr(xparte) +
                            ", " + Srelib.QStr(xcliente) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_venda)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_venda)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_sinal)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_fluxo)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_intermediaria)) +
                            ", " + xnum_parcelas_sinal +
                            ", " + xnum_parcelas_fluxo +
                            ", " + xnum_parcelas_intermediarias +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_parcela_fluxo)) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xprimeiro_vencimento)) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xultimo_vencimento)) +
                            ", " + xquitado +
                            ", " + Srelib.QStr(xindexador) +
                            ", " + Srelib.QStr(xindexador_original) +
                            ", " + Srelib.QStr(xperiodicidade_correcao) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xultima_correcao)) +
                            ", " + xsinal_parcelado +
                            ", " + Srelib.QStr(xcorretor) +
                            ", " + Srelib.QStr(xobservacao) +
                            ", " + Srelib.forcaponto(Convert.ToString(xmulta)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xcomissao)) +
                            ", " + Srelib.QStr(xperiodicidade_comissao) +
                            ", " + Srelib.QStr(xtipo_renegociacao) +
                            ", " + xnum_renegociacao +
                            ", " + xtabela_price +
                            ", " + Srelib.forcaponto(Convert.ToString(xjuros_price)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xtotal_parcelas_price)) +
                            ", " + xindexadorejuros +
                            ", " + Srelib.QStr(xindexador_juros) +
                            " ) ";

            SreDblib.ExecScript(script);
        }
        return " ";
    }


    public static String ApagaRenegociacaoParcelas(string xproduto,
                                                   string xgrupo,
                                                   string xunidade,
                                                   string xparte,
                                                   string xdata_renegociacao)
    {
        string script = "";
        if (xproduto != String.Empty)
        {
            script = "";
            script = " DELETE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                     " WHERE  " +
                     " produto = " + xproduto +
                     " and " +
                     " grupo = " + xgrupo +
                     " and " +
                     " unidade = " + xunidade +
                     " and " +
                     " parte = " + xparte +
                     " and " +
                     " data_vencimento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_renegociacao)) +
                     " and " +
                     " vlr_pagamento = 0";

            SreDblib.ExecScript(script);
            //
            script = "";
            script = " UPDATE parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5) +
                     " SET ATIVA = 0 " +
                     " WHERE  " +
                     " produto = " + xproduto +
                     " and " +
                     " grupo = " + xgrupo +
                     " and " +
                     " unidade = " + xunidade +
                     " and " +
                     " parte = " + xparte +
                     " and " +
                     " data_vencimento < " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_renegociacao));

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String PegaIndexador(string xproduto,
                                       string xgrupo,
                                       string xunidade,
                                       string xparte)
    {
        string script = "";
        if (xparte == "0" || xparte == "1")
        {
            script = "SELECT indexador FROM vendas WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte;
        }
        else
        {
            script = "SELECT indexador FROM vendas WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte;
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

    public static String PegaCorretor(string xproduto,
                                      string xgrupo,
                                      string xunidade,
                                      string xparte)
    {
        string script = "";
        if (xparte == "0" || xparte == "1")
        {
            script = "SELECT corretor FROM vendas WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte;
        }
        else
        {
            script = "SELECT corretor FROM vendas WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte;
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


    public static String PegaProprietário(string xproduto,
                                          string xgrupo,
                                          string xunidade,
                                          string xparte)
    {
        string script = "";
        if (xparte == "0" || xparte == "1")
        {
            script = "SELECT cliente FROM vendas WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte;
        }
        else
        {
            script = "SELECT cliente FROM vendas WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte;
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

    public static Boolean TemVenda(string xproduto,
                                   string xgrupo,
                                   string xunidade,
                                   string xparte)
    {
        string script = "";
        if (xparte == "0" || xparte == "1")
        {
            script = "SELECT ID FROM vendas WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte;
        }
        else
        {
            script = "SELECT ID FROM vendas WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte;
        }

        try
        {
            if (SreDblib.GetCampoScript(script) != String.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch
        {
            return false;
        }
    }

    public static Boolean TemRenegociacao(string xproduto,
                                          string xgrupo,
                                          string xunidade,
                                          string xparte)
    {
        string script = "";
        if (xparte == "0" || xparte == "1")
        {
            script = "SELECT ID FROM vendas_renegociacao WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte;
        }
        else
        {
            script = "SELECT ID FROM vendas_renegociacao WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte;
        }

        try
        {
            if (SreDblib.GetCampoScript(script) != String.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch
        {
            return false;
        }
    }

    public static Boolean TemQuitacao(string xproduto,
                                      string xgrupo,
                                      string xunidade,
                                      string xparte)
    {
        string script = "";
        if (xparte == "0" || xparte == "1")
        {
            script = "SELECT quitado FROM vendas WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte;
        }
        else
        {
            script = "SELECT quitado FROM vendas WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte;
        }

        try
        {
            return Convert.ToBoolean(SreDblib.GetCampoScript(script));
        }
        catch
        {
            return false;
        }
    }


    public static Int64 NumeroRenegociacao(string xproduto,
                                            string xgrupo,
                                            string xunidade,
                                            string xparte)
    {
        string script = "";
        if (xparte == "0" || xparte == "1")
        {
            script = "SELECT Count(*) numero FROM vendas_renegociacao WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte;
        }
        else
        {
            script = "SELECT Count(*) numero FROM vendas_renegociacao WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte;
        }

        return Convert.ToInt64(SreDblib.GetCampoScript(script));
    }

    public static DateTime PegaDataBase(string xproduto,
                                         string xgrupo,
                                         string xunidade,
                                         string xparte)
    {
        //data base = ultima_correcao

        string script = "";
        if (xparte == "0" || xparte == "1")
        {
            script = "SELECT ultima_correcao FROM vendas WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte;
        }
        else
        {
            script = "SELECT ultima_correcao FROM vendas WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte;
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

    public static DateTime PegaDataVenda(string xproduto,
                                         string xgrupo,
                                         string xunidade,
                                         string xparte)
    {
        //data base = ultima_correcao

        string script = "";
        if (xparte == "0" || xparte == "1")
        {
            script = "SELECT data_venda FROM vendas WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte;
        }
        else
        {
            script = "SELECT data_venda FROM vendas WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte;
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


    public static String PegaPeriodicidade(string xproduto,
                                           string xgrupo,
                                           string xunidade,
                                           string xparte,
                                           string xproprietario)
    {
        string script = "";
        if (xparte == "0")
        {
            script = "SELECT periodicidade_correcao FROM vendas WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte;
        }
        else
        {
            //Parte = 1
            if (xproprietario == "1")
            {
                script = "SELECT periodicidade_correcao FROM vendas WITH(NOLOCK) WHERE " +
                    " produto = " + xproduto +
                    " and " +
                    " grupo = " + xgrupo +
                    " and " +
                    " unidade = " + xunidade +
                    " and " +
                    " parte = " + xproprietario;
            }
            else
            {
                //Parte = 2
                script = "SELECT periodicidade_correcao FROM vendas WITH(NOLOCK) WHERE " +
                    " produto = " + xproduto +
                    " and " +
                    " grupo = " + xgrupo +
                    " and " +
                    " unidade = " + xunidade +
                    " and " +
                    " parte = " + xproprietario;
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

    public static String PegaTaxaJuros(string xproduto,
                                       string xgrupo,
                                       string xunidade,
                                       string xparte,
                                       string xproprietario)
    {
        string script = "";
        if (xparte == "0")
        {
            script = "SELECT comissao FROM vendas WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte;
        }
        else
        {
            //Parte = 1
            if (xproprietario == "1")
            {
                script = "SELECT comissao FROM vendas WITH(NOLOCK) WHERE " +
                    " produto = " + xproduto +
                    " and " +
                    " grupo = " + xgrupo +
                    " and " +
                    " unidade = " + xunidade +
                    " and " +
                    " parte = " + xproprietario;
            }
            else
            {
                //Parte = 2
                script = "SELECT comissao FROM vendas WITH(NOLOCK) WHERE " +
                    " produto = " + xproduto +
                    " and " +
                    " grupo = " + xgrupo +
                    " and " +
                    " unidade = " + xunidade +
                    " and " +
                    " parte = " + xproprietario;
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

    public static String PegaTaxaMulta(string xproduto,
                                       string xgrupo,
                                       string xunidade,
                                       string xparte,
                                       string xproprietario)
    {
        string script = "";
        if (xparte == "0")
        {
            script = "SELECT multa FROM vendas WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte;
        }
        else
        {
            //Parte = 1
            if (xproprietario == "1")
            {
                script = "SELECT multa FROM vendas WITH(NOLOCK) WHERE " +
                    " produto = " + xproduto +
                    " and " +
                    " grupo = " + xgrupo +
                    " and " +
                    " unidade = " + xunidade +
                    " and " +
                    " parte = " + xproprietario;
            }
            else
            {
                //Parte = 2
                script = "SELECT multa FROM vendas WITH(NOLOCK) WHERE " +
                    " produto = " + xproduto +
                    " and " +
                    " grupo = " + xgrupo +
                    " and " +
                    " unidade = " + xunidade +
                    " and " +
                    " parte = " + xproprietario;
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


    public static DataSet PegaDadosVendas(string xproduto,
                                          string xgrupo,
                                          string xunidade,
                                          string xparte,
                                          string xperiodicidade_correcao,
                                          string xquitados)
    {
        //Dados das Vendas sem Parcelas
        string arquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);
        string script;
        //
        script = "SELECT * FROM vendas v WITH(NOLOCK) WHERE 1 = 1 ";
        if (xproduto != string.Empty)
            script = script + " AND produto = " + xproduto + " ";
        if (xgrupo != string.Empty)
        {
            script = script + " AND grupo = " + xgrupo + " ";
        }
        if (xunidade != string.Empty)
            script = script + " AND unidade = " + xunidade + " ";
        if (xparte != string.Empty)
            script = script + " AND parte = " + xparte + " ";
        if (xperiodicidade_correcao != string.Empty)
            script = script + " AND periodicidade_correcao = " + Srelib.QStr(xperiodicidade_correcao) + " ";
        if (xquitados != string.Empty)
        {
            if (xquitados == "0")
                script = script + " AND quitado = 0 ";
            if (xquitados == "1")
                script = script + " AND quitado = 1 ";
        }
        //
        script = script + " order by produto, grupo, unidade ";

        return SreDblib.GetDsScript(script);

    }

    public static DataSet PegaDadosDesistencia(string xproduto,
                                               string xgrupo,
                                               string xunidade,
                                               string xparte,
                                               string xData1,
                                               string xData2,
                                               string xproprietario,
                                               string xsituacaovenda,
                                               string xmescorrecao)
    {
        //Dados da Venda e Parcelas
        //xsituacaovenda = 0 todos, 1 vendidos, 2 disponíveis

        string script;
        if (xproprietario == "1")
        {
            script = "SELECT v.*,c.nome proprietario, c.cnpj cnpj_proprietario " +
                        ", u.metragem_1 metragem, u.inscricao_1 inscimobiliaria " +
                        " FROM vendas_renegociacao v WITH(NOLOCK) " +
                        "INNER JOIN contato c ON (v.cliente = c.ID) " +
                        "LEFT JOIN produto_unidades u ON (v.produto = u.produto and v.grupo = u.grupo and v.unidade = u.unidade and v.parte = u.parte) " +
                        "WHERE 1 = 1  ";
            script = script +
                    " AND (data_venda between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") ";
            //
            if (xproduto != string.Empty)
                script = script + "AND v.produto = " + xproduto + " ";
            if (xgrupo != string.Empty)
                script = script + "AND v.grupo = " + xgrupo + " ";
            if (xunidade != string.Empty)
                script = script + "AND v.unidade = " + xunidade + " ";
            if (xparte != string.Empty)
                script = script + "AND v.parte = " + xparte + " ";
            //
            if (xsituacaovenda == "1")
            {
                script = script + "AND u.proprietario_1 <> 1 ";
            }
            if (xsituacaovenda == "2")
            {
                script = script + "AND u.proprietario_1 = 1 ";
            }
            if (xmescorrecao != "")
            {
                script = script + "AND month(v.ultima_correcao) = " + xmescorrecao + " " +
                                    "AND v.periodicidade_correcao = " + Srelib.QStr("ANUAL") + " ";
            }
            script = script + " AND v.tipo_renegociacao = " + Srelib.QStr("D") + " ";
            script = script + " order by v.produto, v.grupo, v.unidade, V.ID desc ";

        }
        else
        {
            //parte 2
            script = "SELECT v.*,c.nome proprietario, c.cnpj cnpj_proprietario " +
                        ", u.metragem_2 metragem, u.inscricao_2 inscimobiliaria " +
                        " FROM vendas_renegociacao v WITH(NOLOCK) " +
                        "INNER JOIN contato c ON (v.cliente = c.ID) " +
                        "LEFT JOIN produto_unidades u ON (v.produto = u.produto and v.grupo = u.grupo and v.unidade = u.unidade) " + // and v.parte = u.parte) " +
                                                                                                                                     //"INNER JOIN contato c ON (v.cliente = c.ID) " +
                                                                                                                                     //"INNER JOIN produto_unidades u ON (v.produto = u.produto and v.grupo = u.grupo and v.unidade = u.unidade) " + // and v.parte = u.parte) " +
                        "WHERE 1 = 1 ";
            script = script +
                    " AND (data_venda between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") ";
            //
            if (xproduto != string.Empty)
                script = script + "AND v.produto = " + xproduto + " ";
            if (xgrupo != string.Empty)
                script = script + "AND v.grupo = " + xgrupo + " ";
            if (xunidade != string.Empty)
                script = script + "AND v.unidade = " + xunidade + " ";
            if (xparte != string.Empty)
                script = script + "AND v.parte = " + xproprietario + " ";
            if (xsituacaovenda == "1")
            {
                script = script + "AND u.proprietario_2 <> 1 ";
            }
            if (xsituacaovenda == "2")
            {
                script = script + "AND u.proprietario_2 = 1 ";
            }
            if (xmescorrecao != "")
            {
                script = script + "AND month(v.ultima_correcao) = " + xmescorrecao + " " +
                                    "AND v.periodicidade_correcao = " + Srelib.QStr("ANUAL") + " ";
            }
            script = script + " AND v.tipo_renegociacao = " + Srelib.QStr("D") + " ";
            script = script + "order by v.produto, v.grupo, v.unidade, V.ID desc ";

        }

        return SreDblib.GetDsScript(script);

    }

    public static DataSet PegaDadosRenegociacao(string xproduto,
                                                string xgrupo,
                                                string xunidade,
                                                string xparte,
                                                string xData1,
                                                string xData2,
                                                string xproprietario,
                                                string xsituacaovenda,
                                                string xmescorrecao)
    {
        //Dados da Venda e Parcelas
        //xsituacaovenda = 0 todos, 1 vendidos, 2 disponíveis

        string script;
        if (xproprietario == "1")
        {
            script = "SELECT v.*,c.nome proprietario, c.cnpj cnpj_proprietario " +
                        ", u.metragem_1 metragem, u.inscricao_1 inscimobiliaria " +
                        " FROM vendas_renegociacao v WITH(NOLOCK) " +
                        "INNER JOIN contato c ON (v.cliente = c.ID) " +
                        "LEFT JOIN produto_unidades u ON (v.produto = u.produto and v.grupo = u.grupo and v.unidade = u.unidade and v.parte = u.parte) " +
                        "WHERE 1 = 1  ";
            script = script +
                    " AND (data_venda between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") ";
            //
            if (xproduto != string.Empty)
                script = script + "AND v.produto = " + xproduto + " ";
            if (xgrupo != string.Empty)
                script = script + "AND v.grupo = " + xgrupo + " ";
            if (xunidade != string.Empty)
                script = script + "AND v.unidade = " + xunidade + " ";
            if (xparte != string.Empty)
                script = script + "AND v.parte = " + xparte + " ";
            //
            if (xsituacaovenda == "1")
            {
                script = script + "AND u.proprietario_1 <> 1 ";
            }
            if (xsituacaovenda == "2")
            {
                script = script + "AND u.proprietario_1 = 1 ";
            }
            if (xmescorrecao != "")
            {
                script = script + "AND month(v.ultima_correcao) = " + xmescorrecao + " " +
                                    "AND v.periodicidade_correcao = " + Srelib.QStr("ANUAL") + " ";
            }
            script = script + " AND v.tipo_renegociacao = " + Srelib.QStr("R") + " ";
            script = script + " order by v.produto, v.grupo, v.unidade, V.ID desc ";

        }
        else
        {
            //parte 2
            script = "SELECT v.*,c.nome proprietario, c.cnpj cnpj_proprietario " +
                        ", u.metragem_2 metragem, u.inscricao_2 inscimobiliaria " +
                        " FROM vendas_renegociacao v WITH(NOLOCK) " +
                        "INNER JOIN contato c ON (v.cliente = c.ID) " +
                        "LEFT JOIN produto_unidades u ON (v.produto = u.produto and v.grupo = u.grupo and v.unidade = u.unidade) " + // and v.parte = u.parte) " +
                                                                                                                                     //"INNER JOIN contato c ON (v.cliente = c.ID) " +
                                                                                                                                     //"INNER JOIN produto_unidades u ON (v.produto = u.produto and v.grupo = u.grupo and v.unidade = u.unidade) " + // and v.parte = u.parte) " +
                        "WHERE 1 = 1 ";
            script = script +
                    " AND (data_venda between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") ";
            //
            if (xproduto != string.Empty)
                script = script + "AND v.produto = " + xproduto + " ";
            if (xgrupo != string.Empty)
                script = script + "AND v.grupo = " + xgrupo + " ";
            if (xunidade != string.Empty)
                script = script + "AND v.unidade = " + xunidade + " ";
            if (xparte != string.Empty)
                script = script + "AND v.parte = " + xproprietario + " ";
            if (xsituacaovenda == "1")
            {
                script = script + "AND u.proprietario_2 <> 1 ";
            }
            if (xsituacaovenda == "2")
            {
                script = script + "AND u.proprietario_2 = 1 ";
            }
            if (xmescorrecao != "")
            {
                script = script + "AND month(v.ultima_correcao) = " + xmescorrecao + " " +
                                    "AND v.periodicidade_correcao = " + Srelib.QStr("ANUAL") + " ";
            }
            script = script + " AND v.tipo_renegociacao = " + Srelib.QStr("R") + " ";
            script = script + "order by v.produto, v.grupo, v.unidade, V.ID desc ";

        }

        return SreDblib.GetDsScript(script);

    }

    public static DataSet PegaDadosRenegociacaoID(string xID)
    {
        //Dados da Renegociação

        string script;
            script = "SELECT v.*,c.nome proprietario, c.cnpj cnpj_proprietario " +
                        ", u.metragem_1 metragem, u.inscricao_1 inscimobiliaria " +
                        " FROM vendas_renegociacao v WITH(NOLOCK) " +
                        " INNER JOIN contato c ON (v.cliente = c.ID) " +
                        " LEFT JOIN produto_unidades u ON (v.produto = u.produto and v.grupo = u.grupo and v.unidade = u.unidade and v.parte = u.parte) " +
                        " WHERE 1 = 1  " +
                        " AND v.ID = " + xID;

        return SreDblib.GetDsScript(script);

    }

    public static DataSet PegaDadosVenda(string xproduto,
                                         string xgrupo,
                                         string xunidade,
                                         string xparte,
                                         string xData1,
                                         string xData2,
                                         string xproprietario,
                                         string xsituacaovenda,
                                         string xmescorrecao)
    {
        //Dados da Venda e Parcelas
        //xsituacaovenda = 0 todos, 1 vendidos, 2 disponíveis

        string script;
        if (xproprietario == "1")
        {
            script = "SELECT v.*,c.nome proprietario, c.cnpj cnpj_proprietario " +
                        ", u.metragem_1 metragem, u.inscricao_1 inscimobiliaria " +
                        " FROM vendas v WITH(NOLOCK) " +
                        "INNER JOIN contato c ON (v.cliente = c.ID) " +
                        "LEFT JOIN produto_unidades u ON (v.produto = u.produto and v.grupo = u.grupo and v.unidade = u.unidade and v.parte = u.parte) " +
                        //"INNER JOIN contato c ON (v.cliente = c.ID) " +
                        //"INNER JOIN produto_unidades u ON (v.produto = u.produto and v.grupo = u.grupo and v.unidade = u.unidade and v.parte = u.parte) " +
                        "WHERE v.cliente <> 0  ";
            script = script +
                    " AND (data_venda between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") ";
            //
            if (xproduto != string.Empty)
                script = script + "AND v.produto = " + xproduto + " ";
            if (xgrupo != string.Empty)
                script = script + "AND v.grupo = " + xgrupo + " ";
            if (xunidade != string.Empty)
                script = script + "AND v.unidade = " + xunidade + " ";
            if (xparte != string.Empty)
                script = script + "AND v.parte = " + xparte + " ";
            //
            if (xsituacaovenda == "1")
            {
                script = script + "AND u.proprietario_1 <> 1 ";
            }
            if (xsituacaovenda == "2")
            {
                script = script + "AND u.proprietario_1 = 1 ";
            }
            if (xmescorrecao != "")
            {
                script = script + "AND month(v.ultima_correcao) = " + xmescorrecao + " " +
                                    "AND v.periodicidade_correcao = " + Srelib.QStr("ANUAL") + " ";
            }
            script = script + "order by v.produto, v.grupo, v.unidade ";

        }
        else
        {
            //parte 2
            script = "SELECT v.*,c.nome proprietario, c.cnpj cnpj_proprietario " +
                        ", u.metragem_2 metragem, u.inscricao_2 inscimobiliaria " +
                        " FROM vendas v WITH(NOLOCK) " +
                        "INNER JOIN contato c ON (v.cliente = c.ID) " +
                        "LEFT JOIN produto_unidades u ON (v.produto = u.produto and v.grupo = u.grupo and v.unidade = u.unidade) " + // and v.parte = u.parte) " +
                                                                                                                                     //"INNER JOIN contato c ON (v.cliente = c.ID) " +
                                                                                                                                     //"INNER JOIN produto_unidades u ON (v.produto = u.produto and v.grupo = u.grupo and v.unidade = u.unidade) " + // and v.parte = u.parte) " +
                        "WHERE v.cliente <> 0  ";
            script = script +
                    " AND (data_venda between " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                    " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") ";
            //
            if (xproduto != string.Empty)
                script = script + "AND v.produto = " + xproduto + " ";
            if (xgrupo != string.Empty)
                script = script + "AND v.grupo = " + xgrupo + " ";
            if (xunidade != string.Empty)
                script = script + "AND v.unidade = " + xunidade + " ";
            if (xparte != string.Empty)
                script = script + "AND v.parte = " + xproprietario + " ";
            if (xsituacaovenda == "1")
            {
                script = script + "AND u.proprietario_2 <> 1 ";
            }
            if (xsituacaovenda == "2")
            {
                script = script + "AND u.proprietario_2 = 1 ";
            }
            if (xmescorrecao != "")
            {
                script = script + "AND month(v.ultima_correcao) = " + xmescorrecao + " " +
                                    "AND v.periodicidade_correcao = " + Srelib.QStr("ANUAL") + " ";
            }
            script = script + "order by v.produto, v.grupo, v.unidade ";

        }

        return SreDblib.GetDsScript(script);

    }


    public static DataSet PegaDadosVendaID(string xID)
    {
        //
        string script;
        script = " SELECT v.*,c.nome proprietario, c.cnpj cnpj_proprietario " +
                 " , u.metragem_1 metragem, u.inscricao_1 inscimobiliaria " +
                 " FROM vendas v WITH(NOLOCK) " +
                 " INNER JOIN contato c ON (v.cliente = c.ID) " +
                 " INNER JOIN produto_unidades u ON (v.produto = u.produto and v.grupo = u.grupo and v.unidade = u.unidade and v.parte = u.parte) " +
                 " WHERE v.ID = " + Srelib.QStr(xID);
        //
        script = script + " order by v.produto, v.grupo, v.unidade ";
        //
        return SreDblib.GetDsScript(script);

    }

    public static DataSet PegaDadosVendaID2(string xID)
    {
        //
        string script;
        script = " SELECT v.* " +
                 " FROM vendas v WITH(NOLOCK) " +
                 " WHERE v.ID = " + Srelib.QStr(xID);
        //
        script = script + " order by v.produto, v.grupo, v.unidade ";
        //
        return SreDblib.GetDsScript(script);

    }

    public static DataSet PegaDadosVendaFinanciamentos(string xproduto,
                                                       string xgrupo,
                                                       string xunidade,
                                                       string xparte)
    {
        //xsituacaovenda = 0 todos, 1 vendidos, 2 disponíveis
        //
        //Saldo Credor e Devedor do Financiamento
        //
        string script = "";
        string nomearquivo = "";
        string ygrupo = "";
        DataSet dsgrupo;
        //
        //Grupo em branco
        if (xgrupo == string.Empty)
        {
            //Loop de Grupos
            dsgrupo = uProduto.PegaDadosProdutoGrupo(Convert.ToInt16(xproduto), "1");
            //
            for (int i = 0; i < dsgrupo.Tables[0].Rows.Count; i++)
            {
                ygrupo = dsgrupo.Tables[0].Rows[i]["grupo"].ToString().Trim();
                //
                if (xunidade == string.Empty)
                {
                    nomearquivo = string.Format("parcelas_{0}_{1}", Srelib.QStr0(xproduto.Trim(), 5), Srelib.QStr0(ygrupo.Trim(), 5));
                    //
                    script = "" +
                    "SELECT v.id, v.produto, v.grupo, v.unidade, v.parte," +
                    "v.data_venda, v.vlr_venda, v.indexador, v.periodicidade_correcao, v.ultima_correcao, v.quitado,  " +
                    "c.nome proprietario, c.cnpj cnpj_proprietario ,  " +
                    " CASE v.parte   " +
                    "    WHEN '0' THEN " + Srelib.QStr("u.metragem_1 metragem") +
                    "    WHEN '1' THEN " + Srelib.QStr("u.metragem_1 metragem") +
                    "    WHEN '2' THEN " + Srelib.QStr("u.metragem_2 metragem") +
                    " END,  " +
                    " CASE v.parte   " +
                    "    WHEN '0' THEN " + Srelib.QStr("u.inscricao_1 inscimobiliaria") +
                    "    WHEN '1' THEN " + Srelib.QStr("u.inscricao_1 inscimobiliaria") +
                    "    WHEN '2' THEN " + Srelib.QStr("u.inscricao_2 inscimobiliaria") +
                    " END,    " +
                    "ISNULL( " +
                    "(SELECT SUM(p.vlr_parcela) FROM " + nomearquivo + " p WITH(NOLOCK) " +
                    "WHERE (v.produto = p.produto and v.grupo = p.grupo and v.unidade = p.unidade and v.parte = p.parte " +
                    " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                    ")),0) saldodevedor, " +
                    "ISNULL( " +
                    "(SELECT SUM(p.vlr_parcela) FROM " + nomearquivo + " p WITH(NOLOCK) " +
                    "WHERE (v.produto = p.produto and v.grupo = p.grupo and v.unidade = p.unidade and v.parte = p.parte " +
                    " and p.ativa = 1" +
                    " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                    ")),0) saldocredorativo, " +
                    "ISNULL( " +
                    "(SELECT SUM(p.vlr_parcela) FROM " + nomearquivo + " p WITH(NOLOCK) " +
                    "WHERE (v.produto = p.produto and v.grupo = p.grupo and v.unidade = p.unidade and v.parte = p.parte " +
                    " and p.ativa = 1" +
                    " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                    ")),0) saldodevedorativo, " +
                    "ISNULL( " +
                    "(SELECT SUM(p.vlr_parcela) FROM " + nomearquivo + " p WITH(NOLOCK) " +
                    "WHERE (v.produto = p.produto and v.grupo = p.grupo and v.unidade = p.unidade and v.parte = p.parte " +
                    " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                    ")),0) saldocredor " +
                    "FROM vendas v WITH(NOLOCK) " +
                    "INNER JOIN contato c ON (v.cliente = c.ID)  " +
                    "INNER JOIN produto_unidades u ON (v.produto = u.produto and v.grupo = u.grupo and v.unidade = u.unidade) " + //and v.parte = u.parte)  " +
                    "WHERE (v.produto = " + xproduto + " AND v.grupo = " + ygrupo + ") " +
                    "AND v.cliente <> 0   " +
                    "order by v.produto, v.grupo, v.unidade ";
                }
                else
                {
                    nomearquivo = string.Format("parcelas_{0}_{1}", Srelib.QStr0(xproduto.Trim(), 5), Srelib.QStr0(ygrupo.Trim(), 5));
                    //
                    script = "" +
                    "SELECT v.id, v.produto, v.grupo, v.unidade, v.parte," +
                    "v.data_venda, v.vlr_venda, v.indexador, v.periodicidade_correcao, v.ultima_correcao, v.quitado,  " +
                    "c.nome proprietario, c.cnpj cnpj_proprietario ,  " +
                    " CASE v.parte   " +
                    "    WHEN '0' THEN " + Srelib.QStr("u.metragem_1 metragem") +
                    "    WHEN '1' THEN " + Srelib.QStr("u.metragem_1 metragem") +
                    "    WHEN '2' THEN " + Srelib.QStr("u.metragem_2 metragem") +
                    " END,  " +
                    " CASE v.parte   " +
                    "    WHEN '0' THEN " + Srelib.QStr("u.inscricao_1 inscimobiliaria") +
                    "    WHEN '1' THEN " + Srelib.QStr("u.inscricao_1 inscimobiliaria") +
                    "    WHEN '2' THEN " + Srelib.QStr("u.inscricao_2 inscimobiliaria") +
                    " END,    " +
                    "ISNULL( " +
                    "(SELECT SUM(p.vlr_parcela) FROM " + nomearquivo + " p WITH(NOLOCK) " +
                    "WHERE (v.produto = p.produto and v.grupo = p.grupo and v.unidade = p.unidade and v.parte = p.parte " +
                    " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                    ")),0) saldodevedor, " +
                    "ISNULL( " +
                    "(SELECT SUM(p.vlr_parcela) FROM " + nomearquivo + " p WITH(NOLOCK) " +
                    "WHERE (v.produto = p.produto and v.grupo = p.grupo and v.unidade = p.unidade and v.parte = p.parte " +
                    " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                    ")),0) saldocredor, " +
                    "ISNULL( " +
                    "(SELECT SUM(p.vlr_parcela) FROM " + nomearquivo + " p WITH(NOLOCK) " +
                    "WHERE (v.produto = p.produto and v.grupo = p.grupo and v.unidade = p.unidade and v.parte = p.parte " +
                    " and p.ativa = 1" +
                    " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                    ")),0) saldodevedorativo, " +
                    "ISNULL( " +
                    "(SELECT SUM(p.vlr_parcela) FROM " + nomearquivo + " p WITH(NOLOCK) " +
                    "WHERE (v.produto = p.produto and v.grupo = p.grupo and v.unidade = p.unidade and v.parte = p.parte " +
                    " and p.ativa = 1" +
                    " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                    ")),0) saldocredorativo " +
                    "FROM vendas v WITH(NOLOCK) " +
                    "INNER JOIN contato c ON (v.cliente = c.ID)  " +
                    "INNER JOIN produto_unidades u ON (v.produto = u.produto and v.grupo = u.grupo and v.unidade = u.unidade) " + //and v.parte = u.parte)  " +
                    "WHERE (v.produto = " + xproduto + " AND v.grupo = " + ygrupo + " " +
                    "AND v.unidade = " + xunidade + ") " +
                    "AND v.cliente <> 0   " +
                    "order by v.produto, v.grupo, v.unidade ";

                }
            }
        }
        else
        {
            //Grupo Preenchido
            if (xunidade == string.Empty)
            {
                nomearquivo = string.Format("parcelas_{0}_{1}", Srelib.QStr0(xproduto.Trim(), 5), Srelib.QStr0(xgrupo.Trim(), 5));
                //
                script = "" +
                    "SELECT v.id, v.produto, v.grupo, v.unidade, v.parte," +
                    "v.data_venda, v.vlr_venda, v.indexador, v.periodicidade_correcao, v.ultima_correcao, v.quitado,  " +
                    "c.nome proprietario, c.cnpj cnpj_proprietario ,  " +
                    " CASE v.parte   " +
                    "    WHEN '0' THEN " + Srelib.QStr("u.metragem_1 metragem") +
                    "    WHEN '1' THEN " + Srelib.QStr("u.metragem_1 metragem") +
                    "    WHEN '2' THEN " + Srelib.QStr("u.metragem_2 metragem") +
                    " END,  " +
                    " CASE v.parte   " +
                    "    WHEN '0' THEN " + Srelib.QStr("u.inscricao_1 inscimobiliaria") +
                    "    WHEN '1' THEN " + Srelib.QStr("u.inscricao_1 inscimobiliaria") +
                    "    WHEN '2' THEN " + Srelib.QStr("u.inscricao_2 inscimobiliaria") +
                    " END,    " +
                    "ISNULL( " +
                    "(SELECT SUM(p.vlr_parcela) FROM " + nomearquivo + " p WITH(NOLOCK) " +
                    "WHERE (v.produto = p.produto and v.grupo = p.grupo and v.unidade = p.unidade and v.parte = p.parte " +
                    " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                    ")),0) saldodevedor, " +
                    "ISNULL( " +
                    "(SELECT SUM(p.vlr_parcela) FROM " + nomearquivo + " p WITH(NOLOCK) " +
                    "WHERE (v.produto = p.produto and v.grupo = p.grupo and v.unidade = p.unidade and v.parte = p.parte " +
                    " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                    ")),0) saldocredor, " +
                    "ISNULL( " +
                    "(SELECT SUM(p.vlr_parcela) FROM " + nomearquivo + " p WITH(NOLOCK) " +
                    "WHERE (v.produto = p.produto and v.grupo = p.grupo and v.unidade = p.unidade and v.parte = p.parte " +
                    " and p.ativa = 1" +
                    " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                    ")),0) saldodevedorativo, " +
                    "ISNULL( " +
                    "(SELECT SUM(p.vlr_parcela) FROM " + nomearquivo + " p WITH(NOLOCK) " +
                    "WHERE (v.produto = p.produto and v.grupo = p.grupo and v.unidade = p.unidade and v.parte = p.parte " +
                    " and p.ativa = 1" +
                    " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                    ")),0) saldocredorativo " +
                    "FROM vendas v WITH(NOLOCK) " +
                    "INNER JOIN contato c ON (v.cliente = c.ID)  " +
                    "INNER JOIN produto_unidades u ON (v.produto = u.produto and v.grupo = u.grupo and v.unidade = u.unidade) " + //and v.parte = u.parte)  " +
                    "WHERE (v.produto = " + xproduto + " AND v.grupo = " + xgrupo + " " + ") " +
                    "AND v.cliente <> 0   " +
                    "order by v.produto, v.grupo, v.unidade ";
            }
            else
            {
                nomearquivo = string.Format("parcelas_{0}_{1}", Srelib.QStr0(xproduto.Trim(), 5), Srelib.QStr0(xgrupo.Trim(), 5));
                //
                script = "" +
                "SELECT v.id, v.produto, v.grupo, v.unidade, v.parte," +
                "v.data_venda, v.vlr_venda, v.indexador, v.periodicidade_correcao, v.ultima_correcao, v.quitado,  " +
                "c.nome proprietario, c.cnpj cnpj_proprietario ,  " +
                    " CASE v.parte   " +
                    "    WHEN '0' THEN " + Srelib.QStr("u.metragem_1 metragem") +
                    "    WHEN '1' THEN " + Srelib.QStr("u.metragem_1 metragem") +
                    "    WHEN '2' THEN " + Srelib.QStr("u.metragem_2 metragem") +
                    " END,  " +
                    " CASE v.parte   " +
                    "    WHEN '0' THEN " + Srelib.QStr("u.inscricao_1 inscimobiliaria") +
                    "    WHEN '1' THEN " + Srelib.QStr("u.inscricao_1 inscimobiliaria") +
                    "    WHEN '2' THEN " + Srelib.QStr("u.inscricao_2 inscimobiliaria") +
                    " END,    " +
                "ISNULL( " +
                "(SELECT SUM(p.vlr_parcela) FROM " + nomearquivo + " p WITH(NOLOCK) " +
                "WHERE (v.produto = p.produto and v.grupo = p.grupo and v.unidade = p.unidade and v.parte = p.parte " +
                " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                ")),0) saldodevedor, " +
                "ISNULL( " +
                "(SELECT SUM(p.vlr_parcela) FROM " + nomearquivo + " p WITH(NOLOCK) " +
                "WHERE (v.produto = p.produto and v.grupo = p.grupo and v.unidade = p.unidade and v.parte = p.parte " +
                " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                ")),0) saldocredor, " +
                "ISNULL( " +
                "(SELECT SUM(p.vlr_parcela) FROM " + nomearquivo + " p WITH(NOLOCK) " +
                "WHERE (v.produto = p.produto and v.grupo = p.grupo and v.unidade = p.unidade and v.parte = p.parte " +
                " and p.ativa = 1" +
                " and data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                ")),0) saldodevedorativo, " +
                "ISNULL( " +
                "(SELECT SUM(p.vlr_parcela) FROM " + nomearquivo + " p WITH(NOLOCK) " +
                "WHERE (v.produto = p.produto and v.grupo = p.grupo and v.unidade = p.unidade and v.parte = p.parte " +
                " and p.ativa = 1" +
                " and data_pagamento <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) +
                ")),0) saldocredorativo " +
                "FROM vendas v WITH(NOLOCK) " +
                "INNER JOIN contato c ON (v.cliente = c.ID)  " +
                "INNER JOIN produto_unidades u ON (v.produto = u.produto and v.grupo = u.grupo and v.unidade = u.unidade) " + //and v.parte = u.parte)  " +
                "WHERE (v.produto = " + xproduto + " AND v.grupo = " + xgrupo + " " +
                "AND v.unidade = " + xunidade + " " +
                "AND v.parte = " + xparte + ") " +
                "AND v.cliente <> 0   " +
                "order by v.produto, v.grupo, v.unidade ";

            }

        }

        return SreDblib.GetDsScript(script);

    }

    public static string CancelaVenda(string xproduto,
                                      string xgrupo,
                                      string xunidade,
                                      string xparte)
    {
        string script = "";
        string nomearquivo = "";

        if (xunidade != string.Empty)
        {
            nomearquivo = string.Format("parcelas_{0}_{1}", Srelib.QStr0(xproduto.Trim(), 5), Srelib.QStr0(xgrupo.Trim(), 5));
            // Parcelas
            script = "delete " + nomearquivo + " " +
            "WHERE (produto = " + xproduto + " AND grupo = " + xgrupo + " " +
            "AND unidade = " + xunidade + " AND parte = " + xparte + ") ";
            SreDblib.ExecScript(script);
            //
            // Vendas
            script = "";
            script = "delete vendas " +
            "WHERE (produto = " + xproduto + " AND grupo = " + xgrupo + " " +
            "AND unidade = " + xunidade + " AND parte = " + xparte + ") ";
            SreDblib.ExecScript(script);
            //
            // Produto Unidades
            if ((xparte == "0") || (xparte == "1"))
            {
                script = "";
                script = "update PRODUTO_UNIDADES set proprietario_1 = 1 " +
                "WHERE (produto = " + xproduto + " AND grupo = " + xgrupo + " " +
                "AND unidade = " + xunidade + " AND parte = " + xparte + ") ";
                SreDblib.ExecScript(script);
            }
            else
            {
                script = "";
                script = "update PRODUTO_UNIDADES set proprietario_2 = 1 " +
                "WHERE (produto = " + xproduto + " AND grupo = " + xgrupo + " " +
                "AND unidade = " + xunidade + " AND parte = " + xparte + ") ";
                SreDblib.ExecScript(script);
            }

        }

        return "";
    }

    public static string DesistenciaVenda(string xproduto,
                                          string xgrupo,
                                          string xunidade,
                                          string xparte,
                                          string xmeiolote)
    {
        string script = "";
        string nomearquivo = "";
        DataSet parcelas;
        DataSet venda;
        //
        string cliente = "";
        DateTime data_venda = Convert.ToDateTime("01/01/1900");
        decimal vlr_venda = 0;
        decimal vlr_sinal = 0;
        decimal vlr_fluxo = 0;
        decimal vlr_intermediaria = 0;
        string num_parcelas_sinal = "0";
        string num_parcelas_fluxo = "0";
        string num_parcelas_intermediarias = "0";
        decimal vlr_parcela_fluxo = 0;
        DateTime primeiro_vencimento = Convert.ToDateTime("01/01/1900");
        DateTime ultimo_vencimento = Convert.ToDateTime("01/01/1900");
        Boolean quitado = false;
        string indexador = "";
        string indexador_original = "";
        string periodicidade_correcao = "";
        DateTime ultima_correcao = Convert.ToDateTime("01/01/1900");
        Boolean sinal_parcelado = false;
        string corretor = "";
        string observacao = "";
        string tipo_renegociacao = "";
        string num_renegociacao = "";
        string periodicidade_comissao = "";
        //
        Int16 tabela_price = 0;
        decimal juros_price = 0;
        Int16 total_parcelas_price = 0;
        Int16 indexadorejuros = 0;
        string indexador_juros = "";
        //
        if (xunidade != string.Empty)
        {
            //Armazenar Valores
            parcelas = uParcelas.PegaDadosParcelas2(xproduto,
                                                   xgrupo,
                                                   xunidade,
                                                   xparte,
                                                   xmeiolote,
                                                   "01/01/1900",
                                                   "31/12/2999",
                                                   "T",
                                                   "0",
                                                   "N",
                                                   false,
                                                   "0");
            //
            venda = uVendas.PegaDadosVenda(xproduto, xgrupo, xunidade, xparte, "01/01/1900", "31/12/2999", "1", "0", "");
            //
            cliente = venda.Tables[0].Rows[0]["cliente"].ToString().Trim();
            if (venda.Tables[0].Rows[0]["data_venda"].ToString() != "")
            {
                data_venda = Convert.ToDateTime(venda.Tables[0].Rows[0]["data_venda"]);
                if (data_venda < Convert.ToDateTime("01/01/1900"))
                    data_venda = Convert.ToDateTime("01/01/1900");
            }
            if (venda.Tables[0].Rows[0]["vlr_venda"].ToString() != "")
            {
                vlr_venda = (Convert.ToDecimal(venda.Tables[0].Rows[0]["vlr_venda"]));
            }
            if (venda.Tables[0].Rows[0]["vlr_fluxo"].ToString() != "")
            {
                vlr_fluxo = Convert.ToDecimal(venda.Tables[0].Rows[0]["vlr_fluxo"]);
            }
            if (venda.Tables[0].Rows[0]["vlr_intermediaria"].ToString() != "")
            {
                vlr_intermediaria = Convert.ToDecimal(venda.Tables[0].Rows[0]["vlr_intermediaria"]);
            }
            if (venda.Tables[0].Rows[0]["num_parcelas_fluxo"].ToString() != "")
            {
                num_parcelas_fluxo = venda.Tables[0].Rows[0]["num_parcelas_fluxo"].ToString().Trim();
            }
            if (venda.Tables[0].Rows[0]["num_parcelas_intermediarias"].ToString() != "")
            {
                num_parcelas_intermediarias = venda.Tables[0].Rows[0]["num_parcelas_intermediarias"].ToString().Trim();
            }
            if (venda.Tables[0].Rows[0]["vlr_parcela_fluxo"].ToString() != "")
            {
                vlr_parcela_fluxo = Convert.ToDecimal(venda.Tables[0].Rows[0]["vlr_parcela_fluxo"]);
            }
            if (venda.Tables[0].Rows[0]["primeiro_vencimento"].ToString() != "")
            {
                primeiro_vencimento = Convert.ToDateTime(venda.Tables[0].Rows[0]["primeiro_vencimento"]);
                if (primeiro_vencimento < Convert.ToDateTime("01/01/1900"))
                    primeiro_vencimento = Convert.ToDateTime("01/01/1900");
            }
            if (venda.Tables[0].Rows[0]["ultimo_vencimento"].ToString() != "")
            {
                ultimo_vencimento = Convert.ToDateTime(venda.Tables[0].Rows[0]["ultimo_vencimento"]);
                if (ultimo_vencimento < Convert.ToDateTime("01/01/1900"))
                    ultimo_vencimento = Convert.ToDateTime("01/01/1900");
            }
            //}
            //quitado = Convert.ToBoolean(venda.Tables[0].Rows[0]["quitado"]);
            indexador = venda.Tables[0].Rows[0]["indexador"].ToString().Trim();
            periodicidade_correcao = venda.Tables[0].Rows[0]["periodicidade_correcao"].ToString().Trim();
            periodicidade_comissao = venda.Tables[0].Rows[0]["periodicidade_comissao"].ToString().Trim();
            if (venda.Tables[0].Rows[0]["ultima_correcao"].ToString() != "")
            {
                ultima_correcao = Convert.ToDateTime(venda.Tables[0].Rows[0]["ultima_correcao"]);
                if (ultima_correcao < Convert.ToDateTime("01/01/1900"))
                    ultima_correcao = Convert.ToDateTime("01/01/1900");
            }
            sinal_parcelado = Convert.ToBoolean(venda.Tables[0].Rows[0]["sinal_parcelado"]);
            corretor = venda.Tables[0].Rows[0]["corretor"].ToString().Trim();
            observacao = venda.Tables[0].Rows[0]["observacao"].ToString().Trim();
            tipo_renegociacao = "D";
            num_renegociacao = "1";
            //
            if (venda.Tables[0].Rows[0]["tabela_price"].ToString() != "")
            {
                tabela_price = Convert.ToInt16(venda.Tables[0].Rows[0]["tabela_price"]);
            }
            if (venda.Tables[0].Rows[0]["juros_price"].ToString() != "")
            {
                juros_price = Convert.ToDecimal(venda.Tables[0].Rows[0]["juros_price"]);
            }
            if (venda.Tables[0].Rows[0]["total_parcelas_price"].ToString() != "")
            {
                total_parcelas_price = Convert.ToInt16(venda.Tables[0].Rows[0]["total_parcelas_price"]);
            }
            if (venda.Tables[0].Rows[0]["indexadorejuros"].ToString() != "")
            {
                indexadorejuros = Convert.ToInt16(venda.Tables[0].Rows[0]["indexadorejuros"]);
            }
            if (venda.Tables[0].Rows[0]["indexador_juros"].ToString() != "")
            {
                indexador_juros = venda.Tables[0].Rows[0]["indexador_juros"].ToString();
            }
            //
            //Gravar Desistência
            uVendas.GravaRenegociacao(xproduto,
                                      xgrupo,
                                      xunidade,
                                      xparte,
                                      cliente,
                                      Convert.ToString(data_venda).Substring(0, 10),
                                      vlr_venda,
                                      vlr_sinal,
                                      vlr_fluxo,
                                      vlr_intermediaria,
                                      num_parcelas_sinal,
                                      num_parcelas_fluxo,
                                      num_parcelas_intermediarias,
                                      vlr_parcela_fluxo,
                                      Convert.ToString(primeiro_vencimento).Substring(0, 10),
                                      Convert.ToString(ultimo_vencimento).Substring(0, 10),
                                      Convert.ToInt16(quitado),
                                      indexador,
                                      indexador_original,
                                      periodicidade_correcao,
                                      Convert.ToString(ultima_correcao).Substring(0, 10),
                                      Convert.ToInt16(sinal_parcelado),
                                      corretor,
                                      observacao,
                                      2,
                                      1,
                                      periodicidade_comissao,
                                      tipo_renegociacao,
                                      num_renegociacao,
                                      tabela_price,
                                      juros_price,
                                      total_parcelas_price,
                                      indexadorejuros,
                                      indexador_juros
                                      );
            //
            //Grava Parcelas
            string parcela = "";
            string tipo = "";
            DateTime data_vencimento = Convert.ToDateTime("01/01/1900");
            decimal vlr_parcela = 0;
            DateTime data_pagamento = Convert.ToDateTime("01/01/1900");
            decimal vlr_pagamento = 0;
            DateTime data_original = Convert.ToDateTime("01/01/1900");
            decimal vlr_original = 0;
            DateTime data_base = Convert.ToDateTime("01/01/1900");
            decimal vlr_base = 0;
            string nossonumero = "";
            string origem_pagamento = "";
            Boolean ativa = false;
            decimal percentual_correcao = 0;
            Boolean carteira = false;
            Boolean protesto = false;
            Boolean contabil = false;
            decimal tx_multa = 0;
            decimal tx_comissao = 0;
            decimal vlr_multa = 0;
            decimal vlr_comissao = 0;
            decimal vlr_desconto = 0;
            periodicidade_comissao = "";
            DateTime data_conta = Convert.ToDateTime("01/01/1900");
            string conta = "";
            indexador = "";
            decimal indexador_mes = 0;
            decimal indexador_acumulado = 0;
            decimal residuo_mes = 0;
            decimal residuo_acumulado = 0;
            decimal vlr_correcao = 0;
            observacao = "";
            //
            juros_price = 0;
            decimal vlr_parcelas_jurosprice = 0;
            Int16 amortizacao = 0;
            decimal vlr_parcelas_descapitalizada = 0;
            decimal taxa_anual_price = 0;
            //
            //
            for (int row = 0; row < parcelas.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (parcelas.Tables[0].Rows[row]["parcela"].ToString() != String.Empty)
                {
                    // 
                    parcela = parcelas.Tables[0].Rows[row]["parcela"].ToString().Trim();
                    tipo = parcelas.Tables[0].Rows[row]["tipo"].ToString().Trim();

                    if (parcelas.Tables[0].Rows[row]["data_vencimento"].ToString() != "")
                    {
                        data_vencimento = Convert.ToDateTime(parcelas.Tables[0].Rows[row]["data_vencimento"]);
                        if (data_vencimento < Convert.ToDateTime("01/01/1900"))
                            data_vencimento = Convert.ToDateTime("01/01/1900");
                    }
                    if (parcelas.Tables[0].Rows[row]["vlr_parcela"].ToString() != "")
                    {
                        vlr_parcela = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["vlr_parcela"]);
                    }

                    if (parcelas.Tables[0].Rows[row]["data_pagamento"].ToString() != "")
                    {
                        data_pagamento = Convert.ToDateTime(parcelas.Tables[0].Rows[row]["data_pagamento"]);
                        if (data_pagamento < Convert.ToDateTime("01/01/1900"))
                            data_pagamento = Convert.ToDateTime("01/01/1900");
                    }

                    if (parcelas.Tables[0].Rows[row]["vlr_pagamento"].ToString() != "")
                    {
                        vlr_pagamento = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["vlr_pagamento"]);
                    }

                    if (parcelas.Tables[0].Rows[row]["vlr_original"].ToString() != "")
                    {
                        vlr_original = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["vlr_original"]);
                    }

                    if (parcelas.Tables[0].Rows[row]["vlr_pagamento"].ToString() != "")
                    {
                        vlr_pagamento = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["vlr_pagamento"]);
                    }

                    nossonumero = parcelas.Tables[0].Rows[row]["nossonumero"].ToString().Trim();
                    origem_pagamento = parcelas.Tables[0].Rows[row]["origem_pagamento"].ToString().Trim();
                    ativa = Convert.ToBoolean(parcelas.Tables[0].Rows[row]["ativa"]);

                    if (parcelas.Tables[0].Rows[row]["percentual_correcao"].ToString() != "")
                    {
                        percentual_correcao = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["percentual_correcao"]);
                    }

                    carteira = Convert.ToBoolean(parcelas.Tables[0].Rows[row]["carteira"]);
                    protesto = Convert.ToBoolean(parcelas.Tables[0].Rows[row]["protesto"]);
                    contabil = Convert.ToBoolean(parcelas.Tables[0].Rows[row]["contabil"]);
                    if (parcelas.Tables[0].Rows[row]["tx_multa"].ToString() != "")
                    {
                        tx_multa = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["tx_multa"]);
                    }
                    if (parcelas.Tables[0].Rows[row]["tx_comissao"].ToString() != "")
                    {
                        tx_comissao = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["tx_comissao"]);
                    }
                    if (parcelas.Tables[0].Rows[row]["vlr_multa"].ToString() != "")
                    {
                        vlr_multa = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["vlr_multa"]);
                    }
                    if (parcelas.Tables[0].Rows[row]["vlr_comissao"].ToString() != "")
                    {
                        vlr_comissao = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["vlr_comissao"]);
                    }
                    if (parcelas.Tables[0].Rows[row]["vlr_desconto"].ToString() != "")
                    {
                        vlr_desconto = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["vlr_desconto"]);
                    }
                    //
                    periodicidade_comissao = parcelas.Tables[0].Rows[row]["periodicidade_comissao"].ToString().Trim();
                    data_conta = Convert.ToDateTime("01/01/1900");
                    conta = parcelas.Tables[0].Rows[row]["conta"].ToString().Trim();
                    indexador = parcelas.Tables[0].Rows[row]["indexador"].ToString().Trim().ToUpper();
                    if (parcelas.Tables[0].Rows[row]["indexador_mes"].ToString() != "")
                    {
                        indexador_mes = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["indexador_mes"]);
                    }
                    if (parcelas.Tables[0].Rows[row]["indexador_acumulado"].ToString() != "")
                    {
                        indexador_acumulado = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["indexador_acumulado"]);
                    }
                    if (parcelas.Tables[0].Rows[row]["residuo_mes"].ToString() != "")
                    {
                        residuo_mes = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["residuo_mes"]);
                    }
                    if (parcelas.Tables[0].Rows[row]["residuo_acumulado"].ToString() != "")
                    {
                        residuo_acumulado = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["residuo_acumulado"]);
                    }
                    observacao = parcelas.Tables[0].Rows[row]["observacao"].ToString().Trim();
                    //
                    //
                    if (parcelas.Tables[0].Rows[0]["juros_price"].ToString() != "")
                    {
                        juros_price = Convert.ToDecimal(parcelas.Tables[0].Rows[0]["juros_price"]);
                    }
                    if (parcelas.Tables[0].Rows[0]["vlr_parcelas_jurosprice"].ToString() != "")
                    {
                        vlr_parcelas_jurosprice = Convert.ToDecimal(parcelas.Tables[0].Rows[0]["vlr_parcelas_jurosprice"]);
                    }
                    if (parcelas.Tables[0].Rows[0]["amortizacao"].ToString() != "")
                    {
                        amortizacao = Convert.ToInt16(parcelas.Tables[0].Rows[0]["amortizacao"]);
                    }
                    if (parcelas.Tables[0].Rows[0]["vlr_parcelas_descapitalizada"].ToString() != "")
                    {
                        vlr_parcelas_descapitalizada = Convert.ToDecimal(parcelas.Tables[0].Rows[0]["vlr_parcelas_descapitalizada"]);
                    }
                    if (parcelas.Tables[0].Rows[0]["taxa_anual_price"].ToString() != "")
                    {
                        taxa_anual_price = Convert.ToDecimal(parcelas.Tables[0].Rows[0]["taxa_anual_price"]);
                    }
                    //

                    if (data_pagamento != Convert.ToDateTime("01/01/1900"))
                    {
                        //Parcelas de Renegociações
                        uParcelas.GravaRenegociacao(xproduto,
                                                    xgrupo,
                                                    xunidade,
                                                    xparte,
                                                    parcela,
                                                    tipo,
                                                    Convert.ToString(data_vencimento).Substring(0, 10),
                                                    vlr_parcela,
                                                    Convert.ToString(data_pagamento).Substring(0, 10),
                                                    vlr_pagamento,
                                                    Convert.ToString(data_original).Substring(0, 10),
                                                    vlr_original,
                                                    Convert.ToString(data_base).Substring(0, 10),
                                                    vlr_base,
                                                    nossonumero,
                                                    origem_pagamento,
                                                    Convert.ToInt16(ativa),
                                                    percentual_correcao,
                                                    Convert.ToInt16(carteira),
                                                    Convert.ToInt16(protesto),
                                                    Convert.ToInt16(contabil),
                                                    tx_multa,
                                                    tx_comissao,
                                                    vlr_multa,
                                                    vlr_comissao,
                                                    vlr_desconto,
                                                    periodicidade_comissao,
                                                    Convert.ToString(data_conta).Substring(0, 10),
                                                    conta,
                                                    indexador,
                                                    indexador_mes,
                                                    indexador_acumulado,
                                                    residuo_mes,
                                                    residuo_acumulado,
                                                    vlr_correcao,
                                                    observacao,
                                                    juros_price,
                                                    vlr_parcelas_jurosprice,
                                                    amortizacao,
                                                    vlr_parcelas_descapitalizada,
                                                    taxa_anual_price
                                                    );
                    }
                    //
                    parcela = "";
                    tipo = "";
                    data_vencimento = Convert.ToDateTime("01/01/1900");
                    vlr_parcela = 0;
                    data_pagamento = Convert.ToDateTime("01/01/1900");
                    vlr_pagamento = 0;
                    data_original = Convert.ToDateTime("01/01/1900");
                    vlr_original = 0;
                    data_base = Convert.ToDateTime("01/01/1900");
                    vlr_base = 0;
                    nossonumero = "";
                    origem_pagamento = "";
                    ativa = false;
                    percentual_correcao = 0;
                    carteira = false;
                    protesto = false;
                    contabil = false;
                    tx_multa = 0;
                    tx_comissao = 0;
                    vlr_multa = 0;
                    vlr_comissao = 0;
                    vlr_desconto = 0;
                    periodicidade_comissao = "";
                    data_conta = Convert.ToDateTime("01/01/1900");
                    conta = "";
                    indexador = "";
                    indexador_mes = 0;
                    indexador_acumulado = 0;
                    residuo_mes = 0;
                    residuo_acumulado = 0;
                    vlr_correcao = 0;
                    observacao = "";
                    //
                    juros_price = 0;
                    vlr_parcelas_jurosprice = 0;
                    amortizacao = 0;
                    vlr_parcelas_descapitalizada = 0;
                    taxa_anual_price = 0;
                    //

                }
                //Fim Migração Arquivo Parcelas 
            }

            //
            //Apagar Valores
            nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);
            // Parcelas
            script = "delete " + nomearquivo + " " +
            "WHERE (produto = " + xproduto + " AND grupo = " + xgrupo + " " +
            "AND unidade = " + xunidade + " AND parte = " + xparte + ") ";
            SreDblib.ExecScript(script);
            //
            // Vendas
            script = "";
            script = "delete vendas " +
            "WHERE (produto = " + xproduto + " AND grupo = " + xgrupo + " " +
            "AND unidade = " + xunidade + " AND parte = " + xparte + ") ";
            SreDblib.ExecScript(script);
            //
            // Produto Unidades
            if ((xparte == "0") || (xparte == "1"))
            {
                script = "";
                script = "update PRODUTO_UNIDADES set proprietario_1 = 1 " +
                "WHERE (produto = " + xproduto + " AND grupo = " + xgrupo + " " +
                "AND unidade = " + xunidade + " AND parte = " + xparte + ") ";
                SreDblib.ExecScript(script);
            }
            else
            {
                script = "";
                script = "update PRODUTO_UNIDADES set proprietario_2 = 1 " +
                "WHERE (produto = " + xproduto + " AND grupo = " + xgrupo + " " +
                "AND unidade = " + xunidade + " AND parte = " + xparte + ") ";
                SreDblib.ExecScript(script);
            }

        }

        return " ";
    }

    public static string GravaPermutaUnidade(string xproduto,
                                             string xgrupo,
                                             string xunidade,
                                             string xparte,
                                             string xmeiolote,
                                             string xcliente,
                                             string xproduto2,
                                             string xgrupo2,
                                             string xunidade2,
                                             string xparte2,
                                             string xmeiolote2,
                                             string xrbtipodestino)
    {
        // Vendas
        string script = "";
        if (xparte == "0")
        {
            if (xparte2 == "0")
            {
                script = "update vendas " +
                " SET " +
                " produto = " + xproduto2 + ", " +
                " grupo = " + xgrupo2 + ", " +
                " unidade = " + xunidade2 + ", " +
                " parte = " + xparte2 +
                " WHERE (produto = " + xproduto + " " +
                " AND grupo = " + xgrupo + " " +
                " AND unidade = " + xunidade + " " +
                " AND parte = " + xparte + ") ";
            }
            else
            {
                script = "update vendas " +
                " SET " +
                " produto = " + xproduto2 + ", " +
                " grupo = " + xgrupo2 + ", " +
                " unidade = " + xunidade2 + ", " +
                " parte = " + xmeiolote2 +
                " WHERE (produto = " + xproduto + " " +
                " AND grupo = " + xgrupo + " " +
                " AND unidade = " + xunidade + " " +
                " AND parte = " + xparte + ") ";
            }
        }
        else
        {
            if (xparte2 == "0")
            {
                script = "update vendas " +
                " SET " +
                " produto = " + xproduto2 + ", " +
                " grupo = " + xgrupo2 + ", " +
                " unidade = " + xunidade2 + ", " +
                " parte = " + xparte2 +
                " WHERE (produto = " + xproduto + " " +
                " AND grupo = " + xgrupo + " " +
                " AND unidade = " + xunidade + " " +
                " AND parte = " + xmeiolote + ") ";
            }
            else
            {
                script = "update vendas " +
                " SET " +
                " produto = " + xproduto2 + ", " +
                " grupo = " + xgrupo2 + ", " +
                " unidade = " + xunidade2 + ", " +
                " parte = " + xmeiolote2 +
                " WHERE (produto = " + xproduto + " " +
                " AND grupo = " + xgrupo + " " +
                " AND unidade = " + xunidade + " " +
                " AND parte = " + xmeiolote + ") ";
            }
        }
        SreDblib.ExecScript(script);
        //
        // Produto Unidades
        if (xparte == "0")
        {
            if (xparte2 == "0")
            {
                //Unidade Origem
                script = "";
                script = "update PRODUTO_UNIDADES " +
                " SET proprietario_1 = 1 " +
                " WHERE (produto = " + xproduto + " AND grupo = " + xgrupo + " " +
                " AND unidade = " + xunidade + " AND parte = " + xparte + ") ";
                SreDblib.ExecScript(script);
                //
                //Unidade Destino
                script = "";
                script = "update PRODUTO_UNIDADES " +
                " SET proprietario_1 = " + xcliente +
                " WHERE (produto = " + xproduto2 + " AND grupo = " + xgrupo2 + " " +
                " AND unidade = " + xunidade2 + " AND parte = " + xparte2 + ") ";
            }
            else
            {
                //Unidade Origem
                script = "";
                script = "update PRODUTO_UNIDADES " +
                " SET proprietario_1 = 1 " +
                " WHERE (produto = " + xproduto + " AND grupo = " + xgrupo + " " +
                " AND unidade = " + xunidade + " AND parte = " + xparte + ") ";
                SreDblib.ExecScript(script);
                //
                //Unidade Destino
                script = "";
                script = "update PRODUTO_UNIDADES " +
                " SET proprietario_1 = " + xcliente +
                " WHERE (produto = " + xproduto2 + " AND grupo = " + xgrupo2 + " " +
                " AND unidade = " + xunidade2 + " AND parte = " + xmeiolote2 + ") ";
            }
            SreDblib.ExecScript(script);
        }
        else
        {
            if (xparte2 == "0")
            {
                //Unidade Origem
                script = "";
                script = "update PRODUTO_UNIDADES " +
                " SET proprietario_2 = 1 " +
                " WHERE (produto = " + xproduto + " AND grupo = " + xgrupo + " " +
                " AND unidade = " + xunidade + " AND parte = " + xmeiolote + ") ";
                SreDblib.ExecScript(script);
                //
                //Unidade Destino
                script = "";
                script = "update PRODUTO_UNIDADES " +
                " SET proprietario_2 = " + xcliente +
                " WHERE (produto = " + xproduto2 + " AND grupo = " + xgrupo2 + " " +
                " AND unidade = " + xunidade2 + " AND parte = " + xparte2 + ") ";
            }
            else
            {
                //Unidade Origem
                script = "";
                script = "update PRODUTO_UNIDADES " +
                " SET proprietario_2 = 1 " +
                " WHERE (produto = " + xproduto + " AND grupo = " + xgrupo + " " +
                " AND unidade = " + xunidade + " AND parte = " + xmeiolote + ") ";
                SreDblib.ExecScript(script);
                //
                //Unidade Destino
                script = "";
                script = "update PRODUTO_UNIDADES " +
                " SET proprietario_2 = " + xcliente +
                " WHERE (produto = " + xproduto2 + " AND grupo = " + xgrupo2 + " " +
                " AND unidade = " + xunidade2 + " AND parte = " + xmeiolote2 + ") ";
            }
            SreDblib.ExecScript(script);
            //
        }
        //
        //Parcelas Origem

        if ((xproduto == xproduto2) && (xgrupo == xgrupo2))
        {
            //Mesmo Empreendimento e Bloco
            string nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);
            // Parcelas
            script = "";
            if (xparte == "0")
            {
                if (xparte2 == "0")
                {
                    script = "update " + nomearquivo + " " +
                    " SET " +
                    " produto = " + xproduto2 + ", " +
                    " grupo = " + xgrupo2 + ", " +
                    " unidade = " + xunidade2 + ", " +
                    " parte = " + xparte2 +
                    " WHERE (produto = " + xproduto + " " +
                    " AND grupo = " + xgrupo + " " +
                    " AND unidade = " + xunidade + " " +
                    " AND parte = " + xparte + ") ";
                }
                else
                {
                    script = "update " + nomearquivo + " " +
                    " SET " +
                    " produto = " + xproduto2 + ", " +
                    " grupo = " + xgrupo2 + ", " +
                    " unidade = " + xunidade2 + ", " +
                    " parte = " + xmeiolote2 +
                    " WHERE (produto = " + xproduto + " " +
                    " AND grupo = " + xgrupo + " " +
                    " AND unidade = " + xunidade + " " +
                    " AND parte = " + xparte + ") ";
                }
            }
            else
            {
                if (xparte2 == "0")
                {
                    script = "update " + nomearquivo + " " +
                    " SET " +
                    " produto = " + xproduto2 + ", " +
                    " grupo = " + xgrupo2 + ", " +
                    " unidade = " + xunidade2 + ", " +
                    " parte = " + xparte2 +
                    " WHERE (produto = " + xproduto + " " +
                    " AND grupo = " + xgrupo + " " +
                    " AND unidade = " + xunidade + " " +
                    " AND parte = " + xmeiolote + ") ";
                }
                else
                {
                    script = "update " + nomearquivo + " " +
                    " SET " +
                    " produto = " + xproduto2 + ", " +
                    " grupo = " + xgrupo2 + ", " +
                    " unidade = " + xunidade2 + ", " +
                    " parte = " + xmeiolote2 +
                    " WHERE (produto = " + xproduto + " " +
                    " AND grupo = " + xgrupo + " " +
                    " AND unidade = " + xunidade + " " +
                    " AND parte = " + xmeiolote + ") ";
                }
            }
            SreDblib.ExecScript(script);
        }
        else
        {
            //Diferente Empreendimento ou Bloco
            string nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);
            //
            DataSet parcelas = uParcelas.PegaDadosParcelas2(xproduto,
                                                           xgrupo,
                                                           xunidade,
                                                           xparte,
                                                          "01/01/1900",
                                                          "31/12/2999",
                                                           "1",
                                                           "T",
                                                           "0",
                                                           "N",
                                                           false,
                                                           "0");
            // Excluir Parcelas
            if (xparte == "0")
            {
                script = "delete " + nomearquivo + " " +
                "WHERE (produto = " + xproduto + " AND grupo = " + xgrupo + " " +
                "AND unidade = " + xunidade + " AND parte = " + xparte + ") ";
            }
            else
            {
                script = "delete " + nomearquivo + " " +
                "WHERE (produto = " + xproduto + " AND grupo = " + xgrupo + " " +
                "AND unidade = " + xunidade + " AND parte = " + xmeiolote + ") ";
            }
            SreDblib.ExecScript(script);
            // Fim Excluir Parcelas
            //
            // Gravar Novas Parcelas
            // Parcelas Venda 2 para Venda 1
            nomearquivo = "parcelas_" + Srelib.QStr0(xproduto2.Trim(), 5) + "_" + Srelib.QStr0(xgrupo2.Trim(), 5);
            //
            string parcela = "";
            string tipo = "";
            DateTime data_vencimento = Convert.ToDateTime("01/01/1900");
            decimal vlr_parcela = 0;
            DateTime data_pagamento = Convert.ToDateTime("01/01/1900");
            decimal vlr_pagamento = 0;
            DateTime data_original = Convert.ToDateTime("01/01/1900");
            decimal vlr_original = 0;
            DateTime data_base = Convert.ToDateTime("01/01/1900");
            decimal vlr_base = 0;
            string nossonumero = "";
            string origem_pagamento = "";
            Boolean ativa = false;
            decimal percentual_correcao = 0;
            Boolean carteira = false;
            Boolean protesto = false;
            Boolean contabil = false;
            decimal tx_multa = 0;
            decimal tx_comissao = 0;
            decimal vlr_multa = 0;
            decimal vlr_comissao = 0;
            decimal vlr_desconto = 0;
            string periodicidade_comissao = "";
            DateTime data_conta = Convert.ToDateTime("01/01/1900");
            string conta = "";
            string indexador = "";
            decimal indexador_mes = 0;
            decimal indexador_acumulado = 0;
            decimal residuo_mes = 0;
            decimal residuo_acumulado = 0;
            decimal vlr_correcao = 0;
            string observacao = "";
            //
            for (int row = 0; row < parcelas.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (parcelas.Tables[0].Rows[row]["parcela"].ToString() != String.Empty)
                {
                    // 
                    parcela = parcelas.Tables[0].Rows[row]["parcela"].ToString().Trim();
                    tipo = parcelas.Tables[0].Rows[row]["tipo"].ToString().Trim();

                    if (parcelas.Tables[0].Rows[row]["data_vencimento"].ToString() != "")
                    {
                        data_vencimento = Convert.ToDateTime(parcelas.Tables[0].Rows[row]["data_vencimento"]);
                        if (data_vencimento < Convert.ToDateTime("01/01/1900"))
                            data_vencimento = Convert.ToDateTime("01/01/1900");
                    }
                    if (parcelas.Tables[0].Rows[row]["vlr_parcela"].ToString() != "")
                    {
                        vlr_parcela = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["vlr_parcela"]);
                    }

                    if (parcelas.Tables[0].Rows[row]["data_pagamento"].ToString() != "")
                    {
                        data_pagamento = Convert.ToDateTime(parcelas.Tables[0].Rows[row]["data_pagamento"]);
                        if (data_pagamento < Convert.ToDateTime("01/01/1900"))
                            data_pagamento = Convert.ToDateTime("01/01/1900");
                    }

                    if (parcelas.Tables[0].Rows[row]["vlr_pagamento"].ToString() != "")
                    {
                        vlr_pagamento = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["vlr_pagamento"]);
                    }

                    if (parcelas.Tables[0].Rows[row]["vlr_original"].ToString() != "")
                    {
                        vlr_original = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["vlr_original"]);
                    }

                    if (parcelas.Tables[0].Rows[row]["vlr_pagamento"].ToString() != "")
                    {
                        vlr_pagamento = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["vlr_pagamento"]);
                    }

                    nossonumero = parcelas.Tables[0].Rows[row]["nossonumero"].ToString().Trim();
                    origem_pagamento = parcelas.Tables[0].Rows[row]["origem_pagamento"].ToString().Trim();
                    ativa = Convert.ToBoolean(parcelas.Tables[0].Rows[row]["ativa"]);

                    if (parcelas.Tables[0].Rows[row]["percentual_correcao"].ToString() != "")
                    {
                        percentual_correcao = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["percentual_correcao"]);
                    }

                    carteira = Convert.ToBoolean(parcelas.Tables[0].Rows[row]["carteira"]);
                    protesto = Convert.ToBoolean(parcelas.Tables[0].Rows[row]["protesto"]);
                    contabil = Convert.ToBoolean(parcelas.Tables[0].Rows[row]["contabil"]);
                    if (parcelas.Tables[0].Rows[row]["tx_multa"].ToString() != "")
                    {
                        tx_multa = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["tx_multa"]);
                    }
                    if (parcelas.Tables[0].Rows[row]["tx_comissao"].ToString() != "")
                    {
                        tx_comissao = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["tx_comissao"]);
                    }
                    if (parcelas.Tables[0].Rows[row]["vlr_multa"].ToString() != "")
                    {
                        vlr_multa = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["vlr_multa"]);
                    }
                    if (parcelas.Tables[0].Rows[row]["vlr_comissao"].ToString() != "")
                    {
                        vlr_comissao = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["vlr_comissao"]);
                    }
                    if (parcelas.Tables[0].Rows[row]["vlr_desconto"].ToString() != "")
                    {
                        vlr_desconto = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["vlr_desconto"]);
                    }

                    periodicidade_comissao = parcelas.Tables[0].Rows[row]["periodicidade_comissao"].ToString().Trim();
                    data_conta = Convert.ToDateTime("01/01/1900");
                    conta = parcelas.Tables[0].Rows[row]["conta"].ToString().Trim();
                    indexador = parcelas.Tables[0].Rows[row]["indexador"].ToString().Trim().ToUpper();
                    if (parcelas.Tables[0].Rows[row]["indexador_mes"].ToString() != "")
                    {
                        indexador_mes = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["indexador_mes"]);
                    }
                    if (parcelas.Tables[0].Rows[row]["indexador_acumulado"].ToString() != "")
                    {
                        indexador_acumulado = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["indexador_acumulado"]);
                    }
                    if (parcelas.Tables[0].Rows[row]["residuo_mes"].ToString() != "")
                    {
                        residuo_mes = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["residuo_mes"]);
                    }
                    if (parcelas.Tables[0].Rows[row]["residuo_acumulado"].ToString() != "")
                    {
                        residuo_acumulado = Convert.ToDecimal(parcelas.Tables[0].Rows[row]["residuo_acumulado"]);
                    }
                    observacao = parcelas.Tables[0].Rows[row]["observacao"].ToString().Trim();

                    if (parcela != String.Empty)
                    {
                        //Parcelas
                        if (xparte2 == "0")
                        {
                            uParcelas.Grava(xproduto,
                                            xgrupo,
                                            xunidade,
                                            xparte,
                                            parcela,
                                            tipo,
                                            Convert.ToString(data_vencimento).Substring(0, 10),
                                            vlr_parcela,
                                            Convert.ToString(data_pagamento).Substring(0, 10),
                                            vlr_pagamento,
                                            Convert.ToString(data_original).Substring(0, 10),
                                            vlr_original,
                                            Convert.ToString(data_base).Substring(0, 10),
                                            vlr_base,
                                            nossonumero,
                                            origem_pagamento,
                                            Convert.ToInt16(ativa),
                                            percentual_correcao,
                                            Convert.ToInt16(carteira),
                                            Convert.ToInt16(protesto),
                                            Convert.ToInt16(contabil),
                                            tx_multa,
                                            tx_comissao,
                                            vlr_multa,
                                            vlr_comissao,
                                            vlr_desconto,
                                            periodicidade_comissao,
                                            Convert.ToString(data_conta).Substring(0, 10),
                                            conta,
                                            indexador,
                                            indexador_mes,
                                            indexador_acumulado,
                                            residuo_mes,
                                            residuo_acumulado,
                                            vlr_correcao,
                                            observacao
                                            );
                        }
                        else
                        {
                            uParcelas.Grava(xproduto,
                                            xgrupo,
                                            xunidade,
                                            xmeiolote,
                                            parcela,
                                            tipo,
                                            Convert.ToString(data_vencimento).Substring(0, 10),
                                            vlr_parcela,
                                            Convert.ToString(data_pagamento).Substring(0, 10),
                                            vlr_pagamento,
                                            Convert.ToString(data_original).Substring(0, 10),
                                            vlr_original,
                                            Convert.ToString(data_base).Substring(0, 10),
                                            vlr_base,
                                            nossonumero,
                                            origem_pagamento,
                                            Convert.ToInt16(ativa),
                                            percentual_correcao,
                                            Convert.ToInt16(carteira),
                                            Convert.ToInt16(protesto),
                                            Convert.ToInt16(contabil),
                                            tx_multa,
                                            tx_comissao,
                                            vlr_multa,
                                            vlr_comissao,
                                            vlr_desconto,
                                            periodicidade_comissao,
                                            Convert.ToString(data_conta).Substring(0, 10),
                                            conta,
                                            indexador,
                                            indexador_mes,
                                            indexador_acumulado,
                                            residuo_mes,
                                            residuo_acumulado,
                                            vlr_correcao,
                                            observacao
                                            );
                        }
                    }
                    //
                    parcela = "";
                    tipo = "";
                    data_vencimento = Convert.ToDateTime("01/01/1900");
                    vlr_parcela = 0;
                    data_pagamento = Convert.ToDateTime("01/01/1900");
                    vlr_pagamento = 0;
                    data_original = Convert.ToDateTime("01/01/1900");
                    vlr_original = 0;
                    data_base = Convert.ToDateTime("01/01/1900");
                    vlr_base = 0;
                    nossonumero = "";
                    origem_pagamento = "";
                    ativa = false;
                    percentual_correcao = 0;
                    carteira = false;
                    protesto = false;
                    contabil = false;
                    tx_multa = 0;
                    tx_comissao = 0;
                    vlr_multa = 0;
                    vlr_comissao = 0;
                    vlr_desconto = 0;
                    periodicidade_comissao = "";
                    data_conta = Convert.ToDateTime("01/01/1900");
                    conta = "";
                    indexador = "";
                    indexador_mes = 0;
                    indexador_acumulado = 0;
                    residuo_mes = 0;
                    residuo_acumulado = 0;
                    vlr_correcao = 0;
                    observacao = "";
                    //
                    // Parcelas Venda 2 para Venda 1
                }
                //Fim Migração Arquivo Parcelas 
            }
        }
        //
        return " ";
    }


    public static string GravaPermutaUnidadeVendida(string xproduto,
                                                    string xgrupo,
                                                    string xunidade,
                                                    string xparte,
                                                    string xmeiolote,
                                                    string xcliente,
                                                    string xcliente2,
                                                    string xproduto2,
                                                    string xgrupo2,
                                                    string xunidade2,
                                                    string xparte2,
                                                    string xmeiolote2,
                                                    string xrbtipodestino)
    {
        //Vendas
        string script = "";
        //
        //Tranferindo Venda 1 para Venda X
        if (xparte == "0")
        {
            script = "update vendas " +
            " SET " +
            " produto = " + "9999" + ", " +
            " grupo = " + "9999" + ", " +
            " unidade = " + "9999" + ", " +
            " parte = " + "0" +
            " WHERE (produto = " + xproduto + " " +
            " AND grupo = " + xgrupo + " " +
            " AND unidade = " + xunidade + " " +
            " AND parte = " + xparte + ") ";
        }
        else
        {
            script = "update vendas " +
            " SET " +
            " produto = " + "9999" + ", " +
            " grupo = " + "9999" + ", " +
            " unidade = " + "9999" + ", " +
            " parte = " + "0" +
            " WHERE (produto = " + xproduto + " " +
            " AND grupo = " + xgrupo + " " +
            " AND unidade = " + xunidade + " " +
            " AND parte = " + xmeiolote + ") ";
        }
        SreDblib.ExecScript(script);
        //Fim Tranferindo Venda 1 para Venda X
        //
        //
        //Tranferindo Venda 2 para Venda 1
        if (xparte == "0")
        {
            if (xparte2 == "0")
            {
                script = "update vendas " +
                " SET " +
                " produto = " + xproduto + ", " +
                " grupo = " + xgrupo + ", " +
                " unidade = " + xunidade + ", " +
                " parte = " + xparte +
                " WHERE (produto = " + xproduto2 + " " +
                " AND grupo = " + xgrupo2 + " " +
                " AND unidade = " + xunidade2 + " " +
                " AND parte = " + xparte2 + ") ";
            }
            else
            {
                script = "update vendas " +
                " SET " +
                " produto = " + xproduto + ", " +
                " grupo = " + xgrupo + ", " +
                " unidade = " + xunidade + ", " +
                " parte = " + xparte +
                " WHERE (produto = " + xproduto2 + " " +
                " AND grupo = " + xgrupo2 + " " +
                " AND unidade = " + xunidade2 + " " +
                " AND parte = " + xmeiolote2 + ") ";
            }
        }
        else
        {
            if (xparte2 == "0")
            {
                script = "update vendas " +
                " SET " +
                " produto = " + xproduto + ", " +
                " grupo = " + xgrupo + ", " +
                " unidade = " + xunidade + ", " +
                " parte = " + xmeiolote +
                " WHERE (produto = " + xproduto2 + " " +
                " AND grupo = " + xgrupo2 + " " +
                " AND unidade = " + xunidade2 + " " +
                " AND parte = " + xparte2 + ") ";
            }
            else
            {
                script = "update vendas " +
                " SET " +
                " produto = " + xproduto + ", " +
                " grupo = " + xgrupo + ", " +
                " unidade = " + xunidade + ", " +
                " parte = " + xmeiolote +
                " WHERE (produto = " + xproduto2 + " " +
                " AND grupo = " + xgrupo2 + " " +
                " AND unidade = " + xunidade2 + " " +
                " AND parte = " + xmeiolote2 + ") ";
            }
        }
        SreDblib.ExecScript(script);
        //Fim Tranferindo Venda 2 para Venda 1
        //
        //
        //Tranferindo Venda X para Venda 2
        if (xparte2 == "0")
        {
            script = "update vendas " +
            " SET " +
            " produto = " + xproduto2 + ", " +
            " grupo = " + xgrupo2 + ", " +
            " unidade = " + xunidade2 + ", " +
            " parte = " + xparte2 +
            " WHERE (produto = " + "9999" + " " +
            " AND grupo = " + "9999" + " " +
            " AND unidade = " + "9999" + " " +
            " AND parte = " + "0" + ") ";
        }
        else
        {
            script = "update vendas " +
            " SET " +
            " produto = " + xproduto2 + ", " +
            " grupo = " + xgrupo2 + ", " +
            " unidade = " + xunidade2 + ", " +
            " parte = " + xmeiolote2 +
            " WHERE (produto = " + "9999" + " " +
            " AND grupo = " + "9999" + " " +
            " AND unidade = " + "9999" + " " +
            " AND parte = " + "0" + ") ";
        }
        SreDblib.ExecScript(script);
        //Fim Tranferindo Venda X para Venda 2
        //
        // Produto Unidades Atualizar Cliente Comprador
        if ((xparte == "0") || (xparte == "1"))
        {
            if ((xparte2 == "0") || (xparte2 == "1"))
            {
                //Unidade Origem
                script = "";
                script = "update PRODUTO_UNIDADES " +
                " SET proprietario_1 = " + xcliente2 +
                " WHERE (produto = " + xproduto +
                " AND grupo = " + xgrupo + " " +
                " AND unidade = " + xunidade +
                " AND parte = " + xparte + ") ";
                //
                SreDblib.ExecScript(script);
                //
                //Unidade Destino
                script = "";
                script = "update PRODUTO_UNIDADES " +
                " SET proprietario_1 = " + xcliente +
                " WHERE (produto = " + xproduto2 +
                " AND grupo = " + xgrupo2 + " " +
                " AND unidade = " + xunidade2 +
                " AND parte = " + xparte2 + ") ";
                //
                SreDblib.ExecScript(script);
                //
            }
            else
            {
                //Unidade Origem
                script = "";
                script = "update PRODUTO_UNIDADES " +
                " SET proprietario_1 = " + xcliente2 +
                " WHERE (produto = " + xproduto +
                " AND grupo = " + xgrupo + " " +
                " AND unidade = " + xunidade +
                " AND parte = " + xparte + ") ";
                //
                SreDblib.ExecScript(script);
                //
                //Unidade Destino
                script = "";
                script = "update PRODUTO_UNIDADES " +
                " SET proprietario_1 = " + xcliente +
                " WHERE (produto = " + xproduto2 +
                " AND grupo = " + xgrupo2 + " " +
                " AND unidade = " + xunidade2 +
                " AND parte = " + xmeiolote2 + ") ";
                //
                SreDblib.ExecScript(script);
                //
            }
        }
        else
        {
            if ((xparte2 == "0") || (xparte2 == "1"))
            {
                //Unidade Origem
                script = "";
                script = "update PRODUTO_UNIDADES " +
                " SET proprietario_2 = " + xcliente2 +
                " WHERE (produto = " + xproduto +
                " AND grupo = " + xgrupo + " " +
                " AND unidade = " + xunidade +
                " AND parte = " + xmeiolote + ") ";
                //
                SreDblib.ExecScript(script);
                //
                //Unidade Destino
                script = "";
                script = "update PRODUTO_UNIDADES " +
                " SET proprietario_2 = " + xcliente +
                " WHERE (produto = " + xproduto2 +
                " AND grupo = " + xgrupo2 + " " +
                " AND unidade = " + xunidade2 +
                " AND parte = " + xparte2 + ") ";
                //
                SreDblib.ExecScript(script);
                //
            }
            else
            {
                //Unidade Origem
                script = "";
                script = "update PRODUTO_UNIDADES " +
                " SET proprietario_2 = " + xcliente2 +
                " WHERE (produto = " + xproduto +
                " AND grupo = " + xgrupo + " " +
                " AND unidade = " + xunidade +
                " AND parte = " + xmeiolote + ") ";
                //
                SreDblib.ExecScript(script);
                //
                //Unidade Destino
                script = "";
                script = "update PRODUTO_UNIDADES " +
                " SET proprietario_2 = " + xcliente +
                " WHERE (produto = " + xproduto2 +
                " AND grupo = " + xgrupo2 + " " +
                " AND unidade = " + xunidade2 +
                " AND parte = " + xmeiolote2 + ") ";
                //
                SreDblib.ExecScript(script);
                //
            }
        }
        // Fim Produto Unidades Atualizar Cliente Comprador
        //
        //
        //Parcelas Origem - Empreendimento ou Bloco Iguais
        if ((xproduto == xproduto2) && (xgrupo == xgrupo2))
        {
            //Mesmo Empreendimento e Bloco
            string nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);
            //
            //Tranferindo Parcelas Venda 1 para Venda X
            script = "";
            if ((xparte == "0") || (xparte == "1"))
            {
                script = "update " + nomearquivo + " " +
                " SET " +
                " produto = " + "9999" + ", " +
                " grupo = " + "9999" + ", " +
                " unidade = " + "9999" + ", " +
                " parte = " + "0" +
                " WHERE (produto = " + xproduto + " " +
                " AND grupo = " + xgrupo + " " +
                " AND unidade = " + xunidade + " " +
                " AND parte = " + xparte + ") ";
            }
            else
            {
                script = "update " + nomearquivo + " " +
                " SET " +
                " produto = " + "9999" + ", " +
                " grupo = " + "9999" + ", " +
                " unidade = " + "9999" + ", " +
                " parte = " + "0" +
                " WHERE (produto = " + xproduto + " " +
                " AND grupo = " + xgrupo + " " +
                " AND unidade = " + xunidade + " " +
                " AND parte = " + xmeiolote + ") ";
            }
            SreDblib.ExecScript(script);
            //
            //Tranferindo Parcelas Venda 2 para Venda 1
            script = "";
            if ((xparte == "0") || (xparte == "1"))
            {
                if ((xparte2 == "0") || (xparte2 == "1"))
                {
                    script = "update " + nomearquivo + " " +
                    " SET " +
                    " produto = " + xproduto + ", " +
                    " grupo = " + xgrupo + ", " +
                    " unidade = " + xunidade + ", " +
                    " parte = " + xparte +
                    " WHERE (produto = " + xproduto2 + " " +
                    " AND grupo = " + xgrupo2 + " " +
                    " AND unidade = " + xunidade2 + " " +
                    " AND parte = " + xparte2 + ") ";
                }
                else
                {
                    script = "update " + nomearquivo + " " +
                    " SET " +
                    " produto = " + xproduto + ", " +
                    " grupo = " + xgrupo + ", " +
                    " unidade = " + xunidade + ", " +
                    " parte = " + xmeiolote +
                    " WHERE (produto = " + xproduto2 + " " +
                    " AND grupo = " + xgrupo2 + " " +
                    " AND unidade = " + xunidade2 + " " +
                    " AND parte = " + xparte2 + ") ";
                }
            }
            else
            {
                if ((xparte2 == "0") || (xparte2 == "1"))
                {
                    script = "update " + nomearquivo + " " +
                    " SET " +
                    " produto = " + xproduto + ", " +
                    " grupo = " + xgrupo + ", " +
                    " unidade = " + xunidade + ", " +
                    " parte = " + xparte +
                    " WHERE (produto = " + xproduto2 + " " +
                    " AND grupo = " + xgrupo2 + " " +
                    " AND unidade = " + xunidade2 + " " +
                    " AND parte = " + xmeiolote2 + ") ";
                }
                else
                {
                    script = "update " + nomearquivo + " " +
                    " SET " +
                    " produto = " + xproduto + ", " +
                    " grupo = " + xgrupo + ", " +
                    " unidade = " + xunidade + ", " +
                    " parte = " + xmeiolote +
                    " WHERE (produto = " + xproduto2 + " " +
                    " AND grupo = " + xgrupo2 + " " +
                    " AND unidade = " + xunidade2 + " " +
                    " AND parte = " + xmeiolote2 + ") ";
                }
            }
            SreDblib.ExecScript(script);
            //
            //Tranferindo Parcelas Venda X para Venda 2
            script = "";
            if ((xparte == "0") || (xparte == "1"))
            {
                script = "update " + nomearquivo + " " +
                " SET " +
                " produto = " + xproduto2 + ", " +
                " grupo = " + xgrupo2 + ", " +
                " unidade = " + xunidade2 + ", " +
                " parte = " + xparte2 + " " +
                " WHERE (produto = " + "9999" + " " +
                " AND grupo = " + "9999" + " " +
                " AND unidade = " + "9999" + " " +
                " AND parte = " + "0" + ") ";
            }
            else
            {
                script = "update " + nomearquivo + " " +
                " SET " +
                " produto = " + xproduto2 + ", " +
                " grupo = " + xgrupo2 + ", " +
                " unidade = " + xunidade2 + ", " +
                " parte = " + xmeiolote2 + " " +
                " WHERE (produto = " + "9999" + " " +
                " AND grupo = " + "9999" + " " +
                " AND unidade = " + "9999" + " " +
                " AND parte = " + "0" + ") ";
            }
            SreDblib.ExecScript(script);
        }
        else
        {
            //Parcela Origem - Diferente Empreendimento ou Bloco
            //Venda 1
            string nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);
            //
            DataSet parcelas = uParcelas.PegaDadosParcelas2(xproduto,
                                                           xgrupo,
                                                           xunidade,
                                                           xparte,
                                                           xmeiolote,
                                                          "01/01/1900",
                                                          "31/12/2999",
                                                           "T",
                                                           "0",
                                                           "N",
                                                           false,
                                                           "0");
            // Excluir Parcelas
            if (xparte == "0")
            {
                script = "delete " + nomearquivo + " " +
                         " WHERE (produto = " + xproduto +
                         " AND grupo = " + xgrupo + " " +
                         " AND unidade = " + xunidade +
                         " AND parte = " + xparte + ") ";
            }
            else
            {
                script = "delete " + nomearquivo + " " +
                         " WHERE (produto = " + xproduto +
                         " AND grupo = " + xgrupo + " " +
                         " AND unidade = " + xunidade +
                         " AND parte = " + xmeiolote + ") ";
            }
            SreDblib.ExecScript(script);
            //
            //Venda 2
            string nomearquivo2 = "parcelas_" + Srelib.QStr0(xproduto2.Trim(), 5) + "_" + Srelib.QStr0(xgrupo2.Trim(), 5);
            //
            DataSet parcelas2 = uParcelas.PegaDadosParcelas2(xproduto2,
                                                            xgrupo2,
                                                            xunidade2,
                                                            xparte2,
                                                            xmeiolote2,
                                                           "01/01/1900",
                                                           "31/12/2999",
                                                            "T",
                                                            "0",
                                                            "N",
                                                            false,
                                                            "0");
            //
            // Excluir Parcelas
            if (xparte2 == "0")
            {
                script = "delete " + nomearquivo2 + " " +
                         " WHERE (produto = " + xproduto2 +
                         " AND grupo = " + xgrupo2 + " " +
                         " AND unidade = " + xunidade2 +
                         " AND parte = " + xparte2 + ") ";
            }
            else
            {
                script = "delete " + nomearquivo2 + " " +
                         " WHERE (produto = " + xproduto2 +
                         " AND grupo = " + xgrupo2 + " " +
                         " AND unidade = " + xunidade2 +
                         " AND parte = " + xmeiolote2 + ") ";
            }
            SreDblib.ExecScript(script);
            //
            //Parcela Origem - Gravar Parcelas Venda 2 para Venda 1
            nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);
            //
            string parcela = "";
            string tipo = "";
            DateTime data_vencimento = Convert.ToDateTime("01/01/1900");
            decimal vlr_parcela = 0;
            DateTime data_pagamento = Convert.ToDateTime("01/01/1900");
            decimal vlr_pagamento = 0;
            DateTime data_original = Convert.ToDateTime("01/01/1900");
            decimal vlr_original = 0;
            DateTime data_base = Convert.ToDateTime("01/01/1900");
            decimal vlr_base = 0;
            string nossonumero = "";
            string origem_pagamento = "";
            Boolean ativa = false;
            decimal percentual_correcao = 0;
            Boolean carteira = false;
            Boolean protesto = false;
            Boolean contabil = false;
            decimal tx_multa = 0;
            decimal tx_comissao = 0;
            decimal vlr_multa = 0;
            decimal vlr_comissao = 0;
            decimal vlr_desconto = 0;
            string periodicidade_comissao = "";
            DateTime data_conta = Convert.ToDateTime("01/01/1900");
            string conta = "";
            string indexador = "";
            decimal indexador_mes = 0;
            decimal indexador_acumulado = 0;
            decimal residuo_mes = 0;
            decimal residuo_acumulado = 0;
            decimal vlr_correcao = 0;
            string observacao = "";
            //
            for (int row = 0; row < parcelas2.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                // 
                parcela = parcelas2.Tables[0].Rows[row]["parcela"].ToString().Trim();
                tipo = parcelas2.Tables[0].Rows[row]["tipo"].ToString().Trim();

                if (parcelas2.Tables[0].Rows[row]["data_vencimento"].ToString() != "")
                {
                    data_vencimento = Convert.ToDateTime(parcelas2.Tables[0].Rows[row]["data_vencimento"]);
                    if (data_vencimento < Convert.ToDateTime("01/01/1900"))
                        data_vencimento = Convert.ToDateTime("01/01/1900");
                }
                if (parcelas2.Tables[0].Rows[row]["vlr_parcela"].ToString() != "")
                {
                    vlr_parcela = Convert.ToDecimal(parcelas2.Tables[0].Rows[row]["vlr_parcela"]);
                }

                if (parcelas2.Tables[0].Rows[row]["data_pagamento"].ToString() != "")
                {
                    data_pagamento = Convert.ToDateTime(parcelas2.Tables[0].Rows[row]["data_pagamento"]);
                    if (data_pagamento < Convert.ToDateTime("01/01/1900"))
                        data_pagamento = Convert.ToDateTime("01/01/1900");
                }

                if (parcelas2.Tables[0].Rows[row]["vlr_pagamento"].ToString() != "")
                {
                    vlr_pagamento = Convert.ToDecimal(parcelas2.Tables[0].Rows[row]["vlr_pagamento"]);
                }

                if (parcelas2.Tables[0].Rows[row]["vlr_original"].ToString() != "")
                {
                    vlr_original = Convert.ToDecimal(parcelas2.Tables[0].Rows[row]["vlr_original"]);
                }

                if (parcelas2.Tables[0].Rows[row]["vlr_pagamento"].ToString() != "")
                {
                    vlr_pagamento = Convert.ToDecimal(parcelas2.Tables[0].Rows[row]["vlr_pagamento"]);
                }

                nossonumero = parcelas2.Tables[0].Rows[row]["nossonumero"].ToString().Trim();
                origem_pagamento = parcelas2.Tables[0].Rows[row]["origem_pagamento"].ToString().Trim();
                ativa = Convert.ToBoolean(parcelas2.Tables[0].Rows[row]["ativa"]);

                if (parcelas2.Tables[0].Rows[row]["percentual_correcao"].ToString() != "")
                {
                    percentual_correcao = Convert.ToDecimal(parcelas2.Tables[0].Rows[row]["percentual_correcao"]);
                }

                carteira = Convert.ToBoolean(parcelas2.Tables[0].Rows[row]["carteira"]);
                protesto = Convert.ToBoolean(parcelas2.Tables[0].Rows[row]["protesto"]);
                contabil = Convert.ToBoolean(parcelas2.Tables[0].Rows[row]["contabil"]);
                if (parcelas2.Tables[0].Rows[row]["tx_multa"].ToString() != "")
                {
                    tx_multa = Convert.ToDecimal(parcelas2.Tables[0].Rows[row]["tx_multa"]);
                }
                if (parcelas2.Tables[0].Rows[row]["tx_comissao"].ToString() != "")
                {
                    tx_comissao = Convert.ToDecimal(parcelas2.Tables[0].Rows[row]["tx_comissao"]);
                }
                if (parcelas2.Tables[0].Rows[row]["vlr_multa"].ToString() != "")
                {
                    vlr_multa = Convert.ToDecimal(parcelas2.Tables[0].Rows[row]["vlr_multa"]);
                }
                if (parcelas2.Tables[0].Rows[row]["vlr_comissao"].ToString() != "")
                {
                    vlr_comissao = Convert.ToDecimal(parcelas2.Tables[0].Rows[row]["vlr_comissao"]);
                }
                if (parcelas2.Tables[0].Rows[row]["vlr_desconto"].ToString() != "")
                {
                    vlr_desconto = Convert.ToDecimal(parcelas2.Tables[0].Rows[row]["vlr_desconto"]);
                }

                periodicidade_comissao = parcelas2.Tables[0].Rows[row]["periodicidade_comissao"].ToString().Trim();
                data_conta = Convert.ToDateTime("01/01/1900");
                conta = parcelas2.Tables[0].Rows[row]["conta"].ToString().Trim();
                indexador = parcelas2.Tables[0].Rows[row]["indexador"].ToString().Trim().ToUpper();
                if (parcelas2.Tables[0].Rows[row]["indexador_mes"].ToString() != "")
                {
                    indexador_mes = Convert.ToDecimal(parcelas2.Tables[0].Rows[row]["indexador_mes"]);
                }
                if (parcelas2.Tables[0].Rows[row]["indexador_acumulado"].ToString() != "")
                {
                    indexador_acumulado = Convert.ToDecimal(parcelas2.Tables[0].Rows[row]["indexador_acumulado"]);
                }
                if (parcelas2.Tables[0].Rows[row]["residuo_mes"].ToString() != "")
                {
                    residuo_mes = Convert.ToDecimal(parcelas2.Tables[0].Rows[row]["residuo_mes"]);
                }
                if (parcelas2.Tables[0].Rows[row]["residuo_acumulado"].ToString() != "")
                {
                    residuo_acumulado = Convert.ToDecimal(parcelas2.Tables[0].Rows[row]["residuo_acumulado"]);
                }
                observacao = parcelas2.Tables[0].Rows[row]["observacao"].ToString().Trim();

                //Grava Parcelas
                if (xparte == "0")
                {
                    uParcelas.Grava(xproduto,
                                    xgrupo,
                                    xunidade,
                                    xparte,
                                    parcela,
                                    tipo,
                                    Convert.ToString(data_vencimento).Substring(0, 10),
                                    vlr_parcela,
                                    Convert.ToString(data_pagamento).Substring(0, 10),
                                    vlr_pagamento,
                                    Convert.ToString(data_original).Substring(0, 10),
                                    vlr_original,
                                    Convert.ToString(data_base).Substring(0, 10),
                                    vlr_base,
                                    nossonumero,
                                    origem_pagamento,
                                    Convert.ToInt16(ativa),
                                    percentual_correcao,
                                    Convert.ToInt16(carteira),
                                    Convert.ToInt16(protesto),
                                    Convert.ToInt16(contabil),
                                    tx_multa,
                                    tx_comissao,
                                    vlr_multa,
                                    vlr_comissao,
                                    vlr_desconto,
                                    periodicidade_comissao,
                                    Convert.ToString(data_conta).Substring(0, 10),
                                    conta,
                                    indexador,
                                    indexador_mes,
                                    indexador_acumulado,
                                    residuo_mes,
                                    residuo_acumulado,
                                    vlr_correcao,
                                    observacao
                                    );
                }
                else
                {
                    uParcelas.Grava(xproduto,
                                    xgrupo,
                                    xunidade,
                                    xmeiolote,
                                    parcela,
                                    tipo,
                                    Convert.ToString(data_vencimento).Substring(0, 10),
                                    vlr_parcela,
                                    Convert.ToString(data_pagamento).Substring(0, 10),
                                    vlr_pagamento,
                                    Convert.ToString(data_original).Substring(0, 10),
                                    vlr_original,
                                    Convert.ToString(data_base).Substring(0, 10),
                                    vlr_base,
                                    nossonumero,
                                    origem_pagamento,
                                    Convert.ToInt16(ativa),
                                    percentual_correcao,
                                    Convert.ToInt16(carteira),
                                    Convert.ToInt16(protesto),
                                    Convert.ToInt16(contabil),
                                    tx_multa,
                                    tx_comissao,
                                    vlr_multa,
                                    vlr_comissao,
                                    vlr_desconto,
                                    periodicidade_comissao,
                                    Convert.ToString(data_conta).Substring(0, 10),
                                    conta,
                                    indexador,
                                    indexador_mes,
                                    indexador_acumulado,
                                    residuo_mes,
                                    residuo_acumulado,
                                    vlr_correcao,
                                    observacao
                                    );
                }
                //
                parcela = "";
                tipo = "";
                data_vencimento = Convert.ToDateTime("01/01/1900");
                vlr_parcela = 0;
                data_pagamento = Convert.ToDateTime("01/01/1900");
                vlr_pagamento = 0;
                data_original = Convert.ToDateTime("01/01/1900");
                vlr_original = 0;
                data_base = Convert.ToDateTime("01/01/1900");
                vlr_base = 0;
                nossonumero = "";
                origem_pagamento = "";
                ativa = false;
                percentual_correcao = 0;
                carteira = false;
                protesto = false;
                contabil = false;
                tx_multa = 0;
                tx_comissao = 0;
                vlr_multa = 0;
                vlr_comissao = 0;
                vlr_desconto = 0;
                periodicidade_comissao = "";
                data_conta = Convert.ToDateTime("01/01/1900");
                conta = "";
                indexador = "";
                indexador_mes = 0;
                indexador_acumulado = 0;
                residuo_mes = 0;
                residuo_acumulado = 0;
                vlr_correcao = 0;
                observacao = "";
            }
            //Fim Migração Arquivo Parcelas Venda 2
            //
            //Parcela Origem - Gravar Parcelas Venda 1 para Venda 2
            nomearquivo = "parcelas_" + Srelib.QStr0(xproduto2.Trim(), 5) + "_" + Srelib.QStr0(xgrupo2.Trim(), 5);
            //
            parcela = "";
            tipo = "";
            data_vencimento = Convert.ToDateTime("01/01/1900");
            vlr_parcela = 0;
            data_pagamento = Convert.ToDateTime("01/01/1900");
            vlr_pagamento = 0;
            data_original = Convert.ToDateTime("01/01/1900");
            vlr_original = 0;
            data_base = Convert.ToDateTime("01/01/1900");
            vlr_base = 0;
            nossonumero = "";
            origem_pagamento = "";
            ativa = false;
            percentual_correcao = 0;
            carteira = false;
            protesto = false;
            contabil = false;
            tx_multa = 0;
            tx_comissao = 0;
            vlr_multa = 0;
            vlr_comissao = 0;
            vlr_desconto = 0;
            periodicidade_comissao = "";
            data_conta = Convert.ToDateTime("01/01/1900");
            conta = "";
            indexador = "";
            indexador_mes = 0;
            indexador_acumulado = 0;
            residuo_mes = 0;
            residuo_acumulado = 0;
            vlr_correcao = 0;
            observacao = "";
            //
            for (int row2 = 0; row2 < parcelas.Tables[0].Rows.Count; row2++)
            //int row = 0;
            {
                // 
                parcela = parcelas.Tables[0].Rows[row2]["parcela"].ToString().Trim();
                tipo = parcelas.Tables[0].Rows[row2]["tipo"].ToString().Trim();

                if (parcelas.Tables[0].Rows[row2]["data_vencimento"].ToString() != "")
                {
                    data_vencimento = Convert.ToDateTime(parcelas.Tables[0].Rows[row2]["data_vencimento"]);
                    if (data_vencimento < Convert.ToDateTime("01/01/1900"))
                        data_vencimento = Convert.ToDateTime("01/01/1900");
                }
                if (parcelas.Tables[0].Rows[row2]["vlr_parcela"].ToString() != "")
                {
                    vlr_parcela = Convert.ToDecimal(parcelas.Tables[0].Rows[row2]["vlr_parcela"]);
                }

                if (parcelas.Tables[0].Rows[row2]["data_pagamento"].ToString() != "")
                {
                    data_pagamento = Convert.ToDateTime(parcelas.Tables[0].Rows[row2]["data_pagamento"]);
                    if (data_pagamento < Convert.ToDateTime("01/01/1900"))
                        data_pagamento = Convert.ToDateTime("01/01/1900");
                }

                if (parcelas.Tables[0].Rows[row2]["vlr_pagamento"].ToString() != "")
                {
                    vlr_pagamento = Convert.ToDecimal(parcelas.Tables[0].Rows[row2]["vlr_pagamento"]);
                }

                if (parcelas.Tables[0].Rows[row2]["vlr_original"].ToString() != "")
                {
                    vlr_original = Convert.ToDecimal(parcelas.Tables[0].Rows[row2]["vlr_original"]);
                }

                if (parcelas.Tables[0].Rows[row2]["vlr_pagamento"].ToString() != "")
                {
                    vlr_pagamento = Convert.ToDecimal(parcelas.Tables[0].Rows[row2]["vlr_pagamento"]);
                }

                nossonumero = parcelas.Tables[0].Rows[row2]["nossonumero"].ToString().Trim();
                origem_pagamento = parcelas.Tables[0].Rows[row2]["origem_pagamento"].ToString().Trim();
                ativa = Convert.ToBoolean(parcelas.Tables[0].Rows[row2]["ativa"]);

                if (parcelas.Tables[0].Rows[row2]["percentual_correcao"].ToString() != "")
                {
                    percentual_correcao = Convert.ToDecimal(parcelas.Tables[0].Rows[row2]["percentual_correcao"]);
                }

                carteira = Convert.ToBoolean(parcelas.Tables[0].Rows[row2]["carteira"]);
                protesto = Convert.ToBoolean(parcelas.Tables[0].Rows[row2]["protesto"]);
                contabil = Convert.ToBoolean(parcelas.Tables[0].Rows[row2]["contabil"]);
                if (parcelas.Tables[0].Rows[row2]["tx_multa"].ToString() != "")
                {
                    tx_multa = Convert.ToDecimal(parcelas.Tables[0].Rows[row2]["tx_multa"]);
                }
                if (parcelas.Tables[0].Rows[row2]["tx_comissao"].ToString() != "")
                {
                    tx_comissao = Convert.ToDecimal(parcelas.Tables[0].Rows[row2]["tx_comissao"]);
                }
                if (parcelas.Tables[0].Rows[row2]["vlr_multa"].ToString() != "")
                {
                    vlr_multa = Convert.ToDecimal(parcelas.Tables[0].Rows[row2]["vlr_multa"]);
                }
                if (parcelas.Tables[0].Rows[row2]["vlr_comissao"].ToString() != "")
                {
                    vlr_comissao = Convert.ToDecimal(parcelas.Tables[0].Rows[row2]["vlr_comissao"]);
                }
                if (parcelas.Tables[0].Rows[row2]["vlr_desconto"].ToString() != "")
                {
                    vlr_desconto = Convert.ToDecimal(parcelas.Tables[0].Rows[row2]["vlr_desconto"]);
                }

                periodicidade_comissao = parcelas.Tables[0].Rows[row2]["periodicidade_comissao"].ToString().Trim();
                data_conta = Convert.ToDateTime("01/01/1900");
                conta = parcelas.Tables[0].Rows[row2]["conta"].ToString().Trim();
                indexador = parcelas.Tables[0].Rows[row2]["indexador"].ToString().Trim().ToUpper();
                if (parcelas.Tables[0].Rows[row2]["indexador_mes"].ToString() != "")
                {
                    indexador_mes = Convert.ToDecimal(parcelas.Tables[0].Rows[row2]["indexador_mes"]);
                }
                if (parcelas.Tables[0].Rows[row2]["indexador_acumulado"].ToString() != "")
                {
                    indexador_acumulado = Convert.ToDecimal(parcelas.Tables[0].Rows[row2]["indexador_acumulado"]);
                }
                if (parcelas.Tables[0].Rows[row2]["residuo_mes"].ToString() != "")
                {
                    residuo_mes = Convert.ToDecimal(parcelas.Tables[0].Rows[row2]["residuo_mes"]);
                }
                if (parcelas.Tables[0].Rows[row2]["residuo_acumulado"].ToString() != "")
                {
                    residuo_acumulado = Convert.ToDecimal(parcelas.Tables[0].Rows[row2]["residuo_acumulado"]);
                }
                observacao = parcelas.Tables[0].Rows[row2]["observacao"].ToString().Trim();

                //Grava Parcelas
                if (xparte2 == "0")
                {
                    uParcelas.Grava(xproduto2,
                                    xgrupo2,
                                    xunidade2,
                                    xparte2,
                                    parcela,
                                    tipo,
                                    Convert.ToString(data_vencimento).Substring(0, 10),
                                    vlr_parcela,
                                    Convert.ToString(data_pagamento).Substring(0, 10),
                                    vlr_pagamento,
                                    Convert.ToString(data_original).Substring(0, 10),
                                    vlr_original,
                                    Convert.ToString(data_base).Substring(0, 10),
                                    vlr_base,
                                    nossonumero,
                                    origem_pagamento,
                                    Convert.ToInt16(ativa),
                                    percentual_correcao,
                                    Convert.ToInt16(carteira),
                                    Convert.ToInt16(protesto),
                                    Convert.ToInt16(contabil),
                                    tx_multa,
                                    tx_comissao,
                                    vlr_multa,
                                    vlr_comissao,
                                    vlr_desconto,
                                    periodicidade_comissao,
                                    Convert.ToString(data_conta).Substring(0, 10),
                                    conta,
                                    indexador,
                                    indexador_mes,
                                    indexador_acumulado,
                                    residuo_mes,
                                    residuo_acumulado,
                                    vlr_correcao,
                                    observacao
                                    );
                }
                else
                {
                    uParcelas.Grava(xproduto2,
                                    xgrupo2,
                                    xunidade2,
                                    xmeiolote2,
                                    parcela,
                                    tipo,
                                    Convert.ToString(data_vencimento).Substring(0, 10),
                                    vlr_parcela,
                                    Convert.ToString(data_pagamento).Substring(0, 10),
                                    vlr_pagamento,
                                    Convert.ToString(data_original).Substring(0, 10),
                                    vlr_original,
                                    Convert.ToString(data_base).Substring(0, 10),
                                    vlr_base,
                                    nossonumero,
                                    origem_pagamento,
                                    Convert.ToInt16(ativa),
                                    percentual_correcao,
                                    Convert.ToInt16(carteira),
                                    Convert.ToInt16(protesto),
                                    Convert.ToInt16(contabil),
                                    tx_multa,
                                    tx_comissao,
                                    vlr_multa,
                                    vlr_comissao,
                                    vlr_desconto,
                                    periodicidade_comissao,
                                    Convert.ToString(data_conta).Substring(0, 10),
                                    conta,
                                    indexador,
                                    indexador_mes,
                                    indexador_acumulado,
                                    residuo_mes,
                                    residuo_acumulado,
                                    vlr_correcao,
                                    observacao
                                    );
                    //
                    parcela = "";
                    tipo = "";
                    data_vencimento = Convert.ToDateTime("01/01/1900");
                    vlr_parcela = 0;
                    data_pagamento = Convert.ToDateTime("01/01/1900");
                    vlr_pagamento = 0;
                    data_original = Convert.ToDateTime("01/01/1900");
                    vlr_original = 0;
                    data_base = Convert.ToDateTime("01/01/1900");
                    vlr_base = 0;
                    nossonumero = "";
                    origem_pagamento = "";
                    ativa = false;
                    percentual_correcao = 0;
                    carteira = false;
                    protesto = false;
                    contabil = false;
                    tx_multa = 0;
                    tx_comissao = 0;
                    vlr_multa = 0;
                    vlr_comissao = 0;
                    vlr_desconto = 0;
                    periodicidade_comissao = "";
                    data_conta = Convert.ToDateTime("01/01/1900");
                    conta = "";
                    indexador = "";
                    indexador_mes = 0;
                    indexador_acumulado = 0;
                    residuo_mes = 0;
                    residuo_acumulado = 0;
                    vlr_correcao = 0;
                    observacao = "";

                }
                //Fim Migração Arquivo Parcelas Venda 1
            }
            //Fim Parcelas Origem - Empreendimento ou Bloco Diferentes
            //
        }
        return " ";
    }

    public static string GravaPermutaProprietario(string xproduto,
                                                  string xgrupo,
                                                  string xunidade,
                                                  string xparte,
                                                  string xcliente,
                                                  string xcliente2)
    {
        // Vendas
        string script = "";
        script = "update vendas " +
        " SET " +
        " cliente = " + xcliente2 + " " +
        " WHERE (produto = " + xproduto + " " +
        " AND grupo = " + xgrupo + " " +
        " AND unidade = " + xunidade + " " +
        " AND parte = " + xparte + ") ";
        SreDblib.ExecScript(script);
        //
        // Produto Unidades
        if (xparte == "0")
        {
            //Unidade 
            script = "";
            script = "update PRODUTO_UNIDADES " +
            " SET proprietario_1 = " + xcliente2 +
            " WHERE (produto = " + xproduto + " AND grupo = " + xgrupo + " " +
            " AND unidade = " + xunidade + " AND parte = " + xparte + ") ";
            SreDblib.ExecScript(script);
        }
        else
        {
            if (xparte == "1")
            {
                //Unidade 
                script = "";
                script = "update PRODUTO_UNIDADES " +
                " SET proprietario_1 = " + xcliente2 +
                " WHERE (produto = " + xproduto + " AND grupo = " + xgrupo + " " +
                " AND unidade = " + xunidade + ") "; // +" AND parte = " + xparte + ") ";
                SreDblib.ExecScript(script);
            }
            else
            {
                //Unidade
                script = "";
                script = "update PRODUTO_UNIDADES " +
                " SET proprietario_2 = " + xcliente2 +
                " WHERE (produto = " + xproduto + " AND grupo = " + xgrupo + " " +
                " AND unidade = " + xunidade + ") "; // +" AND parte = " + xparte + ") ";
                SreDblib.ExecScript(script);
            }
        }
        //
        return " ";
    }

    public static string GravaQuitacaoUnidade(string xproduto,
                                             string xgrupo,
                                             string xunidade,
                                             string xparte)
    {
        // Vendas
        string script = "";
        script = "update vendas " +
        " SET " +
        " quitado = 1 " +
        " WHERE (produto = " + xproduto + " " +
        " AND grupo = " + xgrupo + " " +
        " AND unidade = " + xunidade + " " +
        " AND parte = " + xparte + ") ";
        SreDblib.ExecScript(script);
        //
        //Produtos_Unidade
        if ((xparte == "0") || (xparte == "1"))
        {
            script = "";
            script = "update produto_unidades " +
            " SET " +
            " quitado_1 = 1 " +
            " WHERE (produto = " + xproduto + " " +
            " AND grupo = " + xgrupo + " " +
            " AND unidade = " + xunidade + " " +
            " AND parte = " + xparte + ") ";
            SreDblib.ExecScript(script);
        }
        else
        {
            script = "";
            script = "update produto_unidades " +
            " SET " +
            " quitado_2 = 1 " +
            " WHERE (produto = " + xproduto + " " +
            " AND grupo = " + xgrupo + " " +
            " AND unidade = " + xunidade + " " +
            " AND parte = " + xparte + ") ";
            SreDblib.ExecScript(script);
        }
        //
        //Parcelas Origem

        //Mesmo Empreendimento e Bloco
        string nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);
        // Parcelas
        script = "";
        script = "update " + nomearquivo + " " +
        " SET " +
        " ativa = 0 " +
        " WHERE (produto = " + xproduto + " " +
        " AND grupo = " + xgrupo + " " +
        " AND unidade = " + xunidade + " " +
        " AND parte = " + xparte + ") ";
        SreDblib.ExecScript(script);


        //
        return " ";
    }

    public static string GravaTrocaIndexador(string xproduto,
                                             string xgrupo,
                                             string xunidade,
                                             string xparte,
                                             string xindexador,
                                             string xperiodicidade,
                                             string xdata_base,
                                             Boolean xcongela)
    {
        // Vendas
        string script = "";
        script = "update vendas " +
        " SET " +
        " indexador = " + Srelib.QStr(xindexador) + ", " +
        " periodicidade_correcao = " + Srelib.QStr(xperiodicidade) + ", " +
        " ultima_correcao = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_base)) + " " +
        " WHERE (produto = " + xproduto + " " +
        " AND grupo = " + xgrupo + " " +
        " AND unidade = " + xunidade + " " +
        " AND parte = " + xparte + ") ";
        SreDblib.ExecScript(script);
        //
        if (xcongela)
        {
            //Mesmo Empreendimento e Bloco
            string nomearquivo = "parcelas_" + Srelib.QStr0(xproduto.Trim(), 5) + "_" + Srelib.QStr0(xgrupo.Trim(), 5);
            // Parcelas
            script = "";
            script = "update " + nomearquivo + " " +
            " SET " +
            " vlr_base = vlr_original" + ", " +
            " vlr_original = vlr_parcela" + " " +
            " WHERE (produto = " + xproduto + " " +
            " AND grupo = " + xgrupo + " " +
            " AND unidade = " + xunidade + " " +
            " AND parte = " + xparte + ") ";
            SreDblib.ExecScript(script);
        }
        return " ";
    }


    public static string GravaNovaDataBase(string xproduto,
                                           string xgrupo,
                                           string xunidade,
                                           string xparte,
                                           string xdata_base)
    {
        // Vendas
        string script = "";
        script = "update vendas " +
        " SET " +
        " ultima_correcao = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_base)) + " " +
        " WHERE (produto = " + xproduto + " " +
        " AND grupo = " + xgrupo + " " +
        " AND unidade = " + xunidade + " " +
        " AND parte = " + xparte + ") ";
        SreDblib.ExecScript(script);
        //
        return " ";
    }

    public uVendas()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
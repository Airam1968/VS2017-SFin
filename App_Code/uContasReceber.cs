using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;

/// <summary>
/// Summary description for uContasReceber
/// </summary>
public class uContasReceber
{

    public static DataSet LookUpContasReceber()
    {
        return SreDblib.GetDsScript("select apelido from contas");
    }

    public static ASPxComboBox MontaComboContasReceber(ASPxComboBox pCombo)
    {
        //Documentação - Chamada da Função
        //
        //uBanco.MontaComboBanco(ASPxComboBox1);
        //
        //Fim Documentação - Chamada da Função


        return SreDblib.MontaCombo(pCombo, "MontaComboContasReceber", "codigo", "apelido", false, "");

    }

    public static String Grava(string xlancamento,
                               string xproduto,
                               string xclasse,
                               string xcliente,
                               string xdescricao,
                               string xdtprevista,
                               decimal xvlr_previsto,
                               string xdtrealizado,
                               decimal xvlr_realizado,
                               string xconta,
                               string xdocumento,
                               string xdtdocumento,
                               string xcheque,
                               string xcmc7,
                               string xdtcompensacao,
                               int xcontabil,
                               string xintegracao_contabil)
    {

        if (xlancamento != String.Empty)
        {
            //Check de Lançamento
            if (uContasReceber.LancamentoExiste(xlancamento))
            {
                xlancamento = uContasReceber.PegaNovoCodigoCReceber();
            }
            //
            string script = "INSERT INTO CONTAS_RECEBER VALUES ( " +
                            Srelib.QStr(xlancamento) +
                            ", " + Srelib.QStr(xproduto) +
                            ", " + Srelib.QStr(xclasse) +
                            ", " + Srelib.QStr(xcliente) +
                            ", " + Srelib.QStr(xdescricao) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevista)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_previsto)) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtrealizado)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_realizado)) +
                            ", " + Srelib.QStr(xconta) +
                            ", " + Srelib.QStr(xdocumento) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtdocumento)) +
                            ", " + Srelib.QStr(xcheque) +
                            ", " + Srelib.QStr(xcmc7) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtcompensacao)) +
                            ", " + Convert.ToString(xcontabil) +
                            ", " + Srelib.QStr(xintegracao_contabil) +
                            " ) ";

            //" where nome=" + Rgblib.QStr(pParametro);

            SreDblib.ExecScript(script);
        }
        return " ";
    }


    public static String Altera(string xlancamento,
                                string xproduto,
                                string xclasse,
                                string xcliente,
                                string xdescricao,
                                string xdtprevista,
                                decimal xvlr_previsto,
                                string xdtrealizado,
                                decimal xvlr_realizado,
                                string xconta,
                                string xdocumento,
                                string xdtdocumento,
                                string xcheque,
                                string xcmc7,
                                string xdtcompensacao,
                                int xcontabil,
                                string xintegracao_contabil)
    {

        if (xlancamento != String.Empty)
        {
            string script = "UPDATE contas_receber SET " +
                //" lancamento = " + Srelib.QStr(xlancamento) +
                            " produto = " + Srelib.QStr(xproduto) +
                            ", classe = " + Srelib.QStr(xclasse) +
                            ", cliente = " + Srelib.QStr(xcliente) +
                            ", descricao = " + Srelib.QStr(xdescricao) +
                            ", data_prevista = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevista)) +
                            ", vlr_previsto = " + Srelib.forcaponto(Convert.ToString(xvlr_previsto)) +
                            ", data_realizado = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtrealizado)) +
                            ", vlr_realizado = " + Srelib.forcaponto(Convert.ToString(xvlr_realizado)) +
                            ", conta = " + Srelib.QStr(xconta) +
                            ", documento = " + Srelib.QStr(xdocumento) +
                            ", data_documento = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtdocumento)) +
                            ", cheque = " + Srelib.QStr(xcheque) +
                            ", cmc7 = " + Srelib.QStr(xcmc7) +
                            ", dtcompensacao = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtcompensacao)) +
                            ", contabil = " + Convert.ToString(xcontabil) +
                            ", integracao_contabil = " + Srelib.QStr(xintegracao_contabil) +
                            "  where lancamento = " + Srelib.QStr(xlancamento);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String Exclui(string xID)
    {

        string script = "DELETE contas_receber where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String ExcluiLancamento(string xLancamento)
    {

        string script = "DELETE contas_receber where lancamento =" + xLancamento;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String AlteraCompensacao(string xID,
                                           string xdtcompensacao)
    {

        if (xID != String.Empty)
        {
            string script = "UPDATE contas_receber SET " +
                            " dtcompensacao = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtcompensacao)) +
                            " where ID = " + Srelib.QStr(xID);

            SreDblib.ExecScript(script);
        }
        return " ";
    }


    public static DataSet PegaDadosCReceber(string xproduto,
                                            string xreceita,
                                            string xcliente,
                                            string xcontascorrentes,
                                            string xdtprevisao1,
                                            string xdtprevisao2,
                                            string xdtrealizado1,
                                            string xdtrealizado2,
                                            string xdtnotafiscal1,
                                            string xdtnotafiscal2,
                                            string xdocumento,
                                            string xsituacaopgto,
                                            string xordenacao,
                                            Boolean xckcompensado,
                                            Boolean xcompensado)
    {
        string script = "";
        string nomearquivo = "contas_receber";

        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) ";
        script = script + " WHERE ";
        //Produto
        script = script + "( " + Srelib.QStr(xproduto) + " = " + Srelib.QStr("") + " OR produto IN (" + Srelib.QStr(xproduto) + ") )";
        //Classe de Despesa
        script = script + " AND ";
        script = script + "( " + Srelib.QStr(xreceita) + " = " + Srelib.QStr("") + " OR classe IN (" + Srelib.QStr(xreceita) + ") )";
        //Fornecedor
        script = script + " AND ";
        script = script + "( " + Srelib.QStr(xcliente) + " = " + Srelib.QStr("") + " OR cliente IN (" + Srelib.QStr(xcliente) + ") )";
        //Contas Correntes
        //Contas Correntes
        if (xcontascorrentes != "0" && xcontascorrentes != "")
        {
            script = script + " AND ";
            script = script + "( " + Srelib.QStr(xcontascorrentes) + " = " + Srelib.QStr("") + " OR conta IN (" + Srelib.QStr(xcontascorrentes) + ") )";
        }
        //Data Prevista
        if ((xdtprevisao1 != "01/01/1900") || (xdtprevisao2 != "31/12/2999"))
        {
            script = script + " AND ";
            //script = script + " (data_prevista >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao1));
            //script = script + " and data_prevista <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao2)) + ") ";
            //
            script = script + " (data_prevista between " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao1)) + " and " +
                               Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao2)) + ") ";
        }
        if ((xdtrealizado1 != "01/01/1900") || (xdtrealizado2 != "31/12/2999"))
        {
            //Data Realizado
            script = script + " AND ";
            //script = script + " (data_realizado >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtrealizado1));
            //script = script + " and data_realizado <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtrealizado2)) + ") ";
            //
            script = script + " (data_realizado between " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtrealizado1)) + " and " +
                               Srelib.QStr(Srelib.DataAmericanasembarra(xdtrealizado2)) + ") ";
        }
        if ((xdtnotafiscal1 != "01/01/1900") || (xdtnotafiscal2 != "31/12/2999"))
        {
            //Data NF
            script = script + " AND ";
            //script = script + " (data_documento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtnotafiscal1));
            //script = script + " and data_documento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtnotafiscal2)) + ") ";
            //
            script = script + " (data_documento between " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtnotafiscal1)) + " and " +
                               Srelib.QStr(Srelib.DataAmericanasembarra(xdtnotafiscal2)) + ") ";
        }
        //Documento
        script = script + " AND ";
        script = script + "( " + Srelib.QStr(xdocumento) + " = " + Srelib.QStr("") + " OR documento IN (" + Srelib.QStr(xdocumento) + ") )";
        //Compensado
        if (xckcompensado)
        {
            if (xcompensado)
            {
                //Compensado
                script = script + " AND ";
                script = script + " (dtcompensacao <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
            }
            else
            {
                //Não Compensado
                script = script + " AND ";
                script = script + " (dtcompensacao = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
            }
        }
        if (xsituacaopgto == "T")
        {
            //Todos
        }
        else
        {
            if (xsituacaopgto == "P")
            {
                //Previsto
                script = script + " AND ";
                script = script + " (data_realizado = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
            }
            else
            {
                //Realizado
                script = script + " AND ";
                script = script + " (data_realizado <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
            }
        }

        //
        if (xordenacao == "L")
        {
            //lançamento
            script = script + " order by lancamento";
        }
        if (xordenacao == "D")
        {
            //Despesa
            script = script + " order by classe ";
        }
        if (xordenacao == "F")
        {
            //Fornecedor
            script = script + " order by fornecedor ";
        }
        if (xordenacao == "DP")
        {
            //Data Prevista
            script = script + " order by data_prevista ";
        }
        if (xordenacao == "DR")
        {
            //Data Realizado
            script = script + " order by data_realizado ";
        }
        if (xordenacao == "DN")
        {
            //Data Nota Fiscal
            script = script + " order by data_documento ";
        }

        return SreDblib.GetDsScript(script);

    }

    public static DataSet PegaDadosCReceberLancamento(string xlancamento)
    {
        string script = "";
        string nomearquivo = "contas_receber";

        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) ";
        script = script + " WHERE ";
        //Lançamento
        script = script + " lancamento = " + xlancamento;

        return SreDblib.GetDsScript(script);

    }

    public static String PegaNovoCodigoCReceber()
    {
        string script = "";
        string nomearquivo = "contas_receber";

        script = "SELECT MAX(lancamento) + 1 FROM " + nomearquivo + " WITH(NOLOCK) ";

        return SreDblib.GetCampoScript(script).ToString();

    }

    public static String PegaDepositosCompensados(string xcodigoconta,
                                                  string xdtprevisao1,
                                                  string xdtprevisao2,
                                                  Boolean xcompensado)
    {
        string script = "select SUM(vlr_previsto) total from contas_receber " +
                        " with(nolock) " +
                        " where conta = " + Srelib.QStr(xcodigoconta);
        script = script +
                        " AND " +
                        " (data_prevista >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao1.ToString().Substring(0, 10))) +
                        " and data_prevista <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao2.ToString().Substring(0, 10))) + ") ";
        //Compensado
        if (xcompensado)
        {
            //Compensado
            script = script + " AND ";
            script = script + " (dtcompensacao <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
        }
        else
        {
            //Não Compensado
            script = script + " AND ";
            script = script + " (dtcompensacao = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
        }

        string retorno = "";
        try
        {
            retorno = SreDblib.GetCampoScript(script);
            if (retorno == "")
            {
                retorno = "0.00";
            }
        }
        catch (Exception)
        {
            retorno = "0.00";
        }
        return retorno;
    }

    public static String GravaCompensacao(string xlancamento,
                                          string xdtcompensacao,
                                          string xnumerocheque)
    {

        if (xlancamento != String.Empty)
        {
            string script = "UPDATE contas_receber SET " +
                            " dtcompensacao = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtcompensacao)) +
                            " and cheque = " + Srelib.QStr(xnumerocheque) +
                            " and vlr_realizado = vlr_previsto " +
                            " and data_realizado = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtcompensacao)) +
                            " where lancamento = " + Srelib.QStr(xlancamento);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String GeraLancamentos(string xproduto,
                                         string xdtperiodo1,
                                         string xdtperiodo2,
                                         string xprevisao)
    {
        //
        string script = "";
        string nomearquivo = "";
        DateTime data = Convert.ToDateTime(xdtperiodo1);
        decimal[] sub_previsto = new decimal[1000];
        decimal[] sub_realizado = new decimal[1000];
        for (int i = 0; i < 1000; i++)
        {
            sub_previsto[i] = 0;
            sub_realizado[i] = 0;
        }
        Int16 conta = 0;
        DataSet dsproduto;
        DataSet ds0;
        DataSet ds1;
        //Apagar Lançamentos Conta
        if (xproduto == String.Empty)
        {

            script = "DELETE contas_receber where Cliente = 1 " +
                     " AND (data_prevista between " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                     " AND " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) + ") " +
                     " AND (data_realizado between " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                     " AND " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) + ") ";

            SreDblib.ExecScript(script);
        }
        else
        {
            script = "DELETE contas_receber where Cliente = 1 " +
                     " AND produto = " + xproduto +
                     " AND (data_prevista between " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                     " AND " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) + ") " +
                     " AND (data_realizado between " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                     " AND " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) + ") ";

            SreDblib.ExecScript(script);
        }
        //Fim Apagar Lançamentos Conta
        //
        //Geração Contas a Receber
        if (xproduto == String.Empty)
        {
            //Todos os Produtos
            dsproduto = uProduto.PegaDadosProdutoID(0);
        }
        else
        {
            //Produto Específico
            dsproduto = uProduto.PegaDadosProdutoID(Convert.ToInt16(xproduto));
        }
        //
        //
        //Não Processa produto 0 nem Inativos
        for (int rowproduto = 0; rowproduto < dsproduto.Tables[0].Rows.Count; rowproduto++)
        {
            //Não Processa produto 0 
            if (Convert.ToInt32(dsproduto.Tables[0].Rows[rowproduto]["ID"]) != 0)
            {
                //
                ds0 = uProduto.PegaDadosProdutoGrupo(Convert.ToInt32(dsproduto.Tables[0].Rows[rowproduto]["ID"].ToString().Trim()), "1");
                //
                //Datas
                data = Convert.ToDateTime(xdtperiodo1);
                //
                //Loop de Datas
                while (data <= Convert.ToDateTime(xdtperiodo2))
                {
                    string yproduto = "";
                    string ygrupo = "";
                    //
                    //Loop de Grupos do Produto
                    for (int row0 = 0; row0 < ds0.Tables[0].Rows.Count; row0++)
                    {
                        // Produtos + Grupo
                        yproduto = ds0.Tables[0].Rows[row0]["produto"].ToString().Trim();
                        ygrupo = ds0.Tables[0].Rows[row0]["grupo"].ToString().Trim();
                        //
                        nomearquivo = "parcelas_" + Srelib.QStr0(yproduto.Trim(), 5) + "_" + Srelib.QStr0(ygrupo.Trim(), 5);
                        //
                        // Parcelas Contas a Receber na Data Corrente
                        script = " " +
                        " SELECT * FROM " + nomearquivo + " WITH(NOLOCK)  " +
                        " WHERE (data_vencimento = " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(data).Substring(0, 10))) +
                        " AND vlr_pagamento = 0 ) " +
                        " OR (data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(data).Substring(0, 10))) +
                        " AND vlr_pagamento <> 0 ) " +
                        //" AND ativa = 1  " +
                        " UNION ALL " +
                        " SELECT * FROM parcelas_renegociacao WITH(NOLOCK)  " +
                        " WHERE (data_vencimento = " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(data).Substring(0, 10))) +
                        " AND vlr_pagamento = 0 ) " +
                        " OR (data_pagamento = " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(data).Substring(0, 10))) +
                        " AND vlr_pagamento <> 0 ) " +
                        //" AND ativa = 1  " +
                        " AND produto = " + yproduto +
                        " AND produto = " + ygrupo +
                        " ORDER BY data_vencimento ";
                        //
                        ds1 = SreDblib.GetDsScript(script);
                        //
                        //
                        for (int row1 = 0; row1 < ds1.Tables[0].Rows.Count; row1++)
                        {
                            //Carregar dados das parcelas
                            //
                            //Conta
                            if (ds1.Tables[0].Rows[row1]["conta"].ToString().Trim() == string.Empty)
                            {
                                conta = 0;
                            }
                            else
                            {
                                conta = Convert.ToInt16(ds1.Tables[0].Rows[row1]["conta"]);
                            }
                            //
                            //Totaliza as Parcelas
                            if (data == Convert.ToDateTime(ds1.Tables[0].Rows[row1]["data_pagamento"]))
                            {
                                sub_realizado[conta] = sub_realizado[conta] + Convert.ToDecimal(ds1.Tables[0].Rows[row1]["vlr_pagamento"]);
                            }
                            //
                            if (xprevisao == "0")
                            {
                                //Integral
                                if (data == Convert.ToDateTime(ds1.Tables[0].Rows[row1]["data_vencimento"]))
                                {
                                    sub_previsto[conta] = sub_previsto[conta] + Convert.ToDecimal(ds1.Tables[0].Rows[row1]["vlr_parcela"]);
                                }
                            }
                            else
                            {
                                //Realizado
                                if ((data == Convert.ToDateTime(ds1.Tables[0].Rows[row1]["data_pagamento"])) &&
                                    (data == Convert.ToDateTime(ds1.Tables[0].Rows[row1]["data_vencimento"])))
                                {
                                    sub_previsto[conta] = sub_previsto[conta] + Convert.ToDecimal(ds1.Tables[0].Rows[row1]["vlr_parcela"]);
                                }
                            }
                            //
                        }
                        ds1.Clear();
                        //Fim Parcelas
                    }
                    //Fim Geração Contas a Receber
                    //
                    //Gravar Contas a Receber
                    //na Data todas as Contas
                    for (int j = 0; j < 100; j++)
                    {
                        if ((sub_previsto[j] != 0) || (sub_realizado[j] != 0))
                        {

                            uContasReceber.Grava(PegaNovoCodigoCReceber(),
                                                 yproduto,
                                                 "1",
                                                 "1",
                                                 "Parcelas - " + uProduto.PegaProdutoDescricao(Convert.ToInt16(yproduto)),
                                                 Convert.ToString(data).Substring(0, 10),
                                                 sub_previsto[j],
                                                 Convert.ToString(data).Substring(0, 10),
                                                 sub_realizado[j],
                                                 j.ToString().Trim(),
                                                 "Parcelas",
                                                 Convert.ToString(data).Substring(0, 10),
                                                 "",
                                                 "",
                                                 Convert.ToString(data).Substring(0, 10),
                                                 1,
                                                 ""
                                                 );
                        }
                    }
                    //
                    for (int x = 0; x < 1000; x++)
                    {
                        sub_previsto[x] = 0;
                        sub_realizado[x] = 0;
                    }
                    //
                    data = data.AddDays(1);
                    //
                }
                ds0.Clear();
            }
            //data = Convert.ToDateTime(xdtperiodo1);
        }
        //

        return " ";
    }

    public static Boolean LancamentoExiste(string xlancamento)
    {
        string script = "";
        string retorno = "";
        string nomearquivo = "contas_receber";

        script = " SELECT id FROM " + nomearquivo + " WITH(NOLOCK) " +
                 " WHERE lancamento = " + Srelib.QStr(xlancamento);

        retorno = SreDblib.GetCampoScript(script).ToString().Trim();

        if (retorno != string.Empty)
            return false;
        else
            return true;

    }

    public uContasReceber()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
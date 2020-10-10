using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;
using System.ComponentModel;

/// <summary>
/// Summary description for uContasPagar
/// </summary>
public class uContasPagar
{

    public static DataSet LookUpContasPagar()
    {
        return SreDblib.GetDsScript("select apelido from contas");
    }

    public static ASPxComboBox MontaComboContasPagar(ASPxComboBox pCombo)
    {
        //Documentação - Chamada da Função
        //
        //uBanco.MontaComboBanco(ASPxComboBox1);
        //
        //Fim Documentação - Chamada da Função


        return SreDblib.MontaCombo(pCombo, "contas", "apelido", "apelido", false, "");

    }

    public static String Grava(ref string xlancamento,
                               string xproduto,
                               string xclasse,
                               string xfornecedor,
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
                               string xintegracao_contabil,
                               string xpedido_compra,
                               string xgrupo,
                               int xnominal)
    {
        //
        if (xlancamento != String.Empty)
        {
            //Check de Lançamento
            if (uContasPagar.LancamentoExiste(xlancamento))
            {
                xlancamento = uContasPagar.PegaNovoCodigoCPagar();
            }
            //
            string script = "INSERT INTO CONTAS_PAGAR VALUES ( " +
                            Srelib.QStr(xlancamento) +
                            ", " + Srelib.QStr(xproduto) +
                            ", " + Srelib.QStr(xclasse) +
                            ", " + Srelib.QStr(xfornecedor) +
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
                            ", " + Srelib.QStr(xpedido_compra) +
                            ", " + Srelib.QStr(xgrupo) +
                            ", " + Convert.ToString(xnominal) +
                            " ) ";
            //
            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String Altera(string xlancamento,
                                string xproduto,
                                string xclasse,
                                string xfornecedor,
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
                                string xintegracao_contabil,
                                string xpedido_compra,
                                string xgrupo,
                                int xnominal)
    {

        if (xlancamento != String.Empty)
        {
            string script = "UPDATE CONTAS_PAGAR SET " +
                //" lancamento = " + Srelib.QStr(xlancamento) +
                            " produto = " + Srelib.QStr(xproduto) +
                            ", classe = " + Srelib.QStr(xclasse) +
                            ", fornecedor = " + Srelib.QStr(xfornecedor) +
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
                            ", pedido_compra = " + Srelib.QStr(xpedido_compra) +
                            ", grupo = " + Srelib.QStr(xgrupo) +
                            ", nominal = " + Convert.ToString(xnominal) +
                            "  where lancamento = " + Srelib.QStr(xlancamento);

            SreDblib.ExecScript(script);
        }
        return " ";
    }


    public static String Exclui(string xID)
    {

        string script = "DELETE contas_pagar where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String ExcluiLancamento(string xLancamento)
    {

        string script = "DELETE contas_pagar where lancamento =" + xLancamento;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String AlteraCompensacao(string xID,
                                           string xdtcompensacao)
    {

        if (xID != String.Empty)
        {
            string script = "UPDATE CONTAS_PAGAR SET " +
                            " dtcompensacao = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtcompensacao)) +
                            " where ID = " + Srelib.QStr(xID);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String PegaNovoCodigoCPagar()
    {
        string script = "";
        string nomearquivo = "contas_pagar";

        script = "SELECT MAX(lancamento) + 1 FROM " + nomearquivo + " WITH(NOLOCK) ";

        return SreDblib.GetCampoScript(script).ToString();

    }

    public static Boolean LancamentoExiste(string xlancamento)
    {
        string script = "";
        string retorno = "";
        string nomearquivo = "contas_pagar";

        script = " SELECT id FROM " + nomearquivo + " WITH(NOLOCK) " +
                 " WHERE lancamento = " + Srelib.QStr(xlancamento);

        retorno = SreDblib.GetCampoScript(script).ToString().Trim();

        if (retorno == string.Empty)
            return false;
        else
            return true;

    }

    public static DataSet PegaDadosCPagar(string xproduto,
                                          string xdespesa,
                                          string xfornecedor,
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
        string nomearquivo = "contas_pagar";

        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) ";
        script = script + " WHERE ";
        //Produto
        script = script + "( " + Srelib.QStr(xproduto) + " = " + Srelib.QStr("") + " OR produto IN (" + Srelib.QStr(xproduto) + ") )";
        //Classe de Despesa       
        script = script + " AND ";
        script = script + "( " + Srelib.QStr(xdespesa) + " = " + Srelib.QStr("") + " OR classe IN (" + Srelib.QStr(xdespesa) + ") )";
        //Fornecedor
        script = script + " AND ";
        script = script + "( " + Srelib.QStr(xfornecedor) + " = " + Srelib.QStr("") + " OR fornecedor IN (" + Srelib.QStr(xfornecedor) + ") )";
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
            script = script + " (data_prevista >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao1));
            script = script + " and data_prevista <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao2)) + ") ";
        }
        if ((xdtrealizado1 != "01/01/1900") || (xdtrealizado2 != "31/12/2999"))
        {
            //Data Realizado
            script = script + " AND ";
            script = script + " (data_realizado >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtrealizado1));
            script = script + " and data_realizado <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtrealizado2)) + ") ";
        }
        if ((xdtnotafiscal1 != "01/01/1900") || (xdtnotafiscal2 != "31/12/2999"))
        {
            //Data NF
            script = script + " AND ";
            script = script + " (data_documento >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtnotafiscal1));
            script = script + " and data_documento <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtnotafiscal2)) + ") ";
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

    public static DataSet PegaDadosCPagarLancamento(string xlancamento)
    {
        string script = "";
        string nomearquivo = "contas_pagar";

        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) ";
        script = script + " WHERE ";
        //Lançamento
        script = script + " lancamento = " + xlancamento;

        return SreDblib.GetDsScript(script);

    }


    public static String PegaChequesCompensados(string xcodigoconta,
                                                string xdtprevisao1,
                                                string xdtprevisao2,
                                                Boolean xcompensado)
    {
        string script = "select SUM(vlr_previsto) total from contas_pagar " +
                        " with(nolock) " +
                        " where conta = " + Srelib.QStr(xcodigoconta);
        script = script +
                        " AND " +
                        " (data_prevista >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao1)) +
                        " and data_prevista <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao2)) + ") ";
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

        string retorno = "0.00";
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
            string script = "UPDATE CONTAS_PAGAR SET " +
                            " dtcompensacao = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtcompensacao)) +
                            " , cheque = " + Srelib.QStr(xnumerocheque) +
                            " , vlr_realizado = vlr_previsto " +
                            " , data_realizado = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtcompensacao)) +
                            " where lancamento = " + Srelib.QStr(xlancamento);

            SreDblib.ExecScript(script);
        }
        return " ";
    }


    public uContasPagar()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
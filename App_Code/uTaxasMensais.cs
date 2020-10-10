using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DevExpress.Web.ASPxEditors;

/// <summary>
/// Summary description for uTaxasMensais
/// </summary>
public class uTaxasMensais
{

    public static DataSet PegaDadosTaxasMensaisID(Int32 xID)
    {
        string script;

        if (xID == 0)
        {
            script = "SELECT * FROM taxas_mensais WITH(NOLOCK) order by " +
                     "REPLICATE('0', 4 - LEN(ano)) + CAST(ano AS varchar), " +
                     "REPLICATE('0', 2 - LEN(mes)) + CAST(mes AS varchar) ";
        }
        else
        {
            script = "SELECT * FROM taxas_mensais WITH(NOLOCK) WHERE id = " + Convert.ToString(xID) + " order by " +
                     "REPLICATE('0', 4 - LEN(ano)) + CAST(ano AS varchar), " +
                     "REPLICATE('0', 2 - LEN(mes)) + CAST(mes AS varchar) ";
        }

        return SreDblib.GetDsScript(script);

    }


    public static DataSet PegaDadosTaxasMensaisNomeColunas()
    {
        string script;

        script = "SP_Columns taxas_mensais";

        return SreDblib.GetDsScript(script);

    }


    public static DataSet PegaDadosTaxasMensaisNome(String xNome, DateTime xPrevisao1, DateTime xPrevisao2)
    {
        string script;

        if (xNome == "")
        {
            script = " SELECT * FROM taxas_mensais WITH(NOLOCK) " +
                     " WHERE (Convert(DateTime," + Srelib.QStr("01/") + "+mes+" + Srelib.QStr("/") + "+ano,103) " +
                     " between " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xPrevisao1))) +
                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xPrevisao2))) + ") " +
                     " order by " +
                     "REPLICATE('0', 4 - LEN(ano)) + CAST(ano AS varchar), " +
                     "REPLICATE('0', 2 - LEN(mes)) + CAST(mes AS varchar) ";
        }
        else
        {
            script = "SELECT mes, ano, " + xNome + " FROM taxas_mensais WITH(NOLOCK) " +
                     " WHERE (Convert(DateTime," + Srelib.QStr("01/") + "+mes+" + Srelib.QStr("/") + "+ano,103) " +
                     " between " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xPrevisao1))) +
                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xPrevisao2))) + ") " +
                     " order by " +
                     "REPLICATE('0', 4 - LEN(ano)) + CAST(ano AS varchar), " +
                     "REPLICATE('0', 2 - LEN(mes)) + CAST(mes AS varchar) ";
        }

        return SreDblib.GetDsScript(script);

    }

    public static Double PegaDadosTaxasMensaisAcumuladaNome(String xNome, DateTime xPrevisao1, DateTime xPrevisao2)
    {
        //Calculo para Correção Mensal
        string script;
        DataSet dsTaxasMensais;
        //
        xPrevisao1 = Convert.ToDateTime("01/" + Convert.ToString(xPrevisao1).Substring(3, 7));
        //xPrevisao2 = Convert.ToDateTime("01/" + Convert.ToString(xPrevisao2).Substring(3, 7));
        //
        if (xNome != "NENHUM")
        {
            script = "SELECT mes, ano, " + xNome + " FROM taxas_mensais WITH(NOLOCK) " +
                     " WHERE (Convert(DateTime," + Srelib.QStr("01/") + "+mes+" + Srelib.QStr("/") + "+ano,103) " +
                     " between " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xPrevisao1))) +
                     " and " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xPrevisao2))) + ") " +
                     " order by " +
                     "REPLICATE('0', 4 - LEN(ano)) + CAST(ano AS varchar), " +
                     "REPLICATE('0', 2 - LEN(mes)) + CAST(mes AS varchar) ";


            dsTaxasMensais = SreDblib.GetDsScript(script);

            Double Taxa_acumulada = 1;

            for (int i = 0; i < dsTaxasMensais.Tables[0].Rows.Count; i++)
            {
                Taxa_acumulada = Taxa_acumulada *
                                 ((Convert.ToDouble(dsTaxasMensais.Tables[0].Rows[i][xNome].ToString().Trim()) / 100) + 1);
            }
            //
            Taxa_acumulada = ((Taxa_acumulada - 1) * 100);

            return Taxa_acumulada;
        }
        else
        {
            //Não a Acumulo de taxas para taxa NENHUM
            return 0;
        }
    }

    public static Double PegaDadosTaxasMensaisAcumuladaNomePagamento(String xNome,
                                                                     DateTime xPrevisao1,
                                                                     DateTime xPrevisao2)
    {
        //Calculo para Pagamento de Parcelas
        string script;
        DataSet dsTaxasMensais;
        //
        xPrevisao1 = Convert.ToDateTime("01/" + Convert.ToString(xPrevisao1).Substring(3, 7));
        //xPrevisao2 = Convert.ToDateTime("01/" + Convert.ToString(xPrevisao2).Substring(3, 7));
        //
        if (xNome != "NENHUM")
        {
            Int16 dia = 0;
            dia = Convert.ToInt16(xPrevisao1.Day);
            if (dia != 1)
            {
                xPrevisao1 = xPrevisao1.AddDays(-(dia - 1));
            }
            dia = Convert.ToInt16(xPrevisao2.Day);
            if (dia != 1)
            {
                xPrevisao2 = xPrevisao2.AddDays(-(dia - 1));
            }
            //
            if ((xPrevisao1.Month != xPrevisao2.Month) || (xPrevisao1.Year != xPrevisao2.Year))
            {

                script = "SELECT mes, ano, " + xNome + " FROM taxas_mensais WITH(NOLOCK) " +
                         " WHERE (Convert(DateTime," + Srelib.QStr("01/") + "+mes+" + Srelib.QStr("/") + "+ano,103) " +
                         " between " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xPrevisao1))) +
                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xPrevisao2))) + ") " +
                         " order by " +
                         "REPLICATE('0', 4 - LEN(ano)) + CAST(ano AS varchar), " +
                         "REPLICATE('0', 2 - LEN(mes)) + CAST(mes AS varchar) ";

                dsTaxasMensais = SreDblib.GetDsScript(script);

                Double Taxa_acumulada = 1;

                for (int i = 0; i < dsTaxasMensais.Tables[0].Rows.Count; i++)
                {
                    Taxa_acumulada = Taxa_acumulada *
                                     ((Convert.ToDouble(dsTaxasMensais.Tables[0].Rows[i][xNome].ToString().Trim()) / 100) + 1);
                }
                //
                Taxa_acumulada = ((Taxa_acumulada - 1) * 100);

                return Taxa_acumulada;
            }
            else
            {
                //Não a Acumulo de taxas para mesmo mês e Ano
                return 0;
            }
        }
        else
        {
            //Não a Acumulo de taxas para taxa NENHUM
            return 0;
        }
    }

    public static Double PegaDadosTaxasMensaisNomeString(String xNome, DateTime xPrevisao1, DateTime xPrevisao2)
    {
        string script;
        DataSet dsTaxasMensais;
        DateTime Previsao3;

        //xPrevisao1 = Convert.ToDateTime("01/" + xPrevisao1.Month + "/" + xPrevisao1.Year);
        xPrevisao1 = Convert.ToDateTime("01/" + Convert.ToString(xPrevisao1).Substring(3, 7));
        xPrevisao2 = Convert.ToDateTime("01/" + Convert.ToString(xPrevisao2).Substring(3, 7));
        Previsao3 = xPrevisao2;
        xPrevisao2 = xPrevisao2.AddMonths(1);
        xPrevisao2 = xPrevisao2.AddDays(-1);


        if (xNome != "NENHUM")
        {
            if (xPrevisao1 != Previsao3) 
            {
                script = "SELECT mes, ano, " + xNome + " FROM taxas_mensais WITH(NOLOCK) " +
                         " WHERE (Convert(DateTime," + Srelib.QStr("01/") + "+mes+" + Srelib.QStr("/") + "+ano,103) " +
                         " between " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xPrevisao1))) +
                         " and " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xPrevisao2))) + ") " +
                         " order by " +
                         "REPLICATE('0', 4 - LEN(ano)) + CAST(ano AS varchar), " +
                         "REPLICATE('0', 2 - LEN(mes)) + CAST(mes AS varchar) ";

                dsTaxasMensais = SreDblib.GetDsScript(script);

                Double Taxa_acumulada = 1;

                for (int i = 0; i < dsTaxasMensais.Tables[0].Rows.Count; i++)
                {
                    Taxa_acumulada = ((Convert.ToDouble(dsTaxasMensais.Tables[0].Rows[i][xNome].ToString().Trim()) / 100) + 1);
                }

                Taxa_acumulada = ((Taxa_acumulada - 1) * 100);

                return Taxa_acumulada;
            }
            else
            {
                //Não a Acumulo de taxas para mesmo mês e Ano, metodo apenas para pegar taxa do mês
                return 0;
            }
        }
        else
        {
            //Não a Acumulo de taxas para mesmo mês e Ano, Não Acumular taxa NENHUM
            return 0;
        }
    }



    public static String Grava(string xmes,
                               string xano,
                               string xscript)
    {

        if ((xmes != String.Empty) && (xano != String.Empty))
        {
            string script = "INSERT INTO TAXAS_MENSAIS VALUES ( " +
                            Srelib.QStr0(xmes, 2) +
                            ", " + Srelib.QStr(Srelib.QStr0(xano, 4)) + xscript +
                            " ) ";

            //" where nome=" + Rgblib.QStr(pParametro);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String GravaTaxa(string xmes, string xano, string xnome, string xvalor)
    {
        if (xvalor.Trim() == "")
            xvalor = "0";

        if (xmes != string.Empty)
        {
            string script = "UPDATE TAXAS_MENSAIS " +
                            " SET " + xnome + " = " + Srelib.forcaponto(xvalor) +
                            " WHERE MES = " +
                            Srelib.QStr(xmes) +
                             " AND ANO = " +
                            Srelib.QStr(xano);

            //Srelib.QStr(Srelib.QStr0(xmes, 2)) +
            // " AND ANO = " +
            //Srelib.QStr(Srelib.QStr0(xano, 4));
            //" where nome=" + Rgblib.QStr(pParametro);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String IncluiTaxas(string xID,
                                     string xmes,
                                     string xano,
                                     string xstring_altera,
                                     string xstring_altera2)
    {
        string script = "";
        script = "select ID from TAXAS_MENSAIS where mes = " + xmes + " and ano = " + xano + " ";
        if (!SreDblib.TemNaTabela(script))
        {
            script = "INSERT INTO TAXAS_MENSAIS VALUES (  " + xmes + ", " + xano + ", " +
                     xstring_altera + " ) ";
        }
        else
        {
            script = "UPDATE taxas_mensais SET " +
                     xstring_altera2 +
                     " where mes = " + xmes + " and ano = " + xano;
        }

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String AlteraTaxas(string xID,
                                     string xmes,
                                     string xano,
                                     string xstring_altera)
    {

        string script = "UPDATE taxas_mensais SET " +
                        xstring_altera +
                        " where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String ExcluiTaxas(string xID)
    {

        string script = "DELETE taxas_mensais where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }

    public uTaxasMensais()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
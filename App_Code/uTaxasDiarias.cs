using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DevExpress.Web.ASPxEditors;

/// <summary>
/// Summary description for uTaxasDiarias
/// </summary>
public class uTaxasDiarias
{
    public static DataSet PegaDadosTaxasDiariasID(Int32 xID, DateTime xPrevisao1, DateTime xPrevisao2)
    {
        string script;

        if (xID == 0)
        {
            script = " SELECT * FROM taxas_diarias WITH(NOLOCK) " +
                     " WHERE (data >= " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xPrevisao1))) +
                     " and data <= " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xPrevisao2))) + ") " +
                     " order by data";
        }
        else
        {
            script = "SELECT * FROM taxas_diarias WITH(NOLOCK) WHERE id = " + Convert.ToString(xID) +
                     " AND (data >= " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xPrevisao1))) +
                     " and data <= " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xPrevisao2))) + ") " +
                     " order by data";
        }

        return SreDblib.GetDsScript(script);

    }

    public static DataSet PegaDadosTaxasDiariasNome(String xNome, DateTime xPrevisao1, DateTime xPrevisao2)
    {
        string script;

        if (xNome == "")
        {
            script = " SELECT * FROM taxas_diarias WITH(NOLOCK) " +
                     " WHERE (data >= " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xPrevisao1))) +
                     " and data <= " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xPrevisao2))) + ") " +
                     " order by data";
        }
        else
        {
            script = "SELECT data,"+xNome+" FROM taxas_diarias WITH(NOLOCK) " +
                     " WHERE (data >= " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xPrevisao1))) +
                     " and data <= " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xPrevisao2))) + ") " +
                     " order by data";
        }

        return SreDblib.GetDsScript(script);

    }


    public static String Grava(DateTime xdata)
    {

        if (xdata != Convert.ToDateTime("01/01/1900"))
        {
            string script = "INSERT INTO TAXAS_DIARIAS VALUES ( " +
                            Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xdata))) +
                            " ) ";

            //" where nome=" + Rgblib.QStr(pParametro);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String GravaTaxa(DateTime xdata, string xnome, string xvalor)
    {

        if (xdata != Convert.ToDateTime("01/01/1900"))
        {
            string script = "UPDATE TAXAS_DIARIAS " +
                            "SET "+xnome+" = "+ Srelib.forcaponto(xvalor) +
                            "WHERE DATA = " +
                            Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xdata)));

            //" where nome=" + Rgblib.QStr(pParametro);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static DataSet PegaDadosTaxasDiariasNomeColunas()
    {
        string script;

        script = "SP_Columns TAXAS_DIARIAS";

        return SreDblib.GetDsScript(script);

    }

    public static String IncluiTaxas(string xID,
                                     string xdata,
                                     string xstring_altera)
    {

        string script = "INSERT INTO TAXAS_DIARIAS VALUES (  " +
                        Srelib.QStr(Srelib.DataAmericanasembarra(xdata)) + ", " +
                        xstring_altera + " ) ";
        //" where not exists(select TAXAS_DIARIAS where mes =" + xmes + " and ano = " + xano +") ";

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String AlteraTaxas(string xID,
                                     string xdata,
                                     string xstring_altera)
    {

        string script = "UPDATE TAXAS_DIARIAS SET " +
                        xstring_altera +
                        " where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String ExcluiTaxas(string xID)
    {

        string script = "DELETE TAXAS_DIARIAS where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }



	public uTaxasDiarias()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
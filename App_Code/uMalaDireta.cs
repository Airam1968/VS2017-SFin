using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;

/// <summary>
/// Summary description for uMalaDireta
/// </summary>
public class uMalaDireta
{

    public static DataSet LookUpMala()
    {
        return SreDblib.GetDsScript("select nome from modelo_cartas WITH(NOLOCK) ORDER BY nome");
    }

    public static String Grava(string xnome,
                               string xselecao,
                               string xlinha1, 
                               string xlinha2, 
                               string xlinha3, 
                               string xlinha4, 
                               string xlinha5, 
                               string xlinha6, 
                               string xlinha7, 
                               string xlinha8, 
                               string xlinha9, 
                               string xlinha10,
                               string xlinha11,
                               string xlinha12,
                               string xlinha13,
                               string xlinha14,
                               string xlinha15,
                               string xlinha16,
                               string xlinha17,
                               string xlinha18,
                               string xlinha19)
    {

        if (xnome != String.Empty)
        {

            string script = "INSERT INTO modelo_cartas VALUES ( " +
                            Srelib.QStr(xnome) +
                            ", " + xselecao +
                            ", " + Srelib.QStr(xlinha1) + 
                            ", " + Srelib.QStr(xlinha2) +
                            ", " + Srelib.QStr(xlinha3) +
                            ", " + Srelib.QStr(xlinha4) +
                            ", " + Srelib.QStr(xlinha5) +
                            ", " + Srelib.QStr(xlinha6) +
                            ", " + Srelib.QStr(xlinha7) +
                            ", " + Srelib.QStr(xlinha8) +
                            ", " + Srelib.QStr(xlinha9) +
                            ", " + Srelib.QStr(xlinha10) + 
                            ", " + Srelib.QStr(xlinha11) + 
                            ", " + Srelib.QStr(xlinha12) + 
                            ", " + Srelib.QStr(xlinha13) + 
                            ", " + Srelib.QStr(xlinha14) + 
                            ", " + Srelib.QStr(xlinha15) + 
                            ", " + Srelib.QStr(xlinha16) + 
                            ", " + Srelib.QStr(xlinha17) + 
                            ", " + Srelib.QStr(xlinha18) + 
                            ", " + Srelib.QStr(xlinha19) +
                            " ) ";

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String AlteraCarta(string xID,
                                     string xnome,
                                     string xselecao,
                                     string xlinha1,
                                     string xlinha2,
                                     string xlinha3,
                                     string xlinha4,
                                     string xlinha5,
                                     string xlinha6,
                                     string xlinha7,
                                     string xlinha8,
                                     string xlinha9,
                                     string xlinha10,
                                     string xlinha11,
                                     string xlinha12,
                                     string xlinha13,
                                     string xlinha14,
                                     string xlinha15,
                                     string xlinha16,
                                     string xlinha17,
                                     string xlinha18,
                                     string xlinha19)
    {

        string script = "UPDATE modelo_cartas SET " +
                        " nome = " + Srelib.QStr(xnome) +
                        " ,selecionado = " + xselecao +
                        " ,linha_1 = " + Srelib.QStr(xlinha1) +
                        " ,linha_2 = " + Srelib.QStr(xlinha2) +
                        " ,linha_3 = " + Srelib.QStr(xlinha3) +
                        " ,linha_4 = " + Srelib.QStr(xlinha4) +
                        " ,linha_5 = " + Srelib.QStr(xlinha5) +
                        " ,linha_6 = " + Srelib.QStr(xlinha6) +
                        " ,linha_7 = " + Srelib.QStr(xlinha7) +
                        " ,linha_8 = " + Srelib.QStr(xlinha8) +
                        " ,linha_9 = " + Srelib.QStr(xlinha9) +
                        " ,linha_10 = " + Srelib.QStr(xlinha10) +
                        " ,linha_11 = " + Srelib.QStr(xlinha11) +
                        " ,linha_12 = " + Srelib.QStr(xlinha12) +
                        " ,linha_13 = " + Srelib.QStr(xlinha13) +
                        " ,linha_14 = " + Srelib.QStr(xlinha14) +
                        " ,linha_15 = " + Srelib.QStr(xlinha15) +
                        " ,linha_16 = " + Srelib.QStr(xlinha16) +
                        " ,linha_17 = " + Srelib.QStr(xlinha17) +
                        " ,linha_18 = " + Srelib.QStr(xlinha18) +
                        " ,linha_19 = " + Srelib.QStr(xlinha19) +
                        " where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String ExcluiCarta(string xID)
    {

        string script = "DELETE modelo_cartas where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static DataSet PegaDadosCarta(string xnome)
    {
        string script;
        if (xnome == "")
        {
            script = "SELECT * FROM modelo_cartas WITH(NOLOCK)";
        }
        else
        {
            if (xnome.Trim().Substring(0, 1) == "'")
            {
                script = "SELECT * FROM modelo_cartas WITH(NOLOCK) WHERE nome in (" + xnome + ")";
            }
            else
            {
                script = "SELECT * FROM modelo_cartas WITH(NOLOCK) WHERE nome in (" + Srelib.QStr(xnome) + ")";
            }
        }

        return SreDblib.GetDsScript(script);

    }

	public uMalaDireta()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
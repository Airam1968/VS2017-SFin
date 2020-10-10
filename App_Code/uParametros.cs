using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;

/// <summary>
/// Summary description for uParametros
/// </summary>
public class uParametros
{
    public static DataSet LookUpParametros()
    {
        return SreDblib.GetDsScript("select nome from parametros WITH(NOLOCK)");
    }

    public static String PegaDescricao(string xnome)
    {
        string script = "SELECT descricao FROM parametros WITH(NOLOCK) WHERE nome = " + Srelib.QStr(xnome);
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static ASPxComboBox MontaComboUsuarios(ASPxComboBox pCombo)
    {
        return SreDblib.MontaCombo(pCombo, "parametros", "nome", "nome", false, "");
    }

    public static string PegaParametro(string xnome)
    {
        string script = "SELECT VALOR FROM parametros WITH(NOLOCK) WHERE nome = " + Srelib.QStr(xnome);
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static DataSet PegaDadosParametros(string xnome)
    {
        string script;

        if (xnome == "")
        {
            script = "SELECT * FROM parametros WITH(NOLOCK)";
        }
        else
        {
            script = "SELECT * FROM parametros WITH(NOLOCK) WHERE nome = " + Srelib.QStr(xnome);
        }

        return SreDblib.GetDsScript(script);

    }

    public static String Grava(string xnome,
                               string xvalor,
                               string xdescricao,
                               string xemprego,
                               string xcomplemento)
    {

        if (xnome != String.Empty)
        {

                string script = "INSERT INTO PARAMETROS VALUES ( " +
                                Srelib.QStr(xnome) +
                                ", " + Srelib.QStr(xvalor) +
                                ", " + Srelib.QStr(xdescricao) +
                                ", " + Srelib.QStr(xemprego) +
                                ", " + Srelib.QStr(xcomplemento) +
                                " ) " +
                                " WHERE NOME <> " + Srelib.QStr(xnome);


                SreDblib.ExecScript(script);

        }
        return " ";
    }


    public static String AlteraValorParametro(string xnome,
                                              string xvalor)
    {
        string script;

        if (xnome != String.Empty)
        {

            script = "UPDATE parametros " +
                     " SET valor = " + Srelib.QStr(xvalor) +
                     " WHERE nome = " + Srelib.QStr(xnome);

            SreDblib.ExecScript(script);

        }
        return " ";
    }


    public static string Altera(string xnome,
                                string xvalor,
                                string xdescricao,
                                string xemprego,
                                string xcomplemento)
    {
        string script;

        script = "UPDATE parametros "+
                 " SET valor = " + Srelib.QStr(xvalor) +
                 " , descricao = " + Srelib.QStr(xdescricao) +
                 " , emprego = " + Srelib.QStr(xemprego) +
                 " , complemento = " + Srelib.QStr(xcomplemento) +
                 " WHERE nome = " + Srelib.QStr(xnome);

        SreDblib.GetDsScript(script);

        return " ";
    }

    public static string AlteraMigracao(string xnome,
                                        string xvalor)
    {
        string script;

        script = "UPDATE parametros " +
                 " SET valor = " + Srelib.QStr(xvalor) +
                 " WHERE nome = " + Srelib.QStr(xnome);

        SreDblib.GetDsScript(script);

        return " ";
    }

    public static String Exclui(string xnome)
    {

        if (xnome != String.Empty)
        {
            string script = "DELETE parametros  " +
                            " where nome = " + Srelib.QStr(xnome);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public uParametros()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
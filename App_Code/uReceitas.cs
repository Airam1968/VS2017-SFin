using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DevExpress.Web.ASPxEditors;

/// <summary>
/// Summary description for uReceitas
/// </summary>
public class uReceitas
{

    public static DataSet LookUpReceitas()
    {
        if ((SreDblib.GetParametro("ORDEM RECEITA") != "CODIGO") && (SreDblib.GetParametro("ORDEM RECEITA") != "CÓDIGO"))
        {
            return SreDblib.GetDsScript("select codigo, descricao from classe_receitas WITH(NOLOCK) ORDER BY descricao");
        }
        else
        {
            return SreDblib.GetDsScript("select codigo, descricao from classe_receitas WITH(NOLOCK) ORDER BY codigo");
        }

    }

    public static DataSet PegaDadosReceitasID(Int32 xID)
    {
        string script;

        if ((SreDblib.GetParametro("ORDEM RECEITA") != "CODIGO") && (SreDblib.GetParametro("ORDEM RECEITA") != "CÓDIGO"))
        {
            if (xID == 0)
            {
                script = "SELECT * FROM classe_receitas WITH(NOLOCK) order by descricao";
            }
            else
            {
                script = "SELECT * FROM classe_receitas WITH(NOLOCK) WHERE id = " + Convert.ToString(xID) + " order by descricao";
            }
        }
        else
        {
            if (xID == 0)
            {
                script = "SELECT * FROM classe_receitas WITH(NOLOCK) order by codigo";
            }
            else
            {
                script = "SELECT * FROM classe_receitas WITH(NOLOCK) WHERE id = " + Convert.ToString(xID) + " order by codigo";
            }
        }
        return SreDblib.GetDsScript(script);

    }

    public static DataSet PegaDadosReceitas(string xID)
    {
        string script;

        if ((SreDblib.GetParametro("ORDEM RECEITA") != "CODIGO") && (SreDblib.GetParametro("ORDEM RECEITA") != "CÓDIGO"))
        {
            if ((xID == "0") || (xID == string.Empty))
            {
                script = "SELECT * FROM classe_receitas WITH(NOLOCK) order by descricao";
            }
            else
            {
                script = "SELECT * FROM classe_receitas WITH(NOLOCK) WHERE codigo in (" + xID + ") order by descricao";
            }
        }
        else
        {
            if ((xID == "0") || (xID == string.Empty))
            {
                script = "SELECT * FROM classe_receitas WITH(NOLOCK) order by codigo";
            }
            else
            {
                script = "SELECT * FROM classe_receitas WITH(NOLOCK) WHERE codigo in (" + xID + ") order by codigo";
            }
        }
        return SreDblib.GetDsScript(script);

    }

    public static String Grava(string xcodigo,
                               string xdescricao,
                               string xconta_contabil)
    {

        string script = "INSERT INTO classe_receitas VALUES ( " +
                        xcodigo +
                        ", " + Srelib.QStr(xdescricao) +
                        ", " + Srelib.QStr(xconta_contabil) +
                        " ) ";

        //" where nome=" + Rgblib.QStr(pParametro);

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String AlteraReceita(string xID,
                                       string xcodigo,
                                       string xdescricao,
                                       string xconta_contabil)
    {

        string script = "UPDATE classe_receitas SET " +
                        " codigo = " + Srelib.QStr(xcodigo) +
                        " ,descricao = " + Srelib.QStr(xdescricao) +
                        " ,conta_contabil = " + Srelib.QStr(xconta_contabil) +
                        " where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String ExcluiReceita(string xID)
    {

        string script = "DELETE classe_receitas where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static ASPxComboBox MontaComboReceitas(ASPxComboBox pCombo, string pCodigo, Boolean pativo)
    {
        if ((SreDblib.GetParametro("ORDEM RECEITA") != "CODIGO") && (SreDblib.GetParametro("ORDEM RECEITA") != "CÓDIGO"))
        {
            if (pativo)
            {
                if (pCodigo != "0")
                    return SreDblib.MontaCombo(pCombo, "classe_receitas", "descricao", "codigo", true, " WHERE PRODUTO = " + pCodigo + " ORDER BY descricao ");
                else
                    return SreDblib.MontaCombo(pCombo, "classe_receitas", "descricao", "codigo", true, " ORDER BY descricao ");

            }
            else
                if (pCodigo != "0")
                    return SreDblib.MontaCombo(pCombo, "classe_receitas", "descricao", "codigo", true, " WHERE PRODUTO = " + pCodigo + " ORDER BY descricao ");
                else
                    return SreDblib.MontaCombo(pCombo, "classe_receitas", "descricao", "codigo", true, " ORDER BY descricao ");
        }
        else
        {
            if (pativo)
            {
                if (pCodigo != "0")
                    return SreDblib.MontaCombo(pCombo, "classe_receitas", "descricao", "codigo", true, " WHERE PRODUTO = " + pCodigo + " ORDER BY codigo ");
                else
                    return SreDblib.MontaCombo(pCombo, "classe_receitas", "descricao", "codigo", true, " ORDER BY codigo ");

            }
            else
                if (pCodigo != "0")
                    return SreDblib.MontaCombo(pCombo, "classe_receitas", "descricao", "codigo", true, " WHERE PRODUTO = " + pCodigo + " ORDER BY codigo ");
                else
                    return SreDblib.MontaCombo(pCombo, "classe_receitas", "descricao", "codigo", true, " ORDER BY codigo ");
        }
    }

    public static String PegaReceitaDescricao(Int32 xID)
    {
        string script;

        script = " SELECT descricao FROM classe_receitas WITH(NOLOCK) " +
                 " WHERE codigo = " + Convert.ToString(xID);

        return Convert.ToString(SreDblib.GetCampoScript(script));

    }

    public uReceitas()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DevExpress.Web.ASPxEditors;

/// <summary>
/// Summary description for uDespesas
/// </summary>
public class uDespesas
{

    public static DataSet LookUpDespesas()
    {
        if ((SreDblib.GetParametro("ORDEM DESPESA") != "CODIGO") && (SreDblib.GetParametro("ORDEM DESPESA") != "CÓDIGO"))
        {
            return SreDblib.GetDsScript("select codigo, descricao from classe_despesas WITH(NOLOCK) ORDER BY descricao");
        }
        else
        {
            return SreDblib.GetDsScript("select codigo, descricao from classe_despesas WITH(NOLOCK) ORDER BY codigo");
        }
    }

    public static DataSet PegaDadosDespesas(string xID)
    {
        string script;

        if ((SreDblib.GetParametro("ORDEM DESPESA") != "CODIGO") && (SreDblib.GetParametro("ORDEM DESPESA") != "CÓDIGO"))
        {
            if ((xID == "0") || (xID == string.Empty))
            {
                script = "SELECT * FROM classe_despesas WITH(NOLOCK) order by descricao";
            }
            else
            {
                script = "SELECT * FROM classe_despesas WITH(NOLOCK) WHERE codigo in (" + Convert.ToString(xID) + ") order by descricao";
            }
        }
        else
        {
            if ((xID == "0") || (xID == string.Empty))
            {
                script = "SELECT * FROM classe_despesas WITH(NOLOCK) order by codigo";
            }
            else
            {
                script = "SELECT * FROM classe_despesas WITH(NOLOCK) WHERE codigo in (" + Convert.ToString(xID) + ") order by codigo";
            }
        }
        return SreDblib.GetDsScript(script);

    }


    public static DataSet PegaDadosDespesasID(string xID)
    {
        string script;

        if ((SreDblib.GetParametro("ORDEM DESPESA") != "CODIGO") && (SreDblib.GetParametro("ORDEM DESPESA") != "CÓDIGO"))
        {
            if ((xID == "0") || (xID == string.Empty))
            {
                script = "SELECT * FROM classe_despesas WITH(NOLOCK) order by descricao";
            }
            else
            {
                script = "SELECT * FROM classe_despesas WITH(NOLOCK) WHERE id in (" + Convert.ToString(xID) + ") order by descricao";
            }
        }
        else
        {
            if ((xID == "0") || (xID == string.Empty))
            {
                script = "SELECT * FROM classe_despesas WITH(NOLOCK) order by codigo";
            }
            else
            {
                script = "SELECT * FROM classe_despesas WITH(NOLOCK) WHERE id in (" + Convert.ToString(xID) + ") order by codigo";
            }
        }
        return SreDblib.GetDsScript(script);

    }


    public static String Grava(string xcodigo,
                               string xdescricao,
                               string xconta_contabil)
    {

        string script = "INSERT INTO classe_despesas VALUES ( " +
                        xcodigo +
                        ", " + Srelib.QStr(xdescricao) +
                        ", " + Srelib.QStr(xconta_contabil) +
                        " ) "; // +
                        //" WHERE NOT EXISTS( select codigo from classe_despesas with(nolock) codigo = " + xcodigo + ")";

        //" where nome=" + Rgblib.QStr(pParametro);

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String AlteraDespesa(string xID,
                                       string xcodigo,
                                       string xdescricao,
                                       string xconta_contabil)
    {

        string script = "UPDATE classe_despesas SET " +
                        " codigo = " + Srelib.QStr(xcodigo) +
                        " ,descricao = " + Srelib.QStr(xdescricao) +
                        " ,conta_contabil = " + Srelib.QStr(xconta_contabil) +
                        " where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String ExcluiDespesa(string xID)
    {

        string script = "DELETE classe_despesas where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static ASPxComboBox MontaComboDespesas(ASPxComboBox pCombo, string pCodigo, Boolean pativo)
    {
        if ((SreDblib.GetParametro("ORDEM DESPESA") != "CODIGO") && (SreDblib.GetParametro("ORDEM DESPESA") != "CÓDIGO"))
        {
            if (pativo)
            {
                if (pCodigo != "0")
                    return SreDblib.MontaCombo(pCombo, "classe_despesas", "descricao", "codigo", true, " WHERE PRODUTO = " + pCodigo + " ORDER BY descricao ");
                else
                    return SreDblib.MontaCombo(pCombo, "classe_despesas", "descricao", "codigo", true, "  ORDER BY descricao ");

            }
            else
                if (pCodigo != "0")
                    return SreDblib.MontaCombo(pCombo, "classe_despesas", "descricao", "codigo", true, " WHERE PRODUTO = " + pCodigo + " ORDER BY descricao ");
                else
                    return SreDblib.MontaCombo(pCombo, "classe_despesas", "descricao", "codigo", true, " ORDER BY descricao ");
        }
        else
        {
            if (pativo)
            {
                if (pCodigo != "0")
                    return SreDblib.MontaCombo(pCombo, "classe_despesas", "descricao", "codigo", true, " WHERE PRODUTO = " + pCodigo + " ORDER BY CODIGO ");
                else
                    return SreDblib.MontaCombo(pCombo, "classe_despesas", "descricao", "codigo", true, "  ORDER BY CODIGO ");

            }
            else
                if (pCodigo != "0")
                    return SreDblib.MontaCombo(pCombo, "classe_despesas", "descricao", "codigo", true, " WHERE PRODUTO = " + pCodigo + " ORDER BY CODIGO ");
                else
                    return SreDblib.MontaCombo(pCombo, "classe_despesas", "descricao", "codigo", true, " ORDER BY CODIGO ");
        }
    }


    public static String PegaDespesaDescricao(Int32 xDespesa)
    {
        string script;

        script = " SELECT descricao FROM classe_despesas WITH(NOLOCK) " +
                 " WHERE codigo = " + Convert.ToString(xDespesa);

        return Convert.ToString(SreDblib.GetCampoScript(script));

    }

    public uDespesas()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DevExpress.Web.ASPxEditors;

/// <summary>
/// Summary description for uCorretor
/// </summary>
public class uCorretor
{

    public static ASPxComboBox MontaComboCorretor(ASPxComboBox pCombo, Boolean pativo)
    {
        if (pativo)
            return SreDblib.MontaCombo(pCombo, "corretores", "nome", "codigo", true, " order by codigo ");
        else
            return SreDblib.MontaCombo(pCombo, "corretores", "nome", "codigo", true, " order by codigo ");
    }

    public static DataSet LookUpCorretor()
    {
        return SreDblib.GetDsScript("select apelido from corretores WITH(NOLOCK) GROUP BY apelido");
    }

    public static DataSet PegaDadosCorretor(Int32 xID)
    {
        string script;

        if (xID == 0)
        {
            script = "SELECT * FROM corretores WITH(NOLOCK) order by Apelido";
        }
        else
        {
            script = "SELECT * FROM corretores WITH(NOLOCK) WHERE id = " + Convert.ToString(xID) + " order by Apelido";
        }

        return SreDblib.GetDsScript(script);

    }

    public static String Grava(string xcodigo,
                               string xapelido,
                               string xnome,
                               string xcomissao_base)
    {


        if ((xapelido != String.Empty) && (xnome != String.Empty))
        {
            string script = "INSERT INTO corretores VALUES ( " +
                            xcodigo +
                            ", " + Srelib.QStr(xapelido) +
                            ", " + Srelib.QStr(xnome) +
                            ", " + Srelib.forcaponto(xcomissao_base) +
                            " ) ";

            //" where nome=" + Rgblib.QStr(pParametro);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String Altera(string xID,
                                string xcodigo,
                                string xapelido,
                                string xnome,
                                string xcomissao_base)
    {

        string script = "UPDATE corretores SET " +
                        " codigo = " + xcodigo +
                        " ,apelido = " + Srelib.QStr(xapelido) +
                        " ,nome = " + Srelib.QStr(xnome) +
                        " ,comissao_base = " + Srelib.forcaponto(xcomissao_base) +
                        " where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }


    public static String Exclui(string xID)
    {

        string script = "DELETE corretores where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }


    public static int PegaNovoCodigo()
    {
        //Pega Novo Codigo
        string script = "SELECT MAX(codigo)+1 MNUM FROM corretores WITH(NOLOCK)";
        return Convert.ToInt16(SreDblib.GetCampoScript(script)); ;
        //
    }

    public static string PegaApelidoCorretor(Int32 xTipo)
    {
        string script;

        script = " SELECT apelido FROM corretores WITH(NOLOCK) " +
                 " WHERE codigo = " + Convert.ToString(xTipo);

        return Convert.ToString(SreDblib.GetCampoScript(script));

    }

    public static String PegaNomeIDCorretor(string xID)
    {
        string script = "SELECT nome FROM corretores WITH(NOLOCK) WHERE codigo = " + xID;
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }


    public static string PegaTaxaComissão(Int32 xTipo)
    {
        string script;

        script = " SELECT comissao_base FROM corretores WITH(NOLOCK) " +
                 " WHERE codigo = " + Convert.ToString(xTipo);

        return Convert.ToString(SreDblib.GetCampoScript(script));

    }
	public uCorretor()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
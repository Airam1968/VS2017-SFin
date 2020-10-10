using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;

/// <summary>
/// Summary description for uCadDocumentos
/// </summary>
public class uCadDocumentos
{

    public static String PegaDescricao(string xdoc)
    {
        string script = "SELECT nome FROM cdocumento WITH(NOLOCK) WHERE codigo = " + Srelib.QStr(xdoc);
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }

    }

    public static ASPxComboBox MontaComboDocumento(ASPxComboBox pCombo)
    {

        return SreDblib.MontaCombo(pCombo, "cdocumento", "nome", "codigo", true, "");

    }

}
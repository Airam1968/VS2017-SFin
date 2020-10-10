using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;

/// <summary>
/// Summary description for uGrupo
/// </summary>
public class uJanela
{

    public static ASPxComboBox MontaComboJanela(ASPxComboBox pCombo)
    {
        //Documentação - Chamada da Função
        //
        //Fim Documentação - Chamada da Função

        string pTabela = "janela";
        string pCampoExibe = "codjanela";
        string pCampoValor = "codjanela";
        Boolean pExibeValor = false;

        String script = "SELECT " + pCampoExibe + "," + pCampoValor + " FROM " + pTabela + " WITH(NOLOCK) ORDER BY id";
        DataSet ds = SreDblib.GetDsScript(script);
        ListEditItem le;
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            le = new ListEditItem();
            if (pExibeValor)
            {
                le.Text = dr[pCampoValor].ToString() + " - " + dr[pCampoExibe].ToString();
            }
            else
            {
                le.Text = dr[pCampoExibe].ToString();
            };
            le.Value = dr[pCampoValor].ToString();
            pCombo.Items.Add(le);
        }
        return pCombo;
    }

    public static String PegaNome(string xemp)
    {
        string script = "SELECT nome FROM janela WITH(NOLOCK) WHERE apelido = " + Srelib.QStr(xemp);
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return " ";
        }

    }

	public uJanela()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;

/// <summary>
/// Summary description for uPessoa
/// </summary>
public class uPessoa
{

	public static Boolean SeekChaveFraca(string pTabela, string pNomeChave, string pChave)
	{
		Boolean Retorno = false;

		String script = "SELECT * FROM " + pTabela + " WITH(NOLOCK) "+
						"WHERE " + pNomeChave + " = " + Srelib.QStr(pChave.Trim());

		DataSet ds = SreDblib.GetDsScript(script);

		if (ds.Tables[0].Rows.Count == 0)
		{
			Retorno = false;
		}
		else
		{
			Retorno = true;
		}
		return Retorno;

	}


	public uPessoa()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
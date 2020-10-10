using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for uSpfm
/// </summary>
public class uSpfm
{

	public Boolean Valida_Spfm(String xCPFCNPJ)
	{
		Boolean Retorno = false;
		DataSet PSpfm = new DataSet();

		String Script = "SELECT * FROM infofact WITH(NOLOCK) " +
				" where cgc = " + Srelib.QStr(xCPFCNPJ.Trim()) +
				" OR cpf1  = " + Srelib.QStr(xCPFCNPJ.Trim()) +
				" OR cpf2  = " + Srelib.QStr(xCPFCNPJ.Trim()) +
				" ORDER BY DATA desc";

		PSpfm = SreDblib.GetDsScript(Script);

		if (PSpfm.Tables[0].Rows.Count != 0)
		{
			Retorno = true;
		}
		else
		{
			Retorno = false;
		}

		return Retorno;
	}



	public uSpfm()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
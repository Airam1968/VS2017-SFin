using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for uFechamento
/// </summary>
public class uFechamento
{

	public static DateTime PegaUltimaData()
	{
		//Pega Data da Ultimo Fehamento
		DateTime Retorno1 = Convert.ToDateTime("01/01/1900");

		string script = "SELECT ultimo_fechamento FROM fechamento WITH(NOLOCK) " +
						"Order by ultimo_fechamento DESC";
		Retorno1 = Convert.ToDateTime(SreDblib.GetCampoScript(script));

		return Retorno1;
		//
	}

	public static DateTime PegaUltimaDataBancaria()
	{
		//Pega Data da Ultimo Fehamento
		DateTime Retorno1 = Convert.ToDateTime("01/01/1900");

		string script = "SELECT ultimo_fechamento_Bancario FROM fechamento WITH(NOLOCK) " +
						"Order by ultimo_fechamento DESC";
		Retorno1 = Convert.ToDateTime(SreDblib.GetCampoScript(script));

		return Retorno1;
		//
	}

	
	public uFechamento()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
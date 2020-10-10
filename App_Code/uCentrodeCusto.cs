using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for uCentrodeCusto
/// </summary>
public class uCentrodeCusto
{

    public static string Inclui(SqlParameter[] parameters)
    {
        //inclui_centro_custo
        return SreDblib.ExecSp("inclui_centro_custo", parameters);
        //
    }

    public static string Altera(SqlParameter[] parameters)
    {
        //altera_centro_custo
        return SreDblib.ExecSp("altera_centro_custo", parameters);
        //
    }

    public static string Exclui(SqlParameter[] parameters)
    {
        // deleta_centro_custo
        return SreDblib.ExecSp("deleta_centro_custo", parameters);
        //
    }

	public uCentrodeCusto()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
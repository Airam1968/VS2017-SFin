using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for uEsquema
/// </summary>
public class uEsquema
{
    public static string Inclui(SqlParameter[] parameters)
    {
        //inclui_esquema
        return SreDblib.ExecSp("inclui_esquema", parameters);
        //
    }

    public static string Altera(SqlParameter[] parameters)
    {
        //altera_esquema
        return SreDblib.ExecSp("altera_esquema", parameters);
        //
    }

    public static string Exclui(SqlParameter[] parameters)
    {
        //deleta_esquema
        return SreDblib.ExecSp("deleta_esquema", parameters);
        //
    }

    public static string Troca_Esquema(SqlParameter[] parameters)
    {
        //Troca_Esquema
        string retorno = "";
        retorno = SreDblib.GetCampoSp("Troca_Esquema", parameters);
        return retorno;
        //
    }


    public static DateTime PegaDataMaxima()
    {
        //Pega Data Maxima 
        String Retorno2;
        string script = "Select Max( datai ) wdata from esquema WITH(NOLOCK)";
        Retorno2 = SreDblib.GetCampoScript(script);
        if (Retorno2.Trim() == "")
        {
            Retorno2 = "01/01/1900";
        }
        return Convert.ToDateTime(Retorno2);
        //
    }
	public uEsquema()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for uParamTabela
/// </summary>
public class uParamTabela
{
    public Boolean grupo1;
    public Boolean grupo2;
    public Boolean grupo3;
    public Boolean grupo4;
    public Boolean ckr6;
    public Int16 refat;

    public void PegaDadosCrepar()
    {
        String sql = @"Select isnull(grupo1,0) grupo1, 
                              isnull(grupo2,0) grupo2,
                              isnull(grupo3,0) grupo3,
                              isnull(grupo4,0) grupo4,
                              isnull(ckr6,0) ckr6,
                              isnull(refat,0) refat
                       from crepar";
        DataSet Ds = SreDblib.GetDsScript(sql);
        // dados
        grupo1 = false;
        grupo2 = false;
        grupo3 = false;
        grupo4 = false;
        ckr6 = false;
        refat = 0;
        if (Ds.Tables.Count > 0)
        {
            grupo1 = Convert.ToBoolean(Ds.Tables[0].Rows[0]["grupo1"].ToString());
            grupo2 = Convert.ToBoolean(Ds.Tables[0].Rows[0]["grupo2"].ToString());
            grupo3 = Convert.ToBoolean(Ds.Tables[0].Rows[0]["grupo3"].ToString());
            grupo4 = Convert.ToBoolean(Ds.Tables[0].Rows[0]["grupo4"].ToString());
            ckr6 = Convert.ToBoolean(Ds.Tables[0].Rows[0]["ckr6"].ToString());
            refat = Convert.ToInt16(Ds.Tables[0].Rows[0]["refat"].ToString());

        }
    }

    public static string altera_parametros_credito(SqlParameter[] parameters)
    {
        //altera_crepar
        return SreDblib.ExecSp("altera_crepar", parameters);
    }



	public static string altera_par_contab(SqlParameter[] parameters)
	{
		//altera_par_contab
		return SreDblib.ExecSp("altera_par_contab", parameters);
		//
	}


	public static String PegaEmpresaMasterContabil()
	{
		string script = "SELECT num_empresa_mastercontabil FROM par_contab WITH(NOLOCK)";
		try
		{
			return SreDblib.GetCampoScript(script);
		}
		catch
		{
			return " ";
		}

	}

	public static String PegaFilial()
	{
		string script = "SELECT filial FROM par_contab WITH(NOLOCK)";
		try
		{
			return SreDblib.GetCampoScript(script);
		}
		catch
		{
			return " ";
		}

	}
	public uParamTabela()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
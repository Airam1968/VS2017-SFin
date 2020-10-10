using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.Configuration;
using System.Data.SqlClient;

/// <summary>
/// Summary description for uEmail
/// </summary>
public class uEmail
{


    public static string PegaCaminhoFisicoGitano()
    {
        //SRE_CaminhoGitano - WebConfig
        string resultado;
        string CaminhoGitano = "";
        //CaminhoGitano = ConfigurationSettings.AppSettings["SRE_CaminhoGitano"];
        CaminhoGitano = ConfigurationManager.AppSettings["SRE_CaminhoGitano"];
        if (CaminhoGitano.Trim() == "")
        {
            resultado = "";
        }
        else
        {
            resultado = CaminhoGitano;
        }

        return resultado;

    }

    public static string Grava( string pmarca,
                                string parquivo,
                                string pempresa,
                                string pcedente,
                                Int32 ptipo_operacao,
                                Int32 pbordero,
                                string pcnpj,
                                string pobs,
                                DateTime pdatahora_envio,
                                DateTime pdatahora_geracao,
                                string porigem,
                                string ptitulo,
                                string pemaildest,
                                string pemailcorpo,
                                string pusuario,
                                Int32 psequencial,
                                string pemailcopia,
                                string parquivo1,
                                string parquivo2,
                                string parquivo3,
                                string parquivo4,
                                string parquivo5,
                                string parquivo6,
                                string parquivo7,
                                string parquivo8,
                                string parquivo9  )
    {
        // Parametros SQL
        SqlParameter[] parameters = { new SqlParameter("@marca", pmarca),
                                    new SqlParameter("@arquivo", parquivo),
                                    new SqlParameter("@empresa", pempresa),
                                    new SqlParameter("@cedente", pcedente),
                                    new SqlParameter("@tipo_operacao", ptipo_operacao),
                                    new SqlParameter("@bordero", pbordero),
                                    new SqlParameter("@cnpj", pcnpj),
                                    new SqlParameter("@obs", pobs),
                                    new SqlParameter("@datahora_envio", pdatahora_envio),
                                    new SqlParameter("@datahora_geracao", pdatahora_geracao),
                                    new SqlParameter("@origem", porigem),
                                    new SqlParameter("@titulo", ptitulo),
                                    new SqlParameter("@emaildest", pemaildest),
                                    new SqlParameter("@emailcorpo", pemailcorpo),
                                    new SqlParameter("@usuario", pusuario),
                                    new SqlParameter("@sequencial", psequencial),
                                    new SqlParameter("@emailccopia", pemailcopia),
                                    new SqlParameter("@arquivo1", parquivo1),
                                    new SqlParameter("@arquivo2", parquivo2),
                                    new SqlParameter("@arquivo3", parquivo3),
                                    new SqlParameter("@arquivo4", parquivo4),
                                    new SqlParameter("@arquivo5", parquivo5),
                                    new SqlParameter("@arquivo6", parquivo6),
                                    new SqlParameter("@arquivo7", parquivo7),
                                    new SqlParameter("@arquivo8", parquivo8),
                                    new SqlParameter("@arquivo9", parquivo9) };
        //Grava na Central de Email
        return SreDblib.ExecSp("Inclui_Email", parameters);
        //
    }

	public uEmail()
	{
		//
        //TODO: Add constructor logic here
		//
	}
}
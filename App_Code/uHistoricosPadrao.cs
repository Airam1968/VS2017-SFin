using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using DevExpress.Web.ASPxEditors;

/// <summary>
/// Summary description for uHistoricosPadrao
/// </summary>
public class uHistoricosPadrao
{

	public static ASPxComboBox MontaComboHistorico(ASPxComboBox pCombo)
	{
        //Documentação - Chamada da Função
		//
		//RgbDbLib.MontaComboEmpresa(ASPxComboBox1);
		//
		//Fim Documentação - Chamada da Função

		String[] Campos1 = { "descricao" };

		SreDblib.MontaComboMult(pCombo, "chisto", Campos1, "historico", true);

		return pCombo;
	}

	public static string Inclui(SqlParameter[] parameters)
	{
		//inclui_chisto
		return SreDblib.ExecSp("inclui_chisto", parameters);
		//
	}

	public static string Altera(SqlParameter[] parameters)
	{
		//altera_chisto
		return SreDblib.ExecSp("altera_chisto", parameters);
		//
	}

	public static string Exclui(SqlParameter[] parameters)
	{
		//deleta_chisto
		return SreDblib.ExecSp("deleta_chisto", parameters);
		//
	}

	public uHistoricosPadrao()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
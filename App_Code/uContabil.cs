using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using DevExpress.Web.ASPxEditors;

/// <summary>
/// Summary description for uContabil
/// </summary>
public class uContabil
{

	public static ASPxComboBox MontaTipoEvento(ASPxComboBox pCombo)
	{
		//Documentação - Chamada da Função
		//
		//RgbDbLib.MontaTipoEvento(ASPxComboBox1);
		//
		//Fim Documentação - Chamada da Função

		DataTable dt = new DataTable();
		dt.Columns.Add("Cod", typeof(String));
		dt.Columns.Add("Desc", typeof(String));

		dt.Rows.Add(new object[] { "010", "Borderô" });
		dt.Rows.Add(new object[] { "020", "Abatimentos" });
		dt.Rows.Add(new object[] { "030", "Cancelar Abatimentos" });
		dt.Rows.Add(new object[] { "040", "Antecipacão Parcial" });
		dt.Rows.Add(new object[] { "050", "Pagamento Por Conta" });
		dt.Rows.Add(new object[] { "060", "Duplicatas Liquidadas Via CNAB" });
		dt.Rows.Add(new object[] { "070", "Duplicatas Liquidadas Avulsas" });
		dt.Rows.Add(new object[] { "080", "Depósito de Cheque em Lote" });
		dt.Rows.Add(new object[] { "090", "Depósito de Cheque Individual" });
		dt.Rows.Add(new object[] { "100", "Devolução de Cheques Individual" });
		dt.Rows.Add(new object[] { "110", "Re-Depósito de Cheques / Pagto. Substitutivo" });
		dt.Rows.Add(new object[] { "121", "Aplicação" });
		dt.Rows.Add(new object[] { "122", "Resgate" });
		dt.Rows.Add(new object[] { "123", "Acerto de Saldo" });
		dt.Rows.Add(new object[] { "124", "Lançamentos Bancários Wincc Sem Contra Partida" });
		dt.Rows.Add(new object[] { "125", "Transferência Entre Contas Bancárias" });
		dt.Rows.Add(new object[] { "130", "Despesa em Conjunto" });
		dt.Rows.Add(new object[] { "140", "Cheques Devolvidos Não Identificados - Inclusão" });
		dt.Rows.Add(new object[] { "145", "Cheques Devolvidos Não Identificados - Identificação" });
		dt.Rows.Add(new object[] { "150", "Depósitos Não Identificados - Inclusão" });
		dt.Rows.Add(new object[] { "155", "Depósitos Não Identificados - Identificação Cedente" });
		dt.Rows.Add(new object[] { "158", "Depósitos Não Identificados - Identificação Sacado" });
		dt.Rows.Add(new object[] { "160", "Reposição" });
		dt.Rows.Add(new object[] { "170", "Adiantamento" });
		dt.Rows.Add(new object[] { "180", "Liberação Avulsa" });
		dt.Rows.Add(new object[] { "190", "Devolução de Liberação Avulsa" });
		dt.Rows.Add(new object[] { "195", "Transferência de C/C entre Cedentes do mesmo GRUPO" });
		dt.Rows.Add(new object[] { "200", "Compra de Imobilizado" });
		dt.Rows.Add(new object[] { "210", "Venda de Imobilizado" });
		dt.Rows.Add(new object[] { "220", "Recompras Avulsas" });
		dt.Rows.Add(new object[] { "225", "Recuperação de Prejuízo" });
		dt.Rows.Add(new object[] { "230", "Entrada de Lançamentos de C/C" });
		dt.Rows.Add(new object[] { "250", "Tipo de Operação 2, 3, 4 -> Entrada" });
		dt.Rows.Add(new object[] { "260", "Tipo de Operação 2, 3, 4 -> Liquidação" });
		dt.Rows.Add(new object[] { "270", "Pagamentos Avulsos em C/C Cliente" });
		dt.Rows.Add(new object[] { "300", "Empréstimos" });
		dt.Rows.Add(new object[] { "310", "Repactuações / Renegociações" });
		dt.Rows.Add(new object[] { "320", "Resgates" });
		dt.Rows.Add(new object[] { "330", "IOF (Somatório de IOF de OP. S/ PRAZO 1o. DIA ÚTIL)" });
		dt.Rows.Add(new object[] { "401", "Borderô do CAP" });
		dt.Rows.Add(new object[] { "402", "Pagamento Cedente - CAP" });
		dt.Rows.Add(new object[] { "403", "Cancelamento ítens do Cedente - CAP" });
		dt.Rows.Add(new object[] { "404", "CAP Empresa" });
		dt.Rows.Add(new object[] { "405", "Pagamento CAP sem NF" });
		dt.Rows.Add(new object[] { "406", "Pagamento CAP com NF" });
		dt.Rows.Add(new object[] { "407", "Nota Fiscal Empresa - CAP" });
		dt.Rows.Add(new object[] { "408", "Cancelamento CAP com NF" });
		dt.Rows.Add(new object[] { "409", "Cancelamento CAP sem NF" });
		dt.Rows.Add(new object[] { "500", "Entrada de Acordo de Pagamento" });
		dt.Rows.Add(new object[] { "501", "Pagamento de Parcela de Acordo de Pagamento" });
		
		pCombo.Columns.Clear();
		pCombo.Width = 400;
		pCombo.Columns.Add(new DevExpress.Web.ASPxEditors.ListBoxColumn("Cod"));
		pCombo.Columns.Add(new DevExpress.Web.ASPxEditors.ListBoxColumn("Desc"));
		pCombo.Columns[0].Width = 20;
		pCombo.Columns[0].Caption = "Cod";
		pCombo.Columns[1].Width = 350;
		pCombo.Columns[1].Caption = "Descrição";
		pCombo.TextFormatString = "{0} - {1}";
		pCombo.ValueField = "Cod";
		pCombo.DataSource = dt;
		pCombo.DataBind();
		return pCombo;
	}

	public static string pega_email_cont()
	{
		string resultado;
		string script = "SELECT email_cont FROM par_contab WITH(NOLOCK)";
		resultado = SreDblib.GetCampoScript(script);
		if (resultado.Trim() == "")
			resultado = Srelib.space(18);
		return resultado;
		//
	}

	public static string PegaCusto(String c)
	{
		string resultado;
		string script = "SELECT centro FROM centro_custo WITH(NOLOCK) WHERE conta="+Srelib.QStr(c) ;
		resultado = SreDblib.GetCampoScript(script);
		if (resultado.Trim() == "")
			resultado = Srelib.space(18);
		return resultado;
		//
	}

	public static int PegaNSeqHistor()
	{
		//Pega NSeq Historico Padrão
		string script = "SELECT MAX(historico)+1 MNUM FROM chisto WITH(NOLOCK)";
		return Convert.ToInt16(SreDblib.GetCampoScript(script)); ;
		//
	}

	public static DateTime PegaUltimaGeracaoM1()
	{
		//Pega Datas da Ultima Geração Contabil
		String Retorno1;
		string script = "SELECT M1 FROM ccontrol WITH(NOLOCK)" +
						"WHERE tipo="+Srelib.QStr("G") +
						"ORDER BY sequencial DESC";
		Retorno1 = SreDblib.GetCampoScript(script);
		if (Retorno1.Trim() == "")
		{
			Retorno1 = "01/01/1900";
		}
		return Convert.ToDateTime(Retorno1);
		//
	}

	public static DateTime PegaUltimaGeracaoM2()
	{
		//Pega Data da Próxima Geração Contabil
		String Retorno2;
		string script = "SELECT M2 FROM ccontrol WITH(NOLOCK)" +
						"WHERE tipo=" + Srelib.QStr("G") +
						"ORDER BY sequencial DESC";
		Retorno2 = SreDblib.GetCampoScript(script);
		if (Retorno2.Trim() == "")
		{
			Retorno2 = "01/01/1900";
		}
		return Convert.ToDateTime(Retorno2);
		//
	}

	public static DateTime UltimoMovimentoGerado(DateTime pData)
	{
		//Pega Data da Próxima Geração Contabil
		String Retorno2;
		string script = "SELECT M2 FROM ccontrol WITH(NOLOCK)" +
						"WHERE tipo=" + Srelib.QStr("G") +
						"ORDER BY M2 DESC";
		Retorno2 = SreDblib.GetCampoScript(script);
		if (Retorno2.Trim() == "")
		{
			Retorno2 = Convert.ToString(pData);
		}
		return Convert.ToDateTime(Retorno2);
		//
	}

	public static DateTime UltimoMovimentoExportado(DateTime pData)
	{
		//Pega Data da Próxima Geração Contabil
		String Retorno2;
		string script = "SELECT M2 FROM ccontrol WITH(NOLOCK)" +
						"WHERE tipo=" + Srelib.QStr("E") +
						"ORDER BY M2 DESC";
		Retorno2 = SreDblib.GetCampoScript(script);
		if (Retorno2.Trim() == "")
		{
			Retorno2 = Convert.ToString(pData);
		}
		return Convert.ToDateTime(Retorno2);
		//
	}

	public static DateTime PegaUltimaLimpeza()
	{
		//Pega Data da Ultima Limpeza
		DateTime Retorno;
		string script = "Select dataref from controle_limp WITH(NOLOCK) " +
						"order by dataref desc";
		try
		{
			Retorno = Convert.ToDateTime(SreDblib.GetCampoScript(script));
		}
		catch
		{
			Retorno = Convert.ToDateTime("01/01/1900");
		}
		return Retorno;
		//
	}

	public static string DeletaMovimento(SqlParameter[] parameters)
	{
		//DELETA_MOVIMENTO
		return SreDblib.ExecSp("DELETA_MOVIMENTO", parameters);
		//
	}

	public static string GeraLancamentos(SqlParameter[] parameters)
	{
		//GERA_LANCAMENTOS_CONTABEIS1
		return SreDblib.ExecSp("GERA_LANCAMENTOS_CONTABEIS1", parameters);
		//
	}

	public static Boolean PegaSped()
	{
		string script = "SELECT cksped FROM par_contab WITH(NOLOCK)";
		return Convert.ToBoolean(SreDblib.GetCampoScript(script));
	}

	public static Int16 PegaTipoArq()
	{
		string script = "SELECT QDR7_destino FROM par_contab WITH(NOLOCK)";
		return Convert.ToInt16(SreDblib.GetCampoScript(script));
	}

	public static string PegaCaminho()
	{
		string resultado;
		string script = "SELECT QDR7_Pasta FROM par_contab WITH(NOLOCK)";
		resultado =  Convert.ToString(SreDblib.GetCampoScript(script));
		if (resultado.Trim() == "")
		{
			resultado = "C:";
		}
		return resultado;
	}

	public static string Pega_num_Receita()
	{
		string resultado;
		string script = "SELECT num_receita FROM par_contab WITH(NOLOCK)";
		resultado = Convert.ToString(SreDblib.GetCampoScript(script));
		return resultado;
	}

	public static string Pega_num_despesa()
	{
		string resultado;
		string script = "SELECT num_despesa FROM par_contab WITH(NOLOCK)";
		resultado = Convert.ToString(SreDblib.GetCampoScript(script));
		return resultado;
	}

	public static Int16 PegaHistPadrao()
	{
		Int16 resultado;
		string script = "select historico from chisto WITH(NOLOCK) where ckpadrao=1";
		resultado = Convert.ToInt16(SreDblib.GetCampoScript(script));
		if (resultado == 0)
		{
			resultado = 99;
		}
		return resultado;
	}

	public static Int16 PegaNContabil()
	{
		Int16 resultado;
		string script = "SELECT Ncontabil FROM nContabil WITH(NOLOCK)";
		resultado = Convert.ToInt16(SreDblib.GetCampoScript(script));
		return resultado;
	}

	public static string Pega_Historico(int c)
	{
		string script = "select descricao from chisto WITH(NOLOCK) " + "where historico = "+Convert.ToString(c);
		return  Convert.ToString(SreDblib.GetCampoScript(script));
	}


	public static Boolean AlteraDataExporta(SqlParameter[] parameters)
	{
		//CONTAB_DATA_EXPORTA
		Boolean Retorno = false;
		try
		{
			SreDblib.ExecSp("CONTAB_DATA_EXPORTA", parameters);
			Retorno = true;
		}
		catch
		{
			Retorno = false;
		}
		//
		return Retorno;
	}

	public static string IncluiAcertos(SqlParameter[] parameters)
	{
		//inclui_contab
		return SreDblib.ExecSp("inclui_contab", parameters);
		//
	}

	public static string AlteraAcertos(SqlParameter[] parameters)
	{
		//altera_contab
		return SreDblib.ExecSp("altera_contab", parameters);
		//
	}

	public static string ExcluiAcertos(SqlParameter[] parameters)
	{
		// deleta_contab
		return SreDblib.ExecSp("deleta_contab", parameters);
		//
	}
			 
			 public uContabil()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
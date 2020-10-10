using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Summary description for uPainel
/// </summary>
public class uPainel
{
	public String DataAtual;
	public String PercentualLiquidez;
	public String PercentualLimite;
	public String PercTaxaMedia;
	public String QtdParecer;
	public String TaxaMediaDiaria;
	public String TaxaMediaMensal;
	public String QtdPrejuizo;
	public String Width;
	public String Height;

	public String DiasInicio;
	public String DiasFim;
	public String ValorAtraso;
	public bool IniciaPainel;

	public DataTable DtLiquidez;
	public DataTable DtLimite;
	public DataTable DtTaxaMedia;
	public DataTable DtParecer;
	public DataTable DtClientesAtraso;
	public DataTable DtPrejuizo;
	


	public void Liquidez()
	{

		String Qry = "EXEC PN_SP_LIQUIDEZ " +
					  Srelib.QStr(Srelib.DataQuery(DataAtual, DM.FormatoData)) + "," +
					  PercentualLiquidez;

		DataSet DS = new DataSet();
		SqlCommand Command = new SqlCommand(Qry, DM.ConexaoSessao);
		Command.CommandTimeout = 99999;
		SqlDataAdapter DA = new SqlDataAdapter();
		DA.TableMappings.Add("Table", "PN");
		DA.SelectCommand = Command;
		DA.Fill(DS);
		DtLiquidez = DS.Tables["PN"];
	}

	public void Limite()
	{

		String Qry = "EXEC PN_SP_LIMITE " +
					  PercentualLimite;

		DataSet DS = new DataSet();
		SqlCommand Command = new SqlCommand(Qry, DM.ConexaoSessao);
		Command.CommandTimeout = 99999;
		SqlDataAdapter DA = new SqlDataAdapter();
		DA.TableMappings.Add("Table", "PN");
		DA.SelectCommand = Command;
		DA.Fill(DS);
		DtLimite = DS.Tables["PN"];
	}

	public void TaxaMedia()
	{

		String Qry = "EXEC PN_SP_TAXA_TOTAL " +
					  Srelib.QStr(Srelib.DataQuery(DataAtual, DM.FormatoData)) + "," +
					  PercTaxaMedia;

		DataSet DS = new DataSet();
		SqlCommand Command = new SqlCommand(Qry, DM.ConexaoSessao);
		Command.CommandTimeout = 99999;
		SqlDataAdapter DA = new SqlDataAdapter();
		DA.TableMappings.Add("Table", "PN");
		DA.SelectCommand = Command;
		DA.Fill(DS);
		DtTaxaMedia = DS.Tables["PN"];
	}


	public void TaxaMediaDiariaMensal()
	{

		String Qry = "EXEC PN_SP_TAXA_MEDIA " +
					  Srelib.QStr(Srelib.DataQuery(DataAtual, DM.FormatoData));

		DataSet DS = new DataSet();
		SqlCommand Command = new SqlCommand(Qry, DM.ConexaoSessao);
		Command.CommandTimeout = 99999;
		SqlDataAdapter DA = new SqlDataAdapter();
		DA.TableMappings.Add("Table", "PN");
		DA.SelectCommand = Command;
		DA.Fill(DS);
		DataTable Dt = DS.Tables["PN"];
		TaxaMediaDiaria = String.Format("{0:#,###,##0.00}", Convert.ToDouble(Dt.Rows[0]["TAXA_DIARIA"].ToString()));
		TaxaMediaMensal = String.Format("{0:#,###,##0.00}", Convert.ToDouble(Dt.Rows[0]["TAXA_MENSAL"].ToString()));
	}


	public void Parecer()
	{

		String Qry = "EXEC PN_SP_MANUTCRED " +
					  QtdParecer;

		DataSet DS = new DataSet();
		SqlCommand Command = new SqlCommand(Qry, DM.ConexaoSessao);
		Command.CommandTimeout = 99999;
		SqlDataAdapter DA = new SqlDataAdapter();
		DA.TableMappings.Add("Table", "PN");
		DA.SelectCommand = Command;
		DA.Fill(DS);
		DtParecer = DS.Tables["PN"];
	}

	public void Prejuizo()
	{

		String Qry = "EXEC PN_SP_PREJUIZO " +
					  QtdPrejuizo;

		DataSet DS = new DataSet();
		SqlCommand Command = new SqlCommand(Qry, DM.ConexaoSessao);
		Command.CommandTimeout = 99999;
		SqlDataAdapter DA = new SqlDataAdapter();
		DA.TableMappings.Add("Table", "PN");
		DA.SelectCommand = Command;
		DA.Fill(DS);
		DtPrejuizo = DS.Tables["PN"];
	}


	public void ClientesEmAtraso()
	{

		String Qry = "EXEC PN_SP_CLIENTES_ATRASO " +
					  Srelib.QStr(Srelib.DataQuery(DataAtual, DM.FormatoData)) + "," +
					  DiasInicio + "," +
					  DiasFim + "," +
					  ValorAtraso;

		DataSet DS = new DataSet();
		SqlCommand Command = new SqlCommand(Qry, DM.ConexaoSessao);
		Command.CommandTimeout = 99999;
		SqlDataAdapter DA = new SqlDataAdapter();
		DA.TableMappings.Add("Table", "PN");
		DA.SelectCommand = Command;
		DA.Fill(DS);
		DtClientesAtraso = DS.Tables["PN"];
	}

	
	public uPainel()
	{
		//
		// TODO: Add constructor logic here
		//
		PercentualLiquidez = ConfigurationManager.AppSettings["PnPercentualLiquidez"];
		PercentualLimite = ConfigurationManager.AppSettings["PnPercentualLimite"];
		PercTaxaMedia = ConfigurationManager.AppSettings["PnPercentualTaxaMedia"];
		QtdParecer = ConfigurationManager.AppSettings["PnQtdParecer"];

		DiasInicio = ConfigurationManager.AppSettings["PnDiasInicio"];
		DiasFim = ConfigurationManager.AppSettings["PnDiasFim"];
		ValorAtraso = ConfigurationManager.AppSettings["PnValorAtraso"];
		QtdPrejuizo = ConfigurationManager.AppSettings["PnQtdPrejuizo"];
		Width = ConfigurationManager.AppSettings["PnWidth"];
		Height = ConfigurationManager.AppSettings["PnHeight"];
		Usuario xusuario = new Usuario();
		xusuario.PegaDataAtual("", false);
		DataAtual = xusuario.DataAtual;
	}
}

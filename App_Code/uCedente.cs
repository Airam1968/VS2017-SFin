using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;
using System.ComponentModel;




/// <summary>
/// Summary description for uCedente
/// </summary>
/// 

[DataObject()]
public class uCedente
{
    public String apelido;
    public String cnpjformatado;
    public String cnpj;
    public String raiz_cnpj;
    public String gerente;
    public String grupo;
    public String ramo;
    public String razaosocial;
    public String endereco;
    public String bairro;
    public String cidade;
    public String uf;
    public String cep;
    public String fones;
    public String contatos;

    public String l_acum;
    public String l_acumch;
    public String l_acumdp;
    public String l_sac;
    public String l_sacch;
    public String l_sacdp;
    public String fixacao;
    public String l_valor;
    public String l_titulos;
    public String vencimento;
    public String l_nconf;
    public String limitech;
    public String pconfir;
    public String cnpjmin;
    public String prazomin;
    public String prazomax;
    public String tdesc;
    public String txserv;
    public String txmora;


    public String PegaMoraDefault(String wcedente, Boolean lrec)
    {
        String sql = "PEGAMORADEFAULT";
        
        SqlParameter[] parametros = { 
                                      new SqlParameter("@cedente", wcedente),
                                      new SqlParameter("@lrec", lrec)
                                    };

        DataSet Ds = SreDblib.GetDsSp(sql, parametros);

        return Srelib.PadDouble(Ds.Tables[0].Rows[0]["taxamora"].ToString());
    }


    public void PegaDadosDoCedente(String wcedente)
    {
        String sql = @"Select cnpj,
                              apelido, nome,
                              endereco,
                              bairro, cidade, uf, cep,
                              fone, contato, gerente, ramo, grupo,
                              isnull(l_acum,0.00) l_acum, 
                              isnull(l_acumch,0.00) l_acumch,
                              isnull(l_acumdp,0.00) l_acumdp,
                              isnull(l_sac,0.00) l_sac, 
                              isnull(l_sacch,0.00) l_sacch,
                              isnull(l_sacdp,0.00) l_sacdp,
                              dlimite,
                              isnull(l_valor,0.00) l_valor, 
                              isnull(l_titulos,0.00) l_titulos, 
                              vencimento,
                              isnull(l_nconf,0.00) l_nconf, 
                              isnull(limitech,0.00) limitech, 
                              isnull(pconfir,0.00) pconfir, 
                              isnull(cnpjmin,0.00) cnpjmin, 
                              isnull(prazomin,0) prazomin, 
                              isnull(prazomax,0) prazomax,
                              isnull(tdesc,0.00) tdesc, 
                              isnull(txserv,0.00) txserv 
                       from cedente where apelido=@cedente";
        SqlParameter[] parametros = { new SqlParameter("@cedente", wcedente) };
        DataSet Ds = SreDblib.GetDsCp(sql, parametros);
        // dados
        apelido = "";
        cnpjformatado = "";
        cnpj = "";
        raiz_cnpj = "";
        grupo = "";
        gerente = "";
        ramo = "";
        razaosocial = "";
        endereco = "";
        bairro = "";
        cidade = "";
        uf = "";
        cep = "";
        fones = "";
        contatos = "";
        l_acum = "0.00";
        l_acumch = "0.00";
        l_acumdp = "0.00";
        l_sac = "0.00";
        l_sacch = "0.00";
        l_sacdp = "0.00";
        fixacao = "";
        l_valor = "0.00";
        l_titulos = "0";
        vencimento = "";
        l_nconf = "0.00";
        limitech = "0.00";
        pconfir = "0.00";
        cnpjmin = "0.00";
        prazomin = "0";
        prazomax = "0";
        tdesc = "0.00";
        txserv = "0.00";

        if (Ds.Tables.Count > 0)
        {
            apelido = Ds.Tables[0].Rows[0]["apelido"].ToString();
            cnpj = Ds.Tables[0].Rows[0]["cnpj"].ToString();
            raiz_cnpj = cnpj;
            if (cnpj.Trim().Length == 14)
            {
                raiz_cnpj = raiz_cnpj.Substring(0, 8);
            }
            cnpjformatado = Srelib.FormataCPFCNPJ(cnpj);
            razaosocial = Ds.Tables[0].Rows[0]["nome"].ToString();
            endereco = Ds.Tables[0].Rows[0]["endereco"].ToString();
            bairro = Ds.Tables[0].Rows[0]["bairro"].ToString();
            cidade = Ds.Tables[0].Rows[0]["cidade"].ToString();
            uf =  Ds.Tables[0].Rows[0]["uf"].ToString();
            cep =  Ds.Tables[0].Rows[0]["cep"].ToString();
            fones = Ds.Tables[0].Rows[0]["fone"].ToString();
            contatos = Ds.Tables[0].Rows[0]["contato"].ToString();
            gerente = Ds.Tables[0].Rows[0]["gerente"].ToString();
            ramo = Ds.Tables[0].Rows[0]["ramo"].ToString();
            grupo = Ds.Tables[0].Rows[0]["grupo"].ToString();

            l_titulos = Ds.Tables[0].Rows[0]["l_titulos"].ToString();
            l_valor = Srelib.PadDouble(Ds.Tables[0].Rows[0]["l_valor"].ToString());
            l_acum = Srelib.PadDouble(Ds.Tables[0].Rows[0]["l_acum"].ToString());
            l_acumdp = Srelib.PadDouble(Ds.Tables[0].Rows[0]["l_acumdp"].ToString());
            l_acumch = Srelib.PadDouble(Ds.Tables[0].Rows[0]["l_acumch"].ToString());
            l_sac = Srelib.PadDouble(Ds.Tables[0].Rows[0]["l_sac"].ToString());
            l_sacdp = Srelib.PadDouble(Ds.Tables[0].Rows[0]["l_sacdp"].ToString());
            l_sacch = Srelib.PadDouble(Ds.Tables[0].Rows[0]["l_sacch"].ToString());
            vencimento = Srelib.PadData(Ds.Tables[0].Rows[0]["vencimento"].ToString());
            l_nconf = Srelib.PadDouble(Ds.Tables[0].Rows[0]["l_nconf"].ToString());
            limitech = Srelib.PadDouble(Ds.Tables[0].Rows[0]["limitech"].ToString());
            pconfir = Srelib.PadDouble(Ds.Tables[0].Rows[0]["pconfir"].ToString());
            cnpjmin = Srelib.PadDouble(Ds.Tables[0].Rows[0]["cnpjmin"].ToString());
            prazomin = Ds.Tables[0].Rows[0]["prazomin"].ToString();
            prazomax = Ds.Tables[0].Rows[0]["prazomax"].ToString();
            fixacao = Srelib.PadData(Ds.Tables[0].Rows[0]["dlimite"].ToString());
            tdesc = Srelib.PadDouble(Ds.Tables[0].Rows[0]["tdesc"].ToString());
            txserv = Srelib.PadDouble(Ds.Tables[0].Rows[0]["txserv"].ToString());


        }
    }


    [DataObjectMethod(DataObjectMethodType.Select)]
    public DataSet LiquidezCedente(String wcedente, Boolean zgrupo1, Boolean zgrupo2, Boolean zgrupo3, Boolean zgrupo4, String zrgtipo)
    {
        String sql = "WW_LIQUIDEZ";
        SqlParameter[] param = { new SqlParameter("@cedente", wcedente),
                                      new SqlParameter("@zgrupo1", zgrupo1) ,
                                      new SqlParameter("@zgrupo2", zgrupo2) ,
                                      new SqlParameter("@zgrupo3", zgrupo3) ,
                                      new SqlParameter("@zgrupo4", zgrupo4) ,
                                      new SqlParameter("@rgtipo", Convert.ToInt16(zrgtipo))
                               };
        DataSet DsL = SreDblib.GetDsSp(sql, param);
        return DsL;
    }


    [DataObjectMethod(DataObjectMethodType.Select)]
    public DataSet AtualizaSaldoBancario()
    {
        String sql = @"select b.apelido, ISNULL((select sum(valor) from lanca_cc WITH(NOLOCK) 
                       where conta = b.apelido and conciliado = 1) + 
                       isnull((select top 1 saldo_fechamento from saldos_conta s WITH(NOLOCK) 
                       where s.apelido = b.apelido order by data),0.00),0.00) as saldo, 
                       (select count(conta) from aplicacoes AP WITH(NOLOCK) where b.apelido=ap.conta) as aplicacoes 
                       from bancos b WITH(NOLOCK), lanca_cc WITH(NOLOCK), saldos_conta WITH(NOLOCK) 
                       where b.ativa = 1 
                       group by b.apelido";
        DataSet Ds = SreDblib.GetDsScript(sql);
        return Ds;
    }

    [DataObjectMethod(DataObjectMethodType.Select)]
    public DataSet AtualizaMaioresRiscos(String wcedente,Boolean zgrupo1, Boolean zgrupo2, Boolean zgrupo3, Boolean zgrupo4, String zrgtipo)
    {
        String sql = "WW_PEGAMAIORESRISCOS_CEDENTE";
        SqlParameter[] parametros = { new SqlParameter("@cedente", wcedente) ,
                                      new SqlParameter("@zgrupo1", zgrupo1) ,
                                      new SqlParameter("@zgrupo2", zgrupo2),
                                      new SqlParameter("@zgrupo3", zgrupo3),
                                      new SqlParameter("@zgrupo4", zgrupo4),
                                      new SqlParameter("@rgtipo",  Convert.ToInt16(zrgtipo))
                                    };
        DataSet Ds = SreDblib.GetDsSp(sql, parametros);
       return Ds;
    }

    [DataObjectMethod(DataObjectMethodType.Select)]
    public DataSet AtualizaMaioresRiscosDet(String wcedente, Boolean zgrupo1, Boolean zgrupo2, Boolean zgrupo3, Boolean zgrupo4, String zrgtipo, String tipo, String risco, String chave)
    {
        String sql = "WW_PEGAMAIORESRISCOS_CEDENTE_DET";
        SqlParameter[] parametros = { new SqlParameter("@cedente", wcedente) ,
                                      new SqlParameter("@zgrupo1", zgrupo1) ,
                                      new SqlParameter("@zgrupo2", zgrupo2),
                                      new SqlParameter("@zgrupo3", zgrupo3),
                                      new SqlParameter("@zgrupo4", zgrupo4),
                                      new SqlParameter("@rgtipo",  Convert.ToInt16(zrgtipo)),
                                      new SqlParameter("@tipo",  Convert.ToInt16(tipo)),
                                      new SqlParameter("@risco", Convert.ToDouble(risco)),
                                      new SqlParameter("@chave", chave)
                                    };
        DataSet Ds = SreDblib.GetDsSp(sql, parametros);
        return Ds;
    }




    [DataObjectMethod(DataObjectMethodType.Select)]
    public DataSet AtualizaAplicacoes(String wconta)
    {
        String sql = "WW_PEGAAPLICACOES";
        SqlParameter[] parametros = { new SqlParameter("@CONTA", wconta) };
        DataSet Ds = SreDblib.GetDsSp(sql, parametros);
        return Ds;
    }

    
    [DataObjectMethod(DataObjectMethodType.Select)]
    public DataSet PegaCriticas(Int32 sequencial)
    {
        SqlParameter[] parametros = { new SqlParameter("@zsequencial", sequencial) };

        String sql = @"SELECT C.DATA, C.CODIGO, D.DESCRICAO, C.OBS 
                      FROM CRITICAS C with(nolock), 
                      CODCRITI D with(nolock), 
                      titulo t with(nolock) 
                      WHERE C.CODIGO=D.CODIGO AND 
                      t.empresa = c.empresa and
                      t.cedente = c.cedente and
                      t.tipo_operacao = c.tipo_operacao and
                      t.bordero = c.bordero and
                      t.duplicata = c.duplicata and
                      t.banco = c.banco and
                      t.agencia = c.agencia and
                      t.conta = c.conta and
                      t.cheque = c.cheque and
                      D.ATIVO=1 AND 
                      t.sequencial=@zsequencial 
                      order by c.data desc, c.id desc";
        DataSet Ds = SreDblib.GetDsCp(sql,parametros);
        return Ds;
    }
    

    [DataObjectMethod(DataObjectMethodType.Select)]
    public DataSet PegaConfirmacoes(String wcedente, 
                                    String ctipo, 
                                    DateTime ddata, 
                                    String ordena,
                                    Boolean zgrupo1, Boolean zgrupo2, Boolean zgrupo3, Boolean zgrupo4, Int16 zrgtipo)
    {
        DateTime DataAtual = Redoma.Proximo_Dia_Util(uFechamento.PegaUltimaData());


        String sql="";

        if (ctipo == "N")
        {
            sql = "CRTOTCEDNC";
        }

        if (ctipo == "NC")
        {
            sql = "CRTOTCEDNCC";
        }

        if (ctipo == "OP")
        {
            sql = "CRTOTCEDOP";
        }

        if (ctipo == "OPC")
        {
            sql = "CRTOTCEDOPC";
        }

        if (ctipo == "NN")
        {
            sql = "CRTOTCEDX";
        }

        if (ctipo == "NNC")
        {
            sql = "CRTOTCEDXC";
        }


        SqlParameter[] parametros = { 
                                      new SqlParameter("@cedente", wcedente),
                                      new SqlParameter("@zgrupo1", zgrupo1),
                                      new SqlParameter("@zgrupo2", zgrupo2),
                                      new SqlParameter("@zgrupo3", zgrupo3),
                                      new SqlParameter("@zgrupo4", zgrupo4),
                                      new SqlParameter("@rgtipo", zrgtipo),
                                      new SqlParameter("@dataatual", DataAtual),
                                      new SqlParameter("@tipo", ctipo),
                                      new SqlParameter("@ddata", ddata),
                                      new SqlParameter("@ordena", ordena)
                                    };

        DataSet Ds = SreDblib.GetDsSp(sql, parametros);

        return Ds;
    }


    [DataObjectMethod(DataObjectMethodType.Select)]
    public DataSet PegaVencidos(String wcedente, String ctipo, DateTime ddata,
        Boolean zgrupo1, Boolean zgrupo2, Boolean zgrupo3, Boolean zgrupo4, Int16 zrgtipo)
    {
        DateTime DataAtual = Redoma.Proximo_Dia_Util(uFechamento.PegaUltimaData());


        String sql = "";

        sql = "CRTOTCEDA";


        SqlParameter[] parametros = { 
                                      new SqlParameter("@cedente", wcedente),
                                      new SqlParameter("@zgrupo1", zgrupo1),
                                      new SqlParameter("@zgrupo2", zgrupo2),
                                      new SqlParameter("@zgrupo3", zgrupo3),
                                      new SqlParameter("@zgrupo4", zgrupo4),
                                      new SqlParameter("@rgtipo", zrgtipo),
                                      new SqlParameter("@dataatual", DataAtual),
                                      new SqlParameter("@tipo", ctipo),
                                      new SqlParameter("@ddata", ddata)
                                    };

        DataSet Ds = SreDblib.GetDsSp(sql, parametros);

        return Ds;
    }


	public static ASPxComboBox MontaComboCedente(ASPxComboBox pCombo)
	{

        return SreDblib.MontaCombo(pCombo, "Cedente", "apelido", "apelido", false, "");

	}

	public static String PegaNome(string xced)
	{
		string script = "SELECT nome FROM Cedente WITH(NOLOCK) WHERE apelido = " + Srelib.QStr(xced);
		try
		{
			return SreDblib.GetCampoScript(script);
		}
		catch
		{
			return " ";
		}

	}

	public static String PegaCnpj(string xced)
	{
		string script = "SELECT cnpj FROM Cedente WITH(NOLOCK) WHERE apelido = " + Srelib.QStr(xced);
		try
		{
			return SreDblib.GetCampoScript(script);
		}
		catch
		{
			return " ";
		}

	}

    public static ASPxComboBox MontaComboLookUp_Ger(ASPxComboBox pCombo, Boolean lMaster, String ccUsuario, Boolean ativo, Boolean semfidc)
    {

        string pTabela = "Cedente";
        string pCampoExibe = "apelido";
        string pCampoValor = "apelido";
        Boolean pExibeValor = false;

        String script = "SELECT " + pCampoExibe + "," + pCampoValor + " FROM " + pTabela + " WITH(NOLOCK) WHERE tipocedente<>1";
        if (ativo)
        {
            script = script + " and ativo=1";
        }
        if (!lMaster)
        {
            script = script + " and dbo.vecedente(apelido," + Srelib.QStr(ccUsuario) + ")=1 ";
        }
        if (semfidc)
        {
            script = script + " and cedentefidc<>1";
        }
        script = script + " ORDER BY apelido";

        DataSet ds = SreDblib.GetDsScript(script);
        ListEditItem le;
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            le = new ListEditItem();
            if (pExibeValor)
            {
                le.Text = dr[pCampoValor].ToString() + " - " + dr[pCampoExibe].ToString();
            }
            else
            {
                le.Text = dr[pCampoExibe].ToString();
            };
            le.Value = dr[pCampoValor].ToString();
            pCombo.Items.Add(le);
        }
        return pCombo;
    }

    public static DataSet LookUpCedente_Ger(Boolean lMaster, String ccUsuario, Boolean ativo, Boolean semfidc)
    {
        String script = "SELECT apelido FROM cedente WITH(NOLOCK) WHERE tipocedente<>1";
        if (ativo)
        {
            script = script + " and ativo=1";
        }
        if (!lMaster)
        {
            script = script + " and dbo.vecedente(apelido," + Srelib.QStr(ccUsuario) + ")=1 ";
        }
        if (semfidc)
        {
            script = script + " and cedentefidc<>1";
        }
        script = script + " ORDER BY apelido";

        return SreDblib.GetDsScript(script);
    }
    
    public uCedente()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
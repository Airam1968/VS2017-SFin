using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.ComponentModel;

/// <summary>
/// Summary description for uGerente
/// </summary>
/// 

[DataObject()]
public class uGerente
{
    public String nome;
    public String apelido;


    [DataObjectMethod(DataObjectMethodType.Select)]
    public DataSet PegaVencidos(String wgerente, String ctipo, DateTime ddata,
        Boolean zgrupo1, Boolean zgrupo2, Boolean zgrupo3, Boolean zgrupo4, Int16 zrgtipo)
    {
        DateTime DataAtual = Redoma.Proximo_Dia_Util(uFechamento.PegaUltimaData());


        String sql = "";

        sql = "ww_CRTOTCEDA_gerente";


        SqlParameter[] parametros = { 
                                      new SqlParameter("@gerente", wgerente),
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



    [DataObjectMethod(DataObjectMethodType.Select)]
    public DataSet PegaConfirmacoes(String wgerente,
                                    String ctipo,
                                    DateTime ddata,
                                    String ordena,
                                    Boolean zgrupo1, Boolean zgrupo2, Boolean zgrupo3, Boolean zgrupo4, Int16 zrgtipo)
    {
        DateTime DataAtual = Redoma.Proximo_Dia_Util(uFechamento.PegaUltimaData());


        String sql = "";

        if (ctipo == "N")
        {
            sql = "ww_CRTOTCEDNC_gerente";
        }

        if (ctipo == "NC")
        {
            sql = "WW_CRTOTCEDNCC_GERENTE";
        }

        if (ctipo == "OP")
        {
            sql = "WW_CRTOTCEDOP_GERENTE";
        }

        if (ctipo == "OPC")
        {
            sql = "WW_CRTOTCEDOPC_GERENTE";
        }

        if (ctipo == "NN")
        {
            sql = "WW_CRTOTCEDX_GERENTE";
        }

        if (ctipo == "NNC")
        {
            sql = "WW_CRTOTCEDXC_GERENTE";
        }


        SqlParameter[] parametros = { 
                                      new SqlParameter("@gerente", wgerente),
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



     public void PegaDadosDoGerente(String wgerente)
     {
        String sql = @"Select apelido,nome from gerente where apelido=@gerente";
        SqlParameter[] parametros = { new SqlParameter("@gerente", wgerente) };
        DataSet Ds = SreDblib.GetDsCp(sql, parametros);
        // dados
        apelido = "";
        nome = "";
        if (Ds.Tables.Count > 0)
        {
            apelido = Ds.Tables[0].Rows[0]["apelido"].ToString();
            nome = Ds.Tables[0].Rows[0]["nome"].ToString();
        }
     }

    [DataObjectMethod(DataObjectMethodType.Select)]
    public DataSet LiquidezGerente(String wgerente, Boolean zgrupo1, Boolean zgrupo2, Boolean zgrupo3, Boolean zgrupo4, String zrgtipo)
    {
        String sql = "WW_LIQUIDEZ_GERENTE";
        SqlParameter[] param = { new SqlParameter("@gerente", wgerente),
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
    public DataSet AtualizaMaioresRiscos(String wgerente, Boolean zgrupo1, Boolean zgrupo2, Boolean zgrupo3, Boolean zgrupo4, String zrgtipo)
    {
        String sql = "WW_PEGAMAIORESRISCOS_GERENTE";
        SqlParameter[] parametros = { new SqlParameter("@gerente", wgerente) ,
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
    public DataSet AtualizaMaioresRiscosDet(String wgerente, Boolean zgrupo1, Boolean zgrupo2, Boolean zgrupo3, Boolean zgrupo4, String zrgtipo, String tipo, String risco, String chave)
    {
        String sql = "WW_PEGAMAIORESRISCOS_GERENTE_DET";
        SqlParameter[] parametros = { new SqlParameter("@gerente", wgerente) ,
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


    public static ASPxComboBox MontaComboGerente(ASPxComboBox pCombo)
	{
        return SreDblib.MontaCombo(pCombo, "Gerente", "apelido", "apelido", false, "");
	}

    public static ASPxComboBox MontaComboGerenteCred(ASPxComboBox pCombo, Boolean lMaster, String ccUsuario, Boolean ativo)
    {
        String script = "SELECT apelido FROM gerente WITH(NOLOCK) WHERE 1=1 ";

        if (SreDblib.GetParametro("PESQ_GER_INATIVOS") != "SIM")
        {
            script = script + "and ativo = 1";
        }
        if (!lMaster)
        {
            script = script + "and apelido in (SELECT gerente FROM ger_usu WITH(NOLOCK) WHERE usuario=" + Srelib.QStr(ccUsuario) + ")";
        }
        script = script + "ORDER BY apelido";

        DataSet ds = SreDblib.GetDsScript(script);
        ListEditItem le;
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            le = new ListEditItem();
            le.Text = dr["apelido"].ToString();
            le.Value = dr["apelido"].ToString();
            pCombo.Items.Add(le);
        }
        return pCombo;
    }

    public static DataSet LookUpGerente_Cred(Boolean lMaster, String ccUsuario, Boolean ativo)
    {
        String script = "SELECT apelido FROM gerente WITH(NOLOCK) WHERE 1=1 ";

        if (SreDblib.GetParametro("PESQ_GER_INATIVOS") != "SIM")
        {
            script = script + "and ativo = 1";
        }
        if (!lMaster)
        {
            script = script + "and apelido in (SELECT gerente FROM ger_usu WITH(NOLOCK) WHERE usuario=" + Srelib.QStr(ccUsuario) + ")";
        }
        script = script + "ORDER BY apelido";

        return SreDblib.GetDsScript(script);;
    }

    public static DataSet LookUpFcomiss()
    {
        String script = "SELECT * FROM fcomiss WITH(NOLOCK) WHERE 1=1 ";

        script = script + "ORDER BY recno";

        return SreDblib.GetDsScript(script); ;
    }

    public static ASPxListBox MontaListFullCkGerente(ASPxListBox pListBox)
    {
        //Documentação - Chamada da Função
        //
        //uEmpresa.MontaListFullCkEmpresa(ListBoxModelo);
        //
        //Todas as Caracteristicas do Combo são montadas na Classe, a chamada passa do combo vazio.
        //1o. Campo da Lista é um CheckBox
        //Setar SelectionMode para CheckColumn
        //Fim Documentação - Chamada da Função

        string pTabela = "Gerente";
        string pCampoExibe = "apelido";
        string pCampoValor = "apelido";
        Boolean pExibeValor = false;

        String script = "SELECT " + pCampoExibe + "," + pCampoValor + " FROM " + pTabela + " WITH(NOLOCK)";
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
            pListBox.Items.Add(le);
        }

        return pListBox;
    }


}
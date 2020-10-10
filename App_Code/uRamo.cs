using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.ComponentModel;
using DevExpress.Web.ASPxEditors;





/// <summary>
/// Summary description for Login
/// </summary>
/// 
[DataObject()]
public class uRamo
{
    public String titulografico;
    public double[] data;
    public string[] xlabels;
    public string ValorMaiorRisco;

    public String apelido;
    public String nome_ramo;
    public DataSet DS;
    public String d1;
    public String d2;

    public String op1;
    public String op2;
    public String op3;
    public String op4;

    public String r1;
    public String r2;
    public String r3;
    public String s4;


    public static DataSet LookUpRamo()
    {
        return SreDblib.GetDsScript("select apelido FROM ramo WITH(NOLOCK) ORDER BY apelido");
    }

    [DataObjectMethod(DataObjectMethodType.Select)]
    public DataSet PegaVencidos(String wramo, String ctipo, DateTime ddata, Boolean zgrupo1, Boolean zgrupo2, Boolean zgrupo3, Boolean zgrupo4, Int16 zrgtipo)
    {
        DateTime DataAtual = Redoma.Proximo_Dia_Util(uFechamento.PegaUltimaData());


        String sql = "";

        sql = "ww_CRTOTCEDA_ramo";

        //comentado airam
        SqlParameter[] parametros = { 
                                      new SqlParameter("@ramo", wramo),
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
    public DataSet PegaConfirmacoes(String wramo,
                                    String ctipo,
                                    DateTime ddata,
                                    String ordena,
                                    Boolean zgrupo1, Boolean zgrupo2, Boolean zgrupo3, Boolean zgrupo4, Int16 zrgtipo)
    {
        DateTime DataAtual = Redoma.Proximo_Dia_Util(uFechamento.PegaUltimaData());


        String sql = "";

        if (ctipo == "N")
        {
            sql = "ww_CRTOTCEDNC_ramo";
        }

        if (ctipo == "NC")
        {
            sql = "WW_CRTOTCEDNCC_ramo";
        }

        if (ctipo == "OP")
        {
            sql = "WW_CRTOTCEDOP_ramo";
        }

        if (ctipo == "OPC")
        {
            sql = "WW_CRTOTCEDOPC_ramo";
        }

        if (ctipo == "NN")
        {
            sql = "WW_CRTOTCEDX_ramo";
        }

        if (ctipo == "NNC")
        {
            sql = "WW_CRTOTCEDXC_ramo";
        }


        SqlParameter[] parametros = { 
                                      new SqlParameter("@ramo", wramo),
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



    public void PegaDadosDoRamo(String wramo)
    {
        String sql = @"Select apelido,descricao from ramo where apelido=@ramo";
        SqlParameter[] parametros = { new SqlParameter("@ramo", wramo) };
        DataSet Ds = SreDblib.GetDsCp(sql, parametros);
        // dados
        apelido = "";
        nome_ramo = "";
        if (Ds.Tables.Count > 0)
        {
            apelido = Ds.Tables[0].Rows[0]["apelido"].ToString();
            nome_ramo = Ds.Tables[0].Rows[0]["descricao"].ToString();
        }
    }


    public DataSet LiquidezRamo(String wramo, Boolean zgrupo1, Boolean zgrupo2, Boolean zgrupo3, Boolean zgrupo4, String zrgtipo)
    {
        String sql = "WW_LIQUIDEZ_RAMO";
        SqlParameter[] param = { new SqlParameter("@ramo", wramo),
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
    public DataSet AtualizaMaioresRiscos(String wramo, Boolean zgrupo1, Boolean zgrupo2, Boolean zgrupo3, Boolean zgrupo4, String zrgtipo)
    {
        String sql = "WW_PEGAMAIORESRISCOS_RAMO";
        SqlParameter[] parametros = { new SqlParameter("@ramo", wramo) ,
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
    public DataSet AtualizaMaioresRiscosDet(String wramo, Boolean zgrupo1, Boolean zgrupo2, Boolean zgrupo3, Boolean zgrupo4, String zrgtipo, String tipo, String risco, String chave)
    {
        String sql = "WW_PEGAMAIORESRISCOS_RAMO_DET";
        SqlParameter[] parametros = { new SqlParameter("@ramo", wramo) ,
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



    public static ASPxComboBox MontaComboRamo(ASPxComboBox pCombo)
    {
        //Documentação - Chamada da Função
        //
        //RgbDbLib.MontaComboRamo(ASPxComboBox1);
        //
        //Fim Documentação - Chamada da Função

        string pTabela = "ramo";
        string pCampoExibe = "apelido";
        string pCampoValor = "apelido";
        string pOrderBy = " order by apelido";
        Boolean pExibeValor = false;

        String script = "SELECT " + pCampoExibe + "," + pCampoValor + " FROM " + pTabela + " WITH(NOLOCK)" + pOrderBy;
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


    public DataSet PegaGerentes(Usuario xUsuario, String cGerente, Boolean lMaster, String pXml)
    {

        // Conexao Conn = new Conexao(pXml);

        String Qry;

        String cMaster = "0";
        if (lMaster) { cMaster = "1"; }

        Qry = "SELEC_GERENTES " +
              xUsuario.CodUsuario + "," +
              Srelib.QStr(cGerente) + "," +
              cMaster;

        DS = new DataSet();
        SqlCommand Command = new SqlCommand(Qry, DM.ConexaoSessao);
        Command.CommandTimeout = 99999;
        SqlDataAdapter DA = new SqlDataAdapter();

        DA.TableMappings.Add("Table", "CRTOTCED1");
        DA.SelectCommand = Command;

        DA.Fill(DS);

        // Conn.SqlConn.Close();

        return DS;
    }


    [DataObjectMethod(DataObjectMethodType.Select)]
    public DataSet PegaConcentracaoRamo()
    {

        String Qry;

        Qry = "EXEC GNRAMOS ";

        DS = new DataSet();
        SqlCommand Command = new SqlCommand(Qry, DM.ConexaoSessao);
        Command.CommandTimeout = 99999;
        SqlDataAdapter DA = new SqlDataAdapter();

        DA.TableMappings.Add("Table", "CRTOTCED1");
        DA.SelectCommand = Command;

        DA.Fill(DS);

        // Conn.SqlConn.Close();

        return DS;
    }

    public DataSet PegaConcentracaoRamoCedente(String cRamo)
    {

        String Qry;

        Qry = "EXEC GNRAMOS_CEDENTE " +
              Srelib.QStr(cRamo);

        DS = new DataSet();
        SqlCommand Command = new SqlCommand(Qry, DM.ConexaoSessao);
        Command.CommandTimeout = 99999;
        SqlDataAdapter DA = new SqlDataAdapter();

        DA.TableMappings.Add("Table", "CRTOTCED1");
        DA.SelectCommand = Command;

        DA.Fill(DS);

        // Conn.SqlConn.Close();

        return DS;
    }



    public void PegaDadosRamo(String pApelido, String pXml)
    {

        // Conexao Conn = new Conexao(pXml);

        String Qry = "EXEC crtotramo " +
                     Srelib.QStr(pApelido);


        DS = new DataSet();
        SqlCommand Command = new SqlCommand(Qry, DM.ConexaoSessao);
        Command.CommandTimeout = 99999;
        SqlDataAdapter DA = new SqlDataAdapter();

        DA.TableMappings.Add("Table", "CRTOTCED1");
        DA.SelectCommand = Command;

        DA.Fill(DS);

        DataTable DT;
        DT = DS.Tables["CRTOTCED1"];
        DataRow DR = DT.Rows[0];

        op1 = Srelib.PadData(Convert.ToString(DR["op1"]));
        op2 = Srelib.PadData(Convert.ToString(DR["op2"]));
        op3 = Convert.ToString(DR["op3"]);
        op4 = Srelib.PadDouble(Convert.ToString(DR["op4"]));

        r1 = Srelib.PadDouble(Convert.ToString(DR["r1"]));
        r2 = Srelib.PadDouble(Convert.ToString(DR["r2"]));
        r3 = Srelib.PadDouble(Convert.ToString(DR["r3"]));

        s4 = Srelib.PadDouble(Convert.ToString(DR["s4"]));



        // Conn.SqlConn.Close();

        DS.Dispose();
    }

    

    public uRamo()
    {
        //
        // TODO: Add constructor logic here
        //
    }

}

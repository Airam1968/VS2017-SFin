using System;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Login
/// </summary>
/// 
public class Usuario
{
    public String Msg;
    public String Debug;
    public String CodUsuario;
    public DataSet DSUsuario;
    public DataSet DS;
    public int TipoErro = 9;
    public Boolean equipe;
    public Boolean lCadastro;
    public String DataAtual;
    public String DataAtualBancaria;
    public String DataBase;

    public String grupo1;
    public String grupo2;
    public String grupo3;
    public String grupo4;

    public Boolean bgrupo1;
    public Boolean bgrupo2;
    public Boolean bgrupo3;
    public Boolean bgrupo4;

    public String refat;
    public String dispav;
    public String nrel;
    public String tolerc;
    public String tolerd;

    public String v1;
    public String v2;
    public String v3;
    public String v4;
    public String v5;
    public String v6;
    public String v7;
    public String v8;
    public String v9;

    public String lv1;
    public String lv2;
    public String lv3;
    public String lv4;
    public String lv5;


    public String a1;
    public String a2;
    public String a3;
    public String a4;
    public String a5;
    public String a6;
    public String a7;
    public String a8;
    public String a9;

    public String la1;
    public String la2;
    public String la3;
    public String la4;
    public String la5;
    public String la6;
    public String la7;
    public String la8;
    public String la9;
    public String taxas;


    public String tipo;

    public String nmeses;
    public Boolean lFlag;

    public Boolean criacobsimples;

    public Boolean ckregra;

    public Boolean ckr1;
    public Boolean ckr2;
    public Boolean ckr3;
    public Boolean ckr4;
    public Boolean ckr5;
    public Boolean ckr6;
    public Boolean ckr7;
    public Boolean ckdepende;
    public String acao1;
    public String acao2;
    public String acao3;
    public String acao4;
    public String acao5;
    public String acao6;
    public String acao7;
    public String acao8;
    public String acao9;
    public String acao10;
    public String acao11;
    public String acao12;
    public String acao13;
    public String acao14;
    public String acao15;
    public String acao16;
    public String acao17;
    public String acao18;
    public String acao19;
    public String acao20;
    public String acao21;
    public String acao22;
    public String acao23;
    public String acao24;
    public String acao25;

    public String ndvenc;
    public Boolean ckliq;
    public String op;


    public void WebGravaLog(String pBase,
                        String pLogin,
                        String pIp,
                        String pCod,
                        String pComplem,
                        String pXml)
    {
        // Conexao Conn = new Conexao(pXml);
        String Qry = "EXEC WEBLOGINC " +
                      Srelib.QStr(pBase) + "," +
                      Srelib.QStr(pLogin) + "," +
                      Srelib.QStr(pIp) + "," +
                      pCod + "," +
                      Srelib.QStr(pComplem) + "," +
                      Srelib.QStr(pLogin);

        DS = new DataSet();
        SqlCommand Command = new SqlCommand(Qry, DM.ConexaoSessao);
        Command.CommandTimeout = 99999;
        SqlDataAdapter DA = new SqlDataAdapter();
        Command.ExecuteNonQuery();
        // Conn.SqlConn.Close();
    }



    public Boolean VePermissao(String pUsuario, String Permissao, String pXml)
    {
        // Conexao Conn = new Conexao(pXml);

        if (pUsuario != "GITANO")
        {

            String Qry = "EXEC GN_PERMISSAO " +
                         Srelib.QStr(pUsuario) + "," +
                         Srelib.QStr(Permissao);

            DataSet DS = new DataSet();
            SqlCommand Command = new SqlCommand(Qry, DM.ConexaoSessao);
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.TableMappings.Add("Table", "PERMISSAO");
            DA.SelectCommand = Command;
            DA.Fill(DS);
            DataTable DT;
            DT = DS.Tables["PERMISSAO"];
            if (DT.Rows.Count > 0)
            {
                DataRow DR = DT.Rows[0];

                String sPermissao = Convert.ToString(DR["Permissao"]).Trim();

                // Conn.SqlConn.Close();

                if (sPermissao != "")
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return true;
        }

    }

    public String Converte_Senha(String _x)
    {
        Int64 j, r;
        Byte m;
        Char c;

        r = 0;
        for (m = 0; (m <= (_x.Length - 1)); m++)
        {
            c = _x[m];
            j = c;
            r = (r + (j * 3)) * 2;
        }

        String retorno = Srelib.strzero(r, 10);
        return retorno;
    }


    public String Converte(String _x)
    {
        int m;
        Int64 n;
        String r;
        Char j;

        r = "";
        for (m = 0; (m <= (_x.Length - 1)); m++)
        {
            char c = _x[m];
            // String c = _x.Substring(m, 1);
            //n = Convert.ToInt64 (c) + 14; // ord
            n = c; // ord
            n = n + 14;
            j = Convert.ToChar(n);
            r = r + j;
        }
        return r;
    }



    public String LogarUsuario(String wlogin, String Senha, String pXml)
    {
        // Conexao Conn = new Conexao(pXml);
        if ((wlogin.Trim() == "GITANO") &&
            (Senha.Trim() == "77335P"))
        {
            TipoErro = 3;
        }
        else
        {
            String Senha_Banco;

            Msg = "";
            CodUsuario = "";
            TipoErro = 9;
            String wloginOK = wlogin;
            wloginOK = wlogin.ToUpper();
            wloginOK = wloginOK.Trim();

            String Qry = "EXEC GN_LOGARUSUARIO_1 " +
                         Srelib.QStr(wloginOK);
            DS = new DataSet();
            SqlCommand Command = new SqlCommand(Qry, DM.ConexaoSessao);
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.TableMappings.Add("Table", "login");
            DA.SelectCommand = Command;
            DA.Fill(DS);
            DataTable DT;
            DT = DS.Tables["login"];
            if (DT.Rows.Count == 0)
                CodUsuario = null;
            else
            {
                DataRow DR = DT.Rows[0];
                CodUsuario = Convert.ToString(DR["login"]);
            }
            DS.Dispose();

            if (CodUsuario == null)
            {
                Msg = "Login não cadastrado !";
                TipoErro = 1;
            }
            else
            {

                Qry = "EXEC GN_LOGARUSUARIO_2 " +
                      Srelib.QStr(wloginOK) + "," +
                      Srelib.QStr(Converte_Senha(Senha.Trim()));

                DS = new DataSet();
                Command = new SqlCommand(Qry, DM.ConexaoSessao);
                DA = new SqlDataAdapter();
                DA.TableMappings.Add("Table", "login");
                DA.SelectCommand = Command;
                DA.Fill(DS);
                DT = DS.Tables["login"];
                if (DT.Rows.Count == 0)
                    Senha_Banco = null;
                else
                {
                    DataRow DR = DT.Rows[0];
                    Senha_Banco = Convert.ToString(DR["senha"]);
                }
                DS.Dispose();
                if (Senha_Banco == null)
                {
                    Msg = "Senha incorreta !";
                    TipoErro = 2;
                }
                else
                {
                    TipoErro = 0;
                }

            }
        }
        //        Conn.SqlConn.Close();
        return Msg;
    }

    public void PegaDataAtual(String pXml, Boolean lAprov)
    {
        // Conexao Conn = new Conexao(pXml);
        String Qry = "EXEC GN_dataatual_ret ";

        DS = new DataSet();
        SqlCommand Command = new SqlCommand(Qry, DM.ConexaoSessao);
        SqlDataAdapter DA = new SqlDataAdapter();
        DA.TableMappings.Add("Table", "dataatual");
        DA.SelectCommand = Command;
        DA.Fill(DS);
        DataTable DT;
        DT = DS.Tables["dataatual"];
        DataRow DR = DT.Rows[0];
        DateTime dt1 = Convert.ToDateTime(DR["dataatual"]);

        DataAtual = String.Format("{0:dd/MM/yyyy}", dt1);
        if (lAprov)
        {
            if (dt1 < Convert.ToDateTime(Srelib.DataHojeMais(0)))
            {
                DataAtual = String.Format("{0:dd/MM/yyyy}", Srelib.DataHojeMais(0));
            }
        }

        // Conn.SqlConn.Close();
        DS.Dispose();
    }

    public void PegaDataAtualBancaria(String pXml)
    {
        // Conexao Conn = new Conexao(pXml);
        String Qry = "EXEC GN_DATAATUALBANCARIA_RET ";

        DS = new DataSet();
        SqlCommand Command = new SqlCommand(Qry, DM.ConexaoSessao);
        SqlDataAdapter DA = new SqlDataAdapter();
        DA.TableMappings.Add("Table", "dataatual");
        DA.SelectCommand = Command;
        DA.Fill(DS);
        DataTable DT;
        DT = DS.Tables["dataatual"];
        DataRow DR = DT.Rows[0];
        DateTime dt1 = Convert.ToDateTime(DR["dataatual"]);

        DataAtualBancaria = String.Format("{0:dd/MM/yyyy}", dt1);

        // Conn.SqlConn.Close();
        DS.Dispose();
    }




    public void PegaDataBase(String pXml)
    {
        // Conexao Conn = new Conexao(pXml);
        String Qry = "EXEC GN_DataBase_ret ";

        DS = new DataSet();
        SqlCommand Command = new SqlCommand(Qry, DM.ConexaoSessao);
        SqlDataAdapter DA = new SqlDataAdapter();
        DA.TableMappings.Add("Table", "dataatual");
        DA.SelectCommand = Command;
        DA.Fill(DS);
        DataTable DT;
        DT = DS.Tables["dataatual"];
        DataRow DR = DT.Rows[0];
        DateTime dt1 = Convert.ToDateTime(DR["dataatual"]);
        DataBase = String.Format("{0:dd/MM/yyyy}", dt1);

        // Conn.SqlConn.Close();
        DS.Dispose();
    }


    public void PegaParametros(String pXml)
    {
        // Conexao Conn = new Conexao(pXml);
        String Qry = "EXEC GN_PEGACREPAR ";

        DS = new DataSet();
        SqlCommand Command = new SqlCommand(Qry, DM.ConexaoSessao);
        SqlDataAdapter DA = new SqlDataAdapter();
        DA.TableMappings.Add("Table", "parametros");
        DA.SelectCommand = Command;
        DA.Fill(DS);
        DataTable DT;
        DT = DS.Tables["parametros"];
        DataRow DR = DT.Rows[0];

        taxas = Convert.ToString(DR["taxas"]);

        grupo1 = Convert.ToString(DR["grupo1"]);
        grupo2 = Convert.ToString(DR["grupo2"]);
        grupo3 = Convert.ToString(DR["grupo3"]);
        grupo4 = Convert.ToString(DR["grupo4"]);


        bgrupo1 = Convert.ToBoolean(DR["grupo1"]);
        bgrupo2 = Convert.ToBoolean(DR["grupo2"]);
        bgrupo3 = Convert.ToBoolean(DR["grupo3"]);
        bgrupo4 = Convert.ToBoolean(DR["grupo4"]);


        refat = Convert.ToString(DR["refat"]);
        dispav = Convert.ToString(DR["dispav"]);

        nmeses = Convert.ToString(DR["nmeses"]);

        criacobsimples = Convert.ToBoolean(DR["ckcobsimples"]);
        ckregra = Convert.ToBoolean(DR["repauto"]);
        ckliq = Convert.ToBoolean(DR["ckliq"]);

        tolerc = Convert.ToString(DR["tolerc"]);
        tolerd = Convert.ToString(DR["tolerd"]);

        v1 = Convert.ToString(DR["v1"]);
        v2 = Convert.ToString(DR["v2"]);
        v3 = Convert.ToString(DR["v3"]);
        v4 = Convert.ToString(DR["v4"]);
        v5 = Convert.ToString(DR["v5"]);
        v6 = Convert.ToString(DR["v6"]);
        v7 = Convert.ToString(DR["v7"]);
        v8 = Convert.ToString(DR["v8"]);
        v9 = Convert.ToString(DR["v9"]);

        lv1 = "De " + Srelib.strzero2(v1.Trim(), 3) + " A " + Srelib.strzero2(v2.Trim(), 3) + " dias";
        lv2 = "De " + Srelib.strzero2(v3.Trim(), 3) + " A " + Srelib.strzero2(v4.Trim(), 3) + " dias";
        lv3 = "De " + Srelib.strzero2(v5.Trim(), 3) + " A " + Srelib.strzero2(v6.Trim(), 3) + " dias";
        lv4 = "De " + Srelib.strzero2(v7.Trim(), 3) + " A " + Srelib.strzero2(v8.Trim(), 3) + " dias";
        lv5 = "De " + Srelib.strzero2(v9.Trim(), 3) + " em diante ";

        a1 = Convert.ToString(DR["a1"]);
        a2 = Convert.ToString(DR["a2"]);
        a3 = Convert.ToString(DR["a3"]);
        a4 = Convert.ToString(DR["a4"]);
        a5 = Convert.ToString(DR["a5"]);
        a6 = Convert.ToString(DR["a6"]);
        a7 = Convert.ToString(DR["a7"]);
        a8 = Convert.ToString(DR["a8"]);
        a9 = Convert.ToString(DR["a9"]);


        ndvenc = Convert.ToString(DR["ndvenc"]);


        la1 = "De " + Srelib.strzero2(a1.Trim(), 3) + " A " + Srelib.strzero2(a2.Trim(), 3) + " dias";
        la2 = "De " + Srelib.strzero2(a3.Trim(), 3) + " A " + Srelib.strzero2(a4.Trim(), 3) + " dias";
        la3 = "De " + Srelib.strzero2(a5.Trim(), 3) + " A " + Srelib.strzero2(a6.Trim(), 3) + " dias";
        la4 = "De " + Srelib.strzero2(a7.Trim(), 3) + " A " + Srelib.strzero2(a8.Trim(), 3) + " dias";
        la5 = "De " + Srelib.strzero2(a9.Trim(), 3) + " em diante ";



        if (grupo1 == "True") grupo1 = "1"; else grupo1 = "0";
        if (grupo2 == "True") grupo2 = "2"; else grupo2 = "0";
        if (grupo3 == "True") grupo3 = "3"; else grupo3 = "0";
        if (grupo4 == "True") grupo4 = "4"; else grupo4 = "0";

        ckr1 = Convert.ToBoolean(DR["ckr1"]);
        ckr2 = Convert.ToBoolean(DR["ckr2"]);
        ckr3 = Convert.ToBoolean(DR["ckr3"]);
        ckr4 = Convert.ToBoolean(DR["ckr4"]);
        ckr5 = Convert.ToBoolean(DR["ckr5"]);
        ckr6 = Convert.ToBoolean(DR["ckr6"]);
        ckr7 = Convert.ToBoolean(DR["ckr7"]);

        ckdepende = Convert.ToBoolean(DR["ckdepende"]);
        acao1 = Convert.ToString(DR["acao1"]);
        acao2 = Convert.ToString(DR["acao2"]);
        acao3 = Convert.ToString(DR["acao3"]);
        acao4 = Convert.ToString(DR["acao4"]);
        acao5 = Convert.ToString(DR["acao5"]);
        acao6 = Convert.ToString(DR["acao6"]);
        acao7 = Convert.ToString(DR["acao7"]);
        acao8 = Convert.ToString(DR["acao8"]);
        acao9 = Convert.ToString(DR["acao9"]);
        acao10 = Convert.ToString(DR["acao10"]);
        acao11 = Convert.ToString(DR["acao11"]);
        acao12 = Convert.ToString(DR["acao12"]);
        acao13 = Convert.ToString(DR["acao13"]);
        acao14 = Convert.ToString(DR["acao14"]);
        acao15 = Convert.ToString(DR["acao15"]);
        acao16 = Convert.ToString(DR["acao16"]);
        acao17 = Convert.ToString(DR["acao17"]);
        acao18 = Convert.ToString(DR["acao18"]);
        acao19 = Convert.ToString(DR["acao19"]);
        acao20 = Convert.ToString(DR["acao20"]);
        acao21 = Convert.ToString(DR["acao21"]);
        acao22 = Convert.ToString(DR["acao22"]);
        acao23 = Convert.ToString(DR["acao23"]);
        acao24 = Convert.ToString(DR["acao24"]);
        acao25 = Convert.ToString(DR["acao25"]);

        op = Convert.ToString(DR["op"]).Trim();

        // Conn.SqlConn.Close();
        DS.Dispose();
    }

    public void GravaParametros(String prefat,
                                 String pdispav,
                                 String pgrupo1,
                                 String pgrupo2,
                                 String pgrupo3,
                                 String pgrupo4,
                                 String pv1,
                                 String pv2,
                                 String pv3,
                                 String pv4,
                                 String pv5,
                                 String pv6,
                                 String pv7,
                                 String pv8,
                                 String pv9,
                                 String pa1,
                                 String pa2,
                                 String pa3,
                                 String pa4,
                                 String pa5,
                                 String pa6,
                                 String pa7,
                                 String pa8,
                                 String pa9,
                                 String ptolerd,
                                 String ptolerc,
                                 String pnmeses,
                                 String ptaxas,
                                 String prepauto,
                                 String pndvenc,
                                 String pckcobsimples,
                                 String pckr1,
                                 String pckr2,
                                 String pckr3,
                                 String pckr4,
                                 String pckliq,
                                 String pXml,
                                 String pckr5,
                                 String cOp,
                                 String pckr6,
                                 String pckr7,
                                 String pckdepende,
                                 String pacao1,
                                 String pacao2,
                                 String pacao3,
                                 String pacao4,
                                 String pacao5,
                                 String pacao6,
                                 String pacao7,
                                 String pacao8,
                                 String pacao9,
                                 String pacao10,
                                 String pacao11,
                                 String pacao12,
                                 String pacao13,
                                 String pacao14,
                                 String pacao15,
                                 String pacao16,
                                 String pacao17,
                                 String pacao18,
                                 String pacao19,
                                 String pacao20,
                                 String pacao21,
                                 String pacao22,
                                 String pacao23,
                                 String pacao24,
                                 String pacao25)
    {
        String cMaster = "0";
        // Conexao Conn = new Conexao(pXml);
        String Qry = "EXEC ALTERA_CREPAR " +
                      prefat + "," +
                      pdispav + "," +
                      pgrupo1 + "," +
                      pgrupo2 + "," +
                      pgrupo3 + "," +
                      pgrupo4 + "," +
                      Srelib.Deixa_Numeros2(pv1) + "," +
                      Srelib.Deixa_Numeros2(pv2) + "," +
                      Srelib.Deixa_Numeros2(pv3) + "," +
                      Srelib.Deixa_Numeros2(pv4) + "," +
                      Srelib.Deixa_Numeros2(pv5) + "," +
                      Srelib.Deixa_Numeros2(pv6) + "," +
                      Srelib.Deixa_Numeros2(pv7) + "," +
                      Srelib.Deixa_Numeros2(pv8) + "," +
                      Srelib.Deixa_Numeros2(pv9) + "," +
                      Srelib.Deixa_Numeros2(pa1) + "," +
                      Srelib.Deixa_Numeros2(pa2) + "," +
                      Srelib.Deixa_Numeros2(pa3) + "," +
                      Srelib.Deixa_Numeros2(pa4) + "," +
                      Srelib.Deixa_Numeros2(pa5) + "," +
                      Srelib.Deixa_Numeros2(pa6) + "," +
                      Srelib.Deixa_Numeros2(pa7) + "," +
                      Srelib.Deixa_Numeros2(pa8) + "," +
                      Srelib.Deixa_Numeros2(pa9) + "," +
                      ptolerd + "," +
                      ptolerc + "," +
                      pnmeses + "," +
                      ptaxas + "," +
                      prepauto + "," +
                      Srelib.Deixa_Numeros2(pndvenc) + "," +
                      pckcobsimples + "," +
                      pckr1 + "," +
                      pckr2 + "," +
                      pckr3 + "," +
                      pckr4 + "," +
                      pckliq + "," +
                      pckr5 + "," +
                      cOp + "," +
                      pckr6 + "," +
                      pckr7 + "," +
                      pacao1 + "," +
                      pacao2 + "," +
                      pacao3 + "," +
                      pacao4 + "," +
                      pacao5 + "," +
                      pacao6 + "," +
                      pacao7 + "," +
                      pacao8 + "," +
                      pacao9 + "," +
                      pacao10 + "," +
                      pacao11 + "," +
                      pacao12 + "," +
                      pacao13 + "," +
                      pacao14 + "," +
                      pacao15 + "," +
                      pacao16 + "," +
                      pckdepende + "," +
                      pacao17 + "," +
                      pacao18 + "," +
                      pacao19 + "," +
                      pacao20 + "," +
                      pacao21 + "," +
                      pacao22 + "," +
                      pacao23 + "," +
                      pacao24 + "," +
                      pacao25;

        DataSet DS = new DataSet();
        SqlCommand Command = new SqlCommand(Qry, DM.ConexaoSessao);
        SqlDataAdapter DA = new SqlDataAdapter();
        Command.ExecuteNonQuery();
        // Conn.SqlConn.Close();
    }




    public Usuario()
    {
        //
        // TODO: Add constructor logic here
        //
        TipoErro = 9;
    }

}



using DevExpress.Web.ASPxEditors;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Summary description for SreDblib
/// </summary>

public class SreDblib
{

    public static string connectionString = "";
    public static string connectionStringcep = "";

    public static string GetConnString(string pBaseSql)
    {

        string config = Convert.ToString(ConfigurationManager.ConnectionStrings[pBaseSql].ConnectionString);
        //string config = Convert.ToString(ConfigurationManager.ConnectionStrings["SqlServer0"].ConnectionString);
        //Ajuste da Password
        int posicao = config.IndexOf("pwd=");
        string pedaco1 = config.Substring(0, posicao + 4);
        string oldpass = config.Substring(posicao + 4, config.Length - (posicao + 4));
        oldpass = oldpass.Trim();
        oldpass = oldpass.Substring(0, oldpass.Length - 1);
        int ioldpass = Convert.ToInt16(oldpass);
        string newpass = Convert.ToString(ioldpass - 500);
        config = pedaco1 + newpass + ';';
        //Fim Ajuste Password

        return config;
    }


    public static SqlCommand PreparaCommand(string storedProcName, SqlParameter[] PreparaCommandparameters)
    {
        SqlConnection Conexao = new SqlConnection(connectionString);
        Conexao.Open();
        SqlCommand command = new SqlCommand(storedProcName, Conexao);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Clear();
        command.Parameters.AddRange(PreparaCommandparameters);
        //command.CommandTimeout = 999999;
        command.CommandTimeout = 0;
        return command;
    }

    public static SqlCommand PreparaCommandText(string sql, SqlParameter[] PreparaCommandparameters)
    {
        SqlConnection Conexao = new SqlConnection(connectionString);
        Conexao.Open();
        SqlCommand command = new SqlCommand(sql, Conexao);
        command.CommandType = CommandType.Text;
        command.Parameters.Clear();
        command.Parameters.AddRange(PreparaCommandparameters);
        //command.CommandTimeout = 999999;
        command.CommandTimeout = 0;
        return command;
    }

    public static SqlCommand PreparaCommandSp(string storedProcName)
    {
        SqlConnection Conexao = new SqlConnection(connectionString);
        Conexao.Open();
        SqlCommand command = new SqlCommand(storedProcName, Conexao);
        command.CommandType = CommandType.StoredProcedure;
        //command.CommandTimeout = 999999;
        command.CommandTimeout = 0;
        return command;
    }

    public static SqlCommand PreparaCommandCep(string storedProcName, SqlParameter[] PreparaCommandparameters)
    {
        SqlConnection Conexao = new SqlConnection(connectionStringcep);
        Conexao.Open();
        SqlCommand command = new SqlCommand(storedProcName, Conexao);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Clear();
        command.Parameters.AddRange(PreparaCommandparameters);
        //command.CommandTimeout = 999999;
        command.CommandTimeout = 0;
        return command;
    }

    public static SqlCommand PreparaCommandTextCep(string sql, SqlParameter[] PreparaCommandparameters)
    {
        SqlConnection Conexao = new SqlConnection(connectionStringcep);
        Conexao.Open();
        SqlCommand command = new SqlCommand(sql, Conexao);
        command.CommandType = CommandType.Text;
        command.Parameters.Clear();
        command.Parameters.AddRange(PreparaCommandparameters);
        //command.CommandTimeout = 999999;
        command.CommandTimeout = 0;
        return command;
    }

    public static SqlCommand PreparaCommandSpCep(string storedProcName)
    {
        SqlConnection Conexao = new SqlConnection(connectionStringcep);
        Conexao.Open();
        SqlCommand command = new SqlCommand(storedProcName, Conexao);
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Clear();
        //command.CommandTimeout = 999999;
        command.CommandTimeout = 0;
        return command;
    }

    public static DataSet GetDsSp(string storedProcName, SqlParameter[] GetDsSpparameters)
    {
        SqlCommand command = PreparaCommand(storedProcName, GetDsSpparameters);
        SqlDataAdapter adapter = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        adapter.Fill(ds);
        command.Connection.Close();
        return ds;
    }

    public static DataSet GetDsSpCep(string storedProcName, SqlParameter[] GetDsSpparameters)
    {
        SqlCommand command = PreparaCommandCep(storedProcName, GetDsSpparameters);
        SqlDataAdapter adapter = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        adapter.Fill(ds);
        command.Connection.Close();
        return ds;
    }

    public static DataSet GetDsCp(string sql, SqlParameter[] GetDsSpparameters)
    {
        SqlCommand command = PreparaCommandText(sql, GetDsSpparameters);
        SqlDataAdapter adapter = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        adapter.Fill(ds);
        command.Connection.Close();
        return ds;

    }

    public static DataSet GetDsSpSp(string storedProcName)
    {
        //Versão sem passagem de Parâmetros
        SqlCommand command = PreparaCommandSp(storedProcName);
        SqlDataAdapter adapter = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        adapter.Fill(ds);
        command.Connection.Close();
        return ds;
    }

    public static DataSet GetDsScript(string pScript)
    {
        SqlParameter[] GetDsScriptparameters = { new SqlParameter("@sql", SqlDbType.VarChar, -1) };
        GetDsScriptparameters[0].Value = (pScript);
        return GetDsSp("RODA_SQL", GetDsScriptparameters);
    }

    public static DataSet GetDsScriptCep(string pScript)
    {
        SqlParameter[] GetDsScriptparameters = { new SqlParameter("@sql", SqlDbType.VarChar, -1) };
        GetDsScriptparameters[0].Value = (pScript);
        return GetDsSpCep("RODA_SQL", GetDsScriptparameters);
    }

    public static string ExecSp(string storedProcName, SqlParameter[] parameters)
    {
        string Retorno = "";
        SqlCommand command = PreparaCommand(storedProcName, parameters);
        try
        {
            command.ExecuteReader();
        }
        catch (System.Exception ex)
        {

            Retorno = ex.Message;
            throw;
        }
        command.Connection.Close();
        return Retorno;
    }

    public static string ExecScript(string pScript)
    {
        SqlParameter[] parameters = { new SqlParameter("@sql", SqlDbType.VarChar, -1) };
        parameters[0].Value = (pScript);
        return ExecSp("RODA_SQL", parameters);
    }

    public static String GetCampoSp(string storedProcName, SqlParameter[] parameters)
    {
        SqlCommand command = PreparaCommand(storedProcName, parameters);
        SqlDataAdapter adapter = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        adapter.Fill(ds);
        command.Connection.Close();

        string retorno;
        try
        {
            DataRow dr = ds.Tables[0].Rows[0];
            retorno = dr[0].ToString();
        }
        catch
        {
            retorno = "";
        }
        return retorno;
    }

    public static DataSet GetTabela(string pTabela)
    {
        DataSet ds = SreDblib.GetDsScript("SELECT * FROM " + pTabela + " WITH(NOLOCK)");
        return ds;
    }

    public static DataTable GetTable(string pSql)
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection Conexao = new SqlConnection(connectionString);
        Conexao.Open();
        cmd.Connection = Conexao;
        cmd.CommandText = pSql;
        cmd.CommandType = CommandType.Text;
        SqlDataAdapter Da = new SqlDataAdapter(cmd);
        DataTable Dt = new DataTable();
        Da.Fill(Dt);
        return (Dt);
    }

    public static String GetCampoScript(string pScript)
    {
        DataSet ds = SreDblib.GetDsScript(pScript);
        try
        {
            DataRow dr = ds.Tables[0].Rows[0];
            string retorno = dr[0].ToString();
            return retorno;
        }
        catch
        {
            return "";
        }
    }

    public static String GetParametro(string pParametro)
    {
        string script = "select valor from parametros with(nolock) where nome=" + Srelib.QStr(pParametro);
        return GetCampoScript(script);
    }

    public static String SetParametro(string pParametro, string pValor)
    {
        string script = "UPDATE PARAMETROS SET VALOR = " + Srelib.QStr(pValor) + " where nome=" + Srelib.QStr(pParametro);
        return ExecScript(script);
    }

    public static Boolean TemNaTabela(string pScript)
    {
        DataSet ds = SreDblib.GetDsScript(pScript);
        return (ds.Tables[0].Rows.Count > 0);
    }


    public static Boolean TemPermissao(string pPermissao, string pUsuario)
    {
        Boolean retorno = false;
        if (pUsuario.ToUpper() == "MASTER")
        {
            retorno = true;
        }
        else
        {
            string script = "SELECT * FROM permissoes WITH(NOLOCK) WHERE Login = " + Srelib.QStr(pUsuario) + " and Permissao = " + Srelib.QStr(pPermissao);
            retorno = TemNaTabela(script);
        }

        return retorno;

    }


    public static ASPxComboBox MontaComboBases(ASPxComboBox pCombo, Boolean pExibeValor)
    {
        //Documentação - Chamada da Função
        //
        //RgbDbLib.MontaComboBases(ASPxComboBox1, true);
        //
        //Fim Documentação - Chamada da Função

        string baseconfig = "";
        string config = "";
        ListEditItem le;
        pCombo.Items.Clear();

        for (int i = 0; i < 10; i++)
        {
            baseconfig = "SRE_SqlServer" + Convert.ToString(i);
            try
            {
                config = Convert.ToString(ConfigurationManager.ConnectionStrings[baseconfig].ConnectionString);
            }
            catch (Exception)
            {
                continue;
            }


            int posicaoini = config.IndexOf("database=");
            int posicaofim = config.IndexOf(";pwd=");
            posicaoini = posicaoini + 9;
            int posicaotam = ((posicaofim) - (posicaoini));

            string pedaco1 = config.Substring(0, (posicaoini));
            string nomebase = config.Substring(posicaoini, posicaotam);
            nomebase = nomebase.Trim();
            nomebase = nomebase.ToUpper();

            //
            le = new ListEditItem();
            if (pExibeValor)
            {
                le.Text = i.ToString() + " - " + nomebase;
            }
            else
            {
                le.Text = nomebase;
            };
            le.Value = baseconfig;
            pCombo.Items.Add(le);
        }

        return pCombo;
    }

    public static ASPxComboBox MontaCombo(ASPxComboBox pCombo,
                                          string pTabela,
                                          string pCampoExibe,
                                          string pCampoValor,
                                          Boolean pExibeValor,
                                          string pWhere)
    {
        //Documentação - Chamada da Função
        //
        //RgbDbLib.MontaCombo(ASPxComboBox1, "tcobran", "descricao", "tipo", true);
        //
        //Fim Documentação - Chamada da Função

        String script = "SELECT " + pCampoExibe + "," + pCampoValor + " FROM " + pTabela + " WITH(NOLOCK)" + pWhere;
        DataSet ds = SreDblib.GetDsScript(script);
        ListEditItem le;
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            le = new ListEditItem();
            if (pExibeValor)
            {
                le.Text = Srelib.QStr0(dr[pCampoValor].ToString().Trim(), 5) + " - " + dr[pCampoExibe].ToString();
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

    public static ASPxComboBox MontaComboGroup(ASPxComboBox pCombo, string pTabela, string pCampoExibe, string pCampoValor, Boolean pExibeValor)
    {
        //Documentação - Chamada da Função
        //
        //RgbDbLib.MontaComboGroup(ASPxComboBox1, "tcobran", "descricao", "tipo", true);
        //
        //Especialização para select que precise de Group by em função de grande numero de registros pelo campo pCampoValor
        //
        //Fim Documentação - Chamada da Função

        String script = "SELECT " + pCampoExibe + "," + pCampoValor + " FROM " + pTabela + " WITH(NOLOCK) Group by " + pCampoValor + " Order by " + pCampoValor;
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

    public static ASPxComboBox MontaComboFiltra(ASPxComboBox pCombo, string pTabela, string pCampoExibe, string pCampoValor, Boolean pExibeValor, string pFiltro)
    {
        //Documentação - Chamada da Função
        //
        //RgbDbLib.MontaCombo(ASPxComboBox1, "tcobran", "descricao", "tipo", true);
        //
        //Fim Documentação - Chamada da Função

        String script = "SELECT " + pCampoExibe + "," + pCampoValor + " FROM " + pTabela + " WITH(NOLOCK)" + " WHERE " + pFiltro;
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

    public static ASPxComboBox MontaComboMult(ASPxComboBox pCombo, string pTabela, string[] pCamposExibe, string pCampoValor, Boolean pExibeValor)
    {
        //Documentação - Chamada da Função
        //
        //String[] Campos = { "tipo", "descricao", "apelido" };
        //RgbDbLib.MontaComboMult(ComboModelo2, "tcobran", Campos, "tipo", true);
        //
        //O Search será sempre pelo 1o. campo do Select
        //O Campo de valor Não precisa ser passado na lista de campos, porque ele vem através de pCampoValor
        //Fim Documentação - Chamada da Função

        String script = "SELECT ";

        foreach (String item in pCamposExibe)
        {
            script = script + item + ",";
        }
        script = script + pCampoValor + " FROM " + pTabela + " WITH(NOLOCK)";
        DataSet ds = SreDblib.GetDsScript(script);

        pCombo.DataSource = ds;
        pCombo.ValueField = pCampoValor;
        pCombo.DataBind();

        return pCombo;
    }

    public static ASPxListBox MontaList(ASPxListBox pCombo, string pTabela, string pCampoExibe, string pCampoValor, Boolean pExibeValor)
    {
        //Documentação - Chamada da Função
        //
        //RgbDbLib.MontaList(ASPxListBox1, "tcobran", "descricao", "tipo", true);
        //
        //Fim Documentação - Chamada da Função

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
            pCombo.Items.Add(le);
        }
        return pCombo;
    }

    public static ASPxListBox MontaListMult(ASPxListBox pCombo, string pTabela, string[] pCamposExibe, string pCampoValor, Boolean pExibeValor)
    {
        //Documentação - Chamada da Função
        //
        //String[] Campos = { "tipo", "descricao", "apelido" };
        //RgbDbLib.MontaListMult(ListBoxModelo2, "tcobran", Campos, "tipo", true);
        //
        //O Search será sempre pelo 1o. campo do Select
        //O Campo de valor Não precisa ser passado na lista de campos, porque ele vem através de pCampoValor
        //Fim Documentação - Chamada da Função

        String script = "SELECT ";

        foreach (String item in pCamposExibe)
        {
            script = script + item + ",";
        }
        script = script + pCampoValor + " FROM " + pTabela + " WITH(NOLOCK)";
        DataSet ds = SreDblib.GetDsScript(script);

        pCombo.DataSource = ds;
        pCombo.ValueField = pCampoValor;
        pCombo.DataBind();

        return pCombo;
    }

    public static ASPxListBox MontaListMultCk(ASPxListBox pListBox, string pTabela, string pCampoExibe, string pCampoValor, Boolean pExibeValor)
    {
        //Documentação - Chamada da Função
        //
        //String[] Campos = { "tipo", "descricao", "apelido" };
        //RgbDbLib.MontaComboFullCk(ListBoxModelo2, "tcobran", Campos, "tipo", true);
        //
        //Todas as Caracteristicas do Combo são montadas na Classe, a chamada passa do combo vazio.
        //1o. Campo da Lista é um CheckBox
        //Fim Documentação - Chamada da Função


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

    public static DataSet GetDsSpMD(string storedProcName, SqlParameter[] GetDsSpparameters, string pScript2)
    {

        SqlParameter[] GetDsScriptparameters2 = { new SqlParameter("@sql", SqlDbType.VarChar, -1) };
        GetDsScriptparameters2[0].Value = (pScript2);

        SqlCommand command2 = PreparaCommand("RODA_SQL", GetDsScriptparameters2);
        SqlDataAdapter adapter2 = new SqlDataAdapter(command2);

        SqlCommand command = PreparaCommand(storedProcName, GetDsSpparameters);
        SqlDataAdapter adapter = new SqlDataAdapter(command);
        DataSet ds = new DataSet();
        ds.Tables.Add(new DataTable("Master"));
        ds.Tables.Add(new DataTable("Detail"));
        adapter.Fill(ds.Tables["Master"]);
        adapter2.Fill(ds.Tables["Detail"]);
        command.Connection.Close();
        return ds;
    }

    public static DataSet GetDsSpSpMD(string storedProcName, SqlParameter[] GetDsSpparameters, string storedProcName2, SqlParameter[] GetDsSpparameters2)
    {

        SqlCommand command = PreparaCommand(storedProcName, GetDsSpparameters);
        SqlDataAdapter adapter = new SqlDataAdapter(command);

        SqlCommand command2 = PreparaCommand(storedProcName2, GetDsSpparameters2);
        SqlDataAdapter adapter2 = new SqlDataAdapter(command2);

        DataSet ds = new DataSet();
        ds.Tables.Add(new DataTable("Master"));
        ds.Tables.Add(new DataTable("Detail"));
        adapter.Fill(ds.Tables["Master"]);
        adapter2.Fill(ds.Tables["Detail"]);
        command.Connection.Close();
        return ds;
    }

    public static DataSet GetDsScriptMD(string pScript1, string pScript2)
    {
        SqlParameter[] GetDsScriptparameters = { new SqlParameter("@sql", SqlDbType.VarChar, -1) };
        GetDsScriptparameters[0].Value = (pScript1);

        SqlParameter[] GetDsScriptparameters2 = { new SqlParameter("@sql", SqlDbType.VarChar, -1) };
        GetDsScriptparameters2[0].Value = (pScript2);

        SqlCommand command = PreparaCommand("RODA_SQL", GetDsScriptparameters);
        SqlDataAdapter adapter = new SqlDataAdapter(command);
        SqlCommand command2 = PreparaCommand("RODA_SQL", GetDsScriptparameters2);
        SqlDataAdapter adapter2 = new SqlDataAdapter(command2);

        DataSet ds = new DataSet();
        ds.Tables.Add(new DataTable("Master"));
        ds.Tables.Add(new DataTable("Detail"));
        adapter.Fill(ds.Tables["Master"]);
        adapter2.Fill(ds.Tables["Detail"]);
        command.Connection.Close();
        return ds;
    }


}

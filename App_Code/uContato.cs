using DevExpress.Web.ASPxEditors;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for uContato
/// </summary>
public class uContato
{
    //Contato = Clientes do Produto

    [DataObjectMethod(DataObjectMethodType.Select)]
    public DataSet filtro_combo_contato(string valor_inicio, string id)
    {
        String sql = "";
        if (valor_inicio == null)
        {
            valor_inicio = "";
        }
        if (id == null)
        {
            id = "";
        }

        SqlParameter[] parametros = { new SqlParameter("@valor_inicio", valor_inicio),
                                      new SqlParameter("@id", id)};
        //
        if (id == "")
        {
            sql = @"SELECT nome, id
               FROM contato
               WHERE nome LIKE '%' + replace(@valor_inicio, '%', '[%]') + '%'
               order by nome";
        }
        else
        {
            sql = @"SELECT nome, id
               FROM contato
               WHERE nome LIKE '%' + replace(@valor_inicio, '%', '[%]') + '%'
               AND ID = replace(@ID, '%', '[%]')
               order by nome";
        }
        //
        DataSet Ds = SreDblib.GetDsCp(sql, parametros);
        return Ds;
    }

    [DataObjectMethod(DataObjectMethodType.Select)]
    public DataSet filtro_combo_contato_cnpj(string valor_inicio, string id, string nome )
    {
        String sql = "";
        if (valor_inicio == null)
        {
            valor_inicio = "";
        }
        if (nome == null)
        {
            nome = "";
        }
        if (id == null)
        {
            id = "";
        }
        SqlParameter[] parametros = { new SqlParameter("@valor_inicio", valor_inicio),                                     
                                      new SqlParameter("@id", id),
                                      new SqlParameter("@nome", nome)};
        //
        if (valor_inicio == "")
        {
            sql = @"SELECT nome, id, cnpj
               FROM contato
               WHERE cnpj LIKE '%' + replace(@valor_inicio, '%', '[%]') + '%'
               order by cnpj";
        }
        else
        {
            sql = @"SELECT nome, id, cnpj
               FROM contato
               WHERE cnpj LIKE '%' + replace(@valor_inicio, '%', '[%]') + '%'
               AND ID = replace(@ID, '%', '[%]')
               order by cnpj";
        }
        //
        DataSet Ds = SreDblib.GetDsCp(sql, parametros);
        return Ds;
    }

    [DataObjectMethod(DataObjectMethodType.Select)]
    public DataSet filtro_combo_contato_nome(string valor_inicio, string id, string cnpj)
    {
        String sql = "";
        if (valor_inicio == null)
        {
            valor_inicio = "";
        }
        if (cnpj == null)
        {
            cnpj = "";
        }
        if (id == null)
        {
            id = "";
        }
        SqlParameter[] parametros = { new SqlParameter("@valor_inicio", valor_inicio),                                     
                                      new SqlParameter("@id", id),
                                      new SqlParameter("@cnpj", cnpj)};
        //
        if (valor_inicio == "")
        {
            sql = @"SELECT nome, id, cnpj
               FROM contato
               WHERE nome LIKE '%' + replace(@valor_inicio, '%', '[%]') + '%'
               order by cnpj";
        }
        else
        {
            sql = @"SELECT nome, id, cnpj
               FROM contato
               WHERE nome LIKE '%' + replace(@valor_inicio, '%', '[%]') + '%'
               AND ID = replace(@ID, '%', '[%]')
               order by cnpj";
        }
        //
        DataSet Ds = SreDblib.GetDsCp(sql, parametros);
        return Ds;
    }

    [DataObjectMethod(DataObjectMethodType.Select)]
    public DataSet filtro_combo_contato_id(string valor_inicio, string nome, string cnpj)
    {
        String sql = "";
        if (valor_inicio == null)
        {
            valor_inicio = "";
        }
        if (cnpj == null)
        {
            cnpj = "";
        }
        if (nome == null)
        {
            nome = "";
        }
        SqlParameter[] parametros = { new SqlParameter("@valor_inicio", valor_inicio),                                     
                                      new SqlParameter("@nome", nome),
                                      new SqlParameter("@cnpj", cnpj)};
        //
        if (nome == "")
        {
            sql = @"SELECT nome, id, cnpj
               FROM contato
               WHERE id LIKE '%' + replace(@valor_inicio, '%', '[%]') + '%'
               order by cnpj";
        }
        else
        {
            sql = @"SELECT nome, id, cnpj
               FROM contato
               WHERE nome LIKE '%' + replace(@valor_inicio, '%', '[%]') + '%'
               AND ID = replace(@ID, '%', '[%]')
               order by cnpj";
        }
        //
        DataSet Ds = SreDblib.GetDsCp(sql, parametros);
        return Ds;
    }

    public static ASPxComboBox MontaComboContato(ASPxComboBox pCombo, Boolean pativo)
    {
        if (pativo)
            return SreDblib.MontaCombo(pCombo, "contato", "nome", "ID", true, " WHERE ativo = 1 ORDER BY nome ");
        else
            return SreDblib.MontaCombo(pCombo, "contato", "nome", "ID", true, " ORDER BY nome ");
    }


    public static DataSet LookUpContato()
    {
        return SreDblib.GetDsScript("select apelido from Contato WITH(NOLOCK) ORDER BY apelido");
    }

    public static String PegaNomeApelido(string xapelido)
    {
        string script = "SELECT nome FROM Contato WITH(NOLOCK) WHERE apelido = " + Srelib.QStr(xapelido);
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static String PegaNomeID(string xID)
    {
        string script = "SELECT nome FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static String PegaIDNome(string xnome)
    {
        string script = "SELECT ID FROM Contato WITH(NOLOCK) WHERE nome = " + Srelib.QStr(xnome);
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static String PegaCpfCnpjID(string xID)
    {
        string script = "SELECT cnpj FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static String PegaInscricaoMunicipalID(string xID)
    {
        string script = "SELECT inscrmunicipal FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static String PegaInscricaoEstadualID(string xID)
    {
        string script = "SELECT inscrestadual FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static String PesquisaCpfCnpj(string xcpfcnpj)
    {
        string script = "SELECT cnpj FROM Contato WITH(NOLOCK) WHERE CNPJ = " + xcpfcnpj;
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static String PegaEnderecoID(string xID)
    {
        string script = "SELECT endereco FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
        string resultado = "";
        DataSet ds;
        resultado = SreDblib.GetCampoScript(script);
        if (resultado == "R")
        {
            //Residencial
            script = "SELECT enderecores, enderecoresnumero, enderecorescomplem, bairrores, cidaderes, ufres, cepres FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
            ds = SreDblib.GetDsScript(script);

            resultado = ds.Tables[0].Rows[0]["enderecores"].ToString() + ", " +
                        ds.Tables[0].Rows[0]["enderecoresnumero"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["enderecorescomplem"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["bairrores"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["cidaderes"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["ufres"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["cepres"].ToString();
        }
        else
        {
            //Comercial
            script = "SELECT enderecocom, enderecocomnumero, enderecocomcomplem, bairrocom, cidadecom, ufcom, cepcom FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
            ds = SreDblib.GetDsScript(script);

            resultado = ds.Tables[0].Rows[0]["enderecocom"].ToString() + ", " +
                        ds.Tables[0].Rows[0]["enderecocomnumero"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["enderecocomcomplem"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["bairrocom"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["cidadecom"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["ufcom"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["cepcom"].ToString();
        }



        return resultado;
    }

    public static String PegaEnderecoPuroID(string xID)
    {
        string script = "SELECT endereco FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
        string resultado = "";
        DataSet ds;
        resultado = SreDblib.GetCampoScript(script);
        if (resultado == "R")
        {
            //Residencial
            script = "SELECT enderecores, enderecoresnumero, enderecorescomplem, bairrores, cidaderes, ufres, cepres FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
            ds = SreDblib.GetDsScript(script);

            resultado = ds.Tables[0].Rows[0]["enderecores"].ToString() + ", " +
                        ds.Tables[0].Rows[0]["enderecoresnumero"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["enderecorescomplem"].ToString();
        }
        else
        {
            //Comercial
            script = "SELECT enderecocom, enderecocomnumero, enderecocomcomplem, bairrocom, cidadecom, ufcom, cepcom FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
            ds = SreDblib.GetDsScript(script);

            resultado = ds.Tables[0].Rows[0]["enderecocom"].ToString() + ", " +
                        ds.Tables[0].Rows[0]["enderecocomnumero"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["enderecocomcomplem"].ToString();
        }
        return resultado;
    }

    public static String PegaBairroID(string xID)
    {
        string script = "SELECT endereco FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
        string resultado = "";
        DataSet ds;
        resultado = SreDblib.GetCampoScript(script);
        if (resultado == "R")
        {
            //Residencial
            script = "SELECT enderecores, enderecoresnumero, enderecorescomplem, bairrores, cidaderes, ufres, cepres FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
            ds = SreDblib.GetDsScript(script);

            resultado = ds.Tables[0].Rows[0]["bairrores"].ToString();
        }
        else
        {
            //Comercial
            script = "SELECT enderecocom, enderecocomnumero, enderecocomcomplem, bairrocom, cidadecom, ufcom, cepcom FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
            ds = SreDblib.GetDsScript(script);

            resultado = ds.Tables[0].Rows[0]["bairrocom"].ToString();
        }

        return resultado;
    }

    public static String PegaCidadeID(string xID)
    {
        string script = "SELECT endereco FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
        string resultado = "";
        DataSet ds;
        resultado = SreDblib.GetCampoScript(script);
        if (resultado == "R")
        {
            //Residencial
            script = "SELECT enderecores, enderecoresnumero, enderecorescomplem, bairrores, cidaderes, ufres, cepres FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
            ds = SreDblib.GetDsScript(script);

            resultado = ds.Tables[0].Rows[0]["cidaderes"].ToString();
        }
        else
        {
            //Comercial
            script = "SELECT enderecocom, enderecocomnumero, enderecocomcomplem, bairrocom, cidadecom, ufcom, cepcom FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
            ds = SreDblib.GetDsScript(script);

            resultado = ds.Tables[0].Rows[0]["cidadecom"].ToString();
        }

        return resultado;
    }

    public static String PegaufID(string xID)
    {
        string script = "SELECT endereco FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
        string resultado = "";
        DataSet ds;
        resultado = SreDblib.GetCampoScript(script);
        if (resultado == "R")
        {
            //Residencial
            script = "SELECT enderecores, enderecoresnumero, enderecorescomplem, bairrores, cidaderes, ufres, cepres FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
            ds = SreDblib.GetDsScript(script);

            resultado = ds.Tables[0].Rows[0]["ufres"].ToString();
        }
        else
        {
            //Comercial
            script = "SELECT enderecocom, enderecocomnumero, enderecocomcomplem, bairrocom, cidadecom, ufcom, cepcom FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
            ds = SreDblib.GetDsScript(script);

            resultado = ds.Tables[0].Rows[0]["ufcom"].ToString();
        }

        return resultado;
    }

    public static String PegacepID(string xID)
    {
        string script = "SELECT endereco FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
        string resultado = "";
        DataSet ds;
        resultado = SreDblib.GetCampoScript(script);
        if (resultado == "R")
        {
            //Residencial
            script = "SELECT enderecores, enderecoresnumero, enderecorescomplem, bairrores, cidaderes, ufres, cepres FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
            ds = SreDblib.GetDsScript(script);

            resultado = ds.Tables[0].Rows[0]["cepres"].ToString();
        }
        else
        {
            //Comercial
            script = "SELECT enderecocom, enderecocomnumero, enderecocomcomplem, bairrocom, cidadecom, ufcom, cepcom FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
            ds = SreDblib.GetDsScript(script);

            resultado = ds.Tables[0].Rows[0]["cepcom"].ToString();
        }

        return resultado;
    }

    public static String PegaEnderecoIDReferencia(string xID,
                                                  ref string nome,
                                                  ref string endereco,
                                                  ref string bairro,
                                                  ref string cidade,
                                                  ref string estado,
                                                  ref string cep,
                                                  ref string tiposacado)
    {
        string script = "SELECT endereco FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
        string resultado = "";
        DataSet ds;
        resultado = SreDblib.GetCampoScript(script);
        if (resultado == "R")
        {
            //Residencial
            script = "SELECT nome, sexo, enderecores, enderecoresnumero, enderecorescomplem, bairrores, cidaderes, ufres, cepres FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
            ds = SreDblib.GetDsScript(script);

            nome = ds.Tables[0].Rows[0]["nome"].ToString();
            endereco = ds.Tables[0].Rows[0]["enderecores"].ToString() + ", " +
                        ds.Tables[0].Rows[0]["enderecoresnumero"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["enderecorescomplem"].ToString();
            bairro = ds.Tables[0].Rows[0]["bairrores"].ToString();
            cidade = ds.Tables[0].Rows[0]["cidaderes"].ToString();
            estado = ds.Tables[0].Rows[0]["ufres"].ToString();
            cep = ds.Tables[0].Rows[0]["cepres"].ToString();
            if (ds.Tables[0].Rows[0]["sexo"].ToString() == "O")
            {
                tiposacado = "02";
            }
            else
            {
                tiposacado = "01";
            }
        }
        else
        {
            //Comercial
            script = "SELECT nome, sexo,enderecocom, enderecocomnumero, enderecocomcomplem, bairrocom, cidadecom, ufcom, cepcom FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
            ds = SreDblib.GetDsScript(script);

            nome = ds.Tables[0].Rows[0]["nome"].ToString();
            endereco = ds.Tables[0].Rows[0]["enderecocom"].ToString() + ", " +
                        ds.Tables[0].Rows[0]["enderecocomnumero"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["enderecocomcomplem"].ToString();
            bairro = ds.Tables[0].Rows[0]["bairrocom"].ToString();
            cidade = ds.Tables[0].Rows[0]["cidadecom"].ToString();
            estado = ds.Tables[0].Rows[0]["ufcom"].ToString();
            cep = ds.Tables[0].Rows[0]["cepcom"].ToString();
            if (ds.Tables[0].Rows[0]["sexo"].ToString() == "O")
            {
                tiposacado = "02";
            }
            else
            {
                tiposacado = "01";
            }
        }

        return "";
    }

    public static String PegaNomeConjugeID(string xID)
    {
        string script = "SELECT conjugenome FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static String PegaCpfCnpjConjugeID(string xID)
    {
        string script = "SELECT conjugecnpj FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static String PegaEnderecoConjugeID(string xID)
    {
        string script = "SELECT endereco FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
        string resultado = "";
        DataSet ds;
        resultado = SreDblib.GetCampoScript(script);
        if (resultado == "R")
        {
            //Residencial
            script = "SELECT enderecores, enderecoresnumero, enderecorescomplem, bairrores, cidaderes, ufres, cepres FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
            ds = SreDblib.GetDsScript(script);

            resultado = ds.Tables[0].Rows[0]["enderecores"].ToString() + ", " +
                        ds.Tables[0].Rows[0]["enderecoresnumero"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["enderecorescomplem"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["bairrores"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["cidaderes"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["ufres"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["cepres"].ToString();
        }
        else
        {
            //Comercial
            script = "SELECT enderecocom, enderecocomnumero, enderecocomcomplem, bairrocom, cidadecom, ufcom, cepcom FROM Contato WITH(NOLOCK) WHERE ID = " + xID;
            ds = SreDblib.GetDsScript(script);

            resultado = ds.Tables[0].Rows[0]["enderecocom"].ToString() + ", " +
                        ds.Tables[0].Rows[0]["enderecocomnumero"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["enderecocomcomplem"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["bairrocom"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["cidadecom"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["ufcom"].ToString() + " - " +
                        ds.Tables[0].Rows[0]["cepcom"].ToString();
        }



        return resultado;
    }

    public static ASPxComboBox MontaComboContato(ASPxComboBox pCombo)
    {
        return SreDblib.MontaCombo(pCombo, "Contato", "apelido", "apelido", false, "");
    }

    public static DataSet PegaContato()
    {
        return SreDblib.GetDsScript("select apelido, nome, cnpj from Contato WITH(NOLOCK)");
    }


    public static DataSet PegaDadosContato(string xapelido, string xletra, string xdda)
    {
        string script;
        if (xletra == "")
        {
            if (xapelido == "")
            {
                script = "SELECT * FROM Contato WITH(NOLOCK) WHERE 1 = 1 ";
            }
            else
            {
                if (xapelido.Trim().Substring(0, 1) == "'")
                {
                    script = "SELECT * FROM Contato WITH(NOLOCK) WHERE apelido in (" + xapelido + ") ";
                }
                else
                {
                    script = "SELECT * FROM Contato WITH(NOLOCK) WHERE apelido in (" + Srelib.QStr(xapelido) + ") ";
                }
            }
        }
        else
        {
            script = "SELECT * FROM Contato WITH(NOLOCK) WHERE LEFT(NOME,1) = " + Srelib.QStr(xletra);
        }
        //
        //Débito Direto Autorizado - DDA = 0 = Todos
        if (xdda == "1")
        {
            script = script + " AND dda = 1 ";
        }
        //
        script = script + " ORDER BY nome ";
        //
        return SreDblib.GetDsScript(script);

    }

    public static DataSet PegaDadosContatoAniversariante(string xmes)
    {
        string script;
        if (xmes != "")
        {
            script = "SELECT * FROM Contato C WITH(NOLOCK) WHERE MONTH(C.dtnascimento) = " + xmes;
            //
            script = script + " ORDER BY nome ";
        }
        else
        {
            script = "SELECT * FROM Contato WITH(NOLOCK) ORDER BY nome ";
        }

        return SreDblib.GetDsScript(script);

    }

    public static DataSet PegaDadosContatoProduto(string xcbproduto,
                                                  string xcbprodutogrupo,
                                                  string xdtprevisao1)
    {
        string script;
        //
        if (xdtprevisao1 == "01/01/1900")
        {
            script = "SELECT * FROM Contato C WITH(NOLOCK) WHERE 1 = 1 ";
            //
            if (xcbproduto != string.Empty)
            {
                script = script + " AND exists(SELECT * FROM VENDAS V WHERE V.CLIENTE = C.ID AND V.PRODUTO = " +
                                  Srelib.QStr(xcbproduto) + " ";
                //
                if (xcbprodutogrupo != string.Empty)
                {
                    script = script + " AND V.GRUPO = " +
                                      Srelib.QStr(xcbprodutogrupo) + " ";
                }
                script = script + " ) ";
            }

            script = script + " ORDER BY nome ";
        }
        else
        {
            script = "SELECT * FROM Contato C WITH(NOLOCK) WHERE 1 = 1 ";
            //
            if (xcbproduto != string.Empty)
            {
                script = script + " AND exists(SELECT * FROM VENDAS V WHERE V.CLIENTE = C.ID AND V.PRODUTO = " +
                                  Srelib.QStr(xcbproduto) + " ";
                //
                if (xcbprodutogrupo != string.Empty)
                {
                    script = script + " AND V.GRUPO = " +
                                      Srelib.QStr(xcbprodutogrupo) + " ";
                    //
                    string nomearquivo = "parcelas_" + Srelib.QStr0(xcbproduto.Trim(), 5) + "_" + Srelib.QStr0(xcbprodutogrupo.Trim(), 5);
                    script = script + " AND exists(SELECT * FROM " + nomearquivo + " P WHERE P.PRODUTO = " +
                                      Srelib.QStr(xcbproduto) +
                                      " AND P.GRUPO = " + Srelib.QStr(xcbprodutogrupo);
                }


                script = script + " ) ";
            }

            script = script + " ORDER BY nome ";
        }

        return SreDblib.GetDsScript(script);

    }

    public static DataSet PegaDadosContatoDevedores(string xcbproduto,
                                                    string xcbprodutogrupo,
                                                    string xdtprevisao1)
    {
        string script;
        //
        if (xdtprevisao1 == "01/01/1900")
        {
            script = "SELECT * FROM Contato C WHERE 1 = 1 ";
            //
            if (xcbproduto.Trim() != string.Empty)
            {
                script = script + " AND exists(SELECT * FROM VENDAS V WHERE V.CLIENTE = C.ID AND V.PRODUTO = " +
                                  Srelib.QStr(xcbproduto) + " ";
                //
                if (xcbprodutogrupo.Trim() != string.Empty)
                {
                    script = script + " AND V.GRUPO = " +
                                      Srelib.QStr(xcbprodutogrupo) + " ";
                }
                script = script + " ) ";
            }

            script = script + " ORDER BY nome ";
        }
        else
        {
            script = "SELECT * FROM Contato C WHERE 1 = 1 ";
            //
            if (xcbproduto.Trim() != string.Empty)
            {
                //
                string nomearquivo = "parcelas_" + Srelib.QStr0(xcbproduto.Trim(), 5) + "_" + Srelib.QStr0(xcbprodutogrupo.Trim(), 5);
                //
                script = script + " AND exists(SELECT * FROM " + nomearquivo + " P WHERE 1 = 1 ";
                script = script + " AND P.DATA_VENCIMENTO <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao1)) +
                                  " AND P.DATA_PAGAMENTO = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900"));
                script = script + " ) ";
                //
            }

            script = script + " ORDER BY C.nome ";
        }

        return SreDblib.GetDsScript(script);

    }

    public static string ProximoID()
    {
        string script;

        script = "SELECT MAX(ID) + 1 ID FROM Contato WITH(NOLOCK)";


        return SreDblib.GetCampoScript(script);

    }



    public static String Grava(string xnumcliente,
                                string xapelido,
                                string xnome,
                                string xsexo,
                                string xcnpj,
                                string xinscmunicipal,
                                string xinscestadual,
                                string xregjuntacom,
                                string xnire,
                                string xrg,
                                string xrguf,
                                string xrgemissor,
                                DateTime xrgemissao,
                                string xendereco,
                                string xenderecores,
                                string xenderecoresnumero,
                                string xenderecoresresplem,
                                string xbairrores,
                                string xcidaderes,
                                string xufres,
                                string xcepres,
                                string xfone1res,
                                string xfone2res,
                                string xfone3res,
                                string xenderecocom,
                                string xenderecocomnumero,
                                string xenderecocomcomplem,
                                string xbairrocom,
                                string xcidadecom,
                                string xufcom,
                                string xcepcom,
                                string xfone1com,
                                string xfone2com,
                                string xfone3com,
                                string xemail1,
                                string xemail2,
                                string xemail3,
                                string xemail4,
                                string xemail5,
                                string xgerente,
                                string xcontato,
                                DateTime xdtnascimento,
                                DateTime xdtingresso,
                                string xncontrato,
                                DateTime xdtcontrato,
                                Boolean xativo,
                                Boolean xacessointernet,
                                string xempregador,
                                string xcargo,
                                string xatividade,
                                string conjugenome,
                                string xconjugesexo,
                                string xconjugecnpj,
                                string xconjugerg,
                                string xconjugerguf,
                                string xconjugergemissor,
                                DateTime xconjugergemissao,
                                DateTime xdtnascimentoconjuge,
                                string xfone1con,
                                string xfone2con,
                                string xfone3con,
                                string xconjugeemail1,
                                string xconjugeemail2,
                                string xobs1,
                                string xobs2,
                                string xobs3,
                                string xobs4,
                                string xobs5,
                                string xinstrcob1,
                                string xinstrcob2,
                                string xdiasprotesto,
                                string xconta1,
                                string xconta2,
                                string xconta3,
                                string xconta4,
                                string xconta5,
                                Boolean xdda)
    {

        if (xapelido != String.Empty)
        {
            //Não Incluir com ID duplicado
            string script2 = "select ID from CONTATO with(nolock) where ID = " + xnumcliente;
            //
            if (!SreDblib.TemNaTabela(script2))
            {
                //
                string script = "INSERT INTO CONTATO VALUES ( " +
                                xnumcliente +
                                ", " + Srelib.QStr(xapelido) +
                                ", " + Srelib.QStr(xnome) +
                                ", " + Srelib.QStr(xsexo) +
                                ", " + Srelib.QStr(xcnpj) +
                                ", " + Srelib.QStr(xinscmunicipal) +
                                ", " + Srelib.QStr(xinscestadual) +
                                ", " + Srelib.QStr(xregjuntacom) +
                                ", " + Srelib.QStr(xnire) +
                                ", " + Srelib.QStr(xrg) +
                                ", " + Srelib.QStr(xrguf) +
                                ", " + Srelib.QStr(xrgemissor) +
                                ", " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xrgemissao))) +
                                ", " + Srelib.QStr(xendereco) +
                                ", " + Srelib.QStr(xenderecores) +
                                ", " + Srelib.QStr(xenderecoresnumero) +
                                ", " + Srelib.QStr(xenderecoresresplem) +
                                ", " + Srelib.QStr(xbairrores) +
                                ", " + Srelib.QStr(xcidaderes) +
                                ", " + Srelib.QStr(xufres) +
                                ", " + Srelib.QStr(xcepres) +
                                ", " + Srelib.QStr(xfone1res) +
                                ", " + Srelib.QStr(xfone2res) +
                                ", " + Srelib.QStr(xfone3res) +
                                ", " + Srelib.QStr(xenderecocom) +
                                ", " + Srelib.QStr(xenderecocomnumero) +
                                ", " + Srelib.QStr(xenderecocomcomplem) +
                                ", " + Srelib.QStr(xbairrocom) +
                                ", " + Srelib.QStr(xcidadecom) +
                                ", " + Srelib.QStr(xufcom) +
                                ", " + Srelib.QStr(xcepcom) +
                                ", " + Srelib.QStr(xfone1com) +
                                ", " + Srelib.QStr(xfone2com) +
                                ", " + Srelib.QStr(xfone3com) +
                                ", " + Srelib.QStr(xemail1) +
                                ", " + Srelib.QStr(xemail2) +
                                ", " + Srelib.QStr(xemail3) +
                                ", " + Srelib.QStr(xemail4) +
                                ", " + Srelib.QStr(xemail5) +
                                ", " + Srelib.QStr(xgerente) +
                                ", " + Srelib.QStr(xcontato) +
                                ", " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xdtnascimento))) +
                                ", " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xdtingresso))) +
                                ", " + Srelib.QStr(xncontrato) +
                                ", " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xdtcontrato))) +
                                ", " + Convert.ToString(Convert.ToInt16(xativo)) +
                                ", " + Convert.ToString(Convert.ToInt16(xacessointernet)) +
                                ", " + Srelib.QStr(xempregador) +
                                ", " + Srelib.QStr(xcargo) +
                                ", " + Srelib.QStr(xatividade) +
                                ", " + Srelib.QStr(xobs1) +
                                ", " + Srelib.QStr(xobs2) +
                                ", " + Srelib.QStr(xobs3) +
                                ", " + Srelib.QStr(xobs4) +
                                ", " + Srelib.QStr(xobs5) +
                                ", " + Srelib.QStr(conjugenome) +
                                ", " + Srelib.QStr(xconjugesexo) +
                                ", " + Srelib.QStr(xconjugecnpj) +
                                ", " + Srelib.QStr(xconjugerg) +
                                ", " + Srelib.QStr(xconjugerguf) +
                                ", " + Srelib.QStr(xconjugergemissor) +
                                ", " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xconjugergemissao))) +
                                ", " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xdtnascimentoconjuge))) +
                                ", " + Srelib.QStr(xfone1con) +
                                ", " + Srelib.QStr(xfone2con) +
                                ", " + Srelib.QStr(xfone3con) +
                                ", " + Srelib.QStr(xconjugeemail1) +
                                ", " + Srelib.QStr(xconjugeemail2) +
                                ", " + Srelib.QStr(xinstrcob1) +
                                ", " + Srelib.QStr(xinstrcob2) +
                                ", " + Srelib.QStr(xdiasprotesto) +
                                ", " + Srelib.QStr(xconta1) +
                                ", " + Srelib.QStr(xconta2) +
                                ", " + Srelib.QStr(xconta3) +
                                ", " + Srelib.QStr(xconta4) +
                                ", " + Srelib.QStr(xconta5) +
                                ", " + Convert.ToString(Convert.ToInt16(xdda)) +
                                " ) ";

                //" where nome=" + Rgblib.QStr(pParametro);

                SreDblib.ExecScript(script);
            }
        }
        return " ";
    }

    public static String Altera(string xID,
                                string xapelido,
                                string xnome,
                                string xsexo,
                                string xcnpj,
                                string xinscmunicipal,
                                string xinscestadual,
                                string xregjuntacom,
                                string xnire,
                                string xrg,
                                string xrguf,
                                string xrgemissor,
                                DateTime xrgemissao,
                                string xendereco,
                                string xenderecores,
                                string xenderecoresnumero,
                                string xenderecorescomplem,
                                string xbairrores,
                                string xcidaderes,
                                string xufres,
                                string xcepres,
                                string xfone1res,
                                string xfone2res,
                                string xfone3res,
                                string xenderecocom,
                                string xenderecocomnumero,
                                string xenderecocomcomplem,
                                string xbairrocom,
                                string xcidadecom,
                                string xufcom,
                                string xcepcom,
                                string xfone1com,
                                string xfone2com,
                                string xfone3com,
                                string xemail1,
                                string xemail2,
                                string xemail3,
                                string xemail4,
                                string xemail5,
                                string xgerente,
                                string xcontato,
                                DateTime xdtnascimento,
                                DateTime xdtingresso,
                                string xncontrato,
                                DateTime xdtcontrato,
                                Boolean xativo,
                                Boolean xacessointernet,
                                string xempregador,
                                string xcargo,
                                string xatividade,
                                string xconjugenome,
                                string xconjugesexo,
                                string xconjugecnpj,
                                string xconjugerg,
                                string xconjugerguf,
                                string xconjugergemissor,
                                DateTime xconjugergemissao,
                                DateTime xdtnascimentoconjuge,
                                string xfone1con,
                                string xfone2con,
                                string xfone3con,
                                string xconjugeemail1,
                                string xconjugeemail2,
                                string xobs1,
                                string xobs2,
                                string xobs3,
                                string xobs4,
                                string xobs5,
                                string xinstrcob1,
                                string xinstrcob2,
                                string xdiasprotesto,
                                string xconta1,
                                string xconta2,
                                string xconta3,
                                string xconta4,
                                string xconta5,
                                Boolean xdda
                                )
    {

        string script = "UPDATE CONTATO SET " +
                        " apelido = " + Srelib.QStr(xapelido) +
                        " ,nome = " + Srelib.QStr(xnome) +
                        " ,sexo = " + Srelib.QStr(xsexo) +
                        " ,cnpj = " + Srelib.QStr(xcnpj) +
                        " ,inscmunicipal = " + Srelib.QStr(xinscmunicipal) +
                        " ,inscestadual = " + Srelib.QStr(xinscestadual) +
                        " ,regjuntacom = " + Srelib.QStr(xregjuntacom) +
                        " ,nire = " + Srelib.QStr(xnire) +
                        " ,rg = " + Srelib.QStr(xrg) +
                        " ,rguf = " + Srelib.QStr(xrguf) +
                        " ,rgemissor = " + Srelib.QStr(xrgemissor) +
                        " ,rgemissao = " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xrgemissao))) +
                        " ,endereco = " + Srelib.QStr(xendereco) +
                        " ,enderecores = " + Srelib.QStr(xenderecores) +
                        " ,enderecoresnumero = " + Srelib.QStr(xenderecoresnumero) +
                        " ,enderecorescomplem = " + Srelib.QStr(xenderecorescomplem) +
                        " ,bairrores = " + Srelib.QStr(xbairrores) +
                        " ,cidaderes = " + Srelib.QStr(xcidaderes) +
                        " ,ufres = " + Srelib.QStr(xufres) +
                        " ,cepres = " + Srelib.QStr(xcepres) +
                        " ,fone1res = " + Srelib.QStr(xfone1res) +
                        " ,fone2res = " + Srelib.QStr(xfone2res) +
                        " ,fone3res = " + Srelib.QStr(xfone3res) +
                        " ,enderecocom = " + Srelib.QStr(xenderecocom) +
                        " ,enderecocomnumero = " + Srelib.QStr(xenderecocomnumero) +
                        " ,enderecocomcomplem = " + Srelib.QStr(xenderecocomcomplem) +
                        " ,bairrocom = " + Srelib.QStr(xbairrocom) +
                        " ,cidadecom = " + Srelib.QStr(xcidadecom) +
                        " ,ufcom = " + Srelib.QStr(xufcom) +
                        " ,cepcom = " + Srelib.QStr(xcepcom) +
                        " ,fone1com = " + Srelib.QStr(xfone1com) +
                        " ,fone2com = " + Srelib.QStr(xfone2com) +
                        " ,fone3com = " + Srelib.QStr(xfone3com) +
                        " ,email1 = " + Srelib.QStr(xemail1) +
                        " ,email2 = " + Srelib.QStr(xemail2) +
                        " ,email3 = " + Srelib.QStr(xemail3) +
                        " ,email4 = " + Srelib.QStr(xemail4) +
                        " ,email5 = " + Srelib.QStr(xemail5) +
                        " ,gerente = " + Srelib.QStr(xgerente) +
                        " ,contato = " + Srelib.QStr(xcontato) +
                        " ,dtnascimento = " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xdtnascimento))) +
                        " ,dtingresso = " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xdtingresso))) +
                        " ,ncontrato = " + Srelib.QStr(xncontrato) +
                        " ,dtcontrato = " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xdtcontrato))) +
                        " ,ativo = " + Convert.ToString(Convert.ToInt16(xativo)) +
                        " ,acessointernet = " + Convert.ToString(Convert.ToInt16(xacessointernet)) +
                        " ,empregador = " + Srelib.QStr(xempregador) +
                        " ,cargo = " + Srelib.QStr(xcargo) +
                        " ,atividade = " + Srelib.QStr(xatividade) +
                        " ,conjugenome = " + Srelib.QStr(xconjugenome) +
                        " ,conjugesexo = " + Srelib.QStr(xconjugesexo) +
                        " ,conjugecnpj = " + Srelib.QStr(xconjugecnpj) +
                        " ,conjugerg = " + Srelib.QStr(xconjugerg) +
                        " ,conjugerguf = " + Srelib.QStr(xconjugerguf) +
                        " ,conjugergemissor = " + Srelib.QStr(xconjugergemissor) +
                        " ,conjugergemissao = " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xconjugergemissao))) +
                        " ,dtnascimentoconjuge = " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xdtnascimentoconjuge))) +
                        " ,fone1con = " + Srelib.QStr(xfone1con) +
                        " ,fone2con = " + Srelib.QStr(xfone2con) +
                        " ,fone3con = " + Srelib.QStr(xfone3con) +
                        " ,conjugeemail1 = " + Srelib.QStr(xconjugeemail1) +
                        " ,conjugeemail2 = " + Srelib.QStr(xconjugeemail2) +
                        " ,obs1 = " + Srelib.QStr(xobs1) +
                        " ,obs2 = " + Srelib.QStr(xobs2) +
                        " ,obs3 = " + Srelib.QStr(xobs3) +
                        " ,obs4 = " + Srelib.QStr(xobs4) +
                        " ,obs5 = " + Srelib.QStr(xobs5) +
                        " ,instrcob1 = " + Srelib.QStr(xinstrcob1) +
                        " ,instrcob2 = " + Srelib.QStr(xinstrcob2) +
                        " ,diasprotesto = " + Srelib.QStr(xdiasprotesto) +
                        " ,conta1 = " + Srelib.QStr(xconta1) +
                        " ,conta2 = " + Srelib.QStr(xconta2) +
                        " ,conta3 = " + Srelib.QStr(xconta3) +
                        " ,conta4 = " + Srelib.QStr(xconta4) +
                        " ,conta5 = " + Srelib.QStr(xconta5) +
                        " ,dda = " + Convert.ToString(Convert.ToInt16(xdda)) +
                        " where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String Exclui(string xID)
    {

        string script = "DELETE CONTATO where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static ASPxComboBox MontaComboRegimeCasamento(ASPxComboBox pCombo)
    {
        //Documentação - Chamada da Função
        //
        //SreLib.MontaComboRegimeCasamento(ASPxComboBox1, true);
        //
        //Fim Documentação - Chamada da Função

        ListEditItem le;
        pCombo.Items.Clear();
        //
        le = new ListEditItem();
        le.Text = " 1 - " + "Comunhão Universal de Bens";
        pCombo.Items.Add(le);
        //
        le = new ListEditItem();
        le.Text = " 2 - " + "Comunhão Parcial de Bens";
        pCombo.Items.Add(le);
        //
        le = new ListEditItem();
        le.Text = " 3 - " + "Separação Total de Bens";
        pCombo.Items.Add(le);
        //
        le = new ListEditItem();
        le.Text = " 4 - " + "Participação Final nos Aquestos";
        pCombo.Items.Add(le);
        //
        return pCombo;
    }

    public uContato()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;

/// <summary>
/// Summary description for uPermissoes
/// </summary>
public class uPermissoes
{
    //Classe
    //CadPermissões
    //Permissões

    public static DataSet LookUpPermissoes(string xusuario,
                                           string xpermissoes)
    {
        //Seleção das Permissões de um Usuário 
        string script = "";
        script = " select p.Permissao, c.Descricao from permissoes p WITH(NOLOCK), " +
                 " cadpermissoes c WITH(NOLOCK) " +
                 " WHERE p.permissao = c.permissao " +
                 " and p.Login = " + Srelib.QStr(xusuario);
        //
        //Anexa Permissões que o usuário não possui
        if (xpermissoes != string.Empty)
        {
            script = script +
                     " UNION " +
                     " select c2.Permissao, c2.Descricao from cadpermissoes c2 WITH(NOLOCK) " +
                     " WHERE c2.permissao in (" + Srelib.QStr(xpermissoes) + ") " +
                     " group by Permissao, Descricao " +
                     " order by Permissao ";
        }
        //
        return SreDblib.GetDsScript(script);
    }

    public static DataSet LookUpCadPermissoes()
    {
        //Seleção de Todas as Permissões Cadastradas
        return SreDblib.GetDsScript("select Permissao, Descricao from cadpermissoes WITH(NOLOCK) order by Permissao ");
    }

    public static String PegaDescricao(string xnome)
    {
        //Pega Descrição de uma Permissão
        string script = "SELECT descricao FROM cadpermissoes WITH(NOLOCK) WHERE permissao = " + Srelib.QStr(xnome);
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static ASPxComboBox MontaComboPermissoes(ASPxComboBox pCombo, string pmodulo)
    {
        //Monta Combo de Todas as Permissões Cadastradas
        //return SreDblib.MontaComboPermissoes(pCombo, pmodulo);
        //
        string pTabela = "cadpermissoes";
        string pCampoExibe = "descricao";
        string pCampoValor = "permissao";
        Boolean pExibeValor = true;
        string pWhere = "";

        string script = "";
        script = " select c.Permissao, c.Descricao from cadpermissoes c WITH(NOLOCK) ";
        if (pmodulo != "")
        {
            switch (pmodulo)
            {
                case "PROPOSTAS":
                    script = script +
                             " where substring(c.Permissao,0,8) = " + Srelib.QStr("001.001") + "  ";
                    break;
                case "CLIENTES":
                    script = script +
                             " where substring(c.Permissao,0,8) = " + Srelib.QStr("001.002") + "  ";
                    break;
                case "PRODUTOS":
                    script = script +
                             " where substring(c.Permissao,0,8) = " + Srelib.QStr("001.003") + "  ";
                    break;
                case "VENDAS":
                    script = script +
                             " where substring(c.Permissao,0,8) = " + Srelib.QStr("001.004") + "  ";
                    break;
                case "PAGAMENTOS":
                    script = script +
                             " where substring(c.Permissao,0,8) = " + Srelib.QStr("001.005") + "  ";
                    break;
                case "A PAGAR":
                    script = script +
                             " where substring(c.Permissao,0,8) = " + Srelib.QStr("001.006") + "  ";
                    break;
                case "A RECEBER":
                    script = script +
                             " where substring(c.Permissao,0,8) = " + Srelib.QStr("001.007") + "  ";
                    break;
                case "BANCOS":
                    script = script +
                             " where substring(c.Permissao,0,8) = " + Srelib.QStr("001.008") + "  ";
                    break;
                case "FLUXO DE CAIXA":
                    script = script +
                             " where substring(c.Permissao,0,8) = " + Srelib.QStr("001.009") + "  ";
                    break;
                case "CONTÁBIL":
                    script = script +
                             " where substring(c.Permissao,0,8) = " + Srelib.QStr("001.010") + "  ";
                    break;
                case "CONFIG":
                    script = script +
                             " where substring(c.Permissao,0,8) = " + Srelib.QStr("001.011") + "  ";
                    break;
                case "AJUDA":
                    script = script +
                             " where substring(c.Permissao,0,8) = " + Srelib.QStr("001.012") + "  ";
                    break;
                case "EMPRESA":
                    script = script +
                             " where substring(c.Permissao,0,8) = " + Srelib.QStr("001.013") + "  ";
                    break;
                case "JURIDICO":
                    script = script +
                             " where substring(c.Permissao,0,8) = " + Srelib.QStr("001.014") + "  ";
                    break;
                case "OBRAS":
                    script = script +
                             " where substring(c.Permissao,0,8) = " + Srelib.QStr("001.015") + "  ";
                    break;
            }
        }
        //
        script = script + " order by c.Permissao ";
        //
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

    public static ASPxComboBox MontaComboModulos(ASPxComboBox pCombo, Boolean pExibeValor)
    {
        //Documentação - Chamada da Função
        //
        //uPermissoes.MontaComboModulos(ASPxComboBox1);
        //
        //Fim Documentação - Chamada da Função

        String[] modulos = new String[14] { "AJUDA",
                                            "EMPRESA",
                                            "CLIENTES",
                                            "OBRAS",
                                            "PRODUTOS",
                                            "PROPOSTAS",
                                            "VENDAS",
                                            "A PAGAR",
                                            "A RECEBER",
                                            "BANCOS",
                                            "FLUXO DE CAIXA",
                                            "CONTÁBIL",
                                            "JURIDICO",
                                            "CONFIG"};

        ListEditItem le;
        pCombo.Items.Clear();

        for (int i = 0; i <= 13; i++)
        {
            //
            le = new ListEditItem();
            if (pExibeValor)
            {
                le.Text = Srelib.QStr0(i.ToString().Trim(), 2) + " - " + modulos[i];
            }
            else
            {
                le.Text = modulos[i];
            };
            le.Value = i;
            pCombo.Items.Add(le);
        }

        return pCombo;
    }

    public static ASPxComboBox MontaComboPermissoesUsuario(ASPxComboBox pCombo, string xusuario, string xmodulo)
    {
        //Monta Combo de Todas as Permissões Cadastradas
        //return SreDblib.MontaCombo(pCombo, "permissoes", "permissao", "descricao", true, " where Login in (" + Srelib.QStr(xusuario) + ")");
        //
        string pTabela = "permissoes";
        string pCampoExibe = "descricao";
        string pCampoValor = "permissao";
        Boolean pExibeValor = true;
        string pWhere = "";

        string script = "";
        script = " select p.Permissao, c.Descricao from permissoes p WITH(NOLOCK), " +
                 " cadpermissoes c WITH(NOLOCK) " +
                 " WHERE p.permissao = c.permissao " +
                 " and Login in (" + Srelib.QStr(xusuario) + ") ";
        if (xmodulo != "")
        {
            switch (xmodulo)
            {
                case "PROPOSTAS":
                    script = script +
                             " and substring(p.Permissao,0,8) = " + Srelib.QStr("001.001") + "  ";
                    break;
                case "CLIENTES":
                    script = script +
                             " and substring(p.Permissao,0,8) = " + Srelib.QStr("001.002") + "  ";
                    break;
                case "PRODUTOS":
                    script = script +
                             " and substring(p.Permissao,0,8) = " + Srelib.QStr("001.003") + "  ";
                    break;
                case "VENDAS":
                    script = script +
                             " and substring(p.Permissao,0,8) = " + Srelib.QStr("001.004") + "  ";
                    break;
                case "PAGAMENTOS":
                    script = script +
                             " and substring(p.Permissao,0,8) = " + Srelib.QStr("001.005") + "  ";
                    break;
                case "A PAGAR":
                    script = script +
                             " and substring(p.Permissao,0,8) = " + Srelib.QStr("001.006") + "  ";
                    break;
                case "A RECEBER":
                    script = script +
                             " and substring(p.Permissao,0,8) = " + Srelib.QStr("001.007") + "  ";
                    break;
                case "BANCOS":
                    script = script +
                             " and substring(p.Permissao,0,8) = " + Srelib.QStr("001.008") + "  ";
                    break;
                case "FLUXO DE CAIXA":
                    script = script +
                             " and substring(p.Permissao,0,8) = " + Srelib.QStr("001.009") + "  ";
                    break;
                case "CONTÁBIL":
                    script = script +
                             " and substring(p.Permissao,0,8) = " + Srelib.QStr("001.010") + "  ";
                    break;
                case "CONFIG":
                    script = script +
                             " and substring(p.Permissao,0,8) = " + Srelib.QStr("001.011") + "  ";
                    break;
                case "AJUDA":
                    script = script +
                             " and substring(p.Permissao,0,8) = " + Srelib.QStr("001.012") + "  ";
                    break;
                case "EMPRESA":
                    script = script +
                             " and substring(p.Permissao,0,8) = " + Srelib.QStr("001.013") + "  ";
                    break;
                case "JURIDICO":
                    script = script +
                             " and substring(p.Permissao,0,8) = " + Srelib.QStr("001.014") + "  ";
                    break;
                case "OBRAS":
                    script = script +
                             " and substring(p.Permissao,0,8) = " + Srelib.QStr("001.015") + "  ";
                    break;
            }
        }
        script = script +
                 " group by p.Permissao, c.Descricao " +
                 " order by p.Permissao";

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

    public static DataSet PegaCadPermissoes()
    {
        //Monta DataSet de Todas as permissões cadastradas
        return SreDblib.GetDsScript("select permissao, descricao, obs, critica from cadpermissoes WITH(NOLOCK)");
    }

    public static DataSet PegaDadosCadPermissoes(string xnome)
    {
        //Pega Permissão específica
        string script;

        if (xnome == "")
        {
            script = "SELECT * FROM CadPermissoes WITH(NOLOCK)";
        }
        else
        {
            script = "SELECT * FROM CadPermissoes WITH(NOLOCK) WHERE permissao = " + Srelib.QStr(xnome);
        }

        return SreDblib.GetDsScript(script);

    }

    public static String Grava(string xlogin,
                               string xpermissao
                                )
    {

        if (xlogin != String.Empty)
        {
            string script = "INSERT INTO PERMISSOES VALUES ( " +
                            Srelib.QStr(xlogin) +
                            ", " + Srelib.QStr(xpermissao) +
                            " ) ";

            //" where nome=" + Rgblib.QStr(pParametro);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String GravaCadPermissao(string xpermissao,
                                           string xdescricao,
                                           string xobs,
                                           string xcritica)
    {

        if (xpermissao != String.Empty)
        {
            string script = "INSERT INTO CADPERMISSOES VALUES ( " +
                            Srelib.QStr(xpermissao) +
                            ", " + Srelib.QStr(xdescricao) +
                            ", " + Srelib.QStr(xobs) +
                            ", " + Srelib.QStr(xcritica) +
                            " ) ";

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String AlteraCadPermissao(string xpermissao,
                                            string xdescricao,
                                            string xobs,
                                            string xcritica)
    {

        if (xpermissao != String.Empty)
        {
            string script = "UPDATE CADPERMISSOES SET " +
                            " Descricao = " + Srelib.QStr(xdescricao) +
                            " ,obs = " + Srelib.QStr(xobs) +
                            " ,critica = " + Srelib.QStr(xcritica) +
                            " where Permissao = " + Srelib.QStr(xpermissao);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String ExcluiCadPermissao(string xpermissao)
    {

        if (xpermissao != String.Empty)
        {
            string script = "DELETE CADPERMISSOES  " +
                            " where Permissao = " + Srelib.QStr(xpermissao);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String ExcluiPermissoesUsuario(string xusuario,
                                                 string xmodulo,
                                                 string xpermissao)
    {
        if (xmodulo == String.Empty)
        {
            if (xpermissao != String.Empty)
            {
                string script = "DELETE PERMISSOES  " +
                                " where Login = " + Srelib.QStr(xusuario) +
                                " and Permissao not in (" + xpermissao + ") ";

                SreDblib.ExecScript(script);
            }
            else
            {
                string script = "DELETE PERMISSOES  " +
                                " where Login = " + Srelib.QStr(xusuario);

                SreDblib.ExecScript(script);
            }
        }
        else
        {
            if (xpermissao != String.Empty)
            {
                string script = "DELETE PERMISSOES  " +
                                " where Login = " + Srelib.QStr(xusuario);
                switch (xmodulo)
                {
                    case "PROPOSTAS":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.001") + "  ";
                        break;
                    case "CLIENTES":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.002") + "  ";
                        break;
                    case "PRODUTOS":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.003") + "  ";
                        break;
                    case "VENDAS":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.004") + "  ";
                        break;
                    case "PAGAMENTOS":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.005") + "  ";
                        break;
                    case "A PAGAR":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.006") + "  ";
                        break;
                    case "A RECEBER":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.007") + "  ";
                        break;
                    case "BANCOS":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.008") + "  ";
                        break;
                    case "FLUXO DE CAIXA":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.009") + "  ";
                        break;
                    case "CONTÁBIL":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.010") + "  ";
                        break;
                    case "CONFIG":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.011") + "  ";
                        break;
                    case "AJUDA":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.012") + "  ";
                        break;
                    case "EMPRESA":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.013") + "  ";
                        break;
                    case "JURIDICO":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.014") + "  ";
                        break;
                    case "OBRAS":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.015") + "  ";
                        break;
                }
                script = script + " and Permissao not in (" + xpermissao + ") ";

                SreDblib.ExecScript(script);
            }
            else
            {
                string script = "DELETE PERMISSOES  " +
                                " where Login = " + Srelib.QStr(xusuario);
                switch (xmodulo)
                {
                    case "PROPOSTAS":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.001") + "  ";
                        break;
                    case "CLIENTES":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.002") + "  ";
                        break;
                    case "PRODUTOS":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.003") + "  ";
                        break;
                    case "VENDAS":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.004") + "  ";
                        break;
                    case "PAGAMENTOS":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.005") + "  ";
                        break;
                    case "A PAGAR":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.006") + "  ";
                        break;
                    case "A RECEBER":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.007") + "  ";
                        break;

                    case "BANCOS":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.008") + "  ";
                        break;
                    case "FLUXO DE CAIXA":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.009") + "  ";
                        break;
                    case "CONTÁBIL":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.010") + "  ";
                        break;
                    case "CONFIG":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.011") + "  ";
                        break;
                    case "AJUDA":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.012") + "  ";
                        break;
                    case "EMPRESA":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.013") + "  ";
                        break;
                    case "JURIDICO":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.014") + "  ";
                        break;
                    case "OBRAS":
                        script = script +
                                 " and substring(Permissao,0,8) = " + Srelib.QStr("001.015") + "  ";
                        break;
                }
                //
                SreDblib.ExecScript(script);
            }
        }
        return " ";
    }

    public static String GravaPermissoesUsuario(string xusuario,
                                                string xmodulo,
                                                string xpermissao)
    {
        if (xmodulo == String.Empty)
        {
            //Apaga Todas relacionadas 1o.
            string script = "DELETE PERMISSOES  " +
                        " where Login = " + Srelib.QStr(xusuario) +
                        " and Permissao in (" + xpermissao + ") ";

            SreDblib.ExecScript(script);
            //
            //Inclui
            string[] permissoes = xpermissao.Split(',');
            //sql 2008 metodo insert multiplo
            if (xusuario != String.Empty)
            {
                script = "INSERT INTO PERMISSOES(Login,Permissao) VALUES ";
                //
                foreach (string xval in permissoes)
                {
                    script = script + " (" + Srelib.QStr(xusuario) +
                                      ", " + xval + " ), ";
                }
                script = script.Substring(0, script.Length - 2);
                //
                SreDblib.ExecScript(script);
            }
        }
        else
        {
            //Apaga Todas relacionadas 1o.
            string script = "DELETE PERMISSOES  " +
                        " where Login = " + Srelib.QStr(xusuario);
            switch (xmodulo)
            {
                case "PROPOSTAS":
                    script = script +
                             " and substring(Permissao,0,8) = " + Srelib.QStr("001.001") + "  ";
                    break;
                case "CLIENTES":
                    script = script +
                             " and substring(Permissao,0,8) = " + Srelib.QStr("001.002") + "  ";
                    break;
                case "PRODUTOS":
                    script = script +
                             " and substring(Permissao,0,8) = " + Srelib.QStr("001.003") + "  ";
                    break;
                case "VENDAS":
                    script = script +
                             " and substring(Permissao,0,8) = " + Srelib.QStr("001.004") + "  ";
                    break;
                case "PAGAMENTOS":
                    script = script +
                             " and substring(Permissao,0,8) = " + Srelib.QStr("001.005") + "  ";
                    break;
                case "A PAGAR":
                    script = script +
                             " and substring(Permissao,0,8) = " + Srelib.QStr("001.006") + "  ";
                    break;
                case "A RECEBER":
                    script = script +
                             " and substring(Permissao,0,8) = " + Srelib.QStr("001.007") + "  ";
                    break;

                case "BANCOS":
                    script = script +
                             " and substring(Permissao,0,8) = " + Srelib.QStr("001.008") + "  ";
                    break;
                case "FLUXO DE CAIXA":
                    script = script +
                             " and substring(Permissao,0,8) = " + Srelib.QStr("001.009") + "  ";
                    break;
                case "CONTÁBIL":
                    script = script +
                             " and substring(Permissao,0,8) = " + Srelib.QStr("001.010") + "  ";
                    break;
                case "CONFIG":
                    script = script +
                             " and substring(Permissao,0,8) = " + Srelib.QStr("001.011") + "  ";
                    break;
                case "AJUDA":
                    script = script +
                             " and substring(Permissao,0,8) = " + Srelib.QStr("001.012") + "  ";
                    break;
                case "EMPRESA":
                    script = script +
                             " and substring(Permissao,0,8) = " + Srelib.QStr("001.013") + "  ";
                    break;
                case "JURIDICO":
                    script = script +
                             " and substring(Permissao,0,8) = " + Srelib.QStr("001.014") + "  ";
                    break;
                case "OBRAS":
                    script = script +
                             " and substring(Permissao,0,8) = " + Srelib.QStr("001.015") + "  ";
                    break;
            }
            script = script + " and Permissao in (" + xpermissao + ") ";

            SreDblib.ExecScript(script);
            //
            //Inclui
            string[] permissoes = xpermissao.Split(',');
            //sql 2008 metodo insert multiplo
            if (xusuario != String.Empty)
            {
                script = "INSERT INTO PERMISSOES(Login,Permissao) VALUES ";
                //
                foreach (string xval in permissoes)
                {
                    script = script + " (" + Srelib.QStr(xusuario) +
                                      ", " + xval + " ), ";
                }
                script = script.Substring(0, script.Length - 2);
                //
                SreDblib.ExecScript(script);
            }
        }
        return " ";
    }


    public uPermissoes()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;

/// <summary>
/// Summary description for uUsuario
/// </summary>
public class uUsuario
{
    //Perfil = 0 = Usuário
    //Perfil = 1 = Perfil de Usuário, não faz login

    public static DataSet LookUpUsuario()
    {
        return SreDblib.GetDsScript("select login from usuario WITH(NOLOCK) WHERE perfil = 0");
    }

    public static DataSet LookUpPerfil()
    {
        return SreDblib.GetDsScript("select login from usuario WITH(NOLOCK) WHERE perfil = 1");
    }

    public static String PegaNome(string xlogin)
    {
        string script = "SELECT Nome FROM usuario WITH(NOLOCK) WHERE login = " + Srelib.QStr(xlogin);
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static ASPxComboBox MontaComboUsuarios(ASPxComboBox pCombo)
    {
        return SreDblib.MontaCombo(pCombo, "usuario", "login", "login", false, " WHERE perfil = 0 ");
    }

    public static ASPxComboBox MontaComboPerfil(ASPxComboBox pCombo)
    {
        return SreDblib.MontaCombo(pCombo, "usuario", "login", "login", false, " WHERE perfil = 1 ");
    }

    public static DataSet PegaUsuarios()
    {
        return SreDblib.GetDsScript("select login, nome, funcao from usuario WITH(NOLOCK) WHERE perfil = 0");
    }

    public static DataSet PegaPerfil()
    {
        return SreDblib.GetDsScript("select login, nome, funcao from usuario WITH(NOLOCK) WHERE perfil = 1");
    }

    public static DataSet PegaDadosUsuario(string xlogin)
    {
        string script;

        if (xlogin == "")
        {
            script = "SELECT * FROM usuario WITH(NOLOCK) WHERE perfil = 0";
        }
        else
        {
            script = "SELECT * FROM usuario WITH(NOLOCK) WHERE perfil = 0 and login = " + Srelib.QStr(xlogin);
        }

        return SreDblib.GetDsScript(script);

    }

    public static DataSet PegaDadosPerfil(string xlogin)
    {
        string script;

        if (xlogin == "")
        {
            script = "SELECT * FROM usuario WITH(NOLOCK) WHERE perfil = 1";
        }
        else
        {
            script = "SELECT * FROM usuario WITH(NOLOCK) WHERE perfil = 1 and login = " + Srelib.QStr(xlogin);
        }

        return SreDblib.GetDsScript(script);

    }


    public static String Grava(string xlogin,
                                string xsenha,
                                string xnome,
                                string xsetor,
                                string xfuncao,
                                string xfone,
                                Int32 xperfil,
                                string xemail,
                                string xalcada,
                                Boolean xativo
                                )
    {

        if (xlogin != String.Empty)
        {
            if (!SreDblib.TemNaTabela("select * from usuario with(nolock) where login = " + Srelib.QStr(xlogin)))
            {
                if (xsenha == String.Empty)
                {
                    xsenha = "INATIVO";
                    xativo = false;
                }

                string script = "INSERT INTO USUARIO VALUES ( " +
                                Srelib.QStr(xlogin) +
                                ", " + Srelib.QStr(xsenha) +
                                ", " + Srelib.QStr(xnome) +
                                ", " + Srelib.QStr(xsetor) +
                                ", " + Srelib.QStr(xfuncao) +
                                ", " + Srelib.QStr(xfone) +
                                ", " + Convert.ToString(xperfil) +
                                ", " + Srelib.QStr(xemail) +
                                ", " + Srelib.QStr(xalcada) +
                                ", " + Convert.ToString(Convert.ToInt16(xativo)) +
                                ", " + Srelib.QStr("") + 
                                " ) ";

                //" where nome=" + Rgblib.QStr(pParametro);

                SreDblib.ExecScript(script);
            }

        }
        return " ";
    }

    public static String Altera(string xlogin,
                                string xsenha,
                                string xnome,
                                string xsetor,
                                string xfuncao,
                                string xfone,
                                Int32 xperfil,
                                string xemail,
                                string xalcada,
                                Boolean xativo
                                )
    {

        if (xlogin != String.Empty)
        {
            string script = "UPDATE USUARIO SET " +
                            " Senha = " + Srelib.QStr(xsenha) +
                            " ,Nome =  " + Srelib.QStr(xnome) +
                            " ,Setor = " + Srelib.QStr(xsetor) +
                            " ,Funcao =  " + Srelib.QStr(xfuncao) +
                            " ,Fone = " + Srelib.QStr(xfone) +
                            " ,email =  " + Srelib.QStr(xemail) +
                            " ,alcada = " + Srelib.QStr(xalcada) +
                            " ,ativo =  " + Convert.ToString(Convert.ToInt16(xativo)) +
                            " where Login = " + Srelib.QStr(xlogin);


            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String Exclui(string xlogin)
    {

        if (xlogin != String.Empty)
        {
            string script = "DELETE USUARIO  " +
                            " where Login = " + Srelib.QStr(xlogin);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public uUsuario()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
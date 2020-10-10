using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DevExpress.Web.ASPxEditors;


/// <summary>
/// Summary description for uEmpresa
/// </summary>
public class uEmpresa
{

    public static DataSet LookUpEmpresa()
    {
        return SreDblib.GetDsScript("select apelido from empresa with (nolock)");
    }


    public static ASPxComboBox MontaComboEmpresa(ASPxComboBox pCombo)
    {
        return SreDblib.MontaCombo(pCombo, "empresa", "apelido", "apelido", false, "");
    }


    public static ASPxListBox MontaListFullCkEmpresa(ASPxListBox pListBox)
    {
        //Documentação - Chamada da Função
        //
        //String[] Campos = { "tipo", "descricao", "apelido" };
        //uEmpresa.MontaListFullCkEmpresa(ListBoxModelo)
        //
        //
        //uEmpresa.MontaListFullCkEmpresa(ListBoxModelo);
        //
        //Todas as Caracteristicas do Combo são montadas na Classe, a chamada passa do combo vazio.
        //1o. Campo da Lista é um CheckBox
        //Setar SelectionMode para CheckColumn
        //Fim Documentação - Chamada da Função

        return SreDblib.MontaListMultCk(pListBox, "empresa", "apelido", "apelido", false);

    }

    public static String PegaMatriz()
    {
        string script = "SELECT apelido FROM empresa WITH(NOLOCK) WHERE matriz = " + Srelib.QStr("true");
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return " ";
        }

    }

    public static String PegaNome(string xemp)
    {
        string script = "SELECT nome FROM empresa WITH(NOLOCK) WHERE apelido = " + Srelib.QStr(xemp);
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return " ";
        }

    }

    public static String PegaCidade(string xemp)
    {
        string script = "SELECT cidadecom FROM empresa WITH(NOLOCK) WHERE apelido = " + Srelib.QStr(xemp);
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return " ";
        }

    }

    public static String PegaEstado(string xemp)
    {
        string script = "SELECT ufcom FROM empresa WITH(NOLOCK) WHERE apelido = " + Srelib.QStr(xemp);
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return " ";
        }

    }

    public static String PegaEmail(string xemp)
    {
        string script = "SELECT emailemp FROM empresa WITH(NOLOCK) WHERE apelido = " + Srelib.QStr(xemp);
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return " ";
        }

    }

    public static String PegaCnpj(string xemp)
    {
        string script = "SELECT cnpj FROM empresa WITH(NOLOCK) WHERE apelido = " + Srelib.QStr(xemp);
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return " ";
        }

    }
    public void AutenticaEmail(string wempresa, ref bool wckemail, ref bool wckssl, ref string wsmtpporta, ref string wlogin, ref string wsenha, ref bool wcktls)
    {

        String script = "SELECT ckemail, ckssl, smtpporta, login, senha, cktls " +
                        "FROM empresa WITH(NOLOCK) " +
                        "WHERE apelido = " + Srelib.QStr(wempresa);
        DataSet ds = SreDblib.GetDsScript(script);


        if (ds.Tables[0].Rows.Count == 0)
        {
            wckemail = false;
            wsmtpporta = "";
            wlogin = "";
            wsenha = "";
            wckssl = false;
            wcktls = false;
        }
        else
        {
            wckemail = Convert.ToBoolean(ds.Tables[0].Rows[0]["ckemail"].ToString());
            wckssl = Convert.ToBoolean(ds.Tables[0].Rows[0]["ckssl"].ToString());
            wcktls = Convert.ToBoolean(ds.Tables[0].Rows[0]["cktls"].ToString());
            wsmtpporta = ds.Tables[0].Rows[0]["smtpporta"].ToString();
            wlogin = ds.Tables[0].Rows[0]["login"].ToString();
            wsenha = ds.Tables[0].Rows[0]["senha"].ToString();
        }
        ds.Clear();
    }

    public static DataSet PegaDadosEmpresa(string xapelido)
    {
        string script;

        if (xapelido == "")
        {
            script = "SELECT * FROM Empresa WITH(NOLOCK)";
        }
        else
        {
            if (xapelido.Trim().Substring(0, 1) == "'")
            {
                script = "SELECT * FROM Empresa WITH(NOLOCK) WHERE apelido in (" + xapelido + ")";
            }
            else
            {
                script = "SELECT * FROM Empresa WITH(NOLOCK) WHERE apelido in (" + Srelib.QStr(xapelido) + ")";
            }
        }

        return SreDblib.GetDsScript(script);

    }

    public static String Grava(string xapelido,
                                string xnome,
                                string xcnpj,
                                Boolean xmatriz,
                                string xinscmunicipal,
                                string xinscestadual,
                                string xregjuntacom,
                                string xnire,
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
                                string xconta5
                                )
    {

        if (xapelido != String.Empty)
        {
            string script = "INSERT INTO EMPRESA VALUES ( " +
                            Srelib.QStr(xapelido) +
                            ", " + Srelib.QStr(xnome) +
                            ", " + Srelib.QStr(xcnpj) +
                            ", " + Convert.ToString(Convert.ToInt16(xmatriz)) +
                            ", " + Srelib.QStr(xinscmunicipal) +
                            ", " + Srelib.QStr(xinscestadual) +
                            ", " + Srelib.QStr(xregjuntacom) +
                            ", " + Srelib.QStr(xnire) +
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
                            ", " + Srelib.QStr(xobs1) +
                            ", " + Srelib.QStr(xobs2) +
                            ", " + Srelib.QStr(xobs3) +
                            ", " + Srelib.QStr(xobs4) +
                            ", " + Srelib.QStr(xobs5) +
                            ", " + Srelib.QStr(xinstrcob1) +
                            ", " + Srelib.QStr(xinstrcob2) +
                            ", " + Srelib.QStr(xdiasprotesto) +
                            ", " + Srelib.QStr(xconta1) +
                            ", " + Srelib.QStr(xconta2) +
                            ", " + Srelib.QStr(xconta3) +
                            ", " + Srelib.QStr(xconta4) +
                            ", " + Srelib.QStr(xconta5) +
                            " ) ";

            //" where nome=" + Rgblib.QStr(pParametro);

            SreDblib.ExecScript(script);
        }
        return " ";
    }


    public static String Altera(string xID,
                                string xapelido,
                                string xnome,
                                string xcnpj,
                                Boolean xmatriz,
                                string xinscmunicipal,
                                string xinscestadual,
                                string xregjuntacom,
                                string xnire,
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
                                string xconta5
                                )
    {

        string script = "UPDATE EMPRESA SET " +
                        " apelido = " + Srelib.QStr(xapelido) +
                        " ,nome = " + Srelib.QStr(xnome) +
                        " ,cnpj = " + Srelib.QStr(xcnpj) +
                        " ,matriz = " + Convert.ToString(Convert.ToInt16(xmatriz)) +
                        " ,inscmunicipal = " + Srelib.QStr(xinscmunicipal) +
                        " ,inscestadual = " + Srelib.QStr(xinscestadual) +
                        " ,regjuntacom = " + Srelib.QStr(xregjuntacom) +
                        " ,nire = " + Srelib.QStr(xnire) +
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
                        " where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String Exclui(string xID)
    {

        string script = "DELETE EMPRESA where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String TrocaApelido(string xEmpresa,
                             string xEmpresaNovo)
    {

        ////Via Proc
        //SqlParameter[] parametros = { new SqlParameter("@novo", xEmpresaNovo), 
        //                              new SqlParameter("@velho" , xEmpresa) };

        //SreDblib.ExecSp("TROCA_APELIDO_EMPRESA", parametros);

        string script = "UPDATE EMPRESA SET " + 
                        " apelido = " + Srelib.QStr(xEmpresaNovo) +
                        " where apelido = " + Srelib.QStr(xEmpresa);

        SreDblib.ExecScript(script);

        return " ";
    }

    public uEmpresa()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
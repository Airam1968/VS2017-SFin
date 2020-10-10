using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DevExpress.Web.ASPxEditors;

/// <summary>
/// Summary description for uMensagemBoleto
/// </summary>
public class uMensagemBoleto
{

    public static DataSet PegaDadosMensagemBoleto(Int32 xID)
    {
        string script;

        if (xID == 0)
        {
            script = "SELECT * FROM boleto_mensagens WITH(NOLOCK) order by produto, codigo";
        }
        else
        {
            script = "SELECT * FROM boleto_mensagens WITH(NOLOCK) WHERE id = " + Convert.ToString(xID) + " order by produto, codigo";
        }

        return SreDblib.GetDsScript(script);

    }

    public static String Grava(string xcodigo,
                               string xproduto,
                               string xlinha1,
                               string xlinha2,
                               string xlinha3,
                               string xlinha4,
                               string xlinha5
                                            )
    {


        if (xproduto == "")
            xproduto = "0";

        if ((xcodigo != String.Empty) && (xproduto != String.Empty))
        {
            string script = "INSERT INTO boleto_mensagens VALUES ( " +
                            xcodigo +
                            ", " + xproduto +
                            ", " + Srelib.QStr(xlinha1) +
                            ", " + Srelib.QStr(xlinha2) +
                            ", " + Srelib.QStr(xlinha3) +
                            ", " + Srelib.QStr(xlinha4) +
                            ", " + Srelib.QStr(xlinha5) +
                            " ) ";

            //" where nome=" + Rgblib.QStr(pParametro);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static int PegaNovoCodigo()
    {
        //Pega Novo Codigo
        string script = "SELECT MAX(codigo)+1 MNUM FROM boleto_mensagens WITH(NOLOCK)";
        return Convert.ToInt16(SreDblib.GetCampoScript(script)); ;
        //
    }

    public static String Altera(string xID,
                                string xcodigo,
                                string xproduto,
                                string xlinha1,
                                string xlinha2,
                                string xlinha3,
                                string xlinha4,
                                string xlinha5)
    {

        string script = "UPDATE boleto_mensagens SET " +
                        " codigo = " + Srelib.QStr(xcodigo) +
                        " ,produto = " + Srelib.QStr(xproduto) +
                        " ,linha1 = " + Srelib.QStr(xlinha1) +
                        " ,linha2 = " + Srelib.QStr(xlinha2) +
                        " ,linha3 = " + Srelib.QStr(xlinha3) +
                        " ,linha4 = " + Srelib.QStr(xlinha4) +
                        " ,linha5 = " + Srelib.QStr(xlinha5) +
                        " where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }


    public static String Exclui(string xID)
    {

        string script = "DELETE boleto_mensagens where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String PegaMensagens(string xID,
                                        ref string msg1,
                                        ref string msg2,
                                        ref string msg3,
                                        ref string msg4,
                                        ref string msg5)
    {
        DataSet ds;

        string script = "select * from boleto_mensagens " +
                        " with(nolock) " +
                        " where codigo = " + xID;
        string retorno = "";

        ds = SreDblib.GetDsScript(script);

        try
        {
            msg1 = ds.Tables[0].Rows[0]["linha1"].ToString().Trim() + Srelib.replicate(" ", 80);
            msg2 = ds.Tables[0].Rows[0]["linha2"].ToString().Trim() + Srelib.replicate(" ", 80);
            msg3 = ds.Tables[0].Rows[0]["linha3"].ToString().Trim() + Srelib.replicate(" ", 80);
            msg4 = ds.Tables[0].Rows[0]["linha4"].ToString().Trim() + Srelib.replicate(" ", 80);
            msg5 = ds.Tables[0].Rows[0]["linha5"].ToString().Trim() + Srelib.replicate(" ", 80);
        }
        catch (Exception)
        {
            retorno = "";
        }


        return retorno;

    }

    public uMensagemBoleto()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
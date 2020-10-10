using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;

/// <summary>
/// Summary description for uGerente
/// </summary>
public class uBanco
{

    public static DataSet PegaDadosBancos(Int32 xID)
    {
        string script;

        if (xID == 0)
        {
            script = "SELECT * FROM bancos WITH(NOLOCK) order by cod_banco";
        }
        else
        {
            script = "SELECT * FROM bancos WITH(NOLOCK) WHERE cod_banco = " + Convert.ToString(xID) + " order by cod_banco";
        }

        return SreDblib.GetDsScript(script);

    }

    public static DataSet LookUpBanco()
    {
        return SreDblib.GetDsScript("select apelido from bancos");
    }

    public static ASPxComboBox MontaComboBanco(ASPxComboBox pCombo)
    {
        //Documentação - Chamada da Função
        //
        //uBanco.MontaComboBanco(ASPxComboBox1);
        //
        //Fim Documentação - Chamada da Função


        return SreDblib.MontaCombo(pCombo, "bancos", "nome", "cod_banco", true, " order by cod_banco ");

    }

    public static String PegaNomeID(string xID)
    {
        string script = "SELECT nome FROM BANCOS WITH(NOLOCK) WHERE ID = " + xID;
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static String PegaNomeCodigo(string xID)
    {
        string script = "SELECT nome FROM BANCOS WITH(NOLOCK) WHERE cod_banco = " + xID;
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static String PegaIDCodigo(string xcodigo)
    {
        string script = "SELECT ID FROM BANCOS WITH(NOLOCK) WHERE cod_banco = " + Srelib.QStr(xcodigo);
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static String PegaCodigoID(string xID)
    {
        string script = "SELECT cod_banco FROM BANCOS WITH(NOLOCK) WHERE ID = " + Srelib.QStr(xID);
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }


    public static String PegaCaminhoRemessa(string xID)
    {
        DataSet ds;

        string script = "select * from BANCOS " +
                        " with(nolock) " +
                        " where cod_banco = " + xID;
        string retorno = "";

        ds = SreDblib.GetDsScript(script);

        try
        {
            retorno = ds.Tables[0].Rows[0]["drive"].ToString().Trim() + ":" +
                      ds.Tables[0].Rows[0]["pasta_remessa"].ToString().Trim();
        }
        catch (Exception)
        {
            retorno = "";
        }


        return retorno;
    }

    public static String PegaCaminhoRetorno(string xID)
    {
        DataSet ds;

        string script = "select * from BANCOS " +
                        " with(nolock) " +
                        " where cod_banco = " + xID;
        string retorno = "";

        ds = SreDblib.GetDsScript(script);

        try
        {
            retorno = ds.Tables[0].Rows[0]["drive"].ToString().Trim() + ":" +
                      ds.Tables[0].Rows[0]["pasta_retorno"].ToString().Trim();
        }
        catch (Exception)
        {
            retorno = "";
        }

        return retorno;
    }

    public static String PegaExtensaoRemessa(string xID)
    {
        DataSet ds;

        string script = "select * from BANCOS " +
                        " with(nolock) " +
                        " where cod_banco = " + xID;
        string retorno = "";

        ds = SreDblib.GetDsScript(script);

        try
        {
            retorno = ds.Tables[0].Rows[0]["mascara_remessa"].ToString().Trim();
        }
        catch (Exception)
        {
            retorno = "";
        }


        return retorno;
    }


    public static String PegaExtensaoRetorno(string xID)
    {
        DataSet ds;

        string script = "select * from BANCOS " +
                        " with(nolock) " +
                        " where cod_banco = " + xID;
        string retorno = "";

        ds = SreDblib.GetDsScript(script);

        try
        {
            retorno = ds.Tables[0].Rows[0]["mascara_retorno"].ToString().Trim();
        }
        catch (Exception)
        {
            retorno = "";
        }


        return retorno;
    }

    public static String PegaNumeroArquivo(string xID)
    {
        string script = "select sequencia from BANCOS " +
                        " with(nolock) " +
                        " where cod_banco = " + xID;
        string retorno = "";
        try
        {
            retorno = SreDblib.GetCampoScript(script);
        }
        catch (Exception)
        {
            retorno = "";
        }
        return retorno;
    }

    public static String PegaCaixaPostal(string xID)
    {
        string script = "SELECT caixa_postal FROM BANCOS WITH(NOLOCK) WHERE cod_banco = " + xID;
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static String PegaCarteira(string xID)
    {
        string script = "SELECT carteira FROM BANCOS WITH(NOLOCK) WHERE cod_banco = " + xID;
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static String PegaArquivoNumero(string xID)
    {
        string script = "SELECT numero_arquivo FROM BANCOS WITH(NOLOCK) WHERE cod_banco = " + xID;
        try
        {
            string yID = SreDblib.GetCampoScript(script);
            IncrementaArquivoNumero(yID);
            return yID;
        }
        catch
        {
            return "";
        }
    }


    public static void IncrementaArquivoNumero(string xID)
    {
        string script = "UPDATE BANCOS SET (numero_arquivo = numero_arquivo + 1) WHERE cod_banco = " + xID;
        SreDblib.ExecScript(script);

    }

    public static String PegaAssunto(string xID)
    {
        string script = "SELECT assunto FROM BANCOS WITH(NOLOCK) WHERE cod_banco = " + xID;
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }


    public static String PegaMulta(string xID)
    {
        string script = "SELECT multa FROM BANCOS WITH(NOLOCK) WHERE cod_banco = " + xID;
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static String PegaComissao(string xID)
    {
        string script = "SELECT comissao FROM BANCOS WITH(NOLOCK) WHERE cod_banco = " + xID;
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static String PegaJuros(string xID)
    {
        string script = "SELECT juros FROM BANCOS WITH(NOLOCK) WHERE cod_banco = " + xID;
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static String PegaSequencia(string xID)
    {
        string script = "SELECT sequencia FROM BANCOS WITH(NOLOCK) WHERE cod_banco = " + xID;
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static String PegaPrazoFolga(string xID)
    {
        string script = "SELECT prazo_fol FROM BANCOS WITH(NOLOCK) WHERE cod_banco = " + xID;
        try
        {
            return Srelib.QStr0(SreDblib.GetCampoScript(script).Trim(), 2);
        }
        catch
        {
            return "";
        }
    }

    public static String PegaPrazoProtesto(string xID)
    {
        string script = "SELECT prazo_pro FROM BANCOS WITH(NOLOCK) WHERE cod_banco = " + xID;
        try
        {
            return Srelib.QStr0(SreDblib.GetCampoScript(script).Trim(), 2);
        }
        catch
        {
            return "";
        }
    }

    public static String PegaPrazoDevolucao(string xID)
    {
        string script = "SELECT prazo_dev FROM BANCOS WITH(NOLOCK) WHERE cod_banco = " + xID;
        try
        {
            return Srelib.QStr0(SreDblib.GetCampoScript(script).Trim(), 2);
        }
        catch
        {
            return "";
        }
    }

    public static String Grava(string xcod_banco,
                                string xnome,
                                DateTime xdata,
                                string xdrive,
                                string xpasta_remessa,
                                string xpasta_retorno,
                                string xpasta_envelope,
                                string xassunto,
                                string xcaixa_postal,
                                string xmascara_remessa,
                                string xmascara_retorno,
                                string xnome_arquivo,
                                string xnumero_arquivo,
                                string xprazo_fol,
                                string xprazo_dev,
                                string xprazo_pro,
                                string xmulta,
                                string xjuros,
                                string xcomissao,
                                string xcarteira,
                                string xnum_inicial,
                                string xnum_final,
                                string xsequencia,
                                string xnumero_atual,
                                string xcomplemento)
    {

        if (xcod_banco != String.Empty)
        {
            string script = "INSERT INTO BANCOS VALUES ( " +
                            Srelib.QStr(xcod_banco) +
                            ", " + Srelib.QStr(xnome) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xdata))) +
                            ", " + Srelib.QStr(xdrive) +
                            ", " + Srelib.QStr(xpasta_remessa) +
                            ", " + Srelib.QStr(xpasta_retorno) +
                            ", " + Srelib.QStr(xpasta_envelope) +
                            ", " + Srelib.QStr(xassunto) +
                            ", " + Srelib.QStr(xcaixa_postal) +
                            ", " + Srelib.QStr(xmascara_remessa) +
                            ", " + Srelib.QStr(xmascara_retorno) +
                            ", " + Srelib.QStr(xnome_arquivo) +
                            ", " + xnumero_arquivo +
                            ", " + xprazo_fol +
                            ", " + xprazo_dev +
                            ", " + xprazo_pro +
                            ", " + Srelib.forcaponto(xmulta) +
                            ", " + Srelib.forcaponto(xjuros) +
                            ", " + Srelib.forcaponto(xcomissao) +
                            ", " + Srelib.QStr(xcarteira) +
                            ", " + xnum_inicial +
                            ", " + xnum_final +
                            ", " + xsequencia +
                            ", " + xnumero_atual +
                            ", " + Srelib.QStr(xcomplemento) +
                            " ) ";

            //" where nome=" + Rgblib.QStr(pParametro);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String AlteraBanco(string xID,
                                    string xcod_banco,
                                    string xnome,
                                    DateTime xdata,
                                    string xdrive,
                                    string xpasta_remessa,
                                    string xpasta_retorno,
                                    string xpasta_envelope,
                                    string xassunto,
                                    string xcaixa_postal,
                                    string xmascara_remessa,
                                    string xmascara_retorno,
                                    string xnome_arquivo,
                                    string xnumero_arquivo,
                                    string xprazo_fol,
                                    string xprazo_dev,
                                    string xprazo_pro,
                                    string xmulta,
                                    string xjuros,
                                    string xcomissao,
                                    string xcarteira,
                                    string xnum_inicial,
                                    string xnum_final,
                                    string xsequencia,
                                    string xnumero_atual,
                                    string xcomplemento)
    {

        string script = " UPDATE BANCOS SET " +
                        " cod_banco = " + Srelib.QStr(xcod_banco) +
                        " ,nome = " + Srelib.QStr(xnome) +
                        " ,data = " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xdata))) +
                        " ,drive = " + Srelib.QStr(xdrive) +
                        " ,pasta_remessa = " + Srelib.QStr(xpasta_remessa) +
                        " ,pasta_retorno = " + Srelib.QStr(xpasta_retorno) +
                        " ,pasta_envelope = " + Srelib.QStr(xpasta_envelope) +
                        " ,assunto = " + Srelib.QStr(xassunto) +
                        " ,caixa_postal = " + Srelib.QStr(xcaixa_postal) +
                        " ,mascara_remessa = " + Srelib.QStr(xmascara_remessa) +
                        " ,mascara_retorno = " + Srelib.QStr(xmascara_retorno) +
                        " ,nome_arquivo = " + Srelib.QStr(xnome_arquivo) +
                        " ,numero_arquivo = " + Srelib.QStr(xnumero_arquivo) +
                        " ,prazo_fol = " + xprazo_fol +
                        " ,prazo_dev = " + xprazo_dev +
                        " ,prazo_pro = " + xprazo_pro +
                        " ,multa = " + Srelib.forcaponto(xmulta) +
                        " ,juros = " + Srelib.forcaponto(xjuros) +
                        " ,comissao = " + Srelib.forcaponto(xcomissao) +
                        " ,carteira = " + Srelib.QStr(xcarteira) +
                        " ,num_inicial = " + xnum_inicial +
                        " ,num_final = " + xnum_final +
                        " ,sequencia = " + xsequencia +
                        " ,numero_atual = " + xnumero_atual +
                        " ,complemento = " + Srelib.QStr(xcomplemento) +
                        " where ID =" + xID;

        //revisar quando mexer na cobrança bancária

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String ExcluiBanco(string xID)
    {

        string script = "DELETE BANCOS where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }


    public uBanco()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
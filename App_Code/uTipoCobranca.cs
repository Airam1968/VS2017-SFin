using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;

/// <summary>
/// Summary description for uTipoCobranca
/// </summary>
public class uTipoCobranca
{

    public static DataSet LookUpTcobran(string pTipo)
    {
        //Tipo = C = cheques
        //Tipo = D = Duplicatas
        //Tipo <> C e D = Todos

        string _condicao = "";

        if (pTipo == "D")
        {
            _condicao = " CKDP = 1 ";
        }

        if (pTipo == "C")
        {
            _condicao = " CKCH = 1 ";
        }

        if ((pTipo != "C") && (pTipo != "D"))
        {
            _condicao = " CKCH = 1 and CKDP = 1 ";
        }

        return SreDblib.GetDsScript("select tipo, descricao from tcobran where " + _condicao + "order by tipo");

    }


    public static String PegaApelido(string xdoc)
    {
        string script = "SELECT apelido FROM tcobran WITH(NOLOCK) WHERE tipo = " + Srelib.QStr(xdoc);
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static ASPxComboBox MontaComboTipoCobranca(ASPxComboBox pCombo)
    {
        if (SreDblib.GetParametro("CBTC_NOME") == "SIM")
        {
            return SreDblib.MontaCombo(pCombo, "tcobran", "descricao", "tipo", true, "");
        }
        else
        {
            return SreDblib.MontaCombo(pCombo, "tcobran", "apelido", "tipo", true, "");
        }
    }

    public static ASPxComboBox MontaComboTipoCobrancaTit(ASPxComboBox pCombo, string pTipo)
    {
        //Tipo = C  = cheques
        //Tipo = D  = Duplicatas
        //Tipo = "" = Todos

        ASPxComboBox retorno;

        if (pTipo == "")
        {
            if (SreDblib.GetParametro("CBTC_NOME") == "SIM")
            {
                retorno = SreDblib.MontaComboFiltra(pCombo, "tcobran", "descricao", "tipo", true, " CKCH = 1 and CKDP = 1 ");
            }
            else
            {
                retorno = SreDblib.MontaComboFiltra(pCombo, "tcobran", "apelido", "tipo", true, " CKCH = 1 and CKDP = 1 ");
            }
        }
        else
        {
            if (pTipo == "D")
            {
                if (SreDblib.GetParametro("CBTC_NOME") == "SIM")
                {
                    retorno = SreDblib.MontaComboFiltra(pCombo, "tcobran", "descricao", "tipo", true, " CKDP = 1 ");
                }
                else
                {
                    retorno = SreDblib.MontaComboFiltra(pCombo, "tcobran", "apelido", "tipo", true, " CKDP = 1 ");
                }
            }
            else
            //if (pTipo == "C")
            {
                if (SreDblib.GetParametro("CBTC_NOME") == "SIM")
                {
                    retorno = SreDblib.MontaComboFiltra(pCombo, "tcobran", "descricao", "tipo", true, " CKCH = 1 ");
                }
                else
                {
                    retorno = SreDblib.MontaComboFiltra(pCombo, "tcobran", "apelido", "tipo", true, " CKCH = 1 ");
                }
            }

        }

        return retorno;
    }
}
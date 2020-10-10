using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;

/// <summary>
/// Summary description for uLog
/// </summary>
public class uLog
{

    public static string MakeLog(SqlParameter[] parameterslog)
    {
        //MAKELOG
        return SreDblib.ExecSp("makelog", parameterslog);
        //
    }


    public static ASPxComboBox MontaComboAcao(ASPxComboBox pCombo)
    {
        //
        return SreDblib.MontaCombo(pCombo, "log", "obs", "obs", false, " group by obs order by obs");
    }

    public static ASPxComboBox MontaComboModulo(ASPxComboBox pCombo)
    {
        //
        return SreDblib.MontaCombo(pCombo, "log", "Operacao", "Operacao", false, " group by Operacao order by Operacao");
    }

    public static DataSet LookUpLog(string xusuario,
                                    string xData1,
                                    string xData2,
                                    string xModulo,
                                    string xAcao,
                                    string xComplementoAcao)
    {
        //
        string script;

        if (xusuario == "")
        {
            script = "SELECT * FROM log WITH(NOLOCK) WHERE (DataHora >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                     " and DataHora <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") ";

        }
        else
        {
            script = "SELECT * FROM log WITH(NOLOCK) WHERE Login = " + Srelib.QStr(xusuario) +
                     " and (DataHora >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + " and DataHora <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") ";
        }

        if (xModulo != "")
        {
            script = script + " and (operacao = " + Srelib.QStr(xModulo.ToUpper()) + ") ";
        }

        if (xAcao != "")
        {
            script = script + " and (obs = " + Srelib.QStr(xAcao.ToUpper()) + ") ";
        }

        if (xComplementoAcao != "")
        {
            script = script + " and (obs like " + Srelib.QStr("%" + xComplementoAcao.ToUpper() + "%") + ") ";
        }

        script = script + " order by DataHora";

        return SreDblib.GetDsScript(script);

    }

    public static DataSet LookUpLogAcoes(string xusuario,
                                         string xData1,
                                         string xData2,
                                         string xModulo,
                                         string xAcao,
                                         string xComplementoAcao)
    {
        //
        string script;

        if (xusuario == "")
        {
            script = "SELECT * FROM log WITH(NOLOCK) WHERE (DataHora >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                     " and DataHora <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") ";

        }
        else
        {
            script = "SELECT * FROM log WITH(NOLOCK) WHERE Login = " + Srelib.QStr(xusuario) +
                     " and (DataHora >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) + 
                     " and DataHora <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") ";
        }

        script = script + " and ((tabela like " + Srelib.QStr("%" + xComplementoAcao.ToUpper() + "%") + ") ";

        script = script + " or (obs like " + Srelib.QStr("%" + xComplementoAcao.ToUpper() + "%") + ") ";

        script = script + " or (acao like " + Srelib.QStr("%" + xComplementoAcao.ToUpper() + "%") + ")) ";

        script = script + " order by DataHora";

        return SreDblib.GetDsScript(script);

    }


    public static DataSet PegaDadosLog(string xusuario,
                                       string xData1,
                                       string xData2,
                                       string xModulo,
                                       string xAcao,
                                       string xComplementoAcao)
    {
        //Pega Log
        string script;

        if (xusuario == "")
        {
            script = "SELECT * FROM log WITH(NOLOCK) WHERE (DataHora >= " +
                Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                " and DataHora <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") ";
        }
        else
        {
            script = "SELECT * FROM log WITH(NOLOCK) WHERE Login = " + Srelib.QStr(xusuario) +
                     " and (DataHora >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                     " and DataHora <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") ";
        }

        if (xModulo != "")
        {
            script = script + " and (operacao = " + Srelib.QStr(xModulo) + ") ";
        }

        if (xAcao != "")
        {
            script = script + " and (obs <= " + Srelib.QStr(xAcao) + ") ";
        }

        if (xComplementoAcao != "")
        {
            script = script + " and (acao like " + Srelib.QStr("%" + xComplementoAcao + "%") + ") ";
        }

        script = script + " order by DataHora";

        return SreDblib.GetDsScript(script);

    }

    public static DataSet PegaDadosLogAcoes(string xusuario,
                                            string xData1,
                                            string xData2,
                                            string xModulo,
                                            string xAcao,
                                            string xComplementoAcao)
    {
        //Pega Log
        string script;

        if (xusuario == "")
        {
            script = "SELECT * FROM log WITH(NOLOCK) WHERE (DataHora >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                     " and DataHora <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") ";

        }
        else
        {
            script = "SELECT * FROM log WITH(NOLOCK) WHERE Login = " + Srelib.QStr(xusuario) +
                     " and (DataHora >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData1)) +
                     " and DataHora <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xData2)) + ") ";
        }

        script = script + " and ((tabela like " + Srelib.QStr("%" + xComplementoAcao.ToUpper() + "%") + ") ";

        script = script + " or (obs like " + Srelib.QStr("%" + xComplementoAcao.ToUpper() + "%") + ") ";

        script = script + " or (acao like " + Srelib.QStr("%" + xComplementoAcao.ToUpper() + "%") + ")) ";

        script = script + " order by DataHora";

        return SreDblib.GetDsScript(script);

    }

    public static DataSet PegaDadosLog(string xusuario)
    {
        //Pega Log
        string script;

        if (xusuario == "")
        {
            script = "SELECT * FROM log WITH(NOLOCK)";
        }
        else
        {
            script = "SELECT * FROM log WITH(NOLOCK) WHERE Login = " + Srelib.QStr(xusuario);
        }

        script = script + " order by DataHora";

        return SreDblib.GetDsScript(script);

    }

    public static String Grava(string xlogin,
                                string xdata,
                                string xhora,
                                string xtabela,
                                string xoperacao,
                                string xobs,
                                string xacao)
    {

        if (xlogin != String.Empty)
        {
            if (Convert.ToInt32(xhora.Substring(0, 2)) > 23)
                xhora = "00:00:00";

            string script = "INSERT INTO LOG VALUES ( " +
                            Srelib.QStr(xlogin) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata) + " " + xhora) +
                            ", newid() " +
                            ", " + Srelib.QStr(xtabela) +
                            ", " + Srelib.QStr(xoperacao) +
                            ", " + Srelib.QStr(xobs) +
                            ", " + Srelib.QStr(xacao) +
                            " ) ";

            //" where nome=" + Rgblib.QStr(pParametro);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public uLog()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
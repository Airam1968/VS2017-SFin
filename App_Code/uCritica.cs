using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;

/// <summary>
/// Summary description for uCritica
/// </summary>
public class uCritica
{
    public static DataSet LookUpCritica()
    {
        return SreDblib.GetDsScript("select CODIGO, DESCRICAO from CODCRITI order by CODIGO");
    }

    public static ASPxComboBox MontaComboCritica(ASPxComboBox pCombo)
    {
        //Documentação - Chamada da Função
        //
        //RgbDbLib.MontaComboCritica(ASPxComboBox1);
        //
        //Fim Documentação - Chamada da Função

        string pTabela = "codcriti";
        string pCampoExibe = "descricao";
        string pCampoValor = "codigo";
        Boolean pExibeValor = true;

        String script = "SELECT " + pCampoExibe + "," + pCampoValor + " FROM " + pTabela + " WITH(NOLOCK) ORDER BY 1";
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

    public static int PegaMaiorCritica(String wempresa,String wcedente,int wtipo_op,int wbordero,String wduplicata,String wbanco,String wagencia,String wconta,String wcheque)
    {
        String sql = "SELECT top 1 codigo FROM criticas WITH(NOLOCK) " +
                     "WHERE empresa=" + Srelib.QStr(wempresa) +
                     " and cedente=" + Srelib.QStr(wcedente) +
                     " and tipo_operacao=" + Convert.ToString(wtipo_op) +
                     " and bordero=" + Convert.ToString(wbordero) +
                     " and duplicata=" + Srelib.QStr(wduplicata) +
                     " and banco=" + Srelib.QStr(wbanco) +
                     " and agencia=" + Srelib.QStr(wagencia) +
                     " and conta=" + Srelib.QStr(wconta) +
                     " and cheque=" + Srelib.QStr(wcheque);
        if ((SreDblib.GetParametro("CCC") == "SIM"))
        {
            sql = sql + " and codigo>200 and codigo<255";
        }
        else
        {
            sql = sql + " and ((codigo<=200) or (codigo>=255))";
        }
        sql = sql + " ORDER BY codigo DESC";
        DataSet ds = SreDblib.GetDsScript(sql);

        if (ds.Tables[0].Rows.Count == 0)
        {
            return 0;
        }
        else
        {
            return (Convert.ToInt16(ds.Tables[0].Rows[0]["codigo"].ToString()));
        }

    }

   public uCritica()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
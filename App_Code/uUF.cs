using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;

/// <summary>
/// Summary description for uUF
/// </summary>
public class uUF
{

    public static ASPxComboBox MontaComboUF(ASPxComboBox pCombo, Boolean pExibeValor)
    {
        //Documentação - Chamada da Função
        //
        //SreLib.MontaComboUF(ASPxComboBox1, true);
        //
        //Fim Documentação - Chamada da Função

        DataSet dsestados;
        string script = "";
        string aux = "";
        script = "select * from Estados order by UF ";
        //
        dsestados = SreDblib.GetDsScriptCep(script);
        //
        ListEditItem le;
        pCombo.Items.Clear();
        //
        for (int i = 0; i < dsestados.Tables[0].Rows.Count; i++)
        {
            //
            le = new ListEditItem();
            if (pExibeValor)
            {
                aux = "";
                aux = dsestados.Tables[0].Rows[i]["UF"].ToString().Trim() +
                          " - " +
                          dsestados.Tables[0].Rows[i]["Estado"].ToString().Trim();
                le.Text = aux.ToUpper();
            }
            else
            {
                aux = "";
                aux = dsestados.Tables[0].Rows[i]["UF"].ToString().Trim();
                le.Text = aux.ToUpper();
            };
            le.Value = i;
            pCombo.Items.Add(le);
        }

        return pCombo;
    }


	public uUF()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
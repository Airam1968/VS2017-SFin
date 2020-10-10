using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;
using System.ComponentModel;

/// <summary>
/// Summary description for uGrupo
/// </summary>
/// 

[DataObject()]
public class uGrupo
{

  
    public static DataSet LookUpGrupo()
    {
        return SreDblib.GetDsScript("select apelido FROM grupo WITH(NOLOCK) ORDER BY apelido");
    }
    
    public static ASPxComboBox MontaComboGrupo(ASPxComboBox pCombo)
	{
		//Documentação - Chamada da Função
		//
		//Fim Documentação - Chamada da Função

        return SreDblib.MontaCombo(pCombo, "grupo", "apelido", "apelido", false, "");

	}

    public static String PegaObservacao1(string xproduto, string xgrupo)
    {
        string script = "SELECT observa_1 FROM produto_grupo WITH(NOLOCK) WHERE produto = " + Srelib.QStr(xproduto) +
                        " AND grupo = " + Srelib.QStr(xgrupo);
        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return " ";
        }

    }

	public uGrupo()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using DevExpress.Web.ASPxEditors;

/// <summary>
/// Summary description for uGerente
/// </summary>
public class uClassif_cc
{
    public static DataSet LookUpClassif_cc()
    {
        return SreDblib.GetDsScript("SELECT descricao,nclassif FROM Classif_cc WITH(NOLOCK) ORDER BY descricao");
    }



    public static ASPxComboBox MontaComboClassif_cc(ASPxComboBox pCombo)
    {
        //Documentação - Chamada da Função
        //
        //RgbDbLib.MontaComboEmpresa(ASPxComboBox1);
        //
        //Fim Documentação - Chamada da Função

        String[] Campos1 = { "descricao" };
        SreDblib.MontaComboMult(pCombo, "classif_cc", Campos1, "nclassif", true);

        return pCombo;

    
    }


}
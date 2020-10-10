using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;

/// <summary>
/// Summary description for uBase
/// </summary>
public class uBase
{

    public static ASPxComboBox MontaComboBase(ASPxComboBox pCombo)
    {

        //Documentação - Chamada da Função
        //
        //uBase.MontaComboBase(ASPxComboBox1);
        //
        //Fim Documentação - Chamada da Função

        return SreDblib.MontaComboGroup(pCombo, "weblog", "base", "base", false);

    }

}
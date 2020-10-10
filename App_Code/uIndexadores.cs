using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DevExpress.Web.ASPxEditors;

/// <summary>
/// Summary description for uIndexadores
/// </summary>
public class uIndexadores
{

    public static ASPxComboBox MontaComboIndexadores(ASPxComboBox pCombo, Boolean pativo)
    {
        if (pativo)
            return SreDblib.MontaCombo(pCombo, "indexadores", "nome", "nome", false, " WHERE ativo = 1 ORDER BY nome");
        else
            return SreDblib.MontaCombo(pCombo, "indexadores", "nome", "nome", false, " WHERE ativo = 0 ORDER BY nome");
    }

    public static DataSet LookUpIndexadores(string xTipo)
    {
        if (xTipo == "D")
        {
            return SreDblib.GetDsScript("select nome from Indexadores WITH(NOLOCK) WHERE periodicidade = " + Srelib.QStr("DIARIO") + " GROUP BY nome");
        }
        else
        {
            return SreDblib.GetDsScript("select nome from Indexadores WITH(NOLOCK) WHERE periodicidade = " + Srelib.QStr("MENSAL") + " GROUP BY nome");
        }
    }

    public static DataSet PegaDadosIndexadores(Int32 xID)
    {
        string script;

        if (xID == 0)
        {
            script = "SELECT * FROM indexadores WITH(NOLOCK) order by NOME";
        }
        else
        {
            script = "SELECT * FROM indexadores WITH(NOLOCK) WHERE id = " + Convert.ToString(xID) + " order by NOME";
        }

        return SreDblib.GetDsScript(script);

    }

    public static String Grava(string xnome,
                               string xdescricao,
                               string xorgao,
                               string xdivulgacao,
                               string xperiodicidade,
                               string xtipo,
                               string xinicio,
                               string xfim,
                               string xdmais,
                               Boolean xativo,
                               string xobserva_1,
                               string xobserva_2)
    {

        if (xnome != String.Empty)
        {

            if (xinicio == String.Empty)
                xinicio = "0";
            if (xfim == String.Empty)
                xfim = "0";
            if (xdmais == String.Empty)
                xdmais = "0";

            string script = "Insert into INDEXADORES With (ROWLOCK) (nome, descricao, orgao, divulgacao, periodicidade, tipo, inicio, fim, dmais, ativo, observa_1, observa_2) " +
                            " SELECT " +
                            Srelib.QStr(xnome.ToUpper()) +
                            ", " + Srelib.QStr(xdescricao.ToUpper()) +
                            ", " + Srelib.QStr(xorgao) +
                            ", " + Srelib.QStr(xdivulgacao) +
                            ", " + Srelib.QStr(xperiodicidade.ToUpper()) +
                            ", " + Srelib.QStr(xtipo.ToUpper()) +
                            ", " + xinicio +
                            ", " + xfim +
                            ", " + xdmais +
                            ", " + Convert.ToString(Convert.ToInt16(xativo)) +
                            ", " + Srelib.QStr(xobserva_1) +
                            ", " + Srelib.QStr(xobserva_2) +
                            " WHERE not exists (select * from INDEXADORES where nome = " + Srelib.QStr(xnome.ToUpper()) + ") ";

            SreDblib.ExecScript(script);
            //
            //Grava o campo na tabela de Taxas Mensais ou taxas Diárias
            uIndexadores.GravaCampoTaxa(xnome,
                                        xperiodicidade,
                                        xtipo);
            //
        }
        return " ";
    }


    public static String Altera(string xID,
                                string xnome,
                                string xdescricao,
                                string xorgao,
                                string xdivulgacao,
                                string xperiodicidade,
                                string xtipo,
                                string xinicio,
                                string xfim,
                                string xdmais,
                                Boolean xativo,
                                string xobserva_1,
                                string xobserva_2)
    {

        string script = "UPDATE INDEXADORES SET " +
                        " descricao = " + Srelib.QStr(xdescricao) +
                        " ,orgao = " + Srelib.QStr(xorgao) +
                        " ,divulgacao = " + Srelib.QStr(xdivulgacao) +
                        " ,inicio = " + xinicio +
                        " ,fim = " + xfim +
                        " ,dmais = " + xdmais +
                        ", ativo = " + Convert.ToString(Convert.ToInt16(xativo)) +
                        " ,observa_1 = " + Srelib.QStr(xobserva_1) +
                        " ,observa_2 = " + Srelib.QStr(xobserva_2) +
                        " where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }


    public static String Exclui(string xID, string xnome, string xperiodicidade)
    {
        //Indexadores
        string script = "";
        script = " DELETE FROM INDEXADORES " +
                 " WHERE NOT EXISTS (SELECT 1 FROM VENDAS " +
                 " WHERE indexador  = " + Srelib.QStr(xnome.ToUpper()) + " ) and nome = " + Srelib.QStr(xnome.ToUpper()) + " ";
        SreDblib.ExecScript(script);
        //
        //Campo
        if (xperiodicidade == "DIARIA")
        {
            script = "if not exists(select 1 from vendas where indexador = " + Srelib.QStr(xnome.ToUpper()) + ") " +
                     " ALTER TABLE TAXAS_DIARIAS " +
                     " DROP COLUMN [" + xnome.ToUpper() + "]";
        }
        else
        {
            script = "if not exists(select 1 from vendas where indexador = " + Srelib.QStr(xnome.ToUpper()) + ") " +
                     " ALTER TABLE TAXAS_MENSAIS " +
                     " DROP COLUMN [" + xnome.ToUpper() + "]";
        }
        SreDblib.ExecScript(script);

        return " ";
    }

    public static String GravaCampoTaxa(string xnome,
                                        string xperiodicidade,
                                        string xtipo)
    {
        string script = "";
        if (xnome != String.Empty)
        {
            if (xperiodicidade == "DIARIA")
            {
                if (xtipo == "VALOR")
                {
                    script = "if not exists(select 1 from syscolumns where id = object_id('TAXAS_DIARIAS') and name = " + Srelib.QStr(xnome.ToUpper()) + ")" +
                             " ALTER TABLE TAXAS_DIARIAS " +
                             " ADD [" + xnome.ToUpper() + "] [decimal](18, 2) NULL ";
                    SreDblib.ExecScript(script);
                }
                else
                {
                    script = "if not exists(select 1 from syscolumns where id = object_id('TAXAS_DIARIAS') and name = " + Srelib.QStr(xnome.ToUpper()) + ")" + 
                             " ALTER TABLE TAXAS_DIARIAS " +
                             " ADD [" + xnome.ToUpper() + "] [decimal](18, 8) NULL ";
                    SreDblib.ExecScript(script);
                }
                //
                script = "if exists(select 1 from syscolumns where id = object_id('TAXAS_DIARIAS') and name = " + Srelib.QStr(xnome.ToUpper()) + ")" + 
                         " UPDATE TAXAS_DIARIAS " +
                         " SET " + xnome.ToUpper() + " = 0 ";
                //
                SreDblib.ExecScript(script);
                //

            }
            if (xperiodicidade == "MENSAL")
            {
                if (xtipo == "VALOR")
                {
                    script = "if not exists(select 1 from syscolumns where id = object_id('TAXAS_MENSAIS') and name = " + Srelib.QStr(xnome.ToUpper()) + ")" + 
                             " ALTER TABLE TAXAS_MENSAIS " +
                             " ADD [" + xnome.ToUpper() + "] [decimal](18, 2) NULL ";
                    SreDblib.ExecScript(script);
                }
                else
                {
                    script = "if not exists(select 1 from syscolumns where id = object_id('TAXAS_MENSAIS') and name = " + Srelib.QStr(xnome.ToUpper()) + ")" + 
                             " ALTER TABLE TAXAS_MENSAIS " +
                             " ADD [" + xnome.ToUpper() + "] [decimal](18, 8) NULL ";
                    SreDblib.ExecScript(script);
                }
                //
                script = "if exists(select 1 from syscolumns where id = object_id('TAXAS_MENSAIS') and name = " + Srelib.QStr(xnome.ToUpper()) + ")" + 
                         " UPDATE TAXAS_MENSAIS " +
                         " SET " + xnome.ToUpper() + " = 0 ";
                //
                SreDblib.ExecScript(script);
            }

        }
        return " ";
    }


    public uIndexadores()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
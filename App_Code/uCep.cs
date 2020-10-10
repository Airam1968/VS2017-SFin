using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;

/// <summary>
/// Summary description for uCep
/// </summary>
public class uCep
{
    public static DataSet PegaDadosCep2007(string xcep, Boolean xcepespecial)
    {
        string script = "";
        if (xcep != String.Empty)
        {
            if (!xcepespecial)
            {
                script = "select l.*, " +
                " (select c.Cidade from localidades c where c.id = l.CodLoc ) Cidade, " +
                " (select c.UF from localidades c where c.id = l.CodLoc ) UF " +
                " from logradouros l where l.cep = " + Srelib.QStr(xcep) +
                " order by UF, Cidade";
            }
            else
            {
                script = "select l.*, l.nome Complemento, " +
                " (select c.Cidade from localidades c where c.id = l.CodLoc ) Cidade, " +
                " (select c.UF from localidades c where c.id = l.CodLoc ) UF " +
                " from especiais l where l.cep = " + Srelib.QStr(xcep) +
                " order by UF, Cidade";
            }
            return SreDblib.GetDsScriptCep(script);
        }
        else
        {
            return null;
        }
    }

    public static DataSet PegaDadosLogradouro2007(string xendereco, string xuf, Boolean xcepespecial)
    {
        string script = "";
        if (xendereco != String.Empty)
        {
            if (!xcepespecial)
            {
                script = "select l.*, " +
                " (select c.Cidade from localidades c where c.id = l.CodLoc ) Cidade, " +
                " (select c.UF from localidades c where c.id = l.CodLoc ) UF " +
                " from logradouros l where l.endereco like " + Srelib.QStr("%" + xendereco + "%");
                if (xuf != String.Empty)
                {
                    script = script + " and UF = " + Srelib.QStr(xuf);
                }
                script = script + " order by UF, Cidade";
            }
            else
            {
                script = "select l.*, l.nome Complemento, " +
                " (select c.Cidade from localidades c where c.id = l.CodLoc ) Cidade, " +
                " (select c.UF from localidades c where c.id = l.CodLoc ) UF " +
                " from especiais l where l.endereco like " + Srelib.QStr("%" + xendereco + "%");
                if (xuf != String.Empty)
                {
                    script = script + " and UF = " + Srelib.QStr(xuf);
                }
                script = script + " order by UF, Cidade";
            }
            return SreDblib.GetDsScriptCep(script);
        }
        else
        {
            return null;
        }
    }


    public static DataSet PegaDadosCep2014(string xcep, Boolean xcepespecial)
    {
        string script = "";
        if (xcep != String.Empty)
        {
            if (!xcepespecial)
            {
                script = "select l.*, l.ufe_sg UF, " +
                " (select c.loc_nosub from log_localidade c where c.loc_nu_sequencial = l.loc_nu_sequencial ) Cidade " +
                " from log_logradouro l where l.cep = " + Srelib.QStr(xcep) +
                " order by UF, Cidade";
            }
            else
            {
                script = " select l.*, l.ufe_sg UF, " +
                " (select c.loc_nosub from log_localidade c where c.loc_nu_sequencial = l.loc_nu_sequencial ) Cidade " +
                " from log_grande_usuario l where l.cep = " + Srelib.QStr(xcep) +
                " order by UF, Cidade";
            }
            return SreDblib.GetDsScriptCep(script);
        }
        else
        {
            return null;
        }
    }

    public static DataSet PegaDadosLogradouro2014(string xendereco, string xuf, Boolean xcepespecial)
    {
        string script = "";
        if (xendereco != String.Empty)
        {
            if (!xcepespecial)
            {
                script = "select l.*, l.ufe_sg UF, " +
                " (select c.loc_nosub from log_localidade c where c.loc_nu_sequencial = l.loc_nu_sequencial ) Cidade " +
                " from log_logradouro l where l.endereco like " + Srelib.QStr("%" + xendereco + "%");
                if (xuf != String.Empty)
                {
                    script = script + " and l.ufe_sg = " + Srelib.QStr(xuf);
                }
                script = script + " order by UF, Cidade";
            }
            else
            {
                script = " select l.*, l.ufe_sg UF, " +
                " (select c.loc_nosub from log_localidade c where c.loc_nu_sequencial = l.loc_nu_sequencial ) Cidade " +
                " from log_grande_usuario l where l.endereco like " + Srelib.QStr("%" + xendereco + "%");
                if (xuf != String.Empty)
                {
                    script = script + " and l.ufe_sg = " + Srelib.QStr(xuf);
                }
                script = script + " order by UF, Cidade";
            }
            return SreDblib.GetDsScriptCep(script);
        }
        else
        {
            return null;
        }
    }


	public uCep()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
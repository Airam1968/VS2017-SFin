using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;
using System.ComponentModel;

/// <summary>
/// Summary description for uFornecedores
/// </summary>
public class uFornecedores
{

    [DataObjectMethod(DataObjectMethodType.Select)]
    public DataSet filtro_combo_fornecedores(string valor_inicio)
    {
        if (valor_inicio == null)
        {
            valor_inicio = "";
        }
        SqlParameter[] parametros = { new SqlParameter("@valor_inicio", valor_inicio) };
        //String sql = @"SELECT codigo, nome 
        String sql = @"SELECT nome, codigo
                      FROM fornecedores
                      WHERE nome LIKE '%' + replace(@valor_inicio, '%', '[%]') + '%'
                      order by nome";
        DataSet Ds = SreDblib.GetDsCp(sql, parametros);
        return Ds;
    }
    

    public static DataSet LookUpFornecedores()
    {
        if ((SreDblib.GetParametro("ORDEM FORNECEDOR") != "CODIGO") && (SreDblib.GetParametro("ORDEM FORNECEDOR") != "CÓDIGO"))
        {
            return SreDblib.GetDsScript("select codigo, apelido from fornecedores WITH(NOLOCK) ORDER BY apelido");
        }
        else
        {
            return SreDblib.GetDsScript("select codigo, apelido from fornecedores WITH(NOLOCK) ORDER BY CODIGO");
        }

    }

    public static DataSet PegaDadosFornecedoresID(string xID)
    {
        string script;
        if ((SreDblib.GetParametro("ORDEM FORNECEDOR") != "CODIGO") && (SreDblib.GetParametro("ORDEM FORNECEDOR") != "CÓDIGO"))
        {
            if ((xID == "0") || (xID == string.Empty))
            {
                script = "SELECT * FROM fornecedores WITH(NOLOCK) order by Apelido";
            }
            else
            {
                script = "SELECT * FROM fornecedores WITH(NOLOCK) WHERE codigo in (" + Convert.ToString(xID) + ") order by Apelido";
            }
        }
        else
        {
            if ((xID == "0") || (xID == string.Empty))
            {
                script = "SELECT * FROM fornecedores WITH(NOLOCK) order by CODIGO ";
            }
            else
            {
                script = "SELECT * FROM fornecedores WITH(NOLOCK) WHERE codigo in (" + Convert.ToString(xID) + ") order by CODIGO ";
            }
        }
        return SreDblib.GetDsScript(script);
    }


    public static DataSet PegaDadosFornecedores(string xapelido)
    {
        string script;

        if ((SreDblib.GetParametro("ORDEM FORNECEDOR") != "CODIGO") && (SreDblib.GetParametro("ORDEM FORNECEDOR") != "CÓDIGO"))
        {
            if (xapelido == "")
            {
                script = "SELECT * FROM fornecedores WITH(NOLOCK) ORDER BY APELIDO ";
            }
            else
            {
                if (xapelido.Trim().Substring(0, 1) == "'")
                {
                    script = "SELECT * FROM fornecedores WITH(NOLOCK) WHERE apelido in (" + xapelido + ") ORDER BY APELIDO ";
                }
                else
                {
                    script = "SELECT * FROM fornecedores WITH(NOLOCK) WHERE apelido in (" + Srelib.QStr(xapelido) + ") ORDER BY APELIDO ";
                }
            }
        }
        else
        {
            if (xapelido == "")
            {
                script = "SELECT * FROM fornecedores WITH(NOLOCK) ORDER BY CODIGO ";
            }
            else
            {
                if (xapelido.Trim().Substring(0, 1) == "'")
                {
                    script = "SELECT * FROM fornecedores WITH(NOLOCK) WHERE apelido in (" + xapelido + ") ORDER BY CODIGO ";
                }
                else
                {
                    script = "SELECT * FROM fornecedores WITH(NOLOCK) WHERE apelido in (" + Srelib.QStr(xapelido) + ") ORDER BY CODIGO ";
                }
            }
        }
        return SreDblib.GetDsScript(script);

    }

    public static String Grava(string xcodigo,
                                string xapelido,
                                string xnome,
                                string xsexo,
                                string xcnpj,
                                string xinscmunicipal,
                                string xinscestadual,
                                string xregjuntacom,
                                string xnire,
                                string rg,
                                string rguf,
                                string rgemissor,
                                DateTime rgemissao,
                                string xenderecocom,
                                string xenderecocomnumero,
                                string xenderecocomcomplem,
                                string xbairrocom,
                                string xcidadecom,
                                string xufcom,
                                string xcepcom,
                                string xfone1com,
                                string xfone2com,
                                string xfone3com,
                                string xemail1,
                                string xemail2,
                                string xemail3,
                                string xemail4,
                                string xemail5,
                                string xgerente,
                                string xcontato,
                                DateTime xdtnascimento,
                                DateTime xdtingresso,
                                string xncontrato,
                                DateTime xdtcontrato,
                                Boolean xativo,
                                Boolean xacessointernet,
                                string xobs1,
                                string xobs2,
                                string xobs3,
                                string xobs4,
                                string xobs5,
                                string xinstrcob1,
                                string xinstrcob2,
                                string xdiasprotesto,
                                string xconta1,
                                string xconta2,
                                string xconta3,
                                string xconta4,
                                string xconta5
                                )
    {

        if (xapelido != String.Empty)
        {
            string script = "INSERT INTO FORNECEDORES VALUES ( " +
                            xcodigo +
                            ", " + Srelib.QStr(xapelido) +
                            ", " + Srelib.QStr(xnome) +
                            ", " + Srelib.QStr(xsexo) +
                            ", " + Srelib.QStr(xcnpj) +
                            ", " + Srelib.QStr(xinscmunicipal) +
                            ", " + Srelib.QStr(xinscestadual) +
                            ", " + Srelib.QStr(xregjuntacom) +
                            ", " + Srelib.QStr(xnire) +
                            ", " + Srelib.QStr(rg) +
                            ", " + Srelib.QStr(rguf) +
                            ", " + Srelib.QStr(rgemissor) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(rgemissao))) +
                            ", " + Srelib.QStr(xenderecocom) +
                            ", " + Srelib.QStr(xenderecocomnumero) +
                            ", " + Srelib.QStr(xenderecocomcomplem) +
                            ", " + Srelib.QStr(xbairrocom) +
                            ", " + Srelib.QStr(xcidadecom) +
                            ", " + Srelib.QStr(xufcom) +
                            ", " + Srelib.QStr(xcepcom) +
                            ", " + Srelib.QStr(xfone1com) +
                            ", " + Srelib.QStr(xfone2com) +
                            ", " + Srelib.QStr(xfone3com) +
                            ", " + Srelib.QStr(xemail1) +
                            ", " + Srelib.QStr(xemail2) +
                            ", " + Srelib.QStr(xemail3) +
                            ", " + Srelib.QStr(xemail4) +
                            ", " + Srelib.QStr(xemail5) +
                            ", " + Srelib.QStr(xgerente) +
                            ", " + Srelib.QStr(xcontato) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xdtnascimento))) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xdtingresso))) +
                            ", " + Srelib.QStr(xncontrato) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xdtcontrato))) +
                            ", " + Convert.ToString(Convert.ToInt16(xativo)) +
                            ", " + Convert.ToString(Convert.ToInt16(xacessointernet)) +
                            ", " + Srelib.QStr(xobs1) +
                            ", " + Srelib.QStr(xobs2) +
                            ", " + Srelib.QStr(xobs3) +
                            ", " + Srelib.QStr(xobs4) +
                            ", " + Srelib.QStr(xobs5) +
                            ", " + Srelib.QStr(xinstrcob1) +
                            ", " + Srelib.QStr(xinstrcob2) +
                            ", " + Srelib.QStr(xdiasprotesto) +
                            ", " + Srelib.QStr(xconta1) +
                            ", " + Srelib.QStr(xconta2) +
                            ", " + Srelib.QStr(xconta3) +
                            ", " + Srelib.QStr(xconta4) +
                            ", " + Srelib.QStr(xconta5) +
                            " ) ";

            //" where nome=" + Rgblib.QStr(pParametro);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String Altera(string xID,
                                string xapelido,
                                string xnome,
                                string xsexo,
                                string xcnpj,
                                string xinscmunicipal,
                                string xinscestadual,
                                string xregjuntacom,
                                string xnire,
                                string xrg,
                                string xrguf,
                                string xrgemissor,
                                DateTime xrgemissao,
                                string xenderecocom,
                                string xenderecocomnumero,
                                string xenderecocomcomplem,
                                string xbairrocom,
                                string xcidadecom,
                                string xufcom,
                                string xcepcom,
                                string xfone1com,
                                string xfone2com,
                                string xfone3com,
                                string xemail1,
                                string xemail2,
                                string xemail3,
                                string xemail4,
                                string xemail5,
                                string xgerente,
                                string xcontato,
                                DateTime xdtnascimento,
                                DateTime xdtingresso,
                                string xncontrato,
                                DateTime xdtcontrato,
                                Boolean xativo,
                                Boolean xacessointernet,
                                string xobs1,
                                string xobs2,
                                string xobs3,
                                string xobs4,
                                string xobs5,
                                string xinstrcob1,
                                string xinstrcob2,
                                string xdiasprotesto,
                                string xconta1,
                                string xconta2,
                                string xconta3,
                                string xconta4,
                                string xconta5
                                )
    {

        string script = "UPDATE FORNECEDORES SET " +
                        " apelido = " + Srelib.QStr(xapelido) +
                        " ,nome = " + Srelib.QStr(xnome) +
                        " ,sexo = " + Srelib.QStr(xsexo) +
                        " ,cnpj = " + Srelib.QStr(xcnpj) +
                        " ,inscmunicipal = " + Srelib.QStr(xinscmunicipal) +
                        " ,inscestadual = " + Srelib.QStr(xinscestadual) +
                        " ,regjuntacom = " + Srelib.QStr(xregjuntacom) +
                        " ,nire = " + Srelib.QStr(xnire) +
                        " ,rg = " + Srelib.QStr(xrg) +
                        " ,rguf = " + Srelib.QStr(xrguf) +
                        " ,rgemissor = " + Srelib.QStr(xrgemissor) +
                        " ,rgemissao = " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xrgemissao))) +
                        " ,enderecocom = " + Srelib.QStr(xenderecocom) +
                        " ,enderecocomnumero = " + Srelib.QStr(xenderecocomnumero) +
                        " ,enderecocomcomplem = " + Srelib.QStr(xenderecocomcomplem) +
                        " ,bairrocom = " + Srelib.QStr(xbairrocom) +
                        " ,cidadecom = " + Srelib.QStr(xcidadecom) +
                        " ,ufcom = " + Srelib.QStr(xufcom) +
                        " ,cepcom = " + Srelib.QStr(xcepcom) +
                        " ,fone1com = " + Srelib.QStr(xfone1com) +
                        " ,fone2com = " + Srelib.QStr(xfone2com) +
                        " ,fone3com = " + Srelib.QStr(xfone3com) +
                        " ,email1 = " + Srelib.QStr(xemail1) +
                        " ,email2 = " + Srelib.QStr(xemail2) +
                        " ,email3 = " + Srelib.QStr(xemail3) +
                        " ,email4 = " + Srelib.QStr(xemail4) +
                        " ,email5 = " + Srelib.QStr(xemail5) +
                        " ,gerente = " + Srelib.QStr(xgerente) +
                        " ,contato = " + Srelib.QStr(xcontato) +
                        " ,dtnascimento = " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xdtnascimento))) +
                        " ,dtingresso = " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xdtingresso))) +
                        " ,ncontrato = " + Srelib.QStr(xncontrato) +
                        " ,dtcontrato = " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xdtcontrato))) +
                        " ,ativo = " + Convert.ToString(Convert.ToInt16(xativo)) +
                        " ,acessointernet = " + Convert.ToString(Convert.ToInt16(xacessointernet)) +
                        " ,obs1 = " + Srelib.QStr(xobs1) +
                        " ,obs2 = " + Srelib.QStr(xobs2) +
                        " ,obs3 = " + Srelib.QStr(xobs3) +
                        " ,obs4 = " + Srelib.QStr(xobs4) +
                        " ,obs5 = " + Srelib.QStr(xobs5) +
                        " ,instrcob1 = " + Srelib.QStr(xinstrcob1) +
                        " ,instrcob2 = " + Srelib.QStr(xinstrcob2) +
                        " ,diasprotesto = " + Srelib.QStr(xdiasprotesto) +
                        " ,conta1 = " + Srelib.QStr(xconta1) +
                        " ,conta2 = " + Srelib.QStr(xconta2) +
                        " ,conta3 = " + Srelib.QStr(xconta3) +
                        " ,conta4 = " + Srelib.QStr(xconta4) +
                        " ,conta5 = " + Srelib.QStr(xconta5) +
                        " where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String Exclui(string xID)
    {

        string script = "DELETE FORNECEDORES where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }



    public static ASPxComboBox MontaComboFornecedores(ASPxComboBox pCombo, string pCodigo, Boolean pativo)
    {
        if ((SreDblib.GetParametro("ORDEM FORNECEDOR") != "CODIGO") && (SreDblib.GetParametro("ORDEM FORNECEDOR") != "CÓDIGO"))
        {
            //Ordenação por Nome = Descrição
            if (pativo)
            {
                if (pCodigo != "0")
                {
                    //
                    return SreDblib.MontaCombo(pCombo, "fornecedores", "apelido", "codigo", true,
                        " WHERE PRODUTO = " + pCodigo +
                        " AND ativo = 1 ORDER BY APELIDO ");
                }
                else
                {
                    //
                    return SreDblib.MontaCombo(pCombo, "fornecedores", "apelido", "codigo", true,
                        " WHERE ativo = 1 ORDER BY APELIDO ");
                }
            }
            else
            {
                if (pCodigo != "0")
                {
                    //
                    return SreDblib.MontaCombo(pCombo, "fornecedores", "apelido", "codigo", true,
                        " WHERE PRODUTO = " + pCodigo +
                        " AND ativo = 0 ORDER BY APELIDO ");
                }
                else
                {
                    //
                    return SreDblib.MontaCombo(pCombo, "fornecedores", "apelido", "codigo", true,
                        " WHERE ativo = 0 ORDER BY APELIDO ");
                }
            }
        }
        else
        {
            //Ordenação por Código = Numérica
            if (pativo)
            {
                if (pCodigo != "0")
                {
                    //
                    return SreDblib.MontaCombo(pCombo, "fornecedores", "apelido", "codigo", true,
                        " WHERE PRODUTO = " + pCodigo +
                        " AND ativo = 1 ORDER BY codigo ");
                }
                else
                {
                    //
                    return SreDblib.MontaCombo(pCombo, "fornecedores", "apelido", "codigo", true,
                        " WHERE ativo = 1 ORDER BY codigo ");
                }
            }
            else
            {
                if (pCodigo != "0")
                {
                    //
                    return SreDblib.MontaCombo(pCombo, "fornecedores", "apelido", "codigo", true,
                        " WHERE PRODUTO = " + pCodigo +
                        " AND ativo = 0 ORDER BY codigo ");
                }
                else
                {
                    //
                    return SreDblib.MontaCombo(pCombo, "fornecedores", "apelido", "codigo", true,
                        " WHERE ativo = 0 ORDER BY codigo ");
                }
            }
        }
    }

    public static string ProximoID()
    {
        string script;

        script = "SELECT MAX(codigo) + 1 ID FROM fornecedores WITH(NOLOCK)";


        return SreDblib.GetCampoScript(script);

    }

    public static String PegaNomeFornecedor(Int32 xID)
    {
        string script;

        script = " SELECT nome FROM fornecedores WITH(NOLOCK) " +
                 " WHERE codigo = " + Convert.ToString(xID);

        return Convert.ToString(SreDblib.GetCampoScript(script));

    }

	public uFornecedores()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.ComponentModel;




/// <summary>
/// Summary description for uCedente
/// </summary>
/// 

[DataObject()]
public class uSacado
{
    public String apelido;
    public String nome;
    public String cnpj;
    public String endereco;
    public String bairro;
    public String cidade;
    public String uf;
    public String fone;
    public String cep;
    public String contato;






    [DataObjectMethod(DataObjectMethodType.Select)]
    public DataSet AtualizaMaioresRiscos(String wsacado, Boolean zgrupo1, Boolean zgrupo2, Boolean zgrupo3, Boolean zgrupo4, String zrgtipo, String wusuario)
    {
        String sql = "WW_PEGAMAIORESRISCOS_SACADO";
        SqlParameter[] parametros = { new SqlParameter("@sacado", wsacado) ,
                                      new SqlParameter("@zgrupo1", zgrupo1) ,
                                      new SqlParameter("@zgrupo2", zgrupo2),
                                      new SqlParameter("@zgrupo3", zgrupo3),
                                      new SqlParameter("@zgrupo4", zgrupo4),
                                      new SqlParameter("@rgtipo",  Convert.ToInt16(zrgtipo)),
                                      new SqlParameter("@usuario", wusuario)
                                    };
        DataSet Ds = SreDblib.GetDsSp(sql, parametros);
        return Ds;
    }

    [DataObjectMethod(DataObjectMethodType.Select)]
    public DataSet AtualizaMaioresRiscosDet(String wsacado, Boolean zgrupo1, Boolean zgrupo2, Boolean zgrupo3, Boolean zgrupo4, String zrgtipo, String tipo, String risco, String chave, String wusuario)
    {
        String sql = "WW_PEGAMAIORESRISCOS_SACADO_DET";
        SqlParameter[] parametros = { new SqlParameter("@sacado", wsacado) ,
                                      new SqlParameter("@zgrupo1", zgrupo1) ,
                                      new SqlParameter("@zgrupo2", zgrupo2),
                                      new SqlParameter("@zgrupo3", zgrupo3),
                                      new SqlParameter("@zgrupo4", zgrupo4),
                                      new SqlParameter("@rgtipo",  Convert.ToInt16(zrgtipo)),
                                      new SqlParameter("@tipo",  Convert.ToInt16(tipo)),
                                      new SqlParameter("@risco", Convert.ToDouble(risco)),
                                      new SqlParameter("@chave", chave),
                                      new SqlParameter("@usuario", wusuario)

                                    };
        DataSet Ds = SreDblib.GetDsSp(sql, parametros);
        return Ds;
    }


    public void PegaDadosDoSacado(String wsacado)
    {
        String sql = @"Select cnpj, nome, endereco, bairro, cidade, uf, cep, fone, contato from sacado where cnpj=@sacado";
        SqlParameter[] parametros = { new SqlParameter("@sacado", wsacado) };
        DataSet Ds = SreDblib.GetDsCp(sql, parametros);
        // dados
        apelido = "";
        nome = "";
        cnpj = "";
        endereco = "";
        bairro = "";
        cidade = "";
        uf = "";
        cep = "";
        fone = "";
        contato = "";
        if (Ds.Tables.Count > 0)
        {
            apelido = Ds.Tables[0].Rows[0]["apelido"].ToString();
            nome = Ds.Tables[0].Rows[0]["nome"].ToString();
            cnpj = Ds.Tables[0].Rows[0]["cnpj"].ToString();
            endereco = Ds.Tables[0].Rows[0]["endereco"].ToString();
            bairro = Ds.Tables[0].Rows[0]["bairro"].ToString();
            cidade = Ds.Tables[0].Rows[0]["cidade"].ToString();
            uf = Ds.Tables[0].Rows[0]["uf"].ToString();
            cep = Ds.Tables[0].Rows[0]["cep"].ToString();
            fone = Ds.Tables[0].Rows[0]["fone"].ToString();
            contato = Ds.Tables[0].Rows[0]["contato"].ToString();
        }
    }
    
    public static DataSet LookUpSacado()
    {
        return SreDblib.GetDsScript("select cnpj, nome from sacado order by cnpj");
    }

    public static DataSet PesquisaSacado()
    {
        return SreDblib.GetDsScript("select cnpj, apelido, nome from sacado order by cnpj");
    }

    public static String PegaNomeSacado(string pCNPJ)//criado 13/08/13 bruno junto com Airam
    {
        string script = "select nome from sacado with(nolock) where cnpj=" + Srelib.QStr(pCNPJ);
        return SreDblib.GetCampoScript(script);
    }

    public static ASPxComboBox MontaComboSacado(ASPxComboBox pCombo)
		{
			//Documentação - Chamada da Função
			//
			//uSacado.MontaComboSacado(ASPxComboBox1);
			//
			//Fim Documentação - Chamada da Função

            return SreDblib.MontaCombo(pCombo, "Sacado", "apelido", "apelido", false, "");
		}

		public uSacado()
		{
			//
			// TODO: Add constructor logic here
			//
		}

}
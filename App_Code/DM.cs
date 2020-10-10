using System;
using System.IO;
using System.Data.SqlClient;
using System.Web;
using System.Configuration;
using System.Web.Configuration;




/// <summary>
/// Summary description for DM
/// </summary>
public class DM
{

    public static Boolean Inicializado = true;
    public static String Diretorio;
    public static String DiretorioImportacoes;
    public static String DiretorioRelatorios;
    public static String NomeServidor;
    public static String Parametro;
    public static String VersaoSql;
    public static String FormatoData = "AMD";
    public static String DiretorioVirtual;
    public static String CaminhoUpLoad;
    public static String Banco;
    /// <summary>
    /// Alimentando a ConexaoPublica com a criada 
    /// </summary>
    public static SqlConnection ConexaoPublica = new SqlConnection(SreDblib.connectionString);

    public static SqlConnection ConexaoSessao
    {
        get {
            if (HttpContext.Current.Session == null)
            {
                return DM.ConexaoPublica;
            }
            else
            if (HttpContext.Current.Session["ConexaoSessao"] == null)
              {
                SqlConnection Con = new SqlConnection(SreDblib.connectionString);
                //Codigo original
                //SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString.ToString());
                Con.Open();
                HttpContext.Current.Session.Add("ConexaoSessao", Con);
              }
              return (SqlConnection)HttpContext.Current.Session["ConexaoSessao"];
             }
    }

    
    public static String URLArquivos(String NomeArquivo)
    {
        return "http://" + NomeServidor + "/" + DiretorioVirtual + "/relatorios/" + NomeArquivo;
    }

    public static String URLVirtualRelatorios(String NomeArquivo)
    {
        return "./relatorios/" + NomeArquivo;
    }


    public static String URLImagem(String NomeImagem)
    {
        {
            return "http://" + NomeServidor + "/" + DiretorioVirtual + "/imagens/" + NomeImagem;
        }

    }

}

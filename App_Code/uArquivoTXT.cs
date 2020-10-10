using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;
using System.IO;

/// <summary>
/// Summary description for uArquivoTXT
/// </summary>
public class uArquivoTXT
{
    public Boolean CriaArquivoTXT(string xcaminhoarquivo)
    {
        //
        //xcaminhoarquivo = @"C:\temp\ArquivoExemplo.txt";
        //
        Boolean retorno = false;
        //
        try
        {
            //Usarei a cláusula using como boas práticas de programação em todos os métodos
            //Instancio a classe FileStream, uso a classe File e o método Create para criar o
            //arquivo passando como parâmetro a variável strPathFile, que contém o arquivo

            using (FileStream fs = File.Create(xcaminhoarquivo))
            {
                //Crio outro using, dentro dele instancio o StreamWriter (classe para gravar os dados)
                //que recebe como parâmetro a variável fs, referente ao FileStream criado anteriormente

                using (StreamWriter sw = new StreamWriter(fs))
                {
                    //Uso o método Write para escrever algo em nosso arquivo texto

                    sw.Write("Texto adicionado ao exemplo!");
                    retorno = true;
                }

            }

        }
        catch (Exception)
        {
            retorno = false;
        }

        return retorno;

    }

    public uArquivoTXT()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
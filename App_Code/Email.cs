using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Configuration;


/// <summary>
/// Summary description for Email
/// </summary>
public class Email
{
    public DataSet DSEmail;

    public static String aut_login;
    public static String aut_senha;
    public static String smtp_webfact;
    public static bool   ckemail;
    public static bool   ckSSL;
    public static Int32  smtp_porta;

    public String WebPegaEmailMatriz(String pXml)
    {

        //Via Procedure
        DSEmail = SreDblib.GetDsSpSp("WEBPEGAEMAILMATRIZ");

        aut_login = DSEmail.Tables[0].Rows[0]["login"].ToString();
        aut_senha = DSEmail.Tables[0].Rows[0]["senha"].ToString();
        smtp_webfact = DSEmail.Tables[0].Rows[0]["smtp_webfact"].ToString();
        ckemail = Convert.ToBoolean(DSEmail.Tables[0].Rows[0]["ckemail"].ToString());
        ckSSL = Convert.ToBoolean(DSEmail.Tables[0].Rows[0]["ckssl"].ToString());
        smtp_porta = Convert.ToInt32(DSEmail.Tables[0].Rows[0]["smtpporta"].ToString());

        return DSEmail.Tables[0].Rows[0]["emailemp"].ToString();

    }


    public String WebPegaEmailCedente(String pCedente,String pXml)
    {

        //Via Procedure
        SqlParameter[] parametros = { new SqlParameter("@CEDENTE", Convert.ToString(pCedente))  };

        DSEmail = SreDblib.GetDsSp("WEBPEGAEMAILCEDENTE", parametros);

        return DSEmail.Tables[0].Rows[0]["emailced"].ToString();

    }


    public String WebEnviaEmail( String pCedente,
                                 String pTipo, 
                                 String pXml)
    {

        String _to   = WebPegaEmailMatriz(pXml);
        String _from = WebPegaEmailCedente(pCedente,pXml);
        String mTexto = "";
        String assunto = "";

        if (pTipo == "1")
        {
            assunto = "Nova Solicitação";
            mTexto = "Chegou uma nova solicitação do WEBFACT do cedente " + pCedente;
        }
        else
        if (pTipo == "2")
        {
            assunto = "Nova Proposta";
            mTexto = "Chegou uma nova proposta do WEBFACT do cedente " + pCedente + " >> " + System.DateTime.Now;
        } ;

        return EnviaEmail(_from, _to, mTexto, assunto, aut_login, aut_senha, ckemail, ckSSL, smtp_porta, "");

 
    }


    public String WebEnviaEmailUpLoad(String pCedente,
                                      String pCaminho, String pXml)
    {

        String _to = WebPegaEmailMatriz(pXml);
        String _from = WebPegaEmailCedente(pCedente,pXml);
        String mTexto = "";
        String assunto = "";

        assunto = "Proposta - " + pCedente.Trim() + " - " + System.DateTime.Now; ;
        mTexto = "Arquivo disponível: " + pCaminho;

        return EnviaEmail(_from, _to, mTexto, assunto, aut_login, aut_senha, ckemail, ckSSL, smtp_porta, "");

    }


    public String WebEnviaEmailExportacaoContabil(String pCedente,
                                                  String pCaminho, String pXml)
    {

        String _to = uContabil.pega_email_cont();
        String _from = WebPegaEmailMatriz(pXml);
        //String _from = WebPegaEmailCedente(pCedente, pXml);
        String mTexto = "";
        String assunto = "";

        assunto = "Arquivo Contábil";
        mTexto = "Arquivo disponível: " + pCaminho;

        return EnviaEmail(_from, _to, mTexto, assunto, aut_login, aut_senha, ckemail, ckSSL, smtp_porta, pCaminho);

    }

    public String WebEnviaEmailCliNovo(String pCedente,
                                       String pEmail, String pXml)
    {

        String _to = WebPegaEmailMatriz(pXml);
        String _from = pEmail;
        String mTexto = "";
        String assunto = "";

         assunto = "Novo Cliente";
         mTexto = "Chegou um cadastro de um NOVO CLIENTE " + pCedente;

         return EnviaEmail(_from, _to, mTexto, assunto, aut_login, aut_senha, ckemail, ckSSL, smtp_porta, "");

    }


    public String EnviaEmail(string _from,
                             string _to,
                             string mTexto,
                             string assunto,
                             string a_login,
                             string a_senha,
                             bool   ckemail, 
                             bool   ckSSL, 
                             Int32  a_porta,
                             string Anexo_caminhofisico)
    {

        try
        {
            if ((_to.Trim() != "") &&
                 (_from.Trim() != ""))
            {
                if (a_porta == 0)
                {
                    a_porta = 25;
                };

                string ip = SreDblib.GetParametro("IP_SERVIDOR"); // smtp_webfact;
                SmtpClient SMTP = new SmtpClient(ip, a_porta);
                if (ckSSL)
                {
                    SMTP.EnableSsl = true;
                }
                if (ckemail)
                {
                    SMTP.Credentials = new NetworkCredential(a_login, a_senha);
                }
                

                MailMessage email = new MailMessage(_from, _to, assunto, mTexto);
                email.IsBodyHtml = false;


                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(Anexo_caminhofisico);
                email.Attachments.Add(attachment);


                // email.IsBodyHtml = true;
                SMTP.Send(email);
                return "";
            }
            else
            {
                return "Erro no envio do E-Mail!";
            }
        }
        catch (Exception ex)
        {
            String x = ex.Message;

            return "Erro no envio do E-Mail para " + _to + " => " + x;
        }
    }





    public Email()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}

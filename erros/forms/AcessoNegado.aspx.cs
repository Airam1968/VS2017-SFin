using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AcessoNegado : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetExpires(DateTime.Now);
        Response.Cache.SetNoServerCaching();
        Response.Cache.SetNoStore();

        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            //Response.Redirect("~\\LoginTimeOut.aspx");
        }

        if (!Page.IsPostBack)
        {
            //Cnpj Invalido
            if ((String)Session["Erro"] == null)
            {
                Memo_Texto.Text = "Erro Não Identificado." + "\n\n";
                Memo_Texto.Text = Memo_Texto.Text + "\n\n";
                Memo_Texto.Text = Memo_Texto.Text + "O Sistema não foi capaz de reconheçer o erro, favor informar ao suporte, as ações que levaram a este erro e se possivel imagens das telas." + "\n\n";
            }
            //Cnpj Invalido e Expirado
            if ((String)Session["Erro"] == "1")
            {
                Memo_Texto.Text = "Cnpj Invalido e Expirado" + "\n\n";
                Memo_Texto.Text = Memo_Texto.Text + "\n\n";
                Memo_Texto.Text = Memo_Texto.Text + "O Sistema não foi capaz de reconheçer o CNPJ da Empresa Matriz, favor entrar em contato com o suporte." + "\n\n";

            }
            //Cnpj Expirado
            if ((String)Session["Erro"] == "2")
            {
                Memo_Texto.Text = "Cnpj Expirado" + "\n\n";
                Memo_Texto.Text = Memo_Texto.Text + "\n\n";
                Memo_Texto.Text = Memo_Texto.Text + "O Sistema reconheceu o CNPJ da Empresa Matriz como expirado para o uso do Sistema, favor entrar em contato com o suporte." + "\n\n";
            }
            //Cnpj Invalido
            if ((String)Session["Erro"] == "3")
            {
                Memo_Texto.Text = "Cnpj Invalido" + "\n\n";
                Memo_Texto.Text = Memo_Texto.Text + "\n\n";
                Memo_Texto.Text = Memo_Texto.Text + "O Sistema não foi capaz de reconheçer o CNPJ da Empresa Matriz, favor entrar em contato com o suporte." + "\n\n";
            }
        }
    }

}
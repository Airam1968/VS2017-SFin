using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;

public partial class Login : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetExpires(DateTime.Now);
        Response.Cache.SetNoServerCaching();
        Response.Cache.SetNoStore();

        //lbmsg.Text = Srelib.DiaSemana(DateTime.Now);

        if (!(Page.IsPostBack))
        {
            //Monta Combo com Bases do Web.config
            SreDblib.MontaComboBases(ComboBases, true);

            if (ComboBases.Items.Count > 1)
            {
                ComboBases.SelectedIndex = -1;
                ComboBases.Focus();
            }
            else
            {
                ComboBases.SelectedIndex = 0;
                edusuario.Focus();
            }
        }

        if ((String)Session["fimdesessao"] != null)
        {
            lbmsg.Text = "A Sessão foi expirada, recarregue o sistema!";
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.error('A Sessão foi expirada, recarregue o sistema!', 'Atenção!')", true);
        }

    }

    public String LogarUsuario(String wlogin, String Senha)
    {
        // Conexao Conn = new Conexao(pXml);
        lbmsg.Text = "";
        String Msg = "";

        //Login Admin
        if ((wlogin.Trim() == "MASTER") &&
            (Senha.Trim() == "R2V3#V23"))
        {
            //lMaster = SuperUsuário
            Session.Add("lMaster", true);
            Session.Add("IdSessao", Page.Session.SessionID.ToUpper());
            Session.Add("consulta", "cedente");
            Msg = "";
        }
        else
        {
            //Login Usuário Existe no Banco
            if (SreDblib.TemNaTabela("SELECT LOGIN FROM USUARIO WITH(NOLOCK) WHERE LOGIN =" + Srelib.QStr(wlogin.Trim())))
            {
                //Senha Login Usuário
                if (SreDblib.GetCampoScript("SELECT SENHA FROM USUARIO WITH(NOLOCK) WHERE LOGIN =" + Srelib.QStr(wlogin.Trim())) ==
                    Senha.Trim())
                    //if (SreDblib.GetCampoScript("SELECT SENHA FROM USUARIO WITH(NOLOCK) WHERE LOGIN =" + Srelib.QStr(wlogin.Trim())) ==
                    //    Srelib.Converte_Senha(Senha.Trim()))
                {
                    //lMaster = SuperUsuário
                    Boolean lMaster = SreDblib.TemPermissao("000.000.000.000", wlogin.Trim());
                    Session.Add("IdSessao", Page.Session.SessionID.ToUpper());
                    Session.Add("lMaster", lMaster);
                    Session.Add("consulta", "cedente");
                }
                else
                {
                    lbmsg.Text = "ATENÇÃO: Senha não Confere!";
                    Msg = "* ATENÇÃO: Senha Não Confere!";
                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                    "toastr.error('Senha Não Confere!', 'Atenção!')", true);

                    // CRIA LOG  ===============================================================================================================================================
                    SqlParameter[] param_log1 = { new SqlParameter("@login"    , wlogin.Trim()), 
                                                  new SqlParameter("@tabela"   , "USUARIO"                    ),
                                                  new SqlParameter("@operacao" , "LOGIN"                      ),
                                                  new SqlParameter("@obs"      , "SENHA NÃO CONFERE"          ),
                                                  new SqlParameter("@acao"     , "SENHA NÃO CONFERE USUÁRIO: "+wlogin.Trim())};
                    uLog.MakeLog(param_log1);
                    // FIM CRIA LOG ============================================================================================================================================

                }
            }
            else
            {
                lbmsg.Text = "ATENÇÃO: Usuário não Cadastrado!";
                Msg = "* ATENÇÃO: Usuário Não Cadastrado!";
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.error('Usuário Não Cadastrado!', 'Atenção!')", true);

                // CRIA LOG  ===============================================================================================================================================
                SqlParameter[] param_log2 = { new SqlParameter("@login"    , wlogin.Trim()), 
                                              new SqlParameter("@tabela"   , "USUARIO"                    ),
                                              new SqlParameter("@operacao" , "LOGIN"                      ),
                                              new SqlParameter("@obs"      , "USUÁRIO NÃO CADASTRADO"     ) ,
                                              new SqlParameter("@acao"     , "USUÁRIO NÃO CADASTRADO USUÁRIO: "+wlogin.Trim())};
                uLog.MakeLog(param_log2);
                // FIM CRIA LOG ============================================================================================================================================

            }

        }

        // CRIA LOG  ===============================================================================================================================================
        SqlParameter[] param_log3 = { new SqlParameter("@login"    , wlogin.Trim()), 
                                      new SqlParameter("@tabela"   , "USUARIO"                    ),
                                      new SqlParameter("@operacao" , "LOGIN"                      ),
                                      new SqlParameter("@obs"      , "ENTRADA NO SISTEMA"         ) ,
                                      new SqlParameter("@acao"     , "ENTRADA NO SISTEMA USUÁRIO: "+wlogin.Trim())};
        uLog.MakeLog(param_log3);
        // FIM CRIA LOG ============================================================================================================================================


        return Msg;
    }


    protected void LoginButton_Click(object sender, EventArgs e)
    {
        if ((ComboBases.Text != "") && (edusuario.Text != "") && (edsenha.Text != ""))
        {
            SreDblib.connectionString = SreDblib.GetConnString(Convert.ToString(ComboBases.Value));
            SreDblib.connectionStringcep = SreDblib.GetConnString(Convert.ToString("SRE_SqlServerCep"));

            edusuario.Text = edusuario.Text.ToUpper();
            edsenha.Text = edsenha.Text.ToUpper();
            edusuario.Text = edusuario.Text.Trim();
            edsenha.Text = edsenha.Text.Trim();

            if (LogarUsuario(edusuario.Text, edsenha.Text) == "")
            {
                //Codigos Originais 
                string bd = ComboBases.Text.ToUpper();
                int ptraco = bd.IndexOf("-");
                bd = bd.Substring(ptraco + 2, bd.Length - (ptraco + 2));
                Session.Add("CodBaseSql", bd);
                DM.Banco = bd;
                Session.Add("CodUsuario", edusuario.Text.ToUpper());
                Session.Add("BaseCorrente", ComboBases.Text.ToUpper());
                // Codigos duplicados 
                Session.Add("usuario", edusuario.Text.ToUpper());
                Session.Add("connectionstring", SreDblib.connectionString);
                Session.Add("connectionstringcep", SreDblib.connectionStringcep);
                //
                AtualizaCss();
                //
                Response.Redirect("Principal.aspx");
            }
        }
        else
        {
            lbmsg.Text = "ATENÇÃO: Preencha Todos os Dados!";
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.error('Preencha Todos os Dados!', 'Atenção!')", true);
        }
    }

    protected void AtualizaCss()
    {
        //Aplicação do Site.CSS
        string ArquivoCSS = "";
        //ArquivoCSS = ConfigurationSettings.AppSettings["SRE_ArquivoCss"]; obsoleto 20/09/2018
        ArquivoCSS = ConfigurationManager.AppSettings["SRE_ArquivoCss"];
        if (ArquivoCSS.Trim() != "")
        {
            //Leva o arquivo para o arquivo padrão Site.CSS
            Boolean Sobreescreve = true;

            String arquivo_origem;
            String arquivo_destino;
            arquivo_origem = Server.MapPath("~") + "\\Styles\\" + ArquivoCSS.Trim();
            arquivo_destino = Server.MapPath("~") + "\\Styles\\" + "site.css";

            //String caminho = "E:/Rgb/Projetos/vs2010/ProjetoWeb/MasterPages/Styles/";

            System.IO.File.Copy(arquivo_origem, arquivo_destino, Sobreescreve);

        }

    }

    protected void ComboBases_TextChanged(object sender, EventArgs e)
    {
        edusuario.Focus();
    }
    protected void edusuario_TextChanged(object sender, EventArgs e)
    {
        edsenha.Focus();
    }
    protected void edsenha_TextChanged(object sender, EventArgs e)
    {
        LoginButton.Focus();
    }
}
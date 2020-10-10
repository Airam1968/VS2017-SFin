using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;

public partial class FSelecionaUsuarioPermissaoPerfil : System.Web.UI.Page
{
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "PERMISSOES";
    //
    DataSet dsusuario;       // DATASETS DOS LOOKUPS TEM QUE SER CRIADOS AQUI  ====================================================================================
    DataSet dspermissoes;
    DataSet dspermissoesusuarios;

    protected void Page_Init(object sender, EventArgs e)
    {
        // cbusuario
        uUsuario.MontaComboPerfil(cbusuario);

        // lookuppermissoesusuario
        uPermissoes.MontaComboPermissoesUsuario(lookuppermissoesusuario, "","");

        // lookuppermissoes
        uPermissoes.MontaComboPermissoes(lookuppermissoes, "");
        //
        Label3.Text = "Permissões Disponíveis - " + lookuppermissoes.Items.Count.ToString();
        Label2.Text = "Permissões do Perfil de Usuário Selecionado (Nenhum)  - 0";

        //
        lInsere = SreDblib.TemPermissao("001.011.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.011.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.011.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.011.004.000", (String)Session["CodUsuario"]);

        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        //
        btprocessa.Enabled = lConsulta;
        if (!lConsulta)
            btprocessa.Image.ToolTip = Msg_acesso;

        //
        bttodosparausuario.Enabled = false;
        btselecionadosparausuario.Enabled = false;
        btremovetodosdousuario.Enabled = false;
        btremoveselecionadodousuario.Enabled = false;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //Limpa Cache
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetExpires(DateTime.Now);
        Response.Cache.SetNoServerCaching();
        Response.Cache.SetNoStore();
        //Fim Limpa Cache

        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Response.Redirect("~\\LoginTimeOut.aspx");
        }

        if (!Page.IsPostBack)
        {
            //
        }

    }

    protected void bthelp_Click(object sender, EventArgs e)
    {
        //
        //if (Popuphelp.IsCallback)
        {
            // Intentionally pauses server-side processing, 
            // to demonstrate the Loading Panel functionality.
            Thread.Sleep(1000);
        }
    }

    protected void btprocessa_Click(object sender, EventArgs e)
    {
        Boolean lOk = true;
        //
        string usuarioselecionado = "";
        Int32 permissoes = 0;
        string stringpermissoes = "";
        //Usuario
        if (cbusuario.Text != string.Empty)
        {
            usuarioselecionado = cbusuario.Text;
        }
        else
        {
            lOk = false;
        }
        //Processa Permissões do Perfil de Usuário
        if (lOk)
        {
            permissoes = lookuppermissoesusuario.Items.Count;
            if (permissoes != 0)
            {
                for (int i = 0; i < permissoes; i++)
                {
                    stringpermissoes = stringpermissoes + Srelib.QStr(lookuppermissoesusuario.Items[i].ToString().Substring(0, 15)) + ", ";
                }
            }
        }
        //Grava
        if (lOk)
        {
            //Exclui Permissoes retiradas
            if (stringpermissoes != string.Empty)
            {
                stringpermissoes = stringpermissoes.Substring(0, stringpermissoes.Length - 2);
            }
            //
            uPermissoes.ExcluiPermissoesUsuario(usuarioselecionado, "", stringpermissoes);
            //Inclui Permissoes Acescentadas
            uPermissoes.GravaPermissoesUsuario(usuarioselecionado, "", stringpermissoes);
            //
            // CRIA LOG  ===============================================================================================================================================
            fwObs_Log = "PERFIL: " + usuarioselecionado + " - PERMISSÕES: " + stringpermissoes;
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
                                         new SqlParameter("@tabela"   , "USUARIO"                    ),
                                         new SqlParameter("@operacao" , "CONFIG"                     ),
                                         new SqlParameter("@obs"      , "PERMISSÕES PERFIL"          ),
                                         new SqlParameter("@acao"     , fwObs_Log                    ) };
            uLog.MakeLog(param_log);
            // FIM CRIA LOG ============================================================================================================================================
            //
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Processamento Concluído!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.success('Processamento Concluído!', 'Atenção!')", true);
        }

    }


    protected void btnGoToCedente_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
    {
        // CRIA LOG  ===============================================================================================================================================
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
                                     new SqlParameter("@tabela"   , "USUARIO"                    ),
                                     new SqlParameter("@operacao" , "CONFIG"                     ),
                                     new SqlParameter("@obs"      , "SELEÇÃO DE USUÁRIOS"        ),
                                     new SqlParameter("@acao"     , "SELEÇÃO USUÁRIO: "+e.CommandArgument.ToString()        ) };
        uLog.MakeLog(param_log);
        // FIM CRIA LOG ============================================================================================================================================

        //
        Session.Remove("wusuario");
        Session.Add("wusuario", e.CommandArgument.ToString());
        Response.Redirect("FConsultaUsuario.aspx");

        //ou

        //    ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( '" + HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpRuntime.AppDomainAppVirtualPath + "/relfact/relatorios/RelRiscoCedenteSacado.aspx', null, 'height=755,width=900,status=yes,resizable=yes,menubar=yes,location=yes' );", true);
    }


    protected void bttodosparausuario_Click(object sender, EventArgs e)
    {
        Boolean lOk = true;
        //
        string usuarioselecionado = "";
        //Usuario
        if (cbusuario.Text != string.Empty)
        {
            usuarioselecionado = cbusuario.Text;
        }
        else
        {
            lOk = false;
        }
        //Usuario
        if (lOk)
        {
            //
            //Atualiza grid permissões desejada
            if (usuarioselecionado != "")
            {
                // Desabilita
                cbusuario.Enabled = false;
                btprocessa.Enabled = true;
                bttodosparausuario.Enabled = true;
                btselecionadosparausuario.Enabled = true;
                btremovetodosdousuario.Enabled = true;
                btremoveselecionadodousuario.Enabled = true;
                // lookuppermissoesusuario
                lookuppermissoesusuario.Items.Clear();
                uPermissoes.MontaComboPermissoes(lookuppermissoesusuario, "");
                lookuppermissoes.Text = "";
                lookuppermissoesusuario.Text = "";
                //
                Label3.Text = "Permissões Disponíveis - " + lookuppermissoes.Items.Count.ToString();
                Label2.Text = "Permissões do Perfil de Usuário Selecionado (" + usuarioselecionado + ")  - " + lookuppermissoesusuario.Items.Count.ToString();
            }
        }
    }

    protected void btselecionadosparausuario_Click(object sender, EventArgs e)
    {
        string permissaocorrente = "";
        //Selecionado para Usuário
        if (lookuppermissoes.Text != string.Empty)
        {
            permissaocorrente = lookuppermissoes.Value.ToString();
            //
            if (lookuppermissoesusuario.Items.IndexOfValue(permissaocorrente) == -1)
            {
                //Incluir Permissão no Usuário
                lookuppermissoesusuario.Items.Add(permissaocorrente + " - " + uPermissoes.PegaDescricao(permissaocorrente), permissaocorrente);
                lookuppermissoes.Text = "";
                lookuppermissoesusuario.Text = "";
                //
                Label3.Text = "Permissões Disponíveis - " + lookuppermissoes.Items.Count.ToString();
                Label2.Text = "Permissões do Perfil de Usuário Selecionado (" + cbusuario.Text + ")  - " + lookuppermissoesusuario.Items.Count.ToString();
            }
        }
    }

    protected void btremovetodosdousuario_Click(object sender, EventArgs e)
    {
        Boolean lOk = true;
        //
        string usuarioselecionado = "";
        //Usuario
        if (cbusuario.Text != string.Empty)
        {
            usuarioselecionado = cbusuario.Text;
        }
        else
        {
            lOk = false;
        }
        //Usuario
        if (lOk)
        {

            //
            //Atualiza grid permissões desejada
            if (usuarioselecionado != "")
            {
                // Desabilita
                cbusuario.Enabled = false;
                btprocessa.Enabled = true;
                bttodosparausuario.Enabled = true;
                btselecionadosparausuario.Enabled = true;
                btremovetodosdousuario.Enabled = true;
                btremoveselecionadodousuario.Enabled = true;
                // lookuppermissoesusuario
                lookuppermissoesusuario.Items.Clear();
                uPermissoes.MontaComboPermissoesUsuario(lookuppermissoesusuario, "","");
                lookuppermissoes.Text = "";
                lookuppermissoesusuario.Text = "";
                //
                Label3.Text = "Permissões Disponíveis - " + lookuppermissoes.Items.Count.ToString();
                Label2.Text = "Permissões do Perfil de Usuário Selecionado (" + usuarioselecionado + ")  - " + lookuppermissoesusuario.Items.Count.ToString();
            }
        }
    }

    protected void btremoveselecionadodousuario_Click(object sender, EventArgs e)
    {
        string permissaocorrente = "";
        Int32 posicaocorrente = -1;
        //Selecionado para Usuário
        if (lookuppermissoesusuario.Text != string.Empty)
        {
            permissaocorrente = lookuppermissoesusuario.Value.ToString();
            //
            if (lookuppermissoes.Items.IndexOfValue(permissaocorrente) != -1)
            {
                //Remover Permissão no Usuário
                posicaocorrente = lookuppermissoesusuario.Items.IndexOfValue(permissaocorrente);
                lookuppermissoesusuario.Items.RemoveAt(posicaocorrente);
                lookuppermissoes.Text = "";
                lookuppermissoesusuario.Text = "";
                //
                Label3.Text = "Permissões Disponíveis - " + lookuppermissoes.Items.Count.ToString();
                Label2.Text = "Permissões do Perfil de Usuário Selecionado (" + cbusuario.Text + ")  - " + lookuppermissoesusuario.Items.Count.ToString();
            }
        }
    }

    protected void cbusuario_SelectedIndexChanged(object sender, EventArgs e)
    {
        Boolean lOk = true;
        //
        string usuarioselecionado = "";
        //Usuario
        if (cbusuario.Text != string.Empty)
        {
            usuarioselecionado = cbusuario.Text;
        }
        else
        {
            lOk = false;
        }
        //Usuario
        if (lOk)
        {

            //Atualiza grid permissões do usuário corrente
            if (usuarioselecionado != "")
            {
                // Desabilita
                cbusuario.Enabled = false;
                btprocessa.Enabled = true;
                //
                bttodosparausuario.Enabled = true;
                btselecionadosparausuario.Enabled = true;
                btremovetodosdousuario.Enabled = true;
                btremoveselecionadodousuario.Enabled = true;
                // lookuppermissoesusuario
                lookuppermissoesusuario.Items.Clear();
                uPermissoes.MontaComboPermissoesUsuario(lookuppermissoesusuario, usuarioselecionado,"");
                //
                Label3.Text = "Permissões Disponíveis - " + lookuppermissoes.Items.Count.ToString();
                Label2.Text = "Permissões do Perfil de Usuário Selecionado (" + usuarioselecionado + ")  - " + lookuppermissoesusuario.Items.Count.ToString();
            }
        }

    }
}

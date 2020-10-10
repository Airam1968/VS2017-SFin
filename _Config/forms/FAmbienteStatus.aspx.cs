using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;

public partial class FAmbienteStatus : System.Web.UI.Page
{
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "TODAS";
    DataSet ds0 = new DataSet();
    //

    protected void Page_Init(object sender, EventArgs e)
    {
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
        lbbasegitano.Text = "Base (" + (String)Session["BaseCorrente"] + ")";
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
        //Processamento
        //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Processamento Concluído!');", true);
        ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                            "toastr.success('cessamento Concluído!', 'Atenção!')", true);


        if (lOk)
        {
            //Tamanho da Base corrente
            lbbasegitano2.Text = "";
            ds0.Clear();
            ds0 = SreDblib.GetDsScript("EXEC sp_spaceused @updateusage = N" + Srelib.QStr("TRUE"));
            lbbasegitano2.Text = ds0.Tables[0].Rows[0]["database_size"].ToString();
            //
            try
            {
                //Tamanho da Base Cep
                lbbasecep2.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScriptCep("EXEC sp_spaceused @updateusage = N" + Srelib.QStr("TRUE"));
                lbbasecep2.Text = ds0.Tables[0].Rows[0]["database_size"].ToString();
            }
            catch (Exception)
            {
                //
            }
            //
            //lbusuariosativos
            lbusuariosativos2.Text = "";
            ds0.Clear();
            ds0 = SreDblib.GetDsScript("Select count(login) quantidade from usuario with(nolock) where ativo = 1");
            lbusuariosativos2.Text = ds0.Tables[0].Rows[0]["quantidade"].ToString();
            //
            //
            //lbclientesfinanciamentos
            lbclientesfinanciamentos2.Text = "";
            ds0.Clear();
            ds0 = SreDblib.GetDsScript("Select count(nome) quantidade from contato with(nolock) where ativo = 1");
            lbclientesfinanciamentos2.Text = ds0.Tables[0].Rows[0]["quantidade"].ToString();
            //
            //lbunidadescadastradas
            lbunidadescadastradas2.Text = "";
            ds0.Clear();
            ds0 = SreDblib.GetDsScript("Select count(produto) quantidade from produto_unidades with(nolock)");
            lbunidadescadastradas2.Text = ds0.Tables[0].Rows[0]["quantidade"].ToString();
            //
            //lbvendas
            lbvendas2.Text = "";
            ds0.Clear();
            ds0 = SreDblib.GetDsScript("Select count(produto) quantidade from vendas with(nolock)");
            lbvendas2.Text = ds0.Tables[0].Rows[0]["quantidade"].ToString();
            //
            //lbcontasareceber2
            lbcontasareceber2.Text = "";
            ds0.Clear();
            ds0 = SreDblib.GetDsScript("Select count(lancamento) quantidade from contas_receber with(nolock)");
            lbcontasareceber2.Text = ds0.Tables[0].Rows[0]["quantidade"].ToString();
            //
            //lbcontasapagar2
            lbcontasapagar2.Text = "";
            ds0.Clear();
            ds0 = SreDblib.GetDsScript("Select count(lancamento) quantidade from contas_pagar with(nolock)");
            lbcontasapagar2.Text = ds0.Tables[0].Rows[0]["quantidade"].ToString();
            //
            //lbclientescreceber2
            lbclientescreceber2.Text = "";
            ds0.Clear();
            ds0 = SreDblib.GetDsScript("Select count(nome) quantidade from clientes with(nolock)");
            lbclientescreceber2.Text = ds0.Tables[0].Rows[0]["quantidade"].ToString();
            //
            //lbfornecedorescpagar2
            lbfornecedorescpagar2.Text = "";
            ds0.Clear();
            ds0 = SreDblib.GetDsScript("Select count(nome) quantidade from fornecedores with(nolock)");
            lbfornecedorescpagar2.Text = ds0.Tables[0].Rows[0]["quantidade"].ToString();
            //
            //lbcontascorrentes2
            lbcontascorrentes2.Text = "";
            ds0.Clear();
            ds0 = SreDblib.GetDsScript("Select count(cod_banco) quantidade from contas with(nolock) ");
            lbcontascorrentes2.Text = ds0.Tables[0].Rows[0]["quantidade"].ToString();
            //
            //lbcorretores2
            lbcorretores2.Text = "";
            ds0.Clear();
            ds0 = SreDblib.GetDsScript("Select count(nome) quantidade from corretores with(nolock) ");
            lbcorretores2.Text = ds0.Tables[0].Rows[0]["quantidade"].ToString();
            //
            //lblog2
            lblog2.Text = "";
            ds0.Clear();
            ds0 = SreDblib.GetDsScript("Select count(login) quantidade from log with(nolock) ");
            lblog2.Text = ds0.Tables[0].Rows[0]["quantidade"].ToString();

        }

        if (lOk)
        {
            // CRIA LOG  ===============================================================================================================================================
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
                                         new SqlParameter("@tabela"   , "TODAS"                      ),
                                         new SqlParameter("@operacao" , "CONFIG"                     ),
                                         new SqlParameter("@obs"      , "STATUS"                     ),
                                         new SqlParameter("@acao"     , "STATUS DO AMBIENTE - " +
                                         "BASE ("+(String)Session["BaseCorrente"]+"): " +
                                         lbbasegitano2.Text                                          ) };
            uLog.MakeLog(param_log);
            // FIM CRIA LOG ============================================================================================================================================
        }
    }
}

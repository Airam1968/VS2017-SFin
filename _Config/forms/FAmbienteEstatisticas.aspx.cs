using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;

public partial class FAmbienteEstatisticas : System.Web.UI.Page
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


    protected void btmarcar_Click(object sender, EventArgs e)
    {
        //
        ckempresa.Checked = true;
        ckparametros.Checked = true;
        ckusuariopermissoes.Checked = true;
        ckclientes.Checked = true;
        ckproduto.Checked = true;
        ckprodutotipo.Checked = true;
        ckprodutogrupo1.Checked = true;
        ckprodutogrupo2.Checked = true;
        ckindexadores.Checked = true;
        cktaxasdiarias.Checked = true;
        cktaxasmensais.Checked = true;
        ckmensagensboleto.Checked = true;
        ckcorretores.Checked = true;
        ckdespesas.Checked = true;
        ckfornecedores.Checked = true;
        ckcpagarlancamentos.Checked = true;
        ckreceitas.Checked = true;
        ckclientescontaareceber.Checked = true;
        ckcreceberlancamentos.Checked = true;
        ckbancos.Checked = true;
        ckcontascorrentes.Checked = true;
        cksaldoinicial.Checked = true;
    }
    protected void btdesmarcar_Click(object sender, EventArgs e)
    {
        //
        ckempresa.Checked = false;
        ckparametros.Checked = false;
        ckusuariopermissoes.Checked = false;
        ckclientes.Checked = false;
        ckproduto.Checked = false;
        ckprodutotipo.Checked = false;
        ckprodutogrupo1.Checked = false;
        ckprodutogrupo2.Checked = false;
        ckindexadores.Checked = false;
        cktaxasdiarias.Checked = false;
        cktaxasmensais.Checked = false;
        ckmensagensboleto.Checked = false;
        ckcorretores.Checked = false;
        ckdespesas.Checked = false;
        ckfornecedores.Checked = false;
        ckcpagarlancamentos.Checked = false;
        ckreceitas.Checked = false;
        ckclientescontaareceber.Checked = false;
        ckcreceberlancamentos.Checked = false;
        ckbancos.Checked = false;
        ckcontascorrentes.Checked = false;
        cksaldoinicial.Checked = false;
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

        if (lOk)
        {
            if ((ckempresa.Checked == false) ||
               (ckparametros.Checked == false) ||
               (ckusuariopermissoes.Checked == false) ||
               (ckclientes.Checked == false) ||
               (ckproduto.Checked == false) ||
               (ckprodutotipo.Checked == false) ||
               (ckprodutogrupo1.Checked == false) ||
               (ckprodutogrupo2.Checked == false) ||
               (ckindexadores.Checked == false) ||
               (cktaxasdiarias.Checked == false) ||
               (cktaxasmensais.Checked == false) ||
               (ckmensagensboleto.Checked == false) ||
               (ckcorretores.Checked == false) ||
               (ckdespesas.Checked == false) ||
               (ckfornecedores.Checked == false) ||
               (ckcpagarlancamentos.Checked == false) ||
               (ckreceitas.Checked == false) ||
               (ckclientescontaareceber.Checked == false) ||
               (ckcreceberlancamentos.Checked == false) ||
               (ckbancos.Checked == false) ||
               (ckcontascorrentes.Checked == false) ||
               (cksaldoinicial.Checked == false))
            {
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Nenhuma Tabela marcada para Análise!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.error('Nenhuma Tabela marcada para Análise!', 'Atenção!')", true);
                lOk = false;
            }
        }

        if (lOk)
        {
            //Processamento
            //
            //ckempresa
            if (ckempresa.Checked)
            {
                lbempresa.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScript("Select count(nome) quantidade from empresa with(nolock) ");
                lbempresa.Text = Srelib.QStr0(String.Format("{0:N}", ds0.Tables[0].Rows[0]["quantidade"].ToString()), 10);
            }
            //
            //
            //ckparametros
            if (ckparametros.Checked)
            {
                lbparametros.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScript("Select count(nome) quantidade from parametros with(nolock)");
                lbparametros.Text = Srelib.QStr0(String.Format("{0:N}", ds0.Tables[0].Rows[0]["quantidade"].ToString()), 10);
            }
            //
            //ckusuariopermissoes
            if (ckusuariopermissoes.Checked)
            {
                lbusuariopermissoes.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScript("Select count(permissao) quantidade from cadpermissoes with(nolock)");
                lbusuariopermissoes.Text = Srelib.QStr0(String.Format("{0:N}", ds0.Tables[0].Rows[0]["quantidade"].ToString()), 10);
            }
            //
            //ckclientes
            if (ckclientes.Checked)
            {
                lbclientes.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScript("Select count(nome) quantidade from Contato with(nolock)");
                lbclientes.Text = Srelib.QStr0(String.Format("{0:N}", ds0.Tables[0].Rows[0]["quantidade"].ToString()), 10);
            }
            //
            //ckproduto
            if (ckproduto.Checked)
            {
                lbproduto.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScript("Select count(ID) quantidade from produto with(nolock)");
                lbproduto.Text = Srelib.QStr0(String.Format("{0:N}", ds0.Tables[0].Rows[0]["quantidade"].ToString()), 10);
            }
            //
            //ckprodutotipo
            if (ckprodutotipo.Checked)
            {
                lbprodutotipo.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScript("Select count(produto) quantidade from produto_tipo with(nolock)");
                lbprodutotipo.Text = Srelib.QStr0(String.Format("{0:N}", ds0.Tables[0].Rows[0]["quantidade"].ToString()), 10);
            }
            //
            //ckprodutogrupo1
            if (ckprodutogrupo1.Checked)
            {
                lbprodutogrupo1.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScript("Select count(ID) quantidade from produto_grupo with(nolock) where grupo_tipo = 1 ");
                lbprodutogrupo1.Text = Srelib.QStr0(String.Format("{0:N}", ds0.Tables[0].Rows[0]["quantidade"].ToString()), 10);
            }
            //
            //ckprodutogrupo2
            if (ckprodutogrupo2.Checked)
            {
                lbprodutogrupo2.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScript("Select count(ID) quantidade from produto_grupo with(nolock) where grupo_tipo = 2 ");
                lbprodutogrupo2.Text = Srelib.QStr0(String.Format("{0:N}", ds0.Tables[0].Rows[0]["quantidade"].ToString()), 10);
            }
            //
            //ckindexadores
            if (ckindexadores.Checked)
            {
                lbindexadores.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScript("Select count(nome) quantidade from indexadores with(nolock) ");
                lbindexadores.Text = Srelib.QStr0(String.Format("{0:N}", ds0.Tables[0].Rows[0]["quantidade"].ToString()), 10);
            }
            //
            //cktaxasdiarias
            if (cktaxasdiarias.Checked)
            {
                lbtaxasdiarias.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScript("Select count(data) quantidade from taxas_diarias with(nolock) ");
                lbtaxasdiarias.Text = Srelib.QStr0(String.Format("{0:N}", ds0.Tables[0].Rows[0]["quantidade"].ToString()), 10);
            }
            //
            //cktaxasmensais
            if (cktaxasmensais.Checked)
            {
                lbtaxasmensais.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScript("Select count(ano) quantidade from taxas_mensais with(nolock) ");
                lbtaxasmensais.Text = Srelib.QStr0(String.Format("{0:N}", ds0.Tables[0].Rows[0]["quantidade"].ToString()), 10);
            }
            //
            //ckmensagensboleto
            if (ckmensagensboleto.Checked)
            {
                lbmensagensboleto.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScript("Select count(ID) quantidade from boleto_mensagens with(nolock) ");
                lbmensagensboleto.Text = Srelib.QStr0(String.Format("{0:N}", ds0.Tables[0].Rows[0]["quantidade"].ToString()), 10);
            }
            //
            //ckcorretores
            if (ckcorretores.Checked)
            {
                lbcorretores.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScript("Select count(ID) quantidade from corretores with(nolock) ");
                lbcorretores.Text = Srelib.QStr0(String.Format("{0:N}", ds0.Tables[0].Rows[0]["quantidade"].ToString()), 10);
            }
            //
            //ckcorretores
            if (ckcorretores.Checked)
            {
                lbcorretores.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScript("Select count(ID) quantidade from corretores with(nolock) ");
                lbcorretores.Text = Srelib.QStr0(String.Format("{0:N}", ds0.Tables[0].Rows[0]["quantidade"].ToString()), 10);
            }
            //
            //ckdespesas
            if (ckdespesas.Checked)
            {
                lbdespesas.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScript("Select count(ID) quantidade from classe_despesas with(nolock) ");
                lbdespesas.Text = Srelib.QStr0(String.Format("{0:N}", ds0.Tables[0].Rows[0]["quantidade"].ToString()), 10);
            }
            //
            //ckfornecedores
            if (ckfornecedores.Checked)
            {
                lbfornecedores.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScript("Select count(ID) quantidade from fornecedores with(nolock) ");
                lbfornecedores.Text = Srelib.QStr0(String.Format("{0:N}", ds0.Tables[0].Rows[0]["quantidade"].ToString()), 10);
            }
            //
            //ckcpagarlancamentos
            if (ckcpagarlancamentos.Checked)
            {
                lbcpagarlancamentos.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScript("Select count(ID) quantidade from contas_pagar with(nolock) ");
                lbcpagarlancamentos.Text = Srelib.QStr0(String.Format("{0:N}", ds0.Tables[0].Rows[0]["quantidade"].ToString()), 10);
            }
            //
            //ckreceitas
            if (ckreceitas.Checked)
            {
                lbreceitas.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScript("Select count(ID) quantidade from classe_receitas with(nolock) ");
                lbreceitas.Text = Srelib.QStr0(String.Format("{0:N}", ds0.Tables[0].Rows[0]["quantidade"].ToString()), 10);
            }
            //
            //ckclientescontaareceber
            if (ckclientescontaareceber.Checked)
            {
                lbclientescontaareceber.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScript("Select count(ID) quantidade from clientes with(nolock) ");
                lbclientescontaareceber.Text = Srelib.QStr0(String.Format("{0:N}", ds0.Tables[0].Rows[0]["quantidade"].ToString()), 10);
            }
            //
            //ckcreceberlancamentos
            if (ckcreceberlancamentos.Checked)
            {
                lbcreceberlancamentos.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScript("Select count(ID) quantidade from contas_receber with(nolock) ");
                lbcreceberlancamentos.Text = Srelib.QStr0(String.Format("{0:N}", ds0.Tables[0].Rows[0]["quantidade"].ToString()), 10);
            }
            //
            //ckbancos
            if (ckbancos.Checked)
            {
                lbbancos.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScript("Select count(ID) quantidade from bancos with(nolock) ");
                lbbancos.Text = Srelib.QStr0(String.Format("{0:N}", ds0.Tables[0].Rows[0]["quantidade"].ToString()), 10);
            }
            //
            //ckcontascorrentes
            if (ckcontascorrentes.Checked)
            {
                lbcontascorrentes.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScript("Select count(ID) quantidade from contas with(nolock) ");
                lbcontascorrentes.Text = Srelib.QStr0(String.Format("{0:N}", ds0.Tables[0].Rows[0]["quantidade"].ToString()), 10);
            }
            //
            //cksaldoinicial
            if (cksaldoinicial.Checked)
            {
                lbsaldoinicial.Text = "";
                ds0.Clear();
                ds0 = SreDblib.GetDsScript("Select count(ID) quantidade from contas_saldo_inicial with(nolock) ");
                lbsaldoinicial.Text = Srelib.QStr0(String.Format("{0:N}", ds0.Tables[0].Rows[0]["quantidade"].ToString()), 10);
            }
            //
            //
            // CRIA LOG  ===============================================================================================================================================
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                         new SqlParameter("@tabela"   , "TODAS"                      ),
                                         new SqlParameter("@operacao" , "CONFIG"                     ),
                                         new SqlParameter("@obs"      , "ESTATÍSTICAS"               ),
                                         new SqlParameter("@acao"     , "ESTATÍSTICAS QUANTITATIVA"  ) };
            uLog.MakeLog(param_log);
            // FIM CRIA LOG ============================================================================================================================================
            //
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Processamento Concluído!');", true);
            //
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                "toastr.success('Processamento Concluído!', 'Atenção!')", true);

        }
    }
}

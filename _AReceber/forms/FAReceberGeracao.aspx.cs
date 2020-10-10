using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FAReceberGeracao : System.Web.UI.Page
{
    DataSet dsparcelas;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "";

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = SreDblib.TemPermissao("001.007.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.007.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.007.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.007.004.000", (String)Session["CodUsuario"]);
        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        //
        btprocessa.Enabled = lInsere;
        if (!lInsere)
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
            //Combo Empresas
            cbproduto.Items.Clear();
            uProduto.MontaComboProduto(cbproduto, true);
            //
            dtprevisao1.Date = Convert.ToDateTime("01/01/1900");
            dtprevisao2.Date = Convert.ToDateTime("31/12/2999");
        }

    }


    protected void cbproduto_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        if (cbproduto.Text != string.Empty)
        {
//
        }
        else
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
        //
        Boolean lOk = true;
        string produto = "";
        //CRITICAS
        if (lOk)
        {
            //CRIAÇÃO DA VARIÁVEL DE SESSÃO COM OS ELEMENTOS SELECIONADOS NO LOOKUP  ===============================================================================================================================================
            //Produto
            if (cbproduto.Text != string.Empty)
            {
                produto = cbproduto.Value.ToString().Trim();
            }
            else
            {
                produto = "";
            }
        }
        //
        if (lOk)
        {
            //Previsão
            Session.Remove("dtprevisao1");
            Session.Remove("dtprevisao2");
            if (dtprevisao1.Text != string.Empty)
            {
                Session.Add("dtprevisao1", dtprevisao1.Value.ToString().Trim());
            }
            else
            {
                Session.Add("dtprevisao1", "01/01/1900");
            }
            //
            if (dtprevisao2.Text != string.Empty)
            {
                Session.Add("dtprevisao2", dtprevisao2.Value.ToString().Trim());
            }
            else
            {
                Session.Add("dtprevisao2", "31/12/2999");
            }
            //
        }
        //
        if (lOk)
        {
            //Protesto
            //Protestar
            if (rbprevisto.SelectedIndex == 0)
            {
                //
            }
            else
            {
                //Não Protestar
                if (rbprevisto.SelectedIndex == 1)
                {
                    //
                }
                else
                {
                    //Desmarcado
                    lOk = false;
                    //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Previsto não Selecionado!');", true);
                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                        "toastr.error('Previsto não Selecionado!', 'Atenção!')", true);
                }
            }
        }
        //
        if (lOk)
        {
            //Processamento 
            uContasReceber.GeraLancamentos(produto,
                                           Convert.ToString(dtprevisao1.Value).Substring(0, 10),
                                           Convert.ToString(dtprevisao2.Value).Substring(0, 10),
                                           rbprevisto.SelectedIndex.ToString());
            //
            // CRIA LOG ===============================================================================================================================================
            fwObs_Log = "GERAÇÃO CONTAS A PAGAR: " + produto + " - ";
            fwObs_Log = fwObs_Log + " " + Convert.ToString(dtprevisao1.Value).Substring(0, 10) + " até " + Convert.ToString(dtprevisao2.Value).Substring(0, 10);
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ), 
                                         new SqlParameter("@tabela"   , fWtabela                              ),
                                         new SqlParameter("@operacao" , "PARCELAS"                            ),
                                         new SqlParameter("@obs"      , "GERAÇÃO CONTAS A PAGAR"              ),
                                         new SqlParameter("@acao"     , fwObs_Log                             ) };
            uLog.MakeLog(param_log);
            // FIM CRIA LOG ===============================================================================================================================================
            //
            btprocessa.Enabled = false;
            edfeedback.Text = "";
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Geração Concluída!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                "toastr.success('Geração Concluída!', 'Atenção!')", true);

        }

    }

    protected void rbprevisto_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        edfeedback.Text = "Importante!!! Após clicar no botão Processa, aguarde o fim do Processamento.";
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FBancosGeracao : System.Web.UI.Page
{
    DataSet dsparcelas;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "CONTAS";

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = SreDblib.TemPermissao("001.008.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.008.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.008.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.008.004.000", (String)Session["CodUsuario"]);
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
            //Combo Contas Correntes
            cbcontascorrentes.Items.Clear();
            uContas.MontaComboContas(cbcontascorrentes, "0");
            Label3.Visible = true;
            cbcontascorrentes.Visible = true;
            //
            Label5.Visible = true;
            dtprevisao1.Visible = true;
            Label6.Visible = true;
            dtprevisao2.Visible = true;
            //
            dtprevisao1.Date = DateTime.Now;
            dtprevisao2.Date = DateTime.Now;
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
        string contascorrentes = "";
        //CRITICAS
        if (lOk)
        {
            //CRIAÇÃO DA VARIÁVEL DE SESSÃO COM OS ELEMENTOS SELECIONADOS NO LOOKUP  ===============================================================================================================================================
            //Produto
            if (cbcontascorrentes.Text != string.Empty)
            {
                contascorrentes = cbcontascorrentes.Value.ToString().Trim();
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Selecione uma Conta Corrente!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.info('Selecione uma Conta Corrente!', 'Atenção!')", true);
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
                if (dtprevisao1.Value.ToString() != "01/01/1900")
                {
                    Session.Add("dtprevisao1", dtprevisao1.Value.ToString().Trim());
                }
                else
                {
                    lOk = false;
                    //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Selecione a Data Inicial!');", true);
                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                        "toastr.info('Selecione a Data Inicial!', 'Atenção!')", true);

                }
            }
            //
            if (dtprevisao2.Text != string.Empty)
            {
                if (dtprevisao1.Value.ToString() != "01/01/1900")
                {
                    Session.Add("dtprevisao2", dtprevisao2.Value.ToString().Trim());
                }
                else
                {
                    lOk = false;
                    //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Selecione a Data Inicial!');", true);
                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                        "toastr.info('Selecione a Data Inicial!', 'Atenção!')", true);

                }
            }
            //
        }
        //
        //
        if (lOk)
        {
            //Processamento 
            uContas.GeraLancamentos(contascorrentes,
                                   Convert.ToString(dtprevisao1.Value).Substring(0, 10),
                                   Convert.ToString(dtprevisao2.Value).Substring(0, 10),
                                   ckchequedeposito.Checked,
                                   ckfornecedor.Checked);
            //
            // CRIA LOG ===============================================================================================================================================
            fwObs_Log = "GERAÇÃO CONTA CORRENTE: " + contascorrentes + " - ";
            fwObs_Log = fwObs_Log + " " + Convert.ToString(dtprevisao1.Value).Substring(0, 10) + " até " + Convert.ToString(dtprevisao2.Value).Substring(0, 10);
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ), 
                                         new SqlParameter("@tabela"   , fWtabela                              ),
                                         new SqlParameter("@operacao" , "BANCOS"                              ),
                                         new SqlParameter("@obs"      , "GERAÇÃO CONTAS CORRENTE"             ),
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

    protected void cbcontascorrentes_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        string cbcontascorrentes2 = "";
        //
        if (cbcontascorrentes.Value != null)
        {
            cbcontascorrentes2 = cbcontascorrentes.Value.ToString().Trim();
        }
        dtprevisao1.Value = uContas.PegaDataInicial(cbcontascorrentes2);
        //
        edfeedback.Text = "Importante!!! Após clicar no botão Processa, aguarde o Fim do Processamento.";
    }

}

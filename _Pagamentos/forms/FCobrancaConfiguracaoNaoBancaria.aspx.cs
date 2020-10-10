using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FCobrancaConfiguracaoNaoBancaria : System.Web.UI.Page
{
    DataSet dsbancos;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "BANCOS";

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = SreDblib.TemPermissao("001.005.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.005.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.005.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.005.004.000", (String)Session["CodUsuario"]);
        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        //
        btprocessa.Enabled = lAltera;
        if (!lAltera)
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
            //Combo 
            cbbanco.Items.Clear();
            uBanco_2.MontaComboBanco(cbbanco);
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

        if (lOk)
        {
            //Processa 
            uBanco_2.AlteraBanco(uBanco_2.PegaIDCodigo(cbbanco.Value.ToString()),
                               cbbanco.Value.ToString(),
                               cbbanco.Text.Substring(8, cbbanco.Text.Length - 8),
                               DateTime.Now,
                               eddrivedados.Text,
                               edpastaremessa.Text,
                               edpastaretorno.Text,
                               edpastaenvelope.Text,
                               edassunto.Text,
                               edcaixapostal.Text,
                               edextensaoremessa.Text,
                               edextensaoretorno.Text,
                               ednomearquivo.Text,
                               ednumeroarquivo.Text,
                               edcobrancamulta.Text,
                               eddevolucaotitulos.Text,
                               edcobrancamulta.Text,
                               edmulta.Text,
                               edjuros.Text,
                               edcomissao.Text,
                               edcarteira.Text,
                               ednuminicial.Text,
                               ednumfinal.Text,
                               edremessa.Text,
                               ednumatual.Text,
                               edcomplemento.Text);


            //
            // CRIA LOG ===============================================================================================================================================
            fwObs_Log = "COBRANÇA CONFIGURAÇÃO: " + cbbanco.Value.ToString();
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ), 
                                         new SqlParameter("@tabela"   , fWtabela                              ),
                                         new SqlParameter("@operacao" , "COBRANÇA"                            ),
                                         new SqlParameter("@obs"      , "COBRANÇA CONFIGURAÇÃO"               ),
                                         new SqlParameter("@acao"     , fwObs_Log                             ) };
            uLog.MakeLog(param_log);
            // FIM CRIA LOG ===============================================================================================================================================
            //
            //
            btprocessa.Enabled = false;
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Configuração Registrada!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.success('Configuração Registrada!', 'Atenção!')", true);
        }

    }

    protected void cbbanco_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Prepara
        dtconfiguracao.Date = Convert.ToDateTime("01/01/1900");
        eddrivedados.Text = "";
        edpastaremessa.Text = "";
        edpastaretorno.Text = "";
        edpastaenvelope.Text = "";
        edextensaoremessa.Text = "";
        edextensaoretorno.Text = "";
        ednomearquivo.Text = "";
        ednumeroarquivo.Text = "";
        edassunto.Text = "";
        eddevolucaotitulos.Text = "0";
        edprotesto.Text = "0";
        edcobrancamulta.Text = "0";
        edmulta.Text = "0,00";
        edjuros.Text = "0,00";
        edcomissao.Text = "0,00";
        edcaixapostal.Text = "0";
        edremessa.Text = "0";
        edcarteira.Text = "0";
        ednuminicial.Text = "0";
        ednumfinal.Text = "0";
        ednumatual.Text = "0";
        edcomplemento.Text = "";
        edfeedback.Text = "";
        //
        dtconfiguracao.Enabled = false;
        eddrivedados.Enabled = true;
        edpastaremessa.Enabled = true;
        edpastaretorno.Enabled = true;
        edpastaenvelope.Enabled = true;
        edextensaoremessa.Enabled = true;
        edextensaoretorno.Enabled = true;
        ednomearquivo.Enabled = true;
        ednumeroarquivo.Enabled = true;
        edassunto.Enabled = true;
        eddevolucaotitulos.Enabled = true;
        edprotesto.Enabled = true;
        edcobrancamulta.Enabled = true;
        edmulta.Enabled = true;
        edjuros.Enabled = true;
        edcomissao.Enabled = true;
        edcaixapostal.Enabled = true;
        edremessa.Enabled = true;
        edcarteira.Enabled = true;
        ednuminicial.Enabled = true;
        ednumfinal.Enabled = true;
        ednumatual.Enabled = true;
        edcomplemento.Enabled = true;
        edfeedback.Enabled = true;
        //
        Label3.Visible = true;
        Label23.Visible = true;
        Label5.Visible = true;
        Label6.Visible = true;
        Label7.Visible = true;
        Label8.Visible = true;
        Label9.Visible = true;
        Label10.Visible = true;
        Label11.Visible = true;
        Label12.Visible = true;
        Label13.Visible = true;
        Label14.Visible = true;
        Label15.Visible = true;
        Label24.Visible = true;
        Label2.Visible = true;
        Label4.Visible = true;
        Label16.Visible = true;
        Label17.Visible = true;
        Label18.Visible = true;
        Label19.Visible = true;
        Label20.Visible = true;
        Label21.Visible = true;
        //
        dtconfiguracao.Visible = true;
        eddrivedados.Visible = true;
        edpastaremessa.Visible = true;
        edpastaretorno.Visible = true;
        edpastaenvelope.Visible = true;
        edextensaoremessa.Visible = true;
        edextensaoretorno.Visible = true;
        ednomearquivo.Visible = true;
        ednumeroarquivo.Visible = true;
        edassunto.Visible = true;
        eddevolucaotitulos.Visible = true;
        edprotesto.Visible = true;
        edcobrancamulta.Visible = true;
        edmulta.Visible = true;
        edjuros.Visible = true;
        edcomissao.Visible = true;
        edcaixapostal.Visible = true;
        edremessa.Visible = true;
        edcarteira.Visible = true;
        ednuminicial.Visible = true;
        ednumfinal.Visible = true;
        ednumatual.Visible = true;
        edcomplemento.Visible = true;
        edfeedback.Visible = true;
        //
        //Carregar Dados
        //
        dsbancos = uBanco_2.PegaDadosBancos(Convert.ToInt16(cbbanco.Value));
        if (dsbancos.Tables[0].Rows[0]["data"] != null)
        {
            dtconfiguracao.Date = Convert.ToDateTime(dsbancos.Tables[0].Rows[0]["data"].ToString().Substring(0, 10));
        }
        eddrivedados.Text = dsbancos.Tables[0].Rows[0]["drive"].ToString();
        edpastaremessa.Text = dsbancos.Tables[0].Rows[0]["pasta_remessa"].ToString();
        edpastaretorno.Text = dsbancos.Tables[0].Rows[0]["pasta_retorno"].ToString();
        edpastaenvelope.Text = dsbancos.Tables[0].Rows[0]["pasta_envelope"].ToString();
        edextensaoremessa.Text = dsbancos.Tables[0].Rows[0]["mascara_remessa"].ToString();
        edextensaoretorno.Text = dsbancos.Tables[0].Rows[0]["mascara_retorno"].ToString();
        ednomearquivo.Text = dsbancos.Tables[0].Rows[0]["nome_arquivo"].ToString();
        ednumeroarquivo.Text = dsbancos.Tables[0].Rows[0]["numero_arquivo"].ToString();
        edassunto.Text = dsbancos.Tables[0].Rows[0]["assunto"].ToString();
        eddevolucaotitulos.Text = dsbancos.Tables[0].Rows[0]["prazo_dev"].ToString();
        edprotesto.Text = dsbancos.Tables[0].Rows[0]["prazo_pro"].ToString();
        edcobrancamulta.Text = dsbancos.Tables[0].Rows[0]["prazo_fol"].ToString();
        edmulta.Text = dsbancos.Tables[0].Rows[0]["multa"].ToString();
        edjuros.Text = dsbancos.Tables[0].Rows[0]["juros"].ToString();
        edcomissao.Text = dsbancos.Tables[0].Rows[0]["comissao"].ToString();
        edcaixapostal.Text = dsbancos.Tables[0].Rows[0]["caixa_postal"].ToString();
        edremessa.Text = dsbancos.Tables[0].Rows[0]["sequencia"].ToString();
        edcarteira.Text = dsbancos.Tables[0].Rows[0]["carteira"].ToString();
        ednuminicial.Text = dsbancos.Tables[0].Rows[0]["num_inicial"].ToString();
        ednumfinal.Text = dsbancos.Tables[0].Rows[0]["num_final"].ToString();
        ednumatual.Text = dsbancos.Tables[0].Rows[0]["numero_atual"].ToString();
        edcomplemento.Text = dsbancos.Tables[0].Rows[0]["complemento"].ToString();
        //
        btprocessa.Enabled = true;
        //
        edfeedback.Text = "Preencha os campos e clique no Botão Processa.";
        //
        eddrivedados.Focus();
        //
    }

}

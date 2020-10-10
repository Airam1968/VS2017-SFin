using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FVendasQuitacao : System.Web.UI.Page
{
    DataSet dsunidade;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "VENDAS";

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = SreDblib.TemPermissao("001.004.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.004.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.004.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.004.004.000", (String)Session["CodUsuario"]);
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
            //Combo Produto
            cbproduto.Items.Clear();
            uProduto.MontaComboProduto(cbproduto, true);
            //
        }

    }


    protected void cbproduto_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        if (cbproduto.Text != string.Empty)
        {
            //Combo Grupo
            //string tipo = "";
            cbgrupo.Items.Clear();
            //tipo = uProduto.PegaTipo(Convert.ToInt32(cbproduto.Value));
            uProduto.MontaComboGrupo(cbgrupo, Convert.ToString(cbproduto.Value).Trim(), true);
            Label2.Visible = true;
            cbgrupo.Visible = true;
        }
        else
        {
            Label2.Visible = false;
            cbgrupo.Visible = false;
        }

    }

    protected void cbgrupo_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        if (cbproduto.Text != string.Empty)
        {
            if (cbgrupo.Text != string.Empty)
            {
                //Combo Unidades
                cbgrupounidades.Items.Clear();
                //tipo = uProduto.PegaTipo(Convert.ToInt32(cbproduto.Value));
                uProduto.MontaComboUnidades(cbgrupounidades, Convert.ToString(cbproduto.Value).Trim(), Convert.ToString(cbgrupo.Value).Trim(), true);
                if (cbgrupounidades.Items.Count == 0)
                {
                    btprocessa.Enabled = false;
                    //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não Há Unidades Disponíveis!');", true);
                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                    "toastr.info('Não Há Unidades Disponíveis!', 'Atenção!')", true);
                }
                Label7.Visible = true;
                cbgrupounidades.Visible = true;
            }
            else
            {
                Label2.Visible = true;
                cbgrupo.Visible = true;
                Label7.Visible = false;
                cbgrupounidades.Visible = false;
            }
        }

    }

    protected void cbgrupounidades_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        if (cbproduto.Text != string.Empty)
        {
            if (cbgrupo.Text != string.Empty)
            {
                if (cbgrupounidades.Text != string.Empty)
                {
                    //Cliente
                    Label8.Visible = true;
                    edcliente.Visible = true;
                    Label4.Visible = true;
                    edfeedback.Visible = true;
                    string grupounidades = cbgrupounidades.Text;
                    string parte = grupounidades.Substring(grupounidades.IndexOf("-") + 1).Trim();
                    if (parte != "0")
                    {
                        rbmeiolote.Enabled = true;
                        rbmeiolote.Visible = true;
                    }
                    else
                    {
                        rbmeiolote.Enabled = false;
                        rbmeiolote.Visible = false;
                    }
                    string IDCliente = uUnidade.PegaIDCliente(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte, "1");
                    edcliente.Text = Srelib.QStr0(IDCliente.Trim(), 5) + " - " + uContato.PegaNomeID(IDCliente);
                    //Feedback
                    string quest = parte;
                    if (quest != "0")
                    {
                        quest = (rbmeiolote.SelectedIndex + 1).ToString();
                    }
                    if (!uParcelas.TemParcelaAberto(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), quest))
                    {
                        btprocessa.Enabled = true;
                        edfeedback.Text = "A Quitação ocorrerá se não existir parcelas em aberto. Clique no Botão Processa para efetuar a Quitação!";
                    }
                    else
                    {
                        btprocessa.Enabled = false;
                        edfeedback.Text = "Existem parcelas em aberto neste Financiamento, não é possível efetuar a Quitação!";
                    }
                    //
                    if (uVendas.TemQuitacao(cbproduto.Value.ToString(),
                                                     cbgrupo.Value.ToString(),
                                                     cbgrupounidades.Value.ToString(),
                                                     parte))
                    {
                        Label42.Visible = true;
                        edfeedback.Text = "Financiamento Quitado no Sistema!";
                        btprocessa.Enabled = false;
                    }
                    else
                    {
                        Label42.Visible = false;
                    }
                    //
                }
                else
                {
                    //Cliente
                    Label8.Visible = false;
                    edcliente.Visible = false;
                    //Feedback
                    Label4.Visible = false;
                    edfeedback.Visible = false;
                    Label42.Visible = false;
                }
            }
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
        string produto = "";
        string grupo = "";
        string grupounidade = "";
        string grupounidadeparte = "";
        string grupounidadepartemeiolote = "";
        //

        if (lOk)
        {
            //Check da Unidade para Quitação
            //Produto
            if (cbproduto.Text != string.Empty)
            {
                if (cbgrupo.Text != string.Empty)
                {
                    if (cbgrupounidades.Text != string.Empty)
                    {
                        produto = cbproduto.Value.ToString();
                        grupo = cbgrupo.Value.ToString();
                        grupounidade = cbgrupounidades.Value.ToString();
                        grupounidadeparte = cbgrupounidades.Text.ToString();
                        grupounidadeparte = grupounidadeparte.Substring(grupounidadeparte.IndexOf("-") + 1).Trim();
                        if (grupounidadeparte != "0")
                        {
                            //ou 1 ou 2
                            grupounidadepartemeiolote = (rbmeiolote.SelectedIndex + 1).ToString();
                        }

                    }
                    else
                    {
                        lOk = false;
                        //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione uma Unidade!');", true);
                        ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                        "toastr.info('Selecione uma Unidade!', 'Atenção!')", true);
                    }

                }
                else
                {
                    lOk = false;
                    //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione um Grupo!');", true);
                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                    "toastr.info('Selecione um Grupo!', 'Atenção!')", true);
                }
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione um Produto!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Selecione um Produto!', 'Atenção!')", true);
            }
            //Fim Check da Unidade para Quitação
        }
        if (lOk)
        {
            if (uParcelas.TemParcelaAberto(produto,
                                           grupo,
                                           grupounidade,
                                           grupounidadeparte))
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Existem Parcelas em Aberto, Quitação Não Permitida!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Existem Parcelas em Aberto, Quitação Não Permitida!', 'Atenção!')", true);
            }
        }

        if (lOk)
        {
            //Processa Quitação da Venda
            if (grupounidadeparte == "0")
            {
                uVendas.GravaQuitacaoUnidade(produto,
                                             grupo,
                                             grupounidade,
                                             grupounidadeparte);
            }
            else
            {
                uVendas.GravaQuitacaoUnidade(produto,
                                             grupo,
                                             grupounidade,
                                             grupounidadepartemeiolote);
            }
            //Fim Processa Quitação da Venda
            //
            // CRIA LOG ===================================================================================================================================================
            if (grupounidadeparte == "0")
            {
                fwObs_Log = "QUITAÇÃO UNIDADE: " + produto + "/" + grupo + "/" + grupounidade + "/" + grupounidadeparte;
            }
            else
            {
                fwObs_Log = "QUITAÇÃO UNIDADE: " + produto + "/" + grupo + "/" + grupounidade + "/" + grupounidadepartemeiolote;
            }
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ),
                                         new SqlParameter("@tabela"   , fWtabela                              ),
                                         new SqlParameter("@operacao" , "VENDAS"                              ),
                                         new SqlParameter("@obs"      , "QUITAÇÃO UNIDADE"                    ),
                                         new SqlParameter("@acao"     , fwObs_Log                             ) };
            uLog.MakeLog(param_log);
            // FIM CRIA LOG ===============================================================================================================================================
            //
            btprocessa.Enabled = false;
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Processamento Concluído!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.success('Processamento Concluído!', 'Atenção!')", true);
        }

    }

    protected void rbmeiolote_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        //Cliente
        string grupounidades = cbgrupounidades.Text;
        string parte = grupounidades.Substring(grupounidades.IndexOf("-") + 1).Trim();
        string meiolote = "1";
        if (parte != "0")
        {
            if (rbmeiolote.SelectedIndex == 0)
            {
                meiolote = "1";
            }
            else
            {
                meiolote = "2";
            }
        }
        else
        {
            rbmeiolote.Enabled = false;
            rbmeiolote.Visible = false;
        }
        //
        string IDCliente = uUnidade.PegaIDCliente(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte, meiolote);
        edcliente.Text = Srelib.QStr0(IDCliente.Trim(), 5) + " - " + uContato.PegaNomeID(IDCliente);
        //Feedback
        string quest = parte;
        if (quest != "0")
        {
            quest = meiolote;
        }
        if (!uParcelas.TemParcelaAberto(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), quest))
        {
            edfeedback.Text = "A Quitação ocorrerá se não existir parcelas em aberto. Clique no Botão Processa para efetuar a Quitação!";
            btprocessa.Enabled = true;
        }
        else
        {
            edfeedback.Text = "Existem parcelas em aberto neste Financiamento, não é possível efetuar a Quitação!";
            btprocessa.Enabled = false;
        }
        Label8.Visible = true;
        edcliente.Visible = true;
        //
        Label4.Visible = true;
        edfeedback.Visible = true;
        //
        //
        if (uVendas.TemQuitacao(cbproduto.Value.ToString(),
                                         cbgrupo.Value.ToString(),
                                         cbgrupounidades.Value.ToString(),
                                         parte))
        {
            Label42.Visible = true;
            edfeedback.Text = "Financiamento Quitado no Sistema!";
            btprocessa.Enabled = false;
        }
        else
        {
            Label42.Visible = false;
            btprocessa.Enabled = true;
        }
        //
    }

}

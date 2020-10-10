using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FVendasPermutaUnidade : System.Web.UI.Page
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
            //Combo Produto
            cbproduto2.Items.Clear();
            uProduto.MontaComboProduto(cbproduto2, true);
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
                    //Cliente
                    Label8.Visible = true;
                    edcliente.Visible = true;
                    //Tipo
                    Label10.Visible = true;
                    rbtipodestino.Visible = true;
                    //Produto 2
                    Label5.Visible = true;
                    cbproduto2.Visible = true;
                    //Feedback
                    Label4.Visible = true;
                    edfeedback.Visible = true;
                    //
                }
                else
                {
                    //Cliente
                    Label8.Visible = false;
                    edcliente.Visible = false;
                    //Tipo
                    Label10.Visible = false;
                    rbtipodestino.Visible = false;
                    //Produto 2
                    Label5.Visible = false;
                    cbproduto2.Visible = false;
                    //Feedback
                    Label4.Visible = false;
                    edfeedback.Visible = false;
                    //

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
        //
        string produto = "";
        string grupo = "";
        string grupounidade = "";
        string grupounidadeparte = "";
        string grupounidademeiolote = "";
        //
        string produto2 = "";
        string grupo2 = "";
        string grupounidade2 = "";
        string grupounidadeparte2 = "";
        string grupounidademeiolote2 = "";
        //
        //
        string cliente = "";
        string grupounidades = "";
        string parte = "";
        //
        string cliente2 = "";
        string grupounidades2 = "";
        string parte2 = "";
        //
        if (lOk)
        {
            //Check da Unidade Origem
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
                        grupounidademeiolote = (rbmeiolote.SelectedIndex + 1).ToString();

                    }
                    else
                    {
                        lOk = false;
                        //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione uma Unidade Origem!');", true);
                        ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                        "toastr.info('Selecione uma Unidade Origem!', 'Atenção!')", true);
                    }

                }
                else
                {
                    lOk = false;
                    //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione um Grupo Origem!');", true);
                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                    "toastr.info('Selecione uma Grupo Origem!', 'Atenção!')", true);
                }
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione um Produto Origem!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Selecione uma Produto Origem!', 'Atenção!')", true);
            }
            //Fim Check da Unidade Origem
        }
        //
        if (lOk)
        {
            //Check da Unidade Destino
            //Produto
            if (cbproduto2.Text != string.Empty)
            {
                if (cbgrupo2.Text != string.Empty)
                {
                    if (cbgrupounidades2.Text != string.Empty)
                    {
                        produto2 = cbproduto2.Value.ToString();
                        grupo2 = cbgrupo2.Value.ToString();
                        grupounidade2 = cbgrupounidades2.Value.ToString();
                        grupounidadeparte2 = cbgrupounidades2.Text.ToString();
                        grupounidadeparte2 = grupounidadeparte2.Substring(grupounidadeparte2.IndexOf("-") + 1).Trim();
                        grupounidademeiolote2 = (rbmeiolote2.SelectedIndex + 1).ToString();

                    }
                    else
                    {
                        lOk = false;
                        //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione uma Unidade Destino!');", true);
                        ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                        "toastr.info('Selecione uma Unidade Destino!', 'Atenção!')", true);
                    }

                }
                else
                {
                    lOk = false;
                    //  
                    //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione um Grupo Destino!');", true);
                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                    "toastr.info('Selecione uma Grupo Origem!', 'Atenção!')", true);
                }
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione um Produto Destino!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Selecione uma Produto Origem!', 'Atenção!')", true);
            }
            //Fim Check da Unidade Destino
        }
        //
        if (lOk)
        {
            cliente = "";
            grupounidades = cbgrupounidades.Text;
            parte = grupounidades.Substring(grupounidades.IndexOf("-") + 1).Trim();
            grupounidademeiolote = (rbmeiolote.SelectedIndex + 1).ToString();
            if (grupounidadeparte != "0")
            {
                //
                cliente = uUnidade.PegaIDCliente(cbproduto.Value.ToString(),
                                                 cbgrupo.Value.ToString(),
                                                 cbgrupounidades.Value.ToString(),
                                                 parte,
                                                 "1");
            }
            else
            {
                cliente = uUnidade.PegaIDCliente(cbproduto.Value.ToString(),
                                                 cbgrupo.Value.ToString(),
                                                 cbgrupounidades.Value.ToString(),
                                                 parte,
                                                 grupounidademeiolote);
            }
            //
            cliente2 = "";
            grupounidades2 = cbgrupounidades2.Text;
            parte2 = grupounidades2.Substring(grupounidades.IndexOf("-") + 1).Trim();
            grupounidademeiolote2 = (rbmeiolote2.SelectedIndex + 1).ToString();
            if (grupounidadeparte2 != "0")
            {
                //
                cliente2 = uUnidade.PegaIDCliente(cbproduto2.Value.ToString(),
                                                 cbgrupo2.Value.ToString(),
                                                 cbgrupounidades2.Value.ToString(),
                                                 parte2,
                                                 "1");
            }
            else
            {
                cliente2 = uUnidade.PegaIDCliente(cbproduto2.Value.ToString(),
                                                 cbgrupo2.Value.ToString(),
                                                 cbgrupounidades2.Value.ToString(),
                                                 parte2,
                                                 grupounidademeiolote2);
            }
        }
        //
        //
        if (lOk)
        {
            //Processa Permuta Unidade
            if (rbtipodestino.SelectedIndex == 0)
            {
                //Disponíveis
                uVendas.GravaPermutaUnidade(produto,
                                            grupo,
                                            grupounidade,
                                            grupounidadeparte,
                                            grupounidademeiolote,
                                            cliente,
                                            produto2,
                                            grupo2,
                                            grupounidade2,
                                            grupounidadeparte2,
                                            grupounidademeiolote2,
                                            rbtipodestino.SelectedIndex.ToString().Trim());
            }
            else
            {
                //Vendidos
                uVendas.GravaPermutaUnidadeVendida(produto,
                                                   grupo,
                                                   grupounidade,
                                                   grupounidadeparte,
                                                   grupounidademeiolote,
                                                   cliente,
                                                   cliente2,
                                                   produto2,
                                                   grupo2,
                                                   grupounidade2,
                                                   grupounidadeparte2,
                                                   grupounidademeiolote2,
                                                   rbtipodestino.SelectedIndex.ToString().Trim());
            }

            //Fim Processa Permuta Unidade
            //
            // CRIA LOG ===================================================================================================================================================
            fwObs_Log = "PERMUTA UNIDADE: " + produto + "/" + grupo + "/" + grupounidade + "/" + grupounidadeparte+
                        " PARA: " + produto2 + "/" + grupo2 + "/" + grupounidade2 + "/" + grupounidadeparte2;
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ), 
                                         new SqlParameter("@tabela"   , fWtabela                              ),
                                         new SqlParameter("@operacao" , "VENDAS"                              ),
                                         new SqlParameter("@obs"      , "PERMUTA UNIDADE"                     ),
                                         new SqlParameter("@acao"     , fwObs_Log                             ) };
            uLog.MakeLog(param_log);
            // FIM CRIA LOG ===============================================================================================================================================
            //
            btprocessa.Enabled = false;
            //  
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Processamento Concluído!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.success('Processamento Concluído!', 'Atenção!')", true);
        }

    }

    protected void cbproduto2_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        //
        if (cbproduto2.Text != string.Empty)
        {
            //Combo Grupo
            //string tipo = "";
            cbgrupo2.Items.Clear();
            //tipo = uProduto.PegaTipo(Convert.ToInt32(cbproduto.Value));
            uProduto.MontaComboGrupo(cbgrupo2, Convert.ToString(cbproduto2.Value).Trim(), true);
            Label6.Visible = true;
            cbgrupo2.Visible = true;
        }
        else
        {
            Label6.Visible = false;
            cbgrupo2.Visible = false;
        }
    }

    protected void cbgrupo2_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        if (rbtipodestino.SelectedIndex == 0)
        {
            //Disponíveis
            if (cbproduto2.Text != string.Empty)
            {
                if (cbgrupo2.Text != string.Empty)
                {
                    //Combo Unidades
                    cbgrupounidades2.Items.Clear();
                    //tipo = uProduto.PegaTipo(Convert.ToInt32(cbproduto.Value));
                    uProduto.MontaComboUnidades(cbgrupounidades2,
                                                Convert.ToString(cbproduto2.Value).Trim(),
                                                Convert.ToString(cbgrupo2.Value).Trim(),
                                                false);
                    if (cbgrupounidades2.Items.Count == 0)
                    {
                        btprocessa.Enabled = false;
                        //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não Há Unidades Disponíveis!');", true);
                        ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                        "toastr.info('Não Há Unidades Disponíveis!', 'Atenção!')", true);
                    }
                    Label9.Visible = true;
                    cbgrupounidades2.Visible = true;
                }
                else
                {
                    Label6.Visible = true;
                    cbgrupo2.Visible = true;
                    Label9.Visible = false;
                    cbgrupounidades2.Visible = false;
                }
            }
        }
        else
        {
            //Vendidos
            if (cbproduto2.Text != string.Empty)
            {
                if (cbgrupo2.Text != string.Empty)
                {
                    //Combo Unidades
                    cbgrupounidades2.Items.Clear();
                    //tipo = uProduto.PegaTipo(Convert.ToInt32(cbproduto.Value));
                    uProduto.MontaComboUnidades(cbgrupounidades2,
                                                Convert.ToString(cbproduto2.Value).Trim(),
                                                Convert.ToString(cbgrupo2.Value).Trim(),
                                                true);
                    if (cbgrupounidades2.Items.Count == 0)
                    {
                        btprocessa.Enabled = false;
                        //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não Há Unidades Disponíveis!');", true);
                        ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                        "toastr.info('Não Há Unidades Disponíveis!', 'Atenção!')", true);
                    }
                    Label9.Visible = true;
                    cbgrupounidades2.Visible = true;
                }
                else
                {
                    Label6.Visible = true;
                    cbgrupo2.Visible = true;
                    Label9.Visible = false;
                    cbgrupounidades2.Visible = false;
                }
            }
        }

    }


    protected void cbgrupounidades2_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        if (cbproduto2.Text != string.Empty)
        {
            if (cbgrupo2.Text != string.Empty)
            {
                if (cbgrupounidades2.Text != string.Empty)
                {
                    //Cliente
                    string grupounidades2 = cbgrupounidades2.Text;
                    string parte2 = grupounidades2.Substring(grupounidades2.IndexOf("-") + 1).Trim();
                    if (parte2 != "0")
                    {
                        rbmeiolote2.Enabled = true;
                        rbmeiolote2.Visible = true;
                    }
                    else
                    {
                        rbmeiolote2.Enabled = false;
                        rbmeiolote2.Visible = false;
                    }
                    //
                    if (rbtipodestino.SelectedIndex == 1)
                    {
                        string IDCliente2 = uUnidade.PegaIDCliente(cbproduto2.Value.ToString(), cbgrupo2.Value.ToString(), cbgrupounidades2.Value.ToString(), parte2, "1");
                        edcliente2.Text = Srelib.QStr0(IDCliente2.Trim(), 5) + " - " + uContato.PegaNomeID(IDCliente2);
                        //Cliente
                        Label11.Visible = true;
                        edcliente2.Visible = true;
                    }
                    //
                    //Feedback
                    edfeedback.Text = "Clique no Botão Processar para efetuar a Permuta!";
                    btprocessa.Enabled = true;
                    //
                }
                else
                {
                    //Feedback
                    edfeedback.Text = "Selecione a Unidade Destino!";
                    btprocessa.Enabled = false;
                    //
                }
            }
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
        Label8.Visible = true;
        edcliente.Visible = true;
        //
        Label10.Visible = true;
        rbtipodestino.Visible = true;
        //
    }

    protected void rbmeiolote2_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        //Cliente 2
        string grupounidades2 = cbgrupounidades2.Text;
        string parte = grupounidades2.Substring(grupounidades2.IndexOf("-") + 1).Trim();
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
            rbmeiolote2.Enabled = false;
            rbmeiolote2.Visible = false;
        }
        //
        if (rbtipodestino.SelectedIndex == 1)
        {
            string IDCliente2 = uUnidade.PegaIDCliente(cbproduto2.Value.ToString(), cbgrupo2.Value.ToString(), cbgrupounidades2.Value.ToString(), parte, "1");
            edcliente2.Text = Srelib.QStr0(IDCliente2.Trim(), 5) + " - " + uContato.PegaNomeID(IDCliente2);
            //Cliente
            Label11.Visible = true;
            edcliente2.Visible = true;
        }
    }
}


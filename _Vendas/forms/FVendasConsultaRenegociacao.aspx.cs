using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FVendasConsultaRenegociacao : System.Web.UI.Page
{
    DataSet dsparcelas;
    DataSet dsvenda;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "VENDAS";

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = SreDblib.TemPermissao("001.003.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.003.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.003.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.003.004.000", (String)Session["CodUsuario"]);
        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        //
        btprocessa.Enabled = lConsulta;
        if (!lConsulta)
            btprocessa.Image.ToolTip = Msg_acesso;
        //
        lInsere = false;
        lAltera = false;
        lExclui = false;
        lConsulta = false;
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
        }

        if (edqtdsinal.IsVisible() && ((edqtdsinal.Text != "0") && (edqtdsinal.Text != "")))
        {
            Divsinalparcelado.Style[HtmlTextWriterStyle.Visibility] = "visible";
        }
        else
        {
            Divsinalparcelado.Style[HtmlTextWriterStyle.Visibility] = "hidden";
        }

        if (edqtdintermediarias.IsVisible() && ((edqtdintermediarias.Text != "0") && (edqtdintermediarias.Text != "")))
        {
            Divintermediaria.Style[HtmlTextWriterStyle.Visibility] = "visible";
        }
        else
        {
            Divintermediaria.Style[HtmlTextWriterStyle.Visibility] = "hidden";
        }

        if (edqtdfluxoparcelas.IsVisible() && ((edqtdfluxoparcelas.Text != "0") && (edqtdfluxoparcelas.Text != "")))
        {
            Divfluxos.Style[HtmlTextWriterStyle.Visibility] = "visible";
        }
        else
        {
            Divfluxos.Style[HtmlTextWriterStyle.Visibility] = "hidden";
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
            GridListagem.Visible = false;
        }
        else
        {
            Label2.Visible = false;
            cbgrupo.Visible = false;
            GridListagem.Visible = false;
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
                    //
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
                        //
                        string IDCliente = uUnidade.PegaIDCliente(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte, "1");
                        edcliente.Text = Srelib.QStr0(IDCliente.Trim(), 5) + " - " + uContato.PegaNomeID(IDCliente);
                        Label8.Visible = true;
                        edcliente.Visible = true;
                        if (IDCliente.Trim() == "1")
                        {
                            btprocessa.Enabled = false;
                        }
                        else
                        {
                            btprocessa.Enabled = true;
                        }
                        //
                        uVendas.MontaComboRenegociacoes(cbrenegociacoes,
                                                        " WHERE PRODUTO = " + Srelib.QStr(cbproduto.Value.ToString()) +
                                                        " AND GRUPO = " + Srelib.QStr(cbgrupo.Value.ToString()) +
                                                        " AND UNIDADE = " + Srelib.QStr(cbgrupounidades.Value.ToString()) +
                                                        " AND PARTE = " + Srelib.QStr(parte));

                        cbrenegociacoes.Text = "";
                        //
                        if (cbrenegociacoes.Items.Count > 0)
                        {
                            Label42.Visible = true;
                            cbrenegociacoes.Visible = true;
                            btprocessa.Enabled = true;
                        }
                        else
                        {
                            btprocessa.Enabled = false;
                            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Não há Renegociações para este Financiamento!');", true);
                            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                            "toastr.info('Não há Renegociações para este Financiamento!', 'Atenção!')", true);
                        }
                    }
                }
            }
        }

    }

    private void AtualizaGrid()
    {
        // 
        //dsparcelas.Clear();
        string grupounidades = cbgrupounidades.Text;
        string parte = grupounidades.Substring(grupounidades.IndexOf("-") + 1).Trim();
        //
        dsparcelas = uParcelas.PegaDadosParcelasRenegociacao(cbproduto.Value.ToString().Trim(),
                                                             cbgrupo.Value.ToString().Trim(),
                                                             cbgrupounidades.Value.ToString().Trim(),
                                                             parte,
                                                             (rbmeiolote.SelectedIndex + 1).ToString(),
                                                             "01/01/1900",
                                                             "31/12/2999",
                                                             "T",
                                                             "0",
                                                             "N",
                                                             false);
        //
        //
        GridListagem.DataSource = dsparcelas;
        GridListagem.KeyFieldName = "ID";
        GridListagem.DataBind();
        //btprocessa.Enabled = false;
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
        string ID = "";
        Boolean lOk = true;
        if (lOk)
        {
            //Renegociações
            if (cbrenegociacoes.Text != String.Empty)
            {
                ID = cbrenegociacoes.Text.Substring(3, 7);
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione uma Renegociação para esta Unidade!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Selecione uma Renegociação para esta Unidade!', 'Atenção!')", true);
            }
        }
        if (lOk)
        {
            if (cbproduto.Text != string.Empty)
            {
                if (cbgrupo.Text != string.Empty)
                {
                    if (cbgrupounidades.Text != string.Empty)
                    {
                        //
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
                        //Cliente
                        string IDCliente = uUnidade.PegaIDCliente(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte, (rbmeiolote.SelectedIndex + 1).ToString());
                        edcliente.Text = Srelib.QStr0(IDCliente.Trim(), 5) + " - " + uContato.PegaNomeID(IDCliente);
                        Label8.Visible = true;
                        edcliente.Visible = true;
                        //
                        dsvenda = uVendas.PegaDadosRenegociacaoID(ID);
                        //
                        if (dsvenda.Tables[0].Rows.Count != 0)
                        {
                            dtvenda.Value = Convert.ToDateTime(dsvenda.Tables[0].Rows[0]["data_venda"].ToString().Substring(0, 10));
                            dtbase.Value = Convert.ToDateTime(dsvenda.Tables[0].Rows[0]["primeiro_vencimento"].ToString().Substring(0, 10));
                            //
                            cbindexador.Items.Clear();
                            cbindexador.Text = dsvenda.Tables[0].Rows[0]["indexador"].ToString();
                            if (cbindexador.Text.Trim() == string.Empty)
                            {
                                cbindexador.Text = "SEM REGISTRO";
                            }
                            //
                            cbcorretor.Items.Clear();
                            //cbcorretor.Text = uCorretor.PegaApelidoCorretor(Convert.ToInt32(dsvenda.Tables[0].Rows[0]["corretor"]));
                            cbcorretor.Text = "RENEGOCIAÇÃO";
                            //
                            edvlrvenda.Text = dsvenda.Tables[0].Rows[0]["vlr_venda"].ToString();
                            edvlrsinal.Text = dsvenda.Tables[0].Rows[0]["vlr_sinal"].ToString();
                            edqtdsinal.Text = dsvenda.Tables[0].Rows[0]["num_parcelas_sinal"].ToString();
                            if (edvlrsinal.Text != "0,00")
                            {
                                cksinalparcelado.Checked = true;
                                Label32.Visible = true;
                                edqtdsinal.Visible = true;
                            }
                            else
                            {
                                cksinalparcelado.Checked = false;
                                Label32.Visible = false;
                                edqtdsinal.Visible = false;
                            }
                            edvlrsaldo1.Text = Convert.ToString(Convert.ToDecimal(dsvenda.Tables[0].Rows[0]["vlr_venda"]) - Convert.ToDecimal(dsvenda.Tables[0].Rows[0]["vlr_sinal"]));
                            edvlrintermediarias.Text = dsvenda.Tables[0].Rows[0]["vlr_intermediaria"].ToString();
                            edqtdintermediarias.Text = dsvenda.Tables[0].Rows[0]["num_parcelas_intermediarias"].ToString();
                            if (edvlrintermediarias.Text != "0,00")
                            {
                                Label19.Visible = true;
                                edqtdintermediarias.Visible = true;
                            }
                            else
                            {
                                Label19.Visible = false;
                                edqtdintermediarias.Visible = false;
                            }
                            edvlrfluxoparcelas.Text = dsvenda.Tables[0].Rows[0]["vlr_parcela_fluxo"].ToString();
                            edqtdfluxoparcelas.Text = dsvenda.Tables[0].Rows[0]["num_parcelas_fluxo"].ToString();
                            if (edvlrfluxoparcelas.Text != "0,00")
                            {
                                Label17.Visible = true;
                                edqtdfluxoparcelas.Visible = true;
                            }
                            else
                            {
                                Label17.Visible = false;
                                edqtdfluxoparcelas.Visible = false;
                            }
                            if (dsvenda.Tables[0].Rows[0]["periodicidade_correcao"].ToString().Trim() == "DIÁRIO")
                            {
                                rbperiodicidade.SelectedIndex = 0;
                            }
                            if (dsvenda.Tables[0].Rows[0]["periodicidade_correcao"].ToString().Trim() == "MENSAL")
                            {
                                rbperiodicidade.SelectedIndex = 1;
                            }
                            if (dsvenda.Tables[0].Rows[0]["periodicidade_correcao"].ToString().Trim() == "ANUAL")
                            {
                                rbperiodicidade.SelectedIndex = 2;
                            }
                            edmulta.Text = dsvenda.Tables[0].Rows[0]["multa"].ToString();
                            edcomissao.Text = dsvenda.Tables[0].Rows[0]["comissao"].ToString();
                            if (dsvenda.Tables[0].Rows[0]["periodicidade_comissao"].ToString().Trim() == "DIÁRIO")
                            {
                                rbperiodicidadecomissao.SelectedIndex = 0;
                            }
                            if (dsvenda.Tables[0].Rows[0]["periodicidade_comissao"].ToString().Trim() == "MENSAL")
                            {
                                rbperiodicidadecomissao.SelectedIndex = 1;
                            }
                            if (dsvenda.Tables[0].Rows[0]["periodicidade_comissao"].ToString().Trim() == "ANUAL")
                            {
                                rbperiodicidadecomissao.SelectedIndex = 2;
                            }
                            edobservacao.Text = dsvenda.Tables[0].Rows[0]["observacao"].ToString();
                            //
                            dtvenda.ReadOnly = true;
                            dtbase.ReadOnly = true;
                            cbindexador.ReadOnly = true;
                            cbcorretor.ReadOnly = true;
                            edvlrvenda.ReadOnly = true;
                            edvlrsinal.ReadOnly = true;
                            cksinalparcelado.ReadOnly = true;
                            edvlrsaldo1.ReadOnly = true;
                            edvlrintermediarias.ReadOnly = true;
                            edqtdintermediarias.ReadOnly = true;
                            edvlrfluxoparcelas.ReadOnly = true;
                            edqtdfluxoparcelas.ReadOnly = true;
                            cbindexador.ReadOnly = true;
                            rbperiodicidade.Enabled = false;
                            cbcorretor.ReadOnly = true;
                            edmulta.ReadOnly = true;
                            edcomissao.ReadOnly = true;
                            rbperiodicidadecomissao.Enabled = false;
                            edobservacao.ReadOnly = true;
                            //
                            Label4.Visible = true;
                            dtvenda.Visible = true;
                            Label5.Visible = true;
                            edvlrvenda.Visible = true;
                            Label9.Visible = true;
                            edvlrsinal.Visible = true;
                            cksinalparcelado.Visible = true;
                            Label10.Visible = true;
                            edvlrsaldo1.Visible = true;
                            Label11.Visible = true;
                            edvlrintermediarias.Visible = true;
                            Label19.Visible = true;
                            edqtdintermediarias.Visible = true;
                            Label18.Visible = true;
                            edvlrfluxoparcelas.Visible = true;
                            Label17.Visible = true;
                            edqtdfluxoparcelas.Visible = true;
                            Label12.Visible = true;
                            cbindexador.Visible = true;
                            Label13.Visible = true;
                            rbperiodicidade.Visible = true;
                            Label14.Visible = true;
                            cbcorretor.Visible = true;
                            Label15.Visible = true;
                            edmulta.Visible = true;
                            Label16.Visible = true;
                            edcomissao.Visible = true;
                            rbperiodicidadecomissao.Visible = true;
                            Label41.Visible = true;
                            dtbase.Visible = true;
                            Label6.Visible = true;
                            edobservacao.Visible = true;
                            //
                            AtualizaGrid();
                            GridListagem.Visible = true;
                        }
                        else
                        {
                            //
                            Label4.Visible = false;
                            dtvenda.Visible = false;
                            Label5.Visible = false;
                            edvlrvenda.Visible = false;
                            Label9.Visible = false;
                            edvlrsinal.Visible = false;
                            cksinalparcelado.Visible = false;
                            Label10.Visible = false;
                            edvlrsaldo1.Visible = false;
                            Label11.Visible = false;
                            edvlrintermediarias.Visible = false;
                            Label19.Visible = false;
                            edqtdintermediarias.Visible = false;
                            Label18.Visible = false;
                            edvlrfluxoparcelas.Visible = false;
                            Label17.Visible = false;
                            edqtdfluxoparcelas.Visible = false;
                            Label12.Visible = false;
                            cbindexador.Visible = false;
                            Label13.Visible = false;
                            rbperiodicidade.Visible = false;
                            Label14.Visible = false;
                            cbcorretor.Visible = false;
                            Label15.Visible = false;
                            edmulta.Visible = false;
                            Label16.Visible = false;
                            edcomissao.Visible = false;
                            rbperiodicidadecomissao.Visible = false;
                            Label41.Visible = true;
                            dtbase.Visible = false;
                            Label6.Visible = false;
                            edobservacao.Visible = false;
                            //
                            GridListagem.Visible = false;
                            //
                            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não Há Renegociação neste Unidade!');", true);
                            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                            "toastr.info('Não Há Renegociação neste Unidade!', 'Atenção!')", true);
                        }
                    }
                    else
                    {
                        //
                        Label4.Visible = false;
                        dtvenda.Visible = false;
                        Label5.Visible = false;
                        edvlrvenda.Visible = false;
                        Label9.Visible = false;
                        edvlrsinal.Visible = false;
                        cksinalparcelado.Visible = false;
                        Label10.Visible = false;
                        edvlrsaldo1.Visible = false;
                        Label11.Visible = false;
                        edvlrintermediarias.Visible = false;
                        Label19.Visible = false;
                        edqtdintermediarias.Visible = false;
                        Label18.Visible = false;
                        edvlrfluxoparcelas.Visible = false;
                        Label17.Visible = false;
                        edqtdfluxoparcelas.Visible = false;
                        Label12.Visible = false;
                        cbindexador.Visible = false;
                        Label13.Visible = false;
                        rbperiodicidade.Visible = false;
                        Label14.Visible = false;
                        cbcorretor.Visible = false;
                        Label15.Visible = false;
                        edmulta.Visible = false;
                        Label16.Visible = false;
                        edcomissao.Visible = false;
                        rbperiodicidadecomissao.Visible = false;
                        Label41.Visible = true;
                        dtbase.Visible = false;
                        Label6.Visible = false;
                        edobservacao.Visible = false;
                        //
                        GridListagem.Visible = false;
                    }
                }
            }
        }
    }


    protected void GridListagem_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
    {
        //Código Original
        //ASPxGridView gridView = (ASPxGridView)sender;

        ////
        //string apelido = "";
        //string nome = "";
        //string cnpj = "";
        //string inscmunicipal = "";
        //string inscestadual = "";
        //string regjuntacom = "";
        //string nire = "";
        //string enderecocom = "";
        //string enderecocomnumero = "";
        //string enderecocomcomplem = "";
        //string bairrocom = "";
        //string cidadecom = "";
        //string ufcom = "";
        //string cepcom = "";
        //string fone1com = "";
        //string fone2com = "";
        //string fone3com = "";
        //string email1 = "";
        //string email2 = "";
        //string email3 = "";
        //string email4 = "";
        //string email5 = "";
        //string gerente = "";
        //string contato = "";
        //DateTime dtnascimento = Convert.ToDateTime("01/01/1900");
        //DateTime dtingresso = Convert.ToDateTime("01/01/1900");
        //string ncontrato = "";
        //DateTime dtcontrato = Convert.ToDateTime("01/01/1900");
        //Boolean ativo = true;
        //Boolean acessointernet = true;
        //string obs1 = "";
        //string obs2 = "";
        //string obs3 = "";
        //string obs4 = "";
        //string obs5 = "";
        //string instrcob1 = "";
        //string instrcob2 = "";
        //string diasprotesto = "";
        //string conta1 = "";
        //string conta2 = "";
        //string conta3 = "";
        //string conta4 = "";
        //string conta5 = "";
        ////
        //// Empresa
        //apelido = e.NewValues["apelido"].ToString().ToUpper();
        //nome = e.NewValues["nome"].ToString().ToUpper();
        //cnpj = e.NewValues["cnpj"].ToString();
        //if (e.NewValues["inscmunicipal"] != null)
        //    inscmunicipal = e.NewValues["inscmunicipal"].ToString();
        //if (e.NewValues["inscestadual"] != null)
        //    inscestadual = e.NewValues["inscestadual"].ToString();
        //if (e.NewValues["regjuntacom"] != null)
        //    regjuntacom = e.NewValues["regjuntacom"].ToString();
        //if (e.NewValues["nire"] != null)
        //    nire = e.NewValues["nire"].ToString();
        //if (e.NewValues["enderecocom"] != null)
        //    enderecocom = e.NewValues["enderecocom"].ToString();
        //if (e.NewValues["enderecocomnumero"] != null)
        //    enderecocomnumero = e.NewValues["enderecocomnumero"].ToString();
        //if (e.NewValues["enderecocomcomplem"] != null)
        //    enderecocomcomplem = e.NewValues["enderecocomcomplem"].ToString();
        //if (e.NewValues["bairrocom"] != null)
        //    bairrocom = e.NewValues["bairrocom"].ToString();
        //if (e.NewValues["cidadecom"] != null)
        //    cidadecom = e.NewValues["cidadecom"].ToString();
        //if (e.NewValues["ufcom"] != null)
        //    ufcom = e.NewValues["ufcom"].ToString();
        //if (e.NewValues["cepcom"] != null)
        //    cepcom = e.NewValues["cepcom"].ToString();
        //if (e.NewValues["fone1com"] != null)
        //    fone1com = e.NewValues["fone1com"].ToString();
        //if (e.NewValues["fone2com"] != null)
        //    fone2com = e.NewValues["fone2com"].ToString();
        //if (e.NewValues["fone3com"] != null)
        //    fone3com = e.NewValues["fone3com"].ToString();
        //if (e.NewValues["email1"] != null)
        //    email1 = e.NewValues["email1"].ToString();
        //if (e.NewValues["email2"] != null)
        //    email2 = e.NewValues["email2"].ToString();
        //if (e.NewValues["email3"] != null)
        //    email3 = e.NewValues["email3"].ToString();
        //if (e.NewValues["email4"] != null)
        //    email4 = e.NewValues["email4"].ToString();
        //if (e.NewValues["email5"] != null)
        //    email5 = e.NewValues["email5"].ToString();
        //if (e.NewValues["gerente"] != null)
        //    gerente = e.NewValues["gerente"].ToString();
        //if (e.NewValues["contato"] != null)
        //    contato = e.NewValues["contato"].ToString();
        //if (e.NewValues["dtnascimento"] != null)
        //    dtnascimento = Convert.ToDateTime(e.NewValues["dtnascimento"].ToString());
        //if (e.NewValues["dtingresso"] != null)
        //    dtingresso = Convert.ToDateTime(e.NewValues["dtingresso"].ToString());
        //if (e.NewValues["ncontrato"] != null)
        //    ncontrato = e.NewValues["ncontrato"].ToString();
        //if (e.NewValues["dtcontrato"] != null)
        //    dtcontrato = Convert.ToDateTime(e.NewValues["dtcontrato"].ToString());
        //if (e.NewValues["ativo"] != null)
        //    ativo = Convert.ToBoolean(e.NewValues["ativo"].ToString());
        //if (e.NewValues["acessointernet"] != null)
        //    acessointernet = Convert.ToBoolean(e.NewValues["acessointernet"].ToString());
        //if (e.NewValues["obs1"] != null)
        //    obs1 = e.NewValues["obs1"].ToString();
        //if (e.NewValues["obs2"] != null)
        //    obs2 = e.NewValues["obs2"].ToString();
        //if (e.NewValues["obs3"] != null)
        //    obs3 = e.NewValues["obs3"].ToString();
        //if (e.NewValues["obs4"] != null)
        //    obs4 = e.NewValues["obs4"].ToString();
        //if (e.NewValues["obs5"] != null)
        //    obs5 = e.NewValues["obs5"].ToString();
        //if (e.NewValues["instrcob1"] != null)
        //    instrcob1 = e.NewValues["instrcob1"].ToString();
        //if (e.NewValues["instrcob2"] != null)
        //    instrcob2 = e.NewValues["instrcob2"].ToString();
        //if (e.NewValues["diasprotesto"] != null)
        //    diasprotesto = e.NewValues["diasprotesto"].ToString();
        //if (e.NewValues["conta1"] != null)
        //    conta1 = e.NewValues["conta1"].ToString();
        //if (e.NewValues["conta2"] != null)
        //    conta2 = e.NewValues["conta2"].ToString();
        //if (e.NewValues["conta3"] != null)
        //    conta3 = e.NewValues["conta3"].ToString();
        //if (e.NewValues["conta4"] != null)
        //    conta4 = e.NewValues["conta4"].ToString();
        //if (e.NewValues["conta5"] != null)
        //    conta5 = e.NewValues["conta5"].ToString();

        //uEmpresa.Grava(apelido,
        //               nome,
        //               cnpj,
        //               inscmunicipal,
        //               inscestadual,
        //               regjuntacom,
        //               nire,
        //               enderecocom,
        //               enderecocomnumero,
        //               enderecocomcomplem,
        //               bairrocom,
        //               cidadecom,
        //               ufcom,
        //               cepcom,
        //               fone1com,
        //               fone2com,
        //               fone3com,
        //               email1,
        //               email2,
        //               email3,
        //               email4,
        //               email5,
        //               gerente,
        //               contato,
        //               dtnascimento,
        //               dtingresso,
        //               ncontrato,
        //               dtcontrato,
        //               ativo,
        //               acessointernet,
        //               obs1,
        //               obs2,
        //               obs3,
        //               obs4,
        //               obs5,
        //               instrcob1,
        //               instrcob2,
        //               diasprotesto,
        //               conta1,
        //               conta2,
        //               conta3,
        //               conta4,
        //               conta5);

        ////Código Original
        //gridView.CancelEdit();
        //e.Cancel = true;

        ////Usando Classe uLog.MakeLog - Gravando Log
        //fwObs_Log = "INCLUI EMPRESA: " + "NOVO" + "/" + e.NewValues["apelido"].ToString().ToUpper();
        //SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
        //                             new SqlParameter("@tabela"   , fWtabela                     ),
        //                             new SqlParameter("@operacao" , "EMPRESA"                    ),
        //                             new SqlParameter("@obs"      , "INCLUI"                     ),
        //                             new SqlParameter("@acao"     , fwObs_Log                    ) };
        //uLog.MakeLog(param_log);
        //
        AtualizaGrid();

    }
    protected void GridListagem_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;
        //
        string ID = "";
        string produto = "";
        string grupo = "";
        string unidade = "";
        string parte = "";
        string parcela = "";
        string tipo = "";
        DateTime data_vencimento = Convert.ToDateTime("01/01/1900");
        decimal vlr_parcela = 0;
        DateTime data_pagamento = Convert.ToDateTime("01/01/1900");
        decimal vlr_pagamento = 0;
        DateTime data_original = Convert.ToDateTime("01/01/1900");
        decimal vlr_original = 0;
        DateTime data_base = Convert.ToDateTime("01/01/1900");
        decimal vlr_base = 0;
        string nossonumero = "";
        string origem_pagamento = "";
        Boolean ativa = false;
        decimal percentual_correcao = 0;
        Boolean carteira = false;
        Boolean protesto = false;
        Boolean contabil = false;
        decimal tx_multa = 0;
        decimal tx_comissao = 0;
        decimal vlr_multa = 0;
        decimal vlr_comissao = 0;
        decimal vlr_desconto = 0;
        string periodicidade_comissao = "";
        DateTime data_conta = Convert.ToDateTime("01/01/1900");
        string conta = "";
        string indexador = "";
        decimal indexador_mes = 0;
        decimal indexador_acumulado = 0;
        decimal residuo_mes = 0;
        decimal residuo_acumulado = 0;
        decimal vlr_correcao = 0;
        string observacao = "";      
        //
        // 
        ID = e.NewValues["ID"].ToString().Trim();
        produto = e.NewValues["produto"].ToString().Trim();
        grupo = e.NewValues["grupo"].ToString().Trim();
        unidade = e.NewValues["unidade"].ToString().Trim();
        parte = e.NewValues["parte"].ToString().Trim();
        parcela = e.NewValues["parcela"].ToString().Trim();
        tipo = e.NewValues["tipo"].ToString().Trim();

        if (e.NewValues["data_vencimento"].ToString() != "")
        {
            data_vencimento = Convert.ToDateTime(e.NewValues["data_vencimento"]);
        }
        if (e.NewValues["vlr_parcela"].ToString() != "")
        {
            vlr_parcela = Convert.ToDecimal(e.NewValues["vlr_parcela"]);
        }

        if (e.NewValues["data_pagamento"].ToString() != "")
        {
            data_pagamento = Convert.ToDateTime(e.NewValues["data_pagamento"]);
        }

        if (e.NewValues["vlr_pagamento"].ToString() != "")
        {
            vlr_pagamento = Convert.ToDecimal(e.NewValues["vlr_pagamento"]);
        }

        if (e.NewValues["vlr_original"].ToString() != "")
        {
            vlr_original = Convert.ToDecimal(e.NewValues["vlr_original"]);
        }

        if (e.NewValues["vlr_base"].ToString() != "")
        {
            vlr_base = Convert.ToDecimal(e.NewValues["vlr_base"]);
        }

        if (e.NewValues["nossonumero"] != null)
        {
            nossonumero = e.NewValues["nossonumero"].ToString().Trim();
        }

        if (e.NewValues["origem_pagamento"] != null)
        {
            origem_pagamento = e.NewValues["origem_pagamento"].ToString().Trim();
        }

        //
        ativa = Convert.ToBoolean(e.NewValues["ativa"]);
        //
        if (e.NewValues["percentual_correcao"].ToString() != "")
        {
            percentual_correcao = Convert.ToDecimal(e.NewValues["percentual_correcao"]);
        }
        carteira = Convert.ToBoolean(e.NewValues["carteira"]);
        protesto = Convert.ToBoolean(e.NewValues["protesto"]);
        contabil = Convert.ToBoolean(e.NewValues["contabil"]);
        //
        if (e.NewValues["tx_multa"].ToString() != "")
        {
            tx_multa = Convert.ToDecimal(e.NewValues["tx_multa"]);
        }
        //
        if (e.NewValues["tx_comissao"].ToString() != "")
        {
            tx_comissao = Convert.ToDecimal(e.NewValues["tx_comissao"]);
        }
        //
        if (e.NewValues["vlr_comissao"].ToString() != "")
        {
            vlr_comissao = Convert.ToDecimal(e.NewValues["vlr_comissao"]);
        }
        //
        if (e.NewValues["vlr_multa"].ToString() != "")
        {
            vlr_multa = Convert.ToDecimal(e.NewValues["vlr_multa"]);
        }
        //
        if (e.NewValues["vlr_desconto"].ToString() != "")
        {
            vlr_desconto = Convert.ToDecimal(e.NewValues["vlr_desconto"]);
        }
        
        if (Convert.ToDouble(vlr_pagamento) != Convert.ToDouble(vlr_parcela))
        {
            if (Convert.ToDouble(vlr_pagamento) != 0.00)
            {
                if ((Convert.ToDouble(vlr_pagamento) > 0.00) &&
                (Convert.ToDouble(vlr_pagamento) > Convert.ToDouble(vlr_parcela)))
                {
                    vlr_multa = Convert.ToDecimal((Convert.ToDouble(vlr_pagamento) - Convert.ToDouble(vlr_parcela)));
                }
                else
                {
                    vlr_desconto = Convert.ToDecimal((Convert.ToDouble(vlr_parcela) - Convert.ToDouble(vlr_pagamento)));
                }
            }
        }
        //
        if (e.NewValues["periodicidade_comissao"] != null)
        {
            periodicidade_comissao = e.NewValues["periodicidade_comissao"].ToString().Trim();
        }
        if (e.NewValues["data_conta"].ToString() != "")
        {
            data_conta = Convert.ToDateTime(e.NewValues["data_conta"]);
        }
        if (e.NewValues["conta"] != null)
        {
            conta = e.NewValues["conta"].ToString().Trim();
        }
        if (e.NewValues["indexador"] != null)
        {
            indexador = e.NewValues["indexador"].ToString().Trim().ToUpper();
        }
        if (e.NewValues["indexador_mes"] != null)
        {
            indexador_mes = Convert.ToDecimal(e.NewValues["indexador_mes"]);
        }
        if (e.NewValues["indexador_acumulado"] != null)
        {
            indexador_acumulado = Convert.ToDecimal(e.NewValues["indexador_acumulado"]);
        }
        if (e.NewValues["residuo_mes"] != null)
        {
            residuo_mes = Convert.ToDecimal(e.NewValues["residuo_mes"]);
        }
        if (e.NewValues["residuo_acumulado"] != null)
        {
            residuo_acumulado = Convert.ToDecimal(e.NewValues["residuo_acumulado"]);
        }
        if (e.NewValues["observacao"] != null)
        {
            observacao = e.NewValues["observacao"].ToString().Trim();
        }
        //
        uParcelas.Altera(ID,
                        produto,
                        grupo,
                        unidade,
                        parte,
                        parcela,
                        tipo,
                        Convert.ToString(data_vencimento).Substring(0, 10),
                        vlr_parcela,
                        Convert.ToString(data_pagamento).Substring(0, 10),
                        vlr_pagamento,
                        Convert.ToString(data_original).Substring(0, 10),
                        vlr_original,
                        Convert.ToString(data_base).Substring(0, 10),
                        vlr_base,
                        nossonumero,
                        origem_pagamento,
                        Convert.ToInt16(ativa),
                        percentual_correcao,
                        Convert.ToInt16(carteira),
                        Convert.ToInt16(protesto),
                        Convert.ToInt16(contabil),
                        tx_multa,
                        tx_comissao,
                        vlr_multa,
                        vlr_comissao,
                        vlr_desconto,
                        periodicidade_comissao,
                        Convert.ToString(data_conta).Substring(0, 10),
                        conta,
                        indexador,
                        indexador_mes,
                        indexador_acumulado,
                        residuo_mes,
                        residuo_acumulado,
                        vlr_correcao,
                        observacao);


        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "ALTERA PARCELA : " + produto + "/" + grupo + "/" + unidade + "/" + parte + "/Parcela/Tipo:" + parcela + "/" + tipo;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "VENDAS"                     ),
                                     new SqlParameter("@obs"      , "ALTERA PARCELA"             ),
                                     new SqlParameter("@acao"     , fwObs_Log                    ) };
        uLog.MakeLog(param_log);

        //
        AtualizaGrid();
    }

    protected void GridListagem_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
    {
        //ASPxGridView gridView = (ASPxGridView)sender;

        //uEmpresa.Exclui(e.Values["ID"].ToString());
        ////

        //gridView.CancelEdit();
        //e.Cancel = true;

        ////Usando Classe uLog.MakeLog - Gravando Log
        //fwObs_Log = "EXCLUI EMPRESA: " + e.Values["ID"].ToString() + "/" + e.Values["apelido"].ToString().ToUpper();
        //SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
        //                             new SqlParameter("@tabela"   , fWtabela                     ),
        //                             new SqlParameter("@operacao" , "EMPRESA"                    ),
        //                             new SqlParameter("@obs"      , "EXCLUI"                     ),
        //                             new SqlParameter("@acao"     , fwObs_Log                    ) };
        //uLog.MakeLog(param_log);
        //
        AtualizaGrid();

    }

    protected void GridListagem_CommandButtonInitialize(object sender, ASPxGridViewCommandButtonEventArgs e)
    {
        //Botão Edit
        if (e.ButtonType == DevExpress.Web.ASPxGridView.ColumnCommandButtonType.Edit)
            e.Visible = lAltera;

        //Botão Novo
        if (e.ButtonType == DevExpress.Web.ASPxGridView.ColumnCommandButtonType.New)
            e.Visible = lInsere;

        //Botão Altera
        if (e.ButtonType == DevExpress.Web.ASPxGridView.ColumnCommandButtonType.Update)
            e.Visible = lAltera;

        //Botão Exclui
        if (e.ButtonType == DevExpress.Web.ASPxGridView.ColumnCommandButtonType.Delete)
            e.Visible = lExclui;

    }
    protected void GridListagem_InitNewRow(object sender, DevExpress.Web.Data.ASPxDataInitNewRowEventArgs e)
    {
        //e.NewValues["dtnascimento"] = Convert.ToDateTime("01/01/1900");
        //e.NewValues["dtingresso"] = DateTime.Now;
        //e.NewValues["dtcontrato"] = Convert.ToDateTime("01/01/1900");
        //e.NewValues["ativo"] = true;
        //e.NewValues["acessointernet"] = true;
        //e.NewValues["gerente"] = "GERAL";
    }

    private void GetSelectedValues()
    {
        if (selectedValues != null)
            selectedValues.Clear();

        List<string> fieldNames = new List<string>();
        foreach (GridViewColumn column in GridListagem.Columns)
            if (column is GridViewDataColumn)
                fieldNames.Add(((GridViewDataColumn)column).FieldName);
        selectedValues = GridListagem.GetSelectedFieldValues(fieldNames.ToArray());
    }

    protected void edvlrvenda_TextChanged(object sender, EventArgs e)
    {
        edvlrsaldo1.Text = Convert.ToString(Convert.ToDecimal(edvlrvenda.Text) - Convert.ToDecimal(edvlrsinal.Text));
        edvlrfluxoparcelas.Text = Convert.ToString(Convert.ToDecimal(edvlrvenda.Text) -
                                                   Convert.ToDecimal(edvlrsinal.Text) -
                                                   Convert.ToDecimal(edvlrintermediarias.Text));
        //edvlrsinal.Focus();
    }

    protected void edvlrsinal_TextChanged(object sender, EventArgs e)
    {
        edvlrsaldo1.Text = Convert.ToString(Convert.ToDecimal(edvlrvenda.Text) - Convert.ToDecimal(edvlrsinal.Text));
        edvlrfluxoparcelas.Text = Convert.ToString(Convert.ToDecimal(edvlrvenda.Text) -
                                                   Convert.ToDecimal(edvlrsinal.Text) -
                                                   Convert.ToDecimal(edvlrintermediarias.Text));
        if ((edvlrsinal.Text != "0,00") && (edvlrsinal.Text != ""))
        {
            cksinalparcelado.Visible = true;
            //cksinalparcelado.Focus();
        }
        else
        {
            cksinalparcelado.Visible = false;
            //edvlrsinal.Focus();
        }
    }

    protected void edvlrintermediarias_TextChanged(object sender, EventArgs e)
    {
        edvlrsaldo1.Text = Convert.ToString(Convert.ToDecimal(edvlrvenda.Text) - Convert.ToDecimal(edvlrsinal.Text));
        edvlrfluxoparcelas.Text = Convert.ToString(Convert.ToDecimal(edvlrvenda.Text) -
                                                   Convert.ToDecimal(edvlrsinal.Text) -
                                                   Convert.ToDecimal(edvlrintermediarias.Text));
        if ((edvlrintermediarias.Text != "0,00") && (edvlrintermediarias.Text != ""))
        {
            Label19.Visible = true;
            edqtdintermediarias.Visible = true;
            //edqtdintermediarias.Focus();
        }
        else
        {
            Label19.Visible = false;
            edqtdintermediarias.Visible = false;
            //edvlrfluxoparcelas.Focus();
        }
    }

    protected void edvlrfluxoparcelas_TextChanged(object sender, EventArgs e)
    {
        if ((edvlrfluxoparcelas.Text != "0,00") && (edvlrfluxoparcelas.Text != ""))
        {
            Label17.Visible = true;
            edqtdfluxoparcelas.Visible = true;
            //edqtdfluxoparcelas.Focus();
        }
        else
        {
            Label17.Visible = false;
            edqtdfluxoparcelas.Visible = false;
            //cbindexador.Focus();
        }
    }

    protected void edqtdfluxoparcelas_TextChanged(object sender, EventArgs e)
    {
        //cbindexador.Focus();
        if ((edqtdfluxoparcelas.Text != "0") && (edqtdfluxoparcelas.Text != ""))
        {
            Divfluxos.Style[HtmlTextWriterStyle.Visibility] = "visible";
            Label35.Text = "1/" + edqtdfluxoparcelas.Text.Trim();
            edqtdfluxoparcelas.ReadOnly = true;
            //
            Label34.Visible = true;
            Label35.Visible = true;
            Label36.Visible = true;
            eddtinicialfluxo.Visible = true;
            Label37.Visible = true;
            edvlrparcelafluxo.Visible = true;
            Label40.Visible = true;
            edqtdparcelafluxo.Visible = true;
            Label38.Visible = true;
            edvlrparcelafluxototal.Visible = true;
            btgravafluxo.Visible = true;
            //
            eddtinicialfluxo.Value = DateTime.Now;
            edvlrparcelafluxo.Text = "0,00";
            edvlrparcelafluxototal.Text = "0,00";
            //
            eddtinicialfluxo.Focus();
        }
        else
        {
            Divfluxos.Style[HtmlTextWriterStyle.Visibility] = "hidden";
            Label35.Text = "9999/9999";
            //
            Label34.Visible = false;
            Label35.Visible = false;
            Label36.Visible = false;
            eddtinicialfluxo.Visible = false;
            Label37.Visible = false;
            edvlrparcelafluxo.Visible = false;
            Label40.Visible = false;
            edqtdparcelafluxo.Visible = false;
            Label38.Visible = false;
            edvlrparcelafluxototal.Visible = false;
            btgravafluxo.Visible = false;
            //
            edqtdfluxoparcelas.ReadOnly = false;
            edqtdfluxoparcelas.Focus();
        }
    }

    protected void cbindexador_SelectedIndexChanged(object sender, EventArgs e)
    {
        //rbperiodicidade.Focus();
    }

    protected void rbperiodicidade_SelectedIndexChanged(object sender, EventArgs e)
    {
        //cbcorretor.Focus();
    }

    protected void cbcorretor_SelectedIndexChanged(object sender, EventArgs e)
    {
        //edmulta.Focus();
    }


    protected void edmulta_TextChanged(object sender, EventArgs e)
    {
        //edcomissao.Focus();
    }


    protected void edcomissao_TextChanged(object sender, EventArgs e)
    {
        //rbperiodicidadecomissao.Focus();
    }

    protected void edqtdintermediarias_TextChanged(object sender, EventArgs e)
    {
        //edqtdfluxoparcelas.Focus();
        if ((edqtdintermediarias.Text != "0") && (edqtdintermediarias.Text != ""))
        {
            Divintermediaria.Style[HtmlTextWriterStyle.Visibility] = "visible";

            Label28.Text = "1/" + edqtdintermediarias.Text.Trim();
            edqtdintermediarias.ReadOnly = true;
            //
            Label27.Visible = true;
            Label28.Visible = true;
            Label29.Visible = true;
            eddtparcelaintermediaria.Visible = true;
            Label30.Visible = true;
            edvlrparcelaintermediaria.Visible = true;
            Label39.Visible = true;
            edobsintermediaria.Visible = true;
            Label31.Visible = true;
            edvlrparcelaintermediariatotal.Visible = true;
            btgravaintermediaria.Visible = true;
            //
            edobservacao.Text = "";
            eddtparcelaintermediaria.Value = DateTime.Now;
            edvlrparcelaintermediaria.Text = "0,00";
            edvlrparcelaintermediariatotal.Text = "0,00";
            //
            eddtparcelaintermediaria.Focus();
            //
        }
        else
        {
            Divintermediaria.Style[HtmlTextWriterStyle.Visibility] = "hidden";
            //
            Label27.Visible = false;
            Label28.Visible = false;
            Label29.Visible = false;
            eddtparcelaintermediaria.Visible = false;
            Label30.Visible = false;
            edvlrparcelaintermediaria.Visible = false;
            Label39.Visible = false;
            edobsintermediaria.Visible = false;
            Label31.Visible = false;
            edvlrparcelaintermediariatotal.Visible = false;
            btgravaintermediaria.Visible = false;
            //
            Label28.Text = "9999/9999";
            edqtdintermediarias.ReadOnly = false;
            edqtdintermediarias.Focus();
        }
    }
    protected void rbperiodicidadecomissao_SelectedIndexChanged(object sender, EventArgs e)
    {
        //edobservacao.Focus();
    }
    protected void edobservacao_TextChanged(object sender, EventArgs e)
    {
        //btprocessa.Focus();
    }
    protected void cksinalparcelado_CheckedChanged(object sender, EventArgs e)
    {
        //
        if (cksinalparcelado.Checked)
        {
            Divsinalparcelado.Style[HtmlTextWriterStyle.Visibility] = "visible";
            Label32.Visible = true;
            edqtdsinal.Visible = true;
            Label22.Visible = true;
            eddtparcelasinal.Visible = true;
            Label23.Visible = true;
            edvlrparcelasinal.Visible = true;
            Label24.Visible = true;
            edvlrparcelasinaltotal.Visible = true;
            Label25.Visible = true;
            btgravasinal.Visible = true;
            //
            edqtdsinal.Text = "0";
            eddtparcelasinal.Value = DateTime.Now;
            edvlrparcelasinal.Text = "0,00";
            edvlrparcelasinaltotal.Text = "0,00";
            //
            edqtdsinal.Focus();
        }
        else
        {
            Divsinalparcelado.Style[HtmlTextWriterStyle.Visibility] = "hidden";
            Label32.Visible = false;
            edqtdsinal.Visible = false;
            Label22.Visible = false;
            eddtparcelasinal.Visible = false;
            Label23.Visible = false;
            edvlrparcelasinal.Visible = false;
            Label24.Visible = false;
            edvlrparcelasinaltotal.Visible = false;
            Label25.Visible = false;
            btgravasinal.Visible = false;
        }
    }

    protected void edqtdsinal_TextChanged(object sender, EventArgs e)
    {
        if ((edqtdsinal.Text != "0") && (edqtdsinal.Text != ""))
        {
            Label25.Text = "1/" + edqtdsinal.Text.Trim();
            edqtdsinal.ReadOnly = true;
            eddtparcelasinal.Focus();
        }
        else
        {
            Label25.Text = "9999/9999";
            edqtdsinal.ReadOnly = false;
            edqtdsinal.Focus();
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
        if (IDCliente.Trim() == "1")
        {
            btprocessa.Enabled = false;
        }
        else
        {
            btprocessa.Enabled = true;
        }
    }

}

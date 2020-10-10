using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FAReceberLancamentos : System.Web.UI.Page
{
    DataSet dscpagar;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "CONTAS_PAGAR";

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = SreDblib.TemPermissao("001.007.001.000", (String)Session["CodUsuario"]);
        lAltera = false; //SreDblib.TemPermissao("001.007.002.000", (String)Session["CodUsuario"]);
        lExclui = false; //SreDblib.TemPermissao("001.007.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.007.004.000", (String)Session["CodUsuario"]);
        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        //
        btprocessa.Enabled = lInsere;
        if (!lInsere)
        {
            btprocessa.Image.ToolTip = Msg_acesso;
        }
        lInsere = false;
        //
        edparcelas.Text = "1";
        edparcelas_total.Text = "1";
        //
        //dtprevisao1.Date = new DateTime(1900, 1, 1);
        //dtrealizado1.Date = new DateTime(1900, 1, 1);
        //dtnotafiscal1.Date = new DateTime(1900, 1, 1);
        //dtcompensacao1.Date = new DateTime(1900, 1, 1);
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
            //Combo Grupo
            cbreceita.Items.Clear();
            uReceitas.MontaComboReceitas(cbreceita, "0", true);
            Label2.Visible = true;
            cbreceita.Visible = true;
            GridListagem.Visible = false;
            //
            //Combo Cliente
            if ((SreDblib.GetParametro("ORDEM CLIENTE") == "CODIGO") && (SreDblib.GetParametro("ORDEM CLIENTE") == "CÓDIGO"))
            {
                cbcliente.Items.Clear();
                uCliente.MontaComboClientes(cbcliente, "0", true);
                Label7.Visible = true;
                cbcliente.Visible = true;
            }
            else
            {
                if (SreDblib.GetParametro("FILTRO CLIENTE") == "SIM")
                {
                    Label7.Visible = true;
                    cbcliente_filtro.Visible = true;
                }
                else
                {
                    cbcliente.Items.Clear();
                    uCliente.MontaComboClientes(cbcliente, "0", true);
                    Label7.Visible = true;
                    cbcliente.Visible = true;
                }
            }
            //
            //Combo Contas Correntes
            cbcontascorrentes.Items.Clear();
            uContas.MontaComboContas(cbcontascorrentes, "0");
            Label16.Visible = true;
            cbcontascorrentes.Visible = true;
            //
            Label4.Visible = true;
            dtprevisao1.Visible = true;
            //
            Label6.Visible = true;
            dtrealizado1.Visible = true;
            //
            Label10.Visible = true;
            dtnotafiscal1.Visible = true;
            //
            if (edparcelas_total.Text != "1")
            {
                //
                dtprevisao1.Date = dtprevisao1.Date.AddMonths(1);
                dtrealizado1.Date = new DateTime(1900, 1, 1);
                dtnotafiscal1.Date = new DateTime(1900, 1, 1);
                dtcompensacao1.Date = new DateTime(1900, 1, 1);
            }
            else
            {
                //Direto no Componente
                //dtprevisao1.Date = new DateTime(1900, 1, 1);
                //dtrealizado1.Date = new DateTime(1900, 1, 1);
                //dtnotafiscal1.Date = new DateTime(1900, 1, 1);
                //dtcompensacao1.Date = new DateTime(1900, 1, 1);
            }
            //
            edlancamento.Text = uContasReceber.PegaNovoCodigoCReceber();
            //
            //edlancamento.Focus();

        }

    }

    private void AtualizaGrid(String situacaopgto, String ordenacao)
    {
        string cbproduto2 = "";
        string cbreceita2 = "";
        string cbcliente2 = "";
        string cbcontascorrentes2 = "";
        //
        if (cbproduto.Value != null)
        {
            cbproduto2 = cbproduto.Value.ToString().Trim();
        }
        if (cbreceita.Value != null)
        {
            cbreceita2 = cbreceita.Value.ToString().Trim();
        }
        //
        if ((SreDblib.GetParametro("ORDEM FORNECEDOR") == "CODIGO") && (SreDblib.GetParametro("ORDEM FORNECEDOR") == "CÓDIGO"))
        {
            if (cbcliente.Value != null)
            {
                cbcliente2 = cbcliente.Value.ToString().Trim();
            }
        }
        else
        {
            if (SreDblib.GetParametro("FILTRO FORNECEDOR") == "SIM")
            {
                if (cbcliente_filtro.Value != null)
                {
                    cbcliente2 = cbcliente_filtro.Value.ToString().Trim();
                }
            }
            else
            {
                if (cbcliente.Value != null)
                {
                    cbcliente2 = cbcliente.Value.ToString().Trim();
                }
            }
        }
        //
        if (cbcontascorrentes.Value != null)
        {
            cbcontascorrentes2 = cbcontascorrentes.Value.ToString().Trim();
        }
        // 
        decimal totvlrprevisto = 0;
        decimal totqtdprevisto = 0;
        decimal totvlrrealizado = 0;
        decimal totqtdrealizado = 0;
        for (int i = 0; i < dscpagar.Tables[0].Rows.Count; i++)
        {
            totvlrprevisto = totvlrprevisto + Convert.ToDecimal(dscpagar.Tables[0].Rows[i]["vlr_previsto"]);
            totqtdprevisto = totqtdprevisto + 1;
            totvlrrealizado = totvlrrealizado + Convert.ToDecimal(dscpagar.Tables[0].Rows[i]["vlr_realizado"]);
            totqtdrealizado = totqtdrealizado + 1;
        }

        edvlrtotalprevisto.Text = Convert.ToString(totvlrprevisto);
        edvlrtotalrealizado.Text = Convert.ToString(totvlrrealizado);

        GridListagem.DataSource = dscpagar;
        GridListagem.KeyFieldName = "ID";
        GridListagem.DataBind();
        //GridListagem.Focus();
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
        Boolean lOk = true;

        //Criticas
        if (lOk)
        {
            //lancamento
            if ((edlancamento.Text != string.Empty) && (edlancamento.Text != "0"))
            {
                if (SreDblib.TemNaTabela("select * from contas_receber WITH(NOLOCK) where lancamento = " + Srelib.QStr(edlancamento.Text.Trim())))
                {
                    lOk = false;
                    //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Número de Lançamento ja utilizado, favor gerar outro no botão Novo Código!');", true);
                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                        "toastr.error('Número de Lançamento ja utilizado, favor gerar outro no botão Novo Código!', 'Atenção!')", true);
                }
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Número de Lançamento em Branco!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.error('Número de Lançamento em Branco!', 'Atenção!')", true);
            }
            //Fim Check lancamento
        }
        //
        if (lOk)
        {
            //Check Produto
            if (cbproduto.Text != string.Empty)
            {
                //
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione um Produto!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.info('Selecione um Produto!', 'Atenção!')", true);
            }
            //Fim Check Produto
        }
        //
        if (lOk)
        {
            //Check Receita
            if (cbreceita.Text != string.Empty)
            {
                //
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione uma Receita!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.info('Selecione uma Receita!', 'Atenção!')", true);
            }
            //Fim Check Receita
        }
        //
        if (lOk)
        {
            //Check Cliente
            if ((SreDblib.GetParametro("ORDEM CLIENTE") == "CODIGO") && (SreDblib.GetParametro("ORDEM CLIENTE") == "CÓDIGO"))
            {
                if (cbcliente.Text == string.Empty)
                {
                    lOk = false;
                    //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione um Cliente!');", true);
                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                        "toastr.info('Selecione um Cliente!', 'Atenção!')", true);
                }
            }
            else
            {
                if (SreDblib.GetParametro("FILTRO CLIENTE") == "SIM")
                {
                    if (cbcliente_filtro.Text == string.Empty)
                    {
                        lOk = false;
                        //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Informe um Cliente!');", true);
                        ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                            "toastr.info('Selecione um Cliente!', 'Atenção!')", true);
                    }
                }
                else
                {
                    if (cbcliente.Text == string.Empty)
                    {
                        lOk = false;
                        //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione um Cliente!');", true);
                        ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                            "toastr.info('Selecione um Cliente!', 'Atenção!')", true);
                    }
                }
            }
            //Fim Check Cliente
        }
        //
        if (lOk)
        {
            //Check de Conta Corrente
            if (cbcontascorrentes.Text != string.Empty)
            {
                //
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione uma Conta!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.info('Selecione uma Conta!', 'Atenção!')", true);
            }
            //Fim Check de Conta Corrente
        }
        //
        if (lOk)
        {
            //Check Data Prevista
            if ((dtprevisao1.Date < Convert.ToDateTime("01/01/1900")))
            {
                lOk = false;
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.error('Data Prevista Inválida!', 'Atenção!')", true);
            }
            //Fim Check Data Prevista
        }
        //
        if (lOk)
        {
            //Check Data Documento
            if ((dtnotafiscal1.Date < Convert.ToDateTime("01/01/1900")))
            {
                lOk = false;
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.error('Data Documento Inválida!', 'Atenção!')", true);
            }
            //Fim Check Data Documento
        }
        //
        if (lOk)
        {
            //Check Data Realizado
            if ((dtrealizado1.Date < Convert.ToDateTime("01/01/1900")))
            {
                lOk = false;
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.error('Data Realizado Inválida!', 'Atenção!')", true);
            }
            //Fim Check Data Realizado
        }
        //
        if (lOk)
        {
            //Check Data Compensação
            if ((dtcompensacao1.Date < Convert.ToDateTime("01/01/1900")))
            {
                lOk = false;
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.error('Data Compensação Inválida!', 'Atenção!')", true);
            }
            //Fim Check Data Compensação
        }
        //
        //
        if (lOk)
        {
            //Check Valor Previsto
            if ((edvlrtotalprevisto.Text != string.Empty) || (edvlrtotalprevisto.Text != "0.00"))
            {
                //
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Valor Previsto Zerado ou Vazio!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.error('Valor Previsto Zerado ou Vazio!', 'Atenção!')", true);
            }
            //Fim Check Valor Previsto
        }
        //
        if (lOk)
        {
            //Check Valor Previsto
            if ((edvlrtotalprevisto.Text != string.Empty) || (edvlrtotalprevisto.Text != "0.00"))
            {
                //
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Valor Previsto Zerado ou Vazio!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.error('Valor Previsto Zerado ou Vazio!', 'Atenção!')", true);
            }
            //Fim Check Valor Previsto
        }
        //
        if (lOk)
        {
            //Processa 
            //
            string cliente = "";
            //
            if ((SreDblib.GetParametro("ORDEM CLIENTE") == "CODIGO") && (SreDblib.GetParametro("ORDEM CLIENTE") == "CÓDIGO"))
            {
                if (cbcliente.Value != null)
                {
                    cliente = cbcliente.Value.ToString().Trim();
                }
            }
            else
            {
                if (SreDblib.GetParametro("FILTRO CLIENTE") == "SIM")
                {
                    if (cbcliente_filtro.Value != null)
                    {
                        //fornecedor = cbfornecedor_filtro.Value.ToString().Trim();
                        cliente = cbcliente_filtro.Text.Substring(cbcliente_filtro.Text.IndexOf("(", 1) + 1,
                                                                  cbcliente_filtro.Text.IndexOf(")", 1) - 1 - cbcliente_filtro.Text.IndexOf("(", 1));
                    }
                }
                else
                {
                    if (cbcliente.Value != null)
                    {
                        cliente = cbcliente.Value.ToString().Trim();
                    }
                }
            }
            //
            try
            {
                uContasReceber.Grava(edlancamento.Text,
                                     cbproduto.Value.ToString(),
                                     cbreceita.Value.ToString(),
                                     cliente,
                                     eddescricao.Text,
                                     dtprevisao1.Date.ToString().Substring(0, 10),
                                     Convert.ToDecimal(edvlrtotalprevisto.Text),
                                     dtrealizado1.Date.ToString().Substring(0, 10),
                                     Convert.ToDecimal(edvlrtotalrealizado.Text),
                                     cbcontascorrentes.Value.ToString(),
                                     eddocumento.Text,
                                     dtnotafiscal1.Date.ToString().Substring(0, 10),
                                     edcheque.Text,
                                     edcheque.Text,
                                     dtcompensacao1.Date.ToString().Substring(0, 10),
                                     1,
                                     edcontabil.Text
                                     );
            }
            catch (Exception)
            {
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Erro na Inclusão, acione o Suporte!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.error('Erro na Inclusão, acione o Suporte!', 'Atenção!')", true);
            }



            //
            // CRIA LOG ===============================================================================================================================================
            fwObs_Log = "LANÇAMENTO CONTAS A RECEBER: " + edlancamento.Text;
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ),
                                         new SqlParameter("@tabela"   , fWtabela                              ),
                                         new SqlParameter("@operacao" , "CONTAS A RECEBER"                    ),
                                         new SqlParameter("@obs"      , "LANÇAMENTO CONTAS A RECEBER"         ),
                                         new SqlParameter("@acao"     , fwObs_Log                             ) };
            uLog.MakeLog(param_log);
            // FIM CRIA LOG ===============================================================================================================================================
            //
            //
            if (edparcelas_total.Text != "1")
            {
                btprocessa.Enabled = true;
                btnovocodigo.Enabled = false;
                btnovolancamento.Enabled = false;
                edparcelas.Text = Convert.ToString(Convert.ToInt64(edparcelas.Text) + 1);
                edlancamento.Text = uContasReceber.PegaNovoCodigoCReceber();
                if (Convert.ToInt64(edparcelas.Text) <= Convert.ToInt64(edparcelas_total.Text))
                {
                    //
                    dtprevisao1.Date = dtprevisao1.Date.AddMonths(1);
                    dtrealizado1.Date = new DateTime(1900, 1, 1);
                    dtnotafiscal1.Date = new DateTime(1900, 1, 1);
                    dtcompensacao1.Date = new DateTime(1900, 1, 1);
                    //
                    //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Lançamento Parcelado Registrado!');", true);
                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                        "toastr.success('Lançamento Parcelado Registrado!', 'Atenção!')", true);
                }
                else
                {
                    btprocessa.Enabled = false;
                    btnovocodigo.Enabled = false;
                    btnovolancamento.Enabled = false;
                    edparcelas.Text = Convert.ToString(Convert.ToInt64(edparcelas.Text) - 1);
                    //
                    //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Lançamento Parcelado Concluído!');", true);
                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                        "toastr.success('Lançamento Parcelado Concluído!', 'Atenção!')", true);
                }

            }
            else
            {
                btprocessa.Enabled = true;
                btnovocodigo.Enabled = true;
                btnovolancamento.Enabled = true;
                //
                dtprevisao1.Date = new DateTime(1900, 1, 1);
                dtrealizado1.Date = new DateTime(1900, 1, 1);
                dtnotafiscal1.Date = new DateTime(1900, 1, 1);
                dtcompensacao1.Date = new DateTime(1900, 1, 1);
                //
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Lançamento Registrado!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.success('Lançamento Registrado!', 'Atenção!')", true);
            }
            //
        }
    }



    protected void GridListagem_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
    {

    }
    protected void GridListagem_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
    {
        //
    }

    protected void GridListagem_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
    {
        //
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
        //
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

    protected void btnovocodigo_Click(object sender, EventArgs e)
    {
        //
        edlancamento.Text = uContasReceber.PegaNovoCodigoCReceber();
    }


    protected void btnovolancamento_Click(object sender, EventArgs e)
    {
        //
        //Combo Empresas
        cbproduto.Items.Clear();
        uProduto.MontaComboProduto(cbproduto, true);
        //
        //Combo Grupo
        cbreceita.Items.Clear();
        uReceitas.MontaComboReceitas(cbreceita, "0", true);
        Label2.Visible = true;
        cbreceita.Visible = true;
        GridListagem.Visible = false;
        //
        //Combo Cliente
        if ((SreDblib.GetParametro("ORDEM CLIENTE") == "CODIGO") && (SreDblib.GetParametro("ORDEM CLIENTE") == "CÓDIGO"))
        {
            cbcliente.Items.Clear();
            uCliente.MontaComboClientes(cbcliente, "0", true);
            Label7.Visible = true;
            cbcliente.Visible = true;
        }
        else
        {
            if (SreDblib.GetParametro("FILTRO CLIENTE") == "SIM")
            {
                Label7.Visible = true;
                cbcliente_filtro.Visible = true;
            }
            else
            {
                cbcliente.Items.Clear();
                uCliente.MontaComboClientes(cbcliente, "0", true);
                Label7.Visible = true;
                cbcliente.Visible = true;
            }
        }
        //
        //Combo Contas Correntes
        cbcontascorrentes.Items.Clear();
        uContas.MontaComboContas(cbcontascorrentes, "0");
        Label16.Visible = true;
        cbcontascorrentes.Visible = true;
        //
        //
        Label4.Visible = true;
        dtprevisao1.Visible = true;
        //
        Label6.Visible = true;
        dtrealizado1.Visible = true;
        //
        Label10.Visible = true;
        dtnotafiscal1.Visible = true;
        //
        dtprevisao1.Date = new DateTime(1900, 1, 1);
        dtrealizado1.Date = new DateTime(1900, 1, 1);
        dtnotafiscal1.Date = new DateTime(1900, 1, 1);
        dtcompensacao1.Date = new DateTime(1900, 1, 1);
        //
        eddocumento.Text = "";
        edordemcompra.Text = "";
        eddescricao.Text = "";
        edvlrtotalprevisto.Text = "";
        edvlrtotalrealizado.Text = "";
        edcheque.Text = "";
        edcontabil.Text = "";
        rbchequenominal.SelectedIndex = 0;
        //
        cbproduto.Text = "";
        cbreceita.Text = "";
        cbcliente.Text = "";
        cbcontascorrentes.Text = "";
        //
        edparcelas.Text = "1";
        edparcelas_total.Text = "1";
        //
        GridListagem.Visible = false;
        //
        edlancamento.Text = uContasReceber.PegaNovoCodigoCReceber();
        edlancamento.Focus();

    }

    protected void edparcelas_total_TextChanged(object sender, EventArgs e)
    {
        if (edparcelas_total.Text != "1")
        {
            btprocessa.Enabled = true;
            btnovocodigo.Enabled = false;
            btnovolancamento.Enabled = false;
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Lançamento de Parcelas Iniciado!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                "toastr.info('Lançamento de Parcelas Iniciado!', 'Atenção!')", true);
        }
        else
        {
            btprocessa.Enabled = true;
            btnovocodigo.Enabled = true;
            btnovolancamento.Enabled = true;
        }
    }

    protected void dtrealizado1_DateChanged(object sender, EventArgs e)
    {
        if (SreDblib.GetParametro("DATA COMPENSAÇÃO") != "NAO")
        {
            if (dtrealizado1.Date != Convert.ToDateTime("01/01/1900"))
            {
                dtcompensacao1.Date = dtrealizado1.Date;
                edvlrtotalrealizado.Focus();
            }
        }
    }

}

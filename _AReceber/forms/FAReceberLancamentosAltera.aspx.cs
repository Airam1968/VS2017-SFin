﻿using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FAReceberLancamentosAltera : System.Web.UI.Page
{
    DataSet dscreceber;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "CONTAS_RECEBER";

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = false;// SreDblib.TemPermissao("001.007.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.007.002.000", (String)Session["CodUsuario"]);
        lExclui = false;// SreDblib.TemPermissao("001.007.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.007.004.000", (String)Session["CodUsuario"]);
        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        //
        btprocessa.Enabled = lAltera;
        if (!lAltera)
            btprocessa.Image.ToolTip = Msg_acesso;
        lAltera = false;
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
            //Combo Fornecedor
            cbcliente.Items.Clear();
            uCliente.MontaComboClientes(cbcliente, "0", true);
            Label7.Visible = true;
            cbcliente.Visible = true;
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
            //dtprevisao1.Date = new DateTime(1900, 1, 1);
            //dtrealizado1.Date = new DateTime(1900, 1, 1);
            //dtnotafiscal1.Date = new DateTime(1900, 1, 1);
            //dtcompensacao1.Date = new DateTime(1900, 1, 1);
            //
            edlancamento.Text = "";
            //edlancamento.Focus();
        }
    }

    private void AtualizaGrid(String situacaopgto, String ordenacao)
    {
        string cbproduto2 = "";
        string cbdespesa2 = "";
        string cbfornecedor2 = "";
        string cbcontascorrentes2 = "";
        //
        if (cbproduto.Value != null)
        {
            cbproduto2 = cbproduto.Value.ToString().Trim();
        }
        if (cbreceita.Value != null)
        {
            cbdespesa2 = cbreceita.Value.ToString().Trim();
        }
        if (cbcliente.Value != null)
        {
            cbfornecedor2 = cbcliente.Value.ToString().Trim();
        }
        if (cbcontascorrentes.Value != null)
        {
            cbcontascorrentes2 = cbcontascorrentes.Value.ToString().Trim();
        }
        // 
        decimal totvlrprevisto = 0;
        decimal totqtdprevisto = 0;
        decimal totvlrrealizado = 0;
        decimal totqtdrealizado = 0;
        for (int i = 0; i < dscreceber.Tables[0].Rows.Count; i++)
        {
            totvlrprevisto = totvlrprevisto + Convert.ToDecimal(dscreceber.Tables[0].Rows[i]["vlr_previsto"]);
            totqtdprevisto = totqtdprevisto + 1;
            totvlrrealizado = totvlrrealizado + Convert.ToDecimal(dscreceber.Tables[0].Rows[i]["vlr_realizado"]);
            totqtdrealizado = totqtdrealizado + 1;
        }

        edvlrtotalprevisto.Text = Convert.ToString(totvlrprevisto);
        edvlrtotalrealizado.Text = Convert.ToString(totvlrrealizado);

        GridListagem.DataSource = dscreceber;
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
                //
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Número de Lançamento em Branco!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.info('Número de Lançamento em Branco!', 'Atenção!')", true);
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
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione uma Despesa!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.info('Selecione uma Despesa!', 'Atenção!')", true);
            }
            //Fim Check Receita
        }
        //
        if (lOk)
        {
            //Check Cliente
            if (cbcliente.Text != string.Empty)
            {
                //
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione um Cliente!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.info('Selecione um Cliente!', 'Atenção!')", true);
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
            //Processa Alteração do Lançamento
            try
            {
                uContasReceber.Altera(edlancamento.Text,
                                      cbproduto.Value.ToString(),
                                      cbreceita.Value.ToString(),
                                      cbcliente.Value.ToString(),
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
                                      dtrealizado1.Date.ToString().Substring(0, 10),
                                      1,
                                      edcontabil.Text
                                      );

            }
            catch (Exception)
            {
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Erro na Alteração, acione o Suporte!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.error('Erro na Alteração, acione o Suporte!', 'Atenção!')", true);
            }
            //
            // CRIA LOG ===============================================================================================================================================
            fwObs_Log = "LANÇAMENTO CONTAS A RECEBER - ALTERAÇÃO: " + edlancamento.Text;
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ), 
                                         new SqlParameter("@tabela"   , fWtabela                              ),
                                         new SqlParameter("@operacao" , "CONTAS A RECEBER"                    ),
                                         new SqlParameter("@obs"      , "ALTERAÇÃO LANÇAMENTO CONTAS A RECEBER" ),
                                         new SqlParameter("@acao"     , fwObs_Log                             ) };
            uLog.MakeLog(param_log);
            // FIM CRIA LOG ===============================================================================================================================================
            //
            //btprocessa.Enabled = false;
            //btimprime.Enabled = true;
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Lançamento Alterado!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                "toastr.success('Lançamento Alterado!', 'Atenção!')", true);
        }
    }


    protected void GridListagem_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
    {
        //

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

    protected void edlancamento_TextChanged(object sender, EventArgs e)
    {
        //Carrega Lançamentos
        if (edlancamento.Text.Trim() != String.Empty)
        {
            try
            {
                dscreceber.Clear();
            }
            catch (Exception)
            {
                //
            }
            //
            dscreceber = uContasReceber.PegaDadosCReceberLancamento(edlancamento.Text.Trim());
            //
            if (dscreceber.Tables[0].Rows.Count > 0)
            {
                //Combo Empresas
                cbproduto.Value = dscreceber.Tables[0].Rows[0]["produto"].ToString();
                //Combo Classe Despesas
                cbreceita.Value = dscreceber.Tables[0].Rows[0]["classe"].ToString();
                //Combo Fornecedor
                cbcliente.Value = dscreceber.Tables[0].Rows[0]["cliente"].ToString();
                //Combo Contas Correntes
                cbcontascorrentes.Value = dscreceber.Tables[0].Rows[0]["conta"].ToString();
                //
                eddescricao.Text = dscreceber.Tables[0].Rows[0]["descricao"].ToString();
                //
                DateTime temp;
                try
                {
                    temp = Convert.ToDateTime(dscreceber.Tables[0].Rows[0]["data_prevista"]);
                    if (temp != Convert.ToDateTime("01/01/1900"))
                        dtprevisao1.Date = new DateTime(temp.Year, temp.Month, temp.Day);
                }
                catch (Exception)
                {
                    dtprevisao1.Date = new DateTime(1900, 1, 1);
                }
                //
                try
                {
                    temp = Convert.ToDateTime(dscreceber.Tables[0].Rows[0]["data_realizado"]);
                    if (temp != Convert.ToDateTime("01/01/1900"))
                        dtrealizado1.Date = new DateTime(temp.Year, temp.Month, temp.Day);
                }
                catch (Exception)
                {
                    dtrealizado1.Date = new DateTime(1900, 1, 1);
                }
                //
                try
                {
                    temp = Convert.ToDateTime(dscreceber.Tables[0].Rows[0]["data_documento"]);
                    if (temp != Convert.ToDateTime("01/01/1900"))
                        dtnotafiscal1.Date = new DateTime(temp.Year, temp.Month, temp.Day);
                }
                catch (Exception)
                {
                    dtnotafiscal1.Date = new DateTime(1900, 1, 1);
                }
                //
                try
                {
                    temp = Convert.ToDateTime(dscreceber.Tables[0].Rows[0]["dtcompensacao"]);
                    if (temp != Convert.ToDateTime("01/01/1900"))
                        dtcompensacao1.Date = new DateTime(temp.Year, temp.Month, temp.Day);
                }
                catch (Exception)
                {
                    dtcompensacao1.Date = new DateTime(1900, 1, 1);
                }
                //
                edvlrtotalprevisto.Text = dscreceber.Tables[0].Rows[0]["vlr_previsto"].ToString();
                edvlrtotalrealizado.Text = dscreceber.Tables[0].Rows[0]["vlr_realizado"].ToString();
                //
                eddocumento.Text = dscreceber.Tables[0].Rows[0]["documento"].ToString();
                edcheque.Text = dscreceber.Tables[0].Rows[0]["cheque"].ToString();
                edcontabil.Text = dscreceber.Tables[0].Rows[0]["integracao_contabil"].ToString();
                //edordemcompra.Text = dscreceber.Tables[0].Rows[0]["pedido_compra"].ToString();
                //if (dscreceber.Tables[0].Rows[0]["nominal"] == "S")
                //{
                //    rbchequenominal.SelectedIndex = 1;
                //}
                //else
                //{
                //    rbchequenominal.SelectedIndex = 0;
                //}
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
                Label13.Visible = true;
                dtcompensacao1.Visible = true;
                //
            }
            else
            {
                //Não Localizado
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Lançamento Não Existe!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.error('Lançamento Não Existe!', 'Atenção!')", true);

            }

        }
    }

    protected void dtrealizado1_DateChanged(object sender, EventArgs e)
    {
        if ((SreDblib.GetParametro("DATA COMPENSAÇÃO") != "NAO") && (SreDblib.GetParametro("ORDEM FORNECEDOR") != "NÃO"))
        {
            if (dtrealizado1.Date != Convert.ToDateTime("01/01/1900"))
            {
                dtcompensacao1.Date = dtrealizado1.Date;
                edvlrtotalrealizado.Focus();
            }
        }
    }
}

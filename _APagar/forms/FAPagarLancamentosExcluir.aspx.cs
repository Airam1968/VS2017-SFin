using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FAPagarLancamentosExcluir : System.Web.UI.Page
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
        lInsere = false; // SreDblib.TemPermissao("001.006.001.000", (String)Session["CodUsuario"]);
        lAltera = false; //SreDblib.TemPermissao("001.006.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.006.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.006.004.000", (String)Session["CodUsuario"]);
        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        //
        btprocessa.Enabled = lExclui;
        if (!lInsere)
            btprocessa.Image.ToolTip = Msg_acesso;
        lExclui = false;
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
            cbdespesa.Items.Clear();
            uDespesas.MontaComboDespesas(cbdespesa, "0", true);
            Label2.Visible = true;
            cbdespesa.Visible = true;
            GridListagem.Visible = false;
            //
            //Combo Fornecedor
            cbfornecedor.Items.Clear();
            uFornecedores.MontaComboFornecedores(cbfornecedor, "0", true);
            Label7.Visible = true;
            cbfornecedor.Visible = true;
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
        if (cbdespesa.Value != null)
        {
            cbdespesa2 = cbdespesa.Value.ToString().Trim();
        }
        if (cbfornecedor.Value != null)
        {
            cbfornecedor2 = cbfornecedor.Value.ToString().Trim();
        }
        if (cbcontascorrentes.Value != null)
        {
            cbcontascorrentes2 = cbcontascorrentes.Value.ToString().Trim();
        }
        // 
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
                //
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
            //Processa Excluir do Lançamento
            uContasPagar.ExcluiLancamento(edlancamento.Text);
            //
            // CRIA LOG ===============================================================================================================================================
            fwObs_Log = "LANÇAMENTO CONTAS A PAGAR - EXCLUIR: " + edlancamento.Text;
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ),
                                         new SqlParameter("@tabela"   , fWtabela                              ),
                                         new SqlParameter("@operacao" , "CONTAS A PAGAR"                      ),
                                         new SqlParameter("@obs"      , "EXCLUIR LANÇAMENTO CONTAS A PAGAR"   ),
                                         new SqlParameter("@acao"     , fwObs_Log                             ) };
            uLog.MakeLog(param_log);
            // FIM CRIA LOG ===============================================================================================================================================
            //
            //btprocessa.Enabled = false;
            //btimprime.Enabled = true;
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Lançamento Excluído!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                "toastr.success('Lançamento Excluído!', 'Atenção!')", true);
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
                dscpagar.Clear();
            }
            catch (Exception)
            {
                //
            }
            //
            dscpagar = uContasPagar.PegaDadosCPagarLancamento(edlancamento.Text.Trim());
            //
            if (dscpagar.Tables[0].Rows.Count > 0)
            {
                //Combo Empresas
                cbproduto.Value = dscpagar.Tables[0].Rows[0]["produto"].ToString();
                //Combo Classe Despesas
                cbdespesa.Value = dscpagar.Tables[0].Rows[0]["classe"].ToString();
                //Combo Fornecedor
                cbfornecedor.Value = dscpagar.Tables[0].Rows[0]["fornecedor"].ToString();
                //Combo Contas Correntes
                cbcontascorrentes.Value = dscpagar.Tables[0].Rows[0]["conta"].ToString();
                //
                eddescricao.Text = dscpagar.Tables[0].Rows[0]["descricao"].ToString();
                //
                DateTime temp = Convert.ToDateTime(dscpagar.Tables[0].Rows[0]["data_prevista"]);
                try
                {
                    temp = Convert.ToDateTime(dscpagar.Tables[0].Rows[0]["data_prevista"]);
                    dtprevisao1.Date = new DateTime(temp.Year, temp.Month, temp.Day);
                }
                catch (Exception)
                {
                    dtprevisao1.Date = new DateTime(1900, 1, 1);
                }
                //
                try
                {
                    temp = Convert.ToDateTime(dscpagar.Tables[0].Rows[0]["data_realizado"]);
                    dtrealizado1.Date = new DateTime(temp.Year, temp.Month, temp.Day);
                }
                catch (Exception)
                {
                    dtrealizado1.Date = new DateTime(1900, 1, 1);
                }
                //
                try
                {
                    temp = Convert.ToDateTime(dscpagar.Tables[0].Rows[0]["data_documento"]);
                    dtnotafiscal1.Date = new DateTime(temp.Year, temp.Month, temp.Day);
                }
                catch (Exception)
                {
                    dtnotafiscal1.Date = new DateTime(1900, 1, 1);
                }
                //
                try
                {
                    temp = Convert.ToDateTime(dscpagar.Tables[0].Rows[0]["dtcompensacao"]);
                    dtcompensacao1.Date = new DateTime(temp.Year, temp.Month, temp.Day);
                }
                catch (Exception)
                {
                    dtcompensacao1.Date = new DateTime(1900, 1, 1);
                }
                //
                edvlrtotalprevisto.Text = dscpagar.Tables[0].Rows[0]["vlr_previsto"].ToString();
                edvlrtotalrealizado.Text = dscpagar.Tables[0].Rows[0]["vlr_realizado"].ToString();
                //
                eddocumento.Text = dscpagar.Tables[0].Rows[0]["documento"].ToString();
                edcheque.Text = dscpagar.Tables[0].Rows[0]["cheque"].ToString();
                edcontabil.Text = dscpagar.Tables[0].Rows[0]["integracao_contabil"].ToString();
                edordemcompra.Text = dscpagar.Tables[0].Rows[0]["pedido_compra"].ToString();
                if (dscpagar.Tables[0].Rows[0]["nominal"].ToString().Trim() == "S")
                {
                    rbchequenominal.SelectedIndex = 1;
                }
                else
                {
                    rbchequenominal.SelectedIndex = 0;
                }
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
            }
        }
    }
}

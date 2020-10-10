using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;


public partial class FTabelaVendasTaxasMensais : System.Web.UI.Page
{
    DataSet dstaxasmensais;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "TAXAS_MENSAIS";

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = SreDblib.TemPermissao("001.004.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.004.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.004.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.004.004.000", (String)Session["CodUsuario"]);
        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        //
        GridListagem.Enabled = lInsere;
        if (!lInsere)
        {
            GridListagem.ToolTip = Msg_acesso;
        }
        //
        AtualizaGrid();
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

    private void AtualizaGrid()
    {
        // Taxas Mensais
        dstaxasmensais = uTaxasMensais.PegaDadosTaxasMensaisID(0);
        GridListagem.DataSource = dstaxasmensais;
        GridListagem.KeyFieldName = "ID";
        GridListagem.DataBind();
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


    protected void GridListagem_DataBound(object sender, EventArgs e)
    {
        if (GridListagem.Columns["Ação"] == null)
        {
            GridViewCommandColumn cmdCol = new GridViewCommandColumn("Ação");
            //cmdCol.ButtonType = ButtonType.Image;
            //cmdCol.Width = Unit.Pixel(25);
            //
            //GridViewCommandColumnCustomButton cDelBtn = new GridViewCommandColumnCustomButton();
            //cDelBtn.ID = "cmdDelete";
            //cDelBtn.Text = "Delete";
            //cDelBtn.Image.IsResourcePng = true;
            //cDelBtn.Image.Url = "~/images/BotoesTelas/BTNexcluirA.bmp";
            //cDelBtn.Visibility = GridViewCustomButtonVisibility.AllDataRows;

            //
            cmdCol.ShowNewButton = true;
            cmdCol.ShowEditButton = true;
            cmdCol.ShowDeleteButton = true;
            GridListagem.Columns.Add(cmdCol);
        }
    }

    protected void GridListagem_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        //
        DataSet dsnomecolunas = uTaxasMensais.PegaDadosTaxasMensaisNomeColunas();
        //
        string ID = "";
        string mes = "";
        string ano = "";
        string[] nome_taxa = new string[1000];
        string[] valor = new string[1000];
        string nome_taxa_corrente = "";
        //
        for (int i = 0; i < 1000; i++)
        {
            nome_taxa[i] = "";
            valor[i] = "";
        }
        // 
        //ID = e.NewValues["ID"].ToString();
        mes = e.NewValues["mes"].ToString();
        ano = e.NewValues["ano"].ToString();
        //
        //String
        //ignora id, mes, ano
        Int32 j = 0;
        for (int i = 3; i < dsnomecolunas.Tables[0].Rows.Count; i++)
        {
            nome_taxa_corrente = dsnomecolunas.Tables[0].Rows[i]["COLUMN_NAME"].ToString();
            nome_taxa[j] = nome_taxa_corrente;
            valor[j] = "0";
            if (e.NewValues[nome_taxa_corrente] != null)
            {
                valor[j] = e.NewValues[nome_taxa_corrente].ToString();
            }
            j++;
        }
        //
        string string_altera = "";
        for (int i = 0; i < j; i++)
        {
            string_altera = string_altera +
                            Srelib.forcaponto(valor[i]) + ", ";
        }
        //
        string_altera = string_altera.Substring(0, string_altera.Length - 2);
        //
        //String2
        //
        //ignora id, mes, ano
        j = 0;
        for (int i = 1; i < dsnomecolunas.Tables[0].Rows.Count; i++)
        {
            nome_taxa_corrente = dsnomecolunas.Tables[0].Rows[i]["COLUMN_NAME"].ToString();
            nome_taxa[j] = nome_taxa_corrente;
            valor[j] = "0";
            if (e.NewValues[nome_taxa_corrente] != null)
            {
                valor[j] = e.NewValues[nome_taxa_corrente].ToString();
            }
            j++;
        }
        //
        string string_altera2 = "";
        for (int i = 0; i < j; i++)
        {
            string_altera2 = string_altera2 +
                            nome_taxa[i] + " = " + Srelib.forcaponto(valor[i]) + ", ";
        }
        //
        string_altera2 = string_altera2.Substring(0, string_altera2.Length - 2);
        //
        //
        uTaxasMensais.IncluiTaxas(ID,
                                  mes,
                                  ano,
                                  string_altera,
                                  string_altera2);


        gridView.CancelEdit();
        e.Cancel = true;


        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "INCLUI TAXAS MENSAIS: " + mes + "/" + ano;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "TAXAS MENSAIS"              ),
                                     new SqlParameter("@obs"      , "INCLUI"                     ),
                                     new SqlParameter("@acao"     , fwObs_Log                    ) };
        uLog.MakeLog(param_log);

        //
        AtualizaGrid();

    }

    protected void GridListagem_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;
        //
        DataSet dsnomecolunas = uTaxasMensais.PegaDadosTaxasMensaisNomeColunas();
        //
        string ID = "";
        string mes = "";
        string ano = "";
        string[] nome_taxa = new string[1000];
        string[] valor = new string[1000];
        string nome_taxa_corrente = "";
        //
        for (int i = 0; i < 1000; i++)
        {
            nome_taxa[i] = "";
            valor[i] = "";
        }
        // 
        ID = e.NewValues["ID"].ToString();
        mes = e.NewValues["mes"].ToString();
        ano = e.NewValues["ano"].ToString();
        //
        //ignora id, mes, ano
        Int32 j = 0;
        for (int i = 2; i < dsnomecolunas.Tables[0].Rows.Count; i++)
        {
            nome_taxa_corrente = dsnomecolunas.Tables[0].Rows[i]["COLUMN_NAME"].ToString();
            nome_taxa[j] = nome_taxa_corrente;
            valor[j] = "0";
            if (e.NewValues[nome_taxa_corrente] != null)
            {
                valor[j] = e.NewValues[nome_taxa_corrente].ToString();
            }
            j++;
        }
        //
        string string_altera = "";
        for (int i = 0; i < j; i++)
        {
            string_altera = string_altera +
                            nome_taxa[i] + " = " + Srelib.forcaponto(valor[i]) + ", ";
        }
        //
        string_altera = string_altera.Substring(0, string_altera.Length - 2);

        uTaxasMensais.AlteraTaxas(ID,
                                  mes,
                                  ano,
                                  string_altera);


        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "ALTERA TAXAS MENSAIS: " + mes + "/" + ano;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "TAXAS MENSAIS"              ),
                                     new SqlParameter("@obs"      , "ALTERA"                     ),
                                     new SqlParameter("@acao"     , fwObs_Log                    ) };
        uLog.MakeLog(param_log);

        //
        AtualizaGrid();
    }

    protected void GridListagem_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        //
        string ID = "";
        string mes = "";
        string ano = "";
        //
        // 
        ID = e.Values["ID"].ToString();
        mes = e.Values["mes"].ToString();
        ano = e.Values["ano"].ToString();
        //
        uTaxasMensais.ExcluiTaxas(ID);
        //

        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "EXCLUI TAXAS MENSAIS: " + mes + "/" + ano;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "TAXAS MENSAIS"              ),
                                     new SqlParameter("@obs"      , "EXCLUI"                     ),
                                     new SqlParameter("@acao"     , fwObs_Log                    ) };
        uLog.MakeLog(param_log);
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
        //
        DataSet dsnomecolunas = uTaxasMensais.PegaDadosTaxasMensaisNomeColunas();
        //
        string[] nome_taxa = new string[1000];
        string[] valor = new string[1000];
        string nome_taxa_corrente = "";
        //
        for (int i = 0; i < 1000; i++)
        {
            nome_taxa[i] = "";
            valor[i] = "";
        }
        //String
        //ignora id, mes, ano
        Int32 j = 0;
        for (int i = 3; i < dsnomecolunas.Tables[0].Rows.Count; i++)
        {
            nome_taxa_corrente = dsnomecolunas.Tables[0].Rows[i]["COLUMN_NAME"].ToString();
            nome_taxa[j] = nome_taxa_corrente;
            valor[j] = "0,000000";
            e.NewValues[nome_taxa_corrente] = valor[j].ToString();
            j++;
        }
    }

}

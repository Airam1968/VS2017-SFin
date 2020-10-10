using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;


public partial class FClienteCartaPadrao : System.Web.UI.Page
{
    DataSet dscartas;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "MODELO_CARTAS";

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = SreDblib.TemPermissao("001.002.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.002.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.002.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.002.004.000", (String)Session["CodUsuario"]);
        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        //
        GridListagem.Enabled = lInsere;
        if (!lInsere)
            GridListagem.ToolTip = Msg_acesso;
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
        //dscartas.Clear();
        dscartas = uMalaDireta.PegaDadosCarta("");
        GridListagem.DataSource = dscartas;
        GridListagem.KeyFieldName = "ID";
        GridListagem.DataBind();

    }

    protected void GridListagem_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        //
        string ID = "";
        string nome = "";
        string selecao = "0";
        string linha_1 = "";
        string linha_2 = "";
        string linha_3 = "";
        string linha_4 = "";
        string linha_5 = "";
        string linha_6 = "";
        string linha_7 = "";
        string linha_8 = "";
        string linha_9 = "";
        string linha_10 = "";
        string linha_11 = "";
        string linha_12 = "";
        string linha_13 = "";
        string linha_14 = "";
        string linha_15 = "";
        string linha_16 = "";
        string linha_17 = "";
        string linha_18 = "";
        string linha_19 = "";
        //
        // 
        ID = e.NewValues["ID"].ToString();
        nome = e.NewValues["nome"].ToString();
        linha_1 = e.NewValues["linha_1"].ToString();
        linha_2 = e.NewValues["linha_2"].ToString();
        linha_3 = e.NewValues["linha_3"].ToString();
        linha_4 = e.NewValues["linha_4"].ToString();
        linha_5 = e.NewValues["linha_5"].ToString();
        linha_6 = e.NewValues["linha_6"].ToString();
        linha_7 = e.NewValues["linha_7"].ToString();
        linha_8 = e.NewValues["linha_8"].ToString();
        linha_9 = e.NewValues["linha_9"].ToString();
        linha_10 = e.NewValues["linha_10"].ToString();
        linha_11 = e.NewValues["linha_11"].ToString();
        linha_12 = e.NewValues["linha_12"].ToString();
        linha_13 = e.NewValues["linha_13"].ToString();
        linha_14 = e.NewValues["linha_14"].ToString();
        linha_15 = e.NewValues["linha_15"].ToString();
        linha_16 = e.NewValues["linha_16"].ToString();
        linha_17 = e.NewValues["linha_17"].ToString();
        linha_18 = e.NewValues["linha_18"].ToString();
        linha_19 = e.NewValues["linha_19"].ToString();


        uMalaDireta.Grava(nome,
                          selecao,
                          linha_1,
                          linha_2,
                          linha_3,
                          linha_4,
                          linha_5,
                          linha_6,
                          linha_7,
                          linha_8,
                          linha_9,
                          linha_10,
                          linha_11,
                          linha_12,
                          linha_13,
                          linha_14,
                          linha_15,
                          linha_16,
                          linha_17,
                          linha_18,
                          linha_19);


        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "INCLUI CARTA PADRÃO: " + nome + "/" + linha_1;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "CARTA PADRÃO"               ),
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
        string ID = "";
        string nome = "";
        string selecao = "0";
        string linha_1 = " ";
        string linha_2 = " ";
        string linha_3 = " ";
        string linha_4 = " ";
        string linha_5 = " ";
        string linha_6 = " ";
        string linha_7 = " ";
        string linha_8 = " ";
        string linha_9 = " ";
        string linha_10 = " ";
        string linha_11 = " ";
        string linha_12 = " ";
        string linha_13 = " ";
        string linha_14 = " ";
        string linha_15 = " ";
        string linha_16 = " ";
        string linha_17 = " ";
        string linha_18 = " ";
        string linha_19 = " ";
        //
        //
        // 
        ID = e.NewValues["ID"].ToString();
        nome = e.NewValues["nome"].ToString();
        if (e.NewValues["linha_1"] != null)
        {
            linha_1 = e.NewValues["linha_1"].ToString();
        }
        if (e.NewValues["linha_2"] != null)
        {
            linha_2 = e.NewValues["linha_2"].ToString();
        }
        if (e.NewValues["linha_3"] != null)
        {
            linha_3 = e.NewValues["linha_3"].ToString();
        }
        if (e.NewValues["linha_4"] != null)
        {
            linha_4 = e.NewValues["linha_4"].ToString();
        }
        if (e.NewValues["linha_5"] != null)
        {
            linha_5 = e.NewValues["linha_5"].ToString();
        }
        if (e.NewValues["linha_6"] != null)
        {
            linha_6 = e.NewValues["linha_6"].ToString();
        }
        if (e.NewValues["linha_7"] != null)
        {
            linha_7 = e.NewValues["linha_7"].ToString();
        }
        if (e.NewValues["linha_8"] != null)
        {
            linha_8 = e.NewValues["linha_8"].ToString();
        }
        if (e.NewValues["linha_9"] != null)
        {
            linha_9 = e.NewValues["linha_9"].ToString();
        }
        if (e.NewValues["linha_10"] != null)
        {
            linha_10 = e.NewValues["linha_10"].ToString();
        }
        if (e.NewValues["linha_11"] != null)
        {
            linha_11 = e.NewValues["linha_11"].ToString();
        }
        if (e.NewValues["linha_12"] != null)
        {
            linha_12 = e.NewValues["linha_12"].ToString();
        }
        if (e.NewValues["linha_13"] != null)
        {
            linha_13 = e.NewValues["linha_13"].ToString();
        }
        if (e.NewValues["linha_14"] != null)
        {
            linha_14 = e.NewValues["linha_14"].ToString();
        }
        if (e.NewValues["linha_15"] != null)
        {
            linha_15 = e.NewValues["linha_15"].ToString();
        }
        if (e.NewValues["linha_16"] != null)
        {
            linha_16 = e.NewValues["linha_16"].ToString();
        }
        if (e.NewValues["linha_17"] != null)
        {
            linha_17 = e.NewValues["linha_17"].ToString();
        }
        if (e.NewValues["linha_18"] != null)
        {
            linha_18 = e.NewValues["linha_18"].ToString();
        }
        if (e.NewValues["linha_19"] != null)
        {
            linha_19 = e.NewValues["linha_19"].ToString();
        }

        uMalaDireta.AlteraCarta(ID,
                                nome,
                                selecao,
                                linha_1,
                                linha_2,
                                linha_3,
                                linha_4,
                                linha_5,
                                linha_6,
                                linha_7,
                                linha_8,
                                linha_9,
                                linha_10,
                                linha_11,
                                linha_12,
                                linha_13,
                                linha_14,
                                linha_15,
                                linha_16,
                                linha_17,
                                linha_18,
                                linha_19);


        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "ALTERA CARTA PADRÃO: " + ID + "/" + nome;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "CARTA PADRÃO"               ),
                                     new SqlParameter("@obs"      , "ALTERA"                     ),
                                     new SqlParameter("@acao"     , fwObs_Log                    ) };
        uLog.MakeLog(param_log);

        //
        AtualizaGrid();
    }

    protected void GridListagem_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        uMalaDireta.ExcluiCarta(e.Values["ID"].ToString());
        //

        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "EXCLUI CARTA PADRÃO: " + e.Values["ID"].ToString() + "/" + e.Values["nome"].ToString().ToUpper();
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "CARTA PADRÃO"               ),
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
        //e.NewValues["Historico"] = uContabil.PegaNSeqHistor().ToString();
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


}

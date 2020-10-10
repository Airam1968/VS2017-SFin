using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FTabelaProdutosGrupo : System.Web.UI.Page
{
    DataSet dsprodutogrupo;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "PRODUTO_GRUPO";

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = SreDblib.TemPermissao("001.003.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.003.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.003.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.003.004.000", (String)Session["CodUsuario"]);
        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        //
        GridListagem.Enabled = lInsere;
        if (!lInsere)
        {
            GridListagem.ToolTip = Msg_acesso;
        }
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
        //dsusuario.Clear();
        dsprodutogrupo = uProduto.PegaDadosProdutoGrupo(0, "");
        GridListagem.DataSource = dsprodutogrupo;
        GridListagem.KeyFieldName = "ID";
        GridListagem.DataBind();
    }

    protected void GridListagem_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        //
        //string ID = "";
        string produto = "";
        string grupo = "";
        string grupo_tipo = "";
        string descricao = "";
        string quantidade = "";
        string num_inicio = "";
        string num_final = "";
        Boolean ativo = false;
        DateTime dtbase_vlr_venda = Convert.ToDateTime("01/01/1900");
        Decimal vlr_venda = 0;
        string observa_1 = "";
        string observa_2 = "";
        //
        // 
        //ID = e.NewValues["ID"].ToString();
        produto = e.NewValues["produto"].ToString();
        grupo = e.NewValues["grupo"].ToString();
        grupo_tipo = e.NewValues["grupo_tipo"].ToString();
        descricao = e.NewValues["descricao"].ToString().ToUpper();
        quantidade = e.NewValues["quantidade"].ToString();
        num_inicio = e.NewValues["num_inicio"].ToString();
        num_final = e.NewValues["num_final"].ToString();
        ativo = false;
        if (e.NewValues["dtbase_vlr_venda"] != null)
        {
            dtbase_vlr_venda = Convert.ToDateTime(e.NewValues["dtbase_vlr_venda"].ToString());
        }
        if (e.NewValues["vlr_venda"] != null)
        {
            vlr_venda = Convert.ToDecimal(e.NewValues["vlr_venda"].ToString());
        }
        if (e.NewValues["observa_1"] != null)
        {
            observa_1 = e.NewValues["observa_1"].ToString();
        }
        if (e.NewValues["observa_2"] != null)
        {
            observa_2 = e.NewValues["observa_2"].ToString();
        }
        //
        uProduto.GravaGrupo(produto,
                            grupo,
                            grupo_tipo,
                            descricao,
                            quantidade,
                            num_inicio,
                            num_final,
                            ativo,
                            dtbase_vlr_venda,
                            Convert.ToString(vlr_venda),
                            observa_1,
                            observa_2);


        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "INCLUI PRODUTO GRUPO: " + produto + "/" + grupo + "/" + descricao;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "PRODUTO GRUPO"              ),
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
        string produto = "";
        string grupo = "";
        string grupo_tipo = "";
        string descricao = "";
        string quantidade = "";
        string num_inicio = "";
        string num_final = "";
        Boolean ativo = false;
        DateTime dtbase_vlr_venda = Convert.ToDateTime("01/01/1900");
        Decimal vlr_venda = 0;
        string observa_1 = "";
        string observa_2 = "";
        //
        // 
        ID = e.NewValues["ID"].ToString();
        produto = e.NewValues["produto"].ToString();
        grupo = e.NewValues["grupo"].ToString();
        grupo_tipo = e.NewValues["grupo_tipo"].ToString();
        descricao = e.NewValues["descricao"].ToString().ToUpper();
        quantidade = e.NewValues["quantidade"].ToString();
        num_inicio = e.NewValues["num_inicio"].ToString();
        num_final = e.NewValues["num_final"].ToString();
        ativo = Convert.ToBoolean(e.NewValues["ativo"]);
        if (e.NewValues["dtbase_vlr_venda"] != null)
        {
            dtbase_vlr_venda = Convert.ToDateTime(e.NewValues["dtbase_vlr_venda"].ToString());
        }
        if (e.NewValues["vlr_venda"] != null)
        {
            vlr_venda = Convert.ToDecimal(e.NewValues["vlr_venda"].ToString());
        }
        if (e.NewValues["observa_1"] != null)
        {
            observa_1 = e.NewValues["observa_1"].ToString();
        }
        if (e.NewValues["observa_2"] != null)
        {
            observa_2 = e.NewValues["observa_2"].ToString();
        }

        uProduto.AlteraGrupo(ID,
                            produto,
                            grupo,
                            grupo_tipo,
                            descricao,
                            quantidade,
                            num_inicio,
                            num_final,
                            ativo,
                            dtbase_vlr_venda,
                            Convert.ToString(vlr_venda),
                            observa_1,
                            observa_2);


        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "ALTERA PRODUTO GRUPO: " + produto + "/" + grupo + "/" + descricao;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "PRODUTO GRUPO"              ),
                                     new SqlParameter("@obs"      , "ALTERA"                     ),
                                     new SqlParameter("@acao"     , fwObs_Log                    ) };
        uLog.MakeLog(param_log);

        //
        AtualizaGrid();
    }

    protected void GridListagem_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        uProduto.ExcluiGrupo(e.Values["ID"].ToString());
        //

        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "EXCLUI PRODUTO GRUPO: " + e.Values["produto"].ToString() + "/" + e.Values["grupo"].ToString() + "/" + e.Values["descricao"].ToString().ToUpper();
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "PRODUTO GRUPO"              ),
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
        e.NewValues["ativo"] = false;
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

}

using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;


public partial class FTabelaVendasCorretores : System.Web.UI.Page
{
    DataSet dscorretor;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "CORRETORES";

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
        //dsusuario.Clear();
        dscorretor = uCorretor.PegaDadosCorretor(0);
        GridListagem.DataSource = dscorretor;
        GridListagem.KeyFieldName = "ID";
        GridListagem.DataBind();
    }


    protected void GridListagem_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;
        //
        string ID = "";
        string codigo = "";
        string apelido = "";
        string nome = "";
        string comissao_base = "0";
        //
        //ID = e.NewValues["ID"].ToString();
        codigo = e.NewValues["codigo"].ToString();
        if (e.NewValues["apelido"] != null)
        {
            apelido = e.NewValues["apelido"].ToString();
        }
        if (e.NewValues["nome"] != null)
        {
            nome = e.NewValues["nome"].ToString();
        }
        if (e.NewValues["comissao_base"] != null)
        {
            comissao_base = e.NewValues["comissao_base"].ToString();
        }
        uCorretor.Grava(codigo,
                        apelido,
                        nome,
                        comissao_base);

        //
        //Incluir taxas Mensais ou taxas Diárias
        //

        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "INCLUI CORRETOR: " + nome + "/" + apelido;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "CORRETOR"                   ),
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
        string codigo = "";
        string apelido = "";
        string nome = "";
        string comissao_base = "0";
        //
        ID = e.NewValues["ID"].ToString();
        codigo = e.NewValues["codigo"].ToString();
        if (e.NewValues["apelido"] != null)
        {
            apelido = e.NewValues["apelido"].ToString();
        }
        if (e.NewValues["nome"] != null)
        {
            nome = e.NewValues["nome"].ToString();
        }
        if (e.NewValues["comissao_base"] != null)
        {
            comissao_base = e.NewValues["comissao_base"].ToString();
        }

        uCorretor.Altera(ID,
                        codigo,
                        apelido,
                        nome,
                        comissao_base);


        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "ALTERA CORRETOR: " + apelido + "/" + nome;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "CORRETOR"                   ),
                                     new SqlParameter("@obs"      , "ALTERA"                     ),
                                     new SqlParameter("@acao"     , fwObs_Log                    ) };
        uLog.MakeLog(param_log);

        //
        AtualizaGrid();
    }

    protected void GridListagem_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        uCorretor.Exclui(e.Values["ID"].ToString());
        //
        //Apagar taxas Mensais ou taxas Diárias
        //

        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "EXCLUI CORRETOR: " + e.Values["ID"].ToString() + "/" + e.Values["nome"].ToString().ToUpper();
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "CORRETOR"                   ),
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
        e.NewValues["codigo"] = uCorretor.PegaNovoCodigo().ToString();
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

using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;


public partial class FTabelaVendasMensagensBoleto : System.Web.UI.Page
{
    DataSet dsmensagens;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "BOLETO_MENSAGENS";

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
        dsmensagens = uMensagemBoleto.PegaDadosMensagemBoleto(0);
        GridListagem.DataSource = dsmensagens;
        GridListagem.KeyFieldName = "ID";
        GridListagem.DataBind();
    }

    protected void GridListagem_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        //
        string ID = "";
        string codigo = "";
        string produto = "";
        string linha1 = "";
        string linha2 = "";
        string linha3 = "";
        string linha4 = "";
        string linha5 = "";
        //
        //ID = e.NewValues["ID"].ToString();
        codigo = e.NewValues["codigo"].ToString();
        if (e.NewValues["produto"] != null)
        {
            produto = e.NewValues["produto"].ToString();
        }
        if (e.NewValues["linha1"] != null)
        {
            linha1 = e.NewValues["linha1"].ToString();
        }
        if (e.NewValues["linha2"] != null)
        {
            linha2 = e.NewValues["linha2"].ToString();
        }
        if (e.NewValues["linha3"] != null)
        {
            linha3 = e.NewValues["linha3"].ToString();
        }
        if (e.NewValues["linha4"] != null)
        {
            linha4 = e.NewValues["linha4"].ToString();
        }
        if (e.NewValues["linha5"] != null)
        {
            linha5 = e.NewValues["linha5"].ToString();
        }

        uMensagemBoleto.Grava(codigo,
                               produto,
                               linha1,
                               linha2,
                               linha3,
                               linha4,
                               linha5);

        //
        //Incluir taxas Mensais ou taxas Diárias
        //

        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "INCLUI MENSAGEM BOLETO: " + codigo + "/" + produto;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "MENSAGEM BOLETO"            ),
                                     new SqlParameter("@obs"      , "INCLUI"                     ),
                                     new SqlParameter("@acao"     , fwObs_Log                    ) };
        uLog.MakeLog(param_log);

        //
        AtualizaGrid();

    }
    protected void GridListagem_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        string ID = "";
        string codigo = "";
        string produto = "";
        string linha1 = "";
        string linha2 = "";
        string linha3 = "";
        string linha4 = "";
        string linha5 = "";
        //
        ID = e.NewValues["ID"].ToString();
        codigo = e.NewValues["codigo"].ToString();
        if (e.NewValues["produto"] != null)
        {
            produto = e.NewValues["produto"].ToString();
        }
        if (e.NewValues["linha1"] != null)
        {
            linha1 = e.NewValues["linha1"].ToString();
        }
        if (e.NewValues["linha2"] != null)
        {
            linha2 = e.NewValues["linha2"].ToString();
        }
        if (e.NewValues["linha3"] != null)
        {
            linha3 = e.NewValues["linha3"].ToString();
        }
        if (e.NewValues["linha4"] != null)
        {
            linha4 = e.NewValues["linha4"].ToString();
        }
        if (e.NewValues["linha5"] != null)
        {
            linha5 = e.NewValues["linha5"].ToString();
        }

        uMensagemBoleto.Altera(ID,
                                codigo,
                                produto,
                                linha1,
                                linha2,
                                linha3,
                                linha4,
                                linha5);


        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "ALTERA MENSAGEM BOLETO: " + codigo + "/" + produto;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "MENSAGEM BOLETO"            ),
                                     new SqlParameter("@obs"      , "ALTERA"                     ),
                                     new SqlParameter("@acao"     , fwObs_Log                    ) };
        uLog.MakeLog(param_log);

        //
        AtualizaGrid();
    }

    protected void GridListagem_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        uMensagemBoleto.Exclui(e.Values["ID"].ToString());
        //
        //Apagar taxas Mensais ou taxas Diárias
        //

        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "EXCLUI MENSAGEM BOLETO: " + e.Values["codigo"].ToString() + "/" + e.Values["produto"].ToString().ToUpper();
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "MENSAGEM BOLETO"            ),
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
        e.NewValues["codigo"] = uMensagemBoleto.PegaNovoCodigo().ToString();
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

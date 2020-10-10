using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FTabelaVendasIndexadores : System.Web.UI.Page
{
    DataSet dsindexadores;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "INDEXADORES";


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
        dsindexadores = uIndexadores.PegaDadosIndexadores(0);
        GridListagem.DataSource = dsindexadores;
        GridListagem.KeyFieldName = "ID";
        GridListagem.DataBind();
    }


    protected void GridListagem_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        //
        string ID = "";
        string nome = "";
        string descricao = "";
        string orgao = "";
        string divulgacao = "";
        string periodicidade = "";
        string tipo = "";
        string inicio = "0";
        string fim = "0";
        string dmais = "0";
        Boolean ativo = false;
        string observa_1 = "";
        string observa_2 = "";
        //
        //ID = e.NewValues["ID"].ToString();
        nome = e.NewValues["nome"].ToString().ToUpper().Trim();
        nome = Srelib.tiraacento(nome);
        nome = Regex.Replace(nome, @"\s", "");
        //
        if (e.NewValues["descricao"] != null)
        {
            descricao = e.NewValues["descricao"].ToString().ToUpper().Trim();
        }
        if (e.NewValues["orgao"] != null)
        {
            orgao = e.NewValues["orgao"].ToString();
        }
        if (e.NewValues["divulgacao"] != null)
        {
            divulgacao = e.NewValues["divulgacao"].ToString();
        }
        periodicidade = e.NewValues["periodicidade"].ToString();
        tipo = e.NewValues["tipo"].ToString();
        if (e.NewValues["inicio"] != null)
        {
            inicio = e.NewValues["inicio"].ToString();
        }
        if (e.NewValues["fim"] != null)
        {
            fim = e.NewValues["fim"].ToString();
        }
        if (e.NewValues["dmais"] != null)
        {
            dmais = e.NewValues["dmais"].ToString();
        }
        ativo = Convert.ToBoolean(e.NewValues["ativo"]);

        if (e.NewValues["observa_1"] != null)
        {
            observa_1 = e.NewValues["observa_1"].ToString();
        }
        if (e.NewValues["observa_2"] != null)
        {
            observa_2 = e.NewValues["observa_2"].ToString();
        }

        //Grava o Indexador
        uIndexadores.Grava(nome,
                           descricao,
                           orgao,
                           divulgacao,
                           periodicidade,
                           tipo,
                           inicio,
                           fim,
                           dmais,
                           ativo,
                           observa_1,
                           observa_2);
        //

        //

        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "INCLUI INDEXADORES: " + nome + "/" + descricao;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "INDEXADORES"               ),
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
        string descricao = "";
        string orgao = "";
        string divulgacao = "";
        string periodicidade = "";
        string tipo = "";
        string inicio = "";
        string fim = "";
        string dmais = "";
        Boolean ativo = true;
        string observa_1 = "";
        string observa_2 = "";
        //
        // 
        ID = e.NewValues["ID"].ToString();
        //
        nome = e.NewValues["nome"].ToString().ToUpper().Trim();
        nome = Srelib.tirasimbolos(nome);
        nome = Srelib.tiraacento(nome);
        //
        if (e.NewValues["descricao"] != null)
        {
            descricao = e.NewValues["descricao"].ToString();
        }
        if (e.NewValues["orgao"] != null)
        {
            orgao = e.NewValues["orgao"].ToString();
        }
        if (e.NewValues["divulgacao"] != null)
        {
            divulgacao = e.NewValues["divulgacao"].ToString();
        }
        periodicidade = e.NewValues["periodicidade"].ToString();
        tipo = e.NewValues["tipo"].ToString();
        if (e.NewValues["inicio"] != null)
        {
            inicio = e.NewValues["inicio"].ToString();
        }
        if (e.NewValues["fim"] != null)
        {
            fim = e.NewValues["fim"].ToString();
        }
        if (e.NewValues["dmais"] != null)
        {
            dmais = e.NewValues["dmais"].ToString();
        }
        ativo = Convert.ToBoolean(e.NewValues["ativo"]);

        if (e.NewValues["observa_1"] != null)
        {
            observa_1 = e.NewValues["observa_1"].ToString();
        }
        if (e.NewValues["observa_2"] != null)
        {
            observa_2 = e.NewValues["observa_2"].ToString();
        }


        uIndexadores.Altera(ID,
                            nome,
                            descricao,
                            orgao,
                            divulgacao,
                            periodicidade,
                            tipo,
                            inicio,
                            fim,
                            dmais,
                            ativo,
                            observa_1,
                            observa_2);


        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "ALTERA INDEXADORES: " + nome + "/" + descricao;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "INDEXADORES"                ),
                                     new SqlParameter("@obs"      , "ALTERA"                     ),
                                     new SqlParameter("@acao"     , fwObs_Log                    ) };
        uLog.MakeLog(param_log);

        //
        AtualizaGrid();
    }

    protected void GridListagem_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        uIndexadores.Exclui(e.Values["ID"].ToString(), e.Values["nome"].ToString(), e.Values["periodicidade"].ToString());
        //
        //Apagar taxas Mensais ou taxas Diárias
        //

        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "EXCLUI INDEXADORES: " + e.Values["ID"].ToString() + "/" + e.Values["nome"].ToString().ToUpper();
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "INDEXADORES"               ),
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
        e.NewValues["ativo"] = true;
        e.NewValues["periodicidade"] = "MENSAL";
        e.NewValues["tipo"] = "TAXA";
        e.NewValues["inicio"] = "0";
        e.NewValues["fim"] = "0";
        e.NewValues["dmais"] = "0";
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

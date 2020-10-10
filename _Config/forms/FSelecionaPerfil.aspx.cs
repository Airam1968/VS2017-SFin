using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;


public partial class FSelecionaPerfil : System.Web.UI.Page
{
    DataSet dsusuario;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "USUARIO";

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = SreDblib.TemPermissao("001.011.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.011.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.011.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.011.004.000", (String)Session["CodUsuario"]);
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
        dsusuario = uUsuario.PegaDadosPerfil("");
        GridListagem.DataSource = dsusuario;
        GridListagem.KeyFieldName = "Login";
        GridListagem.DataBind();
    }

    protected void GridListagem_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
    {
        //Código Original
        ASPxGridView gridView = (ASPxGridView)sender;
        // Tratamento dos Campos não preenchidos - Não Obrigatórios
        string login = "";
        string senha = "";
        string nome = "";
        string setor = "";
        string funcao = "";
        string fone = "";
        int perfil = 1;
        string email = "";
        string alcada = "";
        Boolean ativo = true;
        //
        //
        try
        {
            login = e.NewValues["Login"].ToString();
        }
        catch (Exception)
        {
            login = " ";
        }
        //
        try
        {
            senha = e.NewValues["Senha"].ToString();
        }
        catch (Exception)
        {
            senha = " ";
        }
        //
        try
        {
            nome = e.NewValues["Nome"].ToString();
        }
        catch (Exception)
        {
            nome = " ";
        }
        //
        try
        {
            setor = e.NewValues["Setor"].ToString();
        }
        catch (Exception)
        {
            setor = " ";
        }
        //
        try
        {
            funcao = e.NewValues["Funcao"].ToString();
        }
        catch (Exception)
        {
            funcao = " ";
        }
        //
        try
        {
            fone = e.NewValues["Fone"].ToString();
        }
        catch (Exception)
        {
            fone = " ";
        }
        //
        try
        {
            email = e.NewValues["email"].ToString();
        }
        catch (Exception)
        {
            email = " ";
        }
        //
        try
        {
            alcada = e.NewValues["alcada"].ToString();
        }
        catch (Exception)
        {
            alcada = " ";
        }
        //
        //Grava
        uUsuario.Grava(login.ToUpper(),
                       senha.ToUpper(),
                       nome,
                       setor,
                       funcao,
                       fone,
                       perfil,
                       email,
                       alcada,
                       ativo);
        //

        //Código Original
        gridView.CancelEdit();
        e.Cancel = true;
        //
        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "USUÁRIO: " + e.NewValues[0].ToString();
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]           ),
                                     new SqlParameter("@tabela"   , fWtabela                                ),
                                     new SqlParameter("@operacao" , "INCLUSÃO"                              ),
                                     new SqlParameter("@obs"      , "INCLUSÃO USUÁRIO"                      ),
                                     new SqlParameter("@acao"     , fwObs_Log                               ) };
        uLog.MakeLog(param_log);
        //
        AtualizaGrid();

    }
    protected void GridListagem_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;
        // Tratamento dos Campos não preenchidos - Não Obrigatórios
        string login = "";
        string senha = "";
        string nome = "";
        string setor = "";
        string funcao = "";
        string fone = "";
        int perfil = 1;
        string email = "";
        string alcada = "";
        Boolean ativo = true;
        //
        //
        try
        {
            login = e.NewValues["Login"].ToString();
        }
        catch (Exception)
        {
            login = " ";
        }
        //
        try
        {
            senha = e.NewValues["Senha"].ToString();
        }
        catch (Exception)
        {
            senha = " ";
        }
        //
        try
        {
            nome = e.NewValues["Nome"].ToString();
        }
        catch (Exception)
        {
            nome = " ";
        }
        //
        try
        {
            setor = e.NewValues["Setor"].ToString();
        }
        catch (Exception)
        {
            setor = " ";
        }
        //
        try
        {
            funcao = e.NewValues["Funcao"].ToString();
        }
        catch (Exception)
        {
            funcao = " ";
        }
        //
        try
        {
            fone = e.NewValues["Fone"].ToString();
        }
        catch (Exception)
        {
            fone = " ";
        }
        //
        try
        {
            email = e.NewValues["email"].ToString();
        }
        catch (Exception)
        {
            email = " ";
        }
        //
        try
        {
            alcada = e.NewValues["alcada"].ToString();
        }
        catch (Exception)
        {
            alcada = " ";
        }
        //
        //Altera
        uUsuario.Altera(login.ToUpper(),
                       senha.ToUpper(),
                       nome,
                       setor,
                       funcao,
                       fone,
                       perfil,
                       email,
                       alcada,
                       ativo);
        //
        //

        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "USUÁRIO: " + e.NewValues[0].ToString();
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]           ),
                                     new SqlParameter("@tabela"   , fWtabela                                ),
                                     new SqlParameter("@operacao" , "ALTERAÇÃO"                             ),
                                     new SqlParameter("@obs"      , "ALTERAÇÃO USUÁRIO"                     ),
                                     new SqlParameter("@acao"     , fwObs_Log                               ) };

        uLog.MakeLog(param_log);
        //
        AtualizaGrid();
    }

    protected void GridListagem_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        uUsuario.Exclui(e.Values["Login"].ToString());
        //

        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "USUÁRIO: " + e.Values[0].ToString();
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]           ),
                                     new SqlParameter("@tabela"   , fWtabela                                ),
                                     new SqlParameter("@operacao" , "EXCLUSÃO"                              ),
                                     new SqlParameter("@obs"      , "EXCLUSÃO USUÁRIO"                      ),
                                     new SqlParameter("@acao"     , fwObs_Log                               ) };

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
        e.NewValues["Perfil"] = "1";
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

    protected void btnGoToCedente_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
    {
        // CRIA LOG  ===============================================================================================================================================
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , "USUARIO"                    ),
                                     new SqlParameter("@operacao" , "CONFIG"                     ),
                                     new SqlParameter("@obs"      , "SELEÇÃO DE USUÁRIOS"        ),
                                     new SqlParameter("@acao"     , "SELEÇÃO USUÁRIO: "+e.CommandArgument.ToString()        ) };
        uLog.MakeLog(param_log);
        // FIM CRIA LOG ============================================================================================================================================


        //
        Session.Remove("wusuario");
        Session.Add("wusuario", e.CommandArgument.ToString());
        Response.Redirect("FConsultaUsuario.aspx");

        //ou

        //    ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( '" + HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpRuntime.AppDomainAppVirtualPath + "/relfact/relatorios/RelRiscoCedenteSacado.aspx', null, 'height=755,width=900,status=yes,resizable=yes,menubar=yes,location=yes' );", true);
    }


}

using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FTabelaProdutos : System.Web.UI.Page
{
    DataSet dsproduto;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "PRODUTO";

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
        dsproduto = uProduto.PegaDadosProduto(0);
        GridListagem.DataSource = dsproduto;
        GridListagem.KeyFieldName = "ID";
        GridListagem.DataBind();
    }

    protected void GridListagem_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
    {
        //Código Original
        ASPxGridView gridView = (ASPxGridView)sender;

        //
        string ID = "";
        string tipo = "";
        string descricao = "";
        string conta = "";
        string cnpj = "";
        string enderecocom = "";
        string enderecocomnumero = "";
        string enderecocomcomplem = "";
        string bairrocom = "";
        string cidadecom = "";
        string ufcom = "";
        string cepcom = "";
        string fone1com = "";
        string fone2com = "";
        string fone3com = "";
        string email1 = "";
        string email2 = "";
        string email3 = "";
        string area = "";
        string situacao_obra = "";
        DateTime habitese = Convert.ToDateTime("01/01/1900");
        decimal cub = 0;
        string obs1 = "";
        string obs2 = "";
        string obs3 = "";
        string obs4 = "";
        string obs5 = "";
        Boolean ativo = false;
        string codpis = "";
        //
        // Empresa
        ID = e.NewValues["ID"].ToString();
        tipo = e.NewValues["tipo"].ToString();
        descricao = e.NewValues["descricao"].ToString().ToUpper();
        conta = e.NewValues["conta"].ToString();
        if (e.NewValues["cnpj"] != null)
            cnpj = e.NewValues["cnpj"].ToString();
        if (e.NewValues["enderecocom"] != null)
            enderecocom = e.NewValues["enderecocom"].ToString();
        if (e.NewValues["enderecocomnumero"] != null)
            enderecocomnumero = e.NewValues["enderecocomnumero"].ToString();
        if (e.NewValues["enderecocomcomplem"] != null)
            enderecocomcomplem = e.NewValues["enderecocomcomplem"].ToString();
        if (e.NewValues["bairrocom"] != null)
            bairrocom = e.NewValues["bairrocom"].ToString();
        if (e.NewValues["cidadecom"] != null)
            cidadecom = e.NewValues["cidadecom"].ToString();
        if (e.NewValues["ufcom"] != null)
            ufcom = e.NewValues["ufcom"].ToString();
        if (e.NewValues["cepcom"] != null)
            cepcom = e.NewValues["cepcom"].ToString();
        if (e.NewValues["fone1com"] != null)
            fone1com = e.NewValues["fone1com"].ToString();
        if (e.NewValues["fone2com"] != null)
            fone2com = e.NewValues["fone2com"].ToString();
        if (e.NewValues["fone3com"] != null)
            fone3com = e.NewValues["fone3com"].ToString();
        if (e.NewValues["email1"] != null)
            email1 = e.NewValues["email1"].ToString();
        if (e.NewValues["email2"] != null)
            email2 = e.NewValues["email2"].ToString();
        if (e.NewValues["email3"] != null)
            email3 = e.NewValues["email3"].ToString();
        if (e.NewValues["area"] != null)
            area = e.NewValues["area"].ToString();
        if (e.NewValues["situacao_obra"] != null)
            situacao_obra = e.NewValues["situacao_obra"].ToString();
        if (e.NewValues["habitese"] != null)
            habitese = Convert.ToDateTime(e.NewValues["habitese"].ToString());
        if (e.NewValues["cub"] != null)
            cub = Convert.ToDecimal(e.NewValues["cub"].ToString());
        if (e.NewValues["obs1"] != null)
            obs1 = e.NewValues["obs1"].ToString();
        if (e.NewValues["obs2"] != null)
            obs2 = e.NewValues["obs2"].ToString();
        if (e.NewValues["obs3"] != null)
            obs3 = e.NewValues["obs3"].ToString();
        if (e.NewValues["obs4"] != null)
            obs4 = e.NewValues["obs4"].ToString();
        if (e.NewValues["obs5"] != null)
            obs5 = e.NewValues["obs5"].ToString();
        if (e.NewValues["ativo"] != null)
            ativo = Convert.ToBoolean(e.NewValues["ativo"].ToString());
        if (e.NewValues["codpis"] != null)
            codpis = e.NewValues["codpis"].ToString();

        uProduto.Grava(ID,
                        tipo,
                        descricao,
                        conta,
                        cnpj,
                        enderecocom,
                        enderecocomnumero,
                        enderecocomcomplem,
                        bairrocom,
                        cidadecom,
                        ufcom,
                        cepcom,
                        fone1com,
                        fone2com,
                        fone3com,
                        email1,
                        email2,
                        email3,
                        area,
                        situacao_obra,
                        habitese,
                        cub,
                        obs1,
                        obs2,
                        obs3,
                        obs4,
                        obs5,
                        ativo,
                        codpis);

        //Código Original
        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "INCLUI EMPRESA: " + "NOVO" + "/" + e.NewValues["descricao"].ToString().ToUpper();
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "PRODUTO"                    ),
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
        string tipo = "";
        string descricao = "";
        string conta = "";
        string cnpj = "";
        string enderecocom = "";
        string enderecocomnumero = "";
        string enderecocomcomplem = "";
        string bairrocom = "";
        string cidadecom = "";
        string ufcom = "";
        string cepcom = "";
        string fone1com = "";
        string fone2com = "";
        string fone3com = "";
        string email1 = "";
        string email2 = "";
        string email3 = "";
        string area = "";
        string situacao_obra = "";
        DateTime habitese = Convert.ToDateTime("01/01/1900");
        decimal cub = 0;
        string obs1 = "";
        string obs2 = "";
        string obs3 = "";
        string obs4 = "";
        string obs5 = "";
        Boolean ativo = false;
        string codpis = "";
        //
        // Empresa
        ID = e.NewValues["ID"].ToString();
        tipo = e.NewValues["tipo"].ToString();
        descricao = e.NewValues["descricao"].ToString();
        conta = e.NewValues["conta"].ToString();
        if (e.NewValues["cnpj"] != null)
            cnpj = e.NewValues["cnpj"].ToString();
        if (e.NewValues["enderecocom"] != null)
            enderecocom = e.NewValues["enderecocom"].ToString();
        if (e.NewValues["enderecocomnumero"] != null)
            enderecocomnumero = e.NewValues["enderecocomnumero"].ToString();
        if (e.NewValues["enderecocomcomplem"] != null)
            enderecocomcomplem = e.NewValues["enderecocomcomplem"].ToString();
        if (e.NewValues["bairrocom"] != null)
            bairrocom = e.NewValues["bairrocom"].ToString();
        if (e.NewValues["cidadecom"] != null)
            cidadecom = e.NewValues["cidadecom"].ToString();
        if (e.NewValues["ufcom"] != null)
            ufcom = e.NewValues["ufcom"].ToString();
        if (e.NewValues["cepcom"] != null)
            cepcom = e.NewValues["cepcom"].ToString();
        if (e.NewValues["fone1com"] != null)
            fone1com = e.NewValues["fone1com"].ToString();
        if (e.NewValues["fone2com"] != null)
            fone2com = e.NewValues["fone2com"].ToString();
        if (e.NewValues["fone3com"] != null)
            fone3com = e.NewValues["fone3com"].ToString();
        if (e.NewValues["email1"] != null)
            email1 = e.NewValues["email1"].ToString();
        if (e.NewValues["email2"] != null)
            email2 = e.NewValues["email2"].ToString();
        if (e.NewValues["email3"] != null)
            email3 = e.NewValues["email3"].ToString();
        if (e.NewValues["area"] != null)
            area = e.NewValues["area"].ToString();
        if (e.NewValues["situacao_obra"] != null)
            situacao_obra = e.NewValues["situacao_obra"].ToString();
        if (e.NewValues["habitese"] != null)
            habitese = Convert.ToDateTime(e.NewValues["habitese"].ToString());
        if (e.NewValues["cub"] != null)
            cub = Convert.ToDecimal(e.NewValues["cub"].ToString());
        if (e.NewValues["obs1"] != null)
            obs1 = e.NewValues["obs1"].ToString();
        if (e.NewValues["obs2"] != null)
            obs2 = e.NewValues["obs2"].ToString();
        if (e.NewValues["obs3"] != null)
            obs3 = e.NewValues["obs3"].ToString();
        if (e.NewValues["obs4"] != null)
            obs4 = e.NewValues["obs4"].ToString();
        if (e.NewValues["obs5"] != null)
            obs5 = e.NewValues["obs5"].ToString();
        if (e.NewValues["ativo"] != null)
            ativo = Convert.ToBoolean(e.NewValues["ativo"]);
        if (e.NewValues["codpis"] != null)
            codpis = e.NewValues["codpis"].ToString();

        uProduto.Altera(ID,
                        tipo,
                        descricao,
                        conta,
                        cnpj,
                        enderecocom,
                        enderecocomnumero,
                        enderecocomcomplem,
                        bairrocom,
                        cidadecom,
                        ufcom,
                        cepcom,
                        fone1com,
                        fone2com,
                        fone3com,
                        email1,
                        email2,
                        email3,
                        area,
                        situacao_obra,
                        habitese,
                        cub,
                        obs1,
                        obs2,
                        obs3,
                        obs4,
                        obs5,
                        ativo,
                        codpis);


        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "ALTERA PRODUTO: " + ID + "/" + descricao;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "PRODUTO"                    ),
                                     new SqlParameter("@obs"      , "ALTERA"                     ),
                                     new SqlParameter("@acao"     , fwObs_Log                    ) };
        uLog.MakeLog(param_log);

        //
        AtualizaGrid();
    }

    protected void GridListagem_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        uProduto.Exclui(e.Values["ID"].ToString());
        //

        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "EXCLUI PRODUTO: " + e.Values["ID"].ToString() + "/" + e.Values["descricao"].ToString().ToUpper();
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "PRODUTO"                    ),
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
        e.NewValues["cub"] = Convert.ToDecimal("0.00");
        e.NewValues["ativo"] = true;
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

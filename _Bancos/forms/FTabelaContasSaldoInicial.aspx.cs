using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FTabelaContasSaldoInicial : System.Web.UI.Page
{
    DataSet dscontas;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "CONTAS_SALDO_INICIAL";

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = SreDblib.TemPermissao("001.008.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.008.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.008.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.008.004.000", (String)Session["CodUsuario"]);
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
        dscontas = uContas.PegaDadosContasSaldoInicial(0);
        GridListagem.DataSource = dscontas;
        GridListagem.KeyFieldName = "ID";
        GridListagem.DataBind();
    }


    protected void GridListagem_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        //
        string ID = "";
        string cod_conta = "";
        string data = "";
        string descricao = "";
        string complemento = "";
        string saldo_i = "";
        string saldo_aplicacaoD = "";
        string saldo_aplicacaoB = "";
        string dtregistro = "";

        //
        // 
        ID = e.NewValues["ID"].ToString();
        cod_conta = e.NewValues["cod_conta"].ToString();
        data = e.NewValues["data"].ToString();
        descricao = e.NewValues["descricao"].ToString();
        saldo_i = e.NewValues["saldo_i"].ToString();
        saldo_aplicacaoD = e.NewValues["saldo_aplicacaoD"].ToString();
        saldo_aplicacaoB = e.NewValues["saldo_aplicacaoB"].ToString();
        dtregistro = e.NewValues["dtregistro"].ToString();
        complemento = e.NewValues["complemento"].ToString();

        //
        //Gravar Saldo Inicial da Conta
        uContas.GravaSaldoInicial(ID,
                                  "01/01/1900",
                                  "SALDO INICIAL",
                                  " ",
                                  saldo_i,
                                  saldo_aplicacaoD,
                                  saldo_aplicacaoB,
                                  DateTime.Now.ToString().Substring(0, 10)
                                  );


        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "INCLUI CONTAS SALDO INICIAL: " + ID + "/" + cod_conta;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "CONTAS SALDO INICIAL"       ),
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
        string cod_conta = "";
        string data = "";
        string descricao = "";
        string complemento = "";
        string saldo_i = "";
        string saldo_aplicacaoD = "";
        string saldo_aplicacaoB = "";
        string dtregistro = "";

        //
        // 
        ID = e.NewValues["ID"].ToString();
        cod_conta = e.NewValues["cod_conta"].ToString();
        data = e.NewValues["data"].ToString().Substring(0, 10);
        if (e.NewValues["descricao"] != null)
        {
            descricao = e.NewValues["descricao"].ToString();
        }
        saldo_i = e.NewValues["saldo_i"].ToString();
        saldo_aplicacaoD = e.NewValues["saldo_aplicacaoD"].ToString();
        saldo_aplicacaoB = e.NewValues["saldo_aplicacaoB"].ToString();
        dtregistro = e.NewValues["dtregistro"].ToString().Substring(0, 10);
        if (e.NewValues["complemento"] != null)
        {
            complemento = e.NewValues["complemento"].ToString();
        }
        uContas.AlteraContaSaldoInicial(ID,
                                        cod_conta,
                                        data,
                                        descricao,
                                        complemento,
                                        saldo_i,
                                        saldo_aplicacaoD,
                                        saldo_aplicacaoB,
                                        dtregistro);

        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "ALTERA CONTAS SALDO INICIAL: " + ID + "/" + cod_conta;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "CONTAS SALDO INICIAL"       ),
                                     new SqlParameter("@obs"      , "ALTERA"                     ),
                                     new SqlParameter("@acao"     , fwObs_Log                    ) };
        uLog.MakeLog(param_log);

        //
        AtualizaGrid();
    }

    protected void GridListagem_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        uContas.ExcluiContaSaldoInicial(e.Values["ID"].ToString());
        //

        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "EXCLUI CONTAS SALDO INICIAL: " + e.Values["ID"].ToString() + "/" + e.Values["cod_conta"].ToString().ToUpper();
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "CONTAS SALDO INICIAL"       ),
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

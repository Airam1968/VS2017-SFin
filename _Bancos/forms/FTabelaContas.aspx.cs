using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FTabelaContas : System.Web.UI.Page
{
    DataSet dscontas;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "CONTAS";

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
        dscontas = uContas.PegaDadosContas(0);
        GridListagem.DataSource = dscontas;
        GridListagem.KeyFieldName = "ID";
        GridListagem.DataBind();
    }


    protected void GridListagem_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        //
        string ID = "";
        string cod_banco = "";
        string cod_agencia = "";
        string cod_conta = "";
        string nome_agencia = "";
        string cidade = "";
        string uf = "";
        string cep = "";
        string limite_cheque = "0";
        string conta_contabil = "";
        string complemento = "";
        string combo = "1";

        //
        // 
        if (e.NewValues["ID"] != null)
        {
            ID = e.NewValues["ID"].ToString();
        }
        else
        {
            ID = uContas.PegaNovoID();
        }
        if (e.NewValues["cod_banco"] != null)
        {
            cod_banco = e.NewValues["cod_banco"].ToString();
        }
        if (e.NewValues["cod_agencia"] != null)
        {
            cod_agencia = e.NewValues["cod_agencia"].ToString();
        }
        if (e.NewValues["cod_conta"] != null)
        {
            cod_conta = e.NewValues["cod_conta"].ToString();
        }
        if (e.NewValues["nome_agencia"] != null)
        {
            nome_agencia = e.NewValues["nome_agencia"].ToString();
        }
        if (e.NewValues["cidade"] != null)
        {
            cidade = e.NewValues["cidade"].ToString();
        }
        if (e.NewValues["uf"] != null)
        {
            uf = e.NewValues["uf"].ToString();
        }
        if (e.NewValues["cep"] != null)
        {
            cep = e.NewValues["cep"].ToString();
        }
        if (e.NewValues["limite_cheque"] != null)
        {
            limite_cheque = e.NewValues["limite_cheque"].ToString();
        }
        if (e.NewValues["conta_contabil"] != null)
        {
            conta_contabil = e.NewValues["conta_contabil"].ToString();
        }
        if (e.NewValues["complemento"] != null)
        {
            complemento = e.NewValues["complemento"].ToString();
        }
        if (e.NewValues["combo"] != null)
        {
            combo = e.NewValues["combo"].ToString();
        }
        //Criar o registro da Conta
        uContas.Grava(ID,
                      cod_banco,
                      cod_agencia,
                      cod_conta,
                      nome_agencia,
                      cidade,
                      uf,
                      cep,
                      limite_cheque,
                      conta_contabil,
                      complemento,
                      combo);

        //Criar arquivo para lançamentos
        uContas.CriarTabelaContasCorrentes(ID);
        //
        //Gravar Saldo Inicial da Conta
        uContas.GravaSaldoInicial(ID,
                                  "01/01/1900",
                                  "SALDO INICIAL",
                                  " ",
                                  Srelib.forcaponto("0.00"),
                                  Srelib.forcaponto("0.00"),
                                  Srelib.forcaponto("0.00"),
                                  DateTime.Now.ToString().Substring(0, 10)
                                  );


        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "INCLUI CONTAS: " + ID + "/" + cod_banco;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "CONTAS"                     ),
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
        string cod_banco = "";
        string cod_agencia = "";
        string cod_conta = "";
        string nome_agencia = "";
        string cidade = "";
        string uf = "";
        string cep = "";
        string limite_cheque = "0";
        string conta_contabil = "";
        string complemento = "";
        string combo = "1";
        //
        // 
        if (e.NewValues["ID"] != null)
        {
            ID = e.NewValues["ID"].ToString();
        }
        if (e.NewValues["cod_banco"] != null)
        {
            cod_banco = e.NewValues["cod_banco"].ToString();
        }
        if (e.NewValues["cod_agencia"] != null)
        {
            cod_agencia = e.NewValues["cod_agencia"].ToString();
        }
        if (e.NewValues["cod_conta"] != null)
        {
            cod_conta = e.NewValues["cod_conta"].ToString();
        }
        if (e.NewValues["nome_agencia"] != null)
        {
            nome_agencia = e.NewValues["nome_agencia"].ToString();
        }
        if (e.NewValues["cidade"] != null)
        {
            cidade = e.NewValues["cidade"].ToString();
        }
        if (e.NewValues["uf"] != null)
        {
            uf = e.NewValues["uf"].ToString();
        }
        if (e.NewValues["cep"] != null)
        {
            cep = e.NewValues["cep"].ToString();
        }
        if (e.NewValues["limite_cheque"] != null)
        {
            limite_cheque = e.NewValues["limite_cheque"].ToString();
        }
        if (e.NewValues["conta_contabil"] != null)
        {
            conta_contabil = e.NewValues["conta_contabil"].ToString();
        }
        if (e.NewValues["complemento"] != null)
        {
            complemento = e.NewValues["complemento"].ToString();
        }
        if (e.NewValues["combo"] != null)
        {
            combo = e.NewValues["combo"].ToString();
        }

        uContas.AlteraConta(ID,
                            cod_banco,
                            cod_agencia,
                            cod_conta,
                            nome_agencia,
                            cidade,
                            uf,
                            cep,
                            limite_cheque,
                            conta_contabil,
                            complemento,
                            combo);

        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "ALTERA CONTAS: " + ID + "/" + cod_banco;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "CONTAS"                     ),
                                     new SqlParameter("@obs"      , "ALTERA"                     ),
                                     new SqlParameter("@acao"     , fwObs_Log                    ) };
        uLog.MakeLog(param_log);

        //
        AtualizaGrid();
    }

    protected void GridListagem_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        uContas.ExcluiConta(e.Values["ID"].ToString());
        //

        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "EXCLUI CONTAS: " + e.Values["ID"].ToString() + "/" + e.Values["cod_banco"].ToString().ToUpper();
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "CONTAS"                     ),
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
        e.NewValues["ID"] = uContas.PegaNovoID();
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

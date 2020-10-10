using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FTabelaBancos : System.Web.UI.Page
{
    DataSet dsbancos;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "BANCOS";

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
        dsbancos = uBanco.PegaDadosBancos(0);
        GridListagem.DataSource = dsbancos;
        GridListagem.KeyFieldName = "cod_banco";
        GridListagem.DataBind();
    }


    protected void GridListagem_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        //
        string ID = "";
        string cod_banco = "";
        string nome = "";
        DateTime data;
        string drive = "";
        string pasta_remessa = "";
        string pasta_retorno = "";
        string pasta_envelope = "";
        string assunto = "";
        string caixa_postal = "";
        string mascara_remessa = "";
        string mascara_retorno = "";
        string nome_arquivo = "";
        string numero_arquivo = "";
        string prazo_fol = "";
        string prazo_dev = "";
        string prazo_pro = "";
        string multa = "";
        string juros = "";
        string comissao = "";
        string carteira = "";
        string num_inicial = "";
        string num_final = "";
        string sequencia = "";
        string numero_atual = "";
        string complemento = "";

        //
        // 
        ID = e.NewValues["ID"].ToString();
        cod_banco = e.NewValues["cod_banco"].ToString();
        nome = e.NewValues["nome"].ToString();
        data = Convert.ToDateTime(e.NewValues["data"].ToString().Substring(0, 10));
        //drive = e.NewValues["drive"].ToString();
        //pasta_remessa = e.NewValues["pasta_remessa"].ToString();
        //pasta_retorno = e.NewValues["pasta_retorno"].ToString();
        //pasta_envelope = e.NewValues["pasta_envelope"].ToString();
        //assunto = e.NewValues["assunto"].ToString();
        //caixa_postal = e.NewValues["caixa_postal"].ToString();
        //mascara_remessa = e.NewValues["mascara_remessa"].ToString();
        //mascara_retorno = e.NewValues["mascara_retorno"].ToString();
        //prazo_fol = e.NewValues["prazo_fol"].ToString();
        //prazo_dev = e.NewValues["prazo_dev"].ToString();
        //prazo_pro = e.NewValues["prazo_pro"].ToString();
        //multa = e.NewValues["multa"].ToString();
        //juros = e.NewValues["juros"].ToString();
        //comissao = e.NewValues["comissao"].ToString();
        //carteira = e.NewValues["carteira"].ToString();
        //num_inicial = e.NewValues["num_inicial"].ToString();
        //num_final = e.NewValues["num_final"].ToString();
        //sequencia = e.NewValues["sequencia"].ToString();
        //numero_atual = e.NewValues["numero_atual"].ToString();
        //complemento = e.NewValues["complemento"].ToString();


        uBanco.Grava(cod_banco,
                    nome,
                    data,
                    drive,
                    pasta_remessa,
                    pasta_retorno,
                    pasta_envelope,
                    assunto,
                    caixa_postal,
                    mascara_remessa,
                    mascara_retorno,
                    nome_arquivo,
                    numero_arquivo,
                    prazo_fol,
                    prazo_dev,
                    prazo_pro,
                    multa,
                    juros,
                    comissao,
                    carteira,
                    num_inicial,
                    num_final,
                    sequencia,
                    numero_atual,
                    complemento
                    );


        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "INCLUI BANCOS: " + cod_banco + "/" + nome;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "BANCOS"                     ),
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
        string nome = "";
        DateTime data;
        string drive = "";
        string pasta_remessa = "";
        string pasta_retorno = "";
        string pasta_envelope = "";
        string assunto = "";
        string caixa_postal = "";
        string mascara_remessa = "";
        string mascara_retorno = "";
        string nome_arquivo = "";
        string numero_arquivo = "";
        string prazo_fol = "";
        string prazo_dev = "";
        string prazo_pro = "";
        string multa = "";
        string juros = "";
        string comissao = "";
        string carteira = "";
        string num_inicial = "";
        string num_final = "";
        string sequencia = "";
        string numero_atual = "";
        string complemento = "";
        //
        // 
        // 
        ID = e.NewValues["ID"].ToString();
        cod_banco = e.NewValues["cod_banco"].ToString();
        nome = e.NewValues["nome"].ToString();
        data = Convert.ToDateTime(e.NewValues["data"].ToString().Substring(0, 10));
        //drive = e.NewValues["drive"].ToString();
        //pasta_remessa = e.NewValues["pasta_remessa"].ToString();
        //pasta_retorno = e.NewValues["pasta_retorno"].ToString();
        //pasta_envelope = e.NewValues["pasta_envelope"].ToString();
        //assunto = e.NewValues["assunto"].ToString();
        //caixa_postal = e.NewValues["caixa_postal"].ToString();
        //mascara_remessa = e.NewValues["mascara_remessa"].ToString();
        //mascara_retorno = e.NewValues["mascara_retorno"].ToString();
        //prazo_fol = e.NewValues["prazo_fol"].ToString();
        //prazo_dev = e.NewValues["prazo_dev"].ToString();
        //prazo_pro = e.NewValues["prazo_pro"].ToString();
        //multa = e.NewValues["multa"].ToString();
        //juros = e.NewValues["juros"].ToString();
        //comissao = e.NewValues["comissao"].ToString();
        //carteira = e.NewValues["carteira"].ToString();
        //num_inicial = e.NewValues["num_inicial"].ToString();
        //num_final = e.NewValues["num_final"].ToString();
        //sequencia = e.NewValues["sequencia"].ToString();
        //numero_atual = e.NewValues["numero_atual"].ToString();
        //complemento = e.NewValues["complemento"].ToString();

        uBanco.AlteraBanco(ID,
                           cod_banco,
                           nome,
                           data,
                           drive,
                           pasta_remessa,
                           pasta_retorno,
                           pasta_envelope,
                           assunto,
                           caixa_postal,
                           mascara_remessa,
                           mascara_retorno,
                           nome_arquivo,
                           numero_arquivo,
                           prazo_fol,
                           prazo_dev,
                           prazo_pro,
                           multa,
                           juros,
                           comissao,
                           carteira,
                           num_inicial,
                           num_final,
                           sequencia,
                           numero_atual,
                           complemento);


        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "ALTERA BANCOS: " + cod_banco + "/" + nome;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "BANCOS"                     ),
                                     new SqlParameter("@obs"      , "ALTERA"                     ),
                                     new SqlParameter("@acao"     , fwObs_Log                    ) };
        uLog.MakeLog(param_log);

        //
        AtualizaGrid();
    }

    protected void GridListagem_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        uBanco.ExcluiBanco(e.Values["ID"].ToString());
        //

        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "EXCLUI BANCOS: " + e.Values["codigo"].ToString() + "/" + e.Values["descricao"].ToString().ToUpper();
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "BANCOS"                     ),
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

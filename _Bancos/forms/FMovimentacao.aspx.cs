using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FMovimentacao : System.Web.UI.Page
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
        lInsere = false; // SreDblib.TemPermissao("001.008.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.008.002.000", (String)Session["CodUsuario"]);
        lExclui = false; // SreDblib.TemPermissao("001.008.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.008.004.000", (String)Session["CodUsuario"]);
        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        //
        btprocessa.Enabled = lAltera;
        if (!lAltera)
            btprocessa.Image.ToolTip = Msg_acesso;
        lAltera = false;
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
            GridListagem.Visible = false;
            //
            //Combo Contas Correntes
            cbcontascorrentes.Items.Clear();
            uContas.MontaComboContas(cbcontascorrentes, "0");
            Label16.Visible = true;
            cbcontascorrentes.Visible = true;
            //
            Label4.Visible = true;
            dtprevisao1.Visible = true;
            Label5.Visible = true;
            dtprevisao2.Visible = true;
            //
            dtprevisao1.Date = Convert.ToDateTime("01/01/1900");
            dtprevisao2.Date = Convert.ToDateTime("31/12/2999");
        }

    }


    protected void cbproduto_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        //if (cbproduto.Text != string.Empty)
        //{
        //    //Combo Grupo
        //    cbdespesa.Items.Clear();
        //    uDespesas.MontaComboDespesas(cbdespesa, "0", true);
        //    Label2.Visible = true;
        //    cbdespesa.Visible = true;
        //    GridListagem.Visible = false;
        //}
        //else
        //{
        //    Label2.Visible = false;
        //    cbdespesa.Visible = false;
        //    GridListagem.Visible = false;
        //}

    }

    private void AtualizaGrid()
    {
        string cbcontascorrentes2 = "";
        DateTime dtprevisao11 = Convert.ToDateTime("01/01/1900");
        DateTime dtprevisao22 = Convert.ToDateTime("31/12/2999");
        //
        if (cbcontascorrentes.Value != null)
        {
            cbcontascorrentes2 = cbcontascorrentes.Value.ToString().Trim();
        }
        //
        if (dtprevisao1.Value != null)
        {
            dtprevisao11 = dtprevisao1.Date;
        }

        if (dtprevisao2.Value != null)
        {
            dtprevisao22 = dtprevisao2.Date;
        }
        // 

        dscontas = uContas.PegaDadosConta(cbcontascorrentes2,
                                          Convert.ToString(dtprevisao11).Substring(0,10),
                                          Convert.ToString(dtprevisao22).Substring(0,10));
        decimal saldo = 0;
        decimal limite = 0;
        decimal saldolimite = 0;
        decimal aplicdesbloqueada = 0;
        decimal aplicbloqueada = 0;
        decimal saldofinaltotal = 0;

        limite = Convert.ToDecimal(uContas.PegaLimite(cbcontascorrentes2));
        saldo = Convert.ToDecimal(dscontas.Tables[0].Rows[dscontas.Tables[0].Rows.Count - 1]["saldo_f"]);
        saldolimite = saldo + limite;
        aplicdesbloqueada = Convert.ToDecimal(dscontas.Tables[0].Rows[dscontas.Tables[0].Rows.Count - 1]["saldo_aplicacaoD"]);
        aplicbloqueada = Convert.ToDecimal(dscontas.Tables[0].Rows[dscontas.Tables[0].Rows.Count - 1]["saldo_aplicacaoB"]);
        saldofinaltotal = saldolimite + aplicbloqueada + aplicdesbloqueada;

        Label14.Text = "Saldo Em " + dscontas.Tables[0].Rows[dscontas.Tables[0].Rows.Count-1]["data"].ToString().Substring(0, 10);
        edsaldot.Text = saldo.ToString();
        //
        edsaldofinallimitet.Text = saldolimite.ToString();
        //
        edaplicdesbloqueadat.Text = aplicbloqueada.ToString();
        edaplicbloqueadat.Text = aplicdesbloqueada.ToString();
        edsaldofinalt.Text = saldofinaltotal.ToString();


        //for (int i = 0; i < dscreceber.Tables[0].Rows.Count; i++)
        //{
        //    totvlrprevisto = totvlrprevisto + Convert.ToDecimal(dscreceber.Tables[0].Rows[i]["vlr_previsto"]);
        //    totqtdprevisto = totqtdprevisto + 1;
        //    totvlrrealizado = totvlrrealizado + Convert.ToDecimal(dscreceber.Tables[0].Rows[i]["vlr_realizado"]);
        //    totqtdrealizado = totqtdrealizado + 1;
        //}

        //edvlrtotalprevisto.Text =  Convert.ToString(totvlrprevisto);
        //edqtdtotalprevisto.Text =  Convert.ToString(totqtdprevisto);
        //edvlrtotalrealizado.Text = Convert.ToString(totvlrrealizado);
        //edqtdtotalrealizado.Text = Convert.ToString(totqtdrealizado);

        GridListagem.DataSource = dscontas;
        GridListagem.KeyFieldName = "data";
        GridListagem.DataBind();
        GridListagem.Focus();
        //btprocessa.Enabled = false;


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

    protected void btprocessa_Click(object sender, EventArgs e)
    {
        Boolean lOk = true;
        //

        if (lOk)
        {
            //Todas
            if (cbcontascorrentes.Text != "")
            {
                GridListagem.Visible = true;
                AtualizaGrid();

            }

        }

    }

    protected void GridListagem_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
    {
        //Código Original
        //ASPxGridView gridView = (ASPxGridView)sender;

        ////
        //string apelido = "";
        //string nome = "";
        //string cnpj = "";
        //string inscmunicipal = "";
        //string inscestadual = "";
        //string regjuntacom = "";
        //string nire = "";
        //string enderecocom = "";
        //string enderecocomnumero = "";
        //string enderecocomcomplem = "";
        //string bairrocom = "";
        //string cidadecom = "";
        //string ufcom = "";
        //string cepcom = "";
        //string fone1com = "";
        //string fone2com = "";
        //string fone3com = "";
        //string email1 = "";
        //string email2 = "";
        //string email3 = "";
        //string email4 = "";
        //string email5 = "";
        //string gerente = "";
        //string contato = "";
        //DateTime dtnascimento = Convert.ToDateTime("01/01/1900");
        //DateTime dtingresso = Convert.ToDateTime("01/01/1900");
        //string ncontrato = "";
        //DateTime dtcontrato = Convert.ToDateTime("01/01/1900");
        //Boolean ativo = true;
        //Boolean acessointernet = true;
        //string obs1 = "";
        //string obs2 = "";
        //string obs3 = "";
        //string obs4 = "";
        //string obs5 = "";
        //string instrcob1 = "";
        //string instrcob2 = "";
        //string diasprotesto = "";
        //string conta1 = "";
        //string conta2 = "";
        //string conta3 = "";
        //string conta4 = "";
        //string conta5 = "";
        ////
        //// Empresa
        //apelido = e.NewValues["apelido"].ToString().ToUpper();
        //nome = e.NewValues["nome"].ToString().ToUpper();
        //cnpj = e.NewValues["cnpj"].ToString();
        //if (e.NewValues["inscmunicipal"] != null)
        //    inscmunicipal = e.NewValues["inscmunicipal"].ToString();
        //if (e.NewValues["inscestadual"] != null)
        //    inscestadual = e.NewValues["inscestadual"].ToString();
        //if (e.NewValues["regjuntacom"] != null)
        //    regjuntacom = e.NewValues["regjuntacom"].ToString();
        //if (e.NewValues["nire"] != null)
        //    nire = e.NewValues["nire"].ToString();
        //if (e.NewValues["enderecocom"] != null)
        //    enderecocom = e.NewValues["enderecocom"].ToString();
        //if (e.NewValues["enderecocomnumero"] != null)
        //    enderecocomnumero = e.NewValues["enderecocomnumero"].ToString();
        //if (e.NewValues["enderecocomcomplem"] != null)
        //    enderecocomcomplem = e.NewValues["enderecocomcomplem"].ToString();
        //if (e.NewValues["bairrocom"] != null)
        //    bairrocom = e.NewValues["bairrocom"].ToString();
        //if (e.NewValues["cidadecom"] != null)
        //    cidadecom = e.NewValues["cidadecom"].ToString();
        //if (e.NewValues["ufcom"] != null)
        //    ufcom = e.NewValues["ufcom"].ToString();
        //if (e.NewValues["cepcom"] != null)
        //    cepcom = e.NewValues["cepcom"].ToString();
        //if (e.NewValues["fone1com"] != null)
        //    fone1com = e.NewValues["fone1com"].ToString();
        //if (e.NewValues["fone2com"] != null)
        //    fone2com = e.NewValues["fone2com"].ToString();
        //if (e.NewValues["fone3com"] != null)
        //    fone3com = e.NewValues["fone3com"].ToString();
        //if (e.NewValues["email1"] != null)
        //    email1 = e.NewValues["email1"].ToString();
        //if (e.NewValues["email2"] != null)
        //    email2 = e.NewValues["email2"].ToString();
        //if (e.NewValues["email3"] != null)
        //    email3 = e.NewValues["email3"].ToString();
        //if (e.NewValues["email4"] != null)
        //    email4 = e.NewValues["email4"].ToString();
        //if (e.NewValues["email5"] != null)
        //    email5 = e.NewValues["email5"].ToString();
        //if (e.NewValues["gerente"] != null)
        //    gerente = e.NewValues["gerente"].ToString();
        //if (e.NewValues["contato"] != null)
        //    contato = e.NewValues["contato"].ToString();
        //if (e.NewValues["dtnascimento"] != null)
        //    dtnascimento = Convert.ToDateTime(e.NewValues["dtnascimento"].ToString());
        //if (e.NewValues["dtingresso"] != null)
        //    dtingresso = Convert.ToDateTime(e.NewValues["dtingresso"].ToString());
        //if (e.NewValues["ncontrato"] != null)
        //    ncontrato = e.NewValues["ncontrato"].ToString();
        //if (e.NewValues["dtcontrato"] != null)
        //    dtcontrato = Convert.ToDateTime(e.NewValues["dtcontrato"].ToString());
        //if (e.NewValues["ativo"] != null)
        //    ativo = Convert.ToBoolean(e.NewValues["ativo"].ToString());
        //if (e.NewValues["acessointernet"] != null)
        //    acessointernet = Convert.ToBoolean(e.NewValues["acessointernet"].ToString());
        //if (e.NewValues["obs1"] != null)
        //    obs1 = e.NewValues["obs1"].ToString();
        //if (e.NewValues["obs2"] != null)
        //    obs2 = e.NewValues["obs2"].ToString();
        //if (e.NewValues["obs3"] != null)
        //    obs3 = e.NewValues["obs3"].ToString();
        //if (e.NewValues["obs4"] != null)
        //    obs4 = e.NewValues["obs4"].ToString();
        //if (e.NewValues["obs5"] != null)
        //    obs5 = e.NewValues["obs5"].ToString();
        //if (e.NewValues["instrcob1"] != null)
        //    instrcob1 = e.NewValues["instrcob1"].ToString();
        //if (e.NewValues["instrcob2"] != null)
        //    instrcob2 = e.NewValues["instrcob2"].ToString();
        //if (e.NewValues["diasprotesto"] != null)
        //    diasprotesto = e.NewValues["diasprotesto"].ToString();
        //if (e.NewValues["conta1"] != null)
        //    conta1 = e.NewValues["conta1"].ToString();
        //if (e.NewValues["conta2"] != null)
        //    conta2 = e.NewValues["conta2"].ToString();
        //if (e.NewValues["conta3"] != null)
        //    conta3 = e.NewValues["conta3"].ToString();
        //if (e.NewValues["conta4"] != null)
        //    conta4 = e.NewValues["conta4"].ToString();
        //if (e.NewValues["conta5"] != null)
        //    conta5 = e.NewValues["conta5"].ToString();

        //uEmpresa.Grava(apelido,
        //               nome,
        //               cnpj,
        //               inscmunicipal,
        //               inscestadual,
        //               regjuntacom,
        //               nire,
        //               enderecocom,
        //               enderecocomnumero,
        //               enderecocomcomplem,
        //               bairrocom,
        //               cidadecom,
        //               ufcom,
        //               cepcom,
        //               fone1com,
        //               fone2com,
        //               fone3com,
        //               email1,
        //               email2,
        //               email3,
        //               email4,
        //               email5,
        //               gerente,
        //               contato,
        //               dtnascimento,
        //               dtingresso,
        //               ncontrato,
        //               dtcontrato,
        //               ativo,
        //               acessointernet,
        //               obs1,
        //               obs2,
        //               obs3,
        //               obs4,
        //               obs5,
        //               instrcob1,
        //               instrcob2,
        //               diasprotesto,
        //               conta1,
        //               conta2,
        //               conta3,
        //               conta4,
        //               conta5);

        ////Código Original
        //gridView.CancelEdit();
        //e.Cancel = true;

        ////Usando Classe uLog.MakeLog - Gravando Log
        //fwObs_Log = "INCLUI EMPRESA: " + "NOVO" + "/" + e.NewValues["apelido"].ToString().ToUpper();
        //SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
        //                             new SqlParameter("@tabela"   , fWtabela                     ),
        //                             new SqlParameter("@operacao" , "EMPRESA"                    ),
        //                             new SqlParameter("@obs"      , "INCLUI"                     ),
        //                             new SqlParameter("@acao"     , fwObs_Log                    ) };
        //uLog.MakeLog(param_log);
        //
        //AtualizaGrid("T");

    }
    protected void GridListagem_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
    {
        //ASPxGridView gridView = (ASPxGridView)sender;

        ////
        //string produto = "";
        //string grupo = "";
        //string unidade = "";
        //string parte = "";
        //decimal metragem_total = 0;
        //decimal vlr_total = 0;
        //decimal vlr_1 = 0;
        //decimal metragem_1 = 0;
        //string inscricao_1 = "";
        //string proprietario_1 = "";
        //Boolean quitado_1 = false;
        //Boolean escritura_1 = false;
        //DateTime dtescritura_1 = Convert.ToDateTime("01/01/1900");
        //string cartorio_1 = "";
        //string livro_1 = "";
        //string folha_1 = "";
        //Boolean processo_1 = false;
        //string obs_1 = "";
        //decimal vlr_2 = 0;
        //decimal metragem_2 = 0;
        //string inscricao_2 = "";
        //string proprietario_2 = "";
        //Boolean quitado_2 = false;
        //Boolean escritura_2 = false;
        //DateTime dtescritura_2 = Convert.ToDateTime("01/01/1900");
        //string cartorio_2 = "";
        //string livro_2 = "";
        //string folha_2 = "";
        //Boolean processo_2 = false;
        //string obs_2 = "";
        ////
        //// Empresa
        //ID = e.NewValues["ID"].ToString();
        //produto = e.NewValues["produto"].ToString();
        //grupo = e.NewValues["grupo"].ToString();
        //unidade = e.NewValues["unidade"].ToString();
        //parte = e.NewValues["parte"].ToString();
        //if (e.NewValues["metragem_total"] != null)
        //    metragem_total = Convert.ToDecimal(e.NewValues["metragem_total"].ToString());
        //if (e.NewValues["vlr_total"] != null)
        //    vlr_total = Convert.ToDecimal(e.NewValues["vlr_total"].ToString());
        //if (e.NewValues["vlr_1"] != null)
        //    vlr_1 = Convert.ToDecimal(e.NewValues["vlr_1"].ToString());
        //if (e.NewValues["metragem_1"] != null)
        //    metragem_1 = Convert.ToDecimal(e.NewValues["metragem_1"].ToString());
        //if (e.NewValues["inscricao_1"] != null)
        //    inscricao_1 = e.NewValues["inscricao_1"].ToString();
        //if (e.NewValues["proprietario_1"] != null)
        //    proprietario_1 = e.NewValues["proprietario_1"].ToString();
        //if (e.NewValues["quitado_1"] != null)
        //    quitado_1 = Convert.ToBoolean(e.NewValues["quitado_1"].ToString());
        //if (e.NewValues["escritura_1"] != null)
        //    escritura_1 = Convert.ToBoolean(e.NewValues["escritura_1"].ToString());
        //if (e.NewValues["dtescritura_1"] != null)
        //    dtescritura_1 = Convert.ToDateTime(e.NewValues["dtescritura_1"].ToString());
        //if (e.NewValues["cartorio_1"] != null)
        //    cartorio_1 = e.NewValues["cartorio_1"].ToString();
        //if (e.NewValues["livro_1"] != null)
        //    livro_1 = e.NewValues["livro_1"].ToString();
        //if (e.NewValues["folha_1"] != null)
        //    folha_1 = e.NewValues["folha_1"].ToString();
        //if (e.NewValues["processo_1"] != null)
        //    processo_1 = Convert.ToBoolean(e.NewValues["processo_1"].ToString());
        //if (e.NewValues["obs_1"] != null)
        //    obs_1 = e.NewValues["obs_1"].ToString();
        //if (e.NewValues["vlr_2"] != null)
        //    vlr_2 = Convert.ToDecimal(e.NewValues["vlr_2"].ToString());
        //if (e.NewValues["metragem_2"] != null)
        //    metragem_2 = Convert.ToDecimal(e.NewValues["metragem_2"].ToString());
        //if (e.NewValues["inscricao_2"] != null)
        //    inscricao_2 = e.NewValues["inscricao_2"].ToString();
        //if (e.NewValues["proprietario_2"] != null)
        //    proprietario_2 = e.NewValues["proprietario_2"].ToString();
        //if (e.NewValues["quitado_2"] != null)
        //    quitado_2 = Convert.ToBoolean(e.NewValues["quitado_2"].ToString());
        //if (e.NewValues["escritura_2"] != null)
        //    escritura_2 = Convert.ToBoolean(e.NewValues["escritura_2"].ToString());
        //if (e.NewValues["dtescritura_2"] != null)
        //    dtescritura_2 = Convert.ToDateTime(e.NewValues["dtescritura_2"].ToString());
        //if (e.NewValues["cartorio_2"] != null)
        //    cartorio_2 = e.NewValues["cartorio_2"].ToString();
        //if (e.NewValues["livro_2"] != null)
        //    livro_2 = e.NewValues["livro_2"].ToString();
        //if (e.NewValues["folha_2"] != null)
        //    folha_2 = e.NewValues["folha_2"].ToString();
        //if (e.NewValues["processo_2"] != null)
        //    processo_2 = Convert.ToBoolean(e.NewValues["processo_2"].ToString());
        //if (e.NewValues["obs_2"] != null)
        //    obs_2 = e.NewValues["obs_2"].ToString();

        //uUnidade.Altera(ID,
        //                produto,
        //                grupo,
        //                unidade,
        //                parte,
        //                metragem_total,
        //                vlr_total,
        //                vlr_1,
        //                metragem_1,
        //                inscricao_1,
        //                proprietario_1,
        //                Convert.ToInt16(quitado_1),
        //                Convert.ToInt16(escritura_1),
        //                Convert.ToString(dtescritura_1).Substring(0, 10),
        //                cartorio_1,
        //                livro_1,
        //                folha_1,
        //                Convert.ToInt16(processo_1),
        //                obs_1,
        //                vlr_2,
        //                metragem_2,
        //                inscricao_2,
        //                proprietario_2,
        //                Convert.ToInt16(quitado_2),
        //                Convert.ToInt16(escritura_2),
        //                Convert.ToString(dtescritura_2).Substring(0, 10),
        //                cartorio_2,
        //                livro_2,
        //                folha_2,
        //                Convert.ToInt16(processo_2),
        //                obs_2);


        //gridView.CancelEdit();
        //e.Cancel = true;

        ////Usando Classe uLog.MakeLog - Gravando Log
        //fwObs_Log = "ALTERA PRODUTO UNIDADE: " + produto + "/" + grupo + "/" + unidade + "/" + parte;
        //SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
        //                             new SqlParameter("@tabela"   , fWtabela                     ),
        //                             new SqlParameter("@operacao" , "PRODUTO UNIDADE"            ),
        //                             new SqlParameter("@obs"      , "ALTERA"                     ),
        //                             new SqlParameter("@acao"     , fwObs_Log                    ) };
        //uLog.MakeLog(param_log);

        ////
        //AtualizaGrid("T");
    }

    protected void GridListagem_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
    {
        //ASPxGridView gridView = (ASPxGridView)sender;

        //uEmpresa.Exclui(e.Values["ID"].ToString());
        ////

        //gridView.CancelEdit();
        //e.Cancel = true;

        ////Usando Classe uLog.MakeLog - Gravando Log
        //fwObs_Log = "EXCLUI EMPRESA: " + e.Values["ID"].ToString() + "/" + e.Values["apelido"].ToString().ToUpper();
        //SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
        //                             new SqlParameter("@tabela"   , fWtabela                     ),
        //                             new SqlParameter("@operacao" , "EMPRESA"                    ),
        //                             new SqlParameter("@obs"      , "EXCLUI"                     ),
        //                             new SqlParameter("@acao"     , fwObs_Log                    ) };
        //uLog.MakeLog(param_log);
        //
        //AtualizaGrid("T");

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
        //e.NewValues["dtnascimento"] = Convert.ToDateTime("01/01/1900");
        //e.NewValues["dtingresso"] = DateTime.Now;
        //e.NewValues["dtcontrato"] = Convert.ToDateTime("01/01/1900");
        //e.NewValues["ativo"] = true;
        //e.NewValues["acessointernet"] = true;
        //e.NewValues["gerente"] = "GERAL";
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

    protected void cbcontascorrentes_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        string cbcontascorrentes2 = "";
        //
        if (cbcontascorrentes.Value != null)
        {
            cbcontascorrentes2 = cbcontascorrentes.Value.ToString().Trim();
        }
        dtprevisao1.Value = uContas.PegaDataInicial(cbcontascorrentes2);
    }
}

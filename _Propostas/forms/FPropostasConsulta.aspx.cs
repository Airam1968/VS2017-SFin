using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FPropostasConsulta : System.Web.UI.Page
{
    DataSet dsunidade;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "PROPOSTAS";

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = SreDblib.TemPermissao("001.001.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.001.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.001.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.001.004.000", (String)Session["CodUsuario"]);
        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        //
        GridListagem.Enabled = lConsulta;
        if (!lConsulta)
        {
            GridListagem.ToolTip = Msg_acesso;
        }
        //
        lInsere = false;
        lAltera = false;
        lExclui = false;
        lConsulta = false; 
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
            //Combo Empresas
            cbproduto.Items.Clear();
            uProduto.MontaComboProduto(cbproduto, true);
        }

    }


    protected void cbproduto_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        if (cbproduto.Text != string.Empty)
        {
            //Combo Grupo
            //string tipo = "";
            cbgrupo.Items.Clear();
            //tipo = uProduto.PegaTipo(Convert.ToInt32(cbproduto.Value));
            uProduto.MontaComboGrupo(cbgrupo, Convert.ToString(cbproduto.Value).Trim(), true);
            Label2.Visible = true;
            cbgrupo.Visible = true;
            GridListagem.Visible = false;
        }
        else
        {
            Label2.Visible = false;
            cbgrupo.Visible = false;
            GridListagem.Visible = false;
        }

    }

    private void AtualizaGrid()
    {
        //
        if (ednome.Text == string.Empty)
        {
            dsunidade = uProposta.PegaDadosPropostas(cbproduto.Value.ToString().Trim(), cbgrupo.Value.ToString().Trim());
            GridListagem.DataSource = dsunidade;
            GridListagem.KeyFieldName = "proposta";
            GridListagem.DataBind();
        }
        else
        {
            dsunidade = uProposta.PegaDadosPropostasnome(ednome.Text.Trim());
            GridListagem.DataSource = dsunidade;
            GridListagem.KeyFieldName = "proposta";
            GridListagem.DataBind();
        }
    }

    protected void cbgrupo_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        if (cbproduto.Text != string.Empty)
        {
            if (cbgrupo.Text != string.Empty)
            {
                AtualizaGrid();
                GridListagem.Visible = true;
                //
                Label5.Visible = true;
                Label4.Visible = true;
                ednome.Visible = true;
            }
            else
            {
                Label2.Visible = false;
                cbgrupo.Visible = true;
                GridListagem.Visible = false;
                //
                Label5.Visible = false;
                Label4.Visible = false;
                ednome.Visible = false;
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
        AtualizaGrid();

    }
    protected void GridListagem_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        //
        string produto = "";
        string grupo = "";
        string unidade = "";
        string parte = "";
        decimal metragem_total = 0;
        decimal vlr_total = 0;
        decimal vlr_1 = 0;
        decimal metragem_1 = 0;
        string inscricao_1 = "";
        string proprietario_1 = "";
        Boolean quitado_1 = false;
        Boolean escritura_1 = false;
        DateTime dtescritura_1 = Convert.ToDateTime("01/01/1900");
        string cartorio_1 = "";
        string livro_1 = "";
        string folha_1 = "";
        Boolean processo_1 = false;
        string obs_1 = "";
        decimal vlr_2 = 0;
        decimal metragem_2 = 0;
        string inscricao_2 = "";
        string proprietario_2 = "";
        Boolean quitado_2 = false;
        Boolean escritura_2 = false;
        DateTime dtescritura_2 = Convert.ToDateTime("01/01/1900");
        string cartorio_2 = "";
        string livro_2 = "";
        string folha_2 = "";
        Boolean processo_2 = false;
        string obs_2 = "";
        //
        decimal area_privativa_coletiva_m2 = 0;
        decimal area_privativa_terraco_coberto_m2 = 0;
        decimal area_privativa_terraco_descoberto_m2 = 0;
        decimal area_comum_m2 = 0;
        decimal area_garagem_m2 = 0;
        decimal area_hobby_box_m2 = 0;
        decimal area_total_m2 = 0;
        decimal fracao_ideal_m2 = 0;
        decimal fracao_ideal_percentual = 0;
        string hobby_box_numero = "";
        string hobby_box_localizacao = "";
        string numero_garagem_01 = "";
        string numero_garagem_02 = "";
        string numero_garagem_03 = "";
        string numero_garagem_04 = "";
        string numero_garagem_05 = "";
        string vagas_localizacao = "";
        Int16 vagas_quantidade = 0;
        //
        //
        // Empresa
        ID = e.NewValues["ID"].ToString();
        produto = e.NewValues["produto"].ToString();
        grupo = e.NewValues["grupo"].ToString();
        unidade = e.NewValues["unidade"].ToString();
        parte = e.NewValues["parte"].ToString();
        if (e.NewValues["metragem_total"] != null)
            metragem_total = Convert.ToDecimal(e.NewValues["metragem_total"].ToString());
        if (e.NewValues["vlr_total"] != null)
            vlr_total = Convert.ToDecimal(e.NewValues["vlr_total"].ToString());
        if (e.NewValues["vlr_1"] != null)
            vlr_1 = Convert.ToDecimal(e.NewValues["vlr_1"].ToString());
        if (e.NewValues["metragem_1"] != null)
            metragem_1 = Convert.ToDecimal(e.NewValues["metragem_1"].ToString());
        if (e.NewValues["inscricao_1"] != null)
            inscricao_1 = e.NewValues["inscricao_1"].ToString();
        if (e.NewValues["proprietario_1"] != null)
            proprietario_1 = e.NewValues["proprietario_1"].ToString();
        if (e.NewValues["quitado_1"] != null)
            quitado_1 = Convert.ToBoolean(e.NewValues["quitado_1"].ToString());
        if (e.NewValues["escritura_1"] != null)
            escritura_1 = Convert.ToBoolean(e.NewValues["escritura_1"].ToString());
        if (e.NewValues["dtescritura_1"] != null)
            dtescritura_1 = Convert.ToDateTime(e.NewValues["dtescritura_1"].ToString());
        if (e.NewValues["cartorio_1"] != null)
            cartorio_1 = e.NewValues["cartorio_1"].ToString();
        if (e.NewValues["livro_1"] != null)
            livro_1 = e.NewValues["livro_1"].ToString();
        if (e.NewValues["folha_1"] != null)
            folha_1 = e.NewValues["folha_1"].ToString();
        if (e.NewValues["processo_1"] != null)
            processo_1 = Convert.ToBoolean(e.NewValues["processo_1"].ToString());
        if (e.NewValues["obs_1"] != null)
            obs_1 = e.NewValues["obs_1"].ToString();
        if (e.NewValues["vlr_2"] != null)
            vlr_2 = Convert.ToDecimal(e.NewValues["vlr_2"].ToString());
        if (e.NewValues["metragem_2"] != null)
            metragem_2 = Convert.ToDecimal(e.NewValues["metragem_2"].ToString());
        if (e.NewValues["inscricao_2"] != null)
            inscricao_2 = e.NewValues["inscricao_2"].ToString();
        if (e.NewValues["proprietario_2"] != null)
            proprietario_2 = e.NewValues["proprietario_2"].ToString();
        if (e.NewValues["quitado_2"] != null)
            quitado_2 = Convert.ToBoolean(e.NewValues["quitado_2"].ToString());
        if (e.NewValues["escritura_2"] != null)
            escritura_2 = Convert.ToBoolean(e.NewValues["escritura_2"].ToString());
        if (e.NewValues["dtescritura_2"] != null)
            dtescritura_2 = Convert.ToDateTime(e.NewValues["dtescritura_2"].ToString());
        if (e.NewValues["cartorio_2"] != null)
            cartorio_2 = e.NewValues["cartorio_2"].ToString();
        if (e.NewValues["livro_2"] != null)
            livro_2 = e.NewValues["livro_2"].ToString();
        if (e.NewValues["folha_2"] != null)
            folha_2 = e.NewValues["folha_2"].ToString();
        if (e.NewValues["processo_2"] != null)
            processo_2 = Convert.ToBoolean(e.NewValues["processo_2"].ToString());
        if (e.NewValues["obs_2"] != null)
            obs_2 = e.NewValues["obs_2"].ToString();
        //
        if (e.NewValues["area_privativa_coletiva_m2"] != null)
            area_privativa_coletiva_m2 = Convert.ToDecimal(e.NewValues["area_privativa_coletiva_m2"]);
        if (e.NewValues["area_privativa_terraco_coberto_m2"] != null)
            area_privativa_terraco_coberto_m2 = Convert.ToDecimal(e.NewValues["area_privativa_terraco_coberto_m2"]);
        if (e.NewValues["area_privativa_terraco_descoberto_m2"] != null)
            area_privativa_terraco_descoberto_m2 = Convert.ToDecimal(e.NewValues["area_privativa_terraco_descoberto_m2"]);
        //
        if (e.NewValues["area_comum_m2"] != null)
            area_comum_m2 = Convert.ToDecimal(e.NewValues["area_comum_m2"]);
        if (e.NewValues["area_garagem_m2"] != null)
            area_garagem_m2 = Convert.ToDecimal(e.NewValues["area_garagem_m2"]);
        if (e.NewValues["area_hobby_box_m2"] != null)
            area_hobby_box_m2 = Convert.ToDecimal(e.NewValues["area_hobby_box_m2"]);
        if (e.NewValues["area_total_m2"] != null)
            area_total_m2 = Convert.ToDecimal(e.NewValues["area_total_m2"]);
        if (e.NewValues["fracao_ideal_m2"] != null)
            fracao_ideal_m2 = Convert.ToDecimal(e.NewValues["fracao_ideal_m2"]);
        if (e.NewValues["fracao_ideal_percentual"] != null)
            fracao_ideal_percentual = Convert.ToDecimal(e.NewValues["fracao_ideal_percentual"]);
        //
        if (e.NewValues["hobby_box_numero"] != null)
            hobby_box_numero = e.NewValues["hobby_box_numero"].ToString();
        if (e.NewValues["hobby_box_localizacao"] != null)
            hobby_box_localizacao = e.NewValues["hobby_box_localizacao"].ToString();
        if (e.NewValues["numero_garagem_01"] != null)
            numero_garagem_01 = e.NewValues["numero_garagem_01"].ToString();
        if (e.NewValues["numero_garagem_02"] != null)
            numero_garagem_02 = e.NewValues["numero_garagem_02"].ToString();
        if (e.NewValues["numero_garagem_03"] != null)
            numero_garagem_03 = e.NewValues["numero_garagem_03"].ToString();
        if (e.NewValues["numero_garagem_04"] != null)
            numero_garagem_04 = e.NewValues["numero_garagem_04"].ToString();
        if (e.NewValues["numero_garagem_05"] != null)
            numero_garagem_05 = e.NewValues["numero_garagem_05"].ToString();
        //
        if (e.NewValues["vagas_localizacao"] != null)
            vagas_localizacao = e.NewValues["vagas_localizacao"].ToString();
        if (e.NewValues["vagas_quantidade"] != null)
            vagas_quantidade = Convert.ToInt16(e.NewValues["vagas_quantidade"]);
        //


        uUnidade.Altera(ID,
                        produto,
                        grupo,
                        unidade,
                        parte,
                        metragem_total,
                        vlr_total,
                        vlr_1,
                        metragem_1,
                        inscricao_1,
                        proprietario_1,
                        Convert.ToInt16(quitado_1),
                        Convert.ToInt16(escritura_1),
                        Convert.ToString(dtescritura_1).Substring(0, 10),
                        cartorio_1,
                        livro_1,
                        folha_1,
                        Convert.ToInt16(processo_1),
                        obs_1,
                        vlr_2,
                        metragem_2,
                        inscricao_2,
                        proprietario_2,
                        Convert.ToInt16(quitado_2),
                        Convert.ToInt16(escritura_2),
                        Convert.ToString(dtescritura_2).Substring(0, 10),
                        cartorio_2,
                        livro_2,
                        folha_2,
                        Convert.ToInt16(processo_2),
                        obs_2,
                        area_privativa_coletiva_m2,
                        area_privativa_terraco_coberto_m2,
                        area_privativa_terraco_descoberto_m2,
                        area_comum_m2,
                        area_garagem_m2,
                        area_hobby_box_m2,
                        area_total_m2,
                        fracao_ideal_m2,
                        fracao_ideal_percentual,
                        hobby_box_numero,
                        hobby_box_localizacao,
                        numero_garagem_01,
                        numero_garagem_02,
                        numero_garagem_03,
                        numero_garagem_04,
                        numero_garagem_05,
                        vagas_localizacao,
                        vagas_quantidade);



        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "ALTERA PRODUTO UNIDADE: " + produto + "/" + grupo + "/" + unidade + "/" + parte;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "PRODUTO UNIDADE"            ),
                                     new SqlParameter("@obs"      , "ALTERA"                     ),
                                     new SqlParameter("@acao"     , fwObs_Log                    ) };
        uLog.MakeLog(param_log);

        //
        AtualizaGrid();
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


    protected void ednome_TextChanged(object sender, EventArgs e)
    {
        //
        if (ednome.Text != string.Empty)
        {
            ednome.Text = ednome.Text.ToUpper();
            AtualizaGrid();
            GridListagem.Visible = true;
        }

    }
    protected void btcarrega_Click(object sender, EventArgs e)
    {
        Boolean lOk = true;
        string tst = "";
        DataSet propostas;
        //
        if (lOk)
        {
            //Proposta
            tst = "";
            List<object> Listagem = GridListagem.GetSelectedFieldValues(new string[] { "proposta" });
            if (Listagem.Count == 1)
            {
                foreach (Int32 xval in Listagem)
                {
                    if (tst != "")
                    {
                        tst = tst + ",";
                    }
                    tst = tst + Convert.ToString(xval);
                }
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Proposta Não Selecionada!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Proposta Não Selecionada!', 'Atenção!')", true);
            }
            //
            //Fim Proposta
            if (lOk)
            {
                //Carregar Dados
                //
                Label6.Visible = true;
                cbproduto2.Visible = true;
                Label7.Visible = true;
                cbgrupo2.Visible = true;
                Label8.Visible = true;
                cbgrupounidades2.Visible = true;
                rbmeiolote2.Visible = true;
                Label9.Visible = true;
                cbclientes.Visible = true;
                Label76.Visible = true;
                dtnascimento1.Visible = true;
                //
                Label33.Visible = true;
                Label34.Visible = true;
                dtproposta.Visible = true;
                cktabelaprice.Visible = true;
                Label35.Visible = true;
                edvlrvenda.Visible = true;
                Label36.Visible = true;
                edvlrsinal.Visible = true;
                cksinalparcelado.Visible = true;
                Label37.Visible = true;
                edqtdsinal.Visible = true;
                Label44.Visible = true;
                edvlrsaldo1.Visible = true;
                Label45.Visible = true;
                edvlrintermediarias.Visible = true;
                Label46.Visible = true;
                edqtdintermediarias.Visible = true;
                Label94.Visible = true;
                edvlrfluxoparcelas.Visible = true;
                Label52.Visible = true;
                edqtdfluxoparcelas.Visible = true;
                Label60.Visible = true;
                cbindexador.Visible = true;
                Label66.Visible = true;
                cbindexadorpos.Visible = true;
                Label61.Visible = true;
                rbperiodicidade.Visible = true;
                Label62.Visible = true;
                cbcorretor.Visible = true;
                Label63.Visible = true;
                edmulta.Visible = true;
                Label64.Visible = true;
                edcomissao.Visible = true;
                rbperiodicidadecomissao.Visible = true;
                Label65.Visible = true;
                edobservacao.Visible = true;
                //

                dtproposta.Value = DateTime.Now;
                edvlrvenda.Text = "0.00";
                edvlrsinal.Text = "0.00";
                edvlrsaldo1.Text = "0.00";
                edvlrintermediarias.Text = "0.00";
                //
                edmulta.Text = "0.00";
                edcomissao.Text = "0.00";
                //
                edvlrsaldo1.ReadOnly = true;
                //
                //Fim Valores da Proposta
                uContato.MontaComboRegimeCasamento(cbregimecasamento);
                Label41.Visible = true;
                edrg.Visible = true;
                Label4.Visible = true;
                dtrgemissao.Visible = true;
                Label11.Visible = true;
                edrgorgao.Visible = true;
                Label6.Visible = true;
                edprofissao.Visible = true;
                Label9.Visible = true;
                edcpf.Visible = true;
                Label13.Visible = true;
                edcpf.Visible = true;
                Label10.Visible = true;
                edestadocivil.Visible = true;
                Label15.Visible = true;
                cbregimecasamento.Visible = true;
                Label68.Visible = true;
                edsexo.Visible = true;
                Label16.Visible = true;
                ednomeconjuge.Visible = true;
                Label67.Visible = true;
                ednacionalidade.Visible = true;
                Label12.Visible = true;
                edprofissao.Visible = true;
                Label17.Visible = true;
                edenderecores.Visible = true;
                Label75.Visible = true;
                edcpfconjuge.Visible = true;
                Label14.Visible = true;
                edenredecoresnumero.Visible = true;
                Label19.Visible = true;
                edenredecorescomplemento.Visible = true;
                Label20.Visible = true;
                edenderecoresbairro.Visible = true;
                Label77.Visible = true;
                dtnascimentoconjuge.Visible = true;
                Label69.Visible = true;
                edrgconjuge.Visible = true;
                Label70.Visible = true;
                dtrgemissaoconjuge.Visible = true;
                Label71.Visible = true;
                edrgorgaoconjuge.Visible = true;
                Label72.Visible = true;
                edsexoconjuge.Visible = true;
                Label73.Visible = true;
                edprofissaoconjuge.Visible = true;
                Label74.Visible = true;
                ednacionalidadeconjuge.Visible = true;
                Label21.Visible = true;
                edenderecorescep.Visible = true;
                Label18.Visible = true;
                edenderecorescidade.Visible = true;
                Label23.Visible = true;
                edtelefoneres.Visible = true;
                Label24.Visible = true;
                edtelefonecom.Visible = true;
                Label25.Visible = true;
                edenderecocob.Visible = true;
                Label22.Visible = true;
                edenderecocobnumero.Visible = true;
                Label27.Visible = true;
                edenderecocobcomplemento.Visible = true;
                Label28.Visible = true;
                edenderecocobbairro.Visible = true;
                Label29.Visible = true;
                edenderecocobcep.Visible = true;
                Label26.Visible = true;
                edenderecocobcidade.Visible = true;
                Label31.Visible = true;
                edopcaoplanta.Visible = true;
                Label32.Visible = true;
                edenderecoimovel.Visible = true;
                edenderecoimovel.ReadOnly = true;
                edenderecoimovel.Text = uProduto.PegaEndereco(cbproduto.Text.Substring(0, 5));
                Label30.Visible = true;
                //
                propostas = uProposta.PegaDadosProposta(tst);
                //
                if (propostas.Tables[0].Rows[0]["data_proposta"] != null)
                {
                    dtproposta.Date = Convert.ToDateTime(propostas.Tables[0].Rows[0]["data_proposta"].ToString().Substring(0, 10));
                }
                cbproduto2.Text = Srelib.QStr0(propostas.Tables[0].Rows[0]["Produto"].ToString(), 5) + " - " + uProduto.PegaProdutoDescricao(Convert.ToInt16(propostas.Tables[0].Rows[0]["Produto"]));
                cbgrupo2.Text = Srelib.QStr0(propostas.Tables[0].Rows[0]["grupo"].ToString(), 5) + " - " + uProduto.PegaProdutoGrupoDescricao(Convert.ToInt16(propostas.Tables[0].Rows[0]["Produto"]), Convert.ToInt16(propostas.Tables[0].Rows[0]["grupo"]));
                cbgrupounidades2.Text = Srelib.QStr0(propostas.Tables[0].Rows[0]["unidade"].ToString(), 5) + " - " + propostas.Tables[0].Rows[0]["parte"].ToString();
                if (propostas.Tables[0].Rows[0]["parte"].ToString() != string.Empty)
                {
                    if (propostas.Tables[0].Rows[0]["parte"].ToString() == "0")
                    {
                        rbmeiolote2.Visible = false;
                    }
                    else
                    {
                        if (propostas.Tables[0].Rows[0]["parte"].ToString() == "1")
                        {
                            rbmeiolote2.Visible = true;
                            rbmeiolote2.SelectedIndex = 0;
                        }
                        else
                        {
                            rbmeiolote2.Visible = true;
                            rbmeiolote2.SelectedIndex = 1;
                        }
                    }
                }
                //
                cbclientes.Text = propostas.Tables[0].Rows[0]["nome"].ToString();
                edrg.Text = propostas.Tables[0].Rows[0]["rg"].ToString();
                //edrguf.Text = propostas.Tables[0].Rows[0]["rguf"].ToString();
                dtrgemissao.Date = Convert.ToDateTime(propostas.Tables[0].Rows[0]["rgemissao"].ToString().Substring(0, 10));
                edrgorgao.Text = propostas.Tables[0].Rows[0]["rgemissor"].ToString();
                edsexo.Text = propostas.Tables[0].Rows[0]["sexo"].ToString();
                edprofissao.Text = propostas.Tables[0].Rows[0]["profissao"].ToString();
                ednacionalidade.Text = propostas.Tables[0].Rows[0]["nacionalidade"].ToString();
                edcpf.Text = propostas.Tables[0].Rows[0]["cnpj"].ToString();
                edcpf.Text = Srelib.FormataCPFCNPJ(edcpf.Text);
                edestadocivil.Text = propostas.Tables[0].Rows[0]["estadocivil"].ToString();
                cbregimecasamento.Text = propostas.Tables[0].Rows[0]["regimecasamento"].ToString();
                dtnascimento1.Date = Convert.ToDateTime(propostas.Tables[0].Rows[0]["dtnascimento"].ToString().Substring(0, 10));
                //
                ednomeconjuge.Text = propostas.Tables[0].Rows[0]["conjugenome"].ToString();
                edrgconjuge.Text = propostas.Tables[0].Rows[0]["conjugerg"].ToString();
                //edrgufconjuge.Text = propostas.Tables[0].Rows[0]["conjugerguf"].ToString();
                dtrgemissaoconjuge.Date = Convert.ToDateTime(propostas.Tables[0].Rows[0]["conjugergemissao"].ToString().Substring(0, 10));
                edrgorgaoconjuge.Text = propostas.Tables[0].Rows[0]["conjugergemissor"].ToString();
                edsexoconjuge.Text = propostas.Tables[0].Rows[0]["conjugesexo"].ToString();
                edprofissaoconjuge.Text = propostas.Tables[0].Rows[0]["conjugeprofissao"].ToString();
                ednacionalidadeconjuge.Text = propostas.Tables[0].Rows[0]["conjugenacionalidade"].ToString();
                edcpfconjuge.Text = propostas.Tables[0].Rows[0]["conjugecpf"].ToString();
                edcpfconjuge.Text = Srelib.FormataCPFCNPJ(edcpfconjuge.Text);
                dtnascimentoconjuge.Date = Convert.ToDateTime(propostas.Tables[0].Rows[0]["conjugedtnascimento"].ToString().Substring(0, 10));
                //
                edenderecores.Text = propostas.Tables[0].Rows[0]["enderecores"].ToString();
                edenredecoresnumero.Text = propostas.Tables[0].Rows[0]["enderecoresnumero"].ToString();
                edenredecorescomplemento.Text = propostas.Tables[0].Rows[0]["enderecorescomplem"].ToString();
                edenderecoresbairro.Text = propostas.Tables[0].Rows[0]["bairrores"].ToString();
                edenderecorescep.Text = propostas.Tables[0].Rows[0]["cepres"].ToString();
                edenderecorescidade.Text = propostas.Tables[0].Rows[0]["cidaderes"].ToString();
                edtelefoneres.Text = propostas.Tables[0].Rows[0]["fone1res"].ToString();
                edtelefonecom.Text = propostas.Tables[0].Rows[0]["fone1com"].ToString();
                edenderecocob.Text = propostas.Tables[0].Rows[0]["enderecocom"].ToString();
                edenderecocobnumero.Text = propostas.Tables[0].Rows[0]["enderecocomnumero"].ToString();
                edenderecocobcomplemento.Text = propostas.Tables[0].Rows[0]["enderecocomcomplem"].ToString();
                edenderecocobbairro.Text = propostas.Tables[0].Rows[0]["bairrocom"].ToString();
                edenderecocobcep.Text = propostas.Tables[0].Rows[0]["cepcom"].ToString();
                edenderecocobcidade.Text = propostas.Tables[0].Rows[0]["cidadecom"].ToString();
                edopcaoplanta.Text = propostas.Tables[0].Rows[0]["tipoplanta"].ToString();
                //
                //
                dtproposta.Date = Convert.ToDateTime(propostas.Tables[0].Rows[0]["data_proposta"].ToString().Substring(0, 10));
                //
                edvlrvenda.Text = propostas.Tables[0].Rows[0]["valor_venda"].ToString();
                edvlrvenda.Text = String.Format("{0:N}", Convert.ToDouble(edvlrvenda.Text)).Trim();
                edvlrsinal.Text = propostas.Tables[0].Rows[0]["sinal"].ToString();
                edvlrsinal.Text = String.Format("{0:N}", Convert.ToDouble(edvlrsinal.Text)).Trim();
                edvlrsaldo1.Text = propostas.Tables[0].Rows[0]["saldo"].ToString();
                edvlrsaldo1.Text = String.Format("{0:N}", Convert.ToDouble(edvlrsaldo1.Text)).Trim();
                edvlrintermediarias.Text = propostas.Tables[0].Rows[0]["plano2_parcelas_vlr"].ToString();
                edvlrintermediarias.Text = String.Format("{0:N}", Convert.ToDouble(edvlrintermediarias.Text)).Trim();
                edvlrfluxoparcelas.Text = Convert.ToString(
                    (Convert.ToDouble(propostas.Tables[0].Rows[0]["plano3_parcelas_vlr"]) *
                     Convert.ToInt64(propostas.Tables[0].Rows[0]["plano3_parcelas_qtd"])));
                edvlrfluxoparcelas.Text = String.Format("{0:N}", Convert.ToDouble(edvlrfluxoparcelas.Text)).Trim();
                //
                edmulta.Text = uParametros.PegaParametro("MULTA");
                edmulta.Text = String.Format("{0:N}", Convert.ToDouble(edmulta.Text)).Trim();
                //
                cbindexador.Text = propostas.Tables[0].Rows[0]["indexadorprehabitese"].ToString();
                cbindexadorpos.Text = propostas.Tables[0].Rows[0]["indexadorposhabitese"].ToString();
                cbcorretor.Text = propostas.Tables[0].Rows[0]["corretor"].ToString();
                cbcorretor.Text = cbcorretor.Text.Trim() + " - " + uCorretor.PegaNomeIDCorretor(cbcorretor.Text);
                //
                edcomissao.Text = propostas.Tables[0].Rows[0]["comissaopermanencia"].ToString();
                edcomissao.Text = String.Format("{0:N}", Convert.ToDouble(edcomissao.Text)).Trim();
                //
                edobservacao.Text = propostas.Tables[0].Rows[0]["obs"].ToString();
                //
                cktabelaprice.Checked = Convert.ToBoolean(propostas.Tables[0].Rows[0]["tabelaprice"]);
                if (Convert.ToInt16(propostas.Tables[0].Rows[0]["plano1_parcelas_qtd"]) != 0)
                {
                    cksinalparcelado.Checked = true;
                }
                edvlrsaldo1.ReadOnly = true;
            }
        }
    }

    protected void btprocessa_Click(object sender, EventArgs e)
    {
        //
    }
    protected void btimprime_Click(object sender, EventArgs e)
    {
        //
        Boolean lOk = true;
        string tst = "";
        //
        if (lOk)
        {
            //Proposta
            tst = "";
            List<object> Listagem = GridListagem.GetSelectedFieldValues(new string[] { "proposta" });
            if (Listagem.Count == 1)
            {
                foreach (Int32 xval in Listagem)
                {
                    if (tst != "")
                    {
                        tst = tst + ",";
                    }
                    tst = tst + Convert.ToString(xval);
                }
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Proposta Não Selecionada!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Proposta Não Selecionada!', 'Atenção!')", true);
            }
            //
            //
            if (lOk)
            {
                // CRIA LOG ===============================================================================================================================================
                fwObs_Log = "RELATÓRIO PROPOSTA DE VENDA: " + cbproduto2.Text.ToString() + "/" + cbgrupo2.Text.ToString() + "/" + cbgrupounidades2.Text.ToString() +
                            " PROPOSTA ID: " + tst;
                SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ),
                                             new SqlParameter("@tabela"   , fWtabela                              ),
                                             new SqlParameter("@operacao" , "PROPOSTAS"                           ),
                                             new SqlParameter("@obs"      , "RELATÓRIO PROPOSTA DE VENDA"         ),
                                             new SqlParameter("@acao"     , fwObs_Log                             ) };
                uLog.MakeLog(param_log);
                //
                // FIM CRIA LOG ===============================================================================================================================================
                //
                //TITULO RECIBO
                Session.Remove("proposta");
                Session.Add("proposta", tst.ToString().Trim());
                //
                ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( '" + HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpRuntime.AppDomainAppVirtualPath + "/_Propostas/relatorios/RelProposta.aspx', null, 'height=755,width=900,status=yes,resizable=yes,menubar=yes,location=yes' );", true);
            }
        }

    }

    protected void btimprime2_Click(object sender, EventArgs e)
    {
        //
        Boolean lOk = true;
        string tst = "";
        //
        if (lOk)
        {
            //Proposta
            tst = "";
            List<object> Listagem = GridListagem.GetSelectedFieldValues(new string[] { "proposta" });
            if (Listagem.Count == 1)
            {
                foreach (Int32 xval in Listagem)
                {
                    if (tst != "")
                    {
                        tst = tst + ",";
                    }
                    tst = tst + Convert.ToString(xval);
                }
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Proposta Não Selecionada!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Proposta Não Selecionada!', 'Atenção!')", true);
            }
            //
            //
            if (lOk)
            {
                // CRIA LOG ===============================================================================================================================================
                fwObs_Log = "RELATÓRIO ANÁLISE PROPOSTA DE VENDA: " + cbproduto2.Text.ToString() + "/" + cbgrupo2.Text.ToString() + "/" + cbgrupounidades2.Text.ToString() +
                            " PROPOSTA ID: " + tst;
                SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ),
                                             new SqlParameter("@tabela"   , fWtabela                              ),
                                             new SqlParameter("@operacao" , "PROPOSTAS"                           ),
                                             new SqlParameter("@obs"      , "RELATÓRIO ANÁLISE PROPOSTA DE VENDA" ),
                                             new SqlParameter("@acao"     , fwObs_Log                             ) };
                uLog.MakeLog(param_log);
                //
                // FIM CRIA LOG ===============================================================================================================================================
                //
                //TITULO RECIBO
                Session.Remove("proposta");
                Session.Add("proposta", tst.ToString().Trim());
                //
                ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( '" + HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpRuntime.AppDomainAppVirtualPath + "/_Propostas/relatorios/RelPropostaAnalise.aspx', null, 'height=755,width=900,status=yes,resizable=yes,menubar=yes,location=yes' );", true);
            }
        }

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
    protected void edvlrfluxoparcelas_TextChanged(object sender, EventArgs e)
    {
        if ((edvlrfluxoparcelas.Text != "0,00") && (edvlrfluxoparcelas.Text != ""))
        {
            Label52.Visible = true;
            edqtdfluxoparcelas.Visible = true;
            edqtdfluxoparcelas.Focus();
        }
        else
        {
            Label52.Visible = false;
            edqtdfluxoparcelas.Visible = false;
            edvlrfluxoparcelas.Focus();
        }
    }

    protected void edqtdfluxoparcelas_TextChanged(object sender, EventArgs e)
    {
        if ((edqtdfluxoparcelas.Text != "0") && (edqtdfluxoparcelas.Text != ""))
        {
            Divfluxos.Style[HtmlTextWriterStyle.Visibility] = "visible";
            //
            Int32 Contador_Fluxo = Convert.ToInt32((string)Session["Contador_Fluxo"]);
            Contador_Fluxo++;
            Session.Remove("Contador_Fluxo");
            Session.Add("Contador_Fluxo", Contador_Fluxo.ToString());
            Label55.Text = Contador_Fluxo.ToString() + "/" + edqtdfluxoparcelas.Text.Trim();
            edqtdfluxoparcelas.ReadOnly = true;
            eddtparcelaintermediaria.Focus();
            //
            Label54.Visible = true;
            Label55.Visible = true;
            Label56.Visible = true;
            eddtinicialfluxo.Visible = true;
            Label57.Visible = true;
            edvlrparcelafluxo.Visible = true;
            Label58.Visible = true;
            edqtdparcelafluxo.Visible = true;
            Label59.Visible = true;
            edvlrparcelafluxototal.Visible = true;
            btgravafluxo.Visible = true;
            //
            eddtinicialfluxo.Value = DateTime.Now;
            edvlrparcelafluxo.Text = "0,00";
            edvlrparcelafluxototal.Text = "0,00";
            //
            eddtinicialfluxo.Focus();
        }
        else
        {
            Divfluxos.Style[HtmlTextWriterStyle.Visibility] = "hidden";
            Label55.Text = "9999/9999";
            //
            Label54.Visible = false;
            Label55.Visible = false;
            Label56.Visible = false;
            eddtinicialfluxo.Visible = false;
            Label57.Visible = false;
            edvlrparcelafluxo.Visible = false;
            Label58.Visible = false;
            edqtdparcelafluxo.Visible = false;
            Label59.Visible = false;
            edvlrparcelafluxototal.Visible = false;
            btgravafluxo.Visible = false;
            //
            edqtdfluxoparcelas.ReadOnly = false;
            edqtdfluxoparcelas.Focus();
        }
    }
    protected void edcpf_TextChanged(object sender, EventArgs e)
    {
        edcpf.Text = Srelib.tirasimbolos(edcpf.Text);
        edcpf.Text = Srelib.FormataCPFCNPJ(edcpf.Text);
    }
    protected void edcpfconjuge_TextChanged(object sender, EventArgs e)
    {
        edcpfconjuge.Text = Srelib.tirasimbolos(edcpfconjuge.Text);
        edcpfconjuge.Text = Srelib.FormataCPFCNPJ(edcpfconjuge.Text);
    }

}

﻿using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;


public partial class FEmpresaCadastro : System.Web.UI.Page
{
    DataSet dsempresa;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "EMPRESA";

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = SreDblib.TemPermissao("001.013.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.013.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.013.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.013.004.000", (String)Session["CodUsuario"]);
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
        dsempresa = uEmpresa.PegaDadosEmpresa("");
        GridListagem.DataSource = dsempresa;
        GridListagem.KeyFieldName = "apelido";
        GridListagem.DataBind();
    }

    protected void GridListagem_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
    {
        //Código Original
        ASPxGridView gridView = (ASPxGridView)sender;

        //
        string apelido = "";
        string nome = "";
        string cnpj = "";
        Boolean matriz = false;
        string inscmunicipal = "";
        string inscestadual = "";
        string regjuntacom = "";
        string nire = "";
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
        string email4 = "";
        string email5 = "";
        string gerente = "";
        string contato = "";
        DateTime dtnascimento = Convert.ToDateTime("01/01/1900");
        DateTime dtingresso = Convert.ToDateTime("01/01/1900");
        string ncontrato = "";
        DateTime dtcontrato = Convert.ToDateTime("01/01/1900");
        Boolean ativo = true;
        Boolean acessointernet = true;
        string obs1 = "";
        string obs2 = "";
        string obs3 = "";
        string obs4 = "";
        string obs5 = "";
        string instrcob1 = "";
        string instrcob2 = "";
        string diasprotesto = "";
        string conta1 = "";
        string conta2 = "";
        string conta3 = "";
        string conta4 = "";
        string conta5 = "";
        //
        // Empresa
        apelido = e.NewValues["apelido"].ToString().ToUpper();
        nome = e.NewValues["nome"].ToString().ToUpper();
        cnpj = e.NewValues["cnpj"].ToString();
        matriz = false;
        if (e.NewValues["inscmunicipal"] != null)
            inscmunicipal = e.NewValues["inscmunicipal"].ToString();
        if (e.NewValues["inscestadual"] != null)
            inscestadual = e.NewValues["inscestadual"].ToString();
        if (e.NewValues["regjuntacom"] != null)
            regjuntacom = e.NewValues["regjuntacom"].ToString();
        if (e.NewValues["nire"] != null)
            nire = e.NewValues["nire"].ToString();
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
        if (e.NewValues["email4"] != null)
            email4 = e.NewValues["email4"].ToString();
        if (e.NewValues["email5"] != null)
            email5 = e.NewValues["email5"].ToString();
        if (e.NewValues["gerente"] != null)
            gerente = e.NewValues["gerente"].ToString();
        if (e.NewValues["contato"] != null)
            contato = e.NewValues["contato"].ToString();
        if (e.NewValues["dtnascimento"] != null)
            dtnascimento = Convert.ToDateTime(e.NewValues["dtnascimento"].ToString());
        if (e.NewValues["dtingresso"] != null)
            dtingresso = Convert.ToDateTime(e.NewValues["dtingresso"].ToString());
        if (e.NewValues["ncontrato"] != null)
            ncontrato = e.NewValues["ncontrato"].ToString();
        if (e.NewValues["dtcontrato"] != null)
            dtcontrato = Convert.ToDateTime(e.NewValues["dtcontrato"].ToString());
        if (e.NewValues["ativo"] != null)
            ativo = Convert.ToBoolean(e.NewValues["ativo"].ToString());
        if (e.NewValues["acessointernet"] != null)
            acessointernet = Convert.ToBoolean(e.NewValues["acessointernet"].ToString());
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
        if (e.NewValues["instrcob1"] != null)
            instrcob1 = e.NewValues["instrcob1"].ToString();
        if (e.NewValues["instrcob2"] != null)
            instrcob2 = e.NewValues["instrcob2"].ToString();
        if (e.NewValues["diasprotesto"] != null)
            diasprotesto = e.NewValues["diasprotesto"].ToString();
        if (e.NewValues["conta1"] != null)
            conta1 = e.NewValues["conta1"].ToString();
        if (e.NewValues["conta2"] != null)
            conta2 = e.NewValues["conta2"].ToString();
        if (e.NewValues["conta3"] != null)
            conta3 = e.NewValues["conta3"].ToString();
        if (e.NewValues["conta4"] != null)
            conta4 = e.NewValues["conta4"].ToString();
        if (e.NewValues["conta5"] != null)
            conta5 = e.NewValues["conta5"].ToString();

        uEmpresa.Grava(apelido,
                       nome,
                       cnpj,
                       matriz,
                       inscmunicipal,
                       inscestadual,
                       regjuntacom,
                       nire,
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
                       email4,
                       email5,
                       gerente,
                       contato,
                       dtnascimento,
                       dtingresso,
                       ncontrato,
                       dtcontrato,
                       ativo,
                       acessointernet,
                       obs1,
                       obs2,
                       obs3,
                       obs4,
                       obs5,
                       instrcob1,
                       instrcob2,
                       diasprotesto,
                       conta1,
                       conta2,
                       conta3,
                       conta4,
                       conta5);

        //Código Original
        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "INCLUI EMPRESA: " + "NOVO" + "/" + e.NewValues["apelido"].ToString().ToUpper();
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "EMPRESA"                    ),
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
        string apelido = "";
        string nome = "";
        string cnpj = "";
        Boolean matriz = false;
        string inscmunicipal = "";
        string inscestadual = "";
        string regjuntacom = "";
        string nire = "";
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
        string email4 = "";
        string email5 = "";
        string gerente = "";
        string contato = "";
        DateTime dtnascimento = Convert.ToDateTime("01/01/1900");
        DateTime dtingresso = Convert.ToDateTime("01/01/1900");
        string ncontrato = "";
        DateTime dtcontrato = Convert.ToDateTime("01/01/1900");
        Boolean ativo = true;
        Boolean acessointernet = true;
        string obs1 = "";
        string obs2 = "";
        string obs3 = "";
        string obs4 = "";
        string obs5 = "";
        string instrcob1 = "";
        string instrcob2 = "";
        string diasprotesto = "";
        string conta1 = "";
        string conta2 = "";
        string conta3 = "";
        string conta4 = "";
        string conta5 = "";
        //
        // Empresa
        ID = e.NewValues["ID"].ToString();
        apelido = e.NewValues["apelido"].ToString();
        nome = e.NewValues["nome"].ToString();
        cnpj = e.NewValues["cnpj"].ToString();
        matriz = Convert.ToBoolean(e.NewValues["matriz"].ToString());
        if (e.NewValues["inscmunicipal"] != null)
            inscmunicipal = e.NewValues["inscmunicipal"].ToString();
        if (e.NewValues["inscestadual"] != null)
            inscestadual = e.NewValues["inscestadual"].ToString();
        if (e.NewValues["regjuntacom"] != null)
            regjuntacom = e.NewValues["regjuntacom"].ToString();
        if (e.NewValues["nire"] != null)
            nire = e.NewValues["nire"].ToString();
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
        if (e.NewValues["email4"] != null)
            email4 = e.NewValues["email4"].ToString();
        if (e.NewValues["email5"] != null)
            email5 = e.NewValues["email5"].ToString();
        if (e.NewValues["gerente"] != null)
            gerente = e.NewValues["gerente"].ToString();
        if (e.NewValues["contato"] != null)
            contato = e.NewValues["contato"].ToString();
        if (e.NewValues["dtnascimento"] != null)
            dtnascimento = Convert.ToDateTime(e.NewValues["dtnascimento"].ToString());
        if (e.NewValues["dtingresso"] != null)
            dtingresso = Convert.ToDateTime(e.NewValues["dtingresso"].ToString());
        if (e.NewValues["ncontrato"] != null)
            ncontrato = e.NewValues["ncontrato"].ToString();
        if (e.NewValues["dtcontrato"] != null)
            dtcontrato = Convert.ToDateTime(e.NewValues["dtcontrato"].ToString());
        if (e.NewValues["ativo"] != null)
            ativo = Convert.ToBoolean(e.NewValues["ativo"].ToString());
        if (e.NewValues["acessointernet"] != null)
            acessointernet = Convert.ToBoolean(e.NewValues["acessointernet"].ToString());
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
        if (e.NewValues["instrcob1"] != null)
            instrcob1 = e.NewValues["instrcob1"].ToString();
        if (e.NewValues["instrcob2"] != null)
            instrcob2 = e.NewValues["instrcob2"].ToString();
        if (e.NewValues["diasprotesto"] != null)
            diasprotesto = e.NewValues["diasprotesto"].ToString();
        if (e.NewValues["conta1"] != null)
            conta1 = e.NewValues["conta1"].ToString();
        if (e.NewValues["conta2"] != null)
            conta2 = e.NewValues["conta2"].ToString();
        if (e.NewValues["conta3"] != null)
            conta3 = e.NewValues["conta3"].ToString();
        if (e.NewValues["conta4"] != null)
            conta4 = e.NewValues["conta4"].ToString();
        if (e.NewValues["conta5"] != null)
            conta5 = e.NewValues["conta5"].ToString();

        uEmpresa.Altera(ID,
                       apelido,
                       nome,
                       cnpj,
                       matriz,
                       inscmunicipal,
                       inscestadual,
                       regjuntacom,
                       nire,
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
                       email4,
                       email5,
                       gerente,
                       contato,
                       dtnascimento,
                       dtingresso,
                       ncontrato,
                       dtcontrato,
                       ativo,
                       acessointernet,
                       obs1,
                       obs2,
                       obs3,
                       obs4,
                       obs5,
                       instrcob1,
                       instrcob2,
                       diasprotesto,
                       conta1,
                       conta2,
                       conta3,
                       conta4,
                       conta5);


        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "ALTERA EMPRESA: " + ID + "/" + apelido;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "EMPRESA"                    ),
                                     new SqlParameter("@obs"      , "ALTERA"                     ),
                                     new SqlParameter("@acao"     , fwObs_Log                    ) };
        uLog.MakeLog(param_log);

        //
        AtualizaGrid();
    }

    protected void GridListagem_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        uEmpresa.Exclui(e.Values["ID"].ToString());
        //

        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "EXCLUI EMPRESA: " + e.Values["ID"].ToString() + "/" + e.Values["apelido"].ToString().ToUpper();
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "EMPRESA"                    ),
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
        e.NewValues["dtnascimento"] = Convert.ToDateTime("01/01/1900");
        e.NewValues["dtingresso"] = DateTime.Now;
        e.NewValues["dtcontrato"] = Convert.ToDateTime("01/01/1900");
        e.NewValues["ativo"] = true;
        e.NewValues["acessointernet"] = true;
        e.NewValues["gerente"] = "GERAL";
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

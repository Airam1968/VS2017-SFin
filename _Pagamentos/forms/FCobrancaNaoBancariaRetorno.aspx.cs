using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FCobrancaNaoBancariaRetorno : System.Web.UI.Page
{
    DataSet dsparcelas = new DataSet("table");
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "PARCELAS";

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = SreDblib.TemPermissao("001.005.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.005.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.005.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.005.004.000", (String)Session["CodUsuario"]);
        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        //
        btprocessa.Enabled = lAltera;
        btimprime.Enabled = lConsulta;
        if (!lAltera)
            btprocessa.Image.ToolTip = Msg_acesso;
        if (!lConsulta)
            btimprime.Image.ToolTip = Msg_acesso;
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
            cbbanco.Items.Clear();
            uBanco_2.MontaComboBanco(cbbanco);
            //
            Label4.Visible = true;
            edcaminho.Visible = true;
            edextensao.Visible = true;
            //
            Label13.Visible = true;
            ednomearquivo.Visible = true;
            //
            Label2.Visible = true;
            memoarquivo.Visible = true;
            //
            Label8.Visible = true;
            ckplano1x1.Visible = true;
            ckplano1x1.Checked = false;
            //
            Label9.Visible = true;
            ckpesquisaparcela.Visible = true;
            ckpesquisaparcela.Checked = false;
            //
            Label10.Visible = true;
            ckbaixarparcelapaga.Visible = true;
            ckbaixarparcelapaga.Checked = true;
            //
            btprocessa.Enabled = true;
            btimprime.Enabled = true;
            //
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

    protected void btprocessa_Click(object sender, EventArgs e)
    {
        //
        Boolean lOk = true;
        string tst;
        //
        tst = "";
        List<object> cbbaixas = GridListagem.GetSelectedFieldValues(new string[] { "ID" });
        if (cbbaixas.Count > 0)
        {
            foreach (string xval in cbbaixas)
            {
                if (tst != "")
                {
                    tst = tst + ",";
                }
                tst = tst + xval.Trim();
            }
            edfeedback.Text = cbbaixas.Count.ToString() + "Selecionados!";
        }
        else
        {
            lOk = false;
            edfeedback.Text = "Selecione parcelas para a Baixa Automática!";
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Não há Registros Selecionados para Baixa Automática!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não há Registros Selecionados para Baixa Automática!', 'Atenção!')", true);
        }
        //
        string produto = "";
        string grupo = "";
        string unidade = "";
        string parte = "";
        string proprietario = "";
        string contacorrente = "";
        string parcela_ID = "";
        //
        string data_pagamento = "";
        //string valor = "";
        //string valor_juros = "";
        //string valor_total = "";
        //string conta_cedente = "";
        //string apelido_cedente = "";
        string identificador = "";
        string plano = "";
        string data_vencimento = "";
        //string vlr_pgto_base = "";
        string vlr_pgto_juros = "";
        string vlr_pgto_total = "";
        string venda_localizada = "";
        string venda_ID = "";
        //string parcela_sistema = "";
        //string parcela_corrigida = "";
        Double diferenca = 0;
        Double Multa = 0;
        Double desconto = 0;
        string ID = "";
        //Baixa de Registros
        //
        DataTable table1 = new DataTable();
        foreach (GridViewColumn col in GridListagem.VisibleColumns)
        {
            GridViewDataColumn dataColumn = col as GridViewDataColumn;
            if (dataColumn == null) continue;
            table1.Columns.Add(dataColumn.FieldName);
        }
        //
        for (int i = 0; i < GridListagem.VisibleRowCount; i++)
        {
            DataRow row = table1.Rows.Add();
            foreach (DataColumn col in table1.Columns)
            {
                string temp = GridListagem.GetRowValues(i, col.ColumnName).ToString();
                //if ((col.ColumnName == "ID") && (tst.IndexOf(temp) != -1))
                //{
                row[col.ColumnName] = GridListagem.GetRowValues(i, col.ColumnName);
                //}
            }
        }
        //
        dsparcelas.Clear();
        dsparcelas = new DataSet("table");
        dsparcelas.Tables.Add(table1);
        //
        if (lOk)
        {
            if (dsparcelas.Tables[0].Rows.Count > 0)
            {
                //Baixa dos Registros Identificados
                for (int i = 0; i < dsparcelas.Tables[0].Rows.Count; i++)
                {
                    //
                    ID = dsparcelas.Tables[0].Rows[i]["ID"].ToString().Trim();
                    //
                    //Selecionado
                    if (tst.IndexOf(ID) != -1)
                    {
                        venda_ID = dsparcelas.Tables[0].Rows[i]["venda_ID"].ToString().Trim();
                        venda_localizada = dsparcelas.Tables[0].Rows[i]["venda_localizada"].ToString().Trim();
                        //
                        produto = dsparcelas.Tables[0].Rows[i]["venda_ID"].ToString().Trim();
                        string resta = produto.Substring(produto.IndexOf("/"), produto.Length - produto.IndexOf("/"));
                        produto = produto.Substring(0, produto.IndexOf("/"));
                        //
                        grupo = resta.Substring(resta.IndexOf("/") + 1, resta.Length - (resta.IndexOf("/") + 1));
                        resta = resta.Substring(resta.IndexOf("/") + 1, resta.Length - resta.IndexOf("/") - 1);
                        grupo = grupo.Substring(0, grupo.IndexOf("/"));
                        //
                        unidade = resta.Substring(resta.IndexOf("/") + 1, resta.Length - (resta.IndexOf("/") + 1));
                        resta = resta.Substring(resta.IndexOf("/") + 1, resta.Length - resta.IndexOf("/") - 1);
                        unidade = unidade.Substring(0, unidade.IndexOf("/"));
                        //
                        parte = resta.Substring(resta.IndexOf("/") + 1, resta.Length - (resta.IndexOf("/") + 1));
                        if (parte == "0")
                        {
                            proprietario = "1";
                        }
                        else
                        {
                            proprietario = parte;
                        }
                        //
                        data_pagamento = dsparcelas.Tables[0].Rows[i]["data_pagamento"].ToString().Trim();
                        data_vencimento = dsparcelas.Tables[0].Rows[i]["data_vencimento"].ToString().Trim();
                        vlr_pgto_total = "0";
                        vlr_pgto_juros = "0";
                        if (dsparcelas.Tables[0].Rows[i]["vlr_pgto_total"] != null)
                        {
                            vlr_pgto_total = dsparcelas.Tables[0].Rows[i]["vlr_pgto_total"].ToString().Trim();
                        }
                        if (dsparcelas.Tables[0].Rows[i]["vlr_pgto_juros"] != null)
                        {
                            vlr_pgto_juros = dsparcelas.Tables[0].Rows[i]["vlr_pgto_juros"].ToString().Trim();
                        }
                        if (dsparcelas.Tables[0].Rows[i]["parcela_ID"] != null)
                        {
                            parcela_ID = dsparcelas.Tables[0].Rows[i]["parcela_ID"].ToString().Trim();
                        }
                        contacorrente = uProduto.PegaProdutoConta(41);
                        //
                        if (dsparcelas.Tables[0].Rows[i]["diferenca"] != null)
                        {
                            diferenca = Convert.ToDouble(dsparcelas.Tables[0].Rows[i]["diferenca"]);
                        }
                        //
                        if (dsparcelas.Tables[0].Rows[i]["identificador"] != null)
                        {
                            identificador = dsparcelas.Tables[0].Rows[i]["identificador"].ToString().Trim();
                        }
                        //
                        if (dsparcelas.Tables[0].Rows[i]["plano"] != null)
                        {
                            plano = dsparcelas.Tables[0].Rows[i]["plano"].ToString().Trim();
                            //
                        }
                        //
                        //Baixa da 1a. vistoria com controle de diferença
                        if (venda_localizada == "1o.OK")
                        {
                            //
                            if (diferenca <= Convert.ToDouble(uParametros.PegaParametro("DIFERENÇA BAIXA")))
                            {
                                Multa = 0;
                                desconto = 0;
                                if (diferenca != 0)
                                {
                                    if (diferenca < 0)
                                    {
                                        Multa = Math.Abs(diferenca);
                                    }
                                    else
                                    {
                                        desconto = Math.Abs(diferenca);
                                    }
                                }
                                //
                                if (ckbaixarparcelapaga.Checked)
                                {
                                    //
                                    if (!uParcelas.ParcelaPaga(produto,
                                                              grupo,
                                                              unidade,
                                                              parte,
                                                              parcela_ID))
                                    {
                                        uParcelas.GravaPagamento(produto,
                                                                 grupo,
                                                                 unidade,
                                                                 parte,
                                                                 parcela_ID,
                                                                 data_pagamento,
                                                                 Convert.ToDecimal(vlr_pgto_total),
                                                                 "CNB",
                                                                 Convert.ToDecimal(0),
                                                                 Convert.ToDecimal(Multa),
                                                                 Convert.ToDecimal(desconto),
                                                                 DateTime.Now.ToString().Substring(0, 10),
                                                                 contacorrente.ToString().Trim(),
                                                                 Convert.ToDecimal(0));

                                        uParcelas.GravaNossoNumeroID(produto,
                                                                     grupo,
                                                                     unidade,
                                                                     parte,
                                                                     data_vencimento,
                                                                     Srelib.QStr(identificador + " - " + plano),
                                                                     parcela_ID);
                                        //
                                        // CRIA LOG ===============================================================================================================================================
                                        fwObs_Log = "PAGAMENTO PARCELA: " + produto + "/" + grupo + "/" + unidade + "/" + parte + "/" + parte +
                                                    " PARCELA ID: " + parcela_ID;
                                        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ), 
                                                     new SqlParameter("@tabela"   , fWtabela                              ),
                                                     new SqlParameter("@operacao" , "PARCELAS"                            ),
                                                     new SqlParameter("@obs"      , "PAGAMENTO PARCELA - BAIXA CNB"       ),
                                                     new SqlParameter("@acao"     , fwObs_Log                             ) };
                                        uLog.MakeLog(param_log);
                                        // FIM CRIA LOG ===============================================================================================================================================
                                    }
                                }
                                else
                                {
                                    uParcelas.GravaPagamento(produto,
                                                             grupo,
                                                             unidade,
                                                             parte,
                                                             parcela_ID,
                                                             data_pagamento,
                                                             Convert.ToDecimal(vlr_pgto_total),
                                                             "CNB",
                                                             Convert.ToDecimal(0),
                                                             Convert.ToDecimal(Multa),
                                                             Convert.ToDecimal(desconto),
                                                             DateTime.Now.ToString().Substring(0, 10),
                                                             contacorrente.ToString().Trim(),
                                                             Convert.ToDecimal(0));

                                    uParcelas.GravaNossoNumeroID(produto,
                                                                 grupo,
                                                                 unidade,
                                                                 parte,
                                                                 data_vencimento,
                                                                 Srelib.QStr(identificador + " - " + plano),
                                                                 parcela_ID);
                                    //
                                    // CRIA LOG ===============================================================================================================================================
                                    fwObs_Log = "PAGAMENTO PARCELA: " + produto + "/" + grupo + "/" + unidade + "/" + parte + "/" + parte +
                                                " PARCELA ID: " + parcela_ID;
                                    SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ), 
                                                     new SqlParameter("@tabela"   , fWtabela                              ),
                                                     new SqlParameter("@operacao" , "PARCELAS"                            ),
                                                     new SqlParameter("@obs"      , "PAGAMENTO PARCELA - BAIXA CNB"       ),
                                                     new SqlParameter("@acao"     , fwObs_Log                             ) };
                                    uLog.MakeLog(param_log);
                                    // FIM CRIA LOG ===============================================================================================================================================
                                }
                                //
                            }
                        }
                        //Baixa da 2a. vistoria sem controle de diferença
                        if (venda_localizada == "2o.OK")
                        {
                            Multa = 0;
                            desconto = 0;
                            if (diferenca != 0)
                            {
                                if (diferenca < 0)
                                {
                                    Multa = Math.Abs(diferenca);
                                }
                                else
                                {
                                    desconto = Math.Abs(diferenca);
                                }
                            }
                            //
                            //if (diferenca <= Convert.ToDouble(uParametros.PegaParametro("DIFERENÇA BAIXA")))
                            //{
                            if (ckbaixarparcelapaga.Checked)
                            {
                                //
                                if (!uParcelas.ParcelaPaga(produto,
                                                          grupo,
                                                          unidade,
                                                          parte,
                                                          parcela_ID))
                                {
                                    uParcelas.GravaPagamento(produto,
                                                             grupo,
                                                             unidade,
                                                             parte,
                                                             parcela_ID,
                                                             data_pagamento,
                                                             Convert.ToDecimal(vlr_pgto_total),
                                                             "CNB",
                                                             Convert.ToDecimal(0),
                                                             Convert.ToDecimal(Multa),
                                                             Convert.ToDecimal(desconto),
                                                             DateTime.Now.ToString().Substring(0, 10),
                                                             contacorrente.ToString().Trim(),
                                                             Convert.ToDecimal(0));

                                    uParcelas.GravaNossoNumeroID(produto,
                                                                 grupo,
                                                                 unidade,
                                                                 parte,
                                                                 data_vencimento,
                                                                 Srelib.QStr(identificador + " - " + plano),
                                                                 parcela_ID);
                                    //
                                    // CRIA LOG ===============================================================================================================================================
                                    fwObs_Log = "PAGAMENTO PARCELA: " + produto + "/" + grupo + "/" + unidade + "/" + parte + "/" + parte +
                                                " PARCELA ID: " + parcela_ID;
                                    SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ), 
                                                     new SqlParameter("@tabela"   , fWtabela                              ),
                                                     new SqlParameter("@operacao" , "PARCELAS"                            ),
                                                     new SqlParameter("@obs"      , "PAGAMENTO PARCELA - BAIXA CNB"       ),
                                                     new SqlParameter("@acao"     , fwObs_Log                             ) };
                                    uLog.MakeLog(param_log);
                                    // FIM CRIA LOG ===============================================================================================================================================
                                }
                            }
                            else
                            {
                                uParcelas.GravaPagamento(produto,
                                                         grupo,
                                                         unidade,
                                                         parte,
                                                         parcela_ID,
                                                         data_pagamento,
                                                         Convert.ToDecimal(vlr_pgto_total),
                                                         "CNB",
                                                         Convert.ToDecimal(0),
                                                         Convert.ToDecimal(Multa),
                                                         Convert.ToDecimal(desconto),
                                                         DateTime.Now.ToString().Substring(0, 10),
                                                         contacorrente.ToString().Trim(),
                                                         Convert.ToDecimal(0));

                                uParcelas.GravaNossoNumeroID(produto,
                                                             grupo,
                                                             unidade,
                                                             parte,
                                                             data_vencimento,
                                                             Srelib.QStr(identificador + " - " + plano),
                                                             parcela_ID);
                                //
                                // CRIA LOG ===============================================================================================================================================
                                fwObs_Log = "PAGAMENTO PARCELA: " + produto + "/" + grupo + "/" + unidade + "/" + parte + "/" + parte +
                                            " PARCELA ID: " + parcela_ID;
                                SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ), 
                                                     new SqlParameter("@tabela"   , fWtabela                              ),
                                                     new SqlParameter("@operacao" , "PARCELAS"                            ),
                                                     new SqlParameter("@obs"      , "PAGAMENTO PARCELA - BAIXA CNB"       ),
                                                     new SqlParameter("@acao"     , fwObs_Log                             ) };
                                uLog.MakeLog(param_log);
                                // FIM CRIA LOG ===============================================================================================================================================
                            }
                            //
                            //}
                        }
                    }
                }
                //Fim Baixa dos Registros Identificados
            }
            else
            {
                lOk = false;
                btprocessa.Enabled = false;
                btimprime.Enabled = false;
                edfeedback.Text = "Não há Registros para Baixa Automática!";
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Não há Registros para Baixa Automática!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Não há Registros para Baixa Automática!', 'Atenção!')", true);

            }
        }
        //
        if (lOk)
        {
            //
            btprocessa.Enabled = false;
            btimprime.Enabled = true;
            edfeedback.Text = "Baixa Automática Concluída! (" + cbbaixas.Count.ToString() + ") Registro(s).";
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Baixa Automática Concluída!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.success('Baixa Automática Concluída!', 'Atenção!')", true);
            //
        }

    }


    protected void cbbanco_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        if (cbbanco.Text != string.Empty)
        {
            //
            string IDBanco = cbbanco.Value.ToString();
            if (IDBanco != "")
            {
                //
                edcaminho.Text = uBanco_2.PegaCaminhoRetorno(IDBanco);
                edextensao.Text = uBanco_2.PegaExtensaoRetorno(IDBanco);
                string Caminhoservidor = edcaminho.Text;
                //string Caminhoservidor = Server.MapPath("~") + "\\Arquivos\\CobrancaNBancaria\\";
                edcaminho.Text = Caminhoservidor.ToUpper();
                edextensao.Text = edextensao.Text.ToUpper();
                //
                btcarrega.Enabled = true;
                btprocessa.Enabled = false;
                btimprime.Enabled = false;
                //
                Label4.Visible = true;
                edcaminho.Visible = true;
                edextensao.Visible = true;
                //
                Label13.Visible = true;
                ednomearquivo.Visible = true;
                //
                Label5.Visible = true;
                edfeedback.Visible = true;
                //
                edfeedback.Text = "Informe os dados abaixo para captura do arquivo de Retorno e clique no Botão Captura.";
                //
                Label7.Visible = true;
                eddiferença.Visible = true;
                //
                eddiferença.Text = uParametros.PegaParametro("DIFERENÇA BAIXA");
                //
            }

        }

    }
    protected void btcarrega_Click(object sender, EventArgs e)
    {
        Boolean lOk = true;
        memoarquivo.Text = " ";
        Int32 localizados = 0;
        Int32 naolocalizados = 0;
        string IDBanco = cbbanco.Value.ToString();
        //Carregar Arquivo modo TEXTO
        edcaminho.Text = uBanco_2.PegaCaminhoRetorno(IDBanco);
        edextensao.Text = uBanco_2.PegaExtensaoRetorno(IDBanco);
        string Caminhoservidor = edcaminho.Text;
        //string Caminhoservidor = Server.MapPath("~") + "\\Arquivos\\CobrancaNBancaria\\";
        string Arquivo = ednomearquivo.Text.Trim() + "." + edextensao.Text.Trim();
        edcaminho.Text = Caminhoservidor;
        string Caminhoarquivo = Caminhoservidor + Arquivo;
        //
        Boolean ArquivoExiste = false;
        try
        {
            ArquivoExiste = File.Exists(@Caminhoarquivo);
        }
        catch (Exception)
        {
            lOk = false;
            edfeedback.Text = "Caminho ou Arquivo não existe!";
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Caminho ou Arquivo não existe!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Caminho ou Arquivo não existe!', 'Atenção!')", true);
        }
        //
        if (lOk)
        {
            string[] lines;
            try
            {
                lines = File.ReadAllLines(@Caminhoarquivo);
            }
            catch (Exception)
            {
                lOk = false;
                edfeedback.Text = "Erro na tentativa de ler as linhas do arquivo!(" + Caminhoarquivo + ")";
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Erro na tentativa de ler as linhas do arquivo!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.error('Erro na tentativa de ler as linhas do arquivo!', 'Atenção!')", true);
            }
        }
        //
        if (lOk)
        {
            //Produto
            if (cbbanco.Text != string.Empty)
            {
                //
            }
            else
            {
                lOk = false;
                edfeedback.Text = "Nenhuma Origem Selecionada!";
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Nenhuma Origem Selecionada!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Nenhuma Origem Selecionada!', 'Atenção!')", true);
            }
        }
        //
        if (lOk)
        {
            if (ArquivoExiste)
            {
                //using (var fileStream = new FileStream(@Caminhoarquivo, FileMode.Open, FileAccess.Read))
                //{
                //    //Tentativa de Abrir o Arquivo
                //}
                btprocessa.Enabled = true;
                btimprime.Enabled = false;
                edfeedback.Text = "Caso existam registros, clique no Botão Processa para efetuar a baixa automática";
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Carregamento Concluído!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.success('Carregamento Concluído!', 'Atenção!')", true);
                //
            }
            else
            {
                lOk = false;
                btprocessa.Enabled = false;
                btimprime.Enabled = false;
                edfeedback.Text = "Arquivo Não Encontrado! Verificar Pasta, Nome e Extensão.";
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Arquivo Não Encontrado! Verificar Pasta, Nome e Extensão.');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Arquivo Não Encontrado! Verificar Pasta, Nome e Extensão!', 'Atenção!')", true);
                //
            }
        }
        //Fim Carregar Arquivo  modo TEXTO
        //
        //Carregar Arquivo modo TABELA
        //
        Boolean controle = false;
        Int16 inicio = 0;
        Int16 final = 0;
        Int16 final2 = 0;
        string linha_corrente = "";
        string id_origem_quadra = "";
        string id_origem_unidade = "";
        string id_destino_quadra = "";
        string id_destino_unidade = "";
        string id_destino_parte = "";
        string proprietario = "1";
        //Prepara Table e DataSet
        //
        string data_pagamento = "";
        string valor = "";
        string valor_juros = "";
        string valor_total = "";
        string conta_cedente = "";
        string apelido_cedente = "";
        string identificador = "";
        string plano = "";
        string numeroparcela = "";
        string data_vencimento = "";
        string vlr_pgto_base = "";
        string vlr_pgto_juros = "";
        string vlr_pgto_total = "";
        string venda_ID = "";
        string parcela_sistema = "";
        string parcela_corrigida = "";
        string diferenca = "0,00";
        string parcela_ID = "";
        //
        DataTable table1 = new DataTable("table1");
        //
        table1.Columns.Add("ID");
        table1.Columns.Add("data_pagamento");
        table1.Columns.Add("valor");
        table1.Columns.Add("valor_juros");
        table1.Columns.Add("valor_total");
        table1.Columns.Add("conta_cedente");
        table1.Columns.Add("apelido_cedente");
        table1.Columns.Add("identificador");
        table1.Columns.Add("plano");
        table1.Columns.Add("data_vencimento");
        table1.Columns.Add("vlr_pgto_base");
        table1.Columns.Add("vlr_pgto_juros");
        table1.Columns.Add("vlr_pgto_total");
        table1.Columns.Add("venda_ID");
        table1.Columns.Add("venda_localizada");
        table1.Columns.Add("parcela_sistema");
        table1.Columns.Add("parcela_corrigida");
        table1.Columns.Add("diferenca");
        table1.Columns.Add("parcela_ID");
        //
        if (lOk)
        {
            if (File.Exists(@Caminhoarquivo))
            {
                using (var fileStream = new FileStream(@Caminhoarquivo, FileMode.Open, FileAccess.Read))
                {
                    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                    {
                        string linha;
                        Int32 id_contador = 1;
                        while ((linha = streamReader.ReadLine()) != null)
                        {
                            //Linhas Texto para Memo
                            memoarquivo.Text += linha + Environment.NewLine;
                            //Fim Linhas Texto para Memo
                            //
                            //Controle de Linhas
                            if (linha.IndexOf("conta_cedente") != -1)
                            {
                                controle = true;
                            }
                            if (linha.IndexOf("conta_cedente2") != -1)
                            {
                                controle = false;
                            }
                            //Fim do Controle de Linhas
                            //Captura de Dados
                            if (controle)
                            {
                                if ((linha.Trim() != string.Empty) &&
                                    (linha.Substring(0, 5) != "Data1") &&
                                    (linha.Substring(0, 9) != "Textbox54"))
                                {
                                    //
                                    linha_corrente = linha;
                                    //
                                    inicio = 0;
                                    final = Convert.ToInt16(linha_corrente.IndexOf(","));
                                    //Formato Iniciando por Data1
                                    try
                                    {
                                        data_pagamento = linha_corrente.Substring(inicio, final);
                                        data_pagamento = Convert.ToDateTime(data_pagamento).ToString().Substring(0, 10);
                                    }
                                    catch (Exception)
                                    {
                                        //Formato Iniciando por Textbox54
                                        //
                                        linha_corrente = linha_corrente.Substring(final + 5, linha_corrente.Length - (final + 5));
                                        inicio = 0;
                                        //
                                        data_pagamento = linha_corrente.Substring(inicio, final);
                                        data_pagamento = Convert.ToDateTime(data_pagamento).ToString().Substring(0, 10);
                                    }

                                    //
                                    linha_corrente = linha_corrente.Substring(final + 3, linha_corrente.Length - (final + 3));
                                    inicio = 0;
                                    final = Convert.ToInt16(linha_corrente.IndexOf(","));
                                    valor = linha_corrente.Substring(inicio, final + 3);
                                    //
                                    linha_corrente = linha_corrente.Substring(final + 6, linha_corrente.Length - (final + 6));
                                    inicio = 0;
                                    final = Convert.ToInt16(linha_corrente.IndexOf(","));
                                    valor_juros = linha_corrente.Substring(inicio + 1, final + 2);
                                    //
                                    linha_corrente = linha_corrente.Substring(final + 6, linha_corrente.Length - (final + 6));
                                    inicio = 0;
                                    final = Convert.ToInt16(linha_corrente.IndexOf(","));
                                    valor_total = linha_corrente.Substring(inicio + 1, final + 2);
                                    //
                                    linha_corrente = linha_corrente.Substring(final + 5, linha_corrente.Length - (final + 5));
                                    inicio = 0;
                                    final = Convert.ToInt16(linha_corrente.IndexOf(","));
                                    conta_cedente = linha_corrente.Substring(inicio, final);
                                    //
                                    linha_corrente = linha_corrente.Substring(final + 1, linha_corrente.Length - (final + 1));
                                    inicio = 0;
                                    final = Convert.ToInt16(linha_corrente.IndexOf(","));
                                    apelido_cedente = linha_corrente.Substring(inicio, final);
                                    //
                                    linha_corrente = linha_corrente.Substring(final + 1, linha_corrente.Length - (final + 1));
                                    inicio = 0;
                                    final = Convert.ToInt16(linha_corrente.IndexOf(","));
                                    identificador = linha_corrente.Substring(inicio, final);
                                    //
                                    linha_corrente = linha_corrente.Substring(final + 1, linha_corrente.Length - (final + 1));
                                    inicio = 0;
                                    final = Convert.ToInt16(linha_corrente.IndexOf(","));
                                    plano = linha_corrente.Substring(inicio, final);
                                    //
                                    final2 = Convert.ToInt16(plano.IndexOf("/"));
                                    numeroparcela = plano.Substring(inicio, final2);
                                    numeroparcela = Convert.ToString(Math.Truncate(Convert.ToDecimal(numeroparcela)));
                                    //
                                    linha_corrente = linha_corrente.Substring(final + 1, linha_corrente.Length - (final + 1));
                                    inicio = 0;
                                    final = Convert.ToInt16(linha_corrente.IndexOf(","));
                                    data_vencimento = linha_corrente.Substring(inicio, final);
                                    data_vencimento = Convert.ToDateTime(data_vencimento).ToString().Substring(0, 10);
                                    //
                                    linha_corrente = linha_corrente.Substring(final + 3, linha_corrente.Length - (final + 3));
                                    inicio = 0;
                                    final = Convert.ToInt16(linha_corrente.IndexOf(","));
                                    vlr_pgto_base = linha_corrente.Substring(inicio, final + 3);
                                    //
                                    linha_corrente = linha_corrente.Substring(final + 5, linha_corrente.Length - (final + 5));
                                    inicio = 0;
                                    final = Convert.ToInt16(linha_corrente.IndexOf(","));
                                    if (inicio + 3 != final)
                                    {
                                        vlr_pgto_juros = linha_corrente.Substring(inicio + 1, final + 2);
                                    }
                                    else
                                    {
                                        vlr_pgto_juros = "0,00";
                                    }
                                    //
                                    linha_corrente = linha_corrente.Substring(final + 6, linha_corrente.Length - (final + 6));
                                    inicio = 0;
                                    final = Convert.ToInt16(linha_corrente.Length);
                                    vlr_pgto_total = linha_corrente.Substring(inicio, final - 1);
                                    //
                                    //Localizar Parcela
                                    id_origem_quadra = "";
                                    id_origem_unidade = "";
                                    final = Convert.ToInt16(identificador.IndexOf("/"));
                                    id_origem_quadra = identificador.Substring(0, final);
                                    id_origem_unidade = identificador.Substring(final + 1, identificador.Length - (final + 1));
                                    //
                                    id_destino_quadra = uProduto.PegaGrupoPorDescricao(id_origem_quadra);
                                    id_destino_unidade = Convert.ToInt32(id_origem_unidade).ToString().Trim();
                                    //
                                    //Confirmar Venda
                                    string parcela_base = "0,00";
                                    if ((id_destino_quadra.Trim() != string.Empty) && (id_destino_unidade.Trim() != string.Empty))
                                    {
                                        if (SreDblib.TemNaTabela("select * from produto_unidades where produto = 41 and grupo = " + id_destino_quadra + " and unidade = " + id_destino_unidade + " and parte = 0"))
                                        {
                                            id_destino_parte = "0";
                                            proprietario = "1";
                                        }
                                        else
                                        {
                                            if (SreDblib.TemNaTabela("select * from produto_unidades where produto = 41 and grupo = " + id_destino_quadra + " and unidade = " + id_destino_unidade + " and parte = 1"))
                                            {
                                                id_destino_parte = "1";
                                                proprietario = "1";
                                            }
                                            else
                                            {
                                                id_destino_parte = "2";
                                                proprietario = "2";
                                            }

                                        }
                                        //Fim Confirmar Venda
                                        //
                                        venda_ID = "41/" + id_destino_quadra + "/" + id_destino_unidade + "/" + id_destino_parte;
                                        //
                                        //Confirmar Parcela
                                        string nomearquivo = "parcelas_00041_" + Srelib.QStr0(id_destino_quadra.Trim(), 5);
                                        parcela_base = "0,00";
                                        //
                                        if (SreDblib.TemNaTabela("select * from " + nomearquivo + " where ativa = 1 and unidade = " + id_destino_unidade + " and parte = " + id_destino_parte + " and data_vencimento = " + Srelib.QStr(Srelib.DataAmericanasembarra(data_vencimento))))
                                        {
                                            parcela_sistema = "1o.OK";
                                            localizados++;
                                            //
                                            parcela_base = uParcelas.PegaValorParcela("41",
                                                                                      id_destino_quadra,
                                                                                      id_destino_unidade,
                                                                                      id_destino_parte,
                                                                                      proprietario,
                                                                                      data_vencimento);
                                            //
                                            parcela_ID = uParcelas.PegaIDParcela("41",
                                                                                 id_destino_quadra,
                                                                                 id_destino_unidade,
                                                                                 id_destino_parte,
                                                                                 proprietario,
                                                                                 data_vencimento);
                                        }
                                        else
                                        {

                                            //Tentativa de 2a. varredura
                                            if (ckpesquisaparcela.Checked)
                                            {
                                                if (SreDblib.TemNaTabela("select * from " + nomearquivo + " where ativa = 1 and unidade = " +
                                                    id_destino_unidade + " and parte = " + id_destino_parte +
                                                    " and parcela = " + Srelib.QStr(numeroparcela)))
                                                {
                                                    parcela_sistema = "2o.OK";
                                                    localizados++;
                                                    //
                                                    parcela_base = uParcelas.PegaValorParcelaNumeroParcela("41",
                                                                                                           id_destino_quadra,
                                                                                                           id_destino_unidade,
                                                                                                           id_destino_parte,
                                                                                                           proprietario,
                                                                                                           data_vencimento,
                                                                                                           numeroparcela);
                                                    //
                                                    parcela_ID = uParcelas.PegaIDParcelaNumeroParcela("41",
                                                                                                      id_destino_quadra,
                                                                                                      id_destino_unidade,
                                                                                                      id_destino_parte,
                                                                                                      proprietario,
                                                                                                      data_vencimento,
                                                                                                      numeroparcela);
                                                }
                                                else
                                                {
                                                    parcela_sistema = "2o.NÃO";
                                                    naolocalizados++;
                                                    parcela_ID = "0";
                                                    //
                                                }
                                            }
                                            else
                                            {
                                                parcela_sistema = "1o.NÃO";
                                                naolocalizados++;
                                                parcela_ID = "0";
                                                //
                                            }
                                            //Fim Tentativa de 2a. varredura
                                        }
                                    }
                                    else
                                    {
                                        parcela_sistema = "1o.NÃO";
                                        naolocalizados++;
                                        parcela_ID = "0";
                                    }
                                    //Fim Confirmar Parcela
                                    //
                                    //Fim Localizar Parcela
                                    //
                                    if ((ckplano1x1.Checked) &&
                                        ((plano == "1/1") ||
                                         (plano == "1/2") ||
                                         (plano == "2/2")))
                                    {
                                        if ((parcela_sistema == "1o.OK") || (parcela_sistema == "2o.OK"))
                                        {
                                            localizados--;
                                            naolocalizados++;
                                        }
                                        parcela_sistema = "1o.NÃO";
                                    }
                                    //
                                    //Calculo do Pagamento pelo Sistema
                                    //
                                    //Correção de Parcelas em Aberto
                                    //
                                    if (((parcela_sistema != "1o.NÃO") || (parcela_sistema != "2o.NÃO")) &&
                                       (Convert.ToDateTime(data_pagamento.ToString().Substring(0, 10)) >
                                        Convert.ToDateTime(data_vencimento.ToString().Substring(0, 10))))
                                    {
                                        //
                                        string vlrcorrecao = "0";
                                        string vlrjuros = "0";
                                        string vlrmulta = "0";
                                        string vlrdesconto = "0";
                                        string vlrpagamento = "0";
                                        string vlrpagamentofinal = "0";
                                        string edfeedback = "";
                                        string edindexadoracum = "";
                                        string periodicidade_comissao = uVendas.PegaPeriodicidade("41",
                                                                                                  id_destino_quadra,
                                                                                                  id_destino_unidade,
                                                                                                  id_destino_parte,
                                                                                                  proprietario);
                                        string txjuros = uVendas.PegaTaxaJuros("41",
                                                                               id_destino_quadra,
                                                                               id_destino_unidade,
                                                                               id_destino_parte,
                                                                               proprietario);
                                        string taxamulta = uVendas.PegaTaxaMulta("41",
                                                                               id_destino_quadra,
                                                                               id_destino_unidade,
                                                                               id_destino_parte,
                                                                               proprietario);
                                        Int64 diferencadias = Convert.ToInt64((Convert.ToDateTime(data_pagamento) - Convert.ToDateTime(data_vencimento)).TotalDays);
                                        //
                                        parcela_corrigida = parcela_base;
                                        //
                                        Boolean btprocessa2 = true;
                                        //
                                        //Correção Comentada.ScriptManager.RegisterStartupScript(UpdatePanel,
                                        //uCorrecoes.CorrecaoParcela("41",
                                        //                            id_destino_quadra,
                                        //                            id_destino_unidade,
                                        //                            id_destino_parte,
                                        //                            id_destino_parte,
                                        //                            Convert.ToDateTime(data_vencimento.ToString().Substring(0, 10)),
                                        //                            Convert.ToDateTime(data_pagamento.ToString().Substring(0, 10)),
                                        //                            parcela_base.ToString(),
                                        //                            ref vlrcorrecao,
                                        //                            ref vlrjuros,
                                        //                            ref vlrmulta,
                                        //                            ref vlrdesconto,
                                        //                            ref vlrpagamento,
                                        //                            ref vlrpagamentofinal,
                                        //                            ref btprocessa2,
                                        //                            ref edfeedback,
                                        //                            ref edindexadoracum,
                                        //                            periodicidade_comissao,
                                        //                            txjuros,
                                        //                            taxamulta,
                                        //                            diferencadias.ToString().Trim());
                                        //
                                        try
                                        {
                                            parcela_corrigida = Convert.ToString(
                                                                Convert.ToDouble(parcela_base) +
                                                                Convert.ToDouble(vlrcorrecao) +
                                                                Convert.ToDouble(vlrjuros) +
                                                                Convert.ToDouble(vlrmulta));
                                        }
                                        catch (Exception)
                                        {
                                            parcela_corrigida = parcela_base;
                                        }

                                        //
                                    }
                                    else
                                    {
                                        parcela_corrigida = parcela_base;
                                    }
                                    //
                                    //
                                    diferenca = "0,00";
                                    Double vlr_pgto_total_teste = 0;
                                    Boolean sinal_negativo = false;
                                    try
                                    {
                                        vlr_pgto_total_teste = Convert.ToDouble(vlr_pgto_total);
                                        sinal_negativo = false;
                                    }
                                    catch (Exception)
                                    {
                                        vlr_pgto_total_teste = Convert.ToDouble(Srelib.forcaponto(Srelib.tirasimbolos(vlr_pgto_total)));
                                        sinal_negativo = true;
                                    }
                                    //
                                    //Uso de Variavel em função do Sinal Negativo
                                    //
                                    if ((parcela_sistema != "1o.NÃO") || (parcela_sistema != "2o.NÃO"))
                                    {
                                        if (!sinal_negativo)
                                        {
                                            diferenca = Convert.ToString(
                                                        Srelib.ArredondarDecimais(
                                                        Convert.ToDouble(parcela_corrigida) -
                                                        Convert.ToDouble(vlr_pgto_total)));
                                        }
                                        else
                                        {
                                            parcela_sistema = "EXTORNO";
                                        }
                                        diferenca = String.Format("{0:N}", diferenca);
                                    }
                                    //
                                    //Fim Calculo do Pagamento pelo Sistema
                                    //
                                    //Incluir Lançamentos
                                    table1.Rows.Add(id_contador,
                                    data_pagamento,
                                    valor,
                                    valor_juros,
                                    valor_total,
                                    conta_cedente,
                                    apelido_cedente,
                                    identificador,
                                    plano,
                                    data_vencimento,
                                    vlr_pgto_base,
                                    vlr_pgto_juros,
                                    vlr_pgto_total,
                                    venda_ID,
                                    parcela_sistema,
                                    parcela_base,
                                    parcela_corrigida,
                                    diferenca,
                                    parcela_ID);
                                    //
                                    //
                                    data_pagamento = "";
                                    valor = "0,00";
                                    valor_juros = "";
                                    valor_total = "";
                                    conta_cedente = "";
                                    apelido_cedente = "";
                                    identificador = "";
                                    plano = "";
                                    data_vencimento = "";
                                    vlr_pgto_base = "";
                                    vlr_pgto_juros = "";
                                    vlr_pgto_total = "";
                                    venda_ID = "";
                                    parcela_sistema = "";
                                    parcela_corrigida = "";
                                    diferenca = "0,00";
                                    parcela_ID = "";
                                    //
                                    id_contador++;
                                    //Incluir Lançamentos
                                }
                            }
                            //Fim da Captura de Dados
                            //
                            //linha = leitor.ReadLine();
                        }
                        //leitor.Close();
                        //entrada.Close();
                        btprocessa.Enabled = true;
                        btimprime.Enabled = true;
                        //edfeedback.Text = "Carregamento Concluído!";
                        //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Carregamento Concluído!');", true);
                        ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                        "toastr.success('Carregamento Concluído!', 'Atenção!')", true);
                    }
                }
            }
            else
            {
                lOk = false;
                btprocessa.Enabled = false;
                btimprime.Enabled = false;
                //edfeedback.Text = "Arquivo(s) Não Encontrado! Verificar Pasta, Nome e Extensão.";
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Arquivo(s) Não Encontrado! Verificar Pasta, Nome e Extensão.');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Arquivo(s) Não Encontrado! Verificar Pasta, Nome e Extensão!', 'Atenção!')", true);
            }
            //
            DataView dataview = new DataView(table1);
            dataview.Sort = "data_pagamento, identificador ASC";
            DataTable table2 = dataview.ToTable();
            //
            dsparcelas.Clear();
            dsparcelas = new DataSet("table");
            dsparcelas.Tables.Add(table2);
            //
            Label6.Text = "Conteúdo Arquivo Retorno: " + dsparcelas.Tables[0].Rows.Count.ToString().Trim() + " Registros " +
                " - Localizados: " + localizados.ToString().Trim() + " - Não Localizados: " + naolocalizados.ToString().Trim();
            //
            GridListagem.DataSource = dsparcelas;
            GridListagem.KeyFieldName = "data_pagamento";
            GridListagem.DataBind();
            //
            //Fim Prepara Table e DataSet
            Label6.Visible = true;
            GridListagem.Visible = true;
            //
        }
        //Fim Carregar Arquivo modo TABELA
    }

    protected void btimprime_Click(object sender, EventArgs e)
    {
        //
        Boolean lOk = true;
        string tst = "";
        //CRITICAS
        //
        //Captura dos Registros
        DataTable table1 = new DataTable();
        foreach (GridViewColumn col in GridListagem.VisibleColumns)
        {
            GridViewDataColumn dataColumn = col as GridViewDataColumn;
            if (dataColumn == null) continue;
            table1.Columns.Add(dataColumn.FieldName);
        }
        for (int i = 0; i < GridListagem.VisibleRowCount; i++)
        {
            DataRow row = table1.Rows.Add();
            foreach (DataColumn col in table1.Columns)
                row[col.ColumnName] = GridListagem.GetRowValues(i, col.ColumnName);
        }
        dsparcelas.Clear();
        dsparcelas = new DataSet("table");
        dsparcelas.Tables.Add(table1);
        //Fim Captura dos Registros
        //
        if (lOk)
        {
            if (dsparcelas.Tables[0].Rows.Count > 0)
            {
                tst = dsparcelas.Tables[0].Rows[0]["data_pagamento"].ToString().Trim();
                //
                Session.Remove("dsparcelas");
                //Session["dsparcelas"] = dsparcelas;
                Session.Add("dsparcelas", dsparcelas);
            }
            else
            {
                lOk = false;
                edfeedback.Text = "Não Há registros para serem impressos!";
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Não Há registros para serem impressos!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Não Há registros para serem impressos!', 'Atenção!')", true);
            }
        }
        //
        if (lOk)
        {
            // CRIA LOG ===============================================================================================================================================
            fwObs_Log = "RELATÓRIO COBRANÇA NÃO BANCÁRIA: " + tst;
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ), 
                                         new SqlParameter("@tabela"   , fWtabela                              ),
                                         new SqlParameter("@operacao" , "PARCELAS"                            ),
                                         new SqlParameter("@obs"      , "COBRANÇA NÃO BANCÁRIA"               ),
                                         new SqlParameter("@acao"     , fwObs_Log                             ) };
            uLog.MakeLog(param_log);
            // FIM CRIA LOG ===============================================================================================================================================
            //
            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( '" + HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpRuntime.AppDomainAppVirtualPath + "/_Pagamentos/relatorios/RelPagamentosCobrancaNBancaria.aspx', null, 'height=755,width=900,status=yes,resizable=yes,menubar=yes,location=yes' );", true);
            //
        }
    }
}


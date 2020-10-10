using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class FAReceberImportacaoArquivo1 : System.Web.UI.Page
{
    DataTable dt = new DataTable();
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "CONTAS A RECEBER";

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = SreDblib.TemPermissao("001.007.001.000", (String)Session["CodUsuario"]);
        lAltera = false; //SreDbLib.TemPermissao("001.007.002.000", (String)Session["CodUsuario"]);
        lExclui = false; //SreDbLib.TemPermissao("001.007.003.000", (String)Session["CodUsuario"]);
        lConsulta = false; //SreDblib.TemPermissao("001.007.004.000", (String)Session["CodUsuario"]);
        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        //
        btprocessa.Enabled = lInsere;
        if (!lInsere)
            btprocessa.Image.ToolTip = Msg_acesso;
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
            //Carrega Arquivos
            try
            {
                loadFolder(lookuparquivos, Server.MapPath(@"~\Arquivos\Importacao\Creceber\Arquivo_texto\"));
            }
            catch (Exception)
            {
                edfeedback.Text = "Não foi possivel carregar os arquivos da pasta acima, verifique!";
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

    protected void btprocessa_Click(object sender, EventArgs e)
    {
        //
        Boolean lOk = true;
        //
        string tst = "";

        if (lOk)
        {
            //CRIAÇÃO DA VARIÁVEL DE SESSÃO COM OS ELEMENTOS SELECIONADOS NO LOOKUP  ===============================================================================================================================================
            //Arquivo
            tst = "";
            List<object> Listagem = lookuparquivos.GetSelectedFieldValues(new string[] { "Nome" });
            if (Listagem.Count == 1)
            {
                foreach (string xval in Listagem)
                {
                    if (tst != "")
                    {
                        tst = tst + ",";
                    }
                    tst = tst + xval;
                }
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Arquivo Não Selecionado!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.error('Arquivo Não Selecionado!', 'Atenção!')", true);
            }
        }
        //
        if (lOk)
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("classe");
            dt.Columns.Add("produto");
            dt.Columns.Add("cliente");
            dt.Columns.Add("data_prevista");
            dt.Columns.Add("vlr_previsto");
            dt.Columns.Add("descricao");
            dt.Columns.Add("conta");
            dt.Columns.Add("documento");
            dt.Columns.Add("data_documento");
            dt.Columns.Add("data_realizado");
            dt.Columns.Add("vlr_realizado");
            dt.Columns.Add("cheque");
            dt.Columns.Add("lancamento");
            //
            //Le arquivo
            string mensagem = "";
            string PastaSistema = "";
            PastaSistema = ConfigurationSettings.AppSettings["SRE_CaminhoGitanoSFin"];
            //
            List<string> mensagemLinha = new List<string>();
            //
            using (StreamReader texto = new StreamReader(PastaSistema + edpasta.Text + tst))
            {
                while ((mensagem = texto.ReadLine()) != null)
                {
                    mensagemLinha.Add(mensagem);
                }
            }
            int registro = mensagemLinha.Count; //total de linhas do arquivo. 
            //
            for (int i = 0; i < mensagemLinha.Count; i++)
            {
                TextBox textbox1 = new TextBox();
                textbox1.Text += mensagemLinha[i];
                //File.WriteAllText(PastaSistema + edpasta.Text + tst, mensagemLinha[i] + "1");
                //
                DataRow dr = dt.NewRow();
                //
                dr["ID"] = mensagemLinha[i].Substring(0, 1);
                dr["classe"] = mensagemLinha[i].Substring(1, 6);
                dr["classe"] = Convert.ToInt64(dr["classe"]).ToString();
                dr["produto"] = mensagemLinha[i].Substring(8, 4);
                dr["produto"] = Convert.ToInt64(dr["produto"]).ToString();
                dr["cliente"] = mensagemLinha[i].Substring(12, 7);
                dr["cliente"] = Convert.ToInt64(dr["cliente"]).ToString();
                dr["data_prevista"] = mensagemLinha[i].Substring(19, 9).Trim();
                if (dr["data_prevista"].ToString().Trim() != "")
                {
                    dr["data_prevista"] = dr["data_prevista"].ToString().Trim().Substring(0, 2) + "/" +
                                          dr["data_prevista"].ToString().Trim().Substring(3, 2) + "/" +
                                          dr["data_prevista"].ToString().Trim().Substring(4, 4);
                }
                else
                {
                    dr["data_prevista"] = "01/01/1900";
                }
                dr["vlr_previsto"] = mensagemLinha[i].Substring(29, 12);
                dr["descricao"] = mensagemLinha[i].Substring(41, 40);
                dr["conta"] = mensagemLinha[i].Substring(83, 3);
                dr["documento"] = mensagemLinha[i].Substring(86, 20);
                dr["data_documento"] = mensagemLinha[i].Substring(96, 8);
                if (dr["data_documento"].ToString().Trim() != "")
                {
                    dr["data_documento"] = dr["data_documento"].ToString().Trim().Substring(0, 2) + "/" +
                                           dr["data_documento"].ToString().Trim().Substring(3, 2) + "/" +
                                           dr["data_documento"].ToString().Trim().Substring(4, 4);
                }
                else
                {
                    dr["data_documento"] = "01/01/1900";
                }
                dr["data_realizado"] = mensagemLinha[i].Substring(127, 8);
                if (dr["data_documento"].ToString().Trim() != "")
                {
                    dr["data_realizado"] = dr["data_realizado"].ToString().Trim().Substring(0, 2) + "/" +
                                           dr["data_realizado"].ToString().Trim().Substring(3, 2) + "/" +
                                           dr["data_realizado"].ToString().Trim().Substring(4, 4);
                }
                else
                {
                    dr["data_realizado"] = "01/01/1900";
                }
                dr["vlr_realizado"] = mensagemLinha[i].Substring(137, 12);
                dr["cheque"] = mensagemLinha[i].Substring(149, 9);
                dr["lancamento"] = ""; // mensagemLinha[i].Substring(232, 10);
                //
                dt.Rows.Add(dr);
            }
        }
        if (lOk)
        {
            //Processamento 
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                //
                uContasReceber.Grava(uContasReceber.PegaNovoCodigoCReceber(),
                                     dt.Rows[i]["produto"].ToString().Trim(),
                                     dt.Rows[i]["classe"].ToString().Trim(),
                                     dt.Rows[i]["cliente"].ToString().Trim(),
                                     dt.Rows[i]["descricao"].ToString().Trim(),
                                     dt.Rows[i]["data_prevista"].ToString().Trim(),
                                     Convert.ToDecimal(dt.Rows[i]["vlr_previsto"].ToString().Trim()),
                                     dt.Rows[i]["data_realizado"].ToString().Trim(),
                                     Convert.ToDecimal(dt.Rows[i]["vlr_realizado"].ToString().Trim()),
                                     dt.Rows[i]["conta"].ToString().Trim(),
                                     dt.Rows[i]["documento"].ToString().Trim(),
                                     "01/01/1900",
                                     dt.Rows[i]["cheque"].ToString().Trim(),
                                     dt.Rows[i]["cheque"].ToString().Trim(),
                                     dt.Rows[i]["data_realizado"].ToString().Trim(),
                                     1,
                                     ""
                                     );
            }
            //
            // CRIA LOG ===============================================================================================================================================
            fwObs_Log = "IMPORTAÇÃO ARQUIVO CONTAS A RECEBER - TEXTO TIPO 1 : " + tst;
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ), 
                                         new SqlParameter("@tabela"   , fWtabela                              ),
                                         new SqlParameter("@operacao" , "CONTAS A RECEBER"                    ),
                                         new SqlParameter("@obs"      , "IMPORTAÇÃO ARQUIVO CONTAS A RECEBER" ),
                                         new SqlParameter("@acao"     , fwObs_Log                             ) };
            uLog.MakeLog(param_log);
            // FIM CRIA LOG ===============================================================================================================================================
            //
            btcarrega.Enabled = false;
            btprocessa.Enabled = false;
            edfeedback.Text = "Importação Concluída! (" + dt.Rows.Count.ToString() + ") Registros ";
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Importação Concluída!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                "toastr.success('Importação Concluída!', 'Atenção!')", true);

        }

    }

    public void loadFolder(ASPxGridView gv_arquivos, String folder)
    {

        DirectoryInfo pasta = new DirectoryInfo(folder);
        DirectoryInfo[] subPastas = pasta.GetDirectories();
        FileInfo[] arquivos = pasta.GetFiles();

        DataTable dt = new DataTable();

        dt.Columns.Add("Nome");
        dt.Columns.Add("Tamanho");
        dt.Columns.Add("Tipo");
        dt.Columns.Add("Modificado");
        dt.Columns.Add("Action");

        //if (folder != "")
        //{
        //    DataRow dr1 = dt.NewRow();
        //    dr1["Nome"] = "../";

        //    dr1["Tamanho"] = "";
        //    dr1["Tipo"] = "";
        //    dr1["Modificado"] = "";
        //    dr1["Action"] = "";

        //    dt.Rows.Add(dr1);
        //}

        foreach (DirectoryInfo dir in subPastas)
        {
            DataRow dr = dt.NewRow();
            dr["Nome"] = "/" + dir.Name;
            dr["Tamanho"] = "-";
            dr["Tipo"] = "Diretório";
            dr["Modificado"] = dir.LastWriteTime.ToString("dd/MM/yyyy");
            dr["Action"] = "";

            dt.Rows.Add(dr);
        }

        foreach (FileInfo file in arquivos)
        {
            DataRow dr = dt.NewRow();
            dr["Nome"] = file.Name;
            dr["Tamanho"] = Convert.ToString(file.Length / 1024) + " kb";
            dr["Tipo"] = file.Extension;
            dr["Modificado"] = file.LastWriteTime.ToString("dd/MM/yyyy");
            dr["Action"] = "";

            dt.Rows.Add(dr);
        }

        gv_arquivos.DataSource = dt;
        gv_arquivos.DataBind();

    }

    protected void btcarrega_Click(object sender, EventArgs e)
    {
        Boolean lOk = true;
        string tst = "";

        if (lOk)
        {
            //CRIAÇÃO DA VARIÁVEL DE SESSÃO COM OS ELEMENTOS SELECIONADOS NO LOOKUP  ===============================================================================================================================================
            //Arquivo
            tst = "";
            List<object> Listagem = lookuparquivos.GetSelectedFieldValues(new string[] { "Nome" });
            if (Listagem.Count == 1)
            {
                foreach (string xval in Listagem)
                {
                    if (tst != "")
                    {
                        tst = tst + ",";
                    }
                    tst = tst + xval;
                }
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Arquivo Não Selecionado!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.error('Arquivo Não Selecionado!', 'Atenção!')", true);
            }

        }
        if (lOk)
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("classe");
            dt.Columns.Add("produto");
            dt.Columns.Add("cliente");
            dt.Columns.Add("data_prevista");
            dt.Columns.Add("vlr_previsto");
            dt.Columns.Add("descricao");
            dt.Columns.Add("conta");
            dt.Columns.Add("documento");
            dt.Columns.Add("data_documento");
            dt.Columns.Add("data_realizado");
            dt.Columns.Add("vlr_realizado");
            dt.Columns.Add("cheque");
            dt.Columns.Add("lancamento");
            //
            //Le arquivo
            string mensagem = "";
            string PastaSistema = "";
            PastaSistema = ConfigurationSettings.AppSettings["SRE_CaminhoGitanoSFin"];
            //
            List<string> mensagemLinha = new List<string>();
            //
            using (StreamReader texto = new StreamReader(PastaSistema + edpasta.Text + tst))
            {
                while ((mensagem = texto.ReadLine()) != null)
                {
                    mensagemLinha.Add(mensagem);
                }
            }
            int registro = mensagemLinha.Count; //total de linhas do arquivo. 
            //
            for (int i = 0; i < mensagemLinha.Count; i++)
            {
                TextBox textbox1 = new TextBox();
                textbox1.Text += mensagemLinha[i];
                //File.WriteAllText(PastaSistema + edpasta.Text + tst, mensagemLinha[i] + "1");
                //
                DataRow dr = dt.NewRow();
                //
                dr["ID"] = mensagemLinha[i].Substring(0, 1);
                dr["classe"] = mensagemLinha[i].Substring(1, 6);
                dr["classe"] = Convert.ToInt64(dr["classe"]).ToString();
                dr["produto"] = mensagemLinha[i].Substring(8, 4);
                dr["produto"] = Convert.ToInt64(dr["produto"]).ToString();
                dr["cliente"] = mensagemLinha[i].Substring(12, 7);
                dr["cliente"] = Convert.ToInt64(dr["cliente"]).ToString();
                dr["data_prevista"] = mensagemLinha[i].Substring(19, 9).Trim();
                if (dr["data_prevista"].ToString().Trim() != "")
                {
                    dr["data_prevista"] = dr["data_prevista"].ToString().Trim().Substring(0, 2) + "/" +
                                          dr["data_prevista"].ToString().Trim().Substring(3, 2) + "/" +
                                          dr["data_prevista"].ToString().Trim().Substring(4, 4);
                }
                else
                {
                    dr["data_prevista"] = "01/01/1900";
                }
                dr["vlr_previsto"] = mensagemLinha[i].Substring(29, 12);
                dr["descricao"] = mensagemLinha[i].Substring(41, 40);
                dr["conta"] = mensagemLinha[i].Substring(83, 3);
                dr["documento"] = mensagemLinha[i].Substring(86, 20);
                dr["data_documento"] = mensagemLinha[i].Substring(96, 8);
                if (dr["data_documento"].ToString().Trim() != "")
                {
                    dr["data_documento"] = dr["data_documento"].ToString().Trim().Substring(0, 2) + "/" +
                                           dr["data_documento"].ToString().Trim().Substring(3, 2) + "/" +
                                           dr["data_documento"].ToString().Trim().Substring(4, 4);
                }
                else
                {
                    dr["data_documento"] = "01/01/1900";
                }
                dr["data_realizado"] = mensagemLinha[i].Substring(127, 8);
                if (dr["data_documento"].ToString().Trim() != "")
                {
                    dr["data_realizado"] = dr["data_realizado"].ToString().Trim().Substring(0, 2) + "/" +
                                           dr["data_realizado"].ToString().Trim().Substring(3, 2) + "/" +
                                           dr["data_realizado"].ToString().Trim().Substring(4, 4);
                }
                else
                {
                    dr["data_realizado"] = "01/01/1900";
                }
                dr["vlr_realizado"] = mensagemLinha[i].Substring(137, 12);
                dr["cheque"] = mensagemLinha[i].Substring(149, 9);
                dr["lancamento"] = ""; // mensagemLinha[i].Substring(232, 10);
                //
                dt.Rows.Add(dr);
            }

            GridListagem.Visible = true;
            GridListagem.DataSource = dt;
            GridListagem.DataBind();
            //
            edfeedback.Text = "Importante!!! Após clicar no botão Processa, aguarde o fim do Processamento.";

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


}

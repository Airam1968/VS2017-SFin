using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;

public partial class FMigracoesSimbolo : System.Web.UI.Page
{
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "PERMISSOES";
    string path = @"D:\GITANO\Projetos\VS2017\Desenvolvimento\Gitano\Arquivos\Migracao\SimboloDBF\";
    string fileName1 = @"status.dbf";
    DataSet ds0 = new DataSet();
    DataSet ds1 = new DataSet();
    string[] array_nometaxa = new string[300 + 1];
    //

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = SreDblib.TemPermissao("001.011.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.011.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.011.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.011.004.000", (String)Session["CodUsuario"]);
        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        //
        btprocessa.Enabled = lConsulta;
        if (!lConsulta)
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
            // Desabilitado até ser desenvolvido
            ckempresa.Enabled = true;
            ckparametros.Enabled = true;
            ckusuariopermissoes.Enabled = true;
            ckclientes.Enabled = true;
            ckproduto.Enabled = true;
            ckprodutotipo.Enabled = true;
            ckprodutogrupo1.Enabled = true;
            ckprodutogrupo2.Enabled = true;
            ckindexadores.Enabled = true;
            cktaxasdiarias.Enabled = true;
            cktaxasmensais.Enabled = true;
            ckmensagensboleto.Enabled = true;
            ckcorretores.Enabled = true;
            ckdespesas.Enabled = true;
            ckfornecedores.Enabled = true;
            ckreceitas.Enabled = true;
            ckclientescontaareceber.Enabled = true;
            ckbancos.Enabled = true;
            ckcontascorrentes.Enabled = true;
            cksaldoinicial.Enabled = true;
            cklancamentoscontasareceber.Enabled = true;
            cklancamentoscontasapagar.Enabled = true;
            ckunidades.Enabled = true;
            ckvendas.Enabled = true;
            ckparcelas.Enabled = true;
            cklog.Enabled = true;
            ckcartas.Enabled = true;

            MemoAtividades.Text = "";
        }

    }


    protected void btmarcar_Click(object sender, EventArgs e)
    {
        //
        ckempresa.Checked = true;
        ckparametros.Checked = true;
        ckusuariopermissoes.Checked = true;
        ckclientes.Checked = true;
        ckproduto.Checked = true;
        ckprodutotipo.Checked = true;
        ckprodutogrupo1.Checked = true;
        ckprodutogrupo2.Checked = true;
        ckindexadores.Checked = true;
        cktaxasdiarias.Checked = true;
        cktaxasmensais.Checked = true;
        ckmensagensboleto.Checked = true;
        ckcorretores.Checked = true;
        ckdespesas.Checked = true;
        ckfornecedores.Checked = true;
        ckreceitas.Checked = true;
        ckclientescontaareceber.Checked = true;
        ckbancos.Checked = true;
        ckcontascorrentes.Checked = true;
        cksaldoinicial.Checked = true;
        cklancamentoscontasareceber.Checked = true;
        cklancamentoscontasapagar.Checked = true;
        ckunidades.Checked = true;
        ckvendas.Checked = true;
        ckparcelas.Checked = true;
        cklog.Checked = true;
        ckcartas.Checked = true;
    }

    protected void btdesmarcar_Click(object sender, EventArgs e)
    {
        //
        ckempresa.Checked = false;
        ckparametros.Checked = false;
        ckusuariopermissoes.Checked = false;
        ckclientes.Checked = false;
        ckproduto.Checked = false;
        ckprodutotipo.Checked = false;
        ckprodutogrupo1.Checked = false;
        ckprodutogrupo2.Checked = false;
        ckindexadores.Checked = false;
        cktaxasdiarias.Checked = false;
        cktaxasmensais.Checked = false;
        ckmensagensboleto.Checked = false;
        ckcorretores.Checked = false;
        ckdespesas.Checked = false;
        ckfornecedores.Checked = false;
        ckreceitas.Checked = false;
        ckclientescontaareceber.Checked = false;
        ckbancos.Checked = false;
        ckcontascorrentes.Checked = false;
        cksaldoinicial.Checked = false;
        cklancamentoscontasareceber.Checked = false;
        cklancamentoscontasapagar.Checked = false;
        ckunidades.Checked = false;
        ckvendas.Checked = false;
        ckparcelas.Checked = false;
        cklog.Checked = false;
        ckcartas.Checked = false;
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
        MemoAtividades.Text = "";

        if (lOk)
        {
            if (
               (!ckempresa.Checked) &&
               (!ckparametros.Checked) &&
               (!ckusuariopermissoes.Checked) &&
               (!ckclientes.Checked) &&
               (!ckproduto.Checked) &&
               (!ckprodutotipo.Checked) &&
               (!ckprodutogrupo1.Checked) &&
               (!ckprodutogrupo2.Checked) &&
               (!ckindexadores.Checked) &&
               (!cktaxasdiarias.Checked) &&
               (!cktaxasmensais.Checked) &&
               (!ckmensagensboleto.Checked) &&
               (!ckcorretores.Checked) &&
               (!ckdespesas.Checked) &&
               (!ckfornecedores.Checked) &&
               (!ckreceitas.Checked) &&
               (!ckclientescontaareceber.Checked) &&
               (!ckbancos.Checked) &&
               (!ckcontascorrentes.Checked) &&
               (!cksaldoinicial.Checked) &&
               (!cklancamentoscontasareceber.Checked) &&
               (!cklancamentoscontasapagar.Checked) &&
               (!ckunidades.Checked) &&
               (!ckvendas.Checked) &&
               (!ckparcelas.Checked) &&
               (!cklog.Checked) &&
               (!ckcartas.Checked)
                )
            {
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Nenhuma Tabela marcada para ser migrada!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.info('Nenhuma Tabela marcada para ser migrada!', 'Atenção!')", true);
                lOk = false;
            }
        }

        if (lOk)
        {
            //Verificar Pasta
            DirectoryInfo dir = new DirectoryInfo(path);
            if (!dir.Exists)
            {
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Diretorio não existe ou Usuário não possui direitos sobre ele!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                                    "toastr.info('Diretorio não existe ou Usuário não possui direitos sobre ele!', 'Atenção!')", true);
                lOk = false;
            }

        }

        if (lOk)
        {
            //Abre Arquivo Teste
            string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
            try
            {
                using (OleDbConnection con = new OleDbConnection(constr))
                {
                    var sql = "select * from " + fileName1 + "  ";
                    OleDbCommand cmd = new OleDbCommand(sql, con);
                    con.Open();
                    //DataSet ds = new DataSet();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(ds0);
                    con.Close();

                    MemoAtividades.Text = MemoAtividades.Text + "Inicio Migração: " + DateTime.Now.ToString() + "\n\n";
                    MemoAtividades.Text = MemoAtividades.Text + "Diretório: " + path + "\n\n";
                    MemoAtividades.Text = MemoAtividades.Text + "Arquivo Teste: " + fileName1 + "\n\n";
                    MemoAtividades.Text = MemoAtividades.Text + "Empresa Localizada: " + ds0.Tables[0].Rows[0]["empresa"].ToString() + "\n\n";


                }
            }
            catch (Exception)
            {
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel abrir a conexão para os arquivos DBF (status.dbf), Inexistente ou aberto!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Não foi possivel abrir a conexão para os arquivos DBF, Inexistente ou aberto!', 'Atenção!')", true);
                lOk = false;
            }

        }

        if (lOk)
        {
            //Processamento
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Todos os dados das tabelas envolvidas serão apagados na base destino de forma irreversível!');", true);

            // CRIA LOG  ===============================================================================================================================================
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]),
                                         new SqlParameter("@tabela"   , "TODAS"                      ),
                                         new SqlParameter("@operacao" , "CONFIG"                     ),
                                         new SqlParameter("@obs"      , "MIGRAÇÃO"                   ),
                                         new SqlParameter("@acao"     , "MIGRAÇÃO DADOS SIMBOLO"     ) };
            uLog.MakeLog(param_log);
            // FIM CRIA LOG ============================================================================================================================================

            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Feche Todos os Arquivos abertos DBFs e SQL!');", true);

            if (ckempresa.Checked)
            {
                MigrarEmpresa();
            }
            //
            if (ckparametros.Checked)
            {
                MigrarParametros();
            }
            //
            if (ckusuariopermissoes.Checked)
            {
                Migrarusuariopermissoes();
            }
            //
            if (ckclientes.Checked)
            {
                MigrarClientes();
            }
            //
            if (ckproduto.Checked)
            {
                MigrarProdutos();
            }
            //
            if (ckprodutotipo.Checked)
            {
                MigrarProdutosTipo();
            }
            //
            if (ckprodutogrupo1.Checked)
            {
                MigrarProdutosGrupo(1);
            }
            //
            if (ckprodutogrupo2.Checked)
            {
                MigrarProdutosGrupo(2);
            }
            //
            if (ckindexadores.Checked)
            {
                MigrarIndexadores();
            }
            //
            if (cktaxasdiarias.Checked)
            {
                CriaTabelaTaxasDiarias();
                MigrarTaxasDiarias();
            }
            //
            if (cktaxasmensais.Checked)
            {
                CriarTabelaTaxasMensais();
                MigrarTaxasMensais();
            }
            //
            if (ckmensagensboleto.Checked)
            {
                MigrarMensagensBoleto();
            }
            //
            if (ckcorretores.Checked)
            {
                MigrarCorretores();
            }
            //
            if (ckdespesas.Checked)
            {
                MigrarClassificacaoDespesas();
            }
            //
            if (ckfornecedores.Checked)
            {
                MigrarFornecedores();
            }
            //
            if (ckreceitas.Checked)
            {
                MigrarClassificacaoReceitas();
            }
            //
            if (ckclientescontaareceber.Checked)
            {
                MigrarClientesContasaReceber();
            }
            //
            if (ckbancos.Checked)
            {
                MigrarBancos();
            }
            //
            if (ckcontascorrentes.Checked)
            {
                MigrarContasCorrentes();
            }
            //
            if (cksaldoinicial.Checked)
            {
                MigrarSaldoInicial();
            }
            //
            if (cklancamentoscontasareceber.Checked)
            {
                MigrarLancamentosContasaReceber();
            }
            //
            if (cklancamentoscontasapagar.Checked)
            {
                MigrarLancamentosContasaPagar();
            }
            //
            if (ckunidades.Checked)
            {
                MigrarUnidades();
            }
            //
            if (ckvendas.Checked)
            {
                MigrarVendas();
                MigrarRenegociacoes();
            }
            //
            if (ckparcelas.Checked)
            {
                MigrarParcelasGrupo1();
                MigrarParcelasGrupo2();
                MigrarParcelasEspeciais(); //Renegociações-Desistências
            }
            //
            if (cklog.Checked)
            {
                Migrarlog();
            }

            //
            if (ckcartas.Checked)
            {
                MigrarCartas();
            }

            //
            //
            btdesmarcar_Click(sender, e);
            btprocessa.Enabled = true;
            btmarcar.Enabled = true;
            btdesmarcar.Enabled = true;
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Processamento Concluído!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.success('Processamento Concluído!', 'Atenção!')", true);
        }
    }

    private void MigrarEmpresa()
    {
        //Migração Arquivo Empresa
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"status.dbf";
                var sql = "select * from " + fileName1 + "  ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete empresa");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Empresa, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Empresa Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Empresa!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Empresa!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Empresa Não OK \n\n";
        }

        //Migração
        if (lOk)
        {
            string apelido = "";
            string nome = "";
            string cnpj = "";
            Boolean matriz = true;
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
            //for (int row = 0; row < ds.Tables[row].Rows.Count; row++)
            int row = 0;
            {
                // Empresa
                apelido = ds0.Tables[0].Rows[row]["empresa"].ToString();
                if (apelido.Length >= 20)
                    apelido = apelido.Substring(0, 20);
                nome = ds0.Tables[0].Rows[row]["empresa"].ToString();
                cnpj = "";
                if (ds0.Tables[0].Rows[row]["cgc_cpf"].ToString().Trim() != String.Empty)
                    if (ds0.Tables[0].Rows[row]["cgc_cpf"].ToString().Length >= 14)
                    {
                        cnpj = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["cgc_cpf"].ToString());
                        if (cnpj.Length >= 14)
                            cnpj = cnpj.Substring(0, 14);
                    }
                    else
                    {
                        cnpj = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["cgc_cpf"].ToString());
                    }
                matriz = true;
                inscmunicipal = ds0.Tables[0].Rows[row]["inscricao"].ToString();
                inscestadual = ds0.Tables[0].Rows[row]["inscricao"].ToString();
                regjuntacom = "";
                nire = "";
                enderecocom = ds0.Tables[0].Rows[row]["endereco"].ToString();
                enderecocomnumero = "";
                enderecocomcomplem = "";
                bairrocom = ds0.Tables[0].Rows[row]["bairro"].ToString();
                cidadecom = ds0.Tables[0].Rows[row]["cidade"].ToString();
                ufcom = ds0.Tables[0].Rows[row]["estado"].ToString().Substring(0, 2);
                cepcom = ds0.Tables[0].Rows[row]["cep"].ToString().Substring(0, 8);
                fone1com = ds0.Tables[0].Rows[row]["tel1"].ToString();
                fone2com = ds0.Tables[0].Rows[row]["tel2"].ToString();
                fone3com = "";
                email1 = ds0.Tables[0].Rows[row]["email"].ToString();
                email2 = "";
                email3 = "";
                email4 = "";
                email5 = "";
                gerente = "GERAL";
                contato = ds0.Tables[0].Rows[row]["contato"].ToString();
                dtnascimento = Convert.ToDateTime("01/01/1900");
                dtingresso = DateTime.Now;
                ncontrato = "";
                dtcontrato = Convert.ToDateTime("01/01/1900");
                ativo = true;
                acessointernet = true;
                obs1 = "";
                obs2 = "";
                obs3 = "";
                obs4 = "";
                obs5 = "";
                instrcob1 = "";
                instrcob2 = "";
                diasprotesto = "";
                conta1 = "";
                conta2 = "";
                conta3 = "";
                conta4 = "";
                conta5 = "";

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

                if (lOk)
                {
                    //feedback
                    MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                    MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                    MemoAtividades.Text = MemoAtividades.Text + "Empresa OK \n\n";
                }

                //Fim Migração Arquivo Empresa
            }
        }
    }

    private void MigrarParametros()
    {
        //Migração Arquivo Parâmetros
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"status.dbf";
                var sql = "select * from " + fileName1 + "  ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                //try
                //{
                //    SreDblib.ExecScript("delete parametros");
                //}
                //catch (Exception)
                //{
                //    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Parâmetros, possivel registros filhos relacionados. \n";
                //    MemoAtividades.Text = MemoAtividades.Text + "Parâmetros Não OK \n\n";
                //    lOk = false;
                //}
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Parâmetros!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Parâmetros!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Parâmetros Não OK \n\n";
        }

        //Migração
        if (lOk)
        {
            //Parametros           
            string anatocismo = "NAO";
            string caminho_relatórios = "NAO";
            string drive_relatórios = "NAO";
            string comissao_periodo = "NAO";
            string comissao_taxa = "NAO";
            string corrige_atrasada = "NAO";
            string corrige_boleto = "NAO";
            string corrige_inativa = "NAO";
            string corrige_paga = "NAO";
            string desconto_periodo = "NAO";
            string desconto_taxa = "NAO";
            string juros_pro_rata = "NAO";
            string multa = "NAO";
            string multiempresa = "NAO";
            string proximo_cliente = "NAO";
            string proximo_cliente_cr = "NAO";
            string proximo_cpagar = "NAO";
            string proximo_creceber = "NAO";
            string proximo_fornecedor = "NAO";
            string proximo_recibo = "NAO";
            string reindexacao = "NAO";
            string residuo_13_parcela = "NAO";
            string residuo_13_separado = "NAO";
            string sistema = "NAO";
            string sistema_mail = "NAO";
            string sistema_moeda = "NAO";
            string sistema_versao = "NAO";
            string baixa_inativa = "NAO";
            string ordem_produto = "CÓDIGO";
            string ordem_fornecedor = "CÓDIGO";
            string ordem_despesa = "CÓDIGO";
            string ordem_cliente = "CÓDIGO";
            string ordem_receita = "CÓDIGO";
            string relatorio_zebrado = "SIM";

            //
            //for (int row = 0; row < ds.Tables[row].Rows.Count; row++)
            int row = 0;
            {
                //Parametros  
                if (ds0.Tables[0].Rows[row]["anatocismo"].ToString() == "True")
                    anatocismo = "SIM";

                drive_relatórios = ds0.Tables[0].Rows[row]["drive_rel"].ToString();
                caminho_relatórios = ds0.Tables[0].Rows[row]["pasta_rel"].ToString();
                comissao_periodo = "a.m.";
                comissao_taxa = ds0.Tables[0].Rows[row]["com_perm"].ToString();
                if (ds0.Tables[0].Rows[row]["corr_atra"].ToString() == "True")
                    corrige_atrasada = "SIM";
                if (ds0.Tables[0].Rows[row]["corr_bole"].ToString() == "True")
                    corrige_boleto = "SIM";
                corrige_inativa = "NAO";
                if (ds0.Tables[0].Rows[row]["corr_pgto"].ToString() == "True")
                    corrige_paga = "SIM";
                desconto_periodo = "a.m.";
                desconto_taxa = ds0.Tables[0].Rows[row]["desconto"].ToString();
                if (ds0.Tables[0].Rows[row]["pro_rata"].ToString() == "True")
                    juros_pro_rata = "SIM";
                multa = ds0.Tables[0].Rows[row]["multa"].ToString();
                multiempresa = "SIM";
                proximo_cliente = ds0.Tables[0].Rows[row]["num_clie"].ToString();
                proximo_cliente_cr = ds0.Tables[0].Rows[row]["clie_cpg"].ToString();
                proximo_cpagar = ds0.Tables[0].Rows[row]["lanc_cpg"].ToString();
                proximo_creceber = ds0.Tables[0].Rows[row]["lanc_cre"].ToString();
                proximo_fornecedor = ds0.Tables[0].Rows[row]["forn_cpg"].ToString();
                proximo_recibo = ds0.Tables[0].Rows[row]["num_reci"].ToString();
                reindexacao = ds0.Tables[0].Rows[row]["controle"].ToString();
                if (ds0.Tables[0].Rows[row]["residuo_i"].ToString() == "True")
                    residuo_13_parcela = "SIM";
                if (ds0.Tables[0].Rows[row]["resi_sepa"].ToString() == "True")
                    residuo_13_separado = "SIM";
                sistema = ds0.Tables[0].Rows[row]["sistema"].ToString();
                if (ds0.Tables[0].Rows[row]["email"].ToString() != "")
                    sistema_mail = ds0.Tables[0].Rows[row]["email"].ToString();
                else
                    sistema_mail = "airam1968@terra.com.br";
                sistema_moeda = ds0.Tables[0].Rows[row]["moeda"].ToString();
                sistema_versao = ds0.Tables[0].Rows[row]["versao"].ToString();
                try
                {
                    if (ds0.Tables[0].Rows[row]["baixa_ativ"].ToString() == "True")
                        baixa_inativa = "SIM";
                    //
                    if (ds0.Tables[0].Rows[row]["orde_clar"].ToString() == "True")
                        ordem_receita = "DESCRIÇÃO";
                    if (ds0.Tables[0].Rows[row]["orde_clad"].ToString() == "True")
                        ordem_receita = "DESCRIÇÃO";
                    //
                    if (ds0.Tables[0].Rows[row]["orde_forn"].ToString() == "True")
                        ordem_fornecedor = "DESCRIÇÃO";
                    if (ds0.Tables[0].Rows[row]["orde_clie"].ToString() == "True")
                        ordem_cliente = "DESCRIÇÃO";
                    //
                    if (ds0.Tables[0].Rows[row]["orde_clas"].ToString() == "True")
                        ordem_produto = "DESCRIÇÃO";
                }
                catch (Exception)
                {
                    baixa_inativa = "SIM";
                    ordem_receita = "DESCRIÇÃO";
                    ordem_receita = "DESCRIÇÃO";
                    ordem_fornecedor = "DESCRIÇÃO";
                    ordem_cliente = "DESCRIÇÃO";
                    ordem_produto = "DESCRIÇÃO";
                }

                //
                uParametros.AlteraMigracao("ANATOCISMO", anatocismo);
                uParametros.AlteraMigracao("CAMINHO RELATÓRIOS", caminho_relatórios);
                uParametros.AlteraMigracao("COMISSAO PERIODO", comissao_periodo);
                uParametros.AlteraMigracao("COMISSAO TAXA", comissao_taxa);
                uParametros.AlteraMigracao("CORRIGE ATRASADA", corrige_atrasada);
                uParametros.AlteraMigracao("CORRIGE BOLETO", corrige_boleto);
                uParametros.AlteraMigracao("CORRIGE INATIVA", corrige_inativa);
                uParametros.AlteraMigracao("CORRIGE PAGA", corrige_paga);
                uParametros.AlteraMigracao("DESCONTO PERIODO", desconto_periodo);
                uParametros.AlteraMigracao("DESCONTO TAXA", desconto_taxa);
                uParametros.AlteraMigracao("JUROS PRO-RATA", juros_pro_rata);
                uParametros.AlteraMigracao("MULTA", multa);
                uParametros.AlteraMigracao("MULTIEMPRESA", multiempresa);
                uParametros.AlteraMigracao("PROXIMO CLIENTE", proximo_cliente);
                uParametros.AlteraMigracao("PROXIMO CLIENTE CR", proximo_cliente_cr);
                uParametros.AlteraMigracao("PROXIMO CPAGAR", proximo_cpagar);
                uParametros.AlteraMigracao("PROXIMO CRECEBER", proximo_creceber);
                uParametros.AlteraMigracao("PROXIMO FORNECEDOR", proximo_fornecedor);
                uParametros.AlteraMigracao("PROXIMO RECIBO", proximo_recibo);
                uParametros.AlteraMigracao("REINDEXACAO", reindexacao);
                uParametros.AlteraMigracao("RESIDUO 13 PARCELA", residuo_13_parcela);
                uParametros.AlteraMigracao("RESIDUO 13 SEPARADO", residuo_13_separado);
                uParametros.AlteraMigracao("SISTEMA", sistema);
                uParametros.AlteraMigracao("SISTEMA_MAIL", sistema_mail);
                uParametros.AlteraMigracao("SISTEMA_MOEDA", sistema_moeda);
                uParametros.AlteraMigracao("SISTEMA_VERSAO", sistema_versao);
                uParametros.AlteraMigracao("BAIXA INATIVO", baixa_inativa);
                //
                uParametros.AlteraMigracao("ORDEM PRODUTO", ordem_produto);
                uParametros.AlteraMigracao("ORDEM CLIENTE", ordem_cliente);
                uParametros.AlteraMigracao("ORDEM FORNECEDOR", ordem_fornecedor);
                uParametros.AlteraMigracao("ORDEM RECEITA", ordem_receita);
                uParametros.AlteraMigracao("ORDEM DESPESA", ordem_despesa);
                //
            }

            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Parâmetros OK \n\n";
            }

        }
        //Fim Passagem de Parâmetros

    }

    private void Migrarusuariopermissoes()
    {
        //Migração Arquivo Usuários e Permissões
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"cad_usu.dbf";
                var sql = "select * from " + fileName1 + "  ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete permissoes");
                    SreDblib.ExecScript("delete usuario");

                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores das Tabelas Usuários e Permissões. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Usuários e Permissões Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Usuários e Permissões!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Usuários!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Usuários e Permissões Não OK \n\n";
        }

        //Migração
        if (lOk)
        {

            string login = "";
            string senha = "";
            string nome = "";
            string setor = "";
            string funcao = "";
            string fone = "";
            int perfil = 0;
            string email = "";
            string alcada = "";
            Boolean ativo = true;

            //
            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                // Usuários
                login = ds0.Tables[0].Rows[row]["usuario"].ToString();
                senha = ds0.Tables[0].Rows[row]["senha"].ToString();
                nome = ds0.Tables[0].Rows[row]["usuario"].ToString();
                setor = "";
                funcao = "";
                fone = "";
                perfil = 0;
                email = "";
                alcada = "";
                ativo = true;

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

                // Fim Usuários
                //
                // Permissões
                // Propostas
                login = login.ToUpper();
                //
                uPermissoes.Grava(login, "001.001.000.000");
                // Propostas Cadastro
                uPermissoes.Grava(login, "001.001.001.000");
                // Propostas Alterar
                uPermissoes.Grava(login, "001.001.002.000");
                // Propostas Excluir
                uPermissoes.Grava(login, "001.001.003.000");
                // Propostas Consultar
                uPermissoes.Grava(login, "001.001.004.000");
                // Propostas Relatórios
                uPermissoes.Grava(login, "001.001.005.000");
                //
                // Clientes
                uPermissoes.Grava(login, "001.002.000.000");
                // DI_CA_01 = Clientes Cadastro
                if (ds0.Tables[0].Rows[row]["DI_CA_01"].ToString() == "True")
                    uPermissoes.Grava(login, "001.002.001.000");
                // DI_AL_01 = Clientes Alterar
                if (ds0.Tables[0].Rows[row]["DI_AL_01"].ToString() == "True")
                    uPermissoes.Grava(login, "001.002.002.000");
                // DI_EX_01 = Clientes Excluir
                if (ds0.Tables[0].Rows[row]["DI_EX_01"].ToString() == "True")
                    uPermissoes.Grava(login, "001.002.003.000");
                // DI_CO_01 = Clientes Consultar
                if (ds0.Tables[0].Rows[row]["DI_CO_01"].ToString() == "True")
                    uPermissoes.Grava(login, "001.002.004.000");
                // DI_RE_01 = Clientes Relatórios
                if (ds0.Tables[0].Rows[row]["DI_RE_01"].ToString() == "True")
                    uPermissoes.Grava(login, "001.002.005.000");
                //
                // Produtos
                uPermissoes.Grava(login, "001.003.000.000");
                // DI_CA_02 = Produtos Cadastro
                if (ds0.Tables[0].Rows[row]["DI_CA_02"].ToString() == "True")
                    uPermissoes.Grava(login, "001.003.001.000");
                // DI_AL_02 = Produtos Alterar
                if (ds0.Tables[0].Rows[row]["DI_AL_02"].ToString() == "True")
                    uPermissoes.Grava(login, "001.003.002.000");
                // DI_EX_02 = Produtos Excluir
                if (ds0.Tables[0].Rows[row]["DI_EX_02"].ToString() == "True")
                    uPermissoes.Grava(login, "001.003.003.000");
                // DI_CO_02 = Produtos Consultar
                if (ds0.Tables[0].Rows[row]["DI_CO_02"].ToString() == "True")
                    uPermissoes.Grava(login, "001.003.004.000");
                // DI_RE_02 = Produtos Relatórios
                if (ds0.Tables[0].Rows[row]["DI_RE_02"].ToString() == "True")
                    uPermissoes.Grava(login, "001.003.005.000");
                //
                // Vendas
                uPermissoes.Grava(login, "001.004.000.000");
                // DI_CA_03 = Vendas Cadastro
                if (ds0.Tables[0].Rows[row]["DI_CA_03"].ToString() == "True")
                    uPermissoes.Grava(login, "001.004.001.000");
                // DI_AL_03 = Vendas Alterar
                if (ds0.Tables[0].Rows[row]["DI_AL_03"].ToString() == "True")
                    uPermissoes.Grava(login, "001.004.002.000");
                // DI_EX_03 = Vendas Excluir
                if (ds0.Tables[0].Rows[row]["DI_EX_03"].ToString() == "True")
                    uPermissoes.Grava(login, "001.004.003.000");
                // DI_CO_03 = Vendas Consultar
                if (ds0.Tables[0].Rows[row]["DI_CO_03"].ToString() == "True")
                    uPermissoes.Grava(login, "001.004.004.000");
                // DI_RE_03 = Vendas Relatórios
                if (ds0.Tables[0].Rows[row]["DI_RE_04"].ToString() == "True")
                    uPermissoes.Grava(login, "001.004.005.000");
                //
                // Pagamentos
                uPermissoes.Grava(login, "001.005.000.000");
                // DI_CA_03 = Pagamentos Cadastro
                if (ds0.Tables[0].Rows[row]["DI_CA_03"].ToString() == "True")
                    uPermissoes.Grava(login, "001.005.001.000");
                // DI_AL_03 = Pagamentos Alterar
                if (ds0.Tables[0].Rows[row]["DI_AL_03"].ToString() == "True")
                    uPermissoes.Grava(login, "001.005.002.000");
                // DI_EX_03 = Pagamentos Excluir
                if (ds0.Tables[0].Rows[row]["DI_EX_03"].ToString() == "True")
                    uPermissoes.Grava(login, "001.005.003.000");
                // DI_CO_03 = Pagamentos Consultar
                if (ds0.Tables[0].Rows[row]["DI_CO_03"].ToString() == "True")
                    uPermissoes.Grava(login, "001.005.004.000");
                // DI_RE_03 = Pagamentos Relatórios
                if (ds0.Tables[0].Rows[row]["DI_RE_04"].ToString() == "True")
                    uPermissoes.Grava(login, "001.005.005.000");
                //
                // Contas a Pagar
                uPermissoes.Grava(login, "001.006.000.000");
                // DI_CA_04 = Contas a Pagar Cadastro
                if (ds0.Tables[0].Rows[row]["DI_CA_04"].ToString() == "True")
                    uPermissoes.Grava(login, "001.006.001.000");
                // DI_AL_04 = Contas a Pagar Alterar
                if (ds0.Tables[0].Rows[row]["DI_AL_04"].ToString() == "True")
                    uPermissoes.Grava(login, "001.006.002.000");
                // DI_EX_04 = Contas a Pagar Excluir
                if (ds0.Tables[0].Rows[row]["DI_EX_04"].ToString() == "True")
                    uPermissoes.Grava(login, "001.006.003.000");
                // DI_CO_04 = Contas a Pagar Consultar
                if (ds0.Tables[0].Rows[row]["DI_CO_04"].ToString() == "True")
                    uPermissoes.Grava(login, "001.006.004.000");
                // DI_RE_04 = Contas a Pagar Relatórios
                if (ds0.Tables[0].Rows[row]["DI_RE_04"].ToString() == "True")
                    uPermissoes.Grava(login, "001.006.005.000");
                //
                // Contas a Receber
                uPermissoes.Grava(login, "001.007.000.000");
                // DI_CA_05 = Contas a Receber Cadastro
                if (ds0.Tables[0].Rows[row]["DI_CA_05"].ToString() == "True")
                    uPermissoes.Grava(login, "001.007.001.000");
                // DI_AL_05 = Contas a Receber Alterar
                if (ds0.Tables[0].Rows[row]["DI_AL_05"].ToString() == "True")
                    uPermissoes.Grava(login, "001.007.002.000");
                // DI_EX_05 = Contas a Receber Excluir
                if (ds0.Tables[0].Rows[row]["DI_EX_05"].ToString() == "True")
                    uPermissoes.Grava(login, "001.007.003.000");
                // DI_CO_05 = Contas a Receber Consultar
                if (ds0.Tables[0].Rows[row]["DI_CO_05"].ToString() == "True")
                    uPermissoes.Grava(login, "001.007.004.000");
                // DI_RE_05 = Contas a Receber Relatórios
                if (ds0.Tables[0].Rows[row]["DI_RE_05"].ToString() == "True")
                    uPermissoes.Grava(login, "001.007.005.000");
                //
                // Bancos
                uPermissoes.Grava(login, "001.008.000.000");
                // DI_CA_06 = Bancos Cadastro
                if (ds0.Tables[0].Rows[row]["DI_CA_06"].ToString() == "True")
                    uPermissoes.Grava(login, "001.008.001.000");
                // DI_AL_06 = Bancos Alterar
                if (ds0.Tables[0].Rows[row]["DI_AL_06"].ToString() == "True")
                    uPermissoes.Grava(login, "001.008.002.000");
                // DI_EX_06 = Bancos Excluir
                if (ds0.Tables[0].Rows[row]["DI_EX_06"].ToString() == "True")
                    uPermissoes.Grava(login, "001.008.003.000");
                // DI_CO_06 = Bancos Consultar
                if (ds0.Tables[0].Rows[row]["DI_CO_06"].ToString() == "True")
                    uPermissoes.Grava(login, "001.008.004.000");
                // DI_RE_06 = Bancos Relatórios
                if (ds0.Tables[0].Rows[row]["DI_RE_06"].ToString() == "True")
                    uPermissoes.Grava(login, "001.008.005.000");
                //
                // Análises
                uPermissoes.Grava(login, "001.009.000.000");
                // DI_CA_07 = Análises Cadastro
                if (ds0.Tables[0].Rows[row]["DI_CA_07"].ToString() == "True")
                    uPermissoes.Grava(login, "001.009.001.000");
                // DI_AL_07 = Análises Alterar
                if (ds0.Tables[0].Rows[row]["DI_AL_07"].ToString() == "True")
                    uPermissoes.Grava(login, "001.009.002.000");
                // DI_EX_07 = Análises Excluir
                if (ds0.Tables[0].Rows[row]["DI_EX_07"].ToString() == "True")
                    uPermissoes.Grava(login, "001.009.003.000");
                // DI_CO_07 = Análises Consultar
                if (ds0.Tables[0].Rows[row]["DI_CO_07"].ToString() == "True")
                    uPermissoes.Grava(login, "001.009.004.000");
                // DI_RE_07 = Análises Relatórios
                if (ds0.Tables[0].Rows[row]["DI_RE_07"].ToString() == "True")
                    uPermissoes.Grava(login, "001.009.005.000");
                //
                // Contábil
                uPermissoes.Grava(login, "001.010.000.000");
                // DI_CA_09 = Análises Cadastro
                if (ds0.Tables[0].Rows[row]["DI_CA_09"].ToString() == "True")
                    uPermissoes.Grava(login, "001.010.001.000");
                // DI_AL_09 = Análises Alterar
                if (ds0.Tables[0].Rows[row]["DI_AL_09"].ToString() == "True")
                    uPermissoes.Grava(login, "001.010.002.000");
                // DI_EX_09 = Análises Excluir
                if (ds0.Tables[0].Rows[row]["DI_EX_09"].ToString() == "True")
                    uPermissoes.Grava(login, "001.010.003.000");
                // DI_CO_09 = Análises Consultar
                if (ds0.Tables[0].Rows[row]["DI_CO_09"].ToString() == "True")
                    uPermissoes.Grava(login, "001.010.004.000");
                // DI_RE_09 = Análises Relatórios
                if (ds0.Tables[0].Rows[row]["DI_RE_09"].ToString() == "True")
                    uPermissoes.Grava(login, "001.010.005.000");
                //
                // Configurações
                uPermissoes.Grava(login, "001.011.000.000");
                // DI_CA_09 = Configurações Cadastro
                if (ds0.Tables[0].Rows[row]["DI_CA_09"].ToString() == "True")
                    uPermissoes.Grava(login, "001.011.001.000");
                // DI_AL_09 = Configurações Alterar
                if (ds0.Tables[0].Rows[row]["DI_AL_09"].ToString() == "True")
                    uPermissoes.Grava(login, "001.011.002.000");
                // DI_EX_09 = Configurações Excluir
                if (ds0.Tables[0].Rows[row]["DI_EX_09"].ToString() == "True")
                    uPermissoes.Grava(login, "001.011.003.000");
                // DI_CO_09 = Configurações Consultar
                if (ds0.Tables[0].Rows[row]["DI_CO_09"].ToString() == "True")
                    uPermissoes.Grava(login, "001.011.004.000");
                // DI_RE_09 = Configurações Relatórios
                if (ds0.Tables[0].Rows[row]["DI_RE_09"].ToString() == "True")
                    uPermissoes.Grava(login, "001.011.005.000");
                //
                // Ajuda
                uPermissoes.Grava(login, "001.012.000.000");
                // DI_CA_09 = Ajuda Cadastro
                if (ds0.Tables[0].Rows[row]["DI_CA_09"].ToString() == "True")
                    uPermissoes.Grava(login, "001.012.001.000");
                // DI_AL_09 = Ajuda Alterar
                if (ds0.Tables[0].Rows[row]["DI_AL_09"].ToString() == "True")
                    uPermissoes.Grava(login, "001.012.002.000");
                // DI_EX_09 = Ajuda Excluir
                if (ds0.Tables[0].Rows[row]["DI_EX_09"].ToString() == "True")
                    uPermissoes.Grava(login, "001.012.003.000");
                // DI_CO_09 = Ajuda Consultar
                if (ds0.Tables[0].Rows[row]["DI_CO_09"].ToString() == "True")
                    uPermissoes.Grava(login, "001.012.004.000");
                // DI_RE_09 = Ajuda Relatórios
                if (ds0.Tables[0].Rows[row]["DI_RE_09"].ToString() == "True")
                    uPermissoes.Grava(login, "001.012.005.000");
                //
                // Empresa
                uPermissoes.Grava(login, "001.013.000.000");
                // DI_CA_01 = Empresa Cadastro
                if (ds0.Tables[0].Rows[row]["DI_CA_01"].ToString() == "True")
                    uPermissoes.Grava(login, "001.013.001.000");
                // DI_AL_01 = Empresa Alterar
                if (ds0.Tables[0].Rows[row]["DI_AL_01"].ToString() == "True")
                    uPermissoes.Grava(login, "001.013.002.000");
                // DI_EX_01 = Empresa Excluir
                if (ds0.Tables[0].Rows[row]["DI_EX_01"].ToString() == "True")
                    uPermissoes.Grava(login, "001.013.003.000");
                // DI_CO_01 = Empresa Consultar
                if (ds0.Tables[0].Rows[row]["DI_CO_01"].ToString() == "True")
                    uPermissoes.Grava(login, "001.013.004.000");
                // DI_RE_01 = Empresa Relatórios
                if (ds0.Tables[0].Rows[row]["DI_RE_01"].ToString() == "True")
                    uPermissoes.Grava(login, "001.013.005.000");
                //
                // Fim Permissões

                login = "";
                senha = "";
                nome = "";
                setor = "";
                funcao = "";
                fone = "";
                perfil = 0;
                email = "";
                alcada = "";
                ativo = true;

                //Fim Migração Arquivo Usuários e Permissões
            }

            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Usuários e Permissões OK \n\n";
            }
        }
    }

    private void MigrarClientes()
    {
        //Migração Arquivo Clientes
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"contato.dbf";
                var sql = "select * from " + fileName1 + "  ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete contato");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Clientes-Contatos, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Clientes-Contatos Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Clientes!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Clientes!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Clientes Não OK \n\n";
        }

        //Migração
        if (lOk)
        {
            string numcliente = "";
            string apelido = "";
            string nome = "";
            string sexo = "";
            string cnpj = "";
            string inscmunicipal = "";
            string inscestadual = "";
            string regjuntacom = "";
            string nire = "";
            string rg = "";
            string rguf = "";
            string rgemissor = "";
            DateTime rgemissao = Convert.ToDateTime("01/01/1900");
            string endereco = "";
            string enderecores = "";
            string enderecoresnumero = "";
            string enderecorescomplem = "";
            string bairrores = "";
            string cidaderes = "";
            string ufres = "";
            string cepres = "";
            string fone1res = "";
            string fone2res = "";
            string fone3res = "";
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
            string empregador = "";
            string cargo = "";
            string atividade = "";
            string obs1 = "";
            string obs2 = "";
            string obs3 = "";
            string obs4 = "";
            string obs5 = "";
            string conjugenome = "";
            string conjugesexo = "";
            string conjugecnpj = "";
            string conjugerg = "";
            string conjugerguf = "";
            string conjugergemissor = "";
            DateTime conjugergemissao = Convert.ToDateTime("01/01/1900");
            DateTime dtnascimentoconjuge = Convert.ToDateTime("01/01/1900");
            string fone1con = "";
            string fone2con = "";
            string fone3con = "";
            string conjugeemail1 = "";
            string conjugeemail2 = "";
            string instrcob1 = "";
            string instrcob2 = "";
            string diasprotesto = "";
            string conta1 = "";
            string conta2 = "";
            string conta3 = "";
            string conta4 = "";
            string conta5 = "";
            Boolean dda = false;
            //
            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["cliente"].ToString() != String.Empty)
                {
                    // Clientes
                    numcliente = ds0.Tables[0].Rows[row]["num_clie"].ToString().Trim();
                    if (ds0.Tables[0].Rows[row]["cliente"].ToString().Length > 20)
                        apelido = Srelib.tiraacento(ds0.Tables[0].Rows[row]["cliente"].ToString().Substring(0, 20).ToUpper());
                    else
                        apelido = Srelib.tiraacento(ds0.Tables[0].Rows[row]["cliente"].ToString().Trim().ToUpper());
                    apelido = apelido.ToUpper();
                    //
                    nome = Srelib.tiraacento(ds0.Tables[0].Rows[row]["cliente"].ToString().Trim());
                    nome = nome.ToUpper();
                    //
                    sexo = "";
                    sexo = ds0.Tables[0].Rows[row]["sexo"].ToString().Trim();
                    if (sexo == String.Empty)
                        sexo = "O";
                    cnpj = "";
                    if (ds0.Tables[0].Rows[row]["cpf_cgc"].ToString().Trim() != String.Empty)
                        if (ds0.Tables[0].Rows[row]["cpf_cgc"].ToString().Length >= 14)
                        {
                            cnpj = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["cpf_cgc"].ToString());
                            if (cnpj.Length >= 14)
                                cnpj = cnpj.Substring(0, 14);
                        }
                        else
                        {
                            cnpj = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["cpf_cgc"].ToString());
                        }

                    inscmunicipal = ds0.Tables[0].Rows[row]["inscricao"].ToString().Trim();
                    inscestadual = ds0.Tables[0].Rows[row]["inscricao"].ToString().Trim();
                    regjuntacom = "";
                    nire = "";
                    rg = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["rg"].ToString().Trim());
                    rguf = ds0.Tables[0].Rows[row]["uf_rg"].ToString().Trim();
                    rgemissor = Srelib.tiraacento(ds0.Tables[0].Rows[row]["orgao_rg"].ToString().Trim());
                    //
                    try
                    {
                        rgemissao = Convert.ToDateTime(ds0.Tables[0].Rows[row]["emissao_rg"].ToString());
                        if (rgemissao == Convert.ToDateTime("11/11/1111"))
                        {
                            rgemissao = Convert.ToDateTime("01/01/1900");
                        }
                    }
                    catch (Exception)
                    {
                        rgemissao = Convert.ToDateTime("01/01/1900");
                    }
                    //
                    endereco = ds0.Tables[0].Rows[row]["opcao"].ToString().Trim();
                    enderecores = Srelib.tiraacento(ds0.Tables[0].Rows[row]["end_r"].ToString().Trim());
                    enderecoresnumero = "";
                    enderecorescomplem = "";
                    bairrores = Srelib.tiraacento(ds0.Tables[0].Rows[row]["bairro_r"].ToString().Trim());
                    if (bairrores.Length > 30)
                        bairrores = bairrores.Substring(0, 30);
                    //
                    cidaderes = ds0.Tables[0].Rows[row]["cidade_r"].ToString().Trim();
                    if (cidaderes.Length > 30)
                        cidaderes = cidaderes.Substring(0, 30);
                    //
                    ufres = ds0.Tables[0].Rows[row]["estado_r"].ToString().Trim();
                    cepres = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["cep_r"].ToString().Trim());
                    fone1res = ds0.Tables[0].Rows[row]["tel_r_1"].ToString().Trim();
                    fone2res = ds0.Tables[0].Rows[row]["tel_r_2"].ToString().Trim();
                    fone3res = "";
                    enderecocom = Srelib.tiraacento(ds0.Tables[0].Rows[row]["end_c"].ToString().Trim());
                    enderecocomnumero = "";
                    enderecocomcomplem = "";
                    bairrocom = Srelib.tiraacento(ds0.Tables[0].Rows[row]["bairro_c"].ToString().Trim());
                    if (bairrocom.Length > 30)
                        bairrocom = bairrocom.Substring(0, 30);
                    //
                    cidadecom = ds0.Tables[0].Rows[row]["cidade_c"].ToString().Trim();
                    if (cidadecom.Length > 30)
                        cidadecom = cidadecom.Substring(0, 30);
                    //
                    ufcom = ds0.Tables[0].Rows[row]["estado_c"].ToString().Trim();
                    cepcom = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["cep_c"].ToString().Trim());

                    if (ds0.Tables[0].Rows[row]["tel_c_1"].ToString().Length > 30)
                        fone1com = Srelib.tiraacento(ds0.Tables[0].Rows[row]["tel_c_1"].ToString().Substring(0, 30));
                    else
                        fone1com = Srelib.tiraacento(ds0.Tables[0].Rows[row]["tel_c_1"].ToString().Trim());

                    if (ds0.Tables[0].Rows[row]["tel_c_2"].ToString().Length > 30)
                        fone2com = Srelib.tiraacento(ds0.Tables[0].Rows[row]["tel_c_2"].ToString().Substring(0, 30));
                    else
                        fone2com = Srelib.tiraacento(ds0.Tables[0].Rows[row]["tel_c_2"].ToString().Trim());

                    if (ds0.Tables[0].Rows[row]["fax_c"].ToString().Length > 30)
                        fone3com = Srelib.tiraacento(ds0.Tables[0].Rows[row]["fax_c"].ToString().Substring(0, 30));
                    else
                        fone3com = Srelib.tiraacento(ds0.Tables[0].Rows[row]["fax_c"].ToString().Trim());

                    email1 = ds0.Tables[0].Rows[row]["mail_prop"].ToString().Trim();
                    email2 = ds0.Tables[0].Rows[row]["mail_c"].ToString().Trim();
                    email3 = "";
                    email4 = "";
                    email5 = "";
                    gerente = "GERAL";
                    contato = ds0.Tables[0].Rows[row]["contato"].ToString().Trim();
                    dtnascimento = Convert.ToDateTime("01/01/1900");
                    if (ds0.Tables[0].Rows[row]["nascimento"].ToString() != "")
                    {
                        try
                        {
                            if (ds0.Tables[0].Rows[row]["nascimento"].ToString().Substring(0, 10) != "11/11/1111")
                                dtnascimento = Convert.ToDateTime(ds0.Tables[0].Rows[row]["nascimento"].ToString().Trim());
                        }
                        catch (Exception)
                        {
                            dtnascimento = Convert.ToDateTime("01/01/1900");
                        }
                    }
                    //
                    dtingresso = DateTime.Now;
                    //
                    try
                    {
                        if (ds0.Tables[0].Rows[row]["contrato"].ToString() != "")
                            ncontrato = ds0.Tables[0].Rows[row]["contrato"].ToString().Trim();
                    }
                    catch (Exception)
                    {
                        //
                    }
                    //

                    dtcontrato = Convert.ToDateTime("01/01/1900");
                    ativo = true;
                    acessointernet = true;
                    //
                    empregador = Srelib.tiraacento(ds0.Tables[0].Rows[row]["empresa"].ToString().Trim());
                    //
                    cargo = "";
                    atividade = ds0.Tables[0].Rows[row]["profissao"].ToString().Trim();
                    obs1 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["observa_1"].ToString().Trim());
                    obs2 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["observa_2"].ToString().Trim());
                    obs3 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["observa_3"].ToString().Trim());
                    obs4 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["observa_4"].ToString().Trim());
                    obs5 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["observa_5"].ToString().Trim());
                    conjugenome = Srelib.tiraacento(ds0.Tables[0].Rows[row]["conjuge"].ToString().Trim());
                    if (ds0.Tables[0].Rows[row]["sexo"].ToString() == "M")
                        conjugesexo = "F";
                    if (ds0.Tables[0].Rows[row]["sexo"].ToString() == "F")
                        conjugesexo = "M";
                    else
                        conjugesexo = "O";
                    conjugecnpj = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["cpf_conj"].ToString().Trim());
                    conjugerg = "";
                    conjugerguf = "";
                    conjugergemissor = "";
                    conjugergemissao = Convert.ToDateTime("01/01/1900");
                    dtnascimentoconjuge = Convert.ToDateTime("01/01/1900");
                    if (ds0.Tables[0].Rows[row]["nasc_conj"].ToString() != "")
                    {
                        try
                        {
                            if (ds0.Tables[0].Rows[row]["nasc_conj"].ToString().Substring(0, 10) != "11/11/1111")
                                dtnascimentoconjuge = Convert.ToDateTime(ds0.Tables[0].Rows[row]["nasc_conj"].ToString().Trim());
                        }
                        catch (Exception)
                        {
                            dtnascimentoconjuge = Convert.ToDateTime("01/01/1900");
                        }
                    }
                    //
                    fone1con = ds0.Tables[0].Rows[row]["tel_conj"].ToString().Trim();
                    fone2con = "";
                    fone3con = "";
                    conjugeemail1 = ds0.Tables[0].Rows[row]["mail_conj"].ToString().Trim();
                    conjugeemail2 = "";
                    instrcob1 = "";
                    instrcob2 = "";
                    diasprotesto = "";
                    conta1 = "";
                    conta2 = "";
                    conta3 = "";
                    conta4 = "";
                    conta5 = "";
                    dda = false;

                    if (nome != String.Empty)
                    {
                        uContato.Grava(numcliente,
                                       apelido,
                                       nome,
                                       sexo,
                                       cnpj,
                                       inscmunicipal,
                                       inscestadual,
                                       regjuntacom,
                                       nire,
                                       rg,
                                       rguf,
                                       rgemissor,
                                       rgemissao,
                                       endereco,
                                       enderecores,
                                       enderecoresnumero,
                                       enderecorescomplem,
                                       bairrores,
                                       cidaderes,
                                       ufres,
                                       cepres,
                                       fone1res,
                                       fone2res,
                                       fone3res,
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
                                       empregador,
                                       cargo,
                                       atividade,
                                       conjugenome,
                                       conjugesexo,
                                       conjugecnpj,
                                       conjugerg,
                                       conjugerguf,
                                       conjugergemissor,
                                       conjugergemissao,
                                       dtnascimentoconjuge,
                                       fone1con,
                                       fone2con,
                                       fone3con,
                                       conjugeemail1,
                                       conjugeemail2,
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
                                       conta5,
                                       dda);

                        numcliente = "";
                        apelido = "";
                        nome = "";
                        sexo = "";
                        cnpj = "";
                        inscmunicipal = "";
                        inscestadual = "";
                        regjuntacom = "";
                        nire = "";
                        rg = "";
                        rguf = "";
                        rgemissor = "";
                        rgemissao = Convert.ToDateTime("01/01/1900");
                        endereco = "";
                        enderecores = "";
                        enderecoresnumero = "";
                        enderecorescomplem = "";
                        bairrores = "";
                        cidaderes = "";
                        ufres = "";
                        cepres = "";
                        fone1res = "";
                        fone2res = "";
                        fone3res = "";
                        enderecocom = "";
                        enderecocomnumero = "";
                        enderecocomcomplem = "";
                        bairrocom = "";
                        cidadecom = "";
                        ufcom = "";
                        cepcom = "";
                        fone1com = "";
                        fone2com = "";
                        fone3com = "";
                        email1 = "";
                        email2 = "";
                        email3 = "";
                        email4 = "";
                        email5 = "";
                        gerente = "";
                        contato = "";
                        dtnascimento = Convert.ToDateTime("01/01/1900");
                        dtingresso = Convert.ToDateTime("01/01/1900");
                        ncontrato = "";
                        dtcontrato = Convert.ToDateTime("01/01/1900");
                        ativo = true;
                        acessointernet = true;
                        empregador = "";
                        cargo = "";
                        atividade = "";
                        obs1 = "";
                        obs2 = "";
                        obs3 = "";
                        obs4 = "";
                        obs5 = "";
                        conjugenome = "";
                        conjugesexo = "";
                        conjugecnpj = "";
                        conjugerg = "";
                        conjugerguf = "";
                        conjugergemissor = "";
                        conjugergemissao = Convert.ToDateTime("01/01/1900");
                        dtnascimentoconjuge = Convert.ToDateTime("01/01/1900");
                        fone1con = "";
                        fone2con = "";
                        fone3con = "";
                        conjugeemail1 = "";
                        conjugeemail2 = "";
                        instrcob1 = "";
                        instrcob2 = "";
                        diasprotesto = "";
                        conta1 = "";
                        conta2 = "";
                        conta3 = "";
                        conta4 = "";
                        conta5 = "";
                        dda = false;

                    }

                }
                //Fim Migração Arquivo Clientes
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Clientes-Contatos OK \n\n";
            }
        }
    }

    private void MigrarProdutosTipo()
    {
        //Migração Arquivo Produtos Tipo
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"tipo_pro.dbf";
                var sql = "select * from " + fileName1 + "  ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete produto_tipo");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Produtos Tipo, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Produtos Tipo Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Produtos Tipo!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Produtos Tipo!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Produtos Tipo Não OK \n\n";
        }

        //Migração
        if (lOk)
        {

            string numtipo = "";
            string descricao = "";
            string produto = "";
            string grupo = "";
            string unidade = "";
            //
            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["codigo"].ToString() != String.Empty)
                {
                    // Produtos
                    numtipo = ds0.Tables[0].Rows[row]["codigo"].ToString().Trim();
                    descricao = ds0.Tables[0].Rows[row]["descricao"].ToString().Trim().ToUpper();
                    produto = Srelib.tiraacento(ds0.Tables[0].Rows[row]["produto"].ToString().Trim());
                    grupo = ds0.Tables[0].Rows[row]["grupo"].ToString().Trim();
                    unidade = ds0.Tables[0].Rows[row]["unidade"].ToString().Trim();
                    if (descricao != String.Empty)
                    {
                        uProduto.GravaTipo(numtipo,
                                           descricao,
                                           produto,
                                           grupo,
                                           unidade);

                    }

                    numtipo = "";
                    descricao = "";
                    produto = "";
                    grupo = "";
                    unidade = "";

                }
                //Fim Migração Arquivo Produtos Tipo
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Produtos Tipo OK \n\n";
            }
        }
    }

    private void MigrarProdutos()
    {
        //Migração Arquivo Produtos
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"clas_pro.dbf";
                var sql = "select * from " + fileName1 + "  ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete produto");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Produtos, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Produtos Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Produtos!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Produtos!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Produtos Não OK \n\n";
        }

        //Migração
        if (lOk)
        {

            string numproduto = "";
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
            decimal cub = 0.999999m;
            string obs1 = "";
            string obs2 = "";
            string obs3 = "";
            string obs4 = "";
            string obs5 = "";
            Boolean ativo = true;
            string codpis = "";
            //
            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["codigo"].ToString() != String.Empty)
                {
                    // Produtos
                    numproduto = ds0.Tables[0].Rows[row]["codigo"].ToString().Trim();
                    tipo = ds0.Tables[0].Rows[row]["tipo"].ToString().Trim();
                    descricao = Srelib.tiraacento(ds0.Tables[0].Rows[row]["descricao"].ToString().Trim().ToUpper());
                    conta = ds0.Tables[0].Rows[row]["cod_conta"].ToString().Trim();
                    cnpj = "";
                    enderecocom = Srelib.tiraacento(ds0.Tables[0].Rows[row]["endereco"].ToString().Trim());
                    enderecocomnumero = "";
                    enderecocomcomplem = "";
                    bairrocom = Srelib.tiraacento(ds0.Tables[0].Rows[row]["bairro"].ToString().Trim());
                    cidadecom = ds0.Tables[0].Rows[row]["cidade"].ToString().Trim();
                    ufcom = ds0.Tables[0].Rows[row]["estado"].ToString().Trim();
                    cepcom = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["cep"].ToString().Trim());
                    email1 = "";
                    email2 = "";
                    email3 = "";
                    //
                    try
                    {
                        area = ds0.Tables[0].Rows[row]["area"].ToString().Trim();
                    }
                    catch (Exception)
                    {
                        //
                    }
                    //
                    try
                    {
                        situacao_obra = ds0.Tables[0].Rows[row]["situacao_o"].ToString().Trim();
                    }
                    catch (Exception)
                    {
                        //
                    }
                    //
                    try
                    {
                        cub = Convert.ToDecimal(ds0.Tables[0].Rows[row]["cub"]);
                    }
                    catch (Exception)
                    {
                        cub = 0;
                    }
                    //
                    try
                    {
                        if (ds0.Tables[0].Rows[row]["habitese"].ToString() != "")
                            habitese = Convert.ToDateTime(ds0.Tables[0].Rows[row]["habitese"].ToString().Trim());
                    }
                    catch (Exception)
                    {
                        //
                    }
                    //
                    try
                    {
                        obs1 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["observa_1"].ToString().Trim());
                    }
                    catch (Exception)
                    {
                        //
                    }
                    //
                    try
                    {
                        obs2 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["observa_2"].ToString().Trim());
                    }
                    catch (Exception)
                    {
                        //
                    }
                    //
                    try
                    {
                        codpis = ds0.Tables[0].Rows[row]["cod_pis"].ToString().Trim();
                    }
                    catch (Exception)
                    {
                        codpis = " ";
                    }
                    //
                    if (descricao != String.Empty)
                    {
                        uProduto.Grava(numproduto,
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

                    }

                    numproduto = "";
                    tipo = "";
                    descricao = "";
                    conta = "";
                    cnpj = "";
                    enderecocom = "";
                    enderecocomnumero = "";
                    enderecocomcomplem = "";
                    bairrocom = "";
                    cidadecom = "";
                    ufcom = "";
                    cepcom = "";
                    fone1com = "";
                    fone2com = "";
                    fone3com = "";
                    email1 = "";
                    email2 = "";
                    email3 = "";
                    area = "";
                    situacao_obra = "";
                    habitese = Convert.ToDateTime("01/01/1900");
                    cub = 0.999999m;
                    obs1 = "";
                    obs2 = "";
                    obs3 = "";
                    obs4 = "";
                    obs5 = "";
                    ativo = true;
                    codpis = "";


                }
                //Fim Migração Arquivo Produtos
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Produtos OK \n\n";
            }
        }
    }

    private void MigrarProdutosGrupo(Int16 yTipoGrupo)
    {
        //Migração Arquivo Produtos Grupo 
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                if (yTipoGrupo == 1)
                    fileName1 = @"cad_quad.dbf";
                if (yTipoGrupo == 2)
                    fileName1 = @"cad_apar.dbf";
                var sql = "select * from " + fileName1 + "  ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete produto_grupo where grupo_tipo = " + yTipoGrupo.ToString().Trim());
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Produtos Grupo, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Produtos Grupo " + yTipoGrupo.ToString().Trim() + " Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Produtos Grupo!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Produto Grupo!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Produtos Grupo " + yTipoGrupo.ToString().Trim() + " Não OK \n\n";
        }

        //Migração
        if (lOk)
        {
            string produto = "";
            string grupo = "";
            string grupo_tipo = "";
            string descricao = "";
            string quantidade = "0";
            string num_inicial = "0";
            string num_final = "0";
            Boolean ativo = false;
            DateTime dtbase_vlr_venda = Convert.ToDateTime("01/01/1900");
            string vlr_venda = "0";
            string observa_1 = "";
            string observa_2 = "";
            //
            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["num_loteam"].ToString() != String.Empty)
                {
                    // Produtos
                    produto = Srelib.tiraacento(ds0.Tables[0].Rows[row]["num_loteam"].ToString().Trim());
                    //
                    if (yTipoGrupo == 1)
                        grupo = ds0.Tables[0].Rows[row]["num_quadra"].ToString().Trim();
                    if (yTipoGrupo == 2)
                        grupo = ds0.Tables[0].Rows[row]["num_bloco"].ToString().Trim();
                    //
                    grupo_tipo = Convert.ToString(yTipoGrupo);
                    try
                    {
                        descricao = ds0.Tables[0].Rows[row]["descricao"].ToString().Trim().ToUpper();
                    }
                    catch (Exception)
                    {
                        if (yTipoGrupo == 1)
                            descricao = "QUADRA " + grupo;
                        if (yTipoGrupo == 2)
                            descricao = "BLOCO " + grupo;
                    }
                    //
                    if (yTipoGrupo == 1)
                    {
                        if (ds0.Tables[0].Rows[row]["num_inicio"].ToString().Trim() != String.Empty)
                            num_inicial = ds0.Tables[0].Rows[row]["num_inicio"].ToString().Trim();
                        if (ds0.Tables[0].Rows[row]["num_final"].ToString().Trim() != String.Empty)
                            num_final = ds0.Tables[0].Rows[row]["num_final"].ToString().Trim();
                        if (ds0.Tables[0].Rows[row]["num_final"].ToString().Trim() != String.Empty)
                            quantidade = ds0.Tables[0].Rows[row]["num_final"].ToString().Trim();

                    }
                    if (yTipoGrupo == 2)
                    {
                        if (ds0.Tables[0].Rows[row]["quantidade"].ToString().Trim() != String.Empty)
                            quantidade = ds0.Tables[0].Rows[row]["quantidade"].ToString().Trim();
                        dtbase_vlr_venda = Convert.ToDateTime("01/01/1900");
                        //
                        try
                        {
                            if (ds0.Tables[0].Rows[row]["vlr_venda"].ToString().Trim() != String.Empty)
                                vlr_venda = ds0.Tables[0].Rows[row]["vlr_venda"].ToString().Trim();
                        }
                        catch (Exception)
                        {
                            //
                        }
                        //
                        try
                        {
                            observa_1 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["observa_1"].ToString().Trim());
                        }
                        catch (Exception)
                        {
                            //
                        }
                        //
                        try
                        {
                            observa_2 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["observa_2"].ToString().Trim());
                        }
                        catch (Exception)
                        {
                            //
                        }

                    }
                    ativo = Convert.ToBoolean(ds0.Tables[0].Rows[row]["cadastro"]);


                    if (descricao != String.Empty)
                    {
                        uProduto.GravaGrupo(produto,
                                            grupo,
                                            grupo_tipo,
                                            descricao,
                                            quantidade,
                                            num_inicial,
                                            num_final,
                                            ativo,
                                            dtbase_vlr_venda,
                                            vlr_venda,
                                            observa_1,
                                            observa_2
                                            );

                    }

                    produto = "";
                    grupo = "";
                    grupo_tipo = "2";
                    descricao = "";
                    quantidade = "";
                    num_inicial = "0";
                    num_final = "0";
                    ativo = false;
                    dtbase_vlr_venda = Convert.ToDateTime("01/01/1900");
                    vlr_venda = "";
                    observa_1 = "";
                    observa_2 = "";

                }
                //Fim Migração Arquivo Produtos Grupo 2
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Produtos Grupo " + yTipoGrupo.ToString().Trim() + " OK \n\n";
            }
        }
    }


    private void MigrarIndexadores()
    {
        //Migração Arquivo Indexadores
        Boolean lOk = true;
        //
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        //string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBase 5.0;User ID=Admin;Password=;";

        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"indices.dbf";
                //fileName1 = @"indices";
                var sql = "select * from " + fileName1 + "  ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete indexadores");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Indexadores, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Indexadores Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Indexadores!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Indexadores!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Indexadores Não OK \n\n";
            lOk = false;
        }


        //Migração
        if (lOk)
        {
            string nome = "";
            string descricao = "";
            string orgao = "";
            string divulgacao = "";
            string periodicidade = "";
            string tipo = "";
            string inicio = "0";
            string fim = "0";
            string dmais = "0";
            Boolean ativo = false;
            string observa_1 = "";
            string observa_2 = "";
            //
            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["nome"].ToString() != String.Empty)
                {
                    // indices\indexadores
                    nome = Srelib.tiraacento(ds0.Tables[0].Rows[row]["nome"].ToString().Trim());
                    descricao = ds0.Tables[0].Rows[row]["nome"].ToString().Trim();
                    periodicidade = ds0.Tables[0].Rows[row]["periodo"].ToString().Trim();
                    tipo = ds0.Tables[0].Rows[row]["tipo"].ToString().Trim();
                    inicio = ds0.Tables[0].Rows[row]["inicio"].ToString().Trim();
                    fim = ds0.Tables[0].Rows[row]["fim"].ToString().Trim();
                    dmais = ds0.Tables[0].Rows[row]["d"].ToString().Trim();
                    ativo = true;

                    if (nome != String.Empty)
                    {
                        uIndexadores.Grava(nome,
                                            descricao,
                                            orgao,
                                            divulgacao,
                                            periodicidade,
                                            tipo,
                                            inicio,
                                            fim,
                                            dmais,
                                            ativo,
                                            observa_1,
                                            observa_2
                                            );

                    }

                    nome = "";
                    descricao = "";
                    orgao = "";
                    divulgacao = "";
                    periodicidade = "";
                    tipo = "";
                    inicio = "0";
                    fim = "0";
                    dmais = "0";
                    ativo = false;
                    observa_1 = "";
                    observa_2 = "";

                }
                //Fim Migração Arquivo Indexadores
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Indexadores OK \n\n";
            }
        }
    }

    private void CriaTabelaTaxasDiarias()
    {
        //Migração Arquivo Taxas Diárias
        Boolean lOk = true;
        string constr0 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr0))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"indices.dbf";
                var sql0 = "select * from " + fileName1 + "   " + " where (periodo = 'DIARIO') ";
                OleDbCommand cmd0 = new OleDbCommand(sql0, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da0 = new OleDbDataAdapter(cmd0);
                da0.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("drop table dbo.taxas_diarias");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar a Tabela Indices-Taxas Diárias, possivel tabela em uso ou erro de chave estrangeira. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Indices-Taxas Diárias Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Indices-Taxas Diárias!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Indices-Taxas Diárias!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Indices-Taxas Diárias Não OK \n\n";
            lOk = false;
        }

        if (lOk)
        {

            //Cria nova tabela no SQL
            string nometaxa = "";
            array_nometaxa = new string[ds0.Tables[0].Rows.Count + 1];
            string script = "";
            string script1 = "";
            string script2 = "";
            string scripttaxas = "";
            script1 = " SET ANSI_NULLS ON" +
                      //" GO" +
                      " SET QUOTED_IDENTIFIER ON" +
                      //" GO" +
                      " CREATE TABLE [dbo].[taxas_diarias](" +
                      " 	[ID] [int] IDENTITY(1,1) NOT NULL," +
                      " 	[data] [datetime] NOT NULL,";

            script2 = "  CONSTRAINT [PK_taxas_diarias] PRIMARY KEY NONCLUSTERED " +
                      " (" +
                      " 	[ID] ASC" +
                      " )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]" +
                      " ) ON [PRIMARY]";// +
            //" GO";

            //
            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["nome"].ToString() != String.Empty)
                {
                    //
                    nometaxa = ds0.Tables[0].Rows[row]["nome"].ToString().Trim().ToUpper();

                    if (nometaxa.Trim() != String.Empty)
                    {
                        scripttaxas = scripttaxas +
                                    " 	[" + nometaxa + "]  [decimal](18, 8) NULL,";

                        array_nometaxa[row] = nometaxa.Trim();
                    }
                    //uTaxasDiarias.Grava(data);
                }

                nometaxa = "";

            }

            if (scripttaxas.Trim() != String.Empty)
            {
                //Criação da Tabela
                script = script1 + scripttaxas + script2;
                SreDblib.ExecScript(script);

            }

            //fim Cria nova tabela no SQL
        }
    }

    private void MigrarTaxasDiarias()
    {
        //Migração Arquivo Taxas Diárias
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"taxa_dia.dbf";
                var sql = "select * from " + fileName1 + "  " + " order by data";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete taxas_diarias");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar a Tabela Taxas Diárias, possivel tabela em uso ou erro de chave estrangeira. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Taxas Diárias Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Taxas Diárias!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Taxas Diárias!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Taxas Diárias Não OK \n\n";
            lOk = false;
        }


        //Migração
        if (lOk)
        {
            DateTime data = Convert.ToDateTime("01/01/1900");

            //
            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["data"].ToString() != String.Empty)
                {
                    // Produtos
                    data = Convert.ToDateTime(ds0.Tables[0].Rows[row]["data"]);
                    //Cria Data
                    uTaxasDiarias.Grava(data);
                    //Atualiza Taxa
                    for (int i = 0; i < array_nometaxa.Count(); i++)
                    {
                        uTaxasDiarias.GravaTaxa(data, array_nometaxa[i], ds0.Tables[0].Rows[row][array_nometaxa[i]].ToString());
                        //uTaxasDiarias.GravaTaxa(data, "TR_D", "10");                     
                    }
                }

                data = Convert.ToDateTime("01/01/1900");

                //Fim Migração Arquivo Taxas Diárias
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Taxas Diárias OK \n\n";
            }
        }
    }


    private void CriarTabelaTaxasMensais()
    {
        //Migração Arquivo Taxas Mensais
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"indices.dbf";
                //var sql = "select * from " + fileName1 + "   " + " where (periodo = 'MENSAL') and (nome <> " + Srelib.QStr("NENHUM") + ") ";
                var sql = "select * from " + fileName1 + "   " + " where (periodo = 'MENSAL') and (nome <> " + Srelib.QStr("NENHUM") + ") order by nome";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("drop table dbo.taxas_mensais");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar a Tabela Indices-Taxas Mensais SQL, possivel tabela em uso ou erro de chave estrangeira. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Indices-Taxas Mensais Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Indices-Taxas Mensais!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Indices-Taxas Mensais!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Indices-Taxas Mensais Não OK \n\n";
            lOk = false;
        }

        if (lOk)
        {
            //Cria nova tabela no SQL
            array_nometaxa = new string[ds0.Tables[0].Rows.Count + 1];
            string nometaxa = "";
            string script = "";
            string script1 = "";
            string script2 = "";
            string scripttaxas = "";
            script1 = " SET ANSI_NULLS ON" +
                      //" GO" +
                      " SET QUOTED_IDENTIFIER ON" +
                      //" GO" +
                      " CREATE TABLE [dbo].[taxas_mensais](" +
                      " 	[ID] [int] IDENTITY(1,1) NOT NULL," +
                      "     [mes] [varchar](2) NOT NULL," +
                      "     [ano] [varchar](4) NOT NULL,";
            //
            script2 = "  CONSTRAINT [PK_taxas_mensais] PRIMARY KEY NONCLUSTERED " +
                      " (" +
                      " 	[ID] ASC" +
                      " )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]" +
                      " ) ON [PRIMARY]"; // +
            //" GO";

            //
            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["nome"].ToString() != String.Empty)
                {
                    //
                    nometaxa = ds0.Tables[0].Rows[row]["nome"].ToString().Trim().ToUpper();

                    if (nometaxa.Trim() != String.Empty)
                    {
                        scripttaxas = scripttaxas +
                                    " 	[" + nometaxa + "]  [decimal](18, 8) NULL,";

                        array_nometaxa[row] = nometaxa.Trim();
                    }

                }

                nometaxa = "";

            }

            if (scripttaxas.Trim() != String.Empty)
            {
                //Criação da Tabela
                script = script1 + scripttaxas + script2;
                SreDblib.ExecScript(script);

            }
        }
        //fim Cria nova tabela no SQL
    }

    private void MigrarTaxasMensais()
    {
        //Migração Arquivo Taxas Mensais
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //SQL
                try
                {
                    SreDblib.ExecScript("delete taxas_mensais");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar a Tabela Taxas Mensais, possivel tabela em uso ou erro de chave estrangeira. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Taxas Mensais Não OK \n\n";
                    lOk = false;
                }
                //
                //DBF
                ds0.Clear();
                fileName1 = @"taxa_mes.dbf";
                var sql = "select * from " + fileName1 + "   " + " order by ano, mes";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();

            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Taxas Mensais!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Taxas Mensais!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Taxas Mensais Não OK \n\n";
            lOk = false;
        }


        //Migração
        if (lOk)
        {
            string mes = "";
            string ano = "";

            //
            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["mes"].ToString() != String.Empty)
                {
                    // Produtos
                    mes = Convert.ToInt16(ds0.Tables[0].Rows[row]["mes"]).ToString();
                    ano = Convert.ToInt16(ds0.Tables[0].Rows[row]["ano"]).ToString();
                    //
                    //mes entre 1 e 12 e ano acima de 1900
                    if (((Convert.ToInt16(ds0.Tables[0].Rows[row]["mes"]) >= 1) &&
                       (Convert.ToInt16(ds0.Tables[0].Rows[row]["mes"]) <= 12)) &&
                        (Convert.ToInt16(ds0.Tables[0].Rows[row]["ano"]) >= 1900))
                    {
                        string script = "";
                        for (int i = 0; i < array_nometaxa.Count(); i++)
                        {
                            if (array_nometaxa[i] != null)
                            {
                                script = script + ", 0 ";
                            }
                        }

                        //Cria registro
                        uTaxasMensais.Grava(mes,
                                            ano,
                                            script);

                        //Atualiza Taxa
                        for (int i = 0; i < array_nometaxa.Count(); i++)
                        {
                            if (array_nometaxa[i] != null)
                            {
                                uTaxasMensais.GravaTaxa(mes, ano, array_nometaxa[i], ds0.Tables[0].Rows[row][array_nometaxa[i]].ToString());
                            }
                        }
                    }
                }

                mes = "";
                ano = "";

                //Fim Migração Arquivo Taxas Mensais
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Taxas Mensais OK \n\n";
            }
        }
    }

    private void MigrarMensagensBoleto()
    {
        //Migração Arquivo Mensagens Boleto
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"msg_bole.dbf";
                var sql = "select * from " + fileName1 + "   " + " order by cod_msg";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete boleto_mensagens");
                }
                catch (Exception ex)
                {
                    //MemoAtividades.Text = MemoAtividades.Text + "Excessão: " + ex.ToString() + "\n";
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Mensagens Boleto, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Mensagens Boleto Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception ex)
        {
            //MemoAtividades.Text = MemoAtividades.Text + "Excessão: " + ex.ToString() + "\n";
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Mensagens Boleto!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Mensagens Boleto!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Mensagens Boleto Não OK \n\n";
        }

        //Migração
        if (lOk)
        {
            string codigo = "";
            string produto = "";
            string linha1 = "";
            string linha2 = "";
            string linha3 = "";
            string linha4 = "";
            string linha5 = "";
            //
            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                // Produtos
                codigo = ds0.Tables[0].Rows[row]["cod_msg"].ToString().Trim();
                produto = ds0.Tables[0].Rows[row]["tipo_prod"].ToString().Trim();
                linha1 = ds0.Tables[0].Rows[row]["linha_1"].ToString().Trim();
                linha2 = ds0.Tables[0].Rows[row]["linha_2"].ToString().Trim();
                linha3 = ds0.Tables[0].Rows[row]["linha_3"].ToString().Trim();
                linha4 = ds0.Tables[0].Rows[row]["linha_4"].ToString().Trim();
                linha5 = ds0.Tables[0].Rows[row]["linha_5"].ToString().Trim();

                if (codigo != String.Empty)
                {
                    uMensagemBoleto.Grava(codigo,
                                            produto,
                                            linha1,
                                            linha2,
                                            linha3,
                                            linha4,
                                            linha5
                                            );

                }

                codigo = "";
                produto = "";
                linha1 = "";
                linha2 = "";
                linha3 = "";
                linha4 = "";
                linha5 = "";

                //Fim Migração Arquivo Mensagens Boleto
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Mensagens Boleto OK \n\n";
            }
        }
    }

    private void MigrarCorretores()
    {
        //Migração Arquivo Corretor
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"corretor.dbf";
                var sql = "select * from " + fileName1 + "  " + " order by codigo";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete corretores");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Corretor, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Corretor Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Corretor!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Corretor!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Corretor Não OK \n\n";
        }

        //Migração
        if (lOk)
        {

            string codigo = "";
            string apelido = "";
            string nome = "";
            //
            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["codigo"].ToString() != String.Empty)
                {
                    // Produtos
                    codigo = ds0.Tables[0].Rows[row]["codigo"].ToString().Trim();
                    apelido = Srelib.tiraacento(ds0.Tables[0].Rows[row]["apelido"].ToString().Trim());
                    nome = ds0.Tables[0].Rows[row]["nome"].ToString().Trim();

                    if (apelido != String.Empty)
                    {
                        uCorretor.Grava(codigo,
                                            apelido,
                                            nome,
                                            "0"
                                            );

                    }

                    codigo = "";
                    apelido = "";
                    nome = "";

                }
                //Fim Migração Arquivo Corretor
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Corretor OK \n\n";
            }
        }
    }

    private void MigrarClassificacaoDespesas()
    {
        //Migração Arquivo Classificação de Despesas
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"classe_d.dbf";
                var sql = "select * from " + fileName1 + "  ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete classe_despesas");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Classificação de Despesas, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Classificação de Despesas Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Classificação de Despesas!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Classificação de Despesas!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Classificação de Despesas Não OK \n\n";
        }

        //Migração
        if (lOk)
        {

            string codigo = "";
            string descricao = "";
            string conta_contabil = "";
            //
            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["codigo"].ToString() != String.Empty)
                {
                    // Produtos
                    codigo = ds0.Tables[0].Rows[row]["codigo"].ToString().Trim();
                    descricao = ds0.Tables[0].Rows[row]["descricao"].ToString().Trim();
                    if (descricao.IndexOf("'") != -1)
                    {
                        descricao = Srelib.tiraacento(descricao);
                    }
                    conta_contabil = ds0.Tables[0].Rows[row]["conta_cont"].ToString().Trim();

                    if (descricao != String.Empty)
                    {
                        uDespesas.Grava(codigo,
                                        descricao,
                                        conta_contabil
                                        );
                    }

                    codigo = "";
                    descricao = "";
                    conta_contabil = "";

                }

                //Fim Migração Arquivo Classificação de Despesas
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Classificação de Despesas OK \n\n";
            }
        }
    }

    private void MigrarFornecedores()
    {
        //Migração Arquivo Fornecedores
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"forneced.dbf";
                var sql = "select * from " + fileName1 + " order by codigo  ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete fornecedores");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Fornecedores, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Fornecedores Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Fornecedores!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Fornecedores!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Fornecedores Não OK \n\n";
        }

        //Migração
        if (lOk)
        {
            string codigo = "";
            string apelido = "";
            string nome = "";
            string sexo = "";
            string cnpj = "";
            string inscmunicipal = "";
            string inscestadual = "";
            string regjuntacom = "";
            string nire = "";
            string rg = "";
            string rguf = "";
            string rgemissor = "";
            DateTime rgemissao = Convert.ToDateTime("01/01/1900");
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
            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                // Empresa
                if (ds0.Tables[0].Rows[row]["apelido"].ToString().Trim() == String.Empty)
                    if (ds0.Tables[0].Rows[row]["nome"].ToString().Length >= 20)
                        apelido = (Srelib.tiraacento(ds0.Tables[0].Rows[row]["nome"].ToString().Substring(0, 20).ToUpper()));
                    else
                        apelido = (Srelib.tiraacento(ds0.Tables[0].Rows[row]["nome"].ToString().Trim().ToUpper()));
                else
                    apelido = ds0.Tables[0].Rows[row]["apelido"].ToString().Trim().ToUpper();
                //
                codigo = ds0.Tables[0].Rows[row]["codigo"].ToString();
                nome = Srelib.tiraacento(ds0.Tables[0].Rows[row]["nome"].ToString());
                nome = nome.ToUpper();
                sexo = "";
                sexo = ds0.Tables[0].Rows[row]["sexo"].ToString();
                if (sexo == String.Empty)
                    sexo = "O";
                cnpj = "";
                if (ds0.Tables[0].Rows[row]["cpf_cgc"].ToString().Trim() != String.Empty)
                    if (ds0.Tables[0].Rows[row]["cpf_cgc"].ToString().Length >= 14)
                    {
                        cnpj = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["cpf_cgc"].ToString());
                        if (cnpj.Length >= 14)
                            cnpj = cnpj.Substring(0, 14);
                    }
                    else
                    {
                        cnpj = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["cpf_cgc"].ToString());
                    }

                inscmunicipal = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["inscricao"].ToString());
                inscestadual = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["inscricao"].ToString());
                regjuntacom = "";
                nire = "";
                rg = ds0.Tables[0].Rows[row]["rg"].ToString();
                rguf = ds0.Tables[0].Rows[row]["uf_rg"].ToString();
                rgemissor = ds0.Tables[0].Rows[row]["orgao_rg"].ToString();
                //
                try
                {
                    rgemissao = Convert.ToDateTime(ds0.Tables[0].Rows[row]["emissao_rg"].ToString());
                    if (rgemissao == Convert.ToDateTime("11/11/1111"))
                    {
                        rgemissao = Convert.ToDateTime("01/01/1900");
                    }
                }
                catch (Exception)
                {
                    rgemissao = Convert.ToDateTime("01/01/1900");
                }
                //
                enderecocom = ds0.Tables[0].Rows[row]["end"].ToString();
                enderecocomnumero = "";
                enderecocomcomplem = "";
                bairrocom = ds0.Tables[0].Rows[row]["bairro"].ToString();
                cidadecom = ds0.Tables[0].Rows[row]["cidade"].ToString();
                if (ds0.Tables[0].Rows[row]["estado"].ToString().Trim() != "")
                    ufcom = ds0.Tables[0].Rows[row]["estado"].ToString().Substring(0, 2);
                if (ds0.Tables[0].Rows[row]["cep"].ToString().Trim() != "")
                    cepcom = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["cep"].ToString());

                fone1com = ds0.Tables[0].Rows[row]["tel1"].ToString();
                fone2com = ds0.Tables[0].Rows[row]["tel2"].ToString();
                fone3com = "";
                email1 = "";
                email2 = "";
                email3 = "";
                email4 = "";
                email5 = "";
                gerente = "GERAL";
                contato = ds0.Tables[0].Rows[row]["contato"].ToString();
                //
                try
                {
                    dtnascimento = Convert.ToDateTime(ds0.Tables[0].Rows[row]["nascimento"].ToString());
                    if (rgemissao == Convert.ToDateTime("11/11/1111"))
                    {
                        dtnascimento = Convert.ToDateTime("01/01/1900");
                    }
                }
                catch (Exception)
                {
                    dtnascimento = Convert.ToDateTime("01/01/1900");
                }
                //
                dtingresso = DateTime.Now;
                ncontrato = "";
                dtcontrato = Convert.ToDateTime("01/01/1900");
                ativo = true;
                acessointernet = true;
                obs1 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["observa_1"].ToString());
                obs2 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["observa_2"].ToString());
                obs3 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["observa_3"].ToString());
                obs4 = "";
                obs5 = "";
                instrcob1 = "";
                instrcob2 = "";
                diasprotesto = "";
                conta1 = "";
                conta2 = "";
                conta3 = "";
                conta4 = "";
                conta5 = "";

                uFornecedores.Grava(codigo,
                                    apelido,
                                    nome,
                                    sexo,
                                    cnpj,
                                    inscmunicipal,
                                    inscestadual,
                                    regjuntacom,
                                    nire,
                                    rg,
                                    rguf,
                                    rgemissor,
                                    rgemissao,
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

                codigo = "";
                apelido = "";
                nome = "";
                sexo = "";
                cnpj = "";
                inscmunicipal = "";
                inscestadual = "";
                regjuntacom = "";
                nire = "";
                rg = "";
                rguf = "";
                rgemissor = "";
                rgemissao = Convert.ToDateTime("01/01/1900");
                enderecocom = "";
                enderecocomnumero = "";
                enderecocomcomplem = "";
                bairrocom = "";
                cidadecom = "";
                ufcom = "";
                cepcom = "";
                fone1com = "";
                fone2com = "";
                fone3com = "";
                email1 = "";
                email2 = "";
                email3 = "";
                email4 = "";
                email5 = "";
                gerente = "";
                contato = "";
                dtnascimento = Convert.ToDateTime("01/01/1900");
                dtingresso = Convert.ToDateTime("01/01/1900");
                ncontrato = "";
                dtcontrato = Convert.ToDateTime("01/01/1900");
                ativo = true;
                acessointernet = true;
                obs1 = "";
                obs2 = "";
                obs3 = "";
                obs4 = "";
                obs5 = "";
                instrcob1 = "";
                instrcob2 = "";
                diasprotesto = "";
                conta1 = "";
                conta2 = "";
                conta3 = "";
                conta4 = "";
                conta5 = "";


                //Fim Migração Arquivo Fornecedores
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Fornecedores OK \n\n";
            }
        }
    }

    private void MigrarClassificacaoReceitas()
    {
        //Migração Arquivo Classificação de Receitas
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"classe_r.dbf";
                var sql = "select * from " + fileName1 + "  ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete classe_receitas");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Classificação de Receitas, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Classificação de Receitas Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Classificação de Receitas!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Classificação de Receitas!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Classificação de Receitas Não OK \n\n";
        }

        //Migração
        if (lOk)
        {

            string codigo = "";
            string descricao = "";
            string conta_contabil = "";
            //
            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["codigo"].ToString() != String.Empty)
                {
                    // Produtos
                    codigo = ds0.Tables[0].Rows[row]["codigo"].ToString().Trim();
                    descricao = ds0.Tables[0].Rows[row]["descricao"].ToString().Trim();
                    if (descricao.IndexOf("'") != -1)
                    {
                        descricao = Srelib.tiraacento(descricao);
                    }
                    conta_contabil = ds0.Tables[0].Rows[row]["conta_cont"].ToString().Trim();

                    if (descricao != String.Empty)
                    {
                        uReceitas.Grava(codigo,
                                        descricao,
                                        conta_contabil
                                        );
                    }

                    codigo = "";
                    descricao = "";
                    conta_contabil = "";

                }

                //Fim Migração Arquivo Classificação de Receitas
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Classificação de Receitas OK \n\n";
            }
        }
    }

    private void MigrarClientesContasaReceber()
    {
        //Migração Arquivo Clientes Contas a Receber
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"clientes.dbf";
                var sql = "select * from " + fileName1 + "  ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete clientes");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Clientes Contas a Receber, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Clientes Contas a Receber Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Clientes Contas a Receber!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Clientes Contas a Receber!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Clientes Contas a Receber Não OK \n\n";
        }

        //Migração
        if (lOk)
        {
            string ID = "";
            string apelido = "";
            string nome = "";
            string sexo = "";
            string cnpj = "";
            string inscmunicipal = "";
            string inscestadual = "";
            string regjuntacom = "";
            string nire = "";
            string rg = "";
            string rguf = "";
            string rgemissor = "";
            DateTime rgemissao = Convert.ToDateTime("01/01/1900");
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
            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                // Clientes
                if (ds0.Tables[0].Rows[row]["apelido"].ToString().Trim() == String.Empty)
                {
                    if (ds0.Tables[0].Rows[row]["nome"].ToString().Length >= 20)
                        apelido = (Srelib.tiraacento(ds0.Tables[0].Rows[row]["nome"].ToString().Substring(0, 20)));
                    else
                        apelido = (Srelib.tiraacento(ds0.Tables[0].Rows[row]["nome"].ToString().Trim()));
                }
                else
                {
                    apelido = (Srelib.tiraacento(ds0.Tables[0].Rows[row]["apelido"].ToString().Trim()));
                }
                //
                ID = ds0.Tables[0].Rows[row]["codigo"].ToString();
                nome = Srelib.tiraacento(ds0.Tables[0].Rows[row]["nome"].ToString());
                sexo = "";
                sexo = ds0.Tables[0].Rows[row]["sexo"].ToString();
                if (sexo == String.Empty)
                    sexo = "O";
                cnpj = "";
                if (ds0.Tables[0].Rows[row]["cpf_cgc"].ToString().Trim() != String.Empty)
                    if (ds0.Tables[0].Rows[row]["cpf_cgc"].ToString().Length >= 14)
                    {
                        cnpj = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["cpf_cgc"].ToString());
                        if (cnpj.Length >= 14)
                            cnpj = cnpj.Substring(0, 14);
                    }
                    else
                    {
                        cnpj = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["cpf_cgc"].ToString());
                    }

                inscmunicipal = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["inscricao"].ToString());
                inscestadual = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["inscricao"].ToString());
                regjuntacom = "";
                nire = "";
                rg = ds0.Tables[0].Rows[row]["rg"].ToString();
                rguf = ds0.Tables[0].Rows[row]["uf_rg"].ToString();
                rgemissor = ds0.Tables[0].Rows[row]["orgao_rg"].ToString();
                if (ds0.Tables[0].Rows[row]["emissao_rg"].ToString().Trim() != "")
                    rgemissao = Convert.ToDateTime(ds0.Tables[0].Rows[row]["emissao_rg"]);

                enderecocom = ds0.Tables[0].Rows[row]["end"].ToString();
                enderecocomnumero = "";
                enderecocomcomplem = "";
                bairrocom = ds0.Tables[0].Rows[row]["bairro"].ToString();
                cidadecom = ds0.Tables[0].Rows[row]["cidade"].ToString();
                if (ds0.Tables[0].Rows[row]["estado"].ToString().Trim() != "")
                    ufcom = ds0.Tables[0].Rows[row]["estado"].ToString().Substring(0, 2);
                if (ds0.Tables[0].Rows[row]["cep"].ToString().Trim() != "")
                    cepcom = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["cep"].ToString());

                fone1com = ds0.Tables[0].Rows[row]["tel1"].ToString();
                fone2com = ds0.Tables[0].Rows[row]["tel2"].ToString();
                fone3com = "";
                email1 = "";
                email2 = "";
                email3 = "";
                email4 = "";
                email5 = "";
                gerente = "GERAL";
                contato = ds0.Tables[0].Rows[row]["contato"].ToString();

                if (ds0.Tables[0].Rows[row]["nascimento"].ToString().Trim() != "")
                    dtnascimento = Convert.ToDateTime(ds0.Tables[0].Rows[row]["nascimento"]);

                dtingresso = DateTime.Now;
                ncontrato = "";
                dtcontrato = Convert.ToDateTime("01/01/1900");
                ativo = true;
                acessointernet = true;
                obs1 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["observa_1"].ToString());
                obs2 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["observa_2"].ToString());
                obs3 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["observa_3"].ToString());
                obs4 = "";
                obs5 = "";
                instrcob1 = "";
                instrcob2 = "";
                diasprotesto = "";
                conta1 = "";
                conta2 = "";
                conta3 = "";
                conta4 = "";
                conta5 = "";

                uCliente.Grava(ID,
                                apelido,
                                nome,
                                sexo,
                                cnpj,
                                inscmunicipal,
                                inscestadual,
                                regjuntacom,
                                nire,
                                rg,
                                rguf,
                                rgemissor,
                                rgemissao,
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

                apelido = "";
                nome = "";
                sexo = "";
                cnpj = "";
                inscmunicipal = "";
                inscestadual = "";
                regjuntacom = "";
                nire = "";
                rg = "";
                rguf = "";
                rgemissor = "";
                rgemissao = Convert.ToDateTime("01/01/1900");
                enderecocom = "";
                enderecocomnumero = "";
                enderecocomcomplem = "";
                bairrocom = "";
                cidadecom = "";
                ufcom = "";
                cepcom = "";
                fone1com = "";
                fone2com = "";
                fone3com = "";
                email1 = "";
                email2 = "";
                email3 = "";
                email4 = "";
                email5 = "";
                gerente = "";
                contato = "";
                dtnascimento = Convert.ToDateTime("01/01/1900");
                dtingresso = Convert.ToDateTime("01/01/1900");
                ncontrato = "";
                dtcontrato = Convert.ToDateTime("01/01/1900");
                ativo = true;
                acessointernet = true;
                obs1 = "";
                obs2 = "";
                obs3 = "";
                obs4 = "";
                obs5 = "";
                instrcob1 = "";
                instrcob2 = "";
                diasprotesto = "";
                conta1 = "";
                conta2 = "";
                conta3 = "";
                conta4 = "";
                conta5 = "";


                //Fim Migração Arquivo Clientes Contas a Receber
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Clientes Contas a Receber OK \n\n";
            }
        }
    }

    private void MigrarBancos()
    {
        //Migração Arquivo Bancos
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"bancos.dbf";
                var sql = "select * from " + fileName1 + "  ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete bancos");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Bancos, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Bancos Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Bancos!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Bancos!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Bancos Não OK \n\n";
        }

        //Migração
        if (lOk)
        {

            string cod_banco = "";
            string nome = "";
            DateTime data = Convert.ToDateTime("01/01/1900");
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
            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["cod_banco"].ToString() != String.Empty)
                {
                    // Produtos
                    cod_banco = ds0.Tables[0].Rows[row]["cod_banco"].ToString().Trim();
                    nome = ds0.Tables[0].Rows[row]["nome_banco"].ToString().Trim();
                    if (ds0.Tables[0].Rows[row]["data"].ToString() != "")
                        data = Convert.ToDateTime(ds0.Tables[0].Rows[row]["data"]);
                    drive = ds0.Tables[0].Rows[row]["drive"].ToString().Trim();
                    pasta_remessa = ds0.Tables[0].Rows[row]["subdir_rem"].ToString().Trim();
                    pasta_retorno = ds0.Tables[0].Rows[row]["subdir_ret"].ToString().Trim();
                    pasta_envelope = ds0.Tables[0].Rows[row]["subdir_env"].ToString().Trim();
                    assunto = ds0.Tables[0].Rows[row]["assunto"].ToString().Trim();
                    caixa_postal = ds0.Tables[0].Rows[row]["caixa_pos"].ToString().Trim();
                    mascara_remessa = ds0.Tables[0].Rows[row]["cori_rem"].ToString().Trim();
                    mascara_retorno = ds0.Tables[0].Rows[row]["cori_ret"].ToString().Trim();
                    nome_arquivo = ds0.Tables[0].Rows[row]["nome_arq"].ToString().Trim();
                    numero_arquivo = ds0.Tables[0].Rows[row]["arquivo"].ToString().Trim();
                    prazo_fol = ds0.Tables[0].Rows[row]["prazo_fol"].ToString().Trim();
                    prazo_dev = ds0.Tables[0].Rows[row]["prazo_dev"].ToString().Trim();
                    prazo_pro = ds0.Tables[0].Rows[row]["prazo_pro"].ToString().Trim();
                    multa = ds0.Tables[0].Rows[row]["multa"].ToString().Trim();
                    juros = ds0.Tables[0].Rows[row]["juros"].ToString().Trim();
                    comissao = ds0.Tables[0].Rows[row]["com_perm"].ToString().Trim();
                    carteira = ds0.Tables[0].Rows[row]["cod_carte"].ToString().Trim();
                    try
                    {
                        num_inicial = ds0.Tables[0].Rows[row]["num_ini"].ToString().Trim();
                        if (num_inicial == string.Empty)
                            num_inicial = "0";
                        num_final = ds0.Tables[0].Rows[row]["num_fim"].ToString().Trim();
                        if (num_final == string.Empty)
                            num_final = "0";
                        sequencia = ds0.Tables[0].Rows[row]["sequencia"].ToString().Trim();
                        if (sequencia == string.Empty)
                            sequencia = "0";
                        //
                        numero_atual = ds0.Tables[0].Rows[row]["num_atu"].ToString().Trim();
                        if (numero_atual == string.Empty)
                            numero_atual = "0";
                        complemento = ds0.Tables[0].Rows[row]["complement"].ToString().Trim();
                    }
                    catch (Exception)
                    {
                        num_inicial = "0";
                        num_final = "0";
                        sequencia = "0";
                        numero_atual = "0";
                        complemento = "";
                    }
                    //
                    if (cod_banco != String.Empty)
                    {
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

                    }

                    cod_banco = "";
                    nome = "";
                    data = Convert.ToDateTime("01/01/1900");
                    drive = "";
                    pasta_remessa = "";
                    pasta_retorno = "";
                    pasta_envelope = "";
                    assunto = "";
                    caixa_postal = "";
                    mascara_remessa = "";
                    mascara_retorno = "";
                    nome_arquivo = "";
                    numero_arquivo = "";
                    prazo_fol = "";
                    prazo_dev = "";
                    prazo_pro = "";
                    multa = "";
                    juros = "";
                    comissao = "";
                    carteira = "";
                    num_inicial = "";
                    num_final = "";
                    sequencia = "";
                    numero_atual = "";
                    complemento = "";


                }
                //Fim Migração Arquivo Bancos
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Bancos OK \n\n";
            }
        }
    }

    private void MigrarContasCorrentes()
    {
        //Migração Arquivo Contas Correntes
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"contas.dbf";
                var sql = "select * from " + fileName1 + "  ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete contas");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Contas Correntes, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Contas Correntes Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Contas Correntes!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Clientes Contas Correntes!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Contas Correntes Não OK \n\n";
        }

        //Migração
        if (lOk)
        {
            string codigo = "";
            string cod_banco = "";
            string cod_agencia = "";
            string cod_conta = "";
            string nome_agencia = "";
            string cidade = "";
            string uf = "";
            string cep = "";
            string limite_cheque = "";
            string conta_contabil = "";
            string complemento = "";
            string combo = "1";

            //
            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["cod_banco"].ToString() != String.Empty)
                {
                    // Produtos
                    codigo = ds0.Tables[0].Rows[row]["codigo"].ToString().Trim();
                    cod_banco = ds0.Tables[0].Rows[row]["cod_banco"].ToString().Trim();
                    cod_agencia = ds0.Tables[0].Rows[row]["cod_agenci"].ToString().Trim();
                    cod_conta = ds0.Tables[0].Rows[row]["cod_cc"].ToString().Trim();
                    nome_agencia = ds0.Tables[0].Rows[row]["nome_agenc"].ToString().Trim();
                    nome_agencia = nome_agencia.ToUpper();
                    cidade = ds0.Tables[0].Rows[row]["cidade"].ToString().Trim();
                    uf = ds0.Tables[0].Rows[row]["estado"].ToString().Trim();
                    limite_cheque = ds0.Tables[0].Rows[row]["limite"].ToString();
                    conta_contabil = ds0.Tables[0].Rows[row]["contabil"].ToString().Trim();
                    try
                    {
                        complemento = ds0.Tables[0].Rows[row]["complement"].ToString().Trim();
                    }
                    catch (Exception)
                    {
                        //
                    }
                    //


                    if (cod_banco != String.Empty)
                    {
                        uContas.Grava(codigo,
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
                                     combo
                                     );

                        uContas.CriarTabelaContasCorrentes(codigo);

                        MigrarContasCorrentesIndividual(codigo);
                    }

                    codigo = "";
                    cod_banco = "";
                    cod_agencia = "";
                    cod_conta = "";
                    nome_agencia = "";
                    cidade = "";
                    uf = "";
                    cep = "";
                    limite_cheque = "";
                    conta_contabil = "";
                    complemento = "";
                }

                //Fim Migração Arquivo Contas Correntes
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Contas Correntes OK \n\n";
            }
        }
    }


    private void MigrarContasCorrentesIndividual(string codigo_conta)
    {
        //Migração Arquivo Contas Correntes
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds1.Clear();
                fileName1 = @"conta_" + Srelib.QStr0(codigo_conta.Trim(), 2) + ".dbf";
                var sql = "select * from " + fileName1;// +"  order by data ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds1);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete conta_" + Srelib.QStr0(codigo_conta.Trim(), 5));
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Contas Correntes - Conta " + codigo_conta.Trim() + ", possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Contas Correntes Individual  individual - Conta " + codigo_conta + " Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Contas Correntes - Conta " + codigo_conta.Trim() + " !');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Contas Correntes Individual!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Contas Correntes Individual - Conta " + codigo_conta + " Não OK \n\n";
        }

        //Migração
        if (lOk)
        {

            string lancamento = "";
            string produto = "";
            string classe = "";
            string pedido_compra = "";
            DateTime data = Convert.ToDateTime("01/01/1900");
            string descricao = "";
            string complemento = "";
            string saldo_i = "";
            string credito = "";
            string debito = "";
            string saldo_f = "";
            string saldo_aplicacaoD = "";
            string saldo_aplicacaoB = "";
            string saldo_total = "";
            string cheque = "";
            string cmc7 = "";
            DateTime dtregistro = Convert.ToDateTime("01/01/1900");

            //
            for (int row = 0; row < ds1.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds1.Tables[0].Rows[row]["lancamento"].ToString() != String.Empty)
                {
                    //

                    lancamento = ds1.Tables[0].Rows[row]["lancamento"].ToString().Trim();
                    produto = ds1.Tables[0].Rows[row]["empreendim"].ToString().Trim();
                    classe = Srelib.tirasimbolos(ds1.Tables[0].Rows[row]["classe"].ToString().Trim());
                    if (classe == string.Empty)
                        classe = "0";
                    //
                    pedido_compra = Srelib.tirasimbolos(ds1.Tables[0].Rows[row]["num_compra"].ToString().Trim());
                    if (pedido_compra == string.Empty)
                        pedido_compra = "0";
                    //
                    if (ds1.Tables[0].Rows[row]["data"].ToString().Trim() != "")
                        data = Convert.ToDateTime(ds1.Tables[0].Rows[row]["data"]);
                    //
                    descricao = Srelib.tiraacento(ds1.Tables[0].Rows[row]["descricao"].ToString().Trim());
                    complemento = Srelib.tiraacento(ds1.Tables[0].Rows[row]["descrica2"].ToString().Trim());
                    saldo_i = ds1.Tables[0].Rows[row]["saldo_i"].ToString().Trim();
                    credito = ds1.Tables[0].Rows[row]["entradas"].ToString().Trim();
                    debito = ds1.Tables[0].Rows[row]["saidas"].ToString().Trim();
                    saldo_f = ds1.Tables[0].Rows[row]["saldo_f"].ToString().Trim();
                    saldo_aplicacaoD = ds1.Tables[0].Rows[row]["aplicacaoD"].ToString().Trim();
                    saldo_aplicacaoB = ds1.Tables[0].Rows[row]["aplicacaoB"].ToString().Trim();
                    saldo_total = ds1.Tables[0].Rows[row]["saldo_f"].ToString().Trim();
                    //cheque = ds1.Tables[0].Rows[row]["cheque"].ToString().Trim();
                    //cmc7 = ds1.Tables[0].Rows[row]["cheque"].ToString().Trim();
                    dtregistro = Convert.ToDateTime("01/01/1900");

                    if (codigo_conta != String.Empty)
                    {
                        uContas.GravaLancamento(codigo_conta,
                                                lancamento,
                                                produto,
                                                classe,
                                                pedido_compra,
                                                Convert.ToString(data),
                                                descricao,
                                                complemento,
                                                saldo_i,
                                                credito,
                                                debito,
                                                saldo_f,
                                                saldo_aplicacaoD,
                                                saldo_aplicacaoB,
                                                saldo_total,
                                                cheque,
                                                cmc7,
                                                Convert.ToString(dtregistro)
                                                );

                    }

                    lancamento = "";
                    produto = "";
                    classe = "";
                    pedido_compra = "";
                    data = Convert.ToDateTime("01/01/1900");
                    descricao = "";
                    complemento = "";
                    saldo_i = "";
                    credito = "";
                    debito = "";
                    saldo_f = "";
                    saldo_aplicacaoD = "";
                    saldo_aplicacaoB = "";
                    saldo_total = "";
                    cheque = "";
                    cmc7 = "";
                    dtregistro = Convert.ToDateTime("01/01/1900");
                }

                //Fim Migração Arquivo Contas Correntes
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds1.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Contas Correntes individual - Conta " + codigo_conta + " OK \n\n";
            }
        }
    }

    private void MigrarSaldoInicial()
    {
        //Migração Arquivo Saldos das Contas Correntes
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF 1
                ds0.Clear();
                fileName1 = @"contas.dbf";
                var sql = "select * from " + fileName1 + "  ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete contas_saldo_inicial");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Saldos das Contas Correntes, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Saldos das Contas Correntes Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Saldos das Contas Correntes!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Saldos das Contas Correntes!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Saldos das Contas Correntes Não OK \n\n";
        }

        //Migração
        if (lOk)
        {

            string cod_conta = "";
            DateTime data = Convert.ToDateTime("01/01/1900");
            string descricao = "";
            string complemento = "";
            string saldo_i = "";
            string saldo_aplicacaoD = "";
            string saldo_aplicacaoB = "";
            DateTime dtregistro = Convert.ToDateTime("01/01/1900");


            //
            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["codigo"].ToString() != String.Empty)
                {
                    // Produtos
                    cod_conta = ds0.Tables[0].Rows[row]["codigo"].ToString().Trim();
                    data = Convert.ToDateTime(uContas.PegaSaldoInicialDataMigracao(cod_conta));
                    descricao = "SALDO INCIAL";
                    complemento = "";
                    saldo_i = uContas.PegaSaldoInicialMigracao(cod_conta);
                    saldo_aplicacaoD = uContas.PegaSaldoInicialAplicacaoDMigracao(cod_conta);
                    if (saldo_aplicacaoD == string.Empty)
                        saldo_aplicacaoD = "0";
                    saldo_aplicacaoB = uContas.PegaSaldoInicialAplicacaoBMigracao(cod_conta);
                    if (saldo_aplicacaoB == string.Empty)
                        saldo_aplicacaoB = "0";
                    dtregistro = DateTime.Now;

                    if (cod_conta != String.Empty)
                    {
                        uContas.GravaSaldoInicial(cod_conta,
                                                  Convert.ToString(data),
                                                  descricao,
                                                  complemento,
                                                  Srelib.forcaponto(saldo_i),
                                                  Srelib.forcaponto(saldo_aplicacaoD),
                                                  Srelib.forcaponto(saldo_aplicacaoB),
                                                  Convert.ToString(dtregistro)
                                                  );

                    }

                    cod_conta = "";
                    data = Convert.ToDateTime("01/01/1900");
                    descricao = "";
                    complemento = "";
                    saldo_i = "";
                    dtregistro = Convert.ToDateTime("01/01/1900");
                    saldo_aplicacaoD = "";
                    saldo_aplicacaoB = "";

                }

                //Fim Migração Arquivo Saldos das Contas Correntes
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Saldos das Contas Correntes OK \n\n";
            }
        }
    }

    private void MigrarLancamentosContasaReceber()
    {
        ////Migração Arquivo Contas á Receber
        //Boolean lOk = true;
        //string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        //try
        //{
        //    using (OleDbConnection con = new OleDbConnection(constr))
        //    {
        //        //DBF
        //        ds0.Clear();
        //        fileName1 = @"creceber.dbf";
        //        var sql = "select * from " + fileName1 + "  " + " order by lancamento";
        //        OleDbCommand cmd = new OleDbCommand(sql, con);
        //        con.Open();
        //        //DataSet ds = new DataSet();
        //        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        //        da.Fill(ds0);
        //        con.Close();
        //        //SQL
        //        try
        //        {
        //            SreDblib.ExecScript("delete contas_receber");
        //        }
        //        catch (Exception)
        //        {
        //            MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Contas á Receber, possivel registros filhos relacionados. \n";
        //            MemoAtividades.Text = MemoAtividades.Text + "Contas á Receber Não OK \n\n";
        //            lOk = false;
        //        }
        //        //
        //    }
        //}
        //catch (Exception)
        //{
        //    //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Contas á Receber!');", true);
        //    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
        //    "toastr.info('Não foi possivel migrar Contas á Receber!', 'Atenção!')", true);
        //    MemoAtividades.Text = MemoAtividades.Text + "Contas á Receber Não OK \n\n";
        //}

        //Migração Arquivo Contas á Receber de Origem SQL
        Boolean lOk = true;
        try
        {
            ds0.Clear();
            ds0 = SreDblib.GetDsScript("select * from creceber");
            //
            //SQL
            try
            {
                SreDblib.ExecScript("delete contas_receber");
            }
            catch (Exception)
            {
                MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Contas á Receber, possivel registros filhos relacionados. \n";
                MemoAtividades.Text = MemoAtividades.Text + "Contas á Receber Não OK \n\n";
                lOk = false;
            }
            //
        }
        catch (Exception)
        {
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Contas á Receber!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Contas á Receber Não OK \n\n";
        }

        //Migração
        if (lOk)
        {

            string lancamento = "";
            string produto = "";
            string classe = "";
            string cliente = "";
            string descricao = "";
            DateTime dtprevista = Convert.ToDateTime("01/01/1900");
            decimal vlr_previsto = 0;
            DateTime dtrealizado = Convert.ToDateTime("01/01/1900");
            decimal vlr_realizado = 0;
            string conta = "";
            string documento = "";
            DateTime dtdocumento = Convert.ToDateTime("01/01/1900");
            string cheque = "";
            string cmc7 = "";
            DateTime dtcompensacao = Convert.ToDateTime("01/01/1900");
            Boolean contabil = false;
            string integracao_contabil = "";
            //
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
            }

            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["lancamento"].ToString() != String.Empty)
                {
                    // Produtos
                    lancamento = ds0.Tables[0].Rows[row]["lancamento"].ToString().Trim();
                    produto = ds0.Tables[0].Rows[row]["empreendim"].ToString().Trim();
                    classe = ds0.Tables[0].Rows[row]["classe_r"].ToString().Trim();
                    cliente = ds0.Tables[0].Rows[row]["codigo_cli"].ToString().Trim();
                    descricao = Srelib.tiraacento(ds0.Tables[0].Rows[row]["descricao"].ToString().Trim());
                    //
                    //try
                    //{
                    //    dtprevista = Convert.ToDateTime(ds0.Tables[0].Rows[row]["data_prev"].ToString());
                    //    if (dtprevista == Convert.ToDateTime("11/11/1111"))
                    //    {
                    //        dtprevista = Convert.ToDateTime("01/01/1900");
                    //    }
                    //}
                    //catch (Exception)
                    //{
                    //    dtprevista = Convert.ToDateTime("01/01/1900");
                    //}
                    //
                    if (ds0.Tables[0].Rows[row]["data_prev"].ToString() != "")
                    {
                        dtprevista = Convert.ToDateTime(
                                     ds0.Tables[0].Rows[row]["data_prev"].ToString().Substring(3, 2) + "/" +
                                     ds0.Tables[0].Rows[row]["data_prev"].ToString().Substring(0, 2) + "/" +
                                     ds0.Tables[0].Rows[row]["data_prev"].ToString().Substring(6, 4));
                        //dtprevista = Convert.ToDateTime(ds0.Tables[0].Rows[row]["data_prev"]);
                    }

                    if (ds0.Tables[0].Rows[row]["previsto"].ToString() != "")
                        vlr_previsto = Convert.ToDecimal(ds0.Tables[0].Rows[row]["previsto"]);

                    if (ds0.Tables[0].Rows[row]["data_real"].ToString() != "")
                    {
                        dtrealizado = Convert.ToDateTime(
                                     ds0.Tables[0].Rows[row]["data_real"].ToString().Substring(3, 2) + "/" +
                                     ds0.Tables[0].Rows[row]["data_real"].ToString().Substring(0, 2) + "/" +
                                     ds0.Tables[0].Rows[row]["data_real"].ToString().Substring(6, 4));
                        //dtrealizado = Convert.ToDateTime(ds0.Tables[0].Rows[row]["data_real"]);
                    }
                    if (ds0.Tables[0].Rows[row]["realizado"].ToString() != "")
                        vlr_realizado = Convert.ToDecimal(ds0.Tables[0].Rows[row]["realizado"]);

                    conta = ds0.Tables[0].Rows[row]["cod_conta"].ToString().Trim();
                    documento = Srelib.tiraacento(ds0.Tables[0].Rows[row]["num_docume"].ToString().Trim());
                    if (ds0.Tables[0].Rows[row]["data_nota"].ToString() != "")
                    {
                        dtdocumento = Convert.ToDateTime(
                                     ds0.Tables[0].Rows[row]["data_nota"].ToString().Substring(3, 2) + "/" +
                                     ds0.Tables[0].Rows[row]["data_nota"].ToString().Substring(0, 2) + "/" +
                                     ds0.Tables[0].Rows[row]["data_nota"].ToString().Substring(6, 4));
                        //dtdocumento = Convert.ToDateTime(ds0.Tables[0].Rows[row]["data_nota"]);
                    }

                    cheque = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["num_cheque"].ToString().Trim());
                    cmc7 = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["num_cheque"].ToString().Trim());

                    if (ds0.Tables[0].Rows[row]["data_compe"].ToString() != "")
                    {
                        dtcompensacao = Convert.ToDateTime(
                                     ds0.Tables[0].Rows[row]["data_compe"].ToString().Substring(3, 2) + "/" +
                                     ds0.Tables[0].Rows[row]["data_compe"].ToString().Substring(0, 2) + "/" +
                                     ds0.Tables[0].Rows[row]["data_compe"].ToString().Substring(6, 4));
                        //dtcompensacao = Convert.ToDateTime(ds0.Tables[0].Rows[row]["data_compe"]);
                    }
                    contabil = Convert.ToBoolean(ds0.Tables[0].Rows[row]["contabil"]);

                    integracao_contabil = ds0.Tables[0].Rows[row]["integracao"].ToString().Trim();

                    if (lancamento != String.Empty)
                    {
                        uContasReceber.Grava(lancamento,
                                            produto,
                                            classe,
                                            cliente,
                                            descricao,
                                            Convert.ToString(dtprevista).Substring(0, 10),
                                            vlr_previsto,
                                            Convert.ToString(dtrealizado).Substring(0, 10),
                                            vlr_realizado,
                                            conta,
                                            documento,
                                            Convert.ToString(dtdocumento).Substring(0, 10),
                                            cheque,
                                            cmc7,
                                            Convert.ToString(dtcompensacao).Substring(0, 10),
                                            Convert.ToInt16(contabil),
                                            integracao_contabil
                                            );

                    }

                    lancamento = "";
                    produto = "";
                    classe = "";
                    descricao = "";
                    dtprevista = Convert.ToDateTime("01/01/1900");
                    vlr_previsto = 0;
                    dtrealizado = Convert.ToDateTime("01/01/1900");
                    vlr_realizado = 0;
                    conta = "";
                    documento = "";
                    dtdocumento = Convert.ToDateTime("01/01/1900");
                    cheque = "";
                    cmc7 = "";
                    dtcompensacao = Convert.ToDateTime("01/01/1900");
                    contabil = false;
                    integracao_contabil = "";


                }
                //Fim Migração Arquivo Contas á Receber
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Contas á Receber OK \n\n";
            }
        }
    }

    private void MigrarLancamentosContasaPagar()
    {
        //Migração Arquivo Contas á Pagar de Origem DBF
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"cpagar.dbf";
                var sql = "select * from " + fileName1 + "  " + " order by lancamento";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete contas_pagar");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Contas á Pagar, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Contas á Pagar Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Contas á Pagar!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Contas á Pagar!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Contas á Pagar Não OK \n\n";
        }

        ////Migração Arquivo Contas á Pagar de Origem SQL
        //Boolean lOk = true;
        //try
        //{
        //    ds0.Clear();
        //    ds0 = SreDblib.GetDsScript("select * from cpagar");
        //    //
        //    //SQL
        //    try
        //    {
        //        SreDblib.ExecScript("delete contas_pagar");
        //    }
        //    catch (Exception)
        //    {
        //        MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Contas á Pagar, possivel registros filhos relacionados. \n";
        //        MemoAtividades.Text = MemoAtividades.Text + "Contas á Pagar Não OK \n\n";
        //        lOk = false;
        //    }
        //    //
        //}
        //catch (Exception)
        //{
        //    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
        //    "toastr.info('Não foi possivel migrar Contas á Pagar!', 'Atenção!')", true);
        //    MemoAtividades.Text = MemoAtividades.Text + "Contas á Pagar Não OK \n\n";
        //}

        //Migração
        if (lOk)
        {

            string lancamento = "";
            string produto = "";
            string classe = "";
            string descricao = "";
            string fornecedor = "";
            DateTime dtprevista = Convert.ToDateTime("01/01/1900");
            decimal vlr_previsto = 0;
            DateTime dtrealizado = Convert.ToDateTime("01/01/1900");
            decimal vlr_realizado = 0;
            string conta = "";
            string documento = "";
            DateTime dtdocumento = Convert.ToDateTime("01/01/1900");
            string cheque = "";
            string cmc7 = "";
            DateTime dtcompensacao = Convert.ToDateTime("01/01/1900");
            Boolean contabil = false;
            string integracao_contabil = "";
            string pedido_compra = "";
            string grupo = "";
            Boolean nominal = false;

            //
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
            }

            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["lancamento"].ToString() != String.Empty)
                {
                    // Produtos
                    lancamento = ds0.Tables[0].Rows[row]["lancamento"].ToString().Trim();
                    produto = ds0.Tables[0].Rows[row]["empreendim"].ToString().Trim();
                    classe = ds0.Tables[0].Rows[row]["classe_d"].ToString().Trim();
                    fornecedor = ds0.Tables[0].Rows[row]["codigo_for"].ToString().Trim();
                    descricao = Srelib.tiraacento(ds0.Tables[0].Rows[row]["descricao"].ToString().Trim());
                    if (ds0.Tables[0].Rows[row]["data_prev"].ToString() != "")
                    {
                        //dtprevista = Convert.ToDateTime(
                        //             ds0.Tables[0].Rows[row]["data_prev"].ToString().Substring(8, 2) + "/" +
                        //             ds0.Tables[0].Rows[row]["data_prev"].ToString().Substring(5, 2) + "/" +
                        //             ds0.Tables[0].Rows[row]["data_prev"].ToString().Substring(0, 4));
                        dtprevista = Convert.ToDateTime(ds0.Tables[0].Rows[row]["data_prev"]);
                        if (dtprevista < Convert.ToDateTime("01/01/1900"))
                            dtprevista = Convert.ToDateTime("01/01/1900");
                    }
                    if (ds0.Tables[0].Rows[row]["previsto"].ToString() != "")
                    {
                        vlr_previsto = Convert.ToDecimal(ds0.Tables[0].Rows[row]["previsto"]);
                    }
                    if (ds0.Tables[0].Rows[row]["data_real"].ToString() != "")
                    {
                        //dtrealizado = Convert.ToDateTime(
                        //             ds0.Tables[0].Rows[row]["data_real"].ToString().Substring(8, 2) + "/" +
                        //             ds0.Tables[0].Rows[row]["data_real"].ToString().Substring(5, 2) + "/" +
                        //             ds0.Tables[0].Rows[row]["data_real"].ToString().Substring(0, 4));
                        dtrealizado = Convert.ToDateTime(ds0.Tables[0].Rows[row]["data_real"]);
                        if (dtrealizado < Convert.ToDateTime("01/01/1900"))
                            dtrealizado = Convert.ToDateTime("01/01/1900");
                    }

                    if (ds0.Tables[0].Rows[row]["realizado"].ToString() != "")
                    {
                        vlr_realizado = Convert.ToDecimal(ds0.Tables[0].Rows[row]["realizado"]);
                    }
                    conta = ds0.Tables[0].Rows[row]["cod_conta"].ToString().Trim();
                    documento = Srelib.tiraacento(ds0.Tables[0].Rows[row]["num_docume"].ToString().Trim());
                    if (ds0.Tables[0].Rows[row]["data_nota"].ToString() != "")
                    {
                        //dtdocumento = Convert.ToDateTime(
                        //             ds0.Tables[0].Rows[row]["data_nota"].ToString().Substring(8, 2) + "/" +
                        //             ds0.Tables[0].Rows[row]["data_nota"].ToString().Substring(5, 2) + "/" +
                        //             ds0.Tables[0].Rows[row]["data_nota"].ToString().Substring(0, 4));
                        dtdocumento = Convert.ToDateTime(ds0.Tables[0].Rows[row]["data_nota"]);
                        if (dtdocumento < Convert.ToDateTime("01/01/1900"))
                            dtdocumento = Convert.ToDateTime("01/01/1900");
                    }
                    cheque = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["num_cheque"].ToString().Trim());
                    cmc7 = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["num_cheque"].ToString().Trim());

                    if (ds0.Tables[0].Rows[row]["data_compe"].ToString() != "")
                    {
                        //dtcompensacao = Convert.ToDateTime(
                        //             ds0.Tables[0].Rows[row]["data_compe"].ToString().Substring(8, 2) + "/" +
                        //             ds0.Tables[0].Rows[row]["data_compe"].ToString().Substring(5, 2) + "/" +
                        //             ds0.Tables[0].Rows[row]["data_compe"].ToString().Substring(0, 4));
                        dtcompensacao = Convert.ToDateTime(ds0.Tables[0].Rows[row]["data_compe"]);
                    }
                    contabil = Convert.ToBoolean(ds0.Tables[0].Rows[row]["contabil"]);

                    integracao_contabil = ds0.Tables[0].Rows[row]["integracao"].ToString().Trim();

                    pedido_compra = Srelib.tirasimbolos(ds0.Tables[0].Rows[row]["num_compra"].ToString().Trim());
                    grupo = ds0.Tables[0].Rows[row]["grupo"].ToString().Trim();

                    if (ds0.Tables[0].Rows[row]["nominal"].ToString() == "S")
                    {
                        nominal = true;
                    }
                    //
                    if (lancamento != String.Empty)
                    {
                        uContasPagar.Grava(ref lancamento,
                                            produto,
                                            classe,
                                            fornecedor,
                                            descricao,
                                            Convert.ToString(dtprevista).Substring(0, 10),
                                            vlr_previsto,
                                            Convert.ToString(dtrealizado).Substring(0, 10),
                                            vlr_realizado,
                                            conta,
                                            documento,
                                            Convert.ToString(dtdocumento).Substring(0, 10),
                                            cheque,
                                            cmc7,
                                            Convert.ToString(dtcompensacao).Substring(0, 10),
                                            Convert.ToInt16(contabil),
                                            integracao_contabil,
                                            pedido_compra,
                                            grupo,
                                            Convert.ToInt16(nominal)
                                            );

                    }

                    lancamento = "";
                    produto = "";
                    classe = "";
                    fornecedor = "";
                    descricao = "";
                    dtprevista = Convert.ToDateTime("01/01/1900");
                    vlr_previsto = 0;
                    dtrealizado = Convert.ToDateTime("01/01/1900");
                    vlr_realizado = 0;
                    conta = "";
                    documento = "";
                    dtdocumento = Convert.ToDateTime("01/01/1900");
                    cheque = "";
                    cmc7 = "";
                    dtcompensacao = Convert.ToDateTime("01/01/1900");
                    contabil = false;
                    integracao_contabil = "";
                    pedido_compra = "";
                    grupo = "";
                    nominal = false;

                }
                //Fim Migração Arquivo Contas á Pagar
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Contas á Pagar OK \n\n";
            }
        }
    }

    private void MigrarUnidades()
    {
        //Migração Arquivo Unidades
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"uni_imob.dbf";
                var sql = "select * from " + fileName1 + " order by classe, quadra, num_imovel, status ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete produto_unidades");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Unidades, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Unidades Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Unidades!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Unidades!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Unidades Não OK \n\n";
        }



        //Migração
        if (lOk)
        {

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
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
            }

            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["classe"].ToString() != String.Empty)
                {
                    // 
                    produto = ds0.Tables[0].Rows[row]["classe"].ToString().Trim();
                    grupo = ds0.Tables[0].Rows[row]["quadra"].ToString().Trim();
                    unidade = ds0.Tables[0].Rows[row]["num_imovel"].ToString().Trim();
                    parte = ds0.Tables[0].Rows[row]["status"].ToString().Trim();
                    if (ds0.Tables[0].Rows[row]["metragem_1"].ToString() != "")
                    {
                        metragem_total = Convert.ToDecimal(ds0.Tables[0].Rows[row]["metragem_1"]);
                        metragem_1 = Convert.ToDecimal(ds0.Tables[0].Rows[row]["metragem_1"]);
                    }
                    if (ds0.Tables[0].Rows[row]["valor_1"].ToString() != "")
                    {
                        vlr_total = Convert.ToDecimal(ds0.Tables[0].Rows[row]["valor_1"]);
                        vlr_1 = Convert.ToDecimal(ds0.Tables[0].Rows[row]["valor_1"]);
                    }
                    inscricao_1 = ds0.Tables[0].Rows[row]["inscrica_1"].ToString().Trim();
                    proprietario_1 = ds0.Tables[0].Rows[row]["propriet_1"].ToString().Trim();
                    quitado_1 = Convert.ToBoolean(ds0.Tables[0].Rows[row]["quitado_1"]);
                    //
                    try
                    {
                        if (ds0.Tables[0].Rows[row]["escritu_01"].ToString() == "S")
                            escritura_1 = true;
                    }
                    catch (Exception)
                    {
                        escritura_1 = false;
                    }

                    if (ds0.Tables[0].Rows[row]["escritur_1"].ToString() != "")
                    {
                        dtescritura_1 = Convert.ToDateTime(ds0.Tables[0].Rows[row]["escritur_1"]);
                        if (dtescritura_1 < Convert.ToDateTime("01/01/1900"))
                            dtescritura_1 = Convert.ToDateTime("01/01/1900");
                    }
                    if (ds0.Tables[0].Rows[row]["processo_1"].ToString() != "")
                    {
                        processo_1 = Convert.ToBoolean(ds0.Tables[0].Rows[row]["processo_1"]);
                    }
                    obs_1 = ds0.Tables[0].Rows[row]["obs_proc_1"].ToString().Trim();
                    // 
                    if (ds0.Tables[0].Rows[row]["metragem_2"].ToString() != "")
                    {
                        metragem_2 = Convert.ToDecimal(ds0.Tables[0].Rows[row]["metragem_2"]);
                    }
                    if (ds0.Tables[0].Rows[row]["valor_2"].ToString() != "")
                    {
                        vlr_2 = Convert.ToDecimal(ds0.Tables[0].Rows[row]["valor_2"]);
                    }
                    inscricao_2 = ds0.Tables[0].Rows[row]["inscrica_2"].ToString().Trim();
                    proprietario_2 = ds0.Tables[0].Rows[row]["propriet_2"].ToString().Trim();
                    quitado_2 = Convert.ToBoolean(ds0.Tables[0].Rows[row]["quitado_2"]);
                    //
                    try
                    {
                        if (ds0.Tables[0].Rows[row]["escritu_02"].ToString() == "S")
                            escritura_2 = true;
                    }
                    catch (Exception)
                    {
                        escritura_2 = false;
                    }
                    //
                    if (ds0.Tables[0].Rows[row]["escritur_2"].ToString() != "")
                    {
                        dtescritura_2 = Convert.ToDateTime(ds0.Tables[0].Rows[row]["escritur_2"]);
                        if (dtescritura_2 < Convert.ToDateTime("01/01/1900"))
                            dtescritura_2 = Convert.ToDateTime("01/01/1900");
                    }
                    if (ds0.Tables[0].Rows[row]["processo_2"].ToString() != "")
                    {
                        processo_2 = Convert.ToBoolean(ds0.Tables[0].Rows[row]["processo_2"]);
                    }
                    obs_2 = ds0.Tables[0].Rows[row]["obs_proc_2"].ToString().Trim();

                    if (produto != String.Empty)
                    {
                        uUnidade.Grava(produto,
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
                    }

                    produto = "";
                    grupo = "";
                    unidade = "";
                    parte = "";
                    metragem_total = 0;
                    vlr_total = 0;
                    vlr_1 = 0;
                    metragem_1 = 0;
                    inscricao_1 = "";
                    proprietario_1 = "";
                    quitado_1 = false;
                    escritura_1 = false;
                    dtescritura_1 = Convert.ToDateTime("01/01/1900");
                    cartorio_1 = "";
                    livro_1 = "";
                    folha_1 = "";
                    processo_1 = false;
                    obs_1 = "";
                    vlr_2 = 0;
                    metragem_2 = 0;
                    inscricao_2 = "";
                    proprietario_2 = "";
                    quitado_2 = false;
                    escritura_2 = false;
                    dtescritura_2 = Convert.ToDateTime("01/01/1900");
                    cartorio_2 = "";
                    livro_2 = "";
                    folha_2 = "";
                    processo_2 = false;
                    obs_2 = "";
                    //
                    area_privativa_coletiva_m2 = 0;
                    area_privativa_terraco_coberto_m2 = 0;
                    area_privativa_terraco_descoberto_m2 = 0;
                    area_comum_m2 = 0;
                    area_garagem_m2 = 0;
                    area_hobby_box_m2 = 0;
                    area_total_m2 = 0;
                    fracao_ideal_m2 = 0;
                    fracao_ideal_percentual = 0;
                    hobby_box_numero = "";
                    hobby_box_localizacao = "";
                    numero_garagem_01 = "";
                    numero_garagem_02 = "";
                    numero_garagem_03 = "";
                    numero_garagem_04 = "";
                    numero_garagem_05 = "";
                    vagas_localizacao = "";
                    vagas_quantidade = 0;

                }
                //Fim Migração Arquivo Unidades
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Unidades OK \n\n";
            }
        }
    }


    private void MigrarVendas()
    {
        //Migração Arquivo Vendas
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"cad_vend.dbf";
                var sql = "select * from " + fileName1 + "  ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete vendas");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Vendas, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Vendas Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Vendas!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Vendas!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Vendas Não OK \n\n";
        }

        //Migração
        if (lOk)
        {

            string produto = "";
            string grupo = "";
            string unidade = "";
            string parte = "";
            string cliente = "";
            DateTime data_venda = Convert.ToDateTime("01/01/1900");
            decimal vlr_venda = 0;
            decimal vlr_sinal = 0;
            decimal vlr_fluxo = 0;
            decimal vlr_intermediaria = 0;
            string num_parcelas_sinal = "0";
            string num_parcelas_fluxo = "0";
            string num_parcelas_intermediarias = "0";
            decimal vlr_parcela_fluxo = 0;
            DateTime primeiro_vencimento = Convert.ToDateTime("01/01/1900");
            DateTime ultimo_vencimento = Convert.ToDateTime("01/01/1900");
            Boolean quitado = false;
            string indexador = "";
            string indexador_original = "";
            string periodicidade_correcao = "";
            DateTime ultima_correcao = Convert.ToDateTime("01/01/1900");
            Boolean sinal_parcelado = false;
            string corretor = "";
            string observacao = "";

            //
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
            }

            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["classe"].ToString() != String.Empty)
                {
                    // 
                    produto = ds0.Tables[0].Rows[row]["classe"].ToString().Trim();
                    grupo = ds0.Tables[0].Rows[row]["quadra"].ToString().Trim();
                    unidade = ds0.Tables[0].Rows[row]["num_imovel"].ToString().Trim();
                    parte = ds0.Tables[0].Rows[row]["parte"].ToString().Trim();
                    cliente = ds0.Tables[0].Rows[row]["num_clie"].ToString().Trim();
                    if (ds0.Tables[0].Rows[row]["data_venda"].ToString() != "")
                    {
                        data_venda = Convert.ToDateTime(ds0.Tables[0].Rows[row]["data_venda"]);
                        if (data_venda < Convert.ToDateTime("01/01/1900"))
                            data_venda = Convert.ToDateTime("01/01/1900");
                    }
                    if ((ds0.Tables[0].Rows[row]["sinal"].ToString() != "") &&
                        (ds0.Tables[0].Rows[row]["vlr_parcel"].ToString() != "") &&
                        (ds0.Tables[0].Rows[row]["intermedia"].ToString() != ""))
                    {
                        vlr_venda = Convert.ToDecimal(ds0.Tables[0].Rows[row]["sinal"]) +
                                    Convert.ToDecimal(ds0.Tables[0].Rows[row]["vlr_parcel"]) +
                                    Convert.ToDecimal(ds0.Tables[0].Rows[row]["intermedia"]);
                    }
                    if (ds0.Tables[0].Rows[row]["sinal"].ToString() != "")
                    {
                        vlr_sinal = Convert.ToDecimal(ds0.Tables[0].Rows[row]["sinal"]);
                    }
                    if ((ds0.Tables[0].Rows[row]["vlr_parcel"].ToString() != "") &&
                        (ds0.Tables[0].Rows[row]["parcelas"].ToString() != ""))
                    {
                        vlr_fluxo = Convert.ToDecimal(ds0.Tables[0].Rows[row]["vlr_parcel"]) *
                                    Convert.ToInt16(ds0.Tables[0].Rows[row]["parcelas"]);
                    }
                    if (ds0.Tables[0].Rows[row]["intermedia"].ToString() != "")
                    {
                        vlr_intermediaria = Convert.ToDecimal(ds0.Tables[0].Rows[row]["intermedia"]);
                    }
                    if (ds0.Tables[0].Rows[row]["parcelas"].ToString() != "")
                    {
                        num_parcelas_fluxo = ds0.Tables[0].Rows[row]["parcelas"].ToString().Trim();
                    }
                    if (ds0.Tables[0].Rows[row]["num_interm"].ToString() != "")
                    {
                        num_parcelas_intermediarias = ds0.Tables[0].Rows[row]["num_interm"].ToString().Trim();
                    }
                    if (ds0.Tables[0].Rows[row]["vlr_parcel"].ToString() != "")
                    {
                        vlr_parcela_fluxo = Convert.ToDecimal(ds0.Tables[0].Rows[row]["vlr_parcel"]);
                    }
                    if (ds0.Tables[0].Rows[row]["pri_venc"].ToString() != "")
                    {
                        primeiro_vencimento = Convert.ToDateTime(ds0.Tables[0].Rows[row]["pri_venc"]);
                        if (primeiro_vencimento < Convert.ToDateTime("01/01/1900"))
                            primeiro_vencimento = Convert.ToDateTime("01/01/1900");
                    }
                    if (ds0.Tables[0].Rows[row]["ult_venc"].ToString() != "")
                    {
                        ultimo_vencimento = Convert.ToDateTime(ds0.Tables[0].Rows[row]["ult_venc"]);
                        if (ultimo_vencimento < Convert.ToDateTime("01/01/1900"))
                            ultimo_vencimento = Convert.ToDateTime("01/01/1900");
                    }
                    quitado = Convert.ToBoolean(ds0.Tables[0].Rows[row]["quitado"]);
                    indexador = ds0.Tables[0].Rows[row]["indice"].ToString().Trim();
                    periodicidade_correcao = ds0.Tables[0].Rows[row]["periodo"].ToString().Trim();
                    if (ds0.Tables[0].Rows[row]["ult_correc"].ToString() != "")
                    {
                        ultima_correcao = Convert.ToDateTime(ds0.Tables[0].Rows[row]["ult_correc"]);
                        if (ultima_correcao < Convert.ToDateTime("01/01/1900"))
                            ultima_correcao = Convert.ToDateTime("01/01/1900");
                    }
                    sinal_parcelado = Convert.ToBoolean(ds0.Tables[0].Rows[row]["sinal_par"]);
                    corretor = ds0.Tables[0].Rows[row]["corretor"].ToString().Trim();
                    observacao = ds0.Tables[0].Rows[row]["observacao"].ToString().Trim();

                    if (produto != String.Empty)
                    {
                        uVendas.Grava(produto,
                                        grupo,
                                        unidade,
                                        parte,
                                        cliente,
                                        Convert.ToString(data_venda).Substring(0, 10),
                                        vlr_venda,
                                        vlr_sinal,
                                        vlr_fluxo,
                                        vlr_intermediaria,
                                        num_parcelas_sinal,
                                        num_parcelas_fluxo,
                                        num_parcelas_intermediarias,
                                        vlr_parcela_fluxo,
                                        Convert.ToString(primeiro_vencimento).Substring(0, 10),
                                        Convert.ToString(ultimo_vencimento).Substring(0, 10),
                                        Convert.ToInt16(quitado),
                                        indexador,
                                        indexador_original,
                                        periodicidade_correcao,
                                        Convert.ToString(ultima_correcao).Substring(0, 10),
                                        Convert.ToInt16(sinal_parcelado),
                                        corretor,
                                        observacao,
                                        2,
                                        1,
                                        "a.m."
                                        );

                    }

                    produto = "";
                    grupo = "";
                    unidade = "";
                    parte = "";
                    cliente = "";
                    data_venda = Convert.ToDateTime("01/01/1900");
                    vlr_venda = 0;
                    vlr_sinal = 0;
                    vlr_fluxo = 0;
                    vlr_intermediaria = 0;
                    num_parcelas_sinal = "0";
                    num_parcelas_fluxo = "0";
                    num_parcelas_intermediarias = "0";
                    vlr_parcela_fluxo = 0;
                    primeiro_vencimento = Convert.ToDateTime("01/01/1900");
                    ultimo_vencimento = Convert.ToDateTime("01/01/1900");
                    quitado = false;
                    indexador = "";
                    indexador_original = "";
                    periodicidade_correcao = "";
                    ultima_correcao = Convert.ToDateTime("01/01/1900");
                    sinal_parcelado = false;
                    corretor = "";
                    observacao = "";

                }
                //Fim Migração Arquivo Vendas
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Vendas OK \n\n";
            }
        }
    }


    private void MigrarRenegociacoes()
    {
        //Migração Arquivo Vendas
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"renegoci.dbf";
                var sql = "select * from " + fileName1 + "  ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete vendas_renegociacao");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Renegociações, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Renegociações Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Renegociações!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Renegociações!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Renegociações Não OK \n\n";
        }



        //Migração
        if (lOk)
        {

            string produto = "";
            string grupo = "";
            string unidade = "";
            string parte = "";
            string cliente = "";
            DateTime data_venda = Convert.ToDateTime("01/01/1900");
            decimal vlr_venda = 0;
            decimal vlr_sinal = 0;
            decimal vlr_fluxo = 0;
            decimal vlr_intermediaria = 0;
            string num_parcelas_sinal = "0";
            string num_parcelas_fluxo = "0";
            string num_parcelas_intermediarias = "0";
            decimal vlr_parcela_fluxo = 0;
            DateTime primeiro_vencimento = Convert.ToDateTime("01/01/1900");
            DateTime ultimo_vencimento = Convert.ToDateTime("01/01/1900");
            Boolean quitado = false;
            string indexador = "";
            string indexador_original = "";
            string periodicidade_correcao = "";
            DateTime ultima_correcao = Convert.ToDateTime("01/01/1900");
            Boolean sinal_parcelado = false;
            string corretor = "";
            string observacao = "";
            string tipo_renegociacao = "";
            string num_renegociacao = "";

            //
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
            }

            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["classe"].ToString() != String.Empty)
                {
                    // 
                    produto = ds0.Tables[0].Rows[row]["classe"].ToString().Trim();
                    grupo = ds0.Tables[0].Rows[row]["quadra"].ToString().Trim();
                    unidade = ds0.Tables[0].Rows[row]["num_imovel"].ToString().Trim();
                    parte = ds0.Tables[0].Rows[row]["parte"].ToString().Trim();
                    cliente = ds0.Tables[0].Rows[row]["num_clie"].ToString().Trim();
                    if (ds0.Tables[0].Rows[row]["data_reneg"].ToString() != "")
                    {
                        data_venda = Convert.ToDateTime(ds0.Tables[0].Rows[row]["data_reneg"]);
                        if (data_venda < Convert.ToDateTime("01/01/1900"))
                            data_venda = Convert.ToDateTime("01/01/1900");
                    }
                    if ((ds0.Tables[0].Rows[row]["vlr_parcel"].ToString() != "") &&
                        (ds0.Tables[0].Rows[row]["parcelas"].ToString() != "") &&
                        (ds0.Tables[0].Rows[row]["intermedia"].ToString() != ""))
                    {
                        vlr_venda = (Convert.ToDecimal(ds0.Tables[0].Rows[row]["vlr_parcel"]) *
                                    Convert.ToDecimal(ds0.Tables[0].Rows[row]["parcelas"])) +
                                    Convert.ToDecimal(ds0.Tables[0].Rows[row]["intermedia"]);
                    }
                    //if (ds0.Tables[0].Rows[row]["sinal"].ToString() != "")
                    //{
                    //    vlr_sinal = Convert.ToDecimal(ds0.Tables[0].Rows[row]["sinal"]);
                    //}
                    if ((ds0.Tables[0].Rows[row]["vlr_parcel"].ToString() != "") &&
                        (ds0.Tables[0].Rows[row]["parcelas"].ToString() != ""))
                    {
                        vlr_fluxo = Convert.ToDecimal(ds0.Tables[0].Rows[row]["vlr_parcel"]) *
                                    Convert.ToInt16(ds0.Tables[0].Rows[row]["parcelas"]);
                    }
                    if (ds0.Tables[0].Rows[row]["intermedia"].ToString() != "")
                    {
                        vlr_intermediaria = Convert.ToDecimal(ds0.Tables[0].Rows[row]["intermedia"]);
                    }
                    if (ds0.Tables[0].Rows[row]["parcelas"].ToString() != "")
                    {
                        num_parcelas_fluxo = ds0.Tables[0].Rows[row]["parcelas"].ToString().Trim();
                    }
                    if (ds0.Tables[0].Rows[row]["num_interm"].ToString() != "")
                    {
                        num_parcelas_intermediarias = ds0.Tables[0].Rows[row]["num_interm"].ToString().Trim();
                    }
                    if (ds0.Tables[0].Rows[row]["vlr_parcel"].ToString() != "")
                    {
                        vlr_parcela_fluxo = Convert.ToDecimal(ds0.Tables[0].Rows[row]["vlr_parcel"]);
                    }
                    if (ds0.Tables[0].Rows[row]["pri_venc"].ToString() != "")
                    {
                        primeiro_vencimento = Convert.ToDateTime(ds0.Tables[0].Rows[row]["pri_venc"]);
                        if (primeiro_vencimento < Convert.ToDateTime("01/01/1900"))
                            primeiro_vencimento = Convert.ToDateTime("01/01/1900");
                    }
                    //if (ds0.Tables[0].Rows[row]["ult_venc"].ToString() != "")
                    //{
                    //    ultimo_vencimento = Convert.ToDateTime(ds0.Tables[0].Rows[row]["ult_venc"]);
                    //    if (ultimo_vencimento < Convert.ToDateTime("01/01/1900"))
                    ultimo_vencimento = Convert.ToDateTime("01/01/1900");
                    //}
                    //quitado = Convert.ToBoolean(ds0.Tables[0].Rows[row]["quitado"]);
                    //indexador = ds0.Tables[0].Rows[row]["indice"].ToString().Trim();
                    //periodicidade_correcao = ds0.Tables[0].Rows[row]["periodo"].ToString().Trim();
                    //if (ds0.Tables[0].Rows[row]["ult_correc"].ToString() != "")
                    //{
                    //    ultima_correcao = Convert.ToDateTime(ds0.Tables[0].Rows[row]["ult_correc"]);
                    //    if (ultima_correcao < Convert.ToDateTime("01/01/1900"))
                    //        ultima_correcao = Convert.ToDateTime("01/01/1900");
                    //}
                    //sinal_parcelado = Convert.ToBoolean(ds0.Tables[0].Rows[row]["sinal_par"]);
                    //corretor = ds0.Tables[0].Rows[row]["corretor"].ToString().Trim();
                    //observacao = ds0.Tables[0].Rows[row]["observacao"].ToString().Trim();
                    tipo_renegociacao = ds0.Tables[0].Rows[row]["tipo_reneg"].ToString().Trim();
                    num_renegociacao = ds0.Tables[0].Rows[row]["num_reneg"].ToString().Trim();

                    if (produto != String.Empty)
                    {
                        uVendas.GravaRenegociacao(produto,
                                        grupo,
                                        unidade,
                                        parte,
                                        cliente,
                                        Convert.ToString(data_venda).Substring(0, 10),
                                        vlr_venda,
                                        vlr_sinal,
                                        vlr_fluxo,
                                        vlr_intermediaria,
                                        num_parcelas_sinal,
                                        num_parcelas_fluxo,
                                        num_parcelas_intermediarias,
                                        vlr_parcela_fluxo,
                                        Convert.ToString(primeiro_vencimento).Substring(0, 10),
                                        Convert.ToString(ultimo_vencimento).Substring(0, 10),
                                        Convert.ToInt16(quitado),
                                        indexador,
                                        indexador_original,
                                        periodicidade_correcao,
                                        Convert.ToString(ultima_correcao).Substring(0, 10),
                                        Convert.ToInt16(sinal_parcelado),
                                        corretor,
                                        observacao,
                                        2,
                                        1,
                                        "MENSAL",
                                        tipo_renegociacao,
                                        num_renegociacao,
                                        0,
                                        0,
                                        0,
                                        0,
                                        ""
                                        );

                    }

                    produto = "";
                    grupo = "";
                    unidade = "";
                    parte = "";
                    cliente = "";
                    data_venda = Convert.ToDateTime("01/01/1900");
                    vlr_venda = 0;
                    vlr_sinal = 0;
                    vlr_fluxo = 0;
                    vlr_intermediaria = 0;
                    num_parcelas_sinal = "0";
                    num_parcelas_fluxo = "0";
                    num_parcelas_intermediarias = "0";
                    vlr_parcela_fluxo = 0;
                    primeiro_vencimento = Convert.ToDateTime("01/01/1900");
                    ultimo_vencimento = Convert.ToDateTime("01/01/1900");
                    quitado = false;
                    indexador = "";
                    indexador_original = "";
                    periodicidade_correcao = "";
                    ultima_correcao = Convert.ToDateTime("01/01/1900");
                    sinal_parcelado = false;
                    corretor = "";
                    observacao = "";

                }
                //Fim Migração Arquivo Vendas
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Renegociaçoes OK \n\n";
            }
        }
    }


    private void CriarTabelaParcelas(string produto, string grupo)
    {
        //Criar Arquivo Parcelas 
        Boolean lOk = true;

        if (lOk)
        {
            //Cria nova tabela no SQL
            string nomearquivo = "parcelas_" + Srelib.QStr0(produto.Trim(), 5) + "_" + Srelib.QStr0(grupo.Trim(), 5);
            string script = "";
            string script1 = "";
            string script2 = "";
            string script3 = "";
            string scriptconta = "";

            script1 = "CREATE TABLE [dbo].[";
            script2 = "](" +
                      "[ID] [int] IDENTITY(1,1) NOT NULL , " +
                      "[produto] [int] NOT NULL , " +
                      "[grupo] [int] NOT NULL , " +
                      "[unidade] [int] NOT NULL , " +
                      "[parte] [int] NOT NULL , " +
                      "[parcela] [int] NOT NULL , " +
                      "[tipo] [varchar](5) NOT NULL , " +
                      "[data_vencimento] [datetime] NOT NULL , " +
                      "[vlr_parcela] [decimal](18, 2) NOT NULL , " +
                      "[data_pagamento] [datetime] NULL , " +
                      "[vlr_pagamento] [decimal](18, 2) NULL , " +
                      "[data_original] [datetime] NOT NULL , " +
                      "[vlr_original] [decimal](18, 2) NOT NULL , " +
                      "[data_base] [datetime] NOT NULL , " +
                      "[vlr_base] [decimal](18,  2) NOT NULL , " +
                      "[nossonumero] [varchar](30) NULL , " +
                      "[origem_pagamento] [varchar](30) NULL , " +
                      "[ativa] [bit] NULL , " +
                      "[percentual_correcao] [decimal](18, 8) NULL , " +
                      "[carteira] [bit] NULL , " +
                      "[protesto] [bit] NULL , " +
                      "[contabil] [bit] NULL , " +
                      "[tx_multa] [decimal](18,  2) NULL , " +
                      "[tx_comissao] [decimal](18, 2) NULL , " +
                      "[vlr_multa] [decimal](18, 2) NULL , " +
                      "[vlr_comissao] [decimal](18, 2) NULL , " +
                      "[vlr_desconto] [decimal](18, 2) NULL , " +
                      "[periodicidade_comissao] [varchar](10) NULL , " +
                      "[data_conta] [datetime] NULL , " +
                      "[conta] [varchar](10) NULL , " +
                      "[indexador] [varchar](20) NULL , " +
                      "[indexador_mes] [decimal](18,  8) NULL , " +
                      "[indexador_acumulado] [decimal](18, 8) NULL , " +
                      "[residuo_mes] [decimal](18,  8) NULL , " +
                      "[residuo_acumulado] [decimal](18,  8) NULL , " +
                      "[vlr_correcao] [decimal](18,  2) NULL , " +
                      "[observacao] [varchar](60) NULL , " +
                      "[juros_price] [decimal](18, 8) NULL, " +
                      "[vlr_parcelas_jurosprice] [decimal](18, 2) NULL, " +
                      "[amortizacao] [int] NULL, " +
                      "[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	 " +
                      "[taxa_anual_price] [decimal](18, 2) NULL " +
                      "CONSTRAINT [PK_";

            script3 = "] PRIMARY KEY NONCLUSTERED " +
                        "(" +
                        "	[ID] ASC" +
                        ")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]" +
                        ") ON [PRIMARY]"; // +
            //"GO";
            //
            scriptconta = scriptconta + nomearquivo;

            //Criação da Tabela
            script = script1 + scriptconta + script2 + scriptconta + script3;
            //drop
            try
            {
                SreDblib.ExecScript("drop table dbo." + nomearquivo);
            }
            catch (Exception)
            {
                //
            }
            //create
            try
            {
                SreDblib.ExecScript(script);
            }
            catch (Exception)
            {
                //
            }


        }
        //fim Cria nova tabela no SQL
    }


    private void MigrarParcelasGrupo1()
    {
        //Migração Arquivo Parcelas 
        //Quadras
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"cad_quad.dbf";
                var sql = "select * from " + fileName1 + " where cadastro = true order by num_loteam, num_quadra";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    //SreDblib.ExecScript("delete produto_grupo1");
                }
                catch (Exception)
                {
                    //MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Contas Correntes, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Parcelas Grupo Tipo 1 Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Parcelas Grupo Tipo 1!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Parcelas Grupo Tipo 1!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Parcelas Grupo Tipo 1 Não OK \n\n";
        }

        //Migração
        if (lOk)
        {
            string produto = "";
            string grupo = "";

            //
            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["num_loteam"].ToString() != String.Empty)
                {
                    // Produtos
                    produto = ds0.Tables[0].Rows[row]["num_loteam"].ToString().Trim();
                    grupo = ds0.Tables[0].Rows[row]["num_quadra"].ToString().Trim();


                    if (produto != String.Empty)
                    {

                        CriarTabelaParcelas(produto, grupo);

                        MigrarParcelasIndividual(produto, grupo);
                    }

                    produto = "";
                    grupo = "";

                }

                //Fim Migração Arquivo Parcelas Grupo Tipo 1
            }
            //
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Parcelas Grupo Tipo 1 OK \n\n";
            }
        }
    }

    private void MigrarParcelasGrupo2()
    {
        //Migração Arquivo Parcelas 
        //Quadras
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"cad_apar.dbf";
                var sql = "select * from " + fileName1 + " where cadastro = true order by num_loteam, num_bloco";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    //SreDblib.ExecScript("delete produto_grupo2");
                }
                catch (Exception)
                {
                    //MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Contas Correntes, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Parcelas Grupo Tipo 2 Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Parcelas Grupo Tipo 2!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Parcelas Grupo Tipo 2!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Parcelas Grupo Tipo 2 Não OK \n\n";
        }

        //Migração
        if (lOk)
        {
            string produto = "";
            string grupo = "";

            //
            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["num_loteam"].ToString() != String.Empty)
                {
                    // Produtos
                    produto = ds0.Tables[0].Rows[row]["num_loteam"].ToString().Trim();
                    grupo = ds0.Tables[0].Rows[row]["num_bloco"].ToString().Trim();


                    if (produto != String.Empty)
                    {

                        CriarTabelaParcelas(produto, grupo);

                        MigrarParcelasIndividual(produto, grupo);
                    }

                    produto = "";
                    grupo = "";

                }

                //Fim Migração Arquivo Parcelas Grupo Tipo 2
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Parcelas Grupo Tipo 1 OK \n\n";
            }
        }
    }

    private void MigrarParcelasEspeciais()
    {
        //Migração Arquivo Parcelas de Renegociações
        //Quadras
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"cad_quit.dbf";
                var sql = "select * from " + fileName1 + " order by classe, quadra, num_imovel ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete parcelas_renegociacao");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Parcelas Renegociações, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Parcelas Renegociações Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Parcelas Renegociações!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Parcelas Renegociações!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Parcelas Renegociações Não OK \n\n";
        }

        //Migração
        if (lOk)
        {

            //

            MigrarParcelasIndividual("99999", "99999");

            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Parcelas Renegociações OK \n\n";
            }
        }
    }


    private void MigrarParcelasIndividual(string yproduto, string ygrupo)
    {
        //Migração Arquivo Parcelas Individualmente
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds1.Clear();
                if ((yproduto == "99999") && (ygrupo == "99999"))
                {
                    //Parcelas de Renegociações
                    fileName1 = @"cad_quit" + ".dbf";
                }
                else
                {
                    //Parcelas de Financiamentos
                    fileName1 = @"cp" + Srelib.QStr0(yproduto.Trim(), 3) + Srelib.QStr0(ygrupo.Trim(), 3) + ".dbf";
                }
                var sql = "select * from " + fileName1 + "  ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds1);
                con.Close();
                //SQL
                try
                {
                    if ((yproduto == "99999") && (ygrupo == "99999"))
                    {
                        //Parcelas de Renegociações
                        SreDblib.ExecScript("delete " + "parcelas_renegociacao");
                    }
                    else
                    {
                        //Parcelas de Financiamentos
                        SreDblib.ExecScript("delete " + "parcelas_" + Srelib.QStr0(yproduto.Trim(), 5) + "_" + Srelib.QStr0(ygrupo.Trim(), 5));
                    }

                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Parcelas, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + fileName1 + " Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Parcelas!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Parcelas!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + fileName1 + " Não OK \n\n";
            lOk = false;
        }
        //Migração
        if (lOk)
        {

            string produto = "";
            string grupo = "";
            string unidade = "";
            string parte = "";
            string parcela = "";
            string tipo = "";
            DateTime data_vencimento = Convert.ToDateTime("01/01/1900");
            decimal vlr_parcela = 0;
            DateTime data_pagamento = Convert.ToDateTime("01/01/1900");
            decimal vlr_pagamento = 0;
            DateTime data_original = Convert.ToDateTime("01/01/1900");
            decimal vlr_original = 0;
            DateTime data_base = Convert.ToDateTime("01/01/1900");
            decimal vlr_base = 0;
            string nossonumero = "";
            string origem_pagamento = "";
            Boolean ativa = false;
            decimal percentual_correcao = 0;
            Boolean carteira = false;
            Boolean protesto = false;
            Boolean contabil = false;
            decimal tx_multa = 0;
            decimal tx_comissao = 0;
            decimal vlr_multa = 0;
            decimal vlr_comissao = 0;
            decimal vlr_desconto = 0;
            string periodicidade_comissao = "";
            DateTime data_conta = Convert.ToDateTime("01/01/1900");
            string conta = "";
            string indexador = "";
            decimal indexador_mes = 0;
            decimal indexador_acumulado = 0;
            decimal residuo_mes = 0;
            decimal residuo_acumulado = 0;
            decimal vlr_correcao = 0;
            string observacao = "";
            //
            decimal juros_price = 0;
            decimal vlr_parcelas_jurosprice = 0;
            Int16 amortizacao = 0;
            decimal vlr_parcelas_descapitalizada = 0;
            decimal taxa_anual_price = 0;
            //
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds1.Tables[0].Rows.Count.ToString() + "\n";
            }

            for (int row = 0; row < ds1.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds1.Tables[0].Rows[row]["classe"].ToString().Trim() != String.Empty)
                {
                    // 
                    produto = ds1.Tables[0].Rows[row]["classe"].ToString().Trim();
                    grupo = ds1.Tables[0].Rows[row]["quadra"].ToString().Trim();
                    unidade = ds1.Tables[0].Rows[row]["num_imovel"].ToString().Trim();
                    parte = ds1.Tables[0].Rows[row]["parte"].ToString().Trim();
                    parcela = ds1.Tables[0].Rows[row]["num_parc"].ToString().Trim();
                    tipo = ds1.Tables[0].Rows[row]["tipo_parc"].ToString().Trim();

                    if (ds1.Tables[0].Rows[row]["data_venc"].ToString() != "")
                    {
                        data_vencimento = Convert.ToDateTime(ds1.Tables[0].Rows[row]["data_venc"]);
                        if (data_vencimento < Convert.ToDateTime("01/01/1900"))
                            data_vencimento = Convert.ToDateTime("01/01/1900");
                    }
                    if (ds1.Tables[0].Rows[row]["vlr_parc"].ToString() != "")
                    {
                        vlr_parcela = Convert.ToDecimal(ds1.Tables[0].Rows[row]["vlr_parc"]);
                    }

                    if (ds1.Tables[0].Rows[row]["data_pgto"].ToString() != "")
                    {
                        data_pagamento = Convert.ToDateTime(ds1.Tables[0].Rows[row]["data_pgto"]);
                        if (data_pagamento < Convert.ToDateTime("01/01/1900"))
                            data_pagamento = Convert.ToDateTime("01/01/1900");
                    }

                    if (ds1.Tables[0].Rows[row]["vlr_pgto"].ToString() != "")
                    {
                        vlr_pagamento = Convert.ToDecimal(ds1.Tables[0].Rows[row]["vlr_pgto"]);
                    }

                    if (ds1.Tables[0].Rows[row]["vlr_origin"].ToString() != "")
                    {
                        vlr_original = Convert.ToDecimal(ds1.Tables[0].Rows[row]["vlr_origin"]);
                    }

                    if (ds1.Tables[0].Rows[row]["vlr_base"].ToString() != "")
                    {
                        vlr_base = Convert.ToDecimal(ds1.Tables[0].Rows[row]["vlr_base"]);
                    }

                    nossonumero = ds1.Tables[0].Rows[row]["cod_banco"].ToString().Trim();
                    origem_pagamento = ds1.Tables[0].Rows[row]["origem"].ToString().Trim();
                    ativa = Convert.ToBoolean(ds1.Tables[0].Rows[row]["ativa"]);

                    if (ds1.Tables[0].Rows[row]["percentual"].ToString() != "")
                    {
                        percentual_correcao = Convert.ToDecimal(ds1.Tables[0].Rows[row]["percentual"]);
                    }

                    carteira = Convert.ToBoolean(ds1.Tables[0].Rows[row]["carteira"]);
                    protesto = Convert.ToBoolean(ds1.Tables[0].Rows[row]["protesto"]);
                    contabil = Convert.ToBoolean(ds1.Tables[0].Rows[row]["contabil"]);
                    //
                    if (ds1.Tables[0].Rows[row]["multa"].ToString() != "")
                    {
                        tx_multa = Convert.ToDecimal(ds1.Tables[0].Rows[row]["multa"]);
                    }
                    //
                    if (ds1.Tables[0].Rows[row]["comissao"].ToString() != "")
                    {
                        tx_comissao = Convert.ToDecimal(ds1.Tables[0].Rows[row]["comissao"]);
                    }
                    //
                    if (ds1.Tables[0].Rows[row]["vlr_correc"].ToString() != "")
                    {
                        vlr_comissao = Convert.ToDecimal(ds1.Tables[0].Rows[row]["vlr_correc"]);
                    }
                    ////
                    //if (ds1.Tables[0].Rows[row]["vlr_multa"].ToString() != "")
                    //{
                    //    vlr_multa = Convert.ToDecimal(ds1.Tables[0].Rows[row]["vlr_multa"]);
                    //}
                    ////
                    //if (ds1.Tables[0].Rows[row]["vlr_descon"].ToString() != "")
                    //{
                    //    vlr_desconto = Convert.ToDecimal(ds1.Tables[0].Rows[row]["vlr_descon"]);
                    //}
                    //
                    if (Convert.ToDouble(vlr_pagamento) != Convert.ToDouble(vlr_parcela))
                    {
                        if (Convert.ToDouble(vlr_pagamento) != 0.00)
                        {
                            if ((Convert.ToDouble(vlr_pagamento) > 0.00) &&
                            (Convert.ToDouble(vlr_pagamento) > Convert.ToDouble(vlr_parcela)))
                            {
                                if (data_pagamento > data_vencimento)
                                {
                                    vlr_multa = Convert.ToDecimal((Convert.ToDouble(vlr_pagamento) - Convert.ToDouble(vlr_parcela)));
                                }
                                else
                                {
                                    vlr_multa = 0;
                                }
                            }
                            else
                            {
                                if (data_pagamento <= data_vencimento)
                                {
                                    vlr_desconto = Convert.ToDecimal((Convert.ToDouble(vlr_parcela) - Convert.ToDouble(vlr_pagamento)));
                                }
                                else
                                {
                                    vlr_desconto = 0;
                                }

                            }
                        }
                    }
                    //
                    periodicidade_comissao = ds1.Tables[0].Rows[row]["perid_comi"].ToString().Trim();
                    data_conta = Convert.ToDateTime("01/01/1900");
                    conta = ds1.Tables[0].Rows[row]["conta"].ToString().Trim();
                    indexador = ds1.Tables[0].Rows[row]["indice"].ToString().Trim().ToUpper();
                    if (ds1.Tables[0].Rows[row]["taxa_mes"].ToString() != "")
                    {
                        indexador_mes = Convert.ToDecimal(ds1.Tables[0].Rows[row]["taxa_mes"]);
                    }
                    if (ds1.Tables[0].Rows[row]["taxa_acum"].ToString() != "")
                    {
                        indexador_acumulado = Convert.ToDecimal(ds1.Tables[0].Rows[row]["taxa_acum"]);
                    }
                    if (ds1.Tables[0].Rows[row]["resi_mes"].ToString() != "")
                    {
                        residuo_mes = Convert.ToDecimal(ds1.Tables[0].Rows[row]["resi_mes"]);
                    }
                    if (ds1.Tables[0].Rows[row]["resi_acum"].ToString() != "")
                    {
                        residuo_acumulado = Convert.ToDecimal(ds1.Tables[0].Rows[row]["resi_acum"]);
                    }
                    observacao = ds1.Tables[0].Rows[row]["obs"].ToString().Trim();
                    //
                    try
                    {
                        if (ds1.Tables[0].Rows[0]["juros_price"].ToString() != "")
                        {
                            juros_price = Convert.ToDecimal(ds1.Tables[0].Rows[0]["juros_price"]);
                        }
                    }
                    catch (Exception)
                    {
                        juros_price = 0;
                    }
                    //
                    try
                    {
                        if (ds1.Tables[0].Rows[0]["vlr_parcelas_jurosprice"].ToString() != "")
                        {
                            vlr_parcelas_jurosprice = Convert.ToDecimal(ds1.Tables[0].Rows[0]["vlr_parcelas_jurosprice"]);
                        }
                    }
                    catch (Exception)
                    {
                        vlr_parcelas_jurosprice = 0;
                    }
                    try
                    {
                        if (ds1.Tables[0].Rows[0]["amortizacao"].ToString() != "")
                        {
                            amortizacao = Convert.ToInt16(ds1.Tables[0].Rows[0]["amortizacao"]);
                        }
                    }
                    catch (Exception)
                    {
                        amortizacao = 0;
                    }
                    try
                    {
                        if (ds1.Tables[0].Rows[0]["vlr_parcelas_descapitalizada"].ToString() != "")
                        {
                            vlr_parcelas_descapitalizada = Convert.ToDecimal(ds1.Tables[0].Rows[0]["vlr_parcelas_descapitalizada"]);
                        }
                    }
                    catch (Exception)
                    {
                        vlr_parcelas_descapitalizada = 0;
                    }
                    try
                    {
                        if (ds1.Tables[0].Rows[0]["taxa_anual_price"].ToString() != "")
                        {
                            taxa_anual_price = Convert.ToDecimal(ds1.Tables[0].Rows[0]["taxa_anual_price"]);
                        }
                    }
                    catch (Exception)
                    {
                        taxa_anual_price = 0;
                    }

                    //

                    if (produto != String.Empty)
                    {
                        if ((yproduto == "99999") && (ygrupo == "99999"))
                        {
                            //Parcelas de Renegociações
                            uParcelas.GravaRenegociacao(produto,
                                                        grupo,
                                                        unidade,
                                                        parte,
                                                        parcela,
                                                        tipo,
                                                        Convert.ToString(data_vencimento).Substring(0, 10),
                                                        vlr_parcela,
                                                        Convert.ToString(data_pagamento).Substring(0, 10),
                                                        vlr_pagamento,
                                                        Convert.ToString(data_original).Substring(0, 10),
                                                        vlr_original,
                                                        Convert.ToString(data_base).Substring(0, 10),
                                                        vlr_base,
                                                        nossonumero,
                                                        origem_pagamento,
                                                        Convert.ToInt16(ativa),
                                                        percentual_correcao,
                                                        Convert.ToInt16(carteira),
                                                        Convert.ToInt16(protesto),
                                                        Convert.ToInt16(contabil),
                                                        tx_multa,
                                                        tx_comissao,
                                                        vlr_multa,
                                                        vlr_comissao,
                                                        vlr_desconto,
                                                        periodicidade_comissao,
                                                        Convert.ToString(data_conta).Substring(0, 10),
                                                        conta,
                                                        indexador,
                                                        indexador_mes,
                                                        indexador_acumulado,
                                                        residuo_mes,
                                                        residuo_acumulado,
                                                        vlr_correcao,
                                                        observacao,
                                                        juros_price,
                                                        vlr_parcelas_jurosprice,
                                                        amortizacao,
                                                        vlr_parcelas_descapitalizada,
                                                        taxa_anual_price
                                                      );

                        }
                        else
                        {
                            //Parcelas de Financiamentos
                            uParcelas.Grava(produto,
                                            grupo,
                                            unidade,
                                            parte,
                                            parcela,
                                            tipo,
                                            Convert.ToString(data_vencimento).Substring(0, 10),
                                            vlr_parcela,
                                            Convert.ToString(data_pagamento).Substring(0, 10),
                                            vlr_pagamento,
                                            Convert.ToString(data_original).Substring(0, 10),
                                            vlr_original,
                                            Convert.ToString(data_base).Substring(0, 10),
                                            vlr_base,
                                            nossonumero,
                                            origem_pagamento,
                                            Convert.ToInt16(ativa),
                                            percentual_correcao,
                                            Convert.ToInt16(carteira),
                                            Convert.ToInt16(protesto),
                                            Convert.ToInt16(contabil),
                                            tx_multa,
                                            tx_comissao,
                                            vlr_multa,
                                            vlr_comissao,
                                            vlr_desconto,
                                            periodicidade_comissao,
                                            Convert.ToString(data_conta).Substring(0, 10),
                                            conta,
                                            indexador,
                                            indexador_mes,
                                            indexador_acumulado,
                                            residuo_mes,
                                            residuo_acumulado,
                                            vlr_correcao,
                                            observacao
                                          );

                        }

                    }

                    produto = "";
                    grupo = "";
                    unidade = "";
                    parte = "";
                    parcela = "";
                    tipo = "";
                    data_vencimento = Convert.ToDateTime("01/01/1900");
                    vlr_parcela = 0;
                    data_pagamento = Convert.ToDateTime("01/01/1900");
                    vlr_pagamento = 0;
                    data_original = Convert.ToDateTime("01/01/1900");
                    vlr_original = 0;
                    data_base = Convert.ToDateTime("01/01/1900");
                    vlr_base = 0;
                    nossonumero = "";
                    origem_pagamento = "";
                    ativa = false;
                    percentual_correcao = 0;
                    carteira = false;
                    protesto = false;
                    contabil = false;
                    tx_multa = 0;
                    tx_comissao = 0;
                    vlr_multa = 0;
                    vlr_comissao = 0;
                    vlr_desconto = 0;
                    periodicidade_comissao = "";
                    data_conta = Convert.ToDateTime("01/01/1900");
                    conta = "";
                    indexador = "";
                    indexador_mes = 0;
                    indexador_acumulado = 0;
                    residuo_mes = 0;
                    residuo_acumulado = 0;
                    vlr_correcao = 0;
                    observacao = "";


                }
                //Fim Migração Arquivo Parcelas 
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + fileName1 + " OK \n\n";
            }
        }
    }

    private void Migrarlog()
    {
        //Migração Arquivo Log de Segurança
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"log_usu.dbf";
                var sql = "select * from " + fileName1 + "  ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete log");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Log de Segurança, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Log de Segurança Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Log de Segurança!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Log de Segurança!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Log de Segurança Não OK \n\n";
        }

        //Migração
        if (lOk)
        {

            string login = "";
            string data = "01/01/1900";
            string hora = "01/01/1900 00:00:00";
            string tabela = "";
            string operacao = "";
            string obs = "";
            string acao = "";
            //
            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["usuario"].ToString() != String.Empty)
                {
                    // Produtos
                    login = ds0.Tables[0].Rows[row]["usuario"].ToString().Trim();
                    data = ds0.Tables[0].Rows[row]["data"].ToString().Substring(0, 10);
                    hora = ds0.Tables[0].Rows[row]["hora"].ToString();
                    operacao = ds0.Tables[0].Rows[row]["modulo"].ToString().Trim();
                    acao = ds0.Tables[0].Rows[row]["acao"].ToString().Trim();

                    if (login != String.Empty)
                    {

                        uLog.Grava(login,
                                   data,
                                   hora,
                                   tabela,
                                   operacao,
                                   obs,
                                   acao
                                   );

                    }

                    login = "";
                    data = "01/01/1900";
                    hora = "01/01/1900 00:00:00";
                    tabela = "";
                    operacao = "";
                    obs = "";
                    acao = "";

                }
                //Fim Migração Arquivo Log de Segurança
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Log de Segurança OK \n\n";
            }
        }
    }

    private void MigrarCartas()
    {
        //Migração Arquivo Cartas Modelo
        Boolean lOk = true;
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=dBASE IV;User ID=Admin;Password=;";
        try
        {
            using (OleDbConnection con = new OleDbConnection(constr))
            {
                //DBF
                ds0.Clear();
                fileName1 = @"car_padr.dbf";
                var sql = "select * from " + fileName1 + "  ";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                //DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds0);
                con.Close();
                //SQL
                try
                {
                    SreDblib.ExecScript("delete modelo_cartas");
                }
                catch (Exception)
                {
                    MemoAtividades.Text = MemoAtividades.Text + "Erro ao apagar registros anteriores da Tabela Cartas Padrão, possivel registros filhos relacionados. \n";
                    MemoAtividades.Text = MemoAtividades.Text + "Cartas Padrão Não OK \n\n";
                    lOk = false;
                }
                //
            }
        }
        catch (Exception)
        {
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não foi possivel migrar Cartas Padrão!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Não foi possivel migrar Cartas Padrão!', 'Atenção!')", true);
            MemoAtividades.Text = MemoAtividades.Text + "Cartas Padrão Não OK \n\n";
        }

        //Migração
        if (lOk)
        {

            string nome = "";
            string selecao = "";
            string linha1 = "";
            string linha2 = "";
            string linha3 = "";
            string linha4 = "";
            string linha5 = "";
            string linha6 = "";
            string linha7 = "";
            string linha8 = "";
            string linha9 = "";
            string linha10 = "";
            string linha11 = "";
            string linha12 = "";
            string linha13 = "";
            string linha14 = "";
            string linha15 = "";
            string linha16 = "";
            string linha17 = "";
            string linha18 = "";
            string linha19 = "";

            //
            for (int row = 0; row < ds0.Tables[0].Rows.Count; row++)
            //int row = 0;
            {
                if (ds0.Tables[0].Rows[row]["nome"].ToString() != String.Empty)
                {
                    // Produtos
                    nome = ds0.Tables[0].Rows[row]["nome"].ToString().Trim();
                    nome = Srelib.tiraacento(nome);
                    selecao = "0";
                    linha1 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["linha_1"].ToString().Trim());
                    linha2 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["linha_2"].ToString().Trim());
                    linha3 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["linha_3"].ToString().Trim());
                    linha4 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["linha_4"].ToString().Trim());
                    linha5 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["linha_5"].ToString().Trim());
                    linha6 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["linha_6"].ToString().Trim());
                    linha7 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["linha_7"].ToString().Trim());
                    linha8 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["linha_8"].ToString().Trim());
                    linha9 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["linha_9"].ToString().Trim());
                    linha10 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["linha_10"].ToString().Trim());
                    linha11 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["linha_11"].ToString().Trim());
                    linha12 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["linha_12"].ToString().Trim());
                    linha13 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["linha_13"].ToString().Trim());
                    linha14 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["linha_14"].ToString().Trim());
                    linha15 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["linha_15"].ToString().Trim());
                    linha16 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["linha_16"].ToString().Trim());
                    linha17 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["linha_17"].ToString().Trim());
                    linha18 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["linha_18"].ToString().Trim());
                    linha19 = Srelib.tiraacento(ds0.Tables[0].Rows[row]["linha_19"].ToString().Trim());
                    //
                    if (nome != String.Empty)
                    {

                        uMalaDireta.Grava(nome,
                                          selecao,
                                          linha1,
                                          linha2,
                                          linha3,
                                          linha4,
                                          linha5,
                                          linha6,
                                          linha7,
                                          linha8,
                                          linha9,
                                          linha10,
                                          linha11,
                                          linha12,
                                          linha13,
                                          linha14,
                                          linha15,
                                          linha16,
                                          linha17,
                                          linha18,
                                          linha19
                                          );

                    }

                    nome = "";
                    selecao = "";
                    linha1 = "";
                    linha2 = "";
                    linha3 = "";
                    linha4 = "";
                    linha5 = "";
                    linha6 = "";
                    linha7 = "";
                    linha8 = "";
                    linha9 = "";
                    linha10 = "";
                    linha11 = "";
                    linha12 = "";
                    linha13 = "";
                    linha14 = "";
                    linha15 = "";
                    linha16 = "";
                    linha17 = "";
                    linha18 = "";
                    linha19 = "";

                }
                //Fim Migração Arquivo Cartas Modelo
            }
            if (lOk)
            {
                //feedback
                MemoAtividades.Text = MemoAtividades.Text + "Arquivo: " + fileName1 + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Registros: " + ds0.Tables[0].Rows.Count.ToString() + "\n";
                MemoAtividades.Text = MemoAtividades.Text + "Cartas Modelo OK \n\n";
            }
        }
    }


}

using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FCobrancaRemessa : System.Web.UI.Page
{
    DataSet dsparcelas;
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
        if (!lAltera)
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
            //Combo Empresas
            cbproduto.Items.Clear();
            uProduto.MontaComboProduto(cbproduto, true);
            //
            Label2.Visible = true;
            cbgrupo.Visible = true;
            //
            Label7.Visible = true;
            cbgrupounidades.Visible = true;
            //
            Label8.Visible = true;
            edbanco.Visible = true;
            //
            Label4.Visible = true;
            edcaminho.Visible = true;
            edextensao.Visible = true;
            //
            Label13.Visible = true;
            ednomearquivo.Visible = true;
            //
            //Carregar Dados
            dtprevisao1.Date = DateTime.Now;
            dtprevisao2.Date = DateTime.Now;
            //
            dtprevisao1.Enabled = true;
            dtprevisao2.Enabled = true;
            //
            Label5.Visible = true;
            dtprevisao1.Visible = true;
            Label6.Visible = true;
            dtprevisao2.Visible = true;
            //
            Label9.Visible = true;
            rbmensagemauto.Visible = true;
            //
            btprocessa.Enabled = true;
            //
        }

    }

    protected void cbproduto_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        if (cbproduto.Text != string.Empty)
        {
            //Combo Grupo
            cbgrupo.Items.Clear();
            uProduto.MontaComboGrupo(cbgrupo, Convert.ToString(cbproduto.Value).Trim(), true);
            //
            //Conta
            string IDConta = uProduto.PegaProdutoConta(Convert.ToInt16(cbproduto.Value));
            string IDBanco = "";
            if (IDConta != "0")
            {
                IDBanco = uContas.PegaContaCodigoBanco(IDConta);
                //
                edbanco.Text = uContas.PegaContaDescricao(IDConta);
                edcaminho.Text = uBanco.PegaCaminhoRemessa(IDBanco);
                edextensao.Text = uBanco.PegaExtensaoRemessa(IDBanco);
                ednomearquivo.Text = "RE";
                edbanco.Text = edbanco.Text.ToUpper();
                edcaminho.Text = edcaminho.Text.ToUpper();
                edextensao.Text = edextensao.Text.ToUpper();
                ednomearquivo.Text = ednomearquivo.Text.ToUpper();
                //
                btprocessa.Enabled = true;
            }
            else
            {
                edbanco.Text = "Produto com Conta Corrente Não Associada, Zerada.";
                btprocessa.Enabled = false;
            }

            Label8.Visible = true;
            edbanco.Visible = true;
            //
            Label4.Visible = true;
            edcaminho.Visible = true;
            edextensao.Visible = true;
            //
            Label13.Visible = true;
            ednomearquivo.Visible = true;
        }

    }

    protected void cbgrupo_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        if (cbproduto.Text != string.Empty)
        {
            if (cbgrupo.Text != string.Empty)
            {
                //Combo Unidades
                cbgrupounidades.Items.Clear();
                uProduto.MontaComboUnidades(cbgrupounidades, Convert.ToString(cbproduto.Value).Trim(), Convert.ToString(cbgrupo.Value).Trim(), true);
                if (cbgrupounidades.Items.Count == 0)
                {
                    btprocessa.Enabled = false;
                    //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não Há Unidades Disponíveis!');", true);
                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                    "toastr.info('Não Há Unidades Disponíveis!', 'Atenção!')", true);

                }
                //
            }
        }

    }

    protected void cbgrupounidades_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
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
        string tst = "";
        string IDConta = "";
        string IDBanco = "";
        string headerarquivo = Srelib.replicate(" ", 420);
        string headerarquivo2 = Srelib.replicate(" ", 420);
        string footerarquivo = Srelib.replicate(" ", 420);
        string footerarquivo2 = Srelib.replicate(" ", 420);
        string[] linharegistro1 = new string[1000];
        string[] linharegistro2 = new string[1000];
        for (int i = 0; i < 1000; i++)
        {
            linharegistro1[i] = Srelib.replicate(" ", 420);
            linharegistro2[i] = Srelib.replicate(" ", 420);
        }
        string numeroregistro = "1";
        string titulos = "000000";
        string vlrtitulos = "000000";
        string numeroarquivo = "";
        //
        //CRITICAS

        if (lOk)
        {
            //CRIAÇÃO DA VARIÁVEL DE SESSÃO COM OS ELEMENTOS SELECIONADOS NO LOOKUP  ===============================================================================================================================================
            //Produto
            Session.Remove("cbproduto");
            if (cbproduto.Text != string.Empty)
            {
                Session.Add("cbproduto", cbproduto.Value.ToString().Trim());
                tst = cbproduto.Value.ToString().Trim();
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Nenhum Produto Selecionado!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Nenhum Produto Selecionado!', 'Atenção!')", true);
            }
        }
        if (lOk)
        {
            //Grupo
            Session.Remove("cbgrupo");
            if (cbgrupo.Text != string.Empty)
            {
                Session.Add("cbgrupo", cbgrupo.Value.ToString().Trim());
            }
            else
            {
                Session.Add("cbgrupo", "");
            }
        }
        if (lOk)
        {

            //Unidades
            Session.Remove("cbgrupounidades");
            if (cbgrupounidades.Text != string.Empty)
            {
                Session.Add("cbgrupounidades", cbgrupounidades.Value.ToString().Trim());
            }
            else
            {
                Session.Add("cbgrupounidades", "");
            }
        }
        if (lOk)
        {
            //Parte
            Session.Remove("cbparte");
            Session.Add("cbparte", "0");
        }
        if (lOk)
        {
            //Previsão
            Session.Remove("dtprevisao1");
            Session.Remove("dtprevisao2");
            if (dtprevisao1.Text != string.Empty)
            {
                Session.Add("dtprevisao1", dtprevisao1.Value.ToString().Trim());
            }
            else
            {
                Session.Add("dtprevisao1", "01/01/1900");
            }
            //
            if (dtprevisao2.Text != string.Empty)
            {
                Session.Add("dtprevisao2", dtprevisao2.Value.ToString().Trim());
            }
            else
            {
                Session.Add("dtprevisao2", "31/12/2999");
            }
            //
        }
        //
        if (lOk)
        {
            //Conta e Banco do Empreendimento
            IDConta = uProduto.PegaProdutoConta(Convert.ToInt16(cbproduto.Value));
            IDBanco = "";
            if (IDConta != "0")
            {
                IDBanco = uContas.PegaContaCodigoBanco(IDConta);
                //
                //edbanco.Text = uContas.PegaContaDescricao(IDConta);
                //edcaminho.Text = uBanco.PegaCaminhoRemessa(IDBanco);
                //edextensao.Text = uBanco.PegaExtensaoRemessa(IDBanco);
                //ednomearquivo.Text = "RE";

            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Produto com Conta Corrente Não Associada, Zerada!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Produto com Conta Corrente Não Associada, Zerada!', 'Atenção!')", true);
            }
        }

        if (lOk)
        {
            //Numero Corrente do Arquivo
            numeroarquivo = uBanco.PegaArquivoNumero(IDBanco);
            numeroregistro = "1";
            //Gerar Linhas
            GeraHeader(IDBanco,
                       IDConta,
                       numeroarquivo,
                       ref numeroregistro,
                       ref headerarquivo,
                       ref headerarquivo2);
            //Fim Gerar Header
            //
            //Geração de Registros
            //
            GeraRegistro400((String)Session["cbproduto"],
                            (String)Session["cbgrupo"],
                            (String)Session["cbgrupounidades"],
                            "0",
                            dtprevisao1.Value.ToString().Substring(0, 10),
                            dtprevisao2.Value.ToString().Substring(0, 10),
                            IDBanco,
                            IDConta,
                            ref titulos,
                            ref vlrtitulos, //string com 13 posicoes sem ponto
                            numeroarquivo,
                            ref numeroregistro,
                            Convert.ToBoolean(rbmensagemauto.SelectedIndex == 0),
                            ref linharegistro1,
                            ref linharegistro2);
            //Fim Geração de Registros
            //
            //Geração Footer
            GeraFooter(IDBanco,
                       IDConta,
                       titulos,
                       vlrtitulos, //string com 13 posicoes sem ponto
                       numeroarquivo,
                       numeroregistro.ToString(),
                       ref footerarquivo,
                       ref footerarquivo2);
            //Fim Geração Footer
            //
            //Geração do Arquivo 
            //Gerar arquivo
            string pulalinha = Environment.NewLine;
            string strPathFile = @edcaminho.Text.Trim() + ednomearquivo.Text.Trim() + "." + edextensao.Text.Trim();
            try
            {
                //Usarei a cláusula using como boas práticas de programação em todos os métodos
                //Instancio a classe FileStream, uso a classe File e o método Create para criar o
                //arquivo passando como parâmetro a variável strPathFile, que contém o arquivo
                using (FileStream fs = File.Create(strPathFile))
                {
                    //Crio outro using, dentro dele instancio o StreamWriter (classe para gravar os dados)
                    //que recebe como parâmetro a variável fs, referente ao FileStream criado anteriormente
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        //Uso o método Write para escrever algo em nosso arquivo texto
                        //Header
                        sw.Write(headerarquivo + pulalinha);
                        if (headerarquivo2.Trim() != String.Empty)
                        {
                            sw.Write(headerarquivo2 + pulalinha);
                        }
                        //Fim Header
                        //
                        //Registros
                        //
                        for (int i = 0; i < 1000; i++)
                        {
                            //1a. Linha
                            if (linharegistro1[i].Trim() != String.Empty)
                            {
                                sw.Write(linharegistro1[i] + pulalinha);
                            }
                            //2a. Linha
                            if (linharegistro2[i].Trim() != String.Empty)
                            {
                                sw.Write(linharegistro2[i] + pulalinha);
                            }
                        }
                        //Fim Registros
                        //
                        //Footer
                        sw.Write(footerarquivo + pulalinha);
                        if (footerarquivo2.Trim() != String.Empty)
                        {
                            sw.Write(headerarquivo2 + pulalinha);
                        }
                        //Fim Footer
                    }
                }
            }
            catch (Exception ex)
            {
                btprocessa.Enabled = false;
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Erro ao gravar o Arquivo! Gravação Abortada! Verificar Pasta, Nome e Extensão.');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.error('Erro ao gravar o Arquivo! Gravação Abortada! Verificar Pasta, Nome e Extensão!', 'Atenção!')", true);
            }
            //Fim Gerar arquivo
        }
        //
        if (lOk)
        {
            // CRIA LOG ===============================================================================================================================================
            fwObs_Log = "COBRANÇA REMESSA: " + cbproduto.Value.ToString();
            if (cbgrupo.Value != null)
            {
                fwObs_Log = fwObs_Log + "/" + cbgrupo.Value.ToString();
            }
            if (cbgrupounidades.Value != null)
            {
                fwObs_Log = fwObs_Log + "/" + cbgrupounidades.Value.ToString() + "/" + "0";
            }
            fwObs_Log = fwObs_Log + " de " + Convert.ToString(dtprevisao1.Value).Substring(0, 10) + " até " + Convert.ToString(dtprevisao2.Value).Substring(0, 10);
            //
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ), 
                                         new SqlParameter("@tabela"   , fWtabela                              ),
                                         new SqlParameter("@operacao" , "PARCELAS"                            ),
                                         new SqlParameter("@obs"      , "COBRANÇA REMESSA"                    ),
                                         new SqlParameter("@acao"     , fwObs_Log                             ) };
            uLog.MakeLog(param_log);
            // FIM CRIA LOG ===============================================================================================================================================
            //
            btprocessa.Enabled = false;
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Geração de Arquivo Concluída!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.success('Geração de Arquivo Concluída!', 'Atenção!')", true);

            //
        }

    }

    private void GeraHeader(string xBanco,
                            string xconta,
                            string numeroarquivo,
                            ref string numeroregistro,
                            ref string headerarquivo,
                            ref string headerarquivo2)
    {
        string nomebanco = uBanco.PegaNomeCodigo(xBanco);
        string dataatual = DateTime.Now.ToString().Substring(0, 10);
        string nomeempresa = uEmpresa.PegaNome(uEmpresa.PegaMatriz());
        string cnpjempresa = uEmpresa.PegaCnpj(uEmpresa.PegaMatriz());
        cnpjempresa = Srelib.replicate("0", cnpjempresa.Length - 14) + cnpjempresa;
        string agencia = Srelib.QStr0(uContas.PegaAgencia(xconta), 5);
        string contacorrente = Srelib.QStr0(uContas.PegaConta(xconta), 12);
        string complemento = Srelib.QStr0(uContas.PegaComplemento(xconta), 20);
        if (numeroarquivo.Length != 5)
        {
            numeroarquivo = Srelib.QStr0(numeroarquivo.Trim(), 5);
        }
        string caixapostal = uBanco.PegaCaixaPostal(xBanco);
        string assunto = uBanco.PegaAssunto(xBanco);
        //
        //Agencia e Conta
        switch (xBanco)
        {
            case "341":
                agencia = Srelib.QStr0(uContas.PegaAgencia(xconta), 4);
                contacorrente = Srelib.QStr0(uContas.PegaConta(xconta), 9);
                break;
            case "422":
                agencia = Srelib.QStr0(uContas.PegaAgencia(xconta), 5);
                contacorrente = Srelib.QStr0(uContas.PegaConta(xconta), 9);
                break;
            case "424":
                agencia = Srelib.QStr0(uContas.PegaAgencia(xconta), 3);
                contacorrente = Srelib.QStr0(uContas.PegaConta(xconta), 8);
                break;
            case "641":
                agencia = Srelib.QStr0(uContas.PegaAgencia(xconta), 4);
                contacorrente = Srelib.QStr0(uContas.PegaConta(xconta), 10);
                break;
            default:
                agencia = Srelib.QStr0(uContas.PegaAgencia(xconta), 4);
                contacorrente = Srelib.QStr0(uContas.PegaConta(xconta), 12);
                break;
        }

        //
        //Razão Social da Empresa
        if (nomeempresa.Length < 30)
        {
            nomeempresa = nomeempresa + Srelib.replicate(" ", nomeempresa.Length - 30);
        }
        else
        {
            nomeempresa = nomeempresa.Substring(0, 29);
        }
        //
        //
        if (xBanco != String.Empty)
        {
            switch (xBanco)
            {
                case "001":
                    headerarquivo = "01REMESSA01COBRANCA       " + agencia.Trim() + contacorrente.Substring(0, 9) + "000000" + nomeempresa +
                                    xBanco + nomebanco.Substring(0, 15) + dataatual.Substring(0, 2) + dataatual.Substring(3, 2) + dataatual.Substring(8, 2) +
                                    "00" + numeroarquivo + Srelib.replicate(" ", 22) + caixapostal + Srelib.replicate(" ", 258) + "000001";
                    numeroregistro = Convert.ToString(Convert.ToInt64(numeroregistro) + 1).Trim();

                    break;
                case "008":
                    headerarquivo = "01REMESSA01COBRANCA       " + agencia.Trim() + "000000" + contacorrente.Substring(0, 9) + "  " + nomeempresa +
                                    xBanco + nomebanco.Substring(0, 15) + dataatual.Substring(0, 2) + dataatual.Substring(3, 2) + dataatual.Substring(8, 2) +
                                    "01600BPI" + "0" + numeroarquivo + Srelib.replicate(" ", 280) + "000001";
                    numeroregistro = Convert.ToString(Convert.ToInt64(numeroregistro) + 1).Trim();
                    break;
                case "033":
                    headerarquivo = "01REMESSA01COBRANCA       " + agencia.Substring(2, 3) + contacorrente.Substring(0, 8) + Srelib.replicate(" ", 9) + nomeempresa +
                                    xBanco + nomebanco.Substring(0, 7) + Srelib.replicate(" ", 8) + dataatual.Substring(0, 2) + dataatual.Substring(3, 2) + dataatual.Substring(8, 2) +
                                    "01600BPI" + Srelib.replicate(" ", 286) + "000001";
                    numeroregistro = Convert.ToString(Convert.ToInt64(numeroregistro) + 1).Trim();
                    break;
                case "104":
                    headerarquivo = "01REMESSA01COBRANCA       " + agencia.Trim() + contacorrente.Trim() + Srelib.replicate(" ", 4) + nomeempresa +
                                    xBanco + nomebanco + dataatual.Substring(0, 2) + dataatual.Substring(3, 2) + dataatual.Substring(8, 2) + Srelib.replicate(" ", 289) +
                                    numeroarquivo + "000001";
                    numeroregistro = Convert.ToString(Convert.ToInt64(numeroregistro) + 1).Trim();
                    break;
                case "151":
                    headerarquivo = "15100000         2" + cnpjempresa + Srelib.replicate(" ", 20) + "00" + agencia.Trim() + "0000" + contacorrente.Trim() + Srelib.replicate(" ", 1) + nomeempresa +
                                    "NOSSA CAIXA-NOSSO BANCO       " + Srelib.replicate(" ", 10) + "1" + dataatual.Substring(0, 2) + dataatual.Substring(3, 2) + dataatual.Substring(8, 2) +
                                    "1200000" + numeroarquivo + "020" + "00000" + Srelib.replicate(" ", 69);
                    numeroregistro = Convert.ToString(Convert.ToInt64(numeroregistro) + 1).Trim();
                    //
                    //2a. linha de Header
                    headerarquivo2 = "15100011R0100020 20" + cnpjempresa + Srelib.replicate(" ", 20) + "00" + agencia.Trim() + "0000" + contacorrente.Trim() + Srelib.replicate(" ", 1) + nomeempresa +
                                     "000000" + Srelib.replicate(" ", 40) + Srelib.replicate(" ", 34) + "000" + numeroarquivo + dataatual.Substring(0, 2) + dataatual.Substring(3, 2) + dataatual.Substring(5, 4) +
                                     "00000000" + Srelib.replicate(" ", 33);
                    numeroregistro = Convert.ToString(Convert.ToInt64(numeroregistro) + 1).Trim();
                    break;
                case "215":
                    headerarquivo = "01REMESSA01COBRANCA" + Srelib.replicate(" ", 7) + agencia.Trim() + "02" + contacorrente.Substring(0, 8) + Srelib.replicate(" ", 6) + nomeempresa +
                                    xBanco + nomebanco + dataatual.Substring(0, 2) + dataatual.Substring(3, 2) + dataatual.Substring(5, 4) +
                                    "00000BPI" + "00100" + Srelib.replicate(" ", 281) + "000001";
                    numeroregistro = Convert.ToString(Convert.ToInt64(numeroregistro) + 1).Trim();
                    break;
                case "230":
                    headerarquivo = "01REMESSA01COBRANCA" + Srelib.replicate(" ", 7) + agencia.Substring(2, 3) + contacorrente.Substring(0, 10) + Srelib.replicate(" ", 7) + nomeempresa +
                                    xBanco + nomebanco + dataatual.Substring(0, 2) + dataatual.Substring(3, 2) + dataatual.Substring(8, 2) +
                                    "01600BPI" + Srelib.replicate(" ", 286) + "000001";
                    numeroregistro = Convert.ToString(Convert.ToInt64(numeroregistro) + 1).Trim();
                    break;
                case "237":
                    headerarquivo = "01REMESSA01COBRANCA" + Srelib.replicate(" ", 7) + Srelib.replicate("0", 13) + complemento + nomeempresa +
                                    xBanco + nomebanco + dataatual.Substring(0, 2) + dataatual.Substring(3, 2) + dataatual.Substring(8, 2) +
                                    Srelib.replicate(" ", 8) + "MX00" + numeroarquivo + Srelib.replicate(" ", 11) + "232A" + Srelib.replicate(" ", 262) + "000001";
                    numeroregistro = Convert.ToString(Convert.ToInt64(numeroregistro) + 1).Trim();
                    break;
                case "275":
                    headerarquivo = "01REMESSA01COBRANCA       " + "0" + agencia.Substring(0, 4) + "0" + contacorrente.Substring(0, 7) + Srelib.replicate(" ", 7) + nomeempresa +
                                    xBanco + nomebanco.Substring(0, 15) + dataatual.Substring(0, 2) + dataatual.Substring(3, 2) + dataatual.Substring(8, 2) +
                                    "01600BPI" + Srelib.replicate(" ", 286) + "000001";
                    numeroregistro = Convert.ToString(Convert.ToInt64(numeroregistro) + 1).Trim();
                    break;
                case "291":
                    headerarquivo = "01REMESSA01COBRANCA       " + Srelib.replicate(" ", 10) + agencia.Substring(2, 3) + contacorrente.Substring(0, 7) + nomeempresa +
                                    xBanco + nomebanco + dataatual.Substring(0, 2) + dataatual.Substring(3, 2) + dataatual.Substring(8, 2) +
                                    "01600BPI" + Srelib.replicate(" ", 280) + "0" + numeroarquivo + "000001";
                    numeroregistro = Convert.ToString(Convert.ToInt64(numeroregistro) + 1).Trim();
                    break;
                case "341":
                    headerarquivo = "01REMESSA01COBRANCA" + Srelib.replicate(" ", 7) + agencia.Trim() + contacorrente.Trim() + Srelib.replicate(" ", 8) + nomeempresa +
                                    xBanco + nomebanco + dataatual.Substring(0, 2) + dataatual.Substring(3, 2) + dataatual.Substring(8, 2) +
                                    Srelib.replicate(" ", 294) + "000001";
                    numeroregistro = Convert.ToString(Convert.ToInt64(numeroregistro) + 1).Trim();
                    break;
                case "356":
                    headerarquivo = "01REMESSA01COBRANCA       " + "0" + agencia.Substring(0, 4) + "0" + contacorrente.Substring(0, 7) + Srelib.replicate(" ", 7) + nomeempresa +
                                    xBanco + nomebanco.Substring(0, 15) + dataatual.Substring(0, 2) + dataatual.Substring(3, 2) + dataatual.Substring(8, 2) +
                                    "01600BPI" + Srelib.replicate(" ", 286) + "000001";
                    numeroregistro = Convert.ToString(Convert.ToInt64(numeroregistro) + 1).Trim();
                    break;
                case "409":
                    headerarquivo = "01REMESSA01COBRANCA       " + agencia.Substring(0, 4) + contacorrente.Substring(0, 7) + Srelib.replicate(" ", 9) + nomeempresa +
                                    xBanco + nomebanco.Substring(0, 15) + dataatual.Substring(0, 2) + dataatual.Substring(3, 2) + dataatual.Substring(8, 2) +
                                    "01600BPI" + Srelib.replicate(" ", 283) + numeroarquivo.Substring(2, 3) + "000001";
                    numeroregistro = Convert.ToString(Convert.ToInt64(numeroregistro) + 1).Trim();
                    break;
                case "422":
                    headerarquivo = "01REMESSA01COBRANCA       " + agencia.Trim() + contacorrente.Trim() + Srelib.replicate(" ", 6) + nomeempresa +
                                    xBanco + nomebanco.Substring(0, 11) + Srelib.replicate(" ", 4) + dataatual.Substring(0, 2) + dataatual.Substring(3, 2) + dataatual.Substring(8, 2) +
                                    Srelib.replicate(" ", 291) + numeroarquivo.Substring(2, 3) + "000001";
                    numeroregistro = Convert.ToString(Convert.ToInt64(numeroregistro) + 1).Trim();
                    break;
                case "424":
                    headerarquivo = "01REMESSA09COBRANCA" + Srelib.replicate(" ", 7) + agencia.Trim() + contacorrente.Trim() + Srelib.replicate(" ", 9) + nomeempresa +
                                    xBanco + nomebanco + dataatual.Substring(0, 2) + dataatual.Substring(3, 2) + dataatual.Substring(8, 2) +
                                    Srelib.replicate(" ", 294) + "000001";
                    numeroregistro = Convert.ToString(Convert.ToInt64(numeroregistro) + 1).Trim();
                    break;
                case "479":
                    headerarquivo = "01REMESSA01COBRANCA       " + "009" + "01692724" + Srelib.replicate(" ", 9) + nomeempresa +
                                    xBanco + nomebanco + dataatual.Substring(0, 2) + dataatual.Substring(3, 2) + dataatual.Substring(8, 2) +
                                    "01600BPI" + Srelib.replicate(" ", 91) + "00000000" + Srelib.replicate(" ", 187) + "000001";
                    numeroregistro = Convert.ToString(Convert.ToInt64(numeroregistro) + 1).Trim();
                    break;
                case "641":
                    headerarquivo = "01REMESSA01COBRANCA" + Srelib.replicate(" ", 7) + Srelib.replicate("0", 6) + cnpjempresa + nomeempresa +
                                    xBanco + nomebanco + dataatual.Substring(0, 2) + dataatual.Substring(3, 2) + dataatual.Substring(8, 2) +
                                    Srelib.replicate(" ", 291) + numeroarquivo.Substring(2, 3) + "000001";
                    numeroregistro = Convert.ToString(Convert.ToInt64(numeroregistro) + 1).Trim();
                    break;
                default:
                    headerarquivo = "Erro Interno - Banco " + xBanco + " sem codificação para Header, acione o suporte ou verifique se o banco está correto.";
                    numeroregistro = Convert.ToString(Convert.ToInt64(numeroregistro) + 1).Trim();
                    break;
            }

        }
    }

    private void GeraRegistro400(string xproduto,
                                 string xgrupo,
                                 string xunidade,
                                 string xparte,
                                 string xData1,
                                 string xData2,
                                 string xBanco,
                                 string xconta,
                                 ref string titulos,
                                 ref string vlrtitulos,
                                 string numeroarquivo,
                                 ref string numeroregistro,
                                 Boolean msgautomatica,
                                 ref string[] linharegistro1,
                                 ref string[] linharegistro2)
    {
        //
        DataSet dsparcelas;
        //
        string nomebanco = uBanco.PegaNomeCodigo(xBanco);
        string dataatual = DateTime.Now.ToString().Substring(0, 10);
        string nomeempresa = uEmpresa.PegaNome(uEmpresa.PegaMatriz());
        string cnpjempresa = uEmpresa.PegaCnpj(uEmpresa.PegaMatriz());
        cnpjempresa = Srelib.replicate("0", cnpjempresa.Length - 14) + cnpjempresa;
        string agencia = Srelib.QStr0(uContas.PegaAgencia(xconta), 5);
        string contacorrente = Srelib.QStr0(uContas.PegaConta(xconta), 12);
        string carteira = Srelib.QStr0(uBanco.PegaCarteira(xBanco), 3);
        string complemento = Srelib.QStr0(uContas.PegaComplemento(xconta), 20);
        if (numeroarquivo.Length != 5)
        {
            numeroarquivo = Srelib.QStr0(numeroarquivo.Trim(), 5);
        }
        string caixapostal = uBanco.PegaCaixaPostal(xBanco);
        string assunto = uBanco.PegaAssunto(xBanco);
        string mensagem = "";
        string multabanco = uBanco.PegaMulta(xBanco);
        string comissaobanco = uBanco.PegaJuros(xBanco);
        string sequencia = uBanco.PegaSequencia(xBanco);
        string prazoprotesto = uBanco.PegaPrazoProtesto(xBanco);
        string prazodevolucao = uBanco.PegaPrazoDevolucao(xBanco);
        string prazofolga = uBanco.PegaPrazoFolga(xBanco);
        string identificador = "";
        string identificador7 = ""; //Unidade do numero da parcela, ex.: 37 = 7
        string identificadorespaco = Srelib.replicate(" ", 25);  //25 espaços - identificador
        //identificador7
        string eDAC = "";
        string eCA_1 = "0";
        string eCA_2 = "9";
        string eCA_3 = "0";
        string eCC_1 = "0";
        string eCC_2 = "0";
        string eCC_3 = "0";
        string eCC_4 = "0";
        string eCC_5 = "0";
        string eID_1 = "0";
        string eID_2 = "0";
        string eID_3 = "0";
        string eID_4 = "0";
        string eID_5 = "0";
        string eID_6 = "0";
        string eID_7 = "0";
        string eID_8 = "0";
        string eID_9 = "0";
        string eID_10 = "0";
        string eID_11 = "0";
        //Mensagem
        string msg1 = "";
        string msg2 = "";
        string msg3 = "";
        string msg4 = "";
        string msg5 = "";
        uMensagemBoleto.PegaMensagens(uProduto.PegaTipo(Convert.ToInt32(cbproduto.Value)),
                                      ref msg1,
                                      ref msg2,
                                      ref msg3,
                                      ref msg4,
                                      ref msg5);
        //
        //Agencia e Conta
        switch (xBanco)
        {
            case "341":
                agencia = Srelib.QStr0(uContas.PegaAgencia(xconta), 4);
                contacorrente = Srelib.QStr0(uContas.PegaConta(xconta), 9);
                break;
            case "422":
                agencia = Srelib.QStr0(uContas.PegaAgencia(xconta), 5);
                contacorrente = Srelib.QStr0(uContas.PegaConta(xconta), 9);
                break;
            case "424":
                agencia = Srelib.QStr0(uContas.PegaAgencia(xconta), 3);
                contacorrente = Srelib.QStr0(uContas.PegaConta(xconta), 8);
                break;
            case "641":
                agencia = Srelib.QStr0(uContas.PegaAgencia(xconta), 4);
                contacorrente = Srelib.QStr0(uContas.PegaConta(xconta), 10);
                break;
            default:
                agencia = Srelib.QStr0(uContas.PegaAgencia(xconta), 4);
                contacorrente = Srelib.QStr0(uContas.PegaConta(xconta), 12);
                break;
        }
        //
        //Razão Social da Empresa
        if (nomeempresa.Length < 30)
        {
            nomeempresa = nomeempresa + Srelib.replicate(" ", nomeempresa.Length - 30);
        }
        else
        {
            nomeempresa = nomeempresa.Substring(0, 29);
        }
        //
        //Carregar Dados de Parcelas
        string yproduto = "";
        string ygrupo = "";
        string yunidade = "";
        string yparte = "";
        string codigocliente = "";
        string nome = "";
        string endereco = "";
        string bairro = "";
        string cidade = "";
        string estado = "";
        string cep = "";
        string tiposacado = "";
        //
        string datavencimento = "";
        string datamulta = ""; //data multa é data vencimento + 5 dias
        string vlrparcela = "";
        string numeroparcela = "00000"; //Tamanho 5
        string dataemissao = "";
        Boolean protesto = false;
        string protestocodigo = "00";
        string protestocodigo2 = "00";
        //
        dsparcelas = uParcelas.PegaDadosParcelasDevedores(xproduto,
                                                          xgrupo,
                                                          xunidade,
                                                          xparte,
                                                          "1",
                                                          xData1,
                                                          xData2,
                                                          "0",
                                                          "0",
                                                          "0",
                                                          "V",
                                                          "1",
                                                          "1");
        //
        for (int i = 0; i < dsparcelas.Tables[0].Rows.Count; i++)
        {
            //
            endereco = "";
            bairro = "";
            cidade = "";
            estado = "";
            cep = "";
            tiposacado = "";
            //Carregar Dados de Parcelas
            yproduto = dsparcelas.Tables[0].Rows[i]["produto"].ToString().Trim();
            ygrupo = dsparcelas.Tables[0].Rows[i]["grupo"].ToString().Trim();
            yunidade = dsparcelas.Tables[0].Rows[i]["unidade"].ToString().Trim();
            yparte = dsparcelas.Tables[0].Rows[i]["parte"].ToString().Trim();
            codigocliente = uVendas.PegaProprietário(yproduto, ygrupo, yunidade, yparte);
            uContato.PegaEnderecoIDReferencia(codigocliente,
                                              ref nome,
                                              ref endereco,
                                              ref bairro,
                                              ref cidade,
                                              ref estado,
                                              ref cep,
                                              ref tiposacado);

            //
            datavencimento = dsparcelas.Tables[0].Rows[i]["data_vencimento"].ToString().Substring(0, 10);
            datamulta = Convert.ToString(Convert.ToDateTime(datavencimento).AddDays(5)).Substring(0, 10); //data multa é data vencimento + 5 dias
            dataemissao = DateTime.Now.ToString().Substring(0, 10);
            datavencimento = datavencimento.Substring(0, 2) + datavencimento.Substring(3, 2) + datavencimento.Substring(8, 2);
            datamulta = datamulta.Substring(0, 2) + datamulta.Substring(3, 2) + datamulta.Substring(8, 2);
            dataemissao = dataemissao.Substring(0, 2) + dataemissao.Substring(3, 2) + dataemissao.Substring(8, 2);
            //
            vlrparcela = dsparcelas.Tables[0].Rows[i]["vlr_parcela"].ToString(); //Tamanho 13
            vlrparcela = Convert.ToString(Convert.ToInt64(Convert.ToDouble(vlrparcela) * 100));
            vlrparcela = Srelib.QStr0(vlrparcela, 13);
            //
            numeroparcela = Srelib.QStr0(dsparcelas.Tables[0].Rows[i]["vlr_parcela"].ToString(), 5); //Tamanho 5
            //
            protesto = Convert.ToBoolean(dsparcelas.Tables[0].Rows[i]["protesto"].ToString());
            protestocodigo = "00";
            protestocodigo2 = "00";
            //
            identificador = Srelib.QStr0(xproduto.Trim(), 2) +
                            Srelib.QStr0(xgrupo.Trim(), 2) +
                            Srelib.QStr0(xunidade.Trim(), 3) +
                            Srelib.QStr0(xparte.Trim(), 1); //Tamanho 8
            if (numeroparcela.Length == 1)
            {
                identificador7 = numeroparcela.Trim(); //Unidade do numero da parcela, ex.: 7 = 7
            }
            else
            {
                identificador7 = numeroparcela.Substring(1, 1); //Unidade do numero da parcela, ex.: 37 = 7
            }

            identificadorespaco = Srelib.replicate(" ", 25 - identificador.Length) + identificador;  //25 espaços - identificador
            //
            //Registros
            switch (xBanco)
            {
                case "001":
                    if (msgautomatica)
                    {
                        //Mensagem de Multa Baseada na Taxa do Banco
                        mensagem = "MULTA " + Srelib.QStr0(multabanco, 2) + "% E COMISSAO APOS VENC." + Srelib.replicate(" ", 20);
                    }
                    //
                    sequencia = Srelib.QStr0(sequencia, 10);
                    //
                    numeroparcela = Srelib.QStr0("0", numeroparcela.Length - 2);
                    //
                    linharegistro1[i] =
                                    "702" + cnpjempresa + agencia + contacorrente.Substring(0, 9) + caixapostal + identificadorespaco + identificador + caixapostal + sequencia + Srelib.replicate("0", 6) +
                                    "AI 0190" + Srelib.replicate(" ", 11) + "17001" + "00" + identificador + identificador7 + datavencimento + vlrparcela + "0010000001A" + dataemissao + Srelib.replicate("0", 62) +
                                    tiposacado + cnpjempresa + nome.Substring(0, 37) + Srelib.replicate(" ", 3) + endereco.Substring(0, 37) + Srelib.replicate(" ", 15) + cep + cidade.Substring(0, 15) + estado.Substring(0, 2) +
                                    mensagem.Substring(0, 40) + Srelib.replicate(" ", 3) + numeroregistro;

                    break;
                case "008":
                    if (msgautomatica)
                    {
                        //Mensagem de Multa Baseada na Taxa do Banco
                        mensagem = "MULTA " + Srelib.QStr0(multabanco, 2) + "% E COMISSAO APOS VENC." + Srelib.replicate(" ", 20);
                    }
                    //
                    if (protesto)
                        protestocodigo = "0610";
                    else
                        protestocodigo = "0001";
                    //
                    linharegistro1[i] =
                                    "102" + cnpjempresa + agencia + "000000" + contacorrente.Substring(0, 9) + "00" + identificadorespaco + identificador + Srelib.replicate(" ", 45) +
                                    "301" + identificador + "00" + datavencimento + vlrparcela + "008" + Srelib.replicate("0", 5) + "01" + "N" +
                                    dataemissao + protestocodigo + "0000000000033" + Srelib.replicate("0", 45) + tiposacado + cnpjempresa + nome.Substring(0, 40) +
                                    endereco.Substring(0, 40) + bairro.Substring(0, 12) + cep + cidade.Substring(0, 15) + estado.Substring(0, 2) +
                                    mensagem.Substring(0, 40) + Srelib.replicate(" ", 2) + "1" + numeroregistro;

                    break;
                case "033":
                    sequencia = Srelib.QStr0(sequencia, 7);

                    if (msgautomatica)
                    {
                        //Mensagem de Multa Baseada na Taxa do Banco
                        mensagem = "MULTA " + Srelib.QStr0(multabanco, 2) + "% E COMISSAO APOS VENC." + Srelib.replicate(" ", 20);
                    }
                    //
                    if (protesto)
                    {
                        protestocodigo = "06";
                        protestocodigo2 = prazoprotesto;
                    }

                    else
                    {
                        protestocodigo = "07";
                        protestocodigo2 = prazodevolucao;
                    }
                    //
                    linharegistro1[i] =
                                    "102" + cnpjempresa + agencia.Substring(3, 3) + contacorrente.Substring(0, 8) + Srelib.replicate(" ", 9) + identificadorespaco + identificador + agencia.Substring(3, 3) + sequencia +
                                    Srelib.replicate(" ", 35) + "101" + identificador + "00" + datavencimento + vlrparcela + "033" + Srelib.replicate("0", 5) + "01" + "A" +
                                    dataemissao + protestocodigo + "58" + "0000000000033" + Srelib.replicate("0", 45) + tiposacado + cnpjempresa + nome.Substring(0, 30) + "- No:" + numeroparcela +
                                    endereco.Substring(0, 40) + bairro.Substring(0, 12) + cep + cidade.Substring(0, 15) + estado.Substring(0, 2) +
                                    mensagem.Substring(0, 30) + protestocodigo2 + Srelib.replicate(" ", 1) + numeroregistro;

                    break;
                case "104":
                    if (msgautomatica)
                    {
                        //Mensagem de Multa Baseada na Taxa do Banco
                        mensagem = "MULTA " + Srelib.QStr0(multabanco, 2) + "% E COMISSAO APOS VENC." + Srelib.replicate(" ", 20);
                    }
                    if (protesto)
                    {
                        protestocodigo = "01";
                        protestocodigo2 = prazoprotesto;
                    }
                    else
                    {
                        protestocodigo = "02";
                        protestocodigo2 = prazodevolucao;
                    }
                    //
                    linharegistro1[i] =
                                    "102" + cnpjempresa + agencia + contacorrente + Srelib.replicate(" ", 2) + "00" + identificador + Srelib.replicate("0", 11) + Srelib.replicate(" ", 3) +
                                    mensagem.Substring(0, 30) + "11" + "01" + identificador + Srelib.replicate(" ", 2) + datavencimento + vlrparcela + "104" + "00000" + "01" + "A" +
                                    dataemissao + protestocodigo + "00" + Srelib.replicate("0", 13 + 6 + 13 + 13 + 13) + tiposacado + cnpjempresa + nome.Substring(0, 35) +
                                    Srelib.replicate(" ", 5) + endereco.Substring(0, 35) + Srelib.replicate(" ", 5) + bairro.Substring(0, 12) + cep + cidade.Substring(0, 15) + estado.Substring(0, 2) +
                                    datamulta + Srelib.replicate("0", 10) + Srelib.replicate(" ", 22) + "00" + protestocodigo2 + "1" + numeroregistro;

                    break;
                case "151":

                    if (msgautomatica)
                    {
                        //Mensagem de Multa Baseada na Taxa do Banco
                        mensagem = "MULTA " + Srelib.QStr0(multabanco, 2) + "% E COMISSAO APOS VENC." + Srelib.replicate(" ", 20);
                    }
                    //Obs colocar identificador aqui
                    //
                    identificadorespaco = Srelib.replicate(" ", 25 - identificador.Length) + identificador;  //25 espaços - identificador
                    //
                    if (protesto)
                    {
                        protestocodigo = "01";
                        protestocodigo2 = prazoprotesto;
                    }
                    else
                    {
                        protestocodigo = "02";
                        protestocodigo2 = "99";
                    }
                    linharegistro1[i] =
                                    "15100013" + Srelib.QStr0(numeroregistro, 5) + "P 0100" + agencia + "0000" + contacorrente + Srelib.replicate(" ", 5) + "098870" + "0000000000" + "052120" +
                                    Srelib.replicate(" ", 3) + identificadorespaco.Substring(13, 13) + datavencimento + "00" + vlrparcela + "00000002A" + dataemissao + "3" + Srelib.replicate(" ", 8) +
                                    "00000000000100001" + Srelib.replicate("0", 23) + Srelib.replicate(" ", 30) +
                                    identificador + " " + protestocodigo2 + Srelib.replicate(" ", 4) + "00" + Srelib.replicate(" ", 3) + "00" + Srelib.replicate(" ", 4);
                    //
                    numeroregistro = Convert.ToString(Convert.ToInt64(numeroregistro) + 1).Trim();
                    //
                    //2a. linha de Registro
                    linharegistro2[i] =
                                    "15100013" + Srelib.QStr0(numeroregistro, 5) + "Q 0110" + cnpjempresa + nome.Substring(0, 40) + endereco.Substring(0, 40) + bairro.Substring(0, 15) +
                                    cep + cidade.Substring(0, 15) + estado.Substring(0, 2) + "20" + cnpjempresa + nome.Substring(0, 40) + Srelib.replicate(" ", 31);

                    break;
                case "215":
                    if (msgautomatica)
                    {
                        //Mensagem de Multa Baseada na Taxa do Banco
                        mensagem = "MULTA " + Srelib.QStr0(multabanco, 2) + "% E COMISSAO APOS VENC." + Srelib.replicate(" ", 20);
                    }
                    //     
                    if (protesto)
                    {
                        protestocodigo = "16";
                        protestocodigo2 = prazoprotesto;
                    }
                    else
                    {
                        protestocodigo = "20";
                        protestocodigo2 = "00";
                    }

                    linharegistro1[i] =
                                    "102" + cnpjempresa + agencia + "02" + contacorrente.Substring(0, 8) + Srelib.replicate(" ", 6) + identificadorespaco + identificador + Srelib.replicate("0", 16) +
                                    "00" + Srelib.replicate(" ", 27) + "101" + identificador + "00" + datavencimento + vlrparcela + "215" + Srelib.replicate("0", 5) + "15" + "A" +
                                    dataemissao + protestocodigo + "00" + Srelib.replicate("0", 58) + tiposacado + cnpjempresa + nome.Substring(0, 40) +
                                    endereco.Substring(0, 40) + bairro.Substring(0, 10) + protestocodigo2 + prazodevolucao + Srelib.replicate(" ", 8) + cep + cidade.Substring(0, 15) + estado.Substring(0, 2) +
                                    mensagem.Substring(0, 30) + "99" + " " + numeroregistro;

                    break;
                case "230":
                    if (msgautomatica)
                    {
                        //Mensagem de Multa Baseada na Taxa do Banco
                        mensagem = "MULTA " + Srelib.QStr0(multabanco, 2) + "% E COMISSAO APOS VENC." + Srelib.replicate(" ", 20);
                    }

                    //   
                    if (protesto)
                    {
                        protestocodigo = "04";
                        protestocodigo2 = prazoprotesto;
                    }

                    else
                    {
                        protestocodigo = "01";
                        protestocodigo2 = prazodevolucao;
                    }
                    linharegistro1[i] =
                                    "102" + cnpjempresa + agencia.Substring(3, 3) + contacorrente.Substring(0, 10) + Srelib.replicate(" ", 7) + identificadorespaco + identificador + Srelib.replicate("0", 13) +
                                    Srelib.replicate(" ", 7) + protestocodigo2 + Srelib.replicate(" ", 23) + "101" + identificador + "00" + datavencimento + vlrparcela + "230" + Srelib.replicate("0", 5) + "01" + "A" +
                                    dataemissao + protestocodigo + "00" + Srelib.replicate("0", 13) + Srelib.replicate("0", 45) + tiposacado + cnpjempresa + nome.Substring(0, 40) +
                                    endereco.Substring(0, 40) + bairro.Substring(0, 12) + cep + cidade.Substring(0, 15) + estado.Substring(0, 2) +
                                    mensagem.Substring(0, 30) + Srelib.replicate(" ", 2) + "9" + numeroregistro;

                    break;
                case "237":
                    // Bradesco
                    if (msgautomatica)
                    {
                        //Mensagem de Multa Baseada na Taxa do Banco
                        mensagem = "MULTA " + Srelib.QStr0(multabanco, 2) + "% E COMISSAO APOS VENC." + Srelib.replicate(" ", 20);
                    }
                    else
                    {
                        mensagem = msg1;
                    }
                    //
                    // CALCULO DO DAC BASE 11 CARTEIRA No. 9
                    eDAC = "";
                    eCA_1 = "0";
                    eCA_2 = "9";
                    eID_1 = identificador.Substring(1, 1);
                    eID_2 = identificador.Substring(2, 1);
                    eID_3 = identificador.Substring(3, 1);
                    eID_4 = identificador.Substring(4, 1);
                    eID_5 = identificador.Substring(5, 1);
                    eID_6 = identificador.Substring(6, 1);
                    eID_7 = "0";
                    eID_8 = "0";
                    eID_9 = "0";
                    eID_10 = "0";
                    eID_11 = "0";
                    //
                    if (numeroparcela.Length == 1)
                    {
                        eID_7 = "0";
                        eID_8 = "0";
                        eID_9 = numeroparcela;
                    }
                    else
                    {
                        if (numeroparcela.Length == 2)
                        {
                            eID_7 = "0";
                            eID_8 = numeroparcela.Substring(0, 1);
                            eID_9 = numeroparcela.Substring(1, 1);
                        }
                        else
                        {
                            eID_7 = "0";
                            eID_8 = numeroparcela.Substring(0, 1);
                            eID_9 = numeroparcela.Substring(numeroparcela.Length - 1, 1);
                        }
                    }

                    string eAG_1 = Convert.ToString(Convert.ToInt16(eCA_1) * 2);
                    string eAG_2 = Convert.ToString(Convert.ToInt16(eCA_2) * 7);
                    string eAG_3 = Convert.ToString(Convert.ToInt16(eID_1) * 6);
                    string eAG_4 = Convert.ToString(Convert.ToInt16(eID_2) * 5);
                    string eAG_5 = Convert.ToString(Convert.ToInt16(eID_3) * 4);
                    string eAG_6 = Convert.ToString(Convert.ToInt16(eID_4) * 3);
                    string eAG_7 = Convert.ToString(Convert.ToInt16(eID_5) * 2);
                    string eAG_8 = Convert.ToString(Convert.ToInt16(eID_6) * 7);
                    string eAG_9 = Convert.ToString(Convert.ToInt16(eID_7) * 6);
                    string eAG_10 = Convert.ToString(Convert.ToInt16(eID_8) * 5);
                    string eAG_11 = Convert.ToString(Convert.ToInt16(eID_9) * 4);
                    string eAG_12 = Convert.ToString(Convert.ToInt16(eID_10) * 3);
                    string eAG_13 = Convert.ToString(Convert.ToInt16(eID_11) * 2);

                    String eDV = "0";
                    eDV = Convert.ToString(+
                          Convert.ToInt16(eAG_1) +
                          Convert.ToInt16(eAG_2) +
                          Convert.ToInt16(eAG_3) +
                          Convert.ToInt16(eAG_4) +
                          Convert.ToInt16(eAG_5) +
                          Convert.ToInt16(eAG_6) +
                          Convert.ToInt16(eAG_7) +
                          Convert.ToInt16(eAG_8) +
                          Convert.ToInt16(eAG_9) +
                          Convert.ToInt16(eAG_10) +
                          Convert.ToInt16(eAG_11) +
                          Convert.ToInt16(eAG_12) +
                          Convert.ToInt16(eAG_13));

                    Int64 restodivisao = (Convert.ToInt64(eDV) % 11);
                    if (restodivisao == 1)
                    {
                        eDV = "P";
                    }
                    else
                    {
                        if (restodivisao == 0)
                        {
                            eDV = "0";
                        }
                        else
                        {
                            eDV = Convert.ToString((11 - (Convert.ToInt64(eDV) % 11)));
                            eDV = Srelib.replicate(" ", 5 - eDV.Length) + eDV.Trim();
                        }
                    }

                    eDAC = "";
                    eDAC = eID_1.Substring(0, 1) +
                           eID_2.Substring(0, 1) +
                           eID_3.Substring(0, 1) +
                           eID_4.Substring(0, 1) +
                           eID_5.Substring(0, 1) +
                           eID_6.Substring(0, 1) +
                           eID_7.Substring(0, 1) +
                           eID_8.Substring(0, 1) +
                           eID_9.Substring(0, 1) +
                           eID_10.Substring(0, 1) +
                           eID_11.Substring(0, 1) +
                           eDV;

                    //

                    if (protesto)
                    {
                        protestocodigo = "06";
                        protestocodigo2 = prazoprotesto;
                    }

                    else
                    {
                        protestocodigo = "00";
                        protestocodigo2 = "00";
                    }

                    linharegistro1[i] =
                                    "1" + Srelib.replicate("0", 5 + 1 + 5 + 7 + 1) + "00090" + agencia + contacorrente.Substring(0, 8) + identificadorespaco + identificador +
                                    "000" + Srelib.replicate("0", 5) + eDAC + Srelib.replicate("0", 10) + "1 " + Srelib.replicate(" ", 10) +
                                    " 0  " + "01" + identificador + "00" + datavencimento + vlrparcela + Srelib.replicate("0", 8) + "01A" +
                                    dataemissao + protestocodigo + protestocodigo2 + Srelib.replicate("0", (13 + 6 + 13 + 13 + 13)) +
                                    tiposacado + cnpjempresa + nome.Substring(0, 40) + endereco.Substring(0, 40) + Srelib.replicate(" ", 12) +
                                    cep + Srelib.replicate(" ", 60) + numeroregistro;

                    // Numero Sequencial do Registro
                    numeroregistro = Convert.ToString(Convert.ToInt64(numeroregistro) + 1).Trim();
                    //
                    //2a. linha de Registro
                    linharegistro2[i] =
                                    "2" + mensagem.Substring(0, 30) + Srelib.replicate(" ", 40) + msg2 + Srelib.replicate(" ", 40) +
                                    msg3 + Srelib.replicate(" ", 40) + msg4 + Srelib.replicate(" ", 40) + Srelib.replicate(" ", 45) + "0090" + agencia +
                                    "99179066" + eDAC + Srelib.QStr0(numeroregistro, 6);


                    break;
                case "275":
                    if (msgautomatica)
                    {
                        //Mensagem de Multa Baseada na Taxa do Banco
                        mensagem = "MULTA " + Srelib.QStr0(multabanco, 2) + "% E COMISSAO APOS VENC." + Srelib.replicate(" ", 20);
                    }

                    linharegistro1[i] =
                                    "102" + cnpjempresa + "0" + agencia.Substring(1, 4) + "0" + contacorrente.Substring(0, 7) + Srelib.replicate(" ", 7) +
                                    identificador + Srelib.replicate(" ", 17) + "0" + identificador + Srelib.replicate(" ", 24) + Srelib.replicate("0", 9) +
                                    Srelib.replicate(" ", 1) + "2 501" + "  " + identificador + datavencimento + vlrparcela + "275" + Srelib.replicate("0", 5) + "99" + "A" + dataemissao + "0000" + Srelib.replicate("0", 58) +
                                    tiposacado + cnpjempresa + nome.Substring(0, 40) + endereco.Substring(0, 40) + bairro.Substring(0, 12) + cep + cidade.Substring(0, 15) + estado.Substring(0, 2) +
                                    mensagem.Substring(0, 40) + Srelib.replicate(" ", 1) + "77" + numeroregistro;

                    break;
                case "291":
                    if (msgautomatica)
                    {
                        //Mensagem de Multa Baseada na Taxa do Banco
                        mensagem = "MULTA " + Srelib.QStr0(multabanco, 2) + "% E COMISSAO APOS VENC." + Srelib.replicate(" ", 20);
                    }
                    // CALCULO DO DAC
                    eID_1 = identificador.Substring(1, 1);
                    eID_2 = identificador.Substring(2, 1);
                    eID_3 = identificador.Substring(3, 1);
                    eID_4 = identificador.Substring(4, 1);
                    eID_5 = identificador.Substring(5, 1);
                    eID_6 = identificador.Substring(6, 1);
                    eID_7 = "0";
                    //
                    if (numeroparcela.Length == 1)
                    {
                        eID_7 = numeroparcela;
                    }
                    else
                    {
                        if (numeroparcela.Length == 2)
                        {
                            eID_7 = numeroparcela.Substring(1, 1);
                        }
                        else
                        {
                            eID_7 = numeroparcela.Substring(numeroparcela.Length - 1, 1);
                        }
                    }
                    //
                    eAG_1 = Convert.ToString(Convert.ToInt16(eID_1) * 80);
                    eAG_2 = Convert.ToString(Convert.ToInt16(eID_2) * 70);
                    eAG_3 = Convert.ToString(Convert.ToInt16(eID_3) * 60);
                    eAG_4 = Convert.ToString(Convert.ToInt16(eID_4) * 50);
                    eAG_5 = Convert.ToString(Convert.ToInt16(eID_5) * 40);
                    eAG_6 = Convert.ToString(Convert.ToInt16(eID_6) * 30);
                    eAG_7 = Convert.ToString(Convert.ToInt16(eID_7) * 20);

                    eDV = " ";
                    eDV = Convert.ToString(+
                          Convert.ToInt16(eID_1) +
                          Convert.ToInt16(eID_2) +
                          Convert.ToInt16(eID_3) +
                          Convert.ToInt16(eID_4) +
                          Convert.ToInt16(eID_5) +
                          Convert.ToInt16(eID_6) +
                          Convert.ToInt16(eID_7));
                    //
                    restodivisao = (Convert.ToInt64(eDV) % 11);
                    if (restodivisao == 10)
                    {
                        eDV = "0";
                    }
                    else
                    {
                        eDV = Convert.ToString(((Convert.ToInt64(eDV) % 11)));
                        eDV = Srelib.replicate(" ", 5 - eDV.Length) + eDV.Trim();
                    }
                    //
                    identificador = identificador.Substring(1, 7) + eID_7.Substring(eID_7.Length - 1, 1); ; //tamanho 8
                    //

                    linharegistro1[i] =
                                    "101" + cnpjempresa + Srelib.replicate(" ", 10) + agencia.Substring(3, 3) + contacorrente.Substring(0, 7) + identificador + identificadorespaco +
                                    Srelib.replicate(" ", 12) + identificador.Substring(1, 7) + eDV +
                                    Srelib.replicate(" ", 25) + "101" + "00" + identificador + datavencimento + vlrparcela + "291" + Srelib.replicate("0", 5) + "01" + "A" +
                                    dataemissao + prazodevolucao + prazoprotesto + Srelib.replicate("0", 58) + tiposacado + cnpjempresa + nome.Substring(0, 40) +
                                    endereco.Substring(0, 40) + bairro.Substring(0, 12) + cep + cidade.Substring(0, 15) + estado.Substring(0, 2) +
                                    Srelib.replicate(" ", 43) + numeroregistro;

                    break;
                case "341":
                    //Carteira
                    switch (carteira)
                    {
                        case "112":

                            if (msgautomatica)
                            {
                                //Mensagem de Multa Baseada na Taxa do Banco
                                mensagem = "MULTA " + Srelib.QStr0(multabanco, 2) + "% E COMISSAO APOS VENC." + Srelib.replicate(" ", 20);
                            }
                            // 
                            if (protesto)
                            {
                                protestocodigo = "09";
                                protestocodigo2 = prazoprotesto;
                            }

                            else
                            {
                                protestocodigo = "92";
                                protestocodigo2 = prazodevolucao;
                            }
                            linharegistro1[i] =
                                            "102" + cnpjempresa + agencia + contacorrente + Srelib.replicate(" ", 8) + identificador + identificadorespaco + Srelib.replicate("0", 8) + Srelib.replicate("0", 13) +
                                            "112" + Srelib.replicate(" ", 21) + "I" + "01" + identificador + "00" + datavencimento + vlrparcela + "341" + Srelib.replicate(" ", 5) + "06" + "A" +
                                            dataemissao + protestocodigo + Srelib.replicate("0", 60) + tiposacado + cnpjempresa + nome.Substring(0, 40) +
                                            endereco.Substring(0, 40) + bairro.Substring(0, 12) + cep + cidade.Substring(0, 15) + estado.Substring(0, 2) +
                                            Srelib.replicate(" ", 34) + datavencimento + protestocodigo2 + " " + numeroregistro;
                            break;
                        case "121":

                            if (msgautomatica)
                            {
                                //Mensagem de Multa Baseada na Taxa do Banco
                                mensagem = "MULTA " + Srelib.QStr0(multabanco, 2) + "% E COMISSAO APOS VENC." + Srelib.replicate(" ", 20);
                            }
                            // 
                            if (protesto)
                            {
                                protestocodigo = "09";
                                protestocodigo2 = prazoprotesto;
                            }

                            else
                            {
                                protestocodigo = "92";
                                protestocodigo2 = prazodevolucao;
                            }
                            linharegistro1[i] =
                                            "102" + cnpjempresa + agencia + contacorrente + Srelib.replicate(" ", 25) + identificador + Srelib.replicate("0", 8) + Srelib.replicate("0", 13) + "341" +
                                            "121" + Srelib.replicate(" ", 21) + "I" + "01" + "00" + identificador + datavencimento + vlrparcela + "341" + Srelib.replicate(" ", 5) + "06" + "A" +
                                            dataemissao + protestocodigo + Srelib.replicate("0", 60) + tiposacado + cnpjempresa + nome.Substring(0, 40) +
                                            endereco.Substring(0, 40) + bairro.Substring(0, 12) + cep + cidade.Substring(0, 15) + estado.Substring(0, 2) +
                                            Srelib.replicate(" ", 34) + datavencimento + protestocodigo2 + " " + numeroregistro;

                            break;
                        case "175": //Duplicar para carteira 179
                            if (msgautomatica)
                            {
                                //Mensagem de Multa Baseada na Taxa do Banco
                                mensagem = "MULTA " + Srelib.QStr0(multabanco, 2) + "% E COMISSAO APOS VENC." + Srelib.replicate(" ", 20);
                            }
                            //CALCULO DO DAC
                            eAG_1 = "0";
                            eAG_2 = "0";
                            eAG_3 = "0";
                            eAG_4 = "0";
                            eCC_1 = "0";
                            eCC_2 = "0";
                            eCC_3 = "0";
                            eCC_4 = "0";
                            eCC_5 = "0";
                            eCA_1 = "0";
                            eCA_2 = "0";
                            eCA_3 = "0";
                            eID_1 = "0";
                            eID_2 = "0";
                            eID_3 = "0";
                            eID_4 = "0";
                            eID_5 = "0";
                            eID_6 = "0";
                            eID_7 = "0";
                            eID_8 = "0";


                            eAG_1 = agencia.Substring(0, 1);
                            eAG_2 = agencia.Substring(1, 1);
                            eAG_3 = agencia.Substring(2, 1);
                            eAG_4 = agencia.Substring(3, 1);
                            eCC_1 = contacorrente.Substring(2, 1);
                            eCC_2 = contacorrente.Substring(3, 1);
                            eCC_3 = contacorrente.Substring(4, 1);
                            eCC_4 = contacorrente.Substring(5, 1);
                            eCC_5 = contacorrente.Substring(6, 1);
                            if (carteira == "175")
                            {
                                eCA_1 = "1";
                                eCA_2 = "7";
                                eCA_3 = "5";
                            }
                            else
                            {
                                eCA_1 = "1";
                                eCA_2 = "7";
                                eCA_3 = "9";
                            }
                            // CALCULO DO DAC
                            eID_1 = identificador.Substring(0, 1);
                            eID_2 = identificador.Substring(1, 1);
                            eID_3 = identificador.Substring(2, 1);
                            eID_4 = identificador.Substring(3, 1);
                            eID_5 = identificador.Substring(4, 1);
                            eID_6 = identificador.Substring(5, 1);
                            eID_7 = identificador.Substring(6, 1);
                            eID_8 = identificador.Substring(7, 1);

                            eAG_1 = Convert.ToString(Convert.ToInt16(eAG_1) * 1);
                            eAG_2 = Convert.ToString(Convert.ToInt16(eAG_2) * 2);
                            eAG_3 = Convert.ToString(Convert.ToInt16(eAG_3) * 1);
                            eAG_4 = Convert.ToString(Convert.ToInt16(eAG_4) * 2);
                            eCC_1 = Convert.ToString(Convert.ToInt16(eCC_1) * 1);
                            eCC_2 = Convert.ToString(Convert.ToInt16(eCC_2) * 2);
                            eCC_3 = Convert.ToString(Convert.ToInt16(eCC_3) * 1);
                            eCC_4 = Convert.ToString(Convert.ToInt16(eCC_4) * 2);
                            eCC_5 = Convert.ToString(Convert.ToInt16(eCC_5) * 1);
                            eCA_1 = Convert.ToString(Convert.ToInt16(eCA_1) * 2);
                            eCA_2 = Convert.ToString(Convert.ToInt16(eCA_2) * 1);
                            eCA_3 = Convert.ToString(Convert.ToInt16(eCA_3) * 2);
                            eID_1 = Convert.ToString(Convert.ToInt16(eID_1) * 1);
                            eID_2 = Convert.ToString(Convert.ToInt16(eID_2) * 2);
                            eID_3 = Convert.ToString(Convert.ToInt16(eID_3) * 1);
                            eID_4 = Convert.ToString(Convert.ToInt16(eID_4) * 2);
                            eID_5 = Convert.ToString(Convert.ToInt16(eID_5) * 1);
                            eID_6 = Convert.ToString(Convert.ToInt16(eID_6) * 2);
                            eID_7 = Convert.ToString(Convert.ToInt16(eID_7) * 1);
                            eID_8 = Convert.ToString(Convert.ToInt16(eID_8) * 2);

                            if (eAG_1.Length > 1)
                            {
                                eAG_1 = Convert.ToString(Convert.ToInt16(eAG_1.Substring(0, 1)) +
                                        Convert.ToInt16(eAG_1.Substring(1, 1)));
                            }
                            if (eAG_2.Length > 1)
                            {
                                eAG_2 = Convert.ToString(Convert.ToInt16(eAG_2.Substring(0, 1)) +
                                        Convert.ToInt16(eAG_2.Substring(1, 1)));
                            }
                            if (eAG_3.Length > 1)
                            {
                                eAG_3 = Convert.ToString(Convert.ToInt16(eAG_3.Substring(0, 1)) +
                                        Convert.ToInt16(eAG_3.Substring(1, 1)));
                            }
                            if (eAG_4.Length > 1)
                            {
                                eAG_4 = Convert.ToString(Convert.ToInt16(eAG_4.Substring(0, 1)) +
                                        Convert.ToInt16(eAG_4.Substring(1, 1)));
                            }
                            //
                            if (eCC_1.Length > 1)
                            {
                                eCC_1 = Convert.ToString(Convert.ToInt16(eCC_1.Substring(0, 1)) +
                                        Convert.ToInt16(eCC_1.Substring(1, 1)));
                            }
                            if (eCC_2.Length > 1)
                            {
                                eCC_2 = Convert.ToString(Convert.ToInt16(eCC_2.Substring(0, 1)) +
                                        Convert.ToInt16(eCC_2.Substring(1, 1)));
                            }
                            if (eCC_3.Length > 1)
                            {
                                eCC_3 = Convert.ToString(Convert.ToInt16(eCC_3.Substring(0, 1)) +
                                        Convert.ToInt16(eCC_3.Substring(1, 1)));
                            }
                            if (eCC_4.Length > 1)
                            {
                                eCC_4 = Convert.ToString(Convert.ToInt16(eCC_4.Substring(0, 1)) +
                                        Convert.ToInt16(eCC_4.Substring(1, 1)));
                            }
                            if (eCC_5.Length > 1)
                            {
                                eCC_5 = Convert.ToString(Convert.ToInt16(eCC_5.Substring(0, 1)) +
                                        Convert.ToInt16(eCC_5.Substring(1, 1)));
                            }
                            //
                            if (eCA_1.Length > 1)
                            {
                                eCA_1 = Convert.ToString(Convert.ToInt16(eCA_1.Substring(0, 1)) +
                                        Convert.ToInt16(eCA_1.Substring(1, 1)));
                            }
                            if (eCA_2.Length > 1)
                            {
                                eCA_2 = Convert.ToString(Convert.ToInt16(eCA_2.Substring(0, 1)) +
                                        Convert.ToInt16(eCA_2.Substring(1, 1)));
                            }
                            if (eCA_3.Length > 1)
                            {
                                eCA_3 = Convert.ToString(Convert.ToInt16(eCA_3.Substring(0, 1)) +
                                        Convert.ToInt16(eCA_3.Substring(1, 1)));
                            }
                            //
                            if (eID_1.Length > 1)
                            {
                                eID_1 = Convert.ToString(Convert.ToInt16(eID_1.Substring(0, 1)) +
                                        Convert.ToInt16(eID_1.Substring(1, 1)));
                            }
                            if (eID_2.Length > 1)
                            {
                                eID_2 = Convert.ToString(Convert.ToInt16(eID_2.Substring(0, 1)) +
                                        Convert.ToInt16(eID_2.Substring(1, 1)));
                            }
                            if (eID_3.Length > 1)
                            {
                                eID_3 = Convert.ToString(Convert.ToInt16(eID_3.Substring(0, 1)) +
                                        Convert.ToInt16(eID_3.Substring(1, 1)));
                            }
                            if (eID_4.Length > 1)
                            {
                                eID_4 = Convert.ToString(Convert.ToInt16(eID_4.Substring(0, 1)) +
                                        Convert.ToInt16(eID_4.Substring(1, 1)));
                            }
                            if (eID_5.Length > 1)
                            {
                                eID_5 = Convert.ToString(Convert.ToInt16(eID_5.Substring(0, 1)) +
                                        Convert.ToInt16(eID_5.Substring(1, 1)));
                            }
                            if (eID_6.Length > 1)
                            {
                                eID_6 = Convert.ToString(Convert.ToInt16(eID_6.Substring(0, 1)) +
                                        Convert.ToInt16(eID_6.Substring(1, 1)));
                            }
                            if (eID_7.Length > 1)
                            {
                                eID_7 = Convert.ToString(Convert.ToInt16(eID_7.Substring(0, 1)) +
                                        Convert.ToInt16(eID_7.Substring(1, 1)));
                            }
                            if (eID_8.Length > 1)
                            {
                                eID_8 = Convert.ToString(Convert.ToInt16(eID_8.Substring(0, 1)) +
                                        Convert.ToInt16(eID_8.Substring(1, 1)));
                            }
                            //
                            eDV = " ";
                            eDV = Convert.ToString(+
                                  Convert.ToInt16(eAG_1) +
                                  Convert.ToInt16(eAG_2) +
                                  Convert.ToInt16(eAG_3) +
                                  Convert.ToInt16(eAG_4) +
                                  Convert.ToInt16(eCC_1) +
                                  Convert.ToInt16(eCC_2) +
                                  Convert.ToInt16(eCC_3) +
                                  Convert.ToInt16(eCC_4) +
                                  Convert.ToInt16(eCC_5) +
                                  Convert.ToInt16(eCA_1) +
                                  Convert.ToInt16(eCA_2) +
                                  Convert.ToInt16(eCA_3) +
                                  Convert.ToInt16(eID_1) +
                                  Convert.ToInt16(eID_2) +
                                  Convert.ToInt16(eID_3) +
                                  Convert.ToInt16(eID_4) +
                                  Convert.ToInt16(eID_5) +
                                  Convert.ToInt16(eID_6) +
                                  Convert.ToInt16(eID_7) +
                                  Convert.ToInt16(eID_8));
                            //
                            restodivisao = (Convert.ToInt64(eDV) % 10);
                            if (restodivisao != 0)
                            {
                                eDAC = "0";
                                eDAC = Convert.ToString(((10 - restodivisao) % 10));
                            }
                            else
                            {
                                eDAC = "0";
                            }
                            //
                            if ((Convert.ToInt16(eDAC) < 0) && (Convert.ToInt16(eDAC) > 9))
                            {
                                eDAC = "ERRO - DAC FORA DA FAIXA (< 0 - > 9)";
                            }

                            string msgpagavel = "PAGAVEL EM QUALQUER BANCO ATE O VENCIMENTO              ";
                            //           * Numero da Parcela aparece no sacador/avalista
                            string obsparcela = "        PARCELA NUMERO : " + Srelib.QStr0(numeroparcela, 2);

                            linharegistro1[i] =
                                            "61" + agencia + contacorrente + carteira.Substring(1, 2) + identificador + eDAC + "0" + Srelib.replicate(" ", 4) + vlrparcela + identificador + "00" + datavencimento + "01A" +
                                            dataemissao + tiposacado + "0" + cnpjempresa + nome.Substring(0, 39) + endereco.Substring(0, 40) + bairro.Substring(0, 12) +
                                            cep + cidade.Substring(0, 15) + estado.Substring(0, 2) + obsparcela + Srelib.replicate(" ", 4) +
                                            msgpagavel + Srelib.replicate(" ", 55) + "02" + cnpjempresa + Srelib.replicate(" ", 31) + Srelib.QStr0(numeroregistro, 6);

                            // Numero Sequencial do Registro
                            numeroregistro = Convert.ToString(Convert.ToInt64(numeroregistro) + 1).Trim();

                            linharegistro2[i] =
                                             "62" + mensagem.Substring(0, 30) + Srelib.replicate(" ", 29) + msg2 + Srelib.replicate(" ", 29) + msg3 +
                                             Srelib.replicate(" ", 29) + msg4 + Srelib.replicate(" ", 29) + msg5 + Srelib.replicate(" ", 29) + Srelib.replicate(" ", 47) + Srelib.QStr0(numeroregistro, 6);


                            break;
                        default:
                            linharegistro1[i] =
                                            "Banco 341 - Codigo de carteira incompativel, Carteiras 112,121,175 ou 179 aceitos";
                            linharegistro2[i] =
                                             "Se sua carteira de cobranca e diferente destas, comunique o Suporte.";
                            break;
                    }

                    break;
                case "356":

                    if (msgautomatica)
                    {
                        //Mensagem de Multa Baseada na Taxa do Banco
                        mensagem = "MULTA " + Srelib.QStr0(multabanco, 2) + "% E COMISSAO APOS VENC." + Srelib.replicate(" ", 20);
                    }

                    linharegistro1[i] =
                                    "102" + cnpjempresa + "0" + agencia.Substring(1, 4) + "0" + contacorrente.Substring(0, 7) +
                                    Srelib.replicate(" ", 7) + identificador + Srelib.replicate(" ", 17) + "0" + identificador + Srelib.replicate(" ", 24) + Srelib.replicate("0", 9) +
                                    Srelib.replicate(" ", 1) + "2 501" + "  " + identificador + datavencimento + vlrparcela + "356" + Srelib.replicate("0", 5) + "99" + "A" + dataemissao + "0000" + Srelib.replicate("0", 58) +
                                    tiposacado + cnpjempresa + nome.Substring(0, 40) + endereco.Substring(0, 40) + bairro.Substring(0, 12) + cep + cidade.Substring(0, 15) + estado.Substring(0, 2) +
                                    mensagem.Substring(0, 40) + Srelib.replicate(" ", 1) + "77" + Srelib.QStr0(numeroregistro, 6);

                    break;
                case "409":

                    if (msgautomatica)
                    {
                        //Mensagem de Multa Baseada na Taxa do Banco
                        mensagem = "MULTA " + Srelib.QStr0(multabanco, 2) + "% E COMISSAO APOS VENC." + Srelib.replicate(" ", 20);
                    }
                    // 
                    if (protesto)
                    {
                        protestocodigo = "06";
                        protestocodigo2 = prazoprotesto;
                    }

                    else
                    {
                        protestocodigo = "07";
                        protestocodigo2 = prazodevolucao;
                    }
                    //
                    linharegistro1[i] =
                                    "102" + cnpjempresa + agencia.Substring(1, 4) + contacorrente.Substring(0, 7) + Srelib.replicate(" ", 9) + identificadorespaco + identificador + Srelib.replicate("0", 11) +
                                    mensagem.Substring(0, 30) + Srelib.replicate(" ", 4) + carteira.Substring(2, 1) + "01" + identificador + "00" + datavencimento + vlrparcela + "409" + Srelib.replicate("0", 5) + "01" + "A" +
                                    dataemissao + "03" + protestocodigo + Srelib.replicate("0", 58) + tiposacado + cnpjempresa + nome.Substring(0, 40) +
                                    endereco.Substring(0, 40) + bairro.Substring(0, 12) + cep + cidade.Substring(0, 15) + estado.Substring(0, 2) +
                                    Srelib.replicate(" ", 40) + prazoprotesto + "0" + Srelib.QStr0(numeroregistro, 6);

                    break;
                case "422":

                    if (msgautomatica)
                    {
                        //Mensagem de Multa Baseada na Taxa do Banco
                        mensagem = "MULTA " + Srelib.QStr0(multabanco, 2) + "% E COMISSAO APOS VENC." + Srelib.replicate(" ", 20);
                    }
                    eDAC = "000000000";
                    //
                    //* CALCULO DO DAC
                    //IF eNUM_ATU <> 0
                    //   eNUM_NOV = eNUM_ATU + 1
                    //   eNUM_ATU = STR(INT(eNUM_ATU),8,0)
                    //   eNU_1 = SUBSTR(ALLTRIM(eNUM_ATU),1,1)
                    //   eNU_2 = SUBSTR(ALLTRIM(eNUM_ATU),2,1)
                    //   eNU_3 = SUBSTR(ALLTRIM(eNUM_ATU),3,1)
                    //   eNU_4 = SUBSTR(ALLTRIM(eNUM_ATU),4,1)
                    //   eNU_5 = SUBSTR(ALLTRIM(eNUM_ATU),5,1)
                    //   eNU_6 = SUBSTR(ALLTRIM(eNUM_ATU),6,1)
                    //   eNU_7 = SUBSTR(ALLTRIM(eNUM_ATU),7,1)
                    //   eNU_8 = SUBSTR(ALLTRIM(eNUM_ATU),8,1)

                    //   eNU_1 = VAL(eNU_1) * 9
                    //   eNU_2 = VAL(eNU_2) * 8
                    //   eNU_3 = VAL(eNU_3) * 7
                    //   eNU_4 = VAL(eNU_4) * 6
                    //   eNU_5 = VAL(eNU_5) * 5
                    //   eNU_6 = VAL(eNU_6) * 4
                    //   eNU_7 = VAL(eNU_7) * 3
                    //   eNU_8 = VAL(eNU_8) * 2

                    //   eRESULTADO = 0
                    //   eRESULTADO = eNU_1+eNU_2+eNU_3+eNU_4+eNU_5+eNU_6+eNU_7+eNU_8

                    //   eRESTO = 0
                    //   eRESTO = MOD(eRESULTADO,11)

                    //   DO CASE
                    //      CASE eRESTO = 0
                    //         eDAC = 1
                    //      CASE eRESTO = 1
                    //         eDAC = 0
                    //      OTHERWISE
                    //         eDAC   = 0
                    //         eDAC   = 11 - eRESTO
                    //   ENDCASE

                    //   eDAC   = SUBSTR(ALLTRIM(eNUM_ATU),1,8)+ALLTRIM(STR(INT(eDAC)))

                    //   SELE 7
                    //   IF F_BLOQR()
                    //      REPLACE NUM_ATU WITH eNUM_NOV
                    //      eNUM_ATU = eNUM_NOV
                    //      UNLOCK
                    //   ENDIF
                    //   SELE 8
                    //ELSE
                    //   eDAC   = "000000000"
                    //ENDIF

                    //

                    if (protesto)
                    {
                        protestocodigo = "0610";
                        protestocodigo2 = prazoprotesto;
                    }
                    else
                    {
                        protestocodigo = "0300";
                        protestocodigo2 = "00";
                    }
                    // 

                    linharegistro1[i] =
                                    "102" + cnpjempresa + agencia + contacorrente.Substring(0, 9) + Srelib.replicate(" ", 6) + identificadorespaco + identificador + eDAC + Srelib.replicate(" ", 30) +
                                    "000" + Srelib.replicate(" ", 1) + protestocodigo2 + "101" + identificador + "00" +
                                    datavencimento + vlrparcela + "422" + Srelib.replicate(" ", 5) + "01" + "A" + dataemissao +
                                    protestocodigo + Srelib.replicate("0", 58) + tiposacado + cnpjempresa + nome.Substring(0, 40) +
                                    endereco.Substring(0, 40) + bairro.Substring(0, 10) + "  " + cep + cidade.Substring(0, 15) + estado.Substring(0, 2) +
                                    mensagem.Substring(0, 28) + "  " + Srelib.replicate(" ", 10) + numeroarquivo.Substring(1, 5) + Srelib.QStr0(numeroregistro, 6);


                    break;
                case "424":

                    if (msgautomatica)
                    {
                        //Mensagem de Multa Baseada na Taxa do Banco
                        mensagem = "MULTA " + Srelib.QStr0(multabanco, 2) + "% E COMISSAO APOS VENC." + Srelib.replicate(" ", 20);
                    }
                    // 
                    if (protesto)
                    {
                        protestocodigo = "06";
                        protestocodigo2 = prazoprotesto;
                    }

                    else
                    {
                        protestocodigo = "02";
                        protestocodigo2 = prazodevolucao;
                    }
                    //
                    linharegistro1[i] =
                                    "102" + cnpjempresa + agencia + contacorrente + Srelib.replicate(" ", 9) + identificadorespaco + identificador + Srelib.replicate(" ", 45) +
                                    "901" + Srelib.replicate(" ", 2) + identificador + datavencimento + vlrparcela + "424" + Srelib.replicate(" ", 5) + "01" + "A" +
                                    dataemissao + protestocodigo + Srelib.replicate("0", 60) + tiposacado + cnpjempresa + nome.Substring(0, 40) +
                                    endereco.Substring(0, 40) + bairro.Substring(0, 12) + cep + cidade.Substring(0, 15) + estado.Substring(0, 2) +
                                    Srelib.replicate(" ", 40) + protestocodigo2 + " " + Srelib.QStr0(numeroregistro, 6);


                    break;
                case "479":

                    if (msgautomatica)
                    {
                        //Mensagem de Multa Baseada na Taxa do Banco
                        mensagem = "MULTA " + Srelib.QStr0(multabanco, 2) + "% E COMISSAO APOS VENC." + Srelib.replicate(" ", 20);
                    }
                    //
                    // 
                    if (protesto)
                    {
                        protestocodigo = "01";
                        protestocodigo2 = prazoprotesto;
                    }

                    else
                    {
                        protestocodigo = "03";
                        protestocodigo2 = prazodevolucao;
                    }
                    // 
                    linharegistro1[i] =
                                    "102" + cnpjempresa + Srelib.replicate(" ", 20) + identificadorespaco + identificador + Srelib.replicate("0", 20) + " R$  " + Srelib.replicate(" ", 20) + "30100" + identificador +
                                    datavencimento + vlrparcela + "479" + Srelib.replicate(" ", 5) + "DMA" + dataemissao + protestocodigo + protestocodigo2 +
                                    Srelib.replicate("0", 13 + 6 + 13 + 13 + 13) + tiposacado + cnpjempresa + nome.Substring(0, 40) + endereco.Substring(0, 37) + Srelib.replicate(" ", 15) +
                                    cep + cidade.Substring(0, 15) + estado.Substring(0, 2) + mensagem.Substring(0, 30) + Srelib.replicate(" ", 3) + Srelib.QStr0(numeroregistro, 6);

                    break;
                case "641":

                    if (msgautomatica)
                    {
                        //Mensagem de Multa Baseada na Taxa do Banco
                        mensagem = "MULTA " + Srelib.QStr0(multabanco, 2) + "% E COMISSAO APOS VENC." + Srelib.replicate(" ", 20);
                    }
                    // 
                    if (protesto)
                    {
                        protestocodigo = "17";
                        protestocodigo2 = prazoprotesto;
                    }

                    else
                    {
                        protestocodigo = "16";
                        protestocodigo2 = prazodevolucao;
                    }
                    linharegistro1[i] =
                                    "102" + cnpjempresa + "000" + carteira.Substring(1, 2) + agencia + contacorrente + identificadorespaco + identificador +
                                    Srelib.replicate("0", 20) + Srelib.replicate(" ", 25) +
                                    "501" + Srelib.replicate(" ", 2) + identificador + datavencimento + vlrparcela + "0000000001N" +
                                    dataemissao + protestocodigo + Srelib.replicate("0", 60) + tiposacado + cnpjempresa + nome.Substring(0, 40) +
                                    endereco.Substring(0, 40) + bairro.Substring(0, 12) + cep + cidade.Substring(0, 15) + estado.Substring(0, 2) +
                                    mensagem.Substring(0, 40) + protestocodigo2 + "9" + Srelib.QStr0(numeroregistro, 6);

                    break;
                default:
                    linharegistro1[i] = "Erro Interno - Banco " + xBanco + " sem codificação para Registro, acione o suporte ou verifique se o banco está correto.";
                    break;
            }
            numeroregistro = Convert.ToString(Convert.ToInt64(numeroregistro) + 1).Trim();
            //Fim Registros


        }
    }

    private void GeraFooter(string xBanco,
                            string xconta,
                            string xtitulos,
                            string xvlrtitulos,
                            string xnumeroarquivo,
                            string xnumeroregistro,
                            ref string footerarquivo,
                            ref string footerarquivo2)
    {
        //
        xnumeroregistro = Srelib.QStr0(xnumeroregistro, 6);
        string ytitulos = xtitulos;
        string yvlrtitulos = xvlrtitulos;
        //
        if (xBanco != String.Empty)
        {
            switch (xBanco)
            {
                case "008":
                    // ytitulos tamanho 8
                    // yvlrtitulos tamanho 13 com 2 decimais sem ponto
                    if (ytitulos.Length != 8)
                    {
                        ytitulos = Srelib.QStr0("0", 8 - ytitulos.Length) + ytitulos;
                    }
                    if (yvlrtitulos.Length != 13)
                    {
                        yvlrtitulos = Srelib.QStr0("0", 13 - yvlrtitulos.Length) + yvlrtitulos;
                    }
                    //
                    footerarquivo = "91" + ytitulos + yvlrtitulos + Srelib.replicate(" ", 368) + xnumeroarquivo.Substring(2, 3) + xnumeroregistro;

                    break;
                case "151":
                    footerarquivo = "15100015" + Srelib.replicate(" ", 9) + xnumeroregistro + Srelib.replicate(" ", 217);
                    //
                    //2a. linha de Header
                    footerarquivo2 = "15199999" + "000001" + xnumeroregistro + "000000" + Srelib.replicate(" ", 205);

                    break;
                case "275":
                    // ytitulos tamanho 6
                    // yvlrtitulos tamanho 13 com 2 decimais sem ponto
                    if (ytitulos.Length != 6)
                    {
                        ytitulos = Srelib.QStr0("0", ytitulos.Length - 6) + ytitulos;
                    }
                    if (yvlrtitulos.Length != 13)
                    {
                        yvlrtitulos = Srelib.QStr0("0", yvlrtitulos.Length - 13) + yvlrtitulos;
                    }
                    footerarquivo = "9" + ytitulos + yvlrtitulos + Srelib.replicate(" ", 374) + xnumeroregistro;

                    break;
                case "356":
                    // ytitulos tamanho 6
                    // yvlrtitulos tamanho 13 com 2 decimais sem ponto
                    if (ytitulos.Length != 6)
                    {
                        ytitulos = Srelib.QStr0("0", 6 - ytitulos.Length) + ytitulos;
                    }
                    if (yvlrtitulos.Length != 13)
                    {
                        yvlrtitulos = Srelib.QStr0("0", 13 - yvlrtitulos.Length) + yvlrtitulos;
                    }
                    footerarquivo = "9" + ytitulos + yvlrtitulos + Srelib.replicate(" ", 374) + xnumeroregistro;
                    break;
                case "422":
                    // ytitulos tamanho 8
                    // yvlrtitulos tamanho 15 com 2 decimais sem ponto
                    //if (ytitulos.Length != 8)
                    //{
                    ytitulos = Srelib.QStr0("0", 8 - ytitulos.Length) + ytitulos;
                    //}
                    //if (yvlrtitulos.Length != 15)
                    //{
                    yvlrtitulos = Srelib.QStr0("0", 15 - yvlrtitulos.Length) + yvlrtitulos;
                    //}
                    //
                    footerarquivo = "91" + Srelib.replicate(" ", 367) + ytitulos + yvlrtitulos + xnumeroarquivo + xnumeroregistro;

                    break;
                default:
                    footerarquivo = "9" + Srelib.replicate(" ", 393) + xnumeroregistro;

                    break;
            }

        }
    }

    protected void ednomearquivo_TextChanged(object sender, EventArgs e)
    {
        ednomearquivo.Text = ednomearquivo.Text.ToUpper();
    }
}


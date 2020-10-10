using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FCobrancaRetorno : System.Web.UI.Page
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
            cbbanco.Items.Clear();
            uBanco.MontaComboBanco(cbbanco);
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
            btprocessa.Enabled = true;
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
        //Baixa de Registros
        //
        memoarquivo.Text = "";
        Boolean lOk = true;
        string tst = "";
        string IDBanco = "";
        string identificador = "";
        string nossonumero = "";
        string codigo = "";
        string codigocarteira = "";
        DateTime dtcredito = DateTime.Now;
        DateTime dtvencimento = DateTime.Now;
        string vlr_original = "0";
        string vlr_juros = "0";
        string vlr_pago = "0";
        string yproduto = "";
        string ygrupo = "";
        string ygrupounidade = "";
        string yparte = "";
        string[] linharegistro1 = new string[1000];
        string[] linharegistro2 = new string[1000];
        for (int i = 0; i < 1000; i++)
        {
            linharegistro1[i] = Srelib.replicate(" ", 420);
            linharegistro2[i] = Srelib.replicate(" ", 420);
        }
        //
        //CRITICAS

        if (lOk)
        {
            //CRIAÇÃO DA VARIÁVEL DE SESSÃO COM OS ELEMENTOS SELECIONADOS NO LOOKUP  ===============================================================================================================================================
            //Banco
            Session.Remove("cbbanco");
            if (cbbanco.Text != string.Empty)
            {
                Session.Add("cbbanco", cbbanco.Value.ToString().Trim());
                tst = cbbanco.Value.ToString().Trim();
                IDBanco = Srelib.QStr0(tst, 3);
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Nenhum Banco Selecionado!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Nenhum Banco Selecionado!', 'Atenção!')", true);
            }
        }
        //
        if (lOk)
        {
            //Carregamento
            string strPathFile = @edcaminho.Text.Trim() + ednomearquivo.Text.Trim() + "." + edextensao.Text.Trim();
            if (File.Exists(strPathFile))
            {
                Stream entrada = File.Open(strPathFile, FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                Int32 j = 0;
                while (linha != null)
                {
                    linha = leitor.ReadLine();
                    linharegistro1[j] = linha;

                }
                leitor.Close();
                entrada.Close();
            }
            else
            {
                lOk = false;
                edfeedback.Text = "Erro ao abrir o Arquivo! Carregamento Abortado! Verificar Pasta, Nome e Extensão.";
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Erro ao abrir o Arquivo! Carregamento Abortado! Verificar Pasta, Nome e Extensão.');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.error('Erro ao abrir o Arquivo! Carregamento Abortado! Verificar Pasta, Nome e Extensão!', 'Atenção!')", true);
            }
            //Fim Carregamento
        }
        //
        if (lOk)
        {
            for (int i = 0; i < 1000; i++)
            {
                //Loop Registros
                //
                //Baixa Automática

                //
                //Obs.: falta Ajuste das posições dos dados na linha//
                //

                if (IDBanco != String.Empty)
                {
                    switch (IDBanco)
                    {
                        case "001":
                            if ((linharegistro1[i].Substring(0, 2) == "02") ||
                                (linharegistro1[i].Substring(0, 2) == "06"))
                            {
                                //
                                codigo = linharegistro1[i].Substring(0, 2);
                                //Identificação do Registro / Nosso Numero
                                identificador = linharegistro1[i].Substring(0, 10);
                                nossonumero = linharegistro1[i].Substring(0, 10);
                                //Fim Identificação do Registro
                                //Dados de Entrada ou Baixa
                                codigocarteira = linharegistro1[i].Substring(0, 2);
                                dtcredito = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                dtvencimento = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                vlr_original = linharegistro1[i].Substring(0, 2);
                                vlr_juros = linharegistro1[i].Substring(0, 2);
                                vlr_pago = Convert.ToString(Convert.ToDouble(vlr_original) + Convert.ToDouble(vlr_juros));
                                //Fim Dados de Entrada ou Baixa
                                //
                                yproduto = identificador.Substring(0, 2);
                                ygrupo = identificador.Substring(2, 2);
                                ygrupounidade = identificador.Substring(4, 3);
                                yparte = identificador.Substring(7, 1);
                                //
                                memoarquivo.Text = identificador + Environment.NewLine;
                                //
                                //
                                if (linharegistro1[i].Substring(0, 2) == "02")
                                {
                                    //Entrada
                                    uParcelas.GravaNossoNumero(yproduto,
                                                               ygrupo,
                                                               ygrupounidade,
                                                               yparte,
                                                               dtvencimento.ToString().Substring(0, 10),
                                                               nossonumero);
                                    //Fim Entrada
                                }
                                else
                                {
                                    //Baixa
                                    uParcelas.GravaBaixaCobranca(yproduto,
                                                                 ygrupo,
                                                                 ygrupounidade,
                                                                 yparte,
                                                                 dtvencimento.ToString().Substring(0, 10),
                                                                 dtcredito.ToString().Substring(0, 10),
                                                                 nossonumero,
                                                                 uProduto.PegaProdutoConta(Convert.ToInt32(yproduto)),
                                                                 vlr_pago);
                                    //Fim Baixa
                                }
                            }
                            break;
                        case "008":
                            if ((linharegistro1[i].Substring(0, 2) == "02") ||
                                (linharegistro1[i].Substring(0, 2) == "06"))
                            {

                                //
                                codigo = linharegistro1[i].Substring(0, 2);
                                //Identificação do Registro / Nosso Numero
                                identificador = linharegistro1[i].Substring(0, 10);
                                nossonumero = linharegistro1[i].Substring(0, 10);
                                //Fim Identificação do Registro
                                //Dados de Entrada ou Baixa
                                codigocarteira = linharegistro1[i].Substring(0, 2);
                                dtcredito = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                dtvencimento = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                vlr_original = linharegistro1[i].Substring(0, 2);
                                vlr_juros = linharegistro1[i].Substring(0, 2);
                                vlr_pago = Convert.ToString(Convert.ToDouble(vlr_original) + Convert.ToDouble(vlr_juros));
                                //Fim Dados de Entrada ou Baixa
                                //
                                yproduto = identificador.Substring(0, 2);
                                ygrupo = identificador.Substring(2, 2);
                                ygrupounidade = identificador.Substring(4, 3);
                                yparte = identificador.Substring(7, 1);
                                //
                                memoarquivo.Text = identificador + Environment.NewLine;
                                //
                                //
                                if (linharegistro1[i].Substring(0, 2) == "02")
                                {
                                    //Entrada
                                    uParcelas.GravaNossoNumero(yproduto,
                                                               ygrupo,
                                                               ygrupounidade,
                                                               yparte,
                                                               dtvencimento.ToString().Substring(0, 10),
                                                               nossonumero);
                                    //Fim Entrada
                                }
                                else
                                {
                                    //Baixa
                                    uParcelas.GravaBaixaCobranca(yproduto,
                                                                 ygrupo,
                                                                 ygrupounidade,
                                                                 yparte,
                                                                 dtvencimento.ToString().Substring(0, 10),
                                                                 dtcredito.ToString().Substring(0, 10),
                                                                 nossonumero,
                                                                 uProduto.PegaProdutoConta(Convert.ToInt32(yproduto)),
                                                                 vlr_pago);
                                    //Fim Baixa
                                }
                            }
                            break;
                        case "033":
                            if ((linharegistro1[i].Substring(0, 2) == "02") ||
                                (linharegistro1[i].Substring(0, 2) == "06") ||
                                (linharegistro1[i].Substring(0, 2) == "15"))
                            {
                                //
                                codigo = linharegistro1[i].Substring(0, 2);
                                //Identificação do Registro / Nosso Numero
                                identificador = linharegistro1[i].Substring(0, 10);
                                nossonumero = linharegistro1[i].Substring(0, 10);
                                //Fim Identificação do Registro
                                //Dados de Entrada ou Baixa
                                codigocarteira = linharegistro1[i].Substring(0, 2);
                                dtcredito = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                dtvencimento = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                vlr_original = linharegistro1[i].Substring(0, 2);
                                vlr_juros = linharegistro1[i].Substring(0, 2);
                                vlr_pago = Convert.ToString(Convert.ToDouble(vlr_original) + Convert.ToDouble(vlr_juros));
                                //Fim Dados de Entrada ou Baixa
                                //
                                yproduto = identificador.Substring(0, 2);
                                ygrupo = identificador.Substring(2, 2);
                                ygrupounidade = identificador.Substring(4, 3);
                                yparte = identificador.Substring(7, 1);
                                //
                                memoarquivo.Text = identificador + Environment.NewLine;
                                //
                                //
                                if (linharegistro1[i].Substring(0, 2) == "02")
                                {
                                    //Entrada
                                    uParcelas.GravaNossoNumero(yproduto,
                                                               ygrupo,
                                                               ygrupounidade,
                                                               yparte,
                                                               dtvencimento.ToString().Substring(0, 10),
                                                               nossonumero);
                                    //Fim Entrada
                                }
                                else
                                {
                                    //Baixa
                                    uParcelas.GravaBaixaCobranca(yproduto,
                                                                 ygrupo,
                                                                 ygrupounidade,
                                                                 yparte,
                                                                 dtvencimento.ToString().Substring(0, 10),
                                                                 dtcredito.ToString().Substring(0, 10),
                                                                 nossonumero,
                                                                 uProduto.PegaProdutoConta(Convert.ToInt32(yproduto)),
                                                                 vlr_pago);
                                    //Fim Baixa
                                }
                            }
                            break;
                        case "104":
                            if ((linharegistro1[i].Substring(0, 2) == "01") ||
                                (linharegistro1[i].Substring(0, 2) == "21") ||
                                (linharegistro1[i].Substring(0, 2) == "22"))
                            {
                                //
                                codigo = linharegistro1[i].Substring(0, 2);
                                //Identificação do Registro / Nosso Numero
                                identificador = linharegistro1[i].Substring(0, 10);
                                nossonumero = linharegistro1[i].Substring(0, 10);
                                //Fim Identificação do Registro
                                //Dados de Entrada ou Baixa
                                codigocarteira = linharegistro1[i].Substring(0, 2);
                                dtcredito = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                dtvencimento = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                vlr_original = linharegistro1[i].Substring(0, 2);
                                vlr_juros = linharegistro1[i].Substring(0, 2);
                                vlr_pago = Convert.ToString(Convert.ToDouble(vlr_original) + Convert.ToDouble(vlr_juros));
                                //Fim Dados de Entrada ou Baixa
                                //
                                yproduto = identificador.Substring(0, 2);
                                ygrupo = identificador.Substring(2, 2);
                                ygrupounidade = identificador.Substring(4, 3);
                                yparte = identificador.Substring(7, 1);
                                //
                                memoarquivo.Text = identificador + Environment.NewLine;
                                //
                                //
                                if (linharegistro1[i].Substring(0, 2) == "02")
                                {
                                    //Entrada
                                    uParcelas.GravaNossoNumero(yproduto,
                                                               ygrupo,
                                                               ygrupounidade,
                                                               yparte,
                                                               dtvencimento.ToString().Substring(0, 10),
                                                               nossonumero);
                                    //Fim Entrada
                                }
                                else
                                {
                                    //Baixa
                                    uParcelas.GravaBaixaCobranca(yproduto,
                                                                 ygrupo,
                                                                 ygrupounidade,
                                                                 yparte,
                                                                 dtvencimento.ToString().Substring(0, 10),
                                                                 dtcredito.ToString().Substring(0, 10),
                                                                 nossonumero,
                                                                 uProduto.PegaProdutoConta(Convert.ToInt32(yproduto)),
                                                                 vlr_pago);
                                    //Fim Baixa
                                }
                            }
                            break;
                        case "215":
                            if ((linharegistro1[i].Substring(0, 2) == "02") ||
                                (linharegistro1[i].Substring(0, 2) == "06") ||
                                (linharegistro1[i].Substring(0, 2) == "08"))
                            {
                                //
                                codigo = linharegistro1[i].Substring(0, 2);
                                //Identificação do Registro / Nosso Numero
                                identificador = linharegistro1[i].Substring(0, 10);
                                nossonumero = linharegistro1[i].Substring(0, 10);
                                //Fim Identificação do Registro
                                //Dados de Entrada ou Baixa
                                codigocarteira = linharegistro1[i].Substring(0, 2);
                                dtcredito = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                dtvencimento = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                vlr_original = linharegistro1[i].Substring(0, 2);
                                vlr_juros = linharegistro1[i].Substring(0, 2);
                                vlr_pago = Convert.ToString(Convert.ToDouble(vlr_original) + Convert.ToDouble(vlr_juros));
                                //Fim Dados de Entrada ou Baixa
                                //
                                yproduto = identificador.Substring(0, 2);
                                ygrupo = identificador.Substring(2, 2);
                                ygrupounidade = identificador.Substring(4, 3);
                                yparte = identificador.Substring(7, 1);
                                //
                                memoarquivo.Text = identificador + Environment.NewLine;
                                //
                                //
                                if (linharegistro1[i].Substring(0, 2) == "02")
                                {
                                    //Entrada
                                    uParcelas.GravaNossoNumero(yproduto,
                                                               ygrupo,
                                                               ygrupounidade,
                                                               yparte,
                                                               dtvencimento.ToString().Substring(0, 10),
                                                               nossonumero);
                                    //Fim Entrada
                                }
                                else
                                {
                                    //Baixa
                                    uParcelas.GravaBaixaCobranca(yproduto,
                                                                 ygrupo,
                                                                 ygrupounidade,
                                                                 yparte,
                                                                 dtvencimento.ToString().Substring(0, 10),
                                                                 dtcredito.ToString().Substring(0, 10),
                                                                 nossonumero,
                                                                 uProduto.PegaProdutoConta(Convert.ToInt32(yproduto)),
                                                                 vlr_pago);
                                    //Fim Baixa
                                }
                            }
                            break;
                        case "230":
                            if ((linharegistro1[i].Substring(0, 2) == "02") ||
                                (linharegistro1[i].Substring(0, 2) == "06") ||
                                (linharegistro1[i].Substring(0, 2) == "08"))
                            {
                                //
                                codigo = linharegistro1[i].Substring(0, 2);
                                //Identificação do Registro / Nosso Numero
                                identificador = linharegistro1[i].Substring(0, 10);
                                nossonumero = linharegistro1[i].Substring(0, 10);
                                //Fim Identificação do Registro
                                //Dados de Entrada ou Baixa
                                codigocarteira = linharegistro1[i].Substring(0, 2);
                                dtcredito = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                dtvencimento = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                vlr_original = linharegistro1[i].Substring(0, 2);
                                vlr_juros = linharegistro1[i].Substring(0, 2);
                                vlr_pago = Convert.ToString(Convert.ToDouble(vlr_original) + Convert.ToDouble(vlr_juros));
                                //Fim Dados de Entrada ou Baixa
                                //
                                yproduto = identificador.Substring(0, 2);
                                ygrupo = identificador.Substring(2, 2);
                                ygrupounidade = identificador.Substring(4, 3);
                                yparte = identificador.Substring(7, 1);
                                //
                                memoarquivo.Text = identificador + Environment.NewLine;
                                //
                                //
                                if (linharegistro1[i].Substring(0, 2) == "02")
                                {
                                    //Entrada
                                    uParcelas.GravaNossoNumero(yproduto,
                                                               ygrupo,
                                                               ygrupounidade,
                                                               yparte,
                                                               dtvencimento.ToString().Substring(0, 10),
                                                               nossonumero);
                                    //Fim Entrada
                                }
                                else
                                {
                                    //Baixa
                                    uParcelas.GravaBaixaCobranca(yproduto,
                                                                 ygrupo,
                                                                 ygrupounidade,
                                                                 yparte,
                                                                 dtvencimento.ToString().Substring(0, 10),
                                                                 dtcredito.ToString().Substring(0, 10),
                                                                 nossonumero,
                                                                 uProduto.PegaProdutoConta(Convert.ToInt32(yproduto)),
                                                                 vlr_pago);
                                    //Fim Baixa
                                }
                            }
                            break;
                        case "237":
                            if ((linharegistro1[i].Substring(0, 2) == "02") ||
                                (linharegistro1[i].Substring(0, 2) == "06") ||
                                (linharegistro1[i].Substring(0, 2) == "08"))
                            {
                                //
                                codigo = linharegistro1[i].Substring(0, 2);
                                //Identificação do Registro / Nosso Numero
                                identificador = linharegistro1[i].Substring(0, 10);
                                nossonumero = linharegistro1[i].Substring(0, 10);
                                //Fim Identificação do Registro
                                //Dados de Entrada ou Baixa
                                codigocarteira = linharegistro1[i].Substring(0, 2);
                                dtcredito = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                dtvencimento = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                vlr_original = linharegistro1[i].Substring(0, 2);
                                vlr_juros = linharegistro1[i].Substring(0, 2);
                                vlr_pago = Convert.ToString(Convert.ToDouble(vlr_original) + Convert.ToDouble(vlr_juros));
                                //Fim Dados de Entrada ou Baixa
                                //
                                yproduto = identificador.Substring(0, 2);
                                ygrupo = identificador.Substring(2, 2);
                                ygrupounidade = identificador.Substring(4, 3);
                                yparte = identificador.Substring(7, 1);
                                //
                                memoarquivo.Text = identificador + Environment.NewLine;
                                //
                                //
                                if (linharegistro1[i].Substring(0, 2) == "02")
                                {
                                    //Entrada
                                    uParcelas.GravaNossoNumero(yproduto,
                                                               ygrupo,
                                                               ygrupounidade,
                                                               yparte,
                                                               dtvencimento.ToString().Substring(0, 10),
                                                               nossonumero);
                                    //Fim Entrada
                                }
                                else
                                {
                                    //Baixa
                                    uParcelas.GravaBaixaCobranca(yproduto,
                                                                 ygrupo,
                                                                 ygrupounidade,
                                                                 yparte,
                                                                 dtvencimento.ToString().Substring(0, 10),
                                                                 dtcredito.ToString().Substring(0, 10),
                                                                 nossonumero,
                                                                 uProduto.PegaProdutoConta(Convert.ToInt32(yproduto)),
                                                                 vlr_pago);
                                    //Fim Baixa
                                }
                            }
                            break;
                        case "275":
                            if ((linharegistro1[i].Substring(0, 2) == "02") ||
                                (linharegistro1[i].Substring(0, 2) == "06") ||
                                (linharegistro1[i].Substring(0, 2) == "08"))
                            {
                                //
                                codigo = linharegistro1[i].Substring(0, 2);
                                //Identificação do Registro / Nosso Numero
                                identificador = linharegistro1[i].Substring(0, 10);
                                nossonumero = linharegistro1[i].Substring(0, 10);
                                //Fim Identificação do Registro
                                //Dados de Entrada ou Baixa
                                codigocarteira = linharegistro1[i].Substring(0, 2);
                                dtcredito = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                dtvencimento = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                vlr_original = linharegistro1[i].Substring(0, 2);
                                vlr_juros = linharegistro1[i].Substring(0, 2);
                                vlr_pago = Convert.ToString(Convert.ToDouble(vlr_original) + Convert.ToDouble(vlr_juros));
                                //Fim Dados de Entrada ou Baixa
                                //
                                yproduto = identificador.Substring(0, 2);
                                ygrupo = identificador.Substring(2, 2);
                                ygrupounidade = identificador.Substring(4, 3);
                                yparte = identificador.Substring(7, 1);
                                //
                                memoarquivo.Text = identificador + Environment.NewLine;
                                //
                                //
                                if (linharegistro1[i].Substring(0, 2) == "02")
                                {
                                    //Entrada
                                    uParcelas.GravaNossoNumero(yproduto,
                                                               ygrupo,
                                                               ygrupounidade,
                                                               yparte,
                                                               dtvencimento.ToString().Substring(0, 10),
                                                               nossonumero);
                                    //Fim Entrada
                                }
                                else
                                {
                                    //Baixa
                                    uParcelas.GravaBaixaCobranca(yproduto,
                                                                 ygrupo,
                                                                 ygrupounidade,
                                                                 yparte,
                                                                 dtvencimento.ToString().Substring(0, 10),
                                                                 dtcredito.ToString().Substring(0, 10),
                                                                 nossonumero,
                                                                 uProduto.PegaProdutoConta(Convert.ToInt32(yproduto)),
                                                                 vlr_pago);
                                    //Fim Baixa
                                }
                            }
                            break;
                        case "291":
                            if ((linharegistro1[i].Substring(0, 2) == "02") ||
                                (linharegistro1[i].Substring(0, 2) == "06"))
                            {
                                //
                                codigo = linharegistro1[i].Substring(0, 2);
                                //Identificação do Registro / Nosso Numero
                                identificador = linharegistro1[i].Substring(0, 10);
                                nossonumero = linharegistro1[i].Substring(0, 10);
                                //Fim Identificação do Registro
                                //Dados de Entrada ou Baixa
                                codigocarteira = linharegistro1[i].Substring(0, 2);
                                dtcredito = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                dtvencimento = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                vlr_original = linharegistro1[i].Substring(0, 2);
                                vlr_juros = linharegistro1[i].Substring(0, 2);
                                vlr_pago = Convert.ToString(Convert.ToDouble(vlr_original) + Convert.ToDouble(vlr_juros));
                                //Fim Dados de Entrada ou Baixa
                                //
                                yproduto = identificador.Substring(0, 2);
                                ygrupo = identificador.Substring(2, 2);
                                ygrupounidade = identificador.Substring(4, 3);
                                yparte = identificador.Substring(7, 1);
                                //
                                memoarquivo.Text = identificador + Environment.NewLine;
                                //
                                //
                                if (linharegistro1[i].Substring(0, 2) == "02")
                                {
                                    //Entrada
                                    uParcelas.GravaNossoNumero(yproduto,
                                                               ygrupo,
                                                               ygrupounidade,
                                                               yparte,
                                                               dtvencimento.ToString().Substring(0, 10),
                                                               nossonumero);
                                    //Fim Entrada
                                }
                                else
                                {
                                    //Baixa
                                    uParcelas.GravaBaixaCobranca(yproduto,
                                                                 ygrupo,
                                                                 ygrupounidade,
                                                                 yparte,
                                                                 dtvencimento.ToString().Substring(0, 10),
                                                                 dtcredito.ToString().Substring(0, 10),
                                                                 nossonumero,
                                                                 uProduto.PegaProdutoConta(Convert.ToInt32(yproduto)),
                                                                 vlr_pago);
                                    //Fim Baixa
                                }
                            }
                            break;
                        case "341":
                            if ((linharegistro1[i].Substring(0, 2) == "02") ||
                                (linharegistro1[i].Substring(0, 2) == "06") ||
                                (linharegistro1[i].Substring(0, 2) == "07") ||
                                (linharegistro1[i].Substring(0, 2) == "08"))
                            {
                                //
                                codigo = linharegistro1[i].Substring(0, 2);
                                //Identificação do Registro / Nosso Numero
                                identificador = linharegistro1[i].Substring(0, 10);
                                nossonumero = linharegistro1[i].Substring(0, 10);
                                //Fim Identificação do Registro
                                //Dados de Entrada ou Baixa
                                codigocarteira = linharegistro1[i].Substring(0, 2);
                                dtcredito = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                dtvencimento = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                vlr_original = linharegistro1[i].Substring(0, 2);
                                vlr_juros = linharegistro1[i].Substring(0, 2);
                                vlr_pago = Convert.ToString(Convert.ToDouble(vlr_original) + Convert.ToDouble(vlr_juros));
                                //Fim Dados de Entrada ou Baixa
                                //
                                yproduto = identificador.Substring(0, 2);
                                ygrupo = identificador.Substring(2, 2);
                                ygrupounidade = identificador.Substring(4, 3);
                                yparte = identificador.Substring(7, 1);
                                //
                                memoarquivo.Text = identificador + Environment.NewLine;
                                //
                                //
                                if (linharegistro1[i].Substring(0, 2) == "02")
                                {
                                    //Entrada
                                    uParcelas.GravaNossoNumero(yproduto,
                                                               ygrupo,
                                                               ygrupounidade,
                                                               yparte,
                                                               dtvencimento.ToString().Substring(0, 10),
                                                               nossonumero);
                                    //Fim Entrada
                                }
                                else
                                {
                                    //Baixa
                                    uParcelas.GravaBaixaCobranca(yproduto,
                                                                 ygrupo,
                                                                 ygrupounidade,
                                                                 yparte,
                                                                 dtvencimento.ToString().Substring(0, 10),
                                                                 dtcredito.ToString().Substring(0, 10),
                                                                 nossonumero,
                                                                 uProduto.PegaProdutoConta(Convert.ToInt32(yproduto)),
                                                                 vlr_pago);
                                    //Fim Baixa
                                }
                            }
                            break;
                        case "409":
                            if ((linharegistro1[i].Substring(0, 2) == "02") ||
                                (linharegistro1[i].Substring(0, 2) == "06") ||
                                (linharegistro1[i].Substring(0, 2) == "98") ||
                                (linharegistro1[i].Substring(0, 2) == "99"))
                            {
                                //
                                codigo = linharegistro1[i].Substring(0, 2);
                                //Identificação do Registro / Nosso Numero
                                identificador = linharegistro1[i].Substring(0, 10);
                                nossonumero = linharegistro1[i].Substring(0, 10);
                                //Fim Identificação do Registro
                                //Dados de Entrada ou Baixa
                                codigocarteira = linharegistro1[i].Substring(0, 2);
                                dtcredito = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                dtvencimento = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                vlr_original = linharegistro1[i].Substring(0, 2);
                                vlr_juros = linharegistro1[i].Substring(0, 2);
                                vlr_pago = Convert.ToString(Convert.ToDouble(vlr_original) + Convert.ToDouble(vlr_juros));
                                //Fim Dados de Entrada ou Baixa
                                //
                                yproduto = identificador.Substring(0, 2);
                                ygrupo = identificador.Substring(2, 2);
                                ygrupounidade = identificador.Substring(4, 3);
                                yparte = identificador.Substring(7, 1);
                                //
                                memoarquivo.Text = identificador + Environment.NewLine;
                                //
                                //
                                if (linharegistro1[i].Substring(0, 2) == "02")
                                {
                                    //Entrada
                                    uParcelas.GravaNossoNumero(yproduto,
                                                               ygrupo,
                                                               ygrupounidade,
                                                               yparte,
                                                               dtvencimento.ToString().Substring(0, 10),
                                                               nossonumero);
                                    //Fim Entrada
                                }
                                else
                                {
                                    //Baixa
                                    uParcelas.GravaBaixaCobranca(yproduto,
                                                                 ygrupo,
                                                                 ygrupounidade,
                                                                 yparte,
                                                                 dtvencimento.ToString().Substring(0, 10),
                                                                 dtcredito.ToString().Substring(0, 10),
                                                                 nossonumero,
                                                                 uProduto.PegaProdutoConta(Convert.ToInt32(yproduto)),
                                                                 vlr_pago);
                                    //Fim Baixa
                                }
                            }
                            break;
                        case "422":
                            if ((linharegistro1[i].Substring(0, 2) == "02") ||
                                (linharegistro1[i].Substring(0, 2) == "06") ||
                                (linharegistro1[i].Substring(0, 2) == "07") ||
                                (linharegistro1[i].Substring(0, 2) == "15"))
                            {
                                //
                                codigo = linharegistro1[i].Substring(0, 2);
                                //Identificação do Registro / Nosso Numero
                                identificador = linharegistro1[i].Substring(0, 10);
                                nossonumero = linharegistro1[i].Substring(0, 10);
                                //Fim Identificação do Registro
                                //Dados de Entrada ou Baixa
                                codigocarteira = linharegistro1[i].Substring(0, 2);
                                dtcredito = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                dtvencimento = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                vlr_original = linharegistro1[i].Substring(0, 2);
                                vlr_juros = linharegistro1[i].Substring(0, 2);
                                vlr_pago = Convert.ToString(Convert.ToDouble(vlr_original) + Convert.ToDouble(vlr_juros));
                                //Fim Dados de Entrada ou Baixa
                                //
                                yproduto = identificador.Substring(0, 2);
                                ygrupo = identificador.Substring(2, 2);
                                ygrupounidade = identificador.Substring(4, 3);
                                yparte = identificador.Substring(7, 1);
                                //
                                memoarquivo.Text = identificador + Environment.NewLine;
                                //
                                //
                                if (linharegistro1[i].Substring(0, 2) == "02")
                                {
                                    //Entrada
                                    uParcelas.GravaNossoNumero(yproduto,
                                                               ygrupo,
                                                               ygrupounidade,
                                                               yparte,
                                                               dtvencimento.ToString().Substring(0, 10),
                                                               nossonumero);
                                    //Fim Entrada
                                }
                                else
                                {
                                    //Baixa
                                    uParcelas.GravaBaixaCobranca(yproduto,
                                                                 ygrupo,
                                                                 ygrupounidade,
                                                                 yparte,
                                                                 dtvencimento.ToString().Substring(0, 10),
                                                                 dtcredito.ToString().Substring(0, 10),
                                                                 nossonumero,
                                                                 uProduto.PegaProdutoConta(Convert.ToInt32(yproduto)),
                                                                 vlr_pago);
                                    //Fim Baixa
                                }
                            }
                            break;
                        case "424":
                            if ((linharegistro1[i].Substring(0, 2) == "02") ||
                                (linharegistro1[i].Substring(0, 2) == "06") ||
                                (linharegistro1[i].Substring(0, 2) == "15"))
                            {
                                //
                                codigo = linharegistro1[i].Substring(0, 2);
                                //Identificação do Registro / Nosso Numero
                                identificador = linharegistro1[i].Substring(0, 10);
                                nossonumero = linharegistro1[i].Substring(0, 10);
                                //Fim Identificação do Registro
                                //Dados de Entrada ou Baixa
                                codigocarteira = linharegistro1[i].Substring(0, 2);
                                dtcredito = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                dtvencimento = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                vlr_original = linharegistro1[i].Substring(0, 2);
                                vlr_juros = linharegistro1[i].Substring(0, 2);
                                vlr_pago = Convert.ToString(Convert.ToDouble(vlr_original) + Convert.ToDouble(vlr_juros));
                                //Fim Dados de Entrada ou Baixa
                                //
                                yproduto = identificador.Substring(0, 2);
                                ygrupo = identificador.Substring(2, 2);
                                ygrupounidade = identificador.Substring(4, 3);
                                yparte = identificador.Substring(7, 1);
                                //
                                memoarquivo.Text = identificador + Environment.NewLine;
                                //
                                //
                                if (linharegistro1[i].Substring(0, 2) == "02")
                                {
                                    //Entrada
                                    uParcelas.GravaNossoNumero(yproduto,
                                                               ygrupo,
                                                               ygrupounidade,
                                                               yparte,
                                                               dtvencimento.ToString().Substring(0, 10),
                                                               nossonumero);
                                    //Fim Entrada
                                }
                                else
                                {
                                    //Baixa
                                    uParcelas.GravaBaixaCobranca(yproduto,
                                                                 ygrupo,
                                                                 ygrupounidade,
                                                                 yparte,
                                                                 dtvencimento.ToString().Substring(0, 10),
                                                                 dtcredito.ToString().Substring(0, 10),
                                                                 nossonumero,
                                                                 uProduto.PegaProdutoConta(Convert.ToInt32(yproduto)),
                                                                 vlr_pago);
                                    //Fim Baixa
                                }
                            }
                            break;
                        case "641":
                            if ((linharegistro1[i].Substring(0, 2) == "02") ||
                                (linharegistro1[i].Substring(0, 2) == "06") ||
                                (linharegistro1[i].Substring(0, 2) == "15") ||
                                (linharegistro1[i].Substring(0, 2) == "16") ||
                                (linharegistro1[i].Substring(0, 2) == "17"))
                            {
                                //
                                codigo = linharegistro1[i].Substring(0, 2);
                                //Identificação do Registro / Nosso Numero
                                identificador = linharegistro1[i].Substring(0, 10);
                                nossonumero = linharegistro1[i].Substring(0, 10);
                                //Fim Identificação do Registro
                                //Dados de Entrada ou Baixa
                                codigocarteira = linharegistro1[i].Substring(0, 2);
                                dtcredito = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                dtvencimento = Convert.ToDateTime(linharegistro1[i].Substring(0, 10));
                                vlr_original = linharegistro1[i].Substring(0, 2);
                                vlr_juros = linharegistro1[i].Substring(0, 2);
                                vlr_pago = Convert.ToString(Convert.ToDouble(vlr_original) + Convert.ToDouble(vlr_juros));
                                //Fim Dados de Entrada ou Baixa
                                //
                                yproduto = identificador.Substring(0, 2);
                                ygrupo = identificador.Substring(2, 2);
                                ygrupounidade = identificador.Substring(4, 3);
                                yparte = identificador.Substring(7, 1);
                                //
                                memoarquivo.Text = identificador + Environment.NewLine;
                                //
                                //
                                if (linharegistro1[i].Substring(0, 2) == "02")
                                {
                                    //Entrada
                                    uParcelas.GravaNossoNumero(yproduto,
                                                               ygrupo,
                                                               ygrupounidade,
                                                               yparte,
                                                               dtvencimento.ToString().Substring(0, 10),
                                                               nossonumero);
                                    //Fim Entrada
                                }
                                else
                                {
                                    //Baixa
                                    uParcelas.GravaBaixaCobranca(yproduto,
                                                                 ygrupo,
                                                                 ygrupounidade,
                                                                 yparte,
                                                                 dtvencimento.ToString().Substring(0, 10),
                                                                 dtcredito.ToString().Substring(0, 10),
                                                                 nossonumero,
                                                                 uProduto.PegaProdutoConta(Convert.ToInt32(yproduto)),
                                                                 vlr_pago);
                                    //Fim Baixa
                                }
                            }
                            break;
                        default:
                            edfeedback.Text = "Erro Interno - Banco " + IDBanco + " sem codificação para Baixa, acione o suporte ou verifique se o banco está correto.";

                            break;
                    }

                    //Fim Baixa Automática
                }
                //Fim Loop
            }
        }

        if (lOk)
        {
            // CRIA LOG ===============================================================================================================================================
            fwObs_Log = "COBRANÇA RETORNO: " + cbbanco.Value.ToString() + " ARQUIVO: " + ednomearquivo.Text.Trim();
            //
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ), 
                                         new SqlParameter("@tabela"   , fWtabela                              ),
                                         new SqlParameter("@operacao" , "PARCELAS"                            ),
                                         new SqlParameter("@obs"      , "COBRANÇA RETORNO"                    ),
                                         new SqlParameter("@acao"     , fwObs_Log                             ) };
            uLog.MakeLog(param_log);
            // FIM CRIA LOG ===============================================================================================================================================
            //
            btprocessa.Enabled = false;
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
                edcaminho.Text = uBanco.PegaCaminhoRetorno(IDBanco);
                edextensao.Text = uBanco.PegaExtensaoRetorno(IDBanco);
                edcaminho.Text = edcaminho.Text.ToUpper();
                edextensao.Text = edextensao.Text.ToUpper();
                //
                btcarrega.Enabled = true;
                btprocessa.Enabled = false;
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
            }

        }

    }
    protected void btcarrega_Click(object sender, EventArgs e)
    {
        //Carregar Arquivo
        //string pulalinha = Environment.NewLine;
        string strPathFile = @edcaminho.Text.Trim() + ednomearquivo.Text.Trim() + "." + edextensao.Text.Trim();
        if (File.Exists(strPathFile))
        {
            Stream entrada = File.Open(strPathFile, FileMode.Open);
            StreamReader leitor = new StreamReader(entrada);
            string linha = leitor.ReadLine();
            memoarquivo.Text += linha + Environment.NewLine;
            while (linha != null)
            {
                linha = leitor.ReadLine();
                memoarquivo.Text += linha + Environment.NewLine;

            }
            leitor.Close();
            entrada.Close();
            btprocessa.Enabled = true;
            edfeedback.Text = "Caso existam registros, clique no Botão Processa para efetuar a baixa automática";
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Carregamento Concluído!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.success('Carregamento Concluído!', 'Atenção!')", true);
        }
        else
        {
            btprocessa.Enabled = false;
            edfeedback.Text = "Arquivo(s) Não Encontrado! Verificar Pasta, Nome e Extensão.";
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Arquivo(s) Não Encontrado! Verificar Pasta, Nome e Extensão.');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Arquivo(s) Não Encontrado! Verificar Pasta, Nome e Extensão!', 'Atenção!')", true);
        }
        //Fim Carregar Arquivo
        //

    }
}


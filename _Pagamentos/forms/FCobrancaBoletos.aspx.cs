using BoletoNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;


public partial class FCobrancaBoletos : System.Web.UI.Page
{
    DataSet dsbancos;
    List<object> selectedValues;
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

        string vencimento = "10/01/2016";
        String valorBoleto = "1000.00";
        String numeroDocumento = "B20005446";
        //cedente         
        String cedente_codigo = "1111111";
        String cedente_nossoNumeroBoleto = "22222222";
        String cedente_cpfCnpj = "123.456.789-01";
        String cedente_nome = "PAULO FREIRE - FOUR FREIRES INF.";
        String cedente_agencia = "1000";
        String cedente_conta = "22507";
        String cedente_digitoConta = "6";
        //sacado
        String sacado_cpfCnpj = "000.000.000-00";
        String sacado_nome = "Airam Miranda de Almeida";
        String sacado_endereco = "Rua Iraçi Luchina, 62";
        String sacado_bairro = "Bairro Central";
        String sacado_cidade = "Rio de Janeiro";
        String sacado_cep = "23080-600";
        String sacado_uf = "RJ";
        Cedente cedente = new Cedente(cedente_cpfCnpj, cedente_nome, cedente_agencia, cedente_conta, cedente_digitoConta);
        cedente.Codigo = cedente_codigo;
        Boleto boleto = new Boleto(Convert.ToDateTime(vencimento),
                        Convert.ToDecimal(valorBoleto), "109",
                        cedente_nossoNumeroBoleto, cedente);
        boleto.NumeroDocumento = numeroDocumento;
        Sacado sacado = new Sacado(sacado_cpfCnpj, sacado_nome);
        boleto.Sacado = sacado;
        boleto.Sacado.Endereco.End = sacado_endereco;
        boleto.Sacado.Endereco.Bairro = sacado_bairro;
        boleto.Sacado.Endereco.Cidade = sacado_cidade;
        boleto.Sacado.Endereco.CEP = sacado_cep;
        boleto.Sacado.Endereco.UF = sacado_uf;
        Instrucao_Itau instrucao = new Instrucao_Itau();
        instrucao.Descricao = "Não Receber após o vencimento";
        boleto.Instrucoes.Add(instrucao);
        EspecieDocumento_Itau especie = new EspecieDocumento_Itau("99");
        boleto.EspecieDocumento = especie;
        BoletoBancario boleto_bancario = new BoletoBancario();
        boleto_bancario.CodigoBanco = 341;
        boleto_bancario.Boleto = boleto;
        boleto_bancario.MostrarCodigoCarteira = true;
        boleto_bancario.Boleto.Valida();
        boleto_bancario.MostrarComprovanteEntrega = false;
        
        //
        //pnl_dados.Visible = false;
        //
        //return boletoBancario.MontaHtmlEmbedded()
        //
        pnl_boleto.Controls.Add(boleto_bancario);

        //ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( '" + boleto_bancario.MontaHtml() + "', null, 'height=755,width=900,status=yes,resizable=yes,menubar=yes,location=yes' );", true);



        //
        // CRIA LOG ===============================================================================================================================================
        fwObs_Log = "BOLETOS: ";// +cbbanco.Value.ToString();
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ), 
                                         new SqlParameter("@tabela"   , fWtabela                              ),
                                         new SqlParameter("@operacao" , "PARCELAS"                            ),
                                         new SqlParameter("@obs"      , "GERAÇÃO BOLETOS"                     ),
                                         new SqlParameter("@acao"     , fwObs_Log                             ) };
        uLog.MakeLog(param_log);
        // FIM CRIA LOG ===============================================================================================================================================
        //
        //
        btprocessa.Enabled = false;
        //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Configuração Registrada!');", true);

    }


}

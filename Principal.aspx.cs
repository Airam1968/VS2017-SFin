using DevExpress.Web.ASPxTreeView;
using System;
using System.Web;
using System.Web.UI;


public partial class Principal : System.Web.UI.Page
{
    Boolean Valida01 = false;
    Boolean Valida02 = false;
    Boolean Valida03 = false;
    Boolean Valida04 = false;
    Boolean Valida05 = false;
    Boolean Valida06 = false;
    Boolean Valida07 = false;
    Boolean Valida08 = false;
    Boolean Valida09 = false;
    Boolean Valida10 = false;
    Boolean Valida11 = false;
    Boolean Valida12 = false;
    Boolean Valida13 = false;
    Boolean Valida14 = false;
    Boolean Valida15 = false;
    //
    Boolean Cnpj_valido = false;                                    //Cnpj Válido para uso do Sistema
    Boolean Cnpj_expirado = true;                                   //Cnpj Válido prazo de expiração de uso
    string Cnpj_corrente = "";                                      //Cnpj Corrente na empresa Matriz
    DateTime Data_Limite = Convert.ToDateTime("20/01/2020");        //Data Limite para Locações
    DateTime Data_Limite_Hard = Convert.ToDateTime("20/02/2019");   //Data Limite para Locações de Risco
    //

    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetExpires(DateTime.Now);
        Response.Cache.SetNoServerCaching();
        Response.Cache.SetNoStore();

        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Response.Redirect("~\\LoginTimeOut.aspx");
        }

        if (!Page.IsPostBack)
        {
            //////////////////////////////////////////////////////////
            //Validação Sistema via CNPJ
            Cnpj_corrente = uEmpresa.PegaCnpj(uEmpresa.PegaMatriz());
            Cnpj_corrente = Srelib.QStr0(Cnpj_corrente, 14);
            switch (Cnpj_corrente)
            {
                case "02078733000174": Cnpj_valido = true; break;      //SIMBOLO
                case "13305470000105": Cnpj_valido = true; break;      //GITANO
                case "51665396000127": Cnpj_valido = true; break;      //CASTOR ENGENHARIA E COMÉRCIO
                case "62107453000179": Cnpj_valido = true; break;      //DADO SJC
                case "01516542000184": Cnpj_valido = true; break;      //DADO SP
                case "01723214000159": Cnpj_valido = true; break;      //TREVILLA//DADO
                case "02852392000142": Cnpj_valido = true; break;      //SÓLIDA DO VALE
                case "04060621000111": Cnpj_valido = true; break;      //AJ DE LIMA ME//SOLIDA
                case "06983112000196": Cnpj_valido = true; break;      //DELLY//SOLIDA
                case "12407984000109": Cnpj_valido = true; break;      //FAGOMES//VIENA
                case "15274945000179": Cnpj_valido = true; break;      //FAGOMES//LUTÉCIA
                case "00915210000100": Cnpj_valido = true; break;      //TERRA SIMÃO
                case "49467137000140": Cnpj_valido = true; break;      //APEMA SP
                case "03326860000108": Cnpj_valido = true; break;      //NET EMPREENDIMENTOS
            }
            //////////////////////////////////////////////////////////
            //Fim Validação Sistema via CNPJ
            //
            //////////////////////////////////////////////////////////
            //Validação Sistema via CNPJ Expirado
            //Licenciamento Definitivo (Venda)
            switch (Cnpj_corrente)
            {
                case "02078733000174": Cnpj_expirado = false; break;      //SIMBOLO
                case "13305470000105": Cnpj_expirado = false; break;      //GITANO
                case "51665396000127": Cnpj_expirado = false; break;      //CASTOR ENGENHARIA E COMÉRCIO
                case "62107453000179": Cnpj_expirado = false; break;      //DADO SJC
                case "01516542000184": Cnpj_expirado = false; break;      //DADO SP
                case "01723214000159": Cnpj_expirado = false; break;      //TREVILLA//DADO
                case "00915210000100": Cnpj_expirado = false; break;      //TERRA SIMÃO
            }
            //
            //Licenciamento Temporário (Locação)
            switch (Cnpj_corrente)
            {
                case "02852392000142": if (DateTime.Now < Data_Limite) { Cnpj_expirado = false; }; break;       //SÓLIDA DO VALE
                case "04060621000111": if (DateTime.Now < Data_Limite) { Cnpj_expirado = false; }; break;       //AJ DE LIMA ME//SOLIDA
                case "06983112000196": if (DateTime.Now < Data_Limite) { Cnpj_expirado = false; }; break;       //DELLY//SOLIDA
                case "49467137000140": if (DateTime.Now < Data_Limite) { Cnpj_expirado = false; }; break;       //APEMA SP
                case "03326860000108": if (DateTime.Now < Data_Limite_Hard) { Cnpj_expirado = false; }; break;  //NET EMPREENDIMENTOS
            }

            //////////////////////////////////////////////////////////
            //Fim Validação Sistema via CNPJ Expirado

            if ((Cnpj_valido) && (!Cnpj_expirado))
            {
                string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
                //string Msg_desenvolvimento = "Opção em desenvolvimento, Desabilitada.";
                //
                if (((Boolean)Session["lMaster"] == true))
                {
                    //////////////////////////////////////////////////////////
                    //Validação Master
                    Valida01 = true;
                    Valida02 = true;
                    Valida03 = true;
                    Valida04 = true;
                    Valida05 = true;
                    Valida06 = true;
                    Valida07 = true;
                    Valida08 = true;
                    Valida09 = true;
                    Valida10 = true;
                    Valida11 = true;
                    Valida12 = true;
                    Valida13 = true;
                    Valida14 = true;
                    Valida15 = true;
                }
                else
                {
                    //////////////////////////////////////////////////////////
                    //Validação Modulos via permissão de acesso - Menu Principal

                    Valida01 = SreDblib.TemPermissao("001.001.000.000", (String)Session["CodUsuario"]); //Favoritos - Propostas
                    Valida02 = SreDblib.TemPermissao("001.002.000.000", (String)Session["CodUsuario"]); //Clientes
                    Valida03 = SreDblib.TemPermissao("001.003.000.000", (String)Session["CodUsuario"]); //Produtos
                    Valida04 = SreDblib.TemPermissao("001.004.000.000", (String)Session["CodUsuario"]); //Vendas
                    Valida05 = SreDblib.TemPermissao("001.005.000.000", (String)Session["CodUsuario"]); //Pagamentos
                    Valida06 = SreDblib.TemPermissao("001.006.000.000", (String)Session["CodUsuario"]); //ContasaPagar
                    Valida07 = SreDblib.TemPermissao("001.007.000.000", (String)Session["CodUsuario"]); //ContasaReceber
                    Valida08 = SreDblib.TemPermissao("001.008.000.000", (String)Session["CodUsuario"]); //Bancos
                    Valida09 = SreDblib.TemPermissao("001.009.000.000", (String)Session["CodUsuario"]); //Fluxo Caixa
                    Valida10 = SreDblib.TemPermissao("001.010.000.000", (String)Session["CodUsuario"]); //Utilitarios -> Contábil
                    Valida11 = SreDblib.TemPermissao("001.011.000.000", (String)Session["CodUsuario"]); //Config
                    Valida12 = SreDblib.TemPermissao("001.012.000.000", (String)Session["CodUsuario"]); //Ajuda
                    Valida13 = SreDblib.TemPermissao("001.013.000.000", (String)Session["CodUsuario"]); //Empresa
                    Valida14 = SreDblib.TemPermissao("001.014.000.000", (String)Session["CodUsuario"]); //Juridico
                    Valida15 = SreDblib.TemPermissao("001.015.000.000", (String)Session["CodUsuario"]); //Obras
                    //
                }
                //
                //Aplicação das Permissões do Usuário
                //
                //Favoritos -> Propostas
                TreeViewPrincipal.Nodes.FindByName("Propostas").Enabled = Valida01;
                if (!Valida01)
                    TreeViewPrincipal.Nodes.FindByName("Propostas").ToolTip = Msg_acesso;
                //
                //Clientes
                TreeViewPrincipal.Nodes.FindByName("Clientes").Enabled = Valida02;
                if (!Valida02)
                    TreeViewPrincipal.Nodes.FindByName("Clientes").ToolTip = Msg_acesso;
                //
                //Produtos
                TreeViewPrincipal.Nodes.FindByName("Produtos").Enabled = Valida03;
                if (!Valida03)
                    TreeViewPrincipal.Nodes.FindByName("Produtos").ToolTip = Msg_acesso;
                //
                //Vendas
                TreeViewPrincipal.Nodes.FindByName("Vendas").Enabled = Valida04;
                if (!Valida04)
                    TreeViewPrincipal.Nodes.FindByName("Vendas").ToolTip = Msg_acesso;
                //
                //Pagamentos
                TreeViewPrincipal.Nodes.FindByName("Pagamentos").Enabled = Valida05;
                if (!Valida05)
                    TreeViewPrincipal.Nodes.FindByName("Pagamentos").ToolTip = Msg_acesso;
                //
                //ContasaPagar
                TreeViewPrincipal.Nodes.FindByName("ContasaPagar").Enabled = Valida06;
                if (!Valida06)
                    TreeViewPrincipal.Nodes.FindByName("ContasaPagar").ToolTip = Msg_acesso;
                //
                //ContasaReceber
                TreeViewPrincipal.Nodes.FindByName("ContasaReceber").Enabled = Valida07;
                if (!Valida07)
                    TreeViewPrincipal.Nodes.FindByName("ContasaReceber").ToolTip = Msg_acesso;
                //
                //Bancos
                TreeViewPrincipal.Nodes.FindByName("Bancos").Enabled = Valida08;
                if (!Valida08)
                    TreeViewPrincipal.Nodes.FindByName("Bancos").ToolTip = Msg_acesso;
                //
                //Fluxo Caixa
                TreeViewPrincipal.Nodes.FindByName("FluxoCaixa").Enabled = Valida09;
                if (!Valida09)
                    TreeViewPrincipal.Nodes.FindByName("FluxoCaixa").ToolTip = Msg_acesso;
                //
                //Contábil
                TreeViewPrincipal.Nodes.FindByName("Contabil").Enabled = Valida10;
                if (!Valida10)
                    TreeViewPrincipal.Nodes.FindByName("Contabil").ToolTip = Msg_acesso;
                //
                //Config
                TreeViewPrincipal.Nodes.FindByName("Config").Enabled = Valida11;
                if (!Valida11)
                    TreeViewPrincipal.Nodes.FindByName("Config").ToolTip = Msg_acesso;
                //
                //Ajuda
                TreeViewPrincipal.Nodes.FindByName("Ajuda").Enabled = Valida12;
                if (!Valida12)
                    TreeViewPrincipal.Nodes.FindByName("Ajuda").ToolTip = Msg_acesso;
                //
                //Empresa
                TreeViewPrincipal.Nodes.FindByName("Empresa").Enabled = Valida13;
                if (!Valida13)
                    TreeViewPrincipal.Nodes.FindByName("Empresa").ToolTip = Msg_acesso;
                //
                //Juridico
                TreeViewPrincipal.Nodes.FindByName("Juridico").Enabled = Valida14;
                if (!Valida14)
                    TreeViewPrincipal.Nodes.FindByName("Juridico").ToolTip = Msg_acesso;
                //
                //Obras
                TreeViewPrincipal.Nodes.FindByName("Obras").Enabled = Valida15;
                if (!Valida15)
                    TreeViewPrincipal.Nodes.FindByName("Obras").ToolTip = Msg_acesso;
                //
                //Ajuda Itens menu
                //Consultar para todos
                TreeViewPrincipal.Nodes.FindByName("AjudaSobre").Enabled = SreDblib.TemPermissao("001.012.004.000", (String)Session["CodUsuario"]); //Consultar
                TreeViewPrincipal.Nodes.FindByName("AjudaHelp").Enabled = SreDblib.TemPermissao("001.012.004.000", (String)Session["CodUsuario"]); //Consultar
                TreeViewPrincipal.Nodes.FindByName("AjudaLicenca").Enabled = SreDblib.TemPermissao("001.012.004.000", (String)Session["CodUsuario"]); //Consultar
                TreeViewPrincipal.Nodes.FindByName("AjudaNovidades").Enabled = SreDblib.TemPermissao("001.012.004.000", (String)Session["CodUsuario"]); //Consultar
                TreeViewPrincipal.Nodes.FindByName("AjudaFavoritos").Enabled = SreDblib.TemPermissao("001.012.004.000", (String)Session["CodUsuario"]); //Consultar
                //
                //Empresa Itens menu
                TreeViewPrincipal.Nodes.FindByName("EmpresaCadastro").Enabled = SreDblib.TemPermissao("001.013.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("RelatorioEmpresa").Enabled = SreDblib.TemPermissao("001.013.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("EmpresaUtilitariosApelidoEmpresa").Enabled = SreDblib.TemPermissao("001.013.002.000", (String)Session["CodUsuario"]); //Alterar
                //
                //Clientes Itens menu
                TreeViewPrincipal.Nodes.FindByName("ClienteCadastro").Enabled = SreDblib.TemPermissao("001.002.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("ClienteCep").Enabled = SreDblib.TemPermissao("001.002.004.000", (String)Session["CodUsuario"]); //Consultar
                TreeViewPrincipal.Nodes.FindByName("RelatorioClienteResumido").Enabled = SreDblib.TemPermissao("001.002.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("RelatorioClienteTotal").Enabled = SreDblib.TemPermissao("001.002.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("MalaDiretaEmitirEtiquetas").Enabled = SreDblib.TemPermissao("001.002.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("MalaDiretaCartaPadrao").Enabled = SreDblib.TemPermissao("001.002.001.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("MalaDiretaEmitirCartas").Enabled = SreDblib.TemPermissao("001.002.005.000", (String)Session["CodUsuario"]); //Relatório
                //
                //Produtos Itens menu
                TreeViewPrincipal.Nodes.FindByName("ProdutoCadastro").Enabled = SreDblib.TemPermissao("001.003.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("ProdutoExcluir").Enabled = SreDblib.TemPermissao("001.003.003.000", (String)Session["CodUsuario"]); //Excluir
                TreeViewPrincipal.Nodes.FindByName("ProdutoConsulta").Enabled = SreDblib.TemPermissao("001.003.004.000", (String)Session["CodUsuario"]); //Consultar
                TreeViewPrincipal.Nodes.FindByName("RelatorioProdutoResumido").Enabled = SreDblib.TemPermissao("001.003.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("RelatorioProdutoTotal").Enabled = SreDblib.TemPermissao("001.003.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("RelatorioProdutoEstrutura").Enabled = SreDblib.TemPermissao("001.003.001.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("RelatorioProdutoEstruturaUnidades").Enabled = SreDblib.TemPermissao("001.003.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("RelatorioProdutoIPTU").Enabled = SreDblib.TemPermissao("001.003.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("ProdutoTabelaProduto").Enabled = SreDblib.TemPermissao("001.003.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("ProdutoTabelaGrupo").Enabled = SreDblib.TemPermissao("001.003.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("ProdutoTabelaTipoProduto").Enabled = SreDblib.TemPermissao("001.003.001.000", (String)Session["CodUsuario"]); //Incluir
                //
                //Propostas Itens menu
                TreeViewPrincipal.Nodes.FindByName("PropostasCadastro").Enabled = SreDblib.TemPermissao("001.001.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("PropostasConsulta").Enabled = SreDblib.TemPermissao("001.001.004.000", (String)Session["CodUsuario"]); //Consultar
                TreeViewPrincipal.Nodes.FindByName("PropostasRelatóriosContrato").Enabled = SreDblib.TemPermissao("001.001.005.000", (String)Session["CodUsuario"]); //Relatório
                //
                //Vendas Itens menu
                TreeViewPrincipal.Nodes.FindByName("Venda").Enabled = SreDblib.TemPermissao("001.004.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("Vendatabelaprice").Enabled = SreDblib.TemPermissao("001.004.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("VendasCancelamento").Enabled = SreDblib.TemPermissao("001.004.003.000", (String)Session["CodUsuario"]); //Excluir
                TreeViewPrincipal.Nodes.FindByName("VendasConsulta").Enabled = SreDblib.TemPermissao("001.004.004.000", (String)Session["CodUsuario"]); //Consultar
                TreeViewPrincipal.Nodes.FindByName("VendasConsultaDesistencia").Enabled = SreDblib.TemPermissao("001.004.004.000", (String)Session["CodUsuario"]); //Consultar
                TreeViewPrincipal.Nodes.FindByName("VendasConsultaRenegociacao").Enabled = SreDblib.TemPermissao("001.004.004.000", (String)Session["CodUsuario"]); //Consultar
                TreeViewPrincipal.Nodes.FindByName("VendasDesistencia").Enabled = SreDblib.TemPermissao("001.004.003.000", (String)Session["CodUsuario"]); //Excluir
                TreeViewPrincipal.Nodes.FindByName("VendasRenegociacao").Enabled = SreDblib.TemPermissao("001.004.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("VendasPermutaUnidade").Enabled = SreDblib.TemPermissao("001.004.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("VendasPermutaProprietario").Enabled = SreDblib.TemPermissao("001.004.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("VendasQuitacao").Enabled = SreDblib.TemPermissao("001.004.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("VendasTrocaIndexador").Enabled = SreDblib.TemPermissao("001.004.002.000", (String)Session["CodUsuario"]); //Alterar
                TreeViewPrincipal.Nodes.FindByName("VendasCorrecao").Enabled = SreDblib.TemPermissao("001.004.002.000", (String)Session["CodUsuario"]); //Alterar
                TreeViewPrincipal.Nodes.FindByName("RelatorioVendas").Enabled = SreDblib.TemPermissao("001.004.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("RelatorioVendasEstoque").Enabled = SreDblib.TemPermissao("001.004.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("RelatorioVendasProprietario").Enabled = SreDblib.TemPermissao("001.004.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("RelatorioVendasQuitados").Enabled = SreDblib.TemPermissao("001.004.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("RelatorioVendasComissao").Enabled = SreDblib.TemPermissao("001.004.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("RelatorioVendasProcesso").Enabled = SreDblib.TemPermissao("001.004.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("RelatorioVendasHistoricos").Enabled = SreDblib.TemPermissao("001.004.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("RelatorioVendasCarteira").Enabled = SreDblib.TemPermissao("001.004.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("RelatorioVendasFinanciamentos").Enabled = SreDblib.TemPermissao("001.004.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("RelatorioVendasNP").Enabled = SreDblib.TemPermissao("001.004.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("RelatorioVendasMesCorrecao").Enabled = SreDblib.TemPermissao("001.004.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("RelatorioVendasNotaFiscalGitano").Enabled = SreDblib.TemPermissao("001.004.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("VendasTabelasIndexadores").Enabled = SreDblib.TemPermissao("001.004.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("VendasTabelasIndexadoresDiarios").Enabled = SreDblib.TemPermissao("001.004.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("VendasTabelasIndexadoresMensais").Enabled = SreDblib.TemPermissao("001.004.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("VendasTabelasMensagensBoleto").Enabled = SreDblib.TemPermissao("001.004.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("VendasTabelasCorretores").Enabled = SreDblib.TemPermissao("001.004.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("VendasTabelasRelatoriosTaxasDiarias").Enabled = SreDblib.TemPermissao("001.004.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("VendasTabelasRelatoriosTaxasMensais").Enabled = SreDblib.TemPermissao("001.004.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("VendasTabelasRelatoriosCorretores").Enabled = SreDblib.TemPermissao("001.004.005.000", (String)Session["CodUsuario"]); //Relatório
                //
                //Pagamentos Itens menu
                TreeViewPrincipal.Nodes.FindByName("PagamentosParcela").Enabled = SreDblib.TemPermissao("001.005.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("PagamentosParcelaProprietario").Enabled = SreDblib.TemPermissao("001.005.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("PagamentosParcelaProprietarioCPFCNPJ").Enabled = SreDblib.TemPermissao("001.005.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("PagamentosParcelaAgrupadas").Enabled = SreDblib.TemPermissao("001.005.001.000", (String)Session["CodUsuario"]); //Incluir                
                TreeViewPrincipal.Nodes.FindByName("PagamentosCancelamento").Enabled = SreDblib.TemPermissao("001.005.003.000", (String)Session["CodUsuario"]); //Excluir
                TreeViewPrincipal.Nodes.FindByName("PagamentosDesmenbramento").Enabled = SreDblib.TemPermissao("001.005.001.000", (String)Session["CodUsuario"]); //Incluir                
                TreeViewPrincipal.Nodes.FindByName("PagamentosDesmenbramentoRajada").Enabled = SreDblib.TemPermissao("001.005.001.000", (String)Session["CodUsuario"]); //Incluir                
                TreeViewPrincipal.Nodes.FindByName("PagamentosNovaParcela").Enabled = SreDblib.TemPermissao("001.005.001.000", (String)Session["CodUsuario"]); //Incluir                
                TreeViewPrincipal.Nodes.FindByName("PagamentosNovaParcelaRajada").Enabled = SreDblib.TemPermissao("001.005.001.000", (String)Session["CodUsuario"]); //Incluir                
                TreeViewPrincipal.Nodes.FindByName("PagamentosExcluirParcela").Enabled = SreDblib.TemPermissao("001.005.003.000", (String)Session["CodUsuario"]); //Excluir
                TreeViewPrincipal.Nodes.FindByName("PagamentosFluxoParcela").Enabled = SreDblib.TemPermissao("001.005.004.000", (String)Session["CodUsuario"]); //Consultar
                TreeViewPrincipal.Nodes.FindByName("PagamentosVencimento").Enabled = SreDblib.TemPermissao("001.005.002.000", (String)Session["CodUsuario"]); //Alterar
                TreeViewPrincipal.Nodes.FindByName("PagamentosVencimentoForaMes").Enabled = SreDblib.TemPermissao("001.005.002.000", (String)Session["CodUsuario"]); //Alterar
                TreeViewPrincipal.Nodes.FindByName("PagamentosTipoCobrança").Enabled = SreDblib.TemPermissao("001.005.002.000", (String)Session["CodUsuario"]); //Alterar
                TreeViewPrincipal.Nodes.FindByName("PagamentosProtesto").Enabled = SreDblib.TemPermissao("001.005.002.000", (String)Session["CodUsuario"]); //Alterar
                TreeViewPrincipal.Nodes.FindByName("PagamentosContabil").Enabled = SreDblib.TemPermissao("001.005.002.000", (String)Session["CodUsuario"]); //Alterar
                TreeViewPrincipal.Nodes.FindByName("PagamentosPeriodicidade").Enabled = SreDblib.TemPermissao("001.005.002.000", (String)Session["CodUsuario"]); //Alterar
                TreeViewPrincipal.Nodes.FindByName("CobrancaBancariaBoleto").Enabled = SreDblib.TemPermissao("001.005.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("CobrancaBancariaConfig").Enabled = SreDblib.TemPermissao("001.005.001.000", (String)Session["CodUsuario"]); //Incluir   
                TreeViewPrincipal.Nodes.FindByName("CobrancaBancariaRemessa").Enabled = SreDblib.TemPermissao("001.005.002.000", (String)Session["CodUsuario"]); //Alterar
                TreeViewPrincipal.Nodes.FindByName("CobrancaBancariaRetorno").Enabled = SreDblib.TemPermissao("001.005.002.000", (String)Session["CodUsuario"]); //Alterar
                //
                TreeViewPrincipal.Nodes.FindByName("CobrancaNaoBancariaConfig").Enabled = SreDblib.TemPermissao("001.005.001.000", (String)Session["CodUsuario"]); //Incluir   
                TreeViewPrincipal.Nodes.FindByName("CobrancaNaoBancariaRetorno").Enabled = SreDblib.TemPermissao("001.005.002.000", (String)Session["CodUsuario"]); //Alterar
                //
                TreeViewPrincipal.Nodes.FindByName("PagamentosRelatoriosExtratoFinanciamento").Enabled = SreDblib.TemPermissao("001.005.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("PagamentosRelatoriosExtratoFinanciamentoCorrigido").Enabled = SreDblib.TemPermissao("001.005.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("PagamentosRelatoriosExtratoCorrecao").Enabled = SreDblib.TemPermissao("001.005.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("PagamentosRelatoriosParcelas").Enabled = SreDblib.TemPermissao("001.005.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("PagamentosRelatoriosContabilizacao").Enabled = SreDblib.TemPermissao("001.005.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("PagamentosRelatoriosPagamentos").Enabled = SreDblib.TemPermissao("001.005.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("PagamentosRelatoriosParcelasDevedores").Enabled = SreDblib.TemPermissao("001.005.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("PagamentosRelatoriosParcelasInadimplentes").Enabled = SreDblib.TemPermissao("001.005.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("PagamentosRelatoriosSaldoDevedor").Enabled = SreDblib.TemPermissao("001.005.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("PagamentosRelatoriosSaldoCredor").Enabled = SreDblib.TemPermissao("001.005.005.000", (String)Session["CodUsuario"]); //Relatório
                //
                //Contas a Pagar Itens menu
                TreeViewPrincipal.Nodes.FindByName("ContasaPagarLancamentos").Enabled = SreDblib.TemPermissao("001.006.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("ContasaPagarLancamentosAltera").Enabled = SreDblib.TemPermissao("001.006.002.000", (String)Session["CodUsuario"]); //Alterar
                TreeViewPrincipal.Nodes.FindByName("ContasaPagarLancamentosExcluir").Enabled = SreDblib.TemPermissao("001.006.003.000", (String)Session["CodUsuario"]); //Excluir
                TreeViewPrincipal.Nodes.FindByName("ContasaPagarConsultaLancamentos").Enabled = SreDblib.TemPermissao("001.006.004.000", (String)Session["CodUsuario"]); //Consultar
                //
                TreeViewPrincipal.Nodes.FindByName("ContasaPagarRelatoriosLancamentos").Enabled = SreDblib.TemPermissao("001.006.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("ContasaPagarRelatoriosFornecedores").Enabled = SreDblib.TemPermissao("001.006.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("ContasaPagarRelatoriosDespesas").Enabled = SreDblib.TemPermissao("001.006.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("ContasaPagarRelatoriosCheques").Enabled = SreDblib.TemPermissao("001.006.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("ContasaPagarMalaDiretaEmitirMD").Enabled = SreDblib.TemPermissao("001.006.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("ContasaPagarImportacao").Enabled = SreDblib.TemPermissao("001.006.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("ContasaPagarTabelasDespesas").Enabled = SreDblib.TemPermissao("001.006.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("ContasaPagarTabelasFornecedores").Enabled = SreDblib.TemPermissao("001.006.001.000", (String)Session["CodUsuario"]); //Incluir
                //
                //Contas a Receber Itens menu
                TreeViewPrincipal.Nodes.FindByName("ContasaReceberLancamentos").Enabled = SreDblib.TemPermissao("001.007.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("ContasaReceberLancamentosAltera").Enabled = SreDblib.TemPermissao("001.007.002.000", (String)Session["CodUsuario"]); //Alterar
                TreeViewPrincipal.Nodes.FindByName("ContasaReceberLancamentosExcluir").Enabled = SreDblib.TemPermissao("001.007.003.000", (String)Session["CodUsuario"]); //Excluir
                TreeViewPrincipal.Nodes.FindByName("ContasaReceverConsultaLancamentos").Enabled = SreDblib.TemPermissao("001.007.004.000", (String)Session["CodUsuario"]); //Consultar
                TreeViewPrincipal.Nodes.FindByName("ContasaReceberGeracaoLancamentos").Enabled = SreDblib.TemPermissao("001.007.001.000", (String)Session["CodUsuario"]); //Incluir
                //
                TreeViewPrincipal.Nodes.FindByName("ContasaReceberRelatoriosLancamentos").Enabled = SreDblib.TemPermissao("001.007.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("ContasaReceberRelatoriosClientes").Enabled = SreDblib.TemPermissao("001.007.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("ContasaReceberRelatoriosReceitas").Enabled = SreDblib.TemPermissao("001.007.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("ContasaReceberRelatoriosDepositos").Enabled = SreDblib.TemPermissao("001.007.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("ContasaReceberImportacaoArquivoTexto").Enabled = SreDblib.TemPermissao("001.007.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("ContasaReceberTabelasReceitas").Enabled = SreDblib.TemPermissao("001.007.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("ContasaReceberTabelasClientes").Enabled = SreDblib.TemPermissao("001.007.001.000", (String)Session["CodUsuario"]); //Incluir
                //
                //Bancos Itens menu
                TreeViewPrincipal.Nodes.FindByName("BancosMovimentacoes").Enabled = SreDblib.TemPermissao("001.008.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("BancosGeracao").Enabled = SreDblib.TemPermissao("001.008.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("BancosCheques").Enabled = SreDblib.TemPermissao("001.008.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("BancosDepositos").Enabled = SreDblib.TemPermissao("001.008.004.000", (String)Session["CodUsuario"]); //Consultar
                TreeViewPrincipal.Nodes.FindByName("BancosResumo").Enabled = SreDblib.TemPermissao("001.008.001.000", (String)Session["CodUsuario"]); //Incluir
                //
                TreeViewPrincipal.Nodes.FindByName("BancosRelatoriosDepositos").Enabled = SreDblib.TemPermissao("001.008.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("BancosRelatoriosCheques").Enabled = SreDblib.TemPermissao("001.008.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("BancosRelatoriosExtratoMovimentacao").Enabled = SreDblib.TemPermissao("001.008.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("BancosRelatoriosCaixaDiario").Enabled = SreDblib.TemPermissao("001.008.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("BancosRelatoriosResumoContas").Enabled = SreDblib.TemPermissao("001.008.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("ContasaReceberTabelasBancos").Enabled = SreDblib.TemPermissao("001.008.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("ContasaReceberTabelasNaoBancos").Enabled = SreDblib.TemPermissao("001.008.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("ContasaReceberTabelasContasCorrentes").Enabled = SreDblib.TemPermissao("001.008.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("BancosTabelasSaldos").Enabled = SreDblib.TemPermissao("001.008.001.000", (String)Session["CodUsuario"]); //Incluir
                //
                //Fluxo de Caixa Itens menu
                TreeViewPrincipal.Nodes.FindByName("AnalisesFluxoCaixaDiario").Enabled = SreDblib.TemPermissao("001.008.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("AnalisesFluxoCaixaTotal").Enabled = SreDblib.TemPermissao("001.008.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("AnalisesFluxoCaixaMensal").Enabled = SreDblib.TemPermissao("001.008.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("AnalisesFluxoCaixaTrimestral").Enabled = SreDblib.TemPermissao("001.008.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("BancosRelatoriosResumoContas").Enabled = SreDblib.TemPermissao("001.008.005.000", (String)Session["CodUsuario"]); //Relatório
                TreeViewPrincipal.Nodes.FindByName("ContasaReceberTabelasBancos").Enabled = SreDblib.TemPermissao("001.008.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("ContasaReceberTabelasNaoBancos").Enabled = SreDblib.TemPermissao("001.008.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("ContasaReceberTabelasContasCorrentes").Enabled = SreDblib.TemPermissao("001.008.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("BancosTabelasSaldos").Enabled = SreDblib.TemPermissao("001.008.001.000", (String)Session["CodUsuario"]); //Incluir
                //
                //integração Contábil Itens menu
                TreeViewPrincipal.Nodes.FindByName("ContabilFolhadePagamento").Enabled = SreDblib.TemPermissao("001.010.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("UtilitariosExportacaoProsoft").Enabled = SreDblib.TemPermissao("001.010.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("UtilitariosExportacaoCEF").Enabled = SreDblib.TemPermissao("001.010.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("UtilitariosExportacaoPIS").Enabled = SreDblib.TemPermissao("001.010.001.000", (String)Session["CodUsuario"]); //Incluir
                //
                //Juridico Itens menu
                //
                //Fluxo de Caixa Itens menu
                TreeViewPrincipal.Nodes.FindByName("ConfigPermissoes").Enabled = SreDblib.TemPermissao("001.011.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("ConfigParametros").Enabled = SreDblib.TemPermissao("001.011.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("ConfigUsuariosUsuarios").Enabled = SreDblib.TemPermissao("001.011.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("ConfigUsuariosPermissoes").Enabled = SreDblib.TemPermissao("001.011.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("ConfigUsuariosPerfil").Enabled = SreDblib.TemPermissao("001.011.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("ConfigUsuariosPermissoesPerfil").Enabled = SreDblib.TemPermissao("001.011.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("ConfigUsuariosPerfilAssociacao").Enabled = SreDblib.TemPermissao("001.011.001.000", (String)Session["CodUsuario"]); //Incluir
                TreeViewPrincipal.Nodes.FindByName("ConfigAnalisesSegurança").Enabled = SreDblib.TemPermissao("001.011.004.000", (String)Session["CodUsuario"]); //Consultar
                TreeViewPrincipal.Nodes.FindByName("ConfigAnalisesAções").Enabled = SreDblib.TemPermissao("001.011.004.000", (String)Session["CodUsuario"]); //Consultar
                TreeViewPrincipal.Nodes.FindByName("ConfigAmbienteStatus").Enabled = SreDblib.TemPermissao("001.011.004.000", (String)Session["CodUsuario"]); //Consultar
                TreeViewPrincipal.Nodes.FindByName("ConfigAmbienteEstatisticas").Enabled = SreDblib.TemPermissao("001.011.004.000", (String)Session["CodUsuario"]); //Consultar
                TreeViewPrincipal.Nodes.FindByName("ConfigBrowserStatus").Enabled = SreDblib.TemPermissao("001.011.004.000", (String)Session["CodUsuario"]); //Consultar
                //
                TreeViewPrincipal.Nodes.FindByName("ConfigAmbienteMigracoesSimbolo").Enabled = SreDblib.TemPermissao("000.000.000.000", (String)Session["CodUsuario"]); //Usuário Master
                //
                TreeViewPrincipal.Nodes.FindByName("ConfigEditor").Enabled = SreDblib.TemPermissao("001.011.004.000", (String)Session["CodUsuario"]); //Consultar
                //

                //Fim Validação Modulos via permissão de acesso
                //////////////////////////////////////////////////////////
                //
                //////////////////////////////////////////////////////////
                //Validação Modulos Especiais Gitano
                //Nota Fiscal Gitano
                TreeViewPrincipal.Nodes.FindByName("RelatorioVendasNotaFiscalGitano").Enabled = (Cnpj_corrente == "13305470000105");
                TreeViewPrincipal.Nodes.FindByName("RelatorioVendasNotaFiscalGitano").Visible = (Cnpj_corrente == "13305470000105");
                if (!(Cnpj_corrente == "13305470000105"))
                    TreeViewPrincipal.Nodes.FindByName("RelatorioVendasNotaFiscalGitano").ToolTip = Msg_acesso;
                //Contábil Nota Fiscal Gitano
                TreeViewPrincipal.Nodes.FindByName("PagamentosContabil").Enabled = (Cnpj_corrente == "13305470000105");
                TreeViewPrincipal.Nodes.FindByName("PagamentosContabil").Visible = (Cnpj_corrente == "13305470000105");
                if (!(Cnpj_corrente == "13305470000105"))
                    TreeViewPrincipal.Nodes.FindByName("PagamentosContabil").ToolTip = Msg_acesso;
                //
                //Fim Validação Modulos Especiais DADO ou Gitano
                //////////////////////////////////////////////////////////
                //
                //////////////////////////////////////////////////////////
                //Validação Modulos Especiais DADO
                //Módulo Propostas - Pré-Vendas
                TreeViewPrincipal.Nodes.FindByName("Propostas").Enabled = ((Cnpj_corrente == "13305470000105") || (Cnpj_corrente == "62107453000179"));
                TreeViewPrincipal.Nodes.FindByName("Propostas").Visible = ((Cnpj_corrente == "13305470000105") || (Cnpj_corrente == "62107453000179"));
                if ((!(Cnpj_corrente == "13305470000105")) || (!(Cnpj_corrente == "62107453000179")))
                    TreeViewPrincipal.Nodes.FindByName("Propostas").ToolTip = Msg_acesso;
                //
                //Módulo Contábil - Contábil
                TreeViewPrincipal.Nodes.FindByName("Contabil").Enabled = ((Cnpj_corrente == "13305470000105") || (Cnpj_corrente == "62107453000179"));
                TreeViewPrincipal.Nodes.FindByName("Contabil").Visible = ((Cnpj_corrente == "13305470000105") || (Cnpj_corrente == "62107453000179"));
                if ((!(Cnpj_corrente == "13305470000105")) || (!(Cnpj_corrente == "62107453000179")))
                    TreeViewPrincipal.Nodes.FindByName("Contabil").ToolTip = Msg_acesso;
                //
                //Módulo Jurídico - Jurídico
                TreeViewPrincipal.Nodes.FindByName("Juridico").Enabled = ((Cnpj_corrente == "13305470000105") || (Cnpj_corrente == "62107453000179"));
                TreeViewPrincipal.Nodes.FindByName("Juridico").Visible = ((Cnpj_corrente == "13305470000105") || (Cnpj_corrente == "62107453000179"));
                if ((!(Cnpj_corrente == "13305470000105")) || (!(Cnpj_corrente == "62107453000179")))
                    TreeViewPrincipal.Nodes.FindByName("Juridico").ToolTip = Msg_acesso;
                //
                //Módulo Vendas - Vendas Inadimplencia
                TreeViewPrincipal.Nodes.FindByName("VendasInadimplencia").Enabled = ((Cnpj_corrente == "13305470000105") || (Cnpj_corrente == "62107453000179"));
                TreeViewPrincipal.Nodes.FindByName("VendasInadimplencia").Visible = ((Cnpj_corrente == "13305470000105") || (Cnpj_corrente == "62107453000179"));
                if ((!(Cnpj_corrente == "13305470000105")) || (!(Cnpj_corrente == "62107453000179")))
                    TreeViewPrincipal.Nodes.FindByName("VendasInadimplencia").ToolTip = Msg_acesso;
                //
                //Módulo Vendas - Vendas Administracao Carteiras
                TreeViewPrincipal.Nodes.FindByName("VendasAdministracaoCarteiras").Enabled = ((Cnpj_corrente == "13305470000105") || (Cnpj_corrente == "62107453000179"));
                TreeViewPrincipal.Nodes.FindByName("VendasAdministracaoCarteiras").Visible = ((Cnpj_corrente == "13305470000105") || (Cnpj_corrente == "62107453000179"));
                if ((!(Cnpj_corrente == "13305470000105")) || (!(Cnpj_corrente == "62107453000179")))
                    TreeViewPrincipal.Nodes.FindByName("VendasAdministracaoCarteiras").ToolTip = Msg_acesso;
                //
                //Módulo Config - Configuração de E-mail
                TreeViewPrincipal.Nodes.FindByName("ConfigEMail").Enabled = ((Cnpj_corrente == "13305470000105") || (Cnpj_corrente == "62107453000179"));
                TreeViewPrincipal.Nodes.FindByName("ConfigEMail").Visible = ((Cnpj_corrente == "13305470000105") || (Cnpj_corrente == "62107453000179"));
                if ((!(Cnpj_corrente == "13305470000105")) || (!(Cnpj_corrente == "62107453000179")))
                    TreeViewPrincipal.Nodes.FindByName("ConfigEMail").ToolTip = Msg_acesso;
                //
                //Módulo Obras - Obras
                TreeViewPrincipal.Nodes.FindByName("Obras").Enabled = ((Cnpj_corrente == "13305470000105") || (Cnpj_corrente == "62107453000179"));
                TreeViewPrincipal.Nodes.FindByName("Obras").Visible = ((Cnpj_corrente == "13305470000105") || (Cnpj_corrente == "62107453000179"));
                if ((!(Cnpj_corrente == "13305470000105")) || (!(Cnpj_corrente == "62107453000179")))
                    TreeViewPrincipal.Nodes.FindByName("Obras").ToolTip = Msg_acesso;
                //
                //Fim Validação Modulos Especiais DADO
                //////////////////////////////////////////////////////////
                //
                //////////////////////////////////////////////////////////
                //Validação Modulos Via Parâmetros
                //Pagamentos\Fluxo de Parcelas
                if (uParametros.PegaParametro("FLUXO DE PARCELAS") == "SIM")
                {
                    TreeViewPrincipal.Nodes.FindByName("PagamentosFluxoParcela").Enabled = true;
                    TreeViewPrincipal.Nodes.FindByName("PagamentosFluxoParcela").Visible = true;
                }
                else
                {
                    TreeViewPrincipal.Nodes.FindByName("PagamentosFluxoParcela").Enabled = false;
                    TreeViewPrincipal.Nodes.FindByName("PagamentosFluxoParcela").Visible = false;
                    TreeViewPrincipal.Nodes.FindByName("PagamentosFluxoParcela").ToolTip = Msg_acesso;
                }
                //Fim Validação Modulos Via Parâmetros
                //////////////////////////////////////////////////////////
                //
            }
            else
            {
                //////////////////////////////////////////////////////////
                //Validação Negativa
                //Cnpj Inválido e Expirado
                if ((!Cnpj_valido) && (Cnpj_expirado))
                {
                    Session.Add("Erro", "1");
                    Response.Redirect("~\\erros\\forms\\AcessoNegado.aspx");
                }
                else
                {
                    //Cnpj Expirado
                    if (Cnpj_expirado)
                    {
                        Session.Add("Erro", "2");
                        Response.Redirect("~\\erros\\forms\\AcessoNegado.aspx");
                    }
                    else
                    {
                        //Cnpj Inválido
                        if (!Cnpj_valido)
                        {
                            Session.Add("Erro", "3");
                            Response.Redirect("~\\erros\\forms\\AcessoNegado.aspx");
                        }
                    }
                }
            }
        }
    }
}


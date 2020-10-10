<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Principal.aspx.cs" Inherits="Principal" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxSplitter" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxTreeView" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <dx:ASPxSplitter ID="ASPxSplitter1" runat="server" Height="1700px" ResizingMode="Live"
        Width="1160px" PaneMinSize="20px" ShowCollapseBackwardButton="True" ShowCollapseForwardButton="True">
        <Panes>
            <dx:SplitterPane Name="PaneMenu" ScrollBars="Auto" Size="100px" ShowSeparatorImage="True">
                <PaneStyle>
                    <Border BorderStyle="None" BorderWidth="0px" />
                    <BorderLeft BorderStyle="None" BorderWidth="0px" />
                    <BorderTop BorderStyle="None" BorderWidth="0px" />
                    <BorderRight BorderStyle="None" BorderWidth="0px" />
                    <BorderBottom BorderStyle="None" BorderWidth="0px" />
                    <Border BorderStyle="None" BorderWidth="0px"></Border>
                    <BorderLeft BorderStyle="None" BorderWidth="0px"></BorderLeft>
                    <BorderTop BorderStyle="None" BorderWidth="0px"></BorderTop>
                    <BorderRight BorderStyle="None" BorderWidth="0px"></BorderRight>
                    <BorderBottom BorderStyle="None" BorderWidth="0px"></BorderBottom>
                </PaneStyle>
                <ContentCollection>
                    <dx:SplitterContentControl runat="server" SupportsDisabledAttribute="True">
                        <dx:ASPxTreeView ID="TreeViewPrincipal" runat="server" EnableTheming="True" Target="contentUrlPane"
                            AllowSelectNode="True" Height="600px" Width="180px" ClientInstanceName="TreeViewPrincipal"
                            EnableClientSideAPI="True" NodeLinkMode="TextOnly" EnableHotTrack="True">
                            <SettingsLoadingPanel Text="Carregando&amp;hellip;" />
                            <Images>
                                <CollapseButton Height="15px" Url="~/images/Botoes/SETAmenu2.jpg" Width="15px">
                                </CollapseButton>
                                <ExpandButton Height="15px" Url="~/images/Botoes/SETAmenu1.jpg" Width="15px">
                                </ExpandButton>
                                <NodeLoadingPanel Height="10px" Url="~/images/Botoes/SETAmenu3.jpg" Width="10px">
                                </NodeLoadingPanel>
                            </Images>
                            <Styles>
                                <Link>
                                    <HoverFont Bold="False" Underline="True" />
                                    <VisitedFont Bold="False" Underline="True" />
                                    <HoverFont Bold="False" Underline="True"></HoverFont>
                                    <VisitedFont Bold="False" Underline="True"></VisitedFont>
                                </Link>
                            </Styles>
                            <SettingsLoadingPanel Text="Carregando&amp;hellip;"></SettingsLoadingPanel>
                            <Nodes>
                                <dx:TreeViewNode Text="Ajuda"
                                    Name="Ajuda" ToolTip="Ajuda">
                                    <Image Url="~/images/Botoes/bAJUDA.jpg" Height="35px" Width="35px">
                                    </Image>
                                    <TextStyle ForeColor="#000099" VerticalAlign="Middle" HorizontalAlign="Center">
                                    </TextStyle>
                                    <Nodes>
                                        <dx:TreeViewNode Name="AjudaSobre" NavigateUrl="~/_Ajuda/forms/FSobre.aspx"
                                            Text="Sobre" ToolTip="Sobre Nós">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="AjudaHelp" NavigateUrl="~/_Ajuda/forms/FHelp.aspx"
                                            Text="Help" ToolTip="Como Usar o Help">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="AjudaLicenca"
                                            NavigateUrl="~/_Ajuda/forms/FLicencaUso.aspx" Text="Licença de Uso"
                                            ToolTip="Licença de Uso do Software">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="AjudaNovidades"
                                            NavigateUrl="~/_Ajuda/forms/FNovidades.aspx" Text="Novidades"
                                            ToolTip="Novidades Sistema Gitano">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="AjudaFavoritos"
                                            NavigateUrl="~/_Favoritos/forms/FFavoritos.aspx" Text="Favoritos"
                                            ToolTip="Favoritos">
                                        </dx:TreeViewNode>
                                    </Nodes>
                                </dx:TreeViewNode>
                                <dx:TreeViewNode Name="Empresa" Text="Empresa" ToolTip="Empresa">
                                    <Image Height="35px" Url="~/images/Botoes/bEMPRESA.jpg" Width="35px">
                                    </Image>
                                    <TextStyle ForeColor="#000099" HorizontalAlign="Center" VerticalAlign="Middle">
                                    </TextStyle>
                                    <Nodes>
                                        <dx:TreeViewNode Name="EmpresaCadastro" NavigateUrl="~/_Empresa/forms/FEmpresaCadastro.aspx"
                                            Text="Cadastro" ToolTip="Inclusão, Alteração, Exclusão e Consulta de Empresa">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="RelatoriosEmpresa" Text="Relatórios" ToolTip="Relatórios de Empresa">
                                            <Nodes>
                                                <dx:TreeViewNode Name="RelatorioEmpresa" Text="Cadastro" NavigateUrl="~/_Empresa/relatorios/FRelEmpresaCadastro.aspx" ToolTip="Relatório de Cadastro">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="EmpresaUtilitarios" Text="Utilitários" ToolTip="Utilitários Empresa">
                                            <Nodes>
                                                <dx:TreeViewNode Name="EmpresaUtilitariosApelidoEmpresa" NavigateUrl="~/_Empresa/forms/FEmpresaTrocaApelido.aspx"
                                                    Text="Apelido Empresa" ToolTip="Troca Apelido Empresa">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                    </Nodes>
                                </dx:TreeViewNode>
                                <dx:TreeViewNode Text="Clientes" Name="Clientes" ToolTip="Clientes">
                                    <Image Url="~/images/Botoes/bCLIENTES.jpg" Height="35px" Width="35px">
                                    </Image>
                                    <TextStyle Font-Bold="False" ForeColor="#000099" HorizontalAlign="Center" VerticalAlign="Middle">
                                    </TextStyle>
                                    <Nodes>
                                        <dx:TreeViewNode Name="ClienteCadastro" Text="Cadastro" ToolTip="Inclusão, Alteração, Exclusão e Consulta de Clientes"
                                            NavigateUrl="~/_Clientes/forms/FClienteCadastro.aspx">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ClienteCep" Text="CEP"
                                            ToolTip="Consulta de CEP"
                                            NavigateUrl="~/_Cep/forms/FCep2007Consulta.aspx">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="RelatoriosCliente" Text="Relatórios" ToolTip="Relatórios de Cliente">
                                            <Nodes>
                                                <dx:TreeViewNode Name="RelatorioClienteResumido" Text="Resumido" NavigateUrl="~/_Clientes/relatorios/FRelClienteCadastroResumido.aspx" ToolTip="Relatórios de Cliente Resumido">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="RelatorioClienteTotal" Text="Completo" NavigateUrl="~/_Clientes/relatorios/FRelClienteCadastroTotal.aspx" ToolTip="Relatórios de Cliente Completo">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="MalaDiretaClientes" Text="Mala Direta" ToolTip="Emissão de Cartas e Etiquetas Personalizadas">
                                            <Nodes>
                                                <dx:TreeViewNode Name="MalaDiretaEmitirEtiquetas" Text="Emitir Etiquetas" ToolTip="Emitir Etiquetas"
                                                    NavigateUrl="~/_Clientes/relatorios/FRelClienteMalaDireta.aspx">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="MalaDiretaCartaPadrao" NavigateUrl="~/_Clientes/forms/FClienteCartaPadrao.aspx"
                                                    Text="Carta Padrão" ToolTip="Cadastro de Cartas Padrão">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="MalaDiretaEmitirCartas" Text="Emitir Cartas" NavigateUrl="~/_Clientes/relatorios/FRelClienteCartaPadrao.aspx"
                                                    ToolTip="Emitir Cartas">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                    </Nodes>
                                </dx:TreeViewNode>
                                <dx:TreeViewNode Name="Obras" Text="Obras" ToolTip="Obras">
                                    <Image Height="35px" Url="~/images/Botoes/bOBRAS.jpg" Width="35px">
                                    </Image>
                                    <TextStyle ForeColor="#000099" HorizontalAlign="Center" VerticalAlign="Middle">
                                    </TextStyle>
                                    <Nodes>
                                        <dx:TreeViewNode Text="Em Desenvolvimento" ToolTip="Em Desenvolvimento">
                                        </dx:TreeViewNode>
                                    </Nodes>
                                </dx:TreeViewNode>
                                <dx:TreeViewNode Name="Produtos" Text="Produtos" ToolTip="Produtos">
                                    <Image Height="35px" Url="~/images/Botoes/bPRODUTOS.jpg" Width="35px">
                                    </Image>
                                    <TextStyle ForeColor="#000099" HorizontalAlign="Center" VerticalAlign="Middle">
                                    </TextStyle>
                                    <Nodes>
                                        <dx:TreeViewNode Name="ProdutoCadastro" Text="Cadastro" ToolTip="Inclusão, Alteração, Exclusão e Consulta de Produtos"
                                            NavigateUrl="~/_Produtos/forms/FProdutoCadastro.aspx">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ProdutoExcluir" NavigateUrl="~/_Produtos/forms/FProdutoExcluir.aspx"
                                            Text="Excluir" ToolTip="Excluir Cadastramento do Produto">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ProdutoConsulta" NavigateUrl="~/_Produtos/forms/FProdutoConsulta.aspx"
                                            Text="Consulta" ToolTip="Consulta Produto Cadastrado">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="RelatorioProduto" Text="Relatórios" ToolTip="Relatórios de Produtos">
                                            <Nodes>
                                                <dx:TreeViewNode Name="RelatorioProdutoResumido" Text="Resumido" ToolTip="Relatório Produto Cadastro Resumido"
                                                    NavigateUrl="~/_Produtos/relatorios/FRelProdutoCadastroResumido.aspx">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="RelatorioProdutoTotal" Text="Completo" ToolTip="Relatório Produto Cadastro Total"
                                                    NavigateUrl="~/_Produtos/relatorios/FRelProdutoCadastroTotal.aspx">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="RelatorioProdutoEstrutura" NavigateUrl="~/_Produtos/relatorios/FRelProdutoEstrutura.aspx"
                                                    Text="Estrutura" ToolTip="Relatório Estrutura do Produto">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="RelatorioProdutoEstruturaUnidades"
                                                    NavigateUrl="~/_Produtos/relatorios/FRelProdutoEstruturaUnidades.aspx"
                                                    Text="Estrutura Unidades" ToolTip="Relatório Estrutura Unidades">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="RelatorioProdutoIPTU" Text="IPTU" ToolTip="Relatório Cadastro para fins de IPTU"
                                                    NavigateUrl="~/_Produtos/relatorios/FRelProdutoIptu.aspx">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="TabelasProduto" Text="Tabelas" ToolTip="Tabelas Configuração de Produtos">
                                            <Nodes>
                                                <dx:TreeViewNode Name="ProdutoTabelaProduto" Text="Produto" ToolTip="Personalização do Produto"
                                                    NavigateUrl="~/_Produtos/forms/FTabelaProdutos.aspx">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="ProdutoTabelaGrupo" Text="Grupo do Produto" ToolTip="Personalização da Estrutura Interna do Produto"
                                                    NavigateUrl="~/_Produtos/forms/FTabelaProdutosGrupo.aspx">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="ProdutoTabelaTipoProduto" Text="Tipo de Produto" ToolTip="Tipificação dos Produtos que serão aceitos"
                                                    NavigateUrl="~/_Produtos/forms/FTabelaProdutosTipo.aspx">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                    </Nodes>
                                </dx:TreeViewNode>
                                <dx:TreeViewNode Name="Propostas" Text="Propostas"
                                    ToolTip="Propostas - Pré Vendas">
                                    <Image Height="35px" Url="~/images/Botoes/bPROPOSTAS.jpg" Width="35px">
                                    </Image>
                                    <TextStyle ForeColor="#000099" VerticalAlign="Middle">
                                    </TextStyle>
                                    <Nodes>
                                        <dx:TreeViewNode Text="Cadastro" Name="PropostasCadastro"
                                            NavigateUrl="~/_Propostas/forms/FPropostasCadastro.aspx" ToolTip="Cadastro Propostas - Pré Vendas">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="PropostasConsulta"
                                            NavigateUrl="~/_Propostas/forms/FPropostasConsulta.aspx" Text="Consulta" ToolTip="Consulta Propostas - Pré Vendas">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="PropostasRelatórios" Text="Relatórios" ToolTip="Relatórios Propostas - Pré Vendas">
                                            <Nodes>
                                                <dx:TreeViewNode Name="PropostasRelatóriosContrato" Text="Contrato"
                                                    ToolTip="Emissão do Contrato de Compra">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                    </Nodes>
                                </dx:TreeViewNode>
                                <dx:TreeViewNode Text="Vendas" Name="Vendas" ToolTip="Vendas">
                                    <Image Url="~/images/Botoes/bVENDAS.jpg" Height="35px" Width="35px">
                                    </Image>
                                    <TextStyle ForeColor="#000099" VerticalAlign="Middle">
                                    </TextStyle>
                                    <Nodes>
                                        <dx:TreeViewNode Name="Venda" Text="Venda" ToolTip="Venda de Unidades " NavigateUrl="~/_Vendas/forms/FVendasCadastro.aspx">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="Vendatabelaprice"
                                            NavigateUrl="~/_Vendas/forms/FVendasCadastroPrice.aspx" Text="Venda T.Price"
                                            ToolTip="Venda de Unidades Tabela Price">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="VendasCancelamento" Text="Cancelamento" ToolTip="Cancelamento da Venda"
                                            NavigateUrl="~/_Vendas/forms/FVendasCancelamento.aspx">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="VendasConsulta" NavigateUrl="~/_Vendas/forms/FVendasConsulta.aspx"
                                            Text="Consulta Venda" ToolTip="Consulta da Venda">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="VendasConsultaDesistencia"
                                            NavigateUrl="~/_Vendas/forms/FVendasConsultaDesistencia .aspx"
                                            Text="Consulta Desistências" ToolTip="Consulta de Desistências da Unidade">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="VendasConsultaRenegociacao" NavigateUrl="~/_Vendas/forms/FVendasConsultaRenegociacao.aspx" Text="Consulta Renegoc." ToolTip="Consulta Renegociações da Unidade">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="VendasDesistencia" Text="Desistência" ToolTip="Desistência de Venda"
                                            NavigateUrl="~/_Vendas/forms/FVendasDesistencia.aspx">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="VendasRenegociacao" Text="Renegociação" ToolTip="Renegociação do Financiamento, Repactuação"
                                            NavigateUrl="~/_Vendas/forms/FVendasRenegociacao.aspx">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="VendasPermutaUnidade" Text="Permuta Unidade" ToolTip="Permuta entre Unidades"
                                            NavigateUrl="~/_Vendas/forms/FVendasPermutaUnidade.aspx">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="VendasPermutaProprietario"
                                            Text="Transf.Proprietário" ToolTip="Transferência Proprietário Unidade"
                                            NavigateUrl="~/_Vendas/forms/FVendasPermutaProprietario.aspx">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="VendasQuitacao" Text="Quitação" ToolTip="Quitação da Unidade"
                                            NavigateUrl="~/_Vendas/forms/FVendasQuitacao.aspx">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="VendasTrocaIndexador" Text="Troca Indexador" ToolTip="Troca de Indexador do Financiamento"
                                            NavigateUrl="~/_Vendas/forms/FVendasTrocaIndexador.aspx">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="VendasCorrecao" NavigateUrl="~/_Vendas/forms/FVendasCorrecao.aspx"
                                            Text="Correção Monetária" ToolTip="Correção Monetária de Contratos">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="VendasAdministracaoCarteiras" Text="Adm. Carteiras" ToolTip="Adm. Carteiras">
                                            <Nodes>
                                                <dx:TreeViewNode Text="Em Desenvolvimento" ToolTip="Em Desenvolvimento">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="VendasInadimplencia" Text="Inadimplência" ToolTip="Inadimplência">
                                            <Nodes>
                                                <dx:TreeViewNode Text="Em Desenvolvimento" ToolTip="Em Desenvolvimento">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="RelatorioVendas" Text="Relatórios" ToolTip="Relatórios">
                                            <Nodes>
                                                <dx:TreeViewNode Name="RelatorioVendas" Text="Vendas" ToolTip="Relatório de Vendas"
                                                    NavigateUrl="~/_Vendas/relatorios/FRelVendas.aspx">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="RelatorioVendasEstoque" Text="Estoque" ToolTip="Relatório de Unidades Vendidas e Disponíveis"
                                                    NavigateUrl="~/_Vendas/relatorios/FRelEstoque.aspx">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="RelatorioVendasProprietario" Text="Proprietários" ToolTip="Relatório Vendas por Proprietário"
                                                    NavigateUrl="~/_Vendas/relatorios/FRelProprietario.aspx">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="RelatorioVendasQuitados" Text="Quitados" ToolTip="Relatório de Unidades Quitadas"
                                                    NavigateUrl="~/_Vendas/relatorios/FRelQuitados.aspx">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="RelatorioVendasComissao" Text="Comissões" NavigateUrl="~/_Vendas/relatorios/FRelVendasComissoes.aspx"
                                                    ToolTip="Relatório Comissões sobre Vendas">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="RelatorioVendasProcesso" Text="Processos"
                                                    NavigateUrl="~/_Vendas/relatorios/FRelProcesso.aspx"
                                                    ToolTip="Relatório em Processo Judicial">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="RelatorioVendasHistoricos" Text="Histórico" NavigateUrl="~/_Vendas/relatorios/FRelVendasHistorico.aspx"
                                                    ToolTip="Relatório Histórico de Movimentos da Venda">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="RelatorioVendasCarteira" Text="Carteira" NavigateUrl="~/_Vendas/relatorios/FRelVendasCarteira.aspx"
                                                    ToolTip="Relatório Posição da Carteira">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="RelatorioVendasFinanciamentos" Text="Saldos Financ."
                                                    NavigateUrl="~/_Vendas/relatorios/FRelVendasFinanciamentos.aspx"
                                                    ToolTip="Relatório Saldos Financiamentos">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="RelatorioVendasNP" Text="NP" NavigateUrl="~/_Vendas/relatorios/FRelNotaPromissoria.aspx"
                                                    ToolTip="Emissão de Notas Promissórias">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="RelatorioVendasMesCorrecao" Text="Mês Correção"
                                                    NavigateUrl="~/_Vendas/relatorios/FRelVendasMesCorrecao.aspx"
                                                    ToolTip="Relatório Mês Correção">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="RelatorioVendasNotaFiscalGitano"
                                                    NavigateUrl="~/_Vendas/relatorios/FRelNotaFiscalGitano.aspx" Text="NF Gitano"
                                                    ToolTip="NF Gitano">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="VendasTabelas" Text="Tabelas" ToolTip="Tabelas">
                                            <Nodes>
                                                <dx:TreeViewNode Name="VendasTabelasIndexadores" Text="Indexadores" NavigateUrl="~/_Vendas/forms/FTabelaVendasIndexadores.aspx" ToolTip="Tabelas indexadores">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="VendasTabelasIndexadoresDiarios" Text="Taxas Diárias" NavigateUrl="~/_Vendas/forms/FTabelaVendasTaxasDiarias.aspx" ToolTip="Tabelas Taxas Diárias">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="VendasTabelasIndexadoresMensais" Text="Taxas Mensais" NavigateUrl="~/_Vendas/forms/FTabelaVendasTaxasMensais.aspx" ToolTip="Tabelas Taxas Mensais">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="VendasTabelasMensagensBoleto" Text="Mens. Boleto" NavigateUrl="~/_Vendas/forms/FTabelaVendasMensagensBoleto.aspx" ToolTip="Tabelas Mensagens Boleto">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="VendasTabelasCorretores" Text="Corretores" NavigateUrl="~/_Vendas/forms/FTabelaVendasCorretores.aspx" ToolTip="Tabelas Corretores">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="VendasTabelasRelatorios" Text="Relatórios " ToolTip="Relatórios Tabelas">
                                                    <Nodes>
                                                        <dx:TreeViewNode Name="VendasTabelasRelatoriosTaxasDiarias" Text="Taxas Diárias"
                                                            NavigateUrl="~/_Vendas/relatorios/FRelVendasTaxasDiarias.aspx" ToolTip="Relatórios Taxas Diárias">
                                                        </dx:TreeViewNode>
                                                        <dx:TreeViewNode Name="VendasTabelasRelatoriosTaxasMensais" Text="Taxas Mensais"
                                                            NavigateUrl="~/_Vendas/relatorios/FRelVendasTaxasMensais.aspx" ToolTip="Relatórios Taxas Mensais">
                                                        </dx:TreeViewNode>
                                                        <dx:TreeViewNode Name="VendasTabelasRelatoriosCorretores" Text="Corretores" NavigateUrl="~/_Vendas/relatorios/FRelVendasCorretores.aspx"
                                                            ToolTip="Relatórios Corretores">
                                                        </dx:TreeViewNode>
                                                    </Nodes>
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                    </Nodes>
                                </dx:TreeViewNode>
                                <dx:TreeViewNode Text="Pagamentos" Name="Pagamentos" ToolTip="Pagamentos">
                                    <Image Url="~/images/Botoes/bPAGAMENTOS.jpg" Height="35px" Width="35px">
                                    </Image>
                                    <TextStyle ForeColor="#000099" VerticalAlign="Middle" HorizontalAlign="Center">
                                    </TextStyle>
                                    <Nodes>
                                        <dx:TreeViewNode Name="PagamentosParcela" Text="Parcelas" NavigateUrl="~/_Pagamentos/forms/FParcelas.aspx" ToolTip="Parcelas">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="PagamentosParcelaProprietario"
                                            NavigateUrl="~/_Pagamentos/forms/FParcelasProprietario.aspx"
                                            Text="Parcelas Propr." ToolTip="Parcelas Proprietário">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="PagamentosParcelaProprietarioCPFCNPJ"
                                            NavigateUrl="~/_Pagamentos/forms/FParcelasProprietarioCNPJ.aspx"
                                            Text="Parcelas CPF/CNPJ" ToolTip="Parcelas Proprietário CPF/CNPJ">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="PagamentosParcelaAgrupadas"
                                            NavigateUrl="~/_Pagamentos/forms/FParcelasRajada.aspx" Text="Parcelas Agrup."
                                            ToolTip="Parcelas Agrupadas">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="PagamentosCancelamento" Text="Cancelamento" NavigateUrl="~/_Pagamentos/forms/FParcelasCancelamento.aspx" ToolTip="Cancelamento Pagamento">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="PagamentosDesmenbramento" Text="Desmembramento" NavigateUrl="~/_Pagamentos/forms/FParcelasDesmembramento.aspx" ToolTip="Desmembramento">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="PagamentosDesmenbramentoRajada"
                                            NavigateUrl="~/_Pagamentos/forms/FParcelasDesmembramentoRajada.aspx"
                                            Text="Desmem. Rajada" ToolTip="Desmembramento Rajada">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="PagamentosNovaParcela" Text="Nova Parcela" NavigateUrl="~/_Pagamentos/forms/FParcelasNova.aspx" ToolTip="Nova Parcela">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="PagamentosNovaParcelaRajada"
                                            NavigateUrl="~/_Pagamentos/forms/FParcelasNovaRajada.aspx"
                                            Text="Nova Parcela Rajada" ToolTip="Nova Parcela Rajada">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="PagamentosExcluirParcela" Text="Excluir Parcela" NavigateUrl="~/_Pagamentos/forms/FParcelasExcluir.aspx" ToolTip="Excluir Parcela">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="PagamentosFluxoParcela" Text="Fluxo Parcela" ToolTip="Fluxo Parcela" NavigateUrl="~/_Pagamentos/forms/FParcelasFluxo.aspx">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="PagamentosVencimento" Text="Vencimento no Mês"
                                            NavigateUrl="~/_Pagamentos/forms/FParcelasVencimento.aspx"
                                            ToolTip="Vencimento dentro do Mês">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="PagamentosVencimentoForaMes"
                                            NavigateUrl="~/_Pagamentos/forms/FParcelasVencimentoForaMes.aspx"
                                            Text="Vencimento Fora Mês" ToolTip="Vencimento fora do Mês">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="PagamentosTipoCobrança" Text="Tipo Cobrança" NavigateUrl="~/_Pagamentos/forms/FParcelasTipoCobranca.aspx" ToolTip="Tipo Cobrança">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="PagamentosProtesto" Text="Protesto" NavigateUrl="~/_Pagamentos/forms/FParcelasProtesto.aspx" ToolTip="Protesto">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="PagamentosContabil"
                                            NavigateUrl="~/_Pagamentos/forms/FParcelasContabil.aspx" Text="Contabil" ToolTip="Contabil">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="PagamentosPeriodicidade"
                                            NavigateUrl="~/_Pagamentos/forms/FParcelasPeriodicidade.aspx"
                                            Text="Periodicidade Juros" ToolTip="Periodicidade Juros">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="PagamentosCobrancaBancaria" Text="Cob. Bancária" ToolTip="Cobrança Bancária">
                                            <Nodes>
                                                <dx:TreeViewNode Name="CobrancaBancariaBoleto" Text="2a. Via Boleto"
                                                    NavigateUrl="~/_Pagamentos/forms/FCobrancaBoletos.aspx"
                                                    ToolTip="2a. Via Boleto">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="CobrancaBancariaConfig"
                                                    Text="Configuração Cobrança Bancária"
                                                    NavigateUrl="~/_Pagamentos/forms/FCobrancaConfiguracao.aspx"
                                                    ToolTip="Configuração Cobrança Bancária">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="CobrancaBancariaRemessa" Text="Arquivo de Remessa"
                                                    NavigateUrl="~/_Pagamentos/forms/FCobrancaRemessa.aspx"
                                                    ToolTip="Arquivo de Remessa">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="CobrancaBancariaRetorno" Text="Arquivo de Retorno"
                                                    NavigateUrl="~/_Pagamentos/forms/FCobrancaRetorno.aspx"
                                                    ToolTip="Arquivo de Retorno">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="PagamentosCobrancaNaoBancaria"
                                            Text="Cob. Não Bancária" ToolTip="Cobrança Não Bancária">
                                            <Nodes>
                                                <dx:TreeViewNode Name="CobrancaNaoBancariaConfig"
                                                    NavigateUrl="~/_Pagamentos/forms/FCobrancaConfiguracaoNaoBancaria.aspx"
                                                    Text="Configuração Cobrança Não Bancária"
                                                    ToolTip="Configuração Cobrança Não Bancária">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="CobrancaNaoBancariaRetorno"
                                                    NavigateUrl="~/_Pagamentos/forms/FCobrancaNaoBancariaRetorno.aspx"
                                                    Text="Arquivo Retorno" ToolTip="Arquivo Retorno">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="PagamentosRelatorios" Text="Relatórios" ToolTip="Relatórios">
                                            <Nodes>
                                                <dx:TreeViewNode Name="PagamentosRelatoriosExtratoFinanciamento" NavigateUrl="~/_Pagamentos/relatorios/FRelPagamentosExtFinanciamento.aspx"
                                                    Text="Financiamento" ToolTip="Relatório Extrato de Financiamento">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="PagamentosRelatoriosExtratoFinanciamentoCorrigido"
                                                    NavigateUrl="~/_Pagamentos/relatorios/FRelPagamentosExtFinanciamentoCorrigido.aspx"
                                                    Text="Financ. Corrigido" ToolTip="Relatório Extrato de Financiamento Corrigido">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="PagamentosRelatoriosExtratoCorrecao" NavigateUrl="~/_Pagamentos/relatorios/FRelPagamentosExtCorrecao.aspx"
                                                    Text="Correção" ToolTip="Relatório Extrato Correção">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="PagamentosRelatoriosParcelas" Text="Parcelas" NavigateUrl="~/_Pagamentos/relatorios/FRelPagamentosFluxoParcelas.aspx"
                                                    ToolTip="Fluxo de Parcelas do Financiamento">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="PagamentosRelatoriosContabilizacao" Text="Contabilização"
                                                    NavigateUrl="~/_Pagamentos/relatorios/FRelPagamentosContabil.aspx"
                                                    ToolTip="Relatório Contabilização de Recebimentos">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="PagamentosRelatoriosPagamentos" Text="Pagamentos" NavigateUrl="~/_Pagamentos/relatorios/FRelPagamentosPagamentos.aspx"
                                                    ToolTip="Relatório Pagamentos de Parcela">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="PagamentosRelatoriosParcelasDevedores" Text="Devedores" NavigateUrl="~/_Pagamentos/relatorios/FRelPagamentosDevedores.aspx"
                                                    ToolTip="Relatório Devedores de Parcelas">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="PagamentosRelatoriosParcelasInadimplentes" Text="Inadimplentes"
                                                    NavigateUrl="~/_Pagamentos/relatorios/FRelPagamentosInadimplentes.aspx"
                                                    ToolTip="Relatório Relatório Inadimplentes">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="PagamentosRelatoriosSaldoDevedor" Text="Saldo Devedor" NavigateUrl="~/_Pagamentos/relatorios/FRelPagamentosSaldoDevedor.aspx"
                                                    ToolTip="Relatório Saldo Devedor">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="PagamentosRelatoriosSaldoCredor" Text="Saldo Credor" NavigateUrl="~/_Pagamentos/relatorios/FRelPagamentosSaldoCredor.aspx"
                                                    ToolTip="Relatório Saldo Credor">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                    </Nodes>
                                </dx:TreeViewNode>
                                <dx:TreeViewNode Text="A Pagar" Name="ContasaPagar">
                                    <Image Url="~/images/Botoes/bAPAGAR.jpg" Height="35px" Width="35px">
                                    </Image>
                                    <TextStyle ForeColor="#000099" VerticalAlign="Middle" HorizontalAlign="Center">
                                    </TextStyle>
                                    <Nodes>
                                        <dx:TreeViewNode Name="ContasaPagarLancamentos" Text="Lançamentos" NavigateUrl="~/_APagar/forms/FAPagarLancamentos.aspx" ToolTip="Lançamentos">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ContasaPagarLancamentosAltera"
                                            NavigateUrl="~/_APagar/forms/FAPagarLancamentosAltera.aspx" Text="Altera" ToolTip="Altera Lançamentos">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ContasaPagarLancamentosExcluir"
                                            NavigateUrl="~/_APagar/forms/FAPagarLancamentosExcluir.aspx" Text="Excluir" ToolTip="Excluir Lançamentos">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ContasaPagarConsultaLancamentos" NavigateUrl="~/_APagar/forms/FAPagarConsulta.aspx"
                                            Text="Consulta" ToolTip="Consulta Lançamentos">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ContasaPagarRelatorios" Text="Relatórios">
                                            <Nodes>
                                                <dx:TreeViewNode Name="ContasaPagarRelatoriosLancamentos" Text="Lançamentos" NavigateUrl="~/_APagar/relatorios/FRelAPagarLancamentos.aspx"
                                                    ToolTip="Relatório Contas a Pagar Lançamentos">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="ContasaPagarRelatoriosFornecedores" Text="Fornecedores" NavigateUrl="~/_APagar/relatorios/FRelAPagarFornecedores.aspx"
                                                    ToolTip="Relatório Fornecedores Cadastro">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="ContasaPagarRelatoriosDespesas" Text="Despesas" ToolTip="Relatório Classificação de Despesas"
                                                    NavigateUrl="~/_APagar/relatorios/FRelAPagarDespesas.aspx">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="ContasaPagarRelatoriosCheques" Text="Cheques"
                                                    ToolTip="Relatório Cheques"
                                                    NavigateUrl="~/_APagar/relatorios/FRelAPagarCheques.aspx">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ContasaPagarMalaDireta" Text="Mala Direta" ToolTip="Mala Direta">
                                            <Nodes>
                                                <dx:TreeViewNode Name="ContasaPagarMalaDiretaEmitirMD" Text="Emitir Mala Direta"
                                                    NavigateUrl="~/_APagar/relatorios/FRelApagarMalaDireta.aspx" ToolTip="Emitir Mala Direta">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ContasaPagarImportacao" Text="Importação" ToolTip="Importação">
                                            <Nodes>
                                                <dx:TreeViewNode Name="ContasaPagarImportacaoArquivoTexto" Text="Arquivo Texto" NavigateUrl="~/_APagar/forms/FAPagarImportacaoArquivo1.aspx"
                                                    ToolTip="Arquivo Texto">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ContasaPagarTabelas" Text="Tabelas" ToolTip="Tabelas">
                                            <Nodes>
                                                <dx:TreeViewNode Name="ContasaPagarTabelasDespesas" Text="Despesas" NavigateUrl="~/_APagar/forms/FTabelaDespesas.aspx" ToolTip="Despesas">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="ContasaPagarTabelasFornecedores" Text="Fornecedores" NavigateUrl="~/_APagar/forms/FTabelaFornecedores.aspx" ToolTip="Fornecedores">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                    </Nodes>
                                </dx:TreeViewNode>
                                <dx:TreeViewNode Text="A Receber" Name="ContasaReceber">
                                    <Image Url="~/images/Botoes/bARECEBER.jpg" Height="35px" Width="35px">
                                    </Image>
                                    <TextStyle ForeColor="#000099" VerticalAlign="Middle" HorizontalAlign="Center">
                                    </TextStyle>
                                    <Nodes>
                                        <dx:TreeViewNode Name="ContasaReceberLancamentos" Text="Lançamentos" NavigateUrl="~/_AReceber/forms/FAReceberLancamentos.aspx" ToolTip="Lançamentos">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ContasaReceberLancamentosAltera"
                                            NavigateUrl="~/_AReceber/forms/FAReceberLancamentosAltera.aspx" Text="Altera" ToolTip="Altera Lançamentos">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ContasaReceberLancamentosExcluir"
                                            NavigateUrl="~/_AReceber/forms/FAReceberLancamentosExcluir.aspx" Text="Excluir" ToolTip="Excluir Lançamentos">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ContasaReceverConsultaLancamentos" NavigateUrl="~/_AReceber/forms/FAReceberConsulta.aspx"
                                            Text="Consulta" ToolTip="Consulta Lançamentos">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ContasaReceberGeracaoLancamentos" Text="Geração" ToolTip="Geração de Lançamentos de Receita Oriundos de Financiamentos"
                                            NavigateUrl="~/_AReceber/forms/FAReceberGeracao.aspx">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ContasaReceberRelatorios" Text="Relatórios" ToolTip="Relatórios">
                                            <Nodes>
                                                <dx:TreeViewNode Name="ContasaReceberRelatoriosLancamentos" Text="Lançamentos" NavigateUrl="~/_AReceber/relatorios/FRelAReceberLancamentos.aspx"
                                                    ToolTip="Relatório Contas a Receber Lançamentos">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="ContasaReceberRelatoriosClientes" Text="Clientes" NavigateUrl="~/_AReceber/relatorios/FRelAReceberClientes.aspx"
                                                    ToolTip="Relatório de Clientes Cadastro">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="ContasaReceberRelatoriosReceitas" Text="Receitas" NavigateUrl="~/_AReceber/relatorios/FRelAReceberReceitas.aspx"
                                                    ToolTip="Classificação de Receitas">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="ContasaReceberRelatoriosDepositos" Text="Depósitos"
                                                    ToolTip="Relatório de Depósitos"
                                                    NavigateUrl="~/_AReceber/relatorios/FRelAReceberDepositos.aspx">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ContasaReceberImportacao" Text="Importação" ToolTip="Importação">
                                            <Nodes>
                                                <dx:TreeViewNode Name="ContasaReceberImportacaoArquivoTexto" Text="Arquivo Texto"
                                                    NavigateUrl="~/_AReceber/forms/FAReceberImportacaoArquivo1.aspx" ToolTip="Arquivo Texto">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ContasaReceberTabelas" Text="Tabelas" ToolTip="Tabelas">
                                            <Nodes>
                                                <dx:TreeViewNode Name="ContasaReceberTabelasReceitas" Text="Receitas" NavigateUrl="~/_AReceber/forms/FTabelaReceitas.aspx" ToolTip="Tabela Receita">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="ContasaReceberTabelasClientes" Text="Clientes" NavigateUrl="~/_AReceber/forms/FTabelaClientes.aspx" ToolTip="Tabela Cliente">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                    </Nodes>
                                </dx:TreeViewNode>
                                <dx:TreeViewNode Text="Bancos" Name="Bancos" ToolTip="Bancos">
                                    <Image Height="35px" Url="~/images/Botoes/bBANCOS.jpg" Width="35px">
                                    </Image>
                                    <TextStyle ForeColor="#000099" VerticalAlign="Middle" HorizontalAlign="Center">
                                    </TextStyle>
                                    <Nodes>
                                        <dx:TreeViewNode Name="BancosMovimentacoes" Text="Movimentações" NavigateUrl="~/_Bancos/forms/FMovimentacao.aspx" ToolTip="Movimentações">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="BancosGeracao" NavigateUrl="~/_Bancos/forms/FBancosGeracao.aspx"
                                            Text="Geração" ToolTip="Geração de Lançamentos C. Pagar e C. Receber">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="BancosCheques" Text="Cheques" NavigateUrl="~/_Bancos/forms/FAPagarChequesCompensados.aspx" ToolTip="Cheques">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="BancosDepositos" Text="Depósitos" NavigateUrl="~/_Bancos/forms/FAReceberDepositosCompensados.aspx" ToolTip="Depósitos">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="BancosResumo" Text="Resumo" NavigateUrl="~/_Bancos/forms/FResumoSaldoContas.aspx" ToolTip="Resumo">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="BancosRelatorios" Text="Relatórios" ToolTip="Relatórios">
                                            <Nodes>
                                                <dx:TreeViewNode Name="BancosRelatoriosDepositos" Text="Depósitos" NavigateUrl="~/_Bancos/relatorios/FRelBancosDepositos.aspx"
                                                    ToolTip="Depósitos Compensação">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="BancosRelatoriosCheques" Text="Cheques" NavigateUrl="~/_Bancos/relatorios/FRelBancosCheques.aspx"
                                                    ToolTip="Cheques Compensação">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="BancosRelatoriosExtratoMovimentacao" Text="Movimentação" NavigateUrl="~/_Bancos/relatorios/FRelBancosMovimentacao.aspx"
                                                    ToolTip="Extrato Movimentação">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="BancosRelatoriosCaixaDiario" Text="Caixa Diário" NavigateUrl="~/_Bancos/relatorios/FRelBancosCaixaDiario.aspx"
                                                    ToolTip="Relatório de Caixa Diário">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="BancosRelatoriosResumoContas" Text="Resumo Contas" NavigateUrl="~/_Bancos/relatorios/FRelBancosResumoContas.aspx"
                                                    ToolTip="Relatório Resumo Contas">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="BancosTabelas" Text="Tabelas" ToolTip="Tabelas">
                                            <Nodes>
                                                <dx:TreeViewNode Name="ContasaReceberTabelasBancos" Text="Bancos" NavigateUrl="~/_Bancos/forms/FTabelaBancos.aspx" ToolTip="Tabela Bancos">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="ContasaReceberTabelasNaoBancos"
                                                    NavigateUrl="~/_Bancos/forms/FTabelaNaoBancos.aspx" Text="Não Bancos" ToolTip="Tabela Não Bancos">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="ContasaReceberTabelasContasCorrentes" Text="Contas Correntes"
                                                    NavigateUrl="~/_Bancos/forms/FTabelaContas.aspx" ToolTip="Tabela Contas Correntes">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="BancosTabelasSaldos" Text="Saldos Iniciais" NavigateUrl="~/_Bancos/forms/FTabelaContasSaldoInicial.aspx" ToolTip="Tabela Saldos Iniciais">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                    </Nodes>
                                </dx:TreeViewNode>
                                <dx:TreeViewNode Text="Fluxo Caixa" Name="FluxoCaixa" ToolTip="Relatórios de Fluxo Caixa">
                                    <Image Url="~/images/Botoes/bANALISES.jpg" Height="35px" Width="35px">
                                    </Image>
                                    <TextStyle ForeColor="#000099" VerticalAlign="Middle" HorizontalAlign="Center">
                                    </TextStyle>
                                    <Nodes>
                                        <dx:TreeViewNode Name="AnalisesFluxoCaixaDiario" Text="Diário" NavigateUrl="~/_FCaixa/relatorios/FRelFCaixaDiario.aspx"
                                            ToolTip="Relatório de Fluxo de Caixa Diário">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="AnalisesFluxoCaixaTotal" NavigateUrl="~/_FCaixa/relatorios/FRelFCaixaTotal.aspx"
                                            Text="Total" ToolTip="Relatório de Fluxo de Caixa Total por Período">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="AnalisesFluxoCaixaMensal"
                                            NavigateUrl="~/_FCaixa/relatorios/FRelFCaixaMensal.aspx" Text="Mensal"
                                            ToolTip="Relatório de Fluxo de Caixa Mensal">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="AnalisesFluxoCaixaTrimestral"
                                            NavigateUrl="~/_FCaixa/relatorios/FRelFCaixaTrimestral.aspx" Text="Trimestral"
                                            ToolTip="Relatório de Fluxo de Caixa Trimestral">
                                        </dx:TreeViewNode>
                                    </Nodes>
                                </dx:TreeViewNode>
                                <dx:TreeViewNode Name="Contabil" Text="Contábil" ToolTip="Integração Contábil">
                                    <Image Height="35px" Url="~/images/Botoes/bCONTABIL.jpg" Width="35px">
                                    </Image>
                                    <TextStyle ForeColor="#000099" HorizontalAlign="Center" VerticalAlign="Middle">
                                    </TextStyle>
                                    <Nodes>
                                        <dx:TreeViewNode Name="ContabilFolhadePagamento" Text="Folha de Pagamento" ToolTip="Folha de Pagamento">
                                            <Nodes>
                                                <dx:TreeViewNode Text="Em Desenvolvimento" ToolTip="Em Desenvolvimento">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Text="Utilitários" Name="Utilitarios" ToolTip="Utilitários">
                                            <TextStyle ForeColor="#000099" HorizontalAlign="Center" VerticalAlign="Middle">
                                            </TextStyle>
                                            <Nodes>
                                                <dx:TreeViewNode Name="UtilitariosExportacaoProsoft" Text="Exportação Prosoft"
                                                    ToolTip="Exportação Contabilidade Prosoft">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="UtilitariosExportacaoCEF" Text="Exportação CEF"
                                                    ToolTip="Exportação para Caixa Econômica Federal">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="UtilitariosExportacaoPIS" Text="Exportação PIS">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                    </Nodes>
                                </dx:TreeViewNode>
                                <dx:TreeViewNode Name="Juridico" Text="Jurídico" ToolTip="Jurídico">
                                    <Image Height="35px" Url="~/images/Botoes/bJURIDICO.jpg" Width="35px">
                                    </Image>
                                    <TextStyle ForeColor="#000099" HorizontalAlign="Center" VerticalAlign="Middle">
                                    </TextStyle>
                                    <Nodes>
                                        <dx:TreeViewNode Text="Teste" ToolTip="Teste">
                                        </dx:TreeViewNode>
                                    </Nodes>
                                </dx:TreeViewNode>
                                <dx:TreeViewNode Text="Config" Name="Config" ToolTip="Configurações">
                                    <Image Url="~/images/Botoes/bCONFIG.jpg" Height="35px" Width="35px">
                                    </Image>
                                    <TextStyle ForeColor="#000099" VerticalAlign="Middle" HorizontalAlign="Center">
                                    </TextStyle>
                                    <Nodes>
                                        <dx:TreeViewNode Name="ConfigPermissoes" Text="Permissões" NavigateUrl="~/_Config/forms/FSelecionaPermissao.aspx" ToolTip="Permissões">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ConfigParametros" Text="Parâmetros" NavigateUrl="~/_Config/forms/FSelecionaParametro.aspx" ToolTip="Parâmetros">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ConfigUsuarios" Text="Usuários" ToolTip="Usuários">
                                            <Nodes>
                                                <dx:TreeViewNode Name="ConfigUsuariosUsuarios" NavigateUrl="~/_Config/forms/FSelecionaUsuario.aspx"
                                                    Text="Usuários" ToolTip="Usuários">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="ConfigUsuariosPermissoes" NavigateUrl="~/_Config/forms/FSelecionaUsuarioPermissao.aspx"
                                                    Text="Permissões Usuário" ToolTip="Permissões Usuário">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ConfigPerfil" Text="Perfil Usuários" ToolTip="Perfil Usuários">
                                            <Nodes>
                                                <dx:TreeViewNode Name="ConfigUsuariosPerfil"
                                                    NavigateUrl="~/_Config/forms/FSelecionaPerfil.aspx" Text="Perfil" ToolTip="Perfil">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="ConfigUsuariosPermissoesPerfil"
                                                    NavigateUrl="~/_Config/forms/FSelecionaUsuarioPermissaoPerfil.aspx"
                                                    Text="Permissões Perfil" ToolTip="Permissões Perfil">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="ConfigUsuariosPerfilAssociacao" Text="Associar Perfil"
                                                    ToolTip="Associar perfil ao Usuário">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ConfigAnalises" Text="Análises" ToolTip="Análises LOG">
                                            <Nodes>
                                                <dx:TreeViewNode Name="ConfigAnalisesSegurança" Text="Segurança" NavigateUrl="~/_Config/forms/FSelecionaUsuarioAnaliseSeguranca.aspx" ToolTip="LOG Segurança">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="ConfigAnalisesAções"
                                                    NavigateUrl="~/_Config/forms/FSelecionaUsuarioAnaliseAcoes.aspx" Text="Ações" ToolTip="LOG Ações">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ConfigEMail" Text="E-Mail" ToolTip="E-Mail">
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ConfigAmbiente" Text="Ambiente" ToolTip="Ambiente">
                                            <Nodes>
                                                <dx:TreeViewNode Name="ConfigAmbienteStatus" NavigateUrl="~/_Config/forms/FAmbienteStatus.aspx"
                                                    Text="Status" ToolTip="Status do Ambiente">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="ConfigAmbienteEstatisticas" Text="Estatísticas" NavigateUrl="~/_Config/forms/FAmbienteEstatisticas.aspx"
                                                    ToolTip="Estatísticas Quantitativa do Ambiente ">
                                                </dx:TreeViewNode>
                                                <dx:TreeViewNode Name="ConfigBrowserStatus"
                                                    NavigateUrl="~/_Config/forms/FBrowserStatus.aspx" Text="Browser"
                                                    ToolTip="Status do Browser Atual">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ConfigAmbienteMigracoes" Text="Migrações" ToolTip="Migrações Sistema DOS">
                                            <Nodes>
                                                <dx:TreeViewNode Name="ConfigAmbienteMigracoesSimbolo" NavigateUrl="~/_Config/forms/FMigracoesSimbolo.aspx"
                                                    Text="Símbolo" ToolTip="Migração de dados do sistema Símbolo(DOS)">
                                                </dx:TreeViewNode>
                                            </Nodes>
                                        </dx:TreeViewNode>
                                        <dx:TreeViewNode Name="ConfigEditor" Text="Editor" ToolTip="Editor HTML para documentos"
                                            NavigateUrl="~/_Config/forms/FEditorHtml.aspx">
                                        </dx:TreeViewNode>
                                    </Nodes>
                                </dx:TreeViewNode>
                            </Nodes>
                        </dx:ASPxTreeView>
                    </dx:SplitterContentControl>
                </ContentCollection>
            </dx:SplitterPane>
            <dx:SplitterPane Name="ContentUrlPane" ScrollBars="Auto" ContentUrlIFrameName="contentUrlPane"
                ContentUrl="FundoPadrao.aspx" ShowSeparatorImage="True" Size="500px">
                <PaneStyle>
                    <Border BorderStyle="None" BorderWidth="0px" />
                    <BorderLeft BorderStyle="None" BorderWidth="0px" />
                    <BorderTop BorderStyle="None" BorderWidth="0px" />
                    <BorderRight BorderStyle="None" BorderWidth="0px" />
                    <BorderBottom BorderStyle="None" BorderWidth="0px" />
                    <Border BorderStyle="None" BorderWidth="0px"></Border>
                    <BorderLeft BorderStyle="None" BorderWidth="0px"></BorderLeft>
                    <BorderTop BorderStyle="None" BorderWidth="0px"></BorderTop>
                    <BorderRight BorderStyle="None" BorderWidth="0px"></BorderRight>
                    <BorderBottom BorderStyle="None" BorderWidth="0px"></BorderBottom>
                </PaneStyle>
                <ContentCollection>
                    <dx:SplitterContentControl ID="SplitterContentControl1" runat="server">
                    </dx:SplitterContentControl>
                </ContentCollection>
            </dx:SplitterPane>
        </Panes>
        <Styles>
            <Separator VerticalAlign="Top">
            </Separator>
        </Styles>
    </dx:ASPxSplitter>
</asp:Content>

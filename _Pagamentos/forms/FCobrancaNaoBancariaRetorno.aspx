<%@ Page Title="FCobrancaNaoBancariaRetorno" Language="C#" AutoEventWireup="true"
    CodeFile="FCobrancaNaoBancariaRetorno.aspx.cs" Inherits="FCobrancaNaoBancariaRetorno"
    StylesheetTheme="Principal" %>

<%@ Register Assembly="DevExpress.XtraReports.v13.2.Web, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxFileManager" TagPrefix="dx1" %>
<%@ Register Assembly="eWorld.UI, Version=2.0.6.2393, Culture=neutral, PublicKeyToken=24d65337282035f2"
    Namespace="eWorld.UI" TagPrefix="ew" %>
<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx2" %>
<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxNavBar" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxFormLayout" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx3" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server"></script>
<script type="text/javascript" src="../../Scripts/jquery-1.6.3.min.js"></script>
<script type="text/javascript" src="../../Scripts/toastr.min.js"></script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Gitano - Pagamentos - Cobrança Não Bancária - Retorno</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <link href="../../content/toastr.css" rel="stylesheet" />
</head>
<body style="height: 1400px">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager" runat="server" />
        <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1400px">
            <ContentTemplate>
                <h1>COBRANÇA NÂO BANCÁRIA - RETORNO</h1>
                <h2>Retorno de Arquivos Cobrança não Bancária</h2>
                <div id="DivNova" style="border-style: none">
                    <div style="border: 1px solid #808080; z-index: 1; left: 35px; top: 100px; position: absolute; height: 1400px; width: 832px; text-align: center;">
                        <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px; position: absolute"
                            Text="Selecione" Theme="PlasticBlue"></asp:Label>
                        <asp:Label ID="Label3" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 15px; position: absolute"
                            Text="Origem" Theme="PlasticBlue"></asp:Label>
                        <dx:ASPxComboBox ID="cbbanco" runat="server" ValueType="System.String" Font-Bold="True"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt; top: 15px; left: 150px;"
                            Width="380px" Theme="PlasticBlue"
                            OnSelectedIndexChanged="cbbanco_SelectedIndexChanged" AutoPostBack="True">
                        </dx:ASPxComboBox>
                        <asp:Label ID="Label4" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 50px; position: absolute"
                            Text="Drive\Pasta" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edcaminho" runat="server" Style="z-index: 2; left: 150px; top: 50px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="450px" Visible="False"
                            AutoPostBack="True">
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label13" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 85px; position: absolute"
                            Text="Arquivo\Extensão" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="ednomearquivo" runat="server" Style="z-index: 2; left: 150px; top: 85px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="380px"
                            Visible="False" AutoPostBack="True" Text="DemoRecDesp">
                        </dx:ASPxTextBox>
                        <dx:ASPxTextBox ID="edextensao" runat="server" Style="z-index: 2; left: 550px; top: 85px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="50px" Visible="False"
                            AutoPostBack="True" Text="CSV">
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label5" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 125px; position: absolute"
                            Text="Feedback" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edfeedback" runat="server" Style="z-index: 2; left: 150px; top: 125px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="650px" Visible="False"
                            AutoPostBack="True" ReadOnly="True">
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label7" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 160px; position: absolute; right: 722px;"
                            Text="Dif. Aceitável R$" Theme="PlasticBlue"
                            Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="eddiferença" runat="server" Style="z-index: 2; left: 150px; top: 160px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="380px" Visible="False"
                            AutoPostBack="True" ReadOnly="True">
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label9" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 195px; position: absolute; right: 689px;"
                            Text="Pesquisa Parcela" Theme="PlasticBlue"
                            Visible="False"></asp:Label>
                        <dx:ASPxCheckBox ID="ckpesquisaparcela" runat="server" Style="z-index: 2; left: 150px; top: 195px; position: absolute; right: 562px;"
                            AutoPostBack="True" CheckState="Unchecked"
                            Font-Bold="False" Font-Names="Calibri" Font-Size="14px" ForeColor="#3E5395" Height="21px"
                            Text=" " Theme="PlasticBlue" Width="120px">
                        </dx:ASPxCheckBox>
                        <asp:Label ID="Label8" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 295px; top: 195px; position: absolute; right: 301px;"
                            Text="Não Processa Plano 1/1 - 1/2 - 2/2" Theme="PlasticBlue"></asp:Label>
                        <dx:ASPxCheckBox ID="ckplano1x1" runat="server" Style="z-index: 2; left: 550px; top: 195px; position: absolute; right: 287px; width: 75px;"
                            AutoPostBack="True" CheckState="Unchecked"
                            Font-Bold="False" Font-Names="Calibri" Font-Size="14px"
                            ForeColor="#3E5395" Height="21px"
                            Text=" " Theme="PlasticBlue">
                        </dx:ASPxCheckBox>
                        <asp:Label ID="Label10" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 230px; position: absolute; right: 632px;"
                            Text="Não Baixar Parcela já Paga" Theme="PlasticBlue"></asp:Label>
                        <dx:ASPxCheckBox ID="ckbaixarparcelapaga" runat="server" Style="z-index: 2; left: 200px; top: 230px; position: absolute; right: 287px; width: 75px;"
                            AutoPostBack="True" CheckState="Unchecked"
                            Font-Bold="False" Font-Names="Calibri" Font-Size="14px"
                            ForeColor="#3E5395" Height="21px"
                            Text=" " Theme="PlasticBlue">
                        </dx:ASPxCheckBox>
                        <asp:Label ID="Label2" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 260px; position: absolute"
                            Text="Conteúdo Arquivo Retorno (Texto)" Theme="PlasticBlue"
                            Visible="False"></asp:Label>
                        <dx:ASPxMemo ID="memoarquivo" runat="server" BackColor="White" Font-Bold="False"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 295px; position: absolute"
                            Height="200px" Width="800px" AutoPostBack="True"
                            ReadOnly="True">
                            <FocusedStyle Wrap="True">
                            </FocusedStyle>
                            <InvalidStyle Wrap="True">
                            </InvalidStyle>
                        </dx:ASPxMemo>
                        <asp:Label ID="Label6" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 515px; position: absolute"
                            Text="Conteúdo Arquivo Retorno (Registros)" Theme="PlasticBlue"
                            Visible="False"></asp:Label>
                        <div style="border: 1px solid #808080; z-index: 1; left: 10px; top: 550px; position: absolute; height: 480px; width: 810px; text-align: center;">
                            <dx3:ASPxGridView ID="GridListagem" runat="server" EnableTheming="True" Font-Bold="False"
                                KeyFieldName="ID" Style="margin-top: 6px; margin-left: 6px; margin-right: 6px;" Theme="PlasticBlue" Width="790px"
                                Visible="False" AutoGenerateColumns="False">
                                <SettingsBehavior ColumnResizeMode="Control" ConfirmDelete="True" />
                                <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                                <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                                    VerticalScrollableHeight="400" HorizontalScrollBarMode="Visible"
                                    VerticalScrollBarMode="Visible" />
                                <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                                    CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                                    CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Cobrança Não Bancária"
                                    Title="Verificar" />
                                <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                                <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                                <BackgroundImage HorizontalPosition="center" />
                                <Columns>
                                    <dx3:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Width="50px">
                                        <HeaderTemplate>
                                            <dx:ASPxCheckBox ID="ASPxCheckBox1" runat="server" ToolTip="Marca/Desmarca Todos os itens visíveis"
                                                ClientSideEvents-CheckedChanged="function(s, e) { GridListagem.SelectAllRowsOnPage(s.GetChecked()); }">
                                            </dx:ASPxCheckBox>
                                        </HeaderTemplate>
                                    </dx3:GridViewCommandColumn>
                                    <dx3:GridViewDataTextColumn Caption="ID" FieldName="ID" Name="ID"
                                        VisibleIndex="1" Width="50px">
                                        <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    </dx3:GridViewDataTextColumn>
                                    <dx3:GridViewDataTextColumn Caption="Pagamento" FieldName="data_pagamento" Name="data_pagamento"
                                        VisibleIndex="2" Width="100px">
                                        <PropertiesTextEdit>
                                            <MaskSettings Mask="dd/MM/yyyy" ShowHints="True" />
                                        </PropertiesTextEdit>
                                        <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    </dx3:GridViewDataTextColumn>
                                    <dx3:GridViewDataTextColumn Caption="Valor" FieldName="valor" Name="valor"
                                        VisibleIndex="3" Width="100px">
                                        <PropertiesTextEdit DisplayFormatInEditMode="true" DisplayFormatString="N"></PropertiesTextEdit>
                                        <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    </dx3:GridViewDataTextColumn>
                                    <dx3:GridViewDataTextColumn Caption="Valor Juros" FieldName="valor_juros" Name="valor_juros"
                                        VisibleIndex="4" Width="100px">
                                        <PropertiesTextEdit DisplayFormatInEditMode="true" DisplayFormatString="N"></PropertiesTextEdit>
                                        <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    </dx3:GridViewDataTextColumn>
                                    <dx3:GridViewDataTextColumn Caption="Valor Total" FieldName="valor_total" Name="valor_total"
                                        VisibleIndex="5" Width="100px">
                                        <PropertiesTextEdit DisplayFormatInEditMode="true" DisplayFormatString="N"></PropertiesTextEdit>
                                        <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    </dx3:GridViewDataTextColumn>
                                    <dx3:GridViewDataTextColumn Caption="Cedente" FieldName="conta_cedente" Name="conta_cedente"
                                        VisibleIndex="6" Width="100px">
                                        <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    </dx3:GridViewDataTextColumn>
                                    <dx3:GridViewDataTextColumn Caption="Cedente" FieldName="apelido_cedente" Name="apelido_cedente"
                                        VisibleIndex="7" Width="250px">
                                        <HeaderStyle Font-Bold="True" ForeColor="White" />
                                        <CellStyle HorizontalAlign="Left">
                                        </CellStyle>
                                    </dx3:GridViewDataTextColumn>
                                    <dx3:GridViewDataTextColumn Caption="Identificador" FieldName="identificador" Name="identificador"
                                        VisibleIndex="8" Width="100px">
                                        <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    </dx3:GridViewDataTextColumn>
                                    <dx3:GridViewDataTextColumn Caption="Plano" FieldName="plano" Name="plano"
                                        VisibleIndex="9" Width="100px">
                                        <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    </dx3:GridViewDataTextColumn>
                                    <dx3:GridViewDataTextColumn Caption="Vencimento" FieldName="data_vencimento" Name="data_vencimento"
                                        VisibleIndex="10" Width="100px">
                                        <PropertiesTextEdit>
                                            <MaskSettings Mask="dd/MM/yyyy" ShowHints="True" />
                                        </PropertiesTextEdit>
                                        <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    </dx3:GridViewDataTextColumn>
                                    <dx3:GridViewDataTextColumn Caption="Pagto. Base" FieldName="vlr_pgto_base" Name="vlr_pgto_base"
                                        VisibleIndex="11" Width="100px">
                                        <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    </dx3:GridViewDataTextColumn>
                                    <dx3:GridViewDataTextColumn Caption="Pagto. Base Juros"
                                        FieldName="vlr_pgto_juros" Name="vlr_pgto_juros"
                                        VisibleIndex="12" Width="100px">
                                        <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    </dx3:GridViewDataTextColumn>
                                    <dx3:GridViewDataTextColumn Caption="Pagto. Base Total"
                                        FieldName="vlr_pgto_total" Name="vlr_pgto_total"
                                        VisibleIndex="13" Width="100px">
                                        <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    </dx3:GridViewDataTextColumn>
                                    <dx3:GridViewDataTextColumn Caption="Venda ID" FieldName="venda_ID" Name="venda_ID"
                                        VisibleIndex="14" Width="100px">
                                        <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    </dx3:GridViewDataTextColumn>
                                    <dx3:GridViewDataTextColumn Caption="Venda Localizada"
                                        FieldName="venda_localizada" Name="venda_localizada"
                                        VisibleIndex="15" Width="100px">
                                        <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    </dx3:GridViewDataTextColumn>
                                    <dx3:GridViewDataTextColumn Caption="Parcela Sistema"
                                        FieldName="parcela_sistema" Name="parcela_sistema"
                                        VisibleIndex="16" Width="100px">
                                        <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    </dx3:GridViewDataTextColumn>
                                    <dx3:GridViewDataTextColumn Caption="Parcela Corrigida"
                                        FieldName="parcela_corrigida" Name="parcela_corrigida"
                                        VisibleIndex="17" Width="100px">
                                        <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    </dx3:GridViewDataTextColumn>
                                    <dx3:GridViewDataTextColumn Caption="Diferença" FieldName="diferenca" Name="diferenca"
                                        VisibleIndex="18" Width="100px">
                                        <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    </dx3:GridViewDataTextColumn>
                                    <dx3:GridViewDataTextColumn Caption="Parcela ID" FieldName="parcela_ID" Name="parcela_ID"
                                        VisibleIndex="19" Width="100px">
                                        <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    </dx3:GridViewDataTextColumn>
                                </Columns>
                                <SettingsPager Visible="False" PageSize="10000">
                                    <AllButton ImagePosition="Bottom" Visible="True">
                                    </AllButton>
                                </SettingsPager>
                                <SettingsPopup>
                                    <EditForm AllowResize="True" Height="350px" HorizontalAlign="WindowCenter" Modal="True"
                                        VerticalAlign="Above" Width="690px" />
                                    <CustomizationWindow HorizontalAlign="WindowCenter" VerticalAlign="Above" Height="350px"
                                        Width="690px" />
                                </SettingsPopup>
                                <Styles>
                                    <Header HorizontalAlign="Center" ForeColor="#FFF0D9" Font-Bold="True">
                                    </Header>
                                    <AlternatingRow Enabled="True">
                                    </AlternatingRow>
                                    <Cell HorizontalAlign="Right">
                                        <BackgroundImage Repeat="NoRepeat" />
                                        <BackgroundImage Repeat="NoRepeat" />
                                        <BackgroundImage Repeat="NoRepeat" />
                                        <BackgroundImage Repeat="NoRepeat" />
                                    </Cell>
                                    <LoadingPanel ForeColor="#3955A8" HorizontalAlign="Center">
                                        <BackgroundImage VerticalPosition="center" />
                                        <BackgroundImage VerticalPosition="center" />
                                        <BackgroundImage VerticalPosition="center" />
                                        <BackgroundImage VerticalPosition="center" />
                                    </LoadingPanel>
                                </Styles>
                                <StylesEditors>
                                    <LoadingPanel Font-Bold="False">
                                    </LoadingPanel>
                                </StylesEditors>
                                <StylesPopup>
                                    <EditForm>
                                        <MainArea>
                                            <Border BorderColor="WhiteSmoke" BorderWidth="10px" />
                                        </MainArea>
                                        <Content>
                                            <Border BorderColor="#3955A8" BorderWidth="5px" />
                                        </Content>
                                        <ModalBackground>
                                            <BackgroundImage ImageUrl="~/images/fundos/fundo_gitanoweb_grid.jpg" />
                                        </ModalBackground>
                                    </EditForm>
                                    <Common>
                                        <CloseButton ForeColor="#FF6699">
                                        </CloseButton>
                                        <ModalBackground Opacity="0">
                                        </ModalBackground>
                                    </Common>
                                </StylesPopup>
                            </dx3:ASPxGridView>
                        </div>
                        <div id="Div2" runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute; top: 15px; left: 610px; height: 50px; width: 200px;">
                            <dx:ASPxButton ID="btcarrega" runat="server" Height="40px" ImagePosition="Left" Width="45px"
                                OnClick="btcarrega_Click">
                                <Image Height="30px" ToolTip="Carregar Arquivo" Url="~/images/BotoesTelas/BTNpesquisarA.bmp"
                                    UrlDisabled="~/images/BotoesTelas/BTNpesquisarI.bmp" UrlPressed="~/images/BotoesTelas/BTNpesquisarS.bmp"
                                    Width="30px">
                                </Image>
                            </dx:ASPxButton>
                            <dx:ASPxButton ID="btprocessa" runat="server" Height="40px" ImagePosition="Left"
                                OnClick="btprocessa_Click" Width="45px">
                                <Image Height="30px" ToolTip="Processa" Url="~/images/BotoesTelas/BTNalterarA.bmp" UrlDisabled="~/images/BotoesTelas/BTNalterarI.bmp"
                                    UrlPressed="~/images/BotoesTelas/BTNalterarS.bmp" Width="30px">
                                </Image>
                            </dx:ASPxButton>
                            <dx:ASPxButton ID="btimprime" runat="server" Height="40px" ImagePosition="Left" Width="45px"
                                OnClick="btimprime_Click">
                                <Image Height="30px" ToolTip="Imprimir Recibo" Url="~/images/BotoesTelas/BTNimprimirA.bmp"
                                    UrlDisabled="~/images/BotoesTelas/BTNimprimirI.bmp" UrlPressed="~/images/BotoesTelas/BTNimprimirS.bmp"
                                    Width="30px">
                                </Image>
                            </dx:ASPxButton>
                            <dx:ASPxButton ID="bthelp" runat="server" AutoPostBack="False" Height="40px" ImagePosition="Left"
                                OnClick="bthelp_Click" Width="45px">
                                <Image Height="30px" ToolTip="Help\Ajuda\Orientações" Url="~/images/BotoesTelas/BTNhelpA.bmp"
                                    UrlDisabled="~/images/BotoesTelas/BTNhelpI.bmp" UrlPressed="~/images/BotoesTelas/BTNhelpS.bmp"
                                    Width="30px">
                                </Image>
                            </dx:ASPxButton>
                        </div>
                        <div runat="server" style="z-index: 2; position: absolute; top: 1100px; left: 10px; height: 200px; width: 378px;"
                            id="Div4">
                            <div>
                            </div>
                            <dx:ASPxPopupControl ID="Popuphelp" runat="server" LoadingPanelText="Carregando&amp;hellip;"
                                Theme="PlasticBlue" PopupElementID="bthelp" PopupVerticalAlign="Below" PopupHorizontalAlign="RightSides"
                                AllowDragging="True" ShowFooter="True" Width="310px" Height="160px" HeaderText="Ajuda do Sistema"
                                ClientInstanceName="Popuphelp" FooterText="Gitano Software">
                                <HeaderStyle Font-Bold="True" />
                                <ContentCollection>
                                    <dx:PopupControlContentControl ID="PopupControlContentControl" runat="server">
                                        <div style="vertical-align: middle">
                                            Arquivo Retorno Cobrança Não Bancária e Baixa.<br />
                                            <br />
                                            Captura de arquivo retorno de cobrança para não bancos.<br />
                                            <br />
                                            Localização das Parcelas correspondentes as informações recebidas.<br />
                                            <br />
                                            Baixa Automática de Pagamentos nos Financiamentos.<br />
                                            <br />
                                            Captura realizada de acordo com dados registrados em Configuração.<br />
                                            <br />
                                        </div>
                                    </dx:PopupControlContentControl>
                                </ContentCollection>
                            </dx:ASPxPopupControl>
                        </div>
                    </div>
                    <%--                <asp:UpdateProgress runat="server" ID="UpdateProgress" AssociatedUpdatePanelID="UpdatePanel"
                    DisplayAfter="0" DynamicLayout="false">
                    <ProgressTemplate>
                        <div id="div_aguarde" style="background-color: #FFFFFF">
                            <asp:Label ID="aguarde" runat="server" EnableDefaultAppearance="False" EnableTheming="True"
                                Font-Bold="True" Font-Names="Calibri" Font-Overline="False" Font-Size="15px"
                                Font-Underline="False" ForeColor="#194273" Theme="PlasticBlue">Aguarde</asp:Label>
                            <img alt="Processando..." src="~/images/gifs/carregando4.gif" style="z-index: 1; left: 0px;
                                top: 20px; position: absolute" />
                        </div>
                    </ProgressTemplate>
                </asp:UpdateProgress>--%>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>

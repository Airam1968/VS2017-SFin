<%@ Page Title="FPropostasConsulta" Language="C#" AutoEventWireup="true" CodeFile="FPropostasConsulta.aspx.cs"
    Inherits="FPropostasConsulta" StylesheetTheme="Principal" %>

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
    <title>Gitano - Propostas - Consulta</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <link href="../../content/toastr.css" rel="stylesheet" />
</head>
<body style="height: 2000px">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1200px">
        <ContentTemplate>
            <h1>
                PROPOSTAS - CONSULTA</h1>
            <h2>
                Consulta Propostas</h2>
            <div id="DivNova" style="border-style: none">
                <div style="border: 1px solid #808080; z-index: 1; left: 35px; top: 100px; position: absolute;
                    height: 2200px; width: 832px; text-align: center;">
                    <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px;
                        position: absolute" Text="Selecione" Theme="PlasticBlue"></asp:Label>
                    <asp:Label ID="Label3" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 15px;
                        position: absolute" Text="Produto" Theme="PlasticBlue"></asp:Label>
                    <dx:ASPxComboBox ID="cbproduto" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 40px; left: 10px;" Width="400px" Theme="PlasticBlue"
                        OnSelectedIndexChanged="cbproduto_SelectedIndexChanged" AutoPostBack="True">
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label2" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 70px;
                        position: absolute" Text="Grupo" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxComboBox ID="cbgrupo" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 95px; left: 10px;" Width="400px" Theme="PlasticBlue"
                        OnSelectedIndexChanged="cbgrupo_SelectedIndexChanged" Visible="False" AutoPostBack="True">
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label5" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 135px;
                        position: absolute" Text="OU" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <asp:Label ID="Label4" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 165px;
                        position: absolute" Text="Nome" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="ednome" runat="server" Style="z-index: 2; left: 9px; top: 200px;
                        position: absolute;" Theme="PlasticBlue" Width="400px" Visible="False" AutoPostBack="True"
                        OnTextChanged="ednome_TextChanged">
                    </dx:ASPxTextBox>
                    <dx3:ASPxGridView ID="GridListagem" runat="server" AutoGenerateColumns="False" EnableTheming="True"
                        Font-Bold="False" KeyFieldName="proposta" Style="margin-right: 6px; position: absolute;
                        top: 240px; left: 10px;" Theme="PlasticBlue" Width="812px" Visible="False" OnCommandButtonInitialize="GridListagem_CommandButtonInitialize"
                        OnInitNewRow="GridListagem_InitNewRow" OnRowDeleting="GridListagem_RowDeleting"
                        OnRowInserting="GridListagem_RowInserting" OnRowUpdating="GridListagem_RowUpdating">
                        <SettingsBehavior AllowSelectByRowClick="True" ColumnResizeMode="Control" ConfirmDelete="True"
                            AllowSelectSingleRowOnly="True" />
                        <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                        <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                            VerticalScrollableHeight="400" HorizontalScrollBarMode="Visible" />
                        <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                            CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                            CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Unidades do Produto"
                            Title="Verificar" />
                        <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                        <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                        <BackgroundImage HorizontalPosition="center" />
                        <Columns>
                            <dx3:GridViewCommandColumn ButtonType="Image" Caption=" Ação" ToolTip="Ações de Manutenção da Tabela"
                                VisibleIndex="8" Width="50px">
                                <EditButton Text="Alterar" Visible="True">
                                    <Image AlternateText="Alterar" Height="25px" ToolTip="Alterar" Url="~/images/BotoesTelas/BTNalterarA.bmp"
                                        Width="25px">
                                    </Image>
                                </EditButton>
                                <NewButton Text="Incluir" Visible="True">
                                    <Image AlternateText="Incluir" Height="25px" ToolTip="Incluir" Url="~/images/BotoesTelas/BTNincluirA.bmp"
                                        Width="25px">
                                    </Image>
                                </NewButton>
                                <DeleteButton Text="Excluir" Visible="True">
                                    <Image AlternateText="Excluir" Height="25px" ToolTip="Excluir" Url="~/images/BotoesTelas/BTNexcluirA.bmp"
                                        Width="25px">
                                    </Image>
                                </DeleteButton>
                                <CancelButton>
                                    <Image AlternateText="Cancelar" Height="40px" ToolTip="Cancelar" Url="~/images/BotoesTelas/BTNcancelarA.bmp"
                                        Width="40px">
                                    </Image>
                                </CancelButton>
                                <UpdateButton Text="Grava">
                                    <Image AlternateText="Grava" Height="40px" Url="~/images/BotoesTelas/BTNsalvarA.bmp"
                                        Width="40px">
                                    </Image>
                                </UpdateButton>
                                <HeaderStyle Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                                <CellStyle HorizontalAlign="Center">
                                </CellStyle>
                            </dx3:GridViewCommandColumn>
                            <dx3:GridViewDataTextColumn FieldName="produto" VisibleIndex="3" Width="60px" Caption="Produto"
                                Name="produto" SortIndex="0" SortOrder="Ascending" ReadOnly="True">
                                <EditFormSettings Caption="Produto &gt;" ColumnSpan="1" />
                                <PropertiesTextEdit Width="60px">
                                    <ValidationSettings>
                                        <RequiredField ErrorText="Preenchimento Obrigatório!" IsRequired="True" />
                                    </ValidationSettings>
                                    <Style Font-Bold="True"></Style>
                                </PropertiesTextEdit>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle ForeColor="White" Font-Bold="True" />
                                <CellStyle Font-Bold="True" HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Grupo" FieldName="grupo" Name="grupo" VisibleIndex="4"
                                Width="60px" ReadOnly="True">
                                <PropertiesTextEdit EnableFocusedStyle="False" Width="60px">
                                    <Style Font-Bold="True" HorizontalAlign="Left">
                                        
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Grupo &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle HorizontalAlign="Right" Font-Bold="True">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Proposta" FieldName="proposta" Name="proposta"
                                VisibleIndex="1" Width="80px" ReadOnly="True">
                                <PropertiesTextEdit Width="60px">
                                    <Style Font-Bold="True"></Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Proposta &gt;" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Nome" FieldName="nome" Name="nome" VisibleIndex="7"
                                Width="230px">
                                <PropertiesTextEdit Width="100px">
                                    <Style Font-Bold="False" HorizontalAlign="Left">
                                        
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Nome &gt;" Visible="True" ColumnSpan="2" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Left">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Unidade" FieldName="unidade" Name="unidade"
                                VisibleIndex="5" Width="80px" ReadOnly="True">
                                <PropertiesTextEdit Width="60px">
                                    <Style Font-Bold="True">
                                        
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Unidade &gt;" ColumnSpan="2" Visible="True" />
                                <PropertiesTextEdit Width="100px">
                                    <Style Font-Bold="False" HorizontalAlign="Left"></Style>
                                </PropertiesTextEdit>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn VisibleIndex="6" Caption="Parte" FieldName="parte" Name="parte"
                                Width="60px">
                                <PropertiesTextEdit Width="60px">
                                    <Style Font-Bold="True">
                                        
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Parte &gt;" ColumnSpan="2" Visible="True" CaptionLocation="Near" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataDateColumn Caption="Data" FieldName="data_proposta" Name="data_proposta"
                                VisibleIndex="2" Width="105px">
                                <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy" Width="100px" EditFormat="Custom">
                                </PropertiesDateEdit>
                                <EditFormSettings Caption="Data Proposta &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                            </dx3:GridViewDataDateColumn>
                            <dx3:GridViewCommandColumn Caption=" " ShowSelectCheckbox="True" VisibleIndex="0"
                                Width="50px">
                            </dx3:GridViewCommandColumn>
                        </Columns>
                        <SettingsPager Visible="False" PageSize="1000">
                            <AllButton ImagePosition="Bottom" Visible="True">
                            </AllButton>
                        </SettingsPager>
                        <SettingsPopup>
                            <EditForm AllowResize="True" Height="350px" HorizontalAlign="Center" Modal="True"
                                VerticalAlign="TopSides" Width="690px" />
                            <CustomizationWindow HorizontalAlign="Center" VerticalAlign="TopSides" Height="350px"
                                Width="690px" />
                            <EditForm AllowResize="True" Height="350px" HorizontalAlign="Center" Modal="True"
                                VerticalAlign="TopSides" Width="690px" />
                            <CustomizationWindow Height="350px" HorizontalAlign="Center" VerticalAlign="TopSides"
                                Width="690px" />
                        </SettingsPopup>
                        <Styles>
                            <Header HorizontalAlign="Center" ForeColor="#FFF0D9">
                            </Header>
                            <AlternatingRow Enabled="True">
                            </AlternatingRow>
                            <Cell HorizontalAlign="Left">
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
                        <BackgroundImage HorizontalPosition="center" />
                    </dx3:ASPxGridView>
                    <asp:Label ID="Label6" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 820px;
                        position: absolute" Text="Produto" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxComboBox ID="cbproduto2" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 820px; left: 150px;" Width="380px"
                        Theme="PlasticBlue" 
                        OnSelectedIndexChanged="cbproduto_SelectedIndexChanged" AutoPostBack="True"
                        Visible="False">
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label7" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 855px;
                        position: absolute" Text="Grupo" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxComboBox ID="cbgrupo2" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 855px; left: 150px;" Width="380px"
                        Theme="PlasticBlue" OnSelectedIndexChanged="cbgrupo_SelectedIndexChanged" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label8" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 890px;
                        position: absolute" Text="Unidades - Parte" Theme="PlasticBlue" 
                        Visible="False"></asp:Label>
                    <dx:ASPxComboBox ID="cbgrupounidades2" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 890px; left: 150px;" Width="150px"
                        Theme="PlasticBlue" Visible="False" AutoPostBack="True">
                    </dx:ASPxComboBox>
                    <asp:RadioButtonList ID="rbmeiolote2" runat="server" AutoPostBack="True" CellPadding="0"
                        CellSpacing="0" Font-Names="Calibri" Font-Size="12pt" Font-Strikeout="False"
                        ForeColor="#3E5395" Height="12px" Style="z-index: 2; left: 320px; top: 890px;
                        position: absolute; right: 423px;" Width="200px" RepeatDirection="Horizontal"
                        Visible="False">
                        <asp:ListItem Value="0" Selected="True">1o. Meio</asp:ListItem>
                        <asp:ListItem Value="1">2o. Meio</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:Label ID="Label9" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 925px;
                        position: absolute" Text="Cliente" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="cbclientes" runat="server" Style="z-index: 2; left: 150px; top: 925px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="380px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label76" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 550px; top: 925px;
                        position: absolute" Text="Nascimento" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxDateEdit ID="dtnascimento1" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                        EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4;
                        position: absolute; margin-right: 5px; left: 660px; top: 925px;" Theme="PlasticBlue"
                            UseMaskBehavior="True" Width="120px" Visible="False" MinDate="1900-01-01">
                            <CalendarProperties ClearButtonText="Limpar" TodayButtonText="Hoje">
                            </CalendarProperties>
                            <ClientSideEvents KeyDown="function(s, e) 
                                                   {if (!(
                                                         (e.htmlEvent.keyCode &gt;= 48 &amp;&amp; e.htmlEvent.keyCode &lt;= 57)  ||
                                                         (e.htmlEvent.keyCode &gt;= 96 &amp;&amp; e.htmlEvent.keyCode &lt;= 105) ||
                                                         (e.htmlEvent.keyCode = 9)
                                                       ))
                                                    ASPxClientUtils.PreventEvent(e.htmlEvent);
                                                   }"
                                ButtonClick="function(s, e) {
	                                            s.SetDate(new Date(1900, 0, 1)); 
                                            }"
                                DropDown="function(s, e) {
                                                        if (!s.GetDate())
            	                                            s.SetDate(new Date(1900, 0, 1));	
                                                    }"
                                Init="function(s, e) {
                                                        if (!s.GetDate())
            	                                            s.SetDate(new Date(1900, 0, 1));	
                                                    }" />
                            <Border BorderColor="#808080" BorderStyle="Solid" BorderWidth="1px" />
                        </dx:ASPxDateEdit>
                    <asp:Label ID="Label41" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 960px;
                        position: absolute" Text="Rg No." Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edrg" runat="server" Style="z-index: 2; left: 150px; top: 960px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label10" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 320px; top: 960px;
                        position: absolute" Text="Rg Emissão" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxDateEdit ID="dtrgemissao" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                        EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4;
                        position: absolute; margin-right: 5px; left: 410px; top: 960px;" Theme="PlasticBlue"
                            UseMaskBehavior="True" Width="120px" Visible="False" MinDate="1900-01-01">
                            <CalendarProperties ClearButtonText="Limpar" TodayButtonText="Hoje">
                            </CalendarProperties>
                            <ClientSideEvents KeyDown="function(s, e) 
                                                   {if (!(
                                                         (e.htmlEvent.keyCode &gt;= 48 &amp;&amp; e.htmlEvent.keyCode &lt;= 57)  ||
                                                         (e.htmlEvent.keyCode &gt;= 96 &amp;&amp; e.htmlEvent.keyCode &lt;= 105) ||
                                                         (e.htmlEvent.keyCode = 9)
                                                       ))
                                                    ASPxClientUtils.PreventEvent(e.htmlEvent);
                                                   }"
                                ButtonClick="function(s, e) {
	                                            s.SetDate(new Date(1900, 0, 1)); 
                                            }"
                                DropDown="function(s, e) {
                                                        if (!s.GetDate())
            	                                            s.SetDate(new Date(1900, 0, 1));	
                                                    }"
                                Init="function(s, e) {
                                                        if (!s.GetDate())
            	                                            s.SetDate(new Date(1900, 0, 1));	
                                                    }" />
                            <Border BorderColor="#808080" BorderStyle="Solid" BorderWidth="1px" />
                        </dx:ASPxDateEdit>
                    <asp:Label ID="Label11" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 550px; top: 960px;
                        position: absolute" Text="Rg Orgão" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edrgorgao" runat="server" Style="z-index: 2; left: 660px; top: 960px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label68" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 995px;
                        position: absolute" Text="Sexo" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edsexo" runat="server" Style="z-index: 2; left: 150px; top: 995px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="120px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label12" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 320px; top: 995px;
                        position: absolute" Text="Profissão" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edprofissao" runat="server" Style="z-index: 2; left: 410px; top: 995px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="120px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label67" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 550px; top: 995px;
                        position: absolute" Text="Nacionalidade" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="ednacionalidade" runat="server" Style="z-index: 2; left: 660px; top: 995px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label13" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1030px;
                        position: absolute" Text="CPF No." Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edcpf" runat="server" Style="z-index: 2; left: 150px; top: 1030px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px" Visible="False"
                        AutoPostBack="True" ontextchanged="edcpf_TextChanged">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label14" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 320px; top: 1030px;
                        position: absolute" Text="Estado Civil" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edestadocivil" runat="server" Style="z-index: 2; left: 410px;
                        top: 1030px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="120px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label15" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 550px; top: 1030px;
                        position: absolute" Text="Reg.Casamento" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxComboBox ID="cbregimecasamento" runat="server" ValueType="System.String"
                        Font-Bold="True" Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 1030px; left: 660px;" Width="150px"
                        Theme="PlasticBlue" Visible="False" AutoPostBack="True">
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label16" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1065px;
                        position: absolute" Text="Conjuge" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="ednomeconjuge" runat="server" Style="z-index: 2; left: 150px;
                        top: 1065px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="380px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label77" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 550px; top: 1065px;
                        position: absolute" Text="Nascimento" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxDateEdit ID="dtnascimentoconjuge" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                        EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4;
                        position: absolute; margin-right: 5px; left: 660px; top: 1065px;" Theme="PlasticBlue"
                            UseMaskBehavior="True" Width="120px" Visible="False" MinDate="1900-01-01">
                            <CalendarProperties ClearButtonText="Limpar" TodayButtonText="Hoje">
                            </CalendarProperties>
                            <ClientSideEvents KeyDown="function(s, e) 
                                                   {if (!(
                                                         (e.htmlEvent.keyCode &gt;= 48 &amp;&amp; e.htmlEvent.keyCode &lt;= 57)  ||
                                                         (e.htmlEvent.keyCode &gt;= 96 &amp;&amp; e.htmlEvent.keyCode &lt;= 105) ||
                                                         (e.htmlEvent.keyCode = 9)
                                                       ))
                                                    ASPxClientUtils.PreventEvent(e.htmlEvent);
                                                   }"
                                ButtonClick="function(s, e) {
	                                            s.SetDate(new Date(1900, 0, 1)); 
                                            }"
                                DropDown="function(s, e) {
                                                        if (!s.GetDate())
            	                                            s.SetDate(new Date(1900, 0, 1));	
                                                    }"
                                Init="function(s, e) {
                                                        if (!s.GetDate())
            	                                            s.SetDate(new Date(1900, 0, 1));	
                                                    }" />
                            <Border BorderColor="#808080" BorderStyle="Solid" BorderWidth="1px" />
                        </dx:ASPxDateEdit>
                    <asp:Label ID="Label69" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1100px;
                        position: absolute" Text="Rg No." Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edrgconjuge" runat="server" Style="z-index: 2; left: 150px; top: 1100px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label70" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 320px; top: 1100px;
                        position: absolute" Text="Rg Emissão" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxDateEdit ID="dtrgemissaoconjuge" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                        EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4;
                        position: absolute; margin-right: 5px; left: 410px; top: 1100px;" Theme="PlasticBlue"
                            UseMaskBehavior="True" Width="120px" Visible="False" MinDate="1900-01-01">
                            <CalendarProperties ClearButtonText="Limpar" TodayButtonText="Hoje">
                            </CalendarProperties>
                            <ClientSideEvents KeyDown="function(s, e) 
                                                   {if (!(
                                                         (e.htmlEvent.keyCode &gt;= 48 &amp;&amp; e.htmlEvent.keyCode &lt;= 57)  ||
                                                         (e.htmlEvent.keyCode &gt;= 96 &amp;&amp; e.htmlEvent.keyCode &lt;= 105) ||
                                                         (e.htmlEvent.keyCode = 9)
                                                       ))
                                                    ASPxClientUtils.PreventEvent(e.htmlEvent);
                                                   }"
                                ButtonClick="function(s, e) {
	                                            s.SetDate(new Date(1900, 0, 1)); 
                                            }"
                                DropDown="function(s, e) {
                                                        if (!s.GetDate())
            	                                            s.SetDate(new Date(1900, 0, 1));	
                                                    }"
                                Init="function(s, e) {
                                                        if (!s.GetDate())
            	                                            s.SetDate(new Date(1900, 0, 1));	
                                                    }" />
                            <Border BorderColor="#808080" BorderStyle="Solid" BorderWidth="1px" />
                        </dx:ASPxDateEdit>
                    <asp:Label ID="Label71" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 550px; top: 1100px;
                        position: absolute" Text="Rg Orgão" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edrgorgaoconjuge" runat="server" Style="z-index: 2; left: 660px; top: 1100px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label72" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1135px;
                        position: absolute" Text="Sexo" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edsexoconjuge" runat="server" Style="z-index: 2; left: 150px; top: 1135px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="120px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label73" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 320px; top: 1135px;
                        position: absolute" Text="Profissão" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edprofissaoconjuge" runat="server" Style="z-index: 2; left: 410px; top: 1135px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="120px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label74" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 550px; top: 1135px;
                        position: absolute" Text="Nacionalidade" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="ednacionalidadeconjuge" runat="server" Style="z-index: 2; left: 660px; top: 1135px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label17" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1170px;
                        position: absolute" Text="Endereço Res." Theme="PlasticBlue" 
                        Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenderecores" runat="server" Style="z-index: 2; left: 150px;
                        top: 1170px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="380px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label75" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 550px; top: 1170px;
                        position: absolute" Text="CPF No." Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edcpfconjuge" runat="server" Style="z-index: 2; left: 660px; top: 1170px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px" Visible="False"
                        AutoPostBack="True" ontextchanged="edcpfconjuge_TextChanged">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label18" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1205px;
                        position: absolute" Text="Numero" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenredecoresnumero" runat="server" Style="z-index: 2; left: 150px;
                        top: 1205px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label19" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 320px; top: 1205px;
                        position: absolute" Text="Complemento" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenredecorescomplemento" runat="server" Style="z-index: 2; left: 410px;
                        top: 1205px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="120px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label20" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 550px; top: 1205px;
                        position: absolute" Text="Bairro" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenderecoresbairro" runat="server" Style="z-index: 2; left: 660px;
                        top: 1205px; position: absolute; right: 532px;" Theme="PlasticBlue" Width="150px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label22" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1240px;
                        position: absolute" Text="Cidade" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenderecorescidade" runat="server" Style="z-index: 2; left: 150px;
                        top: 1240px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="380px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label21" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 550px; top: 1240px;
                        position: absolute" Text="Cep" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenderecorescep" runat="server" Style="z-index: 2; left: 660px;
                        top: 1240px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="120px"
                        Visible="False" AutoPostBack="True">
                        <MaskSettings IncludeLiterals="None" Mask="99999-999" />
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label23" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1275px;
                        position: absolute" Text="Tel. Residencial" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edtelefoneres" runat="server" Style="z-index: 2; left: 150px;
                        top: 1275px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="380px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label24" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1310px;
                        position: absolute" Text="Tel. Cobrança" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edtelefonecom" runat="server" Style="z-index: 2; left: 150px;
                        top: 1310px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="380px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label25" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1345px;
                        position: absolute" Text="Endereço Cob." Theme="PlasticBlue" 
                        Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenderecocob" runat="server" Style="z-index: 2; left: 150px;
                        top: 1345px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="380px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label26" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1380px;
                        position: absolute" Text="Numero" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenderecocobnumero" runat="server" Style="z-index: 2; left: 150px;
                        top: 1380px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label27" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 320px; top: 1380px;
                        position: absolute" Text="Complemento" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenderecocobcomplemento" runat="server" Style="z-index: 2; left: 410px;
                        top: 1380px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="120px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label28" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1415px;
                        position: absolute" Text="Bairro" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenderecocobbairro" runat="server" Style="z-index: 2; left: 150px;
                        top: 1415px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label29" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 320px; top: 1415px;
                        position: absolute" Text="Cep" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenderecocobcep" runat="server" Style="z-index: 2; left: 410px;
                        top: 1415px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="120px"
                        Visible="False" AutoPostBack="True">
                        <MaskSettings IncludeLiterals="None" Mask="99999-999" />
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label30" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1450px;
                        position: absolute" Text="Cidade" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenderecocobcidade" runat="server" Style="z-index: 2; left: 150px;
                        top: 1450px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="380px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label31" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1485px;
                        position: absolute" Text="Opção de Planta" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edopcaoplanta" runat="server" Style="z-index: 2; left: 150px;
                        top: 1485px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="380px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label32" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1520px;
                        position: absolute" Text="Endereço Imóvel" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenderecoimovel" runat="server" Style="z-index: 2; left: 150px;
                        top: 1520px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="380px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label33" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1555px;
                        position: absolute" Text="Preço e Condições de Pagamento" Theme="PlasticBlue"
                        Visible="False"></asp:Label>
                    <asp:Label ID="Label34" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1590px;
                        position: absolute" Text="Data da Proposta" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxDateEdit ID="dtproposta" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                        EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4;
                        position: absolute; margin-right: 5px; left: 150px; top: 1590px;" Theme="PlasticBlue"
                            UseMaskBehavior="True" Width="120px" Visible="False" MinDate="1900-01-01">
                            <CalendarProperties ClearButtonText="Limpar" TodayButtonText="Hoje">
                            </CalendarProperties>
                            <ClientSideEvents KeyDown="function(s, e) 
                                                   {if (!(
                                                         (e.htmlEvent.keyCode &gt;= 48 &amp;&amp; e.htmlEvent.keyCode &lt;= 57)  ||
                                                         (e.htmlEvent.keyCode &gt;= 96 &amp;&amp; e.htmlEvent.keyCode &lt;= 105) ||
                                                         (e.htmlEvent.keyCode = 9)
                                                       ))
                                                    ASPxClientUtils.PreventEvent(e.htmlEvent);
                                                   }"
                                ButtonClick="function(s, e) {
	                                            s.SetDate(new Date(1900, 0, 1)); 
                                            }"
                                DropDown="function(s, e) {
                                                        if (!s.GetDate())
            	                                            s.SetDate(new Date(1900, 0, 1));	
                                                    }"
                                Init="function(s, e) {
                                                        if (!s.GetDate())
            	                                            s.SetDate(new Date(1900, 0, 1));	
                                                    }" />
                            <Border BorderColor="#808080" BorderStyle="Solid" BorderWidth="1px" />
                        </dx:ASPxDateEdit>
                    <dx:ASPxCheckBox ID="cktabelaprice" runat="server" Style="z-index: 2; left: 370px;
                        top: 1590px; position: absolute; right: 223px;" AutoPostBack="True" CheckState="Unchecked"
                        Font-Bold="False" Font-Names="Calibri" Font-Size="14px" ForeColor="#3E5395" Height="21px"
                        Text="Tabela Price" Theme="PlasticBlue" Width="120px" Visible="False">
                    </dx:ASPxCheckBox>
                    <asp:Label ID="Label35" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1625px;
                        position: absolute" Text="Valor Proposta" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edvlrvenda" runat="server" Style="z-index: 2; left: 150px; top: 1625px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="200px" Visible="False"
                        AutoPostBack="True">
                        <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label36" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1660px;
                        position: absolute" Text="Valor Sinal" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edvlrsinal" runat="server" Style="z-index: 2; left: 150px; top: 1660px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="200px" Visible="False"
                        AutoPostBack="True">
                        <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                    </dx:ASPxTextBox>
                    <dx:ASPxCheckBox ID="cksinalparcelado" runat="server" Style="z-index: 2; left: 370px;
                        top: 1625px; position: absolute; right: 223px;" AutoPostBack="True" CheckState="Unchecked"
                        Font-Bold="False" Font-Names="Calibri" Font-Size="14px" ForeColor="#3E5395" Height="21px"
                        Text="Sinal Parcelado" Theme="PlasticBlue" Width="120px" Visible="False">
                    </dx:ASPxCheckBox>
                    <asp:Label ID="Label37" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 370px; top: 1660px;
                        position: absolute" Text="Parcelas" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edqtdsinal" runat="server" Style="z-index: 2; left: 430px; top: 1660px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="100px" 
                        Visible="False">
                        <MaskSettings IncludeLiterals="None" Mask="&lt;0..9999999g&gt;" AllowMouseWheel="False" />
                    </dx:ASPxTextBox>
                    <div id="Divsinalparcelado" runat="server" style="border: 1px solid #808080; z-index: 2;
                        position: absolute; top: 1500px; left: 540px; height: 160px; width: 280px;">
                        <asp:Label ID="Label38" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px;
                            position: absolute; right: 177px;" Text="Sinal Parcelado" Theme="PlasticBlue"
                            Visible="False"></asp:Label>
                        <asp:Label ID="Label39" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 20px;
                            position: absolute" Text="Parcelas" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <asp:Label ID="Label40" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 100px; top: 20px;
                            position: absolute" Text="9999/9999" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxButton ID="btgravasinal" runat="server" Style="z-index: 2; left: 230px; top: 15px;
                            position: absolute; width: 35px; height: 20px" RightToLeft="True" HorizontalAlign="Center"
                            position="absolute" VerticalAlign="Middle" Visible="False" ImageSpacing="0px">
                            <Image Height="14px" Width="14px" ToolTip="ProcessaSinal" Url="~/images/BotoesTelas/BTNalterarA.bmp"
                                UrlDisabled="~/images/BotoesTelas/BTNalterarI.bmp" UrlPressed="~/images/BotoesTelas/BTNalterarS.bmp">
                            </Image>
                            <Paddings PaddingBottom="0px" PaddingLeft="0px" PaddingRight="0px" PaddingTop="0px" />
                        </dx:ASPxButton>
                        <asp:Label ID="Label81" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 55px;
                            position: absolute" Text="Data" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxDateEdit ID="eddtparcelasinal" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                            EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4;
                            position: absolute; margin-right: 5px; left: 100px; top: 55px;" Theme="PlasticBlue"
                            UseMaskBehavior="True" Width="120px" Visible="False" MinDate="1900-01-01">
                            <CalendarProperties ClearButtonText="Limpar" TodayButtonText="Hoje">
                            </CalendarProperties>
                            <ClientSideEvents KeyDown="function(s, e) 
                                                   {if (!(
                                                         (e.htmlEvent.keyCode &gt;= 48 &amp;&amp; e.htmlEvent.keyCode &lt;= 57)  ||
                                                         (e.htmlEvent.keyCode &gt;= 96 &amp;&amp; e.htmlEvent.keyCode &lt;= 105) ||
                                                         (e.htmlEvent.keyCode = 9)
                                                       ))
                                                    ASPxClientUtils.PreventEvent(e.htmlEvent);
                                                   }"
                                ButtonClick="function(s, e) {
	                                            s.SetDate(new Date(1900, 0, 1)); 
                                            }"
                                DropDown="function(s, e) {
                                                        if (!s.GetDate())
            	                                            s.SetDate(new Date(1900, 0, 1));	
                                                    }"
                                Init="function(s, e) {
                                                        if (!s.GetDate())
            	                                            s.SetDate(new Date(1900, 0, 1));	
                                                    }" />
                            <Border BorderColor="#808080" BorderStyle="Solid" BorderWidth="1px" />
                        </dx:ASPxDateEdit>
                        <asp:Label ID="Label42" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 90px;
                            position: absolute" Text="Valor" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edvlrparcelasinal" runat="server" Style="z-index: 2; left: 100px;
                            top: 90px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px"
                            Visible="False" AutoPostBack="True">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label43" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 125px;
                            position: absolute" Text="Total" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edvlrparcelasinaltotal" runat="server" Style="z-index: 2; left: 101px;
                            top: 125px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px"
                            Visible="False" AutoPostBack="True" ReadOnly="True">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                    </div>
                    <asp:Label ID="Label44" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1695px;
                        position: absolute" Text="Saldo" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edvlrsaldo1" runat="server" Style="z-index: 2; left: 150px; top: 1695px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="200px" Visible="False"
                        AutoPostBack="True">
                        <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label45" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1730px;
                        position: absolute" Text="Intermediárias" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edvlrintermediarias" runat="server" Style="z-index: 2; left: 150px;
                        top: 1730px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="200px"
                        Visible="False" AutoPostBack="True">
                        <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label46" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 370px; top: 1730px;
                        position: absolute; height: 18px;" Text="Parcelas" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edqtdintermediarias" runat="server" Style="z-index: 2; left: 430px;
                        top: 1730px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="100px"
                        Visible="False">
                        <MaskSettings IncludeLiterals="None" Mask="&lt;0..9999999g&gt;" AllowMouseWheel="False" />
                    </dx:ASPxTextBox>
                    <div id="Divintermediaria" runat="server" style="border: 1px solid #808080; z-index: 2;
                        position: absolute; top: 1700px; left: 540px; height: 190px; width: 280px;">
                        <asp:Label ID="Label47" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px;
                            position: absolute" Text="Intermediárias" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <asp:Label ID="Label48" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 20px;
                            position: absolute" Text="Parcelas" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <asp:Label ID="Label49" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 100px; top: 20px;
                            position: absolute" Text="9999/9999" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxButton ID="btgravaintermediaria" runat="server" Style="z-index: 2; left: 230px;
                            top: 15px; position: absolute; width: 35px; height: 20px" RightToLeft="True"
                            HorizontalAlign="Left" position="absolute" VerticalAlign="Top" Visible="False"
                            ImageSpacing="0px">
                            <Image Height="14px" Width="14px" ToolTip="ProcessaIntermediaria" Url="~/images/BotoesTelas/BTNalterarA.bmp"
                                UrlDisabled="~/images/BotoesTelas/BTNalterarI.bmp" UrlPressed="~/images/BotoesTelas/BTNalterarS.bmp">
                            </Image>
                            <Paddings PaddingBottom="0px" PaddingLeft="0px" PaddingRight="0px" PaddingTop="0px" />
                        </dx:ASPxButton>
                        <asp:Label ID="Label50" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 55px;
                            position: absolute" Text="Data" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxDateEdit ID="eddtparcelaintermediaria" runat="server" BackColor="#E1E6F2"
                            DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" EditFormatString="dd/MM/yyyy"
                            EnableTheming="True" Font-Bold="False" Font-Names="Calibri" Font-Size="15px"
                            ForeColor="#3E5395" Height="16px" Style="z-index: 4; position: absolute; margin-right: 5px;
                            left: 100px; top: 55px;" Theme="PlasticBlue" 
                            UseMaskBehavior="True" Width="120px" Visible="False" MinDate="1900-01-01">
                            <CalendarProperties ClearButtonText="Limpar" TodayButtonText="Hoje">
                            </CalendarProperties>
                            <ClientSideEvents KeyDown="function(s, e) 
                                                   {if (!(
                                                         (e.htmlEvent.keyCode &gt;= 48 &amp;&amp; e.htmlEvent.keyCode &lt;= 57)  ||
                                                         (e.htmlEvent.keyCode &gt;= 96 &amp;&amp; e.htmlEvent.keyCode &lt;= 105) ||
                                                         (e.htmlEvent.keyCode = 9)
                                                       ))
                                                    ASPxClientUtils.PreventEvent(e.htmlEvent);
                                                   }"
                                ButtonClick="function(s, e) {
	                                            s.SetDate(new Date(1900, 0, 1)); 
                                            }"
                                DropDown="function(s, e) {
                                                        if (!s.GetDate())
            	                                            s.SetDate(new Date(1900, 0, 1));	
                                                    }"
                                Init="function(s, e) {
                                                        if (!s.GetDate())
            	                                            s.SetDate(new Date(1900, 0, 1));	
                                                    }" />
                            <Border BorderColor="#808080" BorderStyle="Solid" BorderWidth="1px" />
                        </dx:ASPxDateEdit>
                        <asp:Label ID="Label51" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 90px;
                            position: absolute" Text="Valor" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edvlrparcelaintermediaria" runat="server" Style="z-index: 2;
                            left: 100px; top: 90px; position: absolute; right: 223px;" Theme="PlasticBlue"
                            Width="150px" Visible="False" AutoPostBack="True">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label92" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 125px;
                            position: absolute" Text="Observação" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edobsintermediaria" runat="server" Style="z-index: 2; left: 101px;
                            top: 126px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px"
                            Visible="False" AutoPostBack="True">
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label93" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 160px;
                            position: absolute" Text="Total" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edvlrparcelaintermediariatotal" runat="server" Style="z-index: 2;
                            left: 101px; top: 160px; position: absolute; right: 223px;" Theme="PlasticBlue"
                            Width="150px" Visible="False" AutoPostBack="True" ReadOnly="True">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                    </div>
                    <asp:Label ID="Label94" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1765px;
                        position: absolute" Text="Fluxo de Parcelas" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edvlrfluxoparcelas" runat="server" Style="z-index: 2; left: 150px;
                        top: 1765px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="200px"
                        Visible="False" AutoPostBack="True" ReadOnly="True" 
                        ontextchanged="edvlrfluxoparcelas_TextChanged">
                        <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label52" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 370px; top: 1765px;
                        position: absolute" Text="Fluxos" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edqtdfluxoparcelas" runat="server" Style="z-index: 2; left: 430px;
                        top: 1765px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="100px"
                        Visible="False" ontextchanged="edqtdfluxoparcelas_TextChanged">
                        <MaskSettings IncludeLiterals="None" Mask="&lt;0..9999999g&gt;" AllowMouseWheel="False" />
                    </dx:ASPxTextBox>
                    <div id="Divfluxos" runat="server" style="border: 1px solid #808080; z-index: 2;
                        position: absolute; top: 1950px; left: 540px; height: 190px; width: 280px;">
                        <asp:Label ID="Label53" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px;
                            position: absolute" Text="Fluxos Financeiros" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <asp:Label ID="Label54" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 20px;
                            position: absolute" Text="Fluxos" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <asp:Label ID="Label55" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 100px; top: 20px;
                            position: absolute" Text="9999/9999" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxButton ID="btgravafluxo" runat="server" Style="z-index: 2; left: 230px; top: 15px;
                            position: absolute; width: 35px; height: 20px" RightToLeft="True" HorizontalAlign="Left"
                            position="absolute" VerticalAlign="Top" Visible="False" ImageSpacing="0px">
                            <Image Height="14px" Width="14px" ToolTip="ProcessaFluxo" Url="~/images/BotoesTelas/BTNalterarA.bmp"
                                UrlDisabled="~/images/BotoesTelas/BTNalterarI.bmp" UrlPressed="~/images/BotoesTelas/BTNalterarS.bmp">
                            </Image>
                            <Paddings PaddingBottom="0px" PaddingLeft="0px" PaddingRight="0px" PaddingTop="0px" />
                        </dx:ASPxButton>
                        <asp:Label ID="Label56" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 55px;
                            position: absolute" Text="Data Inicial" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxDateEdit ID="eddtinicialfluxo" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                            EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4;
                            position: absolute; margin-right: 5px; left: 100px; top: 55px;" Theme="PlasticBlue"
                            UseMaskBehavior="True" Width="120px" Visible="False" MinDate="1900-01-01">
                            <CalendarProperties ClearButtonText="Limpar" TodayButtonText="Hoje">
                            </CalendarProperties>
                            <ClientSideEvents KeyDown="function(s, e) 
                                                   {if (!(
                                                         (e.htmlEvent.keyCode &gt;= 48 &amp;&amp; e.htmlEvent.keyCode &lt;= 57)  ||
                                                         (e.htmlEvent.keyCode &gt;= 96 &amp;&amp; e.htmlEvent.keyCode &lt;= 105) ||
                                                         (e.htmlEvent.keyCode = 9)
                                                       ))
                                                    ASPxClientUtils.PreventEvent(e.htmlEvent);
                                                   }"
                                ButtonClick="function(s, e) {
	                                            s.SetDate(new Date(1900, 0, 1)); 
                                            }"
                                DropDown="function(s, e) {
                                                        if (!s.GetDate())
            	                                            s.SetDate(new Date(1900, 0, 1));	
                                                    }"
                                Init="function(s, e) {
                                                        if (!s.GetDate())
            	                                            s.SetDate(new Date(1900, 0, 1));	
                                                    }" />
                            <Border BorderColor="#808080" BorderStyle="Solid" BorderWidth="1px" />
                        </dx:ASPxDateEdit>
                        <asp:Label ID="Label57" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 90px;
                            position: absolute" Text="Valor" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edvlrparcelafluxo" runat="server" Style="z-index: 2; left: 100px;
                            top: 90px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px"
                            Visible="False" AutoPostBack="True">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label58" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 125px;
                            position: absolute" Text="No.Parcelas" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edqtdparcelafluxo" runat="server" Style="z-index: 2; left: 101px;
                            top: 126px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px"
                            Visible="False" AutoPostBack="True">
                            <MaskSettings IncludeLiterals="None" Mask="&lt;0..9999999g&gt;" />
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label59" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 160px;
                            position: absolute" Text="Total" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edvlrparcelafluxototal" runat="server" Style="z-index: 2; left: 101px;
                            top: 160px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px"
                            Visible="False" AutoPostBack="True" ReadOnly="True">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                    </div>
                    <asp:Label ID="Label60" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1800px;
                        position: absolute" Text="Indexador Pré" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxComboBox ID="cbindexador" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 1800px; left: 150px;" Width="380px"
                        Theme="PlasticBlue" AutoPostBack="True" Visible="False">
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label66" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1835px;
                        position: absolute" Text="Indexador Pós" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxComboBox ID="cbindexadorpos" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 1835px; left: 150px;" Width="380px"
                        Theme="PlasticBlue" AutoPostBack="True" Visible="False">
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label61" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1870px;
                        position: absolute" Text="Periodicidade" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <asp:RadioButtonList ID="rbperiodicidade" runat="server" AutoPostBack="True" CellPadding="0"
                        CellSpacing="0" Font-Names="Calibri" Font-Size="12pt" Font-Strikeout="False"
                        ForeColor="#3E5395" Height="12px" Style="z-index: 2; left: 150px; top: 1870px;
                        position: absolute; right: 423px;" Width="200px" RepeatDirection="Horizontal"
                        Visible="False">
                        <asp:ListItem Value="0">Diária</asp:ListItem>
                        <asp:ListItem Value="1" Selected="True">Mensal</asp:ListItem>
                        <asp:ListItem Value="2">Anual</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:Label ID="Label62" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1905px;
                        position: absolute" Text="Corretor" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxComboBox ID="cbcorretor" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 1905px; left: 150px;" Width="380px"
                        Theme="PlasticBlue" AutoPostBack="True" Visible="False">
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label63" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1940px;
                        position: absolute" Text="Multa %" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edmulta" runat="server" Style="z-index: 2; left: 150px; top: 1940px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="200px" Visible="False"
                        AutoPostBack="True">
                        <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label64" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1975px;
                        position: absolute" Text="Comissão %" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edcomissao" runat="server" Style="z-index: 2; left: 150px; top: 1975px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="200px" Visible="False"
                        AutoPostBack="True">
                        <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                    </dx:ASPxTextBox>
                    <asp:RadioButtonList ID="rbperiodicidadecomissao" runat="server" AutoPostBack="True"
                        CellPadding="0" CellSpacing="0" Font-Names="Calibri" Font-Size="12pt" Font-Strikeout="False"
                        ForeColor="#3E5395" Height="12px" Style="z-index: 2; left: 360px; top: 1975px;
                        position: absolute; right: 423px;" Width="170px" RepeatDirection="Horizontal"
                        Visible="False">
                        <asp:ListItem Value="0">a.d.</asp:ListItem>
                        <asp:ListItem Value="1" Selected="True">a.m.</asp:ListItem>
                        <asp:ListItem Value="2">a.a.</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:Label ID="Label65" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 2010px;
                        position: absolute" Text="Observações" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edobservacao" runat="server" Style="z-index: 2; left: 150px;
                        top: 2010px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="380px"
                        Visible="False">
                    </dx:ASPxTextBox>
                    <div id="Div2" runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute;
                        top: 820px; left: 550px; height: 50px; width: 250px;">
                        <dx:ASPxButton ID="btcarrega" runat="server" Height="40px" ImagePosition="Left" Width="45px"
                            OnClick="btcarrega_Click" AutoPostBack="False">
                            <Image Height="30px" ToolTip="Carregar Proposta" Url="~/images/BotoesTelas/BTNpesquisarA.bmp"
                                UrlDisabled="~/images/BotoesTelas/BTNpesquisarI.bmp" UrlPressed="~/images/BotoesTelas/BTNpesquisarS.bmp"
                                Width="30px">
                            </Image>
                        </dx:ASPxButton>
                        <dx:ASPxButton ID="btprocessa" runat="server" Height="40px" ImagePosition="Left"
                            OnClick="btprocessa_Click" Width="45px" Visible="False">
                            <Image Height="30px" ToolTip="Gravar Pagamento Parcela" Url="~/images/BotoesTelas/BTNalterarA.bmp"
                                UrlDisabled="~/images/BotoesTelas/BTNalterarI.bmp" UrlPressed="~/images/BotoesTelas/BTNalterarS.bmp"
                                Width="30px">
                            </Image>
                        </dx:ASPxButton>
                        <dx:ASPxButton ID="btimprime" runat="server" Height="40px" ImagePosition="Left" Width="45px"
                            OnClick="btimprime_Click" AutoPostBack="False">
                            <Image Height="30px" ToolTip="Imprimir Proposta" Url="~/images/BotoesTelas/BTNimprimirA.bmp"
                                UrlDisabled="~/images/BotoesTelas/BTNimprimirI.bmp" UrlPressed="~/images/BotoesTelas/BTNimprimirS.bmp"
                                Width="30px">
                            </Image>
                        </dx:ASPxButton>
                        <dx:ASPxButton ID="btimprime2" runat="server" Height="40px" 
                            ImagePosition="Left" Width="45px"
                            AutoPostBack="False" onclick="btimprime2_Click">
                            <Image Height="30px" ToolTip="Imprimir Análise" Url="~/images/BotoesTelas/BTNimprimirA.bmp"
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
                    <div runat="server" style="z-index: 2; position: absolute; top: 2150px; left: 10px;
                        height: 200px; width: 378px;" id="Div4">
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
                                        Consulta de Proposta.<br />
                                        <br />
                                        Consulta e Impressão de Propostas.<br />
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

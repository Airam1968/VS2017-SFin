<%@ Page Title="FVendasCorrecao" Language="C#" AutoEventWireup="true" CodeFile="FVendasCorrecao.aspx.cs"
    Inherits="FVendasCorrecao" StylesheetTheme="Principal" %>

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
    <title>Gitano - Vendas - Correção Monetária</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <link href="../../content/toastr.css" rel="stylesheet" />
</head>
<body style="height: 1400px">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager" runat="server" />
        <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1400px">
            <ContentTemplate>
                <h1>VENDAS - CORREÇÃO MONETÁRIA</h1>
                <h2>Correção Monetária da Unidade</h2>
                <div id="DivNova" style="border-style: none">
                    <div style="border: 1px solid #808080; z-index: 1; left: 35px; top: 100px; position: absolute; height: 1200px; width: 832px; text-align: center;">
                        <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px; position: absolute"
                            Text="Selecione" Theme="PlasticBlue"></asp:Label>
                        <asp:Label ID="Label3" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 15px; position: absolute"
                            Text="Produto" Theme="PlasticBlue"></asp:Label>
                        <dx:ASPxComboBox ID="cbproduto" runat="server" ValueType="System.String" Font-Bold="True"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt; top: 15px; left: 150px;"
                            Width="380px" Theme="PlasticBlue"
                            OnSelectedIndexChanged="cbproduto_SelectedIndexChanged" AutoPostBack="True">
                        </dx:ASPxComboBox>
                        <asp:Label ID="Label2" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 50px; position: absolute"
                            Text="Grupo" Theme="PlasticBlue"></asp:Label>
                        <dx:ASPxComboBox ID="cbgrupo" runat="server" ValueType="System.String" Font-Bold="True"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt; top: 50px; left: 150px;"
                            Width="380px" Theme="PlasticBlue"
                            OnSelectedIndexChanged="cbgrupo_SelectedIndexChanged" AutoPostBack="True">
                        </dx:ASPxComboBox>
                        <asp:Label ID="Label7" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 85px; position: absolute"
                            Text="Unidades - Parte" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxComboBox ID="cbgrupounidades" runat="server" ValueType="System.String" Font-Bold="True"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt; top: 85px; left: 150px;"
                            Width="150px" Theme="PlasticBlue"
                            OnSelectedIndexChanged="cbgrupounidades_SelectedIndexChanged" Visible="False"
                            AutoPostBack="True">
                        </dx:ASPxComboBox>
                        <asp:RadioButtonList ID="rbmeiolote" runat="server" AutoPostBack="True" CellPadding="0"
                            CellSpacing="0" Font-Names="Calibri" Font-Size="12pt" Font-Strikeout="False"
                            ForeColor="#3E5395" Height="12px" Style="z-index: 2; left: 320px; top: 85px; position: absolute; right: 423px;"
                            Width="200px" RepeatDirection="Horizontal"
                            Visible="False" OnSelectedIndexChanged="rbmeiolote_SelectedIndexChanged">
                            <asp:ListItem Value="0" Selected="True">1o. Meio</asp:ListItem>
                            <asp:ListItem Value="1">2o. Meio</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:Label ID="Label8" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 120px; position: absolute"
                            Text="Cliente" Theme="PlasticBlue"></asp:Label>
                        <dx:ASPxTextBox ID="edcliente" runat="server" Style="z-index: 2; left: 150px; top: 120px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="380px" AutoPostBack="True"
                            ReadOnly="True">
                        </dx:ASPxTextBox>
                        <dx:ASPxTextBox ID="edclienteperiodicidade" runat="server" Style="z-index: 2; left: 550px; top: 120px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="200px"
                            AutoPostBack="True" ReadOnly="True">
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label5" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 150px; position: absolute"
                            Text="Corrigir Até" Theme="PlasticBlue"></asp:Label>
                        <dx:ASPxDateEdit ID="dtcorrecao" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                            EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4; position: absolute; margin-right: 5px; left: 150px; top: 150px;"
                            Theme="PlasticBlue"
                            UseMaskBehavior="True" Width="120px" MinDate="1900-01-01">
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
                        <asp:Label ID="Label13" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 185px; position: absolute"
                            Text="Correção" Theme="PlasticBlue" Visible="True"></asp:Label>
                        <asp:RadioButtonList ID="rbperiodicidade" runat="server" AutoPostBack="True" CellPadding="0"
                            CellSpacing="0" Font-Names="Calibri" Font-Size="12pt" Font-Strikeout="False"
                            ForeColor="#3E5395" Height="12px" Style="z-index: 2; left: 150px; top: 185px; position: absolute; right: 423px;"
                            Width="200px" RepeatDirection="Horizontal"
                            Visible="True">
                            <asp:ListItem Value="0" Selected="True">Todos</asp:ListItem>
                            <asp:ListItem Value="1">Mensal</asp:ListItem>
                            <asp:ListItem Value="2">Anual</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:Label ID="Label4" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 220px; position: absolute"
                            Text="FeedBack" Theme="PlasticBlue"></asp:Label>
                        <dx:ASPxTextBox ID="edfeedback" runat="server" Style="z-index: 2; left: 150px; top: 220px; position: absolute; right: 32px;"
                            Theme="PlasticBlue" Width="650px"
                            AutoPostBack="True" ReadOnly="True">
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label6" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 255px; position: absolute"
                            Text="Contratos" Theme="PlasticBlue"></asp:Label>
                        <dx:ASPxTextBox ID="edselecionados" runat="server" Style="z-index: 2; left: 150px; top: 255px; position: absolute; right: 32px;"
                            Theme="PlasticBlue" Width="650px"
                            AutoPostBack="True" ReadOnly="True">
                        </dx:ASPxTextBox>
                        <dx3:ASPxGridView ID="GridListagem" runat="server" AutoGenerateColumns="False" EnableTheming="True"
                            Font-Bold="False" KeyFieldName="ID" Style="margin-right: 6px; position: absolute; top: 300px; left: 10px;"
                            Theme="PlasticBlue" Width="812px">
                            <SettingsBehavior AllowSelectByRowClick="True" ColumnResizeMode="Control" ConfirmDelete="True" />
                            <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                            <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                                VerticalScrollableHeight="10000" HorizontalScrollBarMode="Visible" VerticalScrollBarMode="Visible" />
                            <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                                CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                                CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Unidades do Produto"
                                Title="Verificar" />
                            <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                            <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                            <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                            <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                                VerticalScrollableHeight="400" />
                            <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                                CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                                CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Unidades do Produto"
                                Title="Verificar" />
                            <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                            <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                            <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                            <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                                VerticalScrollableHeight="400" />
                            <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                                CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                                CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Unidades do Produto"
                                Title="Verificar" />
                            <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                            <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                            <BackgroundImage HorizontalPosition="center" />
                            <SettingsBehavior AllowSelectByRowClick="True" ColumnResizeMode="Control" ConfirmDelete="True" />
                            <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                            <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                                VerticalScrollableHeight="600" />
                            <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                                CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                                CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Unidades do Produto"
                                Title="Verificar" />
                            <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                            <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                            <BackgroundImage HorizontalPosition="center" />
                            <Columns>
                                <dx3:GridViewDataTextColumn FieldName="produto" VisibleIndex="1" Width="60px" Caption="Produto"
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
                                <dx3:GridViewDataTextColumn Caption="Grupo" FieldName="grupo" Name="grupo" VisibleIndex="2"
                                    Width="60px" ReadOnly="True">
                                    <PropertiesTextEdit EnableFocusedStyle="False" Width="60px">
                                        <Style HorizontalAlign="Left" Font-Bold="True"></Style>
                                    </PropertiesTextEdit>
                                    <EditFormSettings Caption="Grupo &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="ID" FieldName="ID" Name="ID" VisibleIndex="0"
                                    Width="50px" ReadOnly="True" Visible="False">
                                    <PropertiesTextEdit Width="60px">
                                        <Style Font-Bold="True">
                                        
                                    </Style>
                                    </PropertiesTextEdit>
                                    <EditFormSettings Caption="ID &gt;" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="ID Cliente" FieldName="cliente" Name="cliente"
                                    VisibleIndex="5" Width="100px">
                                    <PropertiesTextEdit Width="100px">
                                        <Style Font-Bold="False" HorizontalAlign="Left">
                                        
                                    </Style>
                                    </PropertiesTextEdit>
                                    <EditFormSettings Caption="ID Cliente &gt;" ColumnSpan="2" Visible="True" />
                                    <PropertiesTextEdit Width="100px">
                                        <Style Font-Bold="False" HorizontalAlign="Left"></Style>
                                    </PropertiesTextEdit>
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Indexador" FieldName="indexador" Name="indexador"
                                    VisibleIndex="8" Width="100px">
                                    <EditFormSettings Caption="Indexador &gt;" ColumnSpan="2" Visible="True"
                                        CaptionLocation="Near" />
                                    <EditCellStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditCellStyle>
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Unidade" FieldName="unidade"
                                    Name="unidade" VisibleIndex="3"
                                    Width="80px" ReadOnly="True">
                                    <PropertiesTextEdit Width="60px">
                                        <Style Font-Bold="True">
                                    </Style>
                                    </PropertiesTextEdit>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn VisibleIndex="4" Caption="Parte" FieldName="parte"
                                    Name="parte" ReadOnly="True" Width="60px">
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataDateColumn Caption="Venda" FieldName="data_venda" Name="data_venda"
                                    VisibleIndex="6">
                                    <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy" Width="100px">
                                    </PropertiesDateEdit>
                                    <EditFormSettings Caption="Venda &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataDateColumn>
                                <dx3:GridViewDataTextColumn Caption="Periodicidade"
                                    FieldName="periodicidade_correcao" Name="periodicidade_correcao"
                                    VisibleIndex="9" Width="100px">
                                    <EditFormSettings Caption="Periodicidade &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataDateColumn Caption="Data Base" FieldName="ultima_correcao" Name="ultima_correcao"
                                    VisibleIndex="7">
                                    <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy" Width="100px">
                                    </PropertiesDateEdit>
                                    <EditFormSettings Caption="Data Base &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataDateColumn>
                            </Columns>
                            <SettingsBehavior AllowSelectByRowClick="True" ColumnResizeMode="Control" ConfirmDelete="True" />
                            <SettingsPager Visible="False" PageSize="100000">
                                <AllButton ImagePosition="Bottom" Visible="True">
                                </AllButton>
                            </SettingsPager>
                            <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                            <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                                VerticalScrollableHeight="400" />
                            <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                                CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                                CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Unidades do Produto"
                                Title="Verificar" />
                            <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                            <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                            <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                            <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                                VerticalScrollableHeight="400" />
                            <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                                CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                                CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Unidades do Produto"
                                Title="Verificar" />
                            <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                            <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                            <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                            <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                                VerticalScrollableHeight="400" />
                            <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                                CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                                CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Unidades do Produto"
                                Title="Verificar" />
                            <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                            <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                            <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                            <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                                VerticalScrollableHeight="400" />
                            <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                                CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                                CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Unidades do Produto"
                                Title="Verificar" />
                            <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                            <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
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
                        <div id="Div2" runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute; top: 20px; left: 650px; height: 50px; width: 150px;">
                            <dx:ASPxButton ID="btcarrega" runat="server" Height="40px" ImagePosition="Left"
                                Width="45px" OnClick="btcarrega_Click">
                                <Image Height="30px" ToolTip="Carregar Parcela" Url="~/images/BotoesTelas/BTNpesquisarA.bmp" UrlDisabled="~/images/BotoesTelas/BTNpesquisarI.bmp"
                                    UrlPressed="~/images/BotoesTelas/BTNpesquisarS.bmp" Width="30px">
                                </Image>
                            </dx:ASPxButton>
                            <dx:ASPxButton ID="btprocessa" runat="server" Height="40px" ImagePosition="Left"
                                OnClick="btprocessa_Click" Width="45px">
                                <Image Height="30px" ToolTip="Processa" Url="~/images/BotoesTelas/BTNalterarA.bmp" UrlDisabled="~/images/BotoesTelas/BTNalterarI.bmp"
                                    UrlPressed="~/images/BotoesTelas/BTNalterarS.bmp" Width="30px">
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
                        <div runat="server" style="z-index: 2; position: absolute; top: 900px; left: 10px; height: 200px; width: 378px;"
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
                                            <br />
                                            Correção Monetária dos Contratos.<br />
                                            <br />
                                            O Processo de Correção permite que o acordo financeiro feito para uma unidade seja
                                        aplicado, Corrigindo Monetáriamente o contrato baseando-se na Periodicidade e Indexador
                                        Financeiro escolhido.<br />
                                            <br />
                                            Dica: 
                                        <br />
                                            Emita extrato do contrato ou relatório de devedores antes de começar o processo.
                                        Preservando os valores antes da correção para posterior comparação.<br />
                                            <br />
                                            Alertas: 
                                        <br />
                                            A Seleção não inclui financiamentos marcados como quitados no sistema.
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

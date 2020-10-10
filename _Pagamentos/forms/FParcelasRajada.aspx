<%@ Page Title="FParcelasRajada" Language="C#" AutoEventWireup="true" CodeFile="FParcelasRajada.aspx.cs"
    Inherits="FParcelasRajada" StylesheetTheme="Principal" %>

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
    <title>Gitano - Pagamentos - Parcelas Agrupadas</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <link href="../../content/toastr.css" rel="stylesheet" />
</head>
<body style="height: 1400px">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager" runat="server" />
        <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1400px">
            <ContentTemplate>
                <h1>PAGAMENTOS - PARCELAS AGRUPADAS</h1>
                <h2>Pagamento de Parcelas Agrupadas</h2>
                <div id="DivNova" style="border-style: none">
                    <div style="border: 1px solid #808080; z-index: 1; left: 35px; top: 100px; position: absolute; height: 1500px; width: 832px; text-align: center;">
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
                            Text="Grupo" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxComboBox ID="cbgrupo" runat="server" ValueType="System.String" Font-Bold="True"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt; top: 50px; left: 150px;"
                            Width="380px" Theme="PlasticBlue"
                            OnSelectedIndexChanged="cbgrupo_SelectedIndexChanged" Visible="False" AutoPostBack="True">
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
                            ForeColor="#3E5395" Height="12px" Style="z-index: 2; left: 320px; top: 85px; position: absolute; right: 312px;"
                            Width="200px" RepeatDirection="Horizontal"
                            Visible="False" OnSelectedIndexChanged="rbmeiolote_SelectedIndexChanged">
                            <asp:ListItem Value="0" Selected="True">1o. Meio</asp:ListItem>
                            <asp:ListItem Value="1">2o. Meio</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:Label ID="Label8" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 120px; position: absolute"
                            Text="Cliente Comprador" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edcliente" runat="server" Style="z-index: 2; left: 150px; top: 120px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="380px" Visible="False"
                            AutoPostBack="True" ReadOnly="True">
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label4" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 155px; position: absolute"
                            Text="Data da Venda" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxDateEdit ID="dtvenda" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                            EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4; position: absolute; margin-right: 5px; left: 150px; top: 155px;"
                            Theme="PlasticBlue"
                            UseMaskBehavior="True" Width="120px" Visible="False" Enabled="False" MinDate="1900-01-01">
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
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 190px; position: absolute"
                            Text="Parcelas" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <asp:RadioButtonList ID="rbparcelasituacao" runat="server" AutoPostBack="True" CellPadding="0"
                            CellSpacing="0" Font-Names="Calibri" Font-Size="12pt" Font-Strikeout="False"
                            ForeColor="#3E5395" Height="12px" Style="z-index: 2; left: 150px; top: 190px; position: absolute; right: 423px;"
                            Width="300px" RepeatDirection="Horizontal"
                            Visible="False" OnSelectedIndexChanged="rbparcelasituacao_SelectedIndexChanged">
                            <asp:ListItem Value="0">Todas</asp:ListItem>
                            <asp:ListItem Value="1">Pagas</asp:ListItem>
                            <asp:ListItem Value="2" Selected="True">Em Aberto</asp:ListItem>
                        </asp:RadioButtonList>
                        <dx3:ASPxGridView ID="GridListagem" runat="server" AutoGenerateColumns="False" EnableTheming="True"
                            Font-Bold="False" KeyFieldName="ID" Style="margin-right: 6px; position: absolute; top: 230px; left: 10px;"
                            Theme="PlasticBlue" Width="812px" Visible="False" OnCommandButtonInitialize="GridListagem_CommandButtonInitialize"
                            OnInitNewRow="GridListagem_InitNewRow" OnRowDeleting="GridListagem_RowDeleting"
                            OnRowInserting="GridListagem_RowInserting" OnRowUpdating="GridListagem_RowUpdating">
                            <SettingsBehavior AllowSelectByRowClick="True" ColumnResizeMode="Control" ConfirmDelete="True" />
                            <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                            <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                                VerticalScrollableHeight="400" HorizontalScrollBarMode="Visible" />
                            <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                                CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                                CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Unidades do Produto"
                                Title="Verificar" />
                            <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                            <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                            <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                            <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                                VerticalScrollableHeight="400" />
                            <BackgroundImage HorizontalPosition="center" />
                            <Columns>
                                <dx3:GridViewCommandColumn ButtonType="Image" Caption=" Ação" ToolTip="Ações de Manutenção da Tabela"
                                    VisibleIndex="20" Visible="False" ShowSelectCheckbox="True">
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
                                <dx3:GridViewDataTextColumn FieldName="produto" VisibleIndex="2" Width="60px" Caption="Produto"
                                    Name="produto" ReadOnly="True" Visible="False">
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
                                <dx3:GridViewDataTextColumn Caption="Vlr Parcela" FieldName="vlr_parcela" Name="vlr_parcela"
                                    VisibleIndex="9" Width="100px">
                                    <PropertiesTextEdit DisplayFormatInEditMode="true" DisplayFormatString="N"></PropertiesTextEdit>
                                    <EditFormSettings Caption="Valor Parcela &gt;" ColumnSpan="4" Visible="True" CaptionLocation="Near" />
                                    <EditFormCaptionStyle HorizontalAlign="Right" Font-Bold="True">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Grupo" FieldName="grupo" Name="grupo" VisibleIndex="3"
                                    Width="60px" ReadOnly="True" Visible="False">
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
                                <dx3:GridViewDataTextColumn Caption="ID" FieldName="ID" Name="ID" VisibleIndex="1"
                                    Width="50px" ReadOnly="True">
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
                                <dx3:GridViewDataTextColumn Caption="Parcela" FieldName="parcela" Name="parcela"
                                    VisibleIndex="6" Width="50px">
                                    <PropertiesTextEdit Width="100px">
                                        <Style Font-Bold="False" HorizontalAlign="Left">
                                        
                                    </Style>
                                    </PropertiesTextEdit>
                                    <EditFormSettings Caption="Parcela &gt;" ColumnSpan="2" Visible="True" />
                                    <PropertiesTextEdit Width="100px">
                                        <Style Font-Bold="False" HorizontalAlign="Left"></Style>
                                    </PropertiesTextEdit>
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Vlr Pgto" FieldName="vlr_pagamento" Name="vlr_pagamento"
                                    VisibleIndex="11">
                                    <PropertiesTextEdit Width="100px" DisplayFormatInEditMode="true" DisplayFormatString="N"></PropertiesTextEdit>
                                    <EditFormSettings Caption="Valor Pagamento &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Tipo" FieldName="tipo" Name="tipo" VisibleIndex="7"
                                    Width="50px">
                                    <EditFormSettings Caption="Parte &gt;" ColumnSpan="2" Visible="True" CaptionLocation="Near" />
                                    <EditCellStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditCellStyle>
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn VisibleIndex="4" Caption="Unidade" FieldName="unidade"
                                    Name="unidade" ReadOnly="True" Width="80px" Visible="False">
                                    <PropertiesTextEdit Width="60px">
                                        <Style Font-Bold="True">
                                        
                                    </Style>
                                    </PropertiesTextEdit>
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn VisibleIndex="5" Caption="Parte" FieldName="parte" Name="parte"
                                    ReadOnly="True" Width="60px" Visible="False">
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataDateColumn Caption="Vencimento" FieldName="data_vencimento" Name="data_vencimento"
                                    SortIndex="0" SortOrder="Ascending" VisibleIndex="8">
                                    <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy" Width="100px">
                                    </PropertiesDateEdit>
                                    <EditFormSettings Caption="Vencimento &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataDateColumn>
                                <dx3:GridViewDataTextColumn Caption="Valor Base" FieldName="vlr_base" Name="vlr_base"
                                    Visible="False" VisibleIndex="15">
                                    <EditFormSettings Caption="Valor Base &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Nosso Número" FieldName="nossonumero" Name="nossonumero"
                                    VisibleIndex="16">
                                    <EditFormSettings Caption="Nosso Número &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Origem Pagamento" FieldName="origem_pagamento"
                                    Name="origem_pagamento" VisibleIndex="17">
                                    <EditFormSettings Caption="Origem Pagamento &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataCheckColumn Caption="Protesto" FieldName="protesto" Name="protesto"
                                    VisibleIndex="23">
                                    <PropertiesCheckEdit>
                                        <Style HorizontalAlign="Left">
                                        
                                    </Style>
                                    </PropertiesCheckEdit>
                                    <EditFormSettings Caption="Protesto &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataCheckColumn>
                                <dx3:GridViewDataTextColumn Caption="% Correção" FieldName="percentual_correcao"
                                    Name="percentual_correcao" Visible="False" VisibleIndex="21">
                                    <EditFormSettings Caption="% Correção &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Valor Original" FieldName="vlr_original" Name="vlr_original"
                                    Visible="False" VisibleIndex="13">
                                    <PropertiesTextEdit Width="100px">
                                    </PropertiesTextEdit>
                                    <EditFormSettings Caption="Valor Original &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="% Multa" FieldName="tx_multa" Name="tx_multa"
                                    Visible="False" VisibleIndex="25">
                                    <PropertiesTextEdit Width="100px">
                                    </PropertiesTextEdit>
                                    <EditFormSettings Caption="% Multa &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="% Comissão" FieldName="tx_comissao" Name="tx_comissao"
                                    Visible="False" VisibleIndex="26">
                                    <EditFormSettings Caption="% Comissão &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Valor Multa" FieldName="vlr_multa" Name="vlr_multa"
                                    VisibleIndex="29" Width="100px" Visible="False">
                                    <PropertiesTextEdit Width="100px">
                                    </PropertiesTextEdit>
                                    <EditFormSettings Caption="Valor Multa &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Valor Comissão" FieldName="vlr_comissao" Name="vlr_comissao"
                                    Visible="False" VisibleIndex="30">
                                    <EditFormSettings Caption="Valor Comissão &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Valor Desconto" FieldName="vlr_desconto" Name="vlr_desconto"
                                    Visible="False" VisibleIndex="31">
                                    <EditFormSettings Caption="Valor Desconto &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Comissão" FieldName="periodicidade_comissao"
                                    Name="periodicidade_comissao" Visible="False" VisibleIndex="27">
                                    <EditFormSettings Caption="Comissão &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataCheckColumn Caption="Ativa" FieldName="ativa" Name="ativa" ReadOnly="True"
                                    VisibleIndex="18" Width="50px">
                                    <PropertiesCheckEdit>
                                        <Style HorizontalAlign="Left">
                                        
                                    </Style>
                                    </PropertiesCheckEdit>
                                    <EditFormSettings Caption="Ativa &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Center">
                                    </CellStyle>
                                </dx3:GridViewDataCheckColumn>
                                <dx3:GridViewDataCheckColumn Caption="Contabil" FieldName="contabil" Name="contabil"
                                    VisibleIndex="24">
                                    <PropertiesCheckEdit>
                                        <Style HorizontalAlign="Left">
                                        
                                    </Style>
                                    </PropertiesCheckEdit>
                                    <EditFormSettings Caption="Contabil &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataCheckColumn>
                                <dx3:GridViewDataDateColumn Caption="Pagamento" FieldName="data_pagamento" Name="data_pagamento"
                                    VisibleIndex="10">
                                    <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy" Width="100px">
                                    </PropertiesDateEdit>
                                    <EditFormSettings Caption="Pagamento &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataDateColumn>
                                <dx3:GridViewDataTextColumn Caption="Conta" FieldName="conta" Name="conta" VisibleIndex="19"
                                    Width="50px">
                                    <EditFormSettings Caption="Conta &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Center">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataCheckColumn Caption="Carteira" FieldName="carteira" Name="carteira"
                                    VisibleIndex="22">
                                    <PropertiesCheckEdit>
                                        <Style HorizontalAlign="Left">
                                        
                                    </Style>
                                    </PropertiesCheckEdit>
                                    <EditFormSettings Caption="Carteira &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataCheckColumn>
                                <dx3:GridViewDataDateColumn Caption="Data Original" FieldName="data_original" Name="data_original"
                                    Visible="False" VisibleIndex="12">
                                    <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy" Width="100px">
                                    </PropertiesDateEdit>
                                    <EditFormSettings Caption="Data Original &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataDateColumn>
                                <dx3:GridViewDataDateColumn Caption="Data Base" FieldName="data_base" Name="data_base"
                                    Visible="False" VisibleIndex="14" Width="100px">
                                    <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy" Width="100px">
                                    </PropertiesDateEdit>
                                    <EditFormSettings Caption="Data Base &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataDateColumn>
                                <dx3:GridViewDataDateColumn Caption="Data Conta" FieldName="data_conta" Name="data_conta"
                                    ReadOnly="True" Visible="False" VisibleIndex="32">
                                    <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy" EnableFocusedStyle="False">
                                        <Style HorizontalAlign="Left">
                                        
                                    </Style>
                                    </PropertiesDateEdit>
                                    <EditFormSettings Caption="Data Conta &gt;" CaptionLocation="Near" ColumnSpan="2"
                                        Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataDateColumn>
                                <dx3:GridViewDataTextColumn Caption="Indexador" FieldName="indexador" Name="indexador"
                                    Visible="False" VisibleIndex="33">
                                    <PropertiesTextEdit Width="60px">
                                        <Style Font-Bold="True">
                                        
                                    </Style>
                                    </PropertiesTextEdit>
                                    <EditFormSettings Caption="Unidade &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <PropertiesTextEdit EnableFocusedStyle="False">
                                        <Style HorizontalAlign="Left">
                                        
                                    </Style>
                                    </PropertiesTextEdit>
                                    <EditFormSettings Caption="Tipo &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <EditFormSettings Caption="Indexador &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Indexador Mês" FieldName="indexador_mes" Name="indexador_mes"
                                    VisibleIndex="34" Visible="False">
                                    <EditFormSettings Caption="Indexador Mês &gt;" ColumnSpan="2" Visible="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Indexador Acumulado" FieldName="indexador_acumulado"
                                    Name="indexador_acumulado" Visible="False" VisibleIndex="35">
                                    <EditFormSettings Caption="Indexador Acumulado &gt;" ColumnSpan="2" Visible="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Resíduo Mês" FieldName="residuo_mes" Name="residuo_mes"
                                    Visible="False" VisibleIndex="36">
                                    <EditFormSettings Caption="Resíduo Mês &gt;" ColumnSpan="2" Visible="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Resíduo Acumulado" FieldName="residuo_acumulado"
                                    Name="residuo_acumulado" Visible="False" VisibleIndex="37">
                                    <EditFormSettings Caption="Resíduo Acumulado &gt;" ColumnSpan="2" Visible="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Valor Correção" FieldName="vlr_correcao" Name="vlr_correcao"
                                    Visible="False" VisibleIndex="28">
                                    <EditFormSettings Caption="Valor Correção &gt;" ColumnSpan="2" Visible="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Observações" FieldName="observacao" Name="observacao"
                                    Visible="False" VisibleIndex="38">
                                    <EditFormSettings Caption="Observações &gt;" ColumnSpan="2" Visible="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Width="50px">
                                    <HeaderTemplate>
                                        <dx:ASPxCheckBox ID="ASPxCheckBox1" runat="server" ToolTip="Marca/Desmarca Todos os itens visíveis"
                                            ClientSideEvents-CheckedChanged="function(s, e) { GridListagem.SelectAllRowsOnPage(s.GetChecked()); }">
                                        </dx:ASPxCheckBox>
                                    </HeaderTemplate>
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
                        <asp:Label ID="Label11" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 715px; position: absolute"
                            Text="Qtd.Parcelas" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edqtdparcelas" runat="server" Style="z-index: 2; left: 150px; top: 715px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="200px"
                            Visible="False" AutoPostBack="True" ReadOnly="True">
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label5" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 750px; position: absolute"
                            Text="Valor Parcelas" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edvlr_parcela" runat="server" Style="z-index: 2; left: 150px; top: 750px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="200px"
                            Visible="False" AutoPostBack="True" ReadOnly="True">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label6" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 780px; position: absolute"
                            Text="Valor Pagamento" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edvlr_pagamento" runat="server" Style="z-index: 2; left: 150px; top: 780px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="200px"
                            Visible="False" AutoPostBack="True" OnTextChanged="edvlr_pagamento_TextChanged">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                        <dx:ASPxTextBox ID="edvlr_diferenca" runat="server" Style="z-index: 2; left: 370px; top: 780px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="200px"
                            Visible="False" AutoPostBack="True" ReadOnly="True">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                        <dx:ASPxTextBox ID="edperc_diferenca" runat="server" Style="z-index: 2; left: 590px; top: 780px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="80px"
                            Visible="False" AutoPostBack="True" ReadOnly="True">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99999999&gt;" />
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label10" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 680px; top: 780px; position: absolute"
                            Text="%" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <asp:Label ID="Label9" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 815px; position: absolute"
                            Text="Pagamento" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxDateEdit ID="eddtpagamento" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                            EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4; position: absolute; margin-right: 5px; left: 150px; top: 815px;"
                            Theme="PlasticBlue"
                            AutoPostBack="True" UseMaskBehavior="True" Width="120px" Visible="False" Enabled="False" MinDate="1900-01-01">
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
                        <asp:Label ID="Label21" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 850px; position: absolute"
                            Text="Forma Pagamento" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxComboBox ID="cbformapagamento" runat="server" ValueType="System.String" Font-Bold="True"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt; top: 850px; left: 150px;"
                            Width="380px"
                            Theme="PlasticBlue" Visible="False" AutoPostBack="True">
                        </dx:ASPxComboBox>
                        <asp:Label ID="Label22" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 885px; position: absolute"
                            Text="Conta Corrente" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxComboBox ID="cbcontascorrentes" runat="server" ValueType="System.String"
                            Font-Bold="True" Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt; top: 885px; left: 150px;"
                            Width="380px"
                            Theme="PlasticBlue" Visible="False" AutoPostBack="True">
                        </dx:ASPxComboBox>
                        <asp:Label ID="Label24" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 920px; position: absolute"
                            Text="Feedback" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edfeedback" runat="server" Style="z-index: 2; left: 150px; top: 920px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="600px" Visible="False"
                            AutoPostBack="True" ReadOnly="True">
                        </dx:ASPxTextBox>
                        <div id="Div2" runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute; top: 720px; left: 600px; height: 50px; width: 150px;">
                            <dx:ASPxButton ID="btcarrega" runat="server" Height="40px" ImagePosition="Left" Width="45px"
                                OnClick="btcarrega_Click">
                                <Image Height="30px" ToolTip="Carregar Parcela" Url="~/images/BotoesTelas/BTNpesquisarA.bmp"
                                    UrlDisabled="~/images/BotoesTelas/BTNpesquisarI.bmp" UrlPressed="~/images/BotoesTelas/BTNpesquisarS.bmp"
                                    Width="30px">
                                </Image>
                            </dx:ASPxButton>
                            <dx:ASPxButton ID="btprocessa" runat="server" Height="40px" ImagePosition="Left"
                                OnClick="btprocessa_Click" Width="45px">
                                <Image Height="30px" ToolTip="Gravar Pagamento Parcela" Url="~/images/BotoesTelas/BTNalterarA.bmp"
                                    UrlDisabled="~/images/BotoesTelas/BTNalterarI.bmp" UrlPressed="~/images/BotoesTelas/BTNalterarS.bmp"
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
                        <div runat="server" style="z-index: 2; position: absolute; top: 1150px; left: 10px; height: 200px; width: 378px;"
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
                                            Pagamento de Parcela.<br />
                                            <br />
                                            O Processo de pagamento da parcela, envolve a data do pagamento a partir dai o sistema
                                        efetua os calculos conforme foram estabelecidos no momento da venda para pagamento
                                        de parcelas e inadimplência.<br />
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

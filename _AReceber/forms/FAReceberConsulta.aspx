<%@ Page Title="FAReceberConsulta" Language="C#" AutoEventWireup="true" CodeFile="FAReceberConsulta.aspx.cs"
    Inherits="FAReceberConsulta" StylesheetTheme="Principal" %>

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
<script runat="server">
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Gitano - Contas a Receber - Consultas</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body style="height: 1400px">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager" runat="server" />
        <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1400px">
            <ContentTemplate>
                <h1>CONSULTA LANÇAMENTOS - CONTAS A RECEBER</h1>
                <h2>Consulta</h2>
                <div id="DivNova" style="border-style: none">
                    <div style="border: 1px solid #808080; z-index: 1; left: 35px; top: 100px; position: absolute; height: 1200px; width: 900px; text-align: center;">
                        <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px; position: absolute"
                            Text="Filtro" Theme="PlasticBlue"></asp:Label>
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
                            Text="Tipo de Receita" Theme="PlasticBlue"
                            Visible="False"></asp:Label>
                        <dx:ASPxComboBox ID="cbreceita" runat="server" ValueType="System.String" Font-Bold="True"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt; top: 50px; left: 150px;"
                            Width="380px" Theme="PlasticBlue" Visible="False"
                            AutoPostBack="True">
                        </dx:ASPxComboBox>
                        <asp:Label ID="Label7" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 85px; position: absolute"
                            Text="Cliente" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxComboBox ID="cbclientes" runat="server" ValueType="System.String" Font-Bold="True"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt; top: 85px; left: 150px;"
                            Width="380px" Theme="PlasticBlue" Visible="False"
                            AutoPostBack="True">
                        </dx:ASPxComboBox>
                        <asp:Label ID="Label16" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 120px; position: absolute"
                            Text="Conta Corrente" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxComboBox ID="cbcontascorrentes" runat="server" ValueType="System.String" Font-Bold="True"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt; top: 120px; left: 150px;"
                            Width="380px" Theme="PlasticBlue" Visible="False"
                            AutoPostBack="True">
                        </dx:ASPxComboBox>
                        <asp:Label ID="Label8" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 155px; position: absolute"
                            Text="Documento" Theme="PlasticBlue"></asp:Label>
                        <dx:ASPxTextBox ID="eddocumento" runat="server" Style="z-index: 2; left: 150px; top: 155px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="380px"
                            AutoPostBack="True" ReadOnly="True">
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label4" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 190px; position: absolute"
                            Text="Período Previsão" Theme="PlasticBlue"
                            Visible="False"></asp:Label>
                        <dx:ASPxDateEdit ID="dtprevisao1" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                            EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4; position: absolute; margin-right: 5px; left: 150px; top: 190px;"
                            Theme="PlasticBlue"
                            UseMaskBehavior="True" Width="120px" Visible="False" AutoPostBack="True" MinDate="1900-01-01">
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
                        <asp:Label ID="Label5" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 300px; top: 190px; position: absolute"
                            Text="Até" Theme="PlasticBlue"
                            Visible="False"></asp:Label>
                        <dx:ASPxDateEdit ID="dtprevisao2" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                            EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4; position: absolute; margin-right: 5px; left: 350px; top: 190px;"
                            Theme="PlasticBlue"
                            UseMaskBehavior="True" Width="120px" Visible="False" AutoPostBack="True" MinDate="1900-01-01">
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
                        <asp:Label ID="Label6" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 225px; position: absolute"
                            Text="Período Realizado" Theme="PlasticBlue"
                            Visible="False"></asp:Label>
                        <dx:ASPxDateEdit ID="dtrealizado1" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                            EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4; position: absolute; margin-right: 5px; left: 150px; top: 225px;"
                            Theme="PlasticBlue"
                            UseMaskBehavior="True" Width="120px" Visible="False" AutoPostBack="True" MinDate="1900-01-01">
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
                        <asp:Label ID="Label9" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 300px; top: 225px; position: absolute"
                            Text="Até" Theme="PlasticBlue"
                            Visible="False"></asp:Label>
                        <dx:ASPxDateEdit ID="dtrealizado2" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                            EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4; position: absolute; margin-right: 5px; left: 350px; top: 225px;"
                            Theme="PlasticBlue"
                            UseMaskBehavior="True" Width="120px" Visible="False" AutoPostBack="True" MinDate="1900-01-01">
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
                        <asp:Label ID="Label10" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 260px; position: absolute"
                            Text="Período Nota Fiscal" Theme="PlasticBlue"
                            Visible="False"></asp:Label>
                        <dx:ASPxDateEdit ID="dtnotafiscal1" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                            EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4; position: absolute; margin-right: 5px; left: 150px; top: 260px;"
                            Theme="PlasticBlue"
                            UseMaskBehavior="True" Width="120px" Visible="False" AutoPostBack="True" MinDate="1900-01-01">
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
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 300px; top: 260px; position: absolute"
                            Text="Até" Theme="PlasticBlue"
                            Visible="False"></asp:Label>
                        <dx:ASPxDateEdit ID="dtnotafiscal2" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                            EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4; position: absolute; margin-right: 5px; left: 350px; top: 260px;"
                            Theme="PlasticBlue"
                            UseMaskBehavior="True" Width="120px" Visible="False" AutoPostBack="True" MinDate="1900-01-01">
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
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 295px; position: absolute"
                            Text="Lançamentos" Theme="PlasticBlue"></asp:Label>
                        <asp:RadioButtonList ID="rbparcelasituacao" runat="server" AutoPostBack="True" CellPadding="0"
                            CellSpacing="0" Font-Names="Calibri" Font-Size="12pt" Font-Strikeout="False"
                            ForeColor="#3E5395" Height="12px" Style="z-index: 2; left: 150px; top: 295px; position: absolute; right: 382px;"
                            Width="300px" RepeatDirection="Horizontal">
                            <asp:ListItem Value="0" Selected="True">Todos</asp:ListItem>
                            <asp:ListItem Value="1">Previstos</asp:ListItem>
                            <asp:ListItem Value="2">Realizados</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:Label ID="Label12" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 330px; position: absolute"
                            Text="Ordenação" Theme="PlasticBlue"></asp:Label>
                        <asp:RadioButtonList ID="rbordenacao" runat="server" AutoPostBack="True" CellPadding="0"
                            CellSpacing="0" Font-Names="Calibri" Font-Size="12pt" Font-Strikeout="False"
                            ForeColor="#3E5395" Height="12px" Style="z-index: 2; left: 150px; top: 330px; position: absolute; right: 423px;"
                            Width="650px"
                            RepeatDirection="Horizontal">
                            <asp:ListItem Value="0" Selected="True">Lançamento</asp:ListItem>
                            <asp:ListItem Value="1">Classe Receita</asp:ListItem>
                            <asp:ListItem Value="2">Cliente</asp:ListItem>
                            <asp:ListItem Value="3">Dt Prevista</asp:ListItem>
                            <asp:ListItem Value="4">Dt Realizada</asp:ListItem>
                            <asp:ListItem Value="5">Dt Nota Fiscal</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:Label ID="Label14" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 365px; position: absolute"
                            Text="T.Previsto (Vlr\Qtd)" Theme="PlasticBlue"></asp:Label>
                        <dx:ASPxTextBox ID="edvlrtotalprevisto" runat="server" Style="z-index: 2; left: 150px; top: 365px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="200px"
                            AutoPostBack="True" ReadOnly="True" HorizontalAlign="Right">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                        <dx:ASPxTextBox ID="edqtdtotalprevisto" runat="server" Style="z-index: 2; left: 400px; top: 365px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="200px"
                            AutoPostBack="True" ReadOnly="True" HorizontalAlign="Right">
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label15" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 400px; position: absolute"
                            Text="T.Realizado (Vlr\Qtd)" Theme="PlasticBlue"></asp:Label>
                        <dx:ASPxTextBox ID="edvlrtotalrealizado" runat="server" Style="z-index: 2; left: 150px; top: 400px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="200px"
                            AutoPostBack="True" ReadOnly="True" HorizontalAlign="Right">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                        <dx:ASPxTextBox ID="edqtdtotalrealizado" runat="server" Style="z-index: 2; left: 400px; top: 400px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="200px"
                            AutoPostBack="True" ReadOnly="True" HorizontalAlign="Right">
                        </dx:ASPxTextBox>
                        <dx3:ASPxGridView ID="GridListagem" runat="server" AutoGenerateColumns="False" EnableTheming="True"
                            Font-Bold="False" KeyFieldName="lancamento" Style="margin-right: 6px; position: absolute; top: 435px; left: 10px; height: 400px;"
                            Theme="PlasticBlue" Width="850px" Visible="False"
                            OnCommandButtonInitialize="GridListagem_CommandButtonInitialize"
                            OnInitNewRow="GridListagem_InitNewRow" OnRowDeleting="GridListagem_RowDeleting"
                            OnRowInserting="GridListagem_RowInserting"
                            OnRowUpdating="GridListagem_RowUpdating">
                            <SettingsBehavior AllowSelectByRowClick="True" ColumnResizeMode="Control" ConfirmDelete="True" />
                            <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                            <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                                VerticalScrollableHeight="400" HorizontalScrollBarMode="Visible" />
                            <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                                CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                                CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Contas a Receber"
                                Title="Verificar" />
                            <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                            <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                            <BackgroundImage HorizontalPosition="center" />
                            <SettingsBehavior AllowSelectByRowClick="True" ColumnResizeMode="Control" ConfirmDelete="True" />
                            <Columns>
                                <dx3:GridViewCommandColumn ButtonType="Image" Caption=" Ação" ToolTip="Ações de Manutenção da Tabela"
                                    VisibleIndex="9" Width="100px">
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
                                    Name="produto">
                                    <%--                                SortIndex="0" SortOrder="Ascending" ReadOnly="True"--%>
                                    <EditFormSettings Caption="Produto &gt;" ColumnSpan="1" Visible="False" />
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
                                <dx3:GridViewDataTextColumn Caption="Vlr Previsto" FieldName="vlr_previsto" Name="vlr_previsto"
                                    VisibleIndex="8" Width="100px">
                                    <PropertiesTextEdit DisplayFormatInEditMode="true" DisplayFormatString="N"></PropertiesTextEdit>
                                    <EditFormSettings Caption="Vlr Previsto &gt;" ColumnSpan="4" Visible="False"
                                        CaptionLocation="Near" />
                                    <EditFormCaptionStyle HorizontalAlign="Right" Font-Bold="True">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Classe" FieldName="classe" Name="classe" VisibleIndex="4"
                                    Width="60px" ReadOnly="True">
                                    <PropertiesTextEdit EnableFocusedStyle="False" Width="60px">
                                        <Style HorizontalAlign="Left" Font-Bold="True"></Style>
                                    </PropertiesTextEdit>
                                    <EditFormSettings Caption="Classe &gt;" ColumnSpan="2" Visible="False" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="ID" FieldName="ID" Name="ID" VisibleIndex="0"
                                    Width="60px" ReadOnly="True">
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
                                <dx3:GridViewDataTextColumn Caption="Lanc." FieldName="lancamento" Name="lancamento"
                                    VisibleIndex="1" Width="60px">
                                    <PropertiesTextEdit Width="100px">
                                        <Style Font-Bold="False" HorizontalAlign="Left">
                                    </Style>
                                    </PropertiesTextEdit>
                                    <EditFormSettings Caption="No. Lanc. &gt;" ColumnSpan="2" Visible="True" />
                                    <PropertiesTextEdit Width="100px">
                                        <Style Font-Bold="False" HorizontalAlign="Left"></Style>
                                    </PropertiesTextEdit>
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Vlr Real." FieldName="vlr_realizado"
                                    Name="vlr_realizado" VisibleIndex="11" Width="100px">
                                    <PropertiesTextEdit Width="100px" DisplayFormatInEditMode="true" DisplayFormatString="N"></PropertiesTextEdit>
                                    <EditFormSettings Caption="Vlr Real. &gt;" ColumnSpan="4"
                                        Visible="False" CaptionLocation="Near" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Conta" FieldName="conta"
                                    Name="conta" VisibleIndex="12" ReadOnly="True" Width="80px">
                                    <EditFormSettings Caption="Conta &gt;" ColumnSpan="2" Visible="False" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataDateColumn Caption="Data Prev." FieldName="data_prevista"
                                    Name="data_prevista" VisibleIndex="7" Width="100px">
                                    <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy" Width="100px">
                                    </PropertiesDateEdit>
                                    <EditFormSettings Caption="Data Prev. &gt;" ColumnSpan="2" Visible="False" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataDateColumn>
                                <dx3:GridViewDataTextColumn Caption="Documento" FieldName="documento"
                                    Name="documento" VisibleIndex="13" Visible="False">
                                    <PropertiesTextEdit Width="60px">
                                        <Style Font-Bold="True">
                                    </Style>
                                    </PropertiesTextEdit>
                                    <EditFormSettings Caption="Documento &gt;" ColumnSpan="2" Visible="False" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Cheque"
                                    FieldName="cheque" Name="cheque"
                                    VisibleIndex="15" Visible="False">
                                    <EditFormSettings Caption="Cheque &gt;" ColumnSpan="2"
                                        Visible="False" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataCheckColumn Caption="Contabil" FieldName="contabil"
                                    Name="contabil" VisibleIndex="18" ReadOnly="True" Width="50px"
                                    Visible="False">
                                    <PropertiesCheckEdit>
                                        <Style HorizontalAlign="Left">
                                    
                                    </Style>
                                    </PropertiesCheckEdit>
                                    <EditFormSettings Caption="Contabil &gt;" ColumnSpan="2" Visible="False" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Center">
                                    </CellStyle>
                                </dx3:GridViewDataCheckColumn>
                                <dx3:GridViewDataDateColumn Caption="Data Real." FieldName="data_realizado"
                                    Name="data_realizado" VisibleIndex="10" Width="100px">
                                    <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy" Width="100px">
                                    </PropertiesDateEdit>
                                    <EditFormSettings Caption="Data Real. &gt;" ColumnSpan="2" Visible="False" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataDateColumn>
                                <dx3:GridViewDataTextColumn Caption="Integracao Contabil"
                                    FieldName="integracao_contabil" Name="integracao_contabil" VisibleIndex="19"
                                    Width="50px" Visible="False">
                                    <EditFormSettings Caption="Integracao Contabil &gt;" ColumnSpan="2"
                                        Visible="False" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Center">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataDateColumn Caption="Data Documento" FieldName="data_documento"
                                    Name="data_documento" VisibleIndex="14" Visible="False">
                                    <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy" Width="100px">
                                    </PropertiesDateEdit>
                                    <EditFormSettings Caption="Data Documento &gt;" ColumnSpan="2"
                                        Visible="False" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataDateColumn>
                                <dx3:GridViewDataDateColumn Caption="Data Compensação" FieldName="dtcompensacao"
                                    Name="dtcompensacao" VisibleIndex="17" Width="100px">
                                    <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy" Width="100px">
                                        <Style HorizontalAlign="Left">
                                    </Style>
                                    </PropertiesDateEdit>
                                    <EditFormSettings Caption="Data Compensação &gt;" ColumnSpan="2" Visible="True"
                                        CaptionLocation="Near" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataDateColumn>
                                <dx3:GridViewDataTextColumn Caption="Cmc7" FieldName="cmc7" Name="cmc7"
                                    VisibleIndex="16" Visible="False">
                                    <PropertiesTextEdit Width="60px">
                                        <Style Font-Bold="True">
                                    </Style>
                                    </PropertiesTextEdit>
                                    <EditFormSettings Caption="Cmc7 &gt;" ColumnSpan="2" Visible="False" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <PropertiesTextEdit EnableFocusedStyle="False">
                                        <Style HorizontalAlign="Left">
                                    </Style>
                                    </PropertiesTextEdit>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Pedido Compra" FieldName="pedido_compra" Name="pedido_compra"
                                    VisibleIndex="20" Visible="False">
                                    <EditFormSettings Caption="Pedido Compra &gt;" ColumnSpan="2" Visible="False" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Grupo" FieldName="grupo"
                                    Name="grupo" VisibleIndex="3" Visible="False">
                                    <EditFormSettings Caption="Grupo &gt;" ColumnSpan="2" Visible="False" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Descrição" FieldName="descricao"
                                    Name="descricao" VisibleIndex="6" Width="250px">
                                    <EditFormSettings Caption="Descrição &gt;" ColumnSpan="2" Visible="False" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Cliente" FieldName="cliente"
                                    Name="cliente" VisibleIndex="5" Width="60px">
                                    <EditFormSettings Caption="Cliente &gt;" CaptionLocation="Near"
                                        ColumnSpan="2" Visible="False" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                            </Columns>
                            <SettingsPager Visible="False" PageSize="100000">
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
                        <div id="Div2" runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute; top: 20px; left: 700px; height: 50px; width: 100px;">
                            <dx:ASPxButton ID="btprocessa" runat="server" Height="40px" ImagePosition="Left"
                                OnClick="btprocessa_Click" Width="45px" ToolTip="Aplica Filtros">
                                <Image Height="30px" ToolTip="Aplicar Filtro"
                                    Url="~/images/BotoesTelas/BTNalterarA.bmp" UrlDisabled="~/images/BotoesTelas/BTNalterarI.bmp"
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
                                Theme="PlasticBlue" PopupElementID="bthelp" PopupVerticalAlign="Below" PopupHorizontalAlign="LeftSides"
                                AllowDragging="True" ShowFooter="True" Width="310px" Height="160px" HeaderText="Ajuda do Sistema"
                                ClientInstanceName="Popuphelp" FooterText="Gitano Software">
                                <HeaderStyle Font-Bold="True" />
                                <ContentCollection>
                                    <dx:PopupControlContentControl ID="PopupControlContentControl" runat="server">
                                        <div style="vertical-align: middle">
                                            Consulta de Lançamentos do Contas a Receber.<br />
                                            <br />
                                            Através dos filtros é possivel localizar lançamentos em vários perfis.<br />
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

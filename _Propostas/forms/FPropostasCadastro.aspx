<%@ Page Title="FPropostasCadastro" Language="C#" AutoEventWireup="true" CodeFile="FPropostasCadastro.aspx.cs"
    Inherits="FPropostasCadastro" StylesheetTheme="Principal" %>

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
    <title>Gitano - Propostas - Cadastro</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <link href="../../content/toastr.css" rel="stylesheet" />
</head>
<body style="height: 1400px">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1400px">
        <ContentTemplate>
            <h1>
                PROPOSTAS - CADASTRO</h1>
            <h2>
                Cadastro da Proposta de Venda</h2>
            <div id="DivNova" style="border-style: none">
                <div style="border: 1px solid #808080; z-index: 1; left: 35px; top: 100px; position: absolute;
                    height: 2000px; width: 832px; text-align: center;">
                    <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px;
                        position: absolute" Text="Selecione" Theme="PlasticBlue"></asp:Label>
                    <asp:Label ID="Label3" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 15px;
                        position: absolute" Text="Produto" Theme="PlasticBlue"></asp:Label>
                    <dx:ASPxComboBox ID="cbproduto" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 15px; left: 150px;" Width="380px" Theme="PlasticBlue"
                        OnSelectedIndexChanged="cbproduto_SelectedIndexChanged" AutoPostBack="True">
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label2" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 50px;
                        position: absolute" Text="Grupo" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxComboBox ID="cbgrupo" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 50px; left: 150px;" Width="380px" Theme="PlasticBlue"
                        OnSelectedIndexChanged="cbgrupo_SelectedIndexChanged" Visible="False" AutoPostBack="True">
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label7" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 85px;
                        position: absolute" Text="Unidades - Parte" Theme="PlasticBlue" 
                        Visible="False"></asp:Label>
                    <dx:ASPxComboBox ID="cbgrupounidades" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 85px; left: 150px;" Width="150px" Theme="PlasticBlue"
                        OnSelectedIndexChanged="cbgrupounidades_SelectedIndexChanged" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxComboBox>
                    <asp:RadioButtonList ID="rbmeiolote" runat="server" AutoPostBack="True" CellPadding="0"
                        CellSpacing="0" Font-Names="Calibri" Font-Size="12pt" Font-Strikeout="False"
                        ForeColor="#3E5395" Height="12px" Style="z-index: 2; left: 320px; top: 85px;
                        position: absolute; right: 423px;" Width="200px" RepeatDirection="Horizontal"
                        Visible="False">
                        <asp:ListItem Value="0" Selected="True">1o. Meio</asp:ListItem>
                        <asp:ListItem Value="1">2o. Meio</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:Label ID="Label8" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 120px;
                        position: absolute" Text="Cliente" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="cbclientes" runat="server" Style="z-index: 2; left: 150px; top: 120px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="380px" Visible="False"
                        AutoPostBack="True" OnTextChanged="cbclientes_TextChanged">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label76" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 550px; top: 120px;
                        position: absolute" Text="Nascimento" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxDateEdit ID="dtnascimento1" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                        EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 2;
                        position: absolute; margin-right: 5px; left: 660px; top: 120px;" Theme="PlasticBlue"
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
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 155px;
                        position: absolute" Text="Rg No." Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edrg" runat="server" Style="z-index: 2; left: 150px; top: 155px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label4" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 320px; top: 155px;
                        position: absolute" Text="Rg Emissão" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxDateEdit ID="dtrgemissao" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                        EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 2;
                        position: absolute; margin-right: 5px; left: 410px; top: 155px;" Theme="PlasticBlue"
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
                    <asp:Label ID="Label5" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 550px; top: 155px;
                        position: absolute" Text="Rg Orgão" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edrgorgao" runat="server" Style="z-index: 2; left: 660px; top: 155px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px" Visible="False"
                        AutoPostBack="True" ontextchanged="edrgorgao_TextChanged">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label68" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 190px;
                        position: absolute" Text="Sexo" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edsexo" runat="server" Style="z-index: 2; left: 150px; top: 190px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="120px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label6" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 320px; top: 190px;
                        position: absolute" Text="Profissão" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edprofissao" runat="server" Style="z-index: 2; left: 410px; top: 190px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="120px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label67" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 550px; top: 190px;
                        position: absolute" Text="Nacionalidade" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="ednacionalidade" runat="server" Style="z-index: 2; left: 660px; top: 190px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label9" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 225px;
                        position: absolute" Text="CPF No." Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edcpf" runat="server" Style="z-index: 2; left: 150px; top: 225px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px" Visible="False"
                        AutoPostBack="True" ontextchanged="edcpf_TextChanged">
                        <MaskSettings IncludeLiterals="None" Mask="999.999.999-99999" />
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label10" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 320px; top: 225px;
                        position: absolute" Text="Estado Civil" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edestadocivil" runat="server" Style="z-index: 2; left: 410px;
                        top: 225px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="120px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label11" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 550px; top: 225px;
                        position: absolute" Text="Reg.Casamento" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxComboBox ID="cbregimecasamento" runat="server" ValueType="System.String"
                        Font-Bold="True" Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        position: absolute; font-size: 10pt; top: 225px; left: 660px;" Width="150px"
                        Theme="PlasticBlue" Visible="False" AutoPostBack="True">
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label12" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 260px;
                        position: absolute" Text="Conjuge" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="ednomeconjuge" runat="server" Style="z-index: 2; left: 150px;
                        top: 260px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="380px"
                        Visible="False" AutoPostBack="True" 
                        ontextchanged="ednomeconjuge_TextChanged">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label77" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 550px; top: 260px;
                        position: absolute" Text="Nascimento" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxDateEdit ID="dtnascimentoconjuge" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                        EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 2;
                        position: absolute; margin-right: 5px; left: 660px; top: 260px;" Theme="PlasticBlue"
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
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 295px;
                        position: absolute" Text="Rg No." Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edrgconjuge" runat="server" Style="z-index: 2; left: 150px; top: 295px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px" Visible="False"
                        AutoPostBack="True" ontextchanged="edrgconjuge_TextChanged">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label70" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 320px; top: 295px;
                        position: absolute" Text="Rg Emissão" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxDateEdit ID="dtrgemissaoconjuge" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                        EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 2;
                        position: absolute; margin-right: 5px; left: 410px; top: 295px;" Theme="PlasticBlue"
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
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 550px; top: 295px;
                        position: absolute" Text="Rg Orgão" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edrgorgaoconjuge" runat="server" Style="z-index: 2; left: 660px; top: 295px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label72" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 330px;
                        position: absolute" Text="Sexo" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edsexoconjuge" runat="server" Style="z-index: 2; left: 150px; top: 330px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="120px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label73" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 320px; top: 330px;
                        position: absolute" Text="Profissão" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edprofissaoconjuge" runat="server" Style="z-index: 2; left: 410px; top: 330px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="120px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label74" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 550px; top: 330px;
                        position: absolute" Text="Nacionalidade" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="ednacionalidadeconjuge" runat="server" Style="z-index: 2; left: 660px; top: 330px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label13" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 365px;
                        position: absolute" Text="Endereço Res." Theme="PlasticBlue" 
                        Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenderecores" runat="server" Style="z-index: 2; left: 150px;
                        top: 365px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="380px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label75" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 550px; top: 365px;
                        position: absolute" Text="CPF No." Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edcpfconjuge" runat="server" Style="z-index: 2; left: 660px; top: 365px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px" Visible="False"
                        AutoPostBack="True" ontextchanged="edcpfconjuge_TextChanged">
                        <MaskSettings IncludeLiterals="None" Mask="999.999.999-99999" />
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label14" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 400px;
                        position: absolute" Text="Numero" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenredecoresnumero" runat="server" Style="z-index: 2; left: 150px;
                        top: 400px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label15" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 320px; top: 400px;
                        position: absolute" Text="Complemento" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenredecorescomplemento" runat="server" Style="z-index: 2; left: 410px;
                        top: 400px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="120px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label16" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 435px;
                        position: absolute" Text="Bairro" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenderecoresbairro" runat="server" Style="z-index: 2; left: 150px;
                        top: 435px; position: absolute; right: 532px;" Theme="PlasticBlue" Width="150px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label17" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 320px; top: 435px;
                        position: absolute" Text="Cep" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenderecorescep" runat="server" Style="z-index: 2; left: 410px;
                        top: 435px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="120px"
                        Visible="False" AutoPostBack="True">
                        <MaskSettings IncludeLiterals="None" Mask="99999-999" />
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label18" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 470px;
                        position: absolute" Text="Cidade" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenderecorescidade" runat="server" Style="z-index: 2; left: 150px;
                        top: 470px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="380px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label19" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 505px;
                        position: absolute" Text="Tel. Residencial" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edtelefoneres" runat="server" Style="z-index: 2; left: 150px;
                        top: 505px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label20" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 320px; top: 505px;
                        position: absolute" Text="Tel. Cobrança" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edtelefonecom" runat="server" Style="z-index: 2; left: 410px;
                        top: 505px; position: absolute; right: 272px;" Theme="PlasticBlue" Width="120px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label21" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 540px;
                        position: absolute" Text="Endereço Cob." Theme="PlasticBlue" 
                        Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenderecocob" runat="server" Style="z-index: 2; left: 150px;
                        top: 540px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="380px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label22" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 575px;
                        position: absolute" Text="Numero" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenderecocobnumero" runat="server" Style="z-index: 2; left: 150px;
                        top: 575px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label23" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 320px; top: 575px;
                        position: absolute" Text="Complemento" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenderecocobcomplemento" runat="server" Style="z-index: 2; left: 410px;
                        top: 575px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="120px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label24" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 610px;
                        position: absolute" Text="Bairro" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenderecocobbairro" runat="server" Style="z-index: 2; left: 150px;
                        top: 610px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label25" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 320px; top: 610px;
                        position: absolute" Text="Cep" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenderecocobcep" runat="server" Style="z-index: 2; left: 410px;
                        top: 610px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="120px"
                        Visible="False" AutoPostBack="True">
                        <MaskSettings IncludeLiterals="None" Mask="99999-999" />
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label26" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 645px;
                        position: absolute" Text="Cidade" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenderecocobcidade" runat="server" Style="z-index: 2; left: 150px;
                        top: 645px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="380px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label27" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 680px;
                        position: absolute" Text="Opção de Planta" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edopcaoplanta" runat="server" Style="z-index: 2; left: 150px;
                        top: 680px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="380px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label28" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 715px;
                        position: absolute" Text="Endereço Imóvel" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edenderecoimovel" runat="server" Style="z-index: 2; left: 150px;
                        top: 715px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="380px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label30" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 750px;
                        position: absolute" Text="Preço e Condições de Pagamento" Theme="PlasticBlue"
                        Visible="False"></asp:Label>
                    <asp:Label ID="Label29" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 785px;
                        position: absolute" Text="Data da Proposta" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxDateEdit ID="dtproposta" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                        EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4;
                        position: absolute; margin-right: 5px; left: 150px; top: 785px;" Theme="PlasticBlue"
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
                        top: 785px; position: absolute; right: 223px;" AutoPostBack="True" CheckState="Unchecked"
                        Font-Bold="False" Font-Names="Calibri" Font-Size="14px" ForeColor="#3E5395" Height="21px"
                        Text="Tabela Price" Theme="PlasticBlue" Width="120px" Visible="False">
                    </dx:ASPxCheckBox>
                    <asp:Label ID="Label31" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 820px;
                        position: absolute" Text="Valor Proposta" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edvlrvenda" runat="server" Style="z-index: 2; left: 150px; top: 820px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="200px" Visible="False"
                        AutoPostBack="True" OnTextChanged="edvlrvenda_TextChanged">
                        <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label32" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 855px;
                        position: absolute" Text="Valor Sinal" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edvlrsinal" runat="server" Style="z-index: 2; left: 150px; top: 855px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="200px" Visible="False"
                        AutoPostBack="True" OnTextChanged="edvlrsinal_TextChanged">
                        <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                    </dx:ASPxTextBox>
                    <dx:ASPxCheckBox ID="cksinalparcelado" runat="server" Style="z-index: 2; left: 370px;
                        top: 820px; position: absolute; right: 223px;" AutoPostBack="True" CheckState="Unchecked"
                        Font-Bold="False" Font-Names="Calibri" Font-Size="14px" ForeColor="#3E5395" Height="21px"
                        Text="Sinal Parcelado" Theme="PlasticBlue" Width="120px" Visible="False" OnCheckedChanged="cksinalparcelado_CheckedChanged">
                    </dx:ASPxCheckBox>
                    <asp:Label ID="Label33" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 370px; top: 855px;
                        position: absolute" Text="Parcelas" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edqtdsinal" runat="server" Style="z-index: 2; left: 430px; top: 855px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="100px" 
                        Visible="False" OnTextChanged="edqtdsinal_TextChanged">
                        <MaskSettings IncludeLiterals="None" Mask="&lt;0..9999999g&gt;" AllowMouseWheel="False" />
                    </dx:ASPxTextBox>
                    <div id="Divsinalparcelado" runat="server" style="border: 1px solid #808080; z-index: 2;
                        position: absolute; top: 600px; left: 540px; height: 160px; width: 280px;">
                        <asp:Label ID="Label34" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px;
                            position: absolute" Text="Sinal Parcelado" Theme="PlasticBlue"></asp:Label>
                        <asp:Label ID="Label35" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 20px;
                            position: absolute" Text="Parcelas" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <asp:Label ID="Label36" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 100px; top: 20px;
                            position: absolute" Text="9999/9999" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxButton ID="btgravasinal" runat="server" Style="z-index: 2; left: 230px; top: 15px;
                            position: absolute; width: 35px; height: 20px" RightToLeft="True" HorizontalAlign="Center"
                            position="absolute" VerticalAlign="Middle" Visible="False" ImageSpacing="0px"
                            OnClick="btgravasinal_Click">
                            <Image Height="14px" Width="14px" ToolTip="ProcessaSinal" Url="~/images/BotoesTelas/BTNalterarA.bmp"
                                UrlDisabled="~/images/BotoesTelas/BTNalterarI.bmp" UrlPressed="~/images/BotoesTelas/BTNalterarS.bmp">
                            </Image>
                            <Paddings PaddingBottom="0px" PaddingLeft="0px" PaddingRight="0px" PaddingTop="0px" />
                        </dx:ASPxButton>
                        <asp:Label ID="Label37" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
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
                        <asp:Label ID="Label38" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 90px;
                            position: absolute" Text="Valor" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edvlrparcelasinal" runat="server" Style="z-index: 2; left: 100px;
                            top: 90px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px"
                            Visible="False" AutoPostBack="True">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label39" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 125px;
                            position: absolute" Text="Total" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edvlrparcelasinaltotal" runat="server" Style="z-index: 2; left: 101px;
                            top: 125px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px"
                            Visible="False" AutoPostBack="True" ReadOnly="True">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                    </div>
                    <asp:Label ID="Label40" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 890px;
                        position: absolute" Text="Saldo" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edvlrsaldo1" runat="server" Style="z-index: 2; left: 150px; top: 890px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="200px" Visible="False"
                        AutoPostBack="True" ontextchanged="edvlrsaldo1_TextChanged">
                        <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label42" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 925px;
                        position: absolute" Text="Intermediárias" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edvlrintermediarias" runat="server" Style="z-index: 2; left: 150px;
                        top: 925px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="200px"
                        Visible="False" AutoPostBack="True" OnTextChanged="edvlrintermediarias_TextChanged">
                        <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label43" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 370px; top: 925px;
                        position: absolute; height: 18px;" Text="Parcelas" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edqtdintermediarias" runat="server" Style="z-index: 2; left: 430px;
                        top: 925px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="100px"
                        Visible="False" OnTextChanged="edqtdintermediarias_TextChanged">
                        <MaskSettings IncludeLiterals="None" Mask="&lt;0..9999999g&gt;" AllowMouseWheel="False" />
                    </dx:ASPxTextBox>
                    <div id="Divintermediaria" runat="server" style="border: 1px solid #808080; z-index: 2;
                        position: absolute; top: 800px; left: 540px; height: 190px; width: 280px;">
                        <asp:Label ID="Label44" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px;
                            position: absolute" Text="Intermediárias" Theme="PlasticBlue"></asp:Label>
                        <asp:Label ID="Label45" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 20px;
                            position: absolute" Text="Parcelas" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <asp:Label ID="Label46" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 100px; top: 20px;
                            position: absolute" Text="9999/9999" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxButton ID="btgravaintermediaria" runat="server" Style="z-index: 2; left: 230px;
                            top: 15px; position: absolute; width: 35px; height: 20px" RightToLeft="True"
                            HorizontalAlign="Left" position="absolute" VerticalAlign="Top" Visible="False"
                            ImageSpacing="0px" OnClick="btgravaintermediaria_Click">
                            <Image Height="14px" Width="14px" ToolTip="ProcessaIntermediaria" Url="~/images/BotoesTelas/BTNalterarA.bmp"
                                UrlDisabled="~/images/BotoesTelas/BTNalterarI.bmp" UrlPressed="~/images/BotoesTelas/BTNalterarS.bmp">
                            </Image>
                            <Paddings PaddingBottom="0px" PaddingLeft="0px" PaddingRight="0px" PaddingTop="0px" />
                        </dx:ASPxButton>
                        <asp:Label ID="Label47" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
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
                        <asp:Label ID="Label48" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 90px;
                            position: absolute" Text="Valor" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edvlrparcelaintermediaria" runat="server" Style="z-index: 2;
                            left: 100px; top: 90px; position: absolute; right: 223px;" Theme="PlasticBlue"
                            Width="150px" Visible="False" AutoPostBack="True">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label49" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 125px;
                            position: absolute" Text="Observação" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edobsintermediaria" runat="server" Style="z-index: 2; left: 101px;
                            top: 126px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="150px"
                            Visible="False" AutoPostBack="True">
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label50" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 160px;
                            position: absolute" Text="Total" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edvlrparcelaintermediariatotal" runat="server" Style="z-index: 2;
                            left: 101px; top: 160px; position: absolute; right: 223px;" Theme="PlasticBlue"
                            Width="150px" Visible="False" AutoPostBack="True" ReadOnly="True">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                    </div>
                    <asp:Label ID="Label51" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 960px;
                        position: absolute" Text="Fluxo de Parcelas" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edvlrfluxoparcelas" runat="server" Style="z-index: 2; left: 150px;
                        top: 960px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="200px"
                        Visible="False" AutoPostBack="True" 
                        OnTextChanged="edvlrfluxoparcelas_TextChanged">
                        <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label52" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 370px; top: 960px;
                        position: absolute" Text="Fluxos" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edqtdfluxoparcelas" runat="server" Style="z-index: 2; left: 430px;
                        top: 960px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="100px"
                        Visible="False" AutoPostBack="True" OnTextChanged="edqtdfluxoparcelas_TextChanged">
                        <MaskSettings IncludeLiterals="None" Mask="&lt;0..9999999g&gt;" AllowMouseWheel="False" />
                    </dx:ASPxTextBox>
                    <div id="Divfluxos" runat="server" style="border: 1px solid #808080; z-index: 2;
                        position: absolute; top: 1030px; left: 540px; height: 190px; width: 280px;">
                        <asp:Label ID="Label53" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px;
                            position: absolute" Text="Fluxos Financeiros" Theme="PlasticBlue"></asp:Label>
                        <asp:Label ID="Label54" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 20px;
                            position: absolute" Text="Fluxos" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <asp:Label ID="Label55" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 100px; top: 20px;
                            position: absolute" Text="9999/9999" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxButton ID="btgravafluxo" runat="server" Style="z-index: 2; left: 230px; top: 15px;
                            position: absolute; width: 35px; height: 20px" RightToLeft="True" HorizontalAlign="Left"
                            position="absolute" VerticalAlign="Top" Visible="False" ImageSpacing="0px" OnClick="btgravafluxo_Click">
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
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 995px;
                        position: absolute" Text="Indexador Pré" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxComboBox ID="cbindexador" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 995px; left: 150px;" Width="380px"
                        Theme="PlasticBlue" AutoPostBack="True" Visible="False" OnSelectedIndexChanged="cbindexador_SelectedIndexChanged">
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label66" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1030px;
                        position: absolute" Text="Indexador Pós" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxComboBox ID="cbindexadorpos" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 1030px; left: 150px;" Width="380px"
                        Theme="PlasticBlue" AutoPostBack="True" Visible="False" OnSelectedIndexChanged="cbindexador_SelectedIndexChanged">
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label61" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1065px;
                        position: absolute" Text="Periodicidade" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <asp:RadioButtonList ID="rbperiodicidade" runat="server" AutoPostBack="True" CellPadding="0"
                        CellSpacing="0" Font-Names="Calibri" Font-Size="12pt" Font-Strikeout="False"
                        ForeColor="#3E5395" Height="12px" Style="z-index: 2; left: 150px; top: 1065px;
                        position: absolute; right: 423px;" Width="200px" RepeatDirection="Horizontal"
                        Visible="False" OnSelectedIndexChanged="rbperiodicidade_SelectedIndexChanged">
                        <asp:ListItem Value="0">Diária</asp:ListItem>
                        <asp:ListItem Value="1" Selected="True">Mensal</asp:ListItem>
                        <asp:ListItem Value="2">Anual</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:Label ID="Label62" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1100px;
                        position: absolute" Text="Corretor" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxComboBox ID="cbcorretor" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 1100px; left: 150px;" Width="380px"
                        Theme="PlasticBlue" AutoPostBack="True" Visible="False" OnSelectedIndexChanged="cbcorretor_SelectedIndexChanged">
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label63" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1135px;
                        position: absolute" Text="Multa %" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edmulta" runat="server" Style="z-index: 2; left: 150px; top: 1135px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="200px" Visible="False"
                        AutoPostBack="True" OnTextChanged="edmulta_TextChanged">
                        <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label64" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1170px;
                        position: absolute" Text="Comissão %" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edcomissao" runat="server" Style="z-index: 2; left: 150px; top: 1170px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="200px" Visible="False"
                        AutoPostBack="True" OnTextChanged="edcomissao_TextChanged">
                        <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                    </dx:ASPxTextBox>
                    <asp:RadioButtonList ID="rbperiodicidadecomissao" runat="server" AutoPostBack="True"
                        CellPadding="0" CellSpacing="0" Font-Names="Calibri" Font-Size="12pt" Font-Strikeout="False"
                        ForeColor="#3E5395" Height="12px" Style="z-index: 2; left: 360px; top: 1170px;
                        position: absolute; right: 423px;" Width="170px" RepeatDirection="Horizontal"
                        Visible="False" OnSelectedIndexChanged="rbperiodicidadecomissao_SelectedIndexChanged">
                        <asp:ListItem Value="0">a.d.</asp:ListItem>
                        <asp:ListItem Value="1" Selected="True">a.m.</asp:ListItem>
                        <asp:ListItem Value="2">a.a.</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:Label ID="Label65" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 1205px;
                        position: absolute" Text="Observações" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edobservacao" runat="server" Style="z-index: 2; left: 150px;
                        top: 1205px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="380px"
                        Visible="False" OnTextChanged="edobservacao_TextChanged">
                    </dx:ASPxTextBox>
                    <div id="Div2" runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute;
                        top: 20px; left: 700px; height: 50px; width: 100px;">
                        <dx:ASPxButton ID="btprocessa" runat="server" Height="40px" ImagePosition="Left"
                            OnClick="btprocessa_Click" Width="45px" AutoPostBack="False">
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
                    <div runat="server" style="z-index: 2; position: absolute; top: 1500px; left: 10px;
                        height: 350px; width: 378px;" id="Div4">
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
                                        Proposta de Venda de Unidades.<br />
                                        <br />
                                        O Processo ocorre com a reprodução dentro do sistema das regras financeiras propostas
                                        para a compra.<br />
                                        <br />
                                        O Sistema faz a checagem de valores antes de proceder o registro da Proposta.<br />
                                        <br />
                                        Valor da Venda = (Sinal + Intermediárias + Fluxo de Parcelas).<br />
                                        <br />
                                        Informações necessárias aos cálculos de correção de contrato e pagamento de parcelas
                                        são solicitadas.<br />
                                        <br />
                                        <br />
                                    </div>
                                </dx:PopupControlContentControl>
                            </ContentCollection>
                        </dx:ASPxPopupControl>
                    </div>
                </div>
            <asp:ObjectDataSource ID="dsfiltro_combo_contato" runat="server" OldValuesParameterFormatString="original_{0}"
                SelectMethod="filtro_combo_contato" TypeName="uContato">
                <SelectParameters>
                    <asp:SessionParameter Name="valor_inicio" SessionField="nome" Type="String" />
                    <asp:SessionParameter Name="id" SessionField="id" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
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

<%@ Page Title="FCobrancaRemessa" Language="C#" AutoEventWireup="true" CodeFile="FCobrancaRemessa.aspx.cs"
    Inherits="FCobrancaRemessa" StylesheetTheme="Principal" %>

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
    <title>Gitano - Pagamentos - Remessa</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <link href="../../content/toastr.css" rel="stylesheet" />
</head>
<body style="height: 1400px">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager" runat="server" />
        <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1400px">
            <ContentTemplate>
                <h1>COBRANÇA BANCÁRIA - REMESSA</h1>
                <h2>Remessa de Arquivos Cobrança</h2>
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
                            Width="380px" Theme="PlasticBlue"
                            OnSelectedIndexChanged="cbgrupounidades_SelectedIndexChanged" Visible="False"
                            AutoPostBack="True">
                        </dx:ASPxComboBox>
                        <asp:Label ID="Label8" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 120px; position: absolute"
                            Text="Banco\Conta" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edbanco" runat="server" Style="z-index: 2; left: 150px; top: 120px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="380px" Visible="False"
                            AutoPostBack="True" ReadOnly="True">
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label4" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 155px; position: absolute"
                            Text="Drive\Pasta\Extensão" Theme="PlasticBlue"
                            Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edcaminho" runat="server" Style="z-index: 2; left: 150px; top: 155px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="380px" Visible="False"
                            AutoPostBack="True">
                        </dx:ASPxTextBox>
                        <dx:ASPxTextBox ID="edextensao" runat="server" Style="z-index: 2; left: 550px; top: 155px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="100px" Visible="False"
                            AutoPostBack="True">
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label13" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 190px; position: absolute"
                            Text="Nome Arquivo" Theme="PlasticBlue"
                            Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="ednomearquivo" runat="server" Style="z-index: 2; left: 150px; top: 190px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="380px" Visible="False"
                            AutoPostBack="True" OnTextChanged="ednomearquivo_TextChanged">
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label5" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 225px; position: absolute"
                            Text="Período de Parcelas" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxDateEdit ID="dtprevisao1" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                            EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4; position: absolute; margin-right: 5px; left: 150px; top: 225px;"
                            Theme="PlasticBlue"
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
                        <asp:Label ID="Label6" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 300px; top: 225px; position: absolute"
                            Text="Até" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxDateEdit ID="dtprevisao2" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                            EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4; position: absolute; margin-right: 5px; left: 350px; top: 225px;"
                            Theme="PlasticBlue"
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
                        <asp:Label ID="Label9" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 260px; position: absolute"
                            Text="Msg Automática" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <asp:RadioButtonList ID="rbmensagemauto" runat="server" AutoPostBack="True" CellPadding="0"
                            CellSpacing="0" Font-Names="Calibri" Font-Size="12pt" Font-Strikeout="False"
                            ForeColor="#3E5395" Height="12px" Style="z-index: 2; left: 150px; top: 260px; position: absolute; right: 423px;"
                            Width="200px" RepeatDirection="Horizontal"
                            Visible="False">
                            <asp:ListItem Value="0">Sim</asp:ListItem>
                            <asp:ListItem Value="1" Selected="True">Não</asp:ListItem>
                        </asp:RadioButtonList>
                        <div id="Div2" runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute; top: 20px; left: 700px; height: 50px; width: 100px;">
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
                                            Arquivo Remessa Cobrança.<br />
                                            <br />
                                            Geração de arquivo remessa de cobrança para bancos.<br />
                                            <br />
                                            Geração realizada de acordo com dados registrados em Configuração.<br />
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

<%@ Page Title="FSelecionaUsuarioPermissaoPerfil" Language="C#" AutoEventWireup="true"
    CodeFile="FSelecionaUsuarioPermissaoPerfil.aspx.cs" Inherits="FSelecionaUsuarioPermissaoPerfil"
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
    <title>Gitano - Config - Permissões do Perfil</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <link href="../../content/toastr.css" rel="stylesheet" />
</head>
<body style="height: 1200px">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1200px">
        <ContentTemplate>
            <h1>
                CONFIG - PERMISSÕES DE PERFIL</h1>
            <h2>
                Permissões de Perfil</h2>
            <div id="DivNova" style="border-style: none">
                <div style="border: 1px solid #808080; z-index: 2; left: 45px; top: 65px; position: absolute;
                    height: 100px; width: 350px">
                    <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px;
                        position: absolute" Text="Perfil Usuário"></asp:Label>
                    <dx:ASPxComboBox ID="cbusuario" runat="server" ValueType="System.String" BackColor="#E1E6F2"
                        DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" EditFormatString="dd/MM/yyyy"
                        EnableTheming="True" Font-Bold="False" Font-Names="Calibri" Font-Size="15px"
                        ForeColor="#3E5395" Height="16px" Theme="PlasticBlue" UseMaskBehavior="True"
                        Width="300px" Style="z-index: 2; position: absolute; margin-right: 5px; top: 15px;
                        left: 13px;" ToolTip="Filtrar Usuário" AutoPostBack="True" 
                        onselectedindexchanged="cbusuario_SelectedIndexChanged">
                    </dx:ASPxComboBox>
                </div>
                <div runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute;
                    top: 70px; left: 600px; height: 50px; width: 100px;" id="Div2">
                    <dx:ASPxButton ID="btprocessa" runat="server" Height="40px" Width="45px" ImagePosition="Left"
                        OnClick="btprocessa_Click">
                        <Image Height="30px" ToolTip="Processa Permissões" Url="~/images/BotoesTelas/BTNalterarA.bmp"
                            UrlDisabled="~/images/BotoesTelas/BTNalterarI.bmp" UrlPressed="~/images/BotoesTelas/BTNalterarS.bmp"
                            Width="30px">
                        </Image>
                    </dx:ASPxButton>
                    <dx:ASPxButton ID="bthelp" runat="server" Height="40px" Width="45px" ImagePosition="Left"
                        OnClick="bthelp_Click" AutoPostBack="False" Style="z-index: 1;">
                        <Image Height="30px" ToolTip="Help\Ajuda\Orientações" Url="~/images/BotoesTelas/BTNhelpA.bmp"
                            UrlDisabled="~/images/BotoesTelas/BTNhelpI.bmp" UrlPressed="~/images/BotoesTelas/BTNhelpS.bmp"
                            Width="30px">
                        </Image>
                    </dx:ASPxButton>
                </div>
                <div runat="server" style="z-index: 2; position: absolute; top: 800px; left: 10px;
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
                                    Permissão de Perfil.<br />
                                    <br />
                                    As Permissões de Perfil podem ser atribuidas ou retiradas dos Usuários individualmente ou Todas.<br />
                                    <br />
                                    Alterando um Perfil, automaticamente todos os usuários do perfil recebem ou é retirado o direito da permissão.<br />
                                    <br />
                                    Caso tenha dúvidas, procure o suporte ou a orientação necessária.<br />
                                    <br />
                                </div>
                            </dx:PopupControlContentControl>
                        </ContentCollection>
                    </dx:ASPxPopupControl>
                </div>
                <div style="z-index: 1; left: 480px; top: 290px; position: absolute; height: 200px;
                    width: 50px">
                    <div style="z-index: 1; width: 45px">
                        <dx:ASPxButton ID="bttodosparausuario" runat="server" Theme="PlasticBlue" Width="45px"
                            Font-Names="Calibri" Font-Size="11pt" Height="30px" BackColor="White" Enabled="False"
                            ToolTip="Transferir todas as permissões disponíveis para o usuário" OnClick="bttodosparausuario_Click"
                            Style="z-index: 1;">
                            <%--                            <ClientSideEvents Click="function(s,e) {
						 e.processOnServer = confirm('Confirma Definir Histórico como Padrão?');    }" />--%>
                            <Paddings Padding="0px" />
                            <FocusRectPaddings Padding="0px" />
                            <FocusRectBorder BorderStyle="None" />
                            <Border BorderStyle="None" />
                            <Image Height="25px" Url="~/images/Botoes/botão_setadupladireita_1.jpg" UrlHottracked="~/images/Botoes/botão_setadupladireita_2.jpg"
                                UrlPressed="~/images/Botoes/botão_setadupladireita_3.jpg" Width="40px">
                            </Image>
                            <Paddings Padding="0px" />
                            <PressedStyle>
                                <Border BorderStyle="None" />
                                <Border BorderStyle="None" />
                            </PressedStyle>
                            <HoverStyle>
                                <Border BorderStyle="None" />
                                <Border BorderStyle="None" />
                            </HoverStyle>
                            <FocusRectPaddings Padding="0px" />
                            <FocusRectBorder BorderStyle="None" />
                            <Border BorderStyle="None" />
                        </dx:ASPxButton>
                    </div>
                    <div style="z-index: 1; width: 45px">
                        <dx:ASPxButton ID="btselecionadosparausuario" runat="server" Theme="PlasticBlue"
                            Width="45px" Font-Names="Calibri" Font-Size="11pt" Height="30px" BackColor="White"
                            Enabled="False" ToolTip="Transferir todas as permissões selecionadas para o usuário"
                            OnClick="btselecionadosparausuario_Click"
                            Style="z-index: 1;">
                            <%--                            <ClientSideEvents Click="function(s,e) {
						 e.processOnServer = confirm('Confirma Definir Histórico como Padrão?');    }" />--%>
                            <Paddings Padding="0px" />
                            <FocusRectPaddings Padding="0px" />
                            <FocusRectBorder BorderStyle="None" />
                            <Border BorderStyle="None" />
                            <Image Height="25px" Url="~/images/Botoes/botão_setasimplesdireita_1.jpg" UrlHottracked="~/images/Botoes/botão_setasimplesdireita_2.jpg"
                                UrlPressed="~/images/Botoes/botão_setasimplesdireita_3.jpg" Width="40px">
                            </Image>
                            <Paddings Padding="0px" />
                            <PressedStyle>
                                <Border BorderStyle="None" />
                                <Border BorderStyle="None" />
                            </PressedStyle>
                            <HoverStyle>
                                <Border BorderStyle="None" />
                                <Border BorderStyle="None" />
                            </HoverStyle>
                            <FocusRectPaddings Padding="0px" />
                            <FocusRectBorder BorderStyle="None" />
                            <Border BorderStyle="None" />
                        </dx:ASPxButton>
                    </div>
                    <div style="z-index: 1; width: 45px">
                    </div>
                    <div style="z-index: 1; width: 45px">
                        <dx:ASPxButton ID="btremovetodosdousuario" runat="server" Theme="PlasticBlue" Width="45px"
                            Font-Names="Calibri" Font-Size="11pt" Height="30px" BackColor="White" Enabled="False"
                            ToolTip="Remover todas as permissões disponíveis do usuário" OnClick="btremovetodosdousuario_Click"
                            Style="z-index: 1;">
                            <%--                            <ClientSideEvents Click="function(s,e) {
						 e.processOnServer = confirm('Confirma Definir Histórico como Padrão?');    }" />--%>
                            <Paddings Padding="0px" />
                            <FocusRectPaddings Padding="0px" />
                            <FocusRectBorder BorderStyle="None" />
                            <Border BorderStyle="None" />
                            <Image Height="25px" Url="~/images/Botoes/botão_setaduplaesquerda_1.jpg" UrlHottracked="~/images/Botoes/botão_setaduplaesquerda_2.jpg"
                                UrlPressed="~/images/Botoes/botão_setaduplaesquerda_3.jpg" Width="40px">
                            </Image>
                            <Paddings Padding="0px" />
                            <PressedStyle>
                                <Border BorderStyle="None" />
                                <Border BorderStyle="None" />
                            </PressedStyle>
                            <HoverStyle>
                                <Border BorderStyle="None" />
                                <Border BorderStyle="None" />
                            </HoverStyle>
                            <FocusRectPaddings Padding="0px" />
                            <FocusRectBorder BorderStyle="None" />
                            <Border BorderStyle="None" />
                        </dx:ASPxButton>
                    </div>
                    <div style="z-index: 1; width: 45px">
                        <dx:ASPxButton ID="btremoveselecionadodousuario" runat="server" Theme="PlasticBlue"
                            Width="45px" Font-Names="Calibri" Font-Size="11pt" Height="30px" BackColor="White"
                            Enabled="False" 
                            ToolTip="Remover todas as permissões selecionadas do usuário" 
                            onclick="btremoveselecionadodousuario_Click"
                            Style="z-index: 1;">
                            <%--                            <ClientSideEvents Click="function(s,e) {
						 e.processOnServer = confirm('Confirma Definir Histórico como Padrão?');    }" />--%>
                            <Paddings Padding="0px" />
                            <FocusRectPaddings Padding="0px" />
                            <FocusRectBorder BorderStyle="None" />
                            <Border BorderStyle="None" />
                            <Image Height="25px" Url="~/images/Botoes/botão_setasimplesesquerda_1.jpg" UrlHottracked="~/images/Botoes/botão_setasimplesesquerda_2.jpg"
                                UrlPressed="~/images/Botoes/botão_setasimplesesquerda_3.jpg" Width="40px">
                            </Image>
                            <Paddings Padding="0px" />
                            <PressedStyle>
                                <Border BorderStyle="None" />
                                <Border BorderStyle="None" />
                            </PressedStyle>
                            <HoverStyle>
                                <Border BorderStyle="None" />
                                <Border BorderStyle="None" />
                            </HoverStyle>
                            <FocusRectPaddings Padding="0px" />
                            <FocusRectBorder BorderStyle="None" />
                            <Border BorderStyle="None" />
                        </dx:ASPxButton>
                    </div>
                </div>
                <div style="border: 1px solid #808080; z-index: 1; left: 45px; top: 190px; position: absolute;
                    height: 400px; width: 430px">
                    <asp:Label ID="Label3" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 1; left: 9px; top: -11px;
                        position: absolute" Text="Permissões Disponíveis"></asp:Label>
                    <dx:ASPxComboBox ID="lookuppermissoes" runat="server" ValueType="System.String" BackColor="#E1E6F2"
                        DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" EditFormatString="dd/MM/yyyy"
                        EnableTheming="True" Font-Bold="False" Font-Names="Calibri" Font-Size="15px"
                        ForeColor="#3E5395" Height="16px" Theme="PlasticBlue" UseMaskBehavior="True"
                        Width="380px" Style="z-index: 2; position: absolute; margin-right: 5px; top: 15px;
                        left: 13px;" ToolTip="Filtrar Permissões" DropDownRows="15">
                    </dx:ASPxComboBox>                    
                </div>
                <div style="border: 1px solid #808080; z-index: 1; left: 540px; top: 190px; position: absolute;
                    height: 400px; width: 420px">
                    <asp:Label ID="Label2" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px;
                        position: absolute" 
                        Text="Permissões do Perfil de  Usuário Selecionado (Nenhum)"></asp:Label>
                    <dx:ASPxComboBox ID="lookuppermissoesusuario" runat="server" 
                        ValueType="System.String" BackColor="#E1E6F2"
                        DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" EditFormatString="dd/MM/yyyy"
                        EnableTheming="True" Font-Bold="False" Font-Names="Calibri" Font-Size="15px"
                        ForeColor="#3E5395" Height="16px" Theme="PlasticBlue" UseMaskBehavior="True"
                        Width="380px" Style="z-index: 2; position: absolute; margin-right: 5px; top: 15px;
                        left: 13px;" ToolTip="Filtrar Permissões Usuário" DropDownRows="15">
                    </dx:ASPxComboBox>                         </div>
                <%--<div style="border: 1px solid #808080; z-index: 1; left: 35px; top: 100px; position: absolute;
                    height: 481px; width: 832px; text-align: center;">
                </div>--%>
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

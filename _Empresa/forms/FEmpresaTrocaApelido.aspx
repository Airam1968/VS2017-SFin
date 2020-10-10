<%@ Page Title="FEmpresaTrocaApelido" Language="C#" AutoEventWireup="true" CodeFile="FEmpresaTrocaApelido.aspx.cs"
    Inherits="FEmpresaTrocaApelido" StylesheetTheme="Principal" %>

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
    <title>Gitano - Empresas - Utilitários - Troca Apelido</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <link href="../../content/toastr.css" rel="stylesheet" />
</head>
<body style="height: 1200px">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1200px">
        <ContentTemplate>
            <h1>
                EMPRESAS - UTILITÁRIOS - TROCA APELIDO</h1>
            <h2>
                Troca de Apelido da Empresa</h2>
            <div id="DivNova" style="border-style: none">
                <div style="border: 1px solid #808080; z-index: 1; left: 45px; top: 65px; position: absolute;
                    height: 500px; width: 400px">
                    <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px;
                        position: absolute" Text="Selecione" Theme="PlasticBlue"></asp:Label>
                    <asp:Label ID="Label3" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 15px;
                        position: absolute" Text="Apelido Original" Theme="PlasticBlue"></asp:Label>
                    <dx:ASPxComboBox ID="cbempresa" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 40px; left: 10px;" Width="300px" Theme="PlasticBlue">
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label2" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 100px;
                        position: absolute" Text="Apelido Novo"></asp:Label>
                    <dx:ASPxTextBox ID="edempresa" runat="server" BackColor="#E1E6F2" Theme="PlasticBlue"
                        Width="300px" Font-Names="Calibri" Font-Size="12pt" ForeColor="#3E5395" Style="z-index: 2;
                        left: 9px; top: 125px; position: absolute" MaxLength="20">
                    </dx:ASPxTextBox>
                </div>
                <div style="z-index: 1; border-style: none; left: 460px; top: 65px; position: absolute;
                    height: 500px; width: 350px">
                    <dx:ASPxButton ID="btprocessa" runat="server" Height="40px" Width="45px" ImagePosition="Left"
                        OnClick="btprocessa_Click">
                        <Image Height="30px" ToolTip="Atenção!!! Leia o Help antes de Prosseguir!!!" Url="~/images/BotoesTelas/BTNalterarA.bmp"
                            UrlDisabled="~/images/BotoesTelas/BTNalterarI.bmp" UrlPressed="~/images/BotoesTelas/BTNalterarS.bmp"
                            Width="30px">
                        </Image>
                    </dx:ASPxButton>
                    <dx:ASPxButton ID="bthelp" runat="server" Height="40px" Width="45px" ImagePosition="Left"
                        OnClick="bthelp_Click" AutoPostBack="False">
                        <Image Height="30px" ToolTip="Help\Ajuda\Orientações" Url="~/images/BotoesTelas/BTNhelpA.bmp"
                            UrlDisabled="~/images/BotoesTelas/BTNhelpI.bmp" UrlPressed="~/images/BotoesTelas/BTNhelpS.bmp"
                            Width="30px">
                        </Image>
                    </dx:ASPxButton>
                </div>
                <dx:ASPxPopupControl ID="Popuphelp" runat="server" LoadingPanelText="Carregando&amp;hellip;"
                    Theme="PlasticBlue" PopupElementID="bthelp" PopupVerticalAlign="Below" PopupHorizontalAlign="LeftSides"
                    AllowDragging="True" ShowFooter="True" Width="310px" Height="160px" HeaderText="Ajuda do Sistema"
                    ClientInstanceName="Popuphelp" FooterText="Gitano Software">
                    <HeaderStyle Font-Bold="True" />
                    <ContentCollection>
                        <dx:PopupControlContentControl ID="PopupControlContentControl" runat="server">
                            <div style="vertical-align: middle">
                                Troca de Apelido da Empresa.<br />
                                <br />
                                O Apelido da Empresa é a forma de referência da Empresa em todas as associações
                                que ela se faz necessária, qualquer erro nesta associação compromete a consistência
                                dos dados do Sistema.<br />
                                <br />
                                Portanto antes de iniciar o processo tenha certeza que nenhum usuário está em uso,
                                poís isto pode provocar o bloqueio do processamento.<br />
                                <br />
                            </div>
                        </dx:PopupControlContentControl>
                    </ContentCollection>
                </dx:ASPxPopupControl>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>

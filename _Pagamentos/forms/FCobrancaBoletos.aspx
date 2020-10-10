<%@ Page Title="FCobrancaBoletos" Language="C#" AutoEventWireup="true" CodeFile="FCobrancaBoletos.aspx.cs"
    Inherits="FCobrancaBoletos" StylesheetTheme="Principal" %>

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
    <title>Gitano - Cobrança Bancária - Boletos</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        body
        {
            color: #000000;
            background-color: #ffffff;
            margin-top: 0;
            margin-right: 0;
        }
        
        *
        {
            margin: 0px;
            padding: 0px;
        }
        table
        {
            border: 0;
            border-collapse: collapse;
            padding: 0;
        }
        
        img
        {
            border: 0;
        }
        
        .cp
        {
            font: bold 10px arial;
            color: black;
        }
        .ti
        {
            font: 9px arial, helvetica, sans-serif;
        }
        .ld
        {
            font: bold 15px arial;
            color: #000000;
        }
        .ct
        {
            font: 9px "arial narrow";
            color: #000033;
        }
        .cn
        {
            font: 9px arial;
            color: black;
        }
        .bc
        {
            font: bold 22px arial;
            color: #000000;
        }
        
        .cut
        {
            width: 665px;
            height: 1px;
            border-top: dashed 1px #000;
        }
        .Ac
        {
            text-align: center;
        }
        .Ar
        {
            text-align: right;
        }
        .Al
        {
            text-align: left;
        }
        .At
        {
            vertical-align: top;
        }
        .Ab
        {
            vertical-align: bottom;
        }
        .ct td, .cp td
        {
            padding-left: 6px;
            border-left: solid 1px #000;
        }
        .cpN
        {
            font: bold 10px arial;
            color: black;
        }
        .ctN
        {
            font: 9px "arial narrow";
            color: #000033;
        }
        .pL0
        {
            padding-left: 0px;
        }
        .pL6
        {
            padding-left: 6px;
        }
        .pL10
        {
            padding-left: 10px;
        }
        .imgLogo
        {
            width: 150px;
        }
        .imgLogo img
        {
            width: 150px;
            height: 40px;
        }
        .barra
        {
            width: 3px;
            height: 22px;
            vertical-align: bottom;
        }
        .barra img
        {
            width: 2px;
            height: 22px;
        }
        .rBb td
        {
            border-bottom: solid 1px #000;
        }
        .BB
        {
            border-bottom: solid 1px #000;
        }
        .BL
        {
            border-left: solid 1px #000;
        }
        .BR
        {
            border-right: solid 1px #000;
        }
        .BT1
        {
            border-top: dashed 1px #000;
        }
        .BT2
        {
            border-top: solid 2px #000;
        }
        .h1
        {
            height: 1px;
        }
        .h13
        {
            height: 13px;
        }
        .h12
        {
            height: 12px;
        }
        .h13 td
        {
            vertical-align: top;
        }
        .h12 td
        {
            vertical-align: top;
        }
        .w6
        {
            width: 6px;
        }
        .w7
        {
            width: 7px;
        }
        .w34
        {
            width: 34px;
        }
        .w45
        {
            width: 45px;
        }
        .w53
        {
            width: 53px;
        }
        .w62
        {
            width: 62px;
        }
        .w65
        {
            width: 65px;
        }
        .w72
        {
            width: 72px;
        }
        .w83
        {
            width: 83px;
        }
        .w88
        {
            width: 88px;
        }
        .w104
        {
            width: 104px;
        }
        .w105
        {
            width: 105px;
        }
        .w106
        {
            width: 106px;
        }
        .w113
        {
            width: 113px;
        }
        .w112
        {
            width: 112px;
        }
        .w123
        {
            width: 123px;
        }
        .w126
        {
            width: 126px;
        }
        .w128
        {
            width: 128px;
        }
        .w132
        {
            width: 132px;
        }
        .w134
        {
            width: 134px;
        }
        .w150
        {
            width: 150px;
        }
        .w163
        {
            width: 163px;
        }
        .w164
        {
            width: 164px;
        }
        .w180
        {
            width: 180px;
        }
        .w182
        {
            width: 182px;
        }
        .w186
        {
            width: 186px;
        }
        .w192
        {
            width: 192px;
        }
        .w250
        {
            width: 250px;
        }
        .w298
        {
            width: 298px;
        }
        .w409
        {
            width: 409px;
        }
        .w472
        {
            width: 472px;
        }
        .w478
        {
            width: 478px;
        }
        .w500
        {
            width: 500px;
        }
        .w544
        {
            width: 544px;
        }
        .w564
        {
            width: 564px;
        }
        .w659
        {
            width: 659px;
        }
        .w666
        {
            width: 666px;
        }
        .w667
        {
            width: 667px;
        }
        .BHead td
        {
            border-bottom: solid 2px #000;
        }
        .EcdBar
        {
            height: 50px;
            vertical-align: bottom;
        }
        .rc6 td
        {
            vertical-align: top;
            border-bottom: solid 1px #000;
            border-left: solid 1px #000;
        }
        .rc6 div
        {
            padding-left: 6px;
        }
        .rc6 .t
        {
            font: 9px "arial narrow";
            color: #000033;
            height: 13px;
        }
        .rc6 .c
        {
            font: bold 10px arial;
            color: black;
            height: 12px;
        }
        .mt23
        {
            margin-top: 23px;
        }
        .pb4
        {
            padding-bottom: 14px;
        }
        .ebc
        {
            width: 4px;
            height: 440px;
            border-right: dotted 1px #000000;
            margin-right: 4px;
        }
    </style>
</head>
<body style="height: 1200px">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1200px">
        <ContentTemplate>
            <h1>
                PAGAMENTOS - COBRANÇA BANCÁRIA - BOLETOS</h1>
            <h2>
                2a. via Boletos (Versão para testes)</h2>
            <div id="DivNova" style="border-style: none">
                <div style="border: 1px solid #808080; z-index: 1; left: 35px; top: 100px; position: absolute;
                    height: 1200px; width: 832px; text-align: center;">
                    <asp:Panel ID="pnl_boleto" runat="server" Style="border: 1px solid #808080; z-index: 2;
                        position: absolute; top: 100px; left: 10px; height: 1000px; width: 800px;" Wrap="False">
                    </asp:Panel>
                    <div id="Div2" runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute;
                        top: 15px; left: 700px; height: 50px; width: 100px; bottom: 1133px;">
                        <dx:ASPxButton ID="btprocessa" runat="server" Height="40px" ImagePosition="Left"
                            OnClick="btprocessa_Click" Width="45px">
                            <Image Height="30px" ToolTip="Processa Criação" Url="~/images/BotoesTelas/BTNalterarA.bmp"
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
                    <div runat="server" style="z-index: 2; position: absolute; top: 1200px; left: 10px;
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
                                        Geração de Boleto.<br />
                                        <br />
                                        <br />
                                        Caso seja necessário, solicite suporte ou orientação necessária antes de prosseguir.<br />
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

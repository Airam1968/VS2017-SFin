<%@ Page Title="FBrowserStatus" Language="C#" AutoEventWireup="true" CodeFile="FBrowserStatus.aspx.cs"
    Inherits="FBrowserStatus" StylesheetTheme="Principal" %>

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
    <title>Gitano - Config - Browser - Status</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        #Filtros
        {
            width: 200px;
            height: 108px;
            position: relative;
            top: -102px;
            left: 432px;
        }
        
        .myButton
        {
            -moz-box-shadow: inset 0px 1px 0px -20px #08152b;
            -webkit-box-shadow: inset 0px 1px 0px -20px #08152b;
            -box-shadow: inset 0px 1px 0px -20px #08152b;
            background: -webkit-gradient(linear, left top, left bottom, color-stop(0.05, #c3cce0), color-stop(1, #415480));
            background: -moz-linear-gradient(top, #c3cce0 5%, #415480 100%);
            background: -webkit-linear-gradient(top, #c3cce0 5%, #415480 100%);
            background: -o-linear-gradient(top, #c3cce0 5%, #415480 100%);
            background: -ms-linear-gradient(top, #c3cce0 5%, #415480 100%);
            background: linear-gradient(to bottom, #c3cce0 5%, #415480 100%);
            filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#c3cce0', endColorstr='#415480',GradientType=0);
            background-color: #c3cce0;
            -moz-border-radius: 3px;
            -webkit-border-radius: 3px;
            -border-radius: 3px;
            border: 1px solid #1f2f47;
            display: inline-block;
            color: #ffffff;
            font-family: Verdana;
            font-size: 9px;
            font-weight: normal;
            padding: 3px 7px;
            text-decoration: none;
            text-shadow: 0px 1px 0px #0d1626;
        }
        .myButton:hover
        {
            background: -webkit-gradient(linear, left top, left bottom, color-stop(0.05, #415480), color-stop(1, #c3cce0));
            background: -moz-linear-gradient(top, #415480 5%, #c3cce0 100%);
            background: -webkit-linear-gradient(top, #415480 5%, #c3cce0 100%);
            background: -o-linear-gradient(top, #415480 5%, #c3cce0 100%);
            background: -ms-linear-gradient(top, #415480 5%, #c3cce0 100%);
            background: linear-gradient(to bottom, #415480 5%, #c3cce0 100%);
            filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#415480', endColorstr='#c3cce0',GradientType=0);
            background-color: #415480;
        }
        .myButton:active
        {
            position: relative;
            top: 1px;
        }
        .dx-vam, .dx-valm
        {
            vertical-align: middle;
        }
        .dx-vam, .dx-vat, .dx-vab
        {
            display: inline-block !important;
        }
        .dxeTrackBar_PlasticBlue, .dxeIRadioButton_PlasticBlue, .dxeButtonEdit_PlasticBlue, .dxeTextBox_PlasticBlue, .dxeRadioButtonList_PlasticBlue, .dxeCheckBoxList_PlasticBlue, .dxeMemo_PlasticBlue, .dxeListBox_PlasticBlue, .dxeCalendar_PlasticBlue, .dxeColorTable_PlasticBlue
        {
            -webkit-tap-highlight-color: rgba(0,0,0,0);
        }
        
        .dxeTextBox_PlasticBlue, .dxeButtonEdit_PlasticBlue, .dxeIRadioButton_PlasticBlue, .dxeRadioButtonList_PlasticBlue, .dxeCheckBoxList_PlasticBlue
        {
            cursor: default;
        }
        
        .dxeTextBox_PlasticBlue, .dxeMemo_PlasticBlue
        {
            background-color: White;
            border: 1px solid #B8B8B8;
        }
        input[type="text"].dxeEditArea_PlasticBlue, /*Bootstrap correction*/ input[type="password"].dxeEditArea_PlasticBlue /*Bootstrap correction*/
        {
            height: 14px;
        }
        .dxeEditArea_PlasticBlue, input[type="text"].dxeEditArea_PlasticBlue, /*Bootstrap correction*/ input[type="password"].dxeEditArea_PlasticBlue /*Bootstrap correction*/
        {
            margin: 1px 0px;
            font: 12px Tahoma, Geneva, sans-serif;
        }
        .dxeTextBox_PlasticBlue .dxeEditArea_PlasticBlue, .dxeMemo_PlasticBlue .dxeMemoEditArea_PlasticBlue
        {
            background-color: White;
        }
        .dxeEditArea_PlasticBlue
        {
            border: 1px solid #A0A0A0;
        }
        
        .dxeButtonEdit_PlasticBlue
        {
            border: 1px Solid #b8b8b8;
            background-color: White;
        }
        .dxeButtonEdit_PlasticBlue .dxeEditArea_PlasticBlue
        {
            background-color: White;
        }
        .dxeButtonEditButton_PlasticBlue, .dxeCalendarButton_PlasticBlue, .dxeSpinIncButton_PlasticBlue, .dxeSpinDecButton_PlasticBlue, .dxeSpinLargeIncButton_PlasticBlue, .dxeSpinLargeDecButton_PlasticBlue, .dxeColorEditButton_PlasticBlue
        {
            vertical-align: middle;
            color: White;
            border: 1px Solid #CCCCCC;
            cursor: pointer;
            font: normal 12px Tahoma, Geneva, sans-serif;
            text-align: center;
            white-space: nowrap;
        }
        .dxEditors_edtError_PlasticBlue, .dxEditors_edtCalendarPrevYear_PlasticBlue, .dxEditors_edtCalendarPrevYearDisabled_PlasticBlue, .dxEditors_edtCalendarPrevMonth_PlasticBlue, .dxEditors_edtCalendarPrevMonthDisabled_PlasticBlue, .dxEditors_edtCalendarNextMonth_PlasticBlue, .dxEditors_edtCalendarNextMonthDisabled_PlasticBlue, .dxEditors_edtCalendarNextYear_PlasticBlue, .dxEditors_edtCalendarNextYearDisabled_PlasticBlue, .dxEditors_edtCalendarFNPrevYear_PlasticBlue, .dxEditors_edtCalendarFNNextYear_PlasticBlue, .dxEditors_edtEllipsis_PlasticBlue, .dxEditors_edtEllipsisDisabled_PlasticBlue, .dxEditors_edtDropDown_PlasticBlue, .dxEditors_edtDropDownDisabled_PlasticBlue, .dxEditors_edtSpinEditIncrementImage_PlasticBlue, .dxEditors_edtSpinEditIncrementImageDisabled_PlasticBlue, .dxEditors_edtSpinEditDecrementImage_PlasticBlue, .dxEditors_edtSpinEditDecrementImageDisabled_PlasticBlue, .dxEditors_edtSpinEditLargeIncImage_PlasticBlue, .dxEditors_edtSpinEditLargeIncImageDisabled_PlasticBlue, .dxEditors_edtSpinEditLargeDecImage_PlasticBlue, .dxEditors_edtSpinEditLargeDecImageDisabled_PlasticBlue
        {
            display: block;
            margin: auto;
        }
        .dxEditors_edtDropDown_PlasticBlue
        {
            background-position: -140px -158px;
            width: 9px;
            height: 6px;
        }
    </style>
</head>
<body style="height: 1200px">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1200px">
        <ContentTemplate>
            <h1>
                CONFIG - BROWSER - STATUS</h1>
            <h2>
                Status de Ambiente do Sistema</h2>
            <div id="DivNova" style="border-style: none">
                <div style="border: 1px solid #808080; z-index: 1; left: 45px; top: 65px; position: absolute;
                    height: 500px; width: 400px">
                    <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px;
                        position: absolute" Text="Propriedades do seu navegador"></asp:Label>
                    <asp:Label ID="Label3" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 15px;
                        position: absolute" Text="Parâmetro"></asp:Label>
                    <asp:Label ID="Label7" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 210px; top: 15px;
                        position: absolute" Text="Status"></asp:Label>
                    <asp:Label ID="lbbasegitano" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 30px; left: 10px;" Text="Tipo"
                        Width="150px" />
                    <asp:Label ID="lbbasegitano2" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 30px; position: absolute" Text=" "></asp:Label>
                    <asp:Label ID="lbbasecep" runat="server" AutoPostBack="True" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt;
                        top: 45px; left: 10px;" Text="Nome" Width="150px" />
                    <asp:Label ID="lbbasecep2" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 210px; top: 45px;
                        position: absolute" Text=" "></asp:Label>
                    <asp:Label ID="lbusuariosativos" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 75px; left: 10px;" Text="Versão"
                        Width="150px" />
                    <asp:Label ID="lbusuariosativos2" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 75px; position: absolute" Text=" ">
                        </asp:Label>
                    <asp:Label ID="lbclientesfinanciamentos" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 115px; left: 10px;" Text="Maior Versão"
                        Width="150px" />
                    <asp:Label ID="lbclientesfinanciamentos2" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 115px; position: absolute" Text=" "></asp:Label>
                    <asp:Label ID="lbunidadescadastradas" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 130px; left: 10px;" Text="Menor Versão"
                        Width="150px" />
                    <asp:Label ID="lbunidadescadastradas2" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 130px; position: absolute" Text=" "></asp:Label>
                    <asp:Label ID="lbvendas" runat="server" AutoPostBack="True" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt;
                        top: 145px; left: 10px;" Text="Plataforma" Width="150px" />
                    <asp:Label ID="lbvendas2" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 210px; top: 145px;
                        position: absolute" Text=" "></asp:Label>
                    <asp:Label ID="lbcontasapagar" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 160px; left: 10px;" Text="É versão Beta?"
                        Width="150px" />
                    <asp:Label ID="lbcontasapagar2" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 160px; position: absolute" Text=" "></asp:Label>
                    <asp:Label ID="lbcontasareceber" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 175px; left: 10px;" Text="É Crawler"
                        Width="150px" />
                    <asp:Label ID="lbcontasareceber2" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 175px; position: absolute" Text=" "></asp:Label>
                    <asp:Label ID="lbclientescreceber" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 190px; left: 10px;" Text="É AOL"
                        Width="150px" />
                    <asp:Label ID="lbclientescreceber2" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 190px; position: absolute" Text=" "></asp:Label>
                    <asp:Label runat="server" AutoPostBack="True" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt;
                        top: 205px; left: 10px;" Text="É Win16" Width="150px" />
                    <asp:Label ID="lbfornecedorescpagar2" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 205px; position: absolute" Text=" "></asp:Label>
                    <asp:Label ID="lbcontascorrentes" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 220px; left: 10px;" Text="É Win32"
                        Width="150px" />
                    <asp:Label ID="lbcontascorrentes2" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 220px; position: absolute" Text=" "></asp:Label>
                    <asp:Label ID="lbcorretores" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 235px; left: 10px;" Text="Suporta Frames"
                        Width="150px" />
                    <asp:Label ID="lbcorretores2" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 235px; position: absolute" Text=" "></asp:Label>
                    <asp:Label ID="lblog" runat="server" AutoPostBack="True" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt;
                        top: 275px; left: 10px;" Text="Suporta Tabelas" Width="150px" />
                    <asp:Label ID="lblog2" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 210px; top: 275px;
                        position: absolute" Text=" "></asp:Label>
                    <asp:Label ID="ckfornecedores" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 290px; left: 10px;" Text="Suporta Cookies"
                        Width="150px" />
                    <asp:Label ID="lbfornecedores" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 290px; position: absolute" Text=" "></asp:Label>
                    <asp:Label ID="ckreceitas" runat="server" AutoPostBack="True" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt;
                        top: 330px; left: 10px; " Text="Suporta VB Script" 
                        Width="200px" />
                    <asp:Label ID="lbreceitas" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 210px; top: 330px;
                        position: absolute" Text=" "></asp:Label>
                    <asp:Label ID="ckclientescontaareceber" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 345px; left: 10px;" Text="Suporta JavaScript"
                        Width="150px" Visible="False" />
                    <asp:Label ID="lbclientescontaareceber" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 345px; position: absolute" Text=" " Visible="False"></asp:Label>
                    <asp:Label ID="ckbancos" runat="server" AutoPostBack="True" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt;
                        top: 385px; left: 10px; bottom: 105px;" Text="Suporta Applets Java" 
                        Width="200px" />
                    <asp:Label ID="lbbancos" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 210px; top: 385px;
                        position: absolute" Text=" "></asp:Label>
                    <asp:Label ID="ckcontascorrentes" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 400px; left: 10px;" Text="Suporta ActiveX Controls"
                        Width="150px" />
                    <asp:Label ID="lbcontascorrentes3" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 400px; position: absolute" Text=" "></asp:Label>
                    <asp:Label ID="cksaldoinicial" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 415px; left: 10px;" Text="CDG"
                        Width="150px" />
                    <asp:Label ID="lbsaldoinicial" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 415px; position: absolute" Text=" "></asp:Label>
                </div>
                <div style="z-index: 1; border-style: none; left: 460px; top: 65px; position: absolute;
                    height: 500px; width: 350px">
                    <dx:ASPxButton ID="btprocessa" runat="server" Height="40px" Width="45px" ImagePosition="Left"
                        OnClick="btprocessa_Click">
                        <Image Height="30px" ToolTip="Processa Migração" Url="~/images/BotoesTelas/BTNalterarA.bmp"
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
                    <dx:ASPxPopupControl ID="Popuphelp" runat="server" LoadingPanelText="Carregando&amp;hellip;"
                        Theme="PlasticBlue" PopupElementID="bthelp" PopupVerticalAlign="Below" PopupHorizontalAlign="LeftSides"
                        AllowDragging="True" ShowFooter="True" Width="310px" Height="160px" HeaderText="Ajuda do Sistema"
                        ClientInstanceName="Popuphelp" FooterText="Gitano Software">
                        <HeaderStyle Font-Bold="True" />
                        <ContentCollection>
                            <dx:PopupControlContentControl ID="PopupControlContentControl" runat="server">
                                <div style="vertical-align: middle">
                                    Status do Browser Sistema.<br />
                                    <br />
                                    Apresenta informações básicas sobre a disposição dos recursos do Browser que o sistema está Utilizando.<br />
                                    <br />
                                </div>
                            </dx:PopupControlContentControl>
                        </ContentCollection>
                    </dx:ASPxPopupControl>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>

<%@ Page Title="FProdutoExcluir" Language="C#" AutoEventWireup="true" CodeFile="FProdutoExcluir.aspx.cs"
    Inherits="FProdutoExcluir" StylesheetTheme="Principal" %>

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
    <title>Gitano - Produto - Excluir</title>
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
<body style="height: 1400px">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1400px">
        <ContentTemplate>
            <h1>
                PRODUTO - EXCLUIR</h1>
            <h2>
                Excluir Estrutura do Produto</h2>
            <div id="DivNova" style="border-style: none">
                <div style="border: 1px solid #808080; z-index: 1; left: 35px; top: 100px; position: absolute;
                    height: 1200px; width: 832px; text-align: center;">
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
                    <asp:Label ID="Label4" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 125px;
                        position: absolute" Text="Feedback" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edunidades" runat="server" Style="z-index: 2; left: 9px; top: 150px;
                        position: absolute; right: 423px;" Theme="PlasticBlue" Width="800px" Visible="False">
                    </dx:ASPxTextBox>
                    <div id="Div2" runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute;
                        top: 40px; left: 600px; height: 50px; width: 100px;">
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
                    <div runat="server" style="z-index: 2; position: absolute; top: 900px; left: 10px;
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
                                        Excluir a Estrutura do produto.<br />
                                        <br />
                                        O processo cancelará as unidades criadas pelo sistema para venda, isto só ocorrerá
                                        se não houverem vendas ligadas a estas unidades, caso existam a exclusão não será
                                        realizada.<br />
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

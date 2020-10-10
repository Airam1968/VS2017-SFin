<%@ Page Title="RELATÓRIO FORNECEDOR MALA DIRETA" Language="C#" AutoEventWireup="true"
    CodeFile="RelApagarMalaDireta.aspx.cs" Inherits="RelApagarMalaDireta" StylesheetTheme="Principal" %>
<%@ Register Assembly="DevExpress.XtraReports.v13.2.Web, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            text-align: left;
        }
        #Relatorio
        {
            width: 1193px;
            height: 95px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="Relatorio">
        <div style="width: 113px; margin-left: 0px" class="style1">
            <dx:ASPxImage ID="ASPxImage1" runat="server" Height="46px" ImageUrl="~/images/logomarca/logoCliente_relatorio_46x94px.jpg"
                Width="94px" Style="text-align: left">
            </dx:ASPxImage>
        </div>
        <p style="height: 1px; margin-top: 2px">
        </p>
        <dx:ReportToolbar ID="ReportToolbar1" runat="server" ReportViewerID="ReportViewer1"
            ShowDefaultButtons="False" Width="1052px" Theme="PlasticBlue" Height="35px">
            <Items>
                <dx:ReportToolbarButton ItemKind="Search" />
                <dx:ReportToolbarSeparator />
                <dx:ReportToolbarButton ItemKind="PrintReport" />
                <dx:ReportToolbarButton ItemKind="PrintPage" />
                <dx:ReportToolbarSeparator />
                <dx:ReportToolbarButton Enabled="False" ItemKind="FirstPage" />
                <dx:ReportToolbarButton Enabled="False" ItemKind="PreviousPage" />
                <dx:ReportToolbarLabel ItemKind="PageLabel" />
                <dx:ReportToolbarComboBox ItemKind="PageNumber" Width="65px">
                </dx:ReportToolbarComboBox>
                <dx:ReportToolbarLabel ItemKind="OfLabel" />
                <dx:ReportToolbarTextBox ItemKind="PageCount" />
                <dx:ReportToolbarButton ItemKind="NextPage" />
                <dx:ReportToolbarButton ItemKind="LastPage" />
                <dx:ReportToolbarSeparator />
                <dx:ReportToolbarButton ItemKind="SaveToDisk" />
                <dx:ReportToolbarButton ItemKind="SaveToWindow" />
                <dx:ReportToolbarComboBox ItemKind="SaveFormat" Width="70px">
                    <Elements>
                        <dx:ListElement Value="pdf" />
                        <dx:ListElement Value="xls" />
                        <dx:ListElement Value="xlsx" />
                        <dx:ListElement Value="rtf" />
                        <dx:ListElement Value="mht" />
                        <dx:ListElement Value="html" />
                        <dx:ListElement Value="txt" />
                        <dx:ListElement Value="csv" />
                        <dx:ListElement Value="png" />
                    </Elements>
                </dx:ReportToolbarComboBox>
            </Items>
            <Styles>
                <LabelStyle>
                    <Margins MarginLeft="3px" MarginRight="3px" />
                    <Margins MarginLeft="3px" MarginRight="3px"></Margins>
                </LabelStyle>
            </Styles>
        </dx:ReportToolbar>
    </div>
    <dx:ReportViewer ID="ReportViewer1" runat="server" Width="1052px" AutoSize="False"
        Height="750px" PrintUsingAdobePlugIn="False" Theme="PlasticBlue" Style="margin-right: 0px"
        LoadingPanelText="Processando&hellip;">
        <Border BorderStyle="Solid" BorderWidth="1px" />
        <BorderLeft BorderStyle="Solid" BorderWidth="1px" />
        <BorderTop BorderStyle="Solid" BorderWidth="1px" />
        <BorderRight BorderStyle="Solid" BorderWidth="1px" />
        <BorderBottom BorderStyle="Solid" BorderWidth="1px" />
    </dx:ReportViewer>
    <div id="Div1">
        <dx:ReportToolbar ID="ReportToolbar2" runat="server" ReportViewerID="ReportViewer1"
            ShowDefaultButtons="False" Width="1052px" Theme="PlasticBlue"  Height="35px">
            <Items>
                <dx:ReportToolbarButton ItemKind="Search" />
                <dx:ReportToolbarSeparator />
                <dx:ReportToolbarButton ItemKind="PrintReport" />
                <dx:ReportToolbarButton ItemKind="PrintPage" />
                <dx:ReportToolbarSeparator />
                <dx:ReportToolbarButton Enabled="False" ItemKind="FirstPage" />
                <dx:ReportToolbarButton Enabled="False" ItemKind="PreviousPage" />
                <dx:ReportToolbarLabel ItemKind="PageLabel" />
                <dx:ReportToolbarComboBox ItemKind="PageNumber" Width="65px">
                </dx:ReportToolbarComboBox>
                <dx:ReportToolbarLabel ItemKind="OfLabel" />
                <dx:ReportToolbarTextBox IsReadOnly="True" ItemKind="PageCount" />
                <dx:ReportToolbarButton ItemKind="NextPage" />
                <dx:ReportToolbarButton ItemKind="LastPage" />
                <dx:ReportToolbarSeparator />
                <dx:ReportToolbarButton ItemKind="SaveToDisk" />
                <dx:ReportToolbarButton ItemKind="SaveToWindow" />
                <dx:ReportToolbarComboBox ItemKind="SaveFormat" Width="70px">
                    <Elements>
                        <dx:ListElement Value="pdf" />
                        <dx:ListElement Value="xls" />
                        <dx:ListElement Value="xlsx" />
                        <dx:ListElement Value="rtf" />
                        <dx:ListElement Value="mht" />
                        <dx:ListElement Value="html" />
                        <dx:ListElement Value="txt" />
                        <dx:ListElement Value="csv" />
                        <dx:ListElement Value="png" />
                    </Elements>
                </dx:ReportToolbarComboBox>
            </Items>
            <Styles>
                <LabelStyle>
                    <Margins MarginLeft="3px" MarginRight="3px" />
                </LabelStyle>
            </Styles>
        </dx:ReportToolbar>
    </div>
    </form>
</body>
</html>

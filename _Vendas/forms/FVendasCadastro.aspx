<%@ Page Title="FVendasCadastro" Language="C#" AutoEventWireup="true" CodeFile="FVendasCadastro.aspx.cs"
    Inherits="FVendasCadastro" StylesheetTheme="Principal" %>

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
    <title>Gitano - Vendas - Cadastro</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <link href="../../content/toastr.css" rel="stylesheet" />
    <style type="text/css">
        #Filtros {
            width: 200px;
            height: 108px;
            position: relative;
            top: -102px;
            left: 432px;
        }

        .myButton {
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

            .myButton:hover {
                background: -webkit-gradient(linear, left top, left bottom, color-stop(0.05, #415480), color-stop(1, #c3cce0));
                background: -moz-linear-gradient(top, #415480 5%, #c3cce0 100%);
                background: -webkit-linear-gradient(top, #415480 5%, #c3cce0 100%);
                background: -o-linear-gradient(top, #415480 5%, #c3cce0 100%);
                background: -ms-linear-gradient(top, #415480 5%, #c3cce0 100%);
                background: linear-gradient(to bottom, #415480 5%, #c3cce0 100%);
                filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#415480', endColorstr='#c3cce0',GradientType=0);
                background-color: #415480;
            }

            .myButton:active {
                position: relative;
                top: 1px;
            }

        .dx-vam, .dx-valm {
            vertical-align: middle;
        }

        .dx-vam, .dx-vat, .dx-vab {
            display: inline-block !important;
        }

        .dxeTrackBar_PlasticBlue, .dxeIRadioButton_PlasticBlue, .dxeButtonEdit_PlasticBlue, .dxeTextBox_PlasticBlue, .dxeRadioButtonList_PlasticBlue, .dxeCheckBoxList_PlasticBlue, .dxeMemo_PlasticBlue, .dxeListBox_PlasticBlue, .dxeCalendar_PlasticBlue, .dxeColorTable_PlasticBlue {
            -webkit-tap-highlight-color: rgba(0,0,0,0);
        }

        .dxeTextBox_PlasticBlue, .dxeButtonEdit_PlasticBlue, .dxeIRadioButton_PlasticBlue, .dxeRadioButtonList_PlasticBlue, .dxeCheckBoxList_PlasticBlue {
            cursor: default;
        }

        .dxeTextBox_PlasticBlue, .dxeMemo_PlasticBlue {
            background-color: White;
            border: 1px solid #B8B8B8;
        }

        input[type="text"].dxeEditArea_PlasticBlue, /*Bootstrap correction*/ input[type="password"].dxeEditArea_PlasticBlue /*Bootstrap correction*/ {
            height: 14px;
        }

        .dxeEditArea_PlasticBlue, input[type="text"].dxeEditArea_PlasticBlue, /*Bootstrap correction*/ input[type="password"].dxeEditArea_PlasticBlue /*Bootstrap correction*/ {
            margin: 1px 0px;
            font: 12px Tahoma, Geneva, sans-serif;
        }

        .dxeTextBox_PlasticBlue .dxeEditArea_PlasticBlue, .dxeMemo_PlasticBlue .dxeMemoEditArea_PlasticBlue {
            background-color: White;
        }

        .dxeEditArea_PlasticBlue {
            border: 1px solid #A0A0A0;
        }

        .dxeButtonEdit_PlasticBlue {
            border: 1px Solid #b8b8b8;
            background-color: White;
        }

            .dxeButtonEdit_PlasticBlue .dxeEditArea_PlasticBlue {
                background-color: White;
            }

        .dxeButtonEditButton_PlasticBlue, .dxeCalendarButton_PlasticBlue, .dxeSpinIncButton_PlasticBlue, .dxeSpinDecButton_PlasticBlue, .dxeSpinLargeIncButton_PlasticBlue, .dxeSpinLargeDecButton_PlasticBlue, .dxeColorEditButton_PlasticBlue {
            vertical-align: middle;
            color: White;
            border: 1px Solid #CCCCCC;
            cursor: pointer;
            font: normal 12px Tahoma, Geneva, sans-serif;
            text-align: center;
            white-space: nowrap;
        }

        .dxEditors_edtError_PlasticBlue, .dxEditors_edtCalendarPrevYear_PlasticBlue, .dxEditors_edtCalendarPrevYearDisabled_PlasticBlue, .dxEditors_edtCalendarPrevMonth_PlasticBlue, .dxEditors_edtCalendarPrevMonthDisabled_PlasticBlue, .dxEditors_edtCalendarNextMonth_PlasticBlue, .dxEditors_edtCalendarNextMonthDisabled_PlasticBlue, .dxEditors_edtCalendarNextYear_PlasticBlue, .dxEditors_edtCalendarNextYearDisabled_PlasticBlue, .dxEditors_edtCalendarFNPrevYear_PlasticBlue, .dxEditors_edtCalendarFNNextYear_PlasticBlue, .dxEditors_edtEllipsis_PlasticBlue, .dxEditors_edtEllipsisDisabled_PlasticBlue, .dxEditors_edtDropDown_PlasticBlue, .dxEditors_edtDropDownDisabled_PlasticBlue, .dxEditors_edtSpinEditIncrementImage_PlasticBlue, .dxEditors_edtSpinEditIncrementImageDisabled_PlasticBlue, .dxEditors_edtSpinEditDecrementImage_PlasticBlue, .dxEditors_edtSpinEditDecrementImageDisabled_PlasticBlue, .dxEditors_edtSpinEditLargeIncImage_PlasticBlue, .dxEditors_edtSpinEditLargeIncImageDisabled_PlasticBlue, .dxEditors_edtSpinEditLargeDecImage_PlasticBlue, .dxEditors_edtSpinEditLargeDecImageDisabled_PlasticBlue {
            display: block;
            margin: auto;
        }

        .dxEditors_edtDropDown_PlasticBlue {
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
                <h1>VENDAS - CADASTRO</h1>
                <h2>Cadastro da Venda de Unidade</h2>
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
                            Width="150px" Theme="PlasticBlue"
                            OnSelectedIndexChanged="cbgrupounidades_SelectedIndexChanged" Visible="False"
                            AutoPostBack="True">
                        </dx:ASPxComboBox>
                        <asp:RadioButtonList ID="rbmeiolote" runat="server" AutoPostBack="True" CellPadding="0"
                            CellSpacing="0" Font-Names="Calibri" Font-Size="12pt" Font-Strikeout="False"
                            ForeColor="#3E5395" Height="12px" Style="z-index: 2; left: 320px; top: 85px; position: absolute; right: 423px;"
                            Width="200px" RepeatDirection="Horizontal"
                            Visible="False">
                            <asp:ListItem Value="0" Selected="True">1o. Meio</asp:ListItem>
                            <asp:ListItem Value="1">2o. Meio</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:Label ID="Label8" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 120px; position: absolute"
                            Text="Cliente Comprador" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxComboBox ID="cbclientes" runat="server" ValueType="System.String" Font-Bold="True"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt; top: 120px; left: 150px;"
                            Width="380px"
                            Theme="PlasticBlue" OnSelectedIndexChanged="cbclientes_SelectedIndexChanged"
                            Visible="False" AutoPostBack="True">
                        </dx:ASPxComboBox>
                        <dx:ASPxComboBox ID="cbclientes_filtro" runat="server" IncrementalFilteringMode="StartsWith"
                            EnableIncrementalFiltering="True" ValueField="nome" TextFormatString="{0} ({1})"
                            Font-Bold="True" Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt; top: 120px; left: 150px;"
                            Width="380px"
                            Theme="PlasticBlue" AutoPostBack="True" EnableCallbackMode="True"
                            DataSourceID="dsfiltro_combo_contato" Visible="False"
                            OnSelectedIndexChanged="cbclientes_filtro_SelectedIndexChanged">
                            <Columns>
                                <dx:ListBoxColumn FieldName="nome" Width="300px" Caption="Nome" />
                                <dx:ListBoxColumn FieldName="id" Width="100px" Caption="Código" />
                            </Columns>
                        </dx:ASPxComboBox>
                        <asp:Label ID="Label4" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 185px; position: absolute"
                            Text="Data da Venda" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxDateEdit ID="dtvenda" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                            EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4; position: absolute; margin-right: 5px; left: 150px; top: 185px;"
                            Theme="PlasticBlue"
                            UseMaskBehavior="True" Width="120px" Visible="False">
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
                                                    }" />
                            <Border BorderColor="#808080" BorderStyle="Solid" BorderWidth="1px" />
                        </dx:ASPxDateEdit>
                        <asp:Label ID="Label5" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 220px; position: absolute"
                            Text="Valor Venda" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edvlrvenda" runat="server" Style="z-index: 2; left: 150px; top: 220px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="200px" Visible="False"
                            AutoPostBack="True" OnTextChanged="edvlrvenda_TextChanged">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label9" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 255px; position: absolute"
                            Text="Valor Sinal" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edvlrsinal" runat="server" Style="z-index: 2; left: 150px; top: 255px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="200px" Visible="False"
                            AutoPostBack="True" OnTextChanged="edvlrsinal_TextChanged">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                        <dx:ASPxCheckBox ID="cksinalparcelado" runat="server" Style="z-index: 2; left: 370px; top: 220px; position: absolute; right: 223px;"
                            AutoPostBack="True" CheckState="Unchecked"
                            Font-Bold="False" Font-Names="Calibri" Font-Size="14px" ForeColor="#3E5395" Height="21px"
                            Text="Sinal Parcelado" Theme="PlasticBlue" Width="120px" Visible="False" OnCheckedChanged="cksinalparcelado_CheckedChanged">
                        </dx:ASPxCheckBox>
                        <asp:Label ID="Label32" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 370px; top: 255px; position: absolute"
                            Text="Parcelas" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edqtdsinal" runat="server" Style="z-index: 2; left: 430px; top: 255px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="100px" Visible="False"
                            AutoPostBack="True" OnTextChanged="edqtdsinal_TextChanged">
                            <MaskSettings IncludeLiterals="None" Mask="&lt;0..9999999g&gt;" AllowMouseWheel="False" />
                        </dx:ASPxTextBox>
                        <div id="Divsinalparcelado" runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute; top: 90px; left: 540px; height: 160px; width: 280px;">
                            <asp:Label ID="Label20" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px; position: absolute"
                                Text="Sinal Parcelado" Theme="PlasticBlue"></asp:Label>
                            <asp:Label ID="Label21" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 20px; position: absolute"
                                Text="Parcelas" Theme="PlasticBlue" Visible="False"></asp:Label>
                            <asp:Label ID="Label25" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 100px; top: 20px; position: absolute"
                                Text="9999/9999" Theme="PlasticBlue" Visible="False"></asp:Label>
                            <dx:ASPxButton ID="btgravasinal" runat="server" Style="z-index: 2; left: 230px; top: 15px; position: absolute; width: 35px; height: 20px"
                                RightToLeft="True" HorizontalAlign="Center"
                                position="absolute" VerticalAlign="Middle" Visible="False" ImageSpacing="0px"
                                OnClick="btgravasinal_Click">
                                <Image Height="14px" Width="14px" ToolTip="ProcessaSinal" Url="~/images/BotoesTelas/BTNalterarA.bmp"
                                    UrlDisabled="~/images/BotoesTelas/BTNalterarI.bmp" UrlPressed="~/images/BotoesTelas/BTNalterarS.bmp">
                                </Image>
                                <Paddings PaddingBottom="0px" PaddingLeft="0px" PaddingRight="0px" PaddingTop="0px" />
                            </dx:ASPxButton>
                            <asp:Label ID="Label22" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 55px; position: absolute"
                                Text="Data" Theme="PlasticBlue" Visible="False"></asp:Label>
                            <dx:ASPxDateEdit ID="eddtparcelasinal" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                                EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                                Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4; position: absolute; margin-right: 5px; left: 100px; top: 55px;"
                                Theme="PlasticBlue"
                                UseMaskBehavior="True" Width="120px" Visible="False">
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
                                                    }" />
                                <Border BorderColor="#808080" BorderStyle="Solid" BorderWidth="1px" />
                            </dx:ASPxDateEdit>
                            <asp:Label ID="Label23" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 90px; position: absolute"
                                Text="Valor" Theme="PlasticBlue" Visible="False"></asp:Label>
                            <dx:ASPxTextBox ID="edvlrparcelasinal" runat="server" Style="z-index: 2; left: 100px; top: 90px; position: absolute; right: 223px;"
                                Theme="PlasticBlue" Width="150px"
                                Visible="False" AutoPostBack="True">
                                <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                            </dx:ASPxTextBox>
                            <asp:Label ID="Label24" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 125px; position: absolute"
                                Text="Total" Theme="PlasticBlue" Visible="False"></asp:Label>
                            <dx:ASPxTextBox ID="edvlrparcelasinaltotal" runat="server" Style="z-index: 2; left: 101px; top: 125px; position: absolute; right: 223px;"
                                Theme="PlasticBlue" Width="150px"
                                Visible="False" AutoPostBack="True" ReadOnly="True">
                                <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                            </dx:ASPxTextBox>
                        </div>
                        <asp:Label ID="Label10" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 290px; position: absolute"
                            Text="Saldo" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edvlrsaldo1" runat="server" Style="z-index: 2; left: 150px; top: 290px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="200px" Visible="False"
                            AutoPostBack="True">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label11" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 325px; position: absolute"
                            Text="Intermediárias" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edvlrintermediarias" runat="server" Style="z-index: 2; left: 150px; top: 325px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="200px"
                            Visible="False" AutoPostBack="True" OnTextChanged="edvlrintermediarias_TextChanged">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label19" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 370px; top: 325px; position: absolute; height: 18px;"
                            Text="Parcelas" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edqtdintermediarias" runat="server" Style="z-index: 2; left: 433px; top: 325px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="100px"
                            Visible="False" AutoPostBack="True"
                            OnTextChanged="edqtdintermediarias_TextChanged">
                            <MaskSettings IncludeLiterals="None" Mask="&lt;0..9999999g&gt;" AllowMouseWheel="False" />
                        </dx:ASPxTextBox>
                        <div id="Divintermediaria" runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute; top: 280px; left: 540px; height: 190px; width: 280px;">
                            <asp:Label ID="Label26" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px; position: absolute"
                                Text="Intermediárias" Theme="PlasticBlue"></asp:Label>
                            <asp:Label ID="Label27" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 20px; position: absolute"
                                Text="Parcelas" Theme="PlasticBlue" Visible="False"></asp:Label>
                            <asp:Label ID="Label28" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 100px; top: 20px; position: absolute"
                                Text="9999/9999" Theme="PlasticBlue" Visible="False"></asp:Label>
                            <dx:ASPxButton ID="btgravaintermediaria" runat="server" Style="z-index: 2; left: 230px; top: 15px; position: absolute; width: 35px; height: 20px"
                                RightToLeft="True"
                                HorizontalAlign="Left" position="absolute" VerticalAlign="Top" Visible="False"
                                ImageSpacing="0px" OnClick="btgravaintermediaria_Click">
                                <Image Height="14px" Width="14px" ToolTip="ProcessaIntermediaria" Url="~/images/BotoesTelas/BTNalterarA.bmp"
                                    UrlDisabled="~/images/BotoesTelas/BTNalterarI.bmp" UrlPressed="~/images/BotoesTelas/BTNalterarS.bmp">
                                </Image>
                                <Paddings PaddingBottom="0px" PaddingLeft="0px" PaddingRight="0px" PaddingTop="0px" />
                            </dx:ASPxButton>
                            <asp:Label ID="Label29" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 55px; position: absolute"
                                Text="Data" Theme="PlasticBlue" Visible="False"></asp:Label>
                            <dx:ASPxDateEdit ID="eddtparcelaintermediaria" runat="server" BackColor="#E1E6F2"
                                DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" EditFormatString="dd/MM/yyyy"
                                EnableTheming="True" Font-Bold="False" Font-Names="Calibri" Font-Size="15px"
                                ForeColor="#3E5395" Height="16px" Style="z-index: 4; position: absolute; margin-right: 5px; left: 100px; top: 55px;"
                                Theme="PlasticBlue" UseMaskBehavior="True" Width="120px"
                                Visible="False">
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
                                                    }" />
                                <Border BorderColor="#808080" BorderStyle="Solid" BorderWidth="1px" />
                            </dx:ASPxDateEdit>
                            <asp:Label ID="Label30" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 90px; position: absolute"
                                Text="Valor" Theme="PlasticBlue" Visible="False"></asp:Label>
                            <dx:ASPxTextBox ID="edvlrparcelaintermediaria" runat="server" Style="z-index: 2; left: 100px; top: 90px; position: absolute; right: 223px;"
                                Theme="PlasticBlue"
                                Width="150px" Visible="False" AutoPostBack="True">
                                <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                            </dx:ASPxTextBox>
                            <asp:Label ID="Label39" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 125px; position: absolute"
                                Text="Observação" Theme="PlasticBlue" Visible="False"></asp:Label>
                            <dx:ASPxTextBox ID="edobsintermediaria" runat="server" Style="z-index: 2; left: 101px; top: 126px; position: absolute; right: 223px;"
                                Theme="PlasticBlue" Width="150px"
                                Visible="False" AutoPostBack="True">
                            </dx:ASPxTextBox>
                            <asp:Label ID="Label31" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 160px; position: absolute"
                                Text="Total" Theme="PlasticBlue" Visible="False"></asp:Label>
                            <dx:ASPxTextBox ID="edvlrparcelaintermediariatotal" runat="server" Style="z-index: 2; left: 101px; top: 160px; position: absolute; right: 223px;"
                                Theme="PlasticBlue"
                                Width="150px" Visible="False" AutoPostBack="True" ReadOnly="True">
                                <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                            </dx:ASPxTextBox>
                        </div>
                        <asp:Label ID="Label18" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 360px; position: absolute"
                            Text="Fluxo de Parcelas" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edvlrfluxoparcelas" runat="server" Style="z-index: 2; left: 150px; top: 360px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="200px"
                            Visible="False" AutoPostBack="True" ReadOnly="True" OnTextChanged="edvlrfluxoparcelas_TextChanged">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label17" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 370px; top: 360px; position: absolute"
                            Text="Fluxos" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edqtdfluxoparcelas" runat="server" Style="z-index: 2; left: 430px; top: 360px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="100px"
                            Visible="False" AutoPostBack="True" OnTextChanged="edqtdfluxoparcelas_TextChanged">
                            <MaskSettings IncludeLiterals="None" Mask="&lt;0..9999999g&gt;" AllowMouseWheel="False" />
                        </dx:ASPxTextBox>
                        <div id="Divfluxos" runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute; top: 500px; left: 540px; height: 190px; width: 280px;">
                            <asp:Label ID="Label33" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px; position: absolute"
                                Text="Fluxos Financeiros" Theme="PlasticBlue"></asp:Label>
                            <asp:Label ID="Label34" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 20px; position: absolute"
                                Text="Fluxos" Theme="PlasticBlue" Visible="False"></asp:Label>
                            <asp:Label ID="Label35" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 100px; top: 20px; position: absolute"
                                Text="9999/9999" Theme="PlasticBlue" Visible="False"></asp:Label>
                            <dx:ASPxButton ID="btgravafluxo" runat="server" Style="z-index: 2; left: 230px; top: 15px; position: absolute; width: 35px; height: 20px"
                                RightToLeft="True" HorizontalAlign="Left"
                                position="absolute" VerticalAlign="Top" Visible="False" ImageSpacing="0px"
                                OnClick="btgravafluxo_Click">
                                <Image Height="14px" Width="14px" ToolTip="ProcessaFluxo" Url="~/images/BotoesTelas/BTNalterarA.bmp"
                                    UrlDisabled="~/images/BotoesTelas/BTNalterarI.bmp" UrlPressed="~/images/BotoesTelas/BTNalterarS.bmp">
                                </Image>
                                <Paddings PaddingBottom="0px" PaddingLeft="0px" PaddingRight="0px" PaddingTop="0px" />
                            </dx:ASPxButton>
                            <asp:Label ID="Label36" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 55px; position: absolute"
                                Text="Data Inicial" Theme="PlasticBlue" Visible="False"></asp:Label>
                            <dx:ASPxDateEdit ID="eddtinicialfluxo" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                                EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                                Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4; position: absolute; margin-right: 5px; left: 100px; top: 55px;"
                                Theme="PlasticBlue"
                                UseMaskBehavior="True" Width="120px" Visible="False">
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
                                                    }" />
                                <Border BorderColor="#808080" BorderStyle="Solid" BorderWidth="1px" />
                            </dx:ASPxDateEdit>
                            <asp:Label ID="Label37" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 90px; position: absolute"
                                Text="Valor" Theme="PlasticBlue" Visible="False"></asp:Label>
                            <dx:ASPxTextBox ID="edvlrparcelafluxo" runat="server" Style="z-index: 2; left: 100px; top: 90px; position: absolute; right: 223px;"
                                Theme="PlasticBlue" Width="150px"
                                Visible="False" AutoPostBack="True">
                                <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                            </dx:ASPxTextBox>
                            <asp:Label ID="Label40" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 125px; position: absolute"
                                Text="No.Parcelas" Theme="PlasticBlue" Visible="False"></asp:Label>
                            <dx:ASPxTextBox ID="edqtdparcelafluxo" runat="server" Style="z-index: 2; left: 101px; top: 126px; position: absolute; right: 223px;"
                                Theme="PlasticBlue" Width="150px"
                                Visible="False" AutoPostBack="True">
                                <MaskSettings IncludeLiterals="None" Mask="&lt;0..9999999g&gt;" />
                            </dx:ASPxTextBox>
                            <asp:Label ID="Label38" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 160px; position: absolute"
                                Text="Total" Theme="PlasticBlue" Visible="False"></asp:Label>
                            <dx:ASPxTextBox ID="edvlrparcelafluxototal" runat="server" Style="z-index: 2; left: 101px; top: 160px; position: absolute; right: 223px;"
                                Theme="PlasticBlue" Width="150px"
                                Visible="False" AutoPostBack="True" ReadOnly="True">
                                <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                            </dx:ASPxTextBox>
                        </div>
                        <asp:Label ID="Label12" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 395px; position: absolute"
                            Text="Indexador" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxComboBox ID="cbindexador" runat="server" ValueType="System.String" Font-Bold="True"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt; top: 395px; left: 150px;"
                            Width="380px"
                            Theme="PlasticBlue" AutoPostBack="True" Visible="False" OnSelectedIndexChanged="cbindexador_SelectedIndexChanged">
                        </dx:ASPxComboBox>
                        <asp:Label ID="Label13" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 425px; position: absolute"
                            Text="Periodicidade" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <asp:RadioButtonList ID="rbperiodicidade" runat="server" AutoPostBack="True" CellPadding="0"
                            CellSpacing="0" Font-Names="Calibri" Font-Size="12pt" Font-Strikeout="False"
                            ForeColor="#3E5395" Height="12px" Style="z-index: 2; left: 150px; top: 425px; position: absolute; right: 423px;"
                            Width="200px" RepeatDirection="Horizontal"
                            Visible="False" OnSelectedIndexChanged="rbperiodicidade_SelectedIndexChanged">
                            <asp:ListItem Value="0">Diária</asp:ListItem>
                            <asp:ListItem Value="1" Selected="True">Mensal</asp:ListItem>
                            <asp:ListItem Value="2">Anual</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:Label ID="Label14" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 460px; position: absolute"
                            Text="Corretor" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxComboBox ID="cbcorretor" runat="server" ValueType="System.String" Font-Bold="True"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt; top: 460px; left: 150px;"
                            Width="380px"
                            Theme="PlasticBlue" AutoPostBack="True" Visible="False" OnSelectedIndexChanged="cbcorretor_SelectedIndexChanged">
                        </dx:ASPxComboBox>
                        <asp:Label ID="Label15" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 495px; position: absolute"
                            Text="Multa %" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edmulta" runat="server" Style="z-index: 2; left: 150px; top: 495px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="200px" Visible="False"
                            AutoPostBack="True" OnTextChanged="edmulta_TextChanged">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label16" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 530px; position: absolute"
                            Text="Comissão %" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edcomissao" runat="server" Style="z-index: 2; left: 150px; top: 530px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="200px" Visible="False"
                            AutoPostBack="True" OnTextChanged="edcomissao_TextChanged">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                        <asp:RadioButtonList ID="rbperiodicidadecomissao" runat="server" AutoPostBack="True"
                            CellPadding="0" CellSpacing="0" Font-Names="Calibri" Font-Size="12pt" Font-Strikeout="False"
                            ForeColor="#3E5395" Height="12px" Style="z-index: 2; left: 360px; top: 530px; position: absolute; right: 423px;"
                            Width="170px" RepeatDirection="Horizontal"
                            Visible="False" OnSelectedIndexChanged="rbperiodicidadecomissao_SelectedIndexChanged">
                            <asp:ListItem Value="0">a.d.</asp:ListItem>
                            <asp:ListItem Value="1" Selected="True">a.m.</asp:ListItem>
                            <asp:ListItem Value="2">a.a.</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:Label ID="Label6" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 565px; position: absolute"
                            Text="Observações" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxTextBox ID="edobservacao" runat="server" Style="z-index: 2; left: 150px; top: 565px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="380px"
                            Visible="False" OnTextChanged="edobservacao_TextChanged">
                        </dx:ASPxTextBox>
                        <dx3:ASPxGridView ID="GridListagem" runat="server" AutoGenerateColumns="False" EnableTheming="True"
                            Font-Bold="False" KeyFieldName="ID" Style="margin-right: 6px; position: absolute; top: 720px; left: 10px;"
                            Theme="PlasticBlue" Width="812px" Visible="False"
                            OnCommandButtonInitialize="GridListagem_CommandButtonInitialize"
                            OnInitNewRow="GridListagem_InitNewRow" OnRowDeleting="GridListagem_RowDeleting"
                            OnRowInserting="GridListagem_RowInserting" OnRowUpdating="GridListagem_RowUpdating">
                            <SettingsBehavior AllowSelectByRowClick="True" ColumnResizeMode="Control" ConfirmDelete="True" />
                            <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                            <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                                VerticalScrollableHeight="400" />
                            <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                                CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                                CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Unidades do Produto"
                                Title="Verificar" />
                            <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                            <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                            <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                            <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                                VerticalScrollableHeight="400" />
                            <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                                CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                                CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Unidades do Produto"
                                Title="Verificar" />
                            <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                            <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                            <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                            <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                                VerticalScrollableHeight="400" />
                            <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                                CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                                CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Unidades do Produto"
                                Title="Verificar" />
                            <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                            <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                            <BackgroundImage HorizontalPosition="center" />
                            <SettingsBehavior AllowSelectByRowClick="True" ColumnResizeMode="Control" ConfirmDelete="True" />
                            <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                            <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                                VerticalScrollableHeight="600" />
                            <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                                CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                                CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Unidades do Produto"
                                Title="Verificar" />
                            <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                            <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                            <BackgroundImage HorizontalPosition="center" />
                            <Columns>
                                <dx3:GridViewCommandColumn ButtonType="Image" Caption=" Ação" ToolTip="Ações de Manutenção da Tabela"
                                    VisibleIndex="19">
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
                                <dx3:GridViewDataTextColumn FieldName="produto" VisibleIndex="1" Width="60px" Caption="Produto"
                                    Name="produto" SortIndex="0" SortOrder="Ascending" ReadOnly="True"
                                    Visible="False">
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
                                    VisibleIndex="8" Width="100px">
                                    <PropertiesTextEdit DisplayFormatInEditMode="true" DisplayFormatString="N"></PropertiesTextEdit>
                                    <EditFormSettings Caption="Valor Parcela &gt;" ColumnSpan="4" Visible="True"
                                        CaptionLocation="Near" />
                                    <EditFormCaptionStyle HorizontalAlign="Right" Font-Bold="True">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Grupo" FieldName="grupo" Name="grupo" VisibleIndex="2"
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
                                <dx3:GridViewDataTextColumn Caption="ID" FieldName="ID" Name="ID" VisibleIndex="0"
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
                                    VisibleIndex="5" Width="50px">
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
                                <dx3:GridViewDataTextColumn Caption="Vlr Pgto" FieldName="vlr_pagamento"
                                    Name="vlr_pagamento" VisibleIndex="10">
                                    <PropertiesTextEdit Width="100px" DisplayFormatInEditMode="true" DisplayFormatString="N"></PropertiesTextEdit>
                                    <EditFormSettings Caption="Valor Pagamento &gt;" ColumnSpan="2"
                                        Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Tipo" FieldName="tipo"
                                    Name="tipo" VisibleIndex="6" Width="50px">
                                    <EditFormSettings Caption="Parte &gt;" ColumnSpan="2" Visible="True"
                                        CaptionLocation="Near" />
                                    <EditCellStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditCellStyle>
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn VisibleIndex="3" Caption="Unidade" FieldName="unidade"
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
                                <dx3:GridViewDataTextColumn VisibleIndex="4" Caption="Parte" FieldName="parte" Name="parte"
                                    ReadOnly="True" Width="60px" Visible="False">
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataDateColumn Caption="Vencimento" FieldName="data_vencimento"
                                    Name="data_vencimento" VisibleIndex="7">
                                    <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy" Width="100px">
                                    </PropertiesDateEdit>
                                    <EditFormSettings Caption="Vencimento &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataDateColumn>
                                <dx3:GridViewDataTextColumn Caption="Valor Base" FieldName="vlr_base" Name="vlr_base"
                                    Visible="False" VisibleIndex="14">
                                    <EditFormSettings Caption="Valor Base &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Nosso Número" FieldName="nossonumero"
                                    Name="nossonumero" VisibleIndex="15">
                                    <EditFormSettings Caption="Nosso Número &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Origem Pagamento"
                                    FieldName="origem_pagamento" Name="origem_pagamento"
                                    Visible="False" VisibleIndex="16">
                                    <EditFormSettings Caption="Origem Pagamento &gt;" ColumnSpan="2"
                                        Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataCheckColumn Caption="Protesto" FieldName="protesto" Name="protesto"
                                    Visible="False" VisibleIndex="22">
                                    <PropertiesCheckEdit>
                                        <Style HorizontalAlign="Left">
                                        
                                    </Style>
                                    </PropertiesCheckEdit>
                                    <EditFormSettings Caption="Protesto &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataCheckColumn>
                                <dx3:GridViewDataTextColumn Caption="% Correção"
                                    FieldName="percentual_correcao" Name="percentual_correcao"
                                    Visible="False" VisibleIndex="20">
                                    <EditFormSettings Caption="% Correção &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Valor Original" FieldName="vlr_original"
                                    Name="vlr_original" Visible="False"
                                    VisibleIndex="12">
                                    <PropertiesTextEdit Width="100px">
                                    </PropertiesTextEdit>
                                    <EditFormSettings Caption="Valor Original &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="% Multa" FieldName="tx_multa" Name="tx_multa"
                                    Visible="False" VisibleIndex="24">
                                    <PropertiesTextEdit Width="100px">
                                    </PropertiesTextEdit>
                                    <EditFormSettings Caption="% Multa &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="% Comissão" FieldName="tx_comissao"
                                    Name="tx_comissao" Visible="False" VisibleIndex="25">
                                    <EditFormSettings Caption="% Comissão &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Valor Multa" FieldName="vlr_multa" Name="vlr_multa"
                                    VisibleIndex="28" Width="100px" Visible="False">
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
                                    Visible="False" VisibleIndex="29">
                                    <EditFormSettings Caption="Valor Comissão &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Valor Desconto" FieldName="vlr_desconto" Name="vlr_desconto"
                                    Visible="False" VisibleIndex="30">
                                    <EditFormSettings Caption="Valor Desconto &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Comissão"
                                    FieldName="periodicidade_comissao" Name="periodicidade_comissao"
                                    Visible="False" VisibleIndex="26">
                                    <EditFormSettings Caption="Comissão &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataCheckColumn Caption="Ativa" FieldName="ativa" Name="ativa"
                                    ReadOnly="True" VisibleIndex="17" Width="50px">
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
                                    Visible="False" VisibleIndex="23">
                                    <PropertiesCheckEdit>
                                        <Style HorizontalAlign="Left">
                                        
                                    </Style>
                                    </PropertiesCheckEdit>
                                    <EditFormSettings Caption="Contabil &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataCheckColumn>
                                <dx3:GridViewDataDateColumn Caption="Pagamento" FieldName="data_pagamento"
                                    Name="data_pagamento" VisibleIndex="9">
                                    <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy" Width="100px">
                                    </PropertiesDateEdit>
                                    <EditFormSettings Caption="Pagamento &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataDateColumn>
                                <dx3:GridViewDataTextColumn Caption="Conta" FieldName="conta" Name="conta"
                                    Visible="False" VisibleIndex="18" Width="50px">
                                    <EditFormSettings Caption="Conta &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataCheckColumn Caption="Carteira" FieldName="carteira" Name="carteira"
                                    Visible="False" VisibleIndex="21">
                                    <PropertiesCheckEdit>
                                        <Style HorizontalAlign="Left">
                                        
                                    </Style>
                                    </PropertiesCheckEdit>
                                    <EditFormSettings Caption="Carteira &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataCheckColumn>
                                <dx3:GridViewDataDateColumn Caption="Data Original" FieldName="data_original"
                                    Name="data_original" Visible="False" VisibleIndex="11">
                                    <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy" Width="100px">
                                    </PropertiesDateEdit>
                                    <EditFormSettings Caption="Data Original &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataDateColumn>
                                <dx3:GridViewDataDateColumn Caption="Data Base" FieldName="data_base"
                                    Name="data_base" Visible="False" VisibleIndex="13" Width="100px">
                                    <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy" Width="100px">
                                    </PropertiesDateEdit>
                                    <EditFormSettings Caption="Data Base &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataDateColumn>
                                <dx3:GridViewDataDateColumn Caption="Data Conta" FieldName="data_conta"
                                    Name="data_conta" ReadOnly="True" Visible="False" VisibleIndex="31">
                                    <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy" EnableFocusedStyle="False">
                                        <Style HorizontalAlign="Left">
                                    </Style>
                                    </PropertiesDateEdit>
                                    <EditFormSettings Caption="Data Conta &gt;" CaptionLocation="Near"
                                        ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataDateColumn>
                                <dx3:GridViewDataTextColumn Caption="Indexador" FieldName="indexador" Name="indexador"
                                    Visible="False" VisibleIndex="32">
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
                                    VisibleIndex="33" Visible="False">
                                    <EditFormSettings Caption="Indexador Mês &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Indexador Acumulado"
                                    FieldName="indexador_acumulado" Name="indexador_acumulado" Visible="False"
                                    VisibleIndex="34">
                                    <EditFormSettings Caption="Indexador Acumulado &gt;" ColumnSpan="2"
                                        Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Resíduo Mês" FieldName="residuo_mes"
                                    Name="residuo_mes" Visible="False" VisibleIndex="35">
                                    <EditFormSettings Caption="Resíduo Mês &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Resíduo Acumulado"
                                    FieldName="residuo_acumulado" Name="residuo_acumulado" Visible="False"
                                    VisibleIndex="36">
                                    <EditFormSettings Caption="Resíduo Acumulado &gt;" ColumnSpan="2"
                                        Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Valor Correção" FieldName="vlr_correcao"
                                    Name="vlr_correcao" Visible="False" VisibleIndex="27">
                                    <EditFormSettings Caption="Valor Correção &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Observações" FieldName="observacao"
                                    Name="observacao" Visible="False" VisibleIndex="37">
                                    <EditFormSettings Caption="Observações &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                </dx3:GridViewDataTextColumn>
                            </Columns>
                            <SettingsBehavior AllowSelectByRowClick="True" ColumnResizeMode="Control" ConfirmDelete="True" />
                            <SettingsPager Visible="False" PageSize="1000">
                                <AllButton ImagePosition="Bottom" Visible="True">
                                </AllButton>
                            </SettingsPager>
                            <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                            <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                                VerticalScrollableHeight="400" />
                            <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                                CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                                CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Unidades do Produto"
                                Title="Verificar" />
                            <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                            <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                            <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                            <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                                VerticalScrollableHeight="400" />
                            <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                                CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                                CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Unidades do Produto"
                                Title="Verificar" />
                            <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                            <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                            <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                            <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                                VerticalScrollableHeight="400" />
                            <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                                CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                                CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Unidades do Produto"
                                Title="Verificar" />
                            <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                            <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                            <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                            <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                                VerticalScrollableHeight="400" />
                            <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                                CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                                CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Unidades do Produto"
                                Title="Verificar" />
                            <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                            <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
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
                                            Venda de Unidades.<br />
                                            <br />
                                            O Processo ocorre com a reprodução dentro do sistema das regras financeiras explicitadas em contrato.<br />
                                            <br />
                                            O Sistema faz a checagem de valores antes de proceder o registro da Venda.<br />
                                            <br />
                                            Valor da Venda = (Sinal + Intermediárias + Fluxo de Parcelas).<br />
                                            <br />
                                            Informações necessárias aos cálculos de correção de contrato e pagamento de parcelas são solicitadas.<br />
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

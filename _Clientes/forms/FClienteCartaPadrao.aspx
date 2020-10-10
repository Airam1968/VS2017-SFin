<%@ Page Title="FClienteCartaPadrao" Language="C#" AutoEventWireup="true" CodeFile="FClienteCartaPadrao.aspx.cs"
    Inherits="FClienteCartaPadrao" StylesheetTheme="Principal" ClientIDMode="Inherit" %>

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
    <title>Gitano - Clientes - Cartas Padrão</title>
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
        .style1
        {
            border-width: 0;
            margin-left: 10px;
            background-image: url('mvwres://DevExpress.Web.ASPxThemes.v13.2,%20Version=13.2.5.0,%20Culture=neutral,%20PublicKeyToken=b88d1754d700e49a/DevExpress.Web.ASPxThemes.App_Themes.PlasticBlue.GridView.sprite.png');
        }
        .style2
        {
            width: 100%;
            font-size: 0;
        }
        .style3
        {
            width: 100%;
            font-size: 0;
            padding-left: 2px;
        }
        .style4
        {
            border-width: 0;
            background-image: url('mvwres://DevExpress.Web.ASPxThemes.v13.2,%20Version=13.2.5.0,%20Culture=neutral,%20PublicKeyToken=b88d1754d700e49a/DevExpress.Web.ASPxThemes.App_Themes.PlasticBlue.Editors.sprite.png');
        }
        .style5
        {
            height: 25px;
            width: 25px;
            cursor: pointer;
            border-width: 0;
        }
    </style>
</head>
<body style="height: 1200px">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1200px">
        <ContentTemplate>
            <h1>
                CLIENTES - CARTAS PADRÃO</h1>
            <h2>
                Manutenção de Cartas Padrão</h2>
            <div id="DivNova" style="border-style: none">
                <div style="border: 1px solid #808080; z-index: 1; left: 35px; top: 100px; position: absolute;
                    height: 481px; width: 832px; text-align: center;">
                    <dx3:ASPxGridView ID="GridListagem" runat="server" AutoGenerateColumns="False" EnableTheming="True"
                        Font-Bold="False" KeyFieldName="ID" Style="margin-right: 6px;" Theme="PlasticBlue"
                        OnRowInserting="GridListagem_RowInserting" OnRowUpdating="GridListagem_RowUpdating"
                        OnRowDeleting="GridListagem_RowDeleting" OnCommandButtonInitialize="GridListagem_CommandButtonInitialize"
                        OnInitNewRow="GridListagem_InitNewRow" Width="812px">
                        <SettingsBehavior AllowSelectByRowClick="True" ColumnResizeMode="Control" ConfirmDelete="True" />
                        <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                        <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                            VerticalScrollableHeight="400" />
                        <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                            CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                            CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Tipo de Produtos"
                            Title="Verificar" />
                        <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                        <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                        <BackgroundImage HorizontalPosition="center" />
                        <Columns>
                            <dx3:GridViewCommandColumn ButtonType="Image" Caption=" Ação" ToolTip="Ações de Manutenção da Tabela"
                                VisibleIndex="21">
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
                            <dx3:GridViewDataTextColumn FieldName="nome" VisibleIndex="1" Width="150px" Caption="Nome"
                                Name="nome" SortIndex="0" SortOrder="Ascending">
                                <EditFormSettings Caption="Nome &gt;" ColumnSpan="1" />
                                <PropertiesTextEdit Width="150px">
                                    <ValidationSettings>
                                        <RequiredField ErrorText="Preenchimento Obrigatório!" IsRequired="True" />
                                    </ValidationSettings>
                                    <Style Font-Bold="True" ForeColor="#3C6CBA"></Style>
                                </PropertiesTextEdit>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle ForeColor="White" Font-Bold="True" />
                                <CellStyle Font-Bold="True">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Linha 1" FieldName="linha_1" Name="linha_1"
                                VisibleIndex="2" Width="300px">
                                <EditFormSettings Caption="Linha 1 &gt;" CaptionLocation="Near" ColumnSpan="4" Visible="True" />
                                <PropertiesTextEdit>
                                    <Style Font-Bold="True" ForeColor="#3C6CBA" HorizontalAlign="Left"></Style>
                                </PropertiesTextEdit>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle ForeColor="White" Font-Bold="True" />
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Linha 2" FieldName="linha_2" Name="linha_2"
                                VisibleIndex="3" Width="300px" Visible="False">
                                <PropertiesTextEdit EnableFocusedStyle="False">
                                    <Style HorizontalAlign="Left"></Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Linha 2 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="ID" FieldName="ID" Name="ID" VisibleIndex="0"
                                Width="80px" ReadOnly="True">
                                <EditFormSettings Caption="ID &gt;" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Linha 3" FieldName="linha_3" Name="linha_3"
                                VisibleIndex="4" Width="300px" Visible="False">
                                <PropertiesTextEdit EnableFocusedStyle="False">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Linha 3 &gt;" Visible="True" />
                                <EditCellStyle HorizontalAlign="Left">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                                <CellStyle HorizontalAlign="Left">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Linha 4" FieldName="linha_4" Name="linha_4"
                                VisibleIndex="5" Width="300px" Visible="False">
                                <EditFormSettings Caption="Linha 4 &gt;" Visible="True" />
                                <EditCellStyle HorizontalAlign="Left">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                                <CellStyle HorizontalAlign="Left">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Linha 5" FieldName="linha_5" Name="linha_5"
                                VisibleIndex="6" Width="300px" Visible="False">
                                <EditFormSettings Caption="Linha 5 &gt;" Visible="True" />
                                <EditCellStyle HorizontalAlign="Left">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                                <CellStyle HorizontalAlign="Left">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Linha 6" FieldName="linha_6" Name="linha_6"
                                VisibleIndex="7" Width="300px" Visible="False">
                                <EditFormSettings Caption="Linha 6 &gt;" Visible="True" />
                                <EditCellStyle HorizontalAlign="Left">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                                <CellStyle HorizontalAlign="Left">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Linha 7" FieldName="linha_7" Name="linha_7"
                                VisibleIndex="8" Width="300px" Visible="False">
                                <EditFormSettings Caption="Linha 7 &gt;" Visible="True" />
                                <EditCellStyle HorizontalAlign="Left">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                                <CellStyle HorizontalAlign="Left">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Linha 8" FieldName="linha_8" Name="linha_8"
                                VisibleIndex="9" Width="300px" Visible="False">
                                <EditFormSettings Caption="Linha 8 &gt;" Visible="True" />
                                <EditCellStyle HorizontalAlign="Left">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                                <CellStyle HorizontalAlign="Left">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Linha 9" FieldName="linha_9" Name="linha_9"
                                VisibleIndex="10" Width="300px" Visible="False">
                                <EditFormSettings Caption="Linha 9 &gt;" Visible="True" />
                                <EditCellStyle HorizontalAlign="Left">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                                <CellStyle HorizontalAlign="Left">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Linha 10" FieldName="linha_10" Name="linha_10"
                                VisibleIndex="11" Width="300px" Visible="False">
                                <EditFormSettings Caption="Linha 10 &gt;" Visible="True" />
                                <EditCellStyle HorizontalAlign="Left">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                                <CellStyle HorizontalAlign="Left">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Linha 11" FieldName="linha_11" Name="linha_11"
                                VisibleIndex="12" Width="300px" Visible="False">
                                <EditFormSettings Caption="Linha 11 &gt;" Visible="True" />
                                <EditCellStyle HorizontalAlign="Left">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                                <CellStyle HorizontalAlign="Left">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Linha 12" FieldName="linha_12" Name="linha_12"
                                VisibleIndex="13" Width="300px" Visible="False">
                                <EditFormSettings Caption="Linha 12 &gt;" Visible="True" />
                                <EditCellStyle HorizontalAlign="Left">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                                <CellStyle HorizontalAlign="Left">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Linha 13" FieldName="linha_13" Name="linha_13"
                                VisibleIndex="14" Width="300px" Visible="False">
                                <EditFormSettings Caption="Linha 13 &gt;" Visible="True" />
                                <EditCellStyle HorizontalAlign="Left">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                                <CellStyle HorizontalAlign="Left">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Linha 14" FieldName="linha_14" Name="linha_14"
                                VisibleIndex="15" Width="300px" Visible="False">
                                <EditFormSettings Caption="Linha 14 &gt;" Visible="True" />
                                <EditCellStyle HorizontalAlign="Left">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                                <CellStyle HorizontalAlign="Left">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Linha 15" FieldName="linha_15" Name="linha_15"
                                VisibleIndex="16" Width="300px" Visible="False">
                                <EditFormSettings Caption="Linha 15 &gt;" Visible="True" />
                                <EditCellStyle HorizontalAlign="Left">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                                <CellStyle HorizontalAlign="Left">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Linha 16" FieldName="linha_16" Name="linha_16"
                                VisibleIndex="17" Width="300px" Visible="False">
                                <EditFormSettings Caption="Linha 16 &gt;" Visible="True" />
                                <EditCellStyle HorizontalAlign="Left">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                                <CellStyle HorizontalAlign="Left">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Linha 17" FieldName="linha_17" Name="linha_17"
                                VisibleIndex="18" Width="300px" Visible="False">
                                <EditFormSettings Caption="Linha 17 &gt;" Visible="True" />
                                <EditCellStyle HorizontalAlign="Left">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                                <CellStyle HorizontalAlign="Left">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Linha 18" FieldName="linha_18" Name="linha_18"
                                VisibleIndex="19" Width="300px" Visible="False">
                                <EditFormSettings Caption="Linha 18 &gt;" Visible="True" />
                                <EditCellStyle HorizontalAlign="Left">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                                <CellStyle HorizontalAlign="Left">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Linha 19" FieldName="linha_19" Name="linha_19"
                                VisibleIndex="20" Width="300px" Visible="False">
                                <EditFormSettings Caption="Linha 19 &gt;" Visible="True" />
                                <EditCellStyle HorizontalAlign="Left">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                                <CellStyle HorizontalAlign="Left">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                        </Columns>
                        <SettingsBehavior AllowSelectByRowClick="True" ColumnResizeMode="Control" ConfirmDelete="True" />
                        <SettingsPager Visible="False" PageSize="1000">
                            <AllButton ImagePosition="Bottom" Visible="True">
                            </AllButton>
                        </SettingsPager>
                        <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                        <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                        <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                        <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                            VerticalScrollableHeight="400" />
                        <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                            CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                            CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Tipo de Produtos"
                            Title="Verificar" />
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

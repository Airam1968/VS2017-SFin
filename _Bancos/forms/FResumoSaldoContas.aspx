<%@ Page Title="FResumoSaldoContas" Language="C#" AutoEventWireup="true" CodeFile="FResumoSaldoContas.aspx.cs"
    Inherits="FResumoSaldoContas" StylesheetTheme="Principal" %>

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
    <title>Gitano - Bancos - Resumo Saldo de Contas</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body style="height: 1400px">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager" runat="server" />
        <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1400px">
            <ContentTemplate>
                <h1>RESUMO CONTAS - BANCOS</h1>
                <h2>Resumo Saldos de Contas</h2>
                <div id="DivNova" style="border-style: none">
                    <div style="border: 1px solid #808080; z-index: 1; left: 35px; top: 100px; position: absolute; height: 1200px; width: 920px; text-align: center;">
                        <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px; position: absolute"
                            Text="Filtro" Theme="PlasticBlue"></asp:Label>
                        <asp:Label ID="Label16" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 15px; position: absolute"
                            Text="Conta Corrente" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxComboBox ID="cbcontascorrentes" runat="server" ValueType="System.String"
                            Font-Bold="True" Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt; top: 15px; left: 150px;"
                            Width="380px" Theme="PlasticBlue"
                            Visible="False" AutoPostBack="True"
                            OnSelectedIndexChanged="cbcontascorrentes_SelectedIndexChanged">
                        </dx:ASPxComboBox>
                        <asp:Label ID="Label4" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 50px; position: absolute"
                            Text="Período" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxDateEdit ID="dtprevisao1" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                            EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4; position: absolute; margin-right: 5px; left: 150px; top: 50px;"
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
                        <asp:Label ID="Label5" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 300px; top: 50px; position: absolute"
                            Text="Até" Theme="PlasticBlue" Visible="False"></asp:Label>
                        <dx:ASPxDateEdit ID="dtprevisao2" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                            EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4; position: absolute; margin-right: 5px; left: 350px; top: 50px;"
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
                        <asp:Label ID="Label14" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 120px; position: absolute"
                            Text="Saldo Final" Theme="PlasticBlue"></asp:Label>
                        <dx:ASPxTextBox ID="edsaldot" runat="server" Style="z-index: 2; left: 150px; top: 120px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="200px"
                            AutoPostBack="True" ReadOnly="True" HorizontalAlign="Right">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label2" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 155px; position: absolute"
                            Text="Aplic.Desbloqueada" Theme="PlasticBlue"></asp:Label>
                        <dx:ASPxTextBox ID="edaplicdesbloqueadat" runat="server" Style="z-index: 2; left: 150px; top: 155px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="200px"
                            AutoPostBack="True" ReadOnly="True" HorizontalAlign="Right">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label3" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 190px; position: absolute"
                            Text="Aplic.Bloqueada" Theme="PlasticBlue"></asp:Label>
                        <dx:ASPxTextBox ID="edaplicbloqueadat" runat="server" Style="z-index: 2; left: 150px; top: 190px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="200px"
                            AutoPostBack="True" ReadOnly="True" HorizontalAlign="Right">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label6" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 225px; position: absolute"
                            Text="Saldo Final" Theme="PlasticBlue"></asp:Label>
                        <dx:ASPxTextBox ID="edsaldofinalt" runat="server" Style="z-index: 2; left: 150px; top: 225px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="200px"
                            AutoPostBack="True" ReadOnly="True" HorizontalAlign="Right">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                        <dx3:ASPxGridView ID="GridListagem" runat="server" AutoGenerateColumns="False" EnableTheming="True"
                            Font-Bold="False" KeyFieldName="cod_conta" Style="margin-right: 6px; position: absolute; top: 300px; left: 10px;"
                            Theme="PlasticBlue" Width="870px" Visible="False"
                            OnCommandButtonInitialize="GridListagem_CommandButtonInitialize" OnInitNewRow="GridListagem_InitNewRow"
                            OnRowDeleting="GridListagem_RowDeleting" OnRowInserting="GridListagem_RowInserting"
                            OnRowUpdating="GridListagem_RowUpdating">
                            <SettingsBehavior AllowSelectByRowClick="True" ColumnResizeMode="Control" ConfirmDelete="True" />
                            <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                            <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                                VerticalScrollableHeight="600" HorizontalScrollBarMode="Visible" />
                            <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                                CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                                CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Unidades do Produto"
                                Title="Verificar" />
                            <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                            <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                            <BackgroundImage HorizontalPosition="center" />
                            <Columns>
                                <dx3:GridViewCommandColumn ButtonType="Image" Caption=" Ação" ToolTip="Ações de Manutenção da Tabela"
                                    VisibleIndex="12">
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
                                <dx3:GridViewDataTextColumn FieldName="produto" VisibleIndex="3" Width="60px" Caption="Produto"
                                    Name="produto" ReadOnly="True"
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
                                <dx3:GridViewDataTextColumn Caption="Saldo Ini" FieldName="saldo_i" Name="saldo_i"
                                    VisibleIndex="8" Width="100px">
                                    <EditFormSettings Caption="Saldo Ini &gt;" ColumnSpan="4" Visible="True"
                                        CaptionLocation="Near" />
                                    <EditFormCaptionStyle HorizontalAlign="Right" Font-Bold="True">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Classe" FieldName="classe" Name="classe" VisibleIndex="4"
                                    Width="60px" ReadOnly="True" Visible="False">
                                    <PropertiesTextEdit EnableFocusedStyle="False" Width="60px">
                                        <Style HorizontalAlign="Left" Font-Bold="True"></Style>
                                    </PropertiesTextEdit>
                                    <EditFormSettings Caption="Classe &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="White" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="ID" FieldName="ID" Name="ID" VisibleIndex="0"
                                    Width="60px" ReadOnly="True" Visible="False">
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
                                <dx3:GridViewDataTextColumn Caption="Lanc." FieldName="lancamento" Name="lancamento"
                                    VisibleIndex="2" Width="60px" Visible="False">
                                    <PropertiesTextEdit Width="100px">
                                        <Style Font-Bold="False" HorizontalAlign="Left">
                                       
                                    </Style>
                                    </PropertiesTextEdit>
                                    <EditFormSettings Caption="No. Lanc. &gt;" ColumnSpan="2" Visible="True" />
                                    <PropertiesTextEdit Width="100px">
                                        <Style Font-Bold="False" HorizontalAlign="Left"></Style>
                                    </PropertiesTextEdit>
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Crédito" FieldName="credito" Name="credito"
                                    VisibleIndex="9" Width="100px">
                                    <PropertiesTextEdit Width="100px">
                                    </PropertiesTextEdit>
                                    <EditFormSettings Caption="Crédito &gt;" ColumnSpan="4" Visible="True"
                                        CaptionLocation="Near" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Débito" FieldName="debito" Name="debito" VisibleIndex="10"
                                    ReadOnly="True" Width="100px">
                                    <EditFormSettings Caption="Débito &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataDateColumn Caption="Data" FieldName="data" Name="data"
                                    SortIndex="0" SortOrder="Ascending" VisibleIndex="6" Width="100px">
                                    <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy" Width="100px">
                                    </PropertiesDateEdit>
                                    <EditFormSettings Caption="Data &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataDateColumn>
                                <dx3:GridViewDataTextColumn Caption="Complemento" FieldName="complemento" Name="complemento"
                                    VisibleIndex="13" Width="200px">
                                    <PropertiesTextEdit Width="60px">
                                        <Style Font-Bold="True">
                                       
                                    </Style>
                                    </PropertiesTextEdit>
                                    <EditFormSettings Caption="Complemento &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Saldo Fim" FieldName="saldo_f"
                                    Name="saldo_f" VisibleIndex="11" Width="100px">
                                    <EditFormSettings Caption="Saldo Fim &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Aplicação B" FieldName="saldo_aplicacaoB"
                                    Name="saldo_aplicacaoB" VisibleIndex="15" Width="100px">
                                    <EditFormSettings Caption="Aplicação B &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Center">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataDateColumn Caption="Data Registro" FieldName="dtregistro" Name="dtregistro"
                                    VisibleIndex="19" Visible="False">
                                    <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy" Width="100px">
                                    </PropertiesDateEdit>
                                    <EditFormSettings Caption="Data Registro &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataDateColumn>
                                <dx3:GridViewDataTextColumn Caption="Aplicação D" FieldName="saldo_aplicacaoD"
                                    Name="saldo_aplicacaoD" VisibleIndex="14" Width="100px">
                                    <PropertiesTextEdit Width="60px">
                                        <Style Font-Bold="True">
                                       
                                    </Style>
                                    </PropertiesTextEdit>
                                    <EditFormSettings Caption="Aplicação D &gt;" ColumnSpan="2" Visible="True" />
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
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Saldo Total" FieldName="saldo_total" Name="saldo_total"
                                    VisibleIndex="16" Width="100px">
                                    <EditFormSettings Caption="Saldo Total &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Conta" FieldName="cod_conta"
                                    Name="cod_conta" VisibleIndex="1">
                                    <EditFormSettings Caption="Conta &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Descrição" FieldName="descricao" Name="descricao"
                                    VisibleIndex="7" Width="200px">
                                    <EditFormSettings Caption="Descrição &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Ped.Compra" FieldName="pedido_compra" Name="pedido_compra"
                                    VisibleIndex="5" Width="60px" Visible="False">
                                    <EditFormSettings Caption="Ped.Compra &gt;" CaptionLocation="Near"
                                        ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Right">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Cheque" FieldName="cheque" Name="cheque"
                                    VisibleIndex="17" Visible="False">
                                    <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" Width="100px">
                                    </PropertiesTextEdit>
                                    <EditFormSettings Caption="Cheque &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="CMC7" FieldName="cmc7" Name="cmc7"
                                    ReadOnly="True" VisibleIndex="18" Width="200px" Visible="False">
                                    <PropertiesTextEdit EnableFocusedStyle="False">
                                        <Style HorizontalAlign="Left">
                                    </Style>
                                    </PropertiesTextEdit>
                                    <EditFormSettings Caption="CMC7 &gt;" ColumnSpan="2" Visible="True" />
                                    <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                    </EditFormCaptionStyle>
                                    <HeaderStyle Font-Bold="True" />
                                    <CellStyle HorizontalAlign="Center">
                                    </CellStyle>
                                </dx3:GridViewDataTextColumn>
                            </Columns>
                            <SettingsBehavior AllowSelectByRowClick="True" ColumnResizeMode="Control" ConfirmDelete="True" />
                            <SettingsPager Visible="False" PageSize="1000000">
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
                            <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                                CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                                CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Unidades do Produto"
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
                        <div id="Div2" runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute; top: 20px; left: 700px; height: 50px; width: 100px;">
                            <dx:ASPxButton ID="btprocessa" runat="server" Height="40px" ImagePosition="Left"
                                OnClick="btprocessa_Click" Width="45px" ToolTip="Aplica Filtros">
                                <Image Height="30px" ToolTip="Aplicar Filtro" Url="~/images/BotoesTelas/BTNalterarA.bmp"
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
                                            Consulta de Resumo Saldo das Contas.<br />
                                            <br />
                                            Através dos filtros é uma visão rápida sobre os últimos saldos das contas bancárias.<br />
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

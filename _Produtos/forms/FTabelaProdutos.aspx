<%@ Page Title="FTabelaProdutos" Language="C#" AutoEventWireup="true" CodeFile="FTabelaProdutos.aspx.cs"
    Inherits="FTabelaProdutos" StylesheetTheme="Principal" %>

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
    <title>Gitano - Produto - Tabela Produtos</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body style="height: 1200px">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1200px">
        <ContentTemplate>
            <h1>
                PRODUTO - TABELA - PRODUTOS</h1>
            <h2>
                Manutenção de Produtos</h2>
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
                            CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Produtos"
                            Title="Verificar" />
                        <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                        <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                        <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                        <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                            VerticalScrollableHeight="400" />
                        <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                            CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                            CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Produtos"
                            Title="Verificar" />
                        <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                        <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                        <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                        <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                            VerticalScrollableHeight="400" />
                        <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                            CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                            CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Produtos"
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
                            CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Produtos"
                            Title="Verificar" />
                        <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                        <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                        <BackgroundImage HorizontalPosition="center" />
                        <Columns>
                            <dx3:GridViewCommandColumn ButtonType="Image" Caption=" Ação" ToolTip="Ações de Manutenção da Tabela"
                                VisibleIndex="7">
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
                            <dx3:GridViewDataTextColumn FieldName="tipo" VisibleIndex="1" Width="50px" Caption="Tipo"
                                Name="tipo">
                                <EditFormSettings Caption="Tipo &gt;" ColumnSpan="1" />
                                <PropertiesTextEdit Width="150px" MaxLength="20">
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
                            <dx3:GridViewDataTextColumn Caption="Descricao" FieldName="descricao" Name="descricao"
                                VisibleIndex="2" Width="310px">
                                <EditFormSettings Caption="Descricao &gt;" CaptionLocation="Near" ColumnSpan="4"
                                    Visible="True" />
                                <PropertiesTextEdit MaxLength="50">
                                    <ValidationSettings>
                                        <RequiredField ErrorText="Preenchimento Obrigatório!" IsRequired="True" />
                                    </ValidationSettings>
                                    <Style Font-Bold="True" ForeColor="#3C6CBA" HorizontalAlign="Left"></Style>
                                </PropertiesTextEdit>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle ForeColor="White" Font-Bold="True" />
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="CNPJ" FieldName="cnpj" Name="CPFCNPJ" VisibleIndex="3"
                                Width="150px">
                                <PropertiesTextEdit EnableFocusedStyle="False" MaxLength="14">
                                    <MaskSettings IncludeLiterals="None" Mask="99.999.999/9999-99" />
                                    <%--                                    <ValidationSettings>
                                        <RequiredField ErrorText="Preenchimento Obrigatório!" IsRequired="True" />
                                    </ValidationSettings>--%>
                                    <Style HorizontalAlign="Left"></Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="CNPJ &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="ID" FieldName="ID" Name="ID" VisibleIndex="0"
                                Width="50px" ReadOnly="False" SortIndex="0" SortOrder="Ascending">
                                <PropertiesTextEdit Width="60px">
                                    <ValidationSettings>
                                        <RequiredField ErrorText="Preenchimento Obrigatório!" IsRequired="True" />
                                    </ValidationSettings>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="ID &gt;" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataCheckColumn Caption="Ativo" FieldName="ativo" Name="Ativo" VisibleIndex="6"
                                Width="50px" ReadOnly="True">
                                <EditFormSettings Caption="Ativo &gt;" Visible="True" />
                                <PropertiesCheckEdit DisplayTextChecked="Marcado" DisplayTextUnchecked="Desmarcado">
                                    <ValidationSettings>
                                        <RequiredField ErrorText="Preenchimento Obrigatório!" IsRequired="True" />
                                    </ValidationSettings>
                                </PropertiesCheckEdit>
                                <EditCellStyle HorizontalAlign="Left">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                                <CellStyle HorizontalAlign="Center">
                                </CellStyle>
                            </dx3:GridViewDataCheckColumn>
                            <dx3:GridViewDataTextColumn Caption="Conta" FieldName="conta" Name="conta" VisibleIndex="5">
                                <PropertiesTextEdit MaxLength="30">
                                    <ValidationSettings>
                                        <RequiredField ErrorText="Preenchimento Obrigatório!" IsRequired="True" />
                                    </ValidationSettings>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Conta &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Endereço" FieldName="enderecocom" Name="enderecocom"
                                Visible="False" VisibleIndex="8">
                                <PropertiesTextEdit MaxLength="30">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Complemento &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Número" FieldName="enderecocomnumero" Name="enderecocomnumero"
                                Visible="False" VisibleIndex="9">
                                <PropertiesTextEdit MaxLength="15">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Número &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Complemento" FieldName="enderecocomcomplem"
                                Name="enderecocomcomplem" Visible="False" VisibleIndex="10">
                                <PropertiesTextEdit MaxLength="70">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Complemento &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Bairro" FieldName="bairrocom" Name="bairrocom"
                                Visible="False" VisibleIndex="11">
                                <PropertiesTextEdit MaxLength="20">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Bairro &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Cidade" FieldName="cidadecom" Name="cidadecom"
                                Visible="False" VisibleIndex="12">
                                <PropertiesTextEdit MaxLength="20">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Cidade &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="UF" FieldName="ufcom" Name="ufcom" Visible="False"
                                VisibleIndex="13" Width="100px">
                                <PropertiesTextEdit MaxLength="30">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="UF &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="CEP" FieldName="cepcom" Name="cepcom" Visible="False"
                                VisibleIndex="14" Width="100px">
                                <PropertiesTextEdit MaxLength="30">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="CEP &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Telefone 1" FieldName="fone1com" Name="fone1com"
                                Visible="False" VisibleIndex="15">
                                <PropertiesTextEdit MaxLength="8" Width="100px">
                                    <MaskSettings IncludeLiterals="None" Mask="99999-999" />
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Telefone 1&gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Telefone 2" FieldName="fone2com" Name="fone2com"
                                Visible="False" VisibleIndex="16">
                                <PropertiesTextEdit MaxLength="50">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Telefone 2 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Telefone 3" FieldName="fone3com" Name="fone3com"
                                Visible="False" VisibleIndex="17">
                                <PropertiesTextEdit MaxLength="50">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Telefone 3 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="E-Mail 1" FieldName="email1" Name="email1" Visible="False"
                                VisibleIndex="18">
                                <PropertiesTextEdit MaxLength="2" Width="100px">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="E-Mail 1 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="E-Mail 2" FieldName="email2" Name="email2" Visible="False"
                                VisibleIndex="19">
                                <PropertiesTextEdit MaxLength="50">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="E-Mail 2 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="E-Mail 3" FieldName="email3" Name="email3" Visible="False"
                                VisibleIndex="20">
                                <PropertiesTextEdit MaxLength="30">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="E-Mail 3 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Area" FieldName="area" Name="area" Visible="False"
                                VisibleIndex="21">
                                <PropertiesTextEdit MaxLength="10">
                                    <%--                                    <ValidationSettings>
                                        <RequiredField ErrorText="Preenchimento Obrigatório!" IsRequired="True" />
                                    </ValidationSettings>--%>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Area &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Situacao Obra" FieldName="situacao_obra" Name="situacao_obra"
                                Visible="False" VisibleIndex="22">
                                <PropertiesTextEdit MaxLength="20">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Situacao Obra &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataDateColumn Caption="Habitese" FieldName="habitese" Name="habitese"
                                Visible="False" VisibleIndex="4" Width="150px">
                                <PropertiesDateEdit DisplayFormatString="" Width="100px">
                                    <%--                                    <ValidationSettings>
                                        <RequiredField ErrorText="Preenchimento Obrigatório!" IsRequired="True" />
                                    </ValidationSettings>--%>
                                </PropertiesDateEdit>
                                <EditFormSettings Caption="Habitese &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataDateColumn>
                            <dx3:GridViewDataTextColumn Caption="Cub" FieldName="cub" Name="cub" Visible="False"
                                VisibleIndex="23">
                                <PropertiesTextEdit MaxLength="10">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Cub &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Obs" FieldName="obs1" Name="obs1" Visible="False"
                                VisibleIndex="24">
                                <PropertiesTextEdit MaxLength="80">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Obs &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Obs" FieldName="obs2" Name="obs2" Visible="False"
                                VisibleIndex="25">
                                <PropertiesTextEdit MaxLength="80">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Obs &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Obs" FieldName="obs3" Name="obs3" Visible="False"
                                VisibleIndex="26">
                                <PropertiesTextEdit MaxLength="80">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Obs &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Obs" FieldName="obs4" Name="obs4" Visible="False"
                                VisibleIndex="27">
                                <PropertiesTextEdit MaxLength="80">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Obs &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Obs" FieldName="obs5" Name="obs5" Visible="False"
                                VisibleIndex="28">
                                <PropertiesTextEdit MaxLength="80">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Obs &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Cod. PIS" FieldName="codpis" Name="codpis" Visible="False"
                                VisibleIndex="29" Width="150px">
                                <PropertiesTextEdit MaxLength="18">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Cod. PIS &gt;" ColumnSpan="2" Visible="True" />
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
                            CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Produtos"
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
                    <div id="Div2" runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute;
                        top: 20px; left: 850px; height: 50px; width: 50px;">
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
                                        Produtos - Empreendimentos.<br />
                                        <br />
                                        Tabela de Manutenção de Produtos - Empreendimentos.<br />
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

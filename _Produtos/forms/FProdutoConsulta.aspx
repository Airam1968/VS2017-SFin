<%@ Page Title="FProdutoConsulta" Language="C#" AutoEventWireup="true" CodeFile="FProdutoConsulta.aspx.cs"
    Inherits="FProdutoConsulta" StylesheetTheme="Principal" %>

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
    <title>Gitano - Produto - Consulta</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body style="height: 1200px">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1200px">
        <ContentTemplate>
            <h1>
                PRODUTO - CONSULTA</h1>
            <h2>
                Consulta Estrutura do Produto</h2>
            <div id="DivNova" style="border-style: none">
                <div style="border: 1px solid #808080; z-index: 1; left: 35px; top: 100px; position: absolute;
                    height: 620px; width: 832px; text-align: center;">
                    <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px;
                        position: absolute" Text="Selecione" Theme="PlasticBlue"></asp:Label>
                    <asp:Label ID="Label3" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 15px;
                        position: absolute" Text="Produto" Theme="PlasticBlue"></asp:Label>
                    <dx:ASPxComboBox ID="cbproduto" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 40px; left: 10px;" Width="400px" 
                        Theme="PlasticBlue" 
                        onselectedindexchanged="cbproduto_SelectedIndexChanged" AutoPostBack="True">
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label2" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 70px;
                        position: absolute" Text="Grupo" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxComboBox ID="cbgrupo" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 95px; left: 10px;" Width="400px" 
                        Theme="PlasticBlue" onselectedindexchanged="cbgrupo_SelectedIndexChanged" 
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxComboBox>
                    <dx3:ASPxGridView ID="GridListagem" runat="server" AutoGenerateColumns="False" EnableTheming="True"
                        Font-Bold="False" KeyFieldName="ID" 
                        Style="margin-right: 6px; position: absolute; top: 140px; left: 10px;" 
                        Theme="PlasticBlue" Width="812px" Visible="False" 
                        oncommandbuttoninitialize="GridListagem_CommandButtonInitialize" 
                        oninitnewrow="GridListagem_InitNewRow" onrowdeleting="GridListagem_RowDeleting" 
                        onrowinserting="GridListagem_RowInserting" 
                        onrowupdating="GridListagem_RowUpdating">
                        <SettingsBehavior AllowSelectByRowClick="True" ColumnResizeMode="Control" ConfirmDelete="True" />
                        <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" />
                        <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                            VerticalScrollableHeight="400" HorizontalScrollBarMode="Visible" />
                        <SettingsText EmptyDataRow="Não há Dados á Exibir" CommandCancel="Cancela" CommandClearFilter="Limpar Filtros"
                            CommandDelete="Exclui" CommandEdit="Altera" CommandNew="Insere" CommandSelect="Seleciona"
                            CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Unidades do Produto"
                            Title="Verificar" />
                        <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                        <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                        <BackgroundImage HorizontalPosition="center" />
                        <Columns>
                            <dx3:GridViewCommandColumn ButtonType="Image" Caption=" Ação" ToolTip="Ações de Manutenção da Tabela"
                                VisibleIndex="9">
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
                                Name="produto" SortIndex="0" SortOrder="Ascending" ReadOnly="True">
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
                            <dx3:GridViewDataTextColumn Caption="Valor Total" FieldName="vlr_total" Name="vlr_total"
                                VisibleIndex="6" Width="100px">
                                <EditFormSettings Caption="Valor Total &gt;" ColumnSpan="4" Visible="True" 
                                    CaptionLocation="Near" />
                                <EditFormCaptionStyle HorizontalAlign="Right" Font-Bold="True">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Grupo" FieldName="grupo" Name="grupo" VisibleIndex="2"
                                Width="60px" ReadOnly="True">
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
                                Width="60px" ReadOnly="True">
                                <PropertiesTextEdit Width="60px">
                                    <Style Font-Bold="True">
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="ID &gt;" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="M2 Total" FieldName="metragem_total" Name="metragem_total"
                                VisibleIndex="5" Width="60px">
                                <PropertiesTextEdit Width="100px">
                                    <Style Font-Bold="False" HorizontalAlign="Left">
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="M2 Total &gt;" ColumnSpan="2"
                                    Visible="True" />
                                <PropertiesTextEdit Width="100px">
                                    <Style Font-Bold="False" HorizontalAlign="Left"></Style>
                                </PropertiesTextEdit>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Valor 1" FieldName="valor_1" Name="valor_1"
                                Visible="False" VisibleIndex="10">
                                <PropertiesTextEdit Width="100px">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Valor 1 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Metragem 1" FieldName="metragem_1" Name="metragem_1"
                                Visible="False" VisibleIndex="11">
                                <PropertiesTextEdit Width="100px">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Metragem 1 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Inscr.Imobiliária 1" 
                                FieldName="inscricao_1" Name="inscricao_1"
                                Visible="False" VisibleIndex="12">
                                <EditFormSettings Caption="Inscr.Imobiliária 1 &gt;" ColumnSpan="2" 
                                    Visible="True" />
                                <EditCellStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn VisibleIndex="3" Caption="Unidade" 
                                FieldName="unidade" Name="unidade" ReadOnly="True" Width="80px">
                                <PropertiesTextEdit Width="60px">
                                    <Style Font-Bold="True">
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Unidade &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn VisibleIndex="4" Caption="Parte" FieldName="parte" 
                                Name="parte" Width="60px">
                                <PropertiesTextEdit Width="60px">
                                    <Style Font-Bold="True">
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Parte &gt;" CaptionLocation="Near" ColumnSpan="2" 
                                    Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Proprietário 1" FieldName="proprietario_1" 
                                Name="proprietario_1" VisibleIndex="7" Width="100px">
                                <PropertiesTextEdit Width="100px">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Proprietário 1 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataCheckColumn Caption="Quitado 1" FieldName="quitado_1" 
                                Name="quitado_1" ReadOnly="True" Visible="False" VisibleIndex="13">
                                <PropertiesCheckEdit>
                                    <Style HorizontalAlign="Left">
                                    </Style>
                                </PropertiesCheckEdit>
                                <EditFormSettings Caption="Quitado 1 &gt;" CaptionLocation="Near" 
                                    ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                            </dx3:GridViewDataCheckColumn>
                            <dx3:GridViewDataCheckColumn Caption="Escriturado 1" FieldName="escritura_1" 
                                Name="escritura_1" Visible="False" VisibleIndex="14">
                                <PropertiesCheckEdit>
                                    <Style HorizontalAlign="Left">
                                    </Style>
                                </PropertiesCheckEdit>
                                <EditFormSettings Caption="Escriturado 1 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                            </dx3:GridViewDataCheckColumn>
                            <dx3:GridViewDataDateColumn Caption="Data Escritura 1" FieldName="dtescritura_1"
                                Name="dtescritura_1" Visible="False" VisibleIndex="15">
                                <PropertiesDateEdit DisplayFormatString="" Width="100px">
                                </PropertiesDateEdit>
                                <EditFormSettings Caption="Data Escritura 1 &gt;" ColumnSpan="2" 
                                    Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                            </dx3:GridViewDataDateColumn>
                            <dx3:GridViewDataTextColumn Caption="Cartório 1" FieldName="cartorio_1" Name="cartorio_1"
                                Visible="False" VisibleIndex="16">
                                <EditFormSettings Caption="Cartório 1 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Livro 1" FieldName="livro_1" Name="livro_1"
                                Visible="False" VisibleIndex="17">
                                <EditFormSettings Caption="Livro 1 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Folha 1" FieldName="folha_1" Name="folha_1"
                                Visible="False" VisibleIndex="18">
                                <EditFormSettings Caption="Folha 1 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataCheckColumn Caption="Processo 1" FieldName="processo_1" 
                                Name="processo_1" Visible="False" VisibleIndex="19">
                                <PropertiesCheckEdit>
                                    <Style HorizontalAlign="Left">
                                    </Style>
                                </PropertiesCheckEdit>
                                <EditFormSettings Caption="Processo 1 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataCheckColumn>
                            <dx3:GridViewDataTextColumn Caption="Obs Processo 1" FieldName="obs_1" 
                                Name="obs_1" Visible="False" VisibleIndex="20">
                                <EditFormSettings Caption="Obs Processo 1 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Valor 2" FieldName="vlr_2" Name="vlr_2" 
                                Visible="False" VisibleIndex="21">
                                <PropertiesTextEdit Width="100px">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Valor 2 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Metragem 2" FieldName="metragem_2" 
                                Name="metragem_2" Visible="False" VisibleIndex="22">
                                <PropertiesTextEdit Width="100px">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Metragem 2 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Inscr.Imobiliária 2" 
                                FieldName="inscricao_2" Name="inscricao_2" Visible="False" 
                                VisibleIndex="23">
                                <EditFormSettings Caption="Inscr.Imobiliária 2 &gt;" ColumnSpan="2" 
                                    Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Proprietário 2" FieldName="proprietario_2" 
                                Name="proprietario_2" VisibleIndex="8" Width="100px">
                                <PropertiesTextEdit Width="100px">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Proprietário 2 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Cartório 2" FieldName="cartorio_2" 
                                Name="cartorio_2" Visible="False" VisibleIndex="27">
                                <EditFormSettings Caption="Cartório 2 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Livro 2" FieldName="livro_2" 
                                Name="livro_2" Visible="False" VisibleIndex="28">
                                <EditFormSettings Caption="Livro 2 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Folha 2" FieldName="folha_2" 
                                Name="folha_2" Visible="False" VisibleIndex="29">
                                <EditFormSettings Caption="Folha 2 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataCheckColumn Caption="Quitado 2" FieldName="quitado_2" 
                                Name="quitado_2" ReadOnly="True" Visible="False" VisibleIndex="24">
                                <PropertiesCheckEdit>
                                    <Style HorizontalAlign="Left">
                                    </Style>
                                </PropertiesCheckEdit>
                                <EditFormSettings Caption="Quitado 2 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataCheckColumn>
                            <dx3:GridViewDataCheckColumn Caption="Escriturado 2" FieldName="escritura_2" 
                                Name="escritura_2" Visible="False" VisibleIndex="25">
                                <PropertiesCheckEdit>
                                    <Style HorizontalAlign="Left">
                                    </Style>
                                </PropertiesCheckEdit>
                                <EditFormSettings Caption="Escriturado 2 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataCheckColumn>
                            <dx3:GridViewDataDateColumn Caption="Data Escritura 2" 
                                FieldName="dtescritura_2" Name="dtescritura_2" Visible="False" 
                                VisibleIndex="26">
                                <PropertiesDateEdit DisplayFormatString="" Width="100px">
                                </PropertiesDateEdit>
                                <EditFormSettings Caption="Data Escritura 2 &gt;" ColumnSpan="2" 
                                    Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataDateColumn>
                            <dx3:GridViewDataTextColumn Caption="Obs Processo 2" FieldName="obs_2" 
                                Name="obs_2" Visible="False" VisibleIndex="31">
                                <EditFormSettings Caption="Obs Processo 2 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataCheckColumn Caption="Processo 2" FieldName="processo_2" 
                                Name="processo_2" Visible="False" VisibleIndex="30">
                                <PropertiesCheckEdit>
                                    <Style HorizontalAlign="Left">
                                    </Style>
                                </PropertiesCheckEdit>
                                <EditFormSettings Caption="Processo 2 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataCheckColumn>
                            <dx3:GridViewDataTextColumn Caption="AP Terraço Coberto" 
                                FieldName="area_privativa_terraco_coberto_m2" 
                                Name="area_privativa_terraco_coberto_m2" VisibleIndex="33">
                                <EditFormSettings Caption="AP Terraço Coberto &gt;" ColumnSpan="2" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="AP Coletiva" 
                                FieldName="area_privativa_coletiva_m2" Name="area_privativa_coletiva_m2" 
                                VisibleIndex="32">
                                <EditFormSettings Caption="AP Coletiva &gt;" ColumnSpan="2" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="AP Terraço Descoberto" 
                                FieldName="area_privativa_terraco_descoberto_m2" 
                                Name="area_privativa_terraco_descoberto_m2" VisibleIndex="34">
                                <EditFormSettings Caption="AP Terraço Descoberto &gt;" ColumnSpan="2" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="AC Area Comum" FieldName="area_comum_m2" 
                                Name="area_comum_m2" VisibleIndex="35">
                                <EditFormSettings Caption="AC Area Comum &gt;" ColumnSpan="2" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="AG Area Garagem" 
                                FieldName="area_garagem_m2" Name="area_garagem_m2" VisibleIndex="36">
                                <EditFormSettings Caption="AG Area Garagem &gt;" ColumnSpan="2" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Área HobbyBox" 
                                FieldName="area_hobby_box_m2" Name="area_hobby_box_m2" VisibleIndex="37">
                                <EditFormSettings Caption="Área HobbyBox &gt;" ColumnSpan="2" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="AT" FieldName="area_total_m2" 
                                Name="area_total_m2" VisibleIndex="38">
                                <EditFormSettings Caption="AT &gt;" ColumnSpan="2" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Fração Ideal M2" 
                                FieldName="fracao_ideal_m2" Name="fracao_ideal_m2" VisibleIndex="39">
                                <EditFormSettings Caption="Fração Ideal M2 &gt;" ColumnSpan="2" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Fração Ideal %" 
                                FieldName="fracao_ideal_percentual" Name="fracao_ideal_percentual" 
                                VisibleIndex="40">
                                <EditFormSettings Caption="Fração Ideal % &gt;" ColumnSpan="2" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="HobbyBox Número" 
                                FieldName="hobby_box_numero" Name="hobby_box_numero" VisibleIndex="42">
                                <EditFormSettings Caption="HobbyBox Número &gt;" ColumnSpan="2" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="HobbyBox Local" 
                                FieldName="hobby_box_localizacao" Name="hobby_box_localizacao" 
                                VisibleIndex="41">
                                <EditFormSettings Caption="HobbyBox Local &gt;" ColumnSpan="2" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Garagem 01" FieldName="numero_garagem_01" 
                                Name="numero_garagem_01" VisibleIndex="43">
                                <EditFormSettings Caption="Num.Garagem 01 &gt;" ColumnSpan="2" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" HorizontalAlign="Right" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Garagem 02" FieldName="numero_garagem_02" 
                                Name="numero_garagem_02" VisibleIndex="44">
                                <EditFormSettings Caption="Num.Garagem 02 &gt;" ColumnSpan="2" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Garagem 03" FieldName="numero_garagem_03" 
                                Name="numero_garagem_03" VisibleIndex="45">
                                <EditFormSettings Caption="Num.Garagem 03 &gt;" ColumnSpan="2" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Garagem 04" FieldName="numero_garagem_04" 
                                Name="numero_garagem_04" VisibleIndex="46">
                                <EditFormSettings Caption="Num.Garagem 04 &gt;" ColumnSpan="2" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Garagem 05" FieldName="numero_garagem_05" 
                                Name="numero_garagem_05" VisibleIndex="47">
                                <EditFormSettings Caption="Num.Garagem 05 &gt;" ColumnSpan="2" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Vagas Local" FieldName="vagas_localizacao" 
                                Name="vagas_localizacao" VisibleIndex="48">
                                <EditFormSettings Caption="Vagas Localização" ColumnSpan="2" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Left">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Vagas Quant." FieldName="vagas_quantidade" 
                                Name="vagas_quantidade" VisibleIndex="49">
                                <EditFormSettings Caption="Vagas Quant. &gt;" ColumnSpan="2" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                        </Columns>
                        <SettingsPager Visible="False" PageSize="1000">
                            <AllButton ImagePosition="Bottom" Visible="True">
                            </AllButton>
                        </SettingsPager>
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

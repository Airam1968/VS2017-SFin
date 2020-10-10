<%@ Page Title="FClienteCadastro" Language="C#" AutoEventWireup="true" CodeFile="FClienteCadastro.aspx.cs"
    Inherits="FClienteCadastro" StylesheetTheme="Principal" %>

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
    <title>Gitano - Clientes - Cadastro</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <link href="../../content/toastr.css" rel="stylesheet" />
</head>
<body style="height: 1200px">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1200px">
        <ContentTemplate>
            <h1>
                CLIENTES - CADASTRO</h1>
            <h2>
                Manutenção de Clientes</h2>
            <div id="DivNova" style="border-style: none">
                <div style="border: 1px solid #808080; z-index: 2; left: 35px; top: 100px; position: absolute;
                    height: 50px; width: 832px; text-align: center;">
                    <asp:Label ID="Label3" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 15px; top: 15px;
                        position: absolute" Text="Selecione a Letra" Theme="PlasticBlue"></asp:Label>
                    <dx:ASPxComboBox ID="cbletra" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395"                        
                        Style="z-index: 2;
                        position: absolute; font-size: 10pt; top: 15px; left: 150px; right: 482px;" Width="200px"
                        Theme="PlasticBlue" AutoPostBack="True" OnSelectedIndexChanged="cbletra_SelectedIndexChanged">
                    </dx:ASPxComboBox>    
                    <dx:ASPxButton ID="bta" runat="server" Text="Aplicar Filtro" 
                        Style="z-index: 2; left: 400px; top: 15px; position: absolute; width: 95px;" 
                        Theme="PlasticBlue" ToolTip="Aplicar o Filtro Escolhido" 
                        onclick="bta_Click" Visible="False">
                    </dx:ASPxButton>
                </div>
                <div style="border: 1px solid #808080; z-index: 1; left: 35px; top: 160px; position: absolute;
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
                            CommandUpdate="Altera" ConfirmDelete="Apagar o Registro, Confirma?" PopupEditFormCaption="Manutenção de Cadastro de Clientes"
                            Title="Verificar" />
                        <SettingsLoadingPanel ImagePosition="Top" Text="Carregando&amp;hellip;" />
                        <SettingsDetail AllowOnlyOneMasterRowExpanded="True" />
                        <BackgroundImage HorizontalPosition="center" />
                        <Columns>
                            <dx3:GridViewCommandColumn ButtonType="Image" Caption=" Ação" ToolTip="Ações de Manutenção da Tabela"
                                VisibleIndex="6">
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
                            <dx3:GridViewDataTextColumn FieldName="apelido" VisibleIndex="1" Width="150px" Caption="Apelido"
                                Name="apelido">
                                <%-- SortIndex="0" SortOrder="Ascending">--%>
                                <EditFormSettings Caption="Apelido &gt;" ColumnSpan="1" />
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
                            <dx3:GridViewDataTextColumn Caption="Nome" FieldName="nome" Name="Nome" VisibleIndex="2"
                                Width="310px">
                                <EditFormSettings Caption="Nome &gt;" CaptionLocation="Near" ColumnSpan="4" Visible="True" />
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
                            <dx3:GridViewDataTextColumn Caption="CPF\CNPJ" FieldName="cnpj" Name="cnpj" VisibleIndex="4"
                                Width="150px">
                                <PropertiesTextEdit MaxLength="18">
                                    <MaskSettings IncludeLiterals="None" Mask="99.999.999/9999-99" />
                                    <ValidationSettings>
                                        <RequiredField ErrorText="Preenchimento Obrigatório!" IsRequired="True" />
                                    </ValidationSettings>
                                    <Style HorizontalAlign="Left"></Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="CPF\CNPJ &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="ID" FieldName="ID" Name="ID" VisibleIndex="0"
                                Width="40px" ReadOnly="True">
                                <PropertiesTextEdit Width="60px">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="ID &gt;" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <HeaderStyle Font-Bold="True" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataCheckColumn Caption="Ativo" FieldName="ativo" Name="Ativo" VisibleIndex="5"
                                Width="50px">
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
                            <dx3:GridViewDataTextColumn Caption="Inscr.Municipal" FieldName="inscmunicipal" Name="inscmunicipal"
                                Visible="False" VisibleIndex="7">
                                <PropertiesTextEdit MaxLength="20">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Inscr.Municipal &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Inscr.Estadual" FieldName="inscestadual" Name="inscestadual"
                                Visible="False" VisibleIndex="8">
                                <PropertiesTextEdit MaxLength="20">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Inscr.Estadual &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Reg.Junta Comercial" FieldName="regjuntacom"
                                Name="regjuntacom" Visible="False" VisibleIndex="9">
                                <PropertiesTextEdit MaxLength="15">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Reg.Junta Comercial &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Nire" FieldName="nire" Name="nire" Visible="False"
                                VisibleIndex="10">
                                <PropertiesTextEdit MaxLength="15">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Nire &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Endereço Comercial" FieldName="enderecocom"
                                Name="enderecocom" Visible="False" VisibleIndex="26">
                                <PropertiesTextEdit MaxLength="70">
                                    <Style Font-Bold="False" HorizontalAlign="Left">
                                        
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Endereço Comercial &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Número" FieldName="enderecocomnumero" Name="enderecocomnumero"
                                Visible="False" VisibleIndex="27">
                                <PropertiesTextEdit MaxLength="30">
                                    <Style Font-Bold="False" HorizontalAlign="Left">
                                        
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Número &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Complemento" FieldName="enderecocomcomplem"
                                Name="enderecocomcomplem" Visible="False" VisibleIndex="28">
                                <PropertiesTextEdit MaxLength="30">
                                    <Style Font-Bold="False" HorizontalAlign="Left">
                                        
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Complemento &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Bairro" FieldName="bairrocom" Name="bairrocom"
                                Visible="False" VisibleIndex="29">
                                <PropertiesTextEdit MaxLength="20">
                                    <Style Font-Bold="False" HorizontalAlign="Left">
                                        
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Bairro &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Cidade" FieldName="cidadecom" Name="cidadecom"
                                Visible="False" VisibleIndex="30">
                                <PropertiesTextEdit MaxLength="20">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Cidade &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="UF" FieldName="ufcom" Name="ufcom" Visible="False"
                                VisibleIndex="31" Width="100px">
                                <PropertiesTextEdit MaxLength="2" Width="50px">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="UF &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="CEP" FieldName="cepcom" Name="cepcom" Visible="False"
                                VisibleIndex="32" Width="100px">
                                <PropertiesTextEdit MaxLength="8" Width="100px">
                                    <MaskSettings IncludeLiterals="None" Mask="99999-999" />
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="CEP &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Telefone 1" FieldName="fone1com" Name="fone1com"
                                Visible="False" VisibleIndex="33">
                                <PropertiesTextEdit MaxLength="30">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Telefone Com 1 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Telefone 2" FieldName="fone2com" Name="fone2com"
                                Visible="False" VisibleIndex="34">
                                <PropertiesTextEdit MaxLength="30">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Telefone Com 2 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Telefone 3" FieldName="fone3com" Name="fone3com"
                                Visible="False" VisibleIndex="35">
                                <PropertiesTextEdit MaxLength="30">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Telefone Com 3 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="E-Mail 1" FieldName="email1" Name="email1" Visible="False"
                                VisibleIndex="36">
                                <PropertiesTextEdit MaxLength="50">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="E-Mail 1 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="E-Mail 2" FieldName="email2" Name="email2" Visible="False"
                                VisibleIndex="37">
                                <PropertiesTextEdit MaxLength="50">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="E-Mail 2 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="E-Mail 3" FieldName="email3" Name="email3" Visible="False"
                                VisibleIndex="38">
                                <PropertiesTextEdit MaxLength="50">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="E-Mail 3 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="E-Mail 4" FieldName="email4" Name="email4" Visible="False"
                                VisibleIndex="39">
                                <PropertiesTextEdit MaxLength="50">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="E-Mail 4 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="E-Mail 5" FieldName="email5" Name="email5" Visible="False"
                                VisibleIndex="40">
                                <PropertiesTextEdit MaxLength="50">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="E-Mail 5 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Gerente" FieldName="gerente" Name="gerente"
                                Visible="False" VisibleIndex="41">
                                <PropertiesTextEdit MaxLength="10">
                                    <ValidationSettings>
                                        <RequiredField ErrorText="Preenchimento Obrigatório!" IsRequired="True" />
                                    </ValidationSettings>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Gerente &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Contato" FieldName="contato" Name="contato"
                                Visible="False" VisibleIndex="42">
                                <PropertiesTextEdit MaxLength="20">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Contato &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataDateColumn Caption="Nascimento" FieldName="dtnascimento" Name="dtnascimento"
                                Visible="False" VisibleIndex="43" Width="150px">
                                <PropertiesDateEdit DisplayFormatString="" Width="100px">
                                    <ValidationSettings>
                                        <RequiredField ErrorText="Preenchimento Obrigatório!" IsRequired="True" />
                                    </ValidationSettings>
                                </PropertiesDateEdit>
                                <EditFormSettings Caption="Nascimento &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataDateColumn>
                            <dx3:GridViewDataTextColumn Caption="No. Contrato" FieldName="ncontrato" Name="ncontrato"
                                Visible="False" VisibleIndex="45">
                                <PropertiesTextEdit MaxLength="10">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="No. Contrato &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataDateColumn Caption="Data Contrato" FieldName="dtcontrato" Name="dtcontrato"
                                Visible="False" VisibleIndex="46" Width="150px">
                                <PropertiesDateEdit DisplayFormatString="" Width="100px">
                                </PropertiesDateEdit>
                                <EditFormSettings Caption="Data Contrato &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataDateColumn>
                            <dx3:GridViewDataDateColumn Caption="Cadastro" FieldName="dtingresso" Name="dtingresso"
                                Visible="False" VisibleIndex="44" Width="150px">
                                <PropertiesDateEdit DisplayFormatString="" Width="100px">
                                    <ValidationSettings>
                                        <RequiredField ErrorText="Preenchimento Obrigatório!" IsRequired="True" />
                                    </ValidationSettings>
                                </PropertiesDateEdit>
                                <EditFormSettings Caption="Cadastro &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataDateColumn>
                            <dx3:GridViewDataCheckColumn Caption="Acesso á Internet" FieldName="acessointernet"
                                Name="acessointernet" Visible="False" VisibleIndex="47">
                                <PropertiesCheckEdit DisplayTextChecked="Marcado" DisplayTextUnchecked="Desmarcado">
                                    <ValidationSettings>
                                        <RequiredField ErrorText="Preenchimento Obrigatório!" IsRequired="True" />
                                    </ValidationSettings>
                                </PropertiesCheckEdit>
                                <EditFormSettings Caption="Acesso á Internet" Visible="True" />
                                <EditCellStyle HorizontalAlign="Left">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <CellStyle HorizontalAlign="Center">
                                </CellStyle>
                            </dx3:GridViewDataCheckColumn>
                            <dx3:GridViewDataTextColumn Caption="Obs" FieldName="obs1" Name="obs1" Visible="False"
                                VisibleIndex="51">
                                <PropertiesTextEdit MaxLength="80">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Obs &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Obs" FieldName="obs2" Name="obs2" Visible="False"
                                VisibleIndex="52">
                                <PropertiesTextEdit MaxLength="80">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Obs &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Obs" FieldName="obs3" Name="obs3" Visible="False"
                                VisibleIndex="53">
                                <PropertiesTextEdit MaxLength="80">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Obs &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Obs" FieldName="obs4" Name="obs4" Visible="False"
                                VisibleIndex="54">
                                <PropertiesTextEdit MaxLength="80">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Obs &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Obs" FieldName="obs5" Name="obs5" Visible="False"
                                VisibleIndex="55">
                                <PropertiesTextEdit MaxLength="80">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Obs &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="1a. Instrução de Cobrança" FieldName="instrcob1"
                                Name="instrcob1" Visible="False" VisibleIndex="69" Width="100px">
                                <PropertiesTextEdit MaxLength="2" Width="50px">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="1a. Instrução de Cobrança &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="2a. Instrução de Cobrança" FieldName="instrcob2"
                                Name="instrcob2" Visible="False" VisibleIndex="70" Width="100px">
                                <PropertiesTextEdit MaxLength="2" Width="50px">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="2a. Instrução de Cobrança &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Dias Protesto" FieldName="diasprotesto" Name="diasprotesto"
                                Visible="False" VisibleIndex="71" Width="100px">
                                <PropertiesTextEdit MaxLength="2" Width="50px">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Dias Protesto &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Conta 1" FieldName="conta1" Name="conta1" Visible="False"
                                VisibleIndex="72" Width="150px">
                                <PropertiesTextEdit MaxLength="18">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Conta 1 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Conta 2" FieldName="conta2" Name="conta2" Visible="False"
                                VisibleIndex="73" Width="150px">
                                <PropertiesTextEdit MaxLength="18">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Conta 2 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Conta 3" FieldName="conta3" Name="conta3" Visible="False"
                                VisibleIndex="74" Width="150px">
                                <PropertiesTextEdit MaxLength="18">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Conta 3 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Conta 4" FieldName="conta4" Name="conta4" Visible="False"
                                VisibleIndex="75" Width="150px">
                                <PropertiesTextEdit MaxLength="18">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Conta 4 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Conta 5" FieldName="conta5" Name="conta5" Visible="False"
                                VisibleIndex="76" Width="150px">
                                <PropertiesTextEdit MaxLength="18">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Conta 5 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Sexo" FieldName="sexo" Name="sexo" Visible="False"
                                VisibleIndex="3">
                                <PropertiesTextEdit MaxLength="1" Width="50px">
                                    <ValidationSettings>
                                        <RequiredField ErrorText="Preenchimento Obrigatório!" IsRequired="True" />
                                    </ValidationSettings>
                                    <Style Font-Bold="False" HorizontalAlign="Left">                                       
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Sexo (M-F-O)&gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="RG" FieldName="rg" Name="rg" Visible="False"
                                VisibleIndex="11">
                                <PropertiesTextEdit MaxLength="18">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="RG &gt;" ColumnSpan="2" Visible="True" />
                                <EditCellStyle Font-Bold="False">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="RG UF" FieldName="rguf" Name="rguf" Visible="False"
                                VisibleIndex="12">
                                <PropertiesTextEdit MaxLength="2" Width="50px">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="RG UF &gt;" ColumnSpan="2" Visible="True" />
                                <EditCellStyle Font-Bold="False">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Emissor UF" FieldName="rgemissor" Name="rgemissor"
                                Visible="False" VisibleIndex="13">
                                <PropertiesTextEdit MaxLength="20">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Emissor UF &gt;" ColumnSpan="2" Visible="True" />
                                <EditCellStyle Font-Bold="False">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataDateColumn Caption="Emissão UF" FieldName="rgemissao" Name="rgemissao"
                                Visible="False" VisibleIndex="14">
                                <PropertiesDateEdit DisplayFormatString="" Width="100px">
                                </PropertiesDateEdit>
                                <EditFormSettings Caption="Emissão UF &gt;" ColumnSpan="2" Visible="True" />
                                <EditCellStyle Font-Bold="False">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataDateColumn>
                            <dx3:GridViewDataTextColumn Caption="Endereço (R ou C)" FieldName="endereco" Name="endereco"
                                Visible="False" VisibleIndex="15">
                                <PropertiesTextEdit MaxLength="1" Width="50px">
                                    <Style Font-Bold="False" HorizontalAlign="Left">
                                        
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Endereço (R - C) &gt;" ColumnSpan="2" Visible="True" />
                                <EditCellStyle Font-Bold="False">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Endereço Residencial" FieldName="enderecores"
                                Name="enderecores" Visible="False" VisibleIndex="16">
                                <PropertiesTextEdit MaxLength="70">
                                    <Style Font-Bold="False" HorizontalAlign="Left">
                                        
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Endereço Residencial &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Número" FieldName="enderecoresnumero" Name="enderecoresnumero"
                                Visible="False" VisibleIndex="17">
                                <PropertiesTextEdit MaxLength="30">
                                    <Style Font-Bold="False" HorizontalAlign="Left">
                                        
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Número &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Complemento" FieldName="enderecorescomplem"
                                Name="enderecorescomplem" Visible="False" VisibleIndex="18">
                                <PropertiesTextEdit MaxLength="30">
                                    <Style Font-Bold="False" HorizontalAlign="Left">
                                        
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Complemento &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Bairro" FieldName="bairrores" Name="bairrores"
                                Visible="False" VisibleIndex="19">
                                <PropertiesTextEdit MaxLength="30">
                                    <Style Font-Bold="False" HorizontalAlign="Left">
                                        
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Bairro &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Cidade" FieldName="cidaderes" Name="cidaderes"
                                Visible="False" VisibleIndex="20">
                                <PropertiesTextEdit MaxLength="30">
                                    <Style Font-Bold="False" HorizontalAlign="Left">
                                        
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Cidade &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="UF" FieldName="ufres" Name="ufres" Visible="False"
                                VisibleIndex="21">
                                <PropertiesTextEdit MaxLength="2" Width="50px">
                                    <Style Font-Bold="False" HorizontalAlign="Left">
                                        
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="UF &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="CEP" FieldName="cepres" Name="cepres" Visible="False"
                                VisibleIndex="22">
                                <PropertiesTextEdit MaxLength="8" Width="100px">
                                    <MaskSettings IncludeLiterals="None" Mask="99999-999" />
                                    <Style Font-Bold="False" HorizontalAlign="Left">
                                        
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="CEP &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Telefone 1" FieldName="fone1res" Name="fone1res"
                                Visible="False" VisibleIndex="23">
                                <PropertiesTextEdit MaxLength="30">
                                    <Style Font-Bold="False" HorizontalAlign="Left">
                                        
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Telefone Res 1 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Telefone 2" FieldName="fone2res" Name="fone2res"
                                Visible="False" VisibleIndex="24">
                                <PropertiesTextEdit MaxLength="30">
                                    <Style Font-Bold="False" HorizontalAlign="Left">
                                        
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Telefone Res 2 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Telefone 3" FieldName="fone3res" Name="fone3res"
                                Visible="False" VisibleIndex="25">
                                <PropertiesTextEdit MaxLength="30">
                                    <Style Font-Bold="False" HorizontalAlign="Left">
                                        
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Telefone Res 3 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Empregador" FieldName="empregador" Name="empregador"
                                Visible="False" VisibleIndex="48">
                                <PropertiesTextEdit MaxLength="50">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Empregador &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Cargo" FieldName="cargo" Name="cargo" Visible="False"
                                VisibleIndex="49">
                                <PropertiesTextEdit MaxLength="50">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Cargo &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Atividade\Profissão" FieldName="atividade" Name="atividade"
                                Visible="False" VisibleIndex="50">
                                <PropertiesTextEdit MaxLength="50">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Atividade\Profissão &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Conjuge" FieldName="conjugenome" Name="conjugenome"
                                Visible="False" VisibleIndex="56">
                                <PropertiesTextEdit MaxLength="50">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Conjuge &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Sexo" FieldName="conjugesexo" Name="conjugesexo"
                                Visible="False" VisibleIndex="57">
                                <PropertiesTextEdit MaxLength="1" Width="50px">
                                    <Style HorizontalAlign="Left">
                                        
                                    </Style>
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Sexo (M-F-O)&gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="CPF" FieldName="conjugecnpj" Name="conjugecnpj"
                                Visible="False" VisibleIndex="58">
                                <PropertiesTextEdit MaxLength="18">
                                    <MaskSettings IncludeLiterals="None" Mask="999.999.999-99" />
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="CPF &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="RG" FieldName="conjugerg" Name="conjugerg" Visible="False"
                                VisibleIndex="59">
                                <PropertiesTextEdit MaxLength="18">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="RG &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="RG UF" FieldName="conjugerguf" Name="conjugerguf"
                                Visible="False" VisibleIndex="60">
                                <PropertiesTextEdit MaxLength="2" Width="50px">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="RG UF &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="RG Emissor" FieldName="conjugergemissor" Name="conjugergemissor"
                                Visible="False" VisibleIndex="61">
                                <PropertiesTextEdit MaxLength="20">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="RG Emissor &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataDateColumn Caption="RG Emissão" FieldName="conjugergemissao" Name="conjugergemissao"
                                Visible="False" VisibleIndex="62">
                                <PropertiesDateEdit DisplayFormatString="" Width="100px">
                                </PropertiesDateEdit>
                                <EditFormSettings Caption="RG Emissão &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataDateColumn>
                            <dx3:GridViewDataDateColumn Caption="Nascimento" FieldName="dtnascimentoconjuge"
                                Name="dtnascimentoconjuge" Visible="False" VisibleIndex="63">
                                <PropertiesDateEdit DisplayFormatString="" Width="100px">
                                </PropertiesDateEdit>
                                <EditFormSettings Caption="Nascimento &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataDateColumn>
                            <dx3:GridViewDataTextColumn Caption="Telefone 1" FieldName="fone1con" Name="fone1con"
                                Visible="False" VisibleIndex="64">
                                <PropertiesTextEdit MaxLength="30">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Telefone Con 1 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Telefone 2" FieldName="fone2con" Name="fone2con"
                                Visible="False" VisibleIndex="65">
                                <PropertiesTextEdit MaxLength="30">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Telefone Con 2 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Telefone 3" FieldName="fone3con" Name="fone3con"
                                Visible="False" VisibleIndex="66">
                                <PropertiesTextEdit MaxLength="30">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="Telefone Con 3 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="E-Mail 1" FieldName="conjugeemail1" Name="conjugeemail1"
                                Visible="False" VisibleIndex="67">
                                <PropertiesTextEdit MaxLength="50">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="E-Mail 1 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="E-Mail 2" FieldName="conjugeemail2" Name="conjugeemail2"
                                Visible="False" VisibleIndex="68">
                                <PropertiesTextEdit MaxLength="50">
                                </PropertiesTextEdit>
                                <EditFormSettings Caption="E-Mail 2 &gt;" ColumnSpan="2" Visible="True" />
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataCheckColumn Caption="DDA" FieldName="dda" 
                                Name="dda" Visible="False" VisibleIndex="77">
                                <PropertiesCheckEdit DisplayTextChecked="Marcado" DisplayTextUnchecked="Desmarcado">
                                </PropertiesCheckEdit>
                                <EditFormSettings Caption="DDA &gt;" Visible="True" />
                                <EditCellStyle HorizontalAlign="Left">
                                </EditCellStyle>
                                <EditFormCaptionStyle Font-Bold="True" HorizontalAlign="Right">
                                </EditFormCaptionStyle>
                                <CellStyle HorizontalAlign="Center">
                                </CellStyle>
                            </dx3:GridViewDataCheckColumn>                          
                        </Columns>
                        <SettingsPager Visible="False" PageSize="100000">
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

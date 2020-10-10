<%@ Page Title="FMigracoesSimbolo" Language="C#" AutoEventWireup="true" CodeFile="FMigracoesSimbolo.aspx.cs"
    Inherits="FMigracoesSimbolo" StylesheetTheme="Principal" %>

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
    <title>Gitano - Config - Migrações - Símbolo</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <link href="../../content/toastr.css" rel="stylesheet" />
</head>
<body style="height: 1200px">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1200px">
        <ContentTemplate>
            <h1>
                CONFIG - MIGRAÇÕES - SÍMBOLO</h1>
            <h2>
                Migração dados Sistema Símbolo</h2>
            <div id="DivNova" style="border-style: none">
                <div style="border: 1px solid #808080; z-index: 1; left: 45px; top: 65px; position: absolute;
                    height: 650px; width: 400px">
                    <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px;
                        position: absolute" Text="Tabelas Sistema Símbolo"></asp:Label>
                    <asp:Label ID="Label3" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 15px;
                        position: absolute" Text="Gerais"></asp:Label>
                    <asp:CheckBox ID="ckempresa" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 30px; left: 10px;" Text="Empresa" Width="150px" />
                    <asp:CheckBox ID="ckparametros" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 45px; left: 10px;" Text="Parâmetros"
                        Width="150px" />
                    <asp:CheckBox ID="ckusuariopermissoes" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 60px; left: 10px;" Text="Usuários e Permissões"
                        Width="150px" />
                    <asp:CheckBox ID="ckclientes" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 75px; left: 10px;" Text="Clientes"
                        Width="150px" />
                    <asp:Label ID="Label2" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 100px;
                        position: absolute" Text="Produto"></asp:Label>
                    <asp:CheckBox ID="ckproduto" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 115px; left: 10px;" Text="Produtos"
                        Width="150px" />
                    <asp:CheckBox ID="ckprodutotipo" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 130px; left: 10px;" Text="Tipo Produto"
                        Width="150px" />
                    <asp:CheckBox ID="ckprodutogrupo1" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 145px; left: 10px;" Text="Grupo Tipo 1"
                        Width="150px" />
                    <asp:CheckBox ID="ckprodutogrupo2" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 160px; left: 10px;" Text="Grupo Tipo 2"
                        Width="150px" />
                    <asp:CheckBox ID="ckindexadores" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 175px; left: 10px;" Text="Indexadores"
                        Width="150px" />
                    <asp:CheckBox ID="cktaxasdiarias" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 190px; left: 10px;" Text="Taxas Diárias"
                        Width="150px" />
                    <asp:CheckBox ID="cktaxasmensais" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 205px; left: 10px;" Text="Taxas Mensais"
                        Width="150px" />
                    <asp:CheckBox ID="ckmensagensboleto" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 220px; left: 10px;" Text="Mensagens Boleto"
                        Width="150px" />
                    <asp:CheckBox ID="ckcorretores" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 235px; left: 10px;" Text="Corretores"
                        Width="150px" />
                    <asp:Label ID="Label4" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 260px;
                        position: absolute" Text="Contas a Pagar"></asp:Label>
                    <asp:CheckBox ID="ckdespesas" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 275px; left: 10px; bottom: 105px;"
                        Text="Classificação de Despesas" Width="200px" />
                    <asp:CheckBox ID="ckfornecedores" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 290px; left: 10px;" Text="Fornecedores"
                        Width="150px" />
                    <asp:Label ID="Label5" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 315px;
                        position: absolute" Text="Contas a Receber"></asp:Label>
                    <asp:CheckBox ID="ckreceitas" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 330px; left: 10px; bottom: 105px;"
                        Text="Classificação de Receitas" Width="200px" />
                    <asp:CheckBox ID="ckclientescontaareceber" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 345px; left: 10px;" Text="Clientes"
                        Width="150px" />
                    <asp:Label ID="Label6" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 370px;
                        position: absolute" Text="Bancos"></asp:Label>
                    <asp:CheckBox ID="ckbancos" runat="server" AutoPostBack="True" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt;
                        top: 385px; left: 10px; bottom: 105px;" Text="Bancos" Width="200px" />
                    <asp:CheckBox ID="ckcontascorrentes" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 400px; left: 10px;" Text="Contas Correntes"
                        Width="150px" />
                    <asp:CheckBox ID="cksaldoinicial" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 415px; left: 10px;" Text="Saldos Iniciais"
                        Width="150px" />
                    <asp:Label ID="Label9" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 440px;
                        position: absolute" Text="Lançamentos CR\CP"></asp:Label>
                    <asp:CheckBox ID="cklancamentoscontasareceber" runat="server" AutoPostBack="True"
                        Font-Bold="True" Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 455px; left: 10px; bottom: 105px;"
                        Text="Contas a Receber" Width="200px" />
                    <asp:CheckBox ID="cklancamentoscontasapagar" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 470px; left: 10px;" Text="Contas a Pagar"
                        Width="150px" />
                    <asp:Label ID="Label10" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 495px;
                        position: absolute" Text="Parcelas"></asp:Label>
                    <asp:CheckBox ID="ckunidades" runat="server" AutoPostBack="True"
                        Font-Bold="True" Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 510px; left: 10px; bottom: 105px;"
                        Text="Unidades" Width="200px" />
                    <asp:CheckBox ID="ckvendas" runat="server" AutoPostBack="True"
                        Font-Bold="True" Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 525px; left: 10px; bottom: 105px;"
                        Text="Vendas" Width="200px" />
                    <asp:CheckBox ID="ckparcelas" runat="server" AutoPostBack="True"
                        Font-Bold="True" Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 540px; left: 10px; bottom: 105px;"
                        Text="Parcelas" Width="200px" />
                    <asp:Label ID="Label11" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 565px;
                        position: absolute" Text="Log"></asp:Label>
                    <asp:CheckBox ID="cklog" runat="server" AutoPostBack="True"
                        Font-Bold="True" Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 580px; left: 10px; bottom: 105px;"
                        Text="Log Segurança" Width="200px" />
                    <asp:Label ID="Label12" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 605px;
                        position: absolute" Text="Diversos"></asp:Label>
                    <asp:CheckBox ID="ckcartas" runat="server" AutoPostBack="True"
                        Font-Bold="True" Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 620px; left: 10px; bottom: 105px;"
                        Text="Cartas Modelo" Width="200px" />
                </div>
                <div style="z-index: 1; border-style: none; left: 460px; top: 65px; position: absolute;
                    height: 500px; width: 400px">
                    <div>
                        <div runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute;
                            top: 10px; left: 10px; height: 50px; width: 378px;" id="Div1">
                            <asp:Label ID="Label7" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px;
                                position: absolute" Text="Diretório Arquivos DBF"></asp:Label>
                            <dx:ASPxTextBox ID="edpastaDBF" runat="server" ValueType="System.String" BackColor="#E1E6F2"
                                DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" EditFormatString="dd/MM/yyyy"
                                EnableTheming="True" Font-Bold="False" Font-Names="Calibri" Font-Size="15px"
                                ForeColor="#3E5395" Height="16px" Theme="PlasticBlue" UseMaskBehavior="True"
                                Width="300px" Style="z-index: 2; position: absolute; margin-right: 5px; top: 15px;
                                left: 13px;" ToolTip="Pasta para coleta dos arquivo DBF á Migrar" Text="~\Arquivos\Migracao\SimboloDBF\"
                                Enabled="False">
                            </dx:ASPxTextBox>
                        </div>
                        <div runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute;
                            top: 70px; left: 10px; height: 50px; width: 378px;" id="Div2">
                            <dx:ASPxButton ID="btmarcar" runat="server" Height="40px" Width="45px" ImagePosition="Left"
                                OnClick="btmarcar_Click">
                                <Image Height="30px" ToolTip="Marcar Todos" Url="~/images/BotoesTelas/BTNsalvarA.bmp"
                                    UrlDisabled="~/images/BotoesTelas/BTNsalvarI.bmp" UrlPressed="~/images/BotoesTelas/BTNsalvarS.bmp"
                                    Width="30px">
                                </Image>
                            </dx:ASPxButton>
                            <dx:ASPxButton ID="btdesmarcar" runat="server" Height="40px" Width="45px" ImagePosition="Left"
                                OnClick="btdesmarcar_Click">
                                <Image Height="30px" ToolTip="Desmarcar Todos" Url="~/images/BotoesTelas/BTNcancelarA.bmp"
                                    UrlDisabled="~/images/BotoesTelas/BTNcancelarI.bmp" UrlPressed="~/images/BotoesTelas/BTNcancelarS.bmp"
                                    Width="30px">
                                </Image>
                            </dx:ASPxButton>
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
                        </div>
                        <div runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute;
                            top: 130px; left: 10px; height: 355px; width: 378px;" id="Div3">
                            <asp:Label ID="Label8" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px;
                                position: absolute" Text="Registros da Atividade"></asp:Label>
                            <div>
                            </div>
                            <div runat="server" style="position: absolute; top: 10px; left: 10px; height: 330px; width: 370px;"
                             id="Div5">
                                <dx:ASPxMemo ID="MemoAtividades" runat="server" Height="320px" Width="360px" 
                                    AutoPostBack="True">
                                </dx:ASPxMemo>
                            </div>
                        </div>
                    </div>
                    <div runat="server" style="z-index: 2; position: absolute; top: 600px; left: 10px;
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
                                        Migração de Dados Sistema Origem SIMBOLO.<br />
                                        <br />
                                        O Processo migra dos dados das base DBF Simbolo, para base SQL Gitano Software.<br />
                                        <br />
                                        O Processo de migração de dados pressupõe que o operador tenha conheçimento da sequência e ordem em que os dados devem ser migrados, a sequência informada na tela deve ser respeitada, sob pena da migração não ser bem sucedida ao seu final.<br />
                                        <br />
                                        O Sistema espera encontrar os arquivos DBF no diretório <..\Arquivos\Migracao\SimboloDBF>.<br />
                                        <br />
                                        Caso tenha dúvidas, procure o suporte ou a orientação necessária.<br />
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

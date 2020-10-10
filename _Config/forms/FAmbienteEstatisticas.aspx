<%@ Page Title="FAmbienteEstatisticas" Language="C#" AutoEventWireup="true" CodeFile="FAmbienteEstatisticas.aspx.cs"
    Inherits="FAmbienteEstatisticas" StylesheetTheme="Principal" %>

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
    <title>Gitano - Config - Ambiente - Estatísticas</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <link href="../../content/toastr.css" rel="stylesheet" />
</head>
<body style="height: 1200px">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1200px">
        <ContentTemplate>
            <h1>
                CONFIG - AMBIENTE - ESTATÍSTICAS</h1>
            <h2>
                Estatísticas de Ambiente do Sistema</h2>
            <div id="DivNova" style="border-style: none">
                <div style="border: 1px solid #808080; z-index: 1; left: 45px; top: 65px; position: absolute;
                    height: 500px; width: 400px">
                    <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px;
                        position: absolute" Text="Quantitativo"></asp:Label>
                    <asp:Label ID="Label3" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 15px;
                        position: absolute" Text="Geral"></asp:Label>
                    <asp:Label ID="Label7" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 220px; top: 15px;
                        position: absolute" Text="Total Registros"></asp:Label>
                    <asp:CheckBox ID="ckempresa" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 30px; left: 10px;" Text="Empresa" Width="150px" />
                    <dx:ASPxLabel ID="lbempresa" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 230px; top: 30px;
                        position: absolute" Text="0" Width="80px"></dx:ASPxLabel>
                    <asp:CheckBox ID="ckparametros" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 45px; left: 10px;" Text="Parâmetros"
                        Width="150px" />
                    <asp:Label ID="lbparametros" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 230px; top: 45px;
                        position: absolute" Text="0" Width="80px"></asp:Label>
                    <asp:CheckBox ID="ckusuariopermissoes" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 60px; left: 10px;" Text="Usuários e Permissões"
                        Width="150px" />
                    <asp:Label ID="lbusuariopermissoes" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 230px; top: 60px; position: absolute" Text="0" Width="80px"></asp:Label>
                    <asp:CheckBox ID="ckclientes" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 75px; left: 10px;" Text="Clientes"
                        Width="150px" />
                    <asp:Label ID="lbclientes" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 230px; top: 75px;
                        position: absolute" Text="0" Width="80px"></asp:Label>
                    <asp:Label ID="Label2" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 100px;
                        position: absolute" Text="Produto"></asp:Label>
                    <asp:CheckBox ID="ckproduto" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 115px; left: 10px;" Text="Produtos"
                        Width="150px" />
                    <asp:Label ID="lbproduto" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 230px; top: 115px;
                        position: absolute" Text="0" Width="80px"></asp:Label>
                    <asp:CheckBox ID="ckprodutotipo" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 130px; left: 10px;" Text="Tipo Produto"
                        Width="150px" />
                    <asp:Label ID="lbprodutotipo" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 230px; top: 130px; position: absolute" Text="0" Width="80px"></asp:Label>
                    <asp:CheckBox ID="ckprodutogrupo1" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 145px; left: 10px;" Text="Grupo Tipo 1"
                        Width="150px" />
                    <asp:Label ID="lbprodutogrupo1" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 230px; top: 145px; position: absolute" Text="0" Width="80px"></asp:Label>
                    <asp:CheckBox ID="ckprodutogrupo2" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 160px; left: 10px;" Text="Grupo Tipo 2"
                        Width="150px" />
                    <asp:Label ID="lbprodutogrupo2" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 230px; top: 160px; position: absolute" Text="0" Width="80px"></asp:Label>
                    <asp:CheckBox ID="ckindexadores" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 175px; left: 10px;" Text="Indexadores"
                        Width="150px" />
                    <asp:Label ID="lbindexadores" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 230px; top: 175px; position: absolute" Text="0" Width="80px"></asp:Label>
                    <asp:CheckBox ID="cktaxasdiarias" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 190px; left: 10px;" Text="Taxas Diárias"
                        Width="150px" />
                    <asp:Label ID="lbtaxasdiarias" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 230px; top: 190px; position: absolute" Text="0" Width="80px"></asp:Label>
                    <asp:CheckBox ID="cktaxasmensais" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 205px; left: 10px;" Text="Taxas Mensais"
                        Width="150px" />
                    <asp:Label ID="lbtaxasmensais" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 230px; top: 205px; position: absolute" Text="0" Width="80px"></asp:Label>
                    <asp:CheckBox ID="ckmensagensboleto" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 220px; left: 10px;" Text="Mensagens Boleto"
                        Width="150px" />
                    <asp:Label ID="lbmensagensboleto" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 230px; top: 220px; position: absolute" Text="0" Width="80px"></asp:Label>
                    <asp:CheckBox ID="ckcorretores" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 235px; left: 10px;" Text="Corretores"
                        Width="150px" />
                    <asp:Label ID="lbcorretores" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 230px; top: 235px;
                        position: absolute" Text="0" Width="80px"></asp:Label>
                    <asp:Label ID="Label4" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 260px;
                        position: absolute" Text="Contas a Pagar"></asp:Label>
                    <asp:CheckBox ID="ckdespesas" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 275px; left: 10px;"
                        Text="Classificação de Despesas" Width="200px" />
                    <asp:Label ID="lbdespesas" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 230px; top: 275px;
                        position: absolute" Text="0" Width="80px"></asp:Label>
                    <asp:CheckBox ID="ckfornecedores" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 290px; left: 10px;" Text="Fornecedores"
                        Width="150px" />
                    <asp:Label ID="lbfornecedores" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 230px; top: 290px; position: absolute" Text="0" Width="80px"></asp:Label>
                    <asp:CheckBox ID="ckcpagarlancamentos" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 305px; left: 10px;" Text="Lançamentos"
                        Width="150px" />
                    <asp:Label ID="lbcpagarlancamentos" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 230px; top: 305px; position: absolute" Text="0" Width="80px"></asp:Label>
                    <asp:Label ID="Label5" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 330px;
                        position: absolute" Text="Contas a Receber"></asp:Label>
                    <asp:CheckBox ID="ckreceitas" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 345px; left: 10px;"
                        Text="Classificação de Receitas" Width="200px" />
                    <asp:Label ID="lbreceitas" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 230px; top: 345px;
                        position: absolute" Text="0" Width="80px"></asp:Label>
                    <asp:CheckBox ID="ckclientescontaareceber" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 360px; left: 10px;" Text="Clientes"
                        Width="150px" />
                    <asp:Label ID="lbclientescontaareceber" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 230px; top: 360px; position: absolute" Text="0" Width="80px"></asp:Label>
                    <asp:CheckBox ID="ckcreceberlancamentos" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 375px; left: 10px;" Text="Lançamentos"
                        Width="150px" />
                    <asp:Label ID="lbcreceberlancamentos" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 230px; top: 375px; position: absolute" Text="0" Width="80px"></asp:Label>
                    <asp:Label ID="Label6" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 395px;
                        position: absolute" Text="Bancos"></asp:Label>
                    <asp:CheckBox ID="ckbancos" runat="server" AutoPostBack="True" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt;
                        top: 410px; left: 10px; bottom: 105px;" Text="Bancos" Width="200px" />
                    <asp:Label ID="lbbancos" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 230px; top: 410px;
                        position: absolute" Text="0" Width="80px"></asp:Label>
                    <asp:CheckBox ID="ckcontascorrentes" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 425px; left: 10px;" Text="Contas Correntes"
                        Width="150px" />
                    <asp:Label ID="lbcontascorrentes" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 230px; top: 425px; position: absolute" Text="0" Width="80px"></asp:Label>
                    <asp:CheckBox ID="cksaldoinicial" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 440px; left: 10px;" Text="Saldos Iniciais"
                        Width="150px" />
                    <asp:Label ID="lbsaldoinicial" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 230px; top: 440px; position: absolute" Text="0" Width="80px"></asp:Label>
                </div>
                <div style="z-index: 1; border-style: none; left: 460px; top: 65px; position: absolute;
                    height: 500px; width: 350px">
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
                        <Image Height="30px" ToolTip="Processa Estatísticas" Url="~/images/BotoesTelas/BTNalterarA.bmp"
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
                                    Estatísticas do Ambiente do Sistema.<br />
                                    <br />
                                    Apresenta uma visão quantitativa dos registros do Sistema.<br />
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

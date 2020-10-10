<%@ Page Title="FAmbienteStatus" Language="C#" AutoEventWireup="true" CodeFile="FAmbienteStatus.aspx.cs"
    Inherits="FAmbienteStatus" StylesheetTheme="Principal" %>

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
    <title>Gitano - Config - Ambiente - Status</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <link href="../../content/toastr.css" rel="stylesheet" />
</head>
<body style="height: 1200px">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1200px">
        <ContentTemplate>
            <h1>
                CONFIG - AMBIENTE - STATUS</h1>
            <h2>
                Status de Ambiente do Sistema</h2>
            <div id="DivNova" style="border-style: none">
                <div style="border: 1px solid #808080; z-index: 1; left: 45px; top: 65px; position: absolute;
                    height: 500px; width: 400px">
                    <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px;
                        position: absolute" Text="Medições do Ambiente"></asp:Label>
                    <asp:Label ID="Label3" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 15px;
                        position: absolute" Text="Bases"></asp:Label>
                    <asp:Label ID="Label7" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 200px; top: 15px;
                        position: absolute" Text="Quantidades"></asp:Label>
                    <asp:Label ID="lbbasegitano" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 30px; left: 10px;" Text="Base Gitano"
                        Width="150px" />
                    <asp:Label ID="lbbasegitano2" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 30px; position: absolute" Text="0"></asp:Label>
                    <asp:Label ID="lbbasecep" runat="server" AutoPostBack="True" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt;
                        top: 45px; left: 10px;" Text="Base CEP" Width="150px" />
                    <asp:Label ID="lbbasecep2" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 210px; top: 45px;
                        position: absolute" Text="0"></asp:Label>
                    <asp:Label ID="lbusuariosativos" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 75px; left: 10px;" Text="Numero de Usuários Ativos"
                        Width="150px" />
                    <asp:Label ID="lbusuariosativos2" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 75px; position: absolute" Text="0">
                        </asp:Label>
                    <asp:Label ID="Label2" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 100px;
                        position: absolute" Text="Dados"></asp:Label>
                    <asp:Label ID="lbclientesfinanciamentos" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 115px; left: 10px;" Text="Clientes Financiamentos"
                        Width="150px" />
                    <asp:Label ID="lbclientesfinanciamentos2" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 115px; position: absolute" Text="0"></asp:Label>
                    <asp:Label ID="lbunidadescadastradas" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 130px; left: 10px;" Text="Unidades Cadastradas"
                        Width="150px" />
                    <asp:Label ID="lbunidadescadastradas2" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 130px; position: absolute" Text="0"></asp:Label>
                    <asp:Label ID="lbvendas" runat="server" AutoPostBack="True" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt;
                        top: 145px; left: 10px;" Text="Vendas" Width="150px" />
                    <asp:Label ID="lbvendas2" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 210px; top: 145px;
                        position: absolute" Text="0"></asp:Label>
                    <asp:Label ID="lbcontasapagar" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 160px; left: 10px;" Text="Contas a Pagar"
                        Width="150px" />
                    <asp:Label ID="lbcontasapagar2" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 160px; position: absolute" Text="0"></asp:Label>
                    <asp:Label ID="lbcontasareceber" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 175px; left: 10px;" Text="Contas a Receber"
                        Width="150px" />
                    <asp:Label ID="lbcontasareceber2" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 175px; position: absolute" Text="0"></asp:Label>
                    <asp:Label ID="lbclientescreceber" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 190px; left: 10px;" Text="Clientes"
                        Width="150px" />
                    <asp:Label ID="lbclientescreceber2" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 190px; position: absolute" Text="0"></asp:Label>
                    <asp:Label runat="server" AutoPostBack="True" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt;
                        top: 205px; left: 10px;" Text="Fornecedores" Width="150px" />
                    <asp:Label ID="lbfornecedorescpagar2" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 205px; position: absolute" Text="0"></asp:Label>
                    <asp:Label ID="lbcontascorrentes" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 220px; left: 10px;" Text="Contas Correntes"
                        Width="150px" />
                    <asp:Label ID="lbcontascorrentes2" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 220px; position: absolute" Text="0"></asp:Label>
                    <asp:Label ID="lbcorretores" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 235px; left: 10px;" Text="Corretores"
                        Width="150px" />
                    <asp:Label ID="lbcorretores2" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 235px; position: absolute" Text="0"></asp:Label>
                    <asp:Label ID="Label4" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 260px;
                        position: absolute" Text="LOG"></asp:Label>
                    <asp:Label ID="lblog" runat="server" AutoPostBack="True" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt;
                        top: 275px; left: 10px;" Text="Registros de LOG" Width="150px" />
                    <asp:Label ID="lblog2" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 210px; top: 275px;
                        position: absolute" Text="0"></asp:Label>
                    <asp:Label ID="ckfornecedores" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 290px; left: 10px;" Text="Fornecedores"
                        Width="150px" Visible="False" />
                    <asp:Label ID="lbfornecedores" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 290px; position: absolute" Text="0" Visible="False"></asp:Label>
                    <asp:Label ID="Label5" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 315px;
                        position: absolute" Text="Contas a Receber" Visible="False"></asp:Label>
                    <asp:Label ID="ckreceitas" runat="server" AutoPostBack="True" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt;
                        top: 330px; left: 10px; bottom: 105px;" Text="Classificação de Receitas" 
                        Width="200px" Visible="False" />
                    <asp:Label ID="lbreceitas" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 210px; top: 330px;
                        position: absolute" Text="0" Visible="False"></asp:Label>
                    <asp:Label ID="ckclientescontaareceber" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 345px; left: 10px;" Text="Clientes"
                        Width="150px" Visible="False" />
                    <asp:Label ID="lbclientescontaareceber" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 345px; position: absolute" Text="0" Visible="False"></asp:Label>
                    <asp:Label ID="Label6" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 370px;
                        position: absolute" Text="Bancos" Visible="False"></asp:Label>
                    <asp:Label ID="ckbancos" runat="server" AutoPostBack="True" Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt;
                        top: 385px; left: 10px; bottom: 105px;" Text="Bancos" Width="200px" 
                        Visible="False" />
                    <asp:Label ID="lbbancos" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 210px; top: 385px;
                        position: absolute" Text="0" Visible="False"></asp:Label>
                    <asp:Label ID="ckcontascorrentes" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 400px; left: 10px;" Text="Contas Correntes"
                        Width="150px" Visible="False" />
                    <asp:Label ID="lbcontascorrentes3" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 400px; position: absolute" Text="0" Visible="False"></asp:Label>
                    <asp:Label ID="cksaldoinicial" runat="server" AutoPostBack="True" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 415px; left: 10px;" Text="Saldos Iniciais"
                        Width="150px" Visible="False" />
                    <asp:Label ID="lbsaldoinicial" runat="server" BackColor="White" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2;
                        left: 210px; top: 415px; position: absolute" Text="0" Visible="False"></asp:Label>
                </div>
                <div style="z-index: 1; border-style: none; left: 460px; top: 65px; position: absolute;
                    height: 500px; width: 350px">
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
                    <dx:ASPxPopupControl ID="Popuphelp" runat="server" LoadingPanelText="Carregando&amp;hellip;"
                        Theme="PlasticBlue" PopupElementID="bthelp" PopupVerticalAlign="Below" PopupHorizontalAlign="LeftSides"
                        AllowDragging="True" ShowFooter="True" Width="310px" Height="160px" HeaderText="Ajuda do Sistema"
                        ClientInstanceName="Popuphelp" FooterText="Gitano Software">
                        <HeaderStyle Font-Bold="True" />
                        <ContentCollection>
                            <dx:PopupControlContentControl ID="PopupControlContentControl" runat="server">
                                <div style="vertical-align: middle">
                                    Status do Ambiente Sistema.<br />
                                    <br />
                                    Apresenta informações básicas sobre a disposição dos recursos do ambiente que o sistema está instalado.<br />
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

<%@ Page Title="FCobrancaRetorno" Language="C#" AutoEventWireup="true" CodeFile="FCobrancaRetorno.aspx.cs"
    Inherits="FCobrancaRetorno" StylesheetTheme="Principal" %>

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
    <title>Gitano - Pagamentos - Cobrança Bancária - Retorno</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <link href="../../content/toastr.css" rel="stylesheet" />
</head>
<body style="height: 1400px">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1400px">
        <ContentTemplate>
            <h1>
                COBRANÇA BANCÁRIA - RETORNO</h1>
            <h2>
                Retorno de Arquivos Cobrança</h2>
            <div id="DivNova" style="border-style: none">
                <div style="border: 1px solid #808080; z-index: 1; left: 35px; top: 100px; position: absolute;
                    height: 1200px; width: 832px; text-align: center;">
                    <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px;
                        position: absolute" Text="Selecione" Theme="PlasticBlue"></asp:Label>
                    <asp:Label ID="Label3" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 15px;
                        position: absolute" Text="Banco" Theme="PlasticBlue"></asp:Label>
                    <dx:ASPxComboBox ID="cbbanco" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 15px; left: 150px;" Width="380px" Theme="PlasticBlue"
                        OnSelectedIndexChanged="cbbanco_SelectedIndexChanged" AutoPostBack="True">
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label4" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 50px;
                        position: absolute" Text="Drive\Pasta\Extensão" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edcaminho" runat="server" Style="z-index: 2; left: 150px; top: 50px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="380px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <dx:ASPxTextBox ID="edextensao" runat="server" Style="z-index: 2; left: 550px; top: 50px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="100px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label13" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 85px;
                        position: absolute" Text="Nome Arquivo" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="ednomearquivo" runat="server" Style="z-index: 2; left: 150px;
                        top: 85px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="380px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label2" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 120px;
                        position: absolute" Text="Conteúdo Arquivo Retorno" Theme="PlasticBlue" 
                        Visible="False"></asp:Label>
                    <dx:ASPxMemo ID="memoarquivo" runat="server" BackColor="White" 
                        Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 155px;
                        position: absolute" Height="200px" Width="800px" AutoPostBack="True" 
                        ReadOnly="True">
                        <FocusedStyle Wrap="True">
                        </FocusedStyle>
                        <InvalidStyle Wrap="True">
                        </InvalidStyle>
                    </dx:ASPxMemo>
                    <asp:Label ID="Label5" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 400px;
                        position: absolute" Text="Feedback" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edfeedback" runat="server" Style="z-index: 2; left: 150px;
                        top: 400px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="650px"
                        Visible="False" AutoPostBack="True" ReadOnly="True">
                    </dx:ASPxTextBox>
                    <div id="Div2" runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute;
                        top: 15px; left: 670px; height: 50px; width: 150px;">
                        <dx:ASPxButton ID="btcarrega" runat="server" Height="40px" ImagePosition="Left" Width="45px"
                            OnClick="btcarrega_Click">
                            <Image Height="30px" ToolTip="Carregar Arquivo" Url="~/images/BotoesTelas/BTNpesquisarA.bmp"
                                UrlDisabled="~/images/BotoesTelas/BTNpesquisarI.bmp" UrlPressed="~/images/BotoesTelas/BTNpesquisarS.bmp"
                                Width="30px">
                            </Image>
                        </dx:ASPxButton>
                        <dx:ASPxButton ID="btprocessa" runat="server" Height="40px" ImagePosition="Left"
                            OnClick="btprocessa_Click" Width="45px">
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
                                        Arquivo Retorno Cobrança e Baixa.<br />
                                        <br />
                                        Captura de arquivo retorno de cobrança para bancos.<br />
                                        <br />
                                        Baixa Automática de Pagamentos nos Financiamentos.<br />
                                        <br />
                                        Captura realizada de acordo com dados registrados em Configuração.<br />
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

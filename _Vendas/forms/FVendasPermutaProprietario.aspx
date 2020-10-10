<%@ Page Title="FVendasPermutaProprietario" Language="C#" AutoEventWireup="true" CodeFile="FVendasPermutaProprietario.aspx.cs"
    Inherits="FVendasPermutaProprietario" StylesheetTheme="Principal" %>

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
    <title>Gitano - Vendas - Permuta Proprietário</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <link href="../../content/toastr.css" rel="stylesheet" />
</head>
<body style="height: 1400px">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1400px">
        <ContentTemplate>
            <h1>
                VENDAS - TRANFERÊNCIA PROPRIETÁRIO</h1>
            <h2>
                Transferência Proprietário da Unidade</h2>
            <div id="DivNova" style="border-style: none">
                <div style="border: 1px solid #808080; z-index: 1; left: 35px; top: 100px; position: absolute;
                    height: 500px; width: 832px; text-align: center;">
                    <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px;
                        position: absolute" Text="Selecione" Theme="PlasticBlue"></asp:Label>
                    <asp:Label ID="Label3" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 15px;
                        position: absolute" Text="Produto" Theme="PlasticBlue"></asp:Label>
                    <dx:ASPxComboBox ID="cbproduto" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 15px; left: 150px;" Width="380px" Theme="PlasticBlue"
                        OnSelectedIndexChanged="cbproduto_SelectedIndexChanged" AutoPostBack="True">
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label2" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 50px;
                        position: absolute" Text="Grupo" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxComboBox ID="cbgrupo" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 50px; left: 150px;" Width="380px" Theme="PlasticBlue"
                        OnSelectedIndexChanged="cbgrupo_SelectedIndexChanged" Visible="False" AutoPostBack="True">
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label7" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 85px;
                        position: absolute" Text="Unidades - Parte" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxComboBox ID="cbgrupounidades" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 85px; left: 150px;" Width="150px" Theme="PlasticBlue"
                        OnSelectedIndexChanged="cbgrupounidades_SelectedIndexChanged" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxComboBox>
                    <asp:RadioButtonList ID="rbmeiolote" runat="server" AutoPostBack="True" CellPadding="0"
                        CellSpacing="0" Font-Names="Calibri" Font-Size="12pt" Font-Strikeout="False"
                        ForeColor="#3E5395" Height="12px" Style="z-index: 2; left: 320px; top: 85px;
                        position: absolute; right: 423px;" Width="200px" RepeatDirection="Horizontal"
                        Visible="False" onselectedindexchanged="rbmeiolote_SelectedIndexChanged">
                        <asp:ListItem Value="0" Selected="True">1o. Meio</asp:ListItem>
                        <asp:ListItem Value="1">2o. Meio</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:Label ID="Label8" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 120px;
                        position: absolute" Text="Cliente Atual" Theme="PlasticBlue" 
                        Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edcliente" runat="server" Style="z-index: 2; left: 150px; top: 120px;
                        position: absolute; right: 302px;" Theme="PlasticBlue" Width="380px" Visible="False"
                        AutoPostBack="True" ReadOnly="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label5" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 155px;
                        position: absolute" Text="Cliente Novo" Theme="PlasticBlue" 
                        Visible="False"></asp:Label>
                    <dx:ASPxComboBox ID="cbclientes" runat="server" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 155px; left: 150px;" 
                        Width="380px" Theme="PlasticBlue"
                        OnSelectedIndexChanged="cbclientes_SelectedIndexChanged" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxComboBox>
                    <dx:ASPxComboBox ID="cbclientes_filtro" runat="server" IncrementalFilteringMode="StartsWith"
                        EnableIncrementalFiltering="True" ValueField="nome" TextFormatString="{0} ({1})"
                        Font-Bold="True" Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 155px; left: 150px;" Width="380px"
                        Theme="PlasticBlue" AutoPostBack="True" EnableCallbackMode="True" 
                        DataSourceID="dsfiltro_combo_contato" Visible="False" 
                        onselectedindexchanged="cbclientes_filtro_SelectedIndexChanged">
                        <Columns>
                            <dx:ListBoxColumn FieldName="nome" Width="300px" Caption="Nome" />
                            <dx:ListBoxColumn FieldName="id" Width="100px" Caption="Código" />
                        </Columns>
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label4" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 190px;
                        position: absolute" Text="FeedBack" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edfeedback" runat="server" Style="z-index: 2; left: 150px; top: 190px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="650px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <div id="Div2" runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute;
                        top: 20px; left: 700px; height: 50px; width: 100px;">
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
                                        <br />
                                        Permuta de Proprietários.<br />
                                        <br />
                                        O Processo de Permuta permite que o seja feita a transferência da Titularidade de um contrato de um Proprietário para outro. O Processo se divide nas ações a seguir:<br />
                                        <br />
                                        1o. Escolha da Unidade e escolha do Novo Proprietário.<br />
                                        <br />
                                        2o. Processamento da Permuta.<br />
                                        <br />
                                        3o. Ações decorrentes do Processo:<br />
                                        <br />
                                        - As informações de venda serão preservadas.<br />
                                        - O Proprietário Atual é o Novo Proprietário selecionado no processo.<br />
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

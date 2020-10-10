<%@ Page Title="FRelAPagarDespesas" Language="C#" AutoEventWireup="true" CodeFile="FRelAPagarDespesas.aspx.cs"
    Inherits="FRelAPagarDespesas" StylesheetTheme="Principal" %>

<%@ Register Assembly="DevExpress.XtraReports.v13.2.Web, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="eWorld.UI, Version=2.0.6.2393, Culture=neutral, PublicKeyToken=24d65337282035f2"
    Namespace="eWorld.UI" TagPrefix="ew" %>
<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Relatório Contas a Pagar - Despesas</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body style="height: 910px">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel" runat="server">
        <ContentTemplate>
            <h1>
                CONTAS A PAGAR - RELATÓRIOS</h1>
            <h2>
                Despesas Cadastro</h2>
            <div id="DivNova" style="border-style: none">
                <div style="border: 1px solid #808080; z-index: 1; left: 35px; top: 100px; position: absolute;
                    height: 1200px; width: 832px; text-align: center;">
                    <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px;
                        position: absolute" Text="Clientes "></asp:Label>
                    <dx3:ASPxGridView ID="lookupempresa" ClientInstanceName="lookupempresa" runat="server"
                        AutoGenerateColumns="False" EnableTheming="True" Font-Bold="False" KeyFieldName="apelido"
                        Style="z-index: 1; position: absolute; margin-right: 5px; top: 15px; left: 10px;
                        height: 300px;" Theme="PlasticBlue" Width="490px" EnableRowsCache="False" EnableCallBacks="False">
                        <Columns>
                            <dx3:GridViewCommandColumn ShowInCustomizationForm="True" ShowSelectCheckbox="True"
                                VisibleIndex="0" Width="20%">
                                <HeaderTemplate>
                                    <dx:ASPxCheckBox ID="ASPxCheckBox1" runat="server" ToolTip="Marca/Desmarca Todos os itens visíveis"
                                        ClientSideEvents-CheckedChanged="function(s, e) { lookupempresa.SelectAllRowsOnPage(s.GetChecked()); }">
                                    </dx:ASPxCheckBox>
                                </HeaderTemplate>
                            </dx3:GridViewCommandColumn>
                            <dx3:GridViewDataTextColumn Caption="Descricao" FieldName="descricao" Name="descricao"
                                ShowInCustomizationForm="True" VisibleIndex="2" Width="60%">
                                <PropertiesTextEdit>
                                    <MaskSettings Mask="dd/MM/yyyy" ShowHints="True" />
                                </PropertiesTextEdit>
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                            </dx3:GridViewDataTextColumn>
                            <dx3:GridViewDataTextColumn Caption="Código" FieldName="codigo" Name="codigo" 
                                VisibleIndex="1" Width="20%">
                                <HeaderStyle Font-Bold="True" ForeColor="White" />
                                <CellStyle HorizontalAlign="Right">
                                </CellStyle>
                            </dx3:GridViewDataTextColumn>
                        </Columns>
                        <SettingsBehavior AutoFilterRowInputDelay="10000" />
                        <SettingsPager Visible="False" Mode="ShowAllRecords">
                        </SettingsPager>
                        <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                            VerticalScrollableHeight="300" />
                        <Styles>
                            <Header ForeColor="#FFF0D9" HorizontalAlign="Center">
                            </Header>
                            <AlternatingRow Enabled="True">
                            </AlternatingRow>
                            <FocusedRow BackColor="#ACBADB" Font-Bold="True">
                            </FocusedRow>
                            <Cell HorizontalAlign="Left" Font-Names="Calibri" ForeColor="#3E5395">
                                <BackgroundImage Repeat="NoRepeat" />
                            </Cell>
                            <LoadingPanel ForeColor="#2F2FFF">
                                <BackgroundImage VerticalPosition="center" />
                            </LoadingPanel>
                        </Styles>
                        <BackgroundImage HorizontalPosition="center" />
                    </dx3:ASPxGridView>
                    <div id="Div2" runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute;
                        top: 20px; left: 600px; height: 50px; width: 100px;">
                        <dx:ASPxButton ID="btImpressao" runat="server" Height="40px" ImagePosition="Left"
                            OnClick="btImpressao_Click" Width="45px">
                            <Image Height="30px" ToolTip="Imprimir" Url="~/images/Botoes/print2.jpg" UrlDisabled="~/images/Botoes/print2.jpg"
                                UrlPressed="~/images/Botoes/print3.jpg" Width="30px">
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
                                    Relatório Fornecedores Contas a Receber.<br />
                                    <br />
                                    O Relatório em questão apresenta os dados dos Fornecedores cadastrados no Contas
                                    a Pagar.<br />
                                    <br />
                                </div>
                            </dx:PopupControlContentControl>
                        </ContentCollection>
                    </dx:ASPxPopupControl>
                </div>
            </div>
            <%--             DIV ABAIXO FOI CRIADA COM runat="server" PARA PODER SER ACESSADA NO ASPX.CS  ==========================================================================  --%>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>

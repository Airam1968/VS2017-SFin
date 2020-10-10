<%@ Page Title="FRelFCaixaTrimestral" Language="C#" AutoEventWireup="true" CodeFile="FRelFCaixaTrimestral.aspx.cs"
    Inherits="FRelFCaixaTrimestral" StylesheetTheme="Principal" %>

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
    <title>Relatório Fluxo de Caixa - Trimestral</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body style="height: 910px">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager" runat="server" />
        <asp:UpdatePanel ID="UpdatePanel" runat="server">
            <ContentTemplate>
                <h1>FLUXO DE CAIXA - RELATÓRIOS</h1>
                <h2>Trimestral</h2>
                <div id="DivNova" style="border-style: none">
                    <div style="border: 1px solid #808080; z-index: 1; left: 35px; top: 100px; position: absolute; height: 1200px; width: 832px; text-align: center;">
                        <asp:Label ID="Label2" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px; position: absolute"
                            Text="Selecione" Theme="PlasticBlue"></asp:Label>
                        <asp:Label ID="Label3" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 15px; position: absolute"
                            Text="Produto" Theme="PlasticBlue"></asp:Label>
                        <dx:ASPxComboBox ID="cbproduto" runat="server" ValueType="System.String" Font-Bold="True"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt; top: 15px; left: 150px;"
                            Width="380px" Theme="PlasticBlue"
                            OnSelectedIndexChanged="cbproduto_SelectedIndexChanged" AutoPostBack="True">
                        </dx:ASPxComboBox>
                        <asp:Label ID="Label16" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 50px; position: absolute"
                            Text="Conta Corrente" Theme="PlasticBlue"></asp:Label>
                        <dx:ASPxComboBox ID="cbcontascorrentes" runat="server" ValueType="System.String"
                            Font-Bold="True" Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt; top: 50px; left: 150px;"
                            Width="380px" Theme="PlasticBlue"
                            AutoPostBack="True">
                        </dx:ASPxComboBox>
                        <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 85px; position: absolute"
                            Text="Trimestre" Theme="PlasticBlue"></asp:Label>
                        <asp:RadioButtonList ID="rbtrimestre" runat="server" AutoPostBack="True" CellPadding="0"
                            CellSpacing="0" Font-Names="Calibri" Font-Size="12pt" Font-Strikeout="False"
                            ForeColor="#3E5395" Height="12px" Style="z-index: 2; left: 150px; top: 85px; position: absolute; right: 382px;"
                            Width="500px" RepeatDirection="Horizontal">
                            <asp:ListItem Value="1" Selected="True">1o. Trimestre</asp:ListItem>
                            <asp:ListItem Value="2">2o. Trimestre</asp:ListItem>
                            <asp:ListItem Value="3">3o. Trimestre</asp:ListItem>
                            <asp:ListItem Value="4">4o. Trimestre</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:Label ID="Label4" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 120px; position: absolute"
                            Text="Ano" Theme="PlasticBlue"></asp:Label>
                        <dx:ASPxComboBox ID="cbano" runat="server" ValueType="System.String" Font-Bold="True"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 10pt; top: 120px; left: 150px;"
                            Width="180px"
                            Theme="PlasticBlue" AutoPostBack="True">
                        </dx:ASPxComboBox>
                        <asp:Label ID="Label13" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 155px; position: absolute"
                            Text="Lançamentos" Theme="PlasticBlue"></asp:Label>
                        <asp:RadioButtonList ID="rblancamentossituacao" runat="server" AutoPostBack="True"
                            CellPadding="0" CellSpacing="0" Font-Names="Calibri" Font-Size="12pt" Font-Strikeout="False"
                            ForeColor="#3E5395" Height="12px" Style="z-index: 2; left: 150px; top: 155px; position: absolute; right: 382px;"
                            Width="300px" RepeatDirection="Horizontal">
                            <asp:ListItem Value="1" Selected="True">Previstos</asp:ListItem>
                            <asp:ListItem Value="2">Realizados</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:Label ID="Label5" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 190px; position: absolute"
                            Text="Saldo Incial" Theme="PlasticBlue"></asp:Label>
                        <dx:ASPxTextBox ID="edsaldo_inicial" runat="server" Style="z-index: 2; left: 150px; top: 190px; position: absolute; right: 223px;"
                            Theme="PlasticBlue" Width="200px"
                            Visible="False" AutoPostBack="True">
                            <MaskSettings IncludeLiterals="DecimalSymbol" Mask="&lt;0..9999999999999999999g&gt;.&lt;00000000000..99&gt;" />
                        </dx:ASPxTextBox>
                        <asp:Label ID="Label9" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 225px; position: absolute"
                            Text="Multiplas Contas" Theme="PlasticBlue"></asp:Label>
                        <dx:ASPxCheckBox ID="ckmulticontas" runat="server" Style="z-index: 2; left: 150px; top: 225px; position: absolute; right: 562px;"
                            AutoPostBack="True" CheckState="Unchecked"
                            Font-Bold="False" Font-Names="Calibri" Font-Size="14px" ForeColor="#3E5395" Height="21px"
                            Text=" " Theme="PlasticBlue" Width="120px" OnCheckedChanged="ckmulticontas_CheckedChanged">
                        </dx:ASPxCheckBox>
                       <asp:Label ID="Label6" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 300px; top: 225px; position: absolute"
                            Text="Inclui Aplicações" Theme="PlasticBlue"></asp:Label>
                        <dx:ASPxCheckBox ID="ckaplicacoes" runat="server" Style="z-index: 2; top: 225px; left: 450px; position: absolute; right: 562px;"
                            AutoPostBack="True" CheckState="Checked"
                            Font-Bold="False" Font-Names="Calibri" Font-Size="14px" ForeColor="#3E5395" Height="21px"
                            Text=" " Theme="PlasticBlue" Width="120px" Checked="True">
                        </dx:ASPxCheckBox>
                        <dx3:ASPxGridView ID="lookupempresa" ClientInstanceName="lookupempresa" runat="server"
                            AutoGenerateColumns="False" EnableTheming="True" Font-Bold="False" KeyFieldName="ID"
                            Style="z-index: 1; position: absolute; margin-right: 5px; top: 260px; left: 10px; height: 300px;"
                            Theme="PlasticBlue" Width="390px" EnableRowsCache="False" EnableCallBacks="False">
                            <Columns>
                                <dx3:GridViewCommandColumn ShowSelectCheckbox="True"
                                    VisibleIndex="0" Width="20%">
                                    <HeaderTemplate>
                                        <dx:ASPxCheckBox ID="ASPxCheckBox1" runat="server" ToolTip="Marca/Desmarca Todos os itens visíveis"
                                            ClientSideEvents-CheckedChanged="function(s, e) { lookupempresa.SelectAllRowsOnPage(s.GetChecked()); }">
                                        </dx:ASPxCheckBox>
                                    </HeaderTemplate>
                                </dx3:GridViewCommandColumn>
                                <dx3:GridViewDataTextColumn Caption="Contas" FieldName="ID"
                                    Name="ID" VisibleIndex="2" Width="20%">
                                    <PropertiesTextEdit>
                                        <MaskSettings Mask="dd/MM/yyyy" ShowHints="True" />
                                    </PropertiesTextEdit>
                                    <HeaderStyle Font-Bold="True" ForeColor="White" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Nome" FieldName="nome_agencia" Name="nome_agencia"
                                    ShowInCustomizationForm="True" VisibleIndex="2" Width="40%">
                                    <PropertiesTextEdit>
                                        <MaskSettings Mask="dd/MM/yyyy" ShowHints="True" />
                                    </PropertiesTextEdit>
                                    <HeaderStyle Font-Bold="True" ForeColor="White" />
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
                        <div id="Div2" runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute; top: 20px; left: 700px; height: 50px; width: 100px;">
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
                                            Relatório Extrato de Financiamento.<br />
                                            <br />
                                            O Relatório em questão apresenta os dados fluxo de parcelas e recebimentos do financiamento.<br />
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

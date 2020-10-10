<%@ Page Title="FRelClienteMalaDireta" Language="C#" AutoEventWireup="true" CodeFile="FRelClienteMalaDireta.aspx.cs"
    Inherits="FRelClienteMalaDireta" StylesheetTheme="Principal" %>

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
    <title>Relatório Cliente Etiquetas</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body style="height: 910px">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel" runat="server">
        <ContentTemplate>
            <h1>
                CLIENTES - RELATÓRIOS</h1>
            <h2>
                Clientes Mala Direta Etiquetas</h2>
            <div id="DivNova" style="border-style: none">
                <div style="border: 1px solid #808080; z-index: 1; left: 35px; top: 100px; position: absolute;
                    height: 1200px; width: 832px; text-align: center;">
                    <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px;
                        position: absolute" Text="Selecione "></asp:Label>
                    <dx3:ASPxGridView ID="lookupempresa" ClientInstanceName="lookupempresa" runat="server"
                        AutoGenerateColumns="False" EnableTheming="True" Font-Bold="False" KeyFieldName="apelido"
                        Style="z-index: 1; position: absolute; margin-right: 5px; top: 15px; left: 10px;
                        height: 170px;" Theme="PlasticBlue" Width="390px" EnableRowsCache="False" EnableCallBacks="False">
                        <Columns>
                            <dx3:GridViewCommandColumn ShowInCustomizationForm="True" ShowSelectCheckbox="True"
                                VisibleIndex="0" Width="20%">
                                <HeaderTemplate>
                                    <dx:ASPxCheckBox ID="ASPxCheckBox1" runat="server" ToolTip="Marca/Desmarca Todos os itens visíveis"
                                        ClientSideEvents-CheckedChanged="function(s, e) { lookupempresa.SelectAllRowsOnPage(s.GetChecked()); }">
                                    </dx:ASPxCheckBox>
                                </HeaderTemplate>
                            </dx3:GridViewCommandColumn>
                            <dx3:GridViewDataTextColumn Caption="Apelido" FieldName="apelido" Name="apelido"
                                ShowInCustomizationForm="True" VisibleIndex="5" Width="80%">
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
                            VerticalScrollableHeight="100" />
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
                    <asp:Label ID="Label13" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 225px;
                        position: absolute" Text="Filtro Clientes" Theme="PlasticBlue"></asp:Label>
                    <asp:RadioButtonList ID="rbfiltro" runat="server" AutoPostBack="True" CellPadding="0"
                        CellSpacing="0" Font-Names="Calibri" Font-Size="12pt" Font-Strikeout="False"
                        ForeColor="#3E5395" Height="12px" Style="z-index: 2; left: 150px; top: 225px;
                        position: absolute; right: 286px; width: 396px;" 
                        RepeatDirection="Horizontal" 
                        OnSelectedIndexChanged="rbfiltro_SelectedIndexChanged">
                        <asp:ListItem Value="0">Anivesariantes</asp:ListItem>
                        <asp:ListItem Value="1">Clientes Produto</asp:ListItem>
<%--                        <asp:ListItem Value="2">Devedores</asp:ListItem>--%>
                    </asp:RadioButtonList>
                    <asp:Label ID="Label14" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 260px;
                        position: absolute" Text="Mês Aniversário" Theme="PlasticBlue" 
                        Visible="False"></asp:Label>
                    <dx:ASPxComboBox ID="cbmes" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 260px; left: 150px;" Width="380px"
                        Theme="PlasticBlue" AutoPostBack="True" Visible="False">
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label2" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 295px;
                        position: absolute" Text="Produto" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxComboBox ID="cbproduto" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 295px; left: 150px;" 
                        Width="380px" Theme="PlasticBlue"
                        OnSelectedIndexChanged="cbproduto_SelectedIndexChanged" 
                        AutoPostBack="True" Visible="False">
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label23" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 330px;
                        position: absolute" Text="Grupo" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxComboBox ID="cbgrupo" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 330px; left: 150px;" 
                        Width="380px" Theme="PlasticBlue" AutoPostBack="True" Visible="False">
                    </dx:ASPxComboBox>  
                    <asp:Label ID="Label4" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 365px;
                        position: absolute" Text="Devedores Até" Theme="PlasticBlue" 
                        Visible="False"></asp:Label>
                    <dx:ASPxDateEdit ID="dtprevisao1" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                        EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4;
                        position: absolute; margin-right: 5px; left: 150px; top: 365px;" Theme="PlasticBlue"
                        UseMaskBehavior="True" Width="120px" Visible="False">
                        <CalendarProperties ClearButtonText="Limpar" TodayButtonText="Hoje">
                        </CalendarProperties>
                        <ClientSideEvents KeyDown="function(s, e) 
                                                   {if (!(
                                                         (e.htmlEvent.keyCode &gt;= 48 &amp;&amp; e.htmlEvent.keyCode &lt;= 57)  ||
                                                         (e.htmlEvent.keyCode &gt;= 96 &amp;&amp; e.htmlEvent.keyCode &lt;= 105) ||
                                                         (e.htmlEvent.keyCode = 9)
                                                       ))
                                                    ASPxClientUtils.PreventEvent(e.htmlEvent);
                                                   }" />
                        <Border BorderColor="#808080" BorderStyle="Solid" BorderWidth="1px" />
                    </dx:ASPxDateEdit>
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
                                        Mala Direta Clientes.<br />
                                        <br />
                                        Emissão de etiquetas de endereçamento baseado no cadastro de clientes.<br />
                                        <br />
                                        Seleção automática do endereço padrão para endereço residencial ou comercial.<br />
                                        <br />
                                        Modelo Referência do formulário de etiquetas:<br />
                                        <br />
                                        Fabricante: Pimaco<br />
                                        Modelos: A4054/A4254/A4354/A4054R<br />
                                        Medidas: 2,54 A x 9,9 L (2 colunas)<br />
                                        Papel: FOLHAS TAMANHO A4 – 21,0 X 29,7 cm<br />
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

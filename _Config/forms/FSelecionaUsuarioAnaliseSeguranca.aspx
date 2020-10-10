<%@ Page Title="FSelecionaUsuarioAnaliseSeguranca" Language="C#" AutoEventWireup="true"
    CodeFile="FSelecionaUsuarioAnaliseSeguranca.aspx.cs" Inherits="FSelecionaUsuarioAnaliseSeguranca"
    StylesheetTheme="Principal" %>

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
    <title>Gitano - Config - Análises - Segurança de Acesso</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body style="height: 1200px">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager" runat="server" />
        <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1200px">
            <ContentTemplate>
                <h1>CONFIG - ANÁLISES - SEGURANÇA</h1>
                <h2>Segurança de Acesso</h2>
                <div id="DivNova" style="border-style: none">
                    <div style="border: 1px solid #808080; z-index: 1; left: 45px; top: 65px; position: absolute; height: 230px; width: 248px">
                        <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px; position: absolute"
                            Text="Usuário"></asp:Label>
                        <dx3:ASPxGridView ID="lookupusuario" runat="server" AutoGenerateColumns="False" ClientInstanceName="lookupusuario"
                            EnableTheming="True" Font-Bold="False" KeyFieldName="Historico" Style="z-index: 1; position: absolute; margin-right: 6px; top: 15px; left: 11px; height: 166px;"
                            Theme="PlasticBlue" Width="200px">
                            <Columns>
                                <dx3:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Width="20%">
                                    <HeaderTemplate>
                                        <dx:ASPxCheckBox ID="ASPxCheckBox5" runat="server" ClientSideEvents-CheckedChanged="function(s, e) { lookupusuario.SelectAllRowsOnPage(s.GetChecked()); }"
                                            ToolTip="Marca/Desmarca Todos os itens visíveis">
                                        </dx:ASPxCheckBox>
                                    </HeaderTemplate>
                                </dx3:GridViewCommandColumn>
                                <dx3:GridViewDataTextColumn Caption="Usuário" FieldName="login" Name="login" VisibleIndex="5"
                                    Width="80%">
                                    <PropertiesTextEdit>
                                        <MaskSettings Mask="dd/MM/yyyy" ShowHints="True" />
                                    </PropertiesTextEdit>
                                    <HeaderStyle Font-Bold="True" ForeColor="White" />
                                </dx3:GridViewDataTextColumn>
                            </Columns>
                            <SettingsPager Mode="ShowAllRecords" Visible="False">
                            </SettingsPager>
                            <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                                VerticalScrollableHeight="100" />
                            <SettingsText EmptyDataRow="Não há dados á exibir." />
                            <Styles>
                                <Header ForeColor="#FFF0D9" HorizontalAlign="Center">
                                </Header>
                                <AlternatingRow Enabled="True">
                                </AlternatingRow>
                                <Cell HorizontalAlign="Left">
                                    <BackgroundImage Repeat="NoRepeat" />
                                    <BackgroundImage Repeat="NoRepeat" />
                                </Cell>
                                <LoadingPanel ForeColor="#2F2FFF">
                                    <BackgroundImage VerticalPosition="center" />
                                    <BackgroundImage VerticalPosition="center" />
                                </LoadingPanel>
                            </Styles>
                            <BackgroundImage HorizontalPosition="center" />
                            <BackgroundImage HorizontalPosition="center" />
                        </dx3:ASPxGridView>
                    </div>
                    <div runat="server" style="border: 1px solid #808080; z-index: 5; position: absolute; top: 65px; left: 305px; height: 50px; width: 378px;"
                        id="DivPeriodo">
                        <dx:ASPxDateEdit ID="dtinicio" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                            EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Theme="PlasticBlue"
                            UseMaskBehavior="True" Width="120px" Style="z-index: 5; position: absolute; margin-right: 5px; top: 15px; left: 13px;"
                            MinDate="1900-01-01">
                            <CalendarProperties ClearButtonText="Limpar" TodayButtonText="Hoje">
                            </CalendarProperties>
                            <ClientSideEvents KeyDown="function(s, e) 
                                                   {if (!(
                                                         (e.htmlEvent.keyCode &gt;= 48 &amp;&amp; e.htmlEvent.keyCode &lt;= 57)  ||
                                                         (e.htmlEvent.keyCode &gt;= 96 &amp;&amp; e.htmlEvent.keyCode &lt;= 105) ||
                                                         (e.htmlEvent.keyCode = 9)
                                                       ))
                                                    ASPxClientUtils.PreventEvent(e.htmlEvent);
                                                   }"
                                ButtonClick="function(s, e) {
	                                            s.SetDate(new Date(1900, 0, 1)); 
                                            }"
                                DropDown="function(s, e) {
                                                        if (!s.GetDate())
            	                                            s.SetDate(new Date(1900, 0, 1));	
                                                    }"
                                Init="function(s, e) {
                                                        if (!s.GetDate())
            	                                            s.SetDate(new Date(1900, 0, 1));	
                                                    }" />
                            <Border BorderColor="#808080" BorderStyle="Solid" BorderWidth="1px" />
                        </dx:ASPxDateEdit>
                        <asp:Label ID="ASPxLabel2" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Text="Até" Style="z-index: 5; position: absolute; top: 15px; left: 145px;">
                        </asp:Label>
                        <asp:CheckBox ID="cktudoperiodo" runat="server" Font-Bold="True"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" OnCheckedChanged="cktudoperiodo_CheckedChanged"
                            Style="z-index: 5; position: absolute; font-size: 10pt; top: 15px; left: 321px;"
                            Text="Tudo" Width="53px" />
                        <asp:Label ID="Label10" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; left: 9px; top: -11px; position: absolute"
                            Text="Período"></asp:Label>
                        <dx:ASPxDateEdit ID="dtfim" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                            EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                            Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Theme="PlasticBlue"
                            UseMaskBehavior="True" Width="120px" Style="z-index: 5; position: absolute; top: 15px; left: 182px; margin-bottom: 0px;"
                            MinDate="1900-01-01">
                            <CalendarProperties ClearButtonText="Limpar" TodayButtonText="Hoje">
                            </CalendarProperties>
                            <ClientSideEvents KeyDown="function(s, e) 
                                                   {if (!(
                                                         (e.htmlEvent.keyCode &gt;= 48 &amp;&amp; e.htmlEvent.keyCode &lt;= 57)  ||
                                                         (e.htmlEvent.keyCode &gt;= 96 &amp;&amp; e.htmlEvent.keyCode &lt;= 105) ||
                                                         (e.htmlEvent.keyCode = 9)
                                                       ))
                                                    ASPxClientUtils.PreventEvent(e.htmlEvent);
                                                   }"
                                ButtonClick="function(s, e) {
	                                            s.SetDate(new Date(1900, 0, 1)); 
                                            }"
                                DropDown="function(s, e) {
                                                        if (!s.GetDate())
            	                                            s.SetDate(new Date(1900, 0, 1));	
                                                    }"
                                Init="function(s, e) {
                                                        if (!s.GetDate())
            	                                            s.SetDate(new Date(1900, 0, 1));	
                                                    }" />
                            <Border BorderColor="#808080" BorderStyle="Solid" BorderWidth="1px" />
                        </dx:ASPxDateEdit>
                    </div>
                    <div runat="server" style="border: 1px solid #808080; z-index: 4; position: absolute; top: 125px; left: 305px; height: 50px; width: 378px;"
                        id="DivModulo">
                        <asp:Label ID="Label2" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 4; left: 9px; top: -11px; position: absolute"
                            Text="Modulo"></asp:Label>
                        <dx:ASPxComboBox ID="cbModulo" runat="server" ValueType="System.String" BackColor="#E1E6F2"
                            DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" EditFormatString="dd/MM/yyyy"
                            EnableTheming="True" Font-Bold="False" Font-Names="Calibri" Font-Size="15px"
                            ForeColor="#3E5395" Height="16px" Theme="PlasticBlue" UseMaskBehavior="True"
                            Width="300px" Style="z-index: 4; position: absolute; margin-right: 5px; top: 15px; left: 13px;"
                            ToolTip="Filtrar o modulo do Sistema">
                        </dx:ASPxComboBox>
                    </div>

                    <div runat="server" style="border: 1px solid #808080; z-index: 3; position: absolute; top: 185px; left: 305px; height: 50px; width: 378px;"
                        id="DivAcao">
                        <asp:Label ID="Label4" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 3; left: 9px; top: -11px; position: absolute"
                            Text="Ação"></asp:Label>
                        <dx:ASPxComboBox ID="cbAcao" runat="server" ValueType="System.String" BackColor="#E1E6F2"
                            DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" EditFormatString="dd/MM/yyyy"
                            EnableTheming="True" Font-Bold="False" Font-Names="Calibri" Font-Size="15px"
                            ForeColor="#3E5395" Height="16px" Theme="PlasticBlue" UseMaskBehavior="True"
                            Width="300px" Style="z-index: 3; position: absolute; margin-right: 5px; top: 15px; left: 13px;"
                            ToolTip="Filtrar a ação padrão executada">
                        </dx:ASPxComboBox>
                    </div>

                    <div runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute; top: 245px; left: 305px; height: 50px; width: 378px;"
                        id="Div1">
                        <asp:Label ID="Label5" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px; position: absolute"
                            Text="Complemento da Ação"></asp:Label>
                        <dx:ASPxTextBox ID="edComplemento" runat="server" ValueType="System.String" BackColor="#E1E6F2"
                            DisplayFormatString="dd/MM/yyyy" EditFormat="Custom" EditFormatString="dd/MM/yyyy"
                            EnableTheming="True" Font-Bold="False" Font-Names="Calibri" Font-Size="15px"
                            ForeColor="#3E5395" Height="16px" Theme="PlasticBlue" UseMaskBehavior="True"
                            Width="300px" Style="z-index: 2; position: absolute; margin-right: 5px; top: 15px; left: 13px;"
                            ToolTip="Filtrar um texto no complemento da ação">
                        </dx:ASPxTextBox>
                    </div>
                    <div runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute; top: 70px; left: 700px; height: 50px; width: 200px;"
                        id="Div2">
                        <dx:ASPxButton ID="btdesmarcar" runat="server" Height="40px" Width="45px" ImagePosition="Left"
                            OnClick="btdesmarcar_Click">
                            <Image Height="30px" ToolTip="Limpar Marcação" Url="~/images/BotoesTelas/BTNcancelarA.bmp"
                                UrlDisabled="~/images/BotoesTelas/BTNcancelarI.bmp" UrlPressed="~/images/BotoesTelas/BTNcancelarS.bmp"
                                Width="30px">
                            </Image>
                        </dx:ASPxButton>
                        <dx:ASPxButton ID="btprocessa" runat="server" Height="40px" Width="45px" ImagePosition="Left"
                            OnClick="btprocessa_Click">
                            <Image Height="30px" ToolTip="Processa Filtro" Url="~/images/BotoesTelas/BTNalterarA.bmp"
                                UrlDisabled="~/images/BotoesTelas/BTNalterarI.bmp" UrlPressed="~/images/BotoesTelas/BTNalterarS.bmp"
                                Width="30px">
                            </Image>
                        </dx:ASPxButton>
                        <dx:ASPxButton ID="btimprimir" runat="server" Height="40px" Width="45px"
                            ImagePosition="Left" OnClick="btimprimir_Click">
                            <Image Height="30px" ToolTip="Imprimir Selecionados"
                                Url="~/images/BotoesTelas/BTNimprimirA.bmp" UrlDisabled="~/images/BotoesTelas/BTNimprimirI.bmp"
                                UrlPressed="~/images/BotoesTelas/BTNimprimirS.bmp" Width="30px">
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
                    <div runat="server" style="z-index: 2; position: absolute; top: 600px; left: 10px; height: 200px; width: 378px;"
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
                                        Análise de Segurança.<br />
                                        <br />
                                        O Processo apresenta um filtro para análise das ações realizadas pelos usuários no Sistema.<br />
                                        <br />
                                        Caso tenha dúvidas, procure o suporte ou a orientação necessária.<br />
                                        <br />
                                    </div>
                                </dx:PopupControlContentControl>
                            </ContentCollection>
                        </dx:ASPxPopupControl>
                    </div>
                    <div style="border: 1px solid #808080; z-index: 1; left: 45px; top: 310px; position: absolute; height: 400px; width: 800px">
                        <asp:Label ID="Label3" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                            Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px; position: absolute"
                            Text="Log do Usuário ()"></asp:Label>
                        <dx3:ASPxGridView ID="lookuplog" runat="server" AutoGenerateColumns="False" ClientInstanceName="lookuplog"
                            EnableTheming="True" Font-Bold="False" KeyFieldName="DataHora" Style="z-index: 1; position: absolute; margin-right: 6px; top: 15px; left: 11px; height: 350px; width: 770px"
                            Theme="PlasticBlue" Width="100%" EnableRowsCache="False"
                            EnableCallBacks="False">
                            <Columns>
                                <dx3:GridViewDataTextColumn Caption="Login" FieldName="Login" Name="Login"
                                    VisibleIndex="0" Width="50px">
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Nseq" FieldName="Nseq" Name="Nseq" Visible="False"
                                    VisibleIndex="2" Width="100px">
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Tabela" FieldName="Tabela" Name="Tabela"
                                    VisibleIndex="3" Width="150px">
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Operação" FieldName="Operacao"
                                    Name="Operacao" VisibleIndex="4" Width="150px">
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Ação" FieldName="Obs" Name="Obs" VisibleIndex="5"
                                    Width="200px">
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataTextColumn Caption="Complemento da Ação" FieldName="Acao" Name="Acao"
                                    VisibleIndex="6" Width="400px">
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataTextColumn>
                                <dx3:GridViewDataDateColumn Caption="Data\Hora" FieldName="DataHora"
                                    Name="DataHora" VisibleIndex="1" Width="150px">
                                    <PropertiesDateEdit DisplayFormatString="dd/MM/yyyy hh:mm:ss tt" Width="150px">
                                    </PropertiesDateEdit>
                                    <HeaderStyle Font-Bold="True" />
                                </dx3:GridViewDataDateColumn>
                            </Columns>
                            <SettingsPager Mode="ShowAllRecords" Visible="False" PageSize="1000">
                            </SettingsPager>
                            <Settings ShowFilterRow="True" ShowGroupedColumns="True" ShowVerticalScrollBar="True"
                                VerticalScrollableHeight="300" HorizontalScrollBarMode="Visible" />
                            <SettingsText EmptyDataRow="Não há dados á exibir." />
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
                    </div>
                    <%--<div style="border: 1px solid #808080; z-index: 1; left: 35px; top: 100px; position: absolute;
                    height: 481px; width: 832px; text-align: center;">
                </div>--%>
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

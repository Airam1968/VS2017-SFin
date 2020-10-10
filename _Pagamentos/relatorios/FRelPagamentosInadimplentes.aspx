<%@ Page Title="FRelPagamentosInadimplentes" Language="C#" AutoEventWireup="true"
    CodeFile="FRelPagamentosInadimplentes.aspx.cs" Inherits="FRelPagamentosInadimplentes"
    StylesheetTheme="Principal" %>

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
<script runat="server"></script>
<script type="text/javascript" src="../../Scripts/jquery-1.6.3.min.js"></script>
<script type="text/javascript" src="../../Scripts/toastr.min.js"></script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Relatório Pagamentos - Inadimplentes</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <link href="../../content/toastr.css" rel="stylesheet" />
</head>
<body style="height: 910px">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel" runat="server">
        <ContentTemplate>
            <h1>
                PAGAMENTOS - RELATÓRIOS</h1>
            <h2>
                Inadimplentes</h2>
            <div id="DivNova" style="border-style: none">
                <div style="border: 1px solid #808080; z-index: 1; left: 35px; top: 100px; position: absolute;
                    height: 1200px; width: 832px; text-align: center;">
                    <asp:Label ID="Label2" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: -11px;
                        position: absolute" Text="Selecione" Theme="PlasticBlue"></asp:Label>
                    <asp:Label ID="Label13" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 15px;
                        position: absolute" Text="Produto" Theme="PlasticBlue"></asp:Label>
                    <dx:ASPxComboBox ID="cbproduto" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 15px; left: 150px;" Width="380px" Theme="PlasticBlue"
                        OnSelectedIndexChanged="cbproduto_SelectedIndexChanged" AutoPostBack="True">
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label23" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
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
                        position: absolute" Text="Cliente Comprador" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edcliente" runat="server" Style="z-index: 2; left: 150px; top: 120px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="380px" Visible="False"
                        AutoPostBack="True" ReadOnly="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label4" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 150px;
                        position: absolute" Text="Período" Theme="PlasticBlue" 
                        Visible="False"></asp:Label>
                    <dx:ASPxDateEdit ID="dtprevisao1" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                        EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4;
                        position: absolute; margin-right: 5px; left: 150px; top: 150px;" Theme="PlasticBlue"
                            UseMaskBehavior="True" Width="120px" Visible="False" MinDate="1900-01-01">
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
                    <asp:Label ID="Label5" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 300px; top: 150px;
                        position: absolute" Text="Até" Theme="PlasticBlue" 
                        Visible="False"></asp:Label>
                    <dx:ASPxDateEdit ID="dtprevisao2" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                        EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4;
                        position: absolute; margin-right: 5px; left: 350px; top: 150px;" Theme="PlasticBlue"
                            UseMaskBehavior="True" Width="120px" Visible="False" MinDate="1900-01-01">
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
                    <asp:Label ID="Label14" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 180px;
                        position: absolute" Text="Conta Corrente" Theme="PlasticBlue" 
                        Visible="False"></asp:Label>
                    <dx:ASPxComboBox ID="cbcontacorrente" runat="server" ValueType="System.String" Font-Bold="True"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5;
                        position: absolute; font-size: 10pt; top: 180px; left: 150px;" Width="380px"
                        Theme="PlasticBlue" AutoPostBack="True" Visible="False" 
                        OnSelectedIndexChanged="cbcontacorrente_SelectedIndexChanged">
                    </dx:ASPxComboBox>           
                    <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 210px;
                        position: absolute" Text="Protesto" Theme="PlasticBlue" 
                        Visible="False"></asp:Label>
                    <asp:RadioButtonList ID="rbprotesto" runat="server" AutoPostBack="True" CellPadding="0"
                        CellSpacing="0" Font-Names="Calibri" Font-Size="12pt" Font-Strikeout="False"
                        ForeColor="#3E5395" Style="z-index: 2; left: 150px; top: 210px;
                        position: absolute; right: 376px; height: 20px; width: 306px;" 
                        RepeatDirection="Horizontal" Visible="False">
                        <asp:ListItem Value="0" Selected="True">Todos</asp:ListItem>
                        <asp:ListItem Value="1">Protestado</asp:ListItem>
                        <asp:ListItem Value="2">Não Protestado</asp:ListItem>
                    </asp:RadioButtonList>        
                    <asp:Label ID="Label3" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 240px;
                        position: absolute" Text="Tipo Parcela" Theme="PlasticBlue" 
                        Visible="False"></asp:Label>
                    <asp:RadioButtonList ID="rbtipoparcela" runat="server" AutoPostBack="True" CellPadding="0"
                        CellSpacing="0" Font-Names="Calibri" Font-Size="12pt" Font-Strikeout="False"
                        ForeColor="#3E5395" Style="z-index: 2; left: 150px; top: 240px;
                        position: absolute; right: 118px; width: 564px; height: 16px;" 
                        RepeatDirection="Horizontal" Visible="False">
                        <asp:ListItem Value="0" Selected="True">Todas</asp:ListItem>
                        <asp:ListItem Value="1">Sinal</asp:ListItem>
                        <asp:ListItem Value="2">Normal\Renegociação</asp:ListItem>
                        <asp:ListItem Value="3">Intermediárias</asp:ListItem>
                    </asp:RadioButtonList>        
                    <asp:Label ID="Label9" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 270px;
                        position: absolute" Text="Ordenação" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <asp:RadioButtonList ID="rbordem" runat="server" AutoPostBack="True" CellPadding="0"
                        CellSpacing="0" Font-Names="Calibri" Font-Size="12pt" Font-Strikeout="False"
                        ForeColor="#3E5395" Style="z-index: 2; left: 150px; top: 270px;
                        position: absolute; right: 416px; width: 266px; height: 19px;" 
                        RepeatDirection="Horizontal" Visible="False" Enabled="False">
                        <asp:ListItem Value="0">Data de Pagamento</asp:ListItem>
                        <asp:ListItem Value="1" Selected="True">Unidade</asp:ListItem>
                    </asp:RadioButtonList>        
                    <asp:Label ID="Label10" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 300px;
                        position: absolute; right: 713px;" Text="Inclui Desistêntes" 
                        Theme="PlasticBlue" Visible="False"></asp:Label>      
                    <asp:CheckBox ID="ckdesistentes" runat="server" AutoPostBack="True" 
                        Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 15px;
                        top: 300px; left: 150px; width: 50px;" Text=" " 
                        Visible="False" Enabled="False" />          
                    <asp:Label ID="Label6" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 330px;
                        position: absolute; right: 730px;" Text="Quebra Pagina" 
                        Theme="PlasticBlue" Visible="False"></asp:Label>      
                    <asp:CheckBox ID="ckquebrapagina" runat="server" AutoPostBack="True" 
                        Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 15px;
                        top: 330px; left: 150px; width: 50px;" Text=" " 
                        Visible="False" />       
                    <asp:Label ID="Label11" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 365px;
                        position: absolute" Text="Tipo Parcela (n)" Theme="PlasticBlue" 
                        Visible="False"></asp:Label>
                    <asp:RadioButtonList ID="rbnumeroparcelas" runat="server" AutoPostBack="True" CellPadding="0"
                        CellSpacing="0" Font-Names="Calibri" Font-Size="12pt" Font-Strikeout="False"
                        ForeColor="#3E5395" Style="z-index: 2; left: 150px; top: 365px;
                        position: absolute; right: 43px; width: 639px; height: 13px;" 
                        RepeatDirection="Horizontal" Visible="False">
                        <asp:ListItem Value="0" Selected="True">Todas</asp:ListItem>
                        <asp:ListItem Value="1">1</asp:ListItem>
                        <asp:ListItem Value="2">2</asp:ListItem>
                        <asp:ListItem Value="3">3</asp:ListItem>
                        <asp:ListItem Value="4">4</asp:ListItem>
                        <asp:ListItem Value="5">5</asp:ListItem>
                        <asp:ListItem Value="6">6</asp:ListItem>
                        <asp:ListItem Value="7">7</asp:ListItem>
                        <asp:ListItem Value="8">8</asp:ListItem>
                        <asp:ListItem Value="9">9</asp:ListItem>
                        <asp:ListItem Value="10">>=10</asp:ListItem>
                    </asp:RadioButtonList>    
                    <asp:Label ID="Label12" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 400px;
                        position: absolute; right: 677px;" Text="(n) parcelas em diante?" 
                        Theme="PlasticBlue" Visible="False"></asp:Label>      
                    <asp:CheckBox ID="cknumeroparcelas" runat="server" AutoPostBack="True" 
                        Font-Bold="True" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 5; position: absolute; font-size: 15px;
                        top: 400px; left: 150px; width: 50px;" Text=" " 
                        Visible="False" />                         
                    <div id="Div2" runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute;
                        top: 20px; left: 700px; height: 50px; width: 100px;">
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
                                        Relatório Inadimplentes.<br />
                                        <br />
                                        O Relatório em questão apresenta as de parcela em aberto de um período.<br />
                                        <br />
                                        É importante informar a data final do período como limite para a pesquisa das parcelas.<br />
                                        <br />
                                        Totalizando por Data de Pagamento ou Unidade.<br />
                                        <br />
                                        A Seleção pode ser por Produto,Grupo e Unidade.<br />
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

<%@ Page Title="FCobrancaConfiguracaoNaoBancaria" Language="C#" AutoEventWireup="true" CodeFile="FCobrancaConfiguracaoNaoBancaria.aspx.cs"
    Inherits="FCobrancaConfiguracaoNaoBancaria" StylesheetTheme="Principal" %>

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
    <title>Gitano - Cobrança Não Bancária - Configuração</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <link href="../../content/toastr.css" rel="stylesheet" />
</head>
<body style="height: 1400px">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1400px">
        <ContentTemplate>
            <h1>
                COBRANÇA NÃO BANCÁRIA- CONFIGURAÇÃO</h1>
            <h2>
                Cobrança Não Bancária</h2>
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
                        position: absolute; font-size: 10pt; top: 15px; left: 150px;" 
                        Width="380px" Theme="PlasticBlue"
                        OnSelectedIndexChanged="cbbanco_SelectedIndexChanged" AutoPostBack="True">
                    </dx:ASPxComboBox>
                    <asp:Label ID="Label23" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 50px;
                        position: absolute" Text="Ultima Atualização" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxDateEdit ID="dtconfiguracao" runat="server" BackColor="#E1E6F2" DisplayFormatString="dd/MM/yyyy"
                        EditFormat="Custom" EditFormatString="dd/MM/yyyy" EnableTheming="True" Font-Bold="False"
                        Font-Names="Calibri" Font-Size="15px" ForeColor="#3E5395" Height="16px" Style="z-index: 4;
                        position: absolute; margin-right: 5px; left: 150px; top: 50px;" Theme="PlasticBlue"
                             UseMaskBehavior="True" Width="120px" Visible="False" Enabled="False" MinDate="1900-01-01">
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
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 85px;
                        position: absolute" Text="Drive Dados" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="eddrivedados" runat="server" Style="z-index: 2; left: 150px;
                        top: 85px; position: absolute; right: 223px;" Theme="PlasticBlue" Width="200px"
                        Visible="False" AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label6" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 120px;
                        position: absolute" Text="Pasta Remessa" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edpastaremessa" runat="server" Style="z-index: 2; left: 150px; top: 120px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="400px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <dx:ASPxTextBox ID="edextensaoremessa" runat="server" Style="z-index: 2; left: 560px; top: 120px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="100px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label2" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 155px;
                        position: absolute" Text="Pasta Retorno" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edpastaretorno" runat="server" Style="z-index: 2; left: 150px; top: 155px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="400px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <dx:ASPxTextBox ID="edextensaoretorno" runat="server" Style="z-index: 2; left: 560px; top: 155px;
                        position: absolute; right: 223px;" Theme="PlasticBlue" Width="100px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label4" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 190px;
                        position: absolute" Text="Pasta Envelope" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edpastaenvelope" runat="server" Style="z-index: 2; left: 150px; top: 190px;
                        position: absolute; right: 282px;" Theme="PlasticBlue" Width="400px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label16" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 225px;
                        position: absolute" Text="Assunto" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edassunto" runat="server" Style="z-index: 2; left: 150px; top: 225px;
                        position: absolute; right: 282px;" Theme="PlasticBlue" Width="400px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label7" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 260px;
                        position: absolute" Text="Devolução Título (Dias)" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="eddevolucaotitulos" runat="server" Style="z-index: 2; left: 150px; top: 260px;
                        position: absolute; right: 282px;" Theme="PlasticBlue" Width="100px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label8" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 295px;
                        position: absolute" Text="Protesto (Dias)" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edprotesto" runat="server" Style="z-index: 2; left: 150px; top: 295px;
                        position: absolute; right: 282px;" Theme="PlasticBlue" Width="100px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label9" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 330px;
                        position: absolute" Text="Cobrança Multa (Dias)" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edcobrancamulta" runat="server" Style="z-index: 2; left: 150px; top: 330px;
                        position: absolute; right: 582px;" Theme="PlasticBlue" Width="100px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label10" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 365px;
                        position: absolute" Text="Multa (%)" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edmulta" runat="server" Style="z-index: 2; left: 150px; top: 365px;
                        position: absolute; right: 282px;" Theme="PlasticBlue" Width="100px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label11" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 400px;
                        position: absolute" Text="Juros (%)" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edjuros" runat="server" Style="z-index: 2; left: 150px; top: 400px;
                        position: absolute; right: 282px;" Theme="PlasticBlue" Width="100px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label12" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 435px;
                        position: absolute" Text="Com.Permanência (%)" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edcomissao" runat="server" Style="z-index: 2; left: 150px; top: 435px;
                        position: absolute; right: 282px;" Theme="PlasticBlue" Width="100px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label13" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 470px;
                        position: absolute" Text="Caixa Postal" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edcaixapostal" runat="server" Style="z-index: 2; left: 150px; top: 470px;
                        position: absolute; right: 282px;" Theme="PlasticBlue" Width="100px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label14" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 505px;
                        position: absolute" Text="Remessa No." Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edremessa" runat="server" Style="z-index: 2; left: 150px; top: 505px;
                        position: absolute; right: 282px;" Theme="PlasticBlue" Width="100px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label15" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 540px;
                        position: absolute" Text="Carteira No." Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edcarteira" runat="server" Style="z-index: 2; left: 150px; top: 540px;
                        position: absolute; right: 282px;" Theme="PlasticBlue" Width="100px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label17" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 575px;
                        position: absolute" Text="No. Inicial-Final" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="ednuminicial" runat="server" Style="z-index: 2; left: 150px; top: 575px;
                        position: absolute; right: 282px;" Theme="PlasticBlue" Width="100px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <dx:ASPxTextBox ID="ednumfinal" runat="server" Style="z-index: 2; left: 300px; top: 575px;
                        position: absolute; right: 282px;" Theme="PlasticBlue" Width="100px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label18" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 610px;
                        position: absolute" Text="No. Atual" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="ednumatual" runat="server" Style="z-index: 2; left: 150px; top: 610px;
                        position: absolute; right: 282px;" Theme="PlasticBlue" Width="100px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label19" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 645px;
                        position: absolute" Text="Complemento" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edcomplemento" runat="server" Style="z-index: 2; left: 150px; top: 645px;
                        position: absolute; right: 582px;" Theme="PlasticBlue" Width="100px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label20" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 680px;
                        position: absolute" Text="Ultimo Arquivo" Theme="PlasticBlue" 
                        Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="ednomearquivo" runat="server" Style="z-index: 2; left: 150px; top: 680px;
                        position: absolute; right: 582px;" Theme="PlasticBlue" Width="200px" Visible="False"
                        AutoPostBack="True" ReadOnly="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label21" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 715px;
                        position: absolute" Text="Numero Arquivo" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="ednumeroarquivo" runat="server" Style="z-index: 2; left: 150px; top: 715px;
                        position: absolute; right: 582px;" Theme="PlasticBlue" Width="100px" Visible="False"
                        AutoPostBack="True">
                    </dx:ASPxTextBox>
                    <asp:Label ID="Label24" runat="server" BackColor="White" Font-Bold="False" Font-Names="Calibri"
                        Font-Size="15px" ForeColor="#3E5395" Style="z-index: 2; left: 9px; top: 750px;
                        position: absolute" Text="Feedback" Theme="PlasticBlue" Visible="False"></asp:Label>
                    <dx:ASPxTextBox ID="edfeedback" runat="server" Style="z-index: 2; left: 150px; top: 750px;
                        position: absolute; right: 82px;" Theme="PlasticBlue" Width="600px" Visible="False"
                        AutoPostBack="True" ReadOnly="True">
                    </dx:ASPxTextBox>
                    <div id="Div2" runat="server" style="border: 1px solid #808080; z-index: 2; position: absolute;
                        top: 15px; left: 700px; height: 50px; width: 100px; bottom: 1133px;">
                        <dx:ASPxButton ID="btprocessa" runat="server" Height="40px" ImagePosition="Left"
                            OnClick="btprocessa_Click" Width="45px">
                            <Image Height="30px" ToolTip="Processa Criação" Url="~/images/BotoesTelas/BTNalterarA.bmp"
                                UrlDisabled="~/images/BotoesTelas/BTNalterarI.bmp" UrlPressed="~/images/BotoesTelas/BTNalterarS.bmp"
                                Width="30px">
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
                    <div runat="server" style="z-index: 2; position: absolute; top: 1200px; left: 10px;
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
                                        Incluir Parcela Nova.<br />
                                        <br />
                                        O Processo de incluir uma parcela nova em um financiamento e uma situação extraordinária
                                        e não deve ser utilizada sem critério. O Contrato assinado pelas partes rege o gerenciamento
                                        do contrato, caso exista erro no momento da venda, o correto é refazer a venda.<br />
                                        <br />
                                        Sendo necessário incluir a parcela devemos observar qual o tipo de correção do contrato.
                                        O valor da parcela incluida deve ser o valor na DATA BASE do contrato, não o valor
                                        atual, podendo gerar valores errados a partir de uma correção.<br />
                                        <br />
                                        Caso seja necessário, solicite suporte ou orientação necessária antes de prosseguir.<br />
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

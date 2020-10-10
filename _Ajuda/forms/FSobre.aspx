<%@ Page Title="FSobre" Language="C#" AutoEventWireup="true" CodeFile="FSobre.aspx.cs"
    Inherits="FSobre" StylesheetTheme="Principal" %>

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
    <title>Gitano - Ajuda - Sobre Nós</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body style="height: 1200px">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1200px">
        <ContentTemplate>
            <h1>
                AJUDA - SOBRE NÓS</h1>
            <h2>
                SOBRE NÓS</h2>
            <div id="DivNova" style="border-style: none">
                <div style="border: 0px; z-index: 1; left: 35px; top: 100px; position: absolute;
                    height: 481px; width: 832px; text-align: center;">
                    <div style="border: 0px; z-index: 1; left: 10px; top: 10px; position: absolute; height: 400px;
                        width: 400px; text-align: left;">
                        <h2>
                            Nossa História</h2>
                        <br />
                        Constituida em 1997 como empresa a Símbolo Reengenharia Empresarial foi o fruto
                        da experiência de mais de uma década em soluções empresariais.<br />
                        <br />
                        A Gitano Software nasce como empresa filha desta caminhada, com mais de 300 clientes
                        atendidos em todo o Brasil durante mais 20 anos, a Gitano atualizada tecnológicamente
                        traz uma linguagem atual no uso da tecnologia, aplicando em seus produtos ferramental
                        moderno e usual no mundo do desenvolvimento de software, trazendo para seus clientes
                        soluções robustas, atuais e com portabilidade para continuar evoluindo.<br />
                        <br />
                        <br />
                        Temos a alegria de sermos reconheçidos pela seriedade e honestidade no trato dos
                        problemas de nossos clientes.<br />
                        <br />
                        Nascemos como empresa sempre preservando a proximidade com o cliente e seus desafios
                        diários e assim seguiremos nossa caminhada.<br />
                        <br />
                    </div>
                    <div style="border: 0px; z-index: 1; left: 420px; top: 10px; position: absolute;
                        height: 400px; width: 400px; text-align: left;">
                        <h2>
                            Quem Somos</h2>
                        <br />
                        Airam Miranda<br />
                        <br />
                        Evangelista em Tecnologia, Gestor, Desenvolvedor de Software formado na PUC-RJ,
                        Profissional de TI desde a década de 80.<br />
                        Atua na Direção de toda parte técnológica da empresa.<br />
                        <br />
                        <br />
                        Vivian Teixeira<br />
                        <br />
                        Pedagoga, Pós Graduada em Publicidade e Marketing.<br />
                        Atua na Direção Administrativa e Comercial.<br />
                        <br />
                    </div>
                    <div style="border: 0px; z-index: 1; left: 10px; top: 420px; position: absolute;
                        height: 400px; width: 400px; text-align: left;">
                        <h2>
                            Fale Conosco</h2>
                        <br />
                        <br />
                        Fone (12) 3307-4310 (12) 99664-6156<br />
                        <br />
                        e-mail: gitanosoftware@terra.com.br<br />
                    </div>
                    <div style="border: 0px; z-index: 1; left: 420px; top: 420px; position: absolute;
                        height: 400px; width: 400px; text-align: left;">
                        <h2>
                            Dúvidas, Críticas, Idéias e Colaborações.</h2>
                        <br />
                        <br />
                        <br />
                        e-mail: gitanosuporte@terra.com.br<br />
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

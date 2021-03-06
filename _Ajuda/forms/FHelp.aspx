﻿<%@ Page Title="FHelp" Language="C#" AutoEventWireup="true" CodeFile="FHelp.aspx.cs"
    Inherits="FHelp" StylesheetTheme="Principal" %>

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
    <title>Gitano - Ajuda - Help</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body style="height: 1200px">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <asp:UpdatePanel ID="UpdatePanel" runat="server" style="height: 1200px">
        <ContentTemplate>
            <h1>
                AJUDA - HELP</h1>
            <h2>
                HELP</h2>
            <div id="DivNova" style="border-style: none">
                <div style="border: 0px; z-index: 1; left: 35px; top: 100px; position: absolute; height: 481px;
                    width: 832px; text-align: center;">
                    <div style="border: 0px; z-index: 1; left: 10px; top: 10px; position: absolute; height: 400px;
                        width: 400px; text-align: left;">
                        <h2>
                            Suporte e Assistência</h2>
                        <br />
                        <br />   
                        <h1>
                            TELEFONES
                            (12) 3307-4310
                            (12) 99664-6156</h1>
                        <br />
                        <h1>
                            E-MAIL SUPORTE
                            GITANOSUPORTE@TERRA.COM.BR</h1>
                        <br />
                        <h1>
                            E-MAIL ADMINISTRATIVO
                            GITANOSOFTWARE@TERRA.COM.BR</h1>
                        <br />
                        <h1>
                            E-MAIL TÉCNICO
                            AIRAM1968@TERRA.COM.BR</h1>
                        <br /> 
                    </div>
                    <div style="border: 0px; z-index: 1; left: 420px; top: 10px; position: absolute;
                        height: 400px; width: 400px; text-align: left;">
                        <h2>
                            HELP/AJUDA</h2>
                        <br />
                        <br />
                        <h1>
                            O HELP/AJUDA DO SISTEMA ESTÁ PRESENTE EM TODAS AS TELAS.</h1>
                        <br />
                        <h1>
                            CLICANDO NA IMAGEM DE (?) NA TELA O TEXTO DE AJUDA SERÁ APRESENTADO.</h1>
                        <br />
                        <br />
                        <h2>
                            DESEJA COLABORAR?.</h2>
                        <br />
                        <h1>
                            VOCÊ PODE COLABORAR, COPIE O TEXTO ATUAL DE HELP/AJUDA, INFORME QUAL FUNÇÃO DO SISTEMA SE REFERE, E APRESENTE SEU TEXTO DE HELP POR EMAIL. APÓS ANÁLISE SUBSTITUIREMOS O TEXTO EXISTENTE PELO NOVO. O TEXTO EVENTUALMENTE SOFRERÁ ALTERAÇÕES, COMPLEMENTAÇÕES OU CORREÇÕES, CASO NECESSÁRIO, CITAREMOS O(S) COLABORADOR(ES).</h1>
                        <br />

                    </div>
                    <div style="border: 0px; z-index: 1; left: 10px; top: 420px; position: absolute;
                        height: 400px; width: 400px; text-align: left;">
                        <h2>
                        </h2>
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                    </div>
                    <div style="border: 0px; z-index: 1; left: 420px; top: 420px; position: absolute;
                        height: 400px; width: 400px; text-align: left;">
                        <h2>
                        </h2>
                        <br />
                        <br />
                        <br />
                        <br />
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

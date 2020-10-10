<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AcessoNegado.aspx.cs" Inherits="AcessoNegado"
    StylesheetTheme="Principal" Title="Erro Interno - Acesso Negado" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Erro Interno</title>
</head>
<body>
    <form id="form1" runat="server">
    <h1 style="font-family: Calibri; font-size: 15px; text-align: left;">
        GITANO</h1>
    <h2 style="font-family: Calibri; text-align: left; margin-top: 0px;">
        Erro INTERNO - Acesso NEGADO</h2>
    <div>
        <div style="position: absolute; left: 100px; top: 200px">
            <dx:ASPxMemo ID="Memo_Texto" runat="server" Height="200px" Width="500px" 
                AutoPostBack="True" ReadOnly="True">
            </dx:ASPxMemo>
        </div>
    </div>
    </form>
</body>
</html>

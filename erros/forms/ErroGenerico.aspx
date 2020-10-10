<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ErroGenerico.aspx.cs" Inherits="ErroGenerico"
    StylesheetTheme="Principal" Title="Erro Genérico" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Erro Genérico</title>
</head>
<body>
    <form id="form1" runat="server">
    <h1 style="font-family: Calibri; font-size: 15px; text-align: left;">
        GITANO</h1>
    <h2 style="font-family: Calibri; text-align: left; margin-top: 0px;">
        Erro Genérico</h2>
    <div>
        <div style="position: absolute; left: 100px; top: 200px">
            <dx:ASPxImage ID="ASPxImage1" runat="server" ImageUrl="~/images/logintimeout.jpg">
            </dx:ASPxImage>
        </div>
    </div>
    </form>
</body>
</html>

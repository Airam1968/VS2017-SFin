<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FundoPadraoMensagens.aspx.cs"
    Inherits="FundoPadraoMensagens" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1
        {
            height: 589px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 1214px; height: 340px; margin-top: 51px;">
        <div style="padding: 20px; display: inline-block; vertical-align: top;">
            <dx:ASPxRoundPanel ID="RoundPanelAlertas" ClientInstanceName="RoundPanelAlertas"
                HeaderText="Alertas Jurídicos" runat="server" Width="400px" Height="200px" BackColor="White">
                <HeaderStyle BackColor="#DEDEDE">
                    <BorderLeft BorderStyle="None" />
                    <BorderRight BorderStyle="None" />
                    <BorderBottom BorderStyle="None" />
                </HeaderStyle>
                <TopLeftCorner Height="5px" Url="~/Images/ASPxRoundPanel/1769204767/TopLeftCorner.png"
                    Width="5px">
                </TopLeftCorner>
                <NoHeaderTopLeftCorner Height="5px" Url="~/Images/ASPxRoundPanel/1769204767/NoHeaderTopLeftCorner.png"
                    Width="5px">
                </NoHeaderTopLeftCorner>
                <TopRightCorner Height="5px" Url="~/Images/ASPxRoundPanel/1769204767/TopRightCorner.png"
                    Width="5px">
                </TopRightCorner>
                <NoHeaderTopRightCorner Height="5px" Url="~/Images/ASPxRoundPanel/1769204767/NoHeaderTopRightCorner.png"
                    Width="5px">
                </NoHeaderTopRightCorner>
                <BottomRightCorner Height="5px" Url="~/Images/ASPxRoundPanel/1769204767/BottomRightCorner.png"
                    Width="5px">
                </BottomRightCorner>
                <BottomLeftCorner Height="5px" Url="~/Images/ASPxRoundPanel/1769204767/BottomLeftCorner.png"
                    Width="5px">
                </BottomLeftCorner>
                <HeaderLeftEdge>
                    <BackgroundImage HorizontalPosition="left" ImageUrl="~/Images/ASPxRoundPanel/1769204767/HeaderLeftEdge.png"
                        Repeat="NoRepeat" VerticalPosition="bottom" />
                </HeaderLeftEdge>
                <HeaderContent>
                    <BackgroundImage HorizontalPosition="left" ImageUrl="~/Images/ASPxRoundPanel/1769204767/HeaderContent.png"
                        Repeat="RepeatX" VerticalPosition="bottom" />
                </HeaderContent>
                <HeaderRightEdge>
                    <BackgroundImage HorizontalPosition="right" ImageUrl="~/Images/ASPxRoundPanel/1769204767/HeaderRightEdge.png"
                        Repeat="NoRepeat" VerticalPosition="bottom" />
                </HeaderRightEdge>
                <PanelCollection>
                    <dx:PanelContent>
                        <dx:ASPxMemo ID="MemoJuridico" runat="server" Height="180px" Width="380px">
                        </dx:ASPxMemo>
                    </dx:PanelContent>
                </PanelCollection>
                <Border BorderColor="#8B8B8B" BorderStyle="Solid" BorderWidth="1px" />
            </dx:ASPxRoundPanel>
        </div>
        <div style="padding: 20px; display: inline-block; vertical-align: top;">
            <dx:ASPxRoundPanel ID="RoundPanelAdministrativo" ClientInstanceName="RoundPanelAdministrativo"
                HeaderText="Alertas Administrativos" runat="server" Width="400px" Height="200px"
                BackColor="White">
                <HeaderStyle BackColor="#DEDEDE">
                    <BorderLeft BorderStyle="None" />
                    <BorderRight BorderStyle="None" />
                    <BorderBottom BorderStyle="None" />
                </HeaderStyle>
                <TopLeftCorner Height="5px" Url="~/Images/ASPxRoundPanel/2041945718/TopLeftCorner.png"
                    Width="5px">
                </TopLeftCorner>
                <NoHeaderTopLeftCorner Height="5px" Url="~/Images/ASPxRoundPanel/2041945718/NoHeaderTopLeftCorner.png"
                    Width="5px">
                </NoHeaderTopLeftCorner>
                <TopRightCorner Height="5px" Url="~/Images/ASPxRoundPanel/2041945718/TopRightCorner.png"
                    Width="5px">
                </TopRightCorner>
                <NoHeaderTopRightCorner Height="5px" Url="~/Images/ASPxRoundPanel/2041945718/NoHeaderTopRightCorner.png"
                    Width="5px">
                </NoHeaderTopRightCorner>
                <BottomRightCorner Height="5px" Url="~/Images/ASPxRoundPanel/2041945718/BottomRightCorner.png"
                    Width="5px">
                </BottomRightCorner>
                <BottomLeftCorner Height="5px" Url="~/Images/ASPxRoundPanel/2041945718/BottomLeftCorner.png"
                    Width="5px">
                </BottomLeftCorner>
                <HeaderLeftEdge>
                    <BackgroundImage HorizontalPosition="left" ImageUrl="~/Images/ASPxRoundPanel/2041945718/HeaderLeftEdge.png"
                        Repeat="NoRepeat" VerticalPosition="bottom" />
                </HeaderLeftEdge>
                <HeaderContent>
                    <BackgroundImage HorizontalPosition="left" ImageUrl="~/Images/ASPxRoundPanel/2041945718/HeaderContent.png"
                        Repeat="RepeatX" VerticalPosition="bottom" />
                </HeaderContent>
                <HeaderRightEdge>
                    <BackgroundImage HorizontalPosition="right" ImageUrl="~/Images/ASPxRoundPanel/2041945718/HeaderRightEdge.png"
                        Repeat="NoRepeat" VerticalPosition="bottom" />
                </HeaderRightEdge>
                <PanelCollection>
                    <dx:PanelContent>
                        <dx:ASPxMemo ID="MemoAdministrativo" runat="server" Height="180px" Width="380px">
                        </dx:ASPxMemo>
                    </dx:PanelContent>
                </PanelCollection>
                <Border BorderColor="#8B8B8B" BorderStyle="Solid" BorderWidth="1px" />
            </dx:ASPxRoundPanel>
        </div>
    </div>
    </form>
</body>
</html>

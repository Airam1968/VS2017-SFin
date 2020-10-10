<%@ Page Title="Gitano Login" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Login.aspx.cs" Inherits="Login" StylesheetTheme="Login" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <script runat="server"></script>
    <script type="text/javascript" src="../../Scripts/jquery-1.6.3.min.js"></script>
    <script type="text/javascript" src="../../Scripts/toastr.min.js"></script>
    <div id="Main">
        <div style="border: 1px solid #47577A; width: 303px; height: 385px; position: relative; top: 30px; left: 27px; margin-left: 393px; margin-top: 0px;">
            <div style="text-align: center; position: relative; top: 58px; left: 112px; width: 82px;">
                <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="SFin" Theme="iOS" Font-Names="Calibri"
                    Font-Size="18pt">
                </dx:ASPxLabel>
            </div>
            <div style="width: 27px; position: relative; top: 35px; left: 200px;">
                <dx:ASPxImage ID="ASPxImage1" runat="server" Height="25px" ImageUrl="~/images/icones/lock_closed.png"
                    Width="25px">
                </dx:ASPxImage>
            </div>
            <div style="height: 36px; width: 266px; margin-left: 16px; font-size: 13px; font-family: Calibri; position: relative; top: 4px; left: 2px; text-align: center; color: #FFFFFF;">
            </div>
            <div style="width: 264px; height: 243px; margin-left: 63px; margin-top: 32px; position: relative; top: -21px; left: -42px;">
                <div style="width: 204px; position: relative; top: 15px; left: 28px;">
                    <asp:Label ID="lbbase111" runat="server" CssClass="lbusuario111" Font-Bold="True"
                        ForeColor="#3E5395">Base:</asp:Label>
                    <dx:ASPxComboBox ID="ComboBases" runat="server" ValueType="System.String" AutoPostBack="True"
                        MaxLength="20" Width="200px" OnTextChanged="ComboBases_TextChanged" Theme="PlasticBlue"
                        BackColor="#E1E6F2" ForeColor="#3E5395"
                        ToolTip="Informe aqui a Base SQL Configurada no Sistema">
                        <Border BorderColor="#415698" BorderStyle="Solid" BorderWidth="1px" />
                    </dx:ASPxComboBox>
                </div>
                <div style="width: 207px; position: relative; top: 35px; left: 28px">
                    <asp:Label ID="lbusuario111" runat="server" CssClass="lbusuario111" Font-Bold="True"
                        ForeColor="#3E5395">Usuário:</asp:Label>
                    <dx:ASPxTextBox ID="edusuario" runat="server" CssClass="edusuario" MaxLength="20"
                        Width="200px" OnTextChanged="edusuario_TextChanged" Theme="PlasticBlue" BackColor="#E1E6F2"
                        ForeColor="#3E5395" ToolTip="Nome de Usuário Válido ">
                        <ValidationSettings ErrorTextPosition="Bottom">
                        </ValidationSettings>
                        <Border BorderColor="#415698" BorderStyle="Solid" BorderWidth="1px" />
                    </dx:ASPxTextBox>
                </div>
                <div style="width: 208px; top: 48px; left: 28px; height: 48px; position: relative;">
                    <asp:Label ID="lbsenha11" runat="server" CssClass="lbsenha111" Font-Bold="True" ForeColor="#3E5395">Senha:</asp:Label>
                    <dx:ASPxTextBox ID="edsenha" runat="server" CssClass="edsenha" MaxLength="10" Password="True"
                        Width="200px" OnTextChanged="edsenha_TextChanged" Theme="PlasticBlue" BackColor="#E1E6F2"
                        ForeColor="#3E5395" ToolTip="Senha Válida para o Usuario Informado">
                        <MaskSettings Mask="&gt;cccccccccc" />
                        <ValidationSettings ErrorTextPosition="Bottom">
                        </ValidationSettings>
                        <Border BorderColor="#415698" BorderStyle="Solid" BorderWidth="1px" />
                    </dx:ASPxTextBox>
                </div>
                <div style="color: #FF0000; position: relative; top: 45px; left: 28px; width: 220px; text-align: left;">
                    <dx:ASPxLabel ID="lbmsg" runat="server" Text="" CssClass="lbmsg" Theme="Office2010Blue"
                        Font-Size="10px">
                    </dx:ASPxLabel>
                </div>
                <div style="width: 115px; height: 25px; position: relative; top: 73px; left: 67px;">
                    <dx:ASPxButton ID="LoginButton" runat="server" Height="30px" ValidateInvisibleEditors="True"
                        Width="128px" BackColor="White" CommandName="Login"
                        OnClick="LoginButton_Click" ToolTip="Processa a tentativa de Login">
                        <Image Height="25px" Url="~/images/Botoes/botLog2.jpg" UrlHottracked="~/images/Botoes/botLog1.jpg"
                            Width="115px" ToolTip="Login" UrlPressed="~/images/Botoes/botLog3.jpg">
                        </Image>
                        <Paddings Padding="0px" />
                        <Paddings Padding="0px"></Paddings>
                        <CheckedStyle BackColor="White">
                            <Border BorderStyle="None" />
                            <Border BorderStyle="None"></Border>
                        </CheckedStyle>
                        <PressedStyle BackColor="White">
                        </PressedStyle>
                        <HoverStyle BackColor="White">
                            <Border BorderStyle="None" />
                            <BorderLeft BorderStyle="None" />
                            <BorderTop BorderStyle="None" />
                            <BorderRight BorderStyle="None" />
                            <BorderBottom BorderStyle="None" />
                            <Border BorderStyle="None"></Border>
                            <BorderLeft BorderStyle="None"></BorderLeft>
                            <BorderTop BorderStyle="None"></BorderTop>
                            <BorderRight BorderStyle="None"></BorderRight>
                            <BorderBottom BorderStyle="None"></BorderBottom>
                        </HoverStyle>
                        <FocusRectPaddings Padding="0px" />
                        <FocusRectBorder BorderStyle="None" BorderColor="White" />
                        <BackgroundImage HorizontalPosition="center" Repeat="NoRepeat" />
                        <Border BorderStyle="None" />
                        <BorderLeft BorderStyle="None" />
                        <BorderTop BorderStyle="None" />
                        <BorderRight BorderStyle="None" />
                        <BorderBottom BorderStyle="None" />
                        <FocusRectPaddings Padding="0px"></FocusRectPaddings>
                        <FocusRectBorder BorderColor="White" BorderStyle="None"></FocusRectBorder>
                        <BackgroundImage Repeat="NoRepeat" HorizontalPosition="center"></BackgroundImage>
                        <Border BorderStyle="None"></Border>
                        <BorderLeft BorderStyle="None"></BorderLeft>
                        <BorderTop BorderStyle="None"></BorderTop>
                        <BorderRight BorderStyle="None"></BorderRight>
                        <BorderBottom BorderStyle="None"></BorderBottom>
                    </dx:ASPxButton>
                </div>
            </div>
        </div>
        <div style="width: 40px; height: 40px; position: relative; top: -300px; left: 482px; margin-top: 0px">
            <dx:ASPxImage ID="ASPxImage2" runat="server" Height="40px" ImageUrl="~/images/bola_GIT.jpg">
            </dx:ASPxImage>
        </div>
    </div>
</asp:Content>

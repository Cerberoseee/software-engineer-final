<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Staff__WebForm_._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1 style="text-align: center; margin-bottom: 24px">Staff Login</h1>
        <div style="margin: auto; width: 25%;">
            <div style="width: 100%; margin:auto; display: block">
                Username
                <asp:TextBox ID="txtUsername" runat="server" Width="100%"></asp:TextBox>
                <br />
                Password
                <asp:TextBox ID="txtPassword" runat="server" Width="100%" TextMode="Password"></asp:TextBox>
                <div style="display: block; margin-top: 12px; text-align: center;">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                </div>
                <div style="margin-top: 12px; text-align: center">
                    <asp:Label  ID="msgFailed" runat="server" Text="Login Failed! Please check your information"></asp:Label>
                </div>
                <div style="margin-top: 12px; text-align: center">
                    <asp:Label  ID="msgSuccess" runat="server" Text="Login Success!"></asp:Label>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Pizza_Projekt.Login" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="menu-fluid" style="height: 860px;">
        <div class="login-box">
            <center>
                <p class="login-title"><strong>Login to your account</strong></p>
            </center>
            <hr class="title-line" />

            <p class="login-text">Username:</p>
            <div class="form-element">
                <asp:TextBox ID="TB_Username" runat="server" CssClass="login-input"></asp:TextBox>
            </div>
            
            <p class="login-text">Password:</p>
            <div class="form-element">
                <asp:TextBox ID="TB_Password" runat="server" CssClass="login-input"></asp:TextBox>
            </div>
            <asp:Button ID="LoginButton" runat="server" Text="Login" CssClass="login-button" OnClick="LoginButton_Click" />
            <asp:Label ID="AlertBox" runat="server" Text=""></asp:Label>
        </div>  
    </div>
</asp:Content>

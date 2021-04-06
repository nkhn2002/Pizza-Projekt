<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Pizza_Projekt.Register" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="menu-fluid" style="height: 860px;">
        <div class="register-box">
            <center>
                <p class="register-title"><strong>Register your account</strong></p>
            </center>
            <hr class="title-line" />
            <p class="register-desc">Your username must be 6-12 characters long and your password must be 8-32 characters long with 1 big letter</p>

            <p class="register-text">Username:</p>
            <div class="form-element">
                <asp:TextBox ID="TB_Username" runat="server" CssClass="register-input"></asp:TextBox>
            </div>
            
            <p class="register-text">Password:</p>
            <div class="form-element">
                <asp:TextBox ID="TB_Password" runat="server" CssClass="register-input"></asp:TextBox>
            </div>
            <asp:Button ID="RegButton" runat="server" Text="Create Account" CssClass="register-button" OnClick="RegButton_Click" />
            <asp:Label ID="AlertBox" runat="server" Text=""></asp:Label>
        </div>  
    </div>
</asp:Content>

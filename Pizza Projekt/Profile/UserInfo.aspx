<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfo.aspx.cs" Inherits="Pizza_Projekt.Profile.UserInfo" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="menu-fluid" style="height: 860px;">
        <div class="profile-box">
                <center>
                <p class="login-title"><strong>Your account</strong></p>
            </center>
                <hr class="title-line" />

                <asp:Button ID="UserInfo_Btn" runat="server" Text="User Information" CssClass="profile-button" />
                <asp:Button ID="OrderHistory_Btn" runat="server" Text="Order History      " CssClass="profile-button" />
                <asp:Button ID="Address_Btn" runat="server" Text="Delivery Address" CssClass="profile-button" />
                <asp:Button ID="AccSettings_Btn" runat="server" Text="Account Settings" CssClass="profile-button" />
                <asp:Label ID="AlertBox" runat="server" Text=""></asp:Label>
            </div>
        <div class="profile-section">
                <center>
                <p class="login-title"><strong>Your information</strong></p>
            </center>
                <hr class="title-line" />
            
            <p class="login-text">Full name:</p>
            <div class="form-element">
                <asp:TextBox ID="Name" runat="server" CssClass="section-input"></asp:TextBox>
            </div>

            <p class="login-text">Address:</p>
            <div class="form-element">
                <asp:TextBox ID="Address" runat="server" CssClass="section-input"></asp:TextBox>
            </div>

            <p class="login-text">Phone number:</p>
            <div class="form-element">
                <asp:TextBox ID="Phone" runat="server" CssClass="section-input"></asp:TextBox>
            </div>
            </div>
    </div>
</asp:Content>

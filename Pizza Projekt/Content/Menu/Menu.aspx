﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Pizza_Projekt.Content.Menu.Menu" MasterPageFile="~/Site.Master" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="menu-fluid">
        <div class="menu-section" style="height:540px;">
            <center>
                <h1 style="color:#278ea5;"><strong>Menu kort</strong></h1>
            </center>
            <div class="menu-box" style="margin-top: 50px;">
                <asp:Table ID="SalatPizza" runat="server">
                <asp:TableRow runat="server" class="table-menu">
                    <asp:TableCell runat="server">Royal</asp:TableCell>
                    <asp:TableCell runat="server">kebab, champignon, gorgonzola, løg</asp:TableCell>
                    <asp:TableCell runat="server">63,- 85,- 125,-</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" class="table-menu">
                    <asp:TableCell runat="server">Royal</asp:TableCell>
                    <asp:TableCell runat="server">kebab, champignon, gorgonzola, løg</asp:TableCell>
                    <asp:TableCell runat="server">63,- 85,- 125,-</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" class="table-menu">
                    <asp:TableCell runat="server">Royal</asp:TableCell>
                    <asp:TableCell runat="server">kebab, champignon, gorgonzola, løg</asp:TableCell>
                    <asp:TableCell runat="server">63,- 85,- 125,-</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            </div>
        </div>
    </div>
</asp:Content>
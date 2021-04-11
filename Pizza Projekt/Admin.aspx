<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Pizza_Projekt.Admin" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="forside-section" style="height: 680px;">
        <div class="admin-box">
            <center>
                <p class="login-title"><strong>Admin Menu</strong></p>
            </center>
            <hr class="title-line" />

            <asp:Button ID="EditMenu" runat="server" Text="       Edit Menu       " CssClass="profile-button" />
            <asp:Button ID="AccountOverview" runat="server" Text="Account Overview" CssClass="profile-button" />
        </div>

        <div class="menu-box" style="margin-top: 120px;">
            <h1>Edit Menu</h1>
            <asp:GridView ID="MenuGrid" runat="server" AutoGenerateColumns="False" Height="80px" Width="550px" CssClass="menu-table" Style="width: 800px;">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" InsertVisible="False" SortExpression="ID"></asp:BoundField>
                    <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username"></asp:BoundField>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address"></asp:BoundField>
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email"></asp:BoundField>
                    <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone"></asp:BoundField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button CssClass="menu-button" Style="color: black;" ID="EditUser" Text="Edit User" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>

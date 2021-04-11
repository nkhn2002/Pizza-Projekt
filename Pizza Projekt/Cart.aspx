<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Pizza_Projekt.Cart" MasterPageFile="~/Site.Master"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <head>
        <style>
            .cart-label {
                font-size: 24px;
            }
        </style>
    </head>
    <div class="menu-fluid" style="height: 860px;">
        <div class="cart-box" style="margin-top: 50px;">

            <asp:Label ID="CartHeaderLabel" runat="server" Text="" CssClass="cart-label"></asp:Label>

            <asp:GridView ID="MenuGrid" runat="server" AutoGenerateColumns="False" Height="80px" Width="550px" CssClass="menu-table" Style="width: 800px;">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
                    <asp:BoundField DataField="Toppings" HeaderText="Toppings" SortExpression="Toppings"></asp:BoundField>
                    <asp:BoundField DataField="Price" HeaderText="DKK" SortExpression="Price"></asp:BoundField>
                </Columns>
            </asp:GridView>
            <br />
            <asp:Button CssClass="menu-button" Style="color: black;" ID="CheckoutCart" Text="Checkout" runat="server"/>
        </div>
    </div>
</asp:Content>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Pizza_Projekt.Content.Menu.Menu" MasterPageFile="~/Site.Master" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <head>
        <style>
            .toast-top-right {
                right: 10px;
                top: 90px;
            }
        </style>

        <script>
            toastr.options = {
                timeOut: 2500,
                extendedTimeOut: 100,
                tapToDismiss: true,
                debug: false,
                fadeOut: 10,
                positionClass: "toast-top-right"
            };
        </script>
    </head>
    <div class="menu-fluid" style="height: 860px;">
        <div class="menu-box" style="margin-top: 50px;">
            <h1>Menu Kort</h1>
            <asp:GridView ID="MenuGrid" runat="server" AutoGenerateColumns="False" Height="150px" Width="550px" CssClass="menu-table" Style="width: 800px;">
                <Columns>
                    <asp:BoundField DataField="PizzaID" HeaderText="No." ReadOnly="True" InsertVisible="False" SortExpression="PizzaID"></asp:BoundField>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
                    <asp:BoundField DataField="Toppings" HeaderText="Toppings" SortExpression="Toppings"></asp:BoundField>
                    <asp:BoundField DataField="Price" HeaderText="DKK" SortExpression="Price"></asp:BoundField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button CssClass="menu-button" Style="color: black;" ID="AddToCart" Text="Tilføj" runat="server" OnClick="AddToCart_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>

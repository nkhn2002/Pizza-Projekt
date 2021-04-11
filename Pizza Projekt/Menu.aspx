<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Pizza_Projekt.Content.Menu.Menu" MasterPageFile="~/Site.Master" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="menu-fluid" style="height: 860px;">
        <div class="menu-box" style="margin-top: 50px;">
            <asp:GridView ID="MenuGrid" runat="server" AutoGenerateColumns="False" Height="150px" Width="550px">
                <Columns>
                    <asp:BoundField DataField="PizzaID" HeaderText="No." ReadOnly="True" InsertVisible="False" SortExpression="PizzaID" ></asp:BoundField>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price"></asp:BoundField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button CssClass="menu-button" ID="AddToCart" Text="Tilføj" runat="server" OnClick="AddToCart_Click"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>

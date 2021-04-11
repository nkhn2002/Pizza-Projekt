<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Pizza_Projekt.Admin" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="forside-section" style="height:680px;">
        <div class="test-fluid"  style="height:680px;">
             <div>
                 <asp:TextBox CssClass="search-textbox" ID="TextBox1" runat="server"></asp:TextBox> <br />
                 <asp:Table CssClass="table-box" ID="Table1" runat="server"  Height="234px" Width="537px"></asp:Table>
                 <asp:Button class="B1" ID="Button3" runat="server" Text="Button" />
                 <asp:Button class="B2" ID="Button4" runat="server" Text="Button" />
            </div>
      </div>
</div>
</asp:Content>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Pizza_Projekt.About" MasterPageFile="~/Site.Master"  %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="about-fluid"  style="height:860px;">
        <div class="about-img-box">
            <img runat="server" src="~/Content/About/alex.jpg"/>
            <p class="about-img-box-desc">Nikolai Nielsen</p>
        </div>

        <div class="about-img-box">
            <img runat="server" src="~/Content/About/azur.jpg"/>
            <p class="about-img-box-desc">Samranjit</p>
        </div>

        <div class="about-img-box">
            <img runat="server" src="~/Content/About/bale.jpg"/>
            <p class="about-img-box-desc">Markus</p>
        </div>
    </div>
</asp:Content>
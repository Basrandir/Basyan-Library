<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AuthorForm.aspx.cs" Inherits="Basyan_Library.AuthorForm" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h1>Author information</h1>
    <div>
        <asp:Label ID="LblAuthorName" runat="server" Text="Name: "></asp:Label>
        <asp:Label ID="LblShowAuthorName" runat="server"></asp:Label>
    </div>

    <div>
        <asp:Label ID="LblDOB" runat="server" Text="Date of Birth: "></asp:Label>
        <asp:Label ID="LblShowDOB" runat="server"></asp:Label>
    </div>

    <div>
        <asp:Label ID="LblCountry" runat="server" Text="Country of Origin: "></asp:Label>
        <asp:Label ID="LblShowCountry" runat="server"></asp:Label>
    </div>
</asp:Content>

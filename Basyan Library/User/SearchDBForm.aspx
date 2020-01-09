<%@ Page Title="Search" Language="C#" MasterPageFile="/Site.Master" AutoEventWireup="true" CodeBehind="SearchDBForm.aspx.cs" Inherits="Basyan_Library.SearchDBForm" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h1>Search book</h1>
    <div>
        <asp:Label ID="lblStatus" runat="server"></asp:Label>
    </div>
    <div>
        <asp:Label ID="LblTitle" runat="server" Text="Book Title"></asp:Label>
        <asp:TextBox ID="TxtTitle" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="LblAuthorName" runat="server" Text="Author Name"></asp:Label>
        <asp:TextBox ID="TxtAuthorName" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="LblGenre" runat="server" Text="Genre"></asp:Label>
        <asp:TextBox ID="TxtGenre" runat="server"></asp:TextBox>
    </div>

    <asp:Button ID="BtnSearch" runat="server" OnClick="BtnSearch_Click" Text="Search" />
</asp:Content>

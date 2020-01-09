<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookForm.aspx.cs" Inherits="Basyan_Library.BookForm" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h1>Book detail</h1>
    <div>
        <asp:Label ID="LblBookTitle" runat="server" Text="Title: "></asp:Label>
        <asp:Label ID="LblShowTitle" runat="server"></asp:Label>
    </div>

    <div>
        <asp:Label ID="LblAuthor" runat="server" Text="Author: "></asp:Label>
        <asp:Label ID="LblShowAuthor" runat="server"></asp:Label>
    </div>

    <div>
        <asp:Label ID="LblGenre" runat="server" Text="Genre: "></asp:Label>
        <asp:Label ID="LblShowGenre" runat="server"></asp:Label>
    </div>

    <div>
        <asp:Label ID="LblYear" runat="server" Text="Year Publised: "></asp:Label>
        <asp:Label ID="LblShowYear" runat="server"></asp:Label>
    </div>

    <div>
        <asp:Label ID="lblAddBook" runat="server"></asp:Label>
    </div>
    <div>
        <asp:Button ID="btnAddBook" runat="server" Text="Add Book to Library" OnClick="btnAddBook_Click" />
    </div>
</asp:Content>
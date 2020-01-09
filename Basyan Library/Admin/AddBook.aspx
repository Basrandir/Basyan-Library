<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="Basyan_Library.Admin.AddBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h1>Add Book</h1>

    <div>
        <asp:Label ID="LblTitle" runat="server" Text="Title"></asp:Label>
        <asp:TextBox ID="TxtTitle" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="LblAuthor" runat="server" Text="Author"></asp:Label>
        <asp:DropDownList ID="DdAuthor" runat="server"></asp:DropDownList>
    </div>

    <div>
        <asp:Label ID="LblGenre" runat="server" Text="Genre"></asp:Label>
        <asp:DropDownList ID="DdGenre" runat="server"></asp:DropDownList>
    </div>
        <asp:Label ID="LblYear" runat="server" Text="Year"></asp:Label>
        <asp:TextBox ID="TxtYear" runat="server" TextMode="Date"></asp:TextBox>
    <div>
         <asp:Button ID="BtnAddBook" runat="server" Text="Add Book" />
    </div>
</asp:Content>

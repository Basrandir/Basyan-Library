<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddAuthor.aspx.cs" Inherits="Basyan_Library.Admin.AddAuthor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h1>Add Author</h1>
    <div>
        <asp:Label ID="LblAddName" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="TxtAddName" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="LblAddDOB" runat="server" Text="Date of Birth"></asp:Label>
        <asp:TextBox ID="TxtAddDOB" runat="server" TextMode="Date"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="LblAddCountry" runat="server" Text="Country"></asp:Label>
        <asp:TextBox ID="TxtAddCountry" runat="server"></asp:TextBox>
    </div>

    <asp:Button ID="BtnAddAuthor" runat="server" Text="Add Author" />
</asp:Content>

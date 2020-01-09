<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="Basyan_Library.Admin.AdminDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h1>Admin Dashboard</h1>
    <div>
        <asp:Button ID="BtnCreateBook" runat="server" Text="Create Books" />
    </div>

    <div>
        <asp:Button ID="BtnCreateAuthor" runat="server" Text="Create Authors" />
    </div>
</asp:Content>

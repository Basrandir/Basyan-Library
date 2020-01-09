<%@ Page Title="Login" MasterPageFile="Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Basyan_Library.Login" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h1>Login Page</h1>

    <div>
        <asp:Label ID="lblStatus" runat="server"></asp:Label>
    </div>

    <div>
        <asp:Label ID="LblUserName" runat="server" Text="User Name"></asp:Label>
        <asp:TextBox ID="TxtUserName" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="LblPassword" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    
    <div>
        <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" />
    </div>
</asp:Content>
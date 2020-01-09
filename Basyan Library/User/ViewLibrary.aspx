<%@ Page Title="Library" Language="C#" MasterPageFile="/Site.Master" AutoEventWireup="true" CodeBehind="ViewLibrary.aspx.cs" Inherits="Basyan_Library.ViewLibrary" %>

<asp:Content ID="conViewLibrary" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <asp:Table ID="tblLibrary" runat="server">
        <asp:TableRow>
            <asp:TableHeaderCell>Book</asp:TableHeaderCell>
            <asp:TableHeaderCell>Pages Read</asp:TableHeaderCell>
        </asp:TableRow>
    </asp:Table>

    <asp:Button ID="btnAddBook" Text="Add Book To Library" OnClick="btnAddBook_Click" runat="server" />

</asp:Content>
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchResult.aspx.cs" Inherits="Basyan_Library.SearchResult" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h1>Books</h1>
    <div>
        <asp:GridView ID="GridViewSearchResult" AutoGenerateColumns="false" OnRowDataBound="GridViewSearchResult_RowDataBound" AllowSorting="true" runat="server">
            <Columns>
                <asp:BoundField DataField="Author.Name" HeaderText="Author" SortExpression="Author.Name" />
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                <asp:BoundField DataField="Year" HeaderText="Year" SortExpression="Year" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

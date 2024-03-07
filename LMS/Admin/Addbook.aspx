<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="Addbook.aspx.cs" Inherits="LMS.Admin.Addbook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CSS/Addbook.css" rel="stylesheet" />
</asp:Content>

<asp:Content class="addbook" ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add New Book</h2>
    <div>
        <asp:Label ID="lblTitle" runat="server" Text="Title"></asp:Label>
        <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblAuthor" runat="server" Text="Author"></asp:Label>
        <asp:TextBox ID="txtAuthor" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="quantityLabel" runat="server" Text="Quantity"></asp:Label>
        <asp:TextBox ID="quantity1" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="priceLabel" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="price" runat="server" Text="0"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="btnAddBook" OnClick="btnAddBook_Click" runat="server" Text="Add Book" />
    </div>
    
    <!-- Labels for success and error messages -->
    <asp:Label ID="lblSuccess" runat="server" ForeColor="Green" Visible="false"></asp:Label>
    <asp:Label ID="lblError" runat="server" ForeColor="Red" Visible="false"></asp:Label>
</asp:Content>

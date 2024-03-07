<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="Viewbook.aspx.cs" Inherits="LMS.Admin.Viewbook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CSS/Viewbook.css" rel="stylesheet" />
</asp:Content>

<asp:Content class="viewbooks" ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>View Books</h2>
    <asp:Label ID="lblErrorMessage" runat="server" CssClass="error-message" Visible="false"></asp:Label>
    
    <asp:GridView ID="GridViewBooks" runat="server" AutoGenerateColumns="False" CssClass="gridview" GridLines="Both" >
        <Columns>
            <asp:BoundField DataField="BookID" HeaderText="Book ID" SortExpression="BookID"   />
            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
            <asp:BoundField DataField="Author" HeaderText="Author" SortExpression="Author" />
            <asp:BoundField DataField="quantity" HeaderText="Quantity" SortExpression="quantity" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="price" />
                   <asp:CommandField ShowEditButton="True"  />
            
       <asp:TemplateField HeaderText="Delete">
         <ItemTemplate>
   <asp:LinkButton ID="btnDelete" runat="server" onclick="btnDelete_Click" CommandArgument='<%#Eval("BookID") %>' Text="Delete"> </asp:LinkButton>
</ItemTemplate>
   </asp:TemplateField>
        </Columns>
    </asp:GridView>

    <asp:Label ID="lblUpdateSuccess" runat="server" CssClass="success-message" Visible="false">Updated successfully!</asp:Label>
</asp:Content>


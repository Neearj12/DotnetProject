<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="Viewstd.aspx.cs" Inherits="LMS.Admin.Viewstd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CSS/Viewstd.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>View Students</h2>
    <asp:Label ID="lblErrorMessage" runat="server" CssClass="error-message" Visible="false"></asp:Label>
    <asp:GridView ID="GridViewStudents" runat="server" AutoGenerateColumns="False" CssClass="gridview" GridLines="Both">
        <Columns>
            <asp:BoundField DataField="StdId" HeaderText="Student ID" SortExpression="StudentID" />
            <asp:BoundField DataField="Stdname" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
 
        </Columns>
    </asp:GridView>
</asp:Content>

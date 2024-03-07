<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="Issuesbook.aspx.cs" Inherits="LMS.Admin.Issuesbook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CSS/Issues.css" rel="stylesheet" />
</asp:Content>

<asp:Content class="issuebook" ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Issue Book</h2>
    <div>
        <asp:Label ID="lblStudentID" runat="server" Text="Student ID"></asp:Label>
        <asp:DropDownList ID="ddlStudentID" runat="server" AppendDataBoundItems="true" >
            <asp:ListItem Text="- Select Student -" Value="" />
         
        </asp:DropDownList>
    </div>
    <div>
        <asp:Label ID="lblBookID" runat="server" Text="Book ID"></asp:Label>
        <asp:DropDownList ID="ddlBookID" runat="server" AppendDataBoundItems="true">
            <asp:ListItem Text="- Select Book -" Value="" />
        </asp:DropDownList>
    </div>

        <div>
        <asp:Label ID="lblQuantity" runat="server" Text="Quantity"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblIssueDate" runat="server" Text="Issue Date"></asp:Label>
        <asp:TextBox ID="txtIssueDate" runat="server" TextMode="Date"></asp:TextBox>
    </div>
  
    <div>
        <asp:Button ID="btnIssueBook" runat="server" onclick="btnIssueBook_Click" Text="Issue Book" />
    </div>
    <div>
        <asp:Label ID="lblSuccessMessage" runat="server" CssClass="success-message" Visible="false"></asp:Label>
        <asp:Label ID="lblErrorMessage" runat="server" CssClass="error-message" Visible="false"></asp:Label>
    </div>
</asp:Content>

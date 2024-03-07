<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="LMS.registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/registration.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="registration-container">
        <h2>Student Signup</h2>
        <div class="registration-form">
             <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Green" Visible="false"></asp:Label><br />
            <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
            <asp:TextBox ID="txtname" runat="server" CssClass="textbox"></asp:TextBox>
            
            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="textbox"></asp:TextBox>
            
            <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="textbox"></asp:TextBox>
            
            <asp:Button ID="btnSignup" runat="server" Text="Signup"  CssClass="btn" onclick="btnSignup_Click"/>
        </div>
    </div>
</asp:Content>

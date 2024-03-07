<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LMS.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" 
    runat="server">
    <link href="CSS/Login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="login-form">
        <h2>Student Login</h2>
           <asp:Label ID="lblLoginMessage" runat="server" Text=""  ForeColor="Red" Visible="false" ></asp:Label><br />
        <asp:TextBox ID="txtname" runat="server" placeholder="Username"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" Text="Login"  onclick="btnLogin_Click"/>
        <div class="signup-link">
            <p>Don't have an account? <a href="registration.aspx">Sign up here</a></p>
        </div>
    </div>
</asp:Content>

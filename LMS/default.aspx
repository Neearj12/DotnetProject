<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="LMS._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/default.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <div class="signup-login-options" >
                     <a href="registration.aspx">Sign up as a Student</a>
                    <a href="Login.aspx">Login as a Student</a>
                    <a href="registration.aspx">Sign up as an Admin</a>
                     <a href="Login.aspx">Login as an Admin</a>
                </div>

</asp:Content>

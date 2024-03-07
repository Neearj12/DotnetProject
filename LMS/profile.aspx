<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="LMS.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/profile.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
     <div class="student-profile">

        <h2>Student Profile</h2>
        <div class="profile-details">
    <asp:Label ID="lblStudentName" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="lblStudentEmail" runat="server" Text=""></asp:Label><br />
        </div>
          
    </div>
</asp:Content>

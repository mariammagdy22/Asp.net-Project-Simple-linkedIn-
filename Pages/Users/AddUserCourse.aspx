<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Master1.Master" AutoEventWireup="true" CodeBehind="AddUserCourse.aspx.cs" Inherits="LinkedIN.Pages.Users.AddUserCountry" %>
<%@ Register src="../../Controls/Users/Ctrl_AddUserCountry.ascx" tagname="Ctrl_AddUserCountry" tagprefix="uc1" %>
<%@ Register src="../../Controls/Users/ctrl_AddUserCourse.ascx" tagname="ctrl_AddUserCourse" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc2:ctrl_AddUserCourse ID="ctrl_AddUserCourse1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Master1.Master" AutoEventWireup="true" CodeBehind="AddUserWorkExperience.aspx.cs" Inherits="LinkedIN.Pages.Users.AddUserCountry" %>
<%@ Register src="../../Controls/Users/ctrl_add_experience.ascx" tagname="ctrl_add_experience" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ctrl_add_experience ID="ctrl_add_experience1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ProfileMP.Master" AutoEventWireup="true" CodeBehind="AddVolunteerExperience.aspx.cs" Inherits="LinkedIN.Pages.User.AddVolunteerExperience" %>
<%@ Register src="../../Controls/Users/ctrl_AddVolunteerExperience.ascx" tagname="ctrl_AddVolunteerExperience" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ctrl_AddVolunteerExperience ID="ctrl_AddVolunteerExperience1" runat="server" />
</asp:Content>

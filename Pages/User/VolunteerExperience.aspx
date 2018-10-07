<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ProfileMP.Master" AutoEventWireup="true" CodeBehind="VolunteerExperience.aspx.cs" Inherits="LinkedIN.Pages.User.VolunteerExperience" %>
<%@ Register src="../../Controls/Users/ctrl_VolunteerExperience.ascx" tagname="ctrl_VolunteerExperience" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ctrl_VolunteerExperience ID="ctrl_VolunteerExperience1" runat="server" />
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Master1.Master" AutoEventWireup="true" CodeBehind="VolExp.aspx.cs" Inherits="LinkedIN.Pages.Users.VolExp" %>
<%@ Register src="../../Controls/Users/ctrl_VolunteerExperience.ascx" tagname="ctrl_VolunteerExperience" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc2:ctrl_VolunteerExperience ID="ctrl_VolunteerExperience1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>

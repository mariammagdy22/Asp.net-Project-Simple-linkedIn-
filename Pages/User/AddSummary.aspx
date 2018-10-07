<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ProfileMP.Master" AutoEventWireup="true" CodeBehind="AddSummary.aspx.cs" Inherits="LinkedIN.Pages.User.AddSummary" %>
<%@ Register src="../../Controls/Users/Ctrl_AddSummary.ascx" tagname="Ctrl_AddSummary" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:Ctrl_AddSummary ID="Ctrl_AddSummary1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>

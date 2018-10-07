<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ProfileMP.Master" AutoEventWireup="true" CodeBehind="ViewLanguage.aspx.cs" Inherits="LinkedIN.Pages.User.ViewLanguage" %>
<%@ Register src="../../Controls/Users/ctrl_ViewLanguage.ascx" tagname="ctrl_ViewLanguage" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ctrl_ViewLanguage ID="ctrl_ViewLanguage1" runat="server" />
</asp:Content>

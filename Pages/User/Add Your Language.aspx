<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ProfileMP.Master" AutoEventWireup="true" CodeBehind="Add Your Language.aspx.cs" Inherits="LinkedIN.Pages.User.Add_Your_Language" %>
<%@ Register src="../../Controls/Users/ctrl_AddUserLanguage.ascx" tagname="ctrl_AddUserLanguage" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ctrl_AddUserLanguage ID="ctrl_AddUserLanguage1" runat="server" />
</asp:Content>

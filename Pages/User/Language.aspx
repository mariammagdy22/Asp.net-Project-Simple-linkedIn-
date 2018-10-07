<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ProfileMP.Master" AutoEventWireup="true" CodeBehind="Language.aspx.cs" Inherits="LinkedIN.Pages.User.Language" %>
<%@ Register src="../../Controls/Users/ctrl_AddUserLanguage.ascx" tagname="ctrl_AddUserLanguage" tagprefix="uc1" %>
<%@ Register src="../../Controls/Users/ctrl_SelectLanguage.ascx" tagname="ctrl_SelectLanguage" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc2:ctrl_SelectLanguage ID="ctrl_SelectLanguage1" runat="server" />
    </asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Master1.Master" AutoEventWireup="true" CodeBehind="RolesList.aspx.cs" Inherits="LinkedIN.Pages.Admin.RolesList" %>
<%@ Register src="../../Controls/Admin/ctrl_RulesList.ascx" tagname="ctrl_RulesList" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ctrl_RulesList ID="ctrl_RulesList1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>

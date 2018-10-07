<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Master1.Master" AutoEventWireup="true" CodeBehind="Projects.aspx.cs" Inherits="LinkedIN.Pages.Users.Projects" %>
<%@ Register src="../../Controls/Users/ctrl_Projects.ascx" tagname="ctrl_Projects" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ctrl_Projects ID="ctrl_Projects1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>

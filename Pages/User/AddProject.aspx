<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ProfileMP.Master" AutoEventWireup="true" CodeBehind="AddProject.aspx.cs" Inherits="LinkedIN.Pages.User.AddProject" %>
<%@ Register src="../../Controls/Users/ctrl_AddProject.ascx" tagname="ctrl_AddProject" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ctrl_AddProject ID="ctrl_AddProject1" runat="server" />
</asp:Content>

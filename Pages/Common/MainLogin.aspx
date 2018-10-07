<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/LoginMP.Master" AutoEventWireup="true" CodeBehind="MainLogin.aspx.cs" Inherits="LinkedIN.Pages.Common.MainLogin1" %>
<%@ Register src="../../Controls/Users/ctrl_Login.ascx" tagname="ctrl_Login" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ctrl_Login ID="ctrl_Login1" runat="server" />
</asp:Content>

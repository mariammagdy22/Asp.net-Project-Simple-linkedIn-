<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/LoginMP.Master" AutoEventWireup="true" CodeBehind="MainRegisteration.aspx.cs" Inherits="LinkedIN.Pages.Common.MainRegisteration1" %>
<%@ Register src="../../Controls/Users/ctrl_Register.ascx" tagname="ctrl_Register" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ctrl_Register ID="ctrl_Register1" runat="server" />
</asp:Content>

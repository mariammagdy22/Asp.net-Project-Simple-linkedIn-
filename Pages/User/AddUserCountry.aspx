<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ProfileMP.Master" AutoEventWireup="true" CodeBehind="AddUserCountry.aspx.cs" Inherits="LinkedIN.Pages.User.AddUserCountry" %>
<%@ Register src="../../Controls/Users/Ctrl_AddUserCountry.ascx" tagname="Ctrl_AddUserCountry" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:Ctrl_AddUserCountry ID="Ctrl_AddUserCountry1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>

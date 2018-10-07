<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Master1.Master" AutoEventWireup="true" CodeBehind="ViewSentRequests.aspx.cs" Inherits="LinkedIN.Pages.Users.ViewSentRequests" %>
<%@ Register src="../../Controls/Users/Ctrl_ViewSentRequests.ascx" tagname="Ctrl_ViewSentRequests" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:Ctrl_ViewSentRequests ID="Ctrl_ViewSentRequests1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>

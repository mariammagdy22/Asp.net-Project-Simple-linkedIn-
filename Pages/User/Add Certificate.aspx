<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ProfileMP.Master" AutoEventWireup="true" CodeBehind="Add Certificate.aspx.cs" Inherits="LinkedIN.Pages.User.Add_Certificate" %>
<%@ Register src="../../Controls/Users/ctrl_AddCertificate.ascx" tagname="ctrl_AddCertificate" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ctrl_AddCertificate ID="ctrl_AddCertificate1" runat="server" />
</asp:Content>

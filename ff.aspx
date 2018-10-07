<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ProfileMP.Master" AutoEventWireup="true" CodeBehind="ff.aspx.cs" Inherits="LinkedIN.Fo2ad" %>
<%@ Register src="Controls/CommonC/ctrl_SiteMap1.ascx" tagname="ctrl_SiteMap1" tagprefix="uc1" %>
<%@ Register src="Controls/Users/Ctrl_MyProfilePic.ascx" tagname="Ctrl_MyProfilePic" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc2:Ctrl_MyProfilePic ID="Ctrl_MyProfilePic1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <uc1:ctrl_SiteMap1 ID="ctrl_SiteMap11" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>

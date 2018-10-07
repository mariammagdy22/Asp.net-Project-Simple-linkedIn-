<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ProfileMP.Master" AutoEventWireup="true" CodeBehind="MyProfile.aspx.cs" Inherits="LinkedIN.Pages.User.MyProfile" %>
<%@ Register src="../../Controls/Users/Ctrl_MyProfilePic.ascx" tagname="Ctrl_MyProfilePic" tagprefix="uc1" %>
<%@ Register src="../../Controls/Users/Ctrl_viewUpdateSkill.ascx" tagname="Ctrl_viewUpdateSkill" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:Ctrl_MyProfilePic ID="Ctrl_MyProfilePic1" runat="server" />
    <uc2:Ctrl_viewUpdateSkill ID="Ctrl_viewUpdateSkill1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>

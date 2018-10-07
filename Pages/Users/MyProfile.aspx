<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Master1.Master" AutoEventWireup="true" CodeBehind="MyProfile.aspx.cs" Inherits="LinkedIN.Pages.Users.MyProfile" %>
<%@ Register src="../../Controls/Users/Ctrl_ProfilePic.ascx" tagname="Ctrl_ProfilePic" tagprefix="uc1" %>
<%@ Register src="../../Controls/Users/Ctrl_MyProfilePic.ascx" tagname="Ctrl_MyProfilePic" tagprefix="uc2" %>
<%@ Register src="../../Controls/Users/Ctrl_viewUpdateSkill.ascx" tagname="Ctrl_viewUpdateSkill" tagprefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc2:Ctrl_MyProfilePic ID="Ctrl_MyProfilePic1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <uc3:Ctrl_viewUpdateSkill ID="Ctrl_viewUpdateSkill1" runat="server" />
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentPlaceHolder5" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="ContentPlaceHolder6" runat="server">
</asp:Content>

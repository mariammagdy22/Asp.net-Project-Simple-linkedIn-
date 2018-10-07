<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Master1.Master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="LinkedIN.Pages.Users.UserProfile" %>
<%@ Register src="../../Controls/Users/Ctrl_ProfilePic.ascx" tagname="Ctrl_ProfilePic" tagprefix="uc1" %>
<%@ Register src="../../Controls/Users/Ctrl_Profileskills.ascx" tagname="Ctrl_Profileskills" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:Ctrl_ProfilePic ID="Ctrl_ProfilePic1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
    <uc2:Ctrl_Profileskills ID="Ctrl_Profileskills1" runat="server" />
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentPlaceHolder5" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="ContentPlaceHolder6" runat="server">
</asp:Content>

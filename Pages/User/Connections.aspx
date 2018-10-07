<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ProfileMP.Master" AutoEventWireup="true" CodeBehind="Connections.aspx.cs" Inherits="LinkedIN.Pages.User.Connections" %>
<%@ Register src="../../Controls/Users/Ctrl_ViewRequest.ascx" tagname="Ctrl_ViewRequest" tagprefix="uc1" %>
<%@ Register src="../../Controls/Users/Ctrl_ViewSentRequests.ascx" tagname="Ctrl_ViewSentRequests" tagprefix="uc2" %>
<%@ Register src="../../Controls/Users/Ctrl_ShowConnections.ascx" tagname="Ctrl_ShowConnections" tagprefix="uc3" %>
<%@ Register src="../../Controls/Users/Ctrl_SendRequest.ascx" tagname="Ctrl_SendRequest" tagprefix="uc4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc3:Ctrl_ShowConnections ID="Ctrl_ShowConnections1" runat="server" />
<uc2:Ctrl_ViewSentRequests ID="Ctrl_ViewSentRequests1" runat="server" />
<uc4:Ctrl_SendRequest ID="Ctrl_SendRequest1" runat="server" />
<uc1:Ctrl_ViewRequest ID="Ctrl_ViewRequest1" runat="server" />
</asp:Content>

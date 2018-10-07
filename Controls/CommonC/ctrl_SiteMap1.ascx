<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrl_SiteMap1.ascx.cs" Inherits="LinkedIN.Controls.CommonC.ctrl_SiteMap1" %>
<asp:SiteMapDataSource ID="SiteMap1" runat="server" />
<asp:Menu ID="MenuMap1" runat="server" DataSourceID="SiteMap1" StaticDisplayLevels="2">
</asp:Menu>


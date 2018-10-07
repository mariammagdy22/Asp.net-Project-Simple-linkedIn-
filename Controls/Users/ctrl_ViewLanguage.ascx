<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrl_ViewLanguage.ascx.cs" Inherits="LinkedIN.Controls.Users.ctrl_ViewLanguage" %>
<asp:GridView ID="gv_viewlang" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="LangName" HeaderText="Language" />
        <asp:BoundField DataField="LanguageLevelName" HeaderText="Proficiency" />
    </Columns>
</asp:GridView>


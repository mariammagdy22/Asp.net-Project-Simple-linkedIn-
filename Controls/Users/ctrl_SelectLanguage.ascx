<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrl_SelectLanguage.ascx.cs" Inherits="LinkedIN.Controls.Users.SelectLanguage" %>
<asp:Label ID="lbl_selectlang" runat="server" Text="Select Language"></asp:Label>
&nbsp;
<asp:DropDownList ID="ddl_selectlang" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_selectlang_SelectedIndexChanged1">
</asp:DropDownList>
<br />
<p>
    <asp:Label ID="lbl_prof" runat="server" Text="Proficiency"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="ddl_prof" runat="server" AutoPostBack="True" style="margin-bottom: 0px">
    </asp:DropDownList>
</p>
<p>
    <asp:Button ID="btn_save" runat="server" OnClick="btn_save_Click" Text="Save" />
</p>
<p>
    <asp:Label ID="lbl_anaother" runat="server" Text="To Add another Languages"></asp:Label>
&nbsp;
    <asp:LinkButton ID="lbtn_add" runat="server" OnClick="lbtn_add_Click">Add</asp:LinkButton>
</p>
<p>
    &nbsp;</p>



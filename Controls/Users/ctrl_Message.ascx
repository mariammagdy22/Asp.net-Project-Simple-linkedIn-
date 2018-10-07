<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrl_Message.ascx.cs" Inherits="LinkedIN.Controls.Users.ctrl_Message" %>
<p>
&nbsp;
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="lbl_users" runat="server" Text="Select  User"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="ddl_users" runat="server">
    </asp:DropDownList>
</p>
<p>
    <asp:Button ID="btn_users" runat="server" OnClick="btn_users_Click" Text="Ok" />
</p>
<asp:GridView ID="gv_message" runat="server" AllowSorting="True" OnSelectedIndexChanged="gv_message_SelectedIndexChanged">
</asp:GridView>
<p>
    <asp:TextBox ID="txt_send" runat="server" OnTextChanged="txt_send_TextChanged"></asp:TextBox>
&nbsp;&nbsp;
    <asp:Button ID="btn_send" runat="server" OnClick="btn_send_Click" Text="Send" />
</p>
<p>
    &nbsp;</p>


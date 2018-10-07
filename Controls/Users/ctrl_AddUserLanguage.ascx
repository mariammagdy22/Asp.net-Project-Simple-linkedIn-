<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrl_AddUserLanguage.ascx.cs" Inherits="LinkedIN.Controls.Users.Ctrl_AddUserLanguage" %>
<asp:Label ID="lbl_language" runat="server" Text="Add Your Language"></asp:Label>
<p>
    <asp:TextBox ID="txt_language" runat="server" OnTextChanged="txt_language_TextChanged"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btn_add" runat="server" OnClick="Button1_Click" Text="Add" style="height: 26px" />
</p>




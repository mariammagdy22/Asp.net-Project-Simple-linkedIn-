<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrl_AddCertificate.ascx.cs" Inherits="LinkedIN.Controls.Users.ctrl_AddCertificate" %>
<asp:Label ID="lbl_addcert" runat="server" Text="Add Certification"></asp:Label>
<p>
    <asp:TextBox ID="txt_addcert" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
</p>
<p>
    Certification Date
</p>
<p>
    <asp:TextBox ID="txt_addcertdate" runat="server" OnTextChanged="TextBox1_TextChanged1"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btn_addcert" runat="server" Height="28px" OnClick="btn_addcert_Click" Text="Add" />
</p>
<p>
    <asp:Label ID="lbl_data" runat="server" Text="Your Data is saved"></asp:Label>
</p>
<p>
    &nbsp;</p>


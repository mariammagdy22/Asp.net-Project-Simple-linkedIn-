<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Awardsl1.ascx.cs" Inherits="LinkedIN.Controls.Users.Awardsl1" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>

<p>
    &nbsp;</p>
<table class="auto-style1">
    <tr>
        <td>
            <asp:Label ID="lbl_Title" runat="server" Text="Title"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lbl_provider" runat="server" Text="Provider"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lbl_Date" runat="server" Text="Date"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>
<asp:Button ID="btn_Save" runat="server" OnClick="btn_Save_Click" Text="save" />


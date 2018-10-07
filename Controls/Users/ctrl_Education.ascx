<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrl_Education.ascx.cs" Inherits="LinkedIN.Controls.Users.ctrl_Education" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>

<asp:Label ID="lbl_School" runat="server" Text="School"></asp:Label>
<table class="auto-style1">
    <tr>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lbl_Field" runat="server" Text="Field of study"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lbl_location" runat="server" Text="Location"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lbl_from" runat="server" Text="Date from"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lbl_to" runat="server" Text="Date to"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
    </tr>
</table>


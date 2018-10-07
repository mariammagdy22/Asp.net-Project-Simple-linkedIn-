<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrl_RulesAndUsers.ascx.cs" Inherits="LinkedIN.Controls.Admin.ctrl_RulesAndUsers" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>

<table class="auto-style1">
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:GridView ID="gv_RolesAndUsers" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gv_RolesAndUsers_SelectedIndexChanged" OnSelectedIndexChanging="gv_RolesAndUsers_SelectedIndexChanging">
                <Columns>
                    <asp:BoundField DataField="UserName" HeaderText="UserName" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="IsLockedOut" HeaderText="IsLockedOut" />
                    <asp:BoundField DataField="LastLoginDate" HeaderText="LastLoginDate" />
                    <asp:BoundField DataField="IsOnline" HeaderText="IsOnline" />
                    <asp:CommandField HeaderText="Edit Roles" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </td>
        <td>
            <asp:Label ID="lbl_Roles" runat="server" Text="User Name"></asp:Label>
            <br />
            <asp:CheckBoxList ID="cbl_Roles" runat="server" OnSelectedIndexChanged="cbl_Roles_SelectedIndexChanged">
            </asp:CheckBoxList>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>


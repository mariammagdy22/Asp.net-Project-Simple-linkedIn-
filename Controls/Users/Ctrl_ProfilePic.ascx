<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Ctrl_ProfilePic.ascx.cs" Inherits="LinkedIN.Controls.Users.Ctrl_ProfilePic" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>

<table class="auto-style1">
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Image ID="img_ProfPic" runat="server" Height="200px" Width="200px" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:GridView ID="gv_UserDetails" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="UserName" HeaderText="<%$Resources:profPic,UserName%>" />
                    <asp:BoundField DataField="Summary" HeaderText="<%$Resources:profPic,Summary%>" />
                </Columns>
            </asp:GridView>
        </td>
        <td>&nbsp;</td>
    </tr>
</table>


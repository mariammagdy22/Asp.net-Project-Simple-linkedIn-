<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Ctrl_SendRequest.ascx.cs" Inherits="LinkedIN.Controls.Users.Ctrl_SendRequest" %>
<br />
<asp:Label ID="lbl_ppmayKnow" runat="server" Text="People You may Know"></asp:Label>
<asp:GridView ID="gv_Users" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gv_Users_SelectedIndexChanged" OnSelectedIndexChanging="gv_Users_SelectedIndexChanging">
    <Columns>
        <asp:BoundField DataField="UserName" HeaderText="User Name" />
        <asp:CommandField HeaderText="Send Connection Request" SelectText="Send " ShowSelectButton="True" />
    </Columns>
</asp:GridView>

<asp:Label ID="lbl_requestSent" runat="server" Text="Label"></asp:Label>



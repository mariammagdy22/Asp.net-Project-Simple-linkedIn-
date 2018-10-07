<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Ctrl_ShowConnections.ascx.cs" Inherits="LinkedIN.Controls.Users.Ctrl_ShowConnections" %>
<p>
    &nbsp;</p>
<p>
    Current Connections</p>
<asp:GridView ID="gv_ShowConnections" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanging="gv_ShowConnections_SelectedIndexChanging" OnRowDeleting="gv_ShowConnections_RowDeleting">
    <Columns>
        <asp:BoundField DataField="UserName" HeaderText="UserName" />
        <asp:CommandField SelectText="Go To Profile" ShowSelectButton="True" />
        <asp:CommandField DeleteText="Disconnect" ShowDeleteButton="True" ShowHeader="True" />
    </Columns>
</asp:GridView>


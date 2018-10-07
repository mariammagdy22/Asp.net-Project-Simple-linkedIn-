<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Ctrl_ViewSentRequests.ascx.cs" Inherits="LinkedIN.Controls.Users.Ctrl_ViewSentRequests" %>
<p>
    <br />
</p>
<p>
    Waiting Requests</p>
<p>
    <asp:GridView ID="gv_viewSentReq" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="UserName" HeaderText="UserName" />
        </Columns>
    </asp:GridView>
</p>


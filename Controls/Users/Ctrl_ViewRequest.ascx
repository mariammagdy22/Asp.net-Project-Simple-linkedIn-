<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Ctrl_ViewRequest.ascx.cs" Inherits="LinkedIN.Controls.Users.Ctrl_ViewRequest" %>
<p>
    &nbsp;</p>
<p>
    ConnectionRequests</p>
<asp:GridView ID="gv_viewRequest" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gv_viewRequest_SelectedIndexChanged"  OnRowDeleting="gv_viewRequest_RowDeleting" OnSelectedIndexChanging="gv_viewRequest_SelectedIndexChanging"  >
    <Columns>
        <asp:BoundField DataField="UserName" HeaderText="UserName" />
        <asp:BoundField DataField="Status" HeaderText="Status" />
        
        <asp:CommandField HeaderText="Accept" SelectText="accept" ShowSelectButton="True" />
        <asp:CommandField DeleteText="reject" HeaderText="Reject" ShowDeleteButton="True" />
        
    </Columns>
</asp:GridView>


<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrl_ViewCertificate.ascx.cs" Inherits="LinkedIN.Controls.Users.ctrl_ViewCertificate" %>
<asp:GridView ID="gv_viewcert" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="CertificateName" HeaderText="Certificate Name" />
        <asp:BoundField DataField="CertificateDate" HeaderText="Certificate Date" />
    </Columns>
</asp:GridView>


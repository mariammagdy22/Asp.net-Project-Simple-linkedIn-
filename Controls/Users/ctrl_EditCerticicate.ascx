<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrl_EditCerticicate.ascx.cs" Inherits="LinkedIN.Controls.Users.ctrl_EditCerticicate" %>
<asp:GridView ID="gv_editcert" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="gv_editcert_RowCancelingEdit" OnRowDeleting="gv_editcert_RowDeleting" OnRowEditing="gv_editcert_RowEditing" OnRowUpdating="gv_editcert_RowUpdating">
    <Columns>
        <asp:TemplateField HeaderText="Certificate Name">
            <EditItemTemplate>
                <asp:TextBox ID="txt_name" runat="server" Text='<%# Bind("CertificateName") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Bind("CertificateName") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Certificate Date">
            <EditItemTemplate>
                <asp:TextBox ID="txt_date" runat="server" Text='<%# Bind("CertificateDate") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Bind("CertificateDate") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:CommandField ShowEditButton="True" />
        <asp:CommandField ShowDeleteButton="True" />
    </Columns>
</asp:GridView>


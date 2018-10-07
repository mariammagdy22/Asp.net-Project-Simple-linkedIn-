<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrl_VolunteerExperience.ascx.cs" Inherits="LinkedIN.Controls.Users.EditVolExp" %>
<asp:GridView ID="gv_VolExp" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="gv_VolExp_RowCancelingEdit" OnRowDeleting="gv_VolExp_RowDeleting" OnRowEditing="gv_VolExp_RowEditing" OnRowUpdating="gv_VolExp_RowUpdating">
    <Columns>
        <asp:TemplateField HeaderText="Organization">
            <EditItemTemplate>
                <asp:TextBox ID="txt_organization" runat="server" Text='<%# Bind("VolWorkName") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Bind("VolWorkName") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Role">
            <EditItemTemplate>
                <asp:TextBox ID="txt_Role" runat="server" Text='<%# Bind("Role") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label3" runat="server" Text='<%# Bind("Role") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Description">
            <EditItemTemplate>
                <asp:TextBox ID="txt_description" runat="server" Text='<%# Bind("VolWorkDescription") %>' TextMode="MultiLine"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Bind("VolWorkDescription") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:CommandField ShowEditButton="True" />
        <asp:CommandField ShowDeleteButton="True" />
    </Columns>
</asp:GridView>


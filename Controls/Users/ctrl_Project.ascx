<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrl_Project.ascx.cs" Inherits="LinkedIN.Controls.Users.ctrl_Project" %>
<asp:GridView ID="gv_Projects" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="gv_Projects_RowCancelingEdit" OnRowDeleting="gv_Projects_RowDeleting" OnRowEditing="gv_Projects_RowEditing" OnRowUpdating="gv_Projects_RowUpdating">
    <Columns>
        <asp:TemplateField HeaderText="Project Name">
            <EditItemTemplate>
                <asp:TextBox ID="txt_ProjectName" runat="server" Text='<%# Bind("ProjectName") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Bind("ProjectName") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Start Date">
            <EditItemTemplate>
                <asp:TextBox ID="txt_StartDate" runat="server" Text='<%# Bind("StartDate") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Bind("StartDate") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="End Date">
            <EditItemTemplate>
                <asp:TextBox ID="txt_EndDate" runat="server" Text='<%# Bind("EndDate") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label3" runat="server" Text='<%# Bind("EndDate") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Description">
            <EditItemTemplate>
                <asp:TextBox ID="txt_Description" runat="server" Text='<%# Bind("Description") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label4" runat="server" Text='<%# Bind("Description") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:CommandField ShowEditButton="True" />
        <asp:CommandField ShowDeleteButton="True" />
    </Columns>
</asp:GridView>


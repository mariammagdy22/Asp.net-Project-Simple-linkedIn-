<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrl_EditLanguage.ascx.cs" Inherits="LinkedIN.Controls.Users.ctrl_EditLanguage" %>
<asp:GridView ID="gv_editlang" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
    <Columns>
        <asp:TemplateField HeaderText="Language">
            <EditItemTemplate>
                <asp:TextBox ID="txt_editnamelang" runat="server"></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Bind("[LangName ]") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Proficiency">
            <EditItemTemplate>
                <asp:DropDownList ID="ddl_editprof" runat="server">
                </asp:DropDownList>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Bind("LanguageLevelName") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:CommandField ShowEditButton="True" />
        <asp:CommandField ShowDeleteButton="True" />
    </Columns>
</asp:GridView>


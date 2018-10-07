<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Ctrl_MyProfilePic.ascx.cs" Inherits="LinkedIN.Controls.Users.Ctrl_MyProfilePic" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>

<table class="auto-style1">
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Label ID="Label5" runat="server" Text="<%$Resources:profPic,ProfilePic%>"></asp:Label>
            <br />
            <asp:Image ID="img_ProfPic" runat="server" Height="200px" Width="200px" />
            <br />
            <asp:LinkButton ID="lbtn_ChangeProfilePhoto" runat="server" OnClick="lbtn_ChangeProfilePhoto_Click"  Text="<%$Resources:profPic,ChangeProfilePhoto%>"></asp:LinkButton>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td><asp:GridView ID="gv_UserDetails" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="gv_UserDetails_RowCancelingEdit" OnRowDeleting="gv_UserDetails_RowDeleting" OnRowEditing="gv_UserDetails_RowEditing" OnRowUpdating="gv_UserDetails_RowUpdating" OnSelectedIndexChanging="gv_UserDetails_SelectedIndexChanging">
            <Columns>
                <asp:TemplateField HeaderText="<%$Resources:profPic,UserName%>">
                    <EditItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("UserName") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("UserName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="<%$Resources:profPic,Summary%>">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_Summary" runat="server" Text='<%# Bind("Summary") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Summary") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="<%$Resources:profPic,CountryName%>">
                    <EditItemTemplate>
                        <asp:DropDownList ID="ddl_Country" runat="server">
                        </asp:DropDownList>
                        <br />
                        <asp:LinkButton ID="lbtn_addNewCountry" runat="server" OnClick="lbtn_addNewCountry_Click">AddNewCountry</asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("CountryName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="<%$Resources:profPic,PostalCode%>">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_PostalCode" runat="server" Text='<%# Bind("PostalCode") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("PostalCode") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="True" />
            </Columns>
            </asp:GridView>
        </td>
        <td>&nbsp;</td>
    </tr>
</table>


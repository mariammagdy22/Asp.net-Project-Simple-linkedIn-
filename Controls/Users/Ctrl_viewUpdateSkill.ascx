<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Ctrl_viewUpdateSkill.ascx.cs" Inherits="LinkedIN.Controls.Users.Ctrl_viewUpdateSkill" %>

<p>
    <table >
        <tr>
            <td>&nbsp;</td>
            <td >
<asp:GridView ID="gv_skills" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="gv_skills_RowCancelingEdit" OnRowDeleting="gv_skills_RowDeleting" OnRowEditing="gv_skills_RowEditing" OnRowUpdating="gv_skills_RowUpdating" OnSelectedIndexChanging="gv_skills_SelectedIndexChanging">
    <Columns>
        <asp:TemplateField HeaderText="<%$Resources:Skill,SkillName%>">
            <EditItemTemplate>
                <asp:TextBox ID="txt_newSkillName" runat="server" Text='<%# Bind("SkillName") %>'></asp:TextBox>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label3" runat="server" Text='<%# Bind("SkillName") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="<%$Resources:Skill,SkillLevel%>">
            <EditItemTemplate>
                <asp:DropDownList ID="ddl_newSkill" runat="server">
                </asp:DropDownList>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" Text='<%# Bind("SkillLevelName") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="<%$Resources:Skill,Endorsements%>">
            <EditItemTemplate>
                <asp:Label ID="Label11" runat="server" Text='<%# Bind("SkillCounter") %>'></asp:Label>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Bind("SkillCounter") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:CommandField ShowEditButton="True" />
        <asp:CommandField ShowDeleteButton="True" />
        <asp:CommandField SelectText="<%$Resources:Skill,ShowEndorsers%>" ShowSelectButton="True" />
    </Columns>
</asp:GridView>

&nbsp; </td>
            <td>
                <asp:Label ID="lbl_skillName" runat="server" Text="Label"></asp:Label>
                <asp:GridView ID="gv_Endorsers" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="UserName" HeaderText="<%$Resources:Skill,Endorsers%>" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">
                <asp:Button ID="btn_AddNewSkill" runat="server" OnClick="btn_AddNewSkill_Click" Text="<%$Resources:Skill,AddNewSkill%>" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <br />
</p>
<p>
    &nbsp;</p>



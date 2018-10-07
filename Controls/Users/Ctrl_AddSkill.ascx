<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Ctrl_AddSkill.ascx.cs" Inherits="LinkedIN.Controls.Users.Ctrl_AddSkill" %>


<asp:Label ID="Label1" runat="server" Text="<%$Resources:Skill,AddSkill%>"></asp:Label>
<table class="auto-style1">
    <tr>
        <td><asp:Label ID="Label2" runat="server" Text="<%$Resources:Skill,SkillName1%>"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txt_SkillName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td ><asp:Label ID="Label3" runat="server" Text="<%$Resources:Skill,SkillLevel%>"></asp:Label>
        </td>
        <td >
            <asp:DropDownList ID="ddl_SkillLevel" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="btn_addSkill" runat="server" OnClick="btn_addSkill_Click" Text="<%$Resources:Skill,AddSkill%>" />
            <asp:Label ID="lbl_message" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
</table>
<p>
    &nbsp;</p>


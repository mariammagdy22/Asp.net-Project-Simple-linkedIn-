<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Ctrl_Profileskills.ascx.cs" Inherits="LinkedIN.Controls.Users.Ctrl_Profileskills" %>
<p>
    <asp:Label ID="Label1" runat="server" Text="<%$Resources:Skill,Skills%>"></asp:Label>
</p>
<p>
    <asp:GridView ID="gv_Skills" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanging="gv_Skills_SelectedIndexChanging">
        <Columns>
            <asp:BoundField DataField="SkillName" HeaderText="<%$Resources:Skill,SkillName%>" />
            <asp:BoundField DataField="SkillLevelName" HeaderText="<%$Resources:Skill,SkillLevelName%>" />
            <asp:BoundField DataField="SkillCounter" HeaderText="<%$Resources:Skill,Endorsements%>" />
            <asp:CommandField SelectText="<%$Resources:Skill,Endorse_DeEndorse%>" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
</p>
<p>
    <asp:Label ID="lbl_Discription" runat="server" Text="lbl_Discription"></asp:Label>
</p>


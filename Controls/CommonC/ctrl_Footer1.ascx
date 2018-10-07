<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrl_Footer1.ascx.cs" Inherits="LinkedIN.Controls.CommonC.ctrl_Footer1" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>

<table class="auto-style1">
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Label ID="lbl_language" runat="server" Text="<%$Resources:General,Language%>"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="lbtn_en_Us" runat="server" OnClick="lbtn_en_Us_Click">en_Us</asp:LinkButton>
&nbsp;&nbsp;
            <asp:LinkButton ID="lbtn_ar_Eg" runat="server" OnClick="lbtn_ar_Eg_Click">عربي</asp:LinkButton>
        </td>
        <td>
            <asp:Label ID="lbl_theme" runat="server" Text="<%$Resources:General,Selectyourtheme%>"></asp:Label>
            <asp:DropDownList ID="ddl_theme" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_theme_SelectedIndexChanged">
                <asp:ListItem Value="Theme1" Text="<%$Resources:General,Theme1%>"></asp:ListItem>
                <asp:ListItem Value="Theme2" Text="<%$Resources:General,Theme2%>"></asp:ListItem>
                <asp:ListItem Value="None" Text="<%$Resources:General,None%>"></asp:ListItem>                
            </asp:DropDownList>
        </td>
    </tr>
</table>


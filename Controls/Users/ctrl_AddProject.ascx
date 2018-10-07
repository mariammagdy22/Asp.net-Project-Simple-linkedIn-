<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrl_AddProject.ascx.cs" Inherits="LinkedIN.Controls.Users.ctrl_Projects" %>
<style type="text/css">

    .auto-style1 {
        width: 100%;
    }
    .auto-style3 {
        height: 38px;
    }
</style>

<table class="auto-style1">
    <tr>
        <td>
            <asp:Literal ID="ltr_Header" runat="server" Text="&lt;h3&gt;Add Project &lt;/h3&gt;"></asp:Literal>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td colspan="2">
            <hr />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lbl_ProjectName" runat="server" Text="<%$ Resources:Profile, ProjectName %>"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txt_ProjectName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfv_ProjectName" runat="server" Display="Dynamic" ErrorMessage="Please enter the project name" ControlToValidate="txt_ProjectName">*</asp:RequiredFieldValidator>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lbl_header_Dates" runat="server" Text="<%$ Resources:Profile, Dates %>"></asp:Label>
        </td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lbl_StartDate" runat="server" Text="<%$ Resources:Profile, StartDate %>"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbl_EndDate" runat="server" Text="<%$ Resources:Profile, EndDate %>"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txt_StartDate" runat="server" TextMode="Date"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txt_EndDate" runat="server" TextMode="Date"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lbl_Description" runat="server" Text="<%$ Resources:Profile, Description %>"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txt_Description" runat="server" TextMode="MultiLine"></asp:TextBox>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <hr />
        </td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Button ID="btn_Save" runat="server" Text="<%$ Resources:Profile, Save %>" OnClick="btn_Save_Click" />
&nbsp;&nbsp;
            <asp:Button ID="btn_Cancel" runat="server" Text="<%$ Resources:Profile, Cancel %>" UseSubmitBehavior="False" />
        </td>
        <td class="auto-style3"></td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Label ID="lbl_success" runat="server" Text=" "></asp:Label>
        </td>
        <td class="auto-style3">&nbsp;</td>
    </tr>
</table>



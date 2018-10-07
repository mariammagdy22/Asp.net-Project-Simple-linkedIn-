<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrl_AddVolunteerExperience.ascx.cs" Inherits="LinkedIN.Controls.Users.VolunteerExperience" %>

<table>
    <tr>
        <td>
            <asp:Literal ID="ltr_Header" runat="server" Text="&lt;h3&gt; Add Volunteer Experience &lt;/h3&gt;"></asp:Literal>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <hr />
        </td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lbl_Organization" runat="server" Text="<%$ Resources:Profile, Organization%>"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txt_WorkName" runat="server" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfv_organization" runat="server" ControlToValidate="txt_WorkName" Display="Dynamic" ErrorMessage="Please enter the organization name">*</asp:RequiredFieldValidator>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lbl_Role" runat="server" Text="<%$ Resources:Profile, Role %>"></asp:Label>
        </td>
        <td></td>
        
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txt_Role" runat="server" ></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lbl_Description" runat="server" Text="<%$ Resources:Profile, Description %>"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:TextBox id="txt_description" TextMode="multiline" Columns="30" Rows="4" runat="server" />
            </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <hr />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btn_addVol" runat="server" OnClick="btn_addVol_Click" Text="<%$ Resources:Profile, Save %>" />
&nbsp;&nbsp;
            <asp:Button ID="btn_Cancel" runat="server" Text="<%$ Resources:Profile, Cancel %>" UseSubmitBehavior="False" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lbl_success" runat="server" Text=" "></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
</table>


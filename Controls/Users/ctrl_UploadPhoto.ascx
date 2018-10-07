<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrl_UploadPhoto.ascx.cs" Inherits="LinkedIN.Controls.Users.ctrl_UploadPhoto" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>

<table class="auto-style1">
    <tr>
        <td colspan="2">
            <asp:Label ID="lbl_selectYourPic" runat="server" Text="Select Your Pic"></asp:Label>
            <asp:FileUpload ID="FileUpload_image" runat="server" />
            <br />
            <asp:Label ID="lbl_Message" runat="server" Text="Upload Message"></asp:Label>
        &nbsp;<br />
            <asp:Button ID="btn_Upload" runat="server" OnClick="btn_Upload_Click" Text="Upload" />
        </td>
        <td>
            <asp:Image ID="img_preview" runat="server" Height="500px" Width="500px" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td colspan="2">&nbsp;&nbsp;
            <br />
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>


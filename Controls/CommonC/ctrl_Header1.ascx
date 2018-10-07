<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrl_Header1.ascx.cs" Inherits="LinkedIN.Controls.CommonC.ctrl_Header1" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        text-align: right;
    }
    .auto-style3 {
        width: 117px;
        height: 26px;
    }
</style>

<table class="auto-style1">
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td class="auto-style2">
            <asp:LoginStatus ID="LoginStatus1" runat="server" />
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <img alt="LOGO" class="auto-style3" src="file:///D:/Civil%20Material/ITI%20Material/Private%20Codes/LinkedIN/Pics/LOGO.png" /></td>
        <td>&nbsp;</td>
        <td class="auto-style2">
            <asp:LoginName ID="LoginName1" runat="server" />
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:SiteMapPath ID="SiteMapPath1" runat="server">
            </asp:SiteMapPath>
        </td>
        <td>&nbsp;</td>
        <td class="auto-style2">
            <asp:Label ID="lbl_date" runat="server" Text="Date"></asp:Label>
        </td>
    </tr>
</table>


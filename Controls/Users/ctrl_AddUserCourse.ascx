<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrl_AddUserCourse.ascx.cs" Inherits="LinkedIN.Controls.Users.Ctrl_AddUserCourse" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
        float: left;
        border: 1px solid #c0c0c0;
    }
    .auto-style2 {
        height: 23px;
    }
</style>

<table class="auto-style1" dir="ltr">
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Add course"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Course name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:DropDownList ID="ddl_choose_course" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_add_course" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="btn_add_course" runat="server" OnClick="btn_add_course_Click" Text="Add" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label3" runat="server" Text="Number"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txt_course_number" runat="server"></asp:TextBox>
&nbsp;&nbsp; </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label5" runat="server" Text="Course end date"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txt_course_date" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label4" runat="server" ClientIDMode="AutoID" Text="Associated With"></asp:Label>
&nbsp;</td>
        <td class="auto-style2"></td>
    </tr>
    <tr>
        <td>&nbsp;
            <asp:TextBox ID="txt_add_associated_with" runat="server" OnTextChanged="txt_add_associated_with_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_save_course" runat="server" OnClick="btn_save_course_Click" Text="Save" />
&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>


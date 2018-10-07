<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Ctrl_AddUserCountry.ascx.cs" Inherits="LinkedIN.Controls.Users.Ctrl_AddUserCountry" %>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<p>
&nbsp;</p>
<p>
    <asp:Label ID="lbl_PostalCode" runat="server" Text="Postal Code"></asp:Label>
&nbsp;
    <asp:TextBox ID="txt_PostalCode" runat="server"></asp:TextBox>
</p>
&nbsp;<p>
    <asp:Label ID="lbl_select" runat="server" Text="Select Your Country"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="ddl_selectCountry" runat="server">
    </asp:DropDownList>
</p>
<p>
    <asp:LinkButton ID="lbtn_AddNewCountry" runat="server" OnClick="lbtn_AddNewCountry_Click">AddAnotherCountry</asp:LinkButton>
</p>
<p>
    <asp:Button ID="btn_AddCountry" runat="server" OnClick="btn_AddCountry_Click" Text="Add" />
</p>


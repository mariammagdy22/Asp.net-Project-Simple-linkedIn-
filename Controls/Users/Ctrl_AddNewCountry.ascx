<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Ctrl_AddNewCountry.ascx.cs" Inherits="LinkedIN.Controls.Users.Ctrl_AddNewCountry" %>
<p>
    Add the new Country Name</p>
<p>
    <asp:TextBox ID="txt_CountryName" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btn_Add" runat="server" OnClick="btn_Add_Click" Text="Add" />
</p>


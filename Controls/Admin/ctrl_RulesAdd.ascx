<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrl_RulesAdd.ascx.cs" Inherits="LinkedIN.Controls.Admin.ctrl_RulesAdd" %>
<asp:TextBox ID="txt_RuleName" runat="server"></asp:TextBox>
&nbsp;&nbsp;
<asp:RequiredFieldValidator ID="rfv_RuleName" runat="server" ControlToValidate="txt_RuleName" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
&nbsp;<asp:Button ID="btn_Add" runat="server" OnClick="btn_Add_Click" Text="Add" />


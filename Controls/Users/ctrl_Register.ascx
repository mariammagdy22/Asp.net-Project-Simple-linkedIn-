<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrl_Register.ascx.cs" Inherits="LinkedIN.Controls.Users.ctrl_Register" %>
<asp:CreateUserWizard ID="CreateUserWizard1" runat="server" CancelDestinationPageUrl="~/Pages/Users/Login.aspx" ContinueDestinationPageUrl="~/Pages/Users/AddUserCountry.aspx" DisplayCancelButton="True" FinishDestinationPageUrl="~/Pages/User/AddUserCountry.aspx" EnableViewState="False">
    <WizardSteps>
        <asp:CreateUserWizardStep runat="server" />
        <asp:CompleteWizardStep runat="server" />
    </WizardSteps>
</asp:CreateUserWizard>


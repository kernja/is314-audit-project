<%@ Page Language="VB" AutoEventWireup="false" CodeFile="index.aspx.vb" Inherits="index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<link href="global.css" rel="stylesheet" type="text/css" />
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <strong>Auditor<br />
            <br />
        </strong>
        <asp:Label ID="labelError" runat="server" Font-Italic="True" Text="There was an error processing the command.  Please try again."
            Visible="False" Width="456px"></asp:Label><br />
        <table>
            <tr>
                <td style="width: 23px">
                    Username</td>
                <td style="width: 154px">
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></td>
                <td style="width: 225px">
                    <asp:RequiredFieldValidator ID="validatorUsername" runat="server" ControlToValidate="txtUsername"
                        ErrorMessage="Please enter a valid username"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 23px; height: 26px">
                    Password</td>
                <td style="width: 154px; height: 26px">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="148px"></asp:TextBox></td>
                <td style="width: 225px; height: 26px">
                    <asp:RequiredFieldValidator ID="validatorPassword" runat="server" ControlToValidate="txtPassword"
                        ErrorMessage="Please enter a valid password"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 23px; height: 26px;">
                </td>
                <td style="width: 154px; height: 26px;">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
                    &nbsp; 
                    <asp:Button ID="btnClear" runat="server" Text="Clear" UseSubmitBehavior="False" CausesValidation="False" />
                    &nbsp; &nbsp; &nbsp; &nbsp;
                </td>
                <td style="width: 225px; height: 26px;">
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

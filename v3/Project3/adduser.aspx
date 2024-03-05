<%@ Page Language="VB" AutoEventWireup="false" CodeFile="adduser.aspx.vb" Inherits="adduser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<link href="global.css" rel="stylesheet" type="text/css" />
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <strong>Auditor - Main Menu - Add User</strong><br />
        <br />
        <asp:Label ID="labelError" runat="server" Font-Italic="True" Text="There was an error processing the command.  Please try again."
            Visible="False" Width="456px"></asp:Label><br />
        <table>
            <tr>
                <td style="width: 138px; height: 26px;">
                    First Name</td>
                <td style="width: 109px; height: 26px;">
                    <asp:TextBox ID="textNameFirst" runat="server"></asp:TextBox></td>
                <td style="width: 28px; height: 26px">
                    <asp:RequiredFieldValidator ID="validatorFName" runat="server" ErrorMessage="Required field"
                        Width="91px" ControlToValidate="textNameFirst"></asp:RequiredFieldValidator></td>
                <td style="width: 15px; height: 26px;">
                    MI</td>
                <td style="width: 103px; height: 26px;">
                    <asp:TextBox ID="textNameMI" runat="server" MaxLength="1"></asp:TextBox></td>
                <td style="width: 103px; height: 26px">
                    <asp:RequiredFieldValidator ID="validatorMI" runat="server" ErrorMessage="Required field"
                        Width="91px" ControlToValidate="textNameMI"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 138px; height: 26px;">
                    Last Name</td>
                <td style="width: 109px; height: 26px;">
                    <asp:TextBox ID="textNameLast" runat="server"></asp:TextBox></td>
                <td style="width: 28px; height: 26px">
                    <asp:RequiredFieldValidator ID="validatorLName" runat="server" ErrorMessage="Required field"
                        Width="91px" ControlToValidate="textNameLast"></asp:RequiredFieldValidator></td>
                <td style="width: 15px; height: 26px;">
                </td>
                <td style="width: 103px; height: 26px;">
                </td>
                <td style="width: 103px; height: 26px">
                </td>
            </tr>
            <tr>
                <td style="width: 138px; height: 26px;">
                    Username</td>
                <td style="width: 109px; height: 26px;">
                    <asp:TextBox ID="textUsername" runat="server"></asp:TextBox></td>
                <td style="width: 28px; height: 26px">
                    <asp:RequiredFieldValidator ID="validatorUsername" runat="server" ErrorMessage="Required field"
                        Width="91px" ControlToValidate="textUsername"></asp:RequiredFieldValidator></td>
                <td style="width: 15px; height: 26px;">
                </td>
                <td style="width: 103px; height: 26px;">
                </td>
                <td style="width: 103px; height: 26px">
                </td>
            </tr>
            <tr>
                <td style="width: 138px; height: 26px;">
                    Password</td>
                <td style="width: 109px; height: 26px;">
                    <asp:TextBox ID="textPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                <td style="width: 28px; height: 26px;">
                    <asp:RequiredFieldValidator ID="validatorPassword" runat="server" ErrorMessage="Required field"
                        Width="91px" ControlToValidate="textPassword"></asp:RequiredFieldValidator></td>
                <td style="width: 15px; height: 26px;">
                </td>
                <td style="width: 103px; height: 26px;">
                </td>
                <td style="width: 103px; height: 26px;">
                </td>
            </tr>
            <tr>
                <td style="width: 138px; height: 26px">
                    Confirm Password</td>
                <td style="width: 109px; height: 26px">
                    <asp:TextBox ID="textConfirmPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                <td style="width: 28px; height: 26px">
                    <asp:RequiredFieldValidator ID="validatorConfirmPassword" runat="server" ErrorMessage="Required field"
                        Width="91px" ControlToValidate="textConfirmPassword"></asp:RequiredFieldValidator></td>
                <td style="width: 15px; height: 26px">
                </td>
                <td style="width: 103px; height: 26px">
                </td>
                <td style="width: 103px; height: 26px">
                </td>
            </tr>
            <tr>
                <td style="width: 138px; height: 26px">
                    <asp:Button ID="btnCreate" runat="server" Text="Create User" />
                </td>
                <td style="width: 109px; height: 26px">
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" CausesValidation="False" UseSubmitBehavior="False" /></td>
                <td style="width: 28px; height: 26px">
                </td>
                <td style="width: 15px; height: 26px">
                </td>
                <td style="width: 103px; height: 26px">
                </td>
                <td style="width: 103px; height: 26px">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

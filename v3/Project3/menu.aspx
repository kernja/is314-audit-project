<%@ Page Language="VB" AutoEventWireup="false" CodeFile="menu.aspx.vb" Inherits="menu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<link href="global.css" rel="stylesheet" type="text/css" />
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <strong>Auditor - Main Menu<br />
            <br />
        </strong>
        <asp:Label ID="labelError" runat="server" Font-Italic="True" Text="There was an error processing the command.  Please try again."
            Visible="False" Width="456px"></asp:Label><br />
        <table>
            <tr>
                <td style="width: 23px; height: 26px">
                    <asp:Button ID="btnAudit" runat="server" Text="Perform an Audit" Width="188px" UseSubmitBehavior="False" /></td>
            </tr>
            <tr>
                <td style="width: 23px; height: 26px">
                    <asp:Button ID="btnAdd" runat="server" Text="Add Additional Users" Width="186px" UseSubmitBehavior="False" /></td>
            </tr>
            <tr>
                <td style="width: 23px; height: 26px">
                    <asp:Button ID="btnView" runat="server" Text="View All Tables in DB" UseSubmitBehavior="False" /></td>
            </tr>
            <tr>
                <td style="width: 23px; height: 26px">
                </td>
            </tr>
            <tr>
                <td style="width: 23px; height: 26px">
                   <center> <asp:Button ID="btnLogOff" runat="server" Text="Log Off" UseSubmitBehavior="False" /></center></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

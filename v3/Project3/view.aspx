<%@ Page Language="VB" AutoEventWireup="false" CodeFile="view.aspx.vb" Inherits="view" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<link href="global.css" rel="stylesheet" type="text/css" />
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <strong>Auditor - Main Menu - View Tables</strong><br />
        <br />
        <asp:Label ID="labelError" runat="server" Font-Italic="True" Text="There was an error processing the command.  Please try again."
            Visible="False" Width="456px"></asp:Label><br />
        Tables:<br />
        <asp:DropDownList ID="listTables" runat="server" AutoPostBack="True" Width="457px">
        </asp:DropDownList><br />
        <asp:DataGrid ID="dgrid" runat="server">
        </asp:DataGrid><br />
    
    </div>
        <asp:Button ID="btnBack" runat="server" Text="Back to Menu" UseSubmitBehavior="False" />
    </form>
</body>
</html>

<%@ Page Language="VB" AutoEventWireup="false" CodeFile="audit.aspx.vb" Inherits="audit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<link href="global.css" rel="stylesheet" type="text/css" />
<html xmlns="http://www.w3.org/1999/xhtml" >

<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <strong>Auditor - Main Menu - Perform an Audit<br />
        </strong>
        <br />
        Auditor:
        <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label><br />
        <br />
        <table style="width: 193px; height: 99px">
            <tr>
                <td>
                    <strong>Categories:</strong></td>
            </tr>
            <tr>
                <td>
                    <asp:ListBox ID="listCategory" runat="server" AutoPostBack="True" Height="162px"
                        Width="270px"></asp:ListBox></td>
            </tr>
            <tr>
                <td style="height: 21px">
                    <strong>Category Rating:</strong></td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="lstRating" runat="server" AutoPostBack="True" Enabled="False"
                        Height="55px" Width="257px">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td>
                    <strong>Comments on Category:</strong></td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtComments" runat="server" AutoPostBack="True" Enabled="False"
                        Height="144px" TextMode="MultiLine" Width="257px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblScore" runat="server" Text="Label" Width="179px"></asp:Label><asp:Label
                        ID="lblRating" runat="server" Text="Label" Width="70px"></asp:Label></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Save Audit" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" UseSubmitBehavior="False" /></td>
            </tr>
        </table>
        <div>
            &nbsp;</div>
    
    </div>
    </form>
</body>
</html>

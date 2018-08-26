<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Identity.aspx.cs" Inherits="MyFirstWebApp.Identity" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            What is your first name?&nbsp;
            <asp:TextBox ID="firstNameBox" runat="server"></asp:TextBox>
            <br />
            <br />
            What is your last name?&nbsp;
            <asp:TextBox ID="lastNameBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Click Me Please" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
        <div>
            <asp:Button ID="closeConnection" runat="server" OnClick="closeConnection_Click" Text="Close SQL connection" />
        </div>
    </form>
</body>
</html>

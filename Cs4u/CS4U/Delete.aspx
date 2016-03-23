<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="CS4U.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this stock item?"></asp:Label>
    
    </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" Text="No" />
    </form>
</body>
</html>

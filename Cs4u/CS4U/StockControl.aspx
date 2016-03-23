<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StockControl.aspx.cs" Inherits="CS4U.StockControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="btnAddStock" runat="server" OnClick="btnAddStock_Click" Text="Add" />
        <asp:ListBox ID="lstStockItems" runat="server"></asp:ListBox>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
    </form>
</body>
</html>

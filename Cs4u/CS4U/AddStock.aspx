<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStock.aspx.cs" Inherits="CS4U.AddStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblStockName" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="txtStockName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblItemPrice" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="txtItemPrice" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblItemDescription" runat="server" Text="Description"></asp:Label>
        <asp:TextBox ID="txtItemDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblSupplierName" runat="server" Text="Supplier"></asp:Label>
        <asp:TextBox ID="txtSupplierName" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Stock Level"></asp:Label>
        <asp:TextBox ID="txtStockLevel" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        <br />
        <br />
    </form>
</body>
</html>

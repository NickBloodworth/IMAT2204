<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainInterface.aspx.cs" Inherits="CS4U.Main_Interface" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            background-color: #FFCC66;
            font-size: xx-large;
        }
        .newStyle1 {
            font-family: "Arial Black";
        }
        .newStyle2 {
            font-family: "Arial Black";
            font-size: xx-large;
        }
        .auto-style2 {
            font-size: x-large;
            color: #00FFFF;
            font-style: italic;
            font-weight: bold;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color: #FFCC66">
    
        <p class="auto-style1">
            <strong>Main Interface Page</strong></p>
        <br />
        <br />
        <p class="auto-style2">Select your department</p>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
<asp:Button ID="btnStockControl" runat="server" OnClick="btnStockControl_Click" Text="Stock Control" Height="75px" style="float: left" Width="223px" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </div>
        
    </form>
</body>
</html>
       


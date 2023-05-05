<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderStatus.aspx.cs" Inherits="Reseller__Webform_.WebForm2" %>

<!DOCTYPE html>

<style>
    a {
        text-decoration: none;
        color: white;
        margin-top: 12px;
        border-radius: 8px;
        padding: 12px 6px;
        background: #1960d0;
        width: fit-content;
        transition: 0.3s;
        display: block;
    }
    a:hover {
        transform: scale(1.05);
        transition: 0.3s;
    }
</style>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Status</title>
</head>
<body>
    <form id="form1" runat="server">
        <h3>Orders Status</h3>
        <asp:GridView ID="grdOrderStatus" runat="server"></asp:GridView>
    </form>
    <a href="PlaceOrder.aspx">Place Order</a>
</body>
</html>

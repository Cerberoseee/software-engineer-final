<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderStatus.aspx.cs" Inherits="Reseller__Webform_.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h3>Orders Status</h3>
        <asp:GridView ID="grdOrderStatus" runat="server"></asp:GridView>
    </form>
    <a href="PlaceOrder.aspx">Place Order</a>
</body>
</html>

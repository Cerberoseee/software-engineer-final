<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlaceOrder.aspx.cs" Inherits="Reseller__Webform_.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="Application" runat="server">
        <div>
            <label>Order ID</label>
            <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
        </div>
        <div>
            <label>Reseller ID</label>
            <asp:TextBox ID="txtResellerID" runat="server"></asp:TextBox>
        </div>
        <div>
            <label>Payment Method</label>
            <asp:DropDownList ID="dropPayment" runat="server">
                <asp:ListItem Selected="True" Value="Cash"> Cash </asp:ListItem>
                <asp:ListItem Value="Momo"> Momo </asp:ListItem>
                <asp:ListItem Value="Bank"> Bank </asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            <div>
                <label>Good ID</label>
                <asp:TextBox ID="txtItemID" runat="server"></asp:TextBox>
            </div>
            <div>
                <label>Good Quantity</label>
                <asp:TextBox ID="txtQuantity" TextMode="Number" Text="0" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnAddItem" runat="server" Text="Add Item" OnClick="btnAddItem_Click" />
                <asp:Button ID="btnEditItem" runat="server" Text="Edit Item" OnClick="btnEditItem_Click" />
                <asp:Button ID="btnDelItem" runat="server" Text="Delete Item" OnClick="btnDelItem_Click" />
                <label id="errorNotFound" runat="server">Item ID not found</label>
                <label id="errorAdded" runat="server">Item already added</label>
                <label id="errorExceed" runat="server">Quantity exceeded the amount given</label>
            </div>
            <asp:GridView ID="grdAddedItem" runat="server">
            </asp:GridView>
        </div>
        <asp:GridView ID="grdGood" runat="server"></asp:GridView>
        <p>Total: <span id="totalMoney" runat="server">0</span> VND</p>
        <asp:Button ID="btnSaveOrder" runat="server" Text="Place Order" OnClick="btnSaveOrder_Click" />
    </form>
</body>
</html>

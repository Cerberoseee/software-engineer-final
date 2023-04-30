<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeliveryManagement.aspx.cs" Inherits="Staff__WebForm_.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delivery Note Management</title>
</head>
<body>
    <header>
        <div>
            <a href="RecordManagement.aspx">Record Management</a>
            <a >Delivery Note Management</a>
        </div>
    </header>
    <form id="form1" runat="server">
        <div>
            <div>
                <label>Note ID</label>
                <asp:TextBox ID="txtNoteID" runat="server"></asp:TextBox>
            </div>
            <div>
                <label>Order ID</label>
                <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
            </div>
            <div>
                <label>Reseller ID</label>
                <asp:TextBox ID="txtResellerID" runat="server"></asp:TextBox>
            </div>
            <div>
                <label>Delivery Date</label>
                <asp:TextBox TextMode="Date" ID="txtDeliveryDate" runat="server"></asp:TextBox>
            </div>

            <div>
                <label>Delivery Address</label>
                <asp:TextBox ID="txtDeliveryAddress" runat="server"></asp:TextBox>
            </div>
        </div>

        <div>
            <asp:Button ID="btnAddNote" runat="server" Text="Add Deliver Note" OnClick="btnAddNote_Click" />
            <asp:Button ID="btnEditNote" runat="server" Text="Edit Delivery Note" OnClick="btnEditNote_Click" />
            <asp:Button ID="btnSaveNote" runat="server" Text="Save" OnClick="btnSaveNote_Click" />
            <asp:Button ID="btnCancelNote" runat="server" Text="Cancel" OnClick="btnCancelNote_Click" />
            <p runat="server" id="errNotFound">Delivery Note not found</p>
        </div>

        <div>
            <label>Delete Note ID</label>
            <asp:TextBox ID="txtDelNote" runat="server"></asp:TextBox>
            <asp:Button ID="btnDelNote" runat="server" Text="Delete" OnClick="btnDelNote_Click" />
        </div>

        <div>
            <asp:GridView ID="grdNote" runat="server"></asp:GridView>
        </div>

        <div>
            <div>
                <div>
                    <label>Order ID</label>
                    <asp:TextBox ID="txtOrderID2" runat="server"></asp:TextBox>
                </div>
                <div>
                    <label>Order Status</label>
                    <asp:DropDownList ID="dropOrderStatus" runat="server">
                        <asp:ListItem Selected="True" Value="On Delivery"> On Delivery </asp:ListItem>
                        <asp:ListItem Value="Unpaid"> Unpaid </asp:ListItem>
                        <asp:ListItem Value="Paid"> Paid </asp:ListItem>
                    </asp:DropDownList>
                </div>
                
                
                <asp:Button ID="btnSaveStatus" runat="server" Text="Save" OnClick="btnSaveStatus_Click" />
            </div>
            <asp:GridView ID="grdOrder" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecordManagement.aspx.cs" Inherits="Staff__WebForm_.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Record Management</title>
</head>
<body>
    <header>
        <div>
            <a >Record Management</a>
            <a href="DeliveryManagement.aspx">Delivery Note Management</a>
        </div>
    </header>
    <form runat="server" >
        <div style="display: flex; gap: 12px; width: 100%; max-width: 1200px; margin: auto">
            <div style="width: 30%;">
                <div style="display: flex; justify-content: space-between;">
                    <label>Receipt ID</label>
                    <asp:TextBox ID="txtGIRReceiptID" runat="server"></asp:TextBox>
                </div>
                <div style="display: flex; justify-content: space-between; margin-top: 12px">
                    <label>Good ID</label>
                    <asp:TextBox ID="txtGIRGoodID" runat="server"></asp:TextBox>
                </div>
                <div style="display: flex; justify-content: space-between; margin-top: 12px">
                    <label>Good Name</label>
                    <asp:TextBox ID="txtGIRGoodName" runat="server"></asp:TextBox>
                </div>
            </div>
        
            <div style="width: 30%">
                <div style="display: flex; justify-content: space-between;">
                    <label>Employee ID</label>
                    <asp:TextBox ID="txtGIREmpID" TextMode="Number" runat="server"></asp:TextBox>
                </div>
                <div style="display: flex; justify-content: space-between; margin-top: 12px">
                    <label>Good Price</label>
                    <asp:TextBox ID="txtGIRGoodPrice" TextMode="Number" runat="server"></asp:TextBox>
                </div>
                <div style="display: flex; justify-content: space-between; margin-top: 12px">
                    <label>Quantity</label>
                    <asp:TextBox ID="numGIRQuantity" TextMode="Number" runat="server"></asp:TextBox>
                </div>
            </div>
        

            <div style="width: 30%">
                <div style="display: flex; justify-content: space-between;">
                    <label>Import Date</label>
                    <asp:TextBox ID="dpGIRImport" runat="server" TextMode="Date"></asp:TextBox>
                </div>
                <div style="margin-top: 12px">
                    <div style="display: flex; justify-content: space-between; margin-top: 12px">
                        <asp:Button Width="30%" ID="btnAddGood" runat="server" Text="Add Good" OnClick="btnAddGood_Click" />  
                        <asp:Button Width="30%" ID="btnEditGood" runat="server" Text="Edit Good" OnClick="btnEditGood_Click" />                    
                        <asp:Button Width="30%" ID="btnSaveGood" runat="server" Text="Save Good" OnClick="btnSaveGood_Click" />  
                    </div>

                    <div style="display: flex; justify-content: space-between; margin-top: 12px">
                        <asp:Button Width="30%" ID="btnCreateRecord" runat="server" Text="Create Record" OnClick="btnCreateRecord_Click" />
                        <asp:Button Width="30%" ID="btnEditRecord" runat="server" Text="Edit Record" OnClick="btnEditRecord_Click" /> 
                        <asp:Button Width="30%" ID="btnSaveRecord" runat="server" Text="Save Record" OnClick="btnSaveRecord_Click" />  
                    </div>
                </div>
            </div> 
        </div>

        <div style="max-width: 1200px; margin: auto; margin-top: 12px"">
            <div style="display: flex; margin-top: 12px; gap: 12px">
                <div style="width: 30%; display: flex; justify-content: space-between">
                    <label>Find Good by Receipt ID</label>
                    <asp:TextBox ID="txtEditReceiptID" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Button ID="btnFindGood" runat="server" Text="Find" OnClick="btnFindGood_Click" />
                </div>
            </div>
            <div style="display: flex; margin-top: 12px; gap: 12px">
                <div style="width: 30%; display: flex; justify-content: space-between">
                    <label>Delete Receipt by Receipt ID</label>
                    <asp:TextBox ID="txtDeleteReceipt" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Button ID="btnDeleteReceipt" runat="server" Text="Delete Receipt" OnClick="btnDeleteReceipt_Click" />
                </div>
            </div>
            <div runat="server" id="goodDelete" style="display: flex; margin-top: 12px; gap: 12px">
                <div style="width: 30%; display: flex; justify-content: space-between">
                    <label>Delete Good by Good ID</label>
                    <asp:TextBox ID="txtDeleteGood" runat="server"></asp:TextBox>
                </div>
                <div>
                    <asp:Button ID="btnDeleteGood" runat="server" Text="Delete Good" OnClick="btnDeleteGood_Click"/>
                </div>
            </div>
        </div>

        <div style="display: flex; gap: 12px; width: 100%; max-width: 1200px; margin: auto; margin-top: 12px">
            <asp:GridView ID="grdGIRRecord" runat="server"></asp:GridView>
            <asp:GridView ID="grdGIRGood" runat="server"></asp:GridView>
        </div>
        <input runat="server" id="isAddedGood" type="hidden" />
        <input runat="server" id="isAddedRecord" type="hidden" />
    </form>
    
</body>
</html>

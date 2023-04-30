using BUS;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Reseller__Webform_
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string resellerID;
        private DataTable tbGood;
        private DataTable tbAddedItem;

        protected string generateOrderID()
        {
            BUS_ItemOrder gir = new BUS_ItemOrder("", "", "", "", DateTime.Now);

            DataRow[] tb = gir.selectQuery().Select("ResellerID = '" + resellerID + "'");
            return "ORD" + resellerID + (tb.Length + 1).ToString().PadLeft(4, '0');
        }

        private void updateGoodGrd()
        {
            grdGood.DataSource = tbGood;
            grdGood.DataBind();
        }

        private void updateAddedItem()
        {
            grdAddedItem.DataSource = tbAddedItem;
            grdAddedItem.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["ResID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                resellerID = Session["ResID"].ToString();
            }

            txtOrderID.Text = generateOrderID();
            txtResellerID.Text = resellerID;

            if (!IsPostBack)
            {
                BUS_DetailOrder temp = new BUS_DetailOrder(txtOrderID.Text, "", 0);
                DataRow[] tmpRows = temp.selectQuery().Select("OrderID = '" + txtOrderID.Text +"'");
                foreach (DataRow row in tmpRows)
                {
                    BUS_Good t = new BUS_Good("", "", 0, 0);
                    DataRow[] tDr = t.selectQuery().Select("GoodID = '" + row["GoodID"].ToString() + "'");
                    BUS_Good tmpGood = new BUS_Good(row["GoodID"].ToString(), "", Int32.Parse(tDr[0]["Quantity"].ToString()) +  Int32.Parse(row["Quantity"].ToString()), 0);
                    tmpGood.updateQuantityQuery();
                }
                temp.deleteQuery();

            }

            txtResellerID.ReadOnly = true;
            txtOrderID.ReadOnly = true;

            BUS_Good good = new BUS_Good("", "", 0, 0);
            tbGood = good.selectQuery();
            updateGoodGrd();

            BUS_DetailOrder dor = new BUS_DetailOrder("", "", 0);
            tbAddedItem = dor.selectQuery();
            DataRow[] rows = dor.selectQuery().Select("OrderID = '" + txtOrderID.Text + "'");
            tbAddedItem.Rows.Clear();
            foreach (DataRow r in rows)
            {
                DataRow tempRow = tbAddedItem.NewRow();
                tempRow[0] = r[0];
                tempRow[1] = r[1];
                tempRow[2] = r[2];
                tbAddedItem.Rows.Add(tempRow);
            }
            updateAddedItem();
            

            errorNotFound.Visible = false;
            errorExceed.Visible = false;
            errorAdded.Visible = false;

        }

        protected void btnAddItem_Click(object sender, EventArgs e)
        {
            string id = txtItemID.Text;
            int quantity = Int32.Parse(txtQuantity.Text);


            DataRow[] row = tbGood.Select("GoodID = '" + id + "'");


            if (tbAddedItem != null)
            {
                DataRow[] itemRow = tbAddedItem.Select("GoodID = '" + id + "'");

                if (itemRow.Length != 0)
                {
                    errorAdded.Visible = true;
                    return;
                }
                else
                {
                    errorAdded.Visible = false;
                }
            }
            

            if (row.Length == 0)
            {
                errorNotFound.Visible = true;
                return;
            } else
            {
                errorNotFound.Visible = false;
            }

            if (Int32.Parse(row[0]["Quantity"].ToString()) < quantity)
            {
                errorExceed.Visible = true;
                return;
            } else
            {
                errorExceed.Visible = false;
            }



            BUS_DetailOrder dor = new BUS_DetailOrder(txtOrderID.Text, id, quantity);
            dor.addQuery();

            BUS_Good good = new BUS_Good(id, "", Int32.Parse(row[0]["Quantity"].ToString()) - quantity, 0);
            good.updateQuantityQuery();
            tbGood = good.selectQuery();
            tbAddedItem = dor.selectQuery();
            totalMoney.InnerText = (Int32.Parse(totalMoney.InnerText.ToString()) +
                 Int32.Parse(row[0]["Price"].ToString()) * Int32.Parse(txtQuantity.Text)).ToString();
            updateGoodGrd();

            tbAddedItem = dor.selectQuery();
            DataRow[] rows = dor.selectQuery().Select("OrderID = '" + txtOrderID.Text + "'");
            tbAddedItem.Rows.Clear();
            foreach (DataRow r in rows)
            {
                DataRow tempRow = tbAddedItem.NewRow();
                tempRow[0] = r[0];
                tempRow[1] = r[1];
                tempRow[2] = r[2];
                tbAddedItem.Rows.Add(tempRow);
            }
            updateAddedItem();
        }

        protected void btnSaveOrder_Click(object sender, EventArgs e)
        {
            BUS_ItemOrder io = new BUS_ItemOrder(txtOrderID.Text, txtResellerID.Text, "Pending", dropPayment.Text, DateTime.Now);
            io.addQuery();
            Response.Redirect("~/OrderStatus.aspx");
        }

        protected void btnEditItem_Click(object sender, EventArgs e)
        {
            string id = txtItemID.Text;
            int quantity = Int32.Parse(txtQuantity.Text);

            DataRow[] row = tbGood.Select("GoodID = '" + id + "'");
            DataRow[] itemRow = tbAddedItem.Select("GoodID = '" + id + "'");    

            if (itemRow.Length == 0)
            {
                errorNotFound.Visible = true;
                return;
            }
            else
            {
                errorNotFound.Visible = false;
            }

            if (Int32.Parse(row[0]["Quantity"].ToString()) < quantity)
            {
                errorExceed.Visible = true;
                return;
            }
            else
            {
                errorExceed.Visible = false;
            }


            BUS_DetailOrder dor = new BUS_DetailOrder(txtOrderID.Text, id, quantity);
            dor.updateQuery();

            BUS_Good good = new BUS_Good(id, "", Int32.Parse(row[0]["Quantity"].ToString()) + Int32.Parse(itemRow[0]["Quantity"].ToString()) - quantity, 0);
            good.updateQuantityQuery();
            tbGood = good.selectQuery();
            tbAddedItem = dor.selectQuery();
            updateGoodGrd();

            DataRow[] rows = dor.selectQuery().Select("OrderID = '" + txtOrderID.Text + "'");
            tbAddedItem.Rows.Clear();
            totalMoney.InnerText = (Int32.Parse(totalMoney.InnerText.ToString()) - 
                (Int32.Parse(row[0]["Price"].ToString()) * Int32.Parse(itemRow[0]["Quantity"].ToString())) + 
                (Int32.Parse(row[0]["Price"].ToString()) * Int32.Parse(txtQuantity.Text) ) ).ToString();
            foreach (DataRow r in rows)
            {
                DataRow tempRow = tbAddedItem.NewRow();
                tempRow[0] = r[0];
                tempRow[1] = r[1];
                tempRow[2] = r[2];
                tbAddedItem.Rows.Add(tempRow);
            }
            updateAddedItem();
        }

        protected void btnDelItem_Click(object sender, EventArgs e)
        {
            string id = txtItemID.Text;
            int quantity = Int32.Parse(txtQuantity.Text);

            DataRow[] row = tbGood.Select("GoodID = '" + id + "'");
            DataRow[] itemRow = tbAddedItem.Select("GoodID = '" + id + "'");

            if (itemRow.Length == 0)
            {
                errorNotFound.Visible = true;
                return;
            }
            else
            {
                errorNotFound.Visible = false;
            }

            BUS_DetailOrder dor = new BUS_DetailOrder(txtOrderID.Text, id, quantity);
            dor.deleteQuery();

            BUS_Good good = new BUS_Good(id, "", Int32.Parse(row[0]["Quantity"].ToString()) + quantity, 0);
            good.updateQuantityQuery();
            tbGood = good.selectQuery();
            tbAddedItem = dor.selectQuery();
            updateGoodGrd();

            DataRow[] rows = dor.selectQuery().Select("OrderID = '" + txtOrderID.Text + "'");
            tbAddedItem.Rows.Clear();
            totalMoney.InnerText = (Int32.Parse(totalMoney.InnerText.ToString()) -
                (Int32.Parse(row[0]["Price"].ToString()) * Int32.Parse(itemRow[0]["Quantity"].ToString()))).ToString();
            foreach (DataRow r in rows)
            {
                DataRow tempRow = tbAddedItem.NewRow();
                tempRow[0] = r[0];
                tempRow[1] = r[1];
                tempRow[2] = r[2];
                tbAddedItem.Rows.Add(tempRow);
            }
            updateAddedItem();
        }
    }
}
using BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Staff__WebForm_
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private DataTable tbGood;
        private DataTable tbRecord;
        private string employeeID;


        protected void Page_Load(object sender, EventArgs e)
        {

            btnDeleteGood.Enabled = false;
            txtDeleteGood.Enabled = false;

            if (Session["EmpID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            } else
            {
                employeeID = Session["EmpID"].ToString();
            }
            disableGIRTxt();
            txtGIRReceiptID.ReadOnly = true;
            txtGIREmpID.ReadOnly = true;

            disableGIRBtn();
            btnCreateRecord.Enabled = true;


            BUS_Good good = new BUS_Good("", "", 0, 0);
            tbGood = good.selectQuery();
            tbGood.Rows.Clear();


            BUS_GoodImportReceipt gir = new BUS_GoodImportReceipt("", DateTime.Now, "");
            tbRecord = gir.selectQuery();

            updateGIRGoodGrd();
            updateGIRRecordGrd();
        }

        private void disableGIRBtn()
        {
            btnAddGood.Enabled = false;
            btnEditGood.Enabled = false;
            btnCreateRecord.Enabled = false;
            btnEditRecord.Enabled = false;
        }

        private void disableGIRTxt()
        {
            txtGIREmpID.Enabled = false;
            txtGIRReceiptID.Enabled = false;
            txtGIRGoodID.Enabled = false;
            txtGIRGoodPrice.Enabled = false;
            txtGIRGoodName.Enabled = false;
            numGIRQuantity.Enabled = false;
            dpGIRImport.Enabled = false;
        }

        private void enableGIRTxt()
        {
            txtGIREmpID.Enabled = true;
            txtGIRReceiptID.Enabled = true;
            txtGIRGoodID.Enabled = true;
            txtGIRGoodPrice.Enabled = true;
            txtGIRGoodName.Enabled = true;
            numGIRQuantity.Enabled = true;
            dpGIRImport.Enabled = true;
        }

        private void loadGood()
        {
            BUS_GoodImportReceipt gir = new BUS_GoodImportReceipt("", DateTime.Now, "");

            DataTable tb = gir.detailQuery();
            DataRow[] rows = tb.Select("ReceiptID = '" + txtEditReceiptID.Text + "'");
            tbGood.Rows.Clear();

            if (isAddedRecord.Value == "true")
            {
                BUS_GoodReceipt gr = new BUS_GoodReceipt("", txtGIRReceiptID.Text, 0);
                tbGood = gr.detailQuery();
                updateGIRGoodGrd();
                return;
            }

            if (rows.Length == 0)
            {
                txtGIRReceiptID.Text = "";
                txtGIREmpID.Text = "";
            }

            foreach (DataRow row in rows)
            {
                DataRow dr = tbGood.NewRow();
                dr[0] = row["GoodID"].ToString();
                dr[1] = row["GoodName"].ToString();
                dr[2] = Int32.Parse(row["Quantity"].ToString());
                dr[3] = Int32.Parse(row["Price"].ToString());

                txtGIRReceiptID.Text = row["ReceiptID"].ToString();
                txtGIREmpID.Text = row["EmployeeID"].ToString();

                tbGood.Rows.Add(dr);
            }

            updateGIRGoodGrd();
        }

        private string generateRecordID()
        {
            BUS_GoodImportReceipt gir = new BUS_GoodImportReceipt("", DateTime.Now, "");

            DataTable tb = gir.selectQuery();
            return DateTime.Now.ToString("yyyyMMdd") + tb.Rows.Count.ToString().PadLeft(4, '0');
        }

        private void updateGIRGoodGrd()
        {
            grdGIRGood.DataSource = tbGood;
            grdGIRGood.DataBind();
        }

        private void updateGIRRecordGrd()
        {
            grdGIRRecord.DataSource = tbRecord;
            grdGIRRecord.DataBind();
        }

        protected void btnCreateRecord_Click(object sender, EventArgs e)
        {
            btnAddGood.Enabled = true;
            txtGIRReceiptID.Text = generateRecordID();
            txtGIREmpID.Text = employeeID;
            dpGIRImport.Enabled = true;
            tbGood.Rows.Clear();
            btnEditGood.Enabled = true;
            btnAddGood.Enabled = true;
            isAddedRecord.Value = "true";
        }

        protected void btnAddGood_Click(object sender, EventArgs e)
        {
            txtGIRGoodID.Text = "";
            txtGIRGoodName.Text = "";
            txtGIRGoodPrice.Text = "";
            numGIRQuantity.Text = "0";
            btnEditGood.Enabled = true;
            enableGIRTxt();

            isAddedGood.Value = "true";
            btnSaveGood.Enabled = true;

            loadGood();
        }

        protected void btnFindGood_Click(object sender, EventArgs e)
        {
            btnAddGood.Enabled = true;
            btnEditGood.Enabled = true;
            btnEditRecord.Enabled = true;
            btnDeleteGood.Enabled = true;
            txtDeleteGood.Enabled = true;
            loadGood();
        }

        protected void btnEditGood_Click(object sender, EventArgs e)
        {
            txtGIRGoodID.Text = "";
            txtGIRGoodName.Text = "";
            txtGIRGoodPrice.Text = "";
            numGIRQuantity.Text = "0";
            btnAddGood.Enabled = true;
            enableGIRTxt();
            btnSaveGood.Enabled = true;


            isAddedGood.Value = "false";
            loadGood();
        }

        protected void btnSaveGood_Click(object sender, EventArgs e)
        {
            if (isAddedGood.Value == "true")
            {
                BUS_Good good = new BUS_Good(txtGIRGoodID.Text, txtGIRGoodName.Text, Int32.Parse(numGIRQuantity.Text), Int32.Parse(txtGIRGoodPrice.Text));
                good.addQuery();

                BUS_GoodReceipt gr = new BUS_GoodReceipt(txtGIRGoodID.Text, txtGIRReceiptID.Text, Int32.Parse(numGIRQuantity.Text));
                gr.addQuery();
            }
            else
            {
                BUS_Good good = new BUS_Good(txtGIRGoodID.Text, txtGIRGoodName.Text, Int32.Parse(numGIRQuantity.Text), Int32.Parse(txtGIRGoodPrice.Text));
                good.updateQuery();

                BUS_GoodReceipt gr = new BUS_GoodReceipt(txtGIRGoodID.Text, txtGIRReceiptID.Text, Int32.Parse(numGIRQuantity.Text));
                gr.updateQuery();
            }
            loadGood();
            btnAddGood.Enabled = true;
            btnEditGood.Enabled = true;
        }

        protected void btnEditRecord_Click(object sender, EventArgs e)
        {
            dpGIRImport.Enabled = true;
            isAddedRecord.Value = "false";
        }

        protected void btnSaveRecord_Click(object sender, EventArgs e)
        {
            if (isAddedRecord.Value == "true")
            {
                BUS_GoodImportReceipt gir = new BUS_GoodImportReceipt(txtGIRReceiptID.Text, DateTime.Parse(dpGIRImport.Text), txtGIREmpID.Text);
                gir.addQuery();
            }
            else
            {
                BUS_GoodImportReceipt gir = new BUS_GoodImportReceipt(txtGIRReceiptID.Text, DateTime.Parse(dpGIRImport.Text), txtGIREmpID.Text);
                gir.updateQuery();
            }
            isAddedGood.Value = "false";
            loadGood();
            updateGIRRecordGrd();
            btnSaveGood.Enabled = false;
        }

        protected void btnDeleteReceipt_Click(object sender, EventArgs e)
        {
            BUS_GoodImportReceipt gir = new BUS_GoodImportReceipt(txtDeleteReceipt.Text, DateTime.Now, "");
            DataTable temp = gir.detailQuery();
            DataRow[] rows = temp.Select("ReceiptID = '" + txtDeleteReceipt.Text + "'");
            foreach (DataRow row in rows)
            {
                BUS_Good good = new BUS_Good(row["GoodID"].ToString(), row["GoodName"].ToString(), 0, 0);
                good.deleteQuery();

                BUS_GoodReceipt gr = new BUS_GoodReceipt(row["GoodID"].ToString(), txtDeleteReceipt.Text, 0);
                gr.deleteQuery();
            }
            gir.deleteQuery();
            updateGIRRecordGrd();
        }

        protected void btnDeleteGood_Click(object sender, EventArgs e)
        {
            BUS_Good good = new BUS_Good(txtDeleteGood.Text, "", 0, 0);
            good.deleteQuery();

            BUS_GoodReceipt gr = new BUS_GoodReceipt(txtDeleteGood.Text, txtEditReceiptID.Text, 0);
            gr.deleteQuery();
            loadGood();
        }
    }
}
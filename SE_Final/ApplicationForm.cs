using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Final
{
    public partial class ApplicationForm : Form
    {
        private DataTable tbGood;
        private DataTable tbRecord;

        private Boolean isAdded = false;

        private string employeeID;
        public ApplicationForm(string empID)
        {
            InitializeComponent();
            employeeID = empID;
        }

        private void disableGIRBtn()
        {
            btnAddGood.Enabled = false;
            btnSaveGood.Enabled = false;
            btnDelGood.Enabled = false;
            btnCreateRecord.Enabled = false;
            btnSaveRecord.Enabled = false;
            btnDelRecord.Enabled = false;
        }

        private void enableGIRBtn()
        {
            btnAddGood.Enabled = true;
            btnSaveGood.Enabled = true;
            btnDelGood.Enabled = true;
            btnCreateRecord.Enabled = true;
            btnSaveRecord.Enabled = true;
            btnDelRecord.Enabled = true;
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

        private string generateRecordID()
        {
            BUS_GoodImportReceipt gir = new BUS_GoodImportReceipt("", DateTime.Now, "");

            DataTable tb = gir.selectQuery();
            return DateTime.Now.ToString("yyyyMMdd") + tb.Rows.Count.ToString().PadLeft(4, '0');
        }

        private void updateGIRGoodGrd()
        {
            grdGIRGood.DataSource = tbGood;
        }

        private void updateGIRRecordGrd()
        {
            grdGIRRecord.DataSource = tbRecord;
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            disableGIRTxt();
            txtGIRReceiptID.ReadOnly = true;
            txtGIREmpID.ReadOnly = true;

            disableGIRBtn();
            btnCreateRecord.Enabled = true;
            KeyPreview = true;

            BUS_Good good = new BUS_Good("", "", 0, 0);
            tbGood = good.selectQuery();
            tbGood.Rows.Clear();

            BUS_GoodImportReceipt gir = new BUS_GoodImportReceipt("", DateTime.Now, "");
            tbRecord = gir.selectQuery();

            updateGIRGoodGrd();
            updateGIRRecordGrd();
        }

        private void btnCreateRecord_Click(object sender, EventArgs e)
        {
            btnAddGood.Enabled = true;
            txtGIRReceiptID.Text = generateRecordID();
            txtGIREmpID.Text = employeeID;
            dpGIRImport.Enabled = true;
        }

        private void btnAddGood_Click(object sender, EventArgs e)
        {
            txtGIRGoodID.Text = "";
            txtGIRGoodName.Text = "";
            txtGIRGoodPrice.Text = "";
            numGIRQuantity.Value = 0;
            enableGIRTxt();
            isAdded = true;
        }

        private void btnDelGood_Click(object sender, EventArgs e)
        {
            int rowIndex = grdGIRGood.CurrentRow.Index;

            tbGood.Rows.Remove(tbGood.Rows[rowIndex]);
            btnDelGood.Enabled = false;

        }

        private void btnSaveGood_Click(object sender, EventArgs e)
        {
            string id = txtGIRGoodID.Text;
            string name = txtGIRGoodName.Text;
            string price = txtGIRGoodPrice.Text;
            string quantity = numGIRQuantity.Text;

            DataRow dr = tbGood.NewRow();

            dr[0] = id;
            dr[1] = name;
            dr[3] = Int32.Parse(quantity);
            dr[2] = Int32.Parse(price);

            if (isAdded)
            {
                tbGood.Rows.Add(dr);
                isAdded = false;
            } else
            {
                int index = grdGIRGood.CurrentRow.Index;

                tbGood.Rows[index][0] = id;
                tbGood.Rows[index][1] = name;
                tbGood.Rows[index][2] = price;
                tbGood.Rows[index][3] = quantity;
            }
            updateGIRGoodGrd();
            btnSaveGood.Enabled = false;

        }


        private void ApplicationForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtGIRGoodID.Text != "" && txtGIRGoodName.Text != "" && txtGIRGoodPrice.Text != "")
            {
                btnSaveGood.Enabled = true;
            }
            else
            {
                btnSaveGood.Enabled = false;
            }
        }

        private void txtGIRGoodPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void grdGIRGood_Click(object sender, EventArgs e)
        {
            btnDelGood.Enabled = true;

            txtGIRGoodID.Text = grdGIRGood.CurrentRow.Cells[0].Value.ToString();
            txtGIRGoodName.Text = grdGIRGood.CurrentRow.Cells[1].Value.ToString();
            txtGIRGoodPrice.Text = grdGIRGood.CurrentRow.Cells[2].Value.ToString() ;
            numGIRQuantity.Text = grdGIRGood.CurrentRow.Cells[3].Value.ToString() ;
        }

        private void tabGIR_Click(object sender, EventArgs e)
        {

        }
    }
}

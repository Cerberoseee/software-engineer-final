using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Final
{
    public partial class ApplicationForm : Form
    {
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

        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            disableGIRTxt();
            txtGIRReceiptID.ReadOnly = true;
            txtGIREmpID.ReadOnly = true;

            disableGIRBtn();
            btnCreateRecord.Enabled = true;
        }

        private void btnCreateRecord_Click(object sender, EventArgs e)
        {
            enableGIRBtn();
            enableGIRTxt();

            txtGIRReceiptID.Text = generateRecordID();
            txtGIREmpID.Text = employeeID;
        }
    }
}

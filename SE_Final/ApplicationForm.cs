using BUS;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Final
{
    public partial class ApplicationForm : Form
    {
        private DataTable tbGood;
        private DataTable tbRecord;
        private DataTable tbReseller;

        private DataTable tbGDN;
        private DataTable tbGDNOrder;

        private Boolean isAddedGood = false;
        private Boolean isAddedRecord = false;
        private Boolean isAddedGDN = false;

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
            return DateTime.Now.ToString("yyyyMMdd") + (tb.Rows.Count + 1).ToString().PadLeft(4, '0');
        }

        private string generateNoteID()
        {
            BUS_DeliveryNote gir = new BUS_DeliveryNote("", "", "", DateTime.Now, "");

            DataTable tb = gir.selectQuery();
            return "DN" + DateTime.Now.ToString("yyyyMMdd") + (tb.Rows.Count + 1).ToString().PadLeft(4, '0');
        }

        private string generateResellerID()
        {
            BUS_Reseller res = new BUS_Reseller("", "", "", "", "");
            DataTable tb = res.selectQuery();
            return (tb.Rows.Count + 1).ToString().PadLeft(4, '0');
        }

        private void updateGIRGoodGrd()
        {
            grdGIRGood.DataSource = tbGood;
        }

        private void updateGIRRecordGrd()
        {
            grdGIRRecord.DataSource = tbRecord;
        }

        private void updateGDNGir()
        {
            grdGDN.DataSource = tbGDN;
        }

        private void updateGDNOrderGir()
        {
            grdGDNOrder.DataSource = tbGDNOrder;
        }

        private void updateResellerGrd()
        {
            grdReseller.DataSource = tbReseller;
            grdReseller.Columns["Password"].Visible = false;
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            disableGIRTxt();
            txtGIRReceiptID.ReadOnly = true;
            txtGIREmpID.ReadOnly = true;
            txtResellerID.ReadOnly = true;
            txtGDNNoteID.ReadOnly = true;

            txtResellerID.Text = generateResellerID();

            disableGIRBtn();
            btnCreateRecord.Enabled = true;
            KeyPreview = true;

            btnResellerDelete.Enabled = false;

            BUS_Good good = new BUS_Good("", "", 0, 0);
            tbGood = good.selectQuery();
            tbGood.Rows.Clear();

            BUS_GoodImportReceipt gir = new BUS_GoodImportReceipt("", DateTime.Now, "");
            tbRecord = gir.selectQuery();

            BUS_Reseller res = new BUS_Reseller("", "", "", "", "");
            tbReseller = res.selectQuery();

            BUS_DeliveryNote dn = new BUS_DeliveryNote("", "", "", DateTime.Now, "");
            tbGDN = dn.selectQuery();

            BUS_ItemOrder io = new BUS_ItemOrder("", "", "", "", DateTime.Now);
            tbGDNOrder = io.selectQuery();

            rpvReport.Visible = false;

            updateGDNGir();
            updateGDNOrderGir();
            updateGIRGoodGrd();
            updateGIRRecordGrd();
            updateResellerGrd();
            this.rpvReport.RefreshReport();

            txtGDNNoteID.Enabled = false;
            txtGDNResellerID.Enabled = false;
            txtGDNOrderID.Enabled = false;
            txtGDNAddress.Enabled = false;
            dpGDNDate.Enabled = false;
            txtGDNOrderStatus.Enabled = false;
            btnGDNDel.Enabled = false;
        }

        private void btnCreateRecord_Click(object sender, EventArgs e)
        {
            btnAddGood.Enabled = true;
            txtGIRReceiptID.Text = generateRecordID();
            txtGIREmpID.Text = employeeID;
            dpGIRImport.Enabled = true;
            btnSaveRecord.Enabled = true;
            tbGood.Rows.Clear();
        }

        private void btnAddGood_Click(object sender, EventArgs e)
        {
            txtGIRGoodID.Text = "";
            txtGIRGoodName.Text = "";
            txtGIRGoodPrice.Text = "";
            numGIRQuantity.Value = 0;
            enableGIRTxt();
            isAddedGood = true;
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
            dr[2] = Int32.Parse(quantity);
            dr[3] = Int32.Parse(price);

            if (isAddedGood)
            {
                tbGood.Rows.Add(dr);
                isAddedGood = false;
            } else
            {
                int index = grdGIRGood.CurrentRow.Index;

                tbGood.Rows[index][0] = id;
                tbGood.Rows[index][1] = name;
                tbGood.Rows[index][2] = quantity;
                tbGood.Rows[index][3] = price;
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
            isAddedGood = false;

            txtGIRGoodID.Text = grdGIRGood.CurrentRow.Cells[0].Value.ToString();
            txtGIRGoodName.Text = grdGIRGood.CurrentRow.Cells[1].Value.ToString();
            numGIRQuantity.Text = grdGIRGood.CurrentRow.Cells[2].Value.ToString();
            txtGIRGoodPrice.Text = grdGIRGood.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            BUS_GoodImportReceipt gir = new BUS_GoodImportReceipt(txtGIRReceiptID.Text, dpGIRImport.Value, txtGIREmpID.Text);

            if (isAddedRecord)
            {
                gir.addQuery();
                foreach (DataRow row in tbGood.Rows)
                {
                    BUS_Good good = new BUS_Good(row[0].ToString(), row[1].ToString(), Int32.Parse(row[2].ToString()), Int32.Parse(row[3].ToString()));
                    good.addQuery();

                    BUS_GoodReceipt gr = new BUS_GoodReceipt(row[0].ToString(), txtGIRReceiptID.Text, Int32.Parse(row[2].ToString()));
                    gr.addQuery();
                }
                isAddedRecord = false;
            }
            else
            {
                gir.updateQuery();
                foreach (DataRow row in tbGood.Rows)
                {
                    BUS_Good good = new BUS_Good(row[0].ToString(), row[1].ToString(), Int32.Parse(row[2].ToString()), Int32.Parse(row[3].ToString()));
                    good.updateQuery();

                    BUS_GoodReceipt gr = new BUS_GoodReceipt(row[0].ToString(), txtGIRReceiptID.Text, Int32.Parse(row[2].ToString()));
                    gr.updateQuery();
                }
            }
            

            tbRecord = gir.selectQuery();
            updateGIRRecordGrd();
            btnSaveGood.Enabled = false;
        }

        private void grdGIRRecord_Click(object sender, EventArgs e)
        {
            btnSaveRecord.Enabled = true;
            btnAddGood.Enabled = true;
            btnDelGood.Enabled = true;

            isAddedRecord = false;
            enableGIRTxt();

            if (grdGIRRecord.CurrentRow.Index == grdGIRRecord.Rows.Count - 1)
            {
                tbGood.Clear();
                updateGIRGoodGrd();
                return;
            }

            txtGIRReceiptID.Text = grdGIRRecord.CurrentRow.Cells[0].Value.ToString();
            dpGIRImport.Value = DateTime.Parse(grdGIRRecord.CurrentRow.Cells[1].Value.ToString());
            txtGIREmpID.Text = grdGIRRecord.CurrentRow.Cells[2].Value.ToString();

            BUS_GoodImportReceipt gir = new BUS_GoodImportReceipt("", DateTime.Now, "");

            DataTable tb = gir.detailQuery();
            DataRow[] rows = tb.Select("ReceiptID = '" + grdGIRRecord.CurrentRow.Cells[0].Value.ToString() + "'");
            tbGood.Rows.Clear();

            foreach (DataRow row in rows)
            {
                DataRow dr = tbGood.NewRow();
                dr[0] = row["GoodID"].ToString();
                dr[1] = row["GoodName"].ToString();
                dr[2] = Int32.Parse(row["Quantity"].ToString());
                dr[3] = Int32.Parse(row["Price"].ToString());
                

                tbGood.Rows.Add(dr);
            }

            updateGIRGoodGrd();
        }

        private void btnDelRecord_Click(object sender, EventArgs e)
        {
            BUS_GoodImportReceipt gir = new BUS_GoodImportReceipt(txtGIRReceiptID.Text, dpGIRImport.Value, txtGIREmpID.Text);
            foreach (DataRow row in tbGood.Rows)
            {
                BUS_Good good = new BUS_Good(row[0].ToString(), row[1].ToString(), Int32.Parse(row[2].ToString()), Int32.Parse(row[3].ToString()));
                good.deleteQuery();

                BUS_GoodReceipt gr = new BUS_GoodReceipt(row[0].ToString(), txtGIRReceiptID.Text, Int32.Parse(row[2].ToString()));
                gr.deleteQuery();
            }
            gir.deleteQuery();

            txtGIRReceiptID.Text = "";
            txtGIREmpID.Text = "";
            dpGIRImport.Value = DateTime.Now;
            txtGIRGoodID.Text = "";
            txtGIRGoodName.Text = "";
            txtGIRGoodPrice.Text = "";
            numGIRQuantity.Value = 0;
        }

        private void btnResellerAdd_Click(object sender, EventArgs e)
        {
            string id = txtResellerID.Text;
            string name = txtResellerName.Text;
            string address = txtResellerAddress.Text;
            string username = txtResellerUser.Text;
            string pass = txtResellerPass.Text;

            BUS_Reseller res = new BUS_Reseller(id, name, address, username, pass);
            res.addQuery();

            txtResellerID.Text = generateResellerID();
            tbReseller = res.selectQuery();
            updateResellerGrd();
        }

        private void btnResellerDelete_Click(object sender, EventArgs e)
        {
            string id = grdReseller.CurrentRow.Cells[0].Value.ToString();
            BUS_Reseller res = new BUS_Reseller(id, "", "", "", "");
            res.deleteQuery();

            txtResellerID.Text = generateResellerID();
            tbReseller = res.selectQuery();
            updateResellerGrd();

            txtResellerName.Text = "";
            txtResellerAddress.Text = "";
            txtResellerUser.Text = "";
            txtResellerPass.Text = "";
        }

        private void grdReseller_Click(object sender, EventArgs e)
        {
            btnResellerDelete.Enabled = true;
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            BUS_GoodImportReceipt gir = new BUS_GoodImportReceipt("", DateTime.Now, "");
            BUS_GoodReceipt gr = new BUS_GoodReceipt("", "", 0);
            BUS_ItemOrder io = new BUS_ItemOrder("", "", "", "", DateTime.Now);
            BUS_DetailOrder dor = new BUS_DetailOrder("", "", 0);
            BUS_Good good = new BUS_Good("", "", 0, 0);

            DateTime date = dpReportNow.Value;

            DataTable tbGir = gir.selectQuery();
            DataTable tbGr = gr.selectQuery();
            DataTable tbIo = io.selectQuery();
            DataTable tbDor = dor.selectQuery();
            DataTable tbGood = good.selectQuery();

            IEnumerable<DataRow> tb1 = (from p in tbGir.AsEnumerable()
                                        join t in tbGr.AsEnumerable()
                                        on p.Field<string>("ReceiptID") equals t.Field<string>("ReceiptID")
                                        where p.Field<DateTime>("ImportDate").Month == date.Month && p.Field<DateTime>("ImportDate").Year == date.Year
                                        select t
                                        );
            
            DataTable dt1 = tbGood.Clone();
            dt1.Rows.Clear();

            if (tb1.Count() > 0 )
            {
                dt1 = tb1.CopyToDataTable<DataRow>();
            }

            var tb2 = (from p in tbIo.AsEnumerable()
                       join t in tbDor.AsEnumerable()
                       on p.Field<string>("OrderID") equals t.Field<string>("OrderID")
                       where p.Field<DateTime>("CreatedDate").Month == date.Month && p.Field<DateTime>("CreatedDate").Year == date.Year
                       group t by t.Field<string>("GoodID") into gt
                       select new
                       {
                           GoodID = gt.ElementAt(0).Field<string>("GoodID"),
                           Quantity = gt.Sum(t => t.Field<int>("Quantity"))
                       }
            );

            DataTable dt2 = LinqToDataTable(tb2);

            var tb3 = (from p in tbIo.AsEnumerable()
                       join t in tbDor.AsEnumerable()
                       on p.Field<string>("OrderID") equals t.Field<string>("OrderID")
                       where p.Field<DateTime>("CreatedDate").Month == date.Month && p.Field<DateTime>("CreatedDate").Year == date.Year
                       group t by t.Field<string>("GoodID") into gt
                       orderby gt.Sum(t => t.Field<int>("Quantity")) descending
                       select new
                       {
                           GoodID = gt.ElementAt(0).Field<string>("GoodID"),
                           Quantity = gt.Sum(t => t.Field<int>("Quantity"))
                       }
           );

            DataTable dt3 = LinqToDataTable(tb3);

            var tb4 = (from p in tbIo.AsEnumerable()
                       join t in tbDor.AsEnumerable()
                       on p.Field<string>("OrderID") equals t.Field<string>("OrderID")
                       where p.Field<DateTime>("CreatedDate").Month == date.Month && p.Field<DateTime>("CreatedDate").Year == date.Year
                       group t by t.Field<string>("GoodID") into gt
                       select new
                       {
                           GoodID = gt.ElementAt(0).Field<string>("GoodID"),
                           Quantity = gt.Sum(t => t.Field<int>("Quantity")),
                       }
           );

            var revenue = (from p in tb4.AsEnumerable()
                           join t in tbGood.AsEnumerable()
                           on p.GoodID equals t.Field<string>("GoodID") into rv
                           select new
                           {
                               Revenue = rv.Sum(t => p.Quantity * t.Field<int>("Price"))
                           }
            ).AsEnumerable().Sum(x => x.Revenue); ;


            grdGIRGood.DataSource = dt1;

            rpvReport.Visible = true;
            rpvReport.LocalReport.ReportPath = "../../Report.rdlc";
            ReportDataSource rds1 = new ReportDataSource("DataSet1", dt1);
            ReportDataSource rds2 = new ReportDataSource("DataSet2", dt2);
            ReportDataSource rds3 = new ReportDataSource("DataSet3", dt3);
            ReportParameter rev = new ReportParameter("Revenue", revenue.ToString() + " VND");

            rpvReport.LocalReport.DataSources.Clear();

            rpvReport.LocalReport.SetParameters(new ReportParameter[] { rev });
            rpvReport.LocalReport.DataSources.Add(rds1);
            rpvReport.LocalReport.DataSources.Add(rds2);
            rpvReport.LocalReport.DataSources.Add(rds3);
            rpvReport.LocalReport.Refresh();
            rpvReport.RefreshReport();

        }

        private DataTable LinqToDataTable<T>(IEnumerable<T> items)
        {
            DataTable dt = new DataTable(typeof(T).Name);
            PropertyInfo[] propInfos = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo propInfo in propInfos)
            {
                dt.Columns.Add(new DataColumn(propInfo.Name, propInfo.PropertyType));
            }

            foreach (T item in items)
            {
                DataRow dr = dt.Rows.Add();

                foreach (PropertyInfo propInfo in propInfos)
                {
                    dr[propInfo.Name] = propInfo.GetValue(item, null);
                }
            }

            return dt;
        }

        private void btnGDNAdd_Click(object sender, EventArgs e)
        {
            txtGDNNoteID.Text = generateNoteID();

            txtGDNResellerID.Enabled = true;
            txtGDNOrderID.Enabled = true;
            txtGDNAddress.Enabled = true;
            dpGDNDate.Enabled = true;
            btnGDNSave.Enabled = true;
            isAddedGDN = true;
        }

        private void grdGDN_Click(object sender, EventArgs e)
        {
            txtGDNResellerID.Text = grdGDN.CurrentRow.Cells[1].Value.ToString();
            txtGDNOrderID.Text = grdGDN.CurrentRow.Cells[2].Value.ToString();
            dpGDNDate.Value = DateTime.Parse(grdGDN.CurrentRow.Cells[3].Value.ToString());
            txtGDNAddress.Text = grdGDN.CurrentRow.Cells[4].Value.ToString();

            btnGDNDel.Enabled = true;
            txtGDNResellerID.Enabled = true;
            txtGDNOrderID.Enabled = true;
            txtGDNAddress.Enabled = true;
            dpGDNDate.Enabled = true;
            btnGDNSave.Enabled = true;
        }

        private void btnGDNDel_Click(object sender, EventArgs e)
        {
            string id = grdGDN.CurrentRow.Cells[0].Value.ToString();
            BUS_DeliveryNote dn = new BUS_DeliveryNote(id, "", "", DateTime.Now, "");
            dn.deleteQuery();

            tbGDN = dn.selectQuery();
            updateGDNGir();
        }

        private void btnGDNSave_Click(object sender, EventArgs e)
        {
            string id = txtGDNNoteID.Text;
            string resellerId = txtGDNResellerID.Text;
            string orderId = txtGDNOrderID.Text;
            string address = txtGDNAddress.Text;
            DateTime time = dpGDNDate.Value;
            
            BUS_DeliveryNote dn = new BUS_DeliveryNote(id, orderId, resellerId, time, address);

            if (isAddedGDN)
            {
                dn.addQuery();
            } else
            {
                dn.updateQuery();
            }

            tbGDN = dn.selectQuery();
            updateGDNGir();
            btnGDNSave.Enabled = false;
            isAddedGDN = false;

            txtGDNResellerID.Enabled = false;
            txtGDNOrderID.Enabled = false;
            txtGDNAddress.Enabled = false;
            dpGDNDate.Enabled = false;
            btnGDNSave.Enabled = false;
        }
    }
}

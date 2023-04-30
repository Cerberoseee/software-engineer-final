using BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Staff__WebForm_
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private DataTable tbNote;
        private DataTable tbOrder;
        private string employeeID;

        private void updateNoteGrd()
        {
            BUS_DeliveryNote note = new BUS_DeliveryNote("", "", "", DateTime.Now, "");
            tbNote = note.selectQuery();

            grdNote.DataSource = tbNote;
            grdNote.DataBind();
        }

        private string generateNoteID()
        {
            BUS_DeliveryNote gir = new BUS_DeliveryNote("", "", "", DateTime.Now, "");

            DataTable tb = gir.selectQuery();
            return "DN" + DateTime.Now.ToString("ddMMyyyy") + (tb.Rows.Count + 1).ToString().PadLeft(4, '0');
        }

        private void updateOrderGrd()
        {
            BUS_ItemOrder io = new BUS_ItemOrder("", "", "", "", DateTime.Now);
            tbOrder = io.selectQuery();

            DataRow[] dr = io.selectQuery().Select();
            tbOrder.Rows.Clear();

            foreach (DataRow row in dr)
            {
                DataRow tmp = tbOrder.NewRow();

                tmp[0] = row[0];
                tmp[1] = row[1];
                tmp[2] = row[2];
                tmp[3] = row[3];
                tmp[4] = row[4];

                tbOrder.Rows.Add(tmp);
            }

            grdOrder.DataSource = tbOrder;
            grdOrder.DataBind();
        }

        private void clearInput()
        {
            txtOrderID.Text = "";
            txtResellerID.Text = ""; 
            txtDeliveryDate.Text = "";
            txtDeliveryAddress.Text = "";
            txtDelNote.Text = "";
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            txtNoteID.Text = generateNoteID();
            updateNoteGrd();
            updateOrderGrd();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EmpID"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                employeeID = Session["EmpID"].ToString();
            }


            btnSaveNote.Visible = false;
            btnCancelNote.Visible = false;
            txtNoteID.ReadOnly = true;
            errNotFound.Visible = false;


            updateNoteGrd();
            updateOrderGrd();
        }

        protected void btnAddNote_Click(object sender, EventArgs e)
        {
            string noteID = txtNoteID.Text;
            string orderID = txtOrderID.Text;
            string resellerID = txtResellerID.Text;
            string deliveryDate = txtDeliveryDate.Text;
            string deliveryAdd = txtDeliveryAddress.Text;

            BUS_DeliveryNote note = new BUS_DeliveryNote(noteID, orderID, resellerID, DateTime.Parse(deliveryDate), deliveryAdd);
            note.addQuery();

            BUS_ItemOrder ord = new BUS_ItemOrder("", "", "", "", DateTime.Now);
            DataRow[] dr = ord.selectQuery().Select("OrderID = '" + orderID + "'");

            if (dr.Length != 0)
            {
                DataRow row = dr[0];
                ord = new BUS_ItemOrder(orderID, row["ResellerID"].ToString(),
                    "On Delivery",
                    row["PaymentMethod"].ToString(),
                    DateTime.Parse(row["CreatedDate"].ToString())
                );
                ord.updateQuery();
            }


            clearInput();
        }

        protected void btnEditNote_Click(object sender, EventArgs e)
        {
            btnSaveNote.Visible = true;
            btnCancelNote.Visible = true;
            btnAddNote.Enabled = false;
            btnDelNote.Enabled = false;
            txtOrderID.ReadOnly = true;
            txtResellerID.ReadOnly = true;
            txtNoteID.ReadOnly = false;
        }

        protected void btnSaveNote_Click(object sender, EventArgs e)
        {
            string noteID = txtNoteID.Text;
            string orderID = txtOrderID.Text;
            string resellerID = txtResellerID.Text;
            string deliveryDate = txtDeliveryDate.Text;
            string deliveryAdd = txtDeliveryAddress.Text;

            BUS_DeliveryNote note = new BUS_DeliveryNote(noteID, orderID, resellerID, DateTime.Parse(deliveryDate), deliveryAdd);
            if (note.selectQuery().Select("NoteID = '" + noteID + "'").Length == 0)
            {
                errNotFound.Visible = true;
                clearInput();
                return;
            }
            note.updateQuery();

            updateNoteGrd();
            clearInput();

            btnSaveNote.Visible = false;
            btnCancelNote.Visible = false;
            btnAddNote.Enabled = true;
            btnDelNote.Enabled = true;
        }

        protected void btnCancelNote_Click(object sender, EventArgs e)
        {
            btnSaveNote.Visible = false;
            btnCancelNote.Visible = false;
            btnAddNote.Enabled = true;
            btnDelNote.Enabled = true;
            clearInput();
        }

        protected void btnDelNote_Click(Object sender, EventArgs e)
        {
            string noteID = txtDelNote.Text;

            BUS_DeliveryNote note = new BUS_DeliveryNote(noteID, "", "", DateTime.Now, "");
            DataRow[] dr = note.selectQuery().Select("NoteID = '" + noteID + "'");
            if (dr.Length == 0)
            {
                errNotFound.Visible = true;
                clearInput();
                return;
            }

            string orderID = dr[0]["OrderID"].ToString();

            BUS_ItemOrder ord = new BUS_ItemOrder("", "", "", "", DateTime.Now);
            dr = ord.selectQuery().Select("OrderID = '" + orderID + "'");

            DataRow row = dr[0];
            ord = new BUS_ItemOrder(orderID, row["ResellerID"].ToString(),
                "On Delivery",
                row["PaymentMethod"].ToString(),
                DateTime.Parse(row["CreatedDate"].ToString())
            );
            ord.updateQuery();

            note.deleteQuery();
            updateNoteGrd();
        }

        protected void btnSaveStatus_Click(object sender, EventArgs e)
        {
            string orderID = txtOrderID2.Text;
            BUS_ItemOrder ord = new BUS_ItemOrder("", "", "", "", DateTime.Now);
            DataRow [] dr = ord.selectQuery().Select("OrderID = '" + orderID + "'");

            DataRow row = dr[0];
            ord = new BUS_ItemOrder(orderID, row["ResellerID"].ToString(),
                dropOrderStatus.Text,
                row["PaymentMethod"].ToString(),
                DateTime.Parse(row["CreatedDate"].ToString())
            );
            ord.updateQuery();

        }

       
    }
}
using BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Reseller__Webform_
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private DataTable tbOrder;
        private string resellerID;

        private void updateOrderGrd()
        {
            grdOrderStatus.DataSource = tbOrder;
            grdOrderStatus.DataBind();
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
            BUS_ItemOrder dor = new BUS_ItemOrder("", "", "", "", DateTime.Now);
            tbOrder = dor.selectQuery();

            DataRow[] rows = dor.selectQuery().Select("ResellerID = '" + resellerID + "'");
            tbOrder.Rows.Clear();

            foreach (DataRow row in rows)
            {
                DataRow dr = tbOrder.NewRow();
                dr[0] = row[0];
                dr[1] = row[1];
                dr[2] = row[2];
                dr[3] = row[3];
                dr[4] = row[4];
                tbOrder.Rows.Add(dr);
            }
            tbOrder.Columns.RemoveAt(1);
            tbOrder.Columns.RemoveAt(2);
            updateOrderGrd();
        }
    }
}
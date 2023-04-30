using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;

namespace Reseller__Webform_
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            msgFailed.Visible = false;
            msgSuccess.Visible = false;
        }
        DataTable tb;
        public static string passwordHash(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }


        private void showFail()
        {
            msgFailed.Visible = true;
            msgSuccess.Visible = false;
        }

        private void showSuccess()
        {
            msgFailed.Visible = false;
            msgSuccess.Visible = true;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            BUS_Reseller emp = new BUS_Reseller("", "", "", "", "");
            tb = emp.selectQuery();


            string expression = "Username = '" + txtUsername.Text + "'";
            DataRow[] users = tb.Select(expression);

            if (users.Length == 0 || users == null)
            {
                showFail();
            }
            else
            {
                if (users[0]["Password"].ToString() == passwordHash(txtPassword.Text))
                {
                    showSuccess();
                    Session["ResID"] = users[0]["ResellerID"].ToString();
                    Response.Redirect("~/OrderStatus.aspx");
                }
                else
                {
                    showFail();
                }
            }
        }
    }
}
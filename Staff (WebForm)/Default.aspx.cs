using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using BUS;

namespace Staff__WebForm_
{
    public partial class _Default : Page
    {
        DataTable tb;
        protected void Page_Init(object sender, EventArgs e)
        {
            msgFailed.Visible = false;
            msgSuccess.Visible = false;
        }
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
            BUS_Employee emp = new BUS_Employee("", "", "", "", "");
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
                    Session["EmpID"] = users[0]["EmployeeID"].ToString();
                    Response.Redirect("~/RecordManagement.aspx");
                }
                else
                {
                    showFail();
                }
            }
        }
    }
}
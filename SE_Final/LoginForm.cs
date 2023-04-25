using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Final
{
    public partial class LoginForm : Form
    {

        DataTable tb;

        public LoginForm()
        {
            InitializeComponent();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BUS_Employee emp = new BUS_Employee("", "", "", "", "");
            tb = emp.selectQuery();


            string expression = "Username = '" + txtBoxUser.Text.ToString() + "'";
            DataRow[] users = tb.Select(expression);
            Debug.WriteLine(expression);

            if (users.Length == 0 || users == null)
            {
                showFail();
            }  
            else
            {
                if (users[0]["Password"].ToString() == passwordHash(txtBoxPass.Text)) {
                    showSuccess();
                    ApplicationForm app = new ApplicationForm(users[0]["EmployeeID"].ToString());
                    this.Hide();
                    app.ShowDialog();
                    this.Close();
                } else
                {
                    showFail();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            msgFailed.Visible = false;
            msgSuccess.Visible = false;
            txtBoxPass.PasswordChar = '*';

            this.AcceptButton = btnLogin;
        }
    }
}

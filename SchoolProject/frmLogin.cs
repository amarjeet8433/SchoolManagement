using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUN.Text != "" && txtPassword.Text != "")
            {
                SqlConnection objcon = new SqlConnection();
                objcon.ConnectionString = @"data source=(LocalDB)\MSSQLLocalDB;initial catalog = master";// Integrated Security = True
                objcon.Open();

                SqlCommand objcmd = new SqlCommand();
                objcmd.CommandText = "SELECT FirstName,Password FROM users WHERE FirstName='" + txtUN.Text + "' AND Password='" + txtPassword.Text + "'";
                objcmd.Connection = objcon;

                DataTable objDT = new DataTable();

                SqlDataAdapter objDA = new SqlDataAdapter(objcmd);
                objDA.Fill(objDT);
                if (objDT.Rows.Count != 0)
                {
                    MessageBox.Show("Welcome user '" + txtUN.Text + "', you are logged in !!", "Login Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmAdminDashboard objDash = new frmAdminDashboard();
                    objDash.Show();
                }
                else
                {
                    MessageBox.Show("Username or Password is invalid", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("All fields are mandatory", "Details Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUN.Text = "";
            txtPassword.Text = "";
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistration objReg = new frmRegistration();
            objReg.Show();
            this.Hide();
        }
    }
}
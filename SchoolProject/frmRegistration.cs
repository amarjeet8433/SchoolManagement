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
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFN.Text != "" && txtLN.Text != "" && txtPassword.Text != "" && txtCPassword.Text != "")
            {
                if (txtPassword.Text == txtCPassword.Text)
                {
                    SqlConnection objcon = new SqlConnection();
                    objcon.ConnectionString = @"data source=(LocalDB)\MSSQLLocalDB;initial catalog = master";// Integrated Security = True
                    //objcon.Open();

                    SqlCommand objcmd = new SqlCommand();
                    objcmd.CommandText = "INSERT INTO users(FirstName,LastName,Password) VALUES('" + txtFN.Text + "','" + txtLN.Text + "','" + txtPassword.Text + "')";
                    objcmd.Connection = objcon;
                    //objcmd.ExecuteNonQuery();

                    //objcon.Close();

                    DataSet objDS = new DataSet();

                    SqlDataAdapter objDA = new SqlDataAdapter(objcmd);
                    objDA.Fill(objDS);

                    frmLogin objLogin = new frmLogin();
                    objLogin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password does not match", "Password mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Text = "";
                    txtCPassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("All fields are mandatory", "Details Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFN.Text = "";
            txtLN.Text = "";
            txtPassword.Text = "";
            txtCPassword.Text = "";
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin objLogin = new frmLogin();
            objLogin.Show();
            this.Hide();
        }
    }
}

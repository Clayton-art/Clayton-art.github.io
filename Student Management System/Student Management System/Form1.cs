using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strUsername = txtUsername.Text.Trim();
            string strPassword = txtPassword.Text;

            if (strUsername == "admin" && strPassword == "1234")
            {
                this.Hide();
                frmMainStudent frmMain = new frmMainStudent();
                frmMain.FormClosed += (s, args) => this.Close();
                frmMain.Show();
            }
            else
            {
                lblStatus.Text = "Invalid username or password!";
                txtPassword.Clear();
                txtUsername.Focus();
                txtUsername.SelectAll();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }
    }
}

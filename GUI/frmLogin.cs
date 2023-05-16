using GUI.DAO;
using GUI.DTO;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;
            int result = Login(userName, passWord);
            if (result == 1)
            {
                Account loginAccount = AccountDAO.GetAccountByUserName(userName);
                frmDashBoard frm = new frmDashBoard(loginAccount);
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else if (result == 0)
            {
                MessageBox.Show("SAI TÊN TÀI KHOẢN HOẶC MẬT KHẨU!!!!", "THÔNG BÁO");
            }
            else
            {
                MessageBox.Show("KẾT NỐI THẤT BẠI", "THÔNG BÁO");
            }
            btnLogin.Enabled = true;
        }

        private int Login(string userName, string passWord)
        {
            return AccountDAO.Login(userName, passWord);
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void mnuSetting_Click(object sender, EventArgs e)
        {
            frmConnectData frm = new frmConnectData();
            frm.ShowDialog();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "User")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.OliveDrab;

            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "User";
                txtUsername.ForeColor = Color.OliveDrab;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.OliveDrab;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.OliveDrab;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

    }
}

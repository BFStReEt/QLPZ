using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlyquanan;
using Quanlyquanan.DAO;
using Quanlyquanan.DTO;

namespace Quanlyquanan
{
    public partial class FLogin : Form
    {
        //251,214,188
        public FLogin()
        {
            InitializeComponent();
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Ẩn form đăng nhập xuống taskbar
        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtTaiKhoan.Text;
                string passWord = txtMatKhau.Text;
                if (Login(userName, passWord))
                {
                    Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                    FQuanLy quanLy = new FQuanLy();
                    this.Hide();
                    quanLy.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btHide_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                btShow.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                btHide.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

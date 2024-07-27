using BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class LoginForm : Form
    {
        NhanVienServices _services;
        public LoginForm()
        {
            _services = new NhanVienServices();
            InitializeComponent();
        }

        private void cb_ShowPW_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ShowPW.Checked)
            {
                tbt_Password.PasswordChar = '\0';
            }
            else tbt_Password.PasswordChar = '*';
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = tbt_Username.Text;
            string password = tbt_Password.Text;
            if (_services.Login(username, password) == "0")
            {
                MessageBox.Show("Đăng nhập thất bại, sai thông tin");
            }
            else if (_services.Login(username, password) == "1")
            {
                MessageBox.Show("Đăng nhập thất bại, có ít nhất 2 tài khoản trùng");
            }
            else
            {
                Guid idNV = Guid.Parse(_services.Login(username, password));
                this.Hide(); // This chính là form Login
                FormSanPham fsp = new FormSanPham(idNV);
                MessageBox.Show(idNV.ToString());
                fsp.ShowDialog();      
                fsp.FormClosed += Fsp_FormClosed;
                this.Show();
            }
        }
        private void Fsp_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show(); // Khi form sản phẩm kia đóng lại thì form đăng nhập lại hiện ra
        }
        // PasswordChar là thuộc tính khi chúng ta muốn ẩn mật khẩu và thay mỗi kí tự trong
        // mật khẩu bằng 1 ký tự nào đó
    }
}

using ChamSocKhachHang.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamSocKhachHang.gui
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static NhanVienBLL nv;

        private void Login_Load(object sender, EventArgs e)
        {
            this.pnl_login.BackColor = Color.FromArgb(230, 255, 255, 255);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            nv = NhanVienBLL.login(txt_tendn.Text, txt_matkhau.Text);
            if(nv != null)
            {
                Program.db = new Dashboard();
                Program.db.Show();
                Program.lg.Visible = false;
            }
            else
            {
                MessageBox.Show("Tên Đăng Nhập Hoặc Mật Khẩu không đúng !", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

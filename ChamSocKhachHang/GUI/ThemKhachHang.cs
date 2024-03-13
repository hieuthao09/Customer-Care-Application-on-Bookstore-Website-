using ChamSocKhachHang.BLL;
using ChamSocKhachHang.DAL;
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
    public partial class ThemKhachHang : Form
    {
        public ThemKhachHang()
        {
            InitializeComponent();
        }

        public KhachHang fparent = null;

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string maKH = txt_makh.Text;
            string sdt = txt_sdt.Text;
            string tenKh = txt_tenkh.Text;

            try
            {
                new KhachHangBLL().themKhachHang(maKH, tenKh, email, sdt);
                MessageBox.Show("Thêm Thông Tin Khách Hàng Thành Công.", "Response Successful !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fparent.KhachHang_Load(sender, e);
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Response Fail !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

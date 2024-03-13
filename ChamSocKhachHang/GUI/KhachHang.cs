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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ThemKhachHang tkh= new ThemKhachHang();
            tkh.fparent = this;
            tkh.Show();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = dgv_khachhang.CurrentRow.Cells[0].Value.ToString();
                new KhachHangBLL().xoaKhachHang(maKH);
                MessageBox.Show("Xóa Thông Tin Khách Hàng Thành Công.", "Response Successful !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KhachHang_Load(sender, e);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Response Fail !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = dgv_khachhang.CurrentRow.Cells[0].Value.ToString();
                string email = dgv_khachhang.CurrentRow.Cells[1].Value.ToString();
                string sdt = dgv_khachhang.CurrentRow.Cells[2].Value.ToString();
                string tenKH = dgv_khachhang.CurrentRow.Cells[3].Value.ToString();

                new KhachHangBLL().suaKhachHang(maKH, tenKH, email, sdt);
                MessageBox.Show("Cập Nhật Thông Tin Khách Hàng Thành Công.", "Response Successful !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KhachHang_Load(sender, e);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Response Fail !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void KhachHang_Load(object sender, EventArgs e)
        {
            dgv_khachhang.DataSource = new KhachHangBLL().getListKhachHang();
            if(dgv_khachhang.Rows.Count > 0)
            {
                dgv_khachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_khachhang.Columns[0].ReadOnly = true;
                dgv_khachhang.Columns[0].HeaderText = "Mã Khách Hàng";
                dgv_khachhang.Columns[1].HeaderText = "Địa Chỉ Email";
                dgv_khachhang.Columns[2].HeaderText = "Số Điện Thoại";
                dgv_khachhang.Columns[3].HeaderText = "Tên Khách Hàng";
            }
        }
    }
}

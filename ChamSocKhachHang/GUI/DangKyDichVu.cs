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
    public partial class DangKyDichVu : Form
    {
        public DichVu f = null;
        public DangKyDichVu()
        {
            InitializeComponent();
        }

        private void assignKhachHang(KhachHangBLL kh)
        {
            txtMaKH.Text = kh.MaKH;
            txtHoTen.Text = kh.TenKH;
            txtSDT.Text = kh.SDT;
            txtEmail.Text = kh.Email;
        }

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
            KhachHangBLL kh = new KhachHangBLL()
            {
                MaKH = txtMaKH.Text,
                TenKH = txtHoTen.Text,
                Email = txtEmail.Text,
                SDT = txtSDT.Text,
            };
            string maDV = cbDV.SelectedValue.ToString();
            DateTime ngayDK = dTNgayDK.Value;

            try
            {
                new QLDichVuKH().DangKyDichVu(kh, ngayDK, maDV);
                MessageBox.Show("Đăng Ký Thành Công Dịch Vụ Cho Khách Hàng '"+kh.TenKH+"'", "Register Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                f.DichVu_Load(sender, e);
                this.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Register Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DangKyDichVu_Load(object sender, EventArgs e)
        {
            dTNgayDK.Value = DateTime.Now;
            cbDV.DataSource = new DichVuBLL().getListDichVus();
            cbDV.ValueMember = "maDV";
            cbDV.DisplayMember = "tenDV";
        }

        private void txtMaKH_Leave(object sender, EventArgs e)
        {
            if(txtMaKH.Text.Length > 0)
            {
                KhachHangBLL kh = new KhachHangBLL().getThongTinKhachHang(txtMaKH.Text);
                assignKhachHang(kh);
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length > 0)
            {
                KhachHangBLL kh = new KhachHangBLL().getThongTinKhachHang(txtSDT.Text);
                assignKhachHang(kh);
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length > 0)
            {
                KhachHangBLL kh = new KhachHangBLL().getThongTinKhachHang(txtEmail.Text);
                assignKhachHang(kh);
            }
        }
    }
}

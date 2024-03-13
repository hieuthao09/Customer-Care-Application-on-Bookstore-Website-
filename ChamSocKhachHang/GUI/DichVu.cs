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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ChamSocKhachHang.gui
{
    public partial class DichVu : Form
    {
        public DichVu()
        {
            InitializeComponent();
        }

        public void DichVu_Load(object sender, EventArgs e)
        {
            dgv_Dichvu.DataSource = new QLDichVuKH().getListDichVu_KhachHang_DK().Select(t => new
            {
                MaDV = t.DichVu.maDV,
                TenDV = t.DichVu.tenDV,
                NgayDK = t.ngayDK,
                MaKH = t.KhachHang.MaKH,
                TenKH = t.KhachHang.TenKH
            }).ToList<object>();

            dgv_Dichvu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Dichvu.Columns[0].HeaderText = "Mã Dịch Vụ";
            dgv_Dichvu.Columns[1].HeaderText = "Tên Dịch Vụ";
            dgv_Dichvu.Columns[2].HeaderText = "Ngày Đăng Ký";
            dgv_Dichvu.Columns[3].HeaderText = "Mã Khách Hàng";
            dgv_Dichvu.Columns[4].HeaderText = "Tên Khách Hàng";
        }

        private void btn_dichvu_Click(object sender, EventArgs e)
        {
            string maDV = dgv_Dichvu.CurrentRow.Cells[0].Value.ToString();
            string maKH = dgv_Dichvu.CurrentRow.Cells[3].Value.ToString();
            try
            {
                new QLDichVuKH().HuyDichVu(maDV, maKH);
                MessageBox.Show("Hủy Dịch Vụ Thành Công.", "Response Successful !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DichVu_Load(sender, e);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Response Fail !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            DangKyDichVu f = new DangKyDichVu();
            f.f = this;
            f.ShowDialog();
        }
    }
}

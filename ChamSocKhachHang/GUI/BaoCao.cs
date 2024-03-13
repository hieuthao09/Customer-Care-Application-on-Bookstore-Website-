using ChamSocKhachHang.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamSocKhachHang.gui
{
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        private void btn_baocao_Click(object sender, EventArgs e)
        {
            if(cbb_baocao.SelectedIndex == 0)
            {
                if (rdTot.Checked)
                    dgv_Baocao.DataSource = new QLDanhGiaBLL().getDanhGiaTot();
                else
                    dgv_Baocao.DataSource = new QLDanhGiaBLL().getDanhGiaKhongTot();

                dgv_Baocao.Columns[0].HeaderText = "Số Sao Đánh Giá";
                dgv_Baocao.Columns[1].HeaderText = "Nội Dung Đánh Giá";
                dgv_Baocao.Columns[2].HeaderText = "Mã Đánh Giá";
                dgv_Baocao.Columns[3].HeaderText = "Mã Sách Được Đánh Giá";
            }
            else//thoi gian phan hoi
            {
                string t = cbb_thang.SelectedItem != null ? cbb_thang.SelectedItem.ToString() : null;
                dgv_Baocao.DataSource = new QLDanhGiaBLL().getThoiGianPhanHoi(t);

                dgv_Baocao.Columns[0].HeaderText = "Số Sao Đánh Giá";
                dgv_Baocao.Columns[1].HeaderText = "Nội Dung Đánh Giá";
                dgv_Baocao.Columns[2].HeaderText = "Mã Đánh Giá";
                dgv_Baocao.Columns[3].HeaderText = "Thời gian được phản hồi (ngày)";
            }
            
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            cbb_baocao.SelectedIndex = 0;
            cbb_thang.Visible = false;
            rdTot.Checked = true;
        }

        private void cbb_baocao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_baocao.SelectedIndex == 0)
            {
                cbb_thang.Visible = false;
                rdKhongTot.Visible = true;
                rdTot.Visible = true;
                label1.Visible = false;
            }
            else//thoi gian phan hoi
            {
                cbb_thang.Visible = true;
                label1.Visible = true;
                rdKhongTot.Visible = false;
                rdTot.Visible = false;
            }
        }
    }
}

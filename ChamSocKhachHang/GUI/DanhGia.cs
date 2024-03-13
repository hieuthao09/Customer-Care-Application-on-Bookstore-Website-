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
    public partial class DanhGia : Form
    {
        public DanhGia()
        {
            InitializeComponent();
        }



        private void btn_traloi_Click(object sender, EventArgs e)
        {
            string maDG = dgv_DanhGia.CurrentRow.Cells[0].Value.ToString();
            TraLoi_DanhGia tl_dg = new TraLoi_DanhGia();
            tl_dg.maDG = maDG;
            tl_dg.fparent = this;
            tl_dg.ShowDialog();

        }

        public void DanhGia_Load(object sender, EventArgs e)
        {
            cbb_traloi.SelectedIndex = 1;

            QLDanhGiaBLL qldg = new QLDanhGiaBLL();
            List<object> data = qldg.getDataDanhGiaChuaTraLoi().Select(t => new
            {
                t.danhGias.MaDanhGia,
                t.ngayPhanHoi,
                t.khachHang.MaKH,
                t.danhGias.Noidung,
                t.maSach
            }).ToList<object>();
            dgv_DanhGia.DataSource = data;
            dgv_DanhGia.Columns[0].HeaderText = "Mã Đánh Giá";
            dgv_DanhGia.Columns[1].HeaderText = "Ngày Phản Hồi";
            dgv_DanhGia.Columns[2].HeaderText = "Mã Khách Hàng";
            dgv_DanhGia.Columns[3].HeaderText = "Nội Dung Phản Hồi";
            dgv_DanhGia.Columns[4].HeaderText = "Mã Sách";
            dgv_DanhGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        private void cbb_traloi_SelectedValueChanged(object sender, EventArgs e)
        {
            QLDanhGiaBLL qldg = new QLDanhGiaBLL();
            if(cbb_traloi.SelectedIndex == 1)//DG chua tra loi
            {
                btn_traloi.Enabled = true;
                btn_capnhat.Enabled = false;
                btn_xoabinhluan.Enabled = true;
                List<QLDanhGiaBLL> temp = qldg.getDataDanhGiaChuaTraLoi();
                if (temp.Count > 0)
                {
                    List<object> data =temp.Select(t => new
                    {
                        t.danhGias.MaDanhGia,
                        t.ngayPhanHoi,
                        t.khachHang.MaKH,
                        t.danhGias.Noidung,
                        t.maSach
                    }).ToList<object>();
                    dgv_DanhGia.DataSource = data;
                    dgv_DanhGia.Columns[0].HeaderText = "Mã Đánh Giá";
                    dgv_DanhGia.Columns[1].HeaderText = "Ngày Phản Hồi";
                    dgv_DanhGia.Columns[2].HeaderText = "Mã Khách Hàng";
                    dgv_DanhGia.Columns[3].HeaderText = "Nội Dung Phản Hồi";
                    dgv_DanhGia.Columns[4].HeaderText = "Mã Sách";
                    dgv_DanhGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    dgv_DanhGia.DataSource = null;
                    dgv_DanhGia.Rows.Clear();
                }

            }
            else
            {
                List<QLDanhGiaBLL> temp = qldg.getDataDanhGiaDaTraLoi();
                if(temp.Count > 0)
                {
                    btn_traloi.Enabled = false;
                    btn_capnhat.Enabled = true;
                    btn_xoabinhluan.Enabled = false;
                    List<object> data = temp.Select(t => new
                    {
                        t.danhGias.MaDanhGia,
                        t.ngayPhanHoi,
                        t.khachHang.MaKH,
                        t.danhGias.Noidung,
                        t.maSach
                    }).ToList<object>();
                    dgv_DanhGia.DataSource = data;
                    dgv_DanhGia.Columns[0].HeaderText = "Mã Đánh Giá";
                    dgv_DanhGia.Columns[1].HeaderText = "Ngày Phản Hồi";
                    dgv_DanhGia.Columns[2].HeaderText = "Mã Khách Hàng";
                    dgv_DanhGia.Columns[3].HeaderText = "Nội Dung Phản Hồi";
                    dgv_DanhGia.Columns[4].HeaderText = "Mã Sách";
                    dgv_DanhGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    dgv_DanhGia.DataSource = null;
                    dgv_DanhGia.Rows.Clear();
                }
            }  
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            string maDG = dgv_DanhGia.CurrentRow.Cells[0].Value.ToString();

            TraLoi_DanhGia tl_dg = new TraLoi_DanhGia();
            var obj = new DanhGiaBLL().getTraLoi_DanhGia(maDG);

            var elemObj = obj.GetType().GetProperties();
            tl_dg.traloi = elemObj.First(o => o.Name == "NoiDung").GetValue(obj).ToString();
            tl_dg.ngayTL = elemObj.First(o => o.Name == "NgayTraLoi").GetValue(obj).ToString();
            tl_dg.maDG = maDG;
            tl_dg.fparent = this;
            tl_dg.ShowDialog();
        }

        private void btn_xoabinhluan_Click(object sender, EventArgs e)
        {
            string maDG = dgv_DanhGia.CurrentRow.Cells[0].Value.ToString();

            try
            {
                new DanhGiaBLL().deleteDanhGia(maDG);
                MessageBox.Show("Xóa bình luận thành công !", "Delete Successful",MessageBoxButtons.OK, MessageBoxIcon.Information);
                DanhGia_Load(sender, e);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Delete Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

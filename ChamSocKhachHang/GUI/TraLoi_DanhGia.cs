using ChamSocKhachHang.BLL;
using ChamSocKhachHang.DAL;
using Neo4j.Driver;
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
    public partial class TraLoi_DanhGia : Form
    {
        public string traloi = null;
        public string ngayTL = null;
        public string maDG = null;
        public bool flag = false;

        public DanhGia fparent = null;

        public TraLoi_DanhGia()
        {
            InitializeComponent();
        }

        private void TraLoi_DanhGia_Load(object sender, EventArgs e)
        {

            if(traloi == null || traloi.Length == 0)// danh gia chua dc tra loi
            {
                flag = false;
            }
            else // dg đã tra loi
            {
                flag = true;
                txt_noidung.Text = traloi;
                if (ngayTL != null && ngayTL.Length > 0)
                {
                    lb_NgayTraLoi.Text = "Ngày trả lời: " + ngayTL;
                }
                else
                {
                    lb_NgayTraLoi.Visible = false;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string maNV = Login.nv.MaNV;
            string date = DateTime.Now.ToString("yyyy-MM-ddThh:mm:ss");

            if (!flag)
            {
                try
                {
                    new DanhGiaBLL().TraLoiDanhGia(maNV, maDG, txt_noidung.Text, date);
                    MessageBox.Show("Trả Lời Khách Hàng Thành Công.", "Response Successful !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fparent.DanhGia_Load(sender, e);
                    this.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Response Fail !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    new DanhGiaBLL().CapNhatTraLoiDanhGia(maNV, maDG, txt_noidung.Text, date);
                    MessageBox.Show("Cập nhật phản hồi đánh giá khách hàng thành công.", "Response Successful !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fparent.DanhGia_Load(sender, e);
                    this.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Response Fail !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}

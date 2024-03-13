using ChamSocKhachHang.BLL;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace ChamSocKhachHang.gui
{
    public partial class TraCuu : Form
    {
        public TraCuu()
        {
            InitializeComponent();
        }

        private void btn_tracuu_Click(object sender, EventArgs e)
        {
            dg_KH.DataSource = dg_Sach.DataSource = dg_DG.DataSource = null;
            dg_DG.Rows.Clear();
            dg_KH.Rows.Clear();
            dg_Sach.Rows.Clear();

            string str = txt_tracuu.Text;

            List<object> lo = new KhachHangBLL().traCuuThongTinKhachHang(str);
           
            KhachHangBLL kh = lo.Select(t => t.GetType().GetProperties().First(o => o.Name == "KH").GetValue(t).As<KhachHangBLL>()).ToList().FirstOrDefault();
            if(kh!= null)
            {
                dg_KH.Rows.Add(new string[] { "Mã KH", kh.MaKH });
                dg_KH.Rows.Add(new string[] { "Tên KH", kh.TenKH });
                dg_KH.Rows.Add(new string[] { "SDT", kh.SDT });
                dg_KH.Rows.Add(new string[] { "Email", kh.Email });
            }

            List<object> t1 = lo.Select(t => t.GetType().GetProperties().First(o => o.Name == "DG").GetValue(t).As<DanhGiaBLL>()).Select(t => t.Noidung).GroupBy(t => t).Select(t => t.Key.ToString()).ToList<object>();

            dg_Sach.DataSource = lo.Select(t => t.GetType().GetProperties().First(o => o.Name == "S").GetValue(t).As<SachBLL>()).Select(t=> t.TenSach).GroupBy(t => t).Select(t=>new {TenSach = t.Key,SL = t.Count() }).ToList<object>();

            List<object> d1 = lo.Select(t => t.GetType().GetProperties().First(o => o.Name == "ngayPH").GetValue(t).As<DateTime>()).ToList().Select(t => t).GroupBy(t => t).Select(t => t.Key.ToString()).ToList<object>();

            if(t1.Count > 0)
            {
                for (int i = 0; i < t1.Count; i++)
                {
                    string dg = t1[i].ToString();
                    string date = d1[i].ToString();
                    dg_DG.Rows.Add(new string[] { dg, date });
                }
            }

            if (dg_Sach.Rows != null && dg_Sach.Rows.Count > 0)
            {
                dg_Sach.Columns[0].HeaderText = "Tên Sách";
                dg_Sach.Columns[1].HeaderText = "SL Mua";
            }

        }

        private void TraCuu_Load(object sender, EventArgs e)
        {
            dg_DG.Columns.Clear();
            dg_KH.Columns.Clear();
            dg_DG.Columns.Add("", "Nội dung PH");
            dg_DG.Columns.Add("", "Ngày PH");
            dg_KH.Columns.Add("", "Field");
            dg_KH.Columns.Add("", "Value");
        }
    }
}

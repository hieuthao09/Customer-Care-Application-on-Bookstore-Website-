using ChamSocKhachHang.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChamSocKhachHang.gui
{
    public partial class Sach : Form
    {
        public Sach()
        {
            InitializeComponent();
        }

        private void loadChart(List<object> lo) {
            chart.Series.Clear();
            chart.ChartAreas[0].AxisY.Title = "Số Lượng Mua";
            chart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            chart.ChartAreas[0].AxisY.LineDashStyle = ChartDashStyle.Dash;
            chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            for (int i = 0; i < lo.Count; i++)
            {
                var elemObj = lo[i].GetType().GetProperties();
                string name = elemObj.First(o => o.Name == "maSach").GetValue(lo[i]).ToString();
                int val = int.Parse(elemObj.First(o => o.Name == "soLuongSach").GetValue(lo[i]).ToString());
                //Console.WriteLine("{0}-{1}", name, val);
                Series series = chart.Series.Add(name);
                series.Points.AddXY(i + 1, val);
                //series.Points.Add(val);
            }
        }

        private void loadChart_TL(List<object> lo)
        {
            chart.Series.Clear();
            chart.ChartAreas[0].AxisY.Title = "Số Lượng Mua";
            chart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            chart.ChartAreas[0].AxisY.LineDashStyle = ChartDashStyle.Dash;
            chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            for (int i = 0; i < lo.Count; i++)
            {
                var elemObj = lo[i].GetType().GetProperties();
                string name = elemObj.First(o => o.Name == "tenTL").GetValue(lo[i]).ToString();
                int val = int.Parse(elemObj.First(o => o.Name == "soluongTL").GetValue(lo[i]).ToString());
                //Console.WriteLine("{0}-{1}", name, val);
                Series series = chart.Series.Add(name);
                series.Points.AddXY(i + 1, val);
                //series.Points.Add(val);
            }
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            List<object> lo = null;
            if (rd_SachNhieu.Checked)
            {
                if (chkTheLoai.Checked)
                {
                    lo = new SachBLL().listTheLoaiDuocMuaNhieu(cbb_nam.SelectedItem.ToString(), "5");
                    loadChart_TL(lo);
                }
                else
                {
                    lo = new SachBLL().listSachDuocMuaNhieu(cbb_nam.SelectedItem.ToString(), "10");
                    loadChart(lo);
                }
                
            }
            else
            {
                if (chkTheLoai.Checked)
                {
                    lo = new SachBLL().listTheLoaiDuocMuaIt(cbb_nam.SelectedItem.ToString(), "5");
                    loadChart_TL(lo);
                }
                else
                {
                    lo = new SachBLL().listSachDuocMuaIt(cbb_nam.SelectedItem.ToString(), "10");
                    loadChart(lo);
                }  
            }
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 5; i++)
            {
                cbb_nam.Items.Add(DateTime.Now.Year - i);
            }

            cbb_nam.SelectedIndex = 0;

            List<object> lo = new SachBLL().listSachDuocMuaNhieu("2023","10");
            loadChart(lo);
        }
    }
}

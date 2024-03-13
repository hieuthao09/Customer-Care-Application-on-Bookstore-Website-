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
using LibCustomWinform;

namespace ChamSocKhachHang.gui
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private Color col = Color.FromArgb(255, 195, 3);

        private void resetButton()
        {
            btn_baocao.BackColor = Color.White;
            btn_DanhGia.BackColor = Color.White;
            btn_Dichvu.BackColor = Color.White;
            btn_KhachHang.BackColor = Color.White;
            btn_sach.BackColor = Color.White;
            btn_tracuu.BackColor = Color.White;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lbl_username.Text = Login.nv.TenDangNhap;
            lbl_hoten.Text = Login.nv.HoTen;
            lbl_title.Text = "WELCOME TO DASHBOARD";

            timer1.Start();//clock
        }

        Form f;
        private void btn_DanhGia_Click(object sender, EventArgs e)
        {
            resetButton();
            btn_DanhGia.BackColor = col;
            f = new DanhGia();
            LibDashboard.loadFormInsidePanel(pnl_main, f);
            lbl_title.Text = f.Text;
        }       

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            resetButton();
            btn_KhachHang.BackColor = col;
            f = new KhachHang();
            LibDashboard.loadFormInsidePanel(pnl_main, f);
            lbl_title.Text = f.Text;

        }

        private void btn_sach_Click(object sender, EventArgs e)
        {
            resetButton();
            btn_sach.BackColor = col;
            f = new Sach();
            LibDashboard.loadFormInsidePanel(pnl_main, f);
            lbl_title.Text = f.Text;

        }

        private void btn_baocao_Click(object sender, EventArgs e)
        {
            resetButton();
            btn_baocao.BackColor = col;
            f = new BaoCao();
            LibDashboard.loadFormInsidePanel(pnl_main, f);
            lbl_title.Text = f.Text;

        }

        private void btn_tracuu_Click(object sender, EventArgs e)
        {
            resetButton();
            btn_tracuu.BackColor = col;
            f = new TraCuu();
            LibDashboard.loadFormInsidePanel(pnl_main, f);
            lbl_title.Text = f.Text;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_thoigian.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            Program.lg.Show();
        }

        private void btn_Dichvu_Click(object sender, EventArgs e)
        {
            resetButton();
            btn_Dichvu.BackColor = col;
            f = new DichVu();
            LibDashboard.loadFormInsidePanel(pnl_main, f);
            lbl_title.Text = f.Text;
        }

        private void pnl_logout_Click(object sender, EventArgs e)
        {
            Login.nv = null;
            this.Close();
        }
    }
}

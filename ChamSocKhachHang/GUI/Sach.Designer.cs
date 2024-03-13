namespace ChamSocKhachHang.gui
{
    partial class Sach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbb_nam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkTheLoai = new System.Windows.Forms.CheckBox();
            this.rd_SachIt = new System.Windows.Forms.RadioButton();
            this.rd_SachNhieu = new System.Windows.Forms.RadioButton();
            this.pnl_iconxoa = new System.Windows.Forms.Panel();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 531);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chart);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1260, 457);
            this.panel4.TabIndex = 1;
            // 
            // chart
            // 
            chartArea1.BorderColor = System.Drawing.Color.DarkGray;
            chartArea1.Name = "ChartArea";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series1.ChartArea = "ChartArea";
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series1.Legend = "Legend1";
            series1.Name = "AmountSach";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(1260, 457);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1260, 74);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::ChamSocKhachHang.Properties.Resources.Screenshot_2023_10_07_214330;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 79);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cbb_nam);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.chkTheLoai);
            this.panel3.Controls.Add(this.rd_SachIt);
            this.panel3.Controls.Add(this.rd_SachNhieu);
            this.panel3.Controls.Add(this.pnl_iconxoa);
            this.panel3.Controls.Add(this.btn_ThongKe);
            this.panel3.Location = new System.Drawing.Point(332, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(925, 69);
            this.panel3.TabIndex = 1;
            // 
            // cbb_nam
            // 
            this.cbb_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_nam.FormattingEnabled = true;
            this.cbb_nam.Location = new System.Drawing.Point(419, 21);
            this.cbb_nam.Name = "cbb_nam";
            this.cbb_nam.Size = new System.Drawing.Size(91, 28);
            this.cbb_nam.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Năm:";
            // 
            // chkTheLoai
            // 
            this.chkTheLoai.AutoSize = true;
            this.chkTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTheLoai.Location = new System.Drawing.Point(560, 21);
            this.chkTheLoai.Name = "chkTheLoai";
            this.chkTheLoai.Size = new System.Drawing.Size(111, 29);
            this.chkTheLoai.TabIndex = 6;
            this.chkTheLoai.Text = "Thể Loại";
            this.chkTheLoai.UseVisualStyleBackColor = true;
            // 
            // rd_SachIt
            // 
            this.rd_SachIt.AutoSize = true;
            this.rd_SachIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_SachIt.Location = new System.Drawing.Point(194, 21);
            this.rd_SachIt.Name = "rd_SachIt";
            this.rd_SachIt.Size = new System.Drawing.Size(125, 26);
            this.rd_SachIt.TabIndex = 5;
            this.rd_SachIt.Text = "Sách mua ít";
            this.rd_SachIt.UseVisualStyleBackColor = true;
            // 
            // rd_SachNhieu
            // 
            this.rd_SachNhieu.AutoSize = true;
            this.rd_SachNhieu.Checked = true;
            this.rd_SachNhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_SachNhieu.Location = new System.Drawing.Point(15, 21);
            this.rd_SachNhieu.Name = "rd_SachNhieu";
            this.rd_SachNhieu.Size = new System.Drawing.Size(160, 26);
            this.rd_SachNhieu.TabIndex = 4;
            this.rd_SachNhieu.TabStop = true;
            this.rd_SachNhieu.Text = "Sách mua nhiều";
            this.rd_SachNhieu.UseVisualStyleBackColor = true;
            // 
            // pnl_iconxoa
            // 
            this.pnl_iconxoa.BackgroundImage = global::ChamSocKhachHang.Properties.Resources.Screenshot_2023_10_07_214330;
            this.pnl_iconxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_iconxoa.Location = new System.Drawing.Point(688, 9);
            this.pnl_iconxoa.Name = "pnl_iconxoa";
            this.pnl_iconxoa.Size = new System.Drawing.Size(80, 52);
            this.pnl_iconxoa.TabIndex = 1;
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.Location = new System.Drawing.Point(774, 9);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(142, 52);
            this.btn_ThongKe.TabIndex = 0;
            this.btn_ThongKe.Text = "Thống Kê";
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 531);
            this.Controls.Add(this.panel1);
            this.Name = "Sach";
            this.Text = "Quản Lý Sách";
            this.Load += new System.EventHandler(this.Sach_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.Panel pnl_iconxoa;
        private System.Windows.Forms.RadioButton rd_SachIt;
        private System.Windows.Forms.RadioButton rd_SachNhieu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.CheckBox chkTheLoai;
        private System.Windows.Forms.ComboBox cbb_nam;
        private System.Windows.Forms.Label label1;
    }
}
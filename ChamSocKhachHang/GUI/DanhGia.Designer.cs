namespace ChamSocKhachHang.gui
{
    partial class DanhGia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_DanhGia = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_traloi = new System.Windows.Forms.ComboBox();
            this.pnl_iconsua = new System.Windows.Forms.Panel();
            this.pnl_iconxoa = new System.Windows.Forms.Panel();
            this.pnl_iconthem = new System.Windows.Forms.Panel();
            this.btn_traloi = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_xoabinhluan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhGia)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panel4.Controls.Add(this.dgv_DanhGia);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1260, 458);
            this.panel4.TabIndex = 1;
            // 
            // dgv_DanhGia
            // 
            this.dgv_DanhGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dgv_DanhGia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_DanhGia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_DanhGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhGia.Location = new System.Drawing.Point(0, 0);
            this.dgv_DanhGia.Name = "dgv_DanhGia";
            this.dgv_DanhGia.RowHeadersWidth = 51;
            this.dgv_DanhGia.RowTemplate.Height = 24;
            this.dgv_DanhGia.Size = new System.Drawing.Size(1260, 458);
            this.dgv_DanhGia.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1260, 73);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::ChamSocKhachHang.Properties.Resources.Screenshot_2023_10_07_214330;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 70);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.pnl_iconsua);
            this.panel3.Controls.Add(this.pnl_iconxoa);
            this.panel3.Controls.Add(this.pnl_iconthem);
            this.panel3.Controls.Add(this.btn_traloi);
            this.panel3.Controls.Add(this.btn_capnhat);
            this.panel3.Controls.Add(this.btn_xoabinhluan);
            this.panel3.Location = new System.Drawing.Point(332, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(925, 76);
            this.panel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_traloi);
            this.groupBox1.Location = new System.Drawing.Point(22, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 60);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc dữ liệu theo";
            // 
            // cbb_traloi
            // 
            this.cbb_traloi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_traloi.FormattingEnabled = true;
            this.cbb_traloi.Items.AddRange(new object[] {
            "Đã trả lời",
            "Chưa trả lời"});
            this.cbb_traloi.Location = new System.Drawing.Point(17, 19);
            this.cbb_traloi.Name = "cbb_traloi";
            this.cbb_traloi.Size = new System.Drawing.Size(238, 26);
            this.cbb_traloi.TabIndex = 2;
            this.cbb_traloi.SelectedValueChanged += new System.EventHandler(this.cbb_traloi_SelectedValueChanged);
            // 
            // pnl_iconsua
            // 
            this.pnl_iconsua.BackgroundImage = global::ChamSocKhachHang.Properties.Resources.changes;
            this.pnl_iconsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_iconsua.Location = new System.Drawing.Point(501, 9);
            this.pnl_iconsua.Name = "pnl_iconsua";
            this.pnl_iconsua.Size = new System.Drawing.Size(60, 52);
            this.pnl_iconsua.TabIndex = 1;
            // 
            // pnl_iconxoa
            // 
            this.pnl_iconxoa.BackgroundImage = global::ChamSocKhachHang.Properties.Resources.delete;
            this.pnl_iconxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_iconxoa.Location = new System.Drawing.Point(715, 9);
            this.pnl_iconxoa.Name = "pnl_iconxoa";
            this.pnl_iconxoa.Size = new System.Drawing.Size(53, 52);
            this.pnl_iconxoa.TabIndex = 1;
            // 
            // pnl_iconthem
            // 
            this.pnl_iconthem.BackgroundImage = global::ChamSocKhachHang.Properties.Resources.plus;
            this.pnl_iconthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_iconthem.Location = new System.Drawing.Point(289, 9);
            this.pnl_iconthem.Name = "pnl_iconthem";
            this.pnl_iconthem.Size = new System.Drawing.Size(59, 52);
            this.pnl_iconthem.TabIndex = 1;
            // 
            // btn_traloi
            // 
            this.btn_traloi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_traloi.Location = new System.Drawing.Point(354, 9);
            this.btn_traloi.Name = "btn_traloi";
            this.btn_traloi.Size = new System.Drawing.Size(141, 52);
            this.btn_traloi.TabIndex = 0;
            this.btn_traloi.Text = "Trả lời bình luận";
            this.btn_traloi.UseVisualStyleBackColor = true;
            this.btn_traloi.Click += new System.EventHandler(this.btn_traloi_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Location = new System.Drawing.Point(567, 9);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(142, 52);
            this.btn_capnhat.TabIndex = 0;
            this.btn_capnhat.Text = "Cập nhật bình luận";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_xoabinhluan
            // 
            this.btn_xoabinhluan.Location = new System.Drawing.Point(774, 9);
            this.btn_xoabinhluan.Name = "btn_xoabinhluan";
            this.btn_xoabinhluan.Size = new System.Drawing.Size(142, 52);
            this.btn_xoabinhluan.TabIndex = 0;
            this.btn_xoabinhluan.Text = "Xóa bình luận";
            this.btn_xoabinhluan.UseVisualStyleBackColor = true;
            this.btn_xoabinhluan.Click += new System.EventHandler(this.btn_xoabinhluan_Click);
            // 
            // DanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 531);
            this.Controls.Add(this.panel1);
            this.Name = "DanhGia";
            this.Text = "Quản Lý Đánh Giá";
            this.Load += new System.EventHandler(this.DanhGia_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhGia)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_DanhGia;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl_iconsua;
        private System.Windows.Forms.Panel pnl_iconxoa;
        private System.Windows.Forms.Panel pnl_iconthem;
        private System.Windows.Forms.Button btn_traloi;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_xoabinhluan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_traloi;
    }
}
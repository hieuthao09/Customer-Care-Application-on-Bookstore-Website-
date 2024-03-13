namespace ChamSocKhachHang.gui
{
    partial class KhachHang
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
            this.dgv_khachhang = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_iconsua = new System.Windows.Forms.Panel();
            this.pnl_iconxoa = new System.Windows.Forms.Panel();
            this.pnl_iconthem = new System.Windows.Forms.Panel();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).BeginInit();
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
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_khachhang);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1260, 458);
            this.panel4.TabIndex = 1;
            // 
            // dgv_khachhang
            // 
            this.dgv_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_khachhang.Location = new System.Drawing.Point(0, 0);
            this.dgv_khachhang.Name = "dgv_khachhang";
            this.dgv_khachhang.RowHeadersWidth = 51;
            this.dgv_khachhang.RowTemplate.Height = 24;
            this.dgv_khachhang.Size = new System.Drawing.Size(1260, 458);
            this.dgv_khachhang.TabIndex = 0;
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
            this.panel2.Size = new System.Drawing.Size(323, 71);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pnl_iconsua);
            this.panel3.Controls.Add(this.pnl_iconxoa);
            this.panel3.Controls.Add(this.pnl_iconthem);
            this.panel3.Controls.Add(this.btn_them);
            this.panel3.Controls.Add(this.btn_sua);
            this.panel3.Controls.Add(this.btn_xoa);
            this.panel3.Location = new System.Drawing.Point(332, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(925, 71);
            this.panel3.TabIndex = 1;
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
            // btn_them
            // 
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_them.Location = new System.Drawing.Point(354, 9);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(141, 52);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm dữ liệu";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(567, 9);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(142, 52);
            this.btn_sua.TabIndex = 0;
            this.btn_sua.Text = "Sửa dữ liệu";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(774, 9);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(142, 52);
            this.btn_xoa.TabIndex = 0;
            this.btn_xoa.Text = "Xóa dữ liệu";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 531);
            this.Controls.Add(this.panel1);
            this.Name = "KhachHang";
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Panel pnl_iconxoa;
        private System.Windows.Forms.Panel pnl_iconthem;
        private System.Windows.Forms.Panel pnl_iconsua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_khachhang;
    }
}
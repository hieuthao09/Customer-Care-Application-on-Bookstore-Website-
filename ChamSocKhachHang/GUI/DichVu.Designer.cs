namespace ChamSocKhachHang.gui
{
    partial class DichVu
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
            this.dgv_Dichvu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_iconxoa = new System.Windows.Forms.Panel();
            this.btn_dichvu = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dichvu)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Dichvu
            // 
            this.dgv_Dichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Dichvu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Dichvu.Location = new System.Drawing.Point(0, 0);
            this.dgv_Dichvu.Name = "dgv_Dichvu";
            this.dgv_Dichvu.RowHeadersWidth = 51;
            this.dgv_Dichvu.RowTemplate.Height = 24;
            this.dgv_Dichvu.Size = new System.Drawing.Size(1260, 452);
            this.dgv_Dichvu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 531);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_Dichvu);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1260, 452);
            this.panel4.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1260, 79);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::ChamSocKhachHang.Properties.Resources.Screenshot_2023_10_07_214330;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 82);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.btnDK);
            this.panel3.Controls.Add(this.pnl_iconxoa);
            this.panel3.Controls.Add(this.btn_dichvu);
            this.panel3.Location = new System.Drawing.Point(332, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(925, 76);
            this.panel3.TabIndex = 1;
            // 
            // pnl_iconxoa
            // 
            this.pnl_iconxoa.BackgroundImage = global::ChamSocKhachHang.Properties.Resources.delete;
            this.pnl_iconxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_iconxoa.Location = new System.Drawing.Point(715, 10);
            this.pnl_iconxoa.Name = "pnl_iconxoa";
            this.pnl_iconxoa.Size = new System.Drawing.Size(53, 51);
            this.pnl_iconxoa.TabIndex = 1;
            // 
            // btn_dichvu
            // 
            this.btn_dichvu.Location = new System.Drawing.Point(774, 9);
            this.btn_dichvu.Name = "btn_dichvu";
            this.btn_dichvu.Size = new System.Drawing.Size(142, 52);
            this.btn_dichvu.TabIndex = 0;
            this.btn_dichvu.Text = "Hủy dịch vụ";
            this.btn_dichvu.UseVisualStyleBackColor = true;
            this.btn_dichvu.Click += new System.EventHandler(this.btn_dichvu_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::ChamSocKhachHang.Properties.Resources.plus;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(489, 11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(53, 51);
            this.panel5.TabIndex = 3;
            // 
            // btnDK
            // 
            this.btnDK.Location = new System.Drawing.Point(548, 10);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(142, 52);
            this.btnDK.TabIndex = 2;
            this.btnDK.Text = "Đăng ký";
            this.btnDK.UseVisualStyleBackColor = true;
            this.btnDK.Click += new System.EventHandler(this.btnDK_Click);
            // 
            // DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 531);
            this.Controls.Add(this.panel1);
            this.Name = "DichVu";
            this.Text = "Quản Lý Dịch Vụ";
            this.Load += new System.EventHandler(this.DichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dichvu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Dichvu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl_iconxoa;
        private System.Windows.Forms.Button btn_dichvu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDK;
    }
}
namespace ChamSocKhachHang.gui
{
    partial class BaoCao
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
            this.dgv_Baocao = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdKhongTot = new System.Windows.Forms.RadioButton();
            this.rdTot = new System.Windows.Forms.RadioButton();
            this.cbb_thang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_baocao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_baocao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Baocao)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Baocao
            // 
            this.dgv_Baocao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Baocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Baocao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Baocao.Location = new System.Drawing.Point(0, 0);
            this.dgv_Baocao.Name = "dgv_Baocao";
            this.dgv_Baocao.RowHeadersWidth = 51;
            this.dgv_Baocao.RowTemplate.Height = 24;
            this.dgv_Baocao.Size = new System.Drawing.Size(1260, 418);
            this.dgv_Baocao.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 531);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_Baocao);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 113);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1260, 418);
            this.panel4.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1260, 113);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.rdKhongTot);
            this.panel3.Controls.Add(this.rdTot);
            this.panel3.Controls.Add(this.cbb_thang);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btn_baocao);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1254, 110);
            this.panel3.TabIndex = 1;
            // 
            // rdKhongTot
            // 
            this.rdKhongTot.AutoSize = true;
            this.rdKhongTot.Location = new System.Drawing.Point(671, 60);
            this.rdKhongTot.Name = "rdKhongTot";
            this.rdKhongTot.Size = new System.Drawing.Size(83, 20);
            this.rdKhongTot.TabIndex = 8;
            this.rdKhongTot.TabStop = true;
            this.rdKhongTot.Text = "Không tốt";
            this.rdKhongTot.UseVisualStyleBackColor = true;
            // 
            // rdTot
            // 
            this.rdTot.AutoSize = true;
            this.rdTot.Location = new System.Drawing.Point(671, 31);
            this.rdTot.Name = "rdTot";
            this.rdTot.Size = new System.Drawing.Size(48, 20);
            this.rdTot.TabIndex = 7;
            this.rdTot.TabStop = true;
            this.rdTot.Text = "Tốt";
            this.rdTot.UseVisualStyleBackColor = true;
            // 
            // cbb_thang
            // 
            this.cbb_thang.FormattingEnabled = true;
            this.cbb_thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbb_thang.Location = new System.Drawing.Point(494, 32);
            this.cbb_thang.Name = "cbb_thang";
            this.cbb_thang.Size = new System.Drawing.Size(121, 24);
            this.cbb_thang.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tháng:";
            // 
            // btn_baocao
            // 
            this.btn_baocao.Location = new System.Drawing.Point(1052, 22);
            this.btn_baocao.Name = "btn_baocao";
            this.btn_baocao.Size = new System.Drawing.Size(184, 58);
            this.btn_baocao.TabIndex = 0;
            this.btn_baocao.Text = "Báo cáo";
            this.btn_baocao.UseVisualStyleBackColor = true;
            this.btn_baocao.Click += new System.EventHandler(this.btn_baocao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_baocao);
            this.groupBox1.Location = new System.Drawing.Point(20, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 83);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo";
            // 
            // cbb_baocao
            // 
            this.cbb_baocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_baocao.FormattingEnabled = true;
            this.cbb_baocao.Items.AddRange(new object[] {
            "Đánh giá của khách hàng",
            "Thời phản hồi khách hàng"});
            this.cbb_baocao.Location = new System.Drawing.Point(23, 33);
            this.cbb_baocao.Name = "cbb_baocao";
            this.cbb_baocao.Size = new System.Drawing.Size(356, 26);
            this.cbb_baocao.TabIndex = 2;
            this.cbb_baocao.SelectedIndexChanged += new System.EventHandler(this.cbb_baocao_SelectedIndexChanged);
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 531);
            this.Controls.Add(this.panel1);
            this.Name = "BaoCao";
            this.Text = "Quản Lý Báo Cáo";
            this.Load += new System.EventHandler(this.BaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Baocao)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Baocao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_baocao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_baocao;
        private System.Windows.Forms.ComboBox cbb_thang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdKhongTot;
        private System.Windows.Forms.RadioButton rdTot;
    }
}
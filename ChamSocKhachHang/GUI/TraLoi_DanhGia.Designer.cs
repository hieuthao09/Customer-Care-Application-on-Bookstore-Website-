namespace ChamSocKhachHang.gui
{
    partial class TraLoi_DanhGia
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
            this.gpb_noidung = new System.Windows.Forms.GroupBox();
            this.txt_noidung = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lb_NgayTraLoi = new System.Windows.Forms.StatusBar();
            this.gpb_noidung.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_noidung
            // 
            this.gpb_noidung.Controls.Add(this.txt_noidung);
            this.gpb_noidung.Controls.Add(this.btnSave);
            this.gpb_noidung.Controls.Add(this.lb_NgayTraLoi);
            this.gpb_noidung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb_noidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_noidung.Location = new System.Drawing.Point(0, 0);
            this.gpb_noidung.Name = "gpb_noidung";
            this.gpb_noidung.Size = new System.Drawing.Size(382, 237);
            this.gpb_noidung.TabIndex = 0;
            this.gpb_noidung.TabStop = false;
            this.gpb_noidung.Text = "Nội dung";
            // 
            // txt_noidung
            // 
            this.txt_noidung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_noidung.Location = new System.Drawing.Point(3, 24);
            this.txt_noidung.Multiline = true;
            this.txt_noidung.Name = "txt_noidung";
            this.txt_noidung.Size = new System.Drawing.Size(376, 140);
            this.txt_noidung.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(3, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(376, 48);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lb_NgayTraLoi
            // 
            this.lb_NgayTraLoi.Location = new System.Drawing.Point(3, 212);
            this.lb_NgayTraLoi.Name = "lb_NgayTraLoi";
            this.lb_NgayTraLoi.Size = new System.Drawing.Size(376, 22);
            this.lb_NgayTraLoi.TabIndex = 1;
            this.lb_NgayTraLoi.Text = "statusBar1";
            // 
            // TraLoi_DanhGia
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 237);
            this.Controls.Add(this.gpb_noidung);
            this.Name = "TraLoi_DanhGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TraLoi_DanhGia";
            this.Load += new System.EventHandler(this.TraLoi_DanhGia_Load);
            this.gpb_noidung.ResumeLayout(false);
            this.gpb_noidung.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_noidung;
        private System.Windows.Forms.StatusBar lb_NgayTraLoi;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txt_noidung;
    }
}
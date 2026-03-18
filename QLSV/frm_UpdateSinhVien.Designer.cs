namespace QLSV
{
    partial class frm_UpdateSinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Ten = new System.Windows.Forms.Label();
            this.txt_hoTen = new System.Windows.Forms.TextBox();
            this.txt_NSinh = new System.Windows.Forms.Label();
            this.txt_GioiTInh1 = new System.Windows.Forms.Label();
            this.txt_maLop = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.dtP_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.txt_MSSV = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập nhật / Thêm Sinh Viên";
            // 
            // txt_Ten
            // 
            this.txt_Ten.AutoSize = true;
            this.txt_Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten.Location = new System.Drawing.Point(13, 113);
            this.txt_Ten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(71, 13);
            this.txt_Ten.TabIndex = 1;
            this.txt_Ten.Text = "Họ và Tên:";
            // 
            // txt_hoTen
            // 
            this.txt_hoTen.Location = new System.Drawing.Point(105, 106);
            this.txt_hoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_hoTen.Name = "txt_hoTen";
            this.txt_hoTen.Size = new System.Drawing.Size(298, 20);
            this.txt_hoTen.TabIndex = 2;
            // 
            // txt_NSinh
            // 
            this.txt_NSinh.AutoSize = true;
            this.txt_NSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NSinh.Location = new System.Drawing.Point(17, 150);
            this.txt_NSinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_NSinh.Name = "txt_NSinh";
            this.txt_NSinh.Size = new System.Drawing.Size(67, 13);
            this.txt_NSinh.TabIndex = 1;
            this.txt_NSinh.Text = "Ngày sinh:";
            // 
            // txt_GioiTInh1
            // 
            this.txt_GioiTInh1.AutoSize = true;
            this.txt_GioiTInh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GioiTInh1.Location = new System.Drawing.Point(24, 180);
            this.txt_GioiTInh1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_GioiTInh1.Name = "txt_GioiTInh1";
            this.txt_GioiTInh1.Size = new System.Drawing.Size(60, 13);
            this.txt_GioiTInh1.TabIndex = 1;
            this.txt_GioiTInh1.Text = "Giới tính:";
            // 
            // txt_maLop
            // 
            this.txt_maLop.AutoSize = true;
            this.txt_maLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maLop.Location = new System.Drawing.Point(35, 217);
            this.txt_maLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_maLop.Name = "txt_maLop";
            this.txt_maLop.Size = new System.Drawing.Size(49, 13);
            this.txt_maLop.TabIndex = 1;
            this.txt_maLop.Text = "Mã lớp:";
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Luu.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Luu.Location = new System.Drawing.Point(105, 266);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(100, 33);
            this.btn_Luu.TabIndex = 6;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.Silver;
            this.btn_Huy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Huy.Location = new System.Drawing.Point(239, 266);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(100, 33);
            this.btn_Huy.TabIndex = 7;
            this.btn_Huy.Text = "Hủy bỏ";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtP_NgaySinh
            // 
            this.dtP_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtP_NgaySinh.Location = new System.Drawing.Point(105, 144);
            this.dtP_NgaySinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtP_NgaySinh.Name = "dtP_NgaySinh";
            this.dtP_NgaySinh.Size = new System.Drawing.Size(86, 20);
            this.dtP_NgaySinh.TabIndex = 3;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(105, 177);
            this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(92, 21);
            this.cboGioiTinh.TabIndex = 8;
            // 
            // cboMaLop
            // 
            this.cboMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboMaLop.Location = new System.Drawing.Point(105, 214);
            this.cboMaLop.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(92, 21);
            this.cboMaLop.TabIndex = 8;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(35, 80);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(49, 13);
            this.label.TabIndex = 1;
            this.label.Text = "MSSV: ";
            this.label.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_MSSV
            // 
            this.txt_MSSV.Location = new System.Drawing.Point(105, 77);
            this.txt_MSSV.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MSSV.Name = "txt_MSSV";
            this.txt_MSSV.Size = new System.Drawing.Size(298, 20);
            this.txt_MSSV.TabIndex = 1;
            // 
            // frm_UpdateSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 328);
            this.Controls.Add(this.cboMaLop);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.dtP_NgaySinh);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.txt_hoTen);
            this.Controls.Add(this.txt_MSSV);
            this.Controls.Add(this.txt_maLop);
            this.Controls.Add(this.txt_GioiTInh1);
            this.Controls.Add(this.txt_NSinh);
            this.Controls.Add(this.txt_Ten);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_UpdateSinhVien";
            this.Text = "ThemSinhVien";
            this.Load += new System.EventHandler(this.UpdateSinhVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_Ten;
        private System.Windows.Forms.TextBox txt_hoTen;
        private System.Windows.Forms.Label txt_NSinh;
        private System.Windows.Forms.Label txt_GioiTInh1;
        private System.Windows.Forms.Label txt_maLop;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.DateTimePicker dtP_NgaySinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.ComboBox cboMaLop;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txt_MSSV;
    }
}
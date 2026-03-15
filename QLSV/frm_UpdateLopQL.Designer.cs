namespace QLSV
{
    partial class frm_UpdateLopQL
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
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txt_GV = new System.Windows.Forms.TextBox();
            this.txt_soHS = new System.Windows.Forms.TextBox();
            this.txt_Class = new System.Windows.Forms.TextBox();
            this.txt_IDLopQL = new System.Windows.Forms.TextBox();
            this.txt_maLop = new System.Windows.Forms.Label();
            this.txt_GioiTInh1 = new System.Windows.Forms.Label();
            this.txt_ = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenLop = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 68);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(44, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập nhật / Thêm Lớp QL";
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.Silver;
            this.btn_Huy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Huy.Location = new System.Drawing.Point(437, 312);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(134, 41);
            this.btn_Huy.TabIndex = 7;
            this.btn_Huy.Text = "Hủy bỏ";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Luu.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Luu.Location = new System.Drawing.Point(256, 312);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(134, 41);
            this.btn_Luu.TabIndex = 6;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txt_GV
            // 
            this.txt_GV.Location = new System.Drawing.Point(256, 239);
            this.txt_GV.Name = "txt_GV";
            this.txt_GV.Size = new System.Drawing.Size(396, 22);
            this.txt_GV.TabIndex = 5;
            // 
            // txt_soHS
            // 
            this.txt_soHS.Location = new System.Drawing.Point(256, 202);
            this.txt_soHS.Name = "txt_soHS";
            this.txt_soHS.Size = new System.Drawing.Size(396, 22);
            this.txt_soHS.TabIndex = 4;
            // 
            // txt_Class
            // 
            this.txt_Class.Location = new System.Drawing.Point(256, 127);
            this.txt_Class.Name = "txt_Class";
            this.txt_Class.Size = new System.Drawing.Size(396, 22);
            this.txt_Class.TabIndex = 2;
            // 
            // txt_IDLopQL
            // 
            this.txt_IDLopQL.Location = new System.Drawing.Point(256, 98);
            this.txt_IDLopQL.Name = "txt_IDLopQL";
            this.txt_IDLopQL.Size = new System.Drawing.Size(396, 22);
            this.txt_IDLopQL.TabIndex = 1;
            // 
            // txt_maLop
            // 
            this.txt_maLop.AutoSize = true;
            this.txt_maLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maLop.Location = new System.Drawing.Point(148, 245);
            this.txt_maLop.Name = "txt_maLop";
            this.txt_maLop.Size = new System.Drawing.Size(87, 16);
            this.txt_maLop.TabIndex = 9;
            this.txt_maLop.Text = "Giảng Viên:";
            // 
            // txt_GioiTInh1
            // 
            this.txt_GioiTInh1.AutoSize = true;
            this.txt_GioiTInh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GioiTInh1.Location = new System.Drawing.Point(148, 208);
            this.txt_GioiTInh1.Name = "txt_GioiTInh1";
            this.txt_GioiTInh1.Size = new System.Drawing.Size(55, 16);
            this.txt_GioiTInh1.TabIndex = 10;
            this.txt_GioiTInh1.Text = "Số HS:";
            // 
            // txt_
            // 
            this.txt_.AutoSize = true;
            this.txt_.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_.Location = new System.Drawing.Point(148, 130);
            this.txt_.Name = "txt_";
            this.txt_.Size = new System.Drawing.Size(58, 16);
            this.txt_.TabIndex = 12;
            this.txt_.Text = "Mã lớp:";
            // 
            // txt_id
            // 
            this.txt_id.AutoSize = true;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(148, 101);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(24, 16);
            this.txt_id.TabIndex = 13;
            this.txt_id.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã lớp";
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Location = new System.Drawing.Point(256, 162);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(396, 22);
            this.txt_TenLop.TabIndex = 3;
            // 
            // frm_UpdateLopQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.txt_GV);
            this.Controls.Add(this.txt_soHS);
            this.Controls.Add(this.txt_TenLop);
            this.Controls.Add(this.txt_Class);
            this.Controls.Add(this.txt_IDLopQL);
            this.Controls.Add(this.txt_maLop);
            this.Controls.Add(this.txt_GioiTInh1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.panel1);
            this.Name = "frm_UpdateLopQL";
            this.Text = "frm_UpdateLopQL";
            this.Load += new System.EventHandler(this.frm_UpdateLopQL_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.TextBox txt_GV;
        private System.Windows.Forms.TextBox txt_soHS;
        private System.Windows.Forms.TextBox txt_Class;
        private System.Windows.Forms.TextBox txt_IDLopQL;
        private System.Windows.Forms.Label txt_maLop;
        private System.Windows.Forms.Label txt_GioiTInh1;
        private System.Windows.Forms.Label txt_;
        private System.Windows.Forms.Label txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenLop;
    }
}
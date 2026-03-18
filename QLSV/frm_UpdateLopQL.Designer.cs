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
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.txt_ = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 55);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập nhật / Thêm Lớp QL";
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.Silver;
            this.btn_Huy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Huy.Location = new System.Drawing.Point(319, 187);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(100, 33);
            this.btn_Huy.TabIndex = 7;
            this.btn_Huy.Text = "Hủy bỏ";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Luu.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Luu.Location = new System.Drawing.Point(192, 187);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(100, 33);
            this.btn_Luu.TabIndex = 6;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Location = new System.Drawing.Point(192, 103);
            this.txt_MaLop.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(298, 20);
            this.txt_MaLop.TabIndex = 2;
            // 
            // txt_
            // 
            this.txt_.AutoSize = true;
            this.txt_.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_.Location = new System.Drawing.Point(111, 106);
            this.txt_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_.Name = "txt_";
            this.txt_.Size = new System.Drawing.Size(49, 13);
            this.txt_.TabIndex = 12;
            this.txt_.Text = "Mã lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên lớp:";
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Location = new System.Drawing.Point(192, 132);
            this.txt_TenLop.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(298, 20);
            this.txt_TenLop.TabIndex = 3;
            // 
            // frm_UpdateLopQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.txt_TenLop);
            this.Controls.Add(this.txt_MaLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.Label txt_;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenLop;
    }
}
namespace QLSV
{
    partial class frm_LopQL
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dGV_LopQL = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_tien = new System.Windows.Forms.Button();
            this.btn_lui = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_LopQL)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 450);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dGV_LopQL);
            this.panel2.Controls.Add(this.btn_Refresh);
            this.panel2.Controls.Add(this.btn_Delete);
            this.panel2.Controls.Add(this.btn_tien);
            this.panel2.Controls.Add(this.btn_lui);
            this.panel2.Controls.Add(this.btn_Sua);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.txt_search);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 382);
            this.panel2.TabIndex = 3;
            // 
            // dGV_LopQL
            // 
            this.dGV_LopQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_LopQL.Location = new System.Drawing.Point(19, 55);
            this.dGV_LopQL.Name = "dGV_LopQL";
            this.dGV_LopQL.RowHeadersWidth = 51;
            this.dGV_LopQL.RowTemplate.Height = 24;
            this.dGV_LopQL.Size = new System.Drawing.Size(748, 276);
            this.dGV_LopQL.TabIndex = 4;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Refresh.Location = new System.Drawing.Point(280, 337);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(81, 33);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Làm mới";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.frm_LopQL_Load);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Silver;
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Delete.Location = new System.Drawing.Point(193, 337);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(81, 33);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // btn_tien
            // 
            this.btn_tien.Location = new System.Drawing.Point(608, 342);
            this.btn_tien.Name = "btn_tien";
            this.btn_tien.Size = new System.Drawing.Size(24, 25);
            this.btn_tien.TabIndex = 3;
            this.btn_tien.Text = ">";
            this.btn_tien.UseVisualStyleBackColor = true;
            // 
            // btn_lui
            // 
            this.btn_lui.Location = new System.Drawing.Point(578, 341);
            this.btn_lui.Name = "btn_lui";
            this.btn_lui.Size = new System.Drawing.Size(24, 25);
            this.btn_lui.TabIndex = 3;
            this.btn_lui.Text = "<";
            this.btn_lui.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Silver;
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Sua.Location = new System.Drawing.Point(106, 337);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(81, 33);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Add.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Add.Location = new System.Drawing.Point(19, 337);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(81, 33);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Thêm mới";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_ThemLop_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_search.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_search.Location = new System.Drawing.Point(689, 13);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(78, 33);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(516, 342);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(47, 22);
            this.textBox2.TabIndex = 2;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(410, 18);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(273, 22);
            this.txt_search.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "DANH SÁCH LỚP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(458, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Trang";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(322, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tìm kiếm:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btn_DangXuat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 68);
            this.panel1.TabIndex = 1;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Location = new System.Drawing.Point(659, 12);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(108, 44);
            this.btn_DangXuat.TabIndex = 3;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "LỚP QUẢN LÝ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frm_LopQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Name = "frm_LopQL";
            this.Text = "frm_LopHoc";
            this.Load += new System.EventHandler(this.frm_LopQL_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_LopQL)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dGV_LopQL;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_tien;
        private System.Windows.Forms.Button btn_lui;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_DangXuat;
    }
}
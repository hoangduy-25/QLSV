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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLopQL = new System.Windows.Forms.DataGridView();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLop = new System.Windows.Forms.Button();
            this.btnDSSV = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopQL)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1098, 632);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.dgvLopQL);
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
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1098, 577);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 55);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "LỚP QUẢN LÝ";
            // 
            // dgvLopQL
            // 
            this.dgvLopQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopQL.Location = new System.Drawing.Point(222, 63);
            this.dgvLopQL.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLopQL.Name = "dgvLopQL";
            this.dgvLopQL.RowHeadersWidth = 51;
            this.dgvLopQL.RowTemplate.Height = 24;
            this.dgvLopQL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLopQL.Size = new System.Drawing.Size(793, 439);
            this.dgvLopQL.TabIndex = 17;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Refresh.Location = new System.Drawing.Point(467, 522);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(61, 27);
            this.btn_Refresh.TabIndex = 10;
            this.btn_Refresh.Text = "Làm mới";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.frm_LopQL_Load);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Silver;
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Delete.Location = new System.Drawing.Point(386, 522);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(61, 27);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btn_tien
            // 
            this.btn_tien.Location = new System.Drawing.Point(968, 519);
            this.btn_tien.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tien.Name = "btn_tien";
            this.btn_tien.Size = new System.Drawing.Size(18, 20);
            this.btn_tien.TabIndex = 12;
            this.btn_tien.Text = ">";
            this.btn_tien.UseVisualStyleBackColor = true;
            // 
            // btn_lui
            // 
            this.btn_lui.Location = new System.Drawing.Point(934, 519);
            this.btn_lui.Margin = new System.Windows.Forms.Padding(2);
            this.btn_lui.Name = "btn_lui";
            this.btn_lui.Size = new System.Drawing.Size(18, 20);
            this.btn_lui.TabIndex = 13;
            this.btn_lui.Text = "<";
            this.btn_lui.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Silver;
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Sua.Location = new System.Drawing.Point(302, 522);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(61, 27);
            this.btn_Sua.TabIndex = 14;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Add.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Add.Location = new System.Drawing.Point(222, 522);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(61, 27);
            this.btn_Add.TabIndex = 15;
            this.btn_Add.Text = "Thêm mới";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_ThemLop_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_search.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_search.Location = new System.Drawing.Point(934, 20);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(81, 27);
            this.btn_search.TabIndex = 16;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(894, 519);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(36, 20);
            this.textBox2.TabIndex = 8;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(692, 25);
            this.txt_search.Margin = new System.Windows.Forms.Padding(2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(238, 20);
            this.txt_search.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(218, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "DANH SÁCH LỚP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(830, 522);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Trang";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(620, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tìm kiếm:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnLop);
            this.panel4.Controls.Add(this.btnDSSV);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(177, 577);
            this.panel4.TabIndex = 18;
            // 
            // btnLop
            // 
            this.btnLop.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLop.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLop.Location = new System.Drawing.Point(1, 96);
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(175, 90);
            this.btnLop.TabIndex = 0;
            this.btnLop.Text = "Lớp";
            this.btnLop.UseVisualStyleBackColor = false;
            // 
            // btnDSSV
            // 
            this.btnDSSV.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDSSV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDSSV.Location = new System.Drawing.Point(1, 5);
            this.btnDSSV.Name = "btnDSSV";
            this.btnDSSV.Size = new System.Drawing.Size(175, 90);
            this.btnDSSV.TabIndex = 0;
            this.btnDSSV.Text = "Danh sách sinh viên";
            this.btnDSSV.UseVisualStyleBackColor = false;
            this.btnDSSV.Click += new System.EventHandler(this.frm_DSSV);
            // 
            // frm_LopQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 632);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_LopQL";
            this.Text = "frm_LopHoc";
            this.Load += new System.EventHandler(this.frm_LopQL_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopQL)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvLopQL;
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLop;
        private System.Windows.Forms.Button btnDSSV;
    }
}
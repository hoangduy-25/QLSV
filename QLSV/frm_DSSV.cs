using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frm_DSSV : Form
    {
        public frm_DSSV()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DataBaseDataContext db = new DataBaseDataContext();
            var list = db.tbl_sinhviens.ToList();

            dataGridView1.DataSource = list;
            dataGridView1.Columns["Hoten"].HeaderText ="Họ tên";
            dataGridView1.Columns["gioitinh"].HeaderText = "Giới tính";
            dataGridView1.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dataGridView1.Columns["malop"].HeaderText = "Mã lớp";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frm_UpdateSinhVien suaSinhVien = new frm_UpdateSinhVien();
            suaSinhVien.Show();
        }

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            frm_UpdateSinhVien themSinhVienForm = new frm_UpdateSinhVien();
            themSinhVienForm.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string mssv = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
                DataBaseDataContext db = new DataBaseDataContext();
                var sv = db.tbl_sinhviens.FirstOrDefault(s => s.id == mssv);
                if (sv != null)
                {
                    db.tbl_sinhviens.DeleteOnSubmit(sv);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa sinh viên thành công!");
                    var list = db.tbl_sinhviens.ToList();
                    dataGridView1.DataSource = list;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa.");
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frm_Login loginForm = new frm_Login();
            loginForm.Show();
            this.Close();
        }
        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

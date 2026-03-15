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

        private void frm_SinhVien_Load(object sender, EventArgs e)
        {
            
            LoadSinhVien();
            
        }

        private void LoadSinhVien()
        {
            try
            {
                using(DataBaseDataContext db = new DataBaseDataContext())
                {
                    var ds = db.tbl_sinhviens.OrderBy(sv => sv.id).ToList();
                    dgvSinhVien.DataSource = ds;
                    FormatGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sinh viên: " + ex.Message);
            }
        }

        private void FormatGrid()
        {
            if (dgvSinhVien.Rows.Count > 0)
            {
                dgvSinhVien.Columns["Hoten"].HeaderText = "Họ tên";
                dgvSinhVien.Columns["gioitinh"].HeaderText = "Giới tính";
                dgvSinhVien.Columns["ngaysinh"].HeaderText = "Ngày sinh";
                dgvSinhVien.Columns["malop"].HeaderText = "Mã lớp";
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow != null)
            {
                string id = dgvSinhVien.CurrentRow.Cells["id"].Value.ToString();
                frm_UpdateSinhVien update = new frm_UpdateSinhVien(id);
                update.ShowDialog();
                LoadSinhVien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để sửa.");
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm_UpdateSinhVien add = new frm_UpdateSinhVien();
            add.ShowDialog();
            LoadSinhVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (dgvSinhVien.CurrentRow != null)
            {
                string id = dgvSinhVien.CurrentRow.Cells["id"].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (DataBaseDataContext db = new DataBaseDataContext())
                        {
                            var sv = db.tbl_sinhviens.FirstOrDefault(x => x.id == id);
                            if (sv != null)
                            {
                                db.tbl_sinhviens.DeleteOnSubmit(sv);
                                db.SubmitChanges();
                                LoadSinhVien();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa sinh viên: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một lớp để xóa.");
            }
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Login loginForm = new frm_Login();
            loginForm.ShowDialog();
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

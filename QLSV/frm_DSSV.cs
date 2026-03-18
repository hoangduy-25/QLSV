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
                    var ds = db.tbl_SinhViens.OrderBy(sv => sv.id).ToList();
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
                dgvSinhVien.Columns["MaSV"].HeaderText = "MSSV";
                dgvSinhVien.Columns["HoTen"].HeaderText = "Họ tên";
                dgvSinhVien.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgvSinhVien.Columns["Malop"].HeaderText = "Mã lớp";
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
                int id = Convert.ToInt32(dgvSinhVien.CurrentRow.Cells["id"].Value);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (DataBaseDataContext db = new DataBaseDataContext())
                        {
                            var sv = db.tbl_SinhViens.FirstOrDefault(x => x.id == id);
                            if (sv != null)
                            {
                                db.tbl_SinhViens.DeleteOnSubmit(sv);
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

        private void LoadSinhVienTheoTu(string tuKhoa)
        {
            string tk = tuKhoa.Trim();
            using (DataBaseDataContext db = new DataBaseDataContext())
            {
                var ds = db.tbl_SinhViens
                       .Where(sv =>
                           sv.MaSV.Contains(tk) ||
                           sv.HoTen.Contains(tk) ||
                           sv.MaLop.Contains(tk))
                       .OrderBy(sv => sv.id)
                       .ToList();
                dgvSinhVien.DataSource = ds;
                FormatGrid();
            }
            
        }
        
        private void frm_Lop(object sender, EventArgs e)
        {
            this.Hide();
            frm_LopQL frm = new frm_LopQL();
            frm.ShowDialog();
            this.Close();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(btnSearch.Text))
                LoadSinhVien();
            else
                LoadSinhVienTheoTu(btnSearch.Text);
        }
        
    }
}

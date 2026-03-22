using System;
using System.Collections;
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
    public partial class ucSinhVien : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();
        private int pageSize = 10;    
        private int currentPage = 1;  
        private int totalRecords = 0; 
        private int totalPages = 0;
        public ucSinhVien()
        {
            InitializeComponent();
        }
        private void LoadSinhVien()
        {
            try
            {
                
                string tk = txtTimKiem.Text.Trim();

              
                var query = db.tbl_SinhViens.AsQueryable();
            
                if (!string.IsNullOrEmpty(tk))
                {
                    query = query.Where(sv =>
                        sv.MaSV.Contains(tk) ||
                        sv.HoTen.Contains(tk) ||
                        sv.tbl_Lop.TenLop.Contains(tk));
                }

                var finalQuery = query.Select(sv => new
                {
                    sv.id,
                    sv.MaSV,
                    sv.HoTen,
                    sv.GioiTinh,
                    sv.NgaySinh,
                    sv.tbl_Lop.TenLop,
                }).OrderBy(sv => sv.id);

                totalRecords = finalQuery.Count();
                totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

                if (totalPages == 0) totalPages = 1;
                if (currentPage > totalPages) currentPage = totalPages;
                if (currentPage < 1) currentPage = 1;

                var listByPage = finalQuery.Skip((currentPage - 1) * pageSize)
                                      .Take(pageSize)
                                      .ToList();

                dgvSinhVien.DataSource = listByPage;
                FormatGrid();
                UpdatePaginationUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void UpdatePaginationUI()
        {

            txtTrang.Text = currentPage.ToString();


            btnPrev.Enabled = (currentPage > 1);


            btnNext.Enabled = (currentPage < totalPages);
        }
        private void FormatGrid()
        {
            if (dgvSinhVien.Columns.Contains("MaSV") && dgvSinhVien.Columns.Contains("HoTen") && dgvSinhVien.Columns.Contains("GioiTinh") && dgvSinhVien.Columns.Contains("NgaySinh") && dgvSinhVien.Columns.Contains("TenLop"))
            {
                dgvSinhVien.Columns["MaSV"].HeaderText = "MSSV";
                dgvSinhVien.Columns["HoTen"].HeaderText = "Họ tên";
                dgvSinhVien.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgvSinhVien.Columns["TenLop"].HeaderText = "Tên lớp";

                dgvSinhVien.Columns["MaSV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvSinhVien.Columns["GioiTinh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvSinhVien.Columns["NgaySinh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                dgvSinhVien.Columns["HoTen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvSinhVien.Columns["TenLop"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvSinhVien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvSinhVien.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";

                dgvSinhVien.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow != null)
            {
                string mssv = dgvSinhVien.CurrentRow.Cells["MaSV"].Value.ToString();
                frm_UpdateSinhVien update = new frm_UpdateSinhVien(mssv);
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
                        
                            var sv = db.tbl_SinhViens.FirstOrDefault(x => x.id == id);
                            if (sv != null)
                            {
                                db.tbl_SinhViens.DeleteOnSubmit(sv);
                                db.SubmitChanges();
                                LoadSinhVien();
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadSinhVien();
        }

        private void ucSinhVien_Load(object sender, EventArgs e)
        {
            LoadSinhVien();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               
                e.SuppressKeyPress = true;

                
                btnTimKiem.PerformClick();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadSinhVien();
            }
        }

        private void txtTrang_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                int inputPage;

                if (int.TryParse(txtTrang.Text, out inputPage))
                {
                    currentPage = inputPage;
                    LoadSinhVien();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số trang hợp lệ!");
                    txtTrang.Text = currentPage.ToString();
                }
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadSinhVien();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            currentPage = 1;
            LoadSinhVien();
        }
    }
}

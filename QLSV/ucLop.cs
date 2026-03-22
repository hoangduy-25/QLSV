using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class ucLop : UserControl
    {

        DataBaseDataContext db = new DataBaseDataContext();
        private int pageSize = 10;
        private int currentPage = 1;
        private int totalRecords = 0;
        private int totalPages = 0;
        public ucLop()
        {
            InitializeComponent();
            LoadLopQL();
        }
        private void LoadLopQL()
        {
            try
            {
                db = new DataBaseDataContext();

                string tk = txt_search.Text.Trim();

                var query = db.tbl_Lops.AsQueryable();

                if (!string.IsNullOrEmpty(tk))
                {

                    query = query.Where(lop =>
                        lop.MaLop.Contains(tk) ||
                        lop.TenLop.Contains(tk));
                }

                query = query.OrderBy(lop => lop.MaLop);

                totalRecords = query.Count();
                totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

                if (totalPages == 0) totalPages = 1;
                if (currentPage > totalPages) currentPage = totalPages;
                if (currentPage < 1) currentPage = 1;

                var listByPage = query.Skip((currentPage - 1) * pageSize)
                                      .Take(pageSize)
                                      .ToList();

                dgvLopQL.DataSource = listByPage;
                FormatGid(); 

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
        private void FormatGid()
        {
            if (dgvLopQL.Columns.Contains("MaLop") && dgvLopQL.Columns.Contains("TenLop"))
            {
                dgvLopQL.Columns["MaLop"].HeaderText = "Mã Lớp";
                dgvLopQL.Columns["TenLop"].HeaderText = "Tên lớp";

                dgvLopQL.Columns["MaLop"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvLopQL.Columns["TenLop"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                

                dgvLopQL.Columns["MaLop"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvLopQL.Columns["TenLop"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvLopQL.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvLopQL.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            }
        }
        private void btn_ThemLop_Click(object sender, EventArgs e)
        {
            frm_UpdateLopQL UpdateLopQL = new frm_UpdateLopQL();
            UpdateLopQL.ShowDialog();
            LoadLopQL();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLopQL.CurrentRow != null)
            {
                string id = dgvLopQL.CurrentRow.Cells["MaLop"].Value.ToString();
                frm_UpdateLopQL update = new frm_UpdateLopQL(id);
                update.ShowDialog();
                LoadLopQL();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để sửa.");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (dgvLopQL.CurrentRow != null)
            {
                string id = dgvLopQL.CurrentRow.Cells["MaLop"].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        
                            var lop = db.tbl_Lops.FirstOrDefault(x => x.MaLop == id);
                            if (lop != null)
                            {
                                db.tbl_Lops.DeleteOnSubmit(lop);
                                db.SubmitChanges();
                                LoadLopQL();
                            }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa lớp: " + ex.Message);
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
            LoadLopQL();
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true;


                btnTimKiem.PerformClick();
            }
        }

        private void btnXemDSSV_Click(object sender, EventArgs e)
        {
            if (dgvLopQL.CurrentRow != null)
            {
                
                string maLop = dgvLopQL.CurrentRow.Cells["MaLop"].Value.ToString();
                string tenLop = dgvLopQL.CurrentRow.Cells["TenLop"].Value.ToString();

                
                frm_DSSV_TheoLop frm = new frm_DSSV_TheoLop(maLop, tenLop);

                
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một lớp để xem danh sách sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadLopQL();
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
                    LoadLopQL();
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
                LoadLopQL();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txt_search.Clear();
            currentPage = 1;
            LoadLopQL(); 
        }
    }
}

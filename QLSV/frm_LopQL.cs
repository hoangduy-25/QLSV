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
    public partial class frm_LopQL : Form
    {
        
        public frm_LopQL()
        {
            InitializeComponent();
        }
        private void frm_LopQL_Load(object sender, EventArgs e)
        {
            LoadLopQL();
            
        }

        private void LoadLopQL()
        {
            try
            {
                using (DataBaseDataContext db = new DataBaseDataContext())
                {
                    var list = db.tbl_LopQLs.OrderBy(lop => lop.id).ToList();
                    dgvLopQL.DataSource = list;
                    FormatGid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }
        private void FormatGid()
        {
            if (dgvLopQL.Rows.Count > 0)
            {
                dgvLopQL.Columns["maLop"].HeaderText = "Mã Lớp";
                dgvLopQL.Columns["tenLop"].HeaderText = "Tên lớp";
                dgvLopQL.Columns["SoHS"].HeaderText = "Số HS";
                dgvLopQL.Columns["GiangVien"].HeaderText = "Giảng viên";
            }
        }
        private void btn_ThemLop_Click(object sender, EventArgs e)
        {
            frm_UpdateLopQL UpdateLopQL = new frm_UpdateLopQL();
            UpdateLopQL.ShowDialog();
            LoadLopQL();
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Login loginForm = new frm_Login();
            loginForm.ShowDialog();
            this.Close();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLopQL.CurrentRow != null)
            {
                string id = dgvLopQL.CurrentRow.Cells["id"].Value.ToString();
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
                string id = dgvLopQL.CurrentRow.Cells["id"].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (DataBaseDataContext db = new DataBaseDataContext())
                        {
                            var lop = db.tbl_LopQLs.FirstOrDefault(x => x.id == id);
                            if (lop != null)
                            {
                                db.tbl_LopQLs.DeleteOnSubmit(lop);
                                db.SubmitChanges();
                                LoadLopQL();
                            }
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

        private void LoadLopTheoTu(string tuKhoa)
        {
            string tk = tuKhoa.Trim();
            using (DataBaseDataContext db = new DataBaseDataContext())
            {
                var ds = db.tbl_LopQLs
                       .Where(lop =>
                           lop.id.Contains(tk) ||
                           lop.tenLop.Contains(tk) ||
                           lop.maLop.Contains(tk))
                       .OrderBy(sv => sv.id)
                       .ToList();
                dgvLopQL.DataSource = ds;
                FormatGid();
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_search.Text))
                LoadLopQL();
            else
                LoadLopTheoTu(txt_search.Text);
        }
    }

}

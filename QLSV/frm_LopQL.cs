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
                    var list = db.tbl_Lops.OrderBy(lop => lop.MaLop).ToList();
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
                dgvLopQL.Columns["MaLop"].HeaderText = "Mã Lớp";
                dgvLopQL.Columns["TenLop"].HeaderText = "Tên lớp";
                
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
                        using (DataBaseDataContext db = new DataBaseDataContext())
                        {
                            var lop = db.tbl_Lops.FirstOrDefault(x => x.MaLop == id);
                            if (lop != null)
                            {
                                db.tbl_Lops.DeleteOnSubmit(lop);
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
                var ds = db.tbl_Lops
                       .Where(lop =>
                           
                           lop.TenLop.Contains(tk) ||
                           lop.MaLop.Contains(tk))
                       .OrderBy(sv => sv.MaLop)
                       .ToList();
                dgvLopQL.DataSource = ds;
                FormatGid();
            }

        }
        private void frm_DSSV(object sender, EventArgs e)
        {
            this.Hide();
            frm_DSSV frm = new frm_DSSV();
            frm.ShowDialog();
            this.Close();
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

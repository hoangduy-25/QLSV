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
    public partial class frm_UpdateLopQL : Form
    {
        private string _MaLop= "";
        public frm_UpdateLopQL()
        {
            InitializeComponent();
            _MaLop = "";
        }
        public frm_UpdateLopQL(string idLop)
        {
            InitializeComponent();
            _MaLop = idLop;
        }
        private void frm_UpdateLopQL_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_MaLop))
            {
                txt_MaLop.Text = _MaLop;
                txt_MaLop.Enabled = false;
                    using (DataBaseDataContext db = new DataBaseDataContext())
                    {
                        var lop = db.tbl_Lops.FirstOrDefault(l => l.MaLop == _MaLop);
                        if (lop != null)
                        {
                            txt_MaLop.Text = lop.MaLop;
                            txt_TenLop.Text = lop.TenLop;
                            
                        }
                    }
            }
            else
            {
                txt_MaLop.Clear();
                txt_MaLop.Enabled = true;
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maLopInput = txt_MaLop.Text.Trim();
            string tenLopInput = txt_TenLop.Text.Trim();

            if (string.IsNullOrEmpty(maLopInput) || string.IsNullOrEmpty(tenLopInput))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (DataBaseDataContext db = new DataBaseDataContext())
                {

                    if (string.IsNullOrEmpty(_MaLop))
                    {
                        if (db.tbl_Lops.Any(l => l.MaLop == maLopInput))
                        {
                            MessageBox.Show("Mã lớp này đã tồn tại! Vui lòng nhập mã khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_MaLop.Focus();
                            return; 
                        }

                        if (db.tbl_Lops.Any(l => l.TenLop.ToLower() == tenLopInput.ToLower()))
                        {
                            MessageBox.Show("Tên lớp này đã tồn tại! Vui lòng nhập tên khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_TenLop.Focus();
                            return; 
                        }

                        tbl_Lop lopNew = new tbl_Lop();
                        lopNew.MaLop = maLopInput;
                        lopNew.TenLop = tenLopInput;

                        db.tbl_Lops.InsertOnSubmit(lopNew);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        if (db.tbl_Lops.Any(l => l.TenLop.ToLower() == tenLopInput.ToLower() && l.MaLop != _MaLop))
                        {
                            MessageBox.Show("Tên lớp này đang được sử dụng bởi một mã lớp khác! Vui lòng nhập tên khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_TenLop.Focus();
                            return; 
                        }

                        var lopUpdate = db.tbl_Lops.FirstOrDefault(l => l.MaLop == _MaLop);
                        if (lopUpdate != null)
                        {
                            lopUpdate.TenLop = tenLopInput;

                            db.SubmitChanges();
                            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
}

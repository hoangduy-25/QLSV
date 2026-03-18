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
            if (string.IsNullOrEmpty(txt_MaLop.Text) || string.IsNullOrEmpty(txt_TenLop.Text) )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            try
            {
                using (DataBaseDataContext db = new DataBaseDataContext())
                {
                    if (string.IsNullOrEmpty(_MaLop))
                    {
                        if (db.tbl_Lops.Any(l => l.MaLop == txt_MaLop.Text.Trim()))
                        {
                            MessageBox.Show("ID lớp đã tồn tại!");
                            return;
                        }
                        tbl_Lop lopNew = new tbl_Lop();
                        
                        lopNew.MaLop = txt_MaLop.Text.Trim();
                        lopNew.TenLop = txt_TenLop.Text.Trim();
                        
                        db.tbl_Lops.InsertOnSubmit(lopNew);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm mới thành công");
                    }
                    else
                    {
                        var lopUpdate = db.tbl_Lops.FirstOrDefault(l => l.MaLop == _MaLop);
                        if (lopUpdate != null)
                        {
                            lopUpdate.MaLop = txt_MaLop.Text.Trim();
                            lopUpdate.TenLop = txt_TenLop.Text.Trim();
                          
                            db.SubmitChanges();
                            MessageBox.Show("Cập nhật thành công");
                        }
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
}

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
        private string _idLop= "";
        public frm_UpdateLopQL()
        {
            InitializeComponent();
            _idLop = "";
        }
        public frm_UpdateLopQL(string idLop)
        {
            InitializeComponent();
            _idLop = idLop;
        }
        private void frm_UpdateLopQL_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_idLop))
            {
                txt_IDLopQL.Text = _idLop;
                txt_IDLopQL.Enabled = false;
                    using (DataBaseDataContext db = new DataBaseDataContext())
                    {
                        var lop = db.tbl_LopQLs.FirstOrDefault(l => l.id == _idLop);
                        if (lop != null)
                        {
                            txt_Class.Text = lop.maLop;
                            txt_TenLop.Text = lop.tenLop;
                            txt_soHS.Text = lop.SoHS.ToString();
                            txt_GV.Text = lop.GiangVien;
                        }
                    }
            }
            else
            {
                txt_IDLopQL.Clear();
                txt_IDLopQL.Enabled = true;
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_IDLopQL.Text) || string.IsNullOrEmpty(txt_Class.Text) || string.IsNullOrEmpty(txt_TenLop.Text) || string.IsNullOrEmpty(txt_soHS.Text) || string.IsNullOrEmpty(txt_GV.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            try
            {
                using (DataBaseDataContext db = new DataBaseDataContext())
                {
                    if (string.IsNullOrEmpty(_idLop))
                    {
                        if (db.tbl_LopQLs.Any(l => l.id == txt_IDLopQL.Text.Trim()))
                        {
                            MessageBox.Show("ID lớp đã tồn tại!");
                            return;
                        }
                        tbl_LopQL lopNew = new tbl_LopQL();
                        lopNew.id = txt_IDLopQL.Text.Trim();
                        lopNew.maLop = txt_Class.Text.Trim();
                        lopNew.tenLop = txt_TenLop.Text.Trim();
                        lopNew.SoHS = txt_soHS.Text.Trim();
                        lopNew.GiangVien = txt_GV.Text.Trim();
                        db.tbl_LopQLs.InsertOnSubmit(lopNew);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm mới thành công");
                    }
                    else
                    {
                        var lopUpdate = db.tbl_LopQLs.FirstOrDefault(l => l.id == _idLop);
                        if (lopUpdate != null)
                        {
                            lopUpdate.maLop = txt_Class.Text.Trim();
                            lopUpdate.tenLop = txt_TenLop.Text.Trim();
                            lopUpdate.SoHS = txt_soHS.Text.Trim();
                            lopUpdate.GiangVien = txt_GV.Text.Trim();
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

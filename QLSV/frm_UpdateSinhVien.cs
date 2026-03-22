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
    public partial class frm_UpdateSinhVien : Form
    {
        private string _MSSV = "";
        public frm_UpdateSinhVien()
        {
            InitializeComponent();
            _MSSV = "";
        }

        public frm_UpdateSinhVien(string mssv)
        {
            InitializeComponent();
            _MSSV = mssv;
        }

        private void loadComboBox()
        {
            using (DataBaseDataContext db = new DataBaseDataContext())
            {
                var listLop = db.tbl_Lops.Select(lop => new { lop.MaLop, lop.TenLop }).ToList();
                cboMaLop.DataSource = listLop;
                cboMaLop.DisplayMember = "TenLop";
                cboMaLop.ValueMember = "MaLop";
                cboMaLop.SelectedIndex = -1;
            }
        }

       
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MSSV.Text) || string.IsNullOrEmpty(txt_hoTen.Text) || string.IsNullOrEmpty(cboMaLop.Text) || string.IsNullOrEmpty(cboGioiTinh.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            try
            {
                using (DataBaseDataContext db = new DataBaseDataContext())
                {
                    //Them moi

                    if (string.IsNullOrEmpty(_MSSV))
                    {
                        if (db.tbl_SinhViens.Any(s => s.MaSV == txt_MSSV.Text.Trim()))
                        {
                            MessageBox.Show("MSSV đã tồn tại!");
                            return;
                        }

                        tbl_SinhVien svNew = new tbl_SinhVien();
                        svNew.MaSV = txt_MSSV.Text.Trim();
                        svNew.HoTen = txt_hoTen.Text.Trim();
                        svNew.NgaySinh = dtP_NgaySinh.Value;
                        svNew.MaLop = cboMaLop.SelectedValue.ToString();
                        svNew.GioiTinh = cboGioiTinh.Text;

                        db.tbl_SinhViens.InsertOnSubmit(svNew);
                        db.SubmitChanges();

                        MessageBox.Show("Thêm mới thành công");
                    }
                    else
                    {
                        //Sua
                        var sv = db.tbl_SinhViens.FirstOrDefault(s => s.MaSV == _MSSV);
                        if (sv != null)
                        {
                            sv.HoTen = txt_hoTen.Text.Trim();
                            sv.NgaySinh = dtP_NgaySinh.Value;
                            sv.MaLop = cboMaLop.SelectedValue.ToString();
                            sv.GioiTinh = cboGioiTinh.Text;
                            db.SubmitChanges();
                            MessageBox.Show("Cập nhật thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sinh viên!");
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
        private void UpdateSinhVien_Load(object sender, EventArgs e)
        {
            loadComboBox();
            cboGioiTinh.SelectedIndex = 0;
            if (!string.IsNullOrEmpty(_MSSV))
            {
                txt_MSSV.Text = _MSSV;
                txt_MSSV.Enabled = false;
                using (DataBaseDataContext db = new DataBaseDataContext())
                {
                    var sv = db.tbl_SinhViens.FirstOrDefault(s => s.MaSV == txt_MSSV.Text);
                    if (sv != null)
                    {
                        txt_hoTen.Text = sv.HoTen;
                        dtP_NgaySinh.Value = sv.NgaySinh ?? DateTime.Now;
                        cboMaLop.SelectedValue = sv.MaLop;
                        cboGioiTinh.Text = sv.GioiTinh;
                    }
                }
            }
            else
            {
                txt_MSSV.Clear();
                txt_MSSV.Enabled = true;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

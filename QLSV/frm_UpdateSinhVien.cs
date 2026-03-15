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
        private string _id = "";
        public frm_UpdateSinhVien()
        {
            InitializeComponent();
            _id = "";
        }

        public frm_UpdateSinhVien(string mssv)
        {
            InitializeComponent();
            _id = mssv;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MSSV.Text) || string.IsNullOrEmpty(txt_hoTen.Text) || string.IsNullOrEmpty(txt_Lop.Text) || string.IsNullOrEmpty(cB_gioiTinh.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            try
            {
                using (DataBaseDataContext db = new DataBaseDataContext())
                {
                    //Them moi

                    if (string.IsNullOrEmpty(_id))
                    {
                        if (db.tbl_sinhviens.Any(s => s.id == txt_MSSV.Text.Trim()))
                        {
                            MessageBox.Show("MSSV đã tồn tại!");
                            return;
                        }

                        tbl_sinhvien svNew = new tbl_sinhvien();
                        svNew.id = txt_MSSV.Text.Trim();
                        svNew.Hoten = txt_hoTen.Text.Trim();
                        svNew.ngaysinh = dtP_NgaySinh.Value;
                        svNew.malop = txt_Lop.Text.Trim();
                        svNew.gioitinh = cB_gioiTinh.Text;

                        db.tbl_sinhviens.InsertOnSubmit(svNew);
                        db.SubmitChanges();

                        MessageBox.Show("Thêm mới thành công");
                    }
                    else
                    {
                        //Sua
                        var sv = db.tbl_sinhviens.FirstOrDefault(s => s.id == _id);
                        if (sv != null)
                        {
                            sv.Hoten = txt_hoTen.Text.Trim();
                            sv.ngaysinh = dtP_NgaySinh.Value;
                            sv.malop = txt_Lop.Text.Trim();
                            sv.gioitinh = cB_gioiTinh.Text;
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
            cB_gioiTinh.SelectedIndex = 0;
            if (!string.IsNullOrEmpty(_id))
            {
                txt_MSSV.Text = _id;
                txt_MSSV.Enabled = false;
                using (DataBaseDataContext db = new DataBaseDataContext())
                {
                    var sv = db.tbl_sinhviens.FirstOrDefault(s => s.id == txt_MSSV.Text);
                    if (sv != null)
                    {
                        txt_hoTen.Text = sv.Hoten;
                        dtP_NgaySinh.Value = sv.ngaysinh ?? DateTime.Now;
                        txt_Lop.Text = sv.malop;
                        cB_gioiTinh.Text = sv.gioitinh;
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

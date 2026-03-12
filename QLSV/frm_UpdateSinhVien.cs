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
        public frm_UpdateSinhVien()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            DataBaseDataContext db = new DataBaseDataContext();
            tbl_sinhvien sv = new tbl_sinhvien();
            sv.id = txt_MSSV.Text;
            sv.Hoten = txt_hoTen.Text;
            sv.ngaysinh = dtP_NgaySinh.Value;
            sv.malop = txt_Lop.Text;
            sv.gioitinh = cB_gioiTinh.Text;
            db.tbl_sinhviens.InsertOnSubmit(sv);
            db.SubmitChanges();
            MessageBox.Show("Thêm sinh viên thành công!");
            this.Hide();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

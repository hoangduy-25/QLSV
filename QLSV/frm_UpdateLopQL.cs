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
        public frm_UpdateLopQL()
        {
            InitializeComponent();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataBaseDataContext db = new DataBaseDataContext();
            tbl_LopQL LopQL = new tbl_LopQL();
            LopQL.id = txt_IDLopQL.Text;
            LopQL.maLop = txt_Class.Text;
            LopQL.tenLop = txt_TenLop.Text;
            LopQL.SoHS = txt_soHS.Text;
            LopQL.GiangVien = txt_GV.Text;
            db.tbl_LopQLs.InsertOnSubmit(LopQL);
            db.SubmitChanges();
            MessageBox.Show("Thêm thành công");
            this.Hide();
        }
        
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
}

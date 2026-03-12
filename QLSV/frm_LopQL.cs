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
            DataBaseDataContext db = new DataBaseDataContext();
            var list = db.tbl_LopQLs.ToList();
            dGV_LopQL.DataSource = list;
            dGV_LopQL.Columns["maLop"].HeaderText = "Mã Lớp";
            dGV_LopQL.Columns["tenLop"].HeaderText = "Tên lớp";
            dGV_LopQL.Columns["SoHS"].HeaderText = "Số HS";
            dGV_LopQL.Columns["GiangVien"].HeaderText = "Giảng viên";
        }
        private void btn_ThemLop_Click(object sender, EventArgs e)
        {
            frm_UpdateLopQL UpdateLopQL = new frm_UpdateLopQL();
            UpdateLopQL.Show();
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frm_Login loginForm = new frm_Login();
            loginForm.Show();
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}

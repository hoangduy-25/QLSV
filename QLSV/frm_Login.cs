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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_passwd.Text.Trim();
            if (username == "1" && password == "1")
            {
                this.Hide();
                frm_DSSV mainForm = new frm_DSSV();
                mainForm.ShowDialog();
                this.Close();
            }
            else if (username == "2" && password == "2")
            {
                this.Hide();
                frm_LopQL mainForm = new frm_LopQL();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.");
            }
        }
    }
}

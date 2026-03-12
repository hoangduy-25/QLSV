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

        private void label1_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_passwd.Text;
            if (username == "1" && password == "1")
            {
                MessageBox.Show("Đăng nhập thành công!");
                frm_DSSV mainForm = new frm_DSSV();
                mainForm.Show();
                this.Hide();
            }
            else if (username == "2" && password == "2")
            {
                MessageBox.Show("Đăng nhập thành công!");
                frm_LopQL mainForm = new frm_LopQL();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.");
            }
        }
    }
}

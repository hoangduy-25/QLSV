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
        DataBaseDataContext db = new DataBaseDataContext();
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_passwd.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                var user = db.tbl_TaiKhoans.FirstOrDefault(u => u.TenDangNhap == username && u.MatKhau == password);

                if (user != null)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frm_QLSV mainForm = new frm_QLSV();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại! Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message);
            }
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_passwd.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập và Mật khẩu bạn muốn đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                var checkUser = db.tbl_TaiKhoans.FirstOrDefault(u => u.TenDangNhap == username);

                if (checkUser != null)
                {

                    MessageBox.Show("Tên đăng nhập này đã tồn tại. Vui lòng chọn tên khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
  
                    tbl_TaiKhoan newUser = new tbl_TaiKhoan();
                    newUser.TenDangNhap = username;
                    newUser.MatKhau = password; 

                    db.tbl_TaiKhoans.InsertOnSubmit(newUser);
                    db.SubmitChanges(); 

                    MessageBox.Show("Đăng ký tài khoản thành công! Bạn có thể đăng nhập ngay bây giờ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_passwd.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng ký: " + ex.Message);
            }
        }
    }
}

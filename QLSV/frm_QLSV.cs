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
    public partial class frm_QLSV : Form
    {
        
        public frm_QLSV()
        {
            InitializeComponent();
        }

        private void frm_SinhVien_Load(object sender, EventArgs e)
        {

            ucSinhVien ucSV = new ucSinhVien();
            ucSV.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(ucSV);

        }

        

        private void danhSachSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucSinhVien ucSV= new ucSinhVien();
            ucSV.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(ucSV);
        }

        private void lopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucLop ucLop = new ucLop();
            ucLop.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(ucLop);
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Login loginForm = new frm_Login();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}

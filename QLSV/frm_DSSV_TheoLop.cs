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
    public partial class frm_DSSV_TheoLop : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();
        string maLopDangXem = "";
        public frm_DSSV_TheoLop(string maLop, string tenLop)
        {
            InitializeComponent();
            maLopDangXem = maLop;
            lblTieuDe.Text = "Sinh viên thuộc lớp: " + tenLop;
        }

        private void frm_DSSV_TheoLop_Load(object sender, EventArgs e)
        {
            LoadSinhVienTheoLop();
        }
        private void LoadSinhVienTheoLop()
        {
            try
            {

                var listSV = db.tbl_SinhViens
                               .Where(sv => sv.MaLop == maLopDangXem)
                               .Select(sv => new {
                                   sv.MaSV,
                                   sv.HoTen,
                                   sv.NgaySinh,
                                   sv.GioiTinh,

                               })
                               .ToList();

                dgvDSSV.DataSource = listSV;
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void FormatGrid()
        {
            if (dgvDSSV.Columns.Contains("MaSV") && dgvDSSV.Columns.Contains("HoTen") && dgvDSSV.Columns.Contains("GioiTinh") && dgvDSSV.Columns.Contains("NgaySinh"))
            {
                dgvDSSV.Columns["MaSV"].HeaderText = "MSSV";
                dgvDSSV.Columns["HoTen"].HeaderText = "Họ tên";
                dgvDSSV.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgvDSSV.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                

                dgvDSSV.Columns["MaSV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvDSSV.Columns["GioiTinh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvDSSV.Columns["NgaySinh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                dgvDSSV.Columns["HoTen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    

                dgvDSSV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvDSSV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            }

        }
    }
}

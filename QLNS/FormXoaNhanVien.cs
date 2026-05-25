using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class FormXoaNhanVien : Form
    {
        public FormXoaNhanVien()
        {
            InitializeComponent();
        }
        BUS_NhanVien busNhanVien = new BUS_NhanVien();

        private void FromXoaNhanVien_Load(object sender, EventArgs e)
        {

        }

        //load nhân viên lên dgv
        public void LoadNhanVien()
        {
            try
            {
                dgvNhanVien.DataSource = busNhanVien.LayDanhSachLenGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            lblMaNV.Text = "";
        }
    }
}

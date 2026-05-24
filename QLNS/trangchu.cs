using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace QLNS
{
    public partial class trangchu : Form
    {
        private Form currentFormChild;
        public trangchu()
        {
            InitializeComponent();
        }

        private void btnDanhSachNV_Click(object sender, EventArgs e)
        {

            FormNhanVien frm = new FormNhanVien();
            OpenChildForm(frm);


        }

        private void btnTuyenDung_Click(object sender, EventArgs e)
        {


            Formtuyendung frm = new Formtuyendung();
            OpenChildForm(frm);


        }

        private void btnchamcong_Click(object sender, EventArgs e)
        {


            Formchamcong frm = new Formchamcong();
            OpenChildForm(frm);


        }

        private void btnTaiChinh_Click(object sender, EventArgs e)
        {


            Formtaichinh frm = new Formtaichinh();
            OpenChildForm(frm);


        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {


            Formdanhmuc frm = new Formdanhmuc();
            OpenChildForm(frm);


        }

        private void btnBaoMat_Click(object sender, EventArgs e)
        {

            Formhethong frm = new Formhethong();
            OpenChildForm(frm);
        }
        private void OpenChildForm(Form childForm)
        {// Kiểm tra: Nếu đã có form đang mở VÀ form đó cùng loại với form sắp mở
            if (currentFormChild != null && currentFormChild.GetType() == childForm.GetType())
            {
                return;
            }

            // Nếu là form khác, tiến hành đóng form cũ đi để giải phóng RAM
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                currentFormChild.Dispose();
            }

            // Xóa sạch Panel (đề phòng)
            if (pnDesktop.Controls.Count > 0)
            {
                pnDesktop.Controls.Clear();
            }

            // Gán form mới vào biến theo dõi
            currentFormChild = childForm;

            // Cấu hình form mới và nhúng vào Panel
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill; // Tự động co giãn vừa khít Panel

            pnDesktop.Controls.Add(childForm);
            pnDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbtntrangchu_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            OpenChildForm(frm);
        }

        private void rbtnthoat_Click(object sender, EventArgs e)
        {

            // 1. Khởi tạo hộp thoại của Guna
            Guna.UI2.WinForms.Guna2MessageDialog msgDialog = new Guna.UI2.WinForms.Guna2MessageDialog();

            // 2. Cấu hình nội dung và giao diện
            msgDialog.Caption = "Xác nhận";
            msgDialog.Text = "Bạn có chắc chắn muốn thoát phần mềm không?";
            msgDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            msgDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            msgDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light; // Nền trắng hiện đại

            // 3. Hiển thị và xử lý kết quả
            DialogResult rs = msgDialog.Show();

            if (rs == DialogResult.Yes)
            {
                Application.Exit(); // Tắt toàn bộ ứng dụng
            }
        }

        private void trangchu_Load(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            OpenChildForm(frm);
        }
    }
}

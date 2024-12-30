using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYTEM
{
    public partial class Đăng_Nhập : Form
    {

        public Đăng_Nhập() => InitializeComponent();

        Modify modify = new Modify();
        private void b_DangNhap_Click(object sender, EventArgs e)
        {

            string sTenTK = txt_TenTK.Text;
            string sMatKhau = txt_MatKhau.Text;
            string sMaNS = txt_MaNS.Text;

            if (sTenTK.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                return;
            }
            if (sMatKhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }
            if (sMaNS.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân sự!");
                return;
            }
            else
            {
                string sQuery = "SELECT * FROM TaiKhoan WHERE TenTaiKhoan = '" + sTenTK + "' AND MatKhau = '" + sMatKhau + "'";
                string sQuery1 = "SELECT * FROM NhanSu WHERE MaNS = '" + sMaNS + "' AND ChucVu = N'Quản lý'";

                if (modify.TaiKhoans(sQuery).Count != 0)
                {
                    if (modify.NhanSus(sQuery1).Count != 0)
                    {
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm_QLNS frm_QLNS = new frm_QLNS();
                        this.Hide();
                        frm_QLNS.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Bạn không có quyền truy cập! Chỉ dành cho quản lý.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}

       
   
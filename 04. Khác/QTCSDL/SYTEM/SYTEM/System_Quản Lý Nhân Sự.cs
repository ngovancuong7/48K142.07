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
    public partial class frm_QLNS : Form
    {
        bool Hided;
        public frm_QLNS()
        {
            InitializeComponent();
            Hided = false;

        }

        private void b_NhanSu_Click_1(object sender, EventArgs e)
        {
            frm_NhanSu frm_NhanSu = new frm_NhanSu();
            this.Hide();
            frm_NhanSu.ShowDialog();
            this.Show();
        }

        private void b_TaiKhoan_Click(object sender, EventArgs e)
        {
            frm_TaiKhoan frm_TaiKhoan = new frm_TaiKhoan();
            this.Hide();
            frm_TaiKhoan.ShowDialog();
            this.Show();
        }

        private void b_LichlamViec_Click(object sender, EventArgs e)
        {
            frm_LichLamViec frm_LichlamViec = new frm_LichLamViec();
            this.Hide();
            frm_LichlamViec.ShowDialog();
            this.Show();
        }

        private void b_Luong_Click(object sender, EventArgs e)
        {
            frm_Luong frm_Luong = new frm_Luong();
            this.Hide();
            frm_Luong.ShowDialog();
            this.Show();
        }

        private void b_DGYC_Click(object sender, EventArgs e)
        {
            frm_DGYC frm_DGYC = new frm_DGYC();
            this.Hide();
            frm_DGYC.ShowDialog();
            this.Show();
        }
    }
}
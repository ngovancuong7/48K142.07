using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYTEM
{
    public partial class frm_Luong : Form
    {
        string sCon = "Data Source=HUONGNGOC;Initial Catalog=QLNS;Integrated Security=True;Encrypt=False";
        public frm_Luong()
        {
            InitializeComponent();
            this.Opacity = 0;
            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.1;
            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
            {
                //buoc 1
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception )
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối với DB");
                }
                //Buoc 2
                //Lay dl ve
                string sQuery = "select * from BangLuong";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "BangLuong");
                dataGridView4.DataSource = ds.Tables["BangLuong"];

                con.Close(); //Buoc 3
            }
        private void LoadData4()
        {
            // Bước 1: Kết nối cơ sở dữ liệu
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string sQuery = "Select * from BangLuong"; // Câu lệnh truy vấn
                    SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Hiển thị dữ liệu lên DataGridView
                    dataGridView4.DataSource = dt;
                    txtMaBL.Enabled = true;
                    txtMaNS.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
                }
            }
        }
        private void clearBL()
        {

            txtMaBL.Clear();
            txtMaNS.Clear();
            txtTTP.Clear();
            txtTTT.Clear();
            txtSGL.Clear();
            txtML.Clear();
            dtpNgayTinhLuong.Value = DateTime.Now;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
            {
                MessageBox.Show("Xin Cảm Ơn!!", "Thông Báo");
            }

            private void btnLuu_Click(object sender, EventArgs e)
            {
            //buoc 1
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối với DB");
            }
            //buoc2 
            //chuan bi dl
            //ktra hop le cua dl
            //gan dl vao bien
            string sMaBL = txtMaBL.Text;
            string sMaNS = txtMaNS.Text;
            string sTongTienPhat = txtTTP.Text;
            string sTongTienThuong = txtTTT.Text;
            string sSoGioLam = txtSGL.Text;
            string sMucLuong = txtML.Text;
            string sNgayTinhLuong = dtpNgayTinhLuong.Value.ToString("yyyy-MM-dd");

            string sQuery = "insert into BangLuong values(@MaBL, @MucLuong, @TongTienPhat, @TongTienThuong, @SoGioLam, @NgayTinhLuong, @MaNS)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaBL", sMaBL);
            cmd.Parameters.AddWithValue("@MaNS", sMaNS);
            cmd.Parameters.AddWithValue("@TongTienPhat", sTongTienPhat);
            cmd.Parameters.AddWithValue("@TongTienThuong", sTongTienThuong);
            cmd.Parameters.AddWithValue("@SoGioLam", sSoGioLam);
            cmd.Parameters.AddWithValue("@NgayTinhLuong", sNgayTinhLuong);
            cmd.Parameters.AddWithValue("@MucLuong", sMucLuong);


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!!");
                LoadData4();
                clearBL();

            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới");
            }
            con.Close(); //Buoc 3
        }

            private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                txtMaBL.Text = dataGridView4.Rows[e.RowIndex].Cells["MaBL"].Value.ToString();
                txtMaNS.Text = dataGridView4.Rows[e.RowIndex].Cells["MaNS"].Value.ToString();
                txtTTP.Text = dataGridView4.Rows[e.RowIndex].Cells["TongTienPhat"].Value.ToString();
                txtTTT.Text = dataGridView4.Rows[e.RowIndex].Cells["TongTienThuong"].Value.ToString();
                txtSGL.Text = dataGridView4.Rows[e.RowIndex].Cells["SoGioLam"].Value.ToString();
                txtML.Text = dataGridView4.Rows[e.RowIndex].Cells["MucLuong"].Value.ToString();
            txtMaBL.Enabled = false;
            txtMaNS.Enabled = false;
        }

            private void btnSua_Click(object sender, EventArgs e)
            {
                //buoc1
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình kết nối với DB");
                }
                //buoc 2
                //lay du lieu
                string sMaBL = txtMaBL.Text;
                string sMaNS = txtMaNS.Text;
                string sTongTienPhat = txtTTP.Text;
                string sTongTienThuong = txtTTT.Text;
                string sSoGioLam = txtSGL.Text;
                string sMucLuong = txtML.Text;
                string sQuery = "update BangLuong set TongTienPhat = @TongTienPhat, TongTienThuong = @TongTienThuong, SoGioLam = @SoGioLam, MucLuong = @MucLuong " +
                                "where MaNS = @MaNS";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@MaBL", sMaBL);
                cmd.Parameters.AddWithValue("@MucLuong", sMucLuong);
                cmd.Parameters.AddWithValue("@TongTienPhat", sTongTienPhat);
                cmd.Parameters.AddWithValue("@TongTienThuong", sTongTienThuong);
                cmd.Parameters.AddWithValue("@SoGioLam", sSoGioLam);
                cmd.Parameters.AddWithValue("@MaNS", sMaNS);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công");
                    LoadData4();
                clearBL();
                }
            catch (Exception ex)
            {
                MessageBox.Show($"Xảy ra lỗi trong quá trình cập nhật: {ex.Message}");
            }
            con.Close(); //buoc 3

            }

            private void btnXoa_Click(object sender, EventArgs e)
            {
                DialogResult ret = MessageBox.Show("Có chắc chắn xóa không?", "Thông Báo", MessageBoxButtons.OKCancel);
                if (ret == DialogResult.OK)
                {
                //buoc1
                SqlConnection con = new SqlConnection(sCon);
                    try
                    {
                        con.Open();
                    }
                    catch (Exception )
                    {
                        MessageBox.Show("Xảy ra lỗi trong quá trình kết nối với DB");
                    }
                    //buoc 2
                    //lay gia tri
                    string sMaBL = txtMaBL.Text;
                    string sQuery = "delete BangLuong where MaBL = @MaBL";
                    SqlCommand cmd = new SqlCommand(sQuery, con);
                    cmd.Parameters.AddWithValue("MaBL", sMaBL);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công");
                        LoadData4();
                    clearBL() ;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Xảy ra lỗi trong quá trình xóa");
                    }
                    con.Close(); //buoc 3
                }
            }

        private void Lammoi_Click(object sender, EventArgs e)
        {
            LoadData4();
            clearBL();
        }
    }
}

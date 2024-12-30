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
    public partial class frm_TaiKhoan : Form
    {
        string sCon = "Data Source=HUONGNGOC;Initial Catalog=QLNS;Integrated Security=True;Encrypt=False";
       
        public frm_TaiKhoan()
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
        public string temp;
        private void frmTaiKhoanR9_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string sQuery = "SELECT * FROM TaiKhoan"; // Câu lệnh truy vấn
                    SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    // Hiển thị dữ liệu lên DataGridView
                    dataGridView1.DataSource = dt;
                    txtMaNS.Text=temp;
                    txtMaNS.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
                }
            }
        }
        private void LoadDataTK()
        {
            // Bước 1: Kết nối cơ sở dữ liệu
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string sQuery = "select * from TaiKhoan"; // Câu lệnh truy vấn
                    SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    // Hiển thị dữ liệu lên DataGridView
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
                }
            }
        }
        private void ClearInputTK()
        {
            // Xóa nội dung các TextBox
            txtTK.Text = "";
            txtMaNS.Text = "";
            txtMK.Text = "";
            txtMaNS.Enabled = false;
            txtTK.Enabled = false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception )
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sTaiKhoan = txtTK.Text;
            string sMatKhau = txtMK.Text;
            string sMaNS = txtMaNS.Text;
            if (string.IsNullOrEmpty(sTaiKhoan) || string.IsNullOrEmpty(sMatKhau) || string.IsNullOrEmpty(sMaNS))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
                string sQuery = "insert into TaiKhoan values (@TaiKhoan, @MatKhau, @MaNS)";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@TaiKhoan", sTaiKhoan);
                cmd.Parameters.AddWithValue("@MatKhau", sMatKhau);
                cmd.Parameters.AddWithValue("@MaNS", sMaNS);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới thành công");
                    ClearInputTK();
                    LoadDataTK();
                }
                catch (SqlException )
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới!");
                }
                con.Close();
            
        }
    
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTK.Text = dataGridView1.Rows[e.RowIndex].Cells["TenTaiKhoan"].Value.ToString();
            txtMK.Text = dataGridView1.Rows[e.RowIndex].Cells["MatKhau"].Value.ToString();
            txtMaNS.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNS"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sTaiKhoan = txtTK.Text;
            string sMatKhau = txtMK.Text;
            string sMaNS = txtMaNS.Text;
            string sQuery = "update TaiKhoan set MatKhau =@Matkhau where MaNS = @MaNS";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@TaiKhoan", sTaiKhoan);
            cmd.Parameters.AddWithValue("@MatKhau", sMatKhau);
            cmd.Parameters.AddWithValue("@MaNS", sMaNS);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công");
                ClearInputTK();
                LoadDataTK();
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật !");
            }
            con.Close();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DB");
            }
            string sMaNS = txtMaNS.Text;
            string sQuery = "delete TaiKhoan where MaNS = @MaNS";
            SqlCommand cmd = new SqlCommand(@sQuery, con);
            cmd.Parameters.AddWithValue("@MaNS", sMaNS);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                ClearInputTK();
                LoadDataTK();
            }
            catch (SqlException)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình xóa !");
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearInputTK();
            LoadDataTK();
        }
    }

}


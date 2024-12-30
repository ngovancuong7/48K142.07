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
    public partial class frm_NhanSu : Form
    {
        
        string sConnect = "Data Source=HUONGNGOC;Initial Catalog=QLNS;Integrated Security=True;Encrypt=False";

        public frm_NhanSu()
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

        private void b_thoat_ns_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frm_NhanSu_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Xin chào, hẹn gặp lại lần sau!", "Thông Báo");
        }
        private void ns_clear()
        {
            // Xóa nội dung các TextBox
            txtMaNS.Text = "";
            tx_TenNS.Text = "";
            tx_SDT.Text = "";
            txtMaNS.Enabled = true;
            // Reset DateTimePicker
            tx_NgaySinh.Value = DateTime.Now;

            // Reset RadioButton
            tx_NhanVien.Checked = false;
            // Đặt "Không" là mặc định

            tx_QuanLy.Checked = false;


        }

        private void b_Luu_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Có chắn chắn thêm thông tin không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                ;
            }
            //Bước 1:
            SqlConnection connect = new SqlConnection(sConnect);
            try
            {
                connect.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối!!");
            }
            //Bước 2:
            //chbi dữ liệu
            //kiểm tra tính hợp lệ của dữ liệu
            //gán dữ liệu vào biến 
            string sMaNS = txtMaNS.Text;
            string sTenNS = tx_TenNS.Text;
            string sNgaySinh = tx_NgaySinh.Value.ToString("yyyy-MM-dd");
            string sSDT = tx_SDT.Text;
            string sChucVu = "";
            if (tx_NhanVien.Checked == true)
            {
                sChucVu = "Nhân viên";
            }
            else
            {
                sChucVu = "Quản lý";
            }
            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrEmpty(sMaNS) || string.IsNullOrEmpty(sTenNS) || string.IsNullOrEmpty(sNgaySinh) || string.IsNullOrEmpty(sSDT) || string.IsNullOrEmpty(sChucVu))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            string sQuery = ("insert into NhanSu values (@MaNS,@TenNS,@NgaySinh, @SDT, @ChucVu)");
            SqlCommand cmd = new SqlCommand(sQuery, connect);
            cmd.Parameters.AddWithValue("@MaNS", sMaNS);
            cmd.Parameters.AddWithValue("@TenNS", sTenNS);
            cmd.Parameters.AddWithValue("@NgaySinh", sNgaySinh);
            cmd.Parameters.AddWithValue("@SDT", sSDT);
            cmd.Parameters.AddWithValue("@ChucVu", sChucVu);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thông tin thành công!!");
                
                LoadData3();
                ns_clear();
                frm_TaiKhoan TK = new frm_TaiKhoan();
                TK.temp = sMaNS;
                TK.ShowDialog();
                
            
            }
            catch (Exception)
            {

                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới!!");
            }

            connect.Close();
            this.Hide();
        }


        private void frm_NhanSu_Load(object sender, EventArgs e)
        {

            //Bước 1:
            SqlConnection connect = new SqlConnection(sConnect);
            try
            {
                connect.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xảy ra lỗi khi tải dữ liệu: {ex.Message}");
            }
            // Hiển thị toàn bộ danh sách nhân sự trong DataGridView
            string sQuery = "SELECT * FROM NhanSu";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, connect);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "NhanSu");
            dataGridView3.DataSource = ds.Tables["NhanSu"];
            connect.Close();//Bước 3
            }
        private void LoadData3()
        {
            // Bước 1: Kết nối cơ sở dữ liệu
            using (SqlConnection con = new SqlConnection(sConnect))
            {
                try
                {
                    con.Open();
                    string sQuery = "SELECT * FROM NhanSu"; // Câu lệnh truy vấn
                    SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Hiển thị dữ liệu lên DataGridView
                    dataGridView3.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
                }
            }
        }

        public string temp;


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNS.Text = dataGridView3.Rows[e.RowIndex].Cells["MaNS"].Value.ToString();
            tx_TenNS.Text = dataGridView3.Rows[e.RowIndex].Cells["TenNS"].Value.ToString();
            tx_NgaySinh.Value = Convert.ToDateTime(dataGridView3.Rows[e.RowIndex].Cells["NgaySinh"].Value);
            tx_SDT.Text = dataGridView3.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
            string schucVu = dataGridView3.Rows[e.RowIndex].Cells["ChucVu"].Value.ToString();

            // Kiểm tra giá trị và gán cho checkbox tương ứng
            if (schucVu == "Nhân viên")
            {
                tx_NhanVien.Checked = true;
                tx_QuanLy.Checked = false;
            }
            else if (schucVu == "Quản lý")
            {
                tx_NhanVien.Checked = false;
                tx_QuanLy.Checked = true;
            }
            else
            {
                // Xử lý trường hợp giá trị khác
                tx_NhanVien.Checked = false;
                tx_QuanLy.Checked = false;
            }
            txtMaNS.Enabled = false;

        }

        private void b_Sua_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Có chắn chắn sửa thông tin không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                ;
            }

            //Bước 1:
            SqlConnection connect = new SqlConnection(sConnect);
            try
            {
                connect.Open();

            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối!!");
            }

            //Bước 2:
            string sMaNS = txtMaNS.Text;
            string sTenNS = tx_TenNS.Text;
            string sNgaySinh = tx_NgaySinh.Value.ToString("yyyy-MM-dd");
            string sSDT = tx_SDT.Text;
            string sChucVu = "";
            if (tx_NhanVien.Checked == true)
            {
                sChucVu = "Nhân viên";
            }
            else
            {
                sChucVu = "Quản lý";
            }

            string sQuery = "update NhanSu set TenNS = @TenNS, NgaySinh=@NgaySinh, SDT=@SDT, ChucVu=@ChucVu where MaNS=@MaNS";
            SqlCommand cmd = new SqlCommand(sQuery, connect);
            cmd.Parameters.AddWithValue("@MaNS", sMaNS);
            cmd.Parameters.AddWithValue("@TenNS", sTenNS);
            cmd.Parameters.AddWithValue("@NgaySinh", sNgaySinh);
            cmd.Parameters.AddWithValue("@SDT", sSDT);
            cmd.Parameters.AddWithValue("@ChucVu", sChucVu);
            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Sửa thành công!!", "Thông Báo");

                LoadData3();
                ns_clear();

            }
            catch (Exception)
            {

                MessageBox.Show("Xảy ra lỗi trong quá trình sửa!!");
            }
            //Bước 3:
            connect.Close();

        }

        private void b_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Có chắn chắn xoá thông tin không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                SqlConnection connect = new SqlConnection(sConnect);
                try
                {
                    connect.Open();

                    string sMaNS = txtMaNS.Text;

                    // Kiểm tra xem có bản ghi nào trong LichLamViec đang tham chiếu đến MaNS không
                    string checkLichLamViecQuery = "SELECT COUNT(*) FROM LichLamViec WHERE MaNS = @MaNS";
                    SqlCommand checkLichLamViecCmd = new SqlCommand(checkLichLamViecQuery, connect);
                    checkLichLamViecCmd.Parameters.AddWithValue("@MaNS", sMaNS);

                    int lichLamViecCount = (int)checkLichLamViecCmd.ExecuteScalar();

                    if (lichLamViecCount > 0)
                    {
                        // Xóa các bản ghi phụ thuộc trong LichLamViec trước
                        string deleteLichLamViecQuery = "DELETE FROM LichLamViec WHERE MaNS = @MaNS";
                        SqlCommand deleteLichLamViecCmd = new SqlCommand(deleteLichLamViecQuery, connect);
                        deleteLichLamViecCmd.Parameters.AddWithValue("@MaNS", sMaNS);
                        deleteLichLamViecCmd.ExecuteNonQuery();
                    }

                    // Kiểm tra và xóa các bản ghi phụ thuộc trong DongGopYeuCau
                    string checkDongGopYeuCauQuery = "SELECT COUNT(*) FROM DongGopYeuCau WHERE MaNS = @MaNS";
                    SqlCommand checkDongGopYeuCauCmd = new SqlCommand(checkDongGopYeuCauQuery, connect);
                    checkDongGopYeuCauCmd.Parameters.AddWithValue("@MaNS", sMaNS);

                    int dongGopYeuCauCount = (int)checkDongGopYeuCauCmd.ExecuteScalar();

                    if (dongGopYeuCauCount > 0)
                    {
                        string deleteDongGopYeuCauQuery = "DELETE FROM DongGopYeuCau WHERE MaNS = @MaNS";
                        SqlCommand deleteDongGopYeuCauCmd = new SqlCommand(deleteDongGopYeuCauQuery, connect);
                        deleteDongGopYeuCauCmd.Parameters.AddWithValue("@MaNS", sMaNS);
                        deleteDongGopYeuCauCmd.ExecuteNonQuery();
                    }

                    // Kiểm tra và xóa các bản ghi phụ thuộc trong TaiKhoan
                    string checkTaiKhoanQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE MaNS = @MaNS";
                    SqlCommand checkTaiKhoanCmd = new SqlCommand(checkTaiKhoanQuery, connect);
                    checkTaiKhoanCmd.Parameters.AddWithValue("@MaNS", sMaNS);

                    int taiKhoanCount = (int)checkTaiKhoanCmd.ExecuteScalar();

                    if (taiKhoanCount > 0)
                    {
                        string deleteTaiKhoanQuery = "DELETE FROM TaiKhoan WHERE MaNS = @MaNS";
                        SqlCommand deleteTaiKhoanCmd = new SqlCommand(deleteTaiKhoanQuery, connect);
                        deleteTaiKhoanCmd.Parameters.AddWithValue("@MaNS", sMaNS);
                        deleteTaiKhoanCmd.ExecuteNonQuery();
                    }

                    // Kiểm tra và xóa các bản ghi phụ thuộc trong BangLuong
                    string checkBangLuongQuery = "SELECT COUNT(*) FROM BangLuong WHERE MaNS = @MaNS";
                    SqlCommand checkBangLuongCmd = new SqlCommand(checkBangLuongQuery, connect);
                    checkBangLuongCmd.Parameters.AddWithValue("@MaNS", sMaNS);

                    int bangLuongCount = (int)checkBangLuongCmd.ExecuteScalar();

                    if (bangLuongCount > 0)
                    {
                        string deleteBangLuongQuery = "DELETE FROM BangLuong WHERE MaNS = @MaNS";
                        SqlCommand deleteBangLuongCmd = new SqlCommand(deleteBangLuongQuery, connect);
                        deleteBangLuongCmd.Parameters.AddWithValue("@MaNS", sMaNS);
                        deleteBangLuongCmd.ExecuteNonQuery();
                    }

                    // Cuối cùng xóa bản ghi trong NhanSu
                    string deleteNhanSuQuery = "DELETE FROM NhanSu WHERE MaNS = @MaNS";
                    SqlCommand deleteNhanSuCmd = new SqlCommand(deleteNhanSuQuery, connect);
                    deleteNhanSuCmd.Parameters.AddWithValue("@MaNS", sMaNS);
                    deleteNhanSuCmd.ExecuteNonQuery();

                    MessageBox.Show("Xoá thông tin thành công!!");
                    LoadData3();
                    ns_clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình xoá: " + ex.Message);
                }
                finally
                {
                    connect.Close();
                }

            }
        }

        private void LamMoi_Click(object sender, EventArgs e)
        {
            LoadData3();
            ns_clear();
        }
    }
}

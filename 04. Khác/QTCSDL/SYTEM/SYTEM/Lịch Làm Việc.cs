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
    public partial class frm_LichLamViec : Form
    {
        string sCon = "Data Source=HUONGNGOC;Initial Catalog=QLNS;Integrated Security=True;Encrypt=False";
        public frm_LichLamViec()
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
        private void frmLichLamViec_FormClosing(object sender, FormClosingEventArgs e)
        {

            MessageBox.Show("Hẹn gặp lại!", "Thong bao");
        }
        private void LoadData2()
        {
            // Bước 1: Kết nối cơ sở dữ liệu
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string sQuery = "SELECT * FROM LichLamViec"; // Câu lệnh truy vấn
                    SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Hiển thị dữ liệu lên DataGridView
                    dataGridView2.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
                }
            }
        }
        private void ClearInput()
        {
            // Xóa nội dung các TextBox
            txtMaLLV.Text = "";
            txtMaNS.Text = "";
            txtGioVaoLam.Text = "";
            txtGioTanLam.Text = "";
            txtCheckIn.Text = "";
            txtCheckOut.Text = "";
            txtNoiDungNghiPhep.Text = "";
            txtSoTienPhat.Text = ""; // Đặt giá trị mặc định là 0
            txtSoTienThuong.Text = ""; // Đặt giá trị mặc định là 0
            txtMaLLV.Enabled = true;
            txtMaNS.Enabled = true;
            // Reset DateTimePicker
            dtpNgayLam.Value = DateTime.Now;

            // Reset RadioButton
            rbCo.Checked = false;
            rbKhong.Checked = false; // Đặt "Không" là mặc định

            rbCo1.Checked = false;
            rbKhong1.Checked = false; // Đặt "Không" là mặc định

            rbCo2.Checked = false;
            rbKhong2.Checked = false; // Đặt "Không" là mặc định
        }
        private bool ValidateInput()
        {
            // Kiểm tra các trường không được bỏ trống
            if (string.IsNullOrWhiteSpace(txtMaLLV.Text))
            {
                MessageBox.Show("Mã lịch làm việc không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLLV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMaNS.Text))
            {
                MessageBox.Show("Mã nhân sự không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNS.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGioVaoLam.Text))
            {
                MessageBox.Show("Giờ vào làm không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGioVaoLam.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGioTanLam.Text))
            {
                MessageBox.Show("Giờ tan làm không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGioTanLam.Focus();
                return false;
            }
            //if (string.IsNullOrWhiteSpace(txtCheckIn.Text))
            //{
            //    MessageBox.Show("Giờ check-in không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtCheckIn.Focus();
            //    return false;
            //}
            //if (string.IsNullOrWhiteSpace(txtCheckOut.Text))
            //{
            //    MessageBox.Show("Giờ check-out không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtCheckOut.Focus();
            //    return false;
            //}
            // Kiểm tra ngày làm không được nhỏ hơn ngày hiện tại
            if (dtpNgayLam.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Ngày làm không được là ngày trong quá khứ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayLam.Focus();
                return false;
            }
            // Kiểm tra định dạng thời gian (HH:mm:ss)
            TimeSpan timeResult;
            if (!TimeSpan.TryParse(txtGioVaoLam.Text, out timeResult))
            {
                MessageBox.Show("Giờ vào làm không đúng định dạng! Vui lòng nhập theo định dạng HH:mm:ss.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGioVaoLam.Focus();
                return false;
            }
            if (!TimeSpan.TryParse(txtGioTanLam.Text, out timeResult))
            {
                MessageBox.Show("Giờ tan làm không đúng định dạng! Vui lòng nhập theo định dạng HH:mm:ss.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGioTanLam.Focus();
                return false;
            }
            //if (!TimeSpan.TryParse(txtCheckIn.Text, out timeResult))
            //{
            //    MessageBox.Show("Giờ check-in không đúng định dạng! Vui lòng nhập theo định dạng HH:mm:ss.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtCheckIn.Focus();
            //    return false;
            //}
            //if (!TimeSpan.TryParse(txtCheckOut.Text, out timeResult))
            //{
            //    MessageBox.Show("Giờ check-out không đúng định dạng! Vui lòng nhập theo định dạng HH:mm:ss.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtCheckOut.Focus();
            //    return false;
            //}
            // Kiểm tra radio button Xin nghỉ phép
            if (!rbCo.Checked && !rbKhong.Checked)
            {
                MessageBox.Show("Bạn phải chọn Có hoặc Không cho trường 'Xin nghỉ phép'!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //// Kiểm tra số tiền phạt không được để trống và không âm
            //if (string.IsNullOrWhiteSpace(txtSoTienPhat.Text))
            //{
            //    MessageBox.Show("Số tiền phạt không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtSoTienPhat.Focus();
            //    return false;
            //}
            //decimal soTienPhat;
            //if (!decimal.TryParse(txtSoTienPhat.Text, out soTienPhat) || soTienPhat < 0)
            //{
            //    MessageBox.Show("Số tiền phạt phải là số không âm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtSoTienPhat.Focus();
            //    return false;
            //}

            //// Kiểm tra số tiền thưởng không được để trống và không âm
            //if (string.IsNullOrWhiteSpace(txtSoTienThuong.Text))
            //{
            //    MessageBox.Show("Số tiền thưởng không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtSoTienThuong.Focus();
            //    return false;
            //}
            //decimal soTienThuong;
            //if (!decimal.TryParse(txtSoTienThuong.Text, out soTienThuong) || soTienThuong < 0)
            //{
            //    MessageBox.Show("Số tiền thưởng phải là số không âm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtSoTienThuong.Focus();
            //    return false;
            //}


            // Kiểm tra radio button Bị phạt
            if (!rbCo1.Checked && !rbKhong1.Checked)
            {
                MessageBox.Show("Bạn phải chọn Có hoặc Không cho trường 'Bị phạt'!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra radio button Được thưởng
            if (!rbCo2.Checked && !rbKhong2.Checked)
            {
                MessageBox.Show("Bạn phải chọn Có hoặc Không cho trường 'Được thưởng'!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Tất cả dữ liệu đều hợp lệ
            return true;
        }


        private void frmLichLamViec_Load(object sender, EventArgs e)
        {
            //Buoc 1
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trinh kết nối DB");
            }
            //Buoc 2 
            string sQuery = "select * from LichLamViec";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "LichLamViec");

            dataGridView2.DataSource = ds.Tables["LichLamViec"];
            con.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }
            //Buoc 1 
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception  )
            {
                MessageBox.Show("Xảy ra lỗi trong quá trinh kết nối DB");
            }
            //Buoc 2.1: Chuẩn bị dữ liệu (kiểm tra tính hợp lệ)
            //Buoc 2.2: Gán dữ liệu vào biến 
            string sMaLLV = txtMaLLV.Text;
            string sNgayLam = dtpNgayLam.Value.ToString("yyyy-MM-dd");
            string sGioVaoLam = txtGioVaoLam.Text;
            string sGioTanLam = txtGioTanLam.Text;
            string sCheckIn = txtCheckIn.Text;
            string sCheckOut = txtCheckOut.Text;
            int iXinNghiPhep = 0;
            if (rbCo.Checked == true)
            {
                iXinNghiPhep = 1;
            }
            string sNoiDungNghiPhep = txtNoiDungNghiPhep.Text;
            int iBiPhat = 0;
            if (rbCo1.Checked == true)
            {
                iBiPhat = 1;
            }
            string sSoTienPhat = txtSoTienPhat.Text;
            int iDuocThuong = 0;
            if (rbCo2.Checked == true)
            {
                iDuocThuong = 1;
            }
            string sSoTienThuong = txtSoTienThuong.Text;
            string sMaNS = txtMaNS.Text;

            //Buoc 2.3: Khởi tạo SqlCommand 
            string sQuery = "insert into LichLamViec (MaLLV, NgayLam, GioVaoLam, GioTanLam, CheckIn, CheckOut, XinNghiPhep, NoiDungNghiPhep, BiPhat, SoTienPhat, DuocThuong, SoTienThuong, MaNS) values (@MaLLV, @NgayLam, @GioVaoLam, @GioTanLam, @CheckIn, @CheckOut, @XinNghiPhep, @NoiDungNghiPhep, @BiPhat, @SoTienPhat, @DuocThuong, @SoTienThuong, @MaNS)";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaLLV", sMaLLV);
            cmd.Parameters.AddWithValue("@NgayLam", sNgayLam);
            cmd.Parameters.AddWithValue("@GioVaoLam", sGioVaoLam);
            cmd.Parameters.AddWithValue("@GioTanLam", sGioTanLam);
            cmd.Parameters.AddWithValue("@CheckIn", sCheckIn);
            cmd.Parameters.AddWithValue("@CheckOut", sCheckOut);
            cmd.Parameters.AddWithValue("@XinNghiPhep", iXinNghiPhep);
            cmd.Parameters.AddWithValue("@NoiDungNghiPhep", sNoiDungNghiPhep);
            cmd.Parameters.AddWithValue("@BiPhat", iBiPhat);
            cmd.Parameters.AddWithValue("@SoTienPhat", sSoTienPhat);
            cmd.Parameters.AddWithValue("@DuocThuong", iDuocThuong);
            cmd.Parameters.AddWithValue("@SoTienThuong", sSoTienThuong);
            cmd.Parameters.AddWithValue("@MaNS", sMaNS);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công");
                LoadData2();
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm mới: " + ex.Message);
            }
            con.Close(); //Buoc 3 

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLLV.Text = dataGridView2.Rows[e.RowIndex].Cells["MaLLV"].Value.ToString();
            txtMaNS.Text = dataGridView2.Rows[e.RowIndex].Cells["MaNS"].Value.ToString();
            dtpNgayLam.Value = Convert.ToDateTime(dataGridView2.Rows[e.RowIndex].Cells["NgayLam"].Value);
            txtGioVaoLam.Text = dataGridView2.Rows[e.RowIndex].Cells["GioVaoLam"].Value.ToString();
            txtGioTanLam.Text = dataGridView2.Rows[e.RowIndex].Cells["GioTanLam"].Value.ToString();
            txtCheckIn.Text = dataGridView2.Rows[e.RowIndex].Cells["CheckIn"].Value.ToString();
            txtCheckOut.Text = dataGridView2.Rows[e.RowIndex].Cells["CheckOut"].Value.ToString();
            int iXinNghiPhep = Convert.ToInt16(dataGridView2.Rows[e.RowIndex].Cells["XinNghiPhep"].Value);
            if (iXinNghiPhep == 1)
            {
                rbCo.Checked = true;
            }
            else
            {
                rbKhong.Checked = true;
            }
            txtNoiDungNghiPhep.Text = dataGridView2.Rows[e.RowIndex].Cells["NoiDungNghiPhep"].Value.ToString();
            int iBiPhat = Convert.ToInt16(dataGridView2.Rows[e.RowIndex].Cells["BiPhat"].Value);
            if (iBiPhat == 1)
            {
                rbCo1.Checked = true;
            }
            else
            {
                rbKhong1.Checked = true;
            }
            txtSoTienPhat.Text = dataGridView2.Rows[e.RowIndex].Cells["SoTienPhat"].Value.ToString();
            int iDuocThuong = Convert.ToInt16(dataGridView2.Rows[e.RowIndex].Cells["DuocThuong"].Value);
            if (iDuocThuong == 1)
            {
                rbCo2.Checked = true;
            }
            else
            {
                rbKhong2.Checked = true;
            }
            txtSoTienThuong.Text = dataGridView2.Rows[e.RowIndex].Cells["SoTienThuong"].Value.ToString();
            txtMaLLV.Enabled = false;
            txtMaNS.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }
            //Buoc 1 
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trinh kết nối DB");
            }
            //Buoc 2.1: Chuẩn bị dữ liệu (kiểm tra tính hợp lệ)
            //Buoc 2.2: Gán dữ liệu vào biến 
            string sMaLLV = txtMaLLV.Text;
            string sNgayLam = dtpNgayLam.Value.ToString("yyyy-MM-dd");
            string sGioVaoLam = txtGioVaoLam.Text;
            string sGioTanLam = txtGioTanLam.Text;
            string sCheckIn = txtCheckIn.Text;
            string sCheckOut = txtCheckOut.Text;
            int iXinNghiPhep = 0;
            if (rbCo.Checked == true)
            {
                iXinNghiPhep = 1;
            }
            string sNoiDungNghiPhep = txtNoiDungNghiPhep.Text;
            int iBiPhat = 0;
            if (rbCo1.Checked == true)
            {
                iBiPhat = 1;
            }
            string sSoTienPhat = txtSoTienPhat.Text;
            int iDuocThuong = 0;
            if (rbCo2.Checked == true)
            {
                iDuocThuong = 1;
            }
            string sSoTienThuong = txtSoTienThuong.Text;
            string sMaNS = txtMaNS.Text;

            //Buoc 2.3: Khởi tạo SqlCommand 
            string sQuery = "update LichLamViec set NgayLam = @NgayLam, GioVaoLam = @GioVaoLam, " +
                "GioTanLam = @GioTanLam, CheckIn = @CheckIn, CheckOut = @CheckOut, XinNghiPhep = @XinNghiPhep," +
                " NoiDungNghiPhep = @NoiDungNghiPhep, BiPhat = @BiPhat, SoTienPhat = @SoTienPhat, DuocThuong = @DuocThuong, " +
                "SoTienThuong = @SoTienThuong " +
                "where MaLLV = @MaLLV and MaNS = @MaNS";
            SqlCommand cmd = new SqlCommand(sQuery, con);
            cmd.Parameters.AddWithValue("@MaLLV", sMaLLV);
            cmd.Parameters.AddWithValue("@NgayLam", sNgayLam);
            cmd.Parameters.AddWithValue("@GioVaoLam", sGioVaoLam);
            cmd.Parameters.AddWithValue("@GioTanLam", sGioTanLam);
            cmd.Parameters.AddWithValue("@CheckIn", sCheckIn);
            cmd.Parameters.AddWithValue("@CheckOut", sCheckOut);
            cmd.Parameters.AddWithValue("@XinNghiPhep", iXinNghiPhep);
            cmd.Parameters.AddWithValue("@NoiDungNghiPhep", sNoiDungNghiPhep);
            cmd.Parameters.AddWithValue("@BiPhat", iBiPhat);
            cmd.Parameters.AddWithValue("@SoTienPhat", sSoTienPhat);
            cmd.Parameters.AddWithValue("@DuocThuong", iDuocThuong);
            cmd.Parameters.AddWithValue("@SoTienThuong", sSoTienThuong);
            cmd.Parameters.AddWithValue("@MaNS", sMaNS);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công");
                LoadData2();
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình cập nhật: " + ex.Message);
            }

            con.Close(); //Buoc 3 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {

                //Buoc 1 
                SqlConnection con = new SqlConnection(sCon);
                try
                {
                    con.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trinh kết nối DB");
                }
                //Buoc 2.1: Gán dữ liệu vào biến 
                string sMaLLV = txtMaLLV.Text;
                string sMaNS = txtMaNS.Text;

                //Buoc 2.2: Khởi tạo SqlCommand 
                string sQuery = "delete LichLamViec where MaLLV = @MaLLV and MaNS = @MaNS";
                SqlCommand cmd = new SqlCommand(sQuery, con);
                cmd.Parameters.AddWithValue("@MaLLV", sMaLLV);
                cmd.Parameters.AddWithValue("@MaNS", sMaNS);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xoá thành công");
                    LoadData2(); ClearInput();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình xóa: " + ex.Message);
                }

                con.Close(); //Buoc 3 
            }
        }

        private void bLamMoi_Click(object sender, EventArgs e)
        {
            LoadData2(); ClearInput();
        }
    }
}



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
    public partial class frm_DGYC : Form
    {
        string sCon = "Data Source=HUONGNGOC;Initial Catalog=QLNS;Integrated Security=True;Encrypt=False";

        public frm_DGYC()
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
        private void LoadData5()
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
                string sQuery = "SELECT * FROM DongGopYeuCau";
                SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "DongGopYeuCau");

                dataGridView5.DataSource = ds.Tables["DongGopYeuCau"];
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối!!!");
            }
            finally
            {
                con.Close();
            }
        }
        private void frmDongGopYeuCau_Load(object sender, EventArgs e)
        {
            LoadData5();
        }
        private void ClearInputFields()
        {
            txtMaDGYC.Text = "";
            txtNoiDung.Text = "";
            txtMaNS.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            txtMaDGYC.Enabled = true;
            txtMaNS.Enabled = true;
            txtNoiDung.Enabled = true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string sMaDongGopYeuCau = txtMaDGYC.Text;
                    string sNgayGui = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    string sMaNhanSu = txtMaNS.Text;
                    string sNoiDung = txtNoiDung.Text;

                    string sQuery = "INSERT INTO DongGopYeuCau VALUES (@MaDongGopYeuCau, @NoiDung, @NgayGui, @MaNS)";
                    SqlCommand cmd = new SqlCommand(sQuery, con);

                    cmd.Parameters.AddWithValue("@MaDongGopYeuCau", sMaDongGopYeuCau);
                    cmd.Parameters.AddWithValue("@NoiDung", sNoiDung);
                    cmd.Parameters.AddWithValue("@NgayGui", sNgayGui);
                    cmd.Parameters.AddWithValue("@MaNS", sMaNhanSu);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm mới không thành công: " + ex.Message);
                }
                finally
                {
                    con.Close();
                    LoadData5(); // Tải lại dữ liệu
                    ClearInputFields(); // Xóa các ô nhập liệu
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDGYC.Text = dataGridView5.Rows[e.RowIndex].Cells["MaDongGopYeuCau"].Value.ToString();
            txtNoiDung.Text = dataGridView5.Rows[e.RowIndex].Cells["NoiDung"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView5.Rows[e.RowIndex].Cells["NgayGui"].Value);
            txtMaNS.Text = dataGridView5.Rows[e.RowIndex].Cells["MaNS"].Value.ToString();
            txtMaDGYC.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string sMaDGYC = txtMaDGYC.Text;
                    string sNoiDung = txtNoiDung.Text;
                    string sNgayGui = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    string sMaNS = txtMaNS.Text;

                    string sQuery = "UPDATE DongGopYeuCau SET NoiDung = @NoiDung, NgayGui = @NgayGui, MaNS = @MaNS WHERE MaDongGopYeuCau = @MaDGYC";
                    SqlCommand cmd = new SqlCommand(sQuery, con);

                    cmd.Parameters.AddWithValue("@MaDGYC", sMaDGYC);
                    cmd.Parameters.AddWithValue("@NoiDung", sNoiDung);
                    cmd.Parameters.AddWithValue("@NgayGui", sNgayGui);
                    cmd.Parameters.AddWithValue("@MaNS", sMaNS);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
                }
                finally
                {
                    con.Close();
                    LoadData5(); // Tải lại dữ liệu
                    ClearInputFields(); // Xóa các ô nhập liệu
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                using (SqlConnection con = new SqlConnection(sCon))
                {
                    try
                    {
                        con.Open();
                        string sMaDCYC = txtMaDGYC.Text;

                        string sQuery = "DELETE FROM DongGopYeuCau WHERE MaDongGopYeuCau = @MaDGYC";
                        SqlCommand cmd = new SqlCommand(sQuery, con);
                        cmd.Parameters.AddWithValue("@MaDGYC", sMaDCYC);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                        LoadData5(); // Tải lại dữ liệu
                        ClearInputFields(); // Xóa các ô nhập liệu
                    }
                }
            }
        }

        private void b_lammoi_Click(object sender, EventArgs e)
        {
            LoadData5(); // Tải lại dữ liệu
            ClearInputFields(); // Xóa các ô nhập liệu
        }
    }
}

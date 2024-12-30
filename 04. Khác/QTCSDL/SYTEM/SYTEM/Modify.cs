using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SYTEM
{
    class Modify
    {

        public Modify()
        { }
        SqlCommand sqlCommand; //dung truy van cac cau lenh
        SqlDataReader dataReader;// dung de doc du lieu trong bang
        public List<TaiKhoan> TaiKhoans(string sQuery)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(sQuery, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return taiKhoans;
        }
        public List<NhanSu> NhanSus(string sQuery)
        {
            {
                List<NhanSu> nhanSus = new List<NhanSu>();

                using (SqlConnection sqlConnection = connection.GetSqlConnection())
                {
                
                        sqlConnection.Open();
                        sqlCommand = new SqlCommand(sQuery, sqlConnection);
                        dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            nhanSus.Add( new NhanSu(
                                dataReader.GetString(0), // MaNhanSu
                                dataReader.GetString(1), // TenNhanSu
                                dataReader.GetString(4)  // ChucVu
                            ));
                        }
                        sqlConnection.Close();
                    }
                return nhanSus;
            }
        }

    
    }
}

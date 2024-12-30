using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYTEM
{
    class TaiKhoan
    {
        private string TenTaiKhoan;
        private string MatKhau;
        private string MaNS;

        public TaiKhoan()
        {
        }

        public TaiKhoan(string v1, string v2)
        {
        }

        public TaiKhoan(string tenTaiKhoan, string matKhau, string maNS)
        {
            TenTaiKhoan = tenTaiKhoan;
            MatKhau = matKhau;
            MaNS = maNS;
        }


        public string TenTaiKhoan1 { get => TenTaiKhoan; set => TenTaiKhoan = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
        public string MaNS1 {  get => MaNS; set => MaNS = value; } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYTEM
{
    class NhanSu
    {

        private string MaNS;
        private string TenNS;
        private string ChucVu;

        public NhanSu(string maNS, string tenNS, string chucVu)
        {
            MaNS = maNS;
            TenNS = tenNS;
            ChucVu = chucVu;
        }

        public string MaNS1 { get => MaNS; set => MaNS = value; }
        public string TenNS1 { get => TenNS; set => TenNS = value; }
        public string ChucVu1 { get => ChucVu; set => ChucVu = value; }
    }


}
  
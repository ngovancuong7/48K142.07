using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SYTEM
{
    internal class connection
    {
        private static string sCon = "Data Source=HUONGNGOC;Initial Catalog=QLNS;Integrated Security=True;Encrypt=False";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(sCon);
        }
    }
}

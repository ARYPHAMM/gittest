using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSuaDAO
{
    public class DataProvider
    {
        private static string strKetNoi  = @"Data Source = .; Initial Catalog = CuaHangBanSua; Integrated Security = true;";

        public static SqlConnection TaoKetNoi()
        {
            SqlConnection conn = new SqlConnection(strKetNoi);
            conn.Open();
            return conn;
        }

        public static  SqlDataReader TruyVanDuLieu(string strTruyVan, SqlConnection con)
        {
            SqlCommand com = new SqlCommand(strTruyVan, con);
            return com.ExecuteReader();
        }
        public static bool ThucThiCauLenh(string strcaulenh, SqlParameter[] arrparamas, SqlConnection ketnoi)

        {
            SqlCommand com = new SqlCommand(strcaulenh, ketnoi);
            com.Parameters.AddRange(arrparamas.ToArray());
            int ketqua = com.ExecuteNonQuery();
            if(ketqua > 0)
             return true;
            return false;
        }

    }
}

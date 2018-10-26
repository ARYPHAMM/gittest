using QLCuaHangSuaDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSuaDAO
{
    public class LoaiSuaDAO
    {
       

        public List<LoaiSuaDTO> LayDanhSachLoaiSua()
        {
            List<LoaiSuaDTO> lsKetQua = new List<LoaiSuaDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From LoaiSua Where TrangThai = 1";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan,conn);
            while(sdr.Read())
            {
                LoaiSuaDTO loai = new LoaiSuaDTO
                    {
                        MaLoai = (int)sdr["MaLoai"],
                        TenLoai = sdr["TenLoai"].ToString(),
                        TrangThai = int.Parse(sdr["TrangThai"].ToString())
                    };
                lsKetQua.Add(loai);
            }

            sdr.Close();
            conn.Close();


            return lsKetQua;
        }
    }
}

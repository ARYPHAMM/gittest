using QLCuaHangSuaDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSuaDAO
{
    public class SanPhamSuaDAO
    {
        public string LayMaSanPhamLonNhat()
        {
            string strtruyvan = "Select max(MaSua) From SanPhamSua";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strtruyvan, conn);

            string masuamax = null;
            if (sdr.Read())
            {
                masuamax = sdr[0].ToString();
                return masuamax;
                
            }
            sdr.Close();
            conn.Close();
            return masuamax;
           


        }
        public List<SanPhamSuaDTO> LayDanhSachSanPhamSua()
        {
            List<SanPhamSuaDTO> lsKetQua = new List<SanPhamSuaDTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            string strTruyVan = "Select * From SanPhamSua Where TrangThai = 1";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            while (sdr.Read())
            {
                SanPhamSuaDTO sua = new SanPhamSuaDTO();
                sua.MaSua = sdr.GetString(sdr.GetOrdinal("MaSua"));
                sua.TenSua = sdr.GetString(sdr.GetOrdinal("TenSua"));
                sua.HinhAnh = sdr["HinhAnh"].ToString();
                sua.MoTa = sdr["MoTa"].ToString();
                sua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                sua.GiaBan = int.Parse(sdr["GiaBan"].ToString());
                sua.MaLoai = (int)sdr["MaLoai"];
                sua.NhaSanXuat = sdr["NhaSanXuat"].ToString();
                lsKetQua.Add(sua);
            }

            sdr.Close();
            conn.Close();

            return lsKetQua;
        }
        public bool ThemMoiSanPhamSua(SanPhamSuaDTO suachon)
        {
            string insert = "Insert into SanPhamSua(MaSua,TenSua,GiaBan,"
                                     + "MaLoai,HinhAnh,NhaSanXuat,MoTa,TrangThai)values("
                                     + "@MaSua,@TenSua,@GiaBan,"
                                      + "@MaLoai,@HinhAnh,@NhaSanXuat,@MoTa,'1')";
            //SqlParameter[] arrParams = new SqlParameter[7];
            string gia = null;
            foreach (char a in suachon.GiaBan.ToString())
            {
                if(a.ToString() != "V" || a.ToString() != "N" || a.ToString() != "Đ")
                {
                    gia += a;
                }
            }
            
            List<SqlParameter> lsparams = new List<SqlParameter>();
            lsparams.Add(new SqlParameter("@MaSua", suachon.MaSua));
            lsparams.Add(new SqlParameter("@TenSua", suachon.TenSua));
            lsparams.Add(new SqlParameter("@GiaBan", gia));
            lsparams.Add(new SqlParameter("@MaLoai", suachon.MaLoai));
            lsparams.Add(new SqlParameter("@HinhAnh", suachon.HinhAnh));
            lsparams.Add(new SqlParameter("@NhaSanXuat", suachon.NhaSanXuat));
            lsparams.Add(new SqlParameter("@MoTa", suachon.MoTa));
        
            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThiCauLenh(insert, lsparams.ToArray(), con);
            con.Close();
            return thucthi;
        }
    }
}

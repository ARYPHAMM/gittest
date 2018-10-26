using QLCuaHangSuaDAO;
using QLCuaHangSuaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSuaBUS
{
    public class SanPhamSuaBUS
    {
        public List<SanPhamSuaDTO> DanhSachSua()
        {
            SanPhamSuaDAO suaDAO = new SanPhamSuaDAO();
            return suaDAO.LayDanhSachSanPhamSua();
        }
        public string MaSuaTiepTheo()
        {
            SanPhamSuaDAO suaDAO = new SanPhamSuaDAO();
            string MaSPLonNhat =  suaDAO.LayMaSanPhamLonNhat();
            if(string.IsNullOrEmpty(MaSPLonNhat))
            {
                return "S0001";

            }
            else
            {
                int masotiep = int.Parse(MaSPLonNhat.Substring(1));/*MaSPLonNhat.Replace('S', '')*/
                //return string.Format("S{0:4}", masotiep + 1);
                return "S" +(masotiep + 1).ToString("0000");
            }
        }
        public bool ThemSua(SanPhamSuaDTO a)
        {
            SanPhamSuaDAO spdao = new SanPhamSuaDAO();
           return   spdao.ThemMoiSanPhamSua(a);
 
        }
    }
}

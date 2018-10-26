using QLCuaHangSuaDAO;
using QLCuaHangSuaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSuaBUS
{
    public class LoaiSuaBUS
    {
        public List<LoaiSuaDTO> DanhSachLoaiSua()
        {
            LoaiSuaDAO loaisuaDAO = new LoaiSuaDAO();
            return loaisuaDAO.LayDanhSachLoaiSua();
        }
    }
}

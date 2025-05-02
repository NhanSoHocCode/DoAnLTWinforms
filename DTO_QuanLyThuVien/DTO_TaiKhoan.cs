using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO_QuanLyThuVien
{
    public class DTO_TaiKhoan
    {
        public string sTenTK { get; set; }
        public string sMatKhau { get; set; }
        public int sMaQuyen { get; set; }
        public string email { get; set; }
        public string  anhthe { get; set; } 
        public DateTime  createTime { get; set; }
    }
}

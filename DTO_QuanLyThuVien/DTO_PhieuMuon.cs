using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO_QuanLyThuVien
{
    public class DTO_PhieuMuon
    {
        public int sMaPhieuMuon { get; set; }
        public int sMaDocGia { get; set; }
        public DateTime sNgayMuon { get; set; }
        public DateTime sNgayTra { get; set; }
        public int sMaThuThu { get; set; }
        public int sTrangThai { get; set; }
        public string sTenDocGia { get; set; }
        public string sTenThuThu { get; set; }
    }
    

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyThuVien;
using DAL_QuanLyThuVien;
using System.Net.Mail;
using System.Net;

namespace BLL_QuanLyThuVien
{
    public class BLL_TaiKhoan
    {
        DAL_TaiKhoanAccess dal_taikhoan = new DAL_TaiKhoanAccess();
        public string CheckeLogin(DTO_TaiKhoan taikhoan)
        {
            if (taikhoan.sTenTK == "")
            {
                return "Vui long nhap ten tai khoan!";
            }
            if (taikhoan.sMatKhau == "")
            {
                return "Vui long nhap mat khau!";
            }
            string info = dal_taikhoan.CheckeLogin(taikhoan);
            return info;
        }
        // quen mat khau thi goi ve mail
        public void SendMailPassWord(string username) // neu muon sai code nay thi chuyen mail/pass qua cua minh nho bat tinh nang truy cap khong an toan 
        {
            DTO_TaiKhoan tk  = dal_taikhoan.GetMail(username);
            string from = "23110279@student.hcmute.edu.vn"; // doi tai day
            string passfrom = "NgocNhan2711#"; // day nua 
            MailMessage mail = new MailMessage();
            mail.To.Add(tk.email);
            mail.From = new MailAddress(from); mail.Subject = "Quen mat khau";
            mail.Body = "Mat khau cua ban la: " + tk.sMatKhau;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, passfrom);
            smtp.Send(mail);
        }
    }
}

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
        public string ChangePassByOTP(string tk, int OTP)
        {
            if (tk == null)
            {
                return "Vui long nhap email!";
            }
            else
            {
                return dal_taikhoan.DoiMatKhauBangOTP(tk, OTP);
            }
        }
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
        public int SendMailPassWord(string email) // neu muon sai code nay thi chuyen mail/pass qua cua minh nho bat tinh nang truy cap khong an toan 
        {
            if( email == "")
            {
                return 0;
            }
            else // them chuc nang kiem tra mail co ton tai khong ? ----------------
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(1000, 10000); // Tạo số ngẫu nhiên từ 1000 đến 9999
                string from = "23110279@student.hcmute.edu.vn"; // doi tai day
                string passfrom = "NgocNhan2711#"; // day nua 
                MailMessage mail = new MailMessage();
                mail.To.Add(email);
                mail.From = new MailAddress(from); mail.Subject = "Thay đổi mật khẩu tài khoản thư viện";
                mail.Body = "Mã OOP của bạn: " + randomNumber;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, passfrom);
                smtp.Send(mail);
                return randomNumber;
            }
        }
    }
}

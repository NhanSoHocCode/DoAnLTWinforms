using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyThuVien;
using DAL_QuanLyThuVien;
using System.Net.Mail;
using System.Net;

namespace BLL_QuanLyThuVien.APIs
{
    public class API_XacThucMail
    {
        public int SendMailPassWord(string email) // neu muon sai code nay thi chuyen mail/pass qua cua minh nho bat tinh nang truy cap khong an toan 
        {
            if (email == "")
            {
                return 0;
            }
            else // them chuc nang kiem tra mail co ton tai khong ? ----------------
            {
                try {
                    Random rnd = new Random();
                    int randomNumber = rnd.Next(1000, 10000); // Tạo số ngẫu nhiên từ 1000 đến 9999
                    string from = "23110279@student.hcmute.edu.vn"; // doi tai day
                    string passfrom = "Ngocnhan2711#"; // day nua 
                    MailMessage mail = new MailMessage();
                    mail.To.Add(email);
                    mail.From = new MailAddress(from); mail.Subject = "Thay đổi mật khẩu tài khoản thư viện";
                    mail.Body = "Mã OTP của bạn: " + randomNumber;
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, passfrom);
                    smtp.Send(mail);
                    return randomNumber;   
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }
    }
}

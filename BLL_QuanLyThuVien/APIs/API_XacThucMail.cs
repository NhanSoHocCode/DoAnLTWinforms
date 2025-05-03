using System;
using System.Net;
using System.Net.Mail;

namespace BLL_QuanLyThuVien.APIs
{
    public class API_XacThucMail
    {
        // Configuration - these should ideally come from a config file or environment variables
        private const string FromEmail = "dangngocnhan27@gmail.com";
        private const string FromPassword = "zmrh bfga mbaw mifg"; // Use app-specific password
        private const string SmtpHost = "smtp.gmail.com";
        private const int SmtpPort = 587;

        public int SendMailPassWord(string email, Boolean forgot)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return 0;
            }

            try
            {
                // Generate secure OTP
                Random rnd = new Random();
                int otp = rnd.Next(1000, 10000);

                // Configure and send email
                using (MailMessage mail = new MailMessage())
                {
                    mail.To.Add(email);
                    mail.From = new MailAddress(FromEmail);
                    if (forgot)
                    {
                        mail.Subject = "Thay đổi mật khẩu tài khoản thư viện";
                    } else
                    {
                        mail.Subject = "Xác nhận mail để tiếp tục đăng ký tài khoản mới";
                    }
                    mail.Body = $"Mã OTP của bạn: {otp}";

                    using (SmtpClient smtp = new SmtpClient(SmtpHost))
                    {
                        smtp.Port = SmtpPort;
                        smtp.EnableSsl = true;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Credentials = new NetworkCredential(FromEmail, FromPassword);
                        smtp.Send(mail);
                    }
                }

                Console.WriteLine($"Gửi email thành công tới {email}. OTP: {otp}");
                return otp;
            }
            catch (SmtpException ex)
            {
                Console.WriteLine($"Lỗi SMTP: {ex.Message}, Status: {ex.StatusCode}");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi không xác định: {ex.Message}");
                return 0;
            }
        }
    }
}
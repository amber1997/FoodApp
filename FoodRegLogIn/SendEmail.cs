
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace FoodRegLogIn
{
    class SendEmail
    {
        public static void sendEmail(string SendMail,int vertifyNum)
        {
            System.Net.Mail.SmtpClient MySmtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);


            MySmtp.Credentials = new System.Net.NetworkCredential("moutainonlysoup1997@gmail.com", "61352089qrtp960");

            MySmtp.EnableSsl = true;
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("Amber97nov@gmail.com", "AmberFood");
            mail.To.Add(SendMail);
            mail.Priority = MailPriority.Normal;
            mail.Subject = "安柏餐廳驗證碼";//輸入內容帶有隨機驗證碼
            mail.Body = "驗證碼" + vertifyNum.ToString();

            MySmtp.Send(mail);
            MessageBox.Show("發送成功");
        }
    }
}

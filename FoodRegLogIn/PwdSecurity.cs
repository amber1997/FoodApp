using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace FoodRegLogIn
{
    class PwdSecurity
    {
        public static string Md5Encode(string pwd)
        {
            
            string salt = pwd.Trim();


            if(salt.Trim().Length==0)
            {
                salt = "t15t";
            }

            byte[] originalStr = Encoding.Default.GetBytes(pwd);

            byte[] saltVal = Encoding.Default.GetBytes(salt);

            byte[] toSalt = new byte[originalStr.Length + saltVal.Length];

            originalStr.CopyTo(toSalt, 0);

            saltVal.CopyTo(toSalt, originalStr.Length);

            MD5 st = MD5.Create();

            byte[] saltPwd = st.ComputeHash(toSalt);

            byte[] newPwd = new byte[saltPwd.Length + saltVal.Length];

            saltVal.CopyTo(newPwd, 0);

            return Convert.ToBase64String(newPwd);



        }
    }
}

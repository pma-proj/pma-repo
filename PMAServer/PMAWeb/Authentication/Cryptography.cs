using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace PMAWeb.Authentication
{
    public class Cryptography
    {
        public static string Encrypt(string clearText)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(clearText);
            byte[] protectedBytes = ProtectedData.Protect(bytes, null, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(protectedBytes);
        }

        public static string Decrypt(string protectedText)
        {
            byte[] protectedBytes = Convert.FromBase64String(protectedText);
            byte[] bytes = ProtectedData.Unprotect(protectedBytes, null, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
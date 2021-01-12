using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.Utilities
{
    public static class MD5PasswordHash
    {
        private static MD5 CreateMD5() 
        {
            return MD5.Create();
        }

        /// <summary>
        /// Hashea la contrasena en MD5.
        /// </summary>
        /// <param name="password">Constrasena a hashear.</param>
        /// <returns></returns>
        public static string HashPassword(string password)
        {
            /*
             * Sacado de:
             * https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.md5?view=netframework-4.8
             */
            MD5 md5Hash = CreateMD5();

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}

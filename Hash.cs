using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
{
    /// <summary>
    /// Класс расширения для хеширования строк
    /// </summary>
    static class Hash
    {
        /// <summary>
        /// Метод для хеширования строки
        /// </summary>
        /// <param name="text">Строка, которую надо хешировать</param>
        /// <returns>Хешированная строка</returns>
        public static string GetHash(this string text)
        {
            using var hashAlg = MD5.Create();
            byte[] hash = hashAlg.ComputeHash(Encoding.UTF8.GetBytes(text));
            var builder = new StringBuilder(hash.Length * 2);
            for (int i = 0; i < hash.Length; i++)
            {
                builder.Append(hash[i].ToString("X2"));
            }
            return builder.ToString();
        }
    }
}

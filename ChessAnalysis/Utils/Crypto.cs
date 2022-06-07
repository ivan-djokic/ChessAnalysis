using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ChessAnalysis.Utils
{
    public static class Crypto
    {
        private const string PASSWORD = "abcdef0123456789";
        private const string SALT = "ABCD12efGHIjKl3m";
        private const int SIZE = 16;

        private static readonly byte[] s_iv;
        private static readonly byte[] s_key;

        static Crypto()
        {
            var keyGenerator = new Rfc2898DeriveBytes(PASSWORD, Encoding.Default.GetBytes(SALT));

            s_key = keyGenerator.GetBytes(SIZE);
            s_iv = keyGenerator.GetBytes(SIZE / 2);
        }

        public static string Decrypt(string input)
        {
            try
            {
                var buffer = input.ToCharArray();
                using var memoryStream = new MemoryStream(Convert.FromBase64CharArray(buffer, 0, buffer.Length));
                using var crypto = TripleDES.Create();
                return crypto.CreateDecryptor(s_key, s_iv).Read(memoryStream);
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string Encrypt(string input)
        {
            using var memoryStream = new MemoryStream();
            using var crypto = TripleDES.Create();
            crypto.CreateEncryptor(s_key, s_iv).Write(memoryStream, input);
            return Convert.ToBase64String(memoryStream.ToArray());
        }
    }
}

using System.Security.Cryptography;
using System.Text;

namespace UtilsLayer
{
    public class SecurityUtils
    {
        private static readonly byte[] cryptkey = Encoding.ASCII.GetBytes("encryptionIntVec");
        private static readonly byte[] initVector = new byte[16];
        private static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                .ToArray();
        }
        public static void CreatePasswordHash(string password, out byte[] passswordHash, out byte[] passwordSalt)
        {
            using var hmac = new System.Security.Cryptography.HMACSHA512();
            passwordSalt = hmac.Key;
            passswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }
        public static bool VerifyPasswordHash(string password, byte[] passswordHash, byte[] passwordSalt)
        {
            using var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt);
            var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != passswordHash[i])
                    return false;
            }
            return true;
        }
        public static string EncryptAES(string textToCrypt)
        {
            try
            {
                using var aes = Aes.Create();
                using var memoryStream = new MemoryStream();
                aes.Key = cryptkey;
                aes.IV = initVector;
                aes.Mode = CipherMode.CBC;

                using (var cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    using var streamWriter = new StreamWriter(cryptoStream);
                    streamWriter.Write(textToCrypt);
                }

                //return Convert.ToBase64String(memoryStream.ToArray());
                return BitConverter.ToString(memoryStream.ToArray()).Replace("-", "");

            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                return null;
            }
        }
        public static string DecryptAES(string hexData, bool emptyIv = true)
        {
            var _initVector = emptyIv ? initVector : cryptkey;
            try
            {
                using var aes = Aes.Create();
                using var memoryStream = new MemoryStream(StringToByteArray(hexData));
                aes.Key = cryptkey;
                aes.IV = initVector;
                aes.Mode = CipherMode.CBC;

                using var cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(cryptkey, _initVector), CryptoStreamMode.Read);
                using var streamReader = new StreamReader(cryptoStream);
                return streamReader.ReadToEnd();

            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                return null;
            }
        }
    }

}
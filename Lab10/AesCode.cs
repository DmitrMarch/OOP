using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Lab10
{
    public static class AesCode
    {
        public static string encryptText(string text, string password)
        {
            using (Aes aes = Aes.Create())
            {
                // Генерируем ключ и IV из пароля
                (byte[] key, byte[] iv) = generateKeyAndIV(password, aes.KeySize, aes.BlockSize);

                aes.Key = key;
                aes.IV = iv;

                // Шифруем данные
                using (MemoryStream ms = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    byte[] plainBytes = Encoding.UTF8.GetBytes(text);
                    cs.Write(plainBytes, 0, plainBytes.Length);
                    cs.Close();

                    // Возвращаем зашифрованный текст в формате Base64
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        public static string decryptText(string text, string password)
        {
            using (Aes aes = Aes.Create())
            {
                // Генерируем ключ и IV из пароля
                (byte[] key, byte[] iv) = generateKeyAndIV(password, aes.KeySize, aes.BlockSize);

                aes.Key = key;
                aes.IV = iv;

                // Расшифровываем данные
                using (MemoryStream ms = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    byte[] encryptedBytes = Convert.FromBase64String(text);
                    cs.Write(encryptedBytes, 0, encryptedBytes.Length);
                    cs.Close();

                    // Возвращаем расшифрованный текст
                    return Encoding.UTF8.GetString(ms.ToArray());
                }
            }
        }

        private static (byte[] Key, byte[] IV) generateKeyAndIV(string password, int keySize, int blockSize)
        {
            // Используем Rfc2898DeriveBytes для генерации ключа и IV
            using (var deriveBytes = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes("SaltValue123"), 10000))
            {
                byte[] key = deriveBytes.GetBytes(keySize / 8);
                byte[] iv = deriveBytes.GetBytes(blockSize / 8);
                return (key, iv);
            }
        }
    }
}

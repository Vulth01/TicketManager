using System.Security.Cryptography;

namespace BlazorApp1.Services
{
    public class HashPasswordService
    {
        public string HashPassword(string password, out string saltBase64)
        {
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            using (var sha256 = SHA256.Create())
            {
                byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
                byte[] saltedPassword = new byte[passwordBytes.Length + salt.Length];

                System.Buffer.BlockCopy(passwordBytes, 0, saltedPassword, 0, passwordBytes.Length);
                System.Buffer.BlockCopy(salt, 0, saltedPassword, passwordBytes.Length, salt.Length);

                byte[] hash = sha256.ComputeHash(saltedPassword); 
                saltBase64 = Convert.ToBase64String(salt); 
                return Convert.ToBase64String(hash); 
            }
        }

        public bool VerifyPassword(string password, string storedHashBase64, string storedSaltBase64)
        {
            byte[] storedSalt = Convert.FromBase64String(storedSaltBase64);
            byte[] storedHash = Convert.FromBase64String(storedHashBase64);

            using (var sha256 = SHA256.Create())
            {
                byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
                byte[] saltedPassword = new byte[passwordBytes.Length + storedSalt.Length];

                System.Buffer.BlockCopy(passwordBytes, 0, saltedPassword, 0, passwordBytes.Length);
                System.Buffer.BlockCopy(storedSalt, 0, saltedPassword, passwordBytes.Length, storedSalt.Length);

                byte[] hashToCompare = sha256.ComputeHash(saltedPassword); 
                return storedHash.SequenceEqual(hashToCompare); 
            }
        }
    }
}

using System;
using System.Security.Cryptography;
using System.Text;

namespace PasswordHasher
{
    public class SimpleHasher
    {
        public string hash(string thingToHash) {
            using (var algorithm = SHA256.Create()) 
            {
                var hashedBytes = algorithm.ComputeHash(Encoding.UTF8.GetBytes(thingToHash));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
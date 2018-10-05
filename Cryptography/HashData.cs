using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BlockChainCourse.Cryptography
{
    public class HashData
    {
        public static byte[] ComputeHashSha1(byte[] tobeHashed)
        {
            using (var sha1 = SHA1.Create())
            {
                return sha1.ComputeHash(tobeHashed);
 
            }
        }
        public static byte[] ComputeHashSha256(byte[] tobeHashed)
        {
            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(tobeHashed);
            }
        }
        public static byte[] ComputeHashSha384(byte[] tobeHashed)
        {
            using (var sha384 = SHA384.Create())
            {
                return sha384.ComputeHash(tobeHashed);
            }
        }
        public static byte[] ComputeHashSha512(byte[] tobeHashed)
        {
            using (var sha512 = SHA512.Create())
            {
                return sha512.ComputeHash(tobeHashed);
            }
        }
        public static byte[] ComputeHashHmacSha256(byte[] tobeHashed, byte[] key)
        {
            using (var hmac = new HMACSHA256(key))
            {
                return hmac.ComputeHash(tobeHashed);
            }
        }
    }
}

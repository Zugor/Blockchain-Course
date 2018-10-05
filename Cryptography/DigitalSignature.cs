using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Serialization;

namespace BlockChainCourse.Cryptography
{
    public class DigitalSignature
    {
        private RSAParameters _publicKey;
        private RSAParameters _privateKey;

        public string getPublicKey()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                return rsa.ToXmlString(false);
            }
        }
        public string getPrivateKey()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                return rsa.ToXmlString(true);
            }
        }
        public void setPublicKey(string key)
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.FromXmlString(key);
                _publicKey = rsa.ExportParameters(false);
            }
        }
        public void setPrivateKey(string key)
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.FromXmlString(key);
                _privateKey = rsa.ExportParameters(true);
            }
        }

        public void AssignNewKey()
        {
            using(var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                _publicKey = rsa.ExportParameters(false);
                _privateKey = rsa.ExportParameters(true);
            }
        }

        public byte[] Encrypt(byte[] input)
        {
            byte[] encrypted;
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(_publicKey);
                encrypted = rsa.Encrypt(input, true);
            }

            return encrypted;
        }

        private int getMaxBlockSize(int keySize)
        {
            int max = ((int)(keySize / 8 / 3)) * 4;
            if ((keySize / 8) % 3 != 0){
                max += 4;
            }
            return max;
        }

        public byte[] Decrypt(byte[] encrypted)
        {
            byte[] decrypted;
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(_privateKey);
                decrypted = rsa.Decrypt(encrypted, true);
            }
            return decrypted;
        }

        public byte[] SignData(byte[] hashOfDataToSign)
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(_privateKey);

                var rsaFommater = new RSAPKCS1SignatureFormatter(rsa);
                rsaFommater.SetHashAlgorithm("SHA256");
                return rsaFommater.CreateSignature(hashOfDataToSign);
            }
        }

        public bool VerifySignature(byte[] hashOfDataToSign, byte[] signature)
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.ImportParameters(_publicKey);

                var rsaDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
                rsaDeformatter.SetHashAlgorithm("SHA256");

                return rsaDeformatter.VerifySignature(hashOfDataToSign, signature);
            }
        }
    }
}

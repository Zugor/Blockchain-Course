using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace BlockChainCourse.Cryptography
{
    public partial class Form1 : Form
    {
        DigitalSignature rsa = new DigitalSignature();
        public Form1()
        {
            InitializeComponent();
            rsa.AssignNewKey();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string originalMessage = txtMsg.Text.Trim();
            string hash = hashType.Text;

            byte[] encrypted;
            var data = Encoding.UTF8.GetBytes(originalMessage);

            if (originalMessage.Length > 0)
            {
                encrypted = rsa.Encrypt(data);

                txtResult.Text = Convert.ToBase64String(encrypted);

                txtPublicKey.Text = rsa.getPublicKey();
                txtPrivateKey.Text = rsa.getPrivateKey();
            }
            else txtResult.Text = "";

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string originalMessage = txtMsg.Text.Trim();
            string privateKey = txtPrivateKey.Text.Trim();
            string publicKey = txtPublicKey.Text.Trim();

            byte[] decrypted;
            var data = Convert.FromBase64String(originalMessage);

            decrypted = rsa.Decrypt(data);
            txtResult.Text = Encoding.UTF8.GetString(decrypted);
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            string originalMessage = txtMsg.Text.Trim();
            var sha256HashedMessage = HashData.ComputeHashSha256(Encoding.UTF8.GetBytes(originalMessage));
            var signData = rsa.SignData(sha256HashedMessage);

            txtResult.Text = Convert.ToBase64String(sha256HashedMessage);
            txtSignature.Text = Convert.ToBase64String(signData);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMsg.Text = "";
            txtResult.Text = "";

            txtSignature.Text = "";
            txtPublicKey.Text = "";
            txtPrivateKey.Text = "";
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            var hashData = Convert.FromBase64String(txtResult.Text);
            var signature = Convert.FromBase64String(txtSignature.Text);
            if (rsa.VerifySignature(hashData, signature))
                MessageBox.Show("Message is verified!");
            else
                MessageBox.Show("Message not correct!");
        }
    }
}

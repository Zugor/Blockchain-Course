using System;
using System.Text;
using BlockChainCourse.BlockWithMultipleTransactions.Interfaces;
using BlockChainCourse.Cryptography;

namespace BlockChainCourse.BlockWithMultipleTransactions
{
    public class Transaction : ITransaction
    {
        public string ClaimNumber { get; set; }
        public decimal SettlementAmount { get; set; }
        public DateTime SettlementDate { get; set; }
        public string CarRegistration { get; set; }
        public int Mileage { get; set; }
        public ClaimType ClaimType { get; set; }
        public string Signature { get; set; }

        public Transaction(string claimNumber,
                            decimal settlementAmount,
                            DateTime settlementDate,
                            string carRegistration,
                            int mileage,
                            ClaimType claimType)
        {
            ClaimNumber = claimNumber;
            SettlementAmount = settlementAmount;
            SettlementDate = settlementDate;
            CarRegistration = carRegistration;
            Mileage = mileage;
            ClaimType = claimType;
        }

        public void SetSignature(DigitalSignature rsa)
        {
            byte[] signData = rsa.SignData(CalculateTransactionHash());
            Signature = Convert.ToBase64String(signData);
        }

        public byte[] CalculateTransactionHash()
        {
            string txnHash = ClaimNumber + SettlementAmount + SettlementDate + CarRegistration + Mileage + ClaimType;
            return HashData.ComputeHashSha256(Encoding.UTF8.GetBytes(txnHash));
        }
    }
}

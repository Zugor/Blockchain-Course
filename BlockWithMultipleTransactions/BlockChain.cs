using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using BlockChainCourse.BlockWithMultipleTransactions.Interfaces;

namespace BlockChainCourse.BlockWithMultipleTransactions
{
    public class BlockChain : IBlockChain
    {
        public IBlock CurrentBlock { get; private set; }
        public IBlock HeadBlock { get; private set; }

        public List<IBlock> Blocks { get; }

        public BlockChain()
        {
            Blocks = new List<IBlock>();
        }

        public void LoadFile(string path)
        {
            TextReader reader = null;
            try
            {
                reader = new StreamReader(path);
                var fileContents = reader.ReadToEnd();
                dynamic chain = JsonConvert.DeserializeObject(fileContents);

                for (int i = 0; i < chain.Blocks.Count; i++)
                {
                    IBlock block = new Block(i);
                    for (int j = 0; j < chain.Blocks[i].Transaction.Count; j++)
                    {
                        dynamic transaction = chain.Blocks[i].Transaction[j];
                        string ClaimNumber = transaction.ClaimNumber;
                        decimal SettlementAmount = transaction.SettlementAmount;
                        DateTime SettlementDate = transaction.SettlementDate;
                        string carRegistration = transaction.CarRegistration;
                        string signature = transaction.Signature;

                        int Mileage = transaction.Mileage;
                        ITransaction txn = new Transaction(ClaimNumber, SettlementAmount, SettlementDate, carRegistration, Mileage, ClaimType.TotalLoss);
                        if (string.IsNullOrEmpty(signature)) txn.Signature = transaction.Signature;
                        block.AddTransaction(txn);
                    }
                    AcceptBlock(block);
                    block.SetBlockHash(chain.Blocks[i].BlockHash);
                }

            }
            finally
            {
                if (reader != null)
                    reader.Close();
            } 
        }

        public void AcceptBlock(IBlock block)
        {
            // This is the first block, so make it the genesis block.
            if (HeadBlock == null)
            {
                HeadBlock = block;
                HeadBlock.PreviousBlockHash = null;
            }

            CurrentBlock = block;
            Blocks.Add(block);
        }

        public int NextBlockNumber
        {
            get
            {
                if (HeadBlock == null)
                { 
                    return 0; 
                }

                return CurrentBlock.BlockNumber + 1;
            }
        }

        public void VerifyChain()
        {
            if (HeadBlock == null)
            {
                throw new InvalidOperationException("Genesis block not set.");
            }

            bool isValid = HeadBlock.IsValidChain(null, true);

            if (isValid)
            {
                Console.WriteLine("Blockchain integrity intact.");
            }
            else
            {
                Console.WriteLine("Blockchain integrity NOT intact.");
            }
        }
    }
}

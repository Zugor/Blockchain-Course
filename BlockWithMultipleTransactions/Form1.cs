using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Newtonsoft.Json;

using BlockChainCourse.Cryptography;
using BlockChainCourse.BlockWithMultipleTransactions;
using BlockChainCourse.BlockWithMultipleTransactions.Interfaces;

namespace BlockWithMultipleTransactions
{
    public partial class Form1 : Form
    {
        int nBlock = 0;
        BlockChain chain = new BlockChain();
        IBlock cacheBlock = new Block(0);
        DigitalSignature rsa = new DigitalSignature();

        public Form1()
        {
            InitializeComponent();
            rsa.AssignNewKey();

            if (File.Exists("Blockchain.txt"))
            {
                chain.LoadFile("Blockchain.txt");

                for (int i = 0; i < chain.Blocks.Count; i++)
                {
                    nBlock++;
                    cb_blockList.Items.Add("Block " + (i + 1).ToString());
                }
                txt_nameBlock.Text = "Block " + (nBlock + 1).ToString();
                cb_blockList.SelectedIndex = cb_blockList.Items.Count - 1;
                cacheBlock = new Block(nBlock);
            }
        }

        private void btn_addTransactions_Click(object sender, EventArgs e)
        {
            if (dtg_inTransactions.RowCount > 1)
            {
                int numAdded = cacheBlock.Transaction.Count;
                int numInTransactions = dtg_inTransactions.RowCount - 1;
                int numTransactions = numAdded == 0 ? numInTransactions : numInTransactions - (5 - numAdded);
                int numAddCacheTransactions = numAdded == 0 ? 0 : (numInTransactions <= 5 - numAdded ? numInTransactions : 5 - numAdded);

                for (int i = 0; i < numAddCacheTransactions; i++)
                {
                    string claimNumber = dtg_inTransactions.Rows[i].Cells[0].Value.ToString().Trim();
                    string settlementAmount = dtg_inTransactions.Rows[i].Cells[1].Value.ToString().Trim();
                    string carRegistration = dtg_inTransactions.Rows[i].Cells[2].Value.ToString().Trim();
                    string mileage = dtg_inTransactions.Rows[i].Cells[3].Value.ToString().Trim();
                    DateTime timestamp = DateTime.Now;

                    ITransaction txn = new Transaction(claimNumber, Convert.ToDecimal(settlementAmount), timestamp, carRegistration, Convert.ToInt32(mileage), ClaimType.TotalLoss);
                    if (chb_signTransaction.Checked) txn.SetSignature(rsa);
                    cacheBlock.AddTransaction(txn);
                    dtg_outTransactions.Rows.Add(claimNumber, Convert.ToDecimal(settlementAmount), timestamp, carRegistration, Convert.ToInt32(mileage), ClaimType.TotalLoss);
                }
                //dtg_outTransactions.DataSource = cacheBlock.Transaction;
                //dtg_outTransactions.Refresh();

                if (cacheBlock.Transaction.Count == 5)
                {
                    cacheBlock.SetBlockHash(nBlock == 0 ? null : chain.Blocks[nBlock-1]);
                    chain.AcceptBlock(cacheBlock);
                    nBlock += 1;
                    txt_nameBlock.Text = "Block " + (nBlock + 1).ToString();
                    if(numTransactions == 0) dtg_inTransactions.Rows.Clear();
                    cacheBlock = new Block(nBlock);
                }
                int numBlocks = numTransactions > 0 ? numTransactions / 5 + (numTransactions % 5 == 0 ? 0 : 1) : 0;

                for (int i = 0; i < numBlocks; i++)
                {
                    IBlock block = new Block(nBlock);
                    int iMaxTransaction = (i == numBlocks - 1 && numTransactions != 5) ? numTransactions % 5 : 5;
                    dtg_outTransactions.Rows.Clear();
                    for (int j = 0; j < iMaxTransaction; j++)
                    {
                        string claimNumber = dtg_inTransactions.Rows[numAddCacheTransactions + i * 5 + j].Cells[0].Value.ToString().Trim();
                        string settlementAmount = dtg_inTransactions.Rows[numAddCacheTransactions + i * 5 + j].Cells[1].Value.ToString().Trim();
                        string carRegistration = dtg_inTransactions.Rows[numAddCacheTransactions + i * 5 + j].Cells[2].Value.ToString().Trim();
                        string mileage = dtg_inTransactions.Rows[numAddCacheTransactions + i * 5 + j].Cells[3].Value.ToString().Trim();
                        DateTime timestamp = DateTime.Now;
                        ITransaction txn = new Transaction(claimNumber, Convert.ToDecimal(settlementAmount), timestamp, carRegistration, Convert.ToInt32(mileage), ClaimType.TotalLoss);
                        if(chb_signTransaction.Checked) txn.SetSignature(rsa);

                        if (iMaxTransaction < 5)
                            cacheBlock.AddTransaction(txn);
                        else
                            block.AddTransaction(txn);
                        dtg_outTransactions.Rows.Add(claimNumber, Convert.ToDecimal(settlementAmount), timestamp, carRegistration, Convert.ToInt32(mileage), ClaimType.TotalLoss);
                    }
                    //dtg_outTransactions.DataSource = null;
                    cb_blockList.Items.Add("Block " + (nBlock + 1).ToString());
                    if (iMaxTransaction < 5) { }
                        //dtg_outTransactions.DataSource = cacheBlock.Transaction;
                    else
                    {
                        //dtg_outTransactions.DataSource = block.Transaction;
                        block.SetBlockHash(nBlock == 0 ? null : chain.Blocks[nBlock - 1]);
                        chain.AcceptBlock(block); 
                        nBlock += 1;
                        txt_nameBlock.Text = "Block " + (nBlock + 1).ToString();
                    }
                    cb_blockList.SelectedIndex = cb_blockList.Items.Count - 1;
                    if (i == numBlocks - 1) dtg_inTransactions.Rows.Clear();
                }
                if (cacheBlock.Transaction.Count > 0) dtg_inTransactions.Rows.Clear();
            }
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            if(chain.Blocks.Count > 0)
                chain.VerifyChain();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            nBlock = 0;
            chain = new BlockChain();
            cacheBlock = new Block(0);
            dtg_inTransactions.Rows.Clear();
            dtg_outTransactions.Rows.Clear();
            cb_blockList.Items.Clear();
            txt_nameBlock.Text = "Block 1".ToString();
        }

        private void cb_blockList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = cb_blockList.SelectedIndex;
            List<ITransaction> transaction;
            if (cacheBlock.Transaction.Count != 0 && SelectedIndex == cb_blockList.Items.Count - 1)
                transaction = cacheBlock.Transaction;
            else
                transaction = chain.Blocks[SelectedIndex].Transaction;

            dtg_outTransactions.Rows.Clear();
            for (int i = 0; i < transaction.Count; i++)
            {
                string claimNumber = transaction[i].ClaimNumber;
                string settlementAmount = transaction[i].SettlementAmount.ToString();
                string timestamp = transaction[i].SettlementDate.ToString();
                string carRegistration = transaction[i].CarRegistration;
                string mileage = transaction[i].Mileage.ToString();
                string claimType = transaction[i].ClaimType.ToString();
                dtg_outTransactions.Rows.Add(claimNumber, settlementAmount, timestamp, carRegistration, mileage, claimType);
            }
        }

        private void btn_exportBlockchain_Click(object sender, EventArgs e)
        {
            TextWriter writer = null;
            try
            {
                var contentsToWriteToFile = JsonConvert.SerializeObject(chain);
                writer = new StreamWriter("Blockchain.txt", false);
                writer.Write(contentsToWriteToFile);
            }
            finally
            {
                if (writer != null)
                {
                    MessageBox.Show("Exported your blockchain!");
                    writer.Close();
                }
            }
        }

        private void btn_importBlockchain_Click(object sender, EventArgs e)
        {
            if (ofd_importBlockchain.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                chain = new BlockChain();
                chain.LoadFile(ofd_importBlockchain.FileName);
                cb_blockList.Items.Clear();
                dtg_inTransactions.Rows.Clear();
                dtg_outTransactions.Rows.Clear();
                nBlock = 0;
                for (int i = 0; i < chain.Blocks.Count; i++)
                {
                    nBlock++;
                    cb_blockList.Items.Add("Block " + (i + 1).ToString());
                }
                txt_nameBlock.Text = "Block " + (nBlock + 1).ToString();
                cb_blockList.SelectedIndex = cb_blockList.Items.Count - 1;
                cacheBlock = new Block(nBlock);
            }
        }
    }
}

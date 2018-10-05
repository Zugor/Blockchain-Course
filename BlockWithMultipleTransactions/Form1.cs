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

using BlockChainCourse.Cryptography;
using BlockChainCourse.BlockWithMultipleTransactions;
using BlockChainCourse.BlockWithMultipleTransactions.Interfaces;

namespace BlockWithMultipleTransactions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rsa.AssignNewKey();
            dtg_inTransactions.Rows.Add(1, 1, "asgdf", 1);
            dtg_inTransactions.Rows.Add(2, 2, "bvd", 2);
            dtg_inTransactions.Rows.Add(3, 3, "asg5gfdf", 3);
            dtg_inTransactions.Rows.Add(4, 4, "543tg", 4);
            dtg_inTransactions.Rows.Add(5, 5, "fsd53", 5);
            dtg_inTransactions.Rows.Add(6, 6, "hdsd", 6);
        }

        int nBlock = 0;
        BlockChain chain = new BlockChain();
        IBlock cacheBlock = new Block(0);
        DigitalSignature rsa = new DigitalSignature();
        private void btn_addTransactions_Click(object sender, EventArgs e)
        {
            if (dtg_inTransactions.RowCount > 1)
            {
                if (chain.Blocks.Count == 0)
                {
                    int numTransactions = dtg_inTransactions.RowCount - 1;
                    int numBlocks = numTransactions / 5 + (numTransactions % 5 == 0 ? 0 : 1);

                    for (int i = 0; i < numBlocks; i++)
                    {
                        IBlock block = new Block(nBlock);

                        bool blVaildBlock = true;
                        int iMaxTransaction = (i == numBlocks - 1) ? numTransactions % 5 : 5;

                        if (iMaxTransaction < 5) cacheBlock = new Block(nBlock);

                        for (int j = 0; j < iMaxTransaction; j++)
                        {
                            int iSettlementAmount;
                            int iMileage;

                            string claimNumber = dtg_inTransactions.Rows[i * 5 + j].Cells[0].Value.ToString().Trim();
                            string settlementAmount = dtg_inTransactions.Rows[i * 5 + j].Cells[1].Value.ToString().Trim();
                            string carRegistration = dtg_inTransactions.Rows[i * 5 + j].Cells[2].Value.ToString().Trim();
                            string mileage = dtg_inTransactions.Rows[i * 5 + j].Cells[3].Value.ToString().Trim();
                            DateTime timestamp = DateTime.Now;

                            if (claimNumber.Length > 0 && settlementAmount.Length > 0 && carRegistration.Length > 0 && int.TryParse(settlementAmount, out iSettlementAmount) && int.TryParse(mileage, out iMileage))
                            {
                                if (iMaxTransaction < 5) cacheBlock.AddTransaction(new Transaction(claimNumber, Convert.ToDecimal(settlementAmount), timestamp, carRegistration, Convert.ToInt32(mileage), ClaimType.TotalLoss));

                                else block.AddTransaction(new Transaction(claimNumber, Convert.ToDecimal(settlementAmount), timestamp, carRegistration, Convert.ToInt32(mileage), ClaimType.TotalLoss));

                            }
                            else blVaildBlock = false;
                        }
                        if (blVaildBlock)
                        {
                            nBlock += 1;
                            if (iMaxTransaction < 5) dtg_outTransactions.DataSource = cacheBlock.Transaction;
                            else
                            {
                                dtg_outTransactions.DataSource = block.Transaction;
                                chain.AcceptBlock(block);
                            }
                            if (iMaxTransaction == 5) txt_nameBlock.Text = "Block " + (nBlock + 1).ToString();
                            cb_blockList.Items.Add("Block " + nBlock.ToString());
                            cb_blockList.SelectedIndex = cb_blockList.Items.Count - 1;
                            if (i == numBlocks - 1) dtg_inTransactions.Rows.Clear();
                        }
                        else Console.WriteLine("FALSE");
                    }
                }
                else
                {
                    if (cacheBlock.Transaction.Count != 0 && cacheBlock.Transaction.Count < 5)
                    {
                        int numAdded = cacheBlock.Transaction.Count;
                        int numInTransactions = dtg_inTransactions.RowCount - 1;
                        int numTransactions = numInTransactions - (5 - numAdded);

                        if (numTransactions <= 0)
                        {
                            bool blVaildBlock = true;
                            for (int i = 0; i < numInTransactions; i++)
                            {
                                int iSettlementAmount;
                                int iMileage;

                                string claimNumber = dtg_inTransactions.Rows[i].Cells[0].Value.ToString().Trim();
                                string settlementAmount = dtg_inTransactions.Rows[i].Cells[1].Value.ToString().Trim();
                                string carRegistration = dtg_inTransactions.Rows[i].Cells[2].Value.ToString().Trim();
                                string mileage = dtg_inTransactions.Rows[i].Cells[3].Value.ToString().Trim();
                                DateTime timestamp = DateTime.Now;

                                if (claimNumber.Length > 0 && settlementAmount.Length > 0 && carRegistration.Length > 0 && int.TryParse(settlementAmount, out iSettlementAmount) && int.TryParse(mileage, out iMileage))
                                    cacheBlock.AddTransaction(new Transaction(claimNumber, Convert.ToDecimal(settlementAmount), timestamp, carRegistration, Convert.ToInt32(mileage), ClaimType.TotalLoss));
                                else blVaildBlock = false;
                            }
                            dtg_outTransactions.DataSource = null;
                            dtg_outTransactions.DataSource = cacheBlock.Transaction;
                            Console.WriteLine(nBlock);
                            if (numTransactions == 0 && blVaildBlock)
                            {
                                nBlock += 1;
                                Console.WriteLine(nBlock);
                                chain.AcceptBlock(cacheBlock);

                                txt_nameBlock.Text = "Block " + (nBlock + 1).ToString();
                                cb_blockList.SelectedIndex = cb_blockList.Items.Count - 1;
                            }
                            else Console.WriteLine("FALSE");
                            

                            dtg_inTransactions.Rows.Clear();
                        }
                        else
                        {
                            int numBlocks = numTransactions / 5 + (numTransactions % 5 == 0 ? 0 : 1);

                            for (int i = 0; i < numBlocks; i++)
                            {
                                IBlock block = new Block(nBlock);

                                bool blVaildBlock = true;
                                int iMaxTransaction = (i == numBlocks - 1) ? numTransactions % 5 : 5;

                                if (iMaxTransaction < 5) cacheBlock = new Block(nBlock);

                                for (int j = 0; j < iMaxTransaction; j++)
                                {
                                    int iSettlementAmount;
                                    int iMileage;

                                    string claimNumber = dtg_inTransactions.Rows[i * 5 + j].Cells[0].Value.ToString().Trim();
                                    string settlementAmount = dtg_inTransactions.Rows[i * 5 + j].Cells[1].Value.ToString().Trim();
                                    string carRegistration = dtg_inTransactions.Rows[i * 5 + j].Cells[2].Value.ToString().Trim();
                                    string mileage = dtg_inTransactions.Rows[i * 5 + j].Cells[3].Value.ToString().Trim();
                                    DateTime timestamp = DateTime.Now;

                                    if (claimNumber.Length > 0 && settlementAmount.Length > 0 && carRegistration.Length > 0 && int.TryParse(settlementAmount, out iSettlementAmount) && int.TryParse(mileage, out iMileage))
                                    {
                                        if (iMaxTransaction < 5) cacheBlock.AddTransaction(new Transaction(claimNumber, Convert.ToDecimal(settlementAmount), timestamp, carRegistration, Convert.ToInt32(mileage), ClaimType.TotalLoss));

                                        else block.AddTransaction(new Transaction(claimNumber, Convert.ToDecimal(settlementAmount), timestamp, carRegistration, Convert.ToInt32(mileage), ClaimType.TotalLoss));

                                    }
                                    else blVaildBlock = false;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {

        }

        private void btn_verify_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            dtg_inTransactions.Rows.Clear();
        }

        private void cb_blockList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = cb_blockList.SelectedIndex;
            if(cacheBlock.Transaction.Count != 0 && SelectedIndex == cb_blockList.Items.Count-1)
                dtg_outTransactions.DataSource = cacheBlock.Transaction;
            else
                dtg_outTransactions.DataSource = chain.Blocks[SelectedIndex].Transaction;
        }
    }
}

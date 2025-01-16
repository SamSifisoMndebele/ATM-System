using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_System
{
    public partial class ReceiptForm : Form
    {
        public ReceiptForm()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Close();
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            datetime.Text = DateTime.Now.ToString();
            Receipt receipt = (Receipt)Tag;
            accountNo.Text = receipt.AccountNo.ToString();
            balance.Text = receipt.Balance.ToString();
            tranAmount.Text = receipt.TransBalance.ToString();
            newBalance.Text = receipt.NewBalance.ToString();
            if (receipt.IsDeposit)
            {
                tranLabel.Text = "Amount Deposit";
            } else
            {
                tranLabel.Text = "Amount Withdraw";
            }
            if (!receipt.IsSuccessful)
            {
                status.Text = receipt.ErrorMsg;
            }
        }
    }
}

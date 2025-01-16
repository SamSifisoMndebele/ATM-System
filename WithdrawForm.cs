using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_System
{
    public partial class WithdrawForm : Form
    {
        public WithdrawForm()
        {
            InitializeComponent();
        }

        double balance = 0;

        private void WithdrawForm_Load(object sender, EventArgs e)
        {
            datetime.Text = DateTime.Now.ToString();
            Connection.GetConnection(connection =>
            {
                SqlCommand cmd = new SqlCommand("SELECT balance FROM Users WHERE account_no=@account_no", connection);
                cmd.Parameters.AddWithValue("@account_no", Tag.ToString());
                balance = Convert.ToDouble(cmd.ExecuteScalar());
            });

            if (balance < 500)
            {
                amount500.Enabled = false;
            } else if (balance < 200)
            {
                amount500.Enabled = false;
                amount200.Enabled = false;
            } else if(balance < 100)
            {
                amount500.Enabled = false;
                amount200.Enabled = false;
                amount100.Enabled = false;
            } else if(balance < 50)
            {
                amount500.Enabled = false;
                amount200.Enabled = false;
                amount100.Enabled = false;
                amount50.Enabled = false;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Tag = Tag.ToString();
            mainMenuForm.Show();
            Close();
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountBox.Text);
            if (balance >= amount)
            {
                withdrawMoney(amount);
            } else
            {
                showReport(amount, balance, false, "Transaction Not SUccesfull\nInsuficient Balance");
            }
        }

        private void withdrawMoney(double amount)
        {
            try
            {
                Connection.GetConnection(connection =>
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Users SET balance=@balance WHERE account_no=@account_no", connection);
                    cmd.Parameters.AddWithValue("@account_no", Tag.ToString());
                    cmd.Parameters.AddWithValue("@balance", balance - amount);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                });

                showReport(amount, balance - amount, true);
            }
            catch (Exception ex)
            {
                showReport(amount, balance, false, "Transaction Not SUccesfull\nUnknown Error Occured. \n\n"+ex.Message);
            }
        }

        private void showReport(double amount, double newBalance, bool isSuccessful, string errorMsg = null)
        {
            ReceiptForm receiptForm = new ReceiptForm();
            receiptForm.Tag = new Receipt(Tag.ToString(), balance, amount, newBalance, false, isSuccessful, errorMsg);
            receiptForm.Show();
            Close();
        }

        private void amount500_Click(object sender, EventArgs e)
        {
            withdrawMoney(500);
        }

        private void amount200_Click(object sender, EventArgs e)
        {
            withdrawMoney(200);
        }

        private void amount100_Click(object sender, EventArgs e)
        {
            withdrawMoney(100);
        }

        private void amount50_Click(object sender, EventArgs e)
        {
            withdrawMoney(50);
        }
    }
}

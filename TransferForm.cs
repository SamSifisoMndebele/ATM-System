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
    public partial class TransferForm : Form
    {
        bool amountBoxFocused = false;
        double balance = 0;
        public TransferForm()
        {
            InitializeComponent();
        }

        private void TransferForm_Load(object sender, EventArgs e)
        {
            datetime.Text = DateTime.Now.ToString();

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\BankDatabase.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT balance FROM Users WHERE account_no=@account_no", con);
            cmd.Parameters.AddWithValue("@account_no", Tag.ToString());
            balance = Convert.ToDouble(cmd.ExecuteScalar());
            con.Close();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (accountNoBox.Text.Trim() == "" ||  accountNoBox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your account number and amount you want to tranfer.");
            } else
            {
                sendMoney(Convert.ToDouble(amountBox.Text.Trim()), accountNoBox.Text.Trim());
            }

        }
        private void sendMoney(double amount, string accountNo)
        {
            if(amount > balance)
            {
                showReport(amount, balance, false, "Transaction Not SUccesfull\nInsuficient funds.");
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\BankDatabase.mdf;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Users SET balance=balance-@amount WHERE account_no=@my_account_no;" +
                    "UPDATE Users SET balance=balance+@amount WHERE account_no=@account_no;", con);
                cmd.Parameters.AddWithValue("@my_account_no", Tag.ToString());
                cmd.Parameters.AddWithValue("@account_no", accountNo);
                cmd.Parameters.AddWithValue("@amount",amount);
                int rows = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                if (rows > 0)
                {
                    showReport(amount, balance - amount, true);
                } else
                {
                    throw new Exception("Wrong account number");
                }
                
            }
            catch (Exception ex)
            {
                showReport(amount, balance, false, "Transaction Not SUccesfull\nUnknown Error Occured.\n\n" + ex.Message);
            }
        }

        private void showReport(double amount, double newBalance, bool isSuccessful, string errorMsg = null)
        {
            ReceiptForm receiptForm = new ReceiptForm();
            receiptForm.Tag = new Receipt(Tag.ToString(), balance, amount, newBalance, false, isSuccessful, errorMsg);
            receiptForm.Show();
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Tag = Tag.ToString();
            mainMenuForm.Show();
            Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            if (amountBoxFocused)
            {
                amountBox.Text = "";
            }
            else
            {
                accountNoBox.Text = "";
            }
        }

        private void accountNoBox_TextChanged(object sender, EventArgs e)
        {
            amountBoxFocused = false;
        }

        private void amountBox_TextChanged(object sender, EventArgs e)
        {
            amountBoxFocused = true;
        }
    }
}

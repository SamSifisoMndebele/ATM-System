using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATM_System
{
    public partial class DepositForm : Form
    {
        double balance;
        public DepositForm()
        {
            InitializeComponent();
        }
 
        private void DebositForm_Load(object sender, EventArgs e)
        {
            datetime.Text = DateTime.Now.ToString();
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\BankDatabase.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT balance FROM Users WHERE account_no=@account_no", con);
            cmd.Parameters.AddWithValue("@account_no", Tag.ToString());
            balance = Convert.ToDouble(cmd.ExecuteScalar());
            con.Close();
            amountBox.Text = balance.ToString();
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountBox.Text);
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\BankDatabase.mdf;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Users SET balance=@balance WHERE account_no=@account_no", con);
                cmd.Parameters.AddWithValue("@account_no", Tag.ToString());
                cmd.Parameters.AddWithValue("@balance", balance + amount);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                showReport(amount, balance + amount, true);
            } catch (Exception ex)
            {
                showReport(amount, balance, false, "Transaction Not SUccesfull\nUnknown Error Occured.");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Tag = Tag.ToString();
            mainMenuForm.Show();
            Close();
        }

        private void showReport(double tranAmount, double newBalance, bool isSuccessful, string errorMsg = null)
        {
            ReceiptForm receiptForm = new ReceiptForm();
            receiptForm.Tag = new Receipt(Tag.ToString(), balance, tranAmount, newBalance, true, isSuccessful, errorMsg);
            receiptForm.Show();
            Close();
        }
    }
}

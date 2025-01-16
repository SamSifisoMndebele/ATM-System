using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATM_System
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, System.EventArgs e)
        {
            datetime.Text = DateTime.Now.ToString();
            Connection.GetConnection(connection =>
            {
                SqlCommand cmd = new SqlCommand("SELECT CONCAT(first_names,' ',lastname) FROM Users WHERE account_no=@account_no", connection);
                var accountNo = Tag.ToString();
                cmd.Parameters.AddWithValue("@account_no", accountNo);
                userAccNo.Text = accountNo;
                userName.Text = (string)cmd.ExecuteScalar();
                cmd.Dispose();
            });
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Close();
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            DepositForm adminForm = new DepositForm();
            adminForm.Tag = Tag.ToString();
            adminForm.Show();
            Hide();
        }

        private void buttonBulance_Click(object sender, EventArgs e)
        {
            BalanceForm balanceForm = new BalanceForm();
            balanceForm.Tag = Tag.ToString();
            balanceForm.Show();
            Hide();
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawForm withdrawForm = new WithdrawForm();
            withdrawForm.Tag = Tag.ToString();
            withdrawForm.Show();
            Hide();
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm();
            transferForm.Tag = Tag.ToString();
            transferForm.Show();
            Hide();
        }
    }
}
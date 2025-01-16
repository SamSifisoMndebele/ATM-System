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
    public partial class BalanceForm : Form
    {
        public BalanceForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Tag = Tag.ToString();
            mainMenuForm.Show();
            Close();
        }

        private void BalanceForm_Load(object sender, EventArgs e)
        {
            datetime.Text = DateTime.Now.ToString();
            Connection.GetConnection(connection =>
            {
                SqlCommand cmd = new SqlCommand("SELECT balance FROM Users WHERE account_no=@account_no", connection);
                cmd.Parameters.AddWithValue("@account_no", Tag.ToString());
                double balance = Convert.ToDouble(cmd.ExecuteScalar());
                cmd.Dispose();
                userBalance.Text = "R "+ balance.ToString();
            });
        }
    }
}

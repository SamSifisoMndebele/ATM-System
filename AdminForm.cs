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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchAccNo.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the account number.");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\BankDatabase.mdf;Integrated Security=True");
                con.Open();
                string query = "SELECT account_no, first_names, lastname, balance, pin, phone FROM Users WHERE account_no=@account_no";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@account_no", searchAccNo.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    string accNo = reader.GetString(0);
                    string fName = reader.GetString(1);
                    string lName = reader.GetString(2);
                    string pin   = reader.GetString(3);
                    double balance = reader.GetDouble(4);
                    string phone = reader.GetString(5);

                    txtAcctNo.Text = accNo;
                    txtfnme.Text = fName;
                    txtlnme.Text = lName;
                    txtPincode.Text = pin;
                    txtPhone.Text = phone;

                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Account Number Not found");
                }
            }
        }
    }
}

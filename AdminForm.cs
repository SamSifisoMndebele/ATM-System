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
                Connection.GetConnection(connection =>
                {
                    SqlCommand cmd = new SqlCommand("SELECT account_no, first_names, lastname, pin, phone FROM Users WHERE account_no=@account_no", connection);
                    cmd.Parameters.AddWithValue("@account_no", searchAccNo.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtAcctNo.Text = reader.GetString(0);
                            txtfnme.Text = reader.GetString(1);
                            txtlnme.Text = reader.GetString(2);
                            txtPincode.Text = reader.GetString(3);
                            txtPhone.Text = reader.GetString(4);
                        }
                        else
                        {
                            MessageBox.Show("Account Number Not found");
                        }
                    }
                });

            }
        }
    }
}

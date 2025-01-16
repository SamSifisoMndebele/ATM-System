using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ATM_System
{
    public partial class LoginForm : Form
    {
        bool pinBoxFocused =  false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pinBox.PasswordChar = '*';
            datetime.Text = DateTime.Now.ToString();
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            if (accountNoBox.Text.Trim() == "" || pinBox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your account number and PIN.");
            } else
            {
                Connection.GetConnection(connection =>
                {
                    SqlCommand cmd = new SqlCommand("SELECT is_admin FROM Users WHERE account_no=@account_no AND pin=@pin", connection);
                    cmd.Parameters.AddWithValue("@account_no", accountNoBox.Text);
                    cmd.Parameters.AddWithValue("@pin", pinBox.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bool isAdmin = reader.GetBoolean(0);
                            if (isAdmin)
                            {
                                AdminForm adminForm = new AdminForm();
                                adminForm.Show();
                                Hide();
                            }
                            else
                            {
                                MainMenuForm mainMenu = new MainMenuForm();
                                mainMenu.Tag = accountNoBox.Text;
                                mainMenu.Show();
                                Hide();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Wrong Account number or PIN");
                        }
                    }
                });
            }
            
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            if (pinBoxFocused)
            {
                pinBox.Text = "";
            } else
            {
                accountNoBox.Text = "";
            }
        }

        private void accountNoBox_TextChanged(object sender, EventArgs e)
        {
            pinBoxFocused = false;
        }

        private void pinBox_TextChanged(object sender, EventArgs e)
        {
            pinBoxFocused = true;
        }
    }
}

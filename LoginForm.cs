using System;
using System.Data.SqlClient;
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

            // todo: remove
            accountNoBox.Text = "admin";
            pinBox.Text = "1111";
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            if (accountNoBox.Text.Trim() == "" || pinBox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your account number and PIN.");
            } else
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\BankDatabase.mdf;Integrated Security=True");
                con.Open();
                string query = "SELECT is_admin FROM Users WHERE account_no=@account_no AND pin=@pin";  
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@account_no", accountNoBox.Text);
                cmd.Parameters.AddWithValue("@pin", pinBox.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    bool isAdmin = (bool)cmd.ExecuteScalar();
                    if (isAdmin)
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        Hide();
                    } else
                    {
                        MainMenuForm mainMenu = new MainMenuForm();
                        mainMenu.Tag = accountNoBox.Text;
                        mainMenu.Show();
                        Hide();
                    }
                    
                } else
                {
                    MessageBox.Show("Wrong Account number or PIN");
                }
                con.Close();
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

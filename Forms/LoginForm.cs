using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoardGamesLibrary2.Models;
using BoardGamesLibrary2.Utils;


namespace BoardGamesLibrary2.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            User user = AuthenticateUser(username, password);

            if (user != null)
            {
                if (user.Role == Constants.ROLE_ADMIN)
                {
                    new AdminForm().Show();
                }
                else
                {
                    new UserForm().Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Identifiants incorrects");
            }
        }

        private User AuthenticateUser(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.CONNECTION_STRING))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE Username = @username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedHash = reader["PasswordHash"].ToString();
                        if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                        {
                            return new User
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Username = reader["Username"].ToString(),
                                Role = reader["Role"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}

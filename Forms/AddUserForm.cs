using BoardGamesLibrary2.Utils;
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

namespace BoardGamesLibrary2.Forms
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(Constants.CONNECTION_STRING))
                {
                    conn.Open();

                    // Vérifier si l'utilisateur existe déjà
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE Username = @username";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@username", txtUsername.Text);

                    if ((long)checkCmd.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Ce nom d'utilisateur existe déjà");
                        return;
                    }

                    // Ajouter le nouvel utilisateur
                    string insertQuery = @"INSERT INTO users 
                        (Username, PasswordHash, Role) 
                        VALUES (@username, @password, 'User')";

                    MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", Security.HashPassword(txtPassword.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Utilisateur créé avec succès !");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
           

            // Ajouter un bouton "Ajouter utilisateur"
            Button btnAddUser = new Button();
            btnAddUser.Text = "Ajouter utilisateur";
            btnAddUser.Location = new Point(200, 340);
            btnAddUser.Click += (s, ev) =>
            {
                new AddUserForm().ShowDialog();
            };
            this.Controls.Add(btnAddUser);
        }
    }
}

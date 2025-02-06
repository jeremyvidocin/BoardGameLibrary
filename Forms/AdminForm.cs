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
using BoardGamesLibrary2.Utils;

namespace BoardGamesLibrary2.Forms
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

        private void LoadGames()
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.CONNECTION_STRING))
            {
                conn.Open();
                string query = "SELECT * FROM games";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvGames.DataSource = dt;
            }
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            // Ajouter une logique pour ouvrir un formulaire d'ajout
            //AddGameForm addForm = new AddGameForm();
            //if (addForm.ShowDialog() == DialogResult.OK)
            //{
            //    LoadGames(); // Rafraîchir la liste
            //}
        }
    }
}

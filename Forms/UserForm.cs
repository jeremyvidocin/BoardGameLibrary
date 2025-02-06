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
    public partial class UserForm : Form
    {

        public UserForm()
        {
            InitializeComponent();
            LoadGames();
        }

        private void LoadGames(string search = "", string sortBy = "Name")
        {
            using (MySqlConnection conn = new MySqlConnection(Constants.CONNECTION_STRING))
            {
                conn.Open();
                string query = $"SELECT * FROM games WHERE Name LIKE @search ORDER BY {sortBy}";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@search", $"%{search}%");

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvGames.DataSource = dt;
            }
        }

        private void dgvGames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

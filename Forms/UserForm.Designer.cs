namespace BoardGamesLibrary2.Forms
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvGames = new DataGridView();
            this.txtSearch = new TextBox();
            this.cmbSort = new ComboBox();
            this.ClientSize = new Size(800, 450);

            // Configuration DataGridView
            dgvGames.Location = new Point(20, 50);
            dgvGames.Size = new Size(600, 300);
            dgvGames.ReadOnly = true;

            // Zone de recherche
            txtSearch.Location = new Point(20, 10);
            txtSearch.Size = new Size(200, 23);
            txtSearch.TextChanged += (s, e) => LoadGames(txtSearch.Text);

            // ComboBox de tri
            cmbSort.Location = new Point(250, 10);
            cmbSort.Size = new Size(150, 23);
            cmbSort.Items.AddRange(new[] { "Nom", "Nombre de joueurs", "Nombre de cartes" });
            cmbSort.SelectedIndexChanged += (s, e) =>
            {
                string sortColumn = cmbSort.Text switch
                {
                    "Nombre de joueurs" => "MinPlayers",
                    "Nombre de cartes" => "NumberOfCards",
                    _ => "Name"
                };
                LoadGames(txtSearch.Text, sortColumn);
            };

            this.Controls.Add(dgvGames);
            this.Controls.Add(txtSearch);
            this.Controls.Add(cmbSort);
        }

        #endregion

        private DataGridView dgvGames;
        private TextBox txtSearch;
        private ComboBox cmbSort;
    }
}
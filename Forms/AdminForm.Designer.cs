namespace BoardGamesLibrary2.Forms
{
    partial class AdminForm
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
            dgvGames = new DataGridView();
            btnAddGame = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            SuspendLayout();
            // 
            // dgvGames
            // 
            dgvGames.Location = new Point(20, 20);
            dgvGames.Name = "dgvGames";
            dgvGames.Size = new Size(600, 300);
            dgvGames.TabIndex = 0;
            // 
            // btnAddGame
            // 
            btnAddGame.Location = new Point(20, 340);
            btnAddGame.Name = "btnAddGame";
            btnAddGame.Size = new Size(156, 23);
            btnAddGame.TabIndex = 1;
            btnAddGame.Text = "Ajouter un jeu";
            btnAddGame.Click += btnAddGame_Click;
            // 
            // AdminForm
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(dgvGames);
            Controls.Add(btnAddGame);
            Name = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGames;
        private Button btnAddGame;
    }
}
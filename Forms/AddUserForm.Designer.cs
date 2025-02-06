namespace BoardGamesLibrary2.Forms
{
    partial class AddUserForm
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
            this.txtUsername = new TextBox();
            this.txtPassword = new TextBox();
            this.btnAdd = new Button();
            this.label1 = new Label();
            this.label2 = new Label();

            // Configuration des contrôles
            this.ClientSize = new Size(300, 200);
            this.Text = "Ajouter un utilisateur";

            // Positionnement
            label1.Location = new Point(20, 30);
            label1.Text = "Nom d'utilisateur :";
            txtUsername.Location = new Point(20, 50);
            txtUsername.Size = new Size(260, 23);

            label2.Location = new Point(20, 90);
            label2.Text = "Mot de passe :";
            txtPassword.Location = new Point(20, 110);
            txtPassword.Size = new Size(260, 23);
            txtPassword.PasswordChar = '*';

            btnAdd.Location = new Point(20, 150);
            btnAdd.Text = "Ajouter";
            btnAdd.Click += btnAdd_Click;

            // Ajout des contrôles
            this.Controls.Add(label1);
            this.Controls.Add(txtUsername);
            this.Controls.Add(label2);
            this.Controls.Add(txtPassword);
            this.Controls.Add(btnAdd);
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnAdd;
        private Label label1;
        private Label label2;
    }
}
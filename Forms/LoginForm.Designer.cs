namespace BoardGamesLibrary2.Forms
{
    partial class LoginForm
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
            this.lblUsername = new Label();
            this.txtUsername = new TextBox();
            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new Point(50, 50);
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new Point(150, 47);
            this.txtUsername.Size = new Size(200, 23);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new Point(50, 100);
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new Point(150, 97);
            this.txtPassword.Size = new Size(200, 23);
            this.txtPassword.PasswordChar = '*';
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new Point(150, 150);
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.ClientSize = new Size(400, 250);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}
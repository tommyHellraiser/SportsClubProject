namespace SportsClubProject.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLogin.Location = new Point(359, 39);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(100, 23);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "LOGIN";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            txtUser.Location = new Point(490, 130);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(205, 23);
            txtUser.TabIndex = 2;
            txtUser.Text = "Usuario";
            txtUser.Click += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(490, 190);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(205, 23);
            txtPass.TabIndex = 3;
            txtPass.Text = "Contraseña";
            txtPass.Click += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnLogin.Location = new Point(522, 299);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 36);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(lblLogin);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            Click += txtUser_Enter;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblLogin;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
    }
}
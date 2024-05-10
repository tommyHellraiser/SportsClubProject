namespace SportsClubProject
{
	partial class HomeScreen
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            lblRole = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblLastName = new Label();
            lblBirthday = new Label();
            lblName = new Label();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(331, 42);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(112, 25);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Bienvenido";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(669, 42);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(34, 21);
            lblRole.TabIndex = 1;
            lblRole.Text = "Rol";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(178, 215);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(74, 21);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Telefono";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(180, 263);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(180, 161);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(72, 21);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Apellido";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBirthday.Location = new Point(180, 314);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(108, 21);
            lblBirthday.TabIndex = 5;
            lblBirthday.Text = "Fecha de nac.";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(180, 116);
            lblName.Name = "lblName";
            lblName.Size = new Size(71, 21);
            lblName.TabIndex = 6;
            lblName.Text = "Nombre";
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(lblName);
            Controls.Add(lblBirthday);
            Controls.Add(lblLastName);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblRole);
            Controls.Add(lblWelcome);
            Name = "HomeScreen";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblRole;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblLastName;
        private Label lblBirthday;
        private Label lblName;
    }
}

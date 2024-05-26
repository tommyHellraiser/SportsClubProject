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
            lblUser = new Label();
            btnSignUp = new Button();
            btnListMembers = new Button();
            btnPayCourse = new Button();
            btnSendTicket = new Button();
            btnExit = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(12, 9);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(95, 25);
            lblUser.TabIndex = 0;
            lblUser.Text = "Example";
            // 
            // btnSignUp
            // 
            btnSignUp.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSignUp.Location = new Point(85, 131);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(280, 89);
            btnSignUp.TabIndex = 1;
            btnSignUp.Text = "Inscribir Postulante";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnListMembers
            // 
            btnListMembers.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnListMembers.Location = new Point(428, 131);
            btnListMembers.Name = "btnListMembers";
            btnListMembers.Size = new Size(280, 89);
            btnListMembers.TabIndex = 2;
            btnListMembers.Text = "Listar socios";
            btnListMembers.UseVisualStyleBackColor = true;
            btnListMembers.Click += btnListMembers_Click;
            // 
            // btnPayCourse
            // 
            btnPayCourse.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPayCourse.Location = new Point(85, 272);
            btnPayCourse.Name = "btnPayCourse";
            btnPayCourse.Size = new Size(280, 89);
            btnPayCourse.TabIndex = 3;
            btnPayCourse.Text = "Realizar pago";
            btnPayCourse.UseVisualStyleBackColor = true;
            btnPayCourse.Click += btnPayCourse_Click;
            // 
            // btnSendTicket
            // 
            btnSendTicket.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSendTicket.Location = new Point(428, 272);
            btnSendTicket.Name = "btnSendTicket";
            btnSendTicket.Size = new Size(280, 89);
            btnSendTicket.TabIndex = 4;
            btnSendTicket.Text = "Emitir Comprobante de Curso";
            btnSendTicket.UseVisualStyleBackColor = true;
            btnSendTicket.Click += btnSendTicket_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(676, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 40);
            btnExit.TabIndex = 5;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(558, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 40);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnExit);
            Controls.Add(btnSendTicket);
            Controls.Add(btnPayCourse);
            Controls.Add(btnListMembers);
            Controls.Add(btnSignUp);
            Controls.Add(lblUser);
            Name = "HomeScreen";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
		private Button btnSignUp;
		private Button btnListMembers;
		private Button btnPayCourse;
		private Button btnSendTicket;
		private Button btnExit;
		private Button btnLogout;
	}
}

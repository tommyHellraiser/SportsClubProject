namespace SportsClubProject.Forms
{
    partial class NonPostulantLog
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
			btnBack = new Button();
			btnClean = new Button();
			btnEnter = new Button();
			txtLastName = new TextBox();
			txtName = new TextBox();
			txtDni = new TextBox();
			cboType = new ComboBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			SuspendLayout();
			// 
			// btnBack
			// 
			btnBack.Location = new Point(390, 320);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(141, 36);
			btnBack.TabIndex = 7;
			btnBack.Text = "Volver";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += btnBack_Click;
			// 
			// btnClean
			// 
			btnClean.Location = new Point(221, 320);
			btnClean.Name = "btnClean";
			btnClean.Size = new Size(141, 36);
			btnClean.TabIndex = 6;
			btnClean.Text = "Limpiar";
			btnClean.UseVisualStyleBackColor = true;
			btnClean.Click += btnClean_Click;
			// 
			// btnEnter
			// 
			btnEnter.Location = new Point(43, 320);
			btnEnter.Name = "btnEnter";
			btnEnter.Size = new Size(141, 36);
			btnEnter.TabIndex = 5;
			btnEnter.Text = "Ingresar";
			btnEnter.UseVisualStyleBackColor = true;
			btnEnter.Click += btnEnter_Click;
			// 
			// txtLastName
			// 
			txtLastName.Location = new Point(175, 138);
			txtLastName.Name = "txtLastName";
			txtLastName.Size = new Size(247, 25);
			txtLastName.TabIndex = 2;
			// 
			// txtName
			// 
			txtName.Location = new Point(175, 91);
			txtName.Name = "txtName";
			txtName.Size = new Size(247, 25);
			txtName.TabIndex = 1;
			// 
			// txtDni
			// 
			txtDni.Location = new Point(318, 210);
			txtDni.Name = "txtDni";
			txtDni.Size = new Size(180, 25);
			txtDni.TabIndex = 4;
			// 
			// cboType
			// 
			cboType.FormattingEnabled = true;
			cboType.Items.AddRange(new object[] { "DNI" });
			cboType.Location = new Point(69, 210);
			cboType.Name = "cboType";
			cboType.Size = new Size(138, 25);
			cboType.TabIndex = 3;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(268, 214);
			label5.Name = "label5";
			label5.Size = new Size(31, 17);
			label5.TabIndex = 16;
			label5.Text = "DNI";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(19, 214);
			label4.Name = "label4";
			label4.Size = new Size(34, 17);
			label4.TabIndex = 14;
			label4.Text = "Tipo";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(87, 147);
			label3.Name = "label3";
			label3.Size = new Size(57, 17);
			label3.TabIndex = 12;
			label3.Text = "Apellido";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(87, 95);
			label2.Name = "label2";
			label2.Size = new Size(58, 17);
			label2.TabIndex = 10;
			label2.Text = "Nombre";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(210, 18);
			label1.Name = "label1";
			label1.Size = new Size(142, 21);
			label1.TabIndex = 8;
			label1.Text = "DATOS NO SOCIO";
			// 
			// NonPostulantLog
			// 
			AutoScaleDimensions = new SizeF(8F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 128, 0);
			ClientSize = new Size(556, 377);
			Controls.Add(btnBack);
			Controls.Add(btnClean);
			Controls.Add(btnEnter);
			Controls.Add(txtLastName);
			Controls.Add(txtName);
			Controls.Add(txtDni);
			Controls.Add(cboType);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Name = "NonPostulantLog";
			Text = "Log";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnBack;
		private Button btnClean;
		private Button btnEnter;
		private TextBox txtLastName;
		private TextBox txtName;
		private TextBox txtDni;
		private ComboBox cboType;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
	}
}
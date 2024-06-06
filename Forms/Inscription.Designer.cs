namespace SportsClubProject.Forms
{
    partial class Inscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscription));
            pictureBox1 = new PictureBox();
            btnBack = new Button();
            btnClean = new Button();
            btnEnter = new Button();
            txtLastName = new TextBox();
            txtName = new TextBox();
            txtDni = new TextBox();
            cboType = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ckBoxHealth = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(684, 327);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(141, 36);
            btnBack.TabIndex = 7;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(515, 327);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(141, 36);
            btnClean.TabIndex = 6;
            btnClean.Text = "Limpiar";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(337, 327);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(141, 36);
            btnEnter.TabIndex = 5;
            btnEnter.Text = "Ingresar";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(469, 145);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(247, 25);
            txtLastName.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(469, 98);
            txtName.Name = "txtName";
            txtName.Size = new Size(247, 25);
            txtName.TabIndex = 1;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(536, 239);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(180, 25);
            txtDni.TabIndex = 4;
            // 
            // cboType
            // 
            cboType.FormattingEnabled = true;
            cboType.Items.AddRange(new object[] { "DNI" });
            cboType.Location = new Point(334, 239);
            cboType.Name = "cboType";
            cboType.Size = new Size(138, 25);
            cboType.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(486, 243);
            label6.Name = "label6";
            label6.Size = new Size(31, 17);
            label6.TabIndex = 21;
            label6.Text = "DNI";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(284, 243);
            label7.Name = "label7";
            label7.Size = new Size(34, 17);
            label7.TabIndex = 19;
            label7.Text = "Tipo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(381, 154);
            label8.Name = "label8";
            label8.Size = new Size(57, 17);
            label8.TabIndex = 17;
            label8.Text = "Apellido";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(381, 102);
            label9.Name = "label9";
            label9.Size = new Size(58, 17);
            label9.TabIndex = 15;
            label9.Text = "Nombre";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(349, 22);
            label10.Name = "label10";
            label10.Size = new Size(112, 21);
            label10.TabIndex = 13;
            label10.Text = "INSCRIPCIÓN";
            // 
            // ckBoxHealth
            // 
            ckBoxHealth.AutoSize = true;
            ckBoxHealth.Location = new Point(745, 243);
            ckBoxHealth.Name = "ckBoxHealth";
            ckBoxHealth.Size = new Size(91, 21);
            ckBoxHealth.TabIndex = 26;
            ckBoxHealth.Text = "Apto fisico";
            ckBoxHealth.UseVisualStyleBackColor = true;
            // 
            // Inscription
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(850, 400);
            Controls.Add(ckBoxHealth);
            Controls.Add(pictureBox1);
            Controls.Add(btnBack);
            Controls.Add(btnClean);
            Controls.Add(btnEnter);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(txtDni);
            Controls.Add(cboType);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Inscription";
            Text = "Inscription";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
		private Button btnBack;
		private Button btnClean;
		private Button btnEnter;
		private TextBox txtLastName;
		private TextBox txtName;
		private TextBox txtDni;
		private ComboBox cboType;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label label10;
        private CheckBox ckBoxHealth;
    }
}
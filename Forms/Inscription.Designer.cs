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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cboType = new ComboBox();
            txtDni = new TextBox();
            txtName = new TextBox();
            txtLastName = new TextBox();
            btnEnter = new Button();
            btnClean = new Button();
            btnBack = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(408, 53);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 0;
            label1.Text = "INSCRIPCIÓN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(440, 133);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(440, 185);
            label3.Name = "label3";
            label3.Size = new Size(57, 17);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(372, 252);
            label4.Name = "label4";
            label4.Size = new Size(34, 17);
            label4.TabIndex = 3;
            label4.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(621, 252);
            label5.Name = "label5";
            label5.Size = new Size(31, 17);
            label5.TabIndex = 4;
            label5.Text = "DNI";
            // 
            // cboType
            // 
            cboType.FormattingEnabled = true;
            cboType.Items.AddRange(new object[] { "DNI" });
            cboType.Location = new Point(422, 248);
            cboType.Name = "cboType";
            cboType.Size = new Size(138, 25);
            cboType.TabIndex = 5;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(671, 248);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(180, 25);
            txtDni.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(528, 129);
            txtName.Name = "txtName";
            txtName.Size = new Size(247, 25);
            txtName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(528, 176);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(247, 25);
            txtLastName.TabIndex = 8;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(396, 358);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(141, 36);
            btnEnter.TabIndex = 9;
            btnEnter.Text = "Ingresar";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(574, 358);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(141, 36);
            btnClean.TabIndex = 10;
            btnClean.Text = "Limpiar";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(743, 358);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(141, 36);
            btnBack.TabIndex = 11;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(76, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Inscription
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(903, 510);
            Controls.Add(pictureBox1);
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
            Name = "Inscription";
            Text = "Inscription";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cboType;
        private TextBox txtDni;
        private TextBox txtName;
        private TextBox txtLastName;
        private Button btnEnter;
        private Button btnClean;
        private Button btnBack;
        private PictureBox pictureBox1;
    }
}
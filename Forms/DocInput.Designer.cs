namespace SportsClubProject.Forms
{
    partial class DocInput
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
            label2 = new Label();
            txtDocN = new TextBox();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 40);
            label2.Name = "label2";
            label2.Size = new Size(354, 21);
            label2.TabIndex = 3;
            label2.Text = "INGRESE NUMERO DE DOCUMENTO DEL SOCIO";
            // 
            // txtDocN
            // 
            txtDocN.Location = new Point(128, 105);
            txtDocN.Name = "txtDocN";
            txtDocN.Size = new Size(247, 23);
            txtDocN.TabIndex = 4;
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.Location = new Point(186, 173);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(141, 36);
            btnEnter.TabIndex = 6;
            btnEnter.Text = "Ingresar";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // DocInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(513, 249);
            Controls.Add(btnEnter);
            Controls.Add(txtDocN);
            Controls.Add(label2);
            Name = "DocInput";
            Text = "DocInput";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtDocN;
        private Button btnEnter;
    }
}
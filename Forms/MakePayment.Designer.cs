namespace SportsClubProject.Forms
{
    partial class MakePayment
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
            lblListMemb = new Label();
            txtNInsc = new TextBox();
            btnPay = new Button();
            btnBill = new Button();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            rbtnCash = new RadioButton();
            btnBack = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblListMemb
            // 
            lblListMemb.AutoSize = true;
            lblListMemb.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblListMemb.Location = new Point(86, 51);
            lblListMemb.Name = "lblListMemb";
            lblListMemb.Size = new Size(220, 20);
            lblListMemb.TabIndex = 2;
            lblListMemb.Text = "Ingrese numero de inscripción";
            lblListMemb.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNInsc
            // 
            txtNInsc.Location = new Point(105, 99);
            txtNInsc.Name = "txtNInsc";
            txtNInsc.Size = new Size(180, 23);
            txtNInsc.TabIndex = 3;
            // 
            // btnPay
            // 
            btnPay.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnPay.Location = new Point(129, 163);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(130, 36);
            btnPay.TabIndex = 5;
            btnPay.Text = "PAGAR";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // btnBill
            // 
            btnBill.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnBill.Location = new Point(129, 238);
            btnBill.Name = "btnBill";
            btnBill.Size = new Size(130, 36);
            btnBill.TabIndex = 6;
            btnBill.Text = "COMPROBANTE";
            btnBill.UseVisualStyleBackColor = true;
            btnBill.Click += btnBill_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkOrange;
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(rbtnCash);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            groupBox1.Location = new Point(455, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 112);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de pago";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 69);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 20);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Tarjeta";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbtnCash
            // 
            rbtnCash.AutoSize = true;
            rbtnCash.Location = new Point(6, 33);
            rbtnCash.Name = "rbtnCash";
            rbtnCash.Size = new Size(81, 20);
            rbtnCash.TabIndex = 0;
            rbtnCash.TabStop = true;
            rbtnCash.Text = "Efectivo";
            rbtnCash.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnBack.Location = new Point(455, 238);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(130, 36);
            btnBack.TabIndex = 8;
            btnBack.Text = "VOLVER";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += button2_Click;
            // 
            // MakePayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(750, 327);
            Controls.Add(btnBack);
            Controls.Add(groupBox1);
            Controls.Add(btnBill);
            Controls.Add(btnPay);
            Controls.Add(txtNInsc);
            Controls.Add(lblListMemb);
            Name = "MakePayment";
            Text = "MakePayment";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListMemb;
        private TextBox txtNInsc;
        private Button btnPay;
        private Button btnBill;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton rbtnCash;
        private Button btnBack;
    }
}
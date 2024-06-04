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
			rbtnCard = new RadioButton();
			rbtnCash = new RadioButton();
			btnBack = new Button();
			txtAmount = new TextBox();
			label1 = new Label();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// lblListMemb
			// 
			lblListMemb.AutoSize = true;
			lblListMemb.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			lblListMemb.Location = new Point(86, 35);
			lblListMemb.Name = "lblListMemb";
			lblListMemb.Size = new Size(225, 20);
			lblListMemb.TabIndex = 2;
			lblListMemb.Text = "Ingrese numero de documento";
			lblListMemb.TextAlign = ContentAlignment.TopCenter;
			// 
			// txtNInsc
			// 
			txtNInsc.Location = new Point(105, 74);
			txtNInsc.Name = "txtNInsc";
			txtNInsc.Size = new Size(180, 23);
			txtNInsc.TabIndex = 1;
			// 
			// btnPay
			// 
			btnPay.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			btnPay.Location = new Point(133, 222);
			btnPay.Name = "btnPay";
			btnPay.Size = new Size(130, 36);
			btnPay.TabIndex = 5;
			btnPay.Text = "PAGAR";
			btnPay.UseVisualStyleBackColor = true;
			btnPay.Click += btnPay_Click;
			// 
			// btnBill
			// 
			btnBill.Enabled = false;
			btnBill.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			btnBill.Location = new Point(133, 264);
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
			groupBox1.Controls.Add(rbtnCard);
			groupBox1.Controls.Add(rbtnCash);
			groupBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
			groupBox1.Location = new Point(455, 51);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(200, 112);
			groupBox1.TabIndex = 7;
			groupBox1.TabStop = false;
			groupBox1.Text = "Forma de pago";
			// 
			// rbtnCard
			// 
			rbtnCard.AutoSize = true;
			rbtnCard.Location = new Point(6, 69);
			rbtnCard.Name = "rbtnCard";
			rbtnCard.Size = new Size(75, 20);
			rbtnCard.TabIndex = 4;
			rbtnCard.TabStop = true;
			rbtnCard.Text = "Tarjeta";
			rbtnCard.UseVisualStyleBackColor = true;
			// 
			// rbtnCash
			// 
			rbtnCash.AutoSize = true;
			rbtnCash.Location = new Point(6, 33);
			rbtnCash.Name = "rbtnCash";
			rbtnCash.Size = new Size(81, 20);
			rbtnCash.TabIndex = 3;
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
			btnBack.TabIndex = 7;
			btnBack.Text = "VOLVER";
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += btnBack_Click;
			// 
			// txtAmount
			// 
			txtAmount.Location = new Point(105, 168);
			txtAmount.Name = "txtAmount";
			txtAmount.Size = new Size(180, 23);
			txtAmount.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			label1.Location = new Point(105, 133);
			label1.Name = "label1";
			label1.Size = new Size(168, 20);
			label1.TabIndex = 9;
			label1.Text = "Ingrese monto a pagar";
			label1.TextAlign = ContentAlignment.TopCenter;
			// 
			// MakePayment
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 128, 0);
			ClientSize = new Size(750, 327);
			Controls.Add(txtAmount);
			Controls.Add(label1);
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
        private RadioButton rbtnCard;
        private RadioButton rbtnCash;
        private Button btnBack;
        private TextBox txtAmount;
        private Label label1;
    }
}
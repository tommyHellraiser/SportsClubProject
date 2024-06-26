﻿namespace SportsClubProject.Forms
{
    partial class Bill
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
			panel1 = new Panel();
			lblDateToday = new Label();
			pictureBox1 = new PictureBox();
			label1 = new Label();
			lblListMemb = new Label();
			panel2 = new Panel();
			lblNameInBill = new Label();
			lblAmount = new Label();
			label4 = new Label();
			lblFormPay = new Label();
			label3 = new Label();
			lblStartDate = new Label();
			lblDate = new Label();
			lblName = new Label();
			btnPrint = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(255, 192, 128);
			panel1.Controls.Add(lblDateToday);
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(lblListMemb);
			panel1.Location = new Point(87, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(631, 156);
			panel1.TabIndex = 0;
			// 
			// lblDateToday
			// 
			lblDateToday.AutoSize = true;
			lblDateToday.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblDateToday.Location = new Point(426, 58);
			lblDateToday.Name = "lblDateToday";
			lblDateToday.Size = new Size(52, 17);
			lblDateToday.TabIndex = 5;
			lblDateToday.Text = "FECHA:";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.Deportivo_Mandiyu;
			pictureBox1.Location = new Point(260, 46);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(111, 92);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			label1.Location = new Point(14, 56);
			label1.Name = "label1";
			label1.Size = new Size(212, 20);
			label1.TabIndex = 3;
			label1.Text = "CLUB DEPORTIVO MANDIYÚ";
			label1.TextAlign = ContentAlignment.TopCenter;
			// 
			// lblListMemb
			// 
			lblListMemb.AutoSize = true;
			lblListMemb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblListMemb.Location = new Point(208, 12);
			lblListMemb.Name = "lblListMemb";
			lblListMemb.Size = new Size(203, 21);
			lblListMemb.TabIndex = 2;
			lblListMemb.Text = "COMPROBANTE DE PAGO";
			lblListMemb.TextAlign = ContentAlignment.TopCenter;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(255, 192, 128);
			panel2.Controls.Add(lblNameInBill);
			panel2.Controls.Add(lblAmount);
			panel2.Controls.Add(label4);
			panel2.Controls.Add(lblFormPay);
			panel2.Controls.Add(label3);
			panel2.Controls.Add(lblStartDate);
			panel2.Controls.Add(lblDate);
			panel2.Controls.Add(lblName);
			panel2.Location = new Point(87, 193);
			panel2.Name = "panel2";
			panel2.Size = new Size(631, 156);
			panel2.TabIndex = 1;
			// 
			// lblNameInBill
			// 
			lblNameInBill.AutoSize = true;
			lblNameInBill.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblNameInBill.Location = new Point(327, 19);
			lblNameInBill.Name = "lblNameInBill";
			lblNameInBill.Size = new Size(63, 17);
			lblNameInBill.TabIndex = 13;
			lblNameInBill.Text = "NOMBRE";
			// 
			// lblAmount
			// 
			lblAmount.AutoSize = true;
			lblAmount.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblAmount.Location = new Point(327, 114);
			lblAmount.Name = "lblAmount";
			lblAmount.Size = new Size(22, 17);
			lblAmount.TabIndex = 12;
			lblAmount.Text = "$$";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.Location = new Point(81, 114);
			label4.Name = "label4";
			label4.Size = new Size(56, 17);
			label4.TabIndex = 11;
			label4.Text = "MONTO";
			// 
			// lblFormPay
			// 
			lblFormPay.AutoSize = true;
			lblFormPay.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblFormPay.Location = new Point(327, 83);
			lblFormPay.Name = "lblFormPay";
			lblFormPay.Size = new Size(54, 17);
			lblFormPay.TabIndex = 10;
			lblFormPay.Text = "FORMA";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(81, 83);
			label3.Name = "label3";
			label3.Size = new Size(116, 17);
			label3.TabIndex = 9;
			label3.Text = "FORMA DE PAGO:";
			// 
			// lblStartDate
			// 
			lblStartDate.AutoSize = true;
			lblStartDate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblStartDate.Location = new Point(327, 50);
			lblStartDate.Name = "lblStartDate";
			lblStartDate.Size = new Size(142, 17);
			lblStartDate.TabIndex = 8;
			lblStartDate.Text = "FECHA DE COMIENZO";
			// 
			// lblDate
			// 
			lblDate.AutoSize = true;
			lblDate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblDate.Location = new Point(81, 50);
			lblDate.Name = "lblDate";
			lblDate.Size = new Size(145, 17);
			lblDate.TabIndex = 7;
			lblDate.Text = "FECHA DE COMIENZO:";
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblName.Location = new Point(81, 19);
			lblName.Name = "lblName";
			lblName.Size = new Size(66, 17);
			lblName.TabIndex = 6;
			lblName.Text = "NOMBRE:";
			// 
			// btnPrint
			// 
			btnPrint.BackColor = SystemColors.GradientInactiveCaption;
			btnPrint.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
			btnPrint.Location = new Point(588, 365);
			btnPrint.Name = "btnPrint";
			btnPrint.Size = new Size(130, 36);
			btnPrint.TabIndex = 13;
			btnPrint.Text = "IMPRIMIR";
			btnPrint.UseVisualStyleBackColor = false;
			btnPrint.Click += btnPrint_Click;
			// 
			// Bill
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.InactiveCaption;
			ClientSize = new Size(800, 450);
			Controls.Add(btnPrint);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "Bill";
			Text = "Bill";
			Load += Bill_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
        private Panel panel2;
        private Label lblListMemb;
        private Label label1;
        private Label lblDateToday;
        private PictureBox pictureBox1;
        private Label lblName;
        private Label lblFormPay;
        private Label label3;
        private Label lblStartDate;
        private Label lblDate;
        private Label lblAmount;
        private Label label4;
        private Button btnPrint;
		private Label lblNameInBill;
	}
}
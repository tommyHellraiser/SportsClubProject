namespace SportsClubProject.Forms
{
    partial class ListMembers
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
            dtgvListMemb = new DataGridView();
            cellName = new DataGridViewTextBoxColumn();
            cellLastName = new DataGridViewTextBoxColumn();
            cellType = new DataGridViewTextBoxColumn();
            cellNDoc = new DataGridViewTextBoxColumn();
            cellDateInscription = new DataGridViewTextBoxColumn();
            cellDateExp = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvListMemb).BeginInit();
            SuspendLayout();
            // 
            // dtgvListMemb
            // 
            dtgvListMemb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListMemb.Columns.AddRange(new DataGridViewColumn[] { cellName, cellLastName, cellType, cellNDoc, cellDateInscription, cellDateExp });
            dtgvListMemb.Location = new Point(58, 96);
            dtgvListMemb.Name = "dtgvListMemb";
            dtgvListMemb.Size = new Size(694, 150);
            dtgvListMemb.TabIndex = 0;
            // 
            // cellName
            // 
            cellName.HeaderText = "NOMBRE";
            cellName.Name = "cellName";
            // 
            // cellLastName
            // 
            cellLastName.HeaderText = "APELLIDO";
            cellLastName.Name = "cellLastName";
            // 
            // cellType
            // 
            cellType.HeaderText = "TIPO DE DOC.";
            cellType.Name = "cellType";
            cellType.Width = 110;
            // 
            // cellNDoc
            // 
            cellNDoc.HeaderText = "NUM. DE DOC.";
            cellNDoc.Name = "cellNDoc";
            cellNDoc.Width = 120;
            // 
            // cellDateInscription
            // 
            cellDateInscription.HeaderText = "F. INSCRIPCIÓN";
            cellDateInscription.Name = "cellDateInscription";
            // 
            // cellDateExp
            // 
            cellDateExp.HeaderText = "F. VENCIMIENTO";
            cellDateExp.Name = "cellDateExp";
            cellDateExp.Width = 120;
            // 
            // ListMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(dtgvListMemb);
            Name = "ListMembers";
            Text = "ListMembers";
            Load += ListMembers_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvListMemb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvListMemb;
        private DataGridViewTextBoxColumn cellName;
        private DataGridViewTextBoxColumn cellLastName;
        private DataGridViewTextBoxColumn cellType;
        private DataGridViewTextBoxColumn cellNDoc;
        private DataGridViewTextBoxColumn cellDateInscription;
        private DataGridViewTextBoxColumn cellDateExp;
    }
}
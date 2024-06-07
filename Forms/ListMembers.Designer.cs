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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dtgvListMemb = new DataGridView();
            cellNMember = new DataGridViewTextBoxColumn();
            cellName = new DataGridViewTextBoxColumn();
            cellLastName = new DataGridViewTextBoxColumn();
            cellType = new DataGridViewTextBoxColumn();
            cellNDoc = new DataGridViewTextBoxColumn();
            cellDateInscription = new DataGridViewTextBoxColumn();
            cellDateExp = new DataGridViewTextBoxColumn();
            CellCert = new DataGridViewTextBoxColumn();
            CellActive = new DataGridViewTextBoxColumn();
            lblListMemb = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvListMemb).BeginInit();
            SuspendLayout();
            // 
            // dtgvListMemb
            // 
            dtgvListMemb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvListMemb.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvListMemb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvListMemb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvListMemb.Columns.AddRange(new DataGridViewColumn[] { cellNMember, cellName, cellLastName, cellType, cellNDoc, cellDateInscription, cellDateExp, CellCert, CellActive });
            dtgvListMemb.Location = new Point(12, 96);
            dtgvListMemb.Name = "dtgvListMemb";
            dtgvListMemb.Size = new Size(873, 211);
            dtgvListMemb.TabIndex = 0;
            // 
            // cellNMember
            // 
            cellNMember.HeaderText = "NUM. DE SOCIO";
            cellNMember.Name = "cellNMember";
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
            // 
            // cellNDoc
            // 
            cellNDoc.HeaderText = "NUM. DE DOC.";
            cellNDoc.Name = "cellNDoc";
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
            // 
            // CellCert
            // 
            CellCert.HeaderText = "APTO FÍSICO";
            CellCert.Name = "CellCert";
            // 
            // CellActive
            // 
            CellActive.HeaderText = "ESTADO";
            CellActive.Name = "CellActive";
            // 
            // lblListMemb
            // 
            lblListMemb.AutoSize = true;
            lblListMemb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListMemb.Location = new Point(309, 29);
            lblListMemb.Name = "lblListMemb";
            lblListMemb.Size = new Size(238, 21);
            lblListMemb.TabIndex = 1;
            lblListMemb.Text = "LISTADO DE SOCIOS DEL CLUB";
            lblListMemb.TextAlign = ContentAlignment.TopCenter;
            // 
            // ListMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(897, 450);
            Controls.Add(lblListMemb);
            Controls.Add(dtgvListMemb);
            Name = "ListMembers";
            Text = "ListMembers";
            Load += ListMembers_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvListMemb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvListMemb;
        private Label lblListMemb;
        private DataGridViewTextBoxColumn cellNMember;
        private DataGridViewTextBoxColumn cellName;
        private DataGridViewTextBoxColumn cellLastName;
        private DataGridViewTextBoxColumn cellType;
        private DataGridViewTextBoxColumn cellNDoc;
        private DataGridViewTextBoxColumn cellDateInscription;
        private DataGridViewTextBoxColumn cellDateExp;
        private DataGridViewTextBoxColumn CellCert;
        private DataGridViewTextBoxColumn CellActive;
    }
}
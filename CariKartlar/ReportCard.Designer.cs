namespace CariKartlar
{
    partial class ReportCard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridViewUnpaid = new System.Windows.Forms.DataGridView();
            this.DebtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reminder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewPaid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCurrentCode = new System.Windows.Forms.Label();
            this.labelCurrentName = new System.Windows.Forms.Label();
            this.buttonCreateCSVReport = new System.Windows.Forms.Button();
            this.buttonCreateExcelReport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnpaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label20.Location = new System.Drawing.Point(371, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 25);
            this.label20.TabIndex = 23;
            this.label20.Text = "Cari Adı:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label21.Location = new System.Drawing.Point(16, 58);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(126, 25);
            this.label21.TabIndex = 22;
            this.label21.Text = "Cari Kodu:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label10.Location = new System.Drawing.Point(184, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 32);
            this.label10.TabIndex = 37;
            this.label10.Text = "Borç Dökümü";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label11.Location = new System.Drawing.Point(682, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(377, 32);
            this.label11.TabIndex = 38;
            this.label11.Text = "Ödemesi Tamamlanan Borçlar";
            // 
            // dataGridViewUnpaid
            // 
            this.dataGridViewUnpaid.AllowUserToAddRows = false;
            this.dataGridViewUnpaid.AllowUserToDeleteRows = false;
            this.dataGridViewUnpaid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewUnpaid.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUnpaid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUnpaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnpaid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DebtAmount,
            this.PaidDebt,
            this.Reminder,
            this.Date});
            this.dataGridViewUnpaid.EnableHeadersVisualStyles = false;
            this.dataGridViewUnpaid.Location = new System.Drawing.Point(12, 251);
            this.dataGridViewUnpaid.MultiSelect = false;
            this.dataGridViewUnpaid.Name = "dataGridViewUnpaid";
            this.dataGridViewUnpaid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUnpaid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUnpaid.RowHeadersWidth = 51;
            this.dataGridViewUnpaid.RowTemplate.Height = 29;
            this.dataGridViewUnpaid.Size = new System.Drawing.Size(561, 553);
            this.dataGridViewUnpaid.TabIndex = 39;
            // 
            // DebtAmount
            // 
            this.DebtAmount.HeaderText = "Borç";
            this.DebtAmount.MinimumWidth = 6;
            this.DebtAmount.Name = "DebtAmount";
            this.DebtAmount.ReadOnly = true;
            this.DebtAmount.Width = 125;
            // 
            // PaidDebt
            // 
            this.PaidDebt.HeaderText = "ÖdenenBorç";
            this.PaidDebt.MinimumWidth = 6;
            this.PaidDebt.Name = "PaidDebt";
            this.PaidDebt.ReadOnly = true;
            this.PaidDebt.Width = 125;
            // 
            // Reminder
            // 
            this.Reminder.HeaderText = "Kalan";
            this.Reminder.MinimumWidth = 6;
            this.Reminder.Name = "Reminder";
            this.Reminder.ReadOnly = true;
            this.Reminder.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Son Ödeme Tarihi";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // dataGridViewPaid
            // 
            this.dataGridViewPaid.AllowUserToAddRows = false;
            this.dataGridViewPaid.AllowUserToDeleteRows = false;
            this.dataGridViewPaid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewPaid.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPaid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewPaid.EnableHeadersVisualStyles = false;
            this.dataGridViewPaid.Location = new System.Drawing.Point(596, 251);
            this.dataGridViewPaid.MultiSelect = false;
            this.dataGridViewPaid.Name = "dataGridViewPaid";
            this.dataGridViewPaid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPaid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPaid.RowHeadersWidth = 51;
            this.dataGridViewPaid.RowTemplate.Height = 29;
            this.dataGridViewPaid.Size = new System.Drawing.Size(561, 553);
            this.dataGridViewPaid.TabIndex = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Borç";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Ödenen Borç";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Kalan";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Son Ödeme Tarihi";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // labelCurrentCode
            // 
            this.labelCurrentCode.AutoSize = true;
            this.labelCurrentCode.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentCode.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelCurrentCode.Location = new System.Drawing.Point(149, 58);
            this.labelCurrentCode.Name = "labelCurrentCode";
            this.labelCurrentCode.Size = new System.Drawing.Size(58, 25);
            this.labelCurrentCode.TabIndex = 41;
            this.labelCurrentCode.Text = "label";
            // 
            // labelCurrentName
            // 
            this.labelCurrentName.AutoSize = true;
            this.labelCurrentName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentName.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelCurrentName.Location = new System.Drawing.Point(504, 58);
            this.labelCurrentName.Name = "labelCurrentName";
            this.labelCurrentName.Size = new System.Drawing.Size(58, 25);
            this.labelCurrentName.TabIndex = 42;
            this.labelCurrentName.Text = "label";
            // 
            // buttonCreateCSVReport
            // 
            this.buttonCreateCSVReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCreateCSVReport.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonCreateCSVReport.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateCSVReport.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCreateCSVReport.Location = new System.Drawing.Point(442, 11);
            this.buttonCreateCSVReport.Name = "buttonCreateCSVReport";
            this.buttonCreateCSVReport.Size = new System.Drawing.Size(132, 72);
            this.buttonCreateCSVReport.TabIndex = 56;
            this.buttonCreateCSVReport.Text = "CSV Rapor Oluştur";
            this.buttonCreateCSVReport.UseVisualStyleBackColor = false;
            this.buttonCreateCSVReport.Click += new System.EventHandler(this.buttonCreateCSVReport_Click);
            // 
            // buttonCreateExcelReport
            // 
            this.buttonCreateExcelReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCreateExcelReport.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonCreateExcelReport.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateExcelReport.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCreateExcelReport.Location = new System.Drawing.Point(629, 11);
            this.buttonCreateExcelReport.Name = "buttonCreateExcelReport";
            this.buttonCreateExcelReport.Size = new System.Drawing.Size(132, 72);
            this.buttonCreateExcelReport.TabIndex = 57;
            this.buttonCreateExcelReport.Text = "Excel Rapor Oluştur";
            this.buttonCreateExcelReport.UseVisualStyleBackColor = false;
            this.buttonCreateExcelReport.Click += new System.EventHandler(this.buttonCreateExcelReport_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonCreateCSVReport);
            this.panel1.Controls.Add(this.buttonCreateExcelReport);
            this.panel1.Location = new System.Drawing.Point(-16, 854);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 107);
            this.panel1.TabIndex = 58;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.labelCurrentName);
            this.panel2.Controls.Add(this.labelCurrentCode);
            this.panel2.Location = new System.Drawing.Point(311, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 92);
            this.panel2.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(389, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 35);
            this.label1.TabIndex = 43;
            this.label1.Text = "Cari Borç Dökümü Rapor Ekranı";
            // 
            // ReportCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1169, 951);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewPaid);
            this.Controls.Add(this.dataGridViewUnpaid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Name = "ReportCard";
            this.Text = "ReportCard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnpaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label20;
        private Label label21;
        private Label label10;
        private Label label11;
        private DataGridView dataGridViewUnpaid;
        private DataGridView dataGridViewPaid;
        private Label labelCurrentCode;
        private Label labelCurrentName;
        private DataGridViewTextBoxColumn DebtAmount;
        private DataGridViewTextBoxColumn PaidDebt;
        private DataGridViewTextBoxColumn Reminder;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button buttonCreateCSVReport;
        private Button buttonCreateExcelReport;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
    }
}
namespace CariKartlar
{
    partial class Dashboard
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
            this.dataGridViewPaidDebt = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewUnpaidDebt = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reminder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPaid = new System.Windows.Forms.Label();
            this.labelUnpaid = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelUnpaid = new System.Windows.Forms.Panel();
            this.panelPaid = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPaidPercent = new System.Windows.Forms.Label();
            this.labelUnpaidPercent = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaidDebt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnpaidDebt)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPaidDebt
            // 
            this.dataGridViewPaidDebt.AllowUserToAddRows = false;
            this.dataGridViewPaidDebt.AllowUserToDeleteRows = false;
            this.dataGridViewPaidDebt.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPaidDebt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPaidDebt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaidDebt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CurrentCode,
            this.CurrentName,
            this.DebtAmount,
            this.PaidDebt,
            this.Date});
            this.dataGridViewPaidDebt.EnableHeadersVisualStyles = false;
            this.dataGridViewPaidDebt.Location = new System.Drawing.Point(12, 67);
            this.dataGridViewPaidDebt.MultiSelect = false;
            this.dataGridViewPaidDebt.Name = "dataGridViewPaidDebt";
            this.dataGridViewPaidDebt.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPaidDebt.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPaidDebt.RowHeadersWidth = 51;
            this.dataGridViewPaidDebt.RowTemplate.Height = 29;
            this.dataGridViewPaidDebt.Size = new System.Drawing.Size(556, 168);
            this.dataGridViewPaidDebt.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // CurrentCode
            // 
            this.CurrentCode.HeaderText = "Cari Kodu";
            this.CurrentCode.MinimumWidth = 6;
            this.CurrentCode.Name = "CurrentCode";
            this.CurrentCode.ReadOnly = true;
            this.CurrentCode.Width = 125;
            // 
            // CurrentName
            // 
            this.CurrentName.HeaderText = "Cari Adı";
            this.CurrentName.MinimumWidth = 6;
            this.CurrentName.Name = "CurrentName";
            this.CurrentName.ReadOnly = true;
            this.CurrentName.Width = 125;
            // 
            // DebtAmount
            // 
            this.DebtAmount.HeaderText = "Borç Miktarı";
            this.DebtAmount.MinimumWidth = 6;
            this.DebtAmount.Name = "DebtAmount";
            this.DebtAmount.ReadOnly = true;
            this.DebtAmount.Width = 125;
            // 
            // PaidDebt
            // 
            this.PaidDebt.HeaderText = "Ödenen Borç";
            this.PaidDebt.MinimumWidth = 6;
            this.PaidDebt.Name = "PaidDebt";
            this.PaidDebt.ReadOnly = true;
            this.PaidDebt.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Son Ödeme Tarihi";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ödenmiş Borçlar";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ödenmemiş Borçlar";
            // 
            // dataGridViewUnpaidDebt
            // 
            this.dataGridViewUnpaidDebt.AllowUserToAddRows = false;
            this.dataGridViewUnpaidDebt.AllowUserToDeleteRows = false;
            this.dataGridViewUnpaidDebt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewUnpaidDebt.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUnpaidDebt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewUnpaidDebt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnpaidDebt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Reminder,
            this.Data});
            this.dataGridViewUnpaidDebt.EnableHeadersVisualStyles = false;
            this.dataGridViewUnpaidDebt.Location = new System.Drawing.Point(12, 342);
            this.dataGridViewUnpaidDebt.MultiSelect = false;
            this.dataGridViewUnpaidDebt.Name = "dataGridViewUnpaidDebt";
            this.dataGridViewUnpaidDebt.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUnpaidDebt.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewUnpaidDebt.RowHeadersWidth = 51;
            this.dataGridViewUnpaidDebt.RowTemplate.Height = 29;
            this.dataGridViewUnpaidDebt.Size = new System.Drawing.Size(556, 168);
            this.dataGridViewUnpaidDebt.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Cari Kodu";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cari Adı";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Borç Miktarı";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Ödenen Borç";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // Reminder
            // 
            this.Reminder.HeaderText = "Kalan Borç";
            this.Reminder.MinimumWidth = 6;
            this.Reminder.Name = "Reminder";
            this.Reminder.ReadOnly = true;
            this.Reminder.Width = 125;
            // 
            // Data
            // 
            this.Data.HeaderText = "Son Ödeme Tarihi";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Toplam Ödenen:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Toplam Borç:";
            // 
            // labelPaid
            // 
            this.labelPaid.AutoSize = true;
            this.labelPaid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPaid.Location = new System.Drawing.Point(172, 238);
            this.labelPaid.Name = "labelPaid";
            this.labelPaid.Size = new System.Drawing.Size(50, 22);
            this.labelPaid.TabIndex = 6;
            this.labelPaid.Text = "label";
            // 
            // labelUnpaid
            // 
            this.labelUnpaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUnpaid.AutoSize = true;
            this.labelUnpaid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnpaid.Location = new System.Drawing.Point(172, 513);
            this.labelUnpaid.Name = "labelUnpaid";
            this.labelUnpaid.Size = new System.Drawing.Size(50, 22);
            this.labelUnpaid.TabIndex = 7;
            this.labelUnpaid.Text = "label";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelUnpaid);
            this.panel1.Controls.Add(this.panelPaid);
            this.panel1.Location = new System.Drawing.Point(43, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 430);
            this.panel1.TabIndex = 8;
            // 
            // panelUnpaid
            // 
            this.panelUnpaid.BackColor = System.Drawing.Color.DarkMagenta;
            this.panelUnpaid.Location = new System.Drawing.Point(187, 3);
            this.panelUnpaid.Name = "panelUnpaid";
            this.panelUnpaid.Size = new System.Drawing.Size(116, 437);
            this.panelUnpaid.TabIndex = 10;
            // 
            // panelPaid
            // 
            this.panelPaid.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panelPaid.Location = new System.Drawing.Point(34, 3);
            this.panelPaid.Name = "panelPaid";
            this.panelPaid.Size = new System.Drawing.Size(116, 437);
            this.panelPaid.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(88, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ödenmiş";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(230, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ödenmemiş";
            // 
            // labelPaidPercent
            // 
            this.labelPaidPercent.AutoSize = true;
            this.labelPaidPercent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPaidPercent.Location = new System.Drawing.Point(103, 48);
            this.labelPaidPercent.Name = "labelPaidPercent";
            this.labelPaidPercent.Size = new System.Drawing.Size(50, 22);
            this.labelPaidPercent.TabIndex = 11;
            this.labelPaidPercent.Text = "label";
            // 
            // labelUnpaidPercent
            // 
            this.labelUnpaidPercent.AutoSize = true;
            this.labelUnpaidPercent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnpaidPercent.Location = new System.Drawing.Point(262, 48);
            this.labelUnpaidPercent.Name = "labelUnpaidPercent";
            this.labelUnpaidPercent.Size = new System.Drawing.Size(50, 22);
            this.labelUnpaidPercent.TabIndex = 12;
            this.labelUnpaidPercent.Text = "label";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.labelUnpaidPercent);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.labelPaidPercent);
            this.panel3.Location = new System.Drawing.Point(600, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 512);
            this.panel3.TabIndex = 14;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1028, 576);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelUnpaid);
            this.Controls.Add(this.labelPaid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewUnpaidDebt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPaidDebt);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaidDebt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnpaidDebt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewPaidDebt;
        private Label label1;
        private Label label2;
        private DataGridView dataGridViewUnpaidDebt;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CurrentCode;
        private DataGridViewTextBoxColumn CurrentName;
        private DataGridViewTextBoxColumn DebtAmount;
        private DataGridViewTextBoxColumn PaidDebt;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Reminder;
        private DataGridViewTextBoxColumn Data;
        private Label label3;
        private Label label4;
        private Label labelPaid;
        private Label labelUnpaid;
        private Panel panel1;
        private Panel panelUnpaid;
        private Panel panelPaid;
        private Label label5;
        private Label label6;
        private Label labelPaidPercent;
        private Label labelUnpaidPercent;
        private Panel panel3;
    }
}
namespace CariKartlar
{
    partial class DebtPaymentCard
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
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridViewDebt = new System.Windows.Forms.DataGridView();
            this.DebtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reminder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.labelSumDebt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCurrentCode = new System.Windows.Forms.Label();
            this.labelCurrentName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurrentSum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDebt)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label11.Location = new System.Drawing.Point(501, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(259, 28);
            this.label11.TabIndex = 39;
            this.label11.Text = "Ödenmemiş Borç Dökümü";
            // 
            // dataGridViewDebt
            // 
            this.dataGridViewDebt.AllowUserToAddRows = false;
            this.dataGridViewDebt.AllowUserToDeleteRows = false;
            this.dataGridViewDebt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridViewDebt.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDebt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDebt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDebt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DebtId,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.DebtAmount,
            this.PaidDebt,
            this.Reminder,
            this.DebtDate});
            this.dataGridViewDebt.EnableHeadersVisualStyles = false;
            this.dataGridViewDebt.Location = new System.Drawing.Point(45, 107);
            this.dataGridViewDebt.MultiSelect = false;
            this.dataGridViewDebt.Name = "dataGridViewDebt";
            this.dataGridViewDebt.RowHeadersWidth = 51;
            this.dataGridViewDebt.RowTemplate.Height = 29;
            this.dataGridViewDebt.Size = new System.Drawing.Size(1185, 466);
            this.dataGridViewDebt.TabIndex = 37;
            this.dataGridViewDebt.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDebt_CellMouseClick);
            this.dataGridViewDebt.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDebt_CellValueChanged);
            // 
            // DebtId
            // 
            this.DebtId.HeaderText = "Id";
            this.DebtId.MinimumWidth = 6;
            this.DebtId.Name = "DebtId";
            this.DebtId.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Cari Kodu";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Cari Adı";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Yetkili";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Yetkili Mail";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // DebtAmount
            // 
            this.DebtAmount.HeaderText = "Borç Miktarı";
            this.DebtAmount.MinimumWidth = 6;
            this.DebtAmount.Name = "DebtAmount";
            this.DebtAmount.Width = 125;
            // 
            // PaidDebt
            // 
            this.PaidDebt.HeaderText = "Ödenen Miktar";
            this.PaidDebt.MinimumWidth = 6;
            this.PaidDebt.Name = "PaidDebt";
            this.PaidDebt.Width = 125;
            // 
            // Reminder
            // 
            this.Reminder.HeaderText = "Kalan";
            this.Reminder.MinimumWidth = 6;
            this.Reminder.Name = "Reminder";
            this.Reminder.Width = 125;
            // 
            // DebtDate
            // 
            this.DebtDate.HeaderText = "Son Ödeme Tarihi";
            this.DebtDate.MinimumWidth = 6;
            this.DebtDate.Name = "DebtDate";
            this.DebtDate.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Orchid;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.labelSumDebt);
            this.panel2.Location = new System.Drawing.Point(45, 585);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 68);
            this.panel2.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(7, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 23);
            this.label12.TabIndex = 29;
            this.label12.Text = "Toplam Borç:";
            // 
            // labelSumDebt
            // 
            this.labelSumDebt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSumDebt.AutoSize = true;
            this.labelSumDebt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSumDebt.ForeColor = System.Drawing.Color.White;
            this.labelSumDebt.Location = new System.Drawing.Point(136, 21);
            this.labelSumDebt.Name = "labelSumDebt";
            this.labelSumDebt.Size = new System.Drawing.Size(50, 23);
            this.labelSumDebt.TabIndex = 32;
            this.labelSumDebt.Text = "label";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Location = new System.Drawing.Point(-13, 659);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 118);
            this.panel1.TabIndex = 41;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonExit.Location = new System.Drawing.Point(1182, 11);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 74);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Kapat";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(64, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 42;
            this.label3.Text = "Cari Kodu:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(403, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 28);
            this.label4.TabIndex = 43;
            this.label4.Text = "Cari Adı:";
            // 
            // labelCurrentCode
            // 
            this.labelCurrentCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCurrentCode.AutoSize = true;
            this.labelCurrentCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentCode.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelCurrentCode.Location = new System.Drawing.Point(179, 59);
            this.labelCurrentCode.Name = "labelCurrentCode";
            this.labelCurrentCode.Size = new System.Drawing.Size(58, 28);
            this.labelCurrentCode.TabIndex = 44;
            this.labelCurrentCode.Text = "label";
            // 
            // labelCurrentName
            // 
            this.labelCurrentName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCurrentName.AutoSize = true;
            this.labelCurrentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentName.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelCurrentName.Location = new System.Drawing.Point(501, 59);
            this.labelCurrentName.Name = "labelCurrentName";
            this.labelCurrentName.Size = new System.Drawing.Size(58, 28);
            this.labelCurrentName.TabIndex = 45;
            this.labelCurrentName.Text = "label";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.Orchid;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.labelCurrentSum);
            this.panel3.Location = new System.Drawing.Point(317, 585);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 68);
            this.panel3.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Güncel Borç:";
            // 
            // labelCurrentSum
            // 
            this.labelCurrentSum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCurrentSum.AutoSize = true;
            this.labelCurrentSum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentSum.ForeColor = System.Drawing.Color.White;
            this.labelCurrentSum.Location = new System.Drawing.Point(136, 21);
            this.labelCurrentSum.Name = "labelCurrentSum";
            this.labelCurrentSum.Size = new System.Drawing.Size(50, 23);
            this.labelCurrentSum.TabIndex = 32;
            this.labelCurrentSum.Text = "label";
            // 
            // DebtPaymentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1271, 756);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelCurrentName);
            this.Controls.Add(this.labelCurrentCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridViewDebt);
            this.Name = "DebtPaymentCard";
            this.Text = "DebtPaymentCard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDebt)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label11;
        private DataGridView dataGridViewDebt;
        private DataGridViewTextBoxColumn DebtId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn DebtAmount;
        private DataGridViewTextBoxColumn PaidDebt;
        private DataGridViewTextBoxColumn Reminder;
        private DataGridViewTextBoxColumn DebtDate;
        private Panel panel2;
        private Label label12;
        private Label labelSumDebt;
        private Panel panel1;
        private Button buttonExit;
        private Label label3;
        private Label label4;
        private Label labelCurrentCode;
        private Label labelCurrentName;
        private Panel panel3;
        private Label label1;
        private Label labelCurrentSum;
    }
}
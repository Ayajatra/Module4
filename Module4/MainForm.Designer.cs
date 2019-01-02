namespace Module4
{
    partial class MainForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ms = new System.Windows.Forms.MenuStrip();
            this.viewResultsSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDetailedResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbTimePeriod = new System.Windows.Forms.ComboBox();
            this.labelTimePeriod = new System.Windows.Forms.Label();
            this.cbxGender = new System.Windows.Forms.CheckBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.cbAge = new System.Windows.Forms.ComboBox();
            this.cbxAge = new System.Windows.Forms.CheckBox();
            this.ms.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms
            // 
            this.ms.Font = new System.Drawing.Font("Tw Cen MT", 10F);
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewResultsSummaryToolStripMenuItem,
            this.viewDetailedResultsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(604, 24);
            this.ms.TabIndex = 0;
            this.ms.Text = "menuStrip1";
            // 
            // viewResultsSummaryToolStripMenuItem
            // 
            this.viewResultsSummaryToolStripMenuItem.Name = "viewResultsSummaryToolStripMenuItem";
            this.viewResultsSummaryToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.viewResultsSummaryToolStripMenuItem.Text = "&View Results Summary";
            this.viewResultsSummaryToolStripMenuItem.Click += new System.EventHandler(this.viewResultsSummaryToolStripMenuItem_Click);
            // 
            // viewDetailedResultsToolStripMenuItem
            // 
            this.viewDetailedResultsToolStripMenuItem.Name = "viewDetailedResultsToolStripMenuItem";
            this.viewDetailedResultsToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.viewDetailedResultsToolStripMenuItem.Text = "&View Detailed Results";
            this.viewDetailedResultsToolStripMenuItem.Click += new System.EventHandler(this.viewDetailedResultsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // rv
            // 
            this.rv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv.DocumentMapWidth = 1;
            reportDataSource1.Name = "SummaryDataSet";
            reportDataSource1.Value = null;
            this.rv.LocalReport.DataSources.Add(reportDataSource1);
            this.rv.LocalReport.ReportEmbeddedResource = "Module4.SummaryReport.rdlc";
            this.rv.Location = new System.Drawing.Point(0, 53);
            this.rv.Name = "rv";
            this.rv.ServerReport.BearerToken = null;
            this.rv.Size = new System.Drawing.Size(604, 366);
            this.rv.TabIndex = 1;
            // 
            // cbTimePeriod
            // 
            this.cbTimePeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTimePeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimePeriod.FormattingEnabled = true;
            this.cbTimePeriod.Location = new System.Drawing.Point(471, 27);
            this.cbTimePeriod.Name = "cbTimePeriod";
            this.cbTimePeriod.Size = new System.Drawing.Size(121, 25);
            this.cbTimePeriod.TabIndex = 2;
            this.cbTimePeriod.SelectedIndexChanged += new System.EventHandler(this.DetailedChanged);
            // 
            // labelTimePeriod
            // 
            this.labelTimePeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimePeriod.AutoSize = true;
            this.labelTimePeriod.Location = new System.Drawing.Point(378, 30);
            this.labelTimePeriod.Name = "labelTimePeriod";
            this.labelTimePeriod.Size = new System.Drawing.Size(87, 17);
            this.labelTimePeriod.TabIndex = 3;
            this.labelTimePeriod.Text = "Time Period :";
            // 
            // cbxGender
            // 
            this.cbxGender.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbxGender.AutoSize = true;
            this.cbxGender.Checked = true;
            this.cbxGender.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxGender.Location = new System.Drawing.Point(62, 430);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(75, 21);
            this.cbxGender.TabIndex = 4;
            this.cbxGender.Text = "Gender";
            this.cbxGender.UseVisualStyleBackColor = true;
            this.cbxGender.CheckedChanged += new System.EventHandler(this.DetailedChanged);
            // 
            // cbGender
            // 
            this.cbGender.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(143, 428);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(121, 25);
            this.cbGender.TabIndex = 2;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.DetailedChanged);
            // 
            // cbAge
            // 
            this.cbAge.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAge.FormattingEnabled = true;
            this.cbAge.Location = new System.Drawing.Point(423, 428);
            this.cbAge.Name = "cbAge";
            this.cbAge.Size = new System.Drawing.Size(121, 25);
            this.cbAge.TabIndex = 2;
            this.cbAge.SelectedIndexChanged += new System.EventHandler(this.DetailedChanged);
            // 
            // cbxAge
            // 
            this.cbxAge.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbxAge.AutoSize = true;
            this.cbxAge.Checked = true;
            this.cbxAge.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAge.Location = new System.Drawing.Point(365, 430);
            this.cbxAge.Name = "cbxAge";
            this.cbxAge.Size = new System.Drawing.Size(52, 21);
            this.cbxAge.TabIndex = 4;
            this.cbxAge.Text = "Age";
            this.cbxAge.UseVisualStyleBackColor = true;
            this.cbxAge.CheckedChanged += new System.EventHandler(this.DetailedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 461);
            this.Controls.Add(this.cbxAge);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.labelTimePeriod);
            this.Controls.Add(this.cbAge);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.cbTimePeriod);
            this.Controls.Add(this.rv);
            this.Controls.Add(this.ms);
            this.MainMenuStrip = this.ms;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "Flight Satisfaction Survey Reports";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.ToolStripMenuItem viewResultsSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDetailedResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private Microsoft.Reporting.WinForms.ReportViewer rv;
        private System.Windows.Forms.ComboBox cbTimePeriod;
        private System.Windows.Forms.Label labelTimePeriod;
        private System.Windows.Forms.CheckBox cbxGender;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.ComboBox cbAge;
        private System.Windows.Forms.CheckBox cbxAge;
    }
}


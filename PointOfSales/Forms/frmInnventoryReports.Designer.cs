namespace PointOfSales.Forms
{
    partial class frmInnventoryReports
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoMonthly = new System.Windows.Forms.RadioButton();
            this.rdoWeekly = new System.Windows.Forms.RadioButton();
            this.rdoDaily = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.DisplayGroupTree = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(153, 56);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(864, 423);
            this.crystalReportViewer1.TabIndex = 8;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdoMonthly);
            this.panel1.Controls.Add(this.rdoWeekly);
            this.panel1.Controls.Add(this.rdoDaily);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 423);
            this.panel1.TabIndex = 7;
            // 
            // rdoMonthly
            // 
            this.rdoMonthly.AutoSize = true;
            this.rdoMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMonthly.Location = new System.Drawing.Point(11, 84);
            this.rdoMonthly.Name = "rdoMonthly";
            this.rdoMonthly.Size = new System.Drawing.Size(135, 22);
            this.rdoMonthly.TabIndex = 9;
            this.rdoMonthly.TabStop = true;
            this.rdoMonthly.Text = "Monthly Reports";
            this.rdoMonthly.UseVisualStyleBackColor = true;
            this.rdoMonthly.Click += new System.EventHandler(this.rdoMonthly_Click);
            // 
            // rdoWeekly
            // 
            this.rdoWeekly.AutoSize = true;
            this.rdoWeekly.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWeekly.Location = new System.Drawing.Point(11, 60);
            this.rdoWeekly.Name = "rdoWeekly";
            this.rdoWeekly.Size = new System.Drawing.Size(132, 22);
            this.rdoWeekly.TabIndex = 8;
            this.rdoWeekly.TabStop = true;
            this.rdoWeekly.Text = "Weekly Reports";
            this.rdoWeekly.UseVisualStyleBackColor = true;
            this.rdoWeekly.Click += new System.EventHandler(this.rdoWeekly_Click);
            // 
            // rdoDaily
            // 
            this.rdoDaily.AutoSize = true;
            this.rdoDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDaily.Location = new System.Drawing.Point(11, 32);
            this.rdoDaily.Name = "rdoDaily";
            this.rdoDaily.Size = new System.Drawing.Size(115, 22);
            this.rdoDaily.TabIndex = 7;
            this.rdoDaily.TabStop = true;
            this.rdoDaily.Text = "Daily Reports";
            this.rdoDaily.UseVisualStyleBackColor = true;
            this.rdoDaily.Click += new System.EventHandler(this.rdoDaily_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1017, 56);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inventory Reports";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmInnventoryReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 479);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmInnventoryReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInnventoryReports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoMonthly;
        private System.Windows.Forms.RadioButton rdoWeekly;
        private System.Windows.Forms.RadioButton rdoDaily;
    }
}
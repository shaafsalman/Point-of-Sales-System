namespace PointOfSales.Forms
{
    partial class frmReports
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSales = new System.Windows.Forms.RadioButton();
            this.rdoInventory = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(755, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdoInventory);
            this.panel1.Controls.Add(this.rdoSales);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 408);
            this.panel1.TabIndex = 1;
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
            this.crystalReportViewer1.Size = new System.Drawing.Size(602, 408);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "List of Products";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(7, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 102);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Filter";
            // 
            // rdoSales
            // 
            this.rdoSales.AutoSize = true;
            this.rdoSales.Location = new System.Drawing.Point(25, 59);
            this.rdoSales.Name = "rdoSales";
            this.rdoSales.Size = new System.Drawing.Size(51, 17);
            this.rdoSales.TabIndex = 3;
            this.rdoSales.TabStop = true;
            this.rdoSales.Text = "Sales";
            this.rdoSales.UseVisualStyleBackColor = true;
            // 
            // rdoInventory
            // 
            this.rdoInventory.AutoSize = true;
            this.rdoInventory.Location = new System.Drawing.Point(25, 91);
            this.rdoInventory.Name = "rdoInventory";
            this.rdoInventory.Size = new System.Drawing.Size(85, 17);
            this.rdoInventory.TabIndex = 3;
            this.rdoInventory.TabStop = true;
            this.rdoInventory.Text = "radioButton1";
            this.rdoInventory.UseVisualStyleBackColor = true;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 464);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoInventory;
        private System.Windows.Forms.RadioButton rdoSales;
    }
}
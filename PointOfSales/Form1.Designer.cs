namespace PointOfSales
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointOfSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.UserIdtoolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.DateTimetoolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimetoolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.productToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.purchaseOrderToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointOfSalesToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // pointOfSalesToolStripMenuItem
            // 
            this.pointOfSalesToolStripMenuItem.Name = "pointOfSalesToolStripMenuItem";
            this.pointOfSalesToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.pointOfSalesToolStripMenuItem.Text = "Point of Sales";
            this.pointOfSalesToolStripMenuItem.Click += new System.EventHandler(this.pointOfSalesToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.addToolStripMenuItem.Text = "Add New Product";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.searchToolStripMenuItem.Text = "Search for Product";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(90, 23);
            this.transactionToolStripMenuItem.Text = "Transaction";
            this.transactionToolStripMenuItem.Click += new System.EventHandler(this.transactionToolStripMenuItem_Click);
            // 
            // purchaseOrderToolStripMenuItem
            // 
            this.purchaseOrderToolStripMenuItem.Name = "purchaseOrderToolStripMenuItem";
            this.purchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(116, 23);
            this.purchaseOrderToolStripMenuItem.Text = "Purchase Order";
            this.purchaseOrderToolStripMenuItem.Click += new System.EventHandler(this.purchaseOrderToolStripMenuItem_Click);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.supplierToolStripMenuItem1,
            this.manageUserToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(100, 23);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem1
            // 
            this.supplierToolStripMenuItem1.Name = "supplierToolStripMenuItem1";
            this.supplierToolStripMenuItem1.Size = new System.Drawing.Size(160, 24);
            this.supplierToolStripMenuItem1.Text = "Supplier";
            this.supplierToolStripMenuItem1.Click += new System.EventHandler(this.supplierToolStripMenuItem1_Click);
            // 
            // manageUserToolStripMenuItem
            // 
            this.manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            this.manageUserToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.manageUserToolStripMenuItem.Text = "Manage User";
            this.manageUserToolStripMenuItem.Click += new System.EventHandler(this.manageUserToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.inventoryReportsToolStripMenuItem,
            this.listOfSuppliersToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.salesToolStripMenuItem.Text = "Sales Reports";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // inventoryReportsToolStripMenuItem
            // 
            this.inventoryReportsToolStripMenuItem.Name = "inventoryReportsToolStripMenuItem";
            this.inventoryReportsToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.inventoryReportsToolStripMenuItem.Text = "Inventory Reports";
            this.inventoryReportsToolStripMenuItem.Click += new System.EventHandler(this.inventoryReportsToolStripMenuItem_Click);
            // 
            // listOfSuppliersToolStripMenuItem
            // 
            this.listOfSuppliersToolStripMenuItem.Name = "listOfSuppliersToolStripMenuItem";
            this.listOfSuppliersToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.listOfSuppliersToolStripMenuItem.Text = "List of Suppliers";
            this.listOfSuppliersToolStripMenuItem.Click += new System.EventHandler(this.listOfSuppliersToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(775, 87);
            this.label1.TabIndex = 5;
            this.label1.Text = "City Garments";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.UserIdtoolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.DateTimetoolStripStatusLabel4,
            this.toolStripStatusLabel2,
            this.TimetoolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(775, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "User ::";
            // 
            // UserIdtoolStripStatusLabel2
            // 
            this.UserIdtoolStripStatusLabel2.Name = "UserIdtoolStripStatusLabel2";
            this.UserIdtoolStripStatusLabel2.Size = new System.Drawing.Size(36, 17);
            this.UserIdtoolStripStatusLabel2.Text = "None";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(40, 17);
            this.toolStripStatusLabel3.Text = "Date ::";
            // 
            // DateTimetoolStripStatusLabel4
            // 
            this.DateTimetoolStripStatusLabel4.Name = "DateTimetoolStripStatusLabel4";
            this.DateTimetoolStripStatusLabel4.Size = new System.Drawing.Size(118, 17);
            this.DateTimetoolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel2.Text = "Time ::";
            // 
            // TimetoolStripStatusLabel4
            // 
            this.TimetoolStripStatusLabel4.Name = "TimetoolStripStatusLabel4";
            this.TimetoolStripStatusLabel4.Size = new System.Drawing.Size(118, 17);
            this.TimetoolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(71, 201);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(352, 46);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(116, 99);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(307, 33);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(408, 20);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(15, 13);
            this.lblClose.TabIndex = 3;
            this.lblClose.Text = "X";
            this.lblClose.Visible = false;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(116, 138);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(307, 33);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.UseSystemPasswordChar = true;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(147, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 289);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Made By Viaeyes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(775, 494);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Point of Sales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointOfSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryReportsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel UserIdtoolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel DateTimetoolStripStatusLabel4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel TimetoolStripStatusLabel4;
        private System.Windows.Forms.ToolStripMenuItem listOfSuppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}


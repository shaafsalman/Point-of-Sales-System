namespace PointOfSales.Forms
{
    partial class frmCategory
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
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtglist = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category :";
            // 
            // txtcategory
            // 
            this.txtcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategory.Location = new System.Drawing.Point(119, 90);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(275, 24);
            this.txtcategory.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(116, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtglist
            // 
            this.dtglist.AllowUserToAddRows = false;
            this.dtglist.AllowUserToDeleteRows = false;
            this.dtglist.AllowUserToResizeColumns = false;
            this.dtglist.AllowUserToResizeRows = false;
            this.dtglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtglist.Location = new System.Drawing.Point(12, 255);
            this.dtglist.Name = "dtglist";
            this.dtglist.RowHeadersVisible = false;
            this.dtglist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtglist.Size = new System.Drawing.Size(425, 148);
            this.dtglist.TabIndex = 3;
            this.dtglist.Click += new System.EventHandler(this.dtglist_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(192, 176);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(273, 176);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search :";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(287, 225);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 24);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(323, 409);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Unit :";
            // 
            // txtUnit
            // 
            this.txtUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.Location = new System.Drawing.Point(119, 146);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(148, 24);
            this.txtUnit.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Type :";
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(119, 118);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(275, 24);
            this.txtType.TabIndex = 1;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(19, 57);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(91, 18);
            this.lb.TabIndex = 0;
            this.lb.Text = "Category Id :";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryId.Location = new System.Drawing.Point(116, 57);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(76, 18);
            this.lblCategoryId.TabIndex = 0;
            this.lblCategoryId.Text = "Category :";
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 437);
            this.Controls.Add(this.dtglist);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtcategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCategoryId);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sales";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dtglist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lblCategoryId;
    }
}
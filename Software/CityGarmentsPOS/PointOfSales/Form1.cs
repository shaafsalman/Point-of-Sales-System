using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PointOfSales.Forms;
using PointOfSales.Config;

namespace PointOfSales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SQLSelects config = new SQLSelects();
        private void VisibleMenu()
        {
            productToolStripMenuItem.Visible = false;
            maintenanceToolStripMenuItem.Visible = false;
            reportsToolStripMenuItem.Visible = false;
            //transactionToolStripMenuItem.Visible = false;
            pointOfSalesToolStripMenuItem.Visible = false;

        }
        public void ViewMenu()
        {
            productToolStripMenuItem.Visible = true;
            maintenanceToolStripMenuItem.Visible = true;
            reportsToolStripMenuItem.Visible = true;
            //  transactionToolStripMenuItem.Visible = true;
            pointOfSalesToolStripMenuItem.Visible = true;

        }
        public Form1(string title, string txt)
        {
            InitializeComponent();
            this.Text = title;
            loginToolStripMenuItem.Text = txt;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //VisibleMenu();
            timer1.Start();
            this.MaximizeBox = false;
            this.Size = new Size(468, 426);
            menuStrip1.Visible = false;
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            frm.ShowDialog();
            frm.Focus();

        }
        public void LoginText(string txt)
        {
            loginToolStripMenuItem.Text = txt;

        }
        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListProducts frm = new frmListProducts();
            frm.ShowDialog();
            frm.Focus();
        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers();
            frm.ShowDialog();
            frm.Focus();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.ShowDialog();
            frm.Focus();

        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransaction frm = new frmTransaction();

            //frm.Close();
            frm.ShowDialog();
            frm.Focus();
        }

        private void pointOfSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockout frm = new frmStockout(UserIdtoolStripStatusLabel2.Text);

            //frm.Close();
            frm.ShowDialog();
            frm.Focus();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmLogin frm = new frmLogin();
            if (loginToolStripMenuItem.Text == "Login")
            {
                // frm.ShowDialog();
                panel1.Visible = true;
            }
            else
            {
                //frm.ShowDialog();
                loginToolStripMenuItem.Text = "Login";
                UserIdtoolStripStatusLabel2.Text = "None";
                VisibleMenu();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            txtUsername.Clear();
            txtpassword.Clear();

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesReports frm = new frmSalesReports();
            frm.ShowDialog();

        }

        private void inventoryReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInnventoryReports frm = new frmInnventoryReports();
            frm.ShowDialog();
        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //frmLogin frm = new frmLogin();
            if (loginToolStripMenuItem.Text == "Login")
            {
                // frm.ShowDialog();
                panel1.Visible = true;
                panel1.BringToFront();
                txtUsername.Focus();
            }
            else
            {
                ////frm.ShowDialog();
                //loginToolStripMenuItem.Text = "Login";
                //VisibleMenu();
                UserIdtoolStripStatusLabel2.Text = "None";
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(468, 426);
                menuStrip1.Visible = false;
                panel1.Visible = true;
                panel1.BringToFront();

            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            config.ValidatingAccounts(txtUsername, txtpassword);
            int maxrows = config.dt.Rows.Count;

            if (maxrows > 0)
            {
                MessageBox.Show("Welcome " + config.dt.Rows[0].Field<string>("UserRole"), "Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (config.dt.Rows[0].Field<string>("UserRole") == "Administrator")
                {
                    UserIdtoolStripStatusLabel2.Text = config.dt.Rows[0].Field<int>("UserId").ToString();
                    ViewMenu();
                    panel1.Visible = false;
                    menuStrip1.Visible = true;
                    this.WindowState = FormWindowState.Maximized;
                    pointOfSalesToolStripMenuItem.Visible = false;
                }
                else if (config.dt.Rows[0].Field<string>("UserRole") == "Cashier")
                {
                    //VisibleMenu();
                    // this.WindowState = FormWindowState.Maximized;
                    UserIdtoolStripStatusLabel2.Text = config.dt.Rows[0].Field<int>("UserId").ToString();
                    pointOfSalesToolStripMenuItem.Visible = true;
                    frmStockout frm = new frmStockout(UserIdtoolStripStatusLabel2.Text);
                    frm.ShowDialog();
                    //txtpassword.Clear();
                    txtUsername.Focus();
                    UserIdtoolStripStatusLabel2.Text = "None";
                    this.WindowState = FormWindowState.Normal;
                    this.Size = new Size(468, 426);
                    menuStrip1.Visible = false;
                    panel1.Visible = true;
                    panel1.BringToFront();

                }

                //panel1.Visible = false;
                loginToolStripMenuItem.Text = "Logout";
                txtUsername.Clear();
                txtpassword.Clear();
            }
            else
            {
                MessageBox.Show("Account does not exist! ", "Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                DateTime today = DateTime.Now;
                DateTimetoolStripStatusLabel4.Text = today.ToShortDateString();
                TimetoolStripStatusLabel4.Text = today.ToShortTimeString();

            }
            catch (Exception ex)
            {
            }
        }

        private void supplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmSupplier frm = new frmSupplier();
            frm.ShowDialog();
        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseOrder frm = new frmPurchaseOrder();
            frm.ShowDialog();
        }

        private void listOfSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrintSuppliers frm = new frmPrintSuppliers();
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
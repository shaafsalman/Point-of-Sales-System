using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PointOfSales.Config;


namespace PointOfSales.Forms
{
    public partial class frmListProducts : Form
    {
        public frmListProducts()
        {
            InitializeComponent();
        }

        SQLConfig prolist = new SQLConfig();

        private void frmListProducts_Load(object sender, EventArgs e)
        {
            prolist.sqlselect = "SELECT p.Barcode,ProductName,Description,Category,p.OriginalPrice,ProductQty,Unit FROM tblcategory c, tblproduct p WHERE p.CategoryId=c.CategoryId";
            prolist.LoadData(prolist.sqlselect, dtgList);
            prolist.dtgcolor(dtgList, 5);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            prolist.sqlselect = "SELECT p.Barcode,ProductName,Description,Category,p.OriginalPrice,ProductQty,Unit FROM tblcategory c, tblproduct p WHERE p.CategoryId=c.CategoryId AND (ProductName Like '%" + txtSearch.Text + "%' OR  Barcode Like '%" + txtSearch.Text + "%')";
            prolist.LoadData(prolist.sqlselect, dtgList);
            prolist.dtgcolor(dtgList, 5);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void dtgList_Click(object sender, EventArgs e)
        {
            int qty;
            //MessageBox.Show("true");
            prolist.sqlselect = "SELECT  * FROM tblproduct  WHERE Barcode = '" + dtgList.CurrentRow.Cells[0].Value + "'";
            prolist.Single_Select(prolist.sqlselect);
            qty = prolist.dt.Rows[0].Field<int>("ProductQty");
            if (qty <= 5)
            {
                DialogResult result = MessageBox.Show("Product quantity is in critical level. Do you want to re-order this product?", "Re-Order", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //frmPurchaseOrder frm = new frmPurchaseOrder(dtgList.CurrentRow.Cells[0].Value.ToString());
                    //frm.Show();
                    //frm.Focus();
                    LoadData();
                    txtBarcode.Text = dtgList.CurrentRow.Cells[0].Value.ToString();
                    pnlReorder.Visible = true;
                    txtQty.Focus();

                }
            }
            else if (qty <= 10)
            {
                DialogResult result = MessageBox.Show("Product quantity is in warning level. Do you want to re-order this product?", "Re-Order", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //frmPurchaseOrder frm = new frmPurchaseOrder(dtgList.CurrentRow.Cells[0].Value.ToString());
                    //frm.Show();
                    //frm.Focus();
                    LoadData();
                    txtBarcode.Text = dtgList.CurrentRow.Cells[0].Value.ToString();
                    pnlReorder.Visible = true;
                    txtQty.Focus();

                }
            }
        }

        private void dtgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int qty;
                //MessageBox.Show("true");
                prolist.sqlselect = "SELECT  * FROM tblproduct  WHERE Barcode = '" + dtgList.CurrentRow.Cells[0].Value + "'";
                prolist.Single_Select(prolist.sqlselect);
                qty = prolist.dt.Rows[0].Field<int>("ProductQty");
                
                if (qty <= 5)
                {
                    DialogResult result = MessageBox.Show("Product quantity is in critical level. Do you want to re-order this product?", "Logout",  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        //frmPurchaseOrder frm = new frmPurchaseOrder(dtgList.CurrentRow.Cells[0].Value.ToString());
                        //frm.Show();
                        //frm.Focus();
                        LoadData();
                        txtBarcode.Text = dtgList.CurrentRow.Cells[0].Value.ToString();
                        pnlReorder.Visible = true;
                        txtQty.Focus();
                       
                    }
                }else if(qty <= 10)
                {
                    DialogResult result = MessageBox.Show("Product quantity is in warning level. Do you want to re-order this product?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        //frmPurchaseOrder frm = new frmPurchaseOrder(dtgList.CurrentRow.Cells[0].Value.ToString());
                        //frm.Show();
                        //frm.Focus();
                        LoadData();
                        txtBarcode.Text = dtgList.CurrentRow.Cells[0].Value.ToString();
                        pnlReorder.Visible = true;
                        txtQty.Focus();
                      
                    }
                }

                
               
                //DialogResult result = MessageBox .Show (
            }
        }
        private void LoadData()
        {
            prolist.sqlselect = "SELECT OrderDate,p.Barcode,ProductName,Description,Category,p.OriginalPrice,OrderQty,Unit,OrderTotal FROM tblcategory c, tblproduct p,tblorder o WHERE p.CategoryId=c.CategoryId AND p.Barcode=o.Barcode";
            prolist.LoadData(prolist.sqlselect, dataGridView1 );
            txtBarcode.MaxLength = 11;
            prolist.FillComboBox("SELECT * FROM tblsupplier", "SupplierId", "Supplier", comboBox1);
            clearStockin();
        }
        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
             try
             {
                 if (txtBarcode.Text != "")
                 {
                     if (txtBarcode.Text.Length >= 10)
                     {

                         prolist.sqlselect = "SELECT * FROM tblcategory c, tblproduct p  WHERE p.CategoryId=c.CategoryId And Barcode Like '%" + txtBarcode.Text  + "%'";
                         prolist.Single_Select(prolist.sqlselect);

                         if (prolist.dt.Rows.Count > 0)
                         {
                             decimal price;
                             txtProduct.Text = prolist.dt.Rows[0].Field<string>("ProductName");
                             txtDescription.Text = prolist.dt.Rows[0].Field<string>("Description");
                             txtCategory.Text = prolist.dt.Rows[0].Field<string>("Category");
                             price = prolist.dt.Rows[0].Field<decimal>("OriginalPrice");
                             txtPrice.Text = price.ToString("N2");
                         }
                         else
                         {
                             clearStockin();
                         }

                     }
                     else
                     {

                         clearStockin();
                     }

                 }
                 else
                 {
                     clearStockin();
                 }


             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
        }


        private void clearStockin()
        {
            //txtProduct.Clear();
            //txtDescription.Clear();
            //txtPrice.Clear();
            //txtCategory.Clear();
            //txtQty.Clear();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtQty.Text != "")
                {
                    DateTime today = DateTime.Now;
                    double price = double.Parse(txtPrice.Text.ToString());
                    int qty = int.Parse(txtQty.Text.ToString());
                    double tot;
                    tot = price * qty;



                    //pro.sql = "Select * From tblorder WHERE ";
                    //pro.Single_Select(pro.sql);
                    //if (pro.dt.Rows.Count > 0)
                    //{
                    //}
                    //else
                    //{
                    prolist.sqladd = "INSERT INTO tblorder (OrderDate,Barcode,OrderQty,OrderTotal,SupplierId,Rem) " +
                        " VALUES ('" + today + "','" + txtBarcode.Text + "'," + txtQty.Text + ",'" + tot.ToString("n2") + "','" + comboBox1.SelectedValue + "','Ordered')";
                    prolist.SaveDataMsg(prolist.sqladd, "New order has been saved in the database.");
                    //}
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Fields is required.","Required",MessageBoxButtons .OK , MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlReorder.Visible = false;
        }
     
    }
}

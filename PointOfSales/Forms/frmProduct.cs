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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        SQLConfig pro = new SQLConfig();
        UsableFunction useFunc = new UsableFunction();
         

        private void frmProduct_Load(object sender, EventArgs e)
        {
            try
            {

                txtBarcode.MaxLength = 11;
                //pro.FillAutonumber(1, lblProductId);

                pro.sql = "Select CategoryId, Category + '[' + CategoryType + ']'  as 'CategType' From tblcategory";
                pro.FillComboBox(pro.sql, "CategoryId", "CategType", cboCategory);

                string categoryid = cboCategory.SelectedValue.ToString();
                int id = Int32.Parse(categoryid);
                pro.PassingAutonumberLbl(id, lblProductId);

                pro.sqlselect = "SELECT ProductId,p.Barcode,ProductName,Description,Category + '[' + CategoryType + ']' as 'Category' ,p.OriginalPrice,MarkupPrice,ProductQty,Unit FROM tblcategory c, tblproduct p  WHERE p.CategoryId=c.CategoryId";
                pro.LoadData(pro.sqlselect, dtglist);
                pro.dtgcolor(dtglist, 7);


                useFunc.clearTxt(this);

            }
            catch
            {
            }
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProduct_Load(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
              
                //double total;
                //DateTime today = DateTime.Now;
                //total =double.Parse(txtPrice.Text) * Int32.Parse (txtQty.Text);


                //pro.sqladd = "INSERT INTO tblstockin (Barcode,DateReceived,Price,ReceivedQty,SubTotal,UserId) " +
                //    " Values('" + txtBarcode.Text + "','" + today + "','" + txtPrice.Text + "','" + txtQty.Text + "','" + total + "',1)";

                //pro.SaveData(pro.sqladd);




                pro.sqlselect = "SELECT * FROM tblproduct WHERE ProductId='" + lblProductId.Text + "'";

                pro.sqladd = "INSERT INTO tblproduct (ProductId,Barcode,ProductName,Description,OriginalPrice,MarkupPrice,ProductQty,CategoryId) " +
                " VALUES ('" + lblProductId.Text + "','" + txtBarcode.Text + "','" + txtProduct.Text + "','" + txtDescription.Text + "','" + txtPrice.Text + "','" + txtMarkupPrice.Text + "',0," + cboCategory.SelectedValue + ")";

                pro.sqledit = "UPDATE tblproduct Set ProductId='" + lblProductId.Text + 
                    "',Barcode='" + txtBarcode.Text +
                    "',ProductName='" + txtProduct.Text +
                    "',Description='" + txtDescription.Text +
                    "',OriginalPrice='" + txtPrice.Text +
                    "',MarkupPrice='" + txtMarkupPrice.Text +
                    "',CategoryId=" + cboCategory.SelectedValue + 
                    "  WHERE ProductId = '" + lblProductId.Text + "'";

                pro.msgadd = "New Product has been saved in the database.";

                pro.msgedit = "Product has been updated in the database."; 

                pro.SaveUpdate(pro.sqlselect, pro.sqladd, pro.msgadd, pro.sqledit, pro.msgedit);

                if (pro.msg == "New Product has been saved in the database.")
                {
                    pro.UpdateProductAutonumber(cboCategory); 
                    pro.msg = "";

                }

                frmProduct_Load(sender, e);
                

            }
            catch (Exception ex)
            {
               
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { 
            string categoryid =  cboCategory.SelectedValue.ToString();
            int id = Int32.Parse(categoryid);
            pro.PassingAutonumberLbl(id, lblProductId);
            }
            catch (Exception ex)
            {

            }

          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pro.sql = "DELETE FROM tblproduct WHERE ProductId = '" + dtglist.CurrentRow.Cells[0].Value + "'";

            pro.SaveDataMsg(pro.sql, "Product has been deleted in the database.");

            btnNew_Click(sender, e);
        }

        private void dtglist_Click(object sender, EventArgs e)
        {
            try
            {
                txtBarcode.Text  = dtglist.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }
        private void clearProduct()
        {
            txtProduct.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtMarkupPrice.Clear();
            pro.sql = "Select CategoryId,Category + '[' + CategoryType + ']' as 'Category' From tblcategory";
            pro.FillComboBox(pro.sql, "CategoryId", "Category", cboCategory);
            string categoryid = cboCategory.SelectedValue.ToString();
            int id = Int32.Parse(categoryid);
            pro.PassingAutonumberLbl(id, lblProductId);
        }
        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal price, markup;

                if (txtBarcode.Text != "")
                {
                    if (txtBarcode.Text.Length >= 11)
                    {

                        pro.sqlselect = "SELECT ProductId,ProductName,Description,OriginalPrice,MarkupPrice,Category + '[' + CategoryType + ']' as 'Category' FROM tblcategory c, tblproduct p  WHERE p.CategoryId=c.CategoryId And Barcode = '" + txtBarcode.Text + "'";
                        pro.Single_Select(pro.sqlselect);

                        if (pro.dt.Rows.Count > 0)
                        {

                            lblProductId.Text = pro.dt.Rows[0].Field<string>("ProductId");
                            txtProduct.Text = pro.dt.Rows[0].Field<string>("ProductName");
                            txtDescription.Text = pro.dt.Rows[0].Field<string>("Description");
                            price = pro.dt.Rows[0].Field<decimal>("OriginalPrice");
                            markup = pro.dt.Rows[0].Field<decimal>("MarkupPrice");

                            txtPrice.Text = price.ToString("N2");
                            txtMarkupPrice.Text = markup.ToString("N2");


                            cboCategory.Text = pro.dt.Rows[0].Field<string>("Category");
                            
                        }
                        else
                        {
                           
                            clearProduct();
                        }

                    }
                    else
                    {
                        
                        clearProduct();
                    }

                }
                else
                {
                    
                    clearProduct();
                }



            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        
      
        
    }
}

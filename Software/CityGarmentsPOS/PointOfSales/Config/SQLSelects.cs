using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient; 
using PointOfSales.Forms;
using System.Data;
using System.Windows.Forms;

namespace PointOfSales.Config
{
    class SQLSelects
    {

        private SqlConnection strcon = new SqlConnection("Data Source=SS-PAVILION;Database=dbpos;trusted_connection=true;");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter da = new SqlDataAdapter();
        public DataTable dt = new DataTable();
        public int result;


        public void ValidatingProduct(string sqlselect, string sqladd, string sqledit)
        {
            try
            {
                strcon.Open();

                cmd = new SqlCommand();
                cmd.Connection = strcon;
                cmd.CommandText = sqlselect;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                int maxrows = dt.Rows.Count;

                if (maxrows > 0)
                {
                    //updating in the database; 
                    cmd = new SqlCommand();
                    cmd.Connection = strcon;
                    cmd.CommandText = sqledit;
                    result = cmd.ExecuteNonQuery();
                    
                    
                    if (result > 0)
                    {
                        //updating Qty in the database; 
                        cmd = new SqlCommand();
                        cmd.Connection = strcon;
                        cmd.CommandText = "";
                        result = cmd.ExecuteNonQuery();



                        MessageBox.Show("");
                    }

                }
                else
                {
                    //adding in the database
                    cmd = new SqlCommand();
                    cmd.Connection = strcon;
                    cmd.CommandText = sqladd;
                    result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("");
                        
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                strcon.Close();
            }
            
        }
        public void ValidatingAccounts(TextBox txtusername,TextBox txtpass)
        {
            try
            {
                strcon.Open();

                cmd = new SqlCommand();
                cmd.Connection = strcon;
                cmd.CommandText = "SELECT * FROM tbluser WHERE User_name ='" + txtusername.Text + "' AND Pass = '" + txtpass.Text + "'";
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);

                //int maxrows = dt.Rows.Count;

                //if (maxrows > 0)
                //{
                //    MessageBox.Show("Welcome " + dt.Rows[0].Field<string>("UserRole"), "Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    frmLogin frm = new frmLogin();
                //    frm.Close();
                //}
                //else
                //{
                //    MessageBox.Show("Account does not exist! ", "Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                strcon.Close();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using PointOfSales.Forms;
using System.Drawing;
//using System.c

namespace PointOfSales.Config
{
 class SQLConfig
 {
     public SqlConnection strcon = new SqlConnection("Data Source=SS-PAVILION;Database=dbpos;trusted_connection=true;");
       public SqlCommand cmd = new SqlCommand();
       public SqlDataAdapter da = new SqlDataAdapter();
       public DataTable dt = new DataTable();
       public DataSet ds = new DataSet();
       public int result;
       public string sqladd;
       public string sqledit;
       public string sqlselect;
       public string msgadd;
       public string msgedit;
       public string sql;
       public string msg;

        public void SaveUpdate(string sqlselect,string sqladd,string msgadd ,string sqledit,string msgedit)
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
                        MessageBox.Show(msgedit);
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
                        MessageBox.Show(msgadd);
                        //user 
                        if (msgadd == "New User has been saved in the database.")
                        { 
                            //auto inc
                            strcon.Close();
                            UpdateAutonumber(2);
                            strcon.Open(); 
                        }
                        //end user

                        //Product 
                        if (msgadd == "New Product has been saved in the database.")
                        {
                            msg = "New Product has been saved in the database.";
                            
                        }
                        //end Product
                        //Category 
                        if (msgadd == "New Category has been saved in the database.")
                        {
                            //auto inc
                            strcon.Close();
                            UpdateAutonumber(4);
                            strcon.Open();
                        }
                        //end Category
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
        public void LoadData(string sqlselect, DataGridView dtg)
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
                dtg.DataSource = dt; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                strcon.Close();
            }
        }
        public void SaveDataMsg(string sql,string msg)
        {
            try
            {
                strcon.Open();

                cmd = new SqlCommand();
                cmd.Connection = strcon;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(msg);
                } 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                strcon.Close();
            }
           
        }
        public void SaveData(string sql)
        {
            try
            {
                strcon.Open();

                cmd = new SqlCommand();
                cmd.Connection = strcon;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                strcon.Close();
            }

        }
        public void PassingAutonumberLbl(int id, Label txt)
        {
            try
            {
                strcon.Open();

                cmd = new SqlCommand();
                cmd.Connection = strcon;
                cmd.CommandText = "Select AutoStart , AutoEnd FROM tblAutonumber Where CategoryId=" + id;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                txt.Text = dt.Rows[0].Field<string>("AutoStart") + dt.Rows[0].Field<int>("AutoEnd");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                strcon.Close();
            }
        }
        public void UpdateProductAutonumber(ComboBox id)
        {
            try
            {
                strcon.Open();

                cmd = new SqlCommand();
                cmd.Connection = strcon;
                cmd.CommandText = "UPDATE tblAutonumber SET  AutoEnd = AutoEnd + AutoIncrement Where CategoryId=" + id.SelectedValue;
                result = cmd.ExecuteNonQuery();
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
        public void FillAutonumber(int id, Label txt)
        {
            try
            {
                strcon.Open();

                cmd = new SqlCommand();
                cmd.Connection = strcon;
                cmd.CommandText =  "Select AutoStart , AutoEnd FROM tblAutonumber Where AutoId=" + id;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                txt.Text = dt.Rows[0].Field<string>("AutoStart") + dt.Rows[0].Field<int>("AutoEnd");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                strcon.Close();
            }
        }
        public void UpdateAutonumber(int id)
        {
            try
            {
                strcon.Open();

                cmd = new SqlCommand();
                cmd.Connection = strcon;
                cmd.CommandText = "UPDATE tblAutonumber SET  AutoEnd = AutoEnd + AutoIncrement Where AutoId=" + id;
                result = cmd.ExecuteNonQuery();
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
        public void FillComboBox(string sql,string field, string id, ComboBox cbo)
        {
            try
            {
                strcon.Open();

                cmd = new SqlCommand();
                cmd.Connection = strcon;
                cmd.CommandText = sql;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                cbo.DataSource = dt;
                cbo .ValueMember = field;
                cbo.DisplayMember = id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                strcon.Close();
            }
        }
        public void Single_Select(string sqlselect)
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
                //txt.Text = dt.Rows[0].Field<string>(0);
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                strcon.Close();
            }
        }

        public void ResponsiveDtg(DataGridView dtg)
        {
            dtg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

      public void dtgcolor(DataGridView dtg,int value) {
          try
          { 
         
              //DataGridViewRow rw = new DataGridViewRow();
              dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

              foreach (DataGridViewColumn c in dtg.Columns)
              {
                  c.SortMode = DataGridViewColumnSortMode.Programmatic;
              }

              foreach(DataGridViewRow rw in dtg.Rows)
              {
                  if (Convert.ToInt32(rw.Cells[value].Value) < 10)
                  { 
                      rw.DefaultCellStyle.BackColor = Color.Red;
                      rw.DefaultCellStyle.SelectionBackColor = Color.Red;
                      rw.DefaultCellStyle.ForeColor = Color.White;
                  }
                  // If rw.Cells(value).Value < 20 Then
            //        rw.DefaultCellStyle.BackColor = Color.Red
            //        rw.DefaultCellStyle.SelectionBackColor = Color.Red
            //        rw.DefaultCellStyle.SelectionForeColor = Color.White
            //    ElseIf rw.Cells(value).Value > 20 And rw.Cells(value).Value < 50 Then
            //        rw.DefaultCellStyle.BackColor = Color.Orange
            //        rw.DefaultCellStyle.SelectionBackColor = Color.Orange
            //        rw.DefaultCellStyle.SelectionForeColor = Color.White
            //    ElseIf rw.Cells(value).Value > 50 Then
            //        rw.DefaultCellStyle.BackColor = Color.Blue
            //        rw.DefaultCellStyle.SelectionBackColor = Color.Blue
            //        rw.DefaultCellStyle.SelectionForeColor = Color.White
            //    End If
              }
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message);
          }
           
            //dtg.RowHeadersVisible = False
            //dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            //For Each c As DataGridViewColumn In dtg.Columns
            //    c.SortMode = DataGridViewColumnSortMode.Programmatic
            //Next


            //For Each rw In dtg.Rows
            //    If rw.Cells(value).Value < 20 Then
            //        rw.DefaultCellStyle.BackColor = Color.Red
            //        rw.DefaultCellStyle.SelectionBackColor = Color.Red
            //        rw.DefaultCellStyle.SelectionForeColor = Color.White
            //    ElseIf rw.Cells(value).Value > 20 And rw.Cells(value).Value < 50 Then
            //        rw.DefaultCellStyle.BackColor = Color.Orange
            //        rw.DefaultCellStyle.SelectionBackColor = Color.Orange
            //        rw.DefaultCellStyle.SelectionForeColor = Color.White
            //    ElseIf rw.Cells(value).Value > 50 Then
            //        rw.DefaultCellStyle.BackColor = Color.Blue
            //        rw.DefaultCellStyle.SelectionBackColor = Color.Blue
            //        rw.DefaultCellStyle.SelectionForeColor = Color.White
            //    End If
            //Next



 
        }
        //public void reports(string sql, string rptname, object  crystalRpt)
        //{
        //    try
        //    {
        //        strcon.Open();
        //        string reportname;


        //        cmd = new SqlCommand();
        //        cmd.Connection = strcon;
        //        cmd.CommandText = sqlselect;
        //        da = new SqlDataAdapter();
        //        da.SelectCommand = cmd;
        //        dt = new DataTable();
        //        da.Fill(dt);

        //        reportname = rptname;
        //        CrystalDecisions.CrystalReports.Engine.ReportDocument reportdoc;
                 
        //        string strReportPath;
                 
        //        strReportPath = Application.StartupPath + "\\report\\"  + reportname + ".rpt";

                
        //       reportdoc.Load(strReportPath);
        //       reportdoc.SetDataSource(dt);

        //        //crystalRpt.ShowRefreshButton = false;
        //        // crystalRpt.ShowCloseButton = false;
        //        // crystalRpt.ShowGroupTreeButton = false;
        //         crystalRpt.ReportSource = reportdoc;


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        da.Dispose();
        //        strcon.Close();
        //    }
        //}

    //  Public Sub reports(ByVal sql As String, ByVal rptname As String, ByVal crystalRpt As Object)
    //    Try
    //        con.Open()

    //        Dim reportname As String
    //        With cmd
    //            .Connection = con
    //            .CommandText = sql
    //        End With
    //        ds = New DataSet
    //        da = New MySqlDataAdapter(sql, con)
    //        da.Fill(ds)

    //        reportname = rptname
    //        Dim reportdoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    //        Dim strReportPath As String
    //        strReportPath = Application.StartupPath & "\report\" & reportname & ".rpt"
    //        With reportdoc
    //            .Load(strReportPath)
    //            .SetDataSource(ds.Tables(0))
    //        End With
    //        With crystalRpt
    //            .ShowRefreshButton = False
    //            .ShowCloseButton = False
    //            .ShowGroupTreeButton = False
    //            .ReportSource = reportdoc
    //        End With
    //    Catch ex As Exception
    //        MsgBox(ex.Message & "No Crystal Reports have been Installed")
    //    End Try
    //    con.Close()
    //    da.Dispose()
    //End Sub
     
 }
   
}

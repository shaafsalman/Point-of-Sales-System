using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PointOfSales.Config;

namespace PointOfSales.Forms
{
    public partial class frmPrintSuppliers : Form
    {
        public frmPrintSuppliers()
        {
            InitializeComponent();
        }

         SQLConfig pro = new SQLConfig();

         public void Print_Suppliers()
          {
          
          
            try
            {
                pro.strcon.Open();
                string reportname = "Suppliers";

                pro.sqlselect = "SELECT * FROM tblsupplier";

                pro.cmd = new SqlCommand();
                pro.cmd.Connection = pro.strcon;
                pro.cmd.CommandText = pro.sqlselect;
                pro.da = new SqlDataAdapter();
                pro.da.SelectCommand = pro.cmd;
                pro.dt = new DataTable();
                pro.da.Fill(pro.dt);

 
                CrystalDecisions.CrystalReports.Engine.ReportDocument reportdoc = new CrystalDecisions.CrystalReports.Engine.ReportDocument(); ;

                string strReportPath = Application.StartupPath + "\\report\\" + reportname + ".rpt";


                reportdoc.Load(strReportPath);
                reportdoc.SetDataSource(pro.dt);
                
                crystalReportViewer1.ReportSource = reportdoc;
        


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                pro.da.Dispose();
                pro.strcon.Close();
            }


        }

         private void frmPrintSuppliers_Load(object sender, EventArgs e)
         {
             Print_Suppliers();
         }

    }
}

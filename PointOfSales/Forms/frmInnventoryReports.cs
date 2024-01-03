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
    public partial class frmInnventoryReports : Form
    {
        public frmInnventoryReports()
        {
            InitializeComponent();
        }
        public string sql = "";
        SQLConfig pro = new SQLConfig();
        private void SalesReports(string sql, string rptname)
        {
            try
            {
                pro.strcon.Open();

                string reportname = rptname;

                pro.cmd = new SqlCommand();
                pro.cmd.Connection = pro.strcon;
                pro.cmd.CommandText = sql;
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
                MessageBox.Show(ex.Message + "No crystal reports installed. Pls. contact administrator.");
            }
            finally
            {
                pro.da.Dispose();
                pro.strcon.Close();
            }
        }
        private void frmInnventoryReports_Load(object sender, EventArgs e)
        {

        }

        private void rdoDaily_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM tblproduct p, tblstockin t WHERE p.Barcode=t.Barcode AND day(DateReceived)=day(GETDATE())";
            SalesReports(sql, "DailyInventory");
        }

        private void rdoWeekly_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM tblproduct p, tblstockin t WHERE p.Barcode=t.Barcode AND datepart(ww, DateReceived) = datepart(ww, GETDATE())";
            SalesReports(sql, "WeeklyInventory");
        }

        private void rdoMonthly_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM tblproduct p, tblstockin t WHERE p.Barcode=t.Barcode AND datepart(month, DateReceived) = datepart(month, GETDATE())";
            SalesReports(sql, "MonthlyInventory");
        }

        
    }
}

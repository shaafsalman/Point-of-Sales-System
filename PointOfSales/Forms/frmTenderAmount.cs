using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PointOfSales.Forms
{
    public partial class frmTenderAmount : Form
    {
        public frmTenderAmount()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         
        public frmTenderAmount(string txt)
        {
            InitializeComponent(); 
            txtTotal.Text = txt;
        }

        private void txttenderedamount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double change = new double();
                double tender = new double();
                double tot = new double();

                if (txttenderedamount.Text == "")
                {
                    change = 0.0;
                    txtChange.Text = change.ToString("N2");
                }
                else
                {
             
                    tot = double.Parse(txtTotal.Text);
                    tender = double.Parse(txttenderedamount.Text);

                    change =  tender - tot;

                    txtChange.Text = change.ToString("N2");
                }
                
            }
            catch
            {
            }
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace project
{
    public partial class Frm_Owener_Report : Form
    {
        public Frm_Owener_Report()
        {
            InitializeComponent();
        }

        ReportDocument cryrpt = new ReportDocument();
        SqlDataAdapter sda;

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3JLA3M7\sqlexpress;Initial Catalog=Live_Stock_Census_DB;Integrated Security=True;Pooling=False");

        private void btn_Search_Click(object sender, EventArgs e)
        {
            con.Open();
            if (tb_Sr_No.Text != "")
            {
                sda = new SqlDataAdapter(" Select * from Village_Or_City_Profile_TB where Sr_No = " + tb_Sr_No.Text + "",con);

                DataSet Dst = new DataSet();
                sda.Fill(Dst, "Village_Or_City_Profile_TB");

                cryrpt.Load(@"E:\project\project\Crystal_Report\Owener.rpt");

                cryrpt.SetDataSource(Dst);
                crystalReportViewer1.ReportSource = cryrpt;
            }
            else
            {
                MessageBox.Show("Enter Valid ID ...");
            }
            con.Close();
        }

        private void tb_Sr_No_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

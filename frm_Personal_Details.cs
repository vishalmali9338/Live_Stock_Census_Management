using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace project
{
    public partial class frm_Personal_Details : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Live_Stock_Census_DB;Integrated Security=True");

        public frm_Personal_Details()
        {
            InitializeComponent();
        }

      
        private void frm_Personal_Details_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Caste_Income_TB", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            cmb_Income.DisplayMember = "Anual_Income";
            cmb_Income.DataSource = dt;

            con.Open();
            SqlCommand cmda= new SqlCommand("select * from Caste_TB", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmda);
            DataTable dta = new DataTable();
            sd.Fill(dta);
            con.Close();
            cmb_caste.DisplayMember = "Caste";
            cmb_caste.DataSource = dta;

            con.Open();
            SqlCommand cm = new SqlCommand("select * from Education_TB", con);
            SqlDataAdapter sdr = new SqlDataAdapter(cm);
            DataTable dtr = new DataTable();
            sdr.Fill(dtr);
            con.Close();
            cmb_education.DisplayMember = "Education";
            cmb_education.DataSource = dtr;

            con.Open();
            SqlCommand cma = new SqlCommand("select * from Agriculture_TB", con);
            SqlDataAdapter sdh = new SqlDataAdapter(cma);
            DataTable dth= new DataTable();
            sdh.Fill(dth);
            con.Close();
            cmb_agriculture.DisplayMember = "Agriculture";
            cmb_agriculture.DataSource = dth;

            con.Open();
            SqlCommand cmo = new SqlCommand("select * from Occupation_TB", con);
            SqlDataAdapter sdo = new SqlDataAdapter(cmo);
            DataTable dto = new DataTable();
            sdo.Fill(dto);
            con.Close();
            cmb_occupation.DisplayMember = "Occupation";
            cmb_occupation.DataSource = dto;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sn = new SqlCommand("Select Top(1) Sr_No from Village_Or_City_Profile_TB Order by Sr_No desc", con);
            string Sr_No = Convert.ToString(sn.ExecuteScalar());
            sn.Dispose();

            if (cmb_occupation.Text != "" && cmb_agriculture.Text != "" && cmb_education.Text != "" && cmb_caste.Text != "" && cmb_Income.Text != "" && (rb_finace_suport_yes.Checked || rb_finance_suport_no.Checked))       
            {
                SqlCommand cmd = new SqlCommand("insert into Personal_Details_TB values('" + cmb_occupation.Text + "','" + cmb_agriculture.Text + "','" + cmb_education.Text + "','" + cmb_caste.Text + "','" + cmb_Income.Text + "',"+ Sr_No +")", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Record Saved Successfully");
              
            }
            else
            {
                MessageBox.Show("First Fill All The Fields!!!");
            }
            con.Close();
        }

    }
}

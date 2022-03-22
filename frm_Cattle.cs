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
    public partial class cattle : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Live_Stock_Census_DB;Integrated Security=True");

        public cattle()
        {
            InitializeComponent();
        }

        private void pnl_cattel_properties_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sn = new SqlCommand("Select Top(1) Sr_No from Village_Or_City_Profile_TB Order by Sr_No desc", con);
            string Sr_No = Convert.ToString(sn.ExecuteScalar());
            sn.Dispose();

            if (cmb_Breed_Name.Text != "" && tb_In_Milk.Text != "" && tb_Up_2_Year.Text != "" && tb_Dry.Text != "" && tb_up_2year.Text != "" && tb_Agriculture.Text != "" && tb_Breeding.Text != "" && tb_subtotal.Text != "")
            {

                SqlCommand cmd = new SqlCommand("insert into Cattle_Details_TB values(" + Sr_No + ",'" + cmb_Breed_Name.Text + "','" + tb_Up_2_Year.Text + "'," + tb_In_Milk.Text + "," + tb_Dry.Text + "," + tb_up_2year.Text + "," + tb_Agriculture.Text + "," + tb_Breeding.Text + "," + tb_subtotal.Text + ")", con);

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

       

        private void cattle_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Cattle_Breed_Names", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            cmb_Breed_Name.SelectedIndex = -1;
            cmb_Breed_Name.DisplayMember = "Breed_Name";
            cmb_Breed_Name.DataSource = dt;


        }

        private void tb_Breeding_TextChanged(object sender, EventArgs e)
        {

            try
            {
                tb_subtotal.Text = (float.Parse(tb_Up_2_Year.Text) + float.Parse(tb_In_Milk.Text) + float.Parse(tb_Dry.Text) + float.Parse(tb_up_2year.Text) + float.Parse(tb_Agriculture.Text) + float.Parse(tb_Breeding.Text)).ToString();

            }
            catch
            {
            }
        }

       
    }
}

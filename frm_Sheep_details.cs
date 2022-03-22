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
    public partial class frm_Sheep_details : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Live_Stock_Census_DB;Integrated Security=True");

        public frm_Sheep_details()
        {
            InitializeComponent();
        }

       

       
        private void frm_Sheep_details_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Sheep_Breed_Name_TB", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            cmb_Breed_Name.SelectedIndex = -1;
            cmb_Breed_Name.DisplayMember = "Breed Name";
            cmb_Breed_Name.DataSource = dt;


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sn = new SqlCommand("Select Top(1) Sr_No from Village_Or_City_Profile_TB Order by Sr_No desc", con);
            string Sr_No = Convert.ToString(sn.ExecuteScalar());
            sn.Dispose();

            if (cmb_Breed_Name.Text != "" && tb_up_6_Month.Text != "" && tb_Dry.Text != "" && tb_In_Milk.Text != "" && tb_under_1_Month_or_6_Month.Text != "" && tb_up_to_1_Year.Text != "" && tb_used_for_Breeding.Text != "" && tb_subtotal.Text != "")
            {



                SqlCommand cmd = new SqlCommand("insert into Sheep_Details_TB values('" + cmb_Breed_Name.Text + "'," + tb_up_6_Month.Text + "," + tb_In_Milk.Text + "," + tb_Dry.Text + "," + tb_under_1_Month_or_6_Month.Text + "," + tb_up_to_1_Year.Text + "," + tb_used_for_Breeding.Text + "," + tb_subtotal.Text + "," + Sr_No + ")", con);

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

        private void tb_used_for_Breeding_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                tb_subtotal.Text = (float.Parse(tb_up_6_Month.Text)+float.Parse(tb_In_Milk.Text)+float.Parse(tb_Dry.Text)+float.Parse(tb_under_1_Month_or_6_Month.Text) + float.Parse(tb_up_to_1_Year.Text) + float.Parse(tb_used_for_Breeding.Text)).ToString();
            }
            catch
            {
            }
        }

       
    }
}

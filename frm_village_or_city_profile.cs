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
    public partial class frm_village_or_city_profile : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Live_Stock_Census_DB;Integrated Security=True");
        int Stateid;
        int Districtid;
        int Talukaid;
        public frm_village_or_city_profile()

                
     
        {
            InitializeComponent();
            refreshstate();

        }

      

        private void refreshstate()
        {
      
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from State_TB", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            cmb_State.SelectedIndex = -1;
            cmb_State.DisplayMember = "Statename";
            cmb_State.ValueMember = "Stateid";
            cmb_State.DataSource = dt;
        }
        
      

     
        private void cmb_State_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_State.SelectedValue.ToString()!=null)
            {
                Stateid = Convert.ToInt32(cmb_State.SelectedValue.ToString());
                refereshdistrict(Stateid);
            }
        }

        private void refereshdistrict(int Stateid)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from District_TB where Stateid=@Stateid", con);
            cmd.Parameters.AddWithValue("Stateid", Stateid);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            cmb_District.DisplayMember = "Districtname";
            cmb_District.ValueMember = "Districtid";
            cmb_District.DataSource = dt;
        }

        private void cmb_District_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_District.SelectedValue.ToString() != null)
            {
                Districtid = Convert.ToInt32(cmb_District.SelectedValue.ToString());
                refereshtaluka(Districtid);
            }
        }

        private void refereshtaluka(int Districtid)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Taluka_TB where Districtid=@Districtid", con);
            cmd.Parameters.AddWithValue("Districtid", Districtid);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            cmb_Taluka.DisplayMember = "Talukaname";
            cmb_Taluka.ValueMember = "Talukaid";
            cmb_Taluka.DataSource = dt;
        }

        private void cmb_Taluka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Taluka.SelectedValue.ToString() != null)
            {
                Talukaid = Convert.ToInt32(cmb_Taluka.SelectedValue.ToString());
                refereshvillege(Talukaid);
            }
        }

        private void refereshvillege(int Talukaid)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Village_TB where Talukaid=@Talukaid", con);
            cmd.Parameters.AddWithValue("Talukaid", Talukaid);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            cmb_Village_or_City.DisplayMember = "Villagename";
            cmb_Village_or_City.ValueMember = "Villageid";
            cmb_Village_or_City.DataSource = dt;
        }

      

        private void tb_mobile_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 )
            {
                e.Handled = true;
                MessageBox.Show("Plese Enter the Mobile umber");
            }
        }

        private void tb_Adhar_card_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Plese Enter the Adhar Card Number");
            }
        }

        private void tb_House_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Plese Enter House Number");
            }

        }

        private void tb_Name_of_House_Hold_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Plese Enter House Hold Name");
            }
        }
        private void refereshhouse()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from House_Hold_Type_Tb", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            cmb_House_Hold_Type.SelectedIndex = -1;
            cmb_House_Hold_Type.DisplayMember = "House_Hold_Type";
            cmb_House_Hold_Type.ValueMember = "House_Hold_id";
            cmb_House_Hold_Type.DataSource = dt;
        }
        
      
     
     private void btn_next_Click(object sender, EventArgs e)
     {
         if (rbtn_livestock_no.Checked)
         {
             frm_Personal_Details fpd = new frm_Personal_Details();
             fpd.Show();
             this.Hide();
         }
         else
         {
             species ob = new species();
             ob.Show();
             this.Hide();
         }

     }

     private void frm_village_or_city_profile_Load(object sender, EventArgs e)
     {
         con.Open();
         SqlCommand cmd = new SqlCommand("select * from House_Hold_Type_Tb", con);
         SqlDataAdapter sda = new SqlDataAdapter(cmd);
         DataTable dt = new DataTable();
         sda.Fill(dt);
         con.Close();
         cmb_House_Hold_Type.Text="";
         cmb_House_Hold_Type.DisplayMember = "House_Hold_Type";
         cmb_House_Hold_Type.ValueMember = "House_Hold_id";
         cmb_House_Hold_Type.DataSource = dt;
         cmb_State.Focus();

         tb_serial_number.Text = Convert.ToString(Auto_Incrt_CID());
     }

     private void Btn_Save_Click(object sender, EventArgs e)
     {
        if(cmb_State.Text!=""&&cmb_District.Text!=""&&cmb_Taluka.Text!=""&&cmb_Village_or_City.Text!=""&&cmb_House_Hold_Type.Text!=""&&tb_mobile_number.Text!=""&&tb_House_Number.Text!=""&&tb_Adhar_card.Text!=""&&tb_Name_of_House_Hold.Text!=""&&tb_serial_number.Text!="")
        {
             SqlCommand cmd = new SqlCommand("insert into Village_Or_City_Profile_TB values(" + tb_serial_number.Text + ",'" + cmb_State.Text + "','" + cmb_District.Text + "','" + cmb_Taluka.Text + "','" + cmb_Village_or_City.Text + "','" + cmb_House_Hold_Type.Text + "'," + tb_mobile_number.Text + "," + tb_House_Number.Text + "," + tb_Adhar_card.Text + ",'" + tb_Name_of_House_Hold.Text + "')", con);

         SqlDataAdapter sda = new SqlDataAdapter(cmd);
         DataTable dt = new DataTable();
         sda.Fill(dt);
         MessageBox.Show("Record Saved Successfully");
         btn_next.Enabled = true;
        }
        else
        {
            MessageBox.Show("First Fill All The Fields!!!");
        }
     }

     private void tb_serial_number_TextChanged(object sender, EventArgs e)
     {

     }

          int Auto_Incrt_CID()
        {
            int CID = 0;
            con.Open();
            //SqlCommand Cmd = new SqlCommand("Select Count(Customer_ID) From Customers_PA_Details_Tbl", Con);
            SqlCommand Cmd = new SqlCommand("Select Count(Sr_No) From Village_Or_City_Profile_TB", con);
            CID = Convert.ToInt32(Cmd.ExecuteScalar());

            if (CID > 0)
            {
                //Cmd.CommandText = ("Select Max(Customer_ID) From Customers_PA_Details_Tbl");
                Cmd.CommandText = ("Select Max(Sr_No) From Village_Or_City_Profile_TB");
                Cmd.Connection = con;
                CID = Convert.ToInt32(Cmd.ExecuteScalar());
                CID++;
            }
            else
            {
                CID = 1;
            }
            con.Close();

            return CID;
        }

    
    }
}

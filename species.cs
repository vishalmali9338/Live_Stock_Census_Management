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
    public partial class species : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3JLA3M7\sqlexpress;Initial Catalog=Live_Stock_Census_DB;Integrated Security=True;Pooling=False");

        public species()
        {
            InitializeComponent();
        }

        private void btn_cattle_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_cattle_Click_1(object sender, EventArgs e)
        {
            cattle obj = new cattle();
            
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void btn_buffallo_Click(object sender, EventArgs e)
        {
            Buffalo_details obj = new Buffalo_details();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void btn_sheep_Click(object sender, EventArgs e)
        {
            frm_Sheep_details ok = new frm_Sheep_details();

            ok.MdiParent = this;
            ok.WindowState = FormWindowState.Maximized;
            ok.Show();

        }

        private void btn_goat_Click(object sender, EventArgs e)
        {
            frm_Goat_Details dk = new frm_Goat_Details();
            dk.MdiParent = this;
            dk.WindowState = FormWindowState.Maximized;
            dk.Show();
        }

        private void btn_horse_Click(object sender, EventArgs e)
        {
            frm_horse_details hd = new frm_horse_details();
            hd.MdiParent = this;
            hd.WindowState = FormWindowState.Maximized;
            hd.Show();
        }

        private void btn_dog_Click(object sender, EventArgs e)
        {
            frm_dog_details dd = new frm_dog_details();
            dd.MdiParent = this;
            dd.WindowState = FormWindowState.Maximized;
            dd.Show();

        }

        private void btn_Cat_Click(object sender, EventArgs e)
        {
            frm_cat_details cd = new frm_cat_details();
            cd.MdiParent = this;
            cd.WindowState = FormWindowState.Maximized;
            cd.Show();
        }

        private void btn_duck_Click(object sender, EventArgs e)
        {
            frm_duck_details dd = new frm_duck_details();
            dd.MdiParent = this;
            dd.WindowState = FormWindowState.Maximized;
            dd.Show();

        }

        private void btn_other_birds_Click(object sender, EventArgs e)
        {
            frm_other_birds ob = new frm_other_birds();
            ob.MdiParent = this;
            ob.WindowState = FormWindowState.Maximized;
            ob.Show();
        }

        private void btn_Equipment_Click(object sender, EventArgs e)
        {
            frm_equipments eq = new frm_equipments();
            eq.MdiParent = this;
            eq.WindowState = FormWindowState.Maximized;
            eq.Show();
        }

        private void species_Load(object sender, EventArgs e)
        {
           
        }

       
        private void btn_Personal_Details_Click(object sender, EventArgs e)
        {
            Frm_Personal_Detail pd = new Frm_Personal_Detail();
            pd.MdiParent = this;
            tblpnl_Species.Visible = false;
            pd.WindowState = FormWindowState.Maximized;
            pd.Show();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            tblpnl_Species.Visible = false;
            if (cb_Cattle.Checked)
            {
                btn_cattle.Enabled = true;
            }
            else
            {
               // btn_cattle.Enabled = false;
                con.Open();
                SqlCommand sn = new SqlCommand("Select Top(1) Sr_No from Village_Or_City_Profile_TB Order by Sr_No desc", con);
                string Sr_No = Convert.ToString(sn.ExecuteScalar());
                sn.Dispose();
                SqlCommand cmd = new SqlCommand("insert into Cattle_Details_TB(Cattle_Breeds,Up_2_Year,In_Milk,Dry,Up_To_2Year,Agriculture,Breeding ,Cattle_Subtotal,Sr_No) values('None','0','0','0','0','0','0','0'," + Sr_No + ")", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();

            }

            if (cb_Buffalo.Checked)
            {
                btn_buffallo.Enabled = true;
            }
            else
            {
                btn_buffallo.Enabled = false;
                
                con.Open();
                SqlCommand sn = new SqlCommand("Select Top(1) Sr_No from Village_Or_City_Profile_TB Order by Sr_No desc", con);
                string Sr_No = Convert.ToString(sn.ExecuteScalar());
                sn.Dispose();
                SqlCommand cmd = new SqlCommand("insert into Buffalo_Details_TB(Buffalo_Breed,Up_To_2_Year,In_Milk,Dry,Up_To_2Year,Agriculture_Bulloc_Cart,Used_For_Breeding,B_Subtotal,Sr_No) values('None','0','0','0','0','0','0','0'," + Sr_No + ")", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();


            }

            if (cb_Sheep.Checked)
            {
                btn_sheep.Enabled = true;
            }
            else
            {
                btn_sheep.Enabled = false;
               
                con.Open();

                SqlCommand sn = new SqlCommand("Select Top(1) Sr_No from Village_Or_City_Profile_TB Order by Sr_No desc", con);
                string Sr_No = Convert.ToString(sn.ExecuteScalar());
                sn.Dispose();
                SqlCommand cmd = new SqlCommand("insert into Sheep_Details_TB(Sheep_Breed_Name,Up_To_6_Month,In_Milk,Dry,Up_To_1_To_6_Month,Up_To_1Year,Breeding,Sheep_Subtotal,Sr_No) values('None','0','0','0','0','0','0','0'," + Sr_No + ")", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                con.Close();


            }


            if (cb_Goat.Checked)
            {
                btn_goat.Enabled = true;
            }
            else
            {
                btn_goat.Enabled = false;
                con.Open();
                SqlCommand sn = new SqlCommand("Select Top(1) Sr_No from Village_Or_City_Profile_TB Order by Sr_No desc", con);
                string Sr_No = Convert.ToString(sn.ExecuteScalar());
                sn.Dispose();
                SqlCommand cmd = new SqlCommand("insert into Goat_Details_TB(Goat_Breed_Name,Up_To_6_Month,In_Milk,Dry,Up_To_1_To_6_MOnth,Up_To_1Year,Breeding,Goat_Subtotal,Sr_No) values('None','0','0','0','0','0','0','0'," + Sr_No + ")", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();


                
            }

            if (cb_Horse.Checked)
            {
                btn_horse.Enabled = true;
            }
            else
            {
                btn_horse.Enabled = false;
                con.Open();
                SqlCommand sn = new SqlCommand("Select Top(1) Sr_No from Village_Or_City_Profile_TB Order by Sr_No desc", con);
                string Sr_No = Convert.ToString(sn.ExecuteScalar());
                sn.Dispose();
                SqlCommand cmd = new SqlCommand("insert into Horse_Detail_TB(Horse_Breed,Up_To_2Year,In_Milk,Dry,Up_To_2_Year,Agriculture,Breeding,Horse_Subtotal,Sr_No) values('None','0','0','0','0','0','0','0'," + Sr_No + ")", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();


               
            }

            if (cb_Dog.Checked)
            {
                btn_dog.Enabled = true;
            }
            else
            {
                btn_dog.Enabled = false;
                con.Open();
                SqlCommand sn = new SqlCommand("Select Top(1) Sr_No from Village_Or_City_Profile_TB Order by Sr_No desc", con);
                string Sr_No = Convert.ToString(sn.ExecuteScalar());
                sn.Dispose();
                SqlCommand cmd = new SqlCommand("insert into Dog_Details_TB(Dog_Breed_Name,Pupys,Male_Dogs,Female_Dogs,Dog_Subtotal,Sr_No)values('None','0','0','0','0'," + Sr_No + ")", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
            }

            if (cb_Cat.Checked)
            {
                btn_Cat.Enabled = true;
            }
            else
            {
                btn_Cat.Enabled = false;
                btn_dog.Enabled = false;
                con.Open();
                SqlCommand sn = new SqlCommand("Select Top(1) Sr_No from Village_Or_City_Profile_TB Order by Sr_No desc", con);
                string Sr_No = Convert.ToString(sn.ExecuteScalar());
                sn.Dispose();
                SqlCommand cmd = new SqlCommand("insert into Cat_Details_TB(Cat_Breed_Name,Kittens,Male_Cat,Female_Cat,Cat_Subtotal,Sr_No)values('None','0','0','0','0'," + Sr_No + ")", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
            }


            if (cb_Duck.Checked)
            {
                btn_duck.Enabled = true;
            }
            else
            {
                btn_duck.Enabled = false;
                btn_dog.Enabled = false;
                con.Open();
                SqlCommand sn = new SqlCommand("Select Top(1) Sr_No from Village_Or_City_Profile_TB Order by Sr_No desc", con);
                string Sr_No = Convert.ToString(sn.ExecuteScalar());
                sn.Dispose();
                SqlCommand cmd = new SqlCommand("insert into Duck_Details_TB (Duck_Breed_Name,Duckling,Male_Duck,Female_Duck,Duck_Subtotal,Sr_No)values('None','0','0','0','0'," + Sr_No + ")", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
            }

            if (cb_Hens.Checked)
            {
                btn_other_birds.Enabled = true;
            }
            else
            {
                btn_other_birds.Enabled = false;
                btn_dog.Enabled = false;
                con.Open();
                SqlCommand sn = new SqlCommand("Select Top(1) Sr_No from Village_Or_City_Profile_TB Order by Sr_No desc", con);
                string Sr_No = Convert.ToString(sn.ExecuteScalar());
                sn.Dispose();
                SqlCommand cmd = new SqlCommand("insert into Other_Birds_Details_TB(Hens_Breed_Name,Chick,Male_Birds,Female_Birds,Hens_Subtotal,Sr_No)values('None',' 0 ','0','0','0'," + Sr_No + ")", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
            }


            if (cb_Equipment.Checked)
            {
                btn_Equipment.Enabled = true;
            }
            else
            {
                btn_Equipment.Enabled = false;
                con.Open();
                SqlCommand sn = new SqlCommand("Select Top(1) Sr_No from Village_Or_City_Profile_TB Order by Sr_No desc", con);
                string Sr_No = Convert.ToString(sn.ExecuteScalar());
                sn.Dispose();
                SqlCommand cmd = new SqlCommand("insert into Equipents_Details_TB(Incubators_Or_Breeders,Milking_Machine,Fodder_Cutter,Choper_And_Baler,Dung_Collection,Eqip_Subtotal,Sr_No)values('0','0','0','0','0','0'," + Sr_No + ")", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
            }
        }

        private void species_Load_1(object sender, EventArgs e)
        {
            btn_Reports.Enabled = true;
          //  tblpnl_Species.Visible = false;

          //  Frm_Personal_Detail pd = new Frm_Personal_Detail();
           // pd.MdiParent = this;
           // tblpnl_Species.Visible = false;
           // pd.WindowState = FormWindowState.Maximized;
           // pd.Show();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Caste_Income_TB", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            cmb_Income.DisplayMember = "Anual_Income";
            cmb_Income.DataSource = dt;

            con.Open();
            SqlCommand cmda = new SqlCommand("select * from Caste_TB", con);
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
            DataTable dth = new DataTable();
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

        private void button1_Click(object sender, EventArgs e)
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
                panel1.Visible = false;
                tblpnl_Species.Visible = true;
                
            }
            else
            {
                MessageBox.Show("First Fill All The Fields!!!");
            }
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            btn_Owener_Details.Enabled = true;
            btn_Personal_Details.Enabled = true;
        }

        private void btn_Owener_Details_Click(object sender, EventArgs e)
        {
            Frm_Owener_Report obj = new Frm_Owener_Report();
            obj.Show();
        }

        private void btn_Personal_Details_Click_1(object sender, EventArgs e)
        {
            Frm_Personal_Details_Report obj = new Frm_Personal_Details_Report();
            obj.Show();
        }
    }
}

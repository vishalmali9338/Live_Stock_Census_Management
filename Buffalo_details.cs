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
    public partial class Buffalo_details : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3JLA3M7\sqlexpress;Initial Catalog=Live_Stock_Census_DB;Integrated Security=True;Pooling=False");
         public Buffalo_details()
        {
            InitializeComponent();
        }

       

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            frm_Personal_Details ok = new frm_Personal_Details();
            ok.Show();
            this.Hide();
        }

        private void tb_under_1year_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                lbl_Up_2Years.Visible = true;
                lbl_Up_2Years.Text = "Plese Enter Count of Up To 2 Years Buffalo";
            }
            else
            {
                lbl_Up_2Years.Visible = false;
            }
                
        }

        private void tb_used_for_breeding_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                lbl_InMilk.Visible = true;
                lbl_InMilk.Text = "Plese Enter Count of Buffalo In Milk ";
            }
            else
            {
                lbl_InMilk.Visible = false;
            }

        }

        private void tb_used_for_agriculture_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                lbl_Drys.Visible = true;
                lbl_Drys.Text = "Plese Enter Count of Buffalo In Dry";
            }
            else
            {
                lbl_Drys.Visible = false;
            }
        }

        private void tb_aggriculture_and_breeding_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                lbl_Up_2Years.Visible = true;
                lbl_Up_2Years.Text = "Plese Enter Count of Buffalo in Up To 2 Years ";
            }
            else
            {
                lbl_Up_2Years.Visible = false;
            }
        }

        private void tb_others_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tb_subtotal.Text = (float.Parse(tb_up_2year.Text) + float.Parse(tb_Dry.Text) + float.Parse(tb_In_Milk.Text) + float.Parse(tb_Up_2_Year.Text) + float.Parse(tb_Agriculture.Text) + float.Parse(tb_Breeding.Text)).ToString();
            }
            catch
            {
            }
        }

        private void cmb_Breed_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblpnl_Buffalo_details.Enabled = true;
        }

        private void pnl_cattel_properties_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Buffalo_details_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Buffalo_Breed_Name", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            cmb_Breed_Name.SelectedIndex = -1;
            cmb_Breed_Name.DisplayMember = "Breed Name";
            cmb_Breed_Name.DataSource = dt;
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sn = new SqlCommand("Select Top(1) Sr_No from Village_Or_City_Profile_TB Order by Sr_No desc", con);
            string Sr_No = Convert.ToString(sn.ExecuteScalar());
            sn.Dispose();

            if (cmb_Breed_Name.Text != "" && tb_up_2year.Text != "" && tb_In_Milk.Text != "" && tb_Dry.Text != "" && tb_Up_2_Year.Text != "" && tb_Agriculture.Text != "" && tb_Breeding.Text != "" && tb_subtotal.Text != "")
            {
                SqlCommand cmd = new SqlCommand("insert into Buffalo_Details_TB values('" + cmb_Breed_Name.Text + "'," + tb_up_2year.Text + "," + tb_In_Milk.Text + "," + tb_Dry.Text + "," + tb_Up_2_Year.Text + "," + tb_Agriculture.Text + "," + tb_Breeding.Text + "," + tb_subtotal.Text + "," + Sr_No + ")", con);

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

        private void tb_Breeding_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                lbl_Breeding.Visible = true;
                lbl_Breeding.Text = "Plese Enter Count of Buffalo Using Breeding ";
            }
            else
            {
                lbl_Breeding.Visible = false;
            }

        }

        private void tb_Agriculture_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                lbl_Agri.Visible = true;
                lbl_Agri.Text = "Plese Enter Count of Buffalo Using Agriculture";
            }
            else
            {
                lbl_Agri.Visible = false;
            }


        }

       
    }
}

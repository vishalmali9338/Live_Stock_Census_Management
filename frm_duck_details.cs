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
    public partial class frm_duck_details : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Live_Stock_Census_DB;Integrated Security=True");

        public frm_duck_details()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            frm_Personal_Details fpd = new frm_Personal_Details();
            fpd.Show();
            this.Hide();
        }

        private void tb_Duckling_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                lbl_Error_Duckling.Visible = true;
                lbl_Error_Duckling.Text = ("Plese Enter Count of Duckling");
            }
            else
            {
                lbl_Error_Duckling.Visible = false;
            }
        }

        private void tb_Male_Duck_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                lbl_Error_Male_Duck.Visible = true;
                lbl_Error_Male_Duck.Text = ("Plese Enter Count of Duckling");
            }
            else
            {
                lbl_Error_Male_Duck.Visible = false;
            }
        }

        private void tb_Female_Duck_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                lbl_Error_Female_Duck.Visible = true;
                lbl_Error_Female_Duck.Text = ("Plese Enter Count of Duckling");
            }
            else
            {
                lbl_Error_Female_Duck.Visible = false;
            }
           
        }

        private void tb_Female_Duck_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tb_subtotal.Text = (float.Parse(tb_Duckling.Text) + float.Parse(tb_Male_Duck.Text) + float.Parse(tb_Female_Duck.Text)).ToString();
            }
            catch
            {
            }
        }

        private void frm_duck_details_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Duck_Breed_Name_TB", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            cmb_Breed_Name.SelectedIndex = -1;
            cmb_Breed_Name.DisplayMember = "Breed Name";
            cmb_Breed_Name.DataSource = dt;
        }

        private void cmb_Breed_Name_SelectedIndexChanged(object sender, EventArgs e)
        {

            tblpnl_cattle_details.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sn = new SqlCommand("Select Top(1) Sr_No from Village_Or_City_Profile_TB Order by Sr_No desc", con);
            string Sr_No = Convert.ToString(sn.ExecuteScalar());
            sn.Dispose();

            if (cmb_Breed_Name.Text != "" && tb_Duckling.Text != "" && tb_Male_Duck.Text != "" && tb_Female_Duck.Text != "" && tb_subtotal.Text != "")
            {
                SqlCommand cmd = new SqlCommand("insert into Duck_Details_TB values('" + cmb_Breed_Name.Text + "'," + tb_Duckling.Text + "," + tb_Male_Duck.Text + "," + tb_Female_Duck.Text + "," + tb_subtotal.Text + ","+ Sr_No +")", con);

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

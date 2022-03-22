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
    public partial class frm_dog_details : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Live_Stock_Census_DB;Integrated Security=True");

        public frm_dog_details()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            frm_Personal_Details fpd = new frm_Personal_Details();
            fpd.Show();
            this.Hide();
        }

        private void tb_Pupys_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                 lbl_Error_Pupys.Visible = true;
                lbl_Error_Pupys.Text = ("Plese Enter Count of Pupys");
            }
            else
            {
                lbl_Error_Pupys.Visible = false;
            }
            
        }

        private void tb_Male_Dogs_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                lbl_Error_Male_Dog.Visible = true;
                lbl_Error_Male_Dog.Text = ("Plese Enter Count of Male Dog");
            }
            else
            {
                lbl_Error_Male_Dog.Visible = false;
            }
        }

        private void tb_Female_Dog_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                lbl_Error_Female_Dog.Visible = true;
                lbl_Error_Female_Dog.Text = ("Plese Enter Count of Female Dog");
            }
            else
            {
                lbl_Error_Female_Dog.Visible = false;
            }
        }

       
        private void btn_save_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sn = new SqlCommand("Select Top(1) Sr_No from Village_Or_City_Profile_TB Order by Sr_No desc", con);
            string Sr_No = Convert.ToString(sn.ExecuteScalar());
            sn.Dispose();

            if (cmb_Breed_Name.Text != "" && tb_Pupys.Text != "" && tb_Male_Dogs.Text != "" && tb_Female_Dog.Text != "" && tb_subtotal.Text !="")
            {
                SqlCommand cmd = new SqlCommand("insert into Dog_Details_TB values('" + cmb_Breed_Name.Text + "'," + tb_Pupys.Text + "," + tb_Male_Dogs.Text + "," + tb_Female_Dog.Text + "," + tb_subtotal.Text + ","+ Sr_No +")", con);

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

        private void tb_Female_Dog_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tb_subtotal.Text = (float.Parse(tb_Pupys.Text) + float.Parse(tb_Male_Dogs.Text) + float.Parse(tb_Female_Dog.Text)).ToString();
            }
            catch
            {
            }
        }

        private void lbl_bread_name_Click(object sender, EventArgs e)
        {

        }

        private void frm_dog_details_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Dog_Breed_Name_TB", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            cmb_Breed_Name.SelectedIndex = -1;
            cmb_Breed_Name.DisplayMember = "Breed Name";
            cmb_Breed_Name.DataSource = dt;
        }
    }
}

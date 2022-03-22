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
    public partial class frm_other_birds : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Live_Stock_Census_DB;Integrated Security=True");

        public frm_other_birds()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            frm_Personal_Details fpd = new frm_Personal_Details();
            fpd.Show();
            this.Hide();
        }

        private void tb_Chick_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                lbl_Error_Chick.Visible = true;
                lbl_Error_Chick.Text = ("Plese Enter Count of Chick");
            }
            else
            {
                lbl_Error_Chick.Visible = false;
            }
        }

        private void tb_Male_birds_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                lbl_Error_Male_Bird.Visible = true;
                lbl_Error_Male_Bird.Text = ("Plese Enter Count of Male Bitrds");
            }
            else
            {
                lbl_Error_Male_Bird.Visible = false;
            }
        }

        private void tb_Female_Birds_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                lbl_Error_Female_Birds.Visible = true;
                lbl_Error_Female_Birds.Text = ("Plese Enter Count of Female Bitrds");
            }
            else
            {
                lbl_Error_Female_Birds.Visible = false;
            }
        }

        private void tb_Female_Birds_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tb_Subtotal.Text = (float.Parse(tb_Chick.Text) + float.Parse(tb_Male_birds.Text) + float.Parse(tb_Male_birds.Text)).ToString();
            }
            catch
            {
            }
        }

        private void frm_other_birds_Load(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Other_Birds_Breed_Name_TB", con);
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

            if (cmb_Breed_Name.Text != "" && tb_Chick.Text != "" && tb_Male_birds.Text != "" && tb_Female_Birds.Text != "" && tb_Subtotal.Text != "")
            {
                SqlCommand cmd = new SqlCommand("insert into Other_Birds_Details_TB values('" + cmb_Breed_Name.Text + "'," + tb_Chick.Text + "," + tb_Male_birds.Text + "," + tb_Female_Birds.Text + "," + tb_Subtotal.Text + "," + Sr_No + ")", con);

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

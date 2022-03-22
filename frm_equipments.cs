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
    public partial class frm_equipments : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Live_Stock_Census_DB;Integrated Security=True");

        public frm_equipments()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            frm_Personal_Details fpd = new frm_Personal_Details();
            fpd.Show();
            this.Hide();
        }

        private void tb_Incubators_Or_Breeders_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                lbl_Error_Incubators.Visible = true;
                lbl_Error_Incubators.Text = ("Plese Enter Count of Incubators Or Breeders");
            }
            else
            {
                lbl_Error_Incubators.Visible = false;
            }

        }

        private void tb_Milking_Machine_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                lbl_Error_Milking_Machine.Visible = true;
                lbl_Error_Milking_Machine.Text = ("Plese Enter Count of Milking Matchine");
            }
            else
            {
                lbl_Error_Milking_Machine.Visible = false;
            }
        }

        private void tb_Fodder_Cutter_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                lbl_Error_Fodder_Cutter.Visible = true;
                lbl_Error_Fodder_Cutter.Text = ("Plese Enter Count of Fodder Cutters");
            }
            else
            {
                lbl_Error_Fodder_Cutter.Visible = false;
            }
        }

        private void tb_Choper_And_Baler_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                lbl_Error_Choper.Visible = true;
                lbl_Error_Choper.Text = ("Plese Enter Count of Choper And Balers");
            }
            else
            {
                lbl_Error_Choper.Visible = false;
            }
        }

        private void tb_Dung_Collection_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                lbl_Error_Dung_Collection.Visible = true;
                lbl_Error_Dung_Collection.Text = ("Plese Enter Count of Dung_Collection");
            }
            else
            {
                lbl_Error_Dung_Collection.Visible = false;
            }
        }

        private void tb_Dung_Collection_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tb_Subtotal.Text = (float.Parse(tb_Dung_Collection.Text) + float.Parse(tb_Milking_Machine.Text) + float.Parse(tb_Fodder_Cutter.Text) + float.Parse(tb_Choper_And_Baler.Text) + float.Parse(tb_Incubators_Or_Breeders.Text)).ToString();
            }
            catch
            {
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sn = new SqlCommand("Select Top(1) Sr_No from Village_Or_City_Profile_TB Order by Sr_No desc", con);
            string Sr_No = Convert.ToString(sn.ExecuteScalar());
            sn.Dispose();

            if (tb_Incubators_Or_Breeders.Text != "" && tb_Milking_Machine.Text != "" && tb_Fodder_Cutter.Text != "" && tb_Choper_And_Baler.Text != "" && tb_Dung_Collection.Text!="" && tb_Subtotal.Text != "")
            {
                SqlCommand cmd = new SqlCommand("insert into Equipents_Details_TB values(" + tb_Incubators_Or_Breeders.Text + "," + tb_Milking_Machine.Text + "," + tb_Fodder_Cutter.Text + "," + tb_Choper_And_Baler.Text + "," + tb_Dung_Collection.Text + "," + tb_Subtotal.Text + ","+ Sr_No +")", con);
                
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

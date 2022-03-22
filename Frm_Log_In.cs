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
    public partial class Frm_Log_In : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Live_Stock_Census_DB;Integrated Security=True");

        public Frm_Log_In()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            if (tb_Username.Text != "" && tb_Password.Text != "" && cmb_UserRole.SelectedIndex == 0)
            {

                con.Open();

                SqlCommand cmd = new SqlCommand("Select * From Survair_Login_D where Username = '" + tb_Username.Text + "' and Password = '" + tb_Password.Text + "' ", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string cmbItemValue = cmb_UserRole.SelectedItem.ToString();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["UserType"].ToString() == cmbItemValue)
                        {
                            MessageBox.Show("You are logged in as " + dt.Rows[i][2]);
                            Global_Vars.Username = "Welcome " + tb_Username.Text;
                            if (cmb_UserRole.SelectedIndex == 0)
                            {
                                Global_Vars.Urole = 1;
                            }
                            //else if (cmb_UserRole.SelectedIndex == 1)
                            //{
                            //    Global_Vars.Urole = 2;
                            //}

                           Frm_Survair_Dashbord DD = new Frm_Survair_Dashbord();
                            DD.Show();
                            this.Hide();

                            con.Close();
                        }
                        //else
                        //{
                        //    MessageBox.Show("Please enter valid username and password");
                        //}
                    }

                }
                else
                {
                    MessageBox.Show("No data found for Admin");
                    tb_Username.Clear();
                    tb_Password.Clear();
                    cmb_UserRole.SelectedIndex = -1;
                }
            }
            else if (tb_Username.Text != "" && tb_Password.Text != "" && cmb_UserRole.SelectedIndex == 1)
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("Select * Taluka_Officer_TB From  where Username = '" + tb_Username.Text + "' and Password = '" + tb_Password.Text + "' ",con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string cmbItemValue = cmb_UserRole.SelectedItem.ToString();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["UserType"].ToString() == cmbItemValue)
                        {
                            MessageBox.Show("You are logged in as " + dt.Rows[i][2]);
                            Global_Vars.Username = "Welcome " + tb_Username.Text;
                            if (cmb_UserRole.SelectedIndex == 1)
                            {
                                Global_Vars.Urole = 2;
                            }
                            Frm_Survair_Dashbord DD = new Frm_Survair_Dashbord();
                            DD.Show();
                            this.Hide();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("No data found for Manager");
                    tb_Username.Clear();
                    tb_Password.Clear();
                    cmb_UserRole.SelectedIndex = -1;
                }
            }
            else if (tb_Username.Text != "" && tb_Password.Text != "" && cmb_UserRole.SelectedIndex == 2)
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("Select * From District_Officer  where Username = '" + tb_Username.Text + "' and Password = '" + tb_Password.Text + "' ", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string cmbItemValue = cmb_UserRole.SelectedItem.ToString();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["UserType"].ToString() == cmbItemValue)
                        {
                            MessageBox.Show("You are logged in as " + dt.Rows[i][2]);
                            Global_Vars.Username = "Welcome " + tb_Username.Text;
                            if (cmb_UserRole.SelectedIndex == 2)
                            {
                                Global_Vars.Urole = 3;
                            }
                            Frm_District_Dashbord DD = new Frm_District_Dashbord();
                            DD.Show();
                            this.Hide();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("No data found for Wireman");
                    tb_Username.Clear();
                    tb_Password.Clear();
                    cmb_UserRole.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Please fill login details");
            }
        }

        private void pnl_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Frm_Sign_In sl = new Frm_Sign_In();
            sl.Show();
            this.Hide();
        }
    }
}

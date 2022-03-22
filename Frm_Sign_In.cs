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
    public partial class Frm_Sign_In : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Live_Stock_Census_DB;Integrated Security=True");

        public Frm_Sign_In()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            con.Open();
            if (rb_Male.Checked == false && rb_Female.Checked == false)
            {
                label1.Text = "Please select the gender";
            }
            else
            {
                string Gender;
                if (rb_Male.Checked == true)
                {
                    Gender = rb_Male.Text;
                }
                else
                {
                    Gender = rb_Female.Text;
                }

                if (tb_Fullname.Text != "" && tb_Mobno.Text != "" && tb_Email.Text != "" && cmb_UserRole.Text != "" && pb_User_Photo.Image != null && Gender != "" && tb_Username.Text != "" && tb_AdminKey.Text != "" && tb_Password.Text != "" && tb_Confirm_Password.Text != "" && tb_Password.Text == tb_Confirm_Password.Text)
                {
                    if (cmb_UserRole.SelectedIndex == 0)
                    {

                        ImageConverter Ic = new ImageConverter();
                        byte[] ImgArray = (byte[])Ic.ConvertTo(pb_User_Photo.Image, typeof(byte[]));


                        // admin key verification

                        string key = "Select Admin_Key from Key_Value where User_type = @UType ";

                        SqlCommand cmd = new SqlCommand(key, con);

                        cmd.Parameters.Add("@UType", SqlDbType.NVarChar).Value = "Survaier";

                        string PassedAKey = Convert.ToString(cmd.ExecuteScalar());

                        cmd.Dispose();

                        if (PassedAKey == tb_AdminKey.Text)
                        {
                            string str = "Insert into Survair_RegD (Full_Name, Mobile_No, Email, UserRole, User_P, Gender, Username, Survair_Key) Values(@Full_Name, @Mobile_No, @Email, @UserRole, @User_P, @Gender, @Username, @AdminKey, @Password)";

                            SqlCommand Cmd = new SqlCommand(str, con);

                            Cmd.Parameters.Add("@Full_Name", SqlDbType.VarChar).Value = tb_Fullname.Text;
                            Cmd.Parameters.Add("@Mobile_No", SqlDbType.BigInt).Value = tb_Mobno.Text;
                            Cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = tb_Email.Text;
                            Cmd.Parameters.Add("UserRole", SqlDbType.VarChar).Value = cmb_UserRole.Text;
                            Cmd.Parameters.Add("User_P", SqlDbType.Image).Value = ImgArray;
                            Cmd.Parameters.Add("Gender", SqlDbType.VarChar).Value = Gender;
                            Cmd.Parameters.Add("Username", SqlDbType.NVarChar).Value = tb_Username.Text;
                            Cmd.Parameters.Add("AdminKey", SqlDbType.NVarChar).Value = tb_AdminKey.Text;
                            Cmd.Parameters.Add("Password", SqlDbType.NVarChar).Value = tb_Password.Text;

                            Cmd.ExecuteNonQuery();

                            string str1 = "Insert into Survair_Login_D (Username, Password, UserType) Values(@Username, @Password, @UserType)";
                            SqlCommand Cmd1 = new SqlCommand(str1, con);

                            Cmd1.Parameters.Add("@Username", SqlDbType.NVarChar).Value = tb_Username.Text;
                            Cmd1.Parameters.Add("@Password", SqlDbType.NVarChar).Value = tb_Password.Text;
                            Cmd1.Parameters.Add("@UserType", SqlDbType.VarChar).Value = cmb_UserRole.Text;

                            Cmd1.ExecuteNonQuery();

                            MessageBox.Show("Manager Registration is sucessfully");
                            frm_village_or_city_profile L = new frm_village_or_city_profile();
                            L.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Admin Key", "Wrong Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                     
                    }
                    else if (cmb_UserRole.SelectedIndex == 1)
                    {
                      
                        ImageConverter Ic = new ImageConverter();
                        byte[] ImgArray = (byte[])Ic.ConvertTo(pb_User_Photo.Image, typeof(byte[]));

                        // admin key verification

                        string key = "Select Admin_Key from Admin_Login_D where UserType = @UType ";

                        SqlCommand cmd = new SqlCommand(key, con);

                        cmd.Parameters.Add("@UType", SqlDbType.NVarChar).Value = "Survair";

                        string PassedAKey = Convert.ToString(cmd.ExecuteScalar());

                        cmd.Dispose();

                        if (PassedAKey == tb_AdminKey.Text)
                        {
                            string str = "Insert into Taluka_Officer_RegD(Full_Name, Mobile_No, Email, UserRole, User_P, Gender, Username, AdminKey, Password) Values(@Full_Name, @Mobile_No, @Email, @UserRole, @User_P, @Gender, @Username, @AdminKey, @Password)";

                            SqlCommand Cmd = new SqlCommand(str, con);

                            Cmd.Parameters.Add("@Full_Name", SqlDbType.VarChar).Value = tb_Fullname.Text;
                            Cmd.Parameters.Add("@Mobile_No", SqlDbType.BigInt).Value = tb_Mobno.Text;
                            Cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = tb_Email.Text;
                            Cmd.Parameters.Add("UserRole", SqlDbType.VarChar).Value = cmb_UserRole.Text;
                            Cmd.Parameters.Add("User_P", SqlDbType.Image).Value = ImgArray;
                            Cmd.Parameters.Add("Gender", SqlDbType.VarChar).Value = Gender;
                            Cmd.Parameters.Add("Username", SqlDbType.NVarChar).Value = tb_Username.Text;
                            Cmd.Parameters.Add("AdminKey", SqlDbType.NVarChar).Value = tb_AdminKey.Text;
                            Cmd.Parameters.Add("Password", SqlDbType.NVarChar).Value = tb_Password.Text;

                            Cmd.ExecuteNonQuery();

                            string str1 = "Insert into Taluka_Officer_TB (Username, Password, UserType) Values(@Username, @Password, @UserType)";
                            SqlCommand Cmd1 = new SqlCommand(str1, con);

                            Cmd1.Parameters.Add("@Username", SqlDbType.NVarChar).Value = tb_Username.Text;
                            Cmd1.Parameters.Add("@Password", SqlDbType.NVarChar).Value = tb_Password.Text;
                            Cmd1.Parameters.Add("@UserType", SqlDbType.VarChar).Value = cmb_UserRole.Text;

                            Cmd1.ExecuteNonQuery();

                            MessageBox.Show("Wireman Registration is sucessfully");
                            Frm_Taluka_Dashbord L = new Frm_Taluka_Dashbord();
                            L.Show();
                            this.Hide();
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Admin Key", "Wrong Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Error11");
                }
                //frm_Login L = new frm_Login();
                //L.Show();
                //this.Hide();
                con.Close();

           
        }
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {

            OpenFileDialog OF = new OpenFileDialog();
            OF.Filter = "Image files (*.jpg; *.jpeg;) | *.jpg; *.jpeg; ";

            if (OF.ShowDialog() == DialogResult.OK)
            {
                pb_User_Photo.Image = new Bitmap(OF.FileName);
            }
        }

        private void lnl_adminKey_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnl_adminKey.Text == "Show")
            {
                lnl_adminKey.Text = "Hide";
                tb_AdminKey.PasswordChar = '\0';
            }
            else
            {
                lnl_adminKey.Text = "Show";
                tb_AdminKey.PasswordChar = '*';
            }
        }

        private void lnl_Show_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (lnl_Show.Text == "Show")
            {
                lnl_Show.Text = "Hide";
                tb_Confirm_Password.PasswordChar = '\0';
            }
            else
            {
                lnl_Show.Text = "Show";
                tb_Confirm_Password.PasswordChar = '*';
            }
        }

        private void btn_back_to_Login_Click(object sender, EventArgs e)
        {
            Frm_Log_In li = new Frm_Log_In();
            li.Show();
            li.Hide();
        }
    }
}
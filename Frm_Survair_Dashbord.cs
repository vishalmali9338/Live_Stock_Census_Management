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
    public partial class Frm_Survair_Dashbord : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Live_Stock_Census_DB;Integrated Security=True");

        public Frm_Survair_Dashbord()
        {
            InitializeComponent();
        }

        private void Frm_Survair_Dashbord_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select Village_Or_City_Profile_TB.Name_of_House_Hold, Village_Or_City_Profile_TB.State, Village_Or_City_Profile_TB.District, Village_Or_City_Profile_TB.Taluka, Village_Or_City_Profile_TB.Village, Personal_Details_TB.Caste,  Personal_Details_TB.Income,Cattle_Details_TB.Cattle_Breeds,Cattle_Subtotal,Buffalo_Breed,B_Subtotal,Goat_Breed_Name, Goat_Subtotal,Sheep_Breed_Name,Sheep_Subtotal,Horse_Breed,Horse_Subtotal,Cat_Breed_Name,Cat_Subtotal,Eqip_Subtotal from Village_Or_City_Profile_TB a ,Personal_Details_TB p ,Cattle_Details_TB mc,Buffalo_Details_TB mb,Goat_Details_TB Fg,Sheep_Details_TB Fs,Horse_Detail_TB Fh,Cat_Details_TB Cd,Equipents_Details_TB Et  where a.Sr_No = p.Sr_No and a.Sr_No = mc.Sr_No and a.Sr_No = mb.Sr_No and a.Sr_No = Fg.Sr_No and a.Sr_No = Fs.Sr_No and a.Sr_No=Fh.Sr_No and  a.Sr_No=Cd.Sr_No and a.Sr_No = Et.Sr_No", con);
        
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DG_S_Dashbord.DataSource = dt;

            con.Close();



            
        }
    }
}

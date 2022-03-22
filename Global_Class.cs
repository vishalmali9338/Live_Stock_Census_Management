using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace project
{
    class Global_state
    {
         public static string Username = "";
        public static int Urole = 0;

        string connection = (@"Data Source=.\SQLEXPRESS;Initial Catalog=Live_Stock_Census_DB;Integrated Security=True");
        public SqlConnection con;

        public void Connect_DB()
        {
            con = new SqlConnection(connection);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void Disconnect_Db()
        {
            con = new SqlConnection(connection);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }


        public void FilltableDb(string Get_Query)
        {
            Connect_DB();

            SqlDataAdapter Sda = new SqlDataAdapter(Get_Query, con);

            DataTable dt = new DataTable();

            Sda.Fill(dt);

            Sda.Dispose();
            dt.Dispose();
        }

        public void Update_Table(string get_u_query)
        {
            Connect_DB();

            SqlDataAdapter Usda = new SqlDataAdapter(get_u_query,con);

            DataTable Udt = new DataTable();
            Usda.Fill(Udt);

            Usda.Dispose();
            Udt.Dispose();

        }



      
    }
}

using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BreachingDroneElite
{
    class DataLayer
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public static string SQLQuery(string query)
        {
            string connStr = "server=192.168.12.10;user=root;database=facedb;port=3306;password=TheytoOkEr4Jobs!";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "";
                sql = query;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr.GetInt32(0) + " -- " + rdr.GetString(1) + " -- "  + rdr.GetString(3));
                }
                rdr.Close();
                return Convert.ToString(rdr);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
            return "";
        }
        private void llOpenConnAndSelect_LinkClicked(object sender,
             LinkLabelLinkClickedEventArgs e)
        {
        }
        public static int GetUserCount()
        {
            return Convert.ToInt32 ( SQLQuery("SELECT MAX (id) FROM face"));
        }
    }
}


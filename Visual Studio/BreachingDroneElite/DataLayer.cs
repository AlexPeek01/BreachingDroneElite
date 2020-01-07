using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreachingDroneElite
{
    class DataLayer
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        private void llOpenConnAndSelect_LinkClicked(object sender,
             LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string connstring = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};");
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                string sql = "SELECT * FROM simple_table";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                conn.Close();
            }
            catch (Exception msg)
            {
                throw;
            }
        }
    }
}

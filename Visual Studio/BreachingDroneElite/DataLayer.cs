﻿using Npgsql;
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
        public static int userCount;
        public static void SQLQuery(string query)
        {
            string connStr = "server=192.168.12.10;user=root;database=facedb;port=3306;password=TheytoOkEr4Jobs!";
            //string connStr = "server=192.168.12.13;user=bde;database=facedb;port=5432;password=bde";
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
                userCount = rdr.GetInt32(0);
                rdr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }
        private void llOpenConnAndSelect_LinkClicked(object sender,
             LinkLabelLinkClickedEventArgs e)
        {
        }
    }
}


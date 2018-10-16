using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DAL_Whatever_Music
{
    public class Conexao
    {
        public static MySqlConnection Conectar()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection
                    ("server=localhost; user=root; password=''; database=whatever");
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("Problemas na conexão! /n" + ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; //cliente MySQL para comandos SQL

namespace ProdutosBD
{
    class Conexao
    {


        private static string connString ="Server=localhost;Database=dbprodutos;Uid=root;Pwd=";

        private static MySqlConnection conn = null;


        public static MySqlConnection obterConexao()
        {
            conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
            }
            catch (MySqlException)
            {
                conn = null;
            }
            return conn;
        }

        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}

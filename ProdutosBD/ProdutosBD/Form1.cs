using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProdutosBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            MySqlCommand comm = new MySqlCommand();
            
            comm.Connection = Conexao.obterConexao();

            MessageBox.Show("Conexão aberta"); 

            Conexao.fecharConexao();

            MessageBox.Show("Conexão fechada");
        }
    }
}

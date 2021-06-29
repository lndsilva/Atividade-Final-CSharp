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

    public partial class frmGerenciarProdutos : Form
    {
        public frmGerenciarProdutos()
        {
            InitializeComponent();
        }

        static int botaoqueestouclicando;
        static DialogResult vresp;
        private void btnCodProd_Click(object sender, EventArgs e)
        {
            if ((rdbCodigo.Checked == false) && (rdbNome.Checked == false))
            {
                MessageBox.Show("Favor selecionar uma opção para pesquisar!!!",
                    "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1); 

            }
            else
            {


                if (rdbCodigo.Checked)
                {
                    try
                    {
                        MySqlCommand comm = new MySqlCommand();
                        comm.CommandText = "select * from produtos where codigo = " + txtDescricao.Text + ";";
                        comm.CommandType = CommandType.Text;
                        comm.Connection = Conexao.obterConexao(); 

                        MySqlDataReader DR;
                        DR = comm.ExecuteReader();
                        DR.Read();

                        txtCodigo.Text = Convert.ToString(DR.GetInt32(0));
                        txtDescr.Text = DR.GetString(1);
                        txtPreVend.Text = Convert.ToString(DR.GetDecimal(2));
                        txtPreCompr.Text = Convert.ToString(DR.GetDecimal(3));
                        txtEstAtual.Text = Convert.ToString(DR.GetDecimal(4));

                        ltbProd.Items.Add(DR.GetInt32(0) + " - " + DR.GetString(1));

                        Conexao.fecharConexao();

                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Favor Inserir Valores Válidos");
                        //cancelarCampos();
                    }
                    Conexao.fecharConexao();
                }
                if (rdbNome.Checked)
                {
                    try
                    {


                        MySqlCommand comm = new MySqlCommand();
                        comm.CommandText = "select * from produtos where descricao like '%" + txtDescricao.Text + "%';";
                        comm.CommandType = CommandType.Text;
                        comm.Connection = Conexao.obterConexao();

                        MySqlDataReader DR;
                        DR = comm.ExecuteReader();

                        ltbProd.Items.Clear();

                        while (DR.Read())
                        {
                            ltbProd.Items.Add(DR.GetInt32(0) + " - " + DR.GetString(1));
                        }

                        //txtDescricao.Text = "";
                        //txtDescricao.Focus();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Favor Inserir Valores Válidos");
                        // cancelarCampos();


                    }
                    Conexao.fecharConexao();
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT CODIGO + 1 FROM produtos order by codigo desc;";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = Convert.ToString(DR.GetInt32(0));


            ativarCampos();
            botaoqueestouclicando = 1;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            lblInformacao.Text = "Você clicou no botão novo!!!";
        }
        public void ativarCampos()
        {
            txtDescr.ReadOnly = false;
            txtPreVend.ReadOnly = false;
            txtPreCompr.ReadOnly = false;
            txtEstAtual.ReadOnly = false;
            txtDescr.Focus();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            switch (botaoqueestouclicando)
            {
                case 1: salvarValores();
                    break;
                case 2: alterarValores();
                    break;
                default:
                    break;
            }
  
        }

        public void salvarValores()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into produtos (DESCRICAO,PVENDA,PCOMPRA,ESTOQUEATUAL)VALUES (@DESCRICAO, @PVENDA, @PCOMPRA, @ESTOQUEATUAL); ";
                comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@DESCRICAO", MySqlDbType.VarChar, 100).Value = txtDescr.Text;
            comm.Parameters.Add("@PVENDA", MySqlDbType.Decimal, 18).Value = txtPreVend.Text;
            comm.Parameters.Add("@PCOMPRA", MySqlDbType.Decimal, 18).Value = txtPreCompr.Text;
            comm.Parameters.Add("@ESTOQUEATUAL", MySqlDbType.Decimal, 18).Value = txtEstAtual.Text;

            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            int res = comm.ExecuteNonQuery();
            MessageBox.Show("Valores Inseridos com Sucesso!!! " + res);

            Conexao.fecharConexao();
            lblInformacao.Text = "";
        }

        public void alterarValores()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "UPDATE produtos SET descricao=@descricao,pvenda=@pvenda, pcompra = @pcompra,estoqueatual = @estoqueatual WHERE codigo = " + txtCodigo.Text;
                comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();
            comm.Parameters.Clear();
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 50).Value = txtDescr.Text;
            comm.Parameters.Add("@pvenda", MySqlDbType.Decimal, 18).Value = txtPreVend.Text;
            comm.Parameters.Add("@pcompra", MySqlDbType.Decimal, 18).Value = txtPreCompr.Text;
            comm.Parameters.Add("@estoqueatual", MySqlDbType.Decimal, 18).Value = txtEstAtual.Text;


            int res = comm.ExecuteNonQuery();
            MessageBox.Show("Valores Alterados com Sucesso!!! " + res);

            Conexao.fecharConexao();
        }

        public void excluirValores()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "DELETE FROM produtos WHERE codigo=@codigo";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();
            comm.Parameters.Clear();
            comm.Parameters.Add("@codigo", MySqlDbType.Int32).Value = txtCodigo.Text;

            vresp = MessageBox.Show("Deseja Realizar a Exclusão?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (vresp == DialogResult.Yes)
            {
                int res = comm.ExecuteNonQuery();
                MessageBox.Show("Registro Excluido com Sucesso!!! " + res);
                //cancelarCampos();
            }
            else if (vresp == DialogResult.No)
            {

                //cancelarCampos();
            }

            Conexao.fecharConexao();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ativarCampos();
            botaoqueestouclicando = 2;
            btnAlterar.Enabled = false;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluirValores();
        }
    }
}
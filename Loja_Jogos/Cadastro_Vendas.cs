using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_Jogos
{
    public partial class Cadastro_Vendas : Form
    {
        string idREGISTRO;      
        string fk_venda;
        string unidade;
        string id_venda;

        public Cadastro_Vendas()
        {
            InitializeComponent();
            Lista_Produtos();
            Nova_Venda();
        }

        private void Limpar()
        {
            textBoxUNIDADE.Clear();
            numericUpDown1.ResetText();
        }

        private void ValorUNID()
        {
            try
            {
                BD_MySQL.conexao.Open();
                BD_MySQL.comando.CommandText = "SELECT preco FROM tbl_produtos WHERE id = '" + idREGISTRO + "'";
                MySqlDataReader resultado = BD_MySQL.comando.ExecuteReader();

                if (resultado.Read())
                {
                    unidade = resultado.GetDouble(0).ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                BD_MySQL.conexao.Close();
            }
        }

        private void Lista_Produtos()
        {
            try
            {
                BD_MySQL.conexao.Open();
                BD_MySQL.comando.CommandText = "SELECT * FROM tbl_produtos;";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(BD_MySQL.comando);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);

                dataGridViewPRODUTOS.DataSource = tabela;
                dataGridViewPRODUTOS.Columns["id"].HeaderText = "código";
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                BD_MySQL.conexao.Close();
            }
        }

        private void Nova_Venda()
        {
            try
            {
                BD_MySQL.conexao.Open();
                BD_MySQL.comando.CommandText = "INSERT INTO tbl_vendas(data_compra,fk_clientes, fk_funcionarios) VALUES (CURDATE(), " + BD_MySQL.id_cliente + "," + BD_MySQL.id_func + ");";
                BD_MySQL.comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                BD_MySQL.conexao.Close();
            }            

            try
            {
                BD_MySQL.conexao.Open();
                BD_MySQL.comando.CommandText = "SELECT MAX(id) FROM tbl_vendas;";
                MySqlDataReader resultado = BD_MySQL.comando.ExecuteReader();

                if (resultado.Read())
                {
                    id_venda = resultado.GetInt32(0).ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                BD_MySQL.conexao.Close();
            }
        }

        private void buttonADICIONAR_Click_1(object sender, EventArgs e)
        {
            fk_vendas();
            string produto = dataGridViewPRODUTOS.CurrentRow.Cells[0].Value.ToString();

            if (textBoxUNIDADE.Text != "" && numericUpDown1.Text != "")
            {
                try
                {
                    BD_MySQL.conexao.Open();
                    BD_MySQL.comando.CommandText = "INSERT INTO tbl_itens_vendas(fk_produtos, fk_vendas, quantidade, valor_venda) VALUES ('" + produto + "', '" + fk_venda + "', '" + numericUpDown1.Text + "', '"+textBoxUNIDADE.Text.Replace(",",".")+"');";
                    BD_MySQL.comando.ExecuteNonQuery();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    BD_MySQL.conexao.Close();
                }

                BD_MySQL.carrinho = BD_MySQL.carrinho + (double.Parse(numericUpDown1.Value.ToString()) * double.Parse(textBoxUNIDADE.Text));
                MessageBox.Show(BD_MySQL.carrinho.ToString());
                textBoxTOTAL.Text = BD_MySQL.carrinho.ToString();

                Limpar();
            }
        }     

        private void fk_vendas()
        {
                try
                {
                    BD_MySQL.conexao.Open();
                    BD_MySQL.comando.CommandText = "SELECT MAX(id) FROM tbl_vendas";
                    MySqlDataReader resultado = BD_MySQL.comando.ExecuteReader();

                    if (resultado.Read())
                    {
                        fk_venda = resultado.GetInt32(0).ToString();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    BD_MySQL.conexao.Close();
                }
        }

        private void buttonCONCLUIR_Click_1(object sender, EventArgs e)
        {
            try
            {
                BD_MySQL.conexao.Open();
                BD_MySQL.comando.CommandText = "UPDATE tbl_vendas SET valor_total = " + textBoxTOTAL.Text.Replace(",",".") + " WHERE id = " + id_venda + ";";
                BD_MySQL.comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                BD_MySQL.conexao.Close();
            }
            MessageBox.Show("Compra finalizada com sucesso");
            id_venda = null;

            if (DialogResult.Yes == MessageBox.Show("Deseja iniciar uma nova venda? Caso não o aplicativo irá encerrar", "Atenção", MessageBoxButtons.YesNo))
            {
                Nova_Venda();
                Lista_Produtos();
            }
            else
            {
                this.Close();
            }
            Limpar();
        }
       

        private void buttonCANCELAR_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Deseja realmente cancelar a compra?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        private void dataGridViewPRODUTOS_DoubleClick(object sender, EventArgs e)
        {
                idREGISTRO = dataGridViewPRODUTOS.CurrentRow.Cells[0].Value.ToString();

                textBoxUNIDADE.Text = dataGridViewPRODUTOS.CurrentRow.Cells[2].Value.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
                if (idREGISTRO.ToString().Length > 0 && numericUpDown1.Text != "")
                {
                    ValorUNID();
                    //labelUNIDADE.Text = $"R$ " + unidade + "";
                    double unitario = double.Parse(unidade);
                    int quantidade = int.Parse(numericUpDown1.Value.ToString());
                    //textBoxTOTAL.Text = $"R$ " + (unitario * quantidade) + "";
                }
        }
    }
}

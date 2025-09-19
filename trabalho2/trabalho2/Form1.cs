using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trabalho2.objeto;

namespace trabalho2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //chamo o metodo da conexao
            conexao com = new conexao();
            com.getConexao();
            // chama o objeto do financeiro
            financeiro financeiro = new financeiro();
            financeiro.id = Convert.ToInt32(txtcodigo.Text);
            if (financeiro.Excluir(com) == true)
            {
                MessageBox.Show("Excluido com sucesso");
                dataGridView1.Refresh();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conexao com = new conexao();
            com.getConexao();
            if (string.IsNullOrEmpty(txtpesquisa.Text))
            {
                dataGridView1.DataSource = com.obterdados("select * from financeiro");
            }
            else
            {
                dataGridView1.DataSource = com.obterdados("select * from financeiro where descricao like '%" + txtpesquisa.Text + "%' or data_lancamento like '%" + txtpesquisa
                    .Text + "%'");
            }
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            con.getConexao();
            //chamando o objeto financeiro
            financeiro fin = new financeiro();
            //populando as informações
            fin.data_lancamento = data_lancamento.Value;
            fin.descricao = txtdescricao.Text;
            fin.servico = cboservico.Text;
            fin.valor = decimal.Parse(txtvalor.Text);
            fin.tipo = cbotipo.Text;
            fin.pgto = chkpagamento.Checked;
            if (fin.cadastrar(con) == true)
            {
                MessageBox.Show("Cadastrado com sucesso");
                dataGridView1.Refresh();// atualiza o grid
            }

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            //chamo o metodo da conexao
            conexao com = new conexao();
            com.getConexao();
            // chama o objeto do financeiro
            financeiro financeiro= new financeiro();
            financeiro.id = Convert.ToInt32(txtcodigo.Text);
            financeiro.descricao = txtdescricao.Text;
            financeiro.servico = cboservico.Text;
            financeiro.tipo = cbotipo.Text;
            financeiro.valor = decimal.Parse(txtvalor.Text);
            financeiro.pgto = chkpagamento.Checked;
            financeiro.data_lancamento = data_lancamento.Value;
            if (financeiro.editar(com) == true)
            {
                MessageBox.Show("Editado com sucesso!");
            }
        }

        private void btnproximo_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = 0;
            codigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            txtcodigo.Text = codigo.ToString();
            txtdescricao.Text = dataGridView1.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
            txtvalor.Text = dataGridView1.Rows[e.RowIndex].Cells["valor"].Value.ToString();
            cboservico.Text = dataGridView1.Rows[e.RowIndex].Cells["servico"].Value.ToString();
            cbotipo.Text = dataGridView1.Rows[e.RowIndex].Cells["tipo"].Value.ToString();
            //convertendo o data implicitamente
            data_lancamento.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["data_lancamento"].Value;
            bool pago = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["pgto"].Value.ToString());
            if (pago == true)
            {
                chkpagamento.Checked = true;
            }
            else
            {
                chkpagamento.Checked = false;
            }
        }

        private void txtpesquisa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

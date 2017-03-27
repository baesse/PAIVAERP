using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paivaVersao0
{
    public partial class frmPgFuncionario : MetroFramework.Forms.MetroForm
    {
        string tipo = "";
        public frmPgFuncionario()
        {
            InitializeComponent();
        }
        public frmPgFuncionario(string tipopagamento)
        {
            tipo = "Fornecedor";
            InitializeComponent();
        }

        private void teste_Load(object sender, EventArgs e)
        {

            //TERMINAR GRID DOS FUNCIONARIOS
          
            ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();
            MySqlConnection getconexao = conexao.getConexao();
            MySqlCommand getcomado = conexao.getComando(getconexao);
            getcomado.CommandText = "SELECT dataVencimento,nomeFornecedor,descricaoLancamento,referencia,categoria,valor,datavencimento from pagamento where tipopagamento=@tipo";
            getcomado.Parameters.AddWithValue("@tipo", tipo);
            DataTable tabela = new DataTable();
            GRIDFUNCIONARIOPAGAR.AutoGenerateColumns = false;
            MySqlDataReader reader = conexao.getReader(getcomado);
            //tabela.Columns[5].DataType.("C2")


            tabela.Load(reader);
            GRIDFUNCIONARIOPAGAR.DataSource = tabela;
            //GRIDFUNCIONARIOPAGAR.Columns[1].HeaderText = "Agendamento";
            //GRIDFUNCIONARIOPAGAR.Columns[2].HeaderText = "Nome do fucionario";
            //GRIDFUNCIONARIOPAGAR.Columns[3].HeaderText = "Descrição";
            //GRIDFUNCIONARIOPAGAR.Columns[4].HeaderText = "Referencia";
            //GRIDFUNCIONARIOPAGAR.Columns[5].HeaderText = "Categoria";
            //GRIDFUNCIONARIOPAGAR.Columns[6].HeaderText = "Valor devido";
            //this.GRIDFUNCIONARIOPAGAR.Columns[6].DefaultCellStyle.Format = "C2";
            //GRIDFUNCIONARIOPAGAR.Columns.Add("Valorpagar", "Valor a pagar");
            //GRIDFUNCIONARIOPAGAR.Columns.Add("datapagamento", "Data do pagamento");

            
        }

        private void GRIDFUNCIONARIOPAGAR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            ArrayList valores = new ArrayList();

            int valor = 0;
            foreach (DataGridViewRow dr in GRIDFUNCIONARIOPAGAR.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    int valoinicial = Convert.ToInt32(dr.Cells[5].Value);

                    valor = valoinicial + valor;


                    lblvalortotal.Text = valor.ToString();
                    lblvalortotal.Text = valor.ToString("c");
                    valores.Add(dr.Index.ToString());


                }


            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }
    }
}

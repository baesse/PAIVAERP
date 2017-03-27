using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paivaVersao0
{
    public partial class frmcontrolefinanceiro : MetroFramework.Forms.MetroForm
    {
        public frmcontrolefinanceiro()
        {
            InitializeComponent();
        }

        private void frmcontrolefinanceiro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_paivaDataSet.pagamento' table. You can move, or remove it, as needed.

            PreencherGridPagamentoEmAberto();
            PreencherGridrecebimentoEmAberto();
            PreencherGridPROXIMASARECEBER();
            PreencherGridrecebimentoVencido();
            prenchergridpagamentosvencidos();
            prenchergridpagamentosquefuturosarecebervencidos();

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            CadFuncionario novocadastro = new CadFuncionario("funcionario");
            novocadastro.ShowDialog();


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadFuncionario frmcadfuncinario = new CadFuncionario();
            frmcadfuncinario.ShowDialog();
        }

        private void cadastroDeFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgendarPagamentos frmpag = new AgendarPagamentos("Fornecedor");
            frmpag.ShowDialog();





        }

      
        private void cadastroDeFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista lista = new Lista("Funcionarios");
            lista.ShowDialog();

            //ArrayList ids = new ArrayList();

            //ConfigClasses.ConexaoBanco conexaobanco = new ConfigClasses.ConexaoBanco();

            //MySqlConnection conexao = conexaobanco.getConexao();
            //MySqlCommand comando = conexaobanco.getComando(conexao);
            //comando.CommandText = "select  nome,idfuncionarios from funcionarios";
            //DataTable tabela = new DataTable();
            //MySqlDataReader reader = conexaobanco.getReader(comando);

            //while (reader.Read())
            //{
            //    ids.Add(reader.GetString(1));

            //}
            //reader.Close();
            //reader = conexaobanco.getReader(comando);
            //tabela.Load(reader);
            //gridFuncionarios.DataSource = tabela;
            //gridFuncionarios.Refresh();
            //gridFuncionarios.Columns[0].HeaderText = "Nome       ";
            //groupBox1.Visible = true;
            //groupBox2.Visible = true;




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           


        }

        private void aGENDARPAGAMENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgendarPagamentos agendarpagamento = new AgendarPagamentos("Funcionario");
            agendarpagamento.ShowDialog();

        }

        private void pAGARToolStripMenuItem_Click(object sender, EventArgs e)
        {


            frmPgFuncionario frmpg = new frmPgFuncionario();
            frmpg.ShowDialog();





        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void GRIDFUNCIONARIOPAGAR_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void GRIDFUNCIONARIOPAGAR_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void pagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPgFuncionario frm = new frmPgFuncionario();
            frm.ShowDialog();



        }

        private void rceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPgFuncionario frmagenda = new frmPgFuncionario("Cliente");
            frmagenda.Show();

        }

        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Lista lista = new Lista("Fornecedores");
            lista.ShowDialog();

            //Fornecedorgp.Visible = true;



            //ConfigClasses.ConexaoBanco conexaobanco = new ConfigClasses.ConexaoBanco();

            //MySqlConnection conexao = conexaobanco.getConexao();
            //MySqlCommand comando = conexaobanco.getComando(conexao);
            //comando.CommandText = "select  nome from fornecedores";
            //DataTable tabela = new DataTable();
            //MySqlDataReader reader = conexaobanco.getReader(comando);         
            //reader.Close();
            //reader = conexaobanco.getReader(comando);
            //tabela.Load(reader);
            //datagrifornecedor.DataSource = tabela;
            //datagrifornecedor.Refresh();
            //datagrifornecedor.Columns[0].HeaderText = "Nome       ";


        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            CadFuncionario frmcad = new CadFuncionario("Fornecedor");
            frmcad.ShowDialog();
        }

        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista lista = new Lista("clientefinanceiro");
            
            lista.ShowDialog();

        }

        private void agendarRecebimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgendarPagamentos agendarecebimento = new AgendarPagamentos("RECEBIMENTO");
            agendarecebimento.ShowDialog();

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contas frmlista = new Contas();
            frmlista.ShowDialog();

        }

        private void contasRecebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Contas frmlista = new Contas();
            frmlista.ShowDialog();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Contas frmlista = new Contas();
            frmlista.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            

        }

        public void PreencherGridPagamentoEmAberto()
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();
            MySqlConnection getconexao = conexao.getConexao();
            MySqlCommand getcomando = conexao.getComando(getconexao);
            getcomando.CommandText = "SELECT NOMEFORNECEDOR,VALOR FROM PAGAMENTO where status=@status";
            getcomando.Parameters.AddWithValue("@status", "emaberto");

            MySqlDataReader READER = conexao.getReader(getcomando);
            DataTable TABELA = new DataTable();
            TABELA.Load(READER);
            gridpgemaberto.DataSource = TABELA;
            double valortotal = 0;

            foreach (DataGridViewRow dr in gridpgemaberto.Rows)
            {
                if (dr.Cells[1].Value != null)
                {
                    valortotal += Convert.ToDouble(dr.Cells[1].Value);
                }
               

            }
            string headergrid = valortotal.ToString("C");
            gridpgemaberto.Columns[1].HeaderText = "Total: " + headergrid;
        }



        public void PreencherGridrecebimentoEmAberto()
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();
            MySqlConnection getconexao = conexao.getConexao();
            MySqlCommand getcomando = conexao.getComando(getconexao);
            getcomando.CommandText = "SELECT NOMEFORNECEDOR,VALOR FROM recebimento where status=@status";
            getcomando.Parameters.AddWithValue("@status", "emaberto");

            MySqlDataReader READER = conexao.getReader(getcomando);
            DataTable TABELA = new DataTable();
            TABELA.Load(READER);
            recebimentoaberto.DataSource = TABELA;
            double valortotal = 0;

            foreach (DataGridViewRow dr in recebimentoaberto.Rows)
            {
                if (dr.Cells[1].Value != null)
                {
                    valortotal += Convert.ToDouble(dr.Cells[1].Value);
                }


            }
            string headergrid = valortotal.ToString("C");
            recebimentoaberto.Columns[1].HeaderText = "Total: " + headergrid;
        }



        public void PreencherGridrecebimentoVencido()
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();
            MySqlConnection getconexao = conexao.getConexao();
            MySqlCommand getcomando = conexao.getComando(getconexao);
            getcomando.CommandText = "SELECT NOMEFORNECEDOR,VALOR,dataVencimento FROM recebimento where status=@status";
            getcomando.Parameters.AddWithValue("@status", "emaberto");
            DataTable TABELA = new DataTable();
            MySqlDataReader READER = conexao.getReader(getcomando);
           
            while (READER.Read())
            {
                string hoje = DateTime.Now.Date.ToString("dd/MM/yyyy");
                DateTime vencimento = Convert.ToDateTime(READER.GetString(2));
                TimeSpan diferenca = vencimento  - Convert.ToDateTime(hoje);
                if (diferenca.Days < 0)
                {
                    metroGrid2.Rows.Add(READER.GetString(0), READER.GetString(1), READER.GetString(2));

                }                
                
            }



            double valortotal=0;

            foreach (DataGridViewRow dr in metroGrid2.Rows)
            {
                if (dr.Cells[1].Value != null)
                {
                    valortotal += Convert.ToDouble(dr.Cells[1].Value);
                }


            }
            string headergrid = valortotal.ToString("C");
            metroGrid2.Columns[1].HeaderText = "Total: " + headergrid;
        }


        public void PreencherGridPROXIMASARECEBER()
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();
            MySqlConnection getconexao = conexao.getConexao();
            MySqlCommand getcomando = conexao.getComando(getconexao);
            getcomando.CommandText = "SELECT NOMEFORNECEDOR,VALOR,dataVencimento FROM recebimento where status=@status";
            getcomando.Parameters.AddWithValue("@status", "emaberto");
            DataTable TABELA = new DataTable();
            MySqlDataReader READER = conexao.getReader(getcomando);

            while (READER.Read())
            {
                string hoje = DateTime.Now.Date.ToString("dd/MM/yyyy");
                DateTime vencimento = Convert.ToDateTime(READER.GetString(2));
                TimeSpan diferenca = vencimento - Convert.ToDateTime(hoje);
                if (diferenca.Days > 0)
                {
                    metroGrid3.Rows.Add(READER.GetString(0), READER.GetString(1), READER.GetString(2));


                }

            }



            double valortotal = 0;

            foreach (DataGridViewRow dr in metroGrid3.Rows)
            {
                if (dr.Cells[1].Value != null)
                {
                    valortotal += Convert.ToDouble(dr.Cells[1].Value);
                }


            }
            string headergrid = valortotal.ToString("C");
            metroGrid3.Columns[1].HeaderText = "Total: " + headergrid;
        }

        public void prenchergridpagamentosvencidos()
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();
            MySqlConnection getconexao = conexao.getConexao();
            MySqlCommand getcomando = conexao.getComando(getconexao);
            getcomando.CommandText = "SELECT NOMEFORNECEDOR,VALOR,dataVencimento FROM pagamento where status=@status";
            getcomando.Parameters.AddWithValue("@status", "emaberto");
            DataTable TABELA = new DataTable();
            MySqlDataReader READER = conexao.getReader(getcomando);

            while (READER.Read())
            {
                string hoje = DateTime.Now.Date.ToString("dd/MM/yyyy");
                DateTime vencimento = Convert.ToDateTime(READER.GetString(2));
                TimeSpan diferenca = vencimento - Convert.ToDateTime(hoje);
                if (diferenca.Days < 0)
                {
                    metroGrid5.Rows.Add(READER.GetString(0), READER.GetString(1), READER.GetString(2));

                }

            }



            double valortotal = 0;

            foreach (DataGridViewRow dr in metroGrid5.Rows)
            {
                if (dr.Cells[1].Value != null)
                {
                    valortotal += Convert.ToDouble(dr.Cells[1].Value);
                }


            }
            string headergrid = valortotal.ToString("C");
            metroGrid5.Columns[1].HeaderText = "Total: " + headergrid;
        }

        public void prenchergridpagamentosquefuturosarecebervencidos()
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();
            MySqlConnection getconexao = conexao.getConexao();
            MySqlCommand getcomando = conexao.getComando(getconexao);
            getcomando.CommandText = "SELECT NOMEFORNECEDOR,VALOR,dataVencimento FROM pagamento where status=@status";
            getcomando.Parameters.AddWithValue("@status", "emaberto");
            DataTable TABELA = new DataTable();
            MySqlDataReader READER = conexao.getReader(getcomando);

            while (READER.Read())
            {
                string hoje = DateTime.Now.Date.ToString("dd/MM/yyyy");
                DateTime vencimento = Convert.ToDateTime(READER.GetString(2));
                TimeSpan diferenca = vencimento - Convert.ToDateTime(hoje);
                if (diferenca.Days > 0)
                {
                    metroGrid4.Rows.Add(READER.GetString(0), READER.GetString(1), READER.GetString(2));

                }

            }



            double valortotal = 0;

            foreach (DataGridViewRow dr in metroGrid4.Rows)
            {
                if (dr.Cells[1].Value != null)
                {
                    valortotal += Convert.ToDouble(dr.Cells[1].Value);
                }


            }
            string headergrid = valortotal.ToString("C");
            metroGrid4.Columns[1].HeaderText = "Total: " + headergrid;
        }


    }
}

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
    public partial class frmcontrolepedidos : MetroFramework.Forms.MetroForm
    {
        public frmcontrolepedidos()
        {
            InitializeComponent();
        }

        private void frmcontrolepedidos_Load(object sender, EventArgs e)
        {

            ConfigClasses.ConexaoBanco manipulaBanco = new ConfigClasses.ConexaoBanco();
            MySqlConnection getconexao = manipulaBanco.getConexao();
            MySqlCommand getComando = manipulaBanco.getComando(getconexao);
            getComando.CommandText = "SELECT idcliente,nomecliente from cliente";
            MySqlDataReader getreader = manipulaBanco.getReader(getComando);

            while (getreader.Read())
            {
                cbbclientes.Items.Add(getreader.GetString(1));

            }


        }

        private void btnBuscaCodigo_Click(object sender, EventArgs e)
        {

            BuscarPorCodigo();
            
        }

        public void BuscarPorCodigo()
        {
            ConfigClasses.ConexaoBanco carregartabela = new ConfigClasses.ConexaoBanco();
            MySqlConnection conexao = carregartabela.getConexao();
            MySqlCommand comando = carregartabela.getComando(conexao);
            comando.CommandText = "SELECT idcliente,produto,regiao,formadecontato,solicitante,urgencia,idpessoa from cadpedido where @id=idpedido";
            comando.Parameters.AddWithValue("@id", txtCodigoPedido.Text);
            MySqlDataReader reader = carregartabela.getReader(comando);
            DataTable TABELAPARAGRID = new DataTable();
            TABELAPARAGRID.Load(reader);
         
            TABELA.DataSource = TABELAPARAGRID;
            TABELA.Refresh();
            TABELA.Columns[0].HeaderText = "Código do cliente";
            TABELA.Columns[1].HeaderText = "Produto";
            TABELA.Columns[2].HeaderText = "Região";
            TABELA.Columns[3].HeaderText = "Forma de contato";
            TABELA.Columns[4].HeaderText = "Solicitante";
            TABELA.Columns[5].HeaderText = "Urgencia";
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            buscaRazaoSocial();

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(txtcpfcnpj.Mask.Equals( "000.000.000-00"))
            {
                txtcpfcnpj.Mask = "00.00.00.00/0000-00";

            }else
            {
                txtcpfcnpj.Mask = "000.000.000-00";

            }

           

        }
        public string replaceString(string cpfcnpj)
        {
            string cpfcnpjr = cpfcnpj;
            cpfcnpjr = cpfcnpj.Replace(".", "");
            cpfcnpjr = cpfcnpj.Replace("_", "");
            cpfcnpjr = cpfcnpj.Replace(",", "");
            cpfcnpjr = cpfcnpj.Replace(".", "");
            cpfcnpjr = cpfcnpj.Replace("/", "");
            cpfcnpjr = cpfcnpj.Replace(" ", "");
            cpfcnpjr = cpfcnpj.Replace("-", "");
            return cpfcnpjr;

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigClasses.ConexaoBanco carregartabela = new ConfigClasses.ConexaoBanco();
            MySqlConnection conexao = carregartabela.getConexao();
            MySqlCommand comando = carregartabela.getComando(conexao);
            comando.CommandText = "SELECT idcliente,produto,regiao,formadecontato,solicitante,urgencia,idpessoa from cadpedido where estado=@estado";
            comando.Parameters.AddWithValue("@estado", cbbEstado.Text);
            MySqlDataReader reader = carregartabela.getReader(comando);
            DataTable TABELAPARAGRID = new DataTable();
            TABELAPARAGRID.Load(reader);
            TABELA.DataSource = TABELAPARAGRID;
            TABELA.Refresh();
            TABELA.Columns[0].HeaderText = "Código do cliente";
            TABELA.Columns[1].HeaderText = "Produto";
            TABELA.Columns[2].HeaderText = "Região";
            TABELA.Columns[3].HeaderText = "Forma de contato";
            TABELA.Columns[4].HeaderText = "Solicitante";
            TABELA.Columns[5].HeaderText = "Urgencia";
            TABELA.Columns[6].HeaderText = "Código pessoa";

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

            ConfigClasses.ConexaoBanco carregartabela = new ConfigClasses.ConexaoBanco();
            MySqlConnection conexao = carregartabela.getConexao();
            MySqlCommand comando = carregartabela.getComando(conexao);
            comando.CommandText = "SELECT idcliente,produto,regiao,formadecontato,solicitante,urgencia,idpessoa from cadpedido where cidade like @cidade";
            comando.Parameters.AddWithValue("@cidade", txtCidade.Text);
            MySqlDataReader reader = carregartabela.getReader(comando);
            DataTable TABELAPARAGRID = new DataTable();
            TABELAPARAGRID.Load(reader);
            TABELA.DataSource = TABELAPARAGRID;
            TABELA.Refresh();
            TABELA.Columns[0].HeaderText = "Código do cliente";
            TABELA.Columns[1].HeaderText = "Produto";
            TABELA.Columns[2].HeaderText = "Região";
            TABELA.Columns[3].HeaderText = "Forma de contato";
            TABELA.Columns[4].HeaderText = "Solicitante";
            TABELA.Columns[5].HeaderText = "Urgencia";
            TABELA.Columns[6].HeaderText = "Código pessoa";

        }

        public void buscaRazaoSocial()
        {
            ConfigClasses.ConexaoBanco carregartabela = new ConfigClasses.ConexaoBanco();
            MySqlConnection conexao = carregartabela.getConexao();
            MySqlCommand comando = carregartabela.getComando(conexao);
            comando.CommandText = "SELECT idcliente,produto,regiao,formadecontato,solicitante,urgencia,idpessoa from cadpedido where razaosocial like @razaosocial";
            comando.Parameters.AddWithValue("@razaosocial", txtRazaoSocial.Text);
            MySqlDataReader reader = carregartabela.getReader(comando);
            DataTable TABELAPARAGRID = new DataTable();
            TABELAPARAGRID.Load(reader);
            TABELA.DataSource = TABELAPARAGRID;
            TABELA.Refresh();
            TABELA.Columns[0].HeaderText = "Código do cliente";
            TABELA.Columns[1].HeaderText = "Produto";
            TABELA.Columns[2].HeaderText = "Região";
            TABELA.Columns[3].HeaderText = "Forma de contato";
            TABELA.Columns[4].HeaderText = "Solicitante";
            TABELA.Columns[5].HeaderText = "Urgencia";
            TABELA.Columns[6].HeaderText = "Código pessoa";
        }
        public void buscaCpfCnpj()
        {
            ConfigClasses.ConexaoBanco carregartabela = new ConfigClasses.ConexaoBanco();
            MySqlConnection conexao = carregartabela.getConexao();
            MySqlCommand comando = carregartabela.getComando(conexao);
            comando.CommandText = "SELECT idcliente,produto,regiao,formadecontato,solicitante,urgencia,idpessoa from cadpedido where cpfcnpj=@cpfcnpj";
            string BUSCA = replaceString(txtcpfcnpj.Text);
            BUSCA = BUSCA.Replace(",", "");
            comando.Parameters.AddWithValue("@cpfcnpj", BUSCA);
            MySqlDataReader reader = carregartabela.getReader(comando);
            DataTable TABELAPARAGRID = new DataTable();
            TABELAPARAGRID.Load(reader);
            TABELA.DataSource = TABELAPARAGRID;
            TABELA.Refresh();
            TABELA.Columns[0].HeaderText = "Código do cliente";
            TABELA.Columns[1].HeaderText = "Produto";
            TABELA.Columns[2].HeaderText = "Região";
            TABELA.Columns[3].HeaderText = "Forma de contato";
            TABELA.Columns[4].HeaderText = "Solicitante";
            TABELA.Columns[5].HeaderText = "Urgencia";
            TABELA.Columns[6].HeaderText = "Código pessoa";
        }

        private void cbbclientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigClasses.ConexaoBanco carregartabela = new ConfigClasses.ConexaoBanco();
            MySqlConnection conexao = carregartabela.getConexao();
            MySqlCommand comando = carregartabela.getComando(conexao);
            comando.CommandText = "SELECT idcliente,produto,regiao,formadecontato,solicitante,urgencia,idpessoa from cadpedido where nomecliente like @nome";
            comando.Parameters.AddWithValue("@nome", cbbclientes.Text);
            MySqlDataReader reader = carregartabela.getReader(comando);
            DataTable TABELAPARAGRID = new DataTable();
            TABELAPARAGRID.Load(reader);
            TABELA.DataSource = TABELAPARAGRID;
            TABELA.Refresh();
            TABELA.Columns[0].HeaderText = "Código do cliente";
            TABELA.Columns[1].HeaderText = "Produto";
            TABELA.Columns[2].HeaderText = "Região";
            TABELA.Columns[3].HeaderText = "Forma de contato";
            TABELA.Columns[4].HeaderText = "Solicitante";
            TABELA.Columns[5].HeaderText = "Urgencia";
            TABELA.Columns[6].HeaderText = "Código pessoa";

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {

            ConfigClasses.ConexaoBanco carregartabela = new ConfigClasses.ConexaoBanco();
            MySqlConnection conexao = carregartabela.getConexao();
            MySqlCommand comando = carregartabela.getComando(conexao);
            comando.CommandText = "SELECT cpfcnpj,nome,razaosocial,,solicitante,urgencia,idpessoa from cadpessoapedido where nomecliente like @nome";

            ArrayList ids = new ArrayList();


            comando.Parameters.AddWithValue("@nome", txtNomeCliente.Text);
            MySqlDataReader reader = carregartabela.getReader(comando);
            DataTable TABELAPARAGRID = new DataTable();
            TABELAPARAGRID.Load(reader);
            TABELA.DataSource = TABELAPARAGRID;
            TABELA.Refresh();
            TABELA.Columns[0].HeaderText = "Código do cliente";
            TABELA.Columns[1].HeaderText = "Produto";
            TABELA.Columns[2].HeaderText = "Região";
            TABELA.Columns[3].HeaderText = "Forma de contato";
            TABELA.Columns[4].HeaderText = "Solicitante";
            TABELA.Columns[5].HeaderText = "Urgencia";
            TABELA.Columns[6].HeaderText = "Código pessoa";
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}

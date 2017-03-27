using MySql.Data.MySqlClient;
using System;
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
    public partial class frmagenda : MetroFramework.Forms.MetroForm
    {
        public frmagenda()
        {
            InitializeComponent();
        }

        private void frmagenda_Load(object sender, EventArgs e)
        {
            ConfigClasses.ConexaoBanco conectabanco = new ConfigClasses.ConexaoBanco();
            MySqlConnection conexao = conectabanco.getConexao();
            MySqlCommand comando = conectabanco.getComando(conexao);
            comando.CommandText = "SELECT nomecliente,razaosocial,status,datapedido from cadpedido where status=@status";
            comando.Parameters.AddWithValue("@status", "PENDENTE");
            MySqlDataReader reader = conectabanco.getReader(comando);
           
          

            DataTable TABELABUSCA = new DataTable();
            TABELABUSCA.Load(reader);
            TABELA.DataSource = TABELABUSCA;
            TABELA.Refresh();
            TABELA.Columns[0].HeaderText = "Cliente";
            TABELA.Columns[1].HeaderText = "Razão Social";
            TABELA.Columns[2].HeaderText = "Status";
            TABELA.Columns[3].HeaderText = "Data do cadastro";
           
          

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

        }
    }
}

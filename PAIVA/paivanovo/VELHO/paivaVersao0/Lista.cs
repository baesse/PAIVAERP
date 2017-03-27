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
    public partial class Lista : MetroFramework.Forms.MetroForm
    {
        string tipoform = "";
        //string tabela = "";



        public Lista()
        {
            InitializeComponent();
        }
        public Lista(string tipo)
        {
            if (tipo.Equals("Fornecedores"))
            {
                this.Text = "Fornecedores";
                tipoform = "Fornecedores";
              

                InitializeComponent();
                btnadicionar.Text = "Adcionar fornecedores    +";

            }
            else if (tipo.Equals("Funcionarios"))
            {
               
                this.Text = "Funcionarios";
                tipoform = "Funcionarios";
                InitializeComponent();
                btnadicionar.Text = "Adcionar Funcionarios   +";
            }
            else
            {
              
                this.Text = "Cliente";
                tipoform = "clientefinanceiro";
                 InitializeComponent();
                btnadicionar.Text = "Adcionar Cliente  +";
            }
        }
       

        private void Lista_Load(object sender, EventArgs e)
        {
            ArrayList nomes = new ArrayList();

            ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();
            MySqlConnection getconexao = conexao.getConexao();
            MySqlCommand getcomando = conexao.getComando(getconexao);
            getcomando.CommandText = "Select nome,valorpagamento from " + tipoform;
            DataTable tabela = new DataTable();            
            MySqlDataReader reader = conexao.getReader(getcomando);           
            tabela.Load(reader);
            datagridnomesevalores.DataSource = tabela;
           
            double total = 0;

            foreach (DataGridViewRow dr in datagridnomesevalores.Rows)
            {
                if (dr.Cells[1].Value != null)
                {


                    total = total + Convert.ToDouble(dr.Cells[1].Value);
                }


            }
            datagridnomesevalores.Columns[1].HeaderText = total.ToString("C");
            metroLabel6.Text = "  Total: " + total.ToString("C");

        }

       

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            if (tipoform.Equals("clientefinanceiro"))
            {
                CadClientefinanceiro frm = new CadClientefinanceiro();
                frm.ShowDialog();

            }
            else
            {
                CadFuncionario frmfuncionar = new CadFuncionario(tipoform);
                frmfuncionar.ShowDialog();
            }
        }
    }
}

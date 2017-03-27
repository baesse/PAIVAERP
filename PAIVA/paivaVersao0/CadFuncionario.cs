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
    public partial class CadFuncionario : MetroFramework.Forms.MetroForm
    {
        string tabela;

        public CadFuncionario()
        {
            InitializeComponent();
        }

        public CadFuncionario(string tipo)
        {
            if (tipo.Equals("Fornecedores"))
            {
                InitializeComponent();
                tabela = "Fornecedores";

                this.Text = "Novo fornecedor";

            }else if (tipo.Equals("Funcionarios"))
            {
                InitializeComponent();
                tabela = "funcionarios";

                this.Text = "Novo Funcionario";

            }
           

        }

        private void CadFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

            ClassesPrograma.funcionarioCadastro funcionarioNovo = new ClassesPrograma.funcionarioCadastro
            {
                nomeFuncionario = txtNomeFuncionario.Text,
                cpf=txtCpf.Text,                           
                banco= txtBanco.Text,
                agencia=txtAgencia.Text,
                conta=txtConta.Text,
                telefone=txtTelefone.Text,
                celular=txtCelular.Text,
                email=txtEmail.Text,
                pessoadecontato=txtPessoaContato.Text,
                razaosocial=txtRazaoSocial.Text,
                inscmunicipal=txtInscMunicipal.Text,
                cep=txtCep.Text,
                endereco=txtEndereco.Text,
                bairro=txtBairro.Text,
                estado=cbbEstado.Text,
                cidade=txtCidade.Text,
               
               
                
            };

         

            string cpf = funcionarioNovo.cpf;
            cpf = funcionarioNovo.replace(cpf);
            if (validaCadastro() & funcionarioNovo.validarCpf(cpf) )
            {

                if (radioFisica.Checked)
                {
                    funcionarioNovo.tipopessoa = "Fisica";
                }
                else if (radioJuridica.Checked)
                {
                    funcionarioNovo.tipopessoa = "Pessoa Juridica";

                }
                else
                {
                    MessageBox.Show("Favor selecionar o tipo de pessoa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }


                ConfigClasses.ConexaoBanco conexaobanco = new ConfigClasses.ConexaoBanco();
                MySqlConnection conexao = conexaobanco.getConexao();

                MySqlCommand comando = conexaobanco.getComando(conexao);
                comando.CommandText = "INSERT INTO "+ tabela + "(nome,banco,agencia,conta,dataCadastro,cpf,telefone,celular,email,pessoadecontato,razaosocial,inscmunicipal,cep,endereco,bairro,estado,cidade,tipopessoa)VALUES(@nome,@banco,@agencia,@conta,@dataCadastro,@cpf,@telefone,@celular,@email,@pessoadecontato,@razaosocial,@inscmunicipal,@cep,@endereco,@bairro,@estado,@cidade,@tipopessoa);";

                comando.Parameters.AddWithValue("@nome", funcionarioNovo.nomeFuncionario);
                comando.Parameters.AddWithValue("@banco", funcionarioNovo.banco);
                comando.Parameters.AddWithValue("@agencia", funcionarioNovo.agencia);
                comando.Parameters.AddWithValue("@conta", funcionarioNovo.conta);
                comando.Parameters.AddWithValue("@dataCadastro", DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
                comando.Parameters.AddWithValue("@cpf", cpf);
                comando.Parameters.AddWithValue("@telefone", funcionarioNovo.telefone);
                comando.Parameters.AddWithValue("@celular", funcionarioNovo.celular);
                comando.Parameters.AddWithValue("@email", funcionarioNovo.email);
                comando.Parameters.AddWithValue("@pessoadecontato", funcionarioNovo.pessoadecontato);
                comando.Parameters.AddWithValue("@razaosocial", funcionarioNovo.razaosocial);
                comando.Parameters.AddWithValue("@inscmunicipal", funcionarioNovo.inscmunicipal);
                comando.Parameters.AddWithValue("@cep", funcionarioNovo.cep);
                comando.Parameters.AddWithValue("@endereco", funcionarioNovo.endereco);
                comando.Parameters.AddWithValue("@bairro", funcionarioNovo.bairro);
                comando.Parameters.AddWithValue("@estado", funcionarioNovo.estado);
                comando.Parameters.AddWithValue("@cidade", funcionarioNovo.cidade);
                comando.Parameters.AddWithValue("@tipopessoa", funcionarioNovo.tipopessoa);
                comando.ExecuteNonQuery();
                MessageBox.Show(tabela+"cadastrado com sucesso!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();

           
            }



        }


        private Boolean validaCadastro()
        {
            if (txtNomeFuncionario.Text == "")
            {
                MessageBox.Show("O nome do"+tabela+" não pode ser vázio", "Erro no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (txtBanco.Text == "")
            {
                MessageBox.Show("O banco do"+tabela+" não pode ser vázio", "Erro no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (txtAgencia.Text == "")
            {
                MessageBox.Show("A agencia do"+tabela+" não pode ser vázio", "Erro no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (txtAgencia.Text == "")
            {
                MessageBox.Show("A agencia do"+tabela+" não pode ser vázio", "Erro no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
           
            return true;


            

        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            ArrayList endereco = ClassesPrograma.Funcoes.BuscaCep(txtCep.Text);

            if (endereco != null)          {




                txtCep.Text = endereco[0].ToString();
                txtEndereco.Text = endereco[1].ToString();
                txtBairro.Text = endereco[7].ToString();
                cbbEstado.Text = endereco[5].ToString();
                txtCidade.Text = endereco[4].ToString();
            }
        }
    }
}

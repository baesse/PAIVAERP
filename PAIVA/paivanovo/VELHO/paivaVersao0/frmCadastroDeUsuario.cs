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
    public partial class frmCadastroDeUsuario : MetroFramework.Forms.MetroForm
    {
        public frmCadastroDeUsuario()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {


            if (validaCadastro())
            {


                ConfigClasses.ConexaoBanco manipulabanco = new ConfigClasses.ConexaoBanco();
                try
                {

                    MySqlConnection conexao = manipulabanco.getConexao();
                    MySqlCommand comando = manipulabanco.getComando(conexao);
                    comando.CommandText = "INSERT INTO cad_usuario (Usuario,Senha,tipoAcessoPermisao) values (@nomeusuario,@senha,@tipodeacesso)";
                    comando.Parameters.AddWithValue("@nomeusuario", txtUsuaio.Text);
                    comando.Parameters.AddWithValue("@senha", txtSenha.Text);
                    comando.Parameters.AddWithValue("@tipodeacesso", permissaoAcesso.Text);
                    comando.ExecuteNonQuery();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Erro de conexão com o banco favor entrar em contato com o suporte", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                limpaCadastro();

            }


        }

        private Boolean validaCadastro()
        {
            if (txtUsuaio.Text == "" || txtSenha.Text == "" || txtRepetirSenha.Text == "" || txtRepetirSenha.Text != txtSenha.Text || permissaoAcesso.Text == "")
            {
                MessageBox.Show("Favor preencher o cadastro de acordo com o que se pede.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }
            else
            {
                return true;

            }
        }

        private void limpaCadastro()
        {
            txtSenha.Text = "";
            txtRepetirSenha.Text = "";
            permissaoAcesso.Text = "";

        }

        private void frmCadastroDeUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frmcontrole : MetroFramework.Forms.MetroForm
    {
        public frmcontrole()
        {
            InitializeComponent();
        }

        private void frmcontrole_Load(object sender, EventArgs e)
        {
            novo_Usuario.Visible = false;

        }

        private void novoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novo_Usuario.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassesPrograma.Usuario usuarionovo = new ClassesPrograma.Usuario
            {
                nome = txtNomeUsuario.Text,
                senha = txtSenha.Text,
                acesso = cbbTipoAcesso.Text,

            };

            if (validaUsuario())
            {
                ConfigClasses.ConexaoBanco manipulabanco = new ConfigClasses.ConexaoBanco();
                MySqlConnection getConexao = manipulabanco.getConexao();
                MySqlCommand getComando = manipulabanco.getComando(getConexao);
                getComando.CommandText = "INSERT INTO cad_usuario (Usuario,Senha,tipoAcessoPermisao) values (@nomeusuario,@Senha,@tipodeacesso)";                                         ;
                getComando.Parameters.AddWithValue("@nomeusuario", usuarionovo.nome);
                getComando.Parameters.AddWithValue("@Senha", usuarionovo.senha);
                getComando.Parameters.AddWithValue("@tipodeacesso", usuarionovo.acesso);
                getComando.ExecuteNonQuery();
                MessageBox.Show("Usuario cadastrado com sucesso !!!", "Novo Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getConexao.Close();

            }

        }

        private Boolean validaUsuario()
        {
            if (txtSenha.Text.Equals(txtValidaSenha.Text))
            {
                if (txtSenha.Text.Length < 4)
                {
                    MessageBox.Show("A senha deve ter no minimo 4 caracteres", "Senha invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Senhas não coicidem favor digitar novamente", "Senha não coicidem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSenha.Text = "";
                txtValidaSenha.Text = "";
                return false;
            }
            return true;

        }

        private void padronizaNome()
        {
            string nome = "";
            

            nome = txtNomeUsuario.Text;
            txtNomeUsuario.Text = nome.ToUpper();

           


        }

        private void txtNomeUsuario_Leave(object sender, EventArgs e)
        {
            padronizaNome();
        }
    }
}

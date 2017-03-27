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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public Boolean logado = false;
        public ArrayList usuariodados = new ArrayList();

        public frmLogin()
        {
            InitializeComponent();
            preencherUsuarios();


        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void btnlogin_Click(object sender, EventArgs e)
        {





        }


        public Boolean validarformulario()
        {
            if (cbbusuario.Text == "" || txtsenha.Text == "")
            {
                MessageBox.Show("Favor digitar os dados de login.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }
            else
            {
                return true;

            }
        }

        public void preencherUsuarios()
        {

            try
            {
                ConfigClasses.ConexaoBanco ManipularBancods = new ConfigClasses.ConexaoBanco();
                MySqlConnection conexao = ManipularBancods.getConexao();
                MySqlCommand comando = ManipularBancods.getComando(conexao);
                comando.CommandText = "Select Usuario from cad_usuario";
                MySqlDataReader reader = ManipularBancods.getReader(comando);

                while (reader.Read())
                {
                    cbbusuario.Items.Add(reader.GetString(0));

                }

            }
            catch (MySqlException)
            {
                MessageBox.Show("Erro de conexão com o banco favor entrar em contato com o suporte", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void validaLogin()
        {



            if (validarformulario())
            {





                try

                {
                    ConfigClasses.ConexaoBanco ManipularBancod = new ConfigClasses.ConexaoBanco();
                    MySqlConnection conexao = ManipularBancod.getConexao();
                    MySqlCommand comando = ManipularBancod.getComando(conexao);
                    comando.CommandText = "Select usuario, senha, tipoAcessoPermisao from cad_usuario where usuario=@usuariobusca and senha=@usuariosenha ";
                    comando.Parameters.AddWithValue("@usuariobusca", cbbusuario.Text);
                    comando.Parameters.AddWithValue("@usuariosenha", txtsenha.Text);
                    MySqlDataReader reader = ManipularBancod.getReader(comando);

                    while (reader.Read())
                    {
                        if (reader.GetString(0).Equals(cbbusuario.Text) && reader.GetString(1).Equals(txtsenha.Text))
                        {

                            logado = true;

                            usuariodados.Add(reader.GetString("usuario"));
                            usuariodados.Add(reader.GetString("senha"));
                            usuariodados.Add(reader.GetString("TipoAcessoPermisao"));

                            conexao.Close();
                            reader.Close();
                            this.Dispose();
                            return;



                        }
                        


                    }
                    MessageBox.Show("Senha invalida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txtsenha.Text = "";
                    logado = false;




                }
                catch (MySqlException)
                {
                    MessageBox.Show("Erro de conexão com o banco favor entrar em contato com o suporte", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }






            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {

            validaLogin();


        }
    }
}

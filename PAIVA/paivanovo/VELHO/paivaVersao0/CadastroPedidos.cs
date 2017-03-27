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
    public partial class CadastroPedidos : MetroFramework.Forms.MetroForm
    {
        int idempresa;
        ClassesPrograma.Cliente clientecad = new ClassesPrograma.Cliente();


        public CadastroPedidos()
        {
            InitializeComponent();
        }
       

        private void CPFCNPJ_Click(object sender, EventArgs e)
        { 

            
            if (txtCpfCnpj.Mask.Equals("000.000.000-00"))
            {
                txtCpfCnpj.Mask=("00.00.00.00/0000-00");
                txtCpfCnpj.Width = 145;
                txtNome.Text = "";
                txtRazaoSocial.Text = "";
                txtInscEstadual.Text = "";
                txtInscMunicipal.Text = "";
                cbbAtividade.Text = "";
              
                txtRg.Text = "";
              
                txtCpfCnpj.Text = "";




            }
            else
            {
                txtCpfCnpj.Mask=("000.000.000-00");
                txtCpfCnpj.Width = 108;
                txtNome.Text = "";
                txtRazaoSocial.Text = "";
                txtInscEstadual.Text = "";
                txtInscMunicipal.Text = "";
                cbbAtividade.Text = "";
                
                txtRg.Text = "";
                
                txtCpfCnpj.Text = "";

            }
           
            
        }

       


            

        private void CadastroPedidos_Load(object sender, EventArgs e)
        {

            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;


          
           
            ConfigClasses.ConexaoBanco manipulaBanco = new ConfigClasses.ConexaoBanco();
            MySqlConnection getconexao = manipulaBanco.getConexao();
            MySqlCommand getComando = manipulaBanco.getComando(getconexao);
            getComando.CommandText = "SELECT idcliente,nomecliente from cliente";
            MySqlDataReader getreader = manipulaBanco.getReader(getComando);           

            while (getreader.Read())
            {
                cbbcliente.Items.Add(getreader.GetString(1));

            }
           

            

        }

       


       

        public string replaceString (string cpfcnpj)
        {
            string cpfcnpjr = cpfcnpj;
            cpfcnpjr = cpfcnpj.Replace(".", "");
            cpfcnpjr = cpfcnpj.Replace("_", "");
            cpfcnpjr = cpfcnpj.Replace(",", "");
            cpfcnpjr = cpfcnpj.Replace(".", "");
            cpfcnpjr = cpfcnpj.Replace("/", "");
            cpfcnpjr = cpfcnpj.Replace(",", "");
            return cpfcnpjr;

        }

        public int BuscaId()
        {
            
            ConfigClasses.ConexaoBanco manipulaBanco = new ConfigClasses.ConexaoBanco();
            MySqlConnection getconexao= manipulaBanco.getConexao();
            MySqlCommand getcomando = manipulaBanco.getComando(getconexao);
            getcomando.CommandText = "select idpessoa from cadpessoapedido where cpfcnpj=@cpfcnpj";
            getcomando.Parameters.AddWithValue("@cpfcnpj", replaceString(txtCpfCnpj.Text));
            MySqlDataReader reader = manipulaBanco.getReader(getcomando);
            int idpessoa;


            while (reader.Read())
            {
                idpessoa = reader.GetInt32(0);
                return idpessoa;


            }
           
            return -1;

        }

        public Boolean validaCadastroPedidoPessoaJuridica()
        {
            
            
            if (txtCpfCnpj.Text == "")
            {
                MessageBox.Show("O campo CPF/CNPJ, não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }
            if (txtNome.Text == "")
            {
                MessageBox.Show("O campo NOME, não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }
            if (txtRazaoSocial.Text == "")
            {
                MessageBox.Show("O campo RAZÃO SOCIAL, não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }
            
            if (txtInscEstadual.Text == "")
            {
                MessageBox.Show("O campo INSCRIÇÃO ESTADUAL, não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }
            if (txtInscMunicipal.Text == "")
            {
                MessageBox.Show("O campo INSCRIÇÃO MINUCIPAL, não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }

            if (cbbAtividade.Text == "")
            {
                MessageBox.Show("O campo ATIVIDADE, não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }
           
            return true;

        }

        public Boolean validaCadastroPedidoPessoaFisica()
        {
          

            if (txtCpfCnpj.Text == "")
            {
                MessageBox.Show("O campo CPF/CNPJ, não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }
            if (txtNome.Text == "")
            {
                MessageBox.Show("O campo NOME, não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }
            if (txtRg.Text == "")
            {
                MessageBox.Show("O campo RG, não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }
            
         
           
          
            return true;
            
        }
        public Boolean validaPedido()
        {
            
            if (cbbcliente.Text == "")
            {
                MessageBox.Show("O campo   CLIENTE, não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }
            if (cbbproduto.Text == "")
            {
                MessageBox.Show("O campo   PRODUTO, não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }
            if (cbbregiao.Text == "")
            {
                MessageBox.Show("O campo   REGIÃO, não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }

            if (cbbFormaContato.Text == "")
            {
                MessageBox.Show("O campo   FORMA DE CONTATO, não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }
            if (cbbSolicitante.Text == "")
            {
                MessageBox.Show("O campo   SOLICITANTE, não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }
            if (cbbUrgencia.Text == "")
            {
                MessageBox.Show("O campo   SOLICITANTE, não pode ser vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }
              
            return true;
          
        }

        private void metroComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (cbbUrgencia.Text.Equals("Urgente")){

                cbbUrgencia.BackColor = Color.Red;

            }
            if (cbbUrgencia.Text.Equals("Médio"))
            {
                cbbUrgencia.BackColor = System.Drawing.Color.Yellow;
            }
            if (cbbUrgencia.Text.Equals("Normal"))
            {
                cbbUrgencia.BackColor = System.Drawing.Color.Green;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show( "Você deseja sair sem salvar ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == DialogResult)
            {
                this.Dispose();

            }
            

        }

        private void cbbcliente_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ConfigClasses.ConexaoBanco manipulaBanco = new ConfigClasses.ConexaoBanco();
            MySqlConnection getconexao = manipulaBanco.getConexao();
            MySqlCommand getComando = manipulaBanco.getComando(getconexao);
            getComando.CommandText = "SELECT idcliente,nomecliente,razaosocialcliente,cpfcnpjcliente,enderecoestadocobranca,enderecocidadecobranca from cliente where nomecliente=@nomecliente";
            getComando.Parameters.AddWithValue("@nomecliente", cbbcliente.Text);

            MySqlDataReader getreader = manipulaBanco.getReader(getComando);

            while (getreader.Read())
            {
                idempresa = getreader.GetInt32(0);
                lblCodigoDI.Text = lblCodigoDI.Text + "" + idempresa.ToString();

                
                
                    clientecad.nomeCliente = getreader.GetString(1);
                    clientecad.razaoSocialcliente = getreader.GetString(2);
                    clientecad.cpfCnpjCliente = getreader.GetString(3);
                    clientecad.enderecoEstadoCobranca = getreader.GetString(4);
                    clientecad.enderecoCidadeCobranca = getreader.GetString(5);



               



            }
            getreader.Close();

            getComando.CommandText = "SELECT nomecontato from contatoresponsavel where idempresa=@idempresa";
            getComando.Parameters.AddWithValue("@idempresa", idempresa);

            getreader = manipulaBanco.getReader(getComando);

            while (getreader.Read())
            {
                cbbSolicitante.Items.Add(getreader.GetString(0));



            }
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            ArrayList endereco = BuscaCep(txtcep.Text);

            if (endereco != null)
            {




                txtcep.Text = endereco[0].ToString();
                txtEndereco.Text = endereco[1].ToString();
                txtBairro.Text = endereco[7].ToString();
                cbbEstado.Text = endereco[5].ToString();
                txtCidade.Text = endereco[4].ToString();
            }
        }

        private ArrayList BuscaCep(string buscacep)
        {
            buscacep = buscacep.Replace("-", "");
            string cepnaoencontrado = "";

            ArrayList cependereco = new ArrayList();
            ConfigClasses.ConexaoBanco buscacepconexao = new ConfigClasses.ConexaoBanco();
            MySqlConnection conexao = buscacepconexao.getConexao();
            MySqlCommand comando = buscacepconexao.getComando(conexao);
            comando.CommandText = "select cep,logradouro,idcidade,idbairro from cep_logradouro where cep=@cepbusca";
            comando.Parameters.AddWithValue("@cepbusca", buscacep = buscacep.Replace(",", ""));
            MySqlDataReader reader = buscacepconexao.getReader(comando);

            while (reader.Read())
            {

                cependereco.Add(reader.GetString(0));
                cependereco.Add(reader.GetString(1));
                cependereco.Add(reader.GetString(2));
                cependereco.Add(reader.GetString(3));
                cepnaoencontrado = cependereco[0].ToString();

            }

            if (cepnaoencontrado == "")
            {
                MessageBox.Show("Cep não encontrado, favor digitar os dados do endereço.", "Cep não encotrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;

            }



            comando.Parameters.Clear();
            reader.Close();



            comando.CommandText = "select ID_CIDADE,CIDADE,UF from cep_cidade where ID_CIDADE=@ID_CIDADE";
            comando.Parameters.AddWithValue("@ID_CIDADE", cependereco[2]);
            reader = buscacepconexao.getReader(comando);
            while (reader.Read())
            {

                cependereco.Add(reader.GetString(1));
                cependereco.Add(reader.GetString(2));


            }

            comando.Parameters.Clear();
            reader.Close();

            comando.CommandText = "select ID_BAIRRO,ID_CIDADE from cep_bairro where ID_BAIRRO=@ID_BAIRRO";
            comando.Parameters.AddWithValue("@ID_BAIRRO", cependereco[3]);
            reader = buscacepconexao.getReader(comando);
            while (reader.Read())
            {
                cependereco.Add(reader.GetString(0));
                cependereco.Add(reader.GetString(1));


            }
            return cependereco;

        }

       

        private void txtCpfCnpj_Leave(object sender, EventArgs e)
        {
            string cpfcnpj = txtCpfCnpj.Text.Replace("-", "");
            cpfcnpj = cpfcnpj.Replace(".", "");
            cpfcnpj = cpfcnpj.Replace("_", "");
            cpfcnpj = cpfcnpj.Replace(",", "");

            ClassesPrograma.PessoaJuridica pessoajuridica = new ClassesPrograma.PessoaJuridica();
            ClassesPrograma.PessoaFisica pessoafisica = new ClassesPrograma.PessoaFisica();





            if (pessoajuridica.validarcnpj(cpfcnpj))
            {


                ConfigClasses.ConexaoBanco manipulaBanco = new ConfigClasses.ConexaoBanco();
                MySqlConnection getconexao = manipulaBanco.getConexao();
                MySqlCommand getComando = manipulaBanco.getComando(getconexao);
                getComando.CommandText = "SELECT nome,razaosocial,inscestadual,inscmunicipal from cadpessoapedido where cpfcnpj=@cpfcnpj";
                getComando.Parameters.AddWithValue("@cpfcnpj", cpfcnpj);
                MySqlDataReader getreader = manipulaBanco.getReader(getComando);

                Boolean achei = false;



                while (getreader.Read())
                {
                    achei = true;

                }
                if (achei)
                {




                    txtNome.Text = getreader.GetString(0);
                    txtRazaoSocial.Text = getreader.GetString(1);
                    txtRazaoSocial.Text = getreader.GetString(2);
                    txtInscMunicipal.Text = getreader.GetString(3);
                    cbbAtividade.Text = getreader.GetString(4);
                    
                }


                txtNome.Enabled = true;
                txtRazaoSocial.Enabled = true;
                txtInscEstadual.Enabled = true;
                txtInscMunicipal.Enabled = true;
                cbbAtividade.Enabled = true;              
                txtRg.Enabled = false;
                





            }
            else if (pessoafisica.validaCpf(cpfcnpj))
            {




                ConfigClasses.ConexaoBanco manipulaBanco = new ConfigClasses.ConexaoBanco();
                MySqlConnection getconexao = manipulaBanco.getConexao();
                MySqlCommand getComando = manipulaBanco.getComando(getconexao);
                getComando.CommandText = "SELECT nome,rg,cep,endereco,bairro,cidade,estado,contatotelefonico,celular,email,observacao from cadpessoapedido where cpfcnpj=@cpfcnpj";
                getComando.Parameters.AddWithValue("@cpfcnpj", cpfcnpj);
                MySqlDataReader getreader = manipulaBanco.getReader(getComando);

                Boolean achei = false;



                while (getreader.Read())
                {
                    achei = true;

                }
                if (achei)
                {




                    txtNome.Text = getreader.GetString(0);
                    txtRg.Text = getreader.GetString(1);
                    txtcep.Text = getreader.GetString(2);
                    txtEndereco.Text = getreader.GetString(3);
                    txtBairro.Text = getreader.GetString(4);
                    txtCidade.Text = getreader.GetString(5);
                    cbbEstado.Text = getreader.GetString(6);
                    txtContatoTelefonico.Text = getreader.GetString(7);
                    txtCelular.Text = getreader.GetString(8);
                    txtEmail.Text = getreader.GetString(9);
                    txtObservacao.Text = getreader.GetString(10);
                        
                    

                }

                txtNome.Enabled = true;
                txtRazaoSocial.Enabled = false;
                txtInscEstadual.Enabled = false;
                txtInscMunicipal.Enabled = false;
                cbbAtividade.Enabled = true;                    
                txtRg.Enabled = true;
            



            }
            else
            {
                MessageBox.Show("Cpf ou cnpj inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ClassesPrograma.PessoaFisica pessoafisica = new ClassesPrograma.PessoaFisica();
            ClassesPrograma.PessoaJuridica pessoajuridica = new ClassesPrograma.PessoaJuridica();



            if (pessoafisica.validaCpf(replaceString(txtCpfCnpj.Text)))
            {

                if (validaPedido())
                {


                    if (validaCadastroPedidoPessoaFisica())
                    {

                        ConfigClasses.ConexaoBanco manipulaBanco = new ConfigClasses.ConexaoBanco();
                        MySqlConnection getconexao = manipulaBanco.getConexao();
                        MySqlCommand getcomando = manipulaBanco.getComando(getconexao);
                        getcomando.CommandText = "INSERT INTO CADPESSOAPEDIDO (CPFCNPJ,NOME,RG,cep,endereco,bairro,cidade,estado,contatotelefonico,celular,email,observacao) VALUES (@CPFCNPJ,@NOME,@RG,@cep,@endereco,@bairro,@cidade,@estado,@contatotelefonico,@celular,@email,@observacao)";
                        getcomando.Parameters.AddWithValue("@CPFCNPJ", replaceString(txtCpfCnpj.Text));
                        getcomando.Parameters.AddWithValue("@NOME", txtNome.Text);
                        getcomando.Parameters.AddWithValue("@RG", txtRg.Text);                 
                        getcomando.Parameters.AddWithValue("@cep", txtcep.Text);
                        getcomando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                        getcomando.Parameters.AddWithValue("@bairro", txtBairro.Text);
                        getcomando.Parameters.AddWithValue("@cidade", txtCidade.Text);
                        getcomando.Parameters.AddWithValue("@estado", cbbEstado.Text);
                        getcomando.Parameters.AddWithValue("@contatotelefonico", txtContatoTelefonico.Text);
                        getcomando.Parameters.AddWithValue("@telefonecelular", txtCelular.Text);
                        getcomando.Parameters.AddWithValue("@email", txtEmail.Text);
                        getcomando.Parameters.AddWithValue("@observacao", txtObservacao.Text);
                        getcomando.ExecuteNonQuery();
                        getcomando.Parameters.Clear();


                        int idinserir = BuscaId();

                        ClassesPrograma.Pedido pedido = new ClassesPrograma.Pedido
                        {

                            cliente = cbbcliente.Text,
                            produto = cbbproduto.Text,
                            regiao = cbbregiao.Text,
                            formacontato = cbbFormaContato.Text,
                            solicitante = cbbSolicitante.Text,
                            urgencia = cbbUrgencia.Text,


                        };
                        getcomando.CommandText = "INSERT INTO CADPEDIDO (IDCLIENTE,produto,regiao,formadecontato,solicitante,urgencia,idpessoa,nomecliente,razaosocial,cpfcnpj,estado,cidade,datapedido,status) values (@IDCLIENTE,@produto,@regiao,@formacontato,@solicitante,@urgencia,@idpessoa,@nomecliente,@razaosocial,@cpfcnpj,@estado,@cidade,@datapedido,@status)";
                        getcomando.Parameters.AddWithValue("@IDCLIENTE", lblCodigoDI.Text);
                        getcomando.Parameters.AddWithValue("@produto", pedido.produto);
                        getcomando.Parameters.AddWithValue("@regiao", pedido.regiao);
                        getcomando.Parameters.AddWithValue("@formacontato", pedido.formacontato);
                        getcomando.Parameters.AddWithValue("@solicitante", pedido.solicitante);
                        getcomando.Parameters.AddWithValue("@urgencia", pedido.urgencia);
                        getcomando.Parameters.AddWithValue("@idpessoa", idinserir);
                        getcomando.Parameters.AddWithValue("@nomecliente", clientecad.nomeCliente);
                        getcomando.Parameters.AddWithValue("@razaosocial", clientecad.razaoSocialcliente);
                        getcomando.Parameters.AddWithValue("@cpfcnpj", clientecad.cpfCnpjCliente);
                        getcomando.Parameters.AddWithValue("@estado", clientecad.enderecoEstadoCobranca);
                        getcomando.Parameters.AddWithValue("@cidade", clientecad.enderecoCidadeCobranca);
                        getcomando.Parameters.AddWithValue("@status", "PENDENTE");
                        getcomando.Parameters.AddWithValue("@datapedido", DateTime.Now.ToString("dd/MM/yyyy"));

                        getcomando.ExecuteNonQuery();                                                                  

                        string numeropedido = getcomando.LastInsertedId.ToString();

                        lblCodigoPedido.Text = lblCodigoPedido.Text + numeropedido;

                        string pedidofrase = "Pedido cadastrado com sucesso Numero de registro: " + numeropedido;


                        MessageBox.Show(pedidofrase, "Numero do registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblCodigoPedido.ForeColor = Color.Red;

                        getconexao.Close();
                    }
                }
            }
            else if (pessoajuridica.validarcnpj(replaceString(txtCpfCnpj.Text)))
            {
                if (validaPedido())
                {


                    if (validaCadastroPedidoPessoaJuridica())
                    {


                        ConfigClasses.ConexaoBanco manipulaBanco = new ConfigClasses.ConexaoBanco();
                        MySqlConnection getconexao = manipulaBanco.getConexao();
                        MySqlCommand getcomando = manipulaBanco.getComando(getconexao);
                        getcomando.CommandText = "INSERT INTO CADPESSOAPEDIDO (CPFCNPJ,NOME,razaosocial,inscestadual,inscmunicipal,ratividade,cep,endereco,bairro,cidade,estado,contatotelefonico,celular,email,observacao,status) VALUES (@CPFCNPJ,@NOME,@razaosocial,@inscestadual,@inscmunicipal,@ratividade,@ocupacao,@ci,@cep,@endereco,@bairro,@cidade,@estado,@contatotelefonico,@telefonecelular,@email,@observacao,@status)";
                        getcomando.Parameters.AddWithValue("@CPFCNPJ", replaceString(txtCpfCnpj.Text));
                        getcomando.Parameters.AddWithValue("@NOME", txtNome.Text);
                        getcomando.Parameters.AddWithValue("@razaosocial", txtRazaoSocial.Text);
                        getcomando.Parameters.AddWithValue("@inscestadual", txtInscEstadual.Text);
                        getcomando.Parameters.AddWithValue("@inscmunicipal", txtInscMunicipal.Text);
                        getcomando.Parameters.AddWithValue("@ratividade", cbbAtividade.Text);
                       
                        getcomando.Parameters.AddWithValue("@cep", txtcep.Text);
                        getcomando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                        getcomando.Parameters.AddWithValue("@bairro", txtBairro.Text);
                        getcomando.Parameters.AddWithValue("@cidade", txtCidade.Text);
                        getcomando.Parameters.AddWithValue("@estado", cbbEstado.Text);
                        getcomando.Parameters.AddWithValue("@contatotelefonico", txtContatoTelefonico.Text);
                        getcomando.Parameters.AddWithValue("@telefonecelular", txtCelular.Text);
                        getcomando.Parameters.AddWithValue("@email", txtEmail.Text);
                        getcomando.Parameters.AddWithValue("@observacao", txtObservacao.Text);
                      

                        getcomando.ExecuteNonQuery();
                        getcomando.Parameters.Clear();
                        int idinserir = BuscaId();

                        ClassesPrograma.Pedido pedido = new ClassesPrograma.Pedido
                        {

                            cliente = cbbcliente.Text,
                            produto = cbbproduto.Text,
                            regiao = cbbregiao.Text,
                            formacontato = cbbFormaContato.Text,
                            solicitante = cbbSolicitante.Text,
                            urgencia = cbbUrgencia.Text,


                        };
                        getcomando.CommandText = "INSERT INTO CADPEDIDO (IDCLIENTE,produto,regiao,formadecontato,solicitante,urgencia,idpessoa,nomecliente,razaosocial,cpfcnpj,estado,cidade,datapedido,status) values (@IDCLIENTE,@produto,@regiao,@formacontato,@solicitante,@urgencia,@idpessoa,@nomecliente,@razaosocial,@cpfcnpj,@estado,@cidade,@datapedido,@status)";
                        getcomando.Parameters.AddWithValue("@IDCLIENTE", lblCodigoDI.Text);
                        getcomando.Parameters.AddWithValue("@produto", pedido.produto);
                        getcomando.Parameters.AddWithValue("@regiao", pedido.regiao);
                        getcomando.Parameters.AddWithValue("@formacontato", pedido.formacontato);
                        getcomando.Parameters.AddWithValue("@solicitante", pedido.solicitante);
                        getcomando.Parameters.AddWithValue("@urgencia", pedido.urgencia);
                        getcomando.Parameters.AddWithValue("@idpessoa", idinserir);
                        getcomando.Parameters.AddWithValue("@nomecliente", clientecad.nomeCliente);
                        getcomando.Parameters.AddWithValue("@razaosocial", clientecad.razaoSocialcliente);
                        getcomando.Parameters.AddWithValue("@cpfcnpj", clientecad.cpfCnpjCliente);
                        getcomando.Parameters.AddWithValue("@estado", clientecad.enderecoEstadoCobranca);
                        getcomando.Parameters.AddWithValue("@cidade", clientecad.enderecoCidadeCobranca);
                        getcomando.Parameters.AddWithValue("@status", "PENDENTE");
                        getcomando.Parameters.AddWithValue("@datapedido", DateTime.Today);
                        getcomando.ExecuteNonQuery();
                        string numeropedido = getcomando.LastInsertedId.ToString();
                        lblCodigoPedido.Text = lblCodigoPedido.Text + numeropedido;
                        string pedidofrase = "Pedido cadastrado com sucesso Numero de registro: " + numeropedido;
                        MessageBox.Show(pedidofrase, "Numero do registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblCodigoPedido.ForeColor = Color.Red;
                        getconexao.Close();

                    }




                }
            }
            else
            {
                MessageBox.Show("Erro ao registrar pedido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void txtCpfCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            string valor1 = txtParticipacaoCapitalSociedade.Text;
            string valor2 = txtCapitalSocialSociedade.Text;
            valor1 = limparValores(valor1);
            valor2 = limparValores(valor2);
            ClassesPrograma.PTSocietaria SOCIEDADE = new ClassesPrograma.PTSocietaria
            {
                idpedido = 0,
                idpessoapedido = 0,
                cnpj = txtCnpjSociedade.Text,
                datafundacao = txtDataDaFundacaoSociedade.Text,
                participacaocapital = Convert.ToDouble(valor1), 
                capitalsocial =Convert.ToDouble(valor2),
                receitafederal =txtReceitaFederalSociedade.Text,
                receitaestadual=txtReceitaEstadualSociedade.Text,
                cep=txtCepSociedade.Text,
                estado=cbbEstadoSociedade.Text,
                contatelefonico=txtContatoTelefonicoSociedade.Text,
                celular=txtCelularSociedade.Text,
                email=txtEmailSociedade.Text,
                endereco=txtEnderecoSociedade.Text,
                bairro=txtBairroSociedade.Text,
                cidade=txtCidadeSociedade.Text,
                              

            };

            if(SOCIEDADE.InserirNaBaseSociedade(SOCIEDADE)){

                DialogResult simnao= MessageBox.Show("Cadastro de sociedade efetuado com sucesso, gostaria de cadastrar mais uma sociedade ? ", "Cadastro de sociedade", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (simnao.ToString().ToUpper().Equals("YES"))
                {
                    txtCnpjSociedade.Text = "";
                    txtDataDaFundacaoSociedade.Text = "";
                    txtParticipacaoCapitalSociedade.Text = "";
                    txtCapitalSocialSociedade.Text = "";
                    txtReceitaFederalSociedade.Text = "";
                    txtReceitaEstadualSociedade.Text = "";
                    txtCepSociedade.Text = "";
                    cbbEstadoSociedade.Text = "";
                    txtContatoTelefonicoSociedade.Text = "";
                    txtCelularSociedade.Text = "";
                    txtEmailSociedade.Text = "";
                    txtEnderecoSociedade.Text = "";
                    txtBairroSociedade.Text = "";
                    txtCidadeSociedade.Text = "";

                }else
                {
                    metroTabPage12.Focus();


                }


            }


        }

        private void txtParticipacaoCapitalSociedade_Leave(object sender, EventArgs e)
        {
            Double valor = 0;

            try
            {
                valor = Double.Parse(txtParticipacaoCapitalSociedade.Text);
                txtParticipacaoCapitalSociedade.Text = valor.ToString("C");


            }
            catch (Exception)
            {

            }

        }

        private void txtCapitalSocialSociedade_Leave(object sender, EventArgs e)
        {
            Double valor = 0;

            try
            {
                valor = Double.Parse(txtCapitalSocialSociedade.Text);
                txtCapitalSocialSociedade.Text = valor.ToString("C");


            }
            catch (Exception)
            {

            }
        }

         public string limparValores(String valor)
          {

            valor = valor.Replace(",", "");
            valor = valor.Replace("R", "");
            valor = valor.Replace("$", "");
            valor = valor.Replace(".", "");
            valor = valor.Replace("/", "");
            valor = valor.Replace("-", "");
            valor = valor.Replace("_", "");
            return valor;




        }

        private void txtDataDaFundacaoSociedade_Leave(object sender, EventArgs e)
        {
                // DateTime data =Convert.ToDateTime( txtDataDaFundacaoSociedade.Text);                
                //txtDataDaFundacaoSociedade.Text = data.ToString("dd/mm/yyyy");

        }

        private void txtCepSociedade_Leave(object sender, EventArgs e)
        {
            ArrayList endereco = BuscaCep(txtCepSociedade.Text);

            if (endereco != null)
            {




                txtCepSociedade.Text = endereco[0].ToString();
                txtEnderecoSociedade.Text = endereco[1].ToString();
                txtBairroSociedade.Text = endereco[7].ToString();
                cbbEstadoSociedade.Text = endereco[5].ToString();
                txtCidadeSociedade.Text = endereco[4].ToString();
            }
        }

        private void txtCnpjSociedade_Leave(object sender, EventArgs e)
        {
            string cnpj = txtCnpjSociedade.Text;
            cnpj = limparValores(cnpj);

            if (validarcnpj(cnpj))
            {
                metroTile1.Enabled = true;


            }else
            {
                MessageBox.Show("CNPJ invalido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                metroTile1.Enabled = false;

            }


         }
        public Boolean validarcnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
                return false;

            tempCnpj = cnpj.Substring(0, 12);

            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        private void lblCodigoDI_Click(object sender, EventArgs e)
        {

        }
    }

}

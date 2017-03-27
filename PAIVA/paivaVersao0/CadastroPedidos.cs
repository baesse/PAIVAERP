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
        string idpedido;
        string idpessoa;
        ClassesPrograma.Cliente clientecad = new ClassesPrograma.Cliente();


        public CadastroPedidos()
        {
            InitializeComponent();
        }
        public CadastroPedidos(string id)
        {
           
            InitializeComponent();
            idpedido = id;
            ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();
            MySqlConnection getconexao = conexao.getConexao();
            MySqlCommand getcomando = conexao.getComando(getconexao);
            getcomando.CommandText = "select nomecliente,produto,regiao,formadecontato,solicitante,urgencia from cadpedido where idpedido=@idpedido";
            getcomando.Parameters.AddWithValue("@idpedido", idpedido);
            MySqlDataReader reader = getcomando.ExecuteReader();

            while (reader.Read())
            {
                MessageBox.Show(reader.GetString(0));
                cbbcliente.Text = reader.GetString(0);
                cbbproduto.Text = reader.GetString(1);
                cbbregiao.Text = reader.GetString(2);
                cbbFormaContato.Text = reader.GetString(3);
                cbbSolicitante.Text = reader.GetString(4);
                cbbUrgencia.Text = reader.GetString(5);
            }
            lblCodigoPedido.Text = lblCodigoPedido.Text + " " + idpedido;
            metroTabControl1.Enabled = true;
            getconexao.Close();



           ConfigClasses.ConexaoBanco conexao2 = new ConfigClasses.ConexaoBanco();
           MySqlConnection getconexao2 = conexao2.getConexao();
           MySqlCommand getcomando2 = conexao.getComando(getconexao2);
           

            getcomando2.CommandText = "SELECT cpfCnpj,cep,endereco,bairro,cidade,estado,contatoTelefonico,celular,email,observacao,nome,rg,naturalidade,datanascimento,nacionalidade,pis,titulodeeleitor,estadocivil,regimeuniao,profissao,dependentes,rendimentomensal,escolaridade,formacaoacademica,carteiraprofissional,carteiradehabilitacao,benspatrimoniais,nomeconjuge,atividade,nomepai,nomemae,site,fax,complemento,idpessoa from cadpessoapedido where idpedido=@idpedido2";
            getcomando2.Parameters.AddWithValue("@idpedido2", idpedido);
            MySqlDataReader reader2 = getcomando2.ExecuteReader();
                  

                Boolean achei = false;



                while (reader2.Read())
                {
                    achei = true;

                }
                if (achei)
                {



                    txtCpfCnpj.Text = reader2.GetString(0);
                    txtcep.Text = reader2.GetString(1);
                    txtEndereco.Text = reader2.GetString(2);
                    txtBairro.Text = reader2.GetString(3);
                    txtCidade.Text = reader2.GetString(4);
                    cbbEstado.Text = reader2.GetString(5);
                    txtContatoTelefonico.Text = reader2.GetString(6);
                    txtCelular.Text = reader2.GetString(7);
                    txtEmail.Text = reader2.GetString(8);
                    txtObservacao.Text = reader2.GetString(9);
                    txtNome.Text = reader2.GetString(10);
                    txtRg.Text = reader2.GetString(11);
                    txtnaturalidade.Text = reader2.GetString(12);
                    txtdatanascimento.Text = reader2.GetString(13);
                    cbbnacionalidade.Text = reader2.GetString(14);
                    txtpis.Text = reader2.GetString(15);
                    txttitulueleitor.Text = reader2.GetString(16);
                    cbbestadocivil.Text = reader2.GetString(17);
                    cbbregimedeuniao.Text = reader2.GetString(18);
                    txtprofissao.Text = reader2.GetString(19);
                    cbbdependentes.Text = reader2.GetString(20);
                    txtrendimentomensal.Text = reader2.GetString(21);
                    txtescolaridade.Text = reader2.GetString(22);
                    txtformacaoacedmica.Text = reader2.GetString(23);
                    txtcarteiradeidnetidadeprofi.Text = reader2.GetString(24);
                    txtbenspatrimoniais.Text = reader2.GetString(25);
                    txtnomeconjuge.Text = reader2.GetString(26);
                    atividade.Text = reader2.GetString(27);
                    txtnomepai.Text = reader2.GetString(28);
                    txtnomemae.Text = reader2.GetString(29);
                    txtwesite.Text = reader2.GetString(30);
                    txtfax.Text = reader2.GetString(31);
                    txtcomplemento.Text = reader2.GetString(32);

                    idpessoa = reader2.GetString(33);




                }

            }


        private void CPFCNPJ_Click(object sender, EventArgs e)
        {


            if (txtCpfCnpj.Mask.Equals("000.000.000-00"))
            {
                txtCpfCnpj.Mask = ("00.00.00.00/0000-00");
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
                txtCpfCnpj.Mask = ("000.000.000-00");
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






        public string replaceString(string cpfcnpj)
        {
            string cpfcnpjr = cpfcnpj;
            cpfcnpjr = cpfcnpj.Replace(".", "");
            cpfcnpjr = cpfcnpj.Replace("_", "");
            cpfcnpjr = cpfcnpj.Replace(",", "");
            cpfcnpjr = cpfcnpj.Replace(".", "");
            cpfcnpjr = cpfcnpj.Replace("-", "");
            cpfcnpjr = cpfcnpj.Replace("/", "");
            cpfcnpjr = cpfcnpj.Replace(",", "");
            return cpfcnpjr;

        }

        public int BuscaId()
        {

            ConfigClasses.ConexaoBanco manipulaBanco = new ConfigClasses.ConexaoBanco();
            MySqlConnection getconexao = manipulaBanco.getConexao();
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
            if (cbbUrgencia.Text.Equals("Urgente"))
            {

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
            DialogResult = MessageBox.Show("Você deseja sair sem salvar ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                getComando.CommandText = "SELECT cpfCnpj,cep,endereco,bairro,cidade,estado,contatoTelefonico,celular,email,observacao,nome,rg,naturalidade,datanascimento,nacionalidade,pis,titulodeeleitor,estadocivil,regimeuniao,profissao,dependentes,rendimentomensal,escolaridade,formacaoacademica,carteiraprofissional,carteiradehabilitacao,benspatrimoniais,nomeconjuge,atividade,nomepai,nomemae,site,fax,complemento,idpessoa from cadpessoapedido where cpfcnpj=@cpfcnpj";
                getComando.Parameters.AddWithValue("@cpfcnpj", cpfcnpj);
                MySqlDataReader getreader = manipulaBanco.getReader(getComando);

                Boolean achei = false;



                while (getreader.Read())
                {
                    achei = true;

                }
                if (achei)
                {



                    txtCpfCnpj.Text = getreader.GetString(0);
                    txtcep.Text = getreader.GetString(1);
                    txtEndereco.Text = getreader.GetString(2);
                    txtBairro.Text = getreader.GetString(3);
                    txtCidade.Text = getreader.GetString(4);
                    cbbEstado.Text = getreader.GetString(5);
                    txtContatoTelefonico.Text = getreader.GetString(6);
                    txtCelular.Text = getreader.GetString(7);
                    txtEmail.Text = getreader.GetString(8);
                    txtObservacao.Text = getreader.GetString(9);
                    txtNome.Text = getreader.GetString(10);
                    txtRg.Text = getreader.GetString(11);
                    txtnaturalidade.Text = getreader.GetString(12);
                    txtdatanascimento.Text = getreader.GetString(13);
                    cbbnacionalidade.Text = getreader.GetString(14);
                    txtpis.Text = getreader.GetString(15);
                    txttitulueleitor.Text = getreader.GetString(16);
                    cbbestadocivil.Text = getreader.GetString(17);
                    cbbregimedeuniao.Text = getreader.GetString(18);
                    txtprofissao.Text = getreader.GetString(19);
                    cbbdependentes.Text = getreader.GetString(20);
                    txtrendimentomensal.Text = getreader.GetString(21);
                    txtescolaridade.Text = getreader.GetString(22);
                    txtformacaoacedmica.Text = getreader.GetString(23);
                    txtcarteiradeidnetidadeprofi.Text = getreader.GetString(24);
                    txtbenspatrimoniais.Text = getreader.GetString(25);
                    txtnomeconjuge.Text = getreader.GetString(26);
                    atividade.Text = getreader.GetString(27);
                    txtnomepai.Text = getreader.GetString(28);
                    txtnomemae.Text = getreader.GetString(29);
                    txtwesite.Text = getreader.GetString(30);
                    txtfax.Text = getreader.GetString(31);
                    txtcomplemento.Text = getreader.GetString(32);

                    idpessoa = getreader.GetString(33);




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
                getComando.CommandText = "SELECT cpfCnpj,cep,endereco,bairro,cidade,estado,contatoTelefonico,celular,email,observacao,nome,rg,naturalidade,datanascimento,nacionalidade,pis,titulodeeleitor,estadocivil,regimeuniao,profissao,dependentes,rendimentomensal,escolaridade,formacaoacademica,carteiraprofissional,carteiradehabilitacao,benspatrimoniais,nomeconjuge,atividade,nomepai,nomemae,site,fax,complemento from cadpessoapedido where cpfcnpj=@cpfcnpj";
                getComando.Parameters.AddWithValue("@cpfcnpj", cpfcnpj);
                MySqlDataReader getreader = manipulaBanco.getReader(getComando);

                Boolean achei = false;



                while (getreader.Read())
                {
                    achei = true;

                }
                if (achei)
                {



                    txtCpfCnpj.Text = getreader.GetString(0);
                    txtcep.Text = getreader.GetString(1);
                    txtEndereco.Text = getreader.GetString(2);
                    txtBairro.Text = getreader.GetString(3);
                    txtCidade.Text = getreader.GetString(4);
                    cbbEstado.Text = getreader.GetString(5);
                    txtContatoTelefonico.Text = getreader.GetString(6);
                    txtCelular.Text = getreader.GetString(7);
                    txtEmail.Text = getreader.GetString(8);
                    txtObservacao.Text = getreader.GetString(9);
                    txtNome.Text = getreader.GetString(10);
                    txtRg.Text = getreader.GetString(11);
                    txtnaturalidade.Text = getreader.GetString(12);
                    txtdatanascimento.Text = getreader.GetString(13);
                    cbbnacionalidade.Text = getreader.GetString(14);
                    txtpis.Text = getreader.GetString(15);
                    txttitulueleitor.Text = getreader.GetString(16);
                    cbbestadocivil.Text = getreader.GetString(17);
                    cbbregimedeuniao.Text = getreader.GetString(18);
                    txtprofissao.Text = getreader.GetString(19);
                    cbbdependentes.Text = getreader.GetString(20);
                    txtrendimentomensal.Text = getreader.GetString(21);
                    txtescolaridade.Text = getreader.GetString(22);
                    txtformacaoacedmica.Text = getreader.GetString(23);
                    txtcarteiradeidnetidadeprofi.Text = getreader.GetString(24);
                    txtbenspatrimoniais.Text = getreader.GetString(25);
                    txtnomeconjuge.Text = getreader.GetString(26);
                    atividade.Text = getreader.GetString(27);
                    txtnomepai.Text = getreader.GetString(28);
                    txtnomemae.Text = getreader.GetString(29);
                    txtwesite.Text = getreader.GetString(30);
                    txtfax.Text = getreader.GetString(31);
                    txtcomplemento.Text = getreader.GetString(32);





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
            /////// salvar pedido na base de dados( Pedido inicial)

            ClassesPrograma.Pedido NOVOPEDIDO = new ClassesPrograma.Pedido()
            {
                cliente = cbbcliente.Text,
                produto = cbbproduto.Text,
                regiao = cbbregiao.Text,
                formacontato = cbbFormaContato.Text,
                solicitante = cbbSolicitante.Text,
                urgencia = cbbUrgencia.Text,
                razaosocial = clientecad.razaoSocialcliente,
                cidade = clientecad.enderecoCidadeCobranca,
                estado = clientecad.enderecoEstadoCobranca,
                cpfcnpj = clientecad.cpfCnpjCliente,
                status = "emaberto",


            };


            ClassesPrograma.Pessoa NOVAPESSOA = new ClassesPrograma.Pessoa()
            {
                cpfnCnpjpessoa = txtCpfCnpj.Text,
                cep = txtcep.Text,
                endereco = txtEndereco.Text,
                bairro = txtBairro.Text,
                cidade = txtCidade.Text,
                estado = cbbEstado.Text,
                contatoTelefonico = txtContatoTelefonico.Text,
                celular = txtCelular.Text,
                email = txtEmail.Text,
                observacao = txtObservacao.Text,
                nome = txtNome.Text,
                datanascimento = txtdatanascimento.Text,
                naturalidade = txtnaturalidade.Text,
                nacionalidade = cbbnacionalidade.Text,
                pis = txtpis.Text,
                titulodeeleitor = txttitulueleitor.Text,
                estadocivil = cbbestadocivil.Text,
                regimeuniao = cbbregimedeuniao.Text,
                profissao = txtprofissao.Text,
                dependentes = cbbdependentes.Text,
                rendimentomensal = txtrendimentomensal.Text,
                escolaridade = txtescolaridade.Text,
                formacaoacademica = txtformacaoacedmica.Text,
                carteiraprofissional = txtcarteiradeidnetidadeprofi.Text,
                carteiradehabilitacao = txtcarteiradehabilitacao.Text,
                benspatrimoniais = "",
                nomeconjuge = txtnomeconjuge.Text,
                inscestadual = txtInscEstadual.Text,
                inscmunicipal = txtInscMunicipal.Text,
                nomepai = txtnomepai.Text,
                nomemae = txtnomemae.Text,
                site = txtwesite.Text,
                fax = txtfax.Text,
                complemento = txtcomplemento.Text,
            };
            idpedido = NOVOPEDIDO.InseriPedidoInicialNaBase(NOVOPEDIDO);
            // NOVAPESSOA.InserirPessoaBase(NOVAPESSOA);

            metroTabControl1.Enabled = true;

            MessageBox.Show("Pedido registrado com sucesso, esta disponivei o cadastro das informações.", "Registro de pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

           lblCodigoPedido.Text =lblCodigoPedido.Text+" "+ idpedido;

            lblCodigoDI.Text = idpedido;
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
            //string valor1 = txtParticipacaoCapitalSociedade.Text;
            //string valor2 = txtCapitalSocialSociedade.Text;
            //valor1 = limparValores(valor1);
            //valor2 = limparValores(valor2);
            //ClassesPrograma.PTSocietaria SOCIEDADE = new ClassesPrograma.PTSocietaria
            //{
            //    idpedido = 0,
            //    idpessoapedido = 0,
            //    cnpj = txtCnpjSociedade.Text,
            //    datafundacao = txtDataDaFundacaoSociedade.Text,
            //    participacaocapital = Convert.ToDouble(valor1), 
            //    capitalsocial =Convert.ToDouble(valor2),
            //    receitafederal =txtReceitaFederalSociedade.Text,
            //    receitaestadual=txtReceitaEstadualSociedade.Text,
            //    cep=txtCepSociedade.Text,
            //    estado=cbbEstadoSociedade.Text,
            //    contatelefonico=txtContatoTelefonicoSociedade.Text,
            //    celular=txtCelularSociedade.Text,
            //    email=txtEmailSociedade.Text,
            //    endereco=txtEnderecoSociedade.Text,
            //    bairro=txtBairroSociedade.Text,
            //    cidade=txtCidadeSociedade.Text,


            //};

            //if(SOCIEDADE.InserirNaBaseSociedade(SOCIEDADE)){

            //    DialogResult simnao= MessageBox.Show("Cadastro de sociedade efetuado com sucesso, gostaria de cadastrar mais uma sociedade ? ", "Cadastro de sociedade", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //    if (simnao.ToString().ToUpper().Equals("YES"))
            //    {
            //        txtCnpjSociedade.Text = "";
            //        txtDataDaFundacaoSociedade.Text = "";
            //        txtParticipacaoCapitalSociedade.Text = "";
            //        txtCapitalSocialSociedade.Text = "";
            //        txtReceitaFederalSociedade.Text = "";
            //        txtReceitaEstadualSociedade.Text = "";
            //        txtCepSociedade.Text = "";
            //        cbbEstadoSociedade.Text = "";
            //        txtContatoTelefonicoSociedade.Text = "";
            //        txtCelularSociedade.Text = "";
            //        txtEmailSociedade.Text = "";
            //        txtEnderecoSociedade.Text = "";
            //        txtBairroSociedade.Text = "";
            //        txtCidadeSociedade.Text = "";

            //    }else
            //    {
            //        metroTabPage12.Focus();


            //    }


        }




        private void txtParticipacaoCapitalSociedade_Leave(object sender, EventArgs e)
        {
            //    Double valor = 0;

            //    try
            //    {
            //        valor = Double.Parse(txtParticipacaoCapitalSociedade.Text);
            //        txtParticipacaoCapitalSociedade.Text = valor.ToString("C");


            //    }
            //    catch (Exception)
            //    {

            //    }

        }

        private void txtCapitalSocialSociedade_Leave(object sender, EventArgs e)
        {
            //Double valor = 0;

            //try
            //{
            //    valor = Double.Parse(txtCapitalSocialSociedade.Text);
            //    txtCapitalSocialSociedade.Text = valor.ToString("C");


            //}
            //catch (Exception)
            //{

            //}
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
            //ArrayList endereco = BuscaCep(txtCepSociedade.Text);

            //if (endereco != null)
            //{




            //    txtCepSociedade.Text = endereco[0].ToString();
            //    txtEnderecoSociedade.Text = endereco[1].ToString();
            //    txtBairroSociedade.Text = endereco[7].ToString();
            //    cbbEstadoSociedade.Text = endereco[5].ToString();
            //    txtCidadeSociedade.Text = endereco[4].ToString();
            //}
        }

        private void txtCnpjSociedade_Leave(object sender, EventArgs e)
        {
            //string cnpj = txtCnpjSociedade.Text;
            //cnpj = limparValores(cnpj);

            //if (validarcnpj(cnpj))
            //{
            //    metroTile1.Enabled = true;


            //}else
            //{
            //    MessageBox.Show("CNPJ invalido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    metroTile1.Enabled = false;

            //}


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

        private void metroTabPage26_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            ClassesPrograma.Desempenhoprofissional DESEMPENHONOVO = new ClassesPrograma.Desempenhoprofissional()
            {

                dataadmissao = dataadmissao.Text,
                datasaida = datasaida.Text,
                motivo = motivo.Text,
                funcaoinicial = funcaoinicial.Text,
                ultimafuncao = ultimafuncao.Text,
                pontualidade = pontualidade.Text,
                diciplina = diciplina.Text,
                capactacao = capacitacao.Text,
                desempenhofuncional = desempenhofuncional.Text,
                relacionamentogeral = relacionamentogeral.Text,
                possibilidadedereadmissao = possibiidadedereadmissao.Text,
                acionouajusticadotrabalho = acionoajustica.Text,
                empregosconsultados = empregoconsutaldos.Text,
                ocorrencias = ocorrencias.Text,
                levantamentoespecifico = levantamentoespecifico.Text,
            };

            DESEMPENHONOVO.InserirDesempenhoProfissional(idpedido, DESEMPENHONOVO);


        }

        private void metroTile14_Click(object sender, EventArgs e)
        {
            ClassesPrograma.PTSocietaria novopt = new ClassesPrograma.PTSocietaria()
            {

                cnpj = cnpj.Text,
                datafundacao = datafundacao.Text,
                participacaocapital = participacaosobrecapital.Text,
                capitalsocial = capitalsocial.Text,
                atividade = atividade.Text,
                receitaestadual = receitaestadual.Text,
                receitafederal = receitafederal.Text,
                cep = cep.Text,
                endereco = endereco.Text,
                bairro = bairro.Text,
                cidade = cidade.Text,
                estado = estado.Text,
                contatelefonico = contatotelefonico.Text,
                celular = celular.Text,
                email = email.Text,
            };

            novopt.InserirNaBaseSociedade(idpedido, novopt);





        }

        private void metroTile15_Click(object sender, EventArgs e)
        {
            ClassesPrograma.Fatorelevante fatosrelevantes = new ClassesPrograma.Fatorelevante()
            {
                tipo = cbbFatoRelevantes.Text,
                descricao = txtFatosRelvantes.Text,
            };

            fatosrelevantes.InserirFatosRelevantes(idpedido, fatosrelevantes);


        }

        private void metroTile16_Click(object sender, EventArgs e)
        {
            ClassesPrograma.OpcoesComercias opcomercias = new ClassesPrograma.OpcoesComercias()
            {
                bandeira = bandeira.Text,
                textoespecifico = textoexpecifco.Text,
                cidade = ocpcidade.Text,
                estado = opcestado.Text,
                banco = banco.Text,
                agencia = agencia.Text,


            };

            opcomercias.InserirOpcoesComerciasi(idpedido, opcomercias);


        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            ClassesPrograma.avaliacacaogeral novaavaliacao = new ClassesPrograma.avaliacacaogeral()
            {

                rendimentomensaldeclarado = txtRendimentoMnesal.Text,
                valorprevistoinvestimento = txtvalorprevistoinvestimento.Text,
                recusrosimediatosdis = txtrecusroimediato.Text,
                basepatrimonialdisp = txtbenspatrimoniaisdis.Text,
                niveldeindividamento = txtniveldeindividamento.Text,
                disponibilidade = txtdisponibilidade.Text,
                Relacionamentocomercialgeral = relacionamentogeral.Text,
                gestaofranquia = txtgestaofranquia.Text,
                CapacidadeAdministrativa = txtcapacidadeadministrativa.Text,
                Tempodededicaçãoprevista = txttempodedicacaopreviista.Text,
                areadestinada = txtareadestinada.Text,
                empresaconstituida = txtempresaconstituida.Text,
                naturezaaquisicaofranquia = txtnaturezadaaqui.Text,
                escolaridade = txtescolaridade.Text,
                desenpenhoprofisio = desempenhoprofissionalant.Text,
                ptsocietaria = ptsocietaria.Text,
                tiporesidencia = txttiporesidencia.Text,
                origemderengimento = txtorigemresidencia.Text,
                qualificacaodoconjuge = txtqualificacaoconjuge.Text,





            };


            novaavaliacao.InseriAvaliacaoGeral(idpedido, novaavaliacao);





        }

        private void metroTile18_Click(object sender, EventArgs e)
        {


            ClassesPrograma.Pessoa NOVAPESSOA = new ClassesPrograma.Pessoa()
            {
                cpfnCnpjpessoa = replaceString(txtCpfCnpj.Text),
                cep = txtcep.Text,
                endereco = txtEndereco.Text,
                bairro = txtBairro.Text,
                cidade = txtCidade.Text,
                estado = cbbEstado.Text,
                contatoTelefonico = txtContatoTelefonico.Text,
                celular = txtCelular.Text,
                email = txtEmail.Text,
                observacao = txtObservacao.Text,
                nome = txtNome.Text,
                datanascimento = txtdatanascimento.Text,
                naturalidade = txtnaturalidade.Text,
                nacionalidade = cbbnacionalidade.Text,
                pis = txtpis.Text,
                titulodeeleitor = txttitulueleitor.Text,
                estadocivil = cbbestadocivil.Text,
                regimeuniao = cbbregimedeuniao.Text,
                profissao = txtprofissao.Text,
                dependentes = cbbdependentes.Text,
                rendimentomensal = txtrendimentomensal.Text,
                escolaridade = txtescolaridade.Text,
                formacaoacademica = txtformacaoacedmica.Text,
                carteiraprofissional = txtcarteiradeidnetidadeprofi.Text,
                carteiradehabilitacao = txtcarteiradehabilitacao.Text,
                benspatrimoniais = txtbenspatrimoniais.Text,
                nomeconjuge = txtnomeconjuge.Text,
                inscestadual = txtInscEstadual.Text,
                inscmunicipal = txtInscMunicipal.Text,
                nomepai = txtnomepai.Text,
                nomemae = txtnomemae.Text,
                site = txtwesite.Text,
                fax = txtfax.Text,
                complemento = txtcomplemento.Text,
                idpedido = lblCodigoDI.Text,



            };
            string idpessoa = NOVAPESSOA.InserirPessoaBase(NOVAPESSOA);
            ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();
            MySqlConnection getconexao = conexao.getConexao();
            MySqlCommand getcomando = conexao.getComando(getconexao);
            getcomando.CommandText = "update cadpedido set idpessoa=@idpessoa where idpedido=@idpedido";
            getcomando.Parameters.AddWithValue("@idpessoa", idpessoa);
            getcomando.Parameters.AddWithValue("@idpedido", idpedido);
            getcomando.ExecuteNonQuery();
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {

            //cadastrod de endereco falta tratar 
            ClassesPrograma.Pessoa NOVAPESSOA = new ClassesPrograma.Pessoa()
            {

                cep = txtcep.Text,
                endereco = txtEndereco.Text,
                bairro = txtBairro.Text,
                cidade = txtCidade.Text,
                estado = cbbEstado.Text,
                contatoTelefonico = txtContatoTelefonico.Text,
                celular = txtCelular.Text,
                email = txtEmail.Text,
                site = txtwesite.Text,
                fax = txtfax.Text,
                complemento = txtcomplemento.Text,


            };
            ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();
            MySqlConnection getconexao = conexao.getConexao();
            MySqlCommand getcomando = conexao.getComando(getconexao);
            getcomando.CommandText = "update cadpessoapedido set cep=@cep, endereco=@endereco ,bairro=@bairro ,cidade=@cidade, estado=@estado ,contatoTelefonico=@contatoTelefonico ,celular=@celular, email=@email, site=@site, fax=@fax complemento=@complemento where idpessoa=@idpessoa";
            getcomando.Parameters.AddWithValue("@cep", NOVAPESSOA.cep);
            getcomando.Parameters.AddWithValue("@endereco", NOVAPESSOA.endereco);
            getcomando.Parameters.AddWithValue("@bairro", NOVAPESSOA.bairro);
            getcomando.Parameters.AddWithValue("@cidade", NOVAPESSOA.cidade);
            getcomando.Parameters.AddWithValue("@estado", NOVAPESSOA.estado);
            getcomando.Parameters.AddWithValue("@contatotelefonico", NOVAPESSOA.contatoTelefonico);
            getcomando.Parameters.AddWithValue("@celular", NOVAPESSOA.celular);
            getcomando.Parameters.AddWithValue("@email", NOVAPESSOA.email);
            getcomando.Parameters.AddWithValue("@site", NOVAPESSOA.site);
            getcomando.Parameters.AddWithValue("@fax", NOVAPESSOA.fax);
            getcomando.Parameters.AddWithValue("@complemento", NOVAPESSOA.complemento);
            getcomando.Parameters.AddWithValue("@idpessoa", idpessoa);

            getcomando.ExecuteNonQuery();




        }

        private void metroTile17_Click(object sender, EventArgs e)
        {
            ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();
            MySqlConnection getconexao = conexao.getConexao();
            MySqlCommand getcomando = conexao.getComando(getconexao);
            getcomando.CommandText = "select observacao from cadpessoapedido where idpessoa=@idpessoa";
            getcomando.Parameters.AddWithValue("@idpessoa", idpessoa);
            MySqlDataReader reader = conexao.getReader(getcomando);
            string ob = "";

            while (reader.Read())
            {
                ob = reader.GetString(0);

            }


            //sobrescrever sempre
            DialogResult simnao = MessageBox.Show("Nova observação informada, você deseja substituir a observação anterior ? " + " \nObservação anterior \n" + ob, "Observação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (simnao.Equals("YES"))
            {


                getcomando.CommandText = "update cadpessoapedido set observacao=@observacao where idpessoa=@idpessoa";
                getcomando.Parameters.AddWithValue("@idpessoa", idpessoa);
                getcomando.Parameters.AddWithValue("@observacao", txtObservacao.Text);
                getcomando.ExecuteNonQuery();
            }


        }



        private void txtCpfCnpj_Click(object sender, EventArgs e)
        {
            if (idpedido == "")
            {
                MessageBox.Show("Você precisa de registrar o pedido antes de incluir uma pessoa", "Registrar pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                metroTabControl1.Enabled = false;


            }

        }

        private void metroTile12_Click(object sender, EventArgs e)
        {
            ClassesPrograma.Benspatrimoniais novoben = new ClassesPrograma.Benspatrimoniais()
            {
                comarcaimovel = txtimoveucomarca.Text,
                cartorioimovel = txtcartorioimovel.Text,
                registroimovel = txtregistroimovel.Text,
                ocorrencias = txtocorrenciaimovel.Text,
                observacao = txtobservacaoimovel.Text,
                naoconstaimovel = txtnaoconstaregistroimovel.Text,


                comarcanotas = txtcomarcanotas.Text,
                cartorionotas = txtcartorionotas.Text,
                registronotas = txtregistroimovel.Text,
                ocorrenciasnotas = txtocorrencias.Text,
                livroefolha = txtlivroefolhadata.Text,
                naoconstaramregistronotas = txtnaoconstaramregistronotas.Text,


                marca = txtmarca.Text,
                modelo = txtmodelo.Text,
                anofabricacao = txtanofabricacao.Text,
                placa = txtplaca.Text,
                chassi = txtchassi.Text,
                renava = txtrenavam.Text,
                restricoes = txtrestricoes.Text,
            };



            novoben.InsertBensNovo(idpedido, novoben);

        }

        private void metroTile13_Click(object sender, EventArgs e)
        {
            ClassesPrograma.Participacaorural novoptrural = new ClassesPrograma.Participacaorural()
            {

                inscstadual = txtinscstadualrural.Text,
                naturezajuridica = txtnaturezajuridicarural.Text,
                titular = txttitularrural.Text,
                atividadeeconomica = txtatividadeeconomicarural.Text,
                endereco = txtenderecorural.Text,
                local = txtlocalrural.Text,
                ocorrencia = txtocorrenciarural.Text,
                observacao = txtobservacaorural.Text,
            };
            novoptrural.InseriParticipacaoRural(idpedido, novoptrural);


        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            ClassesPrograma.Restricoesgerais novarestricaojusticatrabalho = new ClassesPrograma.Restricoesgerais
            {

                DATA = txtjtdata.Text,
                REGIAO = txtjtregiao.Text,
                PROCESSO = txtjtprocesso.Text,
                VARA = txtjtvara.Text,
                OBSERVACAO = txtjtobservacao.Text,
            };

            novarestricaojusticatrabalho.InserirRestricoesGerais(idpedido, novarestricaojusticatrabalho);



        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            ClassesPrograma.Restricoesgerais novarestricaocnh = new ClassesPrograma.Restricoesgerais
            {

                DATA = txtcnhdata.Text,
                CITACOESOCORRENCIAS = txtcnhcitacao.Text,
                OCORRENCIA = txtcnhocorrencia.Text,
                pontos = txtcnhponto.Text,
                OBSERVACAO = txtcnhobservacao.Text,
            };

            novarestricaocnh.InserirRestricoesGerais(idpedido, novarestricaocnh);

        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            ClassesPrograma.Restricoesgerais novarestricaoacoes = new ClassesPrograma.Restricoesgerais()
            {
                DATA = txtacoesdata.Text,
                BANCO = txtacoesbanco.Text,
                AGENCIA = txtacoesagencia.Text,
                CHEQUES = txtacoescheques.Text,
                ALINEA = txtacoesalinea.Text,
                OBSERVACAO = txtObservacao.Text,
            };

            novarestricaoacoes.InserirRestricoesGerais(idpedido, novarestricaoacoes);

        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            ClassesPrograma.Restricoesgerais novarestricaoprotesto = new ClassesPrograma.Restricoesgerais()
            {
                CITACOESOCORRENCIAS = txtprotestocitacoesocorrencias.Text,
                DATA = txtprotestodata.Text,
                cartorio = txtprotestocartorio.Text,
                VALOR = txtprotestovalor.Text,
                LOCAL = txtprotestolocal.Text,
            };
            novarestricaoprotesto.InserirRestricoesGerais(idpedido, novarestricaoprotesto);
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
          
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
           

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            ClassesPrograma.Restricoesgerais novarestricaochequeassutado = new ClassesPrograma.Restricoesgerais()
            {
                DATA=txtcsdata.Text,
                BANCO=txtcsbanco.Text,
                AGENCIA=txtcsagencia.Text,
                CHEQUES=txtcsagencia.Text,
                ALINEA=txtcsalinea.Text,
                OBSERVACAO=txtcsobservacao.Text,
                              
            };
            novarestricaochequeassutado.InserirRestricoesGerais(idpedido, novarestricaochequeassutado);

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            ClassesPrograma.Restricoesgerais novarestricaochequesccf = new ClassesPrograma.Restricoesgerais()
            {
                ultimaemissao = txtccfultimaemissao.Text,
                BANCO = txtccfbanco.Text,
                AGENCIA = txtccfagencia.Text,
                

            };
            novarestricaochequesccf.InserirRestricoesGerais(idpedido, novarestricaochequesccf);

        }

        private void metroTile19_Click(object sender, EventArgs e)
        {
            ClassesPrograma.Restricoesgerais novarestricaochequesspc = new ClassesPrograma.Restricoesgerais()
            {
                DATA = txtrgispcdata.Text,
                OCORRENCIA = txtrgispcocorrencia.Text,
                VALOR = txtrgispcvalor.Text,
                EMPRESA = txtrgispcempresa.Text


            };
            novarestricaochequesspc.InserirRestricoesGerais(idpedido, novarestricaochequesspc);

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CHECKCCF_CheckedChanged(object sender, EventArgs e)
        {
            if (CHECKCCF.Checked)
            {
                GPCCF.Enabled = true;

            }else
            {
                GPCCF.Enabled = false;

            }
        }

        private void metroTile6_Click_1(object sender, EventArgs e)
        {
            ClassesPrograma.Restricoesgerais novarestricaoindimplenciapefin = new ClassesPrograma.Restricoesgerais()
            {

                PERIODO = txtpefinperiodo.Text,
                VALORTOTALDEBITO = txtpefinvalortotaldebito.Text,
                DATA = txtpefindata.Text,
                OCORRENCIA = txtpefinocorrencia.Text,
                VALOR = txtpefinvalor.Text,
                EMPRESA = txtpefinempresa.Text,
            };
            novarestricaoindimplenciapefin.InserirRestricoesGerais(idpedido, novarestricaoindimplenciapefin);

        }

        private void metroTabPage33_Click(object sender, EventArgs e)
        {

        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CHECKChequesExtraviadosSustados.Checked)
            {
                GPCHEQUEASSUTADO.Enabled = true;
            }else
            {
                GPCHEQUEASSUTADO.Enabled = false;


            }
        }

        private void CHECKRI_CheckedChanged(object sender, EventArgs e)
        {
            if (CHECKRI.Checked)
            {
                GPFIN.Enabled = true;

            }else
            {
                GPFIN.Enabled = false;
            }
        }

        private void metroTile7_Click_1(object sender, EventArgs e)
        {
            ClassesPrograma.Restricoesgerais novarestricaoindimplenciacheques = new ClassesPrograma.Restricoesgerais()
            {

                PERIODO = txtricperiodo.Text,
                VALORTOTALDEBITO = txtricvalortotaldebito.Text,
                DATA = txtricdata.Text,
                OCORRENCIA = txtricocorrencia.Text,
                VALOR = txtricvalor.Text,
                EMPRESA = txtricempresa.Text,
            };
            novarestricaoindimplenciacheques.InserirRestricoesGerais(idpedido, novarestricaoindimplenciacheques);
        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {

        }

        private void CHEPROTESTO_CheckedChanged(object sender, EventArgs e)
        {
            if (CHEPROTESTO.Checked)
            {
                GPPROTESTO.Enabled = true;
            }else
            {
                GPPROTESTO.Enabled = false;
            }
        }

        private void metroCheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox5.Checked)
            {
                GPSPC.Enabled = true;


            }else
            {
                GPSPC.Enabled = false;
            }
        }

        private void metroCheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox6.Checked)
            {
                GPACOES.Enabled = true;

            }else
            {
                GPACOES.Enabled = false;


            }
        }

        private void metroCheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox7.Checked)
            {
                GPJUSTICATRABALHO.Enabled = true;
            }else
            {
                GPJUSTICATRABALHO.Enabled = false;

            }
        }

        private void metroCheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox8.Checked)
            {
                GPCNH.Enabled = true;

            }else
            {
                GPCNH.Enabled = false;

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
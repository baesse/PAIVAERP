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
    public partial class CadClientes : MetroFramework.Forms.MetroForm

    {
        ClassesPrograma.ContatoEmpresa contato = new ClassesPrograma.ContatoEmpresa();
        ArrayList listacontatos;
        public CadClientes()
        {
            InitializeComponent();
            //btnNovoCadastro.Enabled = false;
        }

        public void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           ClassesPrograma.Cliente clientenovo = new ClassesPrograma.Cliente
            {
                codigoCliente = txtCodigo.Text,
                nomeCliente = txtNome.Text,
                razaoSocialcliente = txtRazaoSocial.Text,
                cpfCnpjCliente = txtCpfCnpj.Text,
                inscEstadualCliente = txtInscEstadual.Text,
                tipoCalculo = cbbTipoCalulo.Text,
                enderecoBairroCobranca = txtBairroCobranca.Text,
                enderecoCobrancacep = txtCepCobranca.Text,
                enderecoEnderecoCobranca = txtEnderecoCobranca.Text,
                enderecoEstadoCobranca = cbbEstadoCobranca.Text,
                enderecoCidadeCobranca = txtCidadeCobranca.Text,
                enderecoContatoCobranca = txtTelefoneFixoCobranca.Text,
                enderecoCelularCobranca = txtCelularCobranca.Text,
                enderecoCepEntrega = txtCepEntrega.Text,
                enderecoEnderecoEntrega = txtEnderecoEntrega.Text,
                enderecoBairroEntrega = txtBairroEntrega.Text,
                enderecoEstadoEntrega = cbbEstadoEntrega.Text,
                enderecoCidadeEntrega = txtCidadeEntrega.Text,
                enderecoContatoEntrega = txtTelefoneFixoEntrega.Text,
                enderecoCelularEntrega = txtCelularEntreg.Text,
              


            };

            ClassesPrograma.ContatoEmpresa contatoempresa = new ClassesPrograma.ContatoEmpresa
            {
                nomeContato = novocontatotxt.Text,
                funcaoCargo = txtFuncaoCargo.Text,
                dataAniversario = txtDatadeNascimento.Text,
                Email = txtEmail.Text,
                idempresa =txtCodigo.Text,             


            };

            string cpfcnpj = txtCpfCnpj.Text;
            cpfcnpj = limpaString(cpfcnpj);




            if (cpfcnpj.Length == 11)
            {
                if (clientenovo.validaCpf(cpfcnpj)){

                    if (verSeJatemCadastro(cpfcnpj)){

                        clientenovo.atulizacaoDecadastro(clientenovo, contatoempresa, cpfcnpj);

                    }else
                    {
                        clientenovo.inserirClienteCliente(clientenovo, cpfcnpj, contatoempresa);
                    }                
                  }

            }else if (cpfcnpj.Length > 11)
            {
                if (clientenovo.validarcnpj(cpfcnpj))
                {

                    if (verSeJatemCadastro(cpfcnpj))
                    {

                        clientenovo.atulizacaoDecadastro(clientenovo, contatoempresa, cpfcnpj);

                    }else
                    {
                        clientenovo.inserirClienteCliente(clientenovo, cpfcnpj, contatoempresa);
                    }
                }

            }


            


        }

        private Boolean validarCpf(string cpf)
        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        public static bool validarcnpj(string cnpj)
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

        private void label3_Click(object sender, EventArgs e)
        {
            
            if(txtCpfCnpj.Mask.Equals("00.000.000/0000-00")){

                txtCpfCnpj.Mask = "000.000.000-00";

            }else
            {
                txtCpfCnpj.Mask = "00.000.000/0000-00";
            }
          
    
        }

        private Boolean validaEmail(string email)
        {
            for (int i = 0; i < email.Length; i++)
            {
                if (email[i] == '@')
                {
                    return true;


                }
            }

            return false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            txtCepEntrega.Text = txtCepCobranca.Text;
            txtEnderecoEntrega.Text = txtEnderecoCobranca.Text;
            txtBairroEntrega.Text = txtBairroCobranca.Text;
            cbbEstadoEntrega.Text = cbbEstadoCobranca.Text;
            txtCidadeEntrega.Text = txtCidadeCobranca.Text;
            txtCelularEntreg.Text = txtCelularCobranca.Text;
            txtTelefoneFixoEntrega.Text = txtTelefoneFixoCobranca.Text;
            

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
            comando.Parameters.AddWithValue("@cepbusca", buscacep=buscacep.Replace(",",""));
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

         private void button1_Click(object sender, EventArgs e)
        {   


            


        }

        public Boolean verSeJatemCadastro(string cpfcnpj)
        {

            ConfigClasses.ConexaoBanco ManipularBancod = new ConfigClasses.ConexaoBanco();
            MySqlConnection conexao = ManipularBancod.getConexao();
            MySqlCommand comando = ManipularBancod.getComando(conexao);
            comando.CommandText = "Select cpfcnpjcliente from cliente where cpfcnpjcliente=@cpfcnpjcliente ";
            comando.Parameters.AddWithValue("@cpfcnpjcliente", cpfcnpj);

        
            MySqlDataReader reader = ManipularBancod.getReader(comando);

            while (reader.Read())
            {
                if (reader.GetString(0).Equals(cpfcnpj))
                {
                    
                    return true;

                }

            }
            return false;

        }

       

    


        private void cbbContato_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFuncaoCargo.Text = "";
            txtEmail.Text = "";
            txtDatadeNascimento.Text = "";
          

            if (CbbContatos.Text != "")
            {
                foreach(ClassesPrograma.ContatoEmpresa contato in listacontatos)
                {
                    if (contato.nomeContato.Equals(CbbContatos.Text))
                    {
                        txtFuncaoCargo.Text = contato.funcaoCargo;
                        txtDatadeNascimento.Text = contato.dataAniversario;
                        txtEmail.Text = contato.Email;

                    }
                }
                
            }
            
        }

        private void txtCepCobranca_Leave(object sender, EventArgs e)
        {
            
            ArrayList endereco = BuscaCep(txtCepCobranca.Text);

            if (endereco != null)
            {




                txtCepCobranca.Text = endereco[0].ToString();
                txtEnderecoCobranca.Text = endereco[1].ToString();
                txtBairroCobranca.Text = endereco[7].ToString();
                cbbEstadoCobranca.Text = endereco[5].ToString();
                txtCidadeCobranca.Text = endereco[4].ToString();
            }
            
        }

    
        public void limparTela()
        {

            txtCodigo.Text = "";
            txtNome.Text = "";
            txtRazaoSocial.Text = "";
            txtInscEstadual.Text = "";
            cbbTipoCalulo.Text = "";
            txtCepCobranca.Text = "";
            txtEnderecoCobranca.Text = "";
            txtBairroCobranca.Text = "";
            cbbEstadoCobranca.Text = "";
            txtCidadeCobranca.Text = "";
            txtTelefoneFixoCobranca.Text = "";
            txtCelularCobranca.Text = "";
            txtCepEntrega.Text = "";
            txtEnderecoEntrega.Text = "";
            txtBairroEntrega.Text = "";
            cbbEstadoEntrega.Text = "";
            txtCidadeEntrega.Text = "";           
            txtCelularEntreg.Text = "";
            txtCpfCnpj.Text = "";
            btnNovoCadastro.Text = "";
            txtFuncaoCargo.Text = "";
            txtDatadeNascimento.Text = "";
            txtEmail.Text = "";

        }

             public void limparTela(int num)
        {


            txtCodigo.Text = "";
            txtNome.Text = "";
            txtRazaoSocial.Text = "";
            txtInscEstadual.Text = "";
            cbbTipoCalulo.Text = "";
            txtCepCobranca.Text = "";
            txtEnderecoCobranca.Text = "";
            txtBairroCobranca.Text = "";
            cbbEstadoCobranca.Text = "";
            txtCidadeCobranca.Text = "";
            txtTelefoneFixoCobranca.Text = "";
            txtCelularCobranca.Text = "";
            txtCepEntrega.Text = "";
            txtEnderecoEntrega.Text = "";
            txtBairroEntrega.Text = "";
            cbbEstadoEntrega.Text = "";
            txtCidadeEntrega.Text = "";
            txtCelularEntreg.Text = "";
            // txtCpfCnpj.Text = "";
            btnNovoCadastro.Text = "";
            txtFuncaoCargo.Text = "";
            txtDatadeNascimento.Text = "";
            txtEmail.Text = "";

        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {



            

        }

        

        public string limpaString(string limpar)
        {
            string cpfcnpjreplace = limpar;           
            cpfcnpjreplace = cpfcnpjreplace.Replace(",", "");
            cpfcnpjreplace = cpfcnpjreplace.Replace(".", "");
            cpfcnpjreplace = cpfcnpjreplace.Replace("/", "");
             cpfcnpjreplace = cpfcnpjreplace.Replace("-", "");
            return cpfcnpjreplace;

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limparTela();
            CbbContatos.Visible = false;
            novocontatotxt.Text = "";
            txtFuncaoCargo.Text = "";
            txtDatadeNascimento.Text = "";
            txtEmail.Text = "";
            btnNovoCadastro.Enabled = false;
            label4.Visible = false;
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCepCobranca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CadClientes_Load(object sender, EventArgs e)
        {
            novocontatotxt.Visible = false;
            btnNovoCadastro.Enabled = false;


        }

      

        private void novocontato_Click(object sender, EventArgs e)
        {
            CbbContatos.Visible = false;
            novocontatotxt.Visible = true;
            btnNovoCadastro.Enabled = true;
            btnNovoCadastro.Visible = true;
            novocontatotxt.Text = "";
            txtFuncaoCargo.Text = "";
            txtDatadeNascimento.Text = "";
            txtEmail.Text = "";


        }

        private void txtCpfCnpj_Leave_1(object sender, EventArgs e)

        {
            
            string replace = txtCpfCnpj.Text;
            replace = limpaString(replace);

            if (replace != "")
            {
                menuStrip1.Enabled = true;



                if (validarcnpj(replace))
                {
                    limparTela(1);

                    txtCodigo.Enabled = true;
                    txtNome.Enabled = true;
                    txtRazaoSocial.Enabled = true;
                    txtInscEstadual.Enabled = true;
                    cbbTipoCalulo.Enabled = true;
                    txtCepCobranca.Enabled = true;
                    txtEnderecoCobranca.Enabled = true;
                    txtBairroCobranca.Enabled = true;
                    cbbEstadoCobranca.Enabled = true;
                    txtCidadeCobranca.Enabled = true;
                    txtTelefoneFixoCobranca.Enabled = true;
                    txtCelularCobranca.Enabled = true;
                    txtCepEntrega.Enabled = true;
                    txtEnderecoEntrega.Enabled = true;
                    txtBairroEntrega.Enabled = true;
                    cbbEstadoEntrega.Enabled = true;
                    txtCidadeEntrega.Enabled = true;
                    txtCelularEntreg.Enabled = true;
                    btnNovoCadastro.Enabled = true;
                    txtFuncaoCargo.Enabled = true;
                    txtDatadeNascimento.Enabled = true;
                    txtEmail.Enabled = true;
                    CbbContatos.Enabled = true;
                    txtFuncaoCargo.Enabled = true;
                    txtEmail.Enabled = true;
                    txtDatadeNascimento.Enabled = true;
                    txtTelefoneFixoEntrega.Enabled = true;
                    


                    CbbContatos.Items.Clear();



                    ClassesPrograma.Cliente cliente = new ClassesPrograma.Cliente();
                    cliente = cliente.buscacadastro(txtCpfCnpj.Text);


                    if (cliente == null)
                    {
                        CbbContatos.Visible = false;
                        novocontatotxt.Visible = true;
                        limparTela(1);

                    }
                    else
                    {
                        txtCodigo.Text = cliente.codigoCliente;
                        txtNome.Text = cliente.nomeCliente;
                        txtRazaoSocial.Text = cliente.razaoSocialcliente;
                        txtInscEstadual.Text = cliente.inscEstadualCliente;
                        cbbTipoCalulo.Text = cliente.tipoCalculo;
                        txtCepCobranca.Text = cliente.enderecoCobrancacep;
                        txtEnderecoCobranca.Text = cliente.enderecoEnderecoCobranca;
                        txtBairroCobranca.Text = cliente.enderecoBairroCobranca;
                        cbbEstadoCobranca.Text = cliente.enderecoEstadoCobranca;
                        txtCidadeCobranca.Text = cliente.enderecoCidadeCobranca;
                        txtTelefoneFixoCobranca.Text = cliente.enderecoContatoCobranca;
                        txtCelularCobranca.Text = cliente.enderecoCelularCobranca;
                        txtCepEntrega.Text = cliente.enderecoCepEntrega;
                        txtEnderecoEntrega.Text = cliente.enderecoEnderecoEntrega;
                        txtBairroEntrega.Text = cliente.enderecoBairroEntrega;
                        cbbEstadoEntrega.Text = cliente.enderecoEstadoEntrega;
                        txtCidadeEntrega.Text = cliente.enderecoCidadeEntrega;
                        txtEnderecoEntrega.Text = cliente.enderecoContatoEntrega;
                        txtCelularEntreg.Text = cliente.enderecoCelularEntrega;


                        listacontatos = contato.buscaContato(cliente.codigoCliente);

                        foreach (ClassesPrograma.ContatoEmpresa contatoBusca in listacontatos)
                        {
                            CbbContatos.Items.Add(contatoBusca.nomeContato);


                        }
                        novocontatotxt.Visible = false;
                        CbbContatos.Visible = true;






                    }
                }
                else if (validarCpf(replace))
                {
                    limparTela(1);


                    txtCodigo.Enabled = true;
                    txtNome.Enabled = true;
                    txtRazaoSocial.Enabled = true;
                    txtInscEstadual.Enabled = true;
                    cbbTipoCalulo.Enabled = true;
                    txtCepCobranca.Enabled = true;
                    txtEnderecoCobranca.Enabled = true;
                    txtBairroCobranca.Enabled = true;
                    cbbEstadoCobranca.Enabled = true;
                    txtCidadeCobranca.Enabled = true;
                    txtTelefoneFixoCobranca.Enabled = true;
                    txtCelularCobranca.Enabled = true;
                    txtCepEntrega.Enabled = true;
                    txtEnderecoEntrega.Enabled = true;
                    txtBairroEntrega.Enabled = true;
                    cbbEstadoEntrega.Enabled = true;
                    txtCidadeEntrega.Enabled = true;
                    txtCelularEntreg.Enabled = true;
                    btnNovoCadastro.Enabled = true;
                    txtFuncaoCargo.Enabled = true;
                    txtDatadeNascimento.Enabled = true;
                    txtEmail.Enabled = true;
                    CbbContatos.Enabled = true;
                    txtFuncaoCargo.Enabled = true;
                    txtEmail.Enabled = true;
                    txtDatadeNascimento.Enabled = true;
                    txtTelefoneFixoEntrega.Enabled = true;





                    CbbContatos.Items.Clear();



                    ClassesPrograma.Cliente cliente = new ClassesPrograma.Cliente();
                    cliente = cliente.buscacadastro(txtCpfCnpj.Text);


                    if (cliente == null)
                    {
                        CbbContatos.Visible = false;
                        novocontatotxt.Visible = true;
                        limparTela(1);

                    }
                    else
                    {
                        txtCodigo.Text = cliente.codigoCliente;
                        txtNome.Text = cliente.nomeCliente;
                        txtRazaoSocial.Text = cliente.razaoSocialcliente;
                        txtInscEstadual.Text = cliente.inscEstadualCliente;
                        cbbTipoCalulo.Text = cliente.tipoCalculo;
                        txtCepCobranca.Text = cliente.enderecoCobrancacep;
                        txtEnderecoCobranca.Text = cliente.enderecoEnderecoCobranca;
                        txtBairroCobranca.Text = cliente.enderecoBairroCobranca;
                        cbbEstadoCobranca.Text = cliente.enderecoEstadoCobranca;
                        txtCidadeCobranca.Text = cliente.enderecoCidadeCobranca;
                        txtTelefoneFixoCobranca.Text = cliente.enderecoContatoCobranca;
                        txtCelularCobranca.Text = cliente.enderecoCelularCobranca;
                        txtCepEntrega.Text = cliente.enderecoCepEntrega;
                        txtEnderecoEntrega.Text = cliente.enderecoEnderecoEntrega;
                        txtBairroEntrega.Text = cliente.enderecoBairroEntrega;
                        cbbEstadoEntrega.Text = cliente.enderecoEstadoEntrega;
                        txtCidadeEntrega.Text = cliente.enderecoCidadeEntrega;
                        txtEnderecoEntrega.Text = cliente.enderecoContatoEntrega;
                        txtCelularEntreg.Text = cliente.enderecoCelularEntrega;


                        listacontatos = contato.buscaContato(cliente.codigoCliente);

                        foreach (ClassesPrograma.ContatoEmpresa contatoBusca in listacontatos)
                        {
                            CbbContatos.Items.Add(contatoBusca.nomeContato);


                        }
                        novocontatotxt.Visible = false;
                        CbbContatos.Visible = true;






                    }








                }else
                {
                    MessageBox.Show("Cpf ou cpnj inválido", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    menuStrip1.Enabled = false;
                    return;

                }
            }
            
        }

        private void CPFCNPJ_Click(object sender, EventArgs e)
        {

            if (txtCpfCnpj.Mask.Equals("000.000.000-00"))
            {
                txtCpfCnpj.Mask = ("00.00.00.00/0000-00");
                txtCpfCnpj.Width = 145;
                            }
            else
            {
                txtCpfCnpj.Mask = ("000.000.000-00");
                txtCpfCnpj.Width = 108;
               
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            txtEnderecoEntrega.Text = txtEnderecoCobranca.Text;
            txtBairroEntrega.Text = txtBairroCobranca.Text;
            txtCidadeEntrega.Text = txtCidadeCobranca.Text;
            cbbEstadoEntrega.Text = cbbEstadoCobranca.Text;
            txtCepEntrega.Text = txtCepCobranca.Text;
            txtTelefoneFixoEntrega.Text = txtTelefoneFixoCobranca.Text;
            txtCelularEntreg.Text = txtCelularCobranca.Text;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            ClassesPrograma.ContatoEmpresa contatoempresa = new ClassesPrograma.ContatoEmpresa
            {
                nomeContato = novocontatotxt.Text,
                funcaoCargo = txtFuncaoCargo.Text,
                dataAniversario = txtDatadeNascimento.Text,
                Email = txtEmail.Text,


            };

            if (txtCpfCnpj.Text != "")
            {


                ConfigClasses.ConexaoBanco manipulaBanco = new ConfigClasses.ConexaoBanco();
                MySqlConnection conexao = manipulaBanco.getConexao();
                MySqlCommand comando = manipulaBanco.getComando(conexao);




                comando.CommandText = "INSERT INTO contatoresponsavel (idempresa,nomecontato,funcaocargo,dataaniversario,email) values( @idempresa,@nomecontato,@funcaocargo,@dataaniversario,@email)";
                comando.Parameters.AddWithValue("@idempresa", txtCodigo.Text);
                comando.Parameters.AddWithValue("@nomecontato", contatoempresa.nomeContato);
                comando.Parameters.AddWithValue("@funcaocargo", contatoempresa.funcaoCargo);
                comando.Parameters.AddWithValue("@dataaniversario", contatoempresa.dataAniversario);
                comando.Parameters.AddWithValue("@email", contatoempresa.Email);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro de novo contato efetuado !", "Novo contato", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            btnNovoCadastro.Enabled = false;
            novocontatotxt.Visible = false;
            CbbContatos.Visible = true;

            listacontatos.Clear();
            CbbContatos.Items.Clear();
            listacontatos = contatoempresa.buscaContato(txtCodigo.Text);

            foreach (ClassesPrograma.ContatoEmpresa contato in listacontatos)
            {
                CbbContatos.Items.Add(contato.nomeContato);

            }
        }
    }
}




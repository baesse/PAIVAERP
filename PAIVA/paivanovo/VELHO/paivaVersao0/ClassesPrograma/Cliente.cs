using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paivaVersao0.ClassesPrograma
{
    class Cliente
    {
        public string codigoCliente { get; set; }
        public string nomeCliente { get; set; }
        public string razaoSocialcliente { get; set; }
        public string cpfCnpjCliente { get; set; }
        public string inscEstadualCliente { get; set; }
        public string tipoCalculo { get; set; }




        public string enderecoCobrancacep { get; set; }
        public string enderecoEnderecoCobranca { get; set; }
        public string enderecoBairroCobranca { get; set; }
        public string enderecoEstadoCobranca { get; set; }
        public string enderecoCidadeCobranca { get; set; }
        public string enderecoContatoCobranca { get; set; }
        public string enderecoCelularCobranca { get; set; }



        public string enderecoCepEntrega { get; set; }
        public string enderecoEnderecoEntrega { get; set; }
        public string enderecoBairroEntrega { get; set; }
        public string enderecoEstadoEntrega { get; set; }
        public string enderecoCidadeEntrega { get; set; }
        public string enderecoContatoEntrega { get; set; }
        public string enderecoCelularEntrega { get; set; }
        public string enderecoEspecificacaoEntrega { get; set; }

        public Cliente buscacadastro(string cpfcnpj)
        {
            string cpfcnpjreplace = cpfcnpj.Replace("-", "");
            cpfcnpjreplace = cpfcnpjreplace.Replace(",", "");
            cpfcnpjreplace = cpfcnpjreplace.Replace(".", "");
            cpfcnpjreplace = cpfcnpjreplace.Replace("/", "");

            ConfigClasses.ConexaoBanco ManipularBancod = new ConfigClasses.ConexaoBanco();
            MySqlConnection conexao = ManipularBancod.getConexao();
            MySqlCommand comando = ManipularBancod.getComando(conexao);
            comando.CommandText = "Select idcliente,nomecliente, razaosocialcliente, cpfcnpjcliente, inscEstadualCliente,tipoCalculo, enderecoCobrancacep, enderecoEnderecoCobranca, enderecoBairroCobranca, enderecoEstadoCobranca, enderecoCidadeCobranca, enderecoContatoCobranca, enderecoCelularCobranca, enderecoCepEntrega, enderecoEnderecoEntrega, enderecoBairroEntrega, enderecoEstadoEntrega, enderecoCidadeEntrega, enderecoContatoEntrega,  enderecoCelularEntrega  from cliente where cpfcnpjcliente=@cpfcnpjcliente ";
            comando.Parameters.AddWithValue("@cpfcnpjcliente", cpfcnpjreplace);


            MySqlDataReader reader = ManipularBancod.getReader(comando);

            while (reader.Read())
            {
                if (reader.GetString(3).Equals(cpfcnpjreplace))
                {
                    ClassesPrograma.Cliente retornoBuscaCliente = new ClassesPrograma.Cliente
                    {

                        codigoCliente = reader.GetString(0),
                        nomeCliente = reader.GetString(1),
                        razaoSocialcliente = reader.GetString(2),
                        cpfCnpjCliente = reader.GetString(3),
                        inscEstadualCliente = reader.GetString(4),
                        tipoCalculo = reader.GetString(5),
                        enderecoBairroCobranca = reader.GetString(8),
                        enderecoCobrancacep = reader.GetString(6),
                        enderecoEnderecoCobranca = reader.GetString(7),
                        enderecoEstadoCobranca = reader.GetString(9),
                        enderecoCidadeCobranca = reader.GetString(10),
                        enderecoContatoCobranca = reader.GetString(11),
                        enderecoCelularCobranca = reader.GetString(12),
                        enderecoCepEntrega = reader.GetString(13),
                        enderecoEnderecoEntrega = reader.GetString(14),
                        enderecoBairroEntrega = reader.GetString(15),
                        enderecoEstadoEntrega = reader.GetString(16),
                        enderecoCidadeEntrega = reader.GetString(17),
                        enderecoContatoEntrega = reader.GetString(18),
                        enderecoCelularEntrega = reader.GetString(19),
                    



                    };
                    return retornoBuscaCliente;





                }

            }
            return null;
        }
        public void atulizacaoDecadastro(Cliente clientenovo,ContatoEmpresa contatoempresa,string cpfcnpj)
        {
            ConfigClasses.ConexaoBanco manipulaBanco = new ConfigClasses.ConexaoBanco();
            MySqlConnection conexao = manipulaBanco.getConexao();
            MySqlCommand comando = manipulaBanco.getComando(conexao);
            comando.CommandText = "UPDATE cliente SET nomecliente=@nomecliente,razaosocialcliente=@razaosocialcliente,cpfcnpjcliente=@cpfcnpjcliente,inscEstadualCliente=@inscEstadualCliente,tipoCalculo=@tipoCalculo,enderecoCobrancacep=@enderecoCobrancacep,enderecoEnderecoCobranca=@enderecoEnderecoCobranca,enderecoBairroCobranca=@enderecoBairroCobranca,enderecoEstadoCobranca=@enderecoEstadoCobranca,enderecoCidadeCobranca=@enderecoCidadeCobranca,enderecoContatoCobranca=@enderecoContatoCobranca,enderecoCelularCobranca=@enderecoCelularCobranca,enderecoCepEntrega=@enderecoCepEntrega,enderecoEnderecoEntrega =@enderecoEnderecoEntrega,enderecoBairroEntrega =@enderecoBairroEntrega,enderecoEstadoEntrega = @enderecoEstadoEntrega,enderecoCidadeEntrega =@enderecoCidadeEntrega,enderecoContatoEntrega =@enderecoContatoEntrega,enderecoCelularEntrega =@enderecoCelularEntrega,utlimaatualizacao =@utlimaatualizacao WHERE CPFCNPJCLIENTE=@cpfcnpjcliente ";
            
            comando.Parameters.AddWithValue("@nomecliente", clientenovo.nomeCliente);
            comando.Parameters.AddWithValue("@razaosocialcliente", clientenovo.razaoSocialcliente);
            comando.Parameters.AddWithValue("@cpfcnpjcliente", cpfcnpj);
            comando.Parameters.AddWithValue("@inscEstadualCliente", clientenovo.inscEstadualCliente);
            comando.Parameters.AddWithValue("@tipoCalculo", clientenovo.tipoCalculo);
            comando.Parameters.AddWithValue("@enderecoCobrancacep", clientenovo.enderecoCobrancacep);
            comando.Parameters.AddWithValue("@enderecoEnderecoCobranca", clientenovo.enderecoEnderecoCobranca);
            comando.Parameters.AddWithValue("@enderecoBairroCobranca", clientenovo.enderecoBairroCobranca);
            comando.Parameters.AddWithValue("@enderecoEstadoCobranca", clientenovo.enderecoEstadoCobranca);
            comando.Parameters.AddWithValue("@enderecoCidadeCobranca", clientenovo.enderecoCidadeCobranca);
            comando.Parameters.AddWithValue("@enderecoContatoCobranca", clientenovo.enderecoContatoCobranca);
            comando.Parameters.AddWithValue("@enderecoCelularCobranca", clientenovo.enderecoCelularCobranca);
            comando.Parameters.AddWithValue("@enderecoCepEntrega", clientenovo.enderecoCepEntrega);
            comando.Parameters.AddWithValue("@enderecoEnderecoEntrega", clientenovo.enderecoEnderecoEntrega);
            comando.Parameters.AddWithValue("@enderecoBairroEntrega", clientenovo.enderecoBairroEntrega);
            comando.Parameters.AddWithValue("@enderecoEstadoEntrega", clientenovo.enderecoBairroEntrega);           
            comando.Parameters.AddWithValue("@enderecoContatoEntrega", clientenovo.enderecoContatoEntrega);
            comando.Parameters.AddWithValue("@enderecoCidadeEntrega", clientenovo.enderecoCidadeEntrega);         
            comando.Parameters.AddWithValue("@enderecoCelularEntrega", clientenovo.enderecoCelularEntrega);
            comando.Parameters.AddWithValue("@utlimaatualizacao", DateTime.Now.ToString("dd/MM/yyyy"));

            comando.ExecuteNonQuery();


            comando.Parameters.Clear();


            comando.CommandText = "UPDATE CONTATORESPONSAVEL SET idempresa=@idempresa,nomecontato=@nomecontato,funcaocargo=@funcaocargo,dataaniversario=@dataaniversario,email=@email WHERE idempresa=@idempresa and nomecontato=@nomecontato";
            comando.Parameters.AddWithValue("@idempresa", contatoempresa.idempresa);
            comando.Parameters.AddWithValue("@nomecontato", contatoempresa.nomeContato);
            comando.Parameters.AddWithValue("@funcaocargo", contatoempresa.funcaoCargo);
            comando.Parameters.AddWithValue("@dataaniversario", contatoempresa.dataAniversario);
            comando.Parameters.AddWithValue("@email", contatoempresa.Email);
            comando.ExecuteNonQuery();


        }



        public Boolean validaCpf(string cpf)
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

        public void inserirClienteCliente(Cliente clientenovo, string cpfreplace, ContatoEmpresa contatoempresa)
        {
            



                ConfigClasses.ConexaoBanco manipulaBanco = new ConfigClasses.ConexaoBanco();
                MySqlConnection conexao = manipulaBanco.getConexao();
                MySqlCommand comando = manipulaBanco.getComando(conexao);
                    comando.CommandText = "INSERT INTO CLIENTE(nomecliente,razaosocialcliente,cpfcnpjcliente,inscEstadualCliente,tipoCalculo,enderecoCobrancacep,enderecoEnderecoCobranca,enderecoBairroCobranca,enderecoEstadoCobranca,enderecoCidadeCobranca,enderecoContatoCobranca,enderecoCelularCobranca,enderecoCepEntrega,enderecoEnderecoEntrega,enderecoBairroEntrega,enderecoEstadoEntrega,enderecoCidadeEntrega,enderecoContatoEntrega,enderecoCelularEntrega,datacadastro)VALUES(@nomecliente,@razaosocialcliente,@cpfcnpjcliente,@inscEstadualCliente,@tipoCalculo,@enderecoCobrancacep,@enderecoEnderecoCobranca,@enderecoBairroCobranca,@enderecoEstadoCobranca,@enderecoCidadeCobranca,@enderecoContatoCobranca,@enderecoCelularCobranca,@enderecoCepEntrega,@enderecoEnderecoEntrega,@enderecoBairroEntrega,@enderecoEstadoEntrega,@enderecoCidadeEntrega,@enderecoContatoEntrega,@enderecoCelularEntrega,@datacadastro)";







                comando.Parameters.AddWithValue("@nomecliente", clientenovo.nomeCliente);
                comando.Parameters.AddWithValue("@razaosocialcliente", clientenovo.razaoSocialcliente);
                comando.Parameters.AddWithValue("@cpfcnpjcliente", cpfreplace);
                comando.Parameters.AddWithValue("@inscEstadualCliente", clientenovo.inscEstadualCliente);
                comando.Parameters.AddWithValue("@tipoCalculo", clientenovo.tipoCalculo);
                comando.Parameters.AddWithValue("@enderecoCobrancacep", clientenovo.enderecoCobrancacep);
                comando.Parameters.AddWithValue("@enderecoEnderecoCobranca", clientenovo.enderecoEnderecoCobranca);
                comando.Parameters.AddWithValue("@enderecoBairroCobranca", clientenovo.enderecoBairroCobranca);
                comando.Parameters.AddWithValue("@enderecoEstadoCobranca", clientenovo.enderecoEstadoCobranca);
                comando.Parameters.AddWithValue("@enderecoCidadeCobranca", clientenovo.enderecoCidadeCobranca);
                comando.Parameters.AddWithValue("@enderecoContatoCobranca", clientenovo.enderecoContatoCobranca);
                comando.Parameters.AddWithValue("@enderecoCelularCobranca", clientenovo.enderecoCelularCobranca);
                comando.Parameters.AddWithValue("@enderecoCepEntrega", clientenovo.enderecoCepEntrega);
                comando.Parameters.AddWithValue("@enderecoEnderecoEntrega", clientenovo.enderecoEnderecoEntrega);
                comando.Parameters.AddWithValue("@enderecoBairroEntrega", clientenovo.enderecoBairroEntrega);
                comando.Parameters.AddWithValue("@enderecoEstadoEntrega", clientenovo.enderecoBairroEntrega);
                comando.Parameters.AddWithValue("@enderecoCidadeEntrega", clientenovo.enderecoCidadeEntrega);
                comando.Parameters.AddWithValue("@enderecoContatoEntrega", clientenovo.enderecoContatoEntrega);
                comando.Parameters.AddWithValue("@enderecoCelularEntrega", clientenovo.enderecoCelularEntrega);                
                comando.Parameters.AddWithValue("@datacadastro", DateTime.Today);
                comando.ExecuteNonQuery();
                string codigo =comando.LastInsertedId.ToString();


                comando.Parameters.Clear();


                comando.CommandText = "INSERT INTO contatoresponsavel(idempresa,nomecontato,FuncaoCargo,dataaniversario,Email)VALUES(@idempresa, @nomecontato, @FuncaoCargo, @dataaniversario, @Email)";
                comando.Parameters.AddWithValue("@idempresa", codigo);
                comando.Parameters.AddWithValue("@nomecontato", contatoempresa.nomeContato);
                comando.Parameters.AddWithValue("@FuncaoCargo", contatoempresa.funcaoCargo);
                comando.Parameters.AddWithValue("@dataaniversario", contatoempresa.dataAniversario);
                comando.Parameters.AddWithValue("@Email", contatoempresa.Email);
                comando.ExecuteNonQuery();

             
          
        }
    }

  
           
    }




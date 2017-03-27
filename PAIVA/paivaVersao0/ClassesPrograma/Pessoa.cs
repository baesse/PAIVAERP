using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paivaVersao0.ClassesPrograma
{
    class Pessoa
    {
        public string cpfnCnpjpessoa { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string contatoTelefonico { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string observacao { get; set; }
        public string nome { get; set; }
        public string ocupacao { get; set; }
        public string ci { get; set; }
        public string id { get; set; }
        public string datanascimento { get; set; }
        public string naturalidade { get; set; }
        public string nacionalidade { get; set; }
        public string pis { get; set; }
        public string titulodeeleitor { get; set; }
        public string estadocivil { get; set; }
        public string regimeuniao { get; set; }
        public string profissao { get; set; }
        public string dependentes { get; set; }
        public string rendimentomensal { get; set; }
        public string escolaridade { get; set; }
        public string formacaoacademica { get; set; }
        public string carteiraprofissional { get; set; }
        public string carteiradehabilitacao { get; set; }
        public string benspatrimoniais { get; set; }
        public string nomeconjuge { get; set; }
        public string inscestadual { get; set; }
        public string inscmunicipal { get; set; }
        public string atividade { get; set; }
        public string nomepai { get; set; }
        public string nomemae { get; set; }
        public string site { get; set; }
        public string fax { get; set; }
        public string complemento { get; set; }
        public string idpedido { get; set; }




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
        public string InserirPessoaBase(Pessoa novapessoa)
        {
            ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();
            MySqlConnection getconexao = conexao.getConexao();
            MySqlCommand getcomando = conexao.getComando(getconexao);
            getcomando.CommandText = "INSERT INTO cadpessoapedido(cpfCnpj,cep,endereco,bairro,cidade,estado,contatoTelefonico,celular,email,observacao,nome,ocupacao,rg,naturalidade,datanascimento,nacionalidade,pis,titulodeeleitor,estadocivil,regimeuniao,profissao,dependentes,rendimentomensal,escolaridade,formacaoacademica,carteiraprofissional,carteiradehabilitacao,benspatrimoniais,nomeconjuge,atividade,nomepai,nomemae,site,fax,complemento,idpedido)VALUES(@cpfCnpj,@cep,@endereco,@bairro,@cidade,@estado,@contatoTelefonico,@celular,@email,@observacao,@nome,@ocupacao,@rg,@naturalidade,@datanascimento,@nacionalidade,@pis,@titulodeeleitor,@estadocivil,@regimeuniao,@profissao,@dependentes,@rendimentomensal,@escolaridade,@formacaoacademica,@carteiraprofissional,@carteiradehabilitacao,@benspatrimoniais,@nomeconjuge,@atividade,@nomepai,@nomemae,@site,@fax,@complemento,@idpedido)";
            getcomando.Parameters.AddWithValue("@cpfCnpj", novapessoa.cpfnCnpjpessoa);
            getcomando.Parameters.AddWithValue("@cep", novapessoa.cep);
            getcomando.Parameters.AddWithValue("@endereco", novapessoa.endereco);
            getcomando.Parameters.AddWithValue("@bairro", novapessoa.bairro);
            getcomando.Parameters.AddWithValue("@cidade", novapessoa.cidade);
            getcomando.Parameters.AddWithValue("@estado", novapessoa.estado);
            getcomando.Parameters.AddWithValue("@contatoTelefonico", novapessoa.contatoTelefonico);
            getcomando.Parameters.AddWithValue("@celular", novapessoa.celular);
            getcomando.Parameters.AddWithValue("@email", novapessoa.email);
            getcomando.Parameters.AddWithValue("@observacao", novapessoa.observacao);
            getcomando.Parameters.AddWithValue("@nome", novapessoa.nome);
            getcomando.Parameters.AddWithValue("@ocupacao", novapessoa.ocupacao);
            getcomando.Parameters.AddWithValue("@rg", novapessoa.ci);
            getcomando.Parameters.AddWithValue("@naturalidade", novapessoa.naturalidade);
            getcomando.Parameters.AddWithValue("@datanascimento", novapessoa.datanascimento);
            getcomando.Parameters.AddWithValue("@nacionalidade", novapessoa.nacionalidade);
            getcomando.Parameters.AddWithValue("@pis", novapessoa.pis);
            getcomando.Parameters.AddWithValue("@titulodeeleitor", novapessoa.titulodeeleitor);
            getcomando.Parameters.AddWithValue("@estadocivil", novapessoa.estadocivil);
            getcomando.Parameters.AddWithValue("@regimeuniao", novapessoa.regimeuniao);
            getcomando.Parameters.AddWithValue("@profissao", novapessoa.profissao);
            getcomando.Parameters.AddWithValue("@dependentes", novapessoa.dependentes);
            getcomando.Parameters.AddWithValue("@rendimentomensal", novapessoa.rendimentomensal);         
            getcomando.Parameters.AddWithValue("@escolaridade", novapessoa.escolaridade);
            getcomando.Parameters.AddWithValue("@formacaoacademica", novapessoa.formacaoacademica);
            getcomando.Parameters.AddWithValue("@carteiraprofissional", novapessoa.carteiraprofissional);
            getcomando.Parameters.AddWithValue("@carteiradehabilitacao", novapessoa.carteiradehabilitacao);
            getcomando.Parameters.AddWithValue("@benspatrimoniais", novapessoa.benspatrimoniais);
            getcomando.Parameters.AddWithValue("@nomeconjuge", novapessoa.nomeconjuge);
            getcomando.Parameters.AddWithValue("@atividade", novapessoa.atividade);
            getcomando.Parameters.AddWithValue("@nomepai", novapessoa.nomepai);
            getcomando.Parameters.AddWithValue("@nomemae", novapessoa.nomemae);
            getcomando.Parameters.AddWithValue("@site", novapessoa.site);
            getcomando.Parameters.AddWithValue("@fax", novapessoa.fax);
            getcomando.Parameters.AddWithValue("@complemento", novapessoa.complemento);
            getcomando.Parameters.AddWithValue("@idpedido", novapessoa.idpedido);
            getcomando.ExecuteNonQuery();
            return Convert.ToString(getcomando.LastInsertedId);



        }
    }
}

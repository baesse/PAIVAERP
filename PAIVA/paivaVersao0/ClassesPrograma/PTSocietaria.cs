using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paivaVersao0.ClassesPrograma
{
    class PTSocietaria
    {
        public int idpedido { get; set; }
        public int idpessoapedido { get; set; }
        public string cnpj { get; set; }
        public string datafundacao { get; set; }
        public string participacaocapital { get; set; }
        public string capitalsocial { get; set; }
        public string nomemepresa { get; set; }
        public string atividade { get; set; }
        public string receitafederal { get; set; }
        public string receitaestadual { get; set; }
        public string cep { get; set; }
        public string estado { get; set; }
        public string contatelefonico { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
       
       
       
       


        public Boolean InserirNaBaseSociedade(string idpedido,PTSocietaria sociedade)
        {


                ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();
                MySqlConnection getconexao = conexao.getConexao();
                MySqlCommand getcomando = conexao.getComando(getconexao);
                getcomando.CommandText = "INSERT INTO ptsocietaria(idpedido,idpessoapedido,cnpj,datafundacao,participacaocapital,capitalsocial,nomempresa,atividade,receitafederal,receitaestadual,cep,estado,contatotelefonico,celular,email,endereco,bairro,cidade)VALUES(@idpedido,@idpessoapedido,@cnpj,@datafundacao,@participacaocapital,@capitalsocial,@nomempresa,@atividade,@receitafederal,@receitaestadual,@cep,@estado,@contatotelefonico,@celular,@email,@endereco,@bairro,@cidade)";
                getcomando.Parameters.AddWithValue("@idpedido", idpedido);
                getcomando.Parameters.AddWithValue("@idpessoapedido", sociedade.idpessoapedido);
                getcomando.Parameters.AddWithValue("@cnpj", sociedade.cnpj);
                getcomando.Parameters.AddWithValue("@datafundacao", sociedade.datafundacao);
                getcomando.Parameters.AddWithValue("@participacaocapital", sociedade.participacaocapital);
                getcomando.Parameters.AddWithValue("@capitalsocial", sociedade.capitalsocial);
                getcomando.Parameters.AddWithValue("@nomempresa", sociedade.nomemepresa);
                getcomando.Parameters.AddWithValue("@atividade", sociedade.atividade);   
                getcomando.Parameters.AddWithValue("@receitafederal", sociedade.receitafederal);
                getcomando.Parameters.AddWithValue("@receitaestadual", sociedade.receitaestadual);
                getcomando.Parameters.AddWithValue("@cep", sociedade.cep);
                getcomando.Parameters.AddWithValue("@estado", sociedade.estado);
                getcomando.Parameters.AddWithValue("@contatotelefonico", sociedade.contatelefonico);
                getcomando.Parameters.AddWithValue("@celular", sociedade.celular);
                getcomando.Parameters.AddWithValue("@email", sociedade.email);
                getcomando.Parameters.AddWithValue("@endereco", sociedade.endereco);
                getcomando.Parameters.AddWithValue("@bairro", sociedade.bairro);
                getcomando.Parameters.AddWithValue("@cidade", sociedade.cidade);
                getcomando.ExecuteNonQuery();
                return true;

          
           


        }


        public static Boolean validarcnpj(string cnpj)
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
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paivaVersao0
{
    class clientefinanceiro
    {
        public string tipopessoa { get; set; }
        public string cnpjcpf { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string pessoacontato { get; set; }
        public string site { get; set; }
        public string razaosocial { get; set; }
        public string inscmunicpal { get; set; }
        public string endereco { get; set; }      
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
        public string pais { get; set; }
        public string banco { get; set; }
        public string agencia { get; set; }
        public string conta { get; set; }

        public Boolean inserirCliente(clientefinanceiro clientenovo)
        {
            ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();

            MySqlConnection getconexao = conexao.getConexao();

            MySqlCommand getcomando = conexao.getComando(getconexao);
            getcomando.CommandText = "Insert into clientefinanceiro (tipopessoa,cnpjcpf,nome,email,telefone,celular,pessoacontato,site,razaosocial,inscmunicpal,endereco,bairro,cidade,estado,cep,pais,banco,agencia,conta) values(@tipopessoa,@cnpjcpf,@nome,@email,@telefone,@celular,@pessoacontato,@site,@razaosocial,@inscmunicipal,@endereco,@bairro,@cidade,@estado,@cep,@pais,@banco,@agencia,@conta)";
            getcomando.Parameters.AddWithValue("tipopessoa", clientenovo.tipopessoa);
            getcomando.Parameters.AddWithValue("cnpjcpf", clientenovo.cnpjcpf);
            getcomando.Parameters.AddWithValue("nome", clientenovo.nome);
            getcomando.Parameters.AddWithValue("email", clientenovo.email);
            getcomando.Parameters.AddWithValue("telefone", clientenovo.telefone);
            getcomando.Parameters.AddWithValue("celular", clientenovo.celular);
            getcomando.Parameters.AddWithValue("pessoacontato", clientenovo.pessoacontato);
            getcomando.Parameters.AddWithValue("site", clientenovo.site);
            getcomando.Parameters.AddWithValue("razaosocial", clientenovo.razaosocial);
            getcomando.Parameters.AddWithValue("inscmunicipal", clientenovo.inscmunicpal);
            getcomando.Parameters.AddWithValue("endereco", clientenovo.endereco);         
          
            getcomando.Parameters.AddWithValue("bairro", clientenovo.bairro);
            getcomando.Parameters.AddWithValue("cidade", clientenovo.cidade);
            getcomando.Parameters.AddWithValue("estado", clientenovo.estado);
            getcomando.Parameters.AddWithValue("cep", clientenovo.cep);
            getcomando.Parameters.AddWithValue("pais", clientenovo.pais);
            getcomando.Parameters.AddWithValue("banco", clientenovo.banco);
            getcomando.Parameters.AddWithValue("agencia", clientenovo.agencia);
            getcomando.Parameters.AddWithValue("conta", clientenovo.conta);
            getcomando.ExecuteNonQuery();
            return true;





        }

    }
}

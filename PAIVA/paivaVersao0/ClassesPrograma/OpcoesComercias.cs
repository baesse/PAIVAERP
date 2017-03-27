using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paivaVersao0.ClassesPrograma
{
    class OpcoesComercias
    {
        public string bandeira { get; set; }
        public string textoespecifico { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string banco { get; set; }
        public string agencia { get; set; }

        public Boolean InserirOpcoesComerciasi(string idpedido,OpcoesComercias novaopcao)
        {
           


                ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();
                MySqlConnection getconexao = conexao.getConexao();
                MySqlCommand getcomando = conexao.getComando(getconexao);
                getcomando.CommandText = "INSERT INTO opcoescomerciais(idpedido,bandeira,textoespecifico,cidade,estado,banco,agencia)VALUES(@idpedido,@bandeira,@textoespecifico,@cidade,@estado,@banco,@agencia)";
                getcomando.Parameters.AddWithValue("@bandeira", bandeira);
                getcomando.Parameters.AddWithValue("@textoespecifico", textoespecifico);
                getcomando.Parameters.AddWithValue("@cidade", cidade);
                getcomando.Parameters.AddWithValue("@estado", estado);
                getcomando.Parameters.AddWithValue("@banco", banco);
                getcomando.Parameters.AddWithValue("@agencia", agencia);
                getcomando.Parameters.AddWithValue("@idpedido", idpedido);
                getcomando.ExecuteNonQuery();
                return true;

        }
        
    }
}

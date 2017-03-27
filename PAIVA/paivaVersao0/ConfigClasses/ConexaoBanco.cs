using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paivaVersao0.ConfigClasses
{
    class ConexaoBanco
    {

        public MySqlConnection getConexao()
        {
            MySqlConnection conexao = new MySqlConnection(@"Server = localhost; Database = bd_paiva; Uid = root; Pwd = 75395146;");

            try
            {
                conexao.Open();
                return conexao;


            }catch(MySqlException e)
            {

               throw e;

            }

        }

        public MySqlCommand getComando(MySqlConnection conexao)
        {
            MySqlCommand comando = conexao.CreateCommand();

            return comando;
            
        }

        public MySqlDataReader getReader(MySqlCommand comando)
        {
            MySqlDataReader reader = comando.ExecuteReader();
            return reader;

        }
    }
}

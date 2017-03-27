using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paivaVersao0.ClassesPrograma
{
    class Fatorelevante
    {
        public string tipo { get; set; }
        public string descricao { get; set; }

        public Boolean InserirFatosRelevantes(string idpedido,Fatorelevante fatosrelevantes)
        {
            try
            {



                ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();
                MySqlConnection getconexao = conexao.getConexao();
                MySqlCommand getcomando = conexao.getComando(getconexao);
                getcomando.CommandText = "INSERT INTO fatosrelevantes(idpedido,tipo,texto)VALUES(@idpedido,@tipo,@texto)";
                getcomando.Parameters.AddWithValue("@tipo", tipo);
                getcomando.Parameters.AddWithValue("@texto", descricao);
                getcomando.Parameters.AddWithValue("@idpedido", idpedido);
                getcomando.ExecuteNonQuery();
                return true;


            }
            catch
            {
                return false;

            }



        }
    }
}

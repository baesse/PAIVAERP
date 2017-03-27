using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paivaVersao0.ClassesPrograma
{
    public static class Funcoes
    {
        public static ArrayList BuscaCep(string buscacep)
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

    }
}

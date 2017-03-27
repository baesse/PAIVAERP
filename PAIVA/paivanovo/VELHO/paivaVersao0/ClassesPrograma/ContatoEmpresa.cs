using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paivaVersao0.ClassesPrograma
{
    class ContatoEmpresa
    {

        public string nomeContato { get; set; }
        public string funcaoCargo { get; set; }
        public string dataAniversario { get; set; }
        public string Email { get; set; }
        public string idempresa { get; set; }
      


        public ArrayList buscaContato(string idempresaa)
        {
            ArrayList listadecontatos = new ArrayList();
            ConfigClasses.ConexaoBanco getBanco = new ConfigClasses.ConexaoBanco();
            MySqlConnection getConexao = getBanco.getConexao();
            MySqlCommand getComando = getBanco.getComando(getConexao);
            getComando.CommandText = "select idcontato,nomecontato,funcaocargo,dataaniversario,email from contatoresponsavel  where idempresa=@idempresa";
            getComando.Parameters.AddWithValue("@idempresa", idempresaa);

            MySqlDataReader getreader = getComando.ExecuteReader();

            while (getreader.Read())
            {
                ContatoEmpresa contato = new ContatoEmpresa
                {
                    nomeContato = getreader.GetString(1),
                    funcaoCargo=getreader.GetString(2),
                    dataAniversario=getreader.GetString(3),
                    Email=getreader.GetString(4)


                };

               
                listadecontatos.Add(contato);
              


            }

            return listadecontatos;

        


           


        }

    }
}

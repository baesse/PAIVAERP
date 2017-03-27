using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paivaVersao0.ClassesPrograma
{
    class Benspatrimoniais
    {
        public string comarcaimovel { get; set; }
        public string cartorioimovel { get; set; }
        public string registroimovel { get; set; }
        public string ocorrencias { get; set; }
        public string observacao { get; set; }
        public string naoconstaimovel { get; set; }


        public string comarcanotas { get; set; }
        public string cartorionotas { get; set; }
        public string registronotas { get; set; }
        public string ocorrenciasnotas { get; set; }
        public string livroefolha { get; set; }
        public string naoconstaramregistronotas { get; set; }


        public string marca { get; set; }
        public string modelo { get; set; }
        public string anofabricacao { get; set; }
        public string placa { get; set; }
        public string chassi { get; set; }
        public string renava { get; set; }
        public string restricoes { get; set; }


        public Boolean InsertBensNovo(string idpedido, Benspatrimoniais NOVOEBEN)
        {
            


                ConfigClasses.ConexaoBanco Conexao = new ConfigClasses.ConexaoBanco();
                MySqlConnection getconexao = Conexao.getConexao();
                MySqlCommand getcomando = Conexao.getComando(getconexao);
                getcomando.CommandText = "INSERT INTO benspatrimoniais(idpedido,comarcapesquisada,cartorioimovel,registroimovel,ocorrencia,observacao,naoconstaregistro,comarcanotas,cartorionotas,registrooficio,ocorrencias,livroefolha,naconstaregistronotas,marca,modelo,anofabricacao,placa,chassi,renavam,restricoes)VALUES( @idpedido , @comarcapesquisada , @cartorioimovel , @registroimovel , @ocorrencia , @observacao , @naoconstaregistro , @comarcanotas , @cartorionotas , @registrooficio , @ocorrencias , @livroefolha ,@naconstaregistronotas , @marca , @modelo , @anofabricacao , @placa , @chassi , @renavam , @restricoes )  ";
                getcomando.Parameters.AddWithValue("@idpedido", idpedido);
                getcomando.Parameters.AddWithValue("@comarcapesquisada", NOVOEBEN.comarcaimovel);
                getcomando.Parameters.AddWithValue("@cartorioimovel", NOVOEBEN.cartorioimovel);
                getcomando.Parameters.AddWithValue("@registroimovel", NOVOEBEN.registroimovel);
                getcomando.Parameters.AddWithValue("@ocorrencia", NOVOEBEN.ocorrencias);
                getcomando.Parameters.AddWithValue("@observacao", NOVOEBEN.observacao);
                getcomando.Parameters.AddWithValue("@naoconstaregistro", NOVOEBEN.naoconstaimovel);



                getcomando.Parameters.AddWithValue("@comarcanotas", NOVOEBEN.comarcanotas);
                getcomando.Parameters.AddWithValue("@cartorionotas", NOVOEBEN.cartorionotas);
                getcomando.Parameters.AddWithValue("@registrooficio", NOVOEBEN.registronotas);
                getcomando.Parameters.AddWithValue("@ocorrencias", NOVOEBEN.ocorrenciasnotas);
                getcomando.Parameters.AddWithValue("@livroefolha", NOVOEBEN.livroefolha);
                getcomando.Parameters.AddWithValue("@naconstaregistronotas", NOVOEBEN.naoconstaramregistronotas);


                getcomando.Parameters.AddWithValue("@marca", NOVOEBEN.marca);
                getcomando.Parameters.AddWithValue("@modelo", NOVOEBEN.modelo);
                getcomando.Parameters.AddWithValue("@anofabricacao", NOVOEBEN.anofabricacao);
                getcomando.Parameters.AddWithValue("@placa", NOVOEBEN.placa);
                getcomando.Parameters.AddWithValue("@chassi", NOVOEBEN.chassi);
                getcomando.Parameters.AddWithValue("@renavam", NOVOEBEN.renava);
                getcomando.Parameters.AddWithValue("@restricoes", NOVOEBEN.restricoes);

                getcomando.ExecuteNonQuery();
                return true;



        }
    }
}
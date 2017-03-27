using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paivaVersao0.ClassesPrograma
{
    class Participacaorural
    {
        public string inscstadual { get; set; }
        public string naturezajuridica { get; set; }
        public string titular { get; set; }
        public string atividadeeconomica { get; set; }
        public string endereco { get; set; }
        public string local { get; set; }
        public string ocorrencia { get; set; }
        public string observacao { get; set; }


        public Boolean InseriParticipacaoRural(string idpedido, Participacaorural ptrural)
        {
            

                ConfigClasses.ConexaoBanco Conexao = new ConfigClasses.ConexaoBanco();
                MySqlConnection getconexao = Conexao.getConexao();
                MySqlCommand getcomando = Conexao.getComando(getconexao);
                getcomando.CommandText = "INSERT INTO participacaoprodutorrural(idpedido,inscstadual,naturezajuridica,titular,atividadeeconomica,endereco,local,ocorrencia,observacao)VALUES(@idpedido,@inscstadual,@naturezajuridica,@titular,@atividadeeconomica,@endereco,@local,@ocorrencia,@observacao)";
                getcomando.Parameters.AddWithValue("@inscstadual", ptrural.inscstadual);
                getcomando.Parameters.AddWithValue("@naturezajuridica", ptrural.naturezajuridica);
                getcomando.Parameters.AddWithValue("@titular", ptrural.titular);
                getcomando.Parameters.AddWithValue("@atividadeeconomica", ptrural.atividadeeconomica);
                getcomando.Parameters.AddWithValue("@endereco", ptrural.endereco);
                getcomando.Parameters.AddWithValue("@local", ptrural.local);
                getcomando.Parameters.AddWithValue("@ocorrencia", ptrural.ocorrencia);
                getcomando.Parameters.AddWithValue("@observacao", ptrural.observacao);
                getcomando.Parameters.AddWithValue("@idpedido", idpedido);
                getcomando.ExecuteNonQuery();
                return true;

            }
           



        }
    }


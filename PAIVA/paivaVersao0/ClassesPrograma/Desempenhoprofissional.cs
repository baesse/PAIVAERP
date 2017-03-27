using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paivaVersao0.ClassesPrograma
{
    class Desempenhoprofissional
    {
        public string dataadmissao { get; set; }
        public string datasaida { get; set; }
        public string motivo { get; set; }
        public string funcaoinicial { get; set; }
        public string ultimafuncao { get; set; }
        public string pontualidade { get; set; }
        public string diciplina { get; set; }
        public string capactacao { get; set; }
        public string desempenhofuncional { get; set; }
        public string relacionamentogeral { get; set; }
        public string possibilidadedereadmissao { get; set; }
        public string acionouajusticadotrabalho { get; set; }
        public string empregosconsultados { get; set; }
        public string ocorrencias { get; set; }
        public string levantamentoespecifico { get; set; }

        public Boolean InserirDesempenhoProfissional(string idpedido,Desempenhoprofissional NOVODESEMPENHO)
        {
            
                
                ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();
                MySqlConnection getconexao = conexao.getConexao();
                MySqlCommand getcomando = conexao.getComando(getconexao);
                getcomando.CommandText = "INSERT INTO desempenhoprofissional(dataadmissao, datasaida, motivo, funcaoinicial, ultimafuncao, pontualidade, diciplina, capacitacao, desempenhofuncional, relacionamentogeral, possibilidade, acionouajusticao, empregosconsutaldos, ocorrencias, levantamentoespecifico,idpedido)VALUES(@dataadmissao, @datasaida, @motivo, @funcaoinicial, @ultimafuncao, @pontualidade, @diciplina, @capacitacao, @desempenhofuncional, @relacionamentogeral, @possibilidade, @acionouajusticao, @empregosconsutaldos, @ocorrencias, @levantamentoespecifico,@idpedido)";




                getcomando.Parameters.AddWithValue("@dataadmissao", NOVODESEMPENHO.dataadmissao);
                getcomando.Parameters.AddWithValue("@datasaida", NOVODESEMPENHO.datasaida);
                getcomando.Parameters.AddWithValue("@motivo", NOVODESEMPENHO.motivo);
                getcomando.Parameters.AddWithValue("@funcaoinicial", NOVODESEMPENHO.funcaoinicial);
                getcomando.Parameters.AddWithValue("@ultimafuncao", NOVODESEMPENHO.ultimafuncao);
                getcomando.Parameters.AddWithValue("@pontualidade", NOVODESEMPENHO.pontualidade);
                getcomando.Parameters.AddWithValue("@diciplina", NOVODESEMPENHO.diciplina);
                getcomando.Parameters.AddWithValue("@capacitacao", NOVODESEMPENHO.capactacao);
                getcomando.Parameters.AddWithValue("@desempenhofuncional", NOVODESEMPENHO.desempenhofuncional);
                getcomando.Parameters.AddWithValue("@relacionamentogeral", NOVODESEMPENHO.relacionamentogeral);
                getcomando.Parameters.AddWithValue("@possibilidade", NOVODESEMPENHO.possibilidadedereadmissao);
                getcomando.Parameters.AddWithValue("@acionouajusticao", NOVODESEMPENHO.acionouajusticadotrabalho);
                getcomando.Parameters.AddWithValue("@empregosconsutaldos", NOVODESEMPENHO.empregosconsultados);
                getcomando.Parameters.AddWithValue("@ocorrencias", NOVODESEMPENHO.ocorrencias);
                getcomando.Parameters.AddWithValue("@levantamentoespecifico", NOVODESEMPENHO.levantamentoespecifico);
                getcomando.Parameters.AddWithValue("@idpedido", idpedido);
                getcomando.ExecuteNonQuery();
                return true;
                    
        


        }


    }
}

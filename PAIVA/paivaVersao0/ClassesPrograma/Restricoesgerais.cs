using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paivaVersao0.ClassesPrograma
{
    class Restricoesgerais
    {
        public string DATA { get; set; }
        public string BANCO { get; set; }
        public string AGENCIA { get; set; }
        public string CHEQUES { get; set; }
        public string ALINEA { get; set; }
        public string OBSERVACAO    { get; set; }
        public string PERIODO { get; set; }
        public string VALORTOTALDEBITO { get; set; }
        public string OCORRENCIA { get; set; }
        public string VALOR { get; set; }
        public string EMPRESA { get; set; }
        public string CITACOESOCORRENCIAS { get; set; }
        public string LOCAL { get; set; }
        public string REGIAO { get; set; }
        public string PROCESSO { get; set; }
        public string VARA { get; set; }
        public string ultimaemissao{ get; set; }
        public string pontos { get; set; }
        public string cartorio { get; set; }

        public Boolean InserirRestricoesGerais(string idpedido,Restricoesgerais novarestricao)
        {
            ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();
            MySqlConnection getconexao = conexao.getConexao();
            MySqlCommand getcomando = conexao.getComando(getconexao);
            getcomando.CommandText= "INSERT INTO restricoesgerais(DATA,BANCO,AGENCIA,CHEQUES,ALINEA,OBSERVACAO,PERIODO,VALORTOTALDEBITO,OCORRENCIA,VALOR,EMPRESA,CITACOESDASOCORRENCIAS,LOCAL,REGIAO,PROCESSO,VARA,IDPEDIDO,ultimaemissao,pontos,cartorio)VALUES(@DATA,@BANCO,@AGENCIA,@CHEQUES,@ALINEA,@OBSERVACAO,@PERIODO,@VALORTOTALDEBITO,@OCORRENCIA,@VALOR,@EMPRESA,@CITACOESDASOCORRENCIAS,@LOCAL,@REGIAO,@PROCESSO,@VARA,@IDPEDIDO,@ultimaemissao,@pontos,@cartorio)";
            getcomando.Parameters.AddWithValue("DATA", novarestricao.DATA);
            getcomando.Parameters.AddWithValue("@BANCO", novarestricao.BANCO);
            getcomando.Parameters.AddWithValue("@AGENCIA", novarestricao.AGENCIA);
            getcomando.Parameters.AddWithValue("@CHEQUES", novarestricao.CHEQUES);
            getcomando.Parameters.AddWithValue("@ALINEA", novarestricao.ALINEA);
            getcomando.Parameters.AddWithValue("@OBSERVACAO", novarestricao.OBSERVACAO);
            getcomando.Parameters.AddWithValue("@PERIODO", novarestricao.PERIODO);
            getcomando.Parameters.AddWithValue("@VALORTOTALDEBITO", novarestricao.VALORTOTALDEBITO);
            getcomando.Parameters.AddWithValue("@OCORRENCIA", novarestricao.OCORRENCIA);
            getcomando.Parameters.AddWithValue("@VALOR", novarestricao.VALOR);
            getcomando.Parameters.AddWithValue("@EMPRESA", novarestricao.EMPRESA);
            getcomando.Parameters.AddWithValue("@CITACOESDASOCORRENCIAS", novarestricao.CITACOESOCORRENCIAS);
            getcomando.Parameters.AddWithValue("@LOCAL", novarestricao.LOCAL);
            getcomando.Parameters.AddWithValue("@REGIAO", novarestricao.REGIAO);
            getcomando.Parameters.AddWithValue("@PROCESSO", novarestricao.PROCESSO);
            getcomando.Parameters.AddWithValue("@VARA", novarestricao.VARA);
            getcomando.Parameters.AddWithValue("@IDPEDIDO", idpedido);
            getcomando.Parameters.AddWithValue("@pontos", novarestricao.pontos);
            getcomando.Parameters.AddWithValue("@ultimaemissao", novarestricao.ultimaemissao);       
            getcomando.Parameters.AddWithValue("@cartorio", novarestricao.cartorio);
            getcomando.ExecuteNonQuery();
            return true;

        }


    }
}

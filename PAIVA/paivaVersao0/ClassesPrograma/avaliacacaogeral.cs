using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paivaVersao0.ClassesPrograma
{
    class avaliacacaogeral
    {

       


        public string rendimentomensaldeclarado { get; set; }
        public string valorprevistoinvestimento { get; set; }
        public string recusrosimediatosdis { get; set; }
        public string basepatrimonialdisp { get; set; }
        public string niveldeindividamento { get; set; }
        public string disponibilidade { get; set; }
        public string Relacionamentocomercialgeral { get; set; }
        public string gestaofranquia { get; set; }
        public string CapacidadeAdministrativa { get; set; }
        public string Tempodededicaçãoprevista { get; set; }
        public string areadestinada { get; set; }        
        public string empresaconstituida { get; set; }
        public string naturezaaquisicaofranquia { get; set; }
        public string escolaridade { get; set; }
        public string desenpenhoprofisio { get; set; }
        public string ptsocietaria { get; set; }
        public string tiporesidencia { get; set; }
        public string origemderengimento { get; set; }
        public string qualificacaodoconjuge { get; set; }




        public Boolean InseriAvaliacaoGeral(string idpedido,avaliacacaogeral novaavaliacao)
        {
            ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();
            MySqlConnection getconexao = conexao.getConexao();
            MySqlCommand getcomando = conexao.getComando(getconexao);
            getcomando.CommandText = "INSERT INTO avaliacaogeral(idpedido,Rendimentomensaldeclarado,Valorprevistoparainvestimento,Recursosimediatosdisponiveis,Basepatrimonialdisponivel,Niveldeindividamento,relacionamentocomercialgeral,Disponibilidade,gestaodefranquia,capacidadeadministrativa,tempodededicacaoprevista,areadestinada,empresaconstituida,naturezadaaquisicao,escolaridade,desempenhoprofissionalanterior,ptsocietaria,tiporesidencia,origemrendimento,qualificacaoconjuge)VALUES(@idpedido,@Rendimentomensaldeclarado,@Valorprevistoparainvestimento,@Recursosimediatosdisponiveis,@Basepatrimonialdisponivel,@Niveldeindividamento,@relacionamentocomercialgeral,@Disponibilidade,@gestaodefranquia,@capacidadeadministrativa,@tempodededicacaoprevista,@areadestinada,@empresaconstituida,@naturezadaaquisicao,@escolaridade,@desempenhoprofissionalanterior,@ptsocietaria,@tiporesidencia,@origemrendimento,@qualificacaoconjuge)";


            getcomando.Parameters.AddWithValue("idpedido", idpedido);
            getcomando.Parameters.AddWithValue("Rendimentomensaldeclarado", novaavaliacao.rendimentomensaldeclarado);
            getcomando.Parameters.AddWithValue("Valorprevistoparainvestimento", novaavaliacao.valorprevistoinvestimento);
            getcomando.Parameters.AddWithValue("Recursosimediatosdisponiveis", novaavaliacao.recusrosimediatosdis);
            getcomando.Parameters.AddWithValue("Basepatrimonialdisponivel", novaavaliacao.basepatrimonialdisp);
            getcomando.Parameters.AddWithValue("Niveldeindividamento", novaavaliacao.niveldeindividamento);
            getcomando.Parameters.AddWithValue("relacionamentocomercialgeral", novaavaliacao.Relacionamentocomercialgeral);
            getcomando.Parameters.AddWithValue("Disponibilidade", novaavaliacao.disponibilidade);           
            getcomando.Parameters.AddWithValue("gestaodefranquia", novaavaliacao.gestaofranquia);
            getcomando.Parameters.AddWithValue("capacidadeadministrativa", novaavaliacao.CapacidadeAdministrativa);
            getcomando.Parameters.AddWithValue("tempodededicacaoprevista", novaavaliacao.Tempodededicaçãoprevista);
            getcomando.Parameters.AddWithValue("areadestinada", novaavaliacao.areadestinada);
            getcomando.Parameters.AddWithValue("empresaconstituida", novaavaliacao.empresaconstituida);
            getcomando.Parameters.AddWithValue("naturezadaaquisicao", novaavaliacao.naturezaaquisicaofranquia);
            getcomando.Parameters.AddWithValue("escolaridade", novaavaliacao.escolaridade);
            getcomando.Parameters.AddWithValue("desempenhoprofissionalanterior", novaavaliacao.desenpenhoprofisio);
            getcomando.Parameters.AddWithValue("ptsocietaria", novaavaliacao.ptsocietaria);
            getcomando.Parameters.AddWithValue("tiporesidencia", novaavaliacao.tiporesidencia);
            getcomando.Parameters.AddWithValue("origemrendimento", novaavaliacao.origemderengimento);
            getcomando.Parameters.AddWithValue("qualificacaoconjuge", novaavaliacao.qualificacaodoconjuge);
          
            getcomando.ExecuteNonQuery();
            return true;

        }
    }
}

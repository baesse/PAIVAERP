using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paivaVersao0.ClassesPrograma
{
    class Pedido
    {
        public string cliente { get; set; }
        public string produto { get; set; }
        public string regiao { get; set; }
        public string formacontato { get; set; }
        public string solicitante { get; set; }
        public string urgencia { get; set; }
        public int idpessoa { get; set; }
        public string status { get; set; }
        public string razaosocial { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string cpfcnpj { get; set; }
        //objetos referentes ao relatorio
        Pessoa pessoa;
        Desempenhoprofissional desepenhoprofissional;
        PTSocietaria ptsocietaria;
        ProdutorRural produtorrural;
        Benspatrimoniais benspatrimoniais;
        OpcoesComercias opcoescomercias;
        avaliacacaogeral avaliacaogeral;
        Restricoesgerais restricoesgerais;
        Fatorelevante fatorelevante;
        ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();




        public string InseriPedidoInicialNaBase(Pedido pedido)
        {
            MySqlConnection getconexao = conexao.getConexao();
            MySqlCommand getcomando = conexao.getComando(getconexao);
            getcomando.CommandText = "INSERT INTO cadpedido(produto,regiao,formadecontato,solicitante,urgencia,status,datapedido,nomecliente,razaosocial,cpfcnpj,estado,cidade)VALUES(@produto,@regiao,@formadecontato,@solicitante,@urgencia,@status,@datapedido,@nomecliente,@razaosocial,@cpfcnpj,@estado,@cidade)";

            getcomando.Parameters.AddWithValue("@PRODUTO", pedido.produto);
            getcomando.Parameters.AddWithValue("@REGIAO", pedido.regiao);
            getcomando.Parameters.AddWithValue("@FORMADECONTATO", pedido.formacontato);
            getcomando.Parameters.AddWithValue("@SOLICITANTE", pedido.solicitante);
            getcomando.Parameters.AddWithValue("@URGENCIA", pedido.urgencia);          
            getcomando.Parameters.AddWithValue("@STATUS", pedido.status);         
            getcomando.Parameters.AddWithValue("@NOMECLIENTE", pedido.cliente);
            getcomando.Parameters.AddWithValue("@RAZAOSOCIAL", pedido.razaosocial);
            getcomando.Parameters.AddWithValue("@ESTADO", pedido.estado);
            getcomando.Parameters.AddWithValue("@CPFCNPJ", pedido.cpfcnpj);
            getcomando.Parameters.AddWithValue("@DATAPEDIDO", DateTime.Now.ToShortDateString());
            getcomando.Parameters.AddWithValue("@CIDADE", pedido.cidade);
            getcomando.ExecuteNonQuery();
            return getcomando.LastInsertedId.ToString();
        }

    
        }






    }

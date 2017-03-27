using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paivaVersao0.ClassesPrograma
{
    public class Pagamento
    {
        public string nomeFornecedor { get; set; }
        public decimal valor { get; set; }
        public string dataVencimento { get; set; }
        public string categoria { get; set; }
        public string descricaoLancamento { get; set; }
        public string referencia { get; set; }
        public string agendamentoPara { get; set; }
        public string anotacao { get; set; }
        public string arquivos   { get; set; }
        public bool recorrencia { get; set; }
        public bool parcelas { get; set; }
        public ArrayList parcela= new  ArrayList();
        public Recorrencia recorrencias= new Recorrencia();


       

        public string ValidarPagamento(Pagamento pagamento)
        {
            if (pagamento.nomeFornecedor.Equals(""))
            {
                return "Nome do fornecedor não pode ser vazio";

            }
            if(pagamento.valor<0|| pagamento.valor == 0)
            {
                return "O valor do pagamento não corresponde a um valor valido";

            }
            if (pagamento.dataVencimento.Equals("")){
                return "Data do vencimento invalida";

            }

            return "Pagamento valido";
                       

        }

        public string ValidarParcelamento(Pagamento pagamento)
        {
            if (pagamento.parcela==null)
            {
                return "FALSO";

               
                

            }
            return "Parcela valida";

        }

        public string ValidarRecorrencia(Pagamento pagamento)
        {
            if (pagamento.recorrencia)
            {
                
                if (pagamento.recorrencias.tipoRepeticao.Equals(""))
                {
                    return "Repetição invalida";

                }
                if (pagamento.recorrencias.Termino.Equals("")){
                    return "Termino da recorrencia invalido";

                }
            }
            return "Recorrencia valida";

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paivaVersao0.ClassesPrograma
{
    class frmFornecedor
    {
        public string nomeFuncionario { get; set; }
        public string banco { get; set; }
        public string agencia { get; set; }
        public string conta { get; set; }
        public string dataCadastro { get; set; }
        public string anotacao { get; set; }
        public string cargo { get; set; }
        public string cpf { get; set; }
        public string telefone  { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string pessoadecontato { get; set; }
        public string razaosocial { get; set; }
        public string inscmunicipal { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string tipopessoa { get; set; }



        public string replace(string cpf)
        {
            cpf = cpf.Replace(",", "");
            cpf = cpf.Replace(".", "");
            cpf = cpf.Replace("-", "");
            return cpf;


        }


        public  Boolean validarCpf(string cpf)
        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

      
    }
}

using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paivaVersao0
{
    public partial class frmRelatorios : MetroFramework.Forms.MetroForm
    {
        public frmRelatorios()
        {
            InitializeComponent();
        }

        private void frmRelatorios_Load(object sender, EventArgs e)
        {


            ConfigClasses.ConexaoBanco Conexao = new ConfigClasses.ConexaoBanco();
            MySqlConnection getconexao = Conexao.getConexao();
            MySqlCommand getcomando = Conexao.getComando(getconexao);
            getcomando.CommandText = "SELECT cpfCnpj, cep, endereco, bairro, cidade, estado, contatoTelefonico, celular, email, observacao, nome, ocupacao, rg, naturalidade, datanascimento, nacionalidade, pis, titulodeeleitor, estadocivil, regimeuniao, profissao, dependentes, rendimentomensal, escolaridade, formacaoacademica, carteiraprofissional, carteiradehabilitacao, benspatrimoniais, nomeconjuge, atividade, nomepai, nomemae, site, fax, complemento FROM cadpessoapedido where idpessoa = 16 ";
            MySqlDataReader reader = getcomando.ExecuteReader();


            ClassesPrograma.Pessoa PESSOA = new ClassesPrograma.Pessoa();
            while (reader.Read())
            {
                PESSOA.cpfnCnpjpessoa = reader.GetString(0);
                PESSOA.cep = reader.GetString(1);
                PESSOA.endereco = reader.GetString(2);
                PESSOA.bairro = reader.GetString(3);
                PESSOA.cidade = reader.GetString(4);
                PESSOA.estado = reader.GetString(5);
                PESSOA.contatoTelefonico = reader.GetString(6);
                PESSOA.celular = reader.GetString(7);
                PESSOA.email = reader.GetString(8);
                PESSOA.observacao = reader.GetString(9);
                PESSOA.ocupacao = reader.GetString(10);
                PESSOA.ci = reader.GetString(11);
                PESSOA.naturalidade = reader.GetString(12);
                PESSOA.datanascimento = reader.GetString(13);
                PESSOA.nacionalidade = reader.GetString(14);
                PESSOA.pis = reader.GetString(15);
                PESSOA.titulodeeleitor = reader.GetString(16);
                PESSOA.estadocivil = reader.GetString(17);
                PESSOA.regimeuniao = reader.GetString(18);
                PESSOA.profissao = reader.GetString(19);
                PESSOA.dependentes = reader.GetString(20);
                PESSOA.rendimentomensal = reader.GetString(21);
                PESSOA.escolaridade = reader.GetString(22);
                PESSOA.formacaoacademica = reader.GetString(23);
                PESSOA.carteiraprofissional = reader.GetString(24);
                PESSOA.carteiradehabilitacao = reader.GetString(25);
                PESSOA.benspatrimoniais = reader.GetString(26);
                PESSOA.atividade = reader.GetString(27);
                PESSOA.nomeconjuge = reader.GetString(28);
                PESSOA.nomepai = reader.GetString(29);
                PESSOA.nomemae = reader.GetString(30);
                PESSOA.nomeconjuge = reader.GetString(31);
                PESSOA.nomeconjuge = reader.GetString(32);                

            
            }
            reader.Close();



















            PESSOA.endereco = PESSOA.endereco + "  " + PESSOA.bairro + "^p                                " + PESSOA.cep + "                              " + PESSOA.cidade + " " + PESSOA.estado;

            getcomando.CommandText = "select cnpj,datafundacao,participacaocapital,capitalsocial,nomempresa,atividade,receitafederal,receitaestadual,cep,estado,contatotelefonico,celular,email,endereco,bairro,cidade from ptsocietaria where idpedido=32";
            reader = getcomando.ExecuteReader();
            ClassesPrograma.PTSocietaria[] PTS = new ClassesPrograma.PTSocietaria[3];
            int i = 0;

            while (reader.Read())
            {
                PTS[i] = new ClassesPrograma.PTSocietaria();
                PTS[i].cnpj = reader.GetString(0);
                PTS[i].datafundacao = reader.GetString(1);
                PTS[i].participacaocapital = reader.GetString(2);
                PTS[i].capitalsocial = reader.GetString(3);
                PTS[i].nomemepresa = reader.GetString(4);
                PTS[i].atividade = reader.GetString(5);
                PTS[i].receitaestadual = reader.GetString(6);
                PTS[i].receitafederal = reader.GetString(7);
                PTS[i].cep = reader.GetString(8);
                PTS[i].estado = reader.GetString(9);
                PTS[i].contatelefonico = reader.GetString(10);
                PTS[i].celular = reader.GetString(11);
                PTS[i].email = reader.GetString(12);
                PTS[i].endereco = reader.GetString(13);
                PTS[i].bairro = reader.GetString(14);
                PTS[i].cidade = reader.GetString(15);
                i++;


            }




            reader.Close();
            getcomando.CommandText = "select tipo,texto,fatosrelevantescol from fatosrelevantes where idpedido=32";
            reader = getcomando.ExecuteReader();


            ClassesPrograma.Fatorelevante fatos = new ClassesPrograma.Fatorelevante();

            while (reader.Read())
            {
                fatos.tipo = reader.GetString(0);
                fatos.descricao = reader.GetString(2);

            }



            reader.Close();
            getcomando.CommandText = "select tipo,texto,fatosrelevantescol from fatosrelevantes where idpedido=32";
            reader = getcomando.ExecuteReader();


       


            ConfigClasses.ManipulaWord manipula = new ConfigClasses.ManipulaWord();


            try
            {


                manipula.PreencherPorReplace(Application.StartupPath + "\\MODELO.DOC", PESSOA, PTS,fatos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}

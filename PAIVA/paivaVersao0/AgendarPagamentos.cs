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
    public partial class AgendarPagamentos : MetroFramework.Forms.MetroForm

    {
        string tipo = "";

        public AgendarPagamentos()
        {
            InitializeComponent();
           
        }



        public AgendarPagamentos(string tipopagamento)
        {

             tipo = tipopagamento;                    
             this.Text = "Novo recebimento";         
             InitializeComponent();
            

        }

        ClassesPrograma.Pagamento pagamento = new ClassesPrograma.Pagamento();


        private void AgendarPagamentos_Load(object sender, EventArgs e)
        {
            ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();

            MySqlConnection getconexao = conexao.getConexao();
            MySqlCommand getcomando = conexao.getComando(getconexao);
            getcomando.CommandText = "select nome from funcionarios union all select nome from fornecedores";
            MySqlDataReader reader = conexao.getReader(getcomando);
            while (reader.Read())
            {
                cbbFornecedores.Items.Add(reader.GetString(0));

            }
            

        }

       

        private void btnTornarRecorrente_Click(object sender, EventArgs e)
        {
           


        }

        private void btnAdicionarParcelas_Click(object sender, EventArgs e)
        {
          




        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
           {

                pagamento.nomeFornecedor = cbbFornecedores.Text;
                pagamento.valor = Convert.ToInt32(Replace(txtValor.Text));
                pagamento.dataVencimento = txtVencimento.Text;
                pagamento.categoria = cbbCategoria.Text;
                pagamento.descricaoLancamento = txtDescricao.Text;
                pagamento.referencia = txtReferencia.Text;
                pagamento.agendamentoPara = txtagendamento.Text;               
                
            };

            //if (verificarRecorrencia(pagamento).Equals("Recorrencia valida")&&txtRepetir.Text!=""){

            //    ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();

            //    MySqlConnection getconexao = conexao.getConexao();
            //    MySqlCommand getcomando = conexao.getComando(getconexao);
            //    getcomando.CommandText = "INSERT INTO pagamento(nomeFornecedor,valor,dataVencimento,categoria,descricaoLancamento,referencia,agendamentoPara,anotacao,arquivos,recorrencia,parcelas,tipopagamento,status,valorpagamento) VALUES (@NomeFornecedor,@valor,@dataVencimento,@categoria,@descricaoLancamento,@referencia,@agendamentoPara,@anotacao,@arquivos,@recorrencia,@parcelas,@tipopagamento,@status)";
            //    getcomando.Parameters.AddWithValue("@nomeFornecedor", pagamento.nomeFornecedor);
            //    getcomando.Parameters.AddWithValue("@valor", pagamento.valor);
            //    getcomando.Parameters.AddWithValue("@datavencimento", pagamento.dataVencimento);
            //    getcomando.Parameters.AddWithValue("@categoria", pagamento.categoria);
            //    getcomando.Parameters.AddWithValue("@descricaolancamento", pagamento.descricaoLancamento);
            //    getcomando.Parameters.AddWithValue("@referencia", pagamento.referencia);
            //    getcomando.Parameters.AddWithValue("@agendamentopara", pagamento.agendamentoPara);
            //    getcomando.Parameters.AddWithValue("@anotacao", pagamento.anotacao);
            //    getcomando.Parameters.AddWithValue("@arquivos", pagamento.arquivos);
            //    getcomando.Parameters.AddWithValue("@recorrencia", 1);
            //    getcomando.Parameters.AddWithValue("@parcelas", 0);
            //    getcomando.Parameters.AddWithValue("@tipopagamento", tipo);
            //    getcomando.Parameters.AddWithValue("@status", "emaberto");
            //    getcomando.Parameters.AddWithValue("@valorpagamento", pagamento.valor);
            //    getcomando.ExecuteNonQuery();
            //    int idpagamento = Convert.ToInt32(getcomando.LastInsertedId.ToString());

            //    getcomando.CommandText="INSERT INTO RECORRENCIA(tiporepeticao,termino,ocorrencias,datatermino,idpagamento) values (tiporepeticao,termino,ocorrencias,datatermino,idpagamento";
            //    getcomando.Parameters.AddWithValue("@tiporepeticao", pagamento.recorrencias.tipoRepeticao);
            //    getcomando.Parameters.AddWithValue("@termino", pagamento.recorrencias.Termino);
            //    getcomando.Parameters.AddWithValue("@ocorrencias", pagamento.recorrencias.ocorrencia);
            //    getcomando.Parameters.AddWithValue("@datatermino", pagamento.recorrencias.dataTemino);
            //    getcomando.Parameters.AddWithValue("@idpagamento", idpagamento);
            //    getcomando.ExecuteNonQuery();


            //}
            //else if(VerificarParcelas(pagamento)&&txtVarlorParcela.Text!=""){

            //    ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();

            //    MySqlConnection getconexao = conexao.getConexao();
            //    MySqlCommand getcomando = conexao.getComando(getconexao);
            //    getcomando.CommandText = "INSERT INTO pagamento(nomeFornecedor,valor,dataVencimento,categoria,descricaoLancamento,referencia,agendamentoPara,anotacao,arquivos,recorrencia,parcelas,tipopagamento,status,valorpagamento) VALUES (@NomeFornecedor,@valor,@dataVencimento,@categoria,@descricaoLancamento,@referencia,@agendamentoPara,@anotacao,@arquivos,@recorrencia,@parcelas,@tipopagamento,@status,valorpagamento)";
            //    getcomando.Parameters.AddWithValue("@nomeFornecedor", pagamento.nomeFornecedor);
            //    getcomando.Parameters.AddWithValue("@valor", pagamento.valor);
            //    getcomando.Parameters.AddWithValue("@datavencimento", pagamento.dataVencimento);
            //    getcomando.Parameters.AddWithValue("@categoria", pagamento.categoria);
            //    getcomando.Parameters.AddWithValue("@descricaolancamento", pagamento.descricaoLancamento);
            //    getcomando.Parameters.AddWithValue("@referencia", pagamento.referencia);
            //    getcomando.Parameters.AddWithValue("@agendamentopara", pagamento.agendamentoPara);
            //    getcomando.Parameters.AddWithValue("@anotacao", pagamento.anotacao);
            //    getcomando.Parameters.AddWithValue("@arquivos", pagamento.arquivos);
            //    getcomando.Parameters.AddWithValue("@recorrencia", 0);
            //    getcomando.Parameters.AddWithValue("@parcelas", 1);
            //    getcomando.Parameters.AddWithValue("@tipopagamento", tipo);
            //    getcomando.Parameters.AddWithValue("@status", "emaberto");
            //    getcomando.Parameters.AddWithValue("@valorpagamento", pagamento.valor);
            //    getcomando.ExecuteNonQuery();



            //    int idpagamento =Convert.ToInt32( getcomando.LastInsertedId.ToString());

            //    foreach (ClassesPrograma.Parcelamento parcela in pagamento.parcela) {

            //         getcomando.Parameters.Clear();
            //        getcomando.CommandText = "INSERT INTO PARCELAS(valor,descricao,referencia,idpagamento,vencimento,agendada) values (@valor,@descricao,@referencia,@idpagamento,@vencimento,@agendada)";
            //        getcomando.Parameters.AddWithValue("@valor", parcela.valor);
            //        getcomando.Parameters.AddWithValue("@descricao", parcela.descricao);
            //        getcomando.Parameters.AddWithValue("@referencia", parcela.referencia);
            //        getcomando.Parameters.AddWithValue("@idpagamento", idpagamento);
            //        getcomando.Parameters.AddWithValue("@vencimento", parcela.dataVencimento);
            //        getcomando.Parameters.AddWithValue("@agendada", parcela.datapagamenot);

            //        getcomando.ExecuteNonQuery();


            //      }
            //}
            //else {

            if (tipo != "RECEBIMENTO")
            {
                ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();
                MySqlConnection getconexao = conexao.getConexao();
                MySqlCommand getcomando = conexao.getComando(getconexao);
                getcomando.CommandText = "INSERT INTO pagamento(nomeFornecedor,valor,dataVencimento,categoria,descricaoLancamento,referencia,agendamentoPara,anotacao,arquivos,recorrencia,parcelas,tipopagamento,status) VALUES (@NomeFornecedor,@valor,@dataVencimento,@categoria,@descricaoLancamento,@referencia,@agendamentoPara,@anotacao,@arquivos,@recorrencia,@parcelas,@tipopagamento,@status)";
                getcomando.Parameters.AddWithValue("@nomeFornecedor", pagamento.nomeFornecedor);
                getcomando.Parameters.AddWithValue("@valor", pagamento.valor);
                getcomando.Parameters.AddWithValue("@datavencimento", pagamento.dataVencimento);
                getcomando.Parameters.AddWithValue("@categoria", pagamento.categoria);
                getcomando.Parameters.AddWithValue("@descricaolancamento", pagamento.descricaoLancamento);
                getcomando.Parameters.AddWithValue("@referencia", pagamento.referencia);
                getcomando.Parameters.AddWithValue("@agendamentopara", pagamento.agendamentoPara);
                getcomando.Parameters.AddWithValue("@anotacao", pagamento.anotacao);
                getcomando.Parameters.AddWithValue("@arquivos", pagamento.arquivos);
                getcomando.Parameters.AddWithValue("@recorrencia", 0);
                getcomando.Parameters.AddWithValue("@parcelas", 0);
                getcomando.Parameters.AddWithValue("@tipopagamento", tipo);
                getcomando.Parameters.AddWithValue("@status", "emaberto");

                getcomando.ExecuteNonQuery();
                getcomando.Parameters.Clear();
                getcomando.CommandText = "update funcionarios set valorpagamento=@valorpagamento where nome=@nomefornecedor";
                getcomando.Parameters.AddWithValue("@valorpagamento", pagamento.valor);
                getcomando.Parameters.AddWithValue("@nomefornecedor", pagamento.nomeFornecedor);
                getcomando.ExecuteNonQuery();




                //}
                if (cheContinuar.Checked)
                {
                    cbbFornecedores.Text = "";
                    txtValor.Text = "";
                    txtVencimento.Text = "";
                    cbbCategoria.Text = "";
                    txtDescricao.Text = "Ex: Serviço prestado.";
                    txtReferencia.Text = "";
                    txtagendamento.Text = "";

                    cbbNumeroParcelas.Text = "";
                    txtVarlorParcela.Text = "";
                    txtDataVencimento.Text = "";
                    txtParcelaDescricao.Text = "";
                    txtparcelaReferencia.Text = "";
                    txtRepetir.Text = "";
                    tipoderepeticao.Text = "";
                    txtApos.Text = "";
                    txtdatafinal.Text = "";


                }
            }else
            {

                ConfigClasses.ConexaoBanco conexao = new ConfigClasses.ConexaoBanco();
                MySqlConnection getconexao = conexao.getConexao();
                MySqlCommand getcomando = conexao.getComando(getconexao);
                getcomando.CommandText = "INSERT INTO "+tipo+"(nomeFornecedor,valor,dataVencimento,categoria,descricaoLancamento,referencia,agendamentoPara,anotacao,arquivos,recorrencia,parcelas,tipopagamento,status) VALUES (@NomeFornecedor,@valor,@dataVencimento,@categoria,@descricaoLancamento,@referencia,@agendamentoPara,@anotacao,@arquivos,@recorrencia,@parcelas,@tipopagamento,@status)";
                getcomando.Parameters.AddWithValue("@nomeFornecedor", pagamento.nomeFornecedor);
                getcomando.Parameters.AddWithValue("@valor", pagamento.valor);
                getcomando.Parameters.AddWithValue("@datavencimento", pagamento.dataVencimento);
                getcomando.Parameters.AddWithValue("@categoria", pagamento.categoria);
                getcomando.Parameters.AddWithValue("@descricaolancamento", pagamento.descricaoLancamento);
                getcomando.Parameters.AddWithValue("@referencia", pagamento.referencia);
                getcomando.Parameters.AddWithValue("@agendamentopara", pagamento.agendamentoPara);
                getcomando.Parameters.AddWithValue("@anotacao", pagamento.anotacao);
                getcomando.Parameters.AddWithValue("@arquivos", pagamento.arquivos);
                getcomando.Parameters.AddWithValue("@recorrencia", 0);
                getcomando.Parameters.AddWithValue("@parcelas", 0);
                getcomando.Parameters.AddWithValue("@tipopagamento", tipo);
                getcomando.Parameters.AddWithValue("@status", "emaberto");

                getcomando.ExecuteNonQuery();
                getcomando.Parameters.Clear();
                getcomando.CommandText = "update funcionarios set valorpagamento=@valorpagamento where nome=@nomefornecedor";
                getcomando.Parameters.AddWithValue("@valorpagamento", pagamento.valor);
                getcomando.Parameters.AddWithValue("@nomefornecedor", pagamento.nomeFornecedor);
                getcomando.ExecuteNonQuery();




                //}
                if (cheContinuar.Checked)
                {
                    cbbFornecedores.Text = "";
                    txtValor.Text = "";
                    txtVencimento.Text = "";
                    cbbCategoria.Text = "";
                    txtDescricao.Text = "Ex: Serviço prestado.";
                    txtReferencia.Text = "";
                    txtagendamento.Text = "";

                    cbbNumeroParcelas.Text = "";
                    txtVarlorParcela.Text = "";
                    txtDataVencimento.Text = "";
                    txtParcelaDescricao.Text = "";
                    txtparcelaReferencia.Text = "";
                    txtRepetir.Text = "";
                    tipoderepeticao.Text = "";
                    txtApos.Text = "";
                    txtdatafinal.Text = "";


                }

            }


        }

        public Boolean verificarRecorrencia(ClassesPrograma.Pagamento pagamento)
        {
            if (txtRepetir.Text != "" && tipoderepeticao.Text != "")
            {

                if (tipoderepeticao.Text.Equals("Dia(s)"))
                {
                    pagamento.recorrencias.tipoRepeticao = Convert.ToInt32(txtRepetir.Text);

                }
                if (tipoderepeticao.Text.Equals("Semana(s)"))
                {
                    pagamento.recorrencias.tipoRepeticao = Convert.ToInt32(txtRepetir.Text);
                }
                if (tipoderepeticao.Text.Equals("Mês(es)"))
                {
                    pagamento.recorrencias.tipoRepeticao = Convert.ToInt32(txtRepetir.Text);
                }
                if (tipoderepeticao.Text.Equals("Ano(s)"))
                {
                    pagamento.recorrencias.tipoRepeticao = Convert.ToInt32(txtRepetir.Text);
                }

                if (recorrenciaindeterminada.Checked)
                {
                    pagamento.recorrencias.Termino = "INDETERMINADO";

                }
                if (radiuApos.Checked)
                {
                    pagamento.recorrencias.Termino = txtApos.Text;

                }
                if (aposdata.Checked)
                {
                    pagamento.recorrencias.Termino = txtdatafinal.Text;


                }

            }else
            {
                return false;

            }
            return true;

        }

        public Boolean VerificarParcelas(ClassesPrograma.Pagamento pagamento)
        {
            string valor = txtVarlorParcela.Text;
            DateTime proximovencimento =Convert.ToDateTime( txtDataVencimento.Text);
            proximovencimento = proximovencimento.AddDays(30);
            txtDataVencimento.Text = proximovencimento.ToString();

            DateTime pagamentoparcela = Convert.ToDateTime(txtagendamento.Text);
            pagamentoparcela=pagamentoparcela.AddDays(30);
            txtagendamento.Text = pagamentoparcela.ToString();
           
           


            string txtDataVencimentos = txtDataVencimento.Text;
            valor = Replace(valor);
            txtDataVencimentos = Replace(txtDataVencimentos);
            if (!cbbNumeroParcelas.Text.Equals("") || !Replace(valor).Equals("") || !Replace(txtDataVencimentos).Equals("") || !Replace(txtParcelaDescricao.Text).Equals("") || !Replace(txtparcelaReferencia.Text).Equals(""))
            {
                ClassesPrograma.Parcelamento parcela = new ClassesPrograma.Parcelamento();

                string teste = txtVarlorParcela.Text;
                teste = Replace(teste);
                parcela.valor = Convert.ToInt32(Replace(teste));
                parcela.descricao = txtParcelaDescricao.Text;
                parcela.dataVencimento = proximovencimento.ToString("dd/MM/yyyy");
                parcela.referencia = txtparcelaReferencia.Text;
                parcela.datapagamenot = pagamentoparcela.ToString("dd/MM/yyyy");

                pagamento.parcela.Add(parcela);

                return true;


            }else
            {
                return false;

            }
        }

        public string Replace(string texto)
        {
            texto = texto.Replace(".", "");
            texto = texto.Replace(",", "");
            texto = texto.Replace("R", "");
            texto = texto.Replace("$", "");
            texto = texto.Replace(" ", "");
            texto = texto.Replace("_", "");
            texto = texto.Replace("-", "");
            texto = texto.Replace("/", "");
            return texto;


        }

        private void btnAdcionarParcela_Click(object sender, EventArgs e)
        {
            if (validarDATA(txtVencimento.Text, txtagendamento.Text)){
                for (int i = 0; i < Convert.ToInt32(cbbNumeroParcelas.Text); i++)
                {
                    VerificarParcelas(pagamento);
                }
                if (cbbNumeroParcelas.Text.Equals("1"))
                    MessageBox.Show("Foi adicionada " + cbbNumeroParcelas.Text + " parcela a este pagamento, você será avisa quando chegar o dia do pagamento.", "Adcionar parcela", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (Convert.ToInt32(cbbNumeroParcelas.Text) > 1)
                {
                    MessageBox.Show("Foram adicionadas " + cbbNumeroParcelas.Text + " parcelas a este pagamento, você será avisa quando chegar o dia do pagamento.", "Adcionar parcelas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        public Boolean validarDATA(String DATAINICIAL,String DATAFINAL)
        {
            TimeSpan validadata = Convert.ToDateTime(DATAINICIAL) - Convert.ToDateTime(DATAFINAL);

            
            int totdias = validadata.Days;

            if (totdias > 0)
            {
                return true;

            }else 
            {
                MessageBox.Show("A data de pagamento não pode ser posterior ao vencimento", "Vencimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }

        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            Double valor = 0;

            try
            {
                valor = Double.Parse(txtValor.Text);
                txtValor.Text = valor.ToString("C");


            }
            catch (Exception)
            {

            }
        }

        private void txtVarlorParcela_Leave(object sender, EventArgs e)
        {
            Double valor1 = 0;

            try
            {
                valor1 = Double.Parse(txtVarlorParcela.Text);
                txtVarlorParcela.Text = valor1.ToString("C");


            }
            catch (Exception)
            {

            }
        }

      

    
      



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtVarlorParcela.Text = txtValor.Text;
            txtparcelaReferencia.Text = txtReferencia.Text;
            txtParcelaDescricao.Text = txtDescricao.Text;
            txtDataVencimento.Text = txtVencimento.Text;


        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdcionarParcela_Click_1(object sender, EventArgs e)
        {

        }
    }
}

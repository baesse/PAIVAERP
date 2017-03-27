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
    public partial class CadClientefinanceiro : MetroFramework.Forms.MetroForm
    {
        public CadClientefinanceiro()
        {
            InitializeComponent();
        }

        private void CadClientefinanceiro_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            clientefinanceiro novocadfinanceirocliente = new clientefinanceiro() {

                cnpjcpf = txtcpfcnpj.Text,
                nome=txtnome.Text,
                email=txtemail.Text,
                telefone=txttelefone.Text,
                celular=txtcelular.Text,
                pessoacontato=txtpessoacontato.Text,
                site=txtsite.Text,
                razaosocial=txtrazaosocial.Text,
                inscmunicpal=txtinscmunicipal.Text,
                endereco=txtendenreco.Text,
                bairro=txtbairro.Text,
                cidade=txtcidade.Text,
                estado=cbbestado.Text,
                cep=txtcep.Text,
                banco=txtbanco.Text,
                agencia=txtagencia.Text,
                conta=txtconta.Text,                




            };

            novocadfinanceirocliente.inserirCliente(novocadfinanceirocliente);

        }
    }
}

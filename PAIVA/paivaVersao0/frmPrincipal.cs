using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class frmPrincipal : MetroFramework.Forms.MetroForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public frmPrincipal(ArrayList usuario)
        {
            InitializeComponent();
            ClassesPrograma.Usuario usuarioid = new ClassesPrograma.Usuario();
            usuarioid.nome = usuario[0].ToString();
            usuarioid.acesso = usuario[2].ToString();

            barrainfo.Text="Usuario: "+"Igor Baesse"+ "   Tipo de acesso: A"+"Versão: "+ System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

           


        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            timer1.Start();
            ResizeMiddlePanel();

            barrainfo.Text = "Usuario: " + "Igor Baesse" + "   Tipo de acesso: A" +"       Versão: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            alertanotificacao.Start();

        }

        private void cadastroDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroDeUsuario frmCadastro = new frmCadastroDeUsuario();
            frmCadastro.Show();

        }

        private void ResizeMiddlePanel()

        {

           // int panelCentralWidth = (int)(.95 * (statusbar.Width - panel_esq.Width)) - panelcentral.Width;



           // panel_esq.Width = panelCentralWidth / 2;

            //panel_esq.Width = panelCentralWidth / 2;



        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCadastroDeUsuario cadastro = new frmCadastroDeUsuario();
            cadastro.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadClientes cadclienteform = new CadClientes();
            cadclienteform.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroPedidos frmcadastro = new CadastroPedidos();
            frmcadastro.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmRelatorios frmrelatorios = new frmRelatorios();
            frmrelatorios.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CadastroPedidos frmpedido = new CadastroPedidos();
            frmpedido.Show();

               
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CadClientes frmcada = new CadClientes();
            frmcada.Show();

        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            ResizeMiddlePanel();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            CadastroPedidos frmpedidos = new CadastroPedidos();
            frmpedidos.ShowDialog();
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            CadClientes frmcadcleinte = new CadClientes();
            frmcadcleinte.ShowDialog();
        }

        private void abrecadastro_Click(object sender, EventArgs e)
        {
            CadClientes frmcadastro = new CadClientes();
            frmcadastro.Show();

        }

        private void novopedido_Click(object sender, EventArgs e)
        {
            CadastroPedidos frmpedido = new CadastroPedidos();
            frmpedido.ShowDialog();
           

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void abrecadastro_MouseMove(object sender, MouseEventArgs e)
        {
            Menu.Text = "Criar um novo cadastro de clientes";

        }

        private void abrecadastro_MouseLeave(object sender, EventArgs e)
        {
            Menu.Text = "Menu Principal";
        }

        private void novopedido_MouseMove(object sender, MouseEventArgs e)
        {
            Menu.Text = "Criar um novo pedido";
        }

        private void novopedido_MouseLeave(object sender, EventArgs e)
        {
            Menu.Text = "Menu Principal";
        }

        private void metroTile3_MouseMove(object sender, MouseEventArgs e)
        {
            Menu.Text = "Gerar relatórios de controle";
        }

        private void metroTile3_MouseLeave(object sender, EventArgs e)
        {
            Menu.Text = "Menu Principal";
        }

        private void Agenda_MouseMove(object sender, MouseEventArgs e)
        {
            Menu.Text = "Registrar resposta de pedidos";
        }

        private void Agenda_MouseLeave(object sender, EventArgs e)
        {
            Menu.Text = "Menu Principal";
        }

        private void metroTile4_MouseMove(object sender, MouseEventArgs e)
        {
            Menu.Text = "Controle financeiro";
        }

        private void metroTile4_MouseLeave(object sender, EventArgs e)
        {
            Menu.Text = "Menu Principal";
        }

        private void metroTile5_MouseMove(object sender, MouseEventArgs e)
        {
            Menu.Text = "Controle das tarefas diarias";
        }

        private void metroTile5_MouseLeave(object sender, EventArgs e)
        {
            Menu.Text = "Menu Principal";
        }

        private void metroTile2_MouseLeave(object sender, EventArgs e)
        {
            Menu.Text = "Menu Principal";
        }

        private void metroTile2_MouseMove(object sender, MouseEventArgs e)
        {
            Menu.Text = "Controle de usuários e informações do sistema";
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            frmRelatorios frmrelatorios = new frmRelatorios();
            frmrelatorios.ShowDialog();

        }

        private void abrecontrolepedidos_Click(object sender, EventArgs e)
        {
            frmcontrolepedidos controlepedidos = new frmcontrolepedidos();
            controlepedidos.ShowDialog();


        }

        private void abrecontrolefinanceiro_Click(object sender, EventArgs e)
        {
            frmcontrolefinanceiro frmfinanceiro = new frmcontrolefinanceiro();
            frmfinanceiro.ShowDialog();

        }

        private void abreagenda_Click(object sender, EventArgs e)
        {
            frmagenda frmagenda = new frmagenda();
            frmagenda.ShowDialog();

        }

        private void abrecontrole_Click(object sender, EventArgs e)
        {

            frmLogin frmlogin = new frmLogin();

            frmlogin.ShowDialog();
              if (frmlogin.logado) {

                frmcontrole frmcontrole = new frmcontrole();
                frmcontrole.ShowDialog();
            }
        }

        private void abrecontrolepedidos_Enter(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            NotifyIcon NOTI = new NotifyIcon();
            NOTI.Visible = true;
            NOTI.Icon = SystemIcons.Information;
            NOTI.BalloonTipTitle = "Informações sobre os pedidos ";
            ConfigClasses.ConexaoBanco conexaobanco = new ConfigClasses.ConexaoBanco();
            MySqlConnection conexao = conexaobanco.getConexao();
            MySqlCommand comando = conexaobanco.getComando(conexao);
            comando.CommandText = "SELECT idpedido from cadpedido where status=@status";
            comando.Parameters.AddWithValue("@status", "PENDENTE");
            MySqlDataReader reader = conexaobanco.getReader(comando);
            int quanto = 0;

            while (reader.Read())
            {
                quanto++;

            }

            if (quanto > 0)
            {

                if (quanto == 1) {
                    NOTI.BalloonTipText = "Você tem " + quanto + " pedido em aberto.";
                    NOTI.ShowBalloonTip(10);
                }
                else
                {
                    NOTI.BalloonTipText = "Você tem " + quanto + " pedidos em aberto.";
                    NOTI.ShowBalloonTip(10);
                }

            }else
            {
                NOTI.BalloonTipText = "Você  não tem  pedidos em aberto.";
                NOTI.ShowBalloonTip(10);
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string horario1 = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            if (horario1.Equals("09:30:01"))
            {
                NotifyIcon NOTI = new NotifyIcon();
                NOTI.Visible = true;
                NOTI.Icon = SystemIcons.Information;
                NOTI.BalloonTipTitle = "Informações sobre o pedidos ";
                ConfigClasses.ConexaoBanco conexaobanco = new ConfigClasses.ConexaoBanco();
                MySqlConnection conexao = conexaobanco.getConexao();
                MySqlCommand comando = conexaobanco.getComando(conexao);
                comando.CommandText = "SELECT idpedido from cadpedido where status=@status";
                comando.Parameters.AddWithValue("@status", "PENDENTE");
                MySqlDataReader reader = conexaobanco.getReader(comando);
                int quanto = 0;

                while (reader.Read())
                {
                    quanto++;

                }

                if (quanto > 0)
                {

                    if (quanto == 1)
                    {
                        NOTI.BalloonTipText = "Você tem " + quanto + " pedido em aberto.";
                        NOTI.ShowBalloonTip(10);
                    }
                    else
                    {
                        NOTI.BalloonTipText = "Você tem " + quanto + " pedidos em aberto.";
                        NOTI.ShowBalloonTip(10);
                    }

                }
                else
                {
                    NOTI.BalloonTipText = "Você tem não tem  pedidos em aberto.";
                    NOTI.ShowBalloonTip(10);
                }

            }

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paivaVersao0
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           
            frmLogin frmlogin = new frmLogin();
            frmlogin.ShowDialog();
            
            if (frmlogin.logado)
            {
                Application.Run(new frmPrincipal(frmlogin.usuariodados));
               
            }
            
            
        }
    }
}

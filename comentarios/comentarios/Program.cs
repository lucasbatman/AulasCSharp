using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comentarios
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
            Application.Run(new Form1());

            // ToDo(FAZER) - AQUI VAI  UMA MELHORIA DE CÓDIGO, PENDENTE DE SER FEITA PELO MATHEUS 
            VEICULO veic = new VEICULO();
            veic.Mover();
        }
    }
}

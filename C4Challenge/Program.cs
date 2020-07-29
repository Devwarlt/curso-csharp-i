using System;
using System.Windows.Forms;

namespace C4Challenge
{
    /* Após a instalação você deve iniciar um projeto do tipo Windows Forms com Visual C#.
     * O nome do projeto deve ser "ProjetoDesafio123". Você não pode desenvolver ou modificar
     * o projeto inicial, apenas criá-lo. */

    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

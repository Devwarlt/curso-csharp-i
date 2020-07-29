using System;
using System.Windows.Forms;

namespace C6Challenge
{
    /* Aqui, você deve criar um projeto no Visual Studio com o nome Cadastro de Clientes.
     *
     * Neste projeto, você deve adicionar uma nova fonte de dados como Arquivo do Microsoft
     * SQL Server e instalar o Entity Framework.
     *
     * Você deve anexar o projeto e também imagens da tela que mostrem o Gerenciador de
     * Servidores com o banco de dados e, no Gerenciador de Soluções, a exibição da Referência
     * do Entity Framework no projeto. */

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

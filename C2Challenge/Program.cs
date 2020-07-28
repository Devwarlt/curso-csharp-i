using C2Challenge.Scripts;
using System;

namespace C2Challenge
{
    /* Neste desafio você deve criar um projeto do tipo "Aplicativo do Console (.NET Framework)"
     * no Visual Studio com o nome "ControleEscolar".
     *
     * img -> http://lrq.sagah.com.br/uasdinamicas/uploads/layouts/243992215_1567525048bd122bf2921a6764685d857aaa7b551f5d794612.jpg
     *
     * Ao fim, faça uma impressão da idade na tela utilizando o Console.WriteLine e verifique
     * se a idade está correta. */

    public sealed class Program
    {
        private static void Main()
        {
            var aluno = new Aluno("Pedro", "Silva", new DateTime(1991, 10, 10));
            Console.WriteLine(aluno);
            Environment.Exit(0);
        }
    }
}

using C1Challenge.Scripts;
using System;
using System.Text;

namespace C1Challenge
{
    /* Um grande banco contratou você para desenvolver um sistema que gerenciará as contas de todos os clientes.
     * A empresa sugeriu o uso de C#.NET para criar esse sistema. Para isso, você deve criar um projeto do tipo
     * "Aplicativo do Console (.NET Framework)" no Visual Studio com o nome "SistemaBanco".
     *
     * Neste projeto, você deve criar uma classe chamada "Conta", que representará uma conta bancária em um banco.
     * Nessa classe, defina os seguintes atributos:
     * - agencia
     * - numero
     * - nomeCliente
     * - valorDisponível
     *
     * Você deve definir os tipos de dados que melhor representam cada atributo. Tenha em mente os seguintes requisitos:
     * 1) A agencia representa o código da agência da conta, que é formado por quatro números inteiros (ex.: 2312).
     * 2) O numero representa o código da conta, formado por oito números (ex.: 12345333).
     * 3) O nomeCliente armazenará o nome do cliente.
     * 4) O valorDisponível deverá armazenar o valor em dinheiro disponível na conta.
     *
     * Você também deve definir os modificadores de acesso e os getters e setters. Para esta definição, lembre-se da seguinte regra de negócio:
     * - Todos os atributos deverão ser acessados por meio de propriedades de acesso (getters e setters).
     *
     * Bom trabalho. */

    public sealed class Program
    {
        private static void Main()
        {
            var numbers = "0123456789";
            var random = new Random();
            var sistema = new SistemaBanco();
            var contas = new[]
            {
                new Conta()
                {
                    Agencia = $"{RandomStr(numbers, random.Next(4, 6))}-{random.Next(0, 9):D2}",
                    Numero = RandomStr(numbers, random.Next(4, 6)),
                    NomeCliente = "John",
                    ValorDisponivel =
                        (float)Math.Max(1, random.NextDouble()) * random.Next(10, 1000) +
                        (float)random.NextDouble() * 10f
                },
                new Conta()
                {
                    Agencia = $"{RandomStr(numbers, random.Next(4, 6))}-{random.Next(0, 9):D2}",
                    Numero = RandomStr(numbers, random.Next(4, 6)),
                    NomeCliente = "Mary",
                    ValorDisponivel =
                        (float)Math.Max(1, random.NextDouble()) * random.Next(10, 1000) +
                        (float)random.NextDouble() * 10f
                },
                new Conta()
                {
                    Agencia = $"{RandomStr(numbers, random.Next(4, 6))}-{random.Next(0, 9):D2}",
                    Numero = RandomStr(numbers, random.Next(4, 6)),
                    NomeCliente = "Roby",
                    ValorDisponivel =
                        (float)Math.Max(1, random.NextDouble()) * random.Next(10, 1000) +
                        (float)random.NextDouble() * 10f
                }
            };
            for (var i = 0; i < contas.Length; i++)
            {
                var conta = contas[i];
                Console.WriteLine($"Adicionando conta! -> {conta}");
                sistema.AdicionarConta(conta);
            }

            Console.WriteLine();

            for (var i = random.Next(0, contas.Length); i < contas.Length; i++)
            {
                var conta = contas[i];
                Console.WriteLine($"Removendo conta! -> {conta}");
                sistema.RemoverConta(conta.Agencia, conta.Numero);
                break;
            }

            Environment.Exit(0);
        }

        private static string RandomStr(string collection, int amount)
        {
            var random = new Random();
            var sb = new StringBuilder();
            for (var i = 0; i < amount; i++)
                sb.Append(collection[random.Next(0, collection.Length)]);
            return sb.ToString();
        }
    }
}

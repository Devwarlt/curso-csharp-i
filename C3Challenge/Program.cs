using C3Challenge.Scripts;
using System;

namespace C3Challenge
{
    /* Aqui, você deve imaginar que está construindo um sistema de pagamentos on-line.
     * Esse sistema deverá aceitar o pagamento originado por pessoas físicas (que têm CPF)
     * e também por pessoas jurídicas (que têm um CNPJ).
     *
     * Seu desafio é criar um projeto nomeado de "PagamentoOnline".​​​​​​​
     *
     * img -> http://lrq.sagah.com.br/uasdinamicas/uploads/layouts/904710907_1555362510e830c8c9f5764abc77f02ee5dbd12d8590bf164e.jpg
     *
     * - Para validar o CPF, utilize o seguinte código:
     * #######################
     * int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
     * int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
     * string tempCpf;
     * string digito;
     * int soma;
     * int resto;
     *
     * documento = documento.Trim();
     * documento = documento.Replace(".", "").Replace("-", "");
     *
     * if (documento.Length != 11)
     *  return false;
     *
     * tempCpf = cpf.Substring(0, 9);
     * soma = 0;
     *
     * for (int i = 0; i < 9; i++)
     *  soma +="int.Parse(tempCpf[i].ToString())" * multiplicador1[i];
     *
     * resto = soma % 11;
     *
     * if (resto < 2)
     *  resto="0;else resto = 11 - resto;
     *
     * digito = resto.ToString();
     * tempCpf = tempCpf + digito;
     * soma = 0;
     *
     * for (int i = 0; i < 10; i++)
     *  soma +="int.Parse(tempCpf[i].ToString())" * multiplicador2[i];
     *
     * resto = soma % 11;
     *
     * if (resto < 2)
     *  resto="0;else resto = 11 - resto;
     *
     * digito = digito + resto.ToString();
     * return cpf.EndsWith(digito);
     * ####################################
     *
     * - Para validar o CNPJ utilize o seguinte código:
     * ####################################
     * int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
     * int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
     * int soma;
     * int resto;
     * string digito;
     * string tempCnpj;
     *
     * documento = documento.Trim();
     * documento = documento.Replace(".", "").Replace("-", "").Replace("/", "");
     *
     * if (documento.Length != 14)
     *  return false;
     *
     * tempCnpj = documento.Substring(0, 12);
     * soma = 0;
     *
     * for (int i = 0; i < 12; i++)
     *  soma +="int.Parse(tempCnpj[i].ToString())" * multiplicador1[i];
     *
     * resto = (soma % 11);
     *
     * if (resto < 2)
     *  resto="0;else resto = 11 - resto;
     *
     * digito = resto.ToString();
     * tempCnpj = tempCnpj + digito;
     * soma = 0;
     *
     * for (int i = 0; i < 13; i++)
     *  soma +="int.Parse(tempCnpj[i].ToString())" * multiplicador2[i];
     *
     * resto = (soma % 11);
     *
     * if (resto < 2)
     *  resto="0;else resto = 11 - resto;
     *
     * digito = digito + resto.ToString();
     * return documento.EndsWith(digito);
     * ####################################
     *
     * Como resposta, você deve incluir o arquivo com o projeto criado. */

    public sealed class Program
    {
        private static void Main()
        {
            var pessoas = new Pessoa[]
            {
                new Fisica("556.465.420-06"),
                new Fisica("556.465.421-06"),
                new Juridica("80.515.283/0001-43"),
                new Juridica("80.515.284/0001-43")
            };
            pessoas[0].EscreverNome("Joao");
            pessoas[1].EscreverNome("Joao (fake)");
            pessoas[2].EscreverNome("Empresa do Joao");
            pessoas[3].EscreverNome("Empresa do Joao (fake)");

            for (var i = 0; i < pessoas.Length; i++)
                Console.WriteLine(pessoas[i]);

            Environment.Exit(0);
        }
    }
}

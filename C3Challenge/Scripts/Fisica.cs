using System;
using System.Text;

namespace C3Challenge.Scripts
{
    public sealed class Fisica : Pessoa
    {
        private static readonly int[] _m1;
        private static readonly int[] _m2;

        static Fisica()
        {
            _m1 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            _m2 = new int[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        }

        private readonly string _cpf;

        public Fisica(string cpf) => _cpf = cpf;

        public override void EscreverNome(string nome) => _nome = nome;

        public override bool Validar()
        {
            var cpf = _cpf
                .Replace(".", "")
                .Replace("-", "");
            if (cpf.Length != 11)
                return false;

            var dv = new StringBuilder();
            var digits = cpf.Substring(0, 9);
            var dvSum = 0;
            for (var i = 0; i < _m1.Length; i++)
                dvSum += int.Parse(digits[i].ToString()) * _m1[i];

            var dv1 = dvSum % 11;
            dv1 = dv1 < 2 ? 0 : Math.Abs(dv1 - 11);
            digits += dv1;
            dv.Append(dv1);
            dvSum = 0;

            for (var i = 0; i < _m2.Length; i++)
                dvSum += int.Parse(digits[i].ToString()) * _m2[i];

            var dv2 = dvSum % 11;
            dv2 = dv2 < 2 ? 0 : Math.Abs(dv2 - 11);
            dv.Append(dv2);
            return _cpf.EndsWith(dv.ToString());
        }

        public override string ToString() => $"Nome: {_nome}\nCPF: {_cpf} (valido? {(Validar() ? "sim" : "nao")})\n";
    }
}

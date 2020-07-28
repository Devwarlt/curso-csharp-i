using System;
using System.Text;

namespace C3Challenge.Scripts
{
    public sealed class Juridica : Pessoa
    {
        private static readonly int[] _m1;
        private static readonly int[] _m2;

        static Juridica()
        {
            _m1 = new int[] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            _m2 = new int[] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        }

        private readonly string _cnpj;

        public Juridica(string cnpj) => _cnpj = cnpj;

        public override void EscreverNome(string nome) => _nome = nome;

        public override bool Validar()
        {
            var cnpj = _cnpj
                .Replace(".", "")
                .Replace("/", "")
                .Replace("-", "");
            if (cnpj.Length != 14)
                return false;

            var dv = new StringBuilder();
            var digits = cnpj.Substring(0, 12);
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
            return _cnpj.EndsWith(dv.ToString());
        }

        public override string ToString() => $"Nome: {_nome}\nCNPJ: {_cnpj} (valido? {(Validar() ? "sim" : "nao")})\n";
    }
}

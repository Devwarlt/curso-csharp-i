using System;
using System.Globalization;

namespace C2Challenge.Scripts
{
    public sealed class Aluno
    {
        private string _nome;
        private string _sobrenome;
        private DateTime _nascimento;

        public Aluno(string nome, string sobrenome, DateTime nascimento)
        {
            _nome = nome;
            _sobrenome = sobrenome;
            _nascimento = nascimento;
        }

        public void Nome(string nome) => Nome(nome, string.Empty);

        public void Nome(string nome, string sobrenome)
        {
            _nome = nome;

            if (!string.IsNullOrEmpty(sobrenome))
                _sobrenome = sobrenome;
        }

        public void Nascimento(DateTime nascimento) => _nascimento = nascimento;

        public string FormatarNome() => $"Nome: {_nome} {_sobrenome}";

        public string FormatarNascimento()
        {
            var culture = new CultureInfo("pt-BR");
            return string.Format(culture, "Nascimento: {0:D}", _nascimento);
        }

        public string FormatarIdade()
        {
            var idade = (int)((DateTime.UtcNow - _nascimento).TotalDays / 365);
            return $"Idade: {idade} ano{(idade > 1 ? "s" : "")}";
        }

        public override string ToString() => $"{FormatarNome()}\n{FormatarNascimento()}\n{FormatarIdade()}";
    }
}

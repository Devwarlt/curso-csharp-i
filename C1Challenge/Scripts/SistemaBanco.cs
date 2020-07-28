using System.Collections.Generic;

namespace C1Challenge.Scripts
{
    public sealed class SistemaBanco
    {
        private readonly Dictionary<(string agencia, string numero), Conta> _contas;

        public SistemaBanco() => _contas = new Dictionary<(string agencia, string numero), Conta>();

        public Conta this[string agencia, string numero] => _contas.TryGetValue((agencia, numero), out var conta) ? conta : null;

        public void AdicionarConta(Conta conta) => _contas.TryAdd((conta.Agencia, conta.Numero), conta);

        public void RemoverConta(string agencia, string numero) => _contas.Remove((agencia, numero), out _);
    }
}

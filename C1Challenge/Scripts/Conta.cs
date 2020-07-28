namespace C1Challenge.Scripts
{
    public sealed class Conta
    {
        public string Agencia { get; set; }
        public string Numero { get; set; }
        public string NomeCliente { get; set; }
        public float ValorDisponivel { get; set; }

        public override string ToString() => $"agencia: {Agencia}, numero: {Numero}, nome cliente: {NomeCliente}, valor disponivel: {ValorDisponivel:F2}";
    }
}

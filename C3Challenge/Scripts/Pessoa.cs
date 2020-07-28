namespace C3Challenge.Scripts
{
    public abstract class Pessoa
    {
        protected string _nome;

        public string Nome() => _nome;

        public abstract void EscreverNome(string nome);

        public abstract bool Validar();
    }
}

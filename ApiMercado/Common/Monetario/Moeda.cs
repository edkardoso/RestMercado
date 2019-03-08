namespace Common.Monetario
{
    public struct Moeda
    {
        public Moeda(string simbolo, string nome) : this()
        {
            Simbolo = simbolo;
            Nome = nome;
        }

        public string Simbolo { get; private set; }
        public string Nome { get; private set; }

        public override string ToString() => Nome;

        internal string ToString(decimal total) => $"{Simbolo} {total}";
    }
}
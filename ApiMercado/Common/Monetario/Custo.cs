namespace Common.Monetario
{
    public struct Custo
    {
        public decimal ValorBruto { get; set; }
        public decimal ValorImposto { get; set; }
        public decimal Cambio { get; set; }
        public Moeda Moeda { get; set; }
        public decimal Total => (ValorBruto + ValorImposto) * Cambio;

        public override string ToString() => Moeda.ToString(Total);
       
    }
}
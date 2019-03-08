using Common.Identificadores;

namespace Mercado.Domain.Produtos
{
    public class Estabelecimento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public CNPJ CNPJ { get; set; }
    }
}
using Common.Base;
using Common.Monetario;
using System;

namespace Mercado.Domain.Produtos
{
    public class Preco : DomainObjectBase
    {
        public Produto Produto { get; set; }
        public Custo Valor { get; set; }
        public DateTime Atualizacao { get; set; }
        public Estabelecimento Estabelecimento { get; set; }
    }

}

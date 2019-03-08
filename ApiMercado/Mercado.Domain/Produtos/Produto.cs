using Common.Base;
using System.Collections.Generic;

namespace Mercado.Domain.Produtos
{
    public class Produto : DomainObjectBase
    {
        public int Id { get; private set; }
        public NCM NCM { get; private set; }
        public string Descricao { get; private set; }
        public Unidades Unidade { get; private set; }
        public List<Preco> Preco { get; private set; }


    }
}

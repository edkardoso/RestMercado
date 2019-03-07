using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMercado.Models.Produtos
{
    public class Produto
    {
        public int Id { get; private set; }
        public string NCM { get; private set; }
        public string Descricao { get; private set; }
        public decimal PrecoAtual { get; private set; }


    }
}

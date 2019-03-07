using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMercado.Models.Produtos
{
    public class Preco
    {
        public string NCM { get; set; }
        public decimal Valor { get; set; }
        public DateTime Atualizacao { get; set; }
        public string Estabelecimento { get; set; }
    }
}

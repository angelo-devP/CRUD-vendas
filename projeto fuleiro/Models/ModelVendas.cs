using System;
using System.Collections.Generic;

namespace projeto_fuleiro.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public decimal Total { get; set; }

        // Relacionamento
        public List<ItemVenda> Itens { get; set; } = new List<ItemVenda>();
    }
}
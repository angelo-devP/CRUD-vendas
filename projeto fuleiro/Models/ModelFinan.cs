using System;

namespace projeto_fuleiro.Models
{
    public class Financeiro
    {
        public int Id { get; set; }
        public int VendaId { get; set; }
        public DateTime DataPagamento { get; set; }
        public decimal Valor { get; set; }
        public string Tipo { get; set; } = ""; // "Receita" ou "Despesa"

        public Venda Venda { get; set; }
    }
}
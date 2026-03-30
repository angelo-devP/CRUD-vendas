namespace projeto_fuleiro.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public decimal Preco { get; set; }
        public int EstoqueAtual { get; set; } // controla QtdEstoq, EntradaEstoq e SaidaEstoq
    }
}
namespace projeto_fuleiro.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; } // controla QtdEstoq, EntradaEstoq, SaidaEstoq
        public Produto Produto { get; set; } // opcional
    }
}
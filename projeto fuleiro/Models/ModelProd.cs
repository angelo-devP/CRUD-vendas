namespace projeto_fuleiro.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public decimal Preco { get; set; }
        public int EstoqueAtual { get; set; }

        // Relacionamentos
        public List<ItemVenda> ItensVenda { get; set; } = new List<ItemVenda>();
        public Estoque Estoque { get; set; }
    }
}
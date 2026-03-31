namespace projeto_fuleiro.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public decimal Preco { get; set; }
        public List<ItemVenda> ItensVenda { get; set; } = new List<ItemVenda>();
    }
}
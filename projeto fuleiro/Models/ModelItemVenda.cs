namespace projeto_fuleiro.Models
{
    public class ItemVenda
    {
        public int Id { get; set; }
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal Subtotal { get; set; }

        // Navegação
        public Venda Venda { get; set; }
        public Produto Produto { get; set; }
    }
}
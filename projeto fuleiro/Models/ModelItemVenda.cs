namespace projeto_fuleiro.Models
{
    public class ItemVenda
    {
        public int Id { get; set; }
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal Subtotal { get; set; }

        public Produto Produto { get; set; } // facilita consultar o produto no ConsulProd
    }
}
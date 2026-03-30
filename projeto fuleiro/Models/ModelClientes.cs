namespace projeto_fuleiro.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Email { get; set; } = "";
        public string Telefone { get; set; } = "";
        public string Endereco { get; set; } = "";

        // Relacionamento 1:N com Venda
        public List<Venda> Vendas { get; set; } = new List<Venda>();
    }
}
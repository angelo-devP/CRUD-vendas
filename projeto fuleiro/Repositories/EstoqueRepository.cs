using MySql.Data.MySqlClient;
using projeto_fuleiro.Data;
using projeto_fuleiro.Models;

namespace projeto_fuleiro.Repositories
{
    public class EstoqueRepository
    {
        private ConexaoDB conexao = new ConexaoDB();

        public void InserirEstq(Estoque e)
        {
            using var conn = conexao.GetConexao();
            conn.Open();

            string sql = "INSERT INTO Estoque (ProdutoId, Quantidade) VALUES (@ProdutoId, @Quantidade)";
            using var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@ProdutoId", e.ProdutoId);
            cmd.Parameters.AddWithValue("@Quantidade", e.Quantidade);
            cmd.ExecuteNonQuery();
        }

        public void AtualizarQTD(Estoque e)
        {
            using var conn = conexao.GetConexao();
            conn.Open();

            string sql = "UPDATE Estoque SET Quantidade=@Quantidade WHERE ProdutoId=@ProdutoId";
            using var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Quantidade", e.Quantidade);
            cmd.Parameters.AddWithValue("@ProdutoId", e.ProdutoId);
            cmd.ExecuteNonQuery();
        }

        public void Remover(int id)
        {
            using var conn = conexao.GetConexao();
            conn.Open();

            string sql = "DELETE FROM Produto WHERE Id=@Id";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();
        }

        public Estoque BuscarPorProduto(int produtoId)
        {
            using var conn = conexao.GetConexao();
            conn.Open();

            string sql = "SELECT * FROM Estoque WHERE ProdutoId=@ProdutoId";
            using var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@ProdutoId", produtoId);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new Estoque
                {
                    Id = reader.GetInt32("Id"),
                    ProdutoId = reader.GetInt32("ProdutoId"),
                    Quantidade = reader.GetInt32("Quantidade")
                };
            }

            return null;
        }

        public List<Estoque> ListarComProdutos()
        {
            List<Estoque> lista = new List<Estoque>();

            using var conn = conexao.GetConexao();
            conn.Open();

            string sql = @"
            SELECT e.Id, e.ProdutoId, e.Quantidade,
                   p.Nome, p.Preco
            FROM Estoque e
            JOIN Produto p ON e.ProdutoId = p.Id";

            using var cmd = new MySqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Estoque
                {
                    Id = reader.GetInt32("Id"),
                    ProdutoId = reader.GetInt32("ProdutoId"),
                    Quantidade = reader.GetInt32("Quantidade"),

                    Produto = new Produto
                    {
                        Nome = reader.GetString("Nome"),
                        Preco = reader.GetDecimal("Preco")
                    }
                });
            }

            return lista;
        }
    }
}
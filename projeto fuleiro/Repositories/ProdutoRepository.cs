using MySql.Data.MySqlClient;
using projeto_fuleiro.Data;
using projeto_fuleiro.Models;

namespace projeto_fuleiro.Repositories
{
    public class ProdutoRepository
    {
        private ConexaoDB conexao = new ConexaoDB();

        // Cadastrar produto
        public void Inserir(Produto p)
        {
            using var conn = conexao.GetConexao();
            conn.Open();

            string sql = "INSERT INTO Produto (Nome, Preco, EstoqueAtual) VALUES (@Nome, @Preco, @EstoqueAtual)";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Nome", p.Nome);
            cmd.Parameters.AddWithValue("@Preco", p.Preco);
            cmd.Parameters.AddWithValue("@EstoqueAtual", p.EstoqueAtual);

            cmd.ExecuteNonQuery();
        }

        // Editar produto
        public void Editar(Produto p)
        {
            using var conn = conexao.GetConexao();
            conn.Open();

            string sql = "UPDATE Produto SET Nome=@Nome, Preco=@Preco, EstoqueAtual=@EstoqueAtual WHERE Id=@Id";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Nome", p.Nome);
            cmd.Parameters.AddWithValue("@Preco", p.Preco);
            cmd.Parameters.AddWithValue("@EstoqueAtual", p.EstoqueAtual);
            cmd.Parameters.AddWithValue("@Id", p.Id);

            cmd.ExecuteNonQuery();
        }

        // Remover produto
        public void Remover(int id)
        {
            using var conn = conexao.GetConexao();
            conn.Open();

            string sql = "DELETE FROM Produto WHERE Id=@Id";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();
        }

        // Listar todos os produtos
        public List<Produto> Listar()
        {
            var lista = new List<Produto>();
            using var conn = conexao.GetConexao();
            conn.Open();

            string sql = "SELECT Id, Nome, Preco, EstoqueAtual FROM Produto";
            using var cmd = new MySqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Produto
                {
                    Id = reader.GetInt32("Id"),
                    Nome = reader.GetString("Nome"),
                    Preco = reader.GetDecimal("Preco"),
                    EstoqueAtual = reader.GetInt32("EstoqueAtual")
                });
            }

            return lista;
        }

        public Produto? BuscarPorId(int id)
        {
            using var conn = conexao.GetConexao();
            conn.Open();

            string sql = "SELECT Id, Nome, Preco, EstoqueAtual FROM Produto WHERE Id=@Id";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", id);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Produto
                {
                    Id = reader.GetInt32("Id"),
                    Nome = reader.GetString("Nome"),
                    Preco = reader.GetDecimal("Preco"),
                    EstoqueAtual = reader.GetInt32("EstoqueAtual")
                };
            }

            return null; // produto não encontrado
        }
    }
}

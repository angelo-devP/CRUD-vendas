using MySql.Data.MySqlClient;
using projeto_fuleiro.Data;
using projeto_fuleiro.Models;

namespace projeto_fuleiro.Repositories;
public class ProdutoRepository
{
    private ConexaoDB conexao = new ConexaoDB();

    // Inserir produto e retornar ID
    public int Inserir(Produto p)
    {
        using var conn = conexao.GetConexao();
        conn.Open();

        string sqlInsert = "INSERT INTO Produto (Nome, Preco) VALUES (@Nome, @Preco)";
        using var cmd = new MySqlCommand(sqlInsert, conn);

        cmd.Parameters.AddWithValue("@Nome", p.Nome);
        cmd.Parameters.AddWithValue("@Preco", p.Preco);

        cmd.ExecuteNonQuery();

        string sqlId = "SELECT LAST_INSERT_ID()";
        using var cmdId = new MySqlCommand(sqlId, conn);

        return Convert.ToInt32(cmdId.ExecuteScalar());
    }

    // Buscar por nome
    public Produto BuscarPorNome(string nome)
    {
        using var conn = conexao.GetConexao();
        conn.Open();

        string sql = "SELECT * FROM Produto WHERE Nome = @Nome";
        using var cmd = new MySqlCommand(sql, conn);

        cmd.Parameters.AddWithValue("@Nome", nome);

        using var reader = cmd.ExecuteReader();

        if (reader.Read())
        {
            return new Produto
            {
                Id = reader.GetInt32("Id"),
                Nome = reader.GetString("Nome"),
                Preco = reader.GetDecimal("Preco")
            };
        }

        return null;
    }

    // Listar todos
    public List<Produto> Listar()
    {
        List<Produto> lista = new List<Produto>();

        using var conn = conexao.GetConexao();
        conn.Open();

        string sql = "SELECT * FROM Produto";
        using var cmd = new MySqlCommand(sql, conn);

        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            lista.Add(new Produto
            {
                Id = reader.GetInt32("Id"),
                Nome = reader.GetString("Nome"),
                Preco = reader.GetDecimal("Preco")
            });
        }

        return lista;
    }
}
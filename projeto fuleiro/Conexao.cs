using MySql.Data.MySqlClient;

namespace projeto_fuleiro.Data
{ 
    public class ConexaoDB
    {
        private readonly string _conexao = "server=localhost;user=root;password=041055;database=crud_vendas2;";

        public MySqlConnection GetConexao()
        {
            return new MySqlConnection(_conexao);
        }
    }
}
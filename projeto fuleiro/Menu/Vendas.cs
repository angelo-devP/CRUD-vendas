using static projeto_fuleiro.Helpers;

namespace projeto_fuleiro.Menu
{
    public class Vendas
    {
        private Helpers helper = new Helpers();

        public void ExibirMenuVendas()
        {
            while (Estado.ExecutandoVenda)
            {
                Console.WriteLine("------------Página de Vendas------------");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Realizar uma venda");
                Console.WriteLine("2 - Editar uma venda");
                Console.WriteLine("3 - Listar vendas");
                Console.WriteLine("4 - Voltar ao menu principal");

                string opcao = Console.ReadLine();

                helper.ProcessarOpcao(opcao,
                    () => Vender(),
                    () => EditarVenda(),
                    () => ListarVendas()
                );

                if (opcao == "4")
                {
                    return;
                }
            }
        }

        public void Vender()
        {
            Console.WriteLine("Vendendo...");
        }

        public void EditarVenda()
        {
            Console.WriteLine("Editando venda...");
        }

        public void ListarVendas()
        {
            Console.WriteLine("Listando vendas...");
        }
    }
}
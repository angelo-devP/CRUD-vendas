using System;
using System.Collections.Generic;
using System.Text;
using static projeto_fuleiro.Helpers;

namespace projeto_fuleiro.Menu
{
    public class Produtos
    {
        private Helpers helper = new Helpers();
        public void ExibirMenuProdutos()
        {
            while (Estado.ExecutandoProdutos)
            {
                Console.WriteLine("------------Página de Produtos------------");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Cadastrar um produto");
                Console.WriteLine("2 - Editar um produto");
                Console.WriteLine("3 - Remover um produto");
                Console.WriteLine("4 - Listar os produtos");
                Console.WriteLine("5 - Voltar ao menu principal");

                string opcao = Console.ReadLine();

                helper.ProcessarOpcao(opcao,
                   () => CadastrarProd(),
                   () => EditarProd(),
                   () => RemoverProd(),
                   () => ListarProd()
                );

                if (opcao == "5")
                {
                    return;
                }
            }
        }

        public void CadastrarProd()
        {
            Console.WriteLine("Cadastrando...");
        }

        public void EditarProd()
        {
            Console.WriteLine("Editando...");
        }

        public void RemoverProd()
        {
            Console.WriteLine("Removendo...");
        }

        public void ListarProd()
        {
            Console.WriteLine("Listando...");
        }
    }
}
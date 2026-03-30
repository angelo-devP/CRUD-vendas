using System;
using System.Collections.Generic;
using System.Text;
using projeto_fuleiro.Menu;
using static projeto_fuleiro.Helpers;

namespace projeto_fuleiro.Menu
{
    public class Principal
    {
        private Vendas vendas = new Vendas();
        private Produtos produtos = new Produtos();
        private Consultas consultas = new Consultas();
        private Estoque estoque = new Estoque();
        private Relatorios relatorios = new Relatorios();

        public void MenuPrincipal()
        {
            while (Estado.Executando)
            {
                Console.WriteLine("----------+Bem-Vindo ao sistema de vendas+----------");
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Vendas");
                Console.WriteLine("2 - Produtos");
                Console.WriteLine("3 - Consultas");
                Console.WriteLine("4 - Estoque");
                Console.WriteLine("5 - Relatórios");
                Console.WriteLine("0 - Sair");

                string opcao = Console.ReadLine();

                OpçãoMenu(opcao);
            }
        }

        public void OpçãoMenu(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    vendas.ExibirMenuVendas();
                    break;

                case "2":
                    Console.Clear();
                    produtos.ExibirMenuProdutos();
                    break;

                case "3":
                    Console.Clear();
                    consultas.ExibirMenuConsulta();
                    break;

                case "4":
                    Console.Clear();
                    estoque.ExibirMenuEstoque();
                    break;

                case "5":
                    Console.Clear();
                    relatorios.ExibirMenuRelatorio();
                    break;

                case "0":
                    Console.Clear();
                    Console.WriteLine("Encerrando o programa...");
                    Estado.Executando = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
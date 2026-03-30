using System;
using System.Collections.Generic;
using System.Text;
using static projeto_fuleiro.Helpers;

namespace projeto_fuleiro.Menu
{
    public class Consultas
    {
        private Helpers helper = new Helpers();
        public void ExibirMenuConsulta()
        {
            while (Estado.ExecutandoConsulta)
            {
                Console.WriteLine("------------Página de Consulta------------");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Consultar um produto");
                Console.WriteLine("2 - Consultar uma venda");
                Console.WriteLine("3 - Consultar o estoque");
                Console.WriteLine("4 - Consultar o saldo");
                Console.WriteLine("5 - Fluxo de caixa");
                Console.WriteLine("6 - Voltar ao menu principal");

                string opcao = Console.ReadLine();

                helper.ProcessarOpcao(opcao,
                   () => ConsulProd(),
                   () => ConsulVenda(),
                   () => ConsulEstoq(),
                   () => ConsulSaldo(),
                   () => FluxoCaixa()
                );

                if (opcao == "6")
                {
                    return;
                }
            }
        }

        public void ConsulProd()
        {
            Console.WriteLine("Consultando o produto...");
        }

        public void ConsulVenda()
        {
            Console.WriteLine("Consultando a venda...");
        }

        public void ConsulEstoq()
        {
            Console.WriteLine("Consultando o estoque...");
        }

        public void ConsulSaldo()
        {
            Console.WriteLine("Consultando o saldo...");
        }

        public void FluxoCaixa()
        {
            Console.WriteLine("Consultando o fluxo de caixa...");
        }
    }
}
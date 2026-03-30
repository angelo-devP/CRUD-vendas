using System;
using System.Collections.Generic;
using System.Text;
using static projeto_fuleiro.Helpers;

namespace projeto_fuleiro.Menu
{
    public class Estoque
    {
        private Helpers helper = new Helpers();
        public void ExibirMenuEstoque()
        {
            while (Estado.ExecutandoEstoque)
            {
                Console.WriteLine("------------Página de Estoque------------");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Entrada de estoque");
                Console.WriteLine("2 - Saída de estoque");
                Console.WriteLine("3 - Consultar quantidade em estoque");
                Console.WriteLine("4 - Voltar ao menu principal");

                string opcao = Console.ReadLine();

                helper.ProcessarOpcao(opcao,
                   () => EntradaEstoq(),
                   () => SaidaEstoq(),
                   () => QtdEstoq()
                );

                if (opcao == "4")
                {
                    return;
                }
            }
        }

        public void EntradaEstoq()
        {
            Console.WriteLine("Realizando entrada simplificada de estoque...");
        }

        public void SaidaEstoq()
        {
            Console.WriteLine("Realizando saída simplificada de estoque...");
        }

        public void QtdEstoq()
        {
            Console.WriteLine("Consultando quantidade em estoque...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using static projeto_fuleiro.Helpers;

namespace projeto_fuleiro.Menu
{
    public class Relatorios
    {
        private Helpers helper = new Helpers();
        public void ExibirMenuRelatorio()
        {
            while (Estado.ExecutandoRelatorio)
            {
                Console.WriteLine("------------Página de Relatórios------------");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Relatório de produtos");
                Console.WriteLine("2 - Relatório de vendas");
                Console.WriteLine("3 - Relatório de estoque");
                Console.WriteLine("4 - Relatório financeiro");
                Console.WriteLine("5 - Voltar ao menu principal");

                string opcao = Console.ReadLine();

                helper.ProcessarOpcao(opcao,
                   () => RelatProd(),
                   () => RelatVendas(),
                   () => RelatEstq(),
                   () => RelatFinan()
                );

                if (opcao == "5")
                {
                    return;
                }
            }
        }

        public void RelatProd()
        {
            Console.WriteLine("Gerando relatório dos produtos...");
        }

        public void RelatVendas()
        {
            Console.WriteLine("Gerando relatório das vendas...");
        }

        public void RelatEstq()
        {
            Console.WriteLine("Gerando relatório do estoque...");
        }

        public void RelatFinan()
        {
            Console.WriteLine("Gerando relatório financeiro...");
        }
    }
}

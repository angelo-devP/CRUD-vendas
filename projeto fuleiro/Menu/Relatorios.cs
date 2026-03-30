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
                Console.WriteLine("5 - Relatório de clientes");
                Console.WriteLine("6 - Voltar ao menu principal");

                string opcao = Console.ReadLine();

                helper.ProcessarOpcao(opcao,
                   () => RelatProd(),
                   () => RelatVendas(),
                   () => RelatEstq(),
                   () => RelatFinan(),
                   () => RelatClientes()
                );

                if (opcao == "6")
                {
                    return;
                }
            }
        }

        public void RelatProd()
        {
            
        }

        public void RelatVendas()
        {

        }

        public void RelatEstq()
        {

        }

        public void RelatFinan()
        {

        }

        public void RelatClientes()
        {

        }
    }
}

namespace projeto_fuleiro
{
    public class Helpers
    {
        public void ProcessarOpcao(string opcao, params Action[] acoes)
        {
            // tenta converter a opção em índice (1-based)
            if (int.TryParse(opcao, out int index))
            {
                index--; // converte para 0-based
                if (index >= 0 && index < acoes.Length)
                {
                    acoes[index](); // executa a ação correspondente
                    return;
                }
            }

            Console.WriteLine("Opção inválida!");
        }

        public static class Estado
        {
            public static bool ExecutandoEstoque = true;
            public static bool ExecutandoConsulta = true;
            public static bool ExecutandoProdutos = true;
            public static bool ExecutandoRelatorio = true;
            public static bool ExecutandoVenda = true;
            public static bool Executando = true;
        }
    }
}
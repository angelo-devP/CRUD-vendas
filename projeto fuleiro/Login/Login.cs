using System;

namespace projeto_fuleiro.Login
{
    public class Login
    {
        private string username = "angelo@";
        private string password = "123";

        public bool LoginUser()
        {
            int maxTentativas = 3;

            for (int i = 1; i <= maxTentativas; i++)
            {
                Console.WriteLine("Insira o seu usuário:");
                string usernameI = Console.ReadLine() ?? "";

                Console.WriteLine("Insira a sua senha:");
                string passwordI = Console.ReadLine() ?? "";

                if (ValidarCredenciais(usernameI, passwordI))
                {
                    Console.WriteLine($"Login efetuado com sucesso pelo usuário {usernameI}");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Usuário ou senha incorretos. Tentativas restantes: {maxTentativas - i}");
                }
            }

            Console.WriteLine("Tentativas de login excedidas!");
            return false;

        }

        private bool ValidarCredenciais(string usernameI, string passwordI)
        {
            return usernameI == username && passwordI == password;
        }
    }
}
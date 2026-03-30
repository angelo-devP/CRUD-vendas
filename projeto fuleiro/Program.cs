using System;
using System.Security.Cryptography.X509Certificates;

namespace projeto_fuleiro
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecutarLogin();
            ExecutarMenu();
        }

        static void ExecutarLogin()
        {
            Login.Login login = new Login.Login();

            bool acesso = login.LoginUser();

            if (acesso)
            {
                Console.WriteLine("Acesso liberado!");
            }
            else
            {
                Console.WriteLine("Acesso negado!");
            }
        }

        static void ExecutarMenu()
        {
            Menu.Principal menu = new Menu.Principal();

            menu.MenuPrincipal();
        }
    }
}
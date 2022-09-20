using System;

namespace Exercício_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastre sua senha: ");
            int cadastro = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu nome de usuário: ");
            string usu = Console.ReadLine();
            Console.WriteLine("Informe a sua senha: ");
            int senha = int.Parse(Console.ReadLine());
            while (senha != cadastro)
            {
                Console.WriteLine("Senha Inválida. Por favor. Tente novamente!");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Acesso permitido. Seja bem - vindo(a) {usu}");
                
        }
    }
}

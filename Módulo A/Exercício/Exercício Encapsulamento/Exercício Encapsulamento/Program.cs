using System;
using System.Globalization;

namespace Exercício_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria usuario;
            usuario = new ContaBancaria("null", 0, 0);
            Console.Write("Tenha um ótimo dia! Informe o seu nome: ");
            string titular = Console.ReadLine();
            Console.Write($"Tudo certo {titular}, Agora por favor. Informe o número da sua conta: ");
            int numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Você deseja informar o depoósito Incial? Sim [S] Não [N]");
            string pergunta = Console.ReadLine();
            while (pergunta != "S" || pergunta != "s" || pergunta != "N" || pergunta != "n")
            {
                if (pergunta == "S" || pergunta == "s")
                {
                    Console.Write("Informe o valor do depósito Inicial R$: ");
                    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    usuario = new ContaBancaria(titular, numero, depositoInicial);
                    break;
                }
                else if (pergunta == "N" || pergunta == "n")
                {
                    usuario = new ContaBancaria(titular, numero);
                    break;
                }
                else {
                    Console.WriteLine("Dados inválidos, por favor. Tente novamente! 'S' Para Sim, 'N' Para Não.");
                    Console.Write("Você deseja informar o depoósito Incial? Sim [S] Não [N]");
                    pergunta = Console.ReadLine();
                }
            }
            Console.WriteLine("Dados cadatrados");
            Console.WriteLine(usuario);
            
            Console.WriteLine();
            
            Console.Write("Deseja Depositar novamente? Digite um valor R$");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            usuario.Deposito(quantia);
            Console.WriteLine("Dados Atualizados");
            Console.WriteLine(usuario);

            Console.WriteLine();

            Console.Write("Deseja Realizar uma operação de saque? Digite um valor R$");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            usuario.Saque(quantia);
            Console.WriteLine("Dados Atualizados. Obs Taxa de saque R$5.00");
            Console.WriteLine(usuario);
        }
    }
}s
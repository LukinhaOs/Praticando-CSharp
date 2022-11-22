using System;
using System.Globalization;
using Interfaces.Entidades;
using Interfaces.Servicos;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados do Aluguel abaixo;");
            Console.Write("Modelo do carro: ");
            string modelo = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Retorno (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("=========================================");

            Console.Write("Informe o valor por hora R$");
            double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o valor por dia R$");
            double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            AluguelCarro aluguelCarro = new AluguelCarro(start, finish, new Veiculo(modelo));

            ServicoAluguel servicoAluguel = new ServicoAluguel(hora, dia, new BrasilServicoTaxa());

            servicoAluguel.ProcessoFatura(aluguelCarro);

            Console.WriteLine("FATURA: ");
            Console.WriteLine(aluguelCarro.Custo);
        }
    }
}

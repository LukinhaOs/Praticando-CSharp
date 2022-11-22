using System;
using System.Globalization;
using Exercício_Entities_e_Serviços.Entidades;
using Exercício_Entities_e_Serviços.Serviços;

namespace Exercício_Entities_e_Serviços
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe o número do contrato: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Agora será nescessário informar a data (dd/MM/yyyy): ");
            DateTime dataContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Informe o valor do contrato R$");
            double valorContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o número de parcelas: ");
            int meses = int.Parse(Console.ReadLine());

            Contrato contratoAtual = new Contrato(numero, dataContrato, valorContrato);

            ContratoServiço serviços = new ContratoServiço(new ServiçoPagamento());
            serviços.processoContrato(contratoAtual, meses);

            Console.WriteLine("=================================");
            Console.WriteLine("Parcelamentos e informações");
            foreach(Parcelas parcelamento in contratoAtual.Parcelas)
            {
                Console.WriteLine(parcelamento);
            }
            Console.WriteLine("=================================");

        }
    }
}

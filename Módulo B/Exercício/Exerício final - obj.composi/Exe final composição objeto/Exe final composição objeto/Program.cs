using System;
using System.Globalization;
using Exe_final_composição_objeto.Entidades;
using Exe_final_composição_objeto.Entidades.Enum;

namespace Exe_final_composição_objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o nome do Departamento: ");
            string depart = Console.ReadLine();
            Console.Write("Informe o nome do funcionário: ");
            string funcNome = Console.ReadLine();
            Console.Write($"Agora informe o nível de profissão do Funcionário {funcNome} (Junior/Mid_Level/Senior): ");
            LevelWork funcNivel = Enum.Parse<LevelWork>(Console.ReadLine());
            Console.Write($"Informe o salário do funcionário {funcNome} R$", CultureInfo.InvariantCulture);
            double funcSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento dep = new Departamento(depart);
            Trabalhador trabalhador = new Trabalhador(funcNome, funcNivel, dep, funcSalario);

            Console.Write("Quantos contratos serão exibidos? ");
            int numeoc = int.Parse(Console.ReadLine());

            for (int item = 0; item < numeoc; item++)
            {
                Console.WriteLine();
                Console.WriteLine($"Dados do {item + 1}° contrato");
                Console.WriteLine();
                Console.Write("Informe a data (Dia/Mês/Ano): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Informe o valor por hora R$");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write($"Informe a carga horário do funcionário {funcNome}: ");
                int tbhora = int.Parse(Console.ReadLine());
                ContratoHora contrato = new ContratoHora(data, valorPorHora, tbhora);
                trabalhador.AddContrato(contrato);
            }

                Console.Write("Informe novamente, e por último (Mês/Ano): ");
                string MesAno = Console.ReadLine();
                int mes = int.Parse(MesAno.Substring(0, 2));
                int ano = int.Parse(MesAno.Substring(3));

                Console.WriteLine();
                Console.WriteLine($"Nome: {trabalhador.Nome}");
                Console.WriteLine($"Departamento {trabalhador.Departamento.Nome}");
                Console.WriteLine($"Remuneração R${trabalhador.GanhoSalario(ano, mes).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

using System;

namespace Estrutura_Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Error during the operation. Divisiom by zero is not allowed. ");
            }
            catch (FormatException words)
            {
                Console.WriteLine("Format error! The operation is only with numbers! " + words.Message);
            }

            // "Bloco finally" operação para encerrar a tratativa try ou exception, indepedentemente do resultado.  
        }
    }
}

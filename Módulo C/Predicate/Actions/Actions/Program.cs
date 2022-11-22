using System;
using System.Collections.Generic;
using Actions.Entidades;

namespace Actions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();

            lista.Add(new Produto("Tablet Samsung", 1450.00));
            lista.Add(new Produto("Controller Xbox", 450.00));
            lista.Add(new Produto("Mouse", 25.00));
            lista.Add(new Produto("Teclado", 125.00));

            Action<Produto> act = p => { p.Preco += p.Preco * 0.10; }; // Pode utilizar a variável act como calculo

            lista.ForEach(act);

            foreach (Produto p in lista)
            {
                Console.WriteLine(p);
            }
        }

        static public void UptadePreco (Produto p)
        {
            p.Preco += p.Preco * 0.10;
        }
    }
}

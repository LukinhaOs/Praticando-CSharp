using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Comparision.Entidades
{
    class Produto // : ICompareble<Prodct> Classe utiliza para comprar valores númericos
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return Nome + ", " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(Produto item)
        {
            return Nome.ToUpper().CompareTo(item.Nome.ToUpper());
        }
         /* Função que utilizar a variável "Preco" - Use IComparable
         
         public int CompareTo(Produto item) 
         {
            return Preco.CompareTo(item.Preco);
         }
          */ 
    }
}

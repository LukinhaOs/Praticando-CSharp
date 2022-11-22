using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Restricao_Generic.Entidade
{
    class Produto : IComparable
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
            return Nome
                + ", R$" +
                Preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Produto))
            {
                throw new ArgumentException("Comparing error: argumento não é um produto");
            }
            Produto outro = obj as Produto;
            return Preco.CompareTo(outro.Preco);
        }
    }
}

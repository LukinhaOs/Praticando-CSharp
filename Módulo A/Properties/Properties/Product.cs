using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class Product
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }


        public Product(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
    }
}
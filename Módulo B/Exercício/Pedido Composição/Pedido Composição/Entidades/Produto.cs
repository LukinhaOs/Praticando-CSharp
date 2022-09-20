using System;
using System.Collections.Generic;
using System.Text;

namespace Pedido_Composição.Entidades
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco;

        public Produto()
        {

        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}

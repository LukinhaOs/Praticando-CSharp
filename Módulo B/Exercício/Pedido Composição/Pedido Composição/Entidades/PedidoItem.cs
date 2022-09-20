using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using Pedido_Composição.Entidades;

namespace Pedido_Composição.Entidades
{
    class PedidoItem
    {
        public int Qnt { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }


        public PedidoItem()
        {

        }

        public PedidoItem(int qnt, double preco, Produto produto)
        {
            Qnt = qnt;
            Preco = preco;
            Produto = produto;
        }

        public double SubTot()
        {
            return Qnt * Preco;
        }

        public override string ToString()
        {
            return Produto.Nome
                + ", R$"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantidade: "
                + Qnt 
                + ", Subtotal: R$"
                + SubTot().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

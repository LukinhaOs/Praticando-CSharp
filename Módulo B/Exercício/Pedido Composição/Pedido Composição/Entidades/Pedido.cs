using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using Pedido_Composição.Entidades.Enum;

namespace Pedido_Composição.Entidades
{
    class Pedido
    {
        public DateTime Pnow { get; set; }
        public StatusPedido Status { get; set; }
        public Cliente Cliente { get; set; }


        List<PedidoItem> pedidofinal = new List<PedidoItem>(); 
      

        public Pedido()
        {

        }

        public Pedido(DateTime pnow, StatusPedido stats, Cliente cliente)
        {
            Pnow = pnow;
            Status = stats;
            Cliente = cliente;
        }


        public void AddItem(PedidoItem itens)
        {
            pedidofinal.Add(itens);
        }

        public void RemoveItem(PedidoItem itens)
        {
            pedidofinal.Remove(itens);
        }

        public double Total()
        {
            double soma = 0.0;
            foreach (PedidoItem item in pedidofinal)
            {
                soma += item.SubTot();
            }
            return soma;
        }

        public override string ToString()
        {
            StringBuilder format = new StringBuilder();
            format.AppendLine("Horário da Realização do Pedido: " + Pnow.ToString("dd/MM/yyyy HH:mm:ss"));
            format.AppendLine($"Status do pedido: {Status}");
            format.AppendLine($"Dados do cliente: {Cliente}");
            format.AppendLine($"Itens do Pedido: ");
            foreach (PedidoItem item in pedidofinal)
            {
                format.AppendLine(item.ToString());
            }
            format.AppendLine($"Valor total: R${Total().ToString("F2", CultureInfo.InvariantCulture)}");
            return format.ToString();
        }
    }
}

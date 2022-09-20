using Pedido_Composição.Entidades.Enum;

namespace Pedido_Composição.Entidades.Enum
{
    enum StatusPedido : int
    {
        
        Pagamento_Pendente = 0,
        Processando = 1,
        Enviado = 2,
        Entregue = 3
       
    }
}

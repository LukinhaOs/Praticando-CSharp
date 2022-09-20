using System;
using System.Collections.Generic;
using System.Text;

namespace Pedido_Composição.Entidades
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DBirthay { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome, string email, DateTime dbirthay)
        {
            Nome = nome;
            Email = email;
            DBirthay = dbirthay;
        }

        public override string ToString()
        {
            return Nome
                + ", ("
                + DBirthay.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}

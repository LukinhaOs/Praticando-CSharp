using System;
using System.Collections.Generic;
using System.Text;

namespace GetHashCode_e_Equals.Entidades
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Cliente))
            {
                return false;
            }
            Cliente outro = obj as Cliente;
            return Email.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
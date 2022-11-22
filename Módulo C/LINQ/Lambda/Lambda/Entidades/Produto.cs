using System;
using System.Text;
using System.Globalization;

namespace Lambda.Entidades
{
    class Produto : Categoria
    {
        public double  preco { get; set; }
        public Categoria categoria { get; set; }

        public override string ToString()
        {
            return id +
                ", " +
                nome +
                ", " +
                preco.ToString("F2", CultureInfo.InvariantCulture) +
                ", "
                + categoria.nome
                + ", "
                + categoria.camada;
        }
    }
}
